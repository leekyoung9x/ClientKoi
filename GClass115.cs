// Decompiled with JetBrains decompiler
// Type: GClass115
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass115 : GClass113, GInterface0
{
  public static GClass115 gclass115_0;
  private GClass148 gclass148_0;
  public static bool bool_0 = Class15.smethod_0(0) != 0;
  public static GClass184 gclass184_0;
  public static int int_6;
  public static int int_7;
  public static int int_8;
  public static int[][] int_9;
  public static int[] int_10;
  public static int[] int_11;
  private int int_12;
  private int int_13;
  private int[] int_14;
  public int yBegin;
  private int int_15;
  private int int_16;
  private int int_17;
  private int int_18;
  private int int_19;
  private int int_20;

  public GClass115()
  {
    int[] numArray = new int[Class15.smethod_0(5)];
    numArray[Class15.smethod_0(1)] = Class15.smethod_0(2);
    numArray[Class15.smethod_0(7)] = Class15.smethod_0(88);
    this.int_14 = numArray;
    this.int_16 = Class15.smethod_0(160);
    this.int_17 = Class15.smethod_0(306);
    this.int_18 = Class15.smethod_0(70);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    try
    {
      if ((!GClass62.bool_1 ? 0 : 1) == 0)
      {
        byte[] byte_0 = new byte[Class15.smethod_0(283)];
        // ISSUE: field reference
        RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.REAanMsskcWj));
        GClass115.smethod_4((sbyte[]) Class15.smethod_4(byte_0));
      }
      byte[] byte_0_1 = new byte[Class15.smethod_0(283)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.REAanMsskcWj));
      this.method_0((sbyte[]) Class15.smethod_4(byte_0_1));
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(26703) + ex.ToString());
    }
    if (GClass62.int_10 <= Class15.smethod_0(90))
    {
      GClass116.smethod_23(Class15.smethod_0(212), Class15.smethod_0(21));
      GClass116.int_144 = (GClass62.int_10 - Class15.smethod_0(212)) / Class15.smethod_0(7);
      GClass116.int_143 = Class15.smethod_0(31);
      this.int_17 += Class15.smethod_0(9);
      this.int_18 -= Class15.smethod_0(9);
    }
    GClass115.int_6 = Class15.smethod_0(1);
    GClass115.gclass184_0 = new GClass184();
    GClass115.gclass184_0.width = GClass62.gclass117_0.tfUser.width;
    if (GClass62.int_10 < Class15.smethod_0(90))
      GClass115.gclass184_0.width = Class15.smethod_0(4);
    GClass115.gclass184_0.height = GClass113.int_0 + Class15.smethod_0(7);
    if (GClass62.int_10 < Class15.smethod_0(90))
    {
      GClass115.gclass184_0.x = GClass116.int_144 + Class15.smethod_0(70);
      GClass115.gclass184_0.y = GClass116.int_143 + Class15.smethod_0(66);
    }
    else
    {
      GClass115.gclass184_0.x = GClass62.int_10 / Class15.smethod_0(7) - GClass115.gclass184_0.width / Class15.smethod_0(7);
      GClass115.gclass184_0.y = Class15.smethod_0(95);
    }
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
      GClass115.gclass184_0.isFocus = Class15.smethod_0(1) != 0;
    GClass115.gclass184_0.method_28(GClass184.int_7);
    GClass115.gclass184_0.showSubTextField = Class15.smethod_0(0) != 0;
    GClass115.gclass184_0.strInfo = GClass109.string_78;
    if ((!GClass115.gclass184_0.method_21().Equals(Class13.smethod_0(26815)) ? 1 : 0) == 0)
      GClass115.gclass184_0.method_23(GClass62.gclass117_0.tfUser.method_21().Substring(Class15.smethod_0(0), GClass62.gclass117_0.tfUser.method_21().IndexOf(Class13.smethod_0(26815))));
    GClass115.gclass184_0.name = GClass109.string_78;
    GClass115.int_6 = Class15.smethod_0(1);
    GClass115.int_7 = Class15.smethod_0(0);
    this.center = new GClass31(GClass109.string_150, (GInterface0) this, Class15.smethod_0(260), (object) null);
    this.left = new GClass31(GClass109.string_151, (GInterface0) this, Class15.smethod_0(263), (object) null);
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
      this.right = GClass115.gclass184_0.cmdClear;
    this.yBegin = GClass115.gclass184_0.y;
  }

  public static GClass115 smethod_2()
  {
    if ((GClass115.gclass115_0 == null ? 0 : 1) == 0)
      GClass115.gclass115_0 = new GClass115();
    return GClass115.gclass115_0;
  }

  public static void smethod_3()
  {
  }

  public static void smethod_4(sbyte[] mapID)
  {
    GClass151.smethod_7(Class13.smethod_0(26862));
    for (int index1 = Class15.smethod_0(0); index1 < mapID.Length; index1 += Class15.smethod_0(1))
    {
      GClass35 gclass35 = GClass133.smethod_0(Class13.smethod_0(27402) + mapID[index1].ToString());
      GClass92.int_0[index1] = (int) (ushort) gclass35.method_2();
      GClass92.int_1[index1] = (int) (ushort) gclass35.method_2();
      GClass33.smethod_2(Class13.smethod_0(27483) + GClass92.int_0[index1].ToString() + Class13.smethod_0(27565) + GClass92.int_1[index1].ToString());
      GClass92.int_5[index1] = new int[gclass35.method_13()];
      GClass33.smethod_2(Class13.smethod_0(27562) + GClass92.int_5[index1].Length.ToString());
      for (int index2 = Class15.smethod_0(0); index2 < GClass92.int_0[index1] * GClass92.int_1[index1]; index2 += Class15.smethod_0(1))
        GClass92.int_5[index1][index2] = gclass35.method_2();
      GClass92.int_6[index1] = new int[GClass92.int_5[index1].Length];
    }
  }

  public void method_0(sbyte[] mapID)
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
      return;
    try
    {
      for (int index1 = Class15.smethod_0(0); index1 < mapID.Length; index1 += Class15.smethod_0(1))
      {
        GClass35 gclass35 = GClass133.smethod_0(Class13.smethod_0(27521) + mapID[index1].ToString());
        GClass33.smethod_2(Class13.smethod_0(27633) + mapID[index1].ToString());
        short num1 = gclass35.method_0();
        GClass92.gclass134_0[index1] = new GClass134();
        GClass151.smethod_7(Class13.smethod_0(27621) + num1.ToString());
        for (int index2 = Class15.smethod_0(0); index2 < (int) num1; index2 += Class15.smethod_0(1))
        {
          short id = gclass35.method_0();
          short num2 = gclass35.method_0();
          short num3 = gclass35.method_0();
          if ((GClass185.smethod_4((int) id) == null ? 1 : 0) == 0)
          {
            GClass18 gclass18 = GClass185.smethod_4((int) id);
            GClass18 o = new GClass18();
            o.id = (int) id;
            o.idImage = gclass18.idImage;
            o.dx = gclass18.dx;
            o.dy = gclass18.dy;
            o.x = (int) num2 * (int) GClass185.sbyte_0;
            o.y = (int) num3 * (int) GClass185.sbyte_0;
            o.layer = gclass18.layer;
            GClass92.gclass134_0[index1].method_0((object) o);
            if ((!GClass18.gclass128_0.method_7((object) (o.idImage.ToString() + string.Empty)) ? 0 : 1) == 0)
            {
              try
              {
                GClass66 v = GClass62.smethod_40(Class13.smethod_0(27613) + o.idImage.ToString() + Class13.smethod_0(27211));
                if ((v == null ? 0 : 1) == 0)
                {
                  GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0));
                  GClass156.smethod_0().method_114(o.idImage);
                }
                else
                  GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) v);
              }
              catch (Exception ex)
              {
                GClass66 v = GClass62.smethod_40(Class13.smethod_0(27613) + o.idImage.ToString() + Class13.smethod_0(27211));
                if ((v == null ? 0 : 1) == 0)
                {
                  v = GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0);
                  GClass156.smethod_0().method_114(o.idImage);
                }
                GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) v);
              }
              GClass18.gclass134_1.method_0((object) (o.idImage.ToString() + string.Empty));
            }
            if ((!GClass18.smethod_1(o.idImage.ToString() + string.Empty) ? 0 : 1) == 0)
              GClass18.gclass134_0.method_0((object) (o.idImage.ToString() + string.Empty));
            o.method_2();
          }
          else
            GClass151.smethod_7(Class13.smethod_0(27311));
        }
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(27283) + ex.ToString());
    }
  }

  public override void vmethod_0()
  {
    GClass117.bool_0 = Class15.smethod_0(0) != 0;
    GClass62.gclass95_0.showMenu = Class15.smethod_0(0) != 0;
    GClass62.smethod_27();
    base.vmethod_0();
    GClass115.int_6 = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
    GClass115.int_7 = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
    this.method_1();
    GClass20.bool_4 = Class15.smethod_0(0) != 0;
    GClass115.gclass184_0.method_20(Class15.smethod_0(1) != 0);
  }

  public void method_1()
  {
    GClass185.int_27 = new int[GClass92.int_5[GClass115.int_6].Length];
    for (int index = Class15.smethod_0(0); index < GClass92.int_5[GClass115.int_6].Length; index += Class15.smethod_0(1))
      GClass185.int_27[index] = GClass92.int_5[GClass115.int_6][index];
    GClass185.int_28 = GClass92.int_6[GClass115.int_6];
    GClass185.int_24 = GClass92.int_3[GClass115.int_6];
    GClass185.int_23 = GClass92.int_2[GClass115.int_6];
    GClass185.int_25 = GClass92.int_2[GClass115.int_6];
    GClass185.int_21 = GClass92.int_0[GClass115.int_6];
    GClass185.int_22 = GClass92.int_1[GClass115.int_6];
    GClass185.int_25 = this.int_14[GClass115.int_6] + Class15.smethod_0(1);
    GClass185.smethod_33();
    GClass185.smethod_9();
    GClass62.smethod_19(this.int_14[GClass115.int_6]);
    GClass116.smethod_8(Class15.smethod_0(0) != 0, this.int_16, this.int_17);
  }

  public override void vmethod_2(int keyCode) => GClass115.gclass184_0.method_10(keyCode);

  public override void vmethod_3()
  {
    this.int_19 += Class15.smethod_0(1);
    if (this.int_19 > Class15.smethod_0(6))
      this.int_19 = Class15.smethod_0(0);
    this.int_20 = this.int_19 % Class15.smethod_0(9) >= Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0);
    GClass115.gclass184_0.method_17();
    if ((GClass115.int_8 == 0 ? 1 : 0) != 0)
      return;
    GClass115.gclass184_0.isFocus = Class15.smethod_0(0) != 0;
  }

  public override void vmethod_4()
  {
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      GClass115.int_8 -= Class15.smethod_0(1);
      if (GClass115.int_8 < Class15.smethod_0(0))
        GClass115.int_8 = GClass109.string_99.Length - Class15.smethod_0(1);
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      GClass115.int_8 += Class15.smethod_0(1);
      if (GClass115.int_8 >= GClass109.string_99.Length)
        GClass115.int_8 = Class15.smethod_0(0);
    }
    if ((GClass115.int_8 == 0 ? 0 : 1) == 0)
    {
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        this.right = GClass115.gclass184_0.cmdClear;
      GClass115.gclass184_0.method_17();
    }
    if (GClass115.int_8 == Class15.smethod_0(1))
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
      {
        GClass115.int_6 -= Class15.smethod_0(1);
        if (GClass115.int_6 < Class15.smethod_0(0))
          GClass115.int_6 = GClass109.string_100.Length - Class15.smethod_0(1);
        this.method_1();
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) == 0)
      {
        GClass115.int_6 += Class15.smethod_0(1);
        if (GClass115.int_6 > GClass109.string_100.Length - Class15.smethod_0(1))
          GClass115.int_6 = Class15.smethod_0(0);
        this.method_1();
      }
      this.right = (GClass31) null;
    }
    if (GClass115.int_8 == Class15.smethod_0(7))
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
      {
        GClass115.int_7 -= Class15.smethod_0(1);
        if (GClass115.int_7 < Class15.smethod_0(0))
          GClass115.int_7 = GClass109.string_388[Class15.smethod_0(0)].Length - Class15.smethod_0(1);
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) == 0)
      {
        GClass115.int_7 += Class15.smethod_0(1);
        if (GClass115.int_7 > GClass109.string_388[Class15.smethod_0(0)].Length - Class15.smethod_0(1))
          GClass115.int_7 = Class15.smethod_0(0);
      }
      this.right = (GClass31) null;
    }
    if ((!GClass62.bool_16 ? 1 : 0) == 0)
    {
      int num1 = Class15.smethod_0(80);
      int num2 = Class15.smethod_0(4);
      int num3 = Class15.smethod_0(63);
      if (GClass62.int_10 > GClass62.int_11)
      {
        num1 = Class15.smethod_0(21);
        num2 = Class15.smethod_0(54);
      }
      if ((!GClass62.smethod_22(GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(5) * num3 / Class15.smethod_0(7), Class15.smethod_0(9), num3 * Class15.smethod_0(5), Class15.smethod_0(25)) ? 1 : 0) == 0)
      {
        GClass115.int_8 = Class15.smethod_0(0);
        GClass115.gclass184_0.isFocus = Class15.smethod_0(1) != 0;
      }
      if ((!GClass62.smethod_22(GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(5) * num3 / Class15.smethod_0(7), num1 - Class15.smethod_0(6), num3 * Class15.smethod_0(5), num2 + Class15.smethod_0(3)) ? 1 : 0) == 0)
      {
        GClass115.int_8 = Class15.smethod_0(1);
        int int6_1 = GClass115.int_6;
        GClass115.int_6 = (GClass62.int_0 - (GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(5) * num3 / Class15.smethod_0(7))) / num3;
        if (GClass115.int_6 < Class15.smethod_0(0))
          GClass115.int_6 = Class15.smethod_0(0);
        if (GClass115.int_6 > GClass109.string_100.Length - Class15.smethod_0(1))
          GClass115.int_6 = GClass109.string_100.Length - Class15.smethod_0(1);
        int int6_2 = GClass115.int_6;
        if (int6_1 != int6_2)
          this.method_1();
      }
      if ((!GClass62.smethod_22(GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(5) * num3 / Class15.smethod_0(7), num1 - Class15.smethod_0(6) + num2 + Class15.smethod_0(3), num3 * Class15.smethod_0(5), Class15.smethod_0(130)) ? 1 : 0) == 0)
      {
        GClass115.int_8 = Class15.smethod_0(7);
        int int7 = GClass115.int_7;
        GClass115.int_7 = (GClass62.int_0 - (GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(5) * num3 / Class15.smethod_0(7))) / num3;
        if (GClass115.int_7 < Class15.smethod_0(0))
          GClass115.int_7 = Class15.smethod_0(0);
        if (GClass115.int_7 > GClass109.string_388[Class15.smethod_0(0)].Length - Class15.smethod_0(1))
          GClass115.int_7 = GClass109.string_388[Class15.smethod_0(0)].Length - Class15.smethod_0(1);
        int int8 = GClass115.int_8;
        if (int7 != int8)
          this.method_1();
      }
    }
    if ((!GClass188.bool_1 ? 0 : 1) == 0)
      base.vmethod_4();
    GClass62.smethod_25();
    GClass62.smethod_24();
  }

  public override void vmethod_5(GClass98 g)
  {
    if (GClass20.bool_4)
      return;
    GClass62.smethod_16(g);
    g.method_1(-GClass116.int_22, -GClass116.int_23);
    if (!GClass62.bool_1)
    {
      for (int index = Class15.smethod_0(0); index < GClass92.gclass134_0[GClass115.int_6].method_2(); index += Class15.smethod_0(1))
      {
        GClass18 gclass18 = (GClass18) GClass92.gclass134_0[GClass115.int_6].method_3(index);
        if (gclass18.idImage != (short) -1 && (int) gclass18.layer == Class15.smethod_0(1))
          gclass18.method_3(g);
      }
    }
    GClass185.smethod_20(g);
    int num1 = Class15.smethod_0(6);
    if (GClass62.int_10 == Class15.smethod_0(212))
      num1 = Class15.smethod_0(51);
    int index1 = GClass115.int_9[GClass115.int_6][GClass115.int_7];
    int index2 = GClass115.int_10[GClass115.int_6];
    int index3 = GClass115.int_11[GClass115.int_6];
    g.method_32(GClass185.gclass66_10, this.int_16, this.int_17 + this.int_18, Class15.smethod_0(5));
    GClass142 gclass142_1 = GClass116.gclass142_0[index1];
    GClass142 gclass142_2 = GClass116.gclass142_0[index2];
    GClass142 gclass142_3 = GClass116.gclass142_0[index3];
    GClass169.smethod_6(g, (int) gclass142_1.pi[GClass20.int_0[this.int_20][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, this.int_16 + GClass20.int_0[this.int_20][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142_1.pi[GClass20.int_0[this.int_20][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, this.int_17 - GClass20.int_0[this.int_20][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142_1.pi[GClass20.int_0[this.int_20][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
    GClass169.smethod_6(g, (int) gclass142_2.pi[GClass20.int_0[this.int_20][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, this.int_16 + GClass20.int_0[this.int_20][Class15.smethod_0(1)][Class15.smethod_0(1)] + (int) gclass142_2.pi[GClass20.int_0[this.int_20][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx, this.int_17 - GClass20.int_0[this.int_20][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) gclass142_2.pi[GClass20.int_0[this.int_20][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
    GClass169.smethod_6(g, (int) gclass142_3.pi[GClass20.int_0[this.int_20][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, this.int_16 + GClass20.int_0[this.int_20][Class15.smethod_0(7)][Class15.smethod_0(1)] + (int) gclass142_3.pi[GClass20.int_0[this.int_20][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx, this.int_17 - GClass20.int_0[this.int_20][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) gclass142_3.pi[GClass20.int_0[this.int_20][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
    if (!GClass62.bool_1)
    {
      for (int index4 = Class15.smethod_0(0); index4 < GClass92.gclass134_0[GClass115.int_6].method_2(); index4 += Class15.smethod_0(1))
      {
        GClass18 gclass18 = (GClass18) GClass92.gclass134_0[GClass115.int_6].method_3(index4);
        if (gclass18.idImage != (short) -1 && (int) gclass18.layer == Class15.smethod_0(5))
          gclass18.method_3(g);
      }
    }
    g.method_1(-g.method_3(), -g.method_4());
    if (GClass62.int_10 < Class15.smethod_0(90))
    {
      GClass62.gclass140_0.method_34(GClass116.int_144, GClass116.int_143, GClass116.int_150, GClass116.int_151, g);
      GClass169.smethod_6(g, (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, GClass62.int_10 / Class15.smethod_0(7) + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, GClass116.int_143 + Class15.smethod_0(6) + Class15.smethod_0(5) * num1 - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
      GClass169.smethod_6(g, (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, GClass62.int_10 / Class15.smethod_0(7) + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(1)] + (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx, GClass116.int_143 + Class15.smethod_0(6) + Class15.smethod_0(5) * num1 - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
      GClass169.smethod_6(g, (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, GClass62.int_10 / Class15.smethod_0(7) + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(1)] + (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx, GClass116.int_143 + Class15.smethod_0(6) + Class15.smethod_0(5) * num1 - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy + this.int_18, Class15.smethod_0(0), Class15.smethod_0(0));
      for (int index5 = Class15.smethod_0(0); index5 < GClass109.string_99.Length; index5 += Class15.smethod_0(1))
      {
        if (GClass115.int_8 == index5)
        {
          g.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), Class15.smethod_0(7), GClass116.int_144 + Class15.smethod_0(31) + (GClass62.int_8 % Class15.smethod_0(38) > Class15.smethod_0(5) ? Class15.smethod_0(1) : Class15.smethod_0(0)), GClass116.int_143 + Class15.smethod_0(95) + index5 * num1, GClass177.int_6);
          g.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), Class15.smethod_0(0), GClass116.int_144 + GClass116.int_150 - Class15.smethod_0(31) - (GClass62.int_8 % Class15.smethod_0(38) > Class15.smethod_0(5) ? Class15.smethod_0(1) : Class15.smethod_0(0)), GClass116.int_143 + Class15.smethod_0(95) + index5 * num1, GClass177.int_6);
        }
        GClass97.gclass97_6.method_6(g, GClass109.string_99[index5], GClass116.int_144 + Class15.smethod_0(51), GClass116.int_143 + Class15.smethod_0(6) + index5 * num1, Class15.smethod_0(0));
      }
      GClass97.gclass97_6.method_6(g, GClass109.string_100[GClass115.int_6], GClass116.int_144 + Class15.smethod_0(152), GClass116.int_143 + Class15.smethod_0(6) + num1, GClass97.int_0);
      GClass97.gclass97_6.method_6(g, GClass109.string_388[GClass115.int_6][GClass115.int_7], GClass116.int_144 + Class15.smethod_0(280), GClass116.int_143 + Class15.smethod_0(6) + Class15.smethod_0(7) * num1, GClass97.int_0);
      GClass115.gclass184_0.method_13(g);
    }
    else
    {
      if (!Main.bool_3)
      {
        if (GClass98.int_20 != 0)
        {
          this.int_12 = Class15.smethod_0(80);
          this.int_13 = Class15.smethod_0(4);
          if (GClass62.int_10 > GClass62.int_11)
          {
            this.int_12 = GClass116.int_143 + Class15.smethod_0(6) + Class15.smethod_0(5) * num1 + (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy + this.int_18 - Class15.smethod_0(9);
            this.int_13 = Class15.smethod_0(95);
          }
        }
        else
        {
          this.int_12 = Class15.smethod_0(80);
          this.int_13 = Class15.smethod_0(4);
          if (GClass62.int_10 > GClass62.int_11)
          {
            this.int_12 = Class15.smethod_0(21);
            this.int_13 = Class15.smethod_0(70);
          }
        }
        GClass115.gclass184_0.y = this.int_12 - GClass115.gclass184_0.height - this.int_13 + Class15.smethod_0(3);
      }
      else
      {
        this.int_12 = Class15.smethod_0(80);
        this.int_13 = Class15.smethod_0(4);
        if (GClass62.int_10 > GClass62.int_11)
        {
          this.int_12 = Class15.smethod_0(21);
          this.int_13 = Class15.smethod_0(70);
        }
        GClass115.gclass184_0.y = this.yBegin;
      }
      for (int index6 = Class15.smethod_0(0); index6 < Class15.smethod_0(5); index6 += Class15.smethod_0(1))
      {
        int num2 = Class15.smethod_0(63);
        if (index6 != GClass115.int_6)
        {
          g.method_32(GClass116.gclass66_22, GClass62.int_10 / Class15.smethod_0(7) - num2 + index6 * num2, this.int_12, Class15.smethod_0(5));
        }
        else
        {
          if (GClass115.int_8 == Class15.smethod_0(1))
            g.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), Class15.smethod_0(2), GClass62.int_10 / Class15.smethod_0(7) - num2 + index6 * num2, this.int_12 - Class15.smethod_0(51) + (GClass62.int_8 % Class15.smethod_0(38) > Class15.smethod_0(5) ? Class15.smethod_0(1) : Class15.smethod_0(0)), GClass177.int_6);
          g.method_32(GClass116.gclass66_23, GClass62.int_10 / Class15.smethod_0(7) - num2 + index6 * num2, this.int_12, Class15.smethod_0(5));
        }
        GClass97.gclass97_6.method_6(g, GClass109.string_100[index6], GClass62.int_10 / Class15.smethod_0(7) - num2 + index6 * num2, this.int_12 - Class15.smethod_0(3), GClass97.int_2);
      }
      for (int index7 = Class15.smethod_0(0); index7 < Class15.smethod_0(5); index7 += Class15.smethod_0(1))
      {
        int num3 = Class15.smethod_0(63);
        if (index7 != GClass115.int_7)
        {
          g.method_32(GClass116.gclass66_22, GClass62.int_10 / Class15.smethod_0(7) - num3 + index7 * num3, this.int_12 + this.int_13, Class15.smethod_0(5));
        }
        else
        {
          if (GClass115.int_8 == Class15.smethod_0(7))
            g.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), Class15.smethod_0(2), GClass62.int_10 / Class15.smethod_0(7) - num3 + index7 * num3, this.int_12 + this.int_13 - Class15.smethod_0(51) + (GClass62.int_8 % Class15.smethod_0(38) > Class15.smethod_0(5) ? Class15.smethod_0(1) : Class15.smethod_0(0)), GClass177.int_6);
          g.method_32(GClass116.gclass66_23, GClass62.int_10 / Class15.smethod_0(7) - num3 + index7 * num3, this.int_12 + this.int_13, Class15.smethod_0(5));
        }
        GClass97.gclass97_6.method_6(g, GClass109.string_388[GClass115.int_6][index7], GClass62.int_10 / Class15.smethod_0(7) - num3 + index7 * num3, this.int_12 + this.int_13 - Class15.smethod_0(3), GClass97.int_2);
      }
      GClass115.gclass184_0.method_13(g);
    }
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    GClass97.gclass97_3.method_10(g, GClass109.string_96 + Class13.smethod_0(20687) + GClass117.string_1, Class15.smethod_0(3), Class15.smethod_0(3), Class15.smethod_0(0), GClass97.gclass97_6);
    if (GClass188.bool_1)
      return;
    base.vmethod_5(g);
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction <= Class15.smethod_0(263))
    {
      if (idAction != Class15.smethod_0(260))
      {
        if (idAction != Class15.smethod_0(263))
          return;
        if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) == 0)
        {
          GClass62.smethod_34(GClass109.string_420, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(307), (object) null), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(308), (object) null));
        }
        else
        {
          if ((!Main.bool_4 ? 1 : 0) == 0)
            GClass63.bool_1 = Class15.smethod_0(1) != 0;
          GClass157.smethod_0().imethod_4();
          GClass62.gclass120_0.vmethod_0();
        }
      }
      else if ((!GClass115.gclass184_0.method_21().Equals(string.Empty) ? 1 : 0) == 0)
        GClass62.smethod_28(GClass109.string_74);
      else if (GClass115.gclass184_0.method_21().Length < Class15.smethod_0(3))
        GClass62.smethod_28(GClass109.string_75);
      else if (GClass115.gclass184_0.method_21().Length > Class15.smethod_0(9))
      {
        GClass62.smethod_28(GClass109.string_76);
      }
      else
      {
        GClass71.smethod_1();
        GClass156.smethod_0().method_48(GClass115.gclass184_0.method_21(), GClass115.int_6, GClass115.int_9[GClass115.int_6][GClass115.int_7]);
      }
    }
    else if (idAction != Class15.smethod_0(307))
    {
      if (idAction != Class15.smethod_0(308))
        return;
      GClass62.smethod_27();
    }
    else
    {
      GClass157.smethod_0().imethod_4();
      GClass62.smethod_27();
      GClass62.gclass120_0.vmethod_0();
    }
  }

  static GClass115()
  {
    int[][] numArray1 = new int[Class15.smethod_0(5)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_1 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.uLobbJlafGfh));
    int[] numArray2 = (int[]) Class15.smethod_4(byte_0_1);
    numArray1[index1] = numArray2;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.WARLskyWtQNv));
    int[] numArray3 = (int[]) Class15.smethod_4(byte_0_2);
    numArray1[index2] = numArray3;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_3 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.RuSCRISMqCES));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_3);
    numArray1[index3] = numArray4;
    GClass115.int_9 = numArray1;
    byte[] byte_0_4 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.NYLoRprIXPGT));
    GClass115.int_10 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.etyXOEECyJrl));
    GClass115.int_11 = (int[]) Class15.smethod_4(byte_0_5);
  }
}
