// Decompiled with JetBrains decompiler
// Type: GClass135
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass135 : GClass134
{
  public static GClass135 gclass135_0 = new GClass135();
  public static GClass135 gclass135_1 = new GClass135();
  public static GClass135 gclass135_2 = new GClass135();

  public void method_13()
  {
    for (int index = this.method_2() - Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
    {
      GClass54 gclass54 = (GClass54) this.method_3(index);
      if ((gclass54 == null ? 1 : 0) == 0)
      {
        gclass54.method_1();
        if ((!gclass54.isRemove ? 1 : 0) == 0)
          this.method_7(index);
      }
    }
  }

  public static void smethod_0()
  {
    GClass135.gclass135_2.method_13();
    GClass135.gclass135_1.method_13();
    GClass135.gclass135_0.method_13();
  }

  public void method_14(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < this.method_2(); index += Class15.smethod_0(1))
    {
      GClass54 gclass54 = (GClass54) this.method_3(index);
      if ((gclass54 == null ? 1 : 0) == 0 && (!gclass54.isRemove ? 0 : 1) == 0)
        ((GClass54) this.method_3(index)).method_2(g);
    }
  }

  public void method_15()
  {
    for (int index = this.method_2() - Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
    {
      GClass54 gclass54 = (GClass54) this.method_3(index);
      if ((gclass54 == null ? 1 : 0) == 0)
      {
        gclass54.isRemove = Class15.smethod_0(1) != 0;
        this.method_7(index);
      }
    }
  }

  public static void smethod_1(GClass54 eff) => GClass135.gclass135_2.method_0((object) eff);

  public static void smethod_2(GClass54 eff) => GClass135.gclass135_2.method_8((object) eff);

  public static void smethod_3(GClass54 eff) => GClass135.gclass135_1.method_0((object) eff);

  public static void smethod_4(GClass54 eff) => GClass135.gclass135_1.method_8((object) eff);

  public static void smethod_5(GClass54 eff) => GClass135.gclass135_0.method_0((object) eff);

  public static void smethod_6(GClass54 eff) => GClass135.gclass135_0.method_8((object) eff);
}
