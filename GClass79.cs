// Decompiled with JetBrains decompiler
// Type: GClass79
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass79
{
  private static GClass188 gclass188_0;
  public static int int_0;
  public static int int_1 = Class15.smethod_0(1);
  public static int int_2 = Class15.smethod_0(7);
  private static GClass31 gclass31_0;

  public static void smethod_0(string caption, int type, string text, GClass31 action)
  {
    GClass79.gclass31_0 = action;
    GEnum0 t = (type == 0 ? 1 : 0) != 0 || type == Class15.smethod_0(7) ? (GEnum0) Class15.smethod_0(1) : (GEnum0) Class15.smethod_0(7);
    GClass188.bool_0 = Class15.smethod_0(0) != 0;
    GClass79.gclass188_0 = GClass188.smethod_0(text, t, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, type == Class15.smethod_0(7), Class15.smethod_0(0) != 0, caption);
  }

  public static void smethod_1()
  {
    try
    {
      if ((GClass79.gclass188_0 == null ? 1 : 0) != 0 || (!GClass79.gclass188_0.done ? 1 : 0) != 0)
        return;
      if ((GClass79.gclass31_0 == null ? 1 : 0) == 0)
        GClass79.gclass31_0.method_0(GClass79.gclass188_0.text);
      GClass79.gclass188_0.text = string.Empty;
      GClass79.gclass188_0 = (GClass188) null;
    }
    catch (Exception ex)
    {
    }
  }
}
