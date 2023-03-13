// Decompiled with JetBrains decompiler
// Type: GClass40
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass40
{
  public static GClass134 gclass134_0 = new GClass134();

  public static void smethod_0(GClass41 me) => GClass40.gclass134_0.method_0((object) me);

  public static void smethod_1(int id)
  {
    if ((GClass40.smethod_2(id) == null ? 1 : 0) != 0)
      return;
    GClass40.gclass134_0.method_8((object) GClass40.smethod_2(id));
  }

  public static GClass41 smethod_2(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass41 gclass41 = (GClass41) GClass40.gclass134_0.method_3(index);
      if (gclass41.effId == id)
        return gclass41;
    }
    return (GClass41) null;
  }

  public static void smethod_3(GClass98 g, int x, int y, int layer)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass41) GClass40.gclass134_0.method_3(index)).layer == -layer)
        ((GClass41) GClass40.gclass134_0.method_3(index)).method_1(g, x, y);
    }
  }

  public static void smethod_4(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass41) GClass40.gclass134_0.method_3(index)).layer == Class15.smethod_0(1))
        ((GClass41) GClass40.gclass134_0.method_3(index)).method_3(g);
    }
  }

  public static void smethod_5(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass41) GClass40.gclass134_0.method_3(index)).layer == Class15.smethod_0(7))
        ((GClass41) GClass40.gclass134_0.method_3(index)).method_3(g);
    }
  }

  public static void smethod_6(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass41) GClass40.gclass134_0.method_3(index)).layer == Class15.smethod_0(5))
        ((GClass41) GClass40.gclass134_0.method_3(index)).method_3(g);
    }
  }

  public static void smethod_7(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass41) GClass40.gclass134_0.method_3(index)).layer == Class15.smethod_0(2))
        ((GClass41) GClass40.gclass134_0.method_3(index)).method_3(g);
    }
  }

  public static void smethod_8()
  {
    for (int index = Class15.smethod_0(0); index < GClass40.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass41) GClass40.gclass134_0.method_3(index)).method_4();
  }
}
