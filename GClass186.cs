// Decompiled with JetBrains decompiler
// Type: GClass186
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass186
{
  public static GInterface0 ginterface0_0;
  public static int int_0;
  public static long long_0;
  public static bool bool_0;

  public static void smethod_0(GInterface0 actionListener, int action, long timeEllapse)
  {
    GClass186.ginterface0_0 = actionListener;
    GClass186.int_0 = action;
    GClass186.long_0 = GClass126.smethod_18() + timeEllapse;
    GClass186.bool_0 = Class15.smethod_0(1) != 0;
  }

  public static void smethod_1()
  {
    long num = GClass126.smethod_18();
    if ((!GClass186.bool_0 ? 1 : 0) != 0 || num <= GClass186.long_0)
      return;
    GClass186.bool_0 = Class15.smethod_0(0) != 0;
    try
    {
      if (GClass186.int_0 <= Class15.smethod_0(0))
        return;
      GClass116.smethod_6().method_116(GClass186.int_0, (object) null);
    }
    catch (Exception ex)
    {
    }
  }
}
