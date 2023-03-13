// Decompiled with JetBrains decompiler
// Type: GClass105
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass105
{
  public static GClass66 gclass66_0;
  public static int int_0;
  public static int int_1;
  public static int int_2;
  public static int int_3;
  public static int int_4;
  public static int int_5;
  public static int int_6;
  public static int int_7;
  public static int int_8;
  public static int int_9;
  public static bool bool_0;
  public static int int_10;
  public static bool bool_1;
  public static int int_11;
  public static int int_12;
  public static int int_13;
  public static bool bool_2;

  public static void smethod_0() => GClass105.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(154008));

  public static void smethod_1(GClass98 g, int x, int y)
  {
    if ((!GClass105.bool_2 ? 0 : 1) == 0)
    {
      if ((GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
      {
        if (GClass20.smethod_1().cdir == Class15.smethod_0(1))
          GClass105.int_5 = x - Class15.smethod_0(51) - GClass116.int_22;
        if (GClass20.smethod_1().cdir == -1)
          GClass105.int_5 = x + Class15.smethod_0(51) - GClass116.int_22;
      }
      GClass105.int_0 = GClass20.smethod_1().cy - Class15.smethod_0(54) - GClass116.int_23;
    }
    else
    {
      GClass105.int_10 += Class15.smethod_0(1);
      if (GClass105.int_10 == Class15.smethod_0(3))
      {
        GClass105.bool_2 = Class15.smethod_0(0) != 0;
        GClass105.int_10 = Class15.smethod_0(0);
      }
      GClass105.int_5 = x - GClass116.int_22;
      GClass105.int_0 = y - GClass116.int_23;
    }
    GClass105.int_13 = GClass105.int_6 <= x - GClass116.int_22 ? Class15.smethod_0(1) : -1;
    g.method_32(GClass116.gclass66_44, GClass105.int_6, GClass105.int_1 - Class15.smethod_0(54), Class15.smethod_0(5));
    GClass148.smethod_4(g, GClass105.int_6 - Class15.smethod_0(46), GClass105.int_1 - Class15.smethod_0(152), Class15.smethod_0(32), Class15.smethod_0(51), Class15.smethod_0(142), Class15.smethod_0(0) != 0);
    GClass97.gclass97_6.method_6(g, GClass116.smethod_6().keyInput, GClass105.int_6, GClass105.int_1 - Class15.smethod_0(130), Class15.smethod_0(7));
    if ((!GClass105.bool_1 ? 1 : 0) == 0)
    {
      GClass105.bool_1 = Class15.smethod_0(0) != 0;
      GClass40.smethod_0(new GClass41(Class15.smethod_0(124), GClass105.int_6 + GClass116.int_22, GClass105.int_1 + GClass116.int_23, Class15.smethod_0(7), Class15.smethod_0(31), -1));
    }
    if ((!GClass105.bool_0 ? 1 : 0) == 0)
    {
      GClass105.bool_0 = Class15.smethod_0(0) != 0;
      GClass40.smethod_0(new GClass41(Class15.smethod_0(124), GClass105.int_6 + GClass116.int_22, GClass105.int_1 + GClass116.int_23, Class15.smethod_0(7), Class15.smethod_0(31), -1));
      GClass116.smethod_6().mobCapcha = (GClass100) null;
      GClass105.int_5 = -GClass116.int_22;
      GClass105.int_0 = -GClass116.int_23;
    }
    g.method_24(GClass105.gclass66_0, Class15.smethod_0(0), GClass105.int_12 * Class15.smethod_0(54), Class15.smethod_0(54), Class15.smethod_0(54), GClass105.int_13 != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass105.int_6, GClass105.int_1 + Class15.smethod_0(5) + (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0)), Class15.smethod_0(5));
    GClass105.smethod_2();
  }

  public static void smethod_2()
  {
    if (GClass105.int_1 != GClass105.int_0)
    {
      GClass105.int_3 = GClass105.int_0 - GClass105.int_1 << Class15.smethod_0(7);
      GClass105.int_2 += GClass105.int_3;
      GClass105.int_1 += GClass105.int_2 >> Class15.smethod_0(2);
      GClass105.int_2 &= Class15.smethod_0(9);
    }
    if (GClass105.int_6 != GClass105.int_5)
    {
      GClass105.int_8 = GClass105.int_5 - GClass105.int_6 << Class15.smethod_0(7);
      GClass105.int_7 += GClass105.int_8;
      GClass105.int_6 += GClass105.int_7 >> Class15.smethod_0(2);
      GClass105.int_7 &= Class15.smethod_0(9);
    }
    GClass105.int_11 += Class15.smethod_0(1);
    if (GClass105.int_11 != Class15.smethod_0(3))
      return;
    GClass105.int_11 = Class15.smethod_0(0);
    GClass105.int_12 += Class15.smethod_0(1);
    if (GClass105.int_12 <= Class15.smethod_0(7))
      return;
    GClass105.int_12 = Class15.smethod_0(0);
  }
}
