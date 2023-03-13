// Decompiled with JetBrains decompiler
// Type: GClass71
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass71
{
  public static bool bool_0;
  private static string string_0;
  private static string string_1;
  public static int int_0;
  public static bool bool_1;

  public static void smethod_0(string title, string subtitle, int delay)
  {
    if ((title == null ? 1 : 0) != 0)
      return;
    GClass71.bool_0 = Class15.smethod_0(1) != 0;
    GClass71.string_0 = title;
    GClass71.string_1 = subtitle;
    GClass71.int_0 = delay;
  }

  public static void smethod_1()
  {
    GClass71.smethod_0(GClass109.string_83, (string) null, Class15.smethod_0(15));
    GClass71.bool_1 = Class15.smethod_0(1) != 0;
  }

  public static void smethod_2(string str)
  {
    GClass71.smethod_0(str, (string) null, Class15.smethod_0(403));
    GClass71.bool_1 = Class15.smethod_0(1) != 0;
  }

  public static void smethod_3(GClass98 g)
  {
    if ((!GClass71.bool_0 ? 1 : 0) != 0 || (!GClass71.bool_1 ? 1 : 0) == 0 && GClass71.int_0 > Class15.smethod_0(404) || (!GClass116.bool_9 ? 0 : 1) != 0)
      return;
    int y = Class15.smethod_0(31);
    GClass62.gclass140_0.method_33(GClass62.int_12 - Class15.smethod_0(62), y, Class15.smethod_0(19), Class15.smethod_0(280), g);
    if ((!GClass71.bool_1 ? 1 : 0) == 0)
    {
      GClass62.smethod_44(GClass62.int_12 - GClass97.gclass97_21.method_17(GClass71.string_0) / Class15.smethod_0(7) - Class15.smethod_0(31), y + Class15.smethod_0(35), g);
      GClass97.gclass97_21.method_6(g, GClass71.string_0, GClass62.int_12 + Class15.smethod_0(3), y + Class15.smethod_0(27), Class15.smethod_0(7));
    }
    else if ((GClass71.string_1 == null ? 1 : 0) == 0)
    {
      GClass97.gclass97_21.method_6(g, GClass71.string_0, GClass62.int_12, y + Class15.smethod_0(47), Class15.smethod_0(7));
      GClass97.gclass97_14.method_6(g, GClass71.string_1, GClass62.int_12, y + Class15.smethod_0(6), Class15.smethod_0(7));
    }
    else
      GClass97.gclass97_21.method_6(g, GClass71.string_0, GClass62.int_12, y + Class15.smethod_0(27), Class15.smethod_0(7));
  }

  public static void smethod_4()
  {
    if (GClass71.int_0 <= Class15.smethod_0(0))
      return;
    GClass71.int_0 -= Class15.smethod_0(1);
    if ((GClass71.int_0 == 0 ? 0 : 1) != 0)
      return;
    GClass71.smethod_5();
  }

  public static void smethod_5()
  {
    GClass71.string_0 = string.Empty;
    GClass71.string_1 = (string) null;
    GClass71.bool_1 = Class15.smethod_0(0) != 0;
    GClass71.int_0 = Class15.smethod_0(0);
    GClass71.bool_0 = Class15.smethod_0(0) != 0;
  }
}
