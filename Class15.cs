// Decompiled with JetBrains decompiler
// Type: Class15
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

internal class Class15
{
  public static int smethod_0(int int_0) => Class15.Class16.class16_0.int_0[int_0];

  public static long smethod_1(int int_0) => Class15.Class16.class16_0.long_0[int_0];

  public static float smethod_2(int int_0) => Class15.Class16.class16_0.float_0[int_0];

  public static double smethod_3(int int_0) => Class15.Class16.class16_0.double_0[int_0];

  public static Array smethod_4(byte[] byte_0) => Class15.Class16.smethod_0(byte_0);

  public static string smethod_5()
  {
    char[] charArray = "çÏïÜë".ToCharArray();
    int length = charArray.Length;
    while (--length >= 0)
      charArray[length] = (char) ((uint) charArray[length] ^ 159U);
    return new string(charArray);
  }

  private delegate string Delegate1();

  private class Class16
  {
    private static readonly Class15.Delegate1 delegate1_0 = new Class15.Delegate1(Class15.smethod_5);
    internal static readonly Class15.Class16 class16_0 = new Class15.Class16();
    internal int[] int_0;
    internal long[] long_0;
    internal float[] float_0;
    internal double[] double_0;

    private Class16() => this.method_0(Class18.smethod_0(Assembly.GetExecutingAssembly().GetManifestResourceStream(Class15.Class16.delegate1_0())));

    private void method_0(Stream stream_0)
    {
      BinaryReader binaryReader = new BinaryReader(stream_0);
      int length1 = binaryReader.ReadInt32() ^ 1159965444;
      if (length1 > 0)
      {
        this.int_0 = new int[length1];
        while (--length1 >= 0)
          this.int_0[length1] = binaryReader.ReadInt32() ^ 1350609431;
      }
      int length2 = binaryReader.ReadInt32() ^ 1611308284;
      while (length2 > 0)
      {
        this.long_0 = new long[length2];
        while (--length2 >= 0)
          this.long_0[length2] = binaryReader.ReadInt64() ^ 436136966L;
      }
      int length3 = binaryReader.ReadInt32() ^ 1767652703;
      while (length3 > 0)
      {
        this.float_0 = new float[length3];
        while (--length3 >= 0)
          this.float_0[length3] = binaryReader.ReadSingle();
      }
      int length4 = binaryReader.ReadInt32() ^ 287100580;
      while (length4 > 0)
      {
        this.double_0 = new double[length4];
        while (--length4 >= 0)
          this.double_0[length4] = binaryReader.ReadDouble();
      }
    }

    internal static Array smethod_0(byte[] byte_0)
    {
      MemoryStream stream_0 = new MemoryStream(byte_0);
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      Stream serializationStream = Class18.smethod_0((Stream) stream_0);
      try
      {
        return (Array) binaryFormatter.Deserialize(serializationStream);
      }
      finally
      {
        if ((serializationStream == null ? 1 : 0) == 0)
          serializationStream.Dispose();
      }
    }
  }
}
