// Decompiled with JetBrains decompiler
// Type: GClass183
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass183
{
  public static int int_0;
  public static int int_1;
  public static int int_2;
  public static bool bool_0;
  public static string string_0 = string.Empty;

  public static void smethod_0()
  {
    GClass183.int_0 = Class15.smethod_0(0);
    GClass183.int_1 = Class15.smethod_0(0);
    GClass183.bool_0 = Class15.smethod_0(0) != 0;
  }

  public static void smethod_1(GClass98 g, string str, int x, int y, int w, int h, GClass97 f)
  {
    if (GClass183.int_2 != f.method_17(str) || (!GClass183.string_0.Equals(str) ? 0 : 1) == 0)
    {
      GClass183.string_0 = str;
      GClass183.int_0 = Class15.smethod_0(0);
      GClass183.int_2 = f.method_17(str);
      GClass183.bool_0 = Class15.smethod_0(0) != 0;
      GClass183.int_1 = Class15.smethod_0(0);
    }
    g.method_5(x, y, w, h);
    if (GClass183.int_2 > w)
      f.method_6(g, str, x - GClass183.int_0, y, Class15.smethod_0(0));
    else
      f.method_6(g, str, x + w / Class15.smethod_0(7), y, Class15.smethod_0(7));
    GClass62.smethod_6(g);
    if (GClass183.int_2 <= w)
      return;
    if ((!GClass183.bool_0 ? 0 : 1) == 0)
    {
      GClass183.int_1 += Class15.smethod_0(1);
      if (GClass183.int_1 <= Class15.smethod_0(32))
        return;
      GClass183.int_0 += Class15.smethod_0(1);
      if (GClass183.int_0 < GClass183.int_2)
        return;
      GClass183.int_1 = Class15.smethod_0(0);
      GClass183.int_0 = -w + Class15.smethod_0(6);
      GClass183.bool_0 = Class15.smethod_0(1) != 0;
    }
    else
    {
      if (GClass183.int_0 < Class15.smethod_0(0))
      {
        int num = w + GClass183.int_0 >> Class15.smethod_0(1);
        GClass183.int_0 += num;
      }
      if (GClass183.int_0 > Class15.smethod_0(0))
        GClass183.int_0 = Class15.smethod_0(0);
      if ((GClass183.int_0 == 0 ? 0 : 1) != 0)
        return;
      GClass183.int_1 += Class15.smethod_0(1);
      if (GClass183.int_1 != Class15.smethod_0(32))
        return;
      GClass183.int_1 = Class15.smethod_0(0);
      GClass183.bool_0 = Class15.smethod_0(0) != 0;
    }
  }
}
