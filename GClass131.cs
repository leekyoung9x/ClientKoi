// Decompiled with JetBrains decompiler
// Type: GClass131
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Text;
using UnityEngine;

public class GClass131
{
  public sbyte[] buffer;
  private int int_0;
  private int int_1;
  private static string string_0;
  private static int int_2;

  public GClass131()
  {
  }

  public GClass131(sbyte[] data) => this.buffer = data;

  public GClass131(string filename) => this.buffer = GClass126.smethod_20(((TextAsset) Resources.Load(filename, typeof (TextAsset))).bytes);

  public sbyte method_0()
  {
    if (this.int_0 >= this.buffer.Length)
    {
      this.int_0 = this.buffer.Length;
      throw new Exception(Class13.smethod_0(154270));
    }
    sbyte[] buffer = this.buffer;
    int int0 = this.int_0;
    this.int_0 = int0 + Class15.smethod_0(1);
    int index = int0;
    return buffer[index];
  }

  public sbyte method_1() => this.method_0();

  public sbyte method_2() => this.method_0();

  public void method_3(int readlimit) => this.int_1 = this.int_0;

  public void method_4() => this.int_0 = this.int_1;

  public byte method_5() => GClass131.smethod_0(this.method_0());

  public short method_6()
  {
    short num1 = (short) Class15.smethod_0(0);
    for (int index1 = Class15.smethod_0(0); index1 < Class15.smethod_0(7); index1 += Class15.smethod_0(1))
    {
      int num2 = (int) (short) ((int) num1 << Class15.smethod_0(88));
      int num3 = Class15.smethod_0(270);
      sbyte[] buffer = this.buffer;
      int int0 = this.int_0;
      this.int_0 = int0 + Class15.smethod_0(1);
      int index2 = int0;
      int num4 = (int) buffer[index2];
      int num5 = (int) (short) (num3 & num4);
      num1 = (short) (num2 | num5);
    }
    return num1;
  }

  public ushort method_7()
  {
    ushort num1 = (ushort) Class15.smethod_0(0);
    for (int index1 = Class15.smethod_0(0); index1 < Class15.smethod_0(7); index1 += Class15.smethod_0(1))
    {
      int num2 = (int) (ushort) ((uint) num1 << Class15.smethod_0(88));
      int num3 = Class15.smethod_0(270);
      sbyte[] buffer = this.buffer;
      int int0 = this.int_0;
      this.int_0 = int0 + Class15.smethod_0(1);
      int index2 = int0;
      int num4 = (int) buffer[index2];
      int num5 = (int) (ushort) (num3 & num4);
      num1 = (ushort) (num2 | num5);
    }
    return num1;
  }

  public int method_8()
  {
    int num1 = Class15.smethod_0(0);
    for (int index1 = Class15.smethod_0(0); index1 < Class15.smethod_0(2); index1 += Class15.smethod_0(1))
    {
      int num2 = num1 << Class15.smethod_0(88);
      int num3 = Class15.smethod_0(270);
      sbyte[] buffer = this.buffer;
      int int0 = this.int_0;
      this.int_0 = int0 + Class15.smethod_0(1);
      int index2 = int0;
      int num4 = (int) buffer[index2];
      int num5 = num3 & num4;
      num1 = num2 | num5;
    }
    return num1;
  }

  public long method_9()
  {
    long num1 = (long) Class15.smethod_0(0);
    for (int index1 = Class15.smethod_0(0); index1 < Class15.smethod_0(88); index1 += Class15.smethod_0(1))
    {
      long num2 = num1 << Class15.smethod_0(88);
      int num3 = Class15.smethod_0(270);
      sbyte[] buffer = this.buffer;
      int int0 = this.int_0;
      this.int_0 = int0 + Class15.smethod_0(1);
      int index2 = int0;
      int num4 = (int) buffer[index2];
      long num5 = (long) (num3 & num4);
      num1 = num2 | num5;
    }
    return num1;
  }

  public bool method_10() => (int) this.method_0() > Class15.smethod_0(0);

  public bool method_11() => (int) this.method_0() > Class15.smethod_0(0);

  public string method_12()
  {
    short length = this.method_6();
    byte[] bytes = new byte[(int) length];
    for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
      bytes[index] = GClass131.smethod_0(this.method_0());
    return new UTF8Encoding().GetString(bytes);
  }

  public string method_13()
  {
    short length = this.method_6();
    byte[] bytes = new byte[(int) length];
    for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
      bytes[index] = GClass131.smethod_0(this.method_0());
    return new UTF8Encoding().GetString(bytes);
  }

  public string method_14() => this.method_13();

  public int method_15() => this.int_0 < this.buffer.Length ? (int) this.method_0() : -1;

  public int method_16(ref sbyte[] data)
  {
    if ((data == null ? 0 : 1) == 0)
      return Class15.smethod_0(0);
    int num = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < data.Length; index += Class15.smethod_0(1))
    {
      data[index] = this.method_0();
      if (this.int_0 > this.buffer.Length)
        return -1;
      num += Class15.smethod_0(1);
    }
    return num;
  }

  public void method_17(ref sbyte[] data)
  {
    if ((data == null ? 1 : 0) != 0 || data.Length + this.int_0 > this.buffer.Length)
      return;
    for (int index = Class15.smethod_0(0); index < data.Length; index += Class15.smethod_0(1))
      data[index] = this.method_0();
  }

  public int method_18() => this.buffer.Length - this.int_0;

  public static byte smethod_0(sbyte var) => (int) var > Class15.smethod_0(0) ? (byte) var : (byte) ((uint) var + (uint) Class15.smethod_0(290));

  public static byte[] smethod_1(sbyte[] var)
  {
    byte[] numArray = new byte[var.Length];
    for (int index = Class15.smethod_0(0); index < var.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) var[index] <= Class15.smethod_0(0) ? (byte) ((uint) var[index] + (uint) Class15.smethod_0(290)) : (byte) var[index];
    return numArray;
  }

  public void method_19() => this.buffer = (sbyte[]) null;

  public void method_20() => this.buffer = (sbyte[]) null;

  public void method_21(ref sbyte[] data, int arg1, int arg2)
  {
    if ((data == null ? 0 : 1) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < arg2; index += Class15.smethod_0(1))
    {
      data[index + arg1] = this.method_0();
      if (this.int_0 > this.buffer.Length)
        break;
    }
  }
}
