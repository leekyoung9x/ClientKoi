// Decompiled with JetBrains decompiler
// Type: GClass63
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using UnityEngine;

public class GClass63
{
  public static string string_0 = Class13.smethod_0(139726);
  public static int int_0 = Class15.smethod_0(338);
  public static string string_1;
  public static int int_1;
  public static sbyte sbyte_0;
  public static string string_2 = Class13.smethod_0(139712);
  public static GClass62 gclass62_0;
  public static GClass63 gclass63_0;
  public static bool bool_0;
  public static bool bool_1;

  public GClass63() => this.method_0();

  public void method_0()
  {
    GClass63.gclass63_0 = this;
    GClass107.gclass107_0 = new GClass107();
    GClass157.smethod_0().imethod_1((GInterface4) GClass32.smethod_0());
    GClass159.smethod_0().imethod_1((GInterface4) GClass32.smethod_0());
    GClass159.bool_0 = Class15.smethod_0(0) != 0;
    GClass63.gclass63_0 = this;
    GClass63.gclass62_0 = new GClass62();
    GClass63.gclass62_0.method_6();
    GClass122.smethod_4();
    GClass122.smethod_2();
    GClass62.gclass113_0 = (GClass113) new GClass122();
  }

  public void method_1()
  {
    if (Main.int_2 == Class15.smethod_0(37))
    {
      GClass126.smethod_31();
    }
    else
    {
      GClass62.bool_10 = Class15.smethod_0(0) != 0;
      GClass126.smethod_26();
      this.method_2();
    }
  }

  public static void smethod_0(
    string data,
    string to,
    GClass31 successAction,
    GClass31 failAction)
  {
    GClass33.smethod_0(Class13.smethod_0(139710));
  }

  public static void smethod_1(string url)
  {
    GClass33.smethod_5(Class13.smethod_0(139689) + url);
    Application.OpenURL(url);
  }

  public void method_2() => Main.smethod_2();

  public void method_3(string url)
  {
    GClass33.smethod_5(Class13.smethod_0(139765) + url);
    Application.OpenURL(url);
  }
}
