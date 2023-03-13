// Decompiled with JetBrains decompiler
// Type: GClass16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass16
{
  public static GClass134 gclass134_0 = new GClass134();
  private int[] int_0;
  private int[] int_1;
  private int[] int_2;
  private int[] int_3;
  public static int[] int_4;
  private int int_5;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  private int int_10;
  private int int_11;
  private int int_12;
  private int int_13;
  private bool bool_0;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public static GClass66 gclass66_3;
  public static GClass66 gclass66_4;
  private static GClass66 gclass66_5;
  private static GClass66 gclass66_6;
  private static GClass66 gclass66_7;
  private static GClass66 gclass66_8;
  private int[] int_14;
  private int int_15;
  public int typeEff;
  public int xx;
  public int waterY;
  private bool[] bool_1;
  private int[] int_16;
  private int[] int_17;
  private bool[] bool_2;
  private int int_18;
  private int int_19;
  public const int int_20 = 0;
  public const int int_21 = 1;
  public const int int_22 = 2;
  public const int int_23 = 3;
  public const int int_24 = 4;
  public const int int_25 = 5;
  public const int int_26 = 6;
  public const int int_27 = 7;
  public const int int_28 = 8;
  public const int int_29 = 9;
  public const int int_30 = 10;
  public const int int_31 = 11;
  public const int int_32 = 12;
  public const int int_33 = 13;
  public const int int_34 = 14;
  public const int int_35 = 15;
  public static int int_36 = Class15.smethod_0(10);
  public static GClass66 gclass66_9 = GClass62.smethod_40(Class13.smethod_0(26647));
  public static GClass66 gclass66_10 = GClass62.smethod_40(Class13.smethod_0(26736));
  public static GClass66 gclass66_11;
  public static GClass66 gclass66_12;
  public static bool bool_3;
  public static bool bool_4;
  public static int int_37;
  public static GClass66 gclass66_13;
  public static GClass66 gclass66_14;
  public static int int_38;
  public static int int_39;
  public static int int_40;
  public static int int_41;
  private int[] int_42;
  private int[] int_43;

  public GClass16(int typeS)
  {
    byte[] byte_0 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.IGXibPHhHGkv));
    this.int_42 = (int[]) Class15.smethod_4(byte_0);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    GClass16.bool_3 = Class15.smethod_0(1) != 0;
    GClass16.smethod_2();
    this.typeEff = typeS;
    switch (this.typeEff)
    {
      case 0:
      case 12:
        if (GClass16.gclass66_1 == null)
          GClass16.gclass66_1 = GClass62.smethod_39(Class13.smethod_0(31606));
        if (GClass16.gclass66_2 == null)
          GClass16.gclass66_2 = GClass62.smethod_39(Class13.smethod_0(31592));
        if (GClass16.gclass66_3 == null)
          GClass16.gclass66_3 = GClass62.smethod_39(Class13.smethod_0(24968));
        this.int_15 = GClass151.smethod_18(GClass62.int_10 / Class15.smethod_0(5), GClass62.int_10 / Class15.smethod_0(7));
        this.int_0 = new int[this.int_15];
        this.int_1 = new int[this.int_15];
        this.int_2 = new int[this.int_15];
        this.int_3 = new int[this.int_15];
        this.int_14 = new int[this.int_15];
        this.int_17 = new int[this.int_15];
        this.int_16 = new int[this.int_15];
        this.bool_1 = new bool[this.int_15];
        this.bool_2 = new bool[this.int_15];
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          this.int_1[index] = GClass151.smethod_18(Class15.smethod_0(136), GClass62.int_11 + Class15.smethod_0(21)) + GClass116.int_23;
          this.int_0[index] = GClass151.smethod_18(Class15.smethod_0(136), GClass62.int_10 + Class15.smethod_0(137)) + GClass116.int_22;
          this.int_17[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(1));
          this.int_2[index] = Class15.smethod_0(138);
          this.int_3[index] = Class15.smethod_0(66);
          this.int_14[index] = GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5));
          this.bool_1[index] = Class15.smethod_0(0) != 0;
          if (this.int_14[index] == Class15.smethod_0(7) && index % Class15.smethod_0(7) == 0)
            this.bool_1[index] = Class15.smethod_0(1) != 0;
          this.bool_2[index] = Class15.smethod_0(0) != 0;
          this.int_16[index] = GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(7));
        }
        break;
      case 1:
      case 2:
      case 5:
      case 6:
      case 7:
      case 11:
      case 15:
        if (this.typeEff == Class15.smethod_0(1))
        {
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26455));
          GClass16.int_36 = Class15.smethod_0(31);
        }
        if (this.typeEff == Class15.smethod_0(7))
        {
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26434));
          GClass16.int_36 = Class15.smethod_0(124);
        }
        if (this.typeEff == Class15.smethod_0(3))
        {
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26613));
          GClass16.int_36 = Class15.smethod_0(49);
        }
        if (this.typeEff == Class15.smethod_0(37))
        {
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26598));
          GClass16.int_36 = Class15.smethod_0(49);
        }
        if (this.typeEff == Class15.smethod_0(38))
        {
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26569));
          GClass16.int_36 = Class15.smethod_0(66);
        }
        if (this.typeEff == Class15.smethod_0(67))
          GClass16.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(26147));
        if (this.typeEff == Class15.smethod_0(9))
        {
          if (GClass169.gclass192_0[Class15.smethod_0(139)] == null)
            GClass169.smethod_5(Class15.smethod_0(139));
          GClass16.int_36 = Class15.smethod_0(10);
        }
        this.int_15 = GClass151.smethod_18(Class15.smethod_0(9), Class15.smethod_0(46));
        if (this.typeEff == Class15.smethod_0(67))
          this.int_15 = Class15.smethod_0(21);
        this.int_0 = new int[this.int_15];
        this.int_1 = new int[this.int_15];
        this.int_2 = new int[this.int_15];
        this.int_3 = new int[this.int_15];
        this.int_17 = new int[this.int_15];
        this.int_16 = new int[this.int_15];
        this.bool_2 = new bool[this.int_15];
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          this.int_0[index] = GClass151.smethod_18(Class15.smethod_0(136), GClass185.int_23 + Class15.smethod_0(31));
          this.int_1[index] = GClass151.smethod_18(Class15.smethod_0(0), GClass185.int_24);
          this.int_16[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(1));
          this.int_17[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(1));
          this.int_2[index] = GClass151.smethod_18(Class15.smethod_0(134), Class15.smethod_0(5));
          this.int_3[index] = GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(2));
          if (this.typeEff == Class15.smethod_0(67))
          {
            this.int_16[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7));
            this.int_2[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
            this.int_3[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
          }
          if (this.typeEff == Class15.smethod_0(9))
          {
            this.int_16[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7));
            this.int_2[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
            this.int_3[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
          }
        }
        break;
      case 3:
        GClass62.bool_25 = Class15.smethod_0(1) != 0;
        break;
      case 4:
        this.int_15 = GClass151.smethod_18(Class15.smethod_0(3), Class15.smethod_0(31));
        if (GClass16.gclass66_4 == null)
          GClass16.gclass66_4 = GClass62.smethod_39(Class13.smethod_0(26121));
        this.int_0 = new int[this.int_15];
        this.int_1 = new int[this.int_15];
        this.int_16 = new int[this.int_15];
        this.int_17 = new int[this.int_15];
        this.int_43 = new int[this.int_15];
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          this.int_0[index] = GClass151.smethod_18(Class15.smethod_0(0), GClass62.int_10);
          this.int_1[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(32));
          this.int_43[index] = index % Class15.smethod_0(7) != 0 ? (index % Class15.smethod_0(5) != 0 ? (index % Class15.smethod_0(2) != 0 ? Class15.smethod_0(5) : Class15.smethod_0(7)) : Class15.smethod_0(1)) : Class15.smethod_0(0);
          this.int_17[index] = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(31));
        }
        break;
      case 8:
        this.int_12 = GClass151.smethod_18(Class15.smethod_0(21), Class15.smethod_0(137));
        if (GClass16.gclass66_6 == null)
          GClass16.gclass66_6 = GClass62.smethod_39(Class13.smethod_0(26213));
        if (GClass16.gclass66_7 == null)
          GClass16.gclass66_7 = GClass62.smethod_39(Class13.smethod_0(26176));
        if (GClass16.gclass66_8 == null)
          GClass16.gclass66_8 = GClass62.smethod_39(Class13.smethod_0(26288));
        this.bool_0 = Class15.smethod_0(0) != 0;
        this.method_0();
        break;
      case 9:
        if (GClass16.gclass66_11 == null)
          GClass16.gclass66_11 = GClass62.smethod_39(Class13.smethod_0(30649));
        if (GClass16.gclass66_12 == null)
          GClass16.gclass66_12 = GClass62.smethod_39(Class13.smethod_0(31499));
        this.int_5 = Class15.smethod_0(51);
        this.int_0 = new int[this.int_5];
        this.int_1 = new int[this.int_5];
        GClass16.int_4 = new int[this.int_5];
        this.int_2 = new int[this.int_5];
        for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
        {
          this.int_0[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), GClass62.int_10));
          this.int_1[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(31), Class15.smethod_0(25)));
          GClass16.int_4[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
          this.int_2[index] = GClass16.int_4[index];
        }
        break;
      case 10:
        this.int_5 = Class15.smethod_0(6);
        this.int_0 = new int[this.int_5];
        this.int_1 = new int[this.int_5];
        GClass16.int_4 = new int[this.int_5];
        this.int_2 = new int[this.int_5];
        int num = Class15.smethod_0(0);
        for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
        {
          this.int_0[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), GClass62.int_10)) + GClass116.int_22;
          num += Class15.smethod_0(1);
          if (num > this.int_5 / Class15.smethod_0(7))
          {
            this.int_1[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(51), Class15.smethod_0(4)));
            GClass16.int_4[index] = Class15.smethod_0(31);
          }
          else
          {
            this.int_1[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(51)));
            GClass16.int_4[index] = Class15.smethod_0(38);
          }
          this.int_2[index] = GClass16.int_4[index] / Class15.smethod_0(7) - Class15.smethod_0(7);
        }
        break;
      case 13:
        if (GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7))) != 0)
          break;
        GClass16.bool_4 = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7))) != 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
        GClass16.int_37 = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(7), Class15.smethod_0(3)));
        GClass16.smethod_2();
        break;
      case 14:
        if (GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7))) != 0)
          break;
        GClass16.bool_3 = Class15.smethod_0(1) != 0;
        GClass16.smethod_2();
        break;
    }
  }

  public static void smethod_0() => GClass185.int_73 = Class15.smethod_0(0);

  public static bool smethod_1()
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass16 gclass16 = (GClass16) GClass16.gclass134_0.method_3(index);
      if ((gclass16.typeEff == 0 ? 1 : 0) != 0 || gclass16.typeEff == Class15.smethod_0(66))
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static void smethod_2()
  {
    if (GClass126.int_0 == Class15.smethod_0(1))
    {
      GClass16.gclass66_13 = (GClass66) null;
      GClass16.gclass66_14 = (GClass66) null;
    }
    else if ((!GClass62.bool_1 ? 1 : 0) == 0)
    {
      GClass16.gclass66_13 = (GClass66) null;
      GClass16.gclass66_14 = (GClass66) null;
    }
    else
    {
      if (GClass16.int_37 > Class15.smethod_0(0))
      {
        if ((GClass16.gclass66_13 == null ? 0 : 1) == 0)
        {
          GClass16.gclass66_13 = GClass62.smethod_40(Class13.smethod_0(27032));
          GClass16.int_38 = GClass16.gclass66_13.method_0();
        }
      }
      else
        GClass16.gclass66_13 = (GClass66) null;
      if ((!GClass16.bool_3 ? 0 : 1) == 0)
      {
        GClass16.gclass66_14 = (GClass66) null;
      }
      else
      {
        if ((GClass16.gclass66_14 == null ? 0 : 1) == 0)
          GClass16.gclass66_14 = GClass62.smethod_40(Class13.smethod_0(27124));
        GClass16.int_41 = Class15.smethod_0(140);
      }
    }
  }

  public static void smethod_3()
  {
    if (GClass126.int_0 == Class15.smethod_0(1) || (!GClass62.bool_1 ? 0 : 1) != 0 || GClass16.int_37 <= Class15.smethod_0(0))
      return;
    int num1 = GClass62.gclass113_0 != GClass116.smethod_6() ? GClass116.int_22 + GClass62.int_10 : GClass185.int_23;
    for (int index = Class15.smethod_0(0); index < GClass16.int_37; index += Class15.smethod_0(1))
    {
      int num2 = index + Class15.smethod_0(1);
      GClass62.int_41[index] -= num2;
      if (GClass62.int_41[index] < -GClass16.int_38)
        GClass62.int_41[index] = num1 + Class15.smethod_0(21);
    }
  }

  public static void smethod_4()
  {
    if (GClass126.int_0 == Class15.smethod_0(1) || (!GClass62.bool_1 ? 0 : 1) != 0 || (!GClass16.bool_3 ? 1 : 0) != 0)
      return;
    GClass16.int_39 -= Class15.smethod_0(1);
    if (GClass16.int_39 >= -GClass16.int_41)
      return;
    GClass16.int_39 = Class15.smethod_0(0);
  }

  public static void smethod_5(GClass98 g)
  {
    if (GClass126.int_0 == Class15.smethod_0(1) || (!GClass62.bool_1 ? 0 : 1) != 0 || (GClass16.int_37 == 0 ? 1 : 0) != 0 || (GClass16.gclass66_13 == null ? 0 : 1) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < GClass16.int_37; index += Class15.smethod_0(1))
    {
      int num = index;
      if (num > Class15.smethod_0(5))
        num = Class15.smethod_0(5);
      if ((num == 0 ? 0 : 1) == 0)
        Class15.smethod_0(1);
      g.method_32(GClass16.gclass66_13, GClass62.int_41[index], GClass62.int_42[index], Class15.smethod_0(5));
    }
  }

  public static void smethod_6(GClass98 g)
  {
    if (GClass126.int_0 == Class15.smethod_0(1) || (!GClass62.bool_1 ? 0 : 1) != 0 || (!GClass16.bool_3 ? 1 : 0) != 0 || (GClass16.gclass66_14 == null ? 0 : 1) == 0)
      return;
    for (int int39 = GClass16.int_39; int39 < GClass185.int_23; int39 += GClass16.int_41)
    {
      if (int39 >= GClass116.int_22 - GClass16.int_41)
        g.method_33(GClass16.gclass66_14, int39, GClass16.int_40, Class15.smethod_0(0));
    }
  }

  private void method_0()
  {
    int int22 = GClass116.int_22;
    int int23 = GClass116.int_23;
    this.int_8 = GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5));
    this.bool_0 = Class15.smethod_0(0) != 0;
    this.int_13 = GClass151.smethod_18(Class15.smethod_0(5), Class15.smethod_0(3));
    if (this.int_8 == Class15.smethod_0(1))
    {
      this.int_6 = Class15.smethod_0(141);
      this.int_7 = GClass151.smethod_18(int23, GClass62.int_11 - Class15.smethod_0(21) + int23);
      this.int_9 = Class15.smethod_0(0);
    }
    else if (this.int_8 == Class15.smethod_0(7))
    {
      this.int_6 = GClass185.int_23 + Class15.smethod_0(32);
      this.int_7 = GClass151.smethod_18(int23, GClass62.int_11 - Class15.smethod_0(21) + int23);
      this.int_9 = Class15.smethod_0(7);
    }
    else if (this.int_8 == Class15.smethod_0(5))
    {
      this.int_6 = GClass151.smethod_18(Class15.smethod_0(32) + int22, GClass62.int_10 - Class15.smethod_0(32) + int22);
      this.int_7 = Class15.smethod_0(141);
      this.int_9 = (GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7)) == 0 ? 0 : 1) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0);
    }
    else
    {
      if (this.int_8 != Class15.smethod_0(2))
        return;
      this.int_6 = GClass151.smethod_18(Class15.smethod_0(32) + int22, GClass62.int_10 - Class15.smethod_0(32) + int22);
      this.int_7 = GClass185.int_24 + Class15.smethod_0(32);
      this.int_9 = (GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7)) == 0 ? 0 : 1) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0);
    }
  }

  public void method_1(GClass98 g)
  {
    if (this.typeEff != Class15.smethod_0(31))
      return;
    g.method_16(this.int_19);
    for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
      g.method_32(index >= this.int_5 / Class15.smethod_0(7) ? GClass16.gclass66_9 : GClass16.gclass66_10, this.int_0[index], this.int_1[index] + this.int_18, Class15.smethod_0(0));
  }

  public void method_2(GClass98 g)
  {
    g.method_1(-g.method_3(), -g.method_4());
    if (this.typeEff == Class15.smethod_0(2))
    {
      for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        g.method_24(GClass16.gclass66_4, Class15.smethod_0(0), Class15.smethod_0(10) * this.int_16[index], Class15.smethod_0(10), Class15.smethod_0(10), Class15.smethod_0(0), this.int_0[index], this.int_1[index], Class15.smethod_0(0));
    }
    if (this.typeEff != Class15.smethod_0(45))
      return;
    g.method_16(Class15.smethod_0(142));
    for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
      g.method_32(GClass16.int_4[index] != Class15.smethod_0(1) ? GClass16.gclass66_12 : GClass16.gclass66_11, this.int_0[index], this.int_1[index], Class15.smethod_0(5));
  }

  public void method_3()
  {
    switch (this.typeEff)
    {
      case 0:
      case 12:
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          if (index % Class15.smethod_0(5) != 0 && this.typeEff != Class15.smethod_0(66) && GClass185.smethod_27(this.int_0[index], this.int_1[index] - GClass62.int_52, Class15.smethod_0(7)))
            this.bool_2[index] = Class15.smethod_0(1) != 0;
          if (index % Class15.smethod_0(5) == 0 && this.int_1[index] > GClass62.int_11 + GClass116.int_23)
          {
            this.int_0[index] = GClass151.smethod_18(Class15.smethod_0(136), GClass62.int_10 + Class15.smethod_0(137)) + GClass116.int_22;
            this.int_1[index] = GClass151.smethod_18(Class15.smethod_0(143), Class15.smethod_0(0)) + GClass116.int_23;
          }
          if (!this.bool_2[index])
          {
            this.int_1[index] += this.int_3[index];
            this.int_0[index] += this.int_2[index];
          }
          if (this.bool_2[index])
          {
            this.int_17[index] += Class15.smethod_0(1);
            if (this.int_17[index] > Class15.smethod_0(7))
            {
              this.int_16[index] += Class15.smethod_0(1);
              this.int_17[index] = Class15.smethod_0(0);
              if (this.int_16[index] > Class15.smethod_0(1))
              {
                this.int_16[index] = Class15.smethod_0(0);
                this.bool_2[index] = Class15.smethod_0(0) != 0;
                this.int_0[index] = GClass151.smethod_18(Class15.smethod_0(136), GClass62.int_10 + Class15.smethod_0(137)) + GClass116.int_22;
                this.int_1[index] = GClass151.smethod_18(Class15.smethod_0(143), Class15.smethod_0(0)) + GClass116.int_23;
              }
            }
          }
        }
        break;
      case 1:
      case 2:
      case 5:
      case 6:
      case 7:
      case 11:
      case 15:
        for (int index1 = Class15.smethod_0(0); index1 < this.int_15; index1 += Class15.smethod_0(1))
        {
          if (index1 % Class15.smethod_0(5) != 0 && GClass185.smethod_27(this.int_0[index1], this.int_1[index1] + (GClass185.int_25 == Class15.smethod_0(9) ? Class15.smethod_0(31) : Class15.smethod_0(0)), Class15.smethod_0(7)))
            this.bool_2[index1] = Class15.smethod_0(1) != 0;
          if (index1 % Class15.smethod_0(5) == 0 && this.int_1[index1] > GClass185.int_24)
          {
            this.int_0[index1] = GClass151.smethod_18(Class15.smethod_0(136), GClass185.int_23 + Class15.smethod_0(32));
            this.int_1[index1] = GClass151.smethod_18(Class15.smethod_0(141), Class15.smethod_0(0));
          }
          if (!this.bool_2[index1])
          {
            for (int index2 = Class15.smethod_0(0); index2 < GClass182.gclass134_0.method_2(); index2 += Class15.smethod_0(1))
            {
              GClass182 gclass182 = (GClass182) GClass182.gclass134_0.method_3(index2);
              if (gclass182 != null && gclass182.paintFire && this.int_0[index1] < gclass182.x + Class15.smethod_0(25) && this.int_0[index1] > gclass182.x - Class15.smethod_0(25) && this.int_1[index1] < gclass182.y + Class15.smethod_0(25) && this.int_1[index1] > gclass182.y - Class15.smethod_0(25))
                this.int_0[index1] += this.int_0[index1] >= gclass182.x ? Class15.smethod_0(31) : Class15.smethod_0(136);
            }
            this.int_1[index1] += this.int_3[index1];
            this.int_0[index1] += this.int_2[index1];
            this.int_17[index1] += Class15.smethod_0(1);
            int num1 = this.typeEff != Class15.smethod_0(67) ? Class15.smethod_0(2) : Class15.smethod_0(5);
            int num2 = this.typeEff != Class15.smethod_0(9) ? Class15.smethod_0(2) : Class15.smethod_0(2);
            if (this.int_17[index1] > (this.typeEff == Class15.smethod_0(7) ? Class15.smethod_0(2) : Class15.smethod_0(7)))
            {
              if (this.typeEff != Class15.smethod_0(67) && this.typeEff != Class15.smethod_0(9))
                this.int_16[index1] += Class15.smethod_0(1);
              this.int_17[index1] = Class15.smethod_0(0);
              if (this.int_16[index1] > num2 - Class15.smethod_0(1))
                this.int_16[index1] = Class15.smethod_0(0);
            }
          }
          else
          {
            this.int_17[index1] += Class15.smethod_0(1);
            if (this.int_17[index1] == Class15.smethod_0(21))
            {
              this.int_17[index1] = Class15.smethod_0(0);
              this.int_0[index1] = GClass151.smethod_18(Class15.smethod_0(136), GClass185.int_23 + Class15.smethod_0(32));
              this.int_1[index1] = GClass151.smethod_18(Class15.smethod_0(141), Class15.smethod_0(0));
              this.bool_2[index1] = Class15.smethod_0(0) != 0;
            }
          }
        }
        break;
      case 4:
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          this.int_17[index] += Class15.smethod_0(1);
          if (this.int_17[index] > Class15.smethod_0(31))
          {
            this.int_43[index] += Class15.smethod_0(1);
            this.int_17[index] = Class15.smethod_0(0);
            if (this.int_43[index] > Class15.smethod_0(3))
              this.int_43[index] = Class15.smethod_0(0);
            this.int_16[index] = this.int_42[this.int_43[index]];
          }
        }
        break;
      case 8:
        this.int_11 += Class15.smethod_0(1);
        if (this.int_11 == Class15.smethod_0(5))
        {
          this.int_11 = Class15.smethod_0(0);
          this.int_10 += Class15.smethod_0(1);
          if (this.int_10 > Class15.smethod_0(1))
            this.int_10 = Class15.smethod_0(0);
        }
        if (GClass62.int_8 % this.int_12 == 0)
          this.bool_0 = Class15.smethod_0(1) != 0;
        if (!this.bool_0)
          break;
        if (this.int_8 == Class15.smethod_0(1))
        {
          this.int_6 += this.int_13;
          if (this.int_6 <= GClass185.int_23 + Class15.smethod_0(32))
            break;
          this.method_0();
          break;
        }
        if (this.int_8 == Class15.smethod_0(7))
        {
          this.int_6 -= this.int_13;
          if (this.int_6 >= Class15.smethod_0(141))
            break;
          this.method_0();
          break;
        }
        if (this.int_8 == Class15.smethod_0(5))
        {
          this.int_7 += this.int_13;
          if (this.int_7 <= GClass185.int_24 + Class15.smethod_0(32))
            break;
          this.method_0();
          break;
        }
        if (this.int_8 != Class15.smethod_0(2))
          break;
        this.int_7 -= this.int_13;
        if (this.int_7 >= Class15.smethod_0(141))
          break;
        this.method_0();
        break;
      case 9:
        for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
        {
          this.int_0[index] -= this.int_2[index];
          if (this.int_0[index] < -this.int_2[index])
          {
            GClass16.int_4[index] = GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(5)));
            this.int_2[index] = GClass16.int_4[index];
            this.int_0[index] = GClass62.int_10 + this.int_2[index];
          }
        }
        break;
      case 10:
        for (int index = Class15.smethod_0(0); index < this.int_5; index += Class15.smethod_0(1))
        {
          this.int_0[index] -= this.int_2[index];
          if (this.int_0[index] < -this.int_2[index] + GClass116.int_22)
            this.int_0[index] = GClass62.int_10 + this.int_2[index] + GClass116.int_22;
        }
        break;
      case 13:
        GClass16.smethod_3();
        break;
      case 14:
        GClass16.smethod_4();
        break;
    }
  }

  public void method_4(GClass98 g)
  {
    switch (this.typeEff)
    {
      case 0:
      case 12:
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          if (this.int_14[index] == Class15.smethod_0(7) && this.int_0[index] >= GClass116.int_22 && this.int_0[index] <= GClass62.int_10 + GClass116.int_22 && this.int_1[index] >= GClass116.int_23 && this.int_1[index] <= GClass62.int_11 + GClass116.int_23)
          {
            if ((!this.bool_2[index] ? 1 : 0) == 0)
              g.method_24(GClass16.gclass66_1, Class15.smethod_0(0), Class15.smethod_0(31) * this.int_16[index], Class15.smethod_0(47), Class15.smethod_0(31), Class15.smethod_0(0), this.int_0[index], this.int_1[index] - Class15.smethod_0(31), Class15.smethod_0(0));
            else
              g.method_32(GClass16.gclass66_2, this.int_0[index], this.int_1[index], Class15.smethod_0(0));
          }
        }
        break;
      case 1:
      case 2:
      case 5:
      case 6:
      case 7:
      case 11:
      case 15:
        if (this.typeEff == Class15.smethod_0(9))
        {
          if ((GClass169.gclass192_0[Class15.smethod_0(139)] == null ? 1 : 0) == 0 && (GClass169.gclass192_0[Class15.smethod_0(139)].img == null ? 1 : 0) == 0)
            GClass16.gclass66_5 = GClass169.gclass192_0[Class15.smethod_0(139)].img;
          if ((GClass16.gclass66_5 == null ? 1 : 0) != 0)
            break;
        }
        this.method_5(g, GClass16.gclass66_5);
        break;
      case 13:
        if ((!GClass16.bool_4 ? 0 : 1) != 0)
          break;
        GClass16.smethod_5(g);
        break;
    }
  }

  public void method_5(GClass98 g, GClass66 img)
  {
    Class15.smethod_0(67);
    Class15.smethod_0(9);
    for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
    {
      if ((index % Class15.smethod_0(5) == 0 ? 0 : 1) == 0 && this.int_0[index] >= GClass116.int_22 && this.int_0[index] <= GClass62.int_10 + GClass116.int_22 && this.int_1[index] >= GClass116.int_23 && this.int_1[index] <= GClass62.int_11 + GClass116.int_23 && GClass16.int_36 <= GClass98.smethod_1(img) && GClass16.int_36 * this.int_16[index] < img.method_1())
        g.method_24(img, Class15.smethod_0(0), GClass16.int_36 * this.int_16[index], img.method_0(), GClass16.int_36, Class15.smethod_0(0), this.int_0[index], this.int_1[index], Class15.smethod_0(0));
    }
  }

  public void method_6(GClass98 g, GClass66 img)
  {
    Class15.smethod_0(67);
    Class15.smethod_0(9);
    for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
    {
      if ((index % Class15.smethod_0(5) == 0 ? 1 : 0) == 0 && this.int_0[index] >= GClass116.int_22 && this.int_0[index] <= GClass62.int_10 + GClass116.int_22 && this.int_1[index] >= GClass116.int_23 && this.int_1[index] <= GClass62.int_11 + GClass116.int_23 && GClass16.int_36 <= GClass98.smethod_1(img) && GClass16.int_36 * this.int_16[index] < img.method_1())
        g.method_24(img, Class15.smethod_0(0), GClass16.int_36 * this.int_16[index], img.method_0(), GClass16.int_36, Class15.smethod_0(0), this.int_0[index], this.int_1[index], Class15.smethod_0(0));
    }
  }

  public void method_7(GClass98 g)
  {
    int typeEff = this.typeEff;
    if (typeEff != Class15.smethod_0(88))
    {
      if (typeEff != Class15.smethod_0(47) || (!GClass16.bool_4 ? 1 : 0) != 0)
        return;
      GClass16.smethod_5(g);
    }
    else
    {
      g.method_24(GClass16.gclass66_6, Class15.smethod_0(0), Class15.smethod_0(0), GClass16.gclass66_6.method_0(), GClass16.gclass66_6.method_1(), this.int_9, this.int_6, this.int_7, Class15.smethod_0(5));
      if (this.int_8 != Class15.smethod_0(1) && this.int_8 != Class15.smethod_0(7))
      {
        int num = (this.int_9 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(145) : Class15.smethod_0(67);
        g.method_24(GClass16.gclass66_8, Class15.smethod_0(0), this.int_10 * Class15.smethod_0(124), Class15.smethod_0(88), Class15.smethod_0(124), this.int_9, this.int_6 + num, this.int_7 + Class15.smethod_0(28), Class15.smethod_0(5));
      }
      else
      {
        int num = (this.int_9 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(46) : Class15.smethod_0(144);
        g.method_24(GClass16.gclass66_7, Class15.smethod_0(0), this.int_10 * Class15.smethod_0(88), Class15.smethod_0(51), Class15.smethod_0(88), this.int_9, this.int_6 + num, this.int_7 + Class15.smethod_0(3), Class15.smethod_0(5));
      }
    }
  }

  public void method_8(GClass98 g)
  {
    switch (this.typeEff)
    {
      case 0:
        g.method_16(Class15.smethod_0(146));
        for (int index = Class15.smethod_0(0); index < this.int_15; index += Class15.smethod_0(1))
        {
          if (this.int_14[index] != Class15.smethod_0(7) && this.int_0[index] >= GClass116.int_22 && this.int_0[index] <= GClass62.int_10 + GClass116.int_22 && this.int_1[index] >= GClass116.int_23 && this.int_1[index] <= GClass62.int_11 + GClass116.int_23)
            g.method_32(GClass16.gclass66_3, this.int_0[index], this.int_1[index], Class15.smethod_0(0));
        }
        break;
      case 1:
      case 2:
      case 5:
      case 6:
      case 7:
      case 11:
      case 15:
        if (this.typeEff == Class15.smethod_0(9))
        {
          if ((GClass169.gclass192_0[Class15.smethod_0(139)] == null ? 1 : 0) == 0 && (GClass169.gclass192_0[Class15.smethod_0(139)].img == null ? 1 : 0) == 0)
            GClass16.gclass66_5 = GClass169.gclass192_0[Class15.smethod_0(139)].img;
          if ((GClass16.gclass66_5 == null ? 1 : 0) != 0)
            break;
        }
        this.method_6(g, GClass16.gclass66_5);
        break;
    }
  }

  public static void smethod_7(int id)
  {
  }

  public static void smethod_8(int color, int yWater)
  {
  }

  public static void smethod_9(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_1(g);
  }

  public static void smethod_10(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_7(g);
  }

  public static void smethod_11(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_4(g);
  }

  public static void smethod_12(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_2(g);
  }

  public static void smethod_13(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_8(g);
  }

  public static void smethod_14()
  {
    for (int index = Class15.smethod_0(0); index < GClass16.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass16) GClass16.gclass134_0.method_3(index)).method_3();
  }
}
