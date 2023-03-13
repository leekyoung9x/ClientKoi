// Decompiled with JetBrains decompiler
// Type: GClass120
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass120 : GClass113, GInterface0
{
  public static string[] string_0;
  public static string[] string_1;
  public static sbyte sbyte_0;
  public static bool[] bool_0;
  public static short[] short_0;
  public static int int_6;
  public static bool bool_1;
  public static GClass31 gclass31_0;
  public static sbyte[] sbyte_1;
  private GClass31[] gclass31_1;
  private GClass31 gclass31_2;
  private int int_7;
  public static GClass31 gclass31_3;
  private int int_8;
  public static string string_2 = Class13.smethod_0(144491);
  public static string string_3 = Class13.smethod_0(145112);
  public static string string_4 = Class13.smethod_0(145535);
  public static string string_5 = Class13.smethod_0(145498);
  public static string string_6 = Class13.smethod_0(145595);
  public static string string_7 = Class13.smethod_0(145552);
  public static string string_8 = Class13.smethod_0(145643);
  public static string string_9 = GClass120.string_3;
  public const sbyte sbyte_2 = 2;
  public int keyTouch = -1;
  private int int_9;
  public static bool bool_2;
  public static string string_10 = Class13.smethod_0(146230);
  public static bool bool_3;
  public static int int_10;
  public static int[] int_11 = new int[Class15.smethod_0(5)];
  public static int int_12;
  public static int int_13;
  public static bool bool_4;
  public static int int_14;
  public static string string_11;
  public static int int_15;
  public static int int_16;
  public static int int_17;
  public static int int_18;
  public static bool bool_5 = Class15.smethod_0(0) != 0;
  public static GClass31 gclass31_4;
  private GClass31 gclass31_5;
  public string dataSize;
  public static int int_19;
  public static int int_20 = -1;
  public static bool bool_6;

  public GClass120()
  {
    int num1 = Class15.smethod_0(2);
    if (num1 * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48) >= GClass62.int_10)
    {
      int num2 = num1 - Class15.smethod_0(1);
    }
    this.method_0();
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
    {
      GClass120.int_6 = Class15.smethod_0(0);
      this.method_2();
    }
    GClass116.smethod_8(Class15.smethod_0(1) != 0, -1, -1);
    GClass116.int_22 = Class15.smethod_0(21);
    GClass116.int_23 = Class15.smethod_0(90);
    if ((this.gclass31_2 == null ? 0 : 1) == 0)
    {
      this.gclass31_2 = new GClass31(Class13.smethod_0(148193), (GInterface0) this, Class15.smethod_0(47), (object) null);
      this.gclass31_2.x = GClass62.int_10 - Class15.smethod_0(62);
      this.gclass31_2.y = GClass126.int_0 != Class15.smethod_0(1) || (!GClass62.bool_5 ? 0 : 1) != 0 ? Class15.smethod_0(7) + Class15.smethod_0(37) : GClass62.int_11 - Class15.smethod_0(51);
    }
    GClass120.gclass31_0 = new GClass31();
    GClass31 gclass310 = GClass120.gclass31_0;
    // ISSUE: reference to a compiler-generated field
    GDelegate0 gdelegate0 = GClass120.\u003C\u003Ec.\u003C\u003E9__46_0;
    if ((gdelegate0 == null ? 0 : 1) == 0)
    {
      // ISSUE: reference to a compiler-generated field
      gdelegate0 = GClass120.\u003C\u003Ec.\u003C\u003E9__46_0 = (GDelegate0) (string_0 =>
      {
        string str1 = string_0;
        string str2 = string_0;
        if ((str1 == null ? 0 : 1) == 0)
        {
          string string9 = GClass120.string_9;
        }
        else
        {
          if ((str1 == null ? 0 : 1) == 0 && (str2 == null ? 1 : 0) == 0)
          {
            if ((!str2.Equals(string.Empty) ? 0 : 1) != 0 || str2.Length < Class15.smethod_0(51))
              str2 = GClass120.string_9;
            GClass120.smethod_4(str2);
          }
          if ((str1 == null ? 1 : 0) == 0 && (str2 == null ? 0 : 1) == 0)
          {
            if ((!str1.Equals(string.Empty) ? 0 : 1) != 0 || str1.Length < Class15.smethod_0(51))
              str1 = GClass120.string_9;
            GClass120.smethod_4(str1);
          }
          if ((str1 == null ? 1 : 0) != 0 || (str2 == null ? 1 : 0) != 0)
            return;
          if (str1.Length > str2.Length)
            GClass120.smethod_4(str1);
          else
            GClass120.smethod_4(str2);
        }
      });
    }
    gclass310.actionChat = gdelegate0;
    this.method_8(GClass126.sbyte_0);
  }

  public static void smethod_2()
  {
    if ((GClass120.gclass31_3 == null ? 0 : 1) != 0)
      return;
    if ((GClass62.gclass120_0 == null ? 0 : 1) == 0)
      GClass62.gclass120_0 = new GClass120();
    GClass120.gclass31_3 = new GClass31(string.Empty, (GInterface0) GClass62.gclass120_0, Class15.smethod_0(49), (object) null);
    GClass120.gclass31_3.x = GClass62.int_10 - Class15.smethod_0(63);
    GClass120.gclass31_3.y = GClass62.int_11 - Class15.smethod_0(50);
  }

  private void method_0()
  {
    this.int_7 = Class15.smethod_0(0);
    string str = GClass152.smethod_2(Class13.smethod_0(148906));
    if ((str == null ? 0 : 1) == 0)
    {
      if ((GClass152.smethod_1(Class13.smethod_0(148875) + GClass120.int_12.ToString()) == null ? 1 : 0) == 0)
        this.int_7 = Class15.smethod_0(1);
    }
    else if ((!str.Equals(string.Empty) ? 1 : 0) == 0)
    {
      if ((GClass152.smethod_1(Class13.smethod_0(148875) + GClass120.int_12.ToString()) == null ? 1 : 0) == 0)
        this.int_7 = Class15.smethod_0(1);
    }
    else
      this.int_7 = Class15.smethod_0(1);
    this.gclass31_1 = new GClass31[GClass98.int_8 <= Class15.smethod_0(1) ? Class15.smethod_0(2) + this.int_7 : Class15.smethod_0(5) + this.int_7];
    int num = GClass62.int_13 - Class15.smethod_0(9) * this.gclass31_1.Length + Class15.smethod_0(35);
    for (int index = Class15.smethod_0(0); index < this.gclass31_1.Length; index += Class15.smethod_0(1))
    {
      switch (index)
      {
        case 0:
          this.gclass31_1[Class15.smethod_0(0)] = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(5), (object) null);
          if ((str == null ? 0 : 1) == 0)
          {
            this.gclass31_1[Class15.smethod_0(0)].caption = GClass109.string_431;
            if ((GClass152.smethod_1(Class13.smethod_0(148875) + GClass120.int_12.ToString()) == null ? 1 : 0) == 0)
            {
              this.gclass31_1[Class15.smethod_0(0)].caption = GClass109.string_13;
              break;
            }
            break;
          }
          if ((!str.Equals(string.Empty) ? 1 : 0) == 0)
          {
            this.gclass31_1[Class15.smethod_0(0)].caption = GClass109.string_431;
            if ((GClass152.smethod_1(Class13.smethod_0(148875) + GClass120.int_12.ToString()) == null ? 1 : 0) == 0)
            {
              this.gclass31_1[Class15.smethod_0(0)].caption = GClass109.string_13;
              break;
            }
            break;
          }
          this.gclass31_1[Class15.smethod_0(0)].caption = GClass109.string_432 + Class13.smethod_0(149294) + str;
          if (this.gclass31_1[Class15.smethod_0(0)].caption.Length > Class15.smethod_0(29))
          {
            this.gclass31_1[Class15.smethod_0(0)].caption = this.gclass31_1[Class15.smethod_0(0)].caption.Substring(Class15.smethod_0(0), Class15.smethod_0(29));
            this.gclass31_1[Class15.smethod_0(0)].caption += Class13.smethod_0(149264);
            break;
          }
          break;
        case 1:
          if (this.int_7 == Class15.smethod_0(1))
          {
            this.gclass31_1[Class15.smethod_0(1)] = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(562), (object) null);
            this.gclass31_1[Class15.smethod_0(1)].caption = GClass109.string_431;
            break;
          }
          this.gclass31_1[Class15.smethod_0(1)] = new GClass31(GClass109.string_46, (GInterface0) this, Class15.smethod_0(38), (object) null);
          break;
        case 2:
          this.gclass31_1[Class15.smethod_0(7)] = this.int_7 != Class15.smethod_0(1) ? new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(186), (object) null) : new GClass31(GClass109.string_46, (GInterface0) this, Class15.smethod_0(38), (object) null);
          break;
        case 3:
          this.gclass31_1[Class15.smethod_0(5)] = this.int_7 != Class15.smethod_0(1) ? new GClass31(GClass109.string_179, (GInterface0) this, Class15.smethod_0(88), (object) null) : new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(186), (object) null);
          break;
        case 4:
          this.gclass31_1[Class15.smethod_0(2)] = new GClass31(GClass109.string_179, (GInterface0) this, Class15.smethod_0(88), (object) null);
          break;
      }
      this.gclass31_1[index].y = num;
      this.gclass31_1[index].method_2();
      this.gclass31_1[index].x = (GClass62.int_10 - this.gclass31_1[index].w) / Class15.smethod_0(7);
      num += Class15.smethod_0(6);
    }
  }

  public static void smethod_3()
  {
    if ((GClass120.gclass31_0 == null ? 0 : 1) == 0 && (GClass62.gclass120_0 == null ? 0 : 1) == 0)
      GClass62.gclass120_0 = new GClass120();
    Class3.smethod_2(GClass120.string_9, GClass120.gclass31_0);
  }

  public static void smethod_4(string str)
  {
    GClass120.int_11 = new int[Class15.smethod_0(5)];
    string[] strArray1 = GClass151.smethod_27(str.Trim(), Class13.smethod_0(149043), Class15.smethod_0(0));
    GClass151.smethod_7(Class13.smethod_0(149724) + strArray1.Length.ToString());
    GClass109.smethod_1(sbyte.Parse(strArray1[strArray1.Length - Class15.smethod_0(7)]));
    GClass120.string_0 = new string[strArray1.Length - Class15.smethod_0(7)];
    GClass120.string_1 = new string[strArray1.Length - Class15.smethod_0(7)];
    GClass120.short_0 = new short[strArray1.Length - Class15.smethod_0(7)];
    GClass120.sbyte_1 = new sbyte[strArray1.Length - Class15.smethod_0(7)];
    GClass120.bool_0 = new bool[Class15.smethod_0(7)];
    for (int index = Class15.smethod_0(0); index < strArray1.Length - Class15.smethod_0(7); index += Class15.smethod_0(1))
    {
      string[] strArray2 = GClass151.smethod_27(strArray1[index].Trim(), Class13.smethod_0(150059), Class15.smethod_0(0));
      GClass120.string_0[index] = strArray2[Class15.smethod_0(0)];
      GClass120.string_1[index] = strArray2[Class15.smethod_0(1)];
      GClass120.short_0[index] = short.Parse(strArray2[Class15.smethod_0(7)]);
      GClass120.sbyte_1[index] = sbyte.Parse(strArray2[Class15.smethod_0(5)].Trim());
      GClass120.int_11[(int) GClass120.sbyte_1[index]] += Class15.smethod_0(1);
    }
    GClass120.sbyte_0 = sbyte.Parse(strArray1[strArray1.Length - Class15.smethod_0(1)]);
    GClass120.smethod_6();
    GClass62.smethod_27();
  }

  public override void vmethod_5(GClass98 g)
  {
    if ((!GClass120.bool_6 ? 0 : 1) == 0)
    {
      g.method_16(Class15.smethod_0(0));
      g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
      if ((!GClass120.bool_4 ? 1 : 0) != 0)
        ;
    }
    else
      GClass62.smethod_16(g);
    int y1 = Class15.smethod_0(7);
    GClass97.gclass97_20.method_10(g, Class13.smethod_0(150037) + GClass13.gclass13_0.method_45(), GClass62.int_10 - Class15.smethod_0(7), y1 + Class15.smethod_0(9), Class15.smethod_0(1), GClass97.gclass97_16);
    if ((!GClass120.bool_5 ? 1 : 0) == 0 && (!GClass120.bool_6 ? 1 : 0) != 0)
      GClass97.gclass97_20.method_10(g, GClass13.gclass13_0.method_44(), GClass62.int_10 - Class15.smethod_0(7), y1, Class15.smethod_0(1), GClass97.gclass97_16);
    else if (GClass126.int_0 == Class15.smethod_0(1) && (!GClass62.bool_5 ? 0 : 1) == 0)
      GClass97.gclass97_20.method_10(g, GClass13.gclass13_0.method_44(), GClass62.int_10 - Class15.smethod_0(7), GClass62.int_11 - Class15.smethod_0(9), Class15.smethod_0(1), GClass97.gclass97_16);
    else
      GClass97.gclass97_20.method_10(g, GClass13.gclass13_0.method_44(), GClass62.int_10 - Class15.smethod_0(7), y1, Class15.smethod_0(1), GClass97.gclass97_16);
    Class15.smethod_0(90);
    if ((GClass120.gclass31_3 == null ? 1 : 0) == 0)
      GClass97.gclass97_20.method_10(g, GClass109.string_429, GClass62.int_10 - Class15.smethod_0(7), GClass62.int_11 - Class15.smethod_0(9), Class15.smethod_0(1), GClass97.gclass97_16);
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      if ((!GClass120.bool_6 ? 0 : 1) == 0)
      {
        if ((!GClass120.bool_4 ? 0 : 1) == 0)
        {
          g.method_32(GClass117.gclass66_0, GClass62.int_12, GClass62.int_13 - Class15.smethod_0(120), Class15.smethod_0(5));
          if ((!GClass120.bool_5 ? 0 : 1) == 0)
          {
            GClass97.gclass97_3.method_6(g, GClass109.string_426, GClass62.int_12, GClass62.int_13 + Class15.smethod_0(40), Class15.smethod_0(7));
            if ((GClass120.gclass31_4 == null ? 1 : 0) == 0)
              GClass120.gclass31_4.method_3(g);
          }
          else
          {
            if ((GClass120.gclass31_4 == null ? 1 : 0) == 0)
              GClass120.gclass31_4.method_3(g);
            GClass97.gclass97_3.method_6(g, GClass109.string_87 + GClass120.int_14.ToString() + Class13.smethod_0(150035), GClass62.int_10 / Class15.smethod_0(7), GClass62.int_13 + Class15.smethod_0(40), Class15.smethod_0(7));
            GClass116.smethod_3(GClass116.gclass66_4, GClass116.gclass66_5, GClass116.gclass66_6, (float) (GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(32)), (float) (GClass62.int_13 + Class15.smethod_0(70)), Class15.smethod_0(21), Class15.smethod_2(25), g);
            GClass116.smethod_3(GClass116.gclass66_1, GClass116.gclass66_2, GClass116.gclass66_3, (float) (GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(32)), (float) (GClass62.int_13 + Class15.smethod_0(70)), Class15.smethod_0(21), (float) GClass120.int_14, g);
          }
        }
      }
      else
      {
        int y2 = GClass62.int_13 - Class15.smethod_0(9) * this.gclass31_1.Length - Class15.smethod_0(9);
        if (y2 < Class15.smethod_0(46))
          y2 = Class15.smethod_0(46);
        g.method_32(GClass13.gclass13_0.method_37(), GClass62.int_12, y2, Class15.smethod_0(5));
        for (int index = Class15.smethod_0(0); index < this.gclass31_1.Length; index += Class15.smethod_0(1))
          this.gclass31_1[index].method_3(g);
        g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
        if (GClass120.int_20 == -1)
        {
          if (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31))
            g.method_24(GClass116.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(49), Class15.smethod_0(38), Class15.smethod_0(38), Class15.smethod_0(0), (GClass62.int_10 - GClass97.gclass97_6.method_17(this.gclass31_1[Class15.smethod_0(7) + this.int_7].caption) >> Class15.smethod_0(1)) - Class15.smethod_0(31), this.gclass31_1[Class15.smethod_0(7) + this.int_7].y + Class15.smethod_0(31), Class15.smethod_0(0));
        }
        else
          g.method_24(GClass116.gclass66_0, Class15.smethod_0(0), GClass120.int_20 * Class15.smethod_0(38), Class15.smethod_0(38), Class15.smethod_0(38), Class15.smethod_0(0), (GClass62.int_10 - GClass97.gclass97_6.method_17(this.gclass31_1[Class15.smethod_0(7) + this.int_7].caption) >> Class15.smethod_0(1)) - Class15.smethod_0(31), this.gclass31_1[Class15.smethod_0(7) + this.int_7].y + Class15.smethod_0(45), Class15.smethod_0(0));
      }
    }
    base.vmethod_5(g);
  }

  public void method_1()
  {
    GClass120.int_13 = Class15.smethod_0(6);
    GClass62.smethod_29(GClass109.string_83);
    if ((!GClass157.smethod_0().imethod_0() ? 1 : 0) == 0)
      GClass157.smethod_0().imethod_4();
    GClass63.string_0 = GClass120.string_1[GClass120.int_12];
    GClass63.int_0 = (int) GClass120.short_0[GClass120.int_12];
    if ((int) GClass120.sbyte_1[GClass120.int_12] != (int) GClass109.sbyte_0)
      GClass109.smethod_1(GClass120.sbyte_1[GClass120.int_12]);
    GClass117.string_1 = GClass120.string_0[GClass120.int_12];
    this.method_0();
    GClass62.smethod_4();
  }

  public override void vmethod_3()
  {
    if ((!GClass120.bool_3 ? 1 : 0) == 0)
    {
      GClass120.int_10 += Class15.smethod_0(1);
      if (GClass120.int_10 == Class15.smethod_0(32))
        GClass62.gclass120_0.method_1();
      if (GClass120.int_10 == Class15.smethod_0(21))
      {
        if ((GClass62.gclass117_0 == null ? 0 : 1) == 0)
          GClass62.gclass117_0 = new GClass117();
        GClass62.gclass117_0.method_9();
        GClass156.smethod_0().method_116();
        GClass120.bool_3 = Class15.smethod_0(0) != 0;
      }
    }
    if (GClass120.int_13 > Class15.smethod_0(0))
    {
      GClass120.int_13 -= Class15.smethod_0(1);
      if ((GClass120.int_13 == 0 ? 0 : 1) == 0)
        GClass62.smethod_27();
    }
    for (int index = Class15.smethod_0(0); index < this.gclass31_1.Length; index += Class15.smethod_0(1))
      this.gclass31_1[index].isFocus = index != GClass120.int_6 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    GClass116.int_22 += Class15.smethod_0(1);
    if ((!GClass120.bool_6 ? 0 : 1) == 0 && ((!GClass120.bool_4 ? 0 : 1) != 0 || GClass120.int_14 == Class15.smethod_0(21)))
      GClass120.gclass31_4 = (GClass31) null;
    base.vmethod_3();
  }

  private void method_2()
  {
    if ((!GClass120.bool_6 ? 1 : 0) == 0)
      this.center = new GClass31(string.Empty, (GInterface0) this, this.gclass31_1[GClass120.int_6].idAction, (object) null);
    else
      this.center = GClass120.gclass31_4;
  }

  public static void smethod_5()
  {
    if ((GClass120.gclass31_3 == null ? 1 : 0) != 0 || (!GClass120.gclass31_3.method_4() ? 1 : 0) != 0)
      return;
    GClass120.gclass31_3.method_1();
  }

  public override void vmethod_4()
  {
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      GClass120.smethod_5();
      if ((this.gclass31_2 == null ? 1 : 0) == 0 && (!this.gclass31_2.method_4() ? 1 : 0) == 0)
        this.gclass31_2.method_1();
      if ((!GClass120.bool_6 ? 0 : 1) == 0)
      {
        if ((GClass120.gclass31_4 == null ? 1 : 0) == 0 && (!GClass120.gclass31_4.method_4() ? 1 : 0) == 0)
          GClass120.gclass31_4.method_1();
        base.vmethod_4();
        return;
      }
      for (int index = Class15.smethod_0(0); index < this.gclass31_1.Length; index += Class15.smethod_0(1))
      {
        if ((this.gclass31_1[index] == null ? 1 : 0) == 0 && (!this.gclass31_1[index].method_4() ? 1 : 0) == 0)
          this.gclass31_1[index].method_1();
      }
    }
    else if ((!GClass120.bool_6 ? 1 : 0) == 0)
    {
      if ((!GClass62.bool_11[Class15.smethod_0(88)] ? 1 : 0) == 0)
      {
        int num = GClass98.int_8 <= Class15.smethod_0(1) ? Class15.smethod_0(2) : Class15.smethod_0(7);
        GClass62.bool_11[Class15.smethod_0(88)] = Class15.smethod_0(0) != 0;
        GClass120.int_6 += Class15.smethod_0(1);
        if (GClass120.int_6 > num)
          GClass120.int_6 = Class15.smethod_0(0);
        this.method_2();
      }
      if ((!GClass62.bool_11[Class15.smethod_0(7)] ? 1 : 0) == 0)
      {
        int num = GClass98.int_8 <= Class15.smethod_0(1) ? Class15.smethod_0(2) : Class15.smethod_0(7);
        GClass62.bool_11[Class15.smethod_0(7)] = Class15.smethod_0(0) != 0;
        GClass120.int_6 -= Class15.smethod_0(1);
        if (GClass120.int_6 < Class15.smethod_0(0))
          GClass120.int_6 = num;
        this.method_2();
      }
    }
    if ((!GClass120.bool_1 ? 0 : 1) != 0)
      return;
    base.vmethod_4();
  }

  public static void smethod_6()
  {
    GClass36 gclass36 = new GClass36();
    try
    {
      gclass36.method_5(GClass109.sbyte_0);
      gclass36.method_5((sbyte) GClass120.string_0.Length);
      for (int index = Class15.smethod_0(0); index < GClass120.string_0.Length; index += Class15.smethod_0(1))
      {
        gclass36.method_6(GClass120.string_0[index]);
        gclass36.method_6(GClass120.string_1[index]);
        gclass36.method_0(GClass120.short_0[index]);
        gclass36.method_5(GClass120.sbyte_1[index]);
      }
      gclass36.method_5(GClass120.sbyte_0);
      GClass152.smethod_0(Class13.smethod_0(150930), gclass36.method_3());
      gclass36.method_4();
      GClass122.smethod_3();
    }
    catch (Exception ex)
    {
    }
  }

  public static bool smethod_7()
  {
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(7); index += Class15.smethod_0(1))
    {
      if ((!GClass120.bool_0[index] ? 0 : 1) == 0)
        return Class15.smethod_0(0) != 0;
    }
    return Class15.smethod_0(1) != 0;
  }

  public static void smethod_8()
  {
    sbyte[] data = GClass152.smethod_1(Class13.smethod_0(151010));
    if ((data == null ? 0 : 1) == 0)
    {
      GClass120.smethod_4(GClass120.string_9);
    }
    else
    {
      GClass35 gclass35 = new GClass35(data);
      if ((gclass35 == null ? 0 : 1) == 0)
        return;
      try
      {
        GClass120.int_11 = new int[Class15.smethod_0(5)];
        GClass109.smethod_1(gclass35.method_7());
        sbyte length = gclass35.method_7();
        GClass120.string_0 = new string[(int) length];
        GClass120.string_1 = new string[(int) length];
        GClass120.short_0 = new short[(int) length];
        GClass120.sbyte_1 = new sbyte[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
        {
          GClass120.string_0[index] = gclass35.method_6();
          GClass120.string_1[index] = gclass35.method_6();
          GClass120.short_0[index] = gclass35.method_0();
          GClass120.sbyte_1[index] = gclass35.method_7();
          GClass120.int_11[(int) GClass120.sbyte_1[index]] += Class15.smethod_0(1);
        }
        GClass120.sbyte_0 = gclass35.method_7();
        gclass35.method_4();
        GClass122.smethod_3();
      }
      catch (Exception ex)
      {
      }
    }
  }

  public override void vmethod_0()
  {
    GClass62.smethod_4();
    GClass116.int_23 = Class15.smethod_0(0);
    GClass116.int_22 = Class15.smethod_0(0);
    this.method_0();
    GClass120.bool_1 = Class15.smethod_0(0) != 0;
    GClass62.gclass117_0 = (GClass117) null;
    string s = GClass152.smethod_2(Class13.smethod_0(150589));
    if (((s == null ? 1 : 0) != 0 || (!(s != string.Empty) ? 1 : 0) != 0 ? -1 : int.Parse(s)) > Class15.smethod_0(0))
    {
      GClass120.bool_6 = Class15.smethod_0(1) != 0;
      GClass62.smethod_19(Class15.smethod_0(0));
    }
    GClass120.bool_4 = Class15.smethod_0(1) != 0;
    this.gclass31_1[Class15.smethod_0(7) + this.int_7].caption = GClass109.string_96 + Class13.smethod_0(143658) + GClass120.string_0[GClass120.int_12];
    this.center = new GClass31(string.Empty, (GInterface0) this, this.gclass31_1[GClass120.int_6].idAction, (object) null);
    this.gclass31_1[Class15.smethod_0(1) + this.int_7].caption = GClass109.string_46;
    if (this.gclass31_1.Length == Class15.smethod_0(2) + this.int_7)
      this.gclass31_1[Class15.smethod_0(5) + this.int_7].caption = GClass109.string_179;
    GClass126.smethod_0();
    base.vmethod_0();
  }

  public void method_3()
  {
    GClass116.int_23 = Class15.smethod_0(0);
    GClass116.int_22 = Class15.smethod_0(0);
    this.method_0();
    GClass120.bool_1 = Class15.smethod_0(0) != 0;
    GClass62.gclass117_0 = (GClass117) null;
    string s = GClass152.smethod_2(Class13.smethod_0(143647));
    if (((s == null ? 1 : 0) != 0 || (!(s != string.Empty) ? 1 : 0) != 0 ? -1 : int.Parse(s)) > Class15.smethod_0(0))
    {
      GClass120.bool_6 = Class15.smethod_0(1) != 0;
      GClass62.smethod_19(Class15.smethod_0(0));
    }
    GClass120.bool_4 = Class15.smethod_0(1) != 0;
    this.gclass31_1[Class15.smethod_0(7) + this.int_7].caption = GClass109.string_96 + Class13.smethod_0(143624) + GClass120.string_0[GClass120.int_12];
    this.center = new GClass31(string.Empty, (GInterface0) this, this.gclass31_1[GClass120.int_6].idAction, (object) null);
    this.gclass31_1[Class15.smethod_0(1) + this.int_7].caption = GClass109.string_46;
    if (this.gclass31_1.Length == Class15.smethod_0(2) + this.int_7)
      this.gclass31_1[Class15.smethod_0(5) + this.int_7].caption = GClass109.string_179;
    GClass126.smethod_0();
    base.vmethod_0();
  }

  public void method_4()
  {
  }

  public void method_5()
  {
    if ((GClass62.gclass120_0 == null ? 0 : 1) == 0)
      GClass62.gclass120_0 = new GClass120();
    GClass120.int_17 = Class15.smethod_0(0);
    GClass120.int_14 = Class15.smethod_0(0);
    GClass120.bool_2 = Class15.smethod_0(1) != 0;
    GClass62.gclass120_0.method_7();
    GClass120.bool_5 = Class15.smethod_0(0) != 0;
    GClass120.gclass31_4.isFocus = Class15.smethod_0(1) != 0;
    this.center = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(7), (object) null);
  }

  public void imethod_0(int idAction, object p)
  {
    GClass151.smethod_7(Class13.smethod_0(143369) + idAction.ToString());
    if (idAction == Class15.smethod_0(15))
      GClass62.smethod_4();
    if (idAction == Class15.smethod_0(1) || idAction == Class15.smethod_0(2))
      this.method_5();
    if (idAction == Class15.smethod_0(7))
    {
      GClass120.bool_2 = Class15.smethod_0(0) != 0;
      GClass120.gclass31_4 = new GClass31(GClass109.string_427, (GInterface0) this, Class15.smethod_0(2), (object) null);
      GClass120.gclass31_4.x = GClass62.int_10 / Class15.smethod_0(7) - GClass113.int_2 / Class15.smethod_0(7);
      GClass120.gclass31_4.y = GClass62.int_13 + Class15.smethod_0(130);
      this.right = (GClass31) null;
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
      {
        GClass120.gclass31_4.x = GClass62.int_10 / Class15.smethod_0(7) - GClass113.int_2 / Class15.smethod_0(7);
        GClass120.gclass31_4.y = GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(1);
      }
      this.center = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(2), (object) null);
      if ((!GClass120.bool_5 ? 0 : 1) == 0)
      {
        GClass156.smethod_0().method_125((sbyte) Class15.smethod_0(1), (GClass134) null);
        if ((!GClass62.bool_5 ? 0 : 1) == 0)
        {
          GClass120.gclass31_4.isFocus = Class15.smethod_0(1) != 0;
          this.center = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(2), (object) null);
        }
        GClass120.bool_5 = Class15.smethod_0(1) != 0;
      }
    }
    if (idAction == Class15.smethod_0(5))
    {
      GClass151.smethod_7(Class13.smethod_0(143473));
      if ((GClass62.gclass117_0 == null ? 0 : 1) == 0)
        GClass62.gclass117_0 = new GClass117();
      GClass62.gclass117_0.vmethod_0();
      int num = (GClass152.smethod_2(Class13.smethod_0(143432)) == null ? 1 : 0) != 0 ? Class15.smethod_0(0) : ((!GClass152.smethod_2(Class13.smethod_0(143432)).Equals(string.Empty) ? 1 : 0) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
      bool flag = (GClass152.smethod_2(Class13.smethod_0(143528) + GClass120.int_12.ToString()) == null ? 1 : 0) != 0 ? Class15.smethod_0(0) != 0 : ((!GClass152.smethod_2(Class13.smethod_0(143528) + GClass120.int_12.ToString()).Equals(string.Empty) ? 1 : 0) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0);
      if ((num == 0 ? 0 : 1) == 0 && (!flag ? 0 : 1) == 0)
      {
        GClass62.smethod_4();
        string username = GClass152.smethod_2(Class13.smethod_0(143528) + GClass120.int_12.ToString());
        if ((username == null ? 1 : 0) == 0 && (!username.Equals(string.Empty) ? 1 : 0) != 0)
        {
          GClass62.gclass117_0.isLogin2 = Class15.smethod_0(1) != 0;
          GClass62.smethod_4();
          GClass156.smethod_0().method_35();
          GClass156.smethod_0().method_39(username, string.Empty, GClass63.string_2, (sbyte) Class15.smethod_0(1));
        }
        else
          GClass156.smethod_0().method_122(string.Empty);
        if ((!GClass157.bool_1 ? 1 : 0) == 0)
          GClass62.smethod_31();
        else
          GClass62.smethod_28(GClass109.string_20);
      }
      else
        GClass62.gclass117_0.method_9();
      GClass117.string_1 = GClass120.string_0[GClass120.int_12];
    }
    if (idAction == Class15.smethod_0(562))
    {
      if ((GClass62.gclass117_0 == null ? 0 : 1) == 0)
        GClass62.gclass117_0 = new GClass117();
      GClass62.gclass117_0.vmethod_0();
      GClass62.smethod_4();
      GClass156.smethod_0().method_122(string.Empty);
      GClass151.smethod_7(Class13.smethod_0(143521));
      GClass62.smethod_31();
      GClass117.string_1 = GClass120.string_0[GClass120.int_12];
    }
    if (idAction == Class15.smethod_0(3))
    {
      GClass120.smethod_3();
      if (GClass120.string_0.Length == Class15.smethod_0(1))
        return;
      GClass134 menuItems = new GClass134(string.Empty);
      for (int index = Class15.smethod_0(0); index < GClass120.string_0.Length; index += Class15.smethod_0(1))
        menuItems.method_0((object) new GClass31(GClass120.string_0[index], (GInterface0) this, Class15.smethod_0(37), (object) null));
      GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        GClass62.gclass95_0.menuSelectedItem = GClass120.int_12;
    }
    if (idAction == Class15.smethod_0(37))
    {
      GClass120.int_12 = GClass62.gclass95_0.menuSelectedItem;
      this.method_1();
    }
    if (idAction == Class15.smethod_0(38))
    {
      if ((GClass62.gclass117_0 == null ? 0 : 1) == 0)
        GClass62.gclass117_0 = new GClass117();
      GClass62.gclass117_0.vmethod_0();
    }
    if (idAction == Class15.smethod_0(88))
    {
      int num1 = GClass152.smethod_8(Class13.smethod_0(143488)) == Class15.smethod_0(1) ? 1 : 0;
      GClass134 menuItems = new GClass134(Class13.smethod_0(143605));
      menuItems.method_0((object) new GClass31(GClass109.string_21, (GInterface0) this, Class15.smethod_0(45), (object) null));
      menuItems.method_0((object) new GClass31(GClass109.string_22, (GInterface0) this, Class15.smethod_0(31), (object) null));
      GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
      int num2 = num1 == 0 ? 1 : 0;
      GClass62.gclass95_0.menuSelectedItem = num2 != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0);
    }
    if (idAction == Class15.smethod_0(45))
    {
      GClass152.smethod_9(Class13.smethod_0(143488), Class15.smethod_0(1));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    if (idAction == Class15.smethod_0(31))
    {
      GClass152.smethod_9(Class13.smethod_0(143488), Class15.smethod_0(0));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    if (idAction == Class15.smethod_0(67))
    {
      if ((GClass62.gclass117_0 == null ? 0 : 1) == 0)
        GClass62.gclass117_0 = new GClass117();
      GClass62.gclass117_0.vmethod_0();
      string username = GClass152.smethod_2(Class13.smethod_0(143528) + GClass120.int_12.ToString());
      if ((username == null ? 1 : 0) == 0 && (!username.Equals(string.Empty) ? 1 : 0) != 0)
      {
        GClass62.gclass117_0.isLogin2 = Class15.smethod_0(1) != 0;
        GClass62.smethod_4();
        GClass156.smethod_0().method_35();
        GClass156.smethod_0().method_39(username, string.Empty, GClass63.string_2, (sbyte) Class15.smethod_0(1));
      }
      else
        GClass156.smethod_0().method_122(string.Empty);
      GClass62.smethod_29(GClass109.string_83);
      GClass151.smethod_7(Class13.smethod_0(143521));
    }
    if (idAction == Class15.smethod_0(66))
      GClass63.gclass63_0.method_1();
    if (idAction == Class15.smethod_0(47) && ((!GClass120.bool_5 ? 1 : 0) != 0 || (!GClass120.bool_6 ? 1 : 0) == 0))
    {
      switch (GClass126.int_0 - Class15.smethod_0(1))
      {
        case 0:
          GClass126.smethod_8();
          break;
        case 2:
        case 4:
          GClass126.smethod_9();
          break;
        case 3:
          GClass126.smethod_7();
          break;
        case 5:
          GClass126.smethod_10();
          break;
      }
    }
    if (idAction == Class15.smethod_0(49))
    {
      GClass31 cmdYes = new GClass31(GClass109.string_135, (GInterface0) GClass62.gclass120_0, Class15.smethod_0(9), (object) null);
      GClass31 cmdNo = new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass120_0, Class15.smethod_0(10), (object) null);
      GClass62.smethod_34(GClass109.string_430, cmdYes, cmdNo);
    }
    if (idAction == Class15.smethod_0(9))
    {
      GClass152.smethod_13();
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    if (idAction == Class15.smethod_0(10))
    {
      GClass71.smethod_5();
      GClass62.gclass37_0 = (GClass37) null;
    }
    if (idAction != Class15.smethod_0(186))
      return;
    if ((GClass62.gclass121_0 == null ? 0 : 1) == 0)
      GClass62.gclass121_0 = new GClass121();
    GClass62.gclass121_0.vmethod_0();
  }

  public void method_6()
  {
    if ((!GClass120.bool_6 ? 0 : 1) == 0)
    {
      GClass120.gclass31_4 = new GClass31(GClass109.string_428, (GInterface0) this, Class15.smethod_0(7), (object) null);
      GClass120.gclass31_4.isFocus = Class15.smethod_0(1) != 0;
      GClass120.gclass31_4.x = GClass62.int_10 / Class15.smethod_0(7) - GClass113.int_2 / Class15.smethod_0(7);
      GClass120.gclass31_4.y = GClass62.int_13 + Class15.smethod_0(70);
      if (GClass120.gclass31_4.y > GClass62.int_11 - Class15.smethod_0(50))
        GClass120.gclass31_4.y = GClass62.int_11 - Class15.smethod_0(50);
    }
    if ((!GClass62.bool_5 ? 0 : 1) != 0)
      return;
    GClass120.int_6 = Class15.smethod_0(0);
    this.method_2();
  }

  public void method_7()
  {
    GClass116.int_22 = Class15.smethod_0(0);
    GClass116.int_23 = Class15.smethod_0(0);
    this.method_0();
    GClass120.bool_6 = Class15.smethod_0(0) != 0;
    GClass120.int_14 = Class15.smethod_0(0);
    GClass120.bool_4 = Class15.smethod_0(0) != 0;
    GClass120.bool_5 = Class15.smethod_0(0) != 0;
    GClass120.int_19 = Class15.smethod_0(0);
    GClass120.int_17 = Class15.smethod_0(0);
    GClass120.string_11 = GClass109.string_83;
    this.method_6();
    base.vmethod_0();
  }

  public void method_8(sbyte language)
  {
    if ((int) language == Class15.smethod_0(7))
    {
      if (GClass126.int_0 == Class15.smethod_0(1))
        GClass120.string_9 = GClass120.string_5;
      else
        GClass120.string_9 = GClass120.string_4;
    }
    else if ((int) language == Class15.smethod_0(1))
    {
      GClass120.string_9 = GClass120.string_7;
      if (GClass126.int_0 == Class15.smethod_0(1))
        GClass120.string_9 = GClass120.string_7;
      else
        GClass120.string_9 = GClass120.string_6;
    }
    else
    {
      GClass120.string_9 = GClass120.string_3;
      if (GClass126.int_0 == Class15.smethod_0(1))
        GClass120.string_9 = GClass120.string_3;
      else
        GClass120.string_9 = GClass120.string_2;
    }
  }
}
