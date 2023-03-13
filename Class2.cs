// Decompiled with JetBrains decompiler
// Type: Class2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

internal class Class2 : GClass20
{
  public static GClass50 gclass50_0;
  public static GClass50 gclass50_1;
  private int int_26;
  private int int_27;
  private bool bool_20;
  private GClass41 gclass41_1;
  private GClass20 gclass20_3;
  public int xTo;
  public int yTo;
  public bool haftBody;
  public bool change;
  private GClass20[] gclass20_4;
  private int[] int_28;
  private int int_29;
  public static int[] int_30;
  public static int[] int_31;
  public static int[] int_32;
  public static int[] int_33;
  public static int[][] int_34;
  public sbyte skillID = -1;
  private int int_35;
  private int int_36;

  public Class2()
  {
    this.method_158();
    this.method_160();
  }

  public void method_156(int int_37)
  {
    this.gclass41_1 = new GClass41(Class15.smethod_0(57), this.cx, this.cy + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1);
    GClass40.smethod_0(this.gclass41_1);
    if (int_37 == GClass20.smethod_1().charID)
      this.gclass20_3 = GClass20.smethod_1();
    else
      this.gclass20_3 = GClass116.smethod_12(int_37);
  }

  public void method_157(int[] int_37)
  {
    if ((this.skillID == (sbyte) 0 ? 0 : 1) == 0)
    {
      if (this.int_26 == Class15.smethod_0(67))
      {
        this.bool_20 = Class15.smethod_0(1) != 0;
        GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.cx, this.cy + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1));
      }
      if (this.int_26 >= int_37.Length - Class15.smethod_0(1))
      {
        this.skillID = (sbyte) Class15.smethod_0(7);
        return;
      }
    }
    if ((int) this.skillID == Class15.smethod_0(1) && this.int_26 == int_37.Length - Class15.smethod_0(1))
    {
      this.skillID = (sbyte) Class15.smethod_0(5);
      this.cy -= Class15.smethod_0(9);
    }
    else
    {
      this.int_26 += Class15.smethod_0(1);
      if (this.int_26 > int_37.Length - Class15.smethod_0(1))
        this.int_26 = Class15.smethod_0(0);
      this.int_35 = int_37[this.int_26];
    }
  }

  public void method_158()
  {
    Class2.gclass50_0 = (GClass50) null;
    Class2.gclass50_0 = new GClass50();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(139456);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(139790);
    strArray[Class15.smethod_0(5)] = Class15.smethod_0(68).ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(139896);
    string patch = string.Concat(strArray);
    try
    {
      Class2.gclass50_0.method_4(patch);
      Class2.gclass50_0.img = GClass62.smethod_40(Class13.smethod_0(139790) + Class15.smethod_0(68).ToString() + Class13.smethod_0(139890));
    }
    catch (Exception ex)
    {
    }
  }

  public void method_159(
    sbyte sbyte_22,
    short short_5,
    short short_6,
    GClass20[] gclass20_5,
    int[] int_37)
  {
    this.skillID = sbyte_22;
    this.xTo = (int) short_5;
    this.yTo = (int) short_6;
    this.int_27 = this.cdir;
    this.cdir = this.xTo > this.cx ? Class15.smethod_0(1) : -1;
    this.gclass20_4 = gclass20_5;
    this.int_28 = int_37;
  }

  public void method_160()
  {
    Class2.gclass50_1 = (GClass50) null;
    Class2.gclass50_1 = new GClass50();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(139881);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(139873);
    strArray[Class15.smethod_0(5)] = Class15.smethod_0(323).ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(140628);
    string patch = string.Concat(strArray);
    try
    {
      Class2.gclass50_1.method_4(patch);
      Class2.gclass50_1.img = GClass62.smethod_40(Class13.smethod_0(139873) + Class15.smethod_0(323).ToString() + Class13.smethod_0(140610));
      GClass151.smethod_7(Class13.smethod_0(140729));
    }
    catch (Exception ex)
    {
    }
  }

  public override void vmethod_0()
  {
    if ((this.gclass20_3 == null ? 1 : 0) == 0)
    {
      if (this.gclass41_1.t >= Class15.smethod_0(6))
      {
        this.gclass41_1.x += (this.cx - this.gclass41_1.x) / Class15.smethod_0(2);
        this.gclass41_1.y += (this.cy - this.gclass41_1.y) / Class15.smethod_0(2);
        this.gclass20_3.cx = this.gclass41_1.x;
        this.gclass20_3.cy = this.gclass41_1.y;
        this.gclass20_3.isMabuHold = Class15.smethod_0(1) != 0;
      }
      else
      {
        this.gclass41_1.trans = this.gclass41_1.x > this.gclass20_3.cx ? Class15.smethod_0(1) : Class15.smethod_0(0);
        this.gclass41_1.x += (this.gclass20_3.cx - this.gclass41_1.x) / Class15.smethod_0(5);
        this.gclass41_1.y += (this.gclass20_3.cy - this.gclass41_1.y) / Class15.smethod_0(5);
      }
    }
    if (this.skillID != (sbyte) -1)
    {
      if ((this.skillID == (sbyte) 0 ? 0 : 1) == 0 && (!this.bool_20 ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
      {
        this.int_29 += this.xTo <= this.cx ? Class15.smethod_0(217) : Class15.smethod_0(6);
        GClass40.smethod_0(new GClass41(Class15.smethod_0(323), this.cx + this.int_29, this.cy + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1)
        {
          trans = this.xTo <= this.cx ? Class15.smethod_0(1) : Class15.smethod_0(0)
        });
        if (this.cdir == Class15.smethod_0(1) && this.cx + this.int_29 >= this.xTo || this.cdir == -1 && this.cx + this.int_29 <= this.xTo)
        {
          this.bool_20 = Class15.smethod_0(0) != 0;
          this.skillID = (sbyte) -1;
          this.int_29 = Class15.smethod_0(0);
          this.int_26 = Class15.smethod_0(0);
          this.cdir = this.int_27;
          for (int index = Class15.smethod_0(0); index < this.gclass20_4.Length; index += Class15.smethod_0(1))
            this.gclass20_4[index].method_108(this.int_28[index], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
        }
      }
      if ((int) this.skillID != Class15.smethod_0(5))
        return;
      this.xTo = this.gclass20_4[this.int_36].cx;
      this.yTo = this.gclass20_4[this.int_36].cy;
      this.cx += (this.xTo - this.cx) / Class15.smethod_0(5);
      this.cy += (this.yTo - this.cy) / Class15.smethod_0(5);
      if ((GClass62.int_8 % Class15.smethod_0(3) == 0 ? 0 : 1) == 0)
        GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.cx, this.cy, Class15.smethod_0(7), Class15.smethod_0(1), -1));
      if (GClass151.smethod_25(this.cx - this.xTo) > Class15.smethod_0(51) || GClass151.smethod_25(this.cy - this.yTo) > Class15.smethod_0(51))
        return;
      this.cx = this.xTo;
      this.cy = this.yTo;
      this.gclass20_4[this.int_36].method_108(this.int_28[this.int_36], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
      this.int_36 += Class15.smethod_0(1);
      if (this.int_36 != this.gclass20_4.Length)
        return;
      this.skillID = (sbyte) -1;
      this.int_36 = Class15.smethod_0(0);
    }
    else
      base.vmethod_0();
  }

  public override void vmethod_1(GClass98 g)
  {
    if (this.skillID != (sbyte) -1)
    {
      this.method_87(g);
      g.method_1(Class15.smethod_0(0), GClass62.int_52);
      this.method_157(Class2.int_34[(int) this.skillID]);
      if ((this.skillID == (sbyte) 0 ? 1 : 0) == 0 && (int) this.skillID != Class15.smethod_0(1))
        Class2.gclass50_1.method_9(g, this.int_35, this.cx, this.cy + this.fy, this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(7));
      else
        Class2.gclass50_0.method_9(g, this.int_35, this.cx, this.cy + this.fy, this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(7));
      g.method_1(Class15.smethod_0(0), -GClass62.int_52);
    }
    else
      base.vmethod_1(g);
  }

  static Class2()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(13)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.ErXijfVPffPo));
    Class2.int_30 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(216)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.HQJHWidyKelo));
    Class2.int_31 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(623)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.rldtDfxizrQx));
    Class2.int_32 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.ROLmQJntBxwH));
    Class2.int_33 = (int[]) Class15.smethod_4(byte_0_4);
    int[][] numArray = new int[Class15.smethod_0(2)][];
    numArray[Class15.smethod_0(0)] = Class2.int_30;
    numArray[Class15.smethod_0(1)] = Class2.int_31;
    numArray[Class15.smethod_0(7)] = Class2.int_32;
    numArray[Class15.smethod_0(5)] = Class2.int_33;
    Class2.int_34 = numArray;
  }
}
