// Decompiled with JetBrains decompiler
// Type: GClass119
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GClass119 : GClass113
{
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 1;
  public const sbyte sbyte_2 = 2;
  public const sbyte sbyte_3 = 3;
  public const sbyte sbyte_4 = 4;
  public static GClass119 gclass119_0;
  public static bool bool_0;
  public static GClass60 gclass60_0;
  public static GClass60 gclass60_1;
  public static GClass60 gclass60_2;
  private static GClass66 gclass66_0;
  private static GClass66 gclass66_1;
  private static GClass66 gclass66_2;
  private static GClass66 gclass66_3;
  private static GClass66 gclass66_4;
  private static GClass66 gclass66_5;
  private static GClass66 gclass66_6;
  private static GClass66 gclass66_7;
  private static GClass66 gclass66_8;
  private static GClass66 gclass66_9;
  private static GClass66 gclass66_10;
  private static GClass66 gclass66_11;
  private static GClass66 gclass66_12;
  private static GClass66 gclass66_13;
  private static GClass66[] gclass66_14;
  public static int int_6;
  public static int int_7;
  public static int int_8;
  public static int int_9;
  public static int int_10;
  public static int int_11;
  public static int int_12;
  public static int int_13;
  public static int int_14;
  public static int int_15;
  public static int int_16;
  public static int int_17;
  public static int[] int_18 = new int[Class15.smethod_0(0)];
  public static int[] int_19 = new int[Class15.smethod_0(0)];
  private static int[][] int_20;
  private static int[][] int_21;
  private static int[] int_22;
  private int int_23;
  private int[] int_24;
  private int int_25;
  private int int_26;
  private int int_27;
  public static GClass134 gclass134_0;
  public static GClass134 gclass134_1;
  private static int int_28;
  private static int int_29;
  private GClass75 gclass75_0;
  private int int_30;
  private int int_31;
  private int int_32;
  private int int_33;
  private int int_34;
  private int int_35;

  public GClass119()
  {
    GClass119.bool_0 = Class15.smethod_0(1) != 0;
    GClass66 img1 = GClass126.smethod_35(Class13.smethod_0(148246));
    GClass66 img2 = GClass126.smethod_35(Class13.smethod_0(148232));
    GClass66 img3 = GClass126.smethod_35(Class13.smethod_0(148338));
    int width = Class15.smethod_0(35);
    int height = Class15.smethod_0(35);
    GClass119.gclass60_0 = new GClass60(img1, width, height);
    GClass119.gclass60_1 = new GClass60(img2, Class15.smethod_0(6), Class15.smethod_0(6));
    GClass119.gclass60_2 = new GClass60(img3, Class15.smethod_0(67), Class15.smethod_0(67));
    GClass119.gclass66_0 = GClass126.smethod_35(Class13.smethod_0(148410));
    GClass119.gclass66_2 = GClass126.smethod_35(Class13.smethod_0(149433));
    GClass119.gclass66_3 = GClass126.smethod_35(Class13.smethod_0(149420));
    GClass119.gclass66_1 = GClass126.smethod_35(Class13.smethod_0(148246));
    GClass119.gclass66_4 = GClass126.smethod_35(Class13.smethod_0(149407));
    GClass119.gclass66_5 = GClass126.smethod_35(Class13.smethod_0(149394));
    GClass119.gclass66_6 = GClass126.smethod_35(Class13.smethod_0(149381));
    GClass119.gclass66_14 = new GClass66[Class15.smethod_0(38)];
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(38); index += Class15.smethod_0(1))
      GClass119.gclass66_14[index] = GClass126.smethod_35(Class13.smethod_0(149496) + (index + Class15.smethod_0(38)).ToString() + Class13.smethod_0(149488));
    GClass119.gclass66_7 = GClass126.smethod_35(Class13.smethod_0(149461));
    GClass119.gclass66_8 = GClass126.smethod_35(Class13.smethod_0(149441));
    GClass119.gclass66_9 = GClass126.smethod_35(Class13.smethod_0(149039));
    GClass119.gclass66_1 = GClass126.smethod_35(Class13.smethod_0(149119));
    GClass119.gclass66_11 = GClass126.smethod_35(Class13.smethod_0(149804));
    GClass119.gclass66_12 = GClass126.smethod_35(Class13.smethod_0(149780));
    GClass119.gclass66_13 = GClass126.smethod_35(Class13.smethod_0(149766));
    GClass119.gclass66_10 = GClass126.smethod_35(Class13.smethod_0(149880));
    GClass119.int_8 = Class15.smethod_0(90);
    GClass119.int_9 = Class15.smethod_0(558);
    GClass119.int_6 = GClass62.int_12 - (GClass119.int_8 + Class15.smethod_0(54)) / Class15.smethod_0(7);
    GClass119.int_7 = GClass62.int_13 - GClass119.int_9 / Class15.smethod_0(7);
    GClass119.int_12 = GClass119.int_6 + GClass119.int_8 - Class15.smethod_0(13);
    GClass119.int_13 = GClass119.int_7 + Class15.smethod_0(36);
    GClass119.int_14 = Class15.smethod_0(98);
    GClass119.int_16 = Class15.smethod_0(25);
    int[][] numArray1 = new int[Class15.smethod_0(5)][];
    int index1 = Class15.smethod_0(0);
    int[] numArray2 = new int[Class15.smethod_0(7)];
    numArray2[Class15.smethod_0(0)] = GClass119.int_6 + Class15.smethod_0(117);
    numArray2[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(108);
    numArray1[index1] = numArray2;
    int index2 = Class15.smethod_0(1);
    int[] numArray3 = new int[Class15.smethod_0(7)];
    numArray3[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - GClass119.gclass66_4.method_0() / Class15.smethod_0(7);
    numArray3[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 / Class15.smethod_0(7) + Class15.smethod_0(48);
    numArray1[index2] = numArray3;
    int index3 = Class15.smethod_0(7);
    int[] numArray4 = new int[Class15.smethod_0(7)];
    numArray4[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 - Class15.smethod_0(55);
    numArray4[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(108);
    numArray1[index3] = numArray4;
    GClass119.int_20 = numArray1;
    int[][] numArray5 = new int[Class15.smethod_0(3)][];
    int index4 = Class15.smethod_0(0);
    int[] numArray6 = new int[Class15.smethod_0(7)];
    numArray6[Class15.smethod_0(0)] = GClass119.int_6 + Class15.smethod_0(46);
    numArray6[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(257);
    numArray5[index4] = numArray6;
    int index5 = Class15.smethod_0(1);
    int[] numArray7 = new int[Class15.smethod_0(7)];
    numArray7[Class15.smethod_0(0)] = GClass119.int_6 + Class15.smethod_0(210);
    numArray7[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(106);
    numArray5[index5] = numArray7;
    int index6 = Class15.smethod_0(7);
    int[] numArray8 = new int[Class15.smethod_0(7)];
    numArray8[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - Class15.smethod_0(49);
    numArray8[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(68);
    numArray5[index6] = numArray8;
    int index7 = Class15.smethod_0(5);
    int[] numArray9 = new int[Class15.smethod_0(7)];
    numArray9[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 - Class15.smethod_0(210) - Class15.smethod_0(35);
    numArray9[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(106);
    numArray5[index7] = numArray9;
    int index8 = Class15.smethod_0(2);
    int[] numArray10 = new int[Class15.smethod_0(7)];
    numArray10[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 - Class15.smethod_0(46) - Class15.smethod_0(35);
    numArray10[Class15.smethod_0(1)] = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(257);
    numArray5[index8] = numArray10;
    GClass119.int_21 = numArray5;
    this.int_24 = new int[Class15.smethod_0(7)];
    this.int_23 = Class15.smethod_0(0);
    GClass119.int_10 = GClass119.int_6 + Class15.smethod_0(184);
    GClass119.int_11 = GClass119.int_7 + GClass119.int_9 / Class15.smethod_0(7) + Class15.smethod_0(3);
    GClass119.int_17 = GClass119.int_7 + GClass119.int_9 - Class15.smethod_0(28);
    int[] numArray11 = new int[Class15.smethod_0(5)];
    numArray11[Class15.smethod_0(0)] = GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - Class15.smethod_0(88) - Class15.smethod_0(25);
    numArray11[Class15.smethod_0(1)] = GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - Class15.smethod_0(88);
    numArray11[Class15.smethod_0(7)] = GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - Class15.smethod_0(88) + Class15.smethod_0(25);
    GClass119.int_18 = numArray11;
    GClass119.int_19 = new int[Class15.smethod_0(5)];
    this.int_34 = GClass119.int_13 + Class15.smethod_0(31) + Class15.smethod_0(152);
    this.int_35 = Class15.smethod_0(0);
    GClass119.gclass134_0 = new GClass134();
    GClass119.gclass134_1 = new GClass134();
    this.int_25 = Class15.smethod_0(1);
    this.int_26 = Class15.smethod_0(7);
  }

  public static GClass119 smethod_2()
  {
    if ((GClass119.gclass119_0 == null ? 0 : 1) == 0)
      GClass119.gclass119_0 = new GClass119();
    return GClass119.gclass119_0;
  }

  public void method_0(GClass134 list, int num, int numMax)
  {
    GClass119.gclass134_0 = list;
    GClass119.smethod_3(num, numMax);
    this.int_25 = Class15.smethod_0(1);
    this.int_27 = Class15.smethod_0(7);
    this.method_1();
    GClass119.bool_0 = Class15.smethod_0(1) != 0;
    GClass119.smethod_4();
    if ((!GClass119.bool_0 ? 1 : 0) == 0)
      this.int_26 = list.method_2() / Class15.smethod_0(3) + (list.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0));
    else
      this.int_26 = GClass119.gclass134_1.method_2() / Class15.smethod_0(3) + (GClass119.gclass134_1.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0));
  }

  public static void smethod_3(int num, int numMax)
  {
    GClass119.int_28 = num;
    GClass119.int_29 = numMax;
  }

  public static void smethod_4()
  {
    GClass119.gclass134_1 = new GClass134(string.Empty);
    for (int index = Class15.smethod_0(0); index < GClass119.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass75 o = (GClass75) GClass119.gclass134_0.method_3(index);
      if ((o == null ? 1 : 0) == 0 && (int) o.isUse == Class15.smethod_0(1))
        GClass119.gclass134_1.method_0((object) o);
    }
  }

  public void method_1()
  {
    GClass134 gclass134 = GClass119.gclass134_1;
    if ((!GClass119.bool_0 ? 1 : 0) == 0)
      gclass134 = GClass119.gclass134_0;
    int num1 = (this.int_25 - Class15.smethod_0(1)) * Class15.smethod_0(3);
    int num2 = num1 + Class15.smethod_0(3);
    for (int index = num1; index < num2; index += Class15.smethod_0(1))
    {
      if (index >= gclass134.method_2())
      {
        GClass119.int_22[index - num1] = -1;
      }
      else
      {
        GClass75 gclass75 = (GClass75) gclass134.method_3(index);
        if ((gclass75 == null ? 1 : 0) == 0)
          GClass119.int_22[index - num1] = gclass75.id;
      }
    }
    GClass119.int_15 = Class15.smethod_0(0);
    GClass119.int_16 = Class15.smethod_0(0);
    GClass172.smethod_1().method_55();
  }

  public override void vmethod_3()
  {
    try
    {
      if (GClass119.int_16 < Class15.smethod_0(25))
      {
        GClass119.int_16 += Class15.smethod_0(2);
        if (GClass119.int_16 > Class15.smethod_0(25))
          GClass119.int_16 = Class15.smethod_0(25);
      }
      this.gclass75_0 = GClass75.smethod_1(GClass119.gclass134_1, GClass119.int_22[this.int_27]);
      if ((!GClass119.bool_0 ? 1 : 0) == 0)
        this.gclass75_0 = GClass75.smethod_1(GClass119.gclass134_0, GClass119.int_22[this.int_27]);
      GClass116.smethod_6().vmethod_3();
      if (GClass62.int_8 % Class15.smethod_0(31) < Class15.smethod_0(37))
      {
        if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
          this.int_23 -= Class15.smethod_0(1);
      }
      else
        this.int_23 = Class15.smethod_0(0);
      if ((this.gclass75_0 == null ? 1 : 0) != 0)
        return;
      this.int_35 = (int) this.gclass75_0.amount * Class15.smethod_0(21) / (int) this.gclass75_0.max_amount * GClass119.gclass66_11.method_1() / Class15.smethod_0(21);
      this.int_33 = GClass119.int_28 * Class15.smethod_0(21) / GClass119.gclass134_0.method_2() * GClass119.gclass66_13.method_0() / Class15.smethod_0(21);
    }
    catch (Exception ex)
    {
      Debug.LogError((object) (Class13.smethod_0(149824) + ex.ToString()));
    }
  }

  public override void vmethod_4()
  {
    if ((!GClass71.bool_1 ? 0 : 1) != 0)
      return;
    if ((!GClass62.bool_5 ? 1 : 0) == 0 && (!GClass23.smethod_0().isShow ? 0 : 1) == 0 && (!GClass62.gclass95_0.showMenu ? 0 : 1) == 0)
      this.method_3();
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(0) != 0;
      this.method_7(Class15.smethod_0(1));
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(0) != 0;
      this.method_7(-1);
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(0) != 0;
      this.method_8(Class15.smethod_0(1));
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(0) != 0;
      this.method_8(Class15.smethod_0(0));
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
      this.method_4(Class15.smethod_0(1));
    }
    if ((!GClass62.bool_11[Class15.smethod_0(47)] ? 1 : 0) == 0)
      this.method_4(Class15.smethod_0(7));
    if ((!GClass62.bool_11[Class15.smethod_0(66)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(0) != 0;
      this.method_4(Class15.smethod_0(0));
    }
    GClass62.smethod_24();
  }

  private void method_2()
  {
    GClass119.bool_0 = (GClass119.bool_0 ? 1 : 0) == Class15.smethod_0(0);
    this.int_25 = Class15.smethod_0(1);
    this.int_27 = Class15.smethod_0(0);
    this.int_26 = (!GClass119.bool_0 ? 1 : 0) != 0 ? GClass119.gclass134_1.method_2() / Class15.smethod_0(3) + (GClass119.gclass134_1.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0)) : GClass119.gclass134_0.method_2() / Class15.smethod_0(3) + (GClass119.gclass134_0.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0));
    this.method_1();
  }

  private void method_3()
  {
    if ((!GClass62.bool_15 ? 1 : 0) == 0)
    {
      for (int int_36 = Class15.smethod_0(0); int_36 < Class15.smethod_0(3); int_36 += Class15.smethod_0(1))
      {
        if ((!GClass62.smethod_22(GClass119.int_21[int_36][Class15.smethod_0(0)], GClass119.int_21[int_36][Class15.smethod_0(1)], Class15.smethod_0(6), Class15.smethod_0(6)) ? 1 : 0) == 0 && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0 && int_36 != this.int_27)
          this.method_6(int_36);
      }
      if ((!GClass62.smethod_22(GClass119.int_20[Class15.smethod_0(0)][Class15.smethod_0(0)] - Class15.smethod_0(3), GClass119.int_20[Class15.smethod_0(0)][Class15.smethod_0(1)] - Class15.smethod_0(3), Class15.smethod_0(51), Class15.smethod_0(51)) ? 1 : 0) == 0)
      {
        if ((!GClass62.bool_14 ? 1 : 0) == 0)
          this.int_24[Class15.smethod_0(0)] = Class15.smethod_0(1);
        if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
        {
          this.method_5(Class15.smethod_0(0));
          this.int_24[Class15.smethod_0(0)] = Class15.smethod_0(0);
        }
      }
      if ((!GClass62.smethod_22(GClass119.int_20[Class15.smethod_0(7)][Class15.smethod_0(0)] - Class15.smethod_0(3), GClass119.int_20[Class15.smethod_0(7)][Class15.smethod_0(1)] - Class15.smethod_0(3), Class15.smethod_0(51), Class15.smethod_0(51)) ? 1 : 0) == 0)
      {
        if ((!GClass62.bool_14 ? 1 : 0) == 0)
          this.int_24[Class15.smethod_0(1)] = Class15.smethod_0(1);
        if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
        {
          this.method_5(Class15.smethod_0(1));
          this.int_24[Class15.smethod_0(1)] = Class15.smethod_0(0);
        }
      }
      for (int int_36 = Class15.smethod_0(0); int_36 < GClass119.int_18.Length; int_36 += Class15.smethod_0(1))
      {
        if ((!GClass62.smethod_22(GClass119.int_18[int_36] - Class15.smethod_0(3), GClass119.int_17 - Class15.smethod_0(3), Class15.smethod_0(51), Class15.smethod_0(51)) ? 1 : 0) == 0)
        {
          if ((!GClass62.bool_14 ? 1 : 0) == 0)
            GClass119.int_19[int_36] = Class15.smethod_0(1);
          if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          {
            this.method_4(int_36);
            GClass119.int_19[int_36] = Class15.smethod_0(0);
          }
        }
      }
    }
    else
    {
      GClass119.int_19[Class15.smethod_0(0)] = Class15.smethod_0(0);
      GClass119.int_19[Class15.smethod_0(1)] = Class15.smethod_0(0);
      GClass119.int_19[Class15.smethod_0(7)] = Class15.smethod_0(0);
      this.int_24[Class15.smethod_0(0)] = Class15.smethod_0(0);
      this.int_24[Class15.smethod_0(1)] = Class15.smethod_0(0);
    }
    if ((!GClass62.smethod_22(GClass119.int_12, Class15.smethod_0(0), GClass119.int_14, GClass119.int_13 + GClass119.int_16) ? 0 : 1) == 0)
      return;
    if ((!GClass62.bool_17 ? 1 : 0) == 0)
    {
      if ((this.int_31 == 0 ? 0 : 1) == 0)
        this.int_31 = GClass62.int_1;
      this.int_30 = this.int_31 - GClass62.int_1;
      if ((this.int_30 == 0 ? 1 : 0) == 0)
      {
        GClass119.int_15 += this.int_30;
        this.int_31 = GClass62.int_1;
      }
      if (GClass119.int_15 < Class15.smethod_0(0))
        GClass119.int_15 = Class15.smethod_0(0);
      if (GClass119.int_15 <= this.gclass75_0.cp.lim)
        return;
      GClass119.int_15 = this.gclass75_0.cp.lim;
    }
    else
    {
      this.int_31 = Class15.smethod_0(0);
      this.int_31 = Class15.smethod_0(0);
    }
  }

  private void method_4(int int_36)
  {
    switch (int_36)
    {
      case 0:
        this.method_2();
        break;
      case 1:
        if ((this.gclass75_0 == null ? 1 : 0) == 0)
        {
          GClass156.smethod_0().method_146(Class15.smethod_0(1), this.gclass75_0.id);
          break;
        }
        break;
      case 2:
        GClass116.smethod_6().vmethod_0();
        break;
    }
    GClass172.smethod_1().method_54();
  }

  private void method_5(int int_36)
  {
    this.int_26 = (!GClass119.bool_0 ? 1 : 0) != 0 ? GClass119.gclass134_1.method_2() / Class15.smethod_0(3) + (GClass119.gclass134_1.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0)) : GClass119.gclass134_0.method_2() / Class15.smethod_0(3) + (GClass119.gclass134_0.method_2() % Class15.smethod_0(3) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0));
    int int25 = this.int_25;
    int num;
    if ((int_36 == 0 ? 0 : 1) == 0)
    {
      if (this.int_25 == Class15.smethod_0(1))
        return;
      num = int25 - Class15.smethod_0(1);
      if (num < Class15.smethod_0(1))
        num = Class15.smethod_0(1);
    }
    else
    {
      if (this.int_25 == this.int_26)
        return;
      num = int25 + Class15.smethod_0(1);
      if (num > this.int_26)
        num = this.int_26;
    }
    if (num == this.int_25)
      return;
    this.int_25 = num;
    this.method_1();
  }

  private void method_6(int int_36)
  {
    this.int_27 = int_36;
    this.method_1();
  }

  private void method_7(int int_36)
  {
    GClass119.int_15 += Class15.smethod_0(66) * int_36;
    if (GClass119.int_15 < Class15.smethod_0(0))
      GClass119.int_15 = Class15.smethod_0(0);
    if (GClass119.int_15 <= this.gclass75_0.cp.lim)
      return;
    GClass119.int_15 = this.gclass75_0.cp.lim;
  }

  private void method_8(int int_36)
  {
    int int27 = this.int_27;
    int int25 = this.int_25;
    int num = (int_36 == 0 ? 0 : 1) != 0 ? int27 - Class15.smethod_0(1) : int27 + Class15.smethod_0(1);
    if (num >= GClass119.int_22.Length)
    {
      if (this.int_25 < this.int_26)
      {
        num = Class15.smethod_0(0);
        int25 += Class15.smethod_0(1);
      }
      else
        num = GClass119.int_22.Length - Class15.smethod_0(1);
    }
    if (num < Class15.smethod_0(0))
    {
      if (this.int_25 > Class15.smethod_0(1))
      {
        num = GClass119.int_22.Length - Class15.smethod_0(1);
        int25 -= Class15.smethod_0(1);
      }
      else
        num = Class15.smethod_0(0);
    }
    if (num != this.int_27)
    {
      this.int_27 = num;
      GClass119.int_15 = Class15.smethod_0(0);
      GClass119.int_16 = Class15.smethod_0(0);
    }
    if (int25 == this.int_25)
      return;
    this.int_25 = int25;
    this.method_1();
  }

  public override void vmethod_5(GClass98 g)
  {
    try
    {
      GClass116.smethod_6().vmethod_5(g);
      g.method_1(-GClass116.int_22, -GClass116.int_23);
      g.method_1(Class15.smethod_0(0), GClass62.int_52);
      GClass116.smethod_16(g);
      g.method_32(GClass119.gclass66_0, GClass119.int_6, GClass119.int_7, Class15.smethod_0(0));
      g.method_32(GClass119.gclass66_12, GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - GClass119.gclass66_12.method_0() / Class15.smethod_0(7), GClass119.int_7 - GClass119.gclass66_12.method_1() / Class15.smethod_0(7) - Class15.smethod_0(7), Class15.smethod_0(0));
      g.method_5(GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - GClass119.gclass66_12.method_0() / Class15.smethod_0(7) + Class15.smethod_0(47), GClass119.int_7 - GClass119.gclass66_12.method_1() / Class15.smethod_0(7) + Class15.smethod_0(5), this.int_33, GClass119.gclass66_12.method_1());
      g.method_32(GClass119.gclass66_13, GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7) - GClass119.gclass66_12.method_0() / Class15.smethod_0(7) + Class15.smethod_0(47), GClass119.int_7 - GClass119.gclass66_12.method_1() / Class15.smethod_0(7) + Class15.smethod_0(5), Class15.smethod_0(0));
      GClass116.smethod_16(g);
      g.method_32(GClass119.gclass66_9, GClass119.int_18[Class15.smethod_0(0)], GClass119.int_17 + GClass119.int_19[Class15.smethod_0(0)], Class15.smethod_0(0));
      g.method_32(GClass119.gclass66_6, GClass119.int_18[Class15.smethod_0(1)], GClass119.int_17 + GClass119.int_19[Class15.smethod_0(1)], Class15.smethod_0(0));
      g.method_32(GClass119.gclass66_8, GClass119.int_18[Class15.smethod_0(7)], GClass119.int_17 + GClass119.int_19[Class15.smethod_0(7)], Class15.smethod_0(0));
      if (GClass119.bool_0)
        g.method_24(GClass119.gclass66_7, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(186), Class15.smethod_0(186), Class15.smethod_0(0), GClass119.int_18[Class15.smethod_0(1)], GClass119.int_17 + GClass119.int_19[Class15.smethod_0(1)], Class15.smethod_0(0));
      else
        g.method_24(GClass119.gclass66_7, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(186), Class15.smethod_0(186), Class15.smethod_0(1), GClass119.int_18[Class15.smethod_0(1)], GClass119.int_17 + GClass119.int_19[Class15.smethod_0(1)], Class15.smethod_0(0));
      if (this.gclass75_0 != null)
      {
        g.method_5(GClass119.int_6 + Class15.smethod_0(6), GClass119.int_7 + Class15.smethod_0(47), GClass119.int_8 - Class15.smethod_0(4), GClass119.int_9 / Class15.smethod_0(7));
        this.gclass75_0.method_4(g, GClass119.int_10, GClass119.int_11);
        GClass116.smethod_16(g);
        GClass97.gclass97_4.method_6(g, ((int) this.gclass75_0.level <= Class15.smethod_0(0) ? Class13.smethod_0(149739) : Class13.smethod_0(149569) + this.gclass75_0.level.ToString() + Class13.smethod_0(149739)) + this.gclass75_0.name, GClass119.int_6 + GClass119.int_8 / Class15.smethod_0(7), GClass119.int_7 + Class15.smethod_0(9), Class15.smethod_0(7));
        GClass97.gclass97_20.method_6(g, Class13.smethod_0(149737) + this.gclass75_0.no.ToString(), GClass119.int_6 + Class15.smethod_0(6), GClass119.int_13 - Class15.smethod_0(7), Class15.smethod_0(0));
        g.method_32(GClass119.gclass66_10, GClass119.int_6 + Class15.smethod_0(86), GClass119.int_13 + Class15.smethod_0(31), Class15.smethod_0(0));
        g.method_5(GClass119.int_6 + Class15.smethod_0(86), this.int_34 - this.int_35, Class15.smethod_0(38), this.int_35);
        g.method_32(GClass119.gclass66_11, GClass119.int_6 + Class15.smethod_0(86), GClass119.int_13 + Class15.smethod_0(31), Class15.smethod_0(0));
        GClass116.smethod_16(g);
        g.method_32(GClass119.gclass66_14[(int) this.gclass75_0.rank], GClass119.int_6 + Class15.smethod_0(53) - Class15.smethod_0(3) + Class15.smethod_0(49), GClass119.int_13 + Class15.smethod_0(66), Class15.smethod_0(0));
      }
      g.method_5(GClass119.int_12, GClass119.int_13, GClass119.int_14 + Class15.smethod_0(3), GClass119.int_16 + Class15.smethod_0(88));
      if (this.gclass75_0 != null)
        g.method_32(GClass119.gclass66_1, GClass119.int_12, GClass119.int_13, Class15.smethod_0(0));
      GClass116.smethod_16(g);
      g.method_5(GClass119.int_12, GClass119.int_13 + Class15.smethod_0(1), GClass119.int_14, GClass119.int_16 + Class15.smethod_0(3));
      if (this.gclass75_0 != null && this.gclass75_0.cp != null)
      {
        if (this.gclass75_0.cp.says == null)
          return;
        this.gclass75_0.cp.method_0(g, GClass119.int_15);
      }
      GClass116.smethod_16(g);
      if (!GClass119.bool_0 && GClass119.gclass134_1.method_2() > Class15.smethod_0(3) || GClass119.bool_0)
      {
        if (this.int_25 > Class15.smethod_0(1))
          g.method_32(GClass119.gclass66_2, GClass119.int_20[Class15.smethod_0(0)][Class15.smethod_0(0)], GClass119.int_20[Class15.smethod_0(0)][Class15.smethod_0(1)] + this.int_24[Class15.smethod_0(0)], Class15.smethod_0(0));
        if (this.int_25 < this.int_26)
          g.method_32(GClass119.gclass66_3, GClass119.int_20[Class15.smethod_0(7)][Class15.smethod_0(0)], GClass119.int_20[Class15.smethod_0(7)][Class15.smethod_0(1)] + this.int_24[Class15.smethod_0(1)], Class15.smethod_0(0));
      }
      for (int index = Class15.smethod_0(0); index < GClass119.int_22.Length; index += Class15.smethod_0(1))
      {
        int num1 = Class15.smethod_0(0);
        int num2 = Class15.smethod_0(0);
        int idx = Class15.smethod_0(0);
        if (index == this.int_27)
        {
          num1 = this.int_23;
          num2 = Class15.smethod_0(136);
          idx = Class15.smethod_0(1);
          g.method_32(GClass119.gclass66_4, GClass119.int_21[index][Class15.smethod_0(0)] + Class15.smethod_0(31), GClass119.int_21[index][Class15.smethod_0(1)] + this.int_23 + Class15.smethod_0(36) + num2, Class15.smethod_0(0));
        }
        GClass75 gclass75 = GClass75.smethod_1(GClass119.gclass134_1, GClass119.int_22[index]);
        if (GClass119.bool_0)
          gclass75 = GClass75.smethod_1(GClass119.gclass134_0, GClass119.int_22[index]);
        if (gclass75 != null)
        {
          GClass119.gclass60_0.method_0((int) gclass75.rank, GClass119.int_21[index][Class15.smethod_0(0)], GClass119.int_21[index][Class15.smethod_0(1)] + num1 + num2, Class15.smethod_0(0), Class15.smethod_0(0), g);
          GClass169.smethod_6(g, gclass75.idIcon, GClass119.int_21[index][Class15.smethod_0(0)] + Class15.smethod_0(49), GClass119.int_21[index][Class15.smethod_0(1)] + Class15.smethod_0(49) + num1 + num2, Class15.smethod_0(0), GClass177.int_6);
          gclass75.method_8(g, GClass119.int_21[index][Class15.smethod_0(0)], GClass119.int_21[index][Class15.smethod_0(1)] + num1 + num2);
          if (gclass75.level == (sbyte) 0)
            g.method_32(GClass119.gclass66_5, GClass119.int_21[index][Class15.smethod_0(0)], GClass119.int_21[index][Class15.smethod_0(1)] + num1 + num2, Class15.smethod_0(0));
          if (index == this.int_27)
            GClass119.gclass60_0.method_0(Class15.smethod_0(38), GClass119.int_21[index][Class15.smethod_0(0)], GClass119.int_21[index][Class15.smethod_0(1)] + num1 + num2, Class15.smethod_0(0), Class15.smethod_0(0), g);
          if ((int) gclass75.isUse == Class15.smethod_0(1))
            GClass119.gclass60_0.method_0(Class15.smethod_0(88), GClass119.int_21[index][Class15.smethod_0(0)], GClass119.int_21[index][Class15.smethod_0(1)] + num1 + num2, Class15.smethod_0(0), Class15.smethod_0(0), g);
        }
        else
          GClass119.gclass60_1.method_0(idx, GClass119.int_21[index][Class15.smethod_0(0)] - Class15.smethod_0(1), GClass119.int_21[index][Class15.smethod_0(1)] - Class15.smethod_0(1) + num1 + num2, Class15.smethod_0(0), Class15.smethod_0(0), g);
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) (Class13.smethod_0(149713) + ex.ToString()));
    }
  }

  public override void vmethod_0()
  {
    GClass116.bool_0 = Class15.smethod_0(1) != 0;
    base.vmethod_0();
  }

  static GClass119()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.dYcwFKlcdStx));
    GClass119.int_22 = (int[]) Class15.smethod_4(byte_0);
  }
}
