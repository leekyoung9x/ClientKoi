// Decompiled with JetBrains decompiler
// Type: GClass122
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass122 : GClass113
{
  public static int int_6;
  private bool bool_0;
  private bool bool_1;
  public static int int_7 = -1;
  public static int int_8 = -1;
  public static GClass122 gclass122_0;
  public static GClass66 gclass66_0;

  public GClass122() => GClass122.gclass122_0 = this;

  public static void smethod_2() => GClass122.int_6 = Class15.smethod_0(0);

  public override void vmethod_3()
  {
    if (GClass122.int_6 == Class15.smethod_0(6) && (!this.bool_0 ? 0 : 1) == 0)
    {
      this.bool_0 = Class15.smethod_0(1) != 0;
      GClass13.gclass13_0.method_7();
      if (GClass152.smethod_8(Class13.smethod_0(144166)) != -1)
        GClass116.bool_64 = (GClass152.smethod_8(Class13.smethod_0(144166)) == 0 ? 1 : 0) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
      if (GClass152.smethod_8(Class13.smethod_0(144135)) != -1)
        GClass62.bool_21 = GClass152.smethod_8(Class13.smethod_0(144135)) == Class15.smethod_0(1);
      if ((!GClass62.bool_21 ? 1 : 0) == 0)
        GClass172.smethod_1().method_0(GClass185.int_37);
      GClass172.smethod_1().method_2();
      GClass120.smethod_8();
    }
    GClass122.int_6 += Class15.smethod_0(1);
    GClass120.smethod_5();
  }

  public static void smethod_3()
  {
    if (GClass152.smethod_8(Class13.smethod_0(144246)) == -1)
    {
      int num = Class15.smethod_0(0);
      if ((int) GClass109.sbyte_0 > Class15.smethod_0(0))
      {
        for (int index = Class15.smethod_0(0); index < (int) GClass109.sbyte_0; index += Class15.smethod_0(1))
          num += GClass120.int_11[index];
      }
      GClass120.int_12 = GClass120.sbyte_0 != (sbyte) -1 ? (int) GClass120.sbyte_0 : num + GClass151.smethod_18(Class15.smethod_0(0), GClass120.int_11[(int) GClass109.sbyte_0]);
      GClass152.smethod_9(Class13.smethod_0(144246), GClass120.int_12);
      GClass63.string_0 = GClass120.string_1[GClass120.int_12];
      GClass63.int_0 = (int) GClass120.short_0[GClass120.int_12];
      GClass109.smethod_1(GClass120.sbyte_1[GClass120.int_12]);
      GClass117.string_1 = GClass120.string_0[GClass120.int_12];
      GClass62.smethod_4();
    }
    else
    {
      GClass120.int_12 = GClass152.smethod_8(Class13.smethod_0(144246));
      if (GClass120.int_12 > GClass120.string_0.Length - Class15.smethod_0(1))
      {
        GClass120.int_12 = (int) GClass120.sbyte_0;
        GClass152.smethod_9(Class13.smethod_0(144246), GClass120.int_12);
      }
      GClass63.string_0 = GClass120.string_1[GClass120.int_12];
      GClass63.int_0 = (int) GClass120.short_0[GClass120.int_12];
      GClass109.smethod_1(GClass120.sbyte_1[GClass120.int_12]);
      GClass117.string_1 = GClass120.string_0[GClass120.int_12];
      GClass62.smethod_4();
    }
  }

  public override void vmethod_5(GClass98 g)
  {
    if ((GClass122.gclass66_0 == null ? 1 : 0) == 0 && GClass122.int_6 < Class15.smethod_0(6))
    {
      g.method_16(Class15.smethod_0(142));
      g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
      g.method_32(GClass122.gclass66_0, GClass62.int_10 / Class15.smethod_0(7), GClass62.int_11 / Class15.smethod_0(7), Class15.smethod_0(5));
    }
    if (GClass122.int_7 != -1)
    {
      g.method_16(Class15.smethod_0(0));
      g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
      g.method_32(GClass117.gclass66_0, GClass62.int_10 / Class15.smethod_0(7), GClass62.int_11 / Class15.smethod_0(7) - Class15.smethod_0(40), GClass177.int_3);
      GClass62.smethod_44(GClass62.int_12, GClass62.int_11 / Class15.smethod_0(7) + Class15.smethod_0(40), g);
      GClass97.gclass97_3.method_6(g, GClass109.string_87 + (GClass122.int_7 * Class15.smethod_0(21) / GClass122.int_8).ToString() + Class13.smethod_0(144315), GClass62.int_10 / Class15.smethod_0(7), GClass62.int_11 / Class15.smethod_0(7), Class15.smethod_0(7));
    }
    else
    {
      if (GClass122.int_6 < Class15.smethod_0(6))
        return;
      g.method_16(Class15.smethod_0(0));
      g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
      GClass62.smethod_44(GClass62.int_12, GClass62.int_13, g);
      if ((GClass120.gclass31_3 == null ? 1 : 0) != 0)
        return;
      GClass97.gclass97_20.method_10(g, GClass109.string_429, GClass62.int_10 - Class15.smethod_0(7), GClass62.int_11 - Class15.smethod_0(9), Class15.smethod_0(1), GClass97.gclass97_16);
    }
  }

  public static void smethod_4() => GClass122.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(144313));
}
