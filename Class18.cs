// Decompiled with JetBrains decompiler
// Type: Class18
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

internal class Class18
{
  public static Stream smethod_0(Stream stream_0)
  {
    BinaryReader binaryReader1 = new BinaryReader(stream_0);
label_14:
    int num1 = Class24.smethod_1(16);
    byte[] buffer1;
    byte[] buffer2;
    while (true)
    {
      int index;
      int count;
      int length;
      int num2;
      switch (num1)
      {
        case 0:
          if (index != 0)
          {
            num2 = 1;
            goto case 1;
          }
          else
            break;
        case 1:
label_3:
          buffer1[index] = (byte) ((uint) buffer1[index] ^ (uint) buffer2[index % length]);
          num1 = Class24.smethod_1(24);
          continue;
        case 2:
          buffer1 = new byte[count];
          num2 = 4;
          goto case 4;
        case 3:
          index = 0;
          num2 = 0;
          goto case 0;
        case 4:
          binaryReader1.Read(buffer1, 0, count);
          num2 = 7;
          goto case 7;
        case 5:
          count = (int) binaryReader1.ReadUInt16();
          num2 = 2;
          goto case 2;
        case 6:
          binaryReader1.Read(buffer2, 0, buffer2.Length);
          num2 = 3;
          goto case 3;
        case 7:
          length = (int) binaryReader1.ReadByte();
          num2 = 8;
          goto case 8;
        case 8:
          buffer2 = new byte[length];
          num2 = 6;
          goto case 6;
        case 9:
          ++index;
          break;
        default:
          goto label_14;
      }
      if (index >= count)
        break;
      goto label_3;
    }
    byte num3 = 0;
    SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) null;
    BinaryReader binaryReader2 = new BinaryReader((Stream) new MemoryStream(buffer1, false));
    try
    {
      binaryReader2.ReadString();
      num3 = binaryReader2.ReadByte();
      int byte_0 = (int) binaryReader2.ReadByte();
      byte num4 = binaryReader2.ReadByte();
      int count = (int) binaryReader2.ReadByte();
      byte[] numArray = new byte[count];
      binaryReader2.Read(numArray, 0, count);
      if (num4 < (byte) 64)
      {
        binaryReader2.Read(numArray, 0, count);
      }
      else
      {
        byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
        if ((publicKey == null ? 0 : 1) == 0)
          throw new InvalidOperationException();
        Buffer.BlockCopy((Array) publicKey, (int) num4 + 12, (Array) numArray, 0, count);
      }
      symmetricAlgorithm = Class18.smethod_1((byte) byte_0);
label_22:
      int num5;
      switch (Class24.smethod_1(14))
      {
        case 0:
          symmetricAlgorithm.IV = buffer2;
          num5 = 1;
          goto case 1;
        case 1:
          symmetricAlgorithm.Key = numArray;
          num5 = 2;
          break;
        case 2:
          break;
        default:
          goto label_22;
      }
    }
    finally
    {
      if ((binaryReader2 == null ? 1 : 0) == 0)
        ((IDisposable) binaryReader2).Dispose();
    }
    MemoryStream memoryStream = new MemoryStream();
    if ((((int) num3 & 2) == 0 ? 1 : 0) == 0)
    {
      CryptoStream stream_0_1 = new CryptoStream(binaryReader1.BaseStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
      try
      {
        Class18.smethod_2((Stream) stream_0_1, (Stream) memoryStream);
      }
      finally
      {
        if ((stream_0_1 == null ? 1 : 0) == 0)
          stream_0_1.Dispose();
      }
      if ((((int) num3 & 1) == 0 ? 1 : 0) == 0)
      {
        memoryStream.Position = 0L;
label_39:
        int num6 = Class24.smethod_1(14);
        MemoryStream stream_1;
        int num7;
        while (true)
        {
          switch (num6)
          {
            case 0:
              stream_1 = new MemoryStream();
              num7 = 1;
              goto case 1;
            case 1:
              Class24.smethod_0((Stream) memoryStream, (Stream) stream_1);
              num6 = Class24.smethod_1(22);
              continue;
            case 2:
              goto label_40;
            case 3:
              goto label_44;
            default:
              goto label_39;
          }
        }
label_40:
        memoryStream = stream_1;
        num7 = 3;
      }
    }
    else if (num3 == (byte) 1)
      Class24.smethod_0(binaryReader1.BaseStream, (Stream) memoryStream);
    else
      Class18.smethod_2(binaryReader1.BaseStream, (Stream) memoryStream);
label_44:
    memoryStream.Position = 0L;
    return (Stream) memoryStream;
  }

  public static SymmetricAlgorithm smethod_1(byte byte_0)
  {
    string str = (string) null;
    switch (byte_0)
    {
      case 1:
        str = "DES";
        break;
      case 2:
        str = "Aes";
        break;
      case 3:
        str = "TripleDES";
        break;
      case 4:
        str = "Rijndael";
        break;
      case 5:
        str = "RC2";
        break;
      case 6:
        return (SymmetricAlgorithm) new Class17();
    }
    string typeName = "System.Security.Cryptography." + str;
    object type = (object) Type.GetType(typeName, false);
    if ((type == null ? 0 : 1) == 0)
      type = (object) Type.GetType(typeName + ", System.Security.Cryptography.Algorithms", false);
    return (type == null ? 0 : 1) != 0 ? (SymmetricAlgorithm) ((Type) type).InvokeMember("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder) null, (object) null, (object[]) null) : throw new InvalidOperationException(string.Format("Could not load type {0}", (object) typeName));
  }

  public static void smethod_2(Stream stream_0, Stream stream_1)
  {
    byte[] buffer = new byte[4096];
    while (true)
    {
      int count = stream_0.Read(buffer, 0, buffer.Length);
      if (count > 0)
        stream_1.Write(buffer, 0, count);
      else
        break;
    }
  }
}
