// Decompiled with JetBrains decompiler
// Type: GClass57
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass57
{
  private static int int_0;
  private static int int_1;
  private static GClass130 gclass130_0 = new GClass130();
  private static GClass134 gclass134_0 = new GClass134();
  private static int int_2 = Class15.smethod_0(186);
  private static int int_3;
  private static int int_4;
  private static int int_5;
  private static int int_6;
  private static int int_7;
  private static int int_8;
  private static int int_9;
  private static int int_10 = Class15.smethod_0(312);
  private static float float_0;
  private static int[] int_11 = new int[Class15.smethod_0(5)];
  private static int[] int_12 = new int[Class15.smethod_0(5)];
  private static bool bool_0 = Class15.smethod_0(0) != 0;
  private static long long_0 = (long) Class15.smethod_0(0);
  private static long long_1 = (long) Class15.smethod_0(19);

  public static void smethod_0()
  {
    if ((!GClass57.bool_0 ? 1 : 0) == 0)
      GClass57.smethod_4();
    if (GClass57.int_8 <= Class15.smethod_0(120) || (!GClass57.bool_0 ? 1 : 0) != 0)
      return;
    GClass57.bool_0 = Class15.smethod_0(0) != 0;
    GClass57.gclass134_0.method_9();
    GClass57.gclass134_0.method_0((object) new GClass58(GClass151.smethod_18(Class15.smethod_0(32), GClass62.int_10 - Class15.smethod_0(32)), GClass151.smethod_18(GClass62.int_11 - Class15.smethod_0(21), GClass62.int_11), Class15.smethod_0(3), Class15.smethod_0(107)));
  }

  public static void smethod_1(GClass98 g)
  {
    GClass57.smethod_0();
    g.method_16(Class15.smethod_0(0));
    g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass57.int_0, GClass57.int_1);
    g.method_16(Class15.smethod_0(133));
    for (int index = Class15.smethod_0(0); index < GClass57.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass58) GClass57.gclass134_0.method_3(index)).method_0(g);
    if ((!GClass57.bool_0 ? 0 : 1) != 0)
      return;
    GClass57.smethod_2(-(GClass93.smethod_0(GClass57.gclass130_0.method_0() % Class15.smethod_0(5)) + Class15.smethod_0(3)));
  }

  public static void smethod_2(int k)
  {
    if (k == Class15.smethod_0(192) && (!GClass57.bool_0 ? 0 : 1) == 0)
    {
      GClass57.int_6 = GClass57.int_0 / Class15.smethod_0(7);
      GClass57.int_5 = Class15.smethod_0(25);
      GClass57.bool_0 = Class15.smethod_0(1) != 0;
      GClass57.smethod_3();
    }
    else if (k == Class15.smethod_0(252) && (!GClass57.bool_0 ? 0 : 1) == 0)
    {
      GClass57.int_5 = Class15.smethod_0(4);
      GClass57.int_6 = Class15.smethod_0(0);
      GClass57.bool_0 = Class15.smethod_0(1) != 0;
      GClass57.smethod_3();
    }
    else
    {
      if (k != Class15.smethod_0(256) || (!GClass57.bool_0 ? 0 : 1) != 0)
        return;
      GClass57.int_5 = Class15.smethod_0(98);
      GClass57.int_6 = GClass57.int_0;
      GClass57.bool_0 = Class15.smethod_0(1) != 0;
      GClass57.smethod_3();
    }
  }

  public static void smethod_3()
  {
    GClass57.int_7 = Class15.smethod_0(0);
    GClass57.int_9 = Class15.smethod_0(10);
    GClass57.int_8 = Class15.smethod_0(0);
    GClass57.float_0 = Class15.smethod_2(0);
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(5); index += Class15.smethod_0(1))
    {
      GClass57.int_12[index] = Class15.smethod_0(0);
      GClass57.int_11[index] = GClass57.int_6;
    }
    GClass57.bool_0 = Class15.smethod_0(1) != 0;
  }

  public static void smethod_4()
  {
    GClass57.int_12[Class15.smethod_0(7)] = GClass57.int_12[Class15.smethod_0(1)];
    GClass57.int_11[Class15.smethod_0(7)] = GClass57.int_11[Class15.smethod_0(1)];
    GClass57.int_12[Class15.smethod_0(1)] = GClass57.int_12[Class15.smethod_0(0)];
    GClass57.int_11[Class15.smethod_0(1)] = GClass57.int_11[Class15.smethod_0(0)];
    GClass57.int_12[Class15.smethod_0(0)] = GClass57.int_4;
    GClass57.int_11[Class15.smethod_0(0)] = GClass57.int_3;
    GClass57.int_3 = GClass151.smethod_2((int) ((double) GClass57.int_5 * Class15.smethod_3(4) / Class15.smethod_3(5))) * GClass57.int_9 * GClass57.int_8 + GClass57.int_6;
    GClass57.int_4 = (int) ((double) (GClass57.int_9 * GClass151.smethod_1((int) ((double) GClass57.int_5 * Class15.smethod_3(4) / Class15.smethod_3(5))) * GClass57.int_8) - (double) GClass57.float_0 * (double) GClass57.int_8 * (double) GClass57.int_8 / (double) Class15.smethod_2(17)) + GClass57.int_7;
    if (GClass57.smethod_5() - GClass57.long_0 < GClass57.long_1)
      return;
    GClass57.int_8 += Class15.smethod_0(1);
    GClass57.long_0 = GClass57.smethod_5();
  }

  public static long smethod_5() => GClass126.smethod_18();
}
