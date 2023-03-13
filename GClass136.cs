// Decompiled with JetBrains decompiler
// Type: GClass136
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.IO;
using System.Text;
using UnityEngine;

public class GClass136
{
  public sbyte[] buffer = new sbyte[Class15.smethod_0(459)];
  private int int_0;
  private int int_1 = Class15.smethod_0(459);

  public void method_0(sbyte value)
  {
    this.method_21(Class15.smethod_0(0));
    sbyte[] buffer = this.buffer;
    int int0 = this.int_0;
    this.int_0 = int0 + Class15.smethod_0(1);
    int index = int0;
    int num = (int) value;
    buffer[index] = (sbyte) num;
  }

  public void method_1(sbyte value)
  {
    sbyte[] buffer = this.buffer;
    int int0 = this.int_0;
    this.int_0 = int0 + Class15.smethod_0(1);
    int index = int0;
    int num = (int) value;
    buffer[index] = (sbyte) num;
  }

  public void method_2(sbyte value) => this.method_0(value);

  public void method_3(int value) => this.method_0((sbyte) value);

  public void method_4(char value)
  {
    this.method_0((sbyte) Class15.smethod_0(0));
    this.method_0((sbyte) value);
  }

  public void method_5(byte value) => this.method_0((sbyte) value);

  public void method_6(byte[] value)
  {
    this.method_21(value.Length);
    for (int index = Class15.smethod_0(0); index < value.Length; index += Class15.smethod_0(1))
      this.method_1((sbyte) value[index]);
  }

  public void method_7(sbyte[] value)
  {
    this.method_21(value.Length);
    for (int index = Class15.smethod_0(0); index < value.Length; index += Class15.smethod_0(1))
      this.method_1(value[index]);
  }

  public void method_8(short value)
  {
    this.method_21(Class15.smethod_0(7));
    for (int index = Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      this.method_1((sbyte) ((int) value >> (index * Class15.smethod_0(88) & Class15.smethod_0(8))));
  }

  public void method_9(int value)
  {
    this.method_21(Class15.smethod_0(7));
    short num = (short) value;
    for (int index = Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      this.method_1((sbyte) ((int) num >> (index * Class15.smethod_0(88) & Class15.smethod_0(8))));
  }

  public void method_10(ushort value)
  {
    this.method_21(Class15.smethod_0(7));
    for (int index = Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      this.method_1((sbyte) ((int) value >> (index * Class15.smethod_0(88) & Class15.smethod_0(8))));
  }

  public void method_11(int value)
  {
    this.method_21(Class15.smethod_0(2));
    for (int index = Class15.smethod_0(5); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      this.method_1((sbyte) (value >> (index * Class15.smethod_0(88) & Class15.smethod_0(8))));
  }

  public void method_12(long value)
  {
    this.method_21(Class15.smethod_0(88));
    for (int index = Class15.smethod_0(38); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      this.method_1((sbyte) (value >> (index * Class15.smethod_0(88) & Class15.smethod_0(182))));
  }

  public void method_13(bool value) => this.method_0((!value ? 0 : 1) != 0 ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0));

  public void method_14(bool value) => this.method_0((!value ? 0 : 1) != 0 ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0));

  public void method_15(string value)
  {
    char[] charArray = value.ToCharArray();
    this.method_8((short) charArray.Length);
    this.method_21(charArray.Length);
    for (int index = Class15.smethod_0(0); index < charArray.Length; index += Class15.smethod_0(1))
      this.method_1((sbyte) charArray[index]);
  }

  public void method_16(string value)
  {
    Encoding unicode = Encoding.Unicode;
    byte[] numArray = Encoding.Convert(unicode, Encoding.GetEncoding(Class15.smethod_0(458)), unicode.GetBytes(value));
    this.method_8((short) numArray.Length);
    this.method_21(numArray.Length);
    for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
      this.method_1((sbyte) numArray[index]);
  }

  public void method_17(sbyte value) => this.method_0(value);

  public void method_18(ref sbyte[] data, int arg1, int arg2)
  {
    if ((data == null ? 0 : 1) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < arg2; index += Class15.smethod_0(1))
    {
      this.method_0(data[index + arg1]);
      if (this.int_0 > this.buffer.Length)
        break;
    }
  }

  public void method_19(sbyte[] value) => this.method_7(value);

  public sbyte[] method_20()
  {
    if (this.int_0 <= Class15.smethod_0(0))
      return (sbyte[]) null;
    sbyte[] numArray = new sbyte[this.int_0];
    for (int index = Class15.smethod_0(0); index < this.int_0; index += Class15.smethod_0(1))
      numArray[index] = this.buffer[index];
    return numArray;
  }

  public void method_21(int ltemp)
  {
    if (this.int_0 + ltemp <= this.int_1)
      return;
    sbyte[] numArray = new sbyte[this.int_1 + Class15.smethod_0(246) + ltemp];
    for (int index = Class15.smethod_0(0); index < this.int_1; index += Class15.smethod_0(1))
      numArray[index] = this.buffer[index];
    this.buffer = (sbyte[]) null;
    this.buffer = numArray;
    this.int_1 += Class15.smethod_0(246) + ltemp;
  }

  private static void smethod_0(string[] string_0)
  {
    string path1 = string_0[Class15.smethod_0(0)];
    string path2 = string_0[Class15.smethod_0(1)];
    Encoding unicode = Encoding.Unicode;
    StreamReader textReader_0 = new StreamReader(path1, unicode);
    try
    {
      StreamWriter textWriter_0 = new StreamWriter(path2, Class15.smethod_0(0) != 0, Encoding.UTF8);
      try
      {
        GClass136.smethod_1((TextReader) textReader_0, (TextWriter) textWriter_0);
      }
      finally
      {
        if ((textWriter_0 == null ? 1 : 0) == 0)
          textWriter_0.Dispose();
      }
    }
    finally
    {
      if ((textReader_0 == null ? 1 : 0) == 0)
        textReader_0.Dispose();
    }
  }

  private static void smethod_1(TextReader textReader_0, TextWriter textWriter_0)
  {
    char[] buffer = new char[Class15.smethod_0(189)];
    int count;
    while (((count = textReader_0.Read(buffer, Class15.smethod_0(0), buffer.Length)) == 0 ? 0 : 1) != 0)
      textWriter_0.Write(buffer, Class15.smethod_0(0), count);
    textWriter_0.Flush();
    Debug.Log((object) textWriter_0.ToString());
  }

  public byte method_22(sbyte var) => (int) var > Class15.smethod_0(0) ? (byte) var : (byte) ((uint) var + (uint) Class15.smethod_0(290));

  public byte[] method_23(sbyte[] var)
  {
    byte[] numArray = new byte[var.Length];
    for (int index = Class15.smethod_0(0); index < var.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) var[index] <= Class15.smethod_0(0) ? (byte) ((uint) var[index] + (uint) Class15.smethod_0(290)) : (byte) var[index];
    return numArray;
  }

  public void method_24() => this.buffer = (sbyte[]) null;

  public void method_25() => this.buffer = (sbyte[]) null;
}
