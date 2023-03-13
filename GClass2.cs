// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass2
{
  public int life;
  public int ax;
  public int ay;
  public int axTo;
  public int ayTo;
  public int avx;
  public int avy;
  public int adx;
  public int ady;
  public GClass20 charBelong;
  public GClass3 arrp;
  public static sbyte[] sbyte_0;
  public static int[] int_0;
  public static int[] int_1;

  public GClass2(GClass20 charBelong, GClass3 arrp)
  {
    this.charBelong = charBelong;
    this.arrp = arrp;
  }

  public void method_0()
  {
    if ((this.charBelong.mobFocus == null ? 0 : 1) == 0 && (this.charBelong.charFocus == null ? 0 : 1) == 0)
    {
      this.method_1();
    }
    else
    {
      if ((this.charBelong.mobFocus == null ? 1 : 0) == 0)
      {
        this.axTo = this.charBelong.mobFocus.x;
        this.ayTo = this.charBelong.mobFocus.y - this.charBelong.mobFocus.h / Class15.smethod_0(2);
      }
      else if ((this.charBelong.charFocus == null ? 1 : 0) == 0)
      {
        this.axTo = this.charBelong.charFocus.cx;
        this.ayTo = this.charBelong.charFocus.cy - this.charBelong.charFocus.ch / Class15.smethod_0(2);
      }
      int num1 = this.axTo - this.ax;
      int num2 = this.ayTo - this.ay;
      int num3 = Class15.smethod_0(3);
      int num4 = Class15.smethod_0(2);
      if (num1 + num2 < Class15.smethod_0(4))
        num4 = Class15.smethod_0(5);
      else if (num1 + num2 < Class15.smethod_0(6))
        num4 = Class15.smethod_0(7);
      if (this.ax != this.axTo)
      {
        if (num1 > Class15.smethod_0(0) && num1 < num3)
          this.ax = this.axTo;
        else if (num1 < Class15.smethod_0(0) && num1 > -num3)
        {
          this.ax = this.axTo;
        }
        else
        {
          this.avx = this.axTo - this.ax << Class15.smethod_0(7);
          this.adx += this.avx;
          this.ax += this.adx >> (num4 & Class15.smethod_0(8));
          this.adx &= Class15.smethod_0(9);
        }
      }
      if (this.ay != this.ayTo)
      {
        if (num2 > Class15.smethod_0(0) && num2 < num3)
          this.ay = this.ayTo;
        else if (num2 < Class15.smethod_0(0) && num2 > -num3)
        {
          this.ay = this.ayTo;
        }
        else
        {
          this.avy = this.ayTo - this.ay << Class15.smethod_0(7);
          this.ady += this.avy;
          this.ay += this.ady >> (num4 & Class15.smethod_0(8));
          this.ady &= Class15.smethod_0(9);
        }
      }
      int num5 = Class15.smethod_0(0);
      int num6 = Class15.smethod_0(0);
      int num7 = Class15.smethod_0(0);
      int num8 = Class15.smethod_0(0);
      if ((this.charBelong.mobFocus == null ? 1 : 0) == 0)
      {
        num5 = this.axTo - this.charBelong.mobFocus.w / Class15.smethod_0(2);
        num7 = this.axTo + this.charBelong.mobFocus.w / Class15.smethod_0(2);
        num6 = this.ayTo - this.charBelong.mobFocus.h / Class15.smethod_0(2);
        num8 = this.ayTo + this.charBelong.mobFocus.h / Class15.smethod_0(2);
      }
      else if ((this.charBelong.charFocus == null ? 1 : 0) == 0)
      {
        num5 = this.axTo - this.charBelong.charFocus.cw / Class15.smethod_0(2);
        num7 = this.axTo + this.charBelong.charFocus.cw / Class15.smethod_0(2);
        num6 = this.ayTo - this.charBelong.charFocus.ch / Class15.smethod_0(2);
        num8 = this.ayTo + this.charBelong.charFocus.ch / Class15.smethod_0(2);
      }
      if (this.life > Class15.smethod_0(0))
        this.life -= Class15.smethod_0(1);
      if ((this.life == 0 ? 1 : 0) == 0 && (this.ax < num5 || this.ax > num7 || this.ay < num6 || this.ay > num8))
        return;
      this.method_1();
    }
  }

  private void method_1()
  {
    this.charBelong.arr = (GClass2) null;
    this.ax = this.ay = this.axTo = this.ayTo = this.avx = this.avy = this.adx = this.ady = Class15.smethod_0(0);
    this.charBelong.method_72();
    if ((!this.charBelong.me ? 1 : 0) != 0)
      return;
    this.charBelong.method_25();
  }

  public void method_2(GClass98 g)
  {
    int index = GClass2.smethod_0(GClass151.smethod_5(this.axTo - this.ax, -(this.ayTo - this.ay)));
    GClass169.smethod_6(g, this.arrp.imgId[(int) GClass2.sbyte_0[index]], this.ax, this.ay, GClass2.int_1[index], GClass98.int_1 | GClass98.int_0);
  }

  public static int smethod_0(int angle)
  {
    for (int index = Class15.smethod_0(0); index < GClass2.int_0.Length - Class15.smethod_0(1); index += Class15.smethod_0(1))
    {
      if (angle >= GClass2.int_0[index] && angle <= GClass2.int_0[index + Class15.smethod_0(1)])
        return index >= Class15.smethod_0(10) ? Class15.smethod_0(0) : index;
    }
    return Class15.smethod_0(0);
  }

  static GClass2()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.iiBRAPPNXywI));
    GClass2.sbyte_0 = (sbyte[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(12)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.nGDptYHppRbO));
    GClass2.int_0 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(13)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.GPmQKTrjenBc));
    GClass2.int_1 = (int[]) Class15.smethod_4(byte_0_3);
  }
}
