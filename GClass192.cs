// Decompiled with JetBrains decompiler
// Type: GClass192
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass192
{
  public GClass66 img;
  public int id;
  public int timePaint;
  public int timeUpdate;

  public GClass192(GClass66 img, int id)
  {
    this.img = img;
    this.id = id;
    this.timePaint = Class15.smethod_0(0);
    this.timeUpdate = Class15.smethod_0(0);
  }

  public void method_0(GClass98 g, int transform, int x, int y, int anchor)
  {
    g.method_24(this.img, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(this.img), GClass98.smethod_1(this.img), transform, x, y, anchor);
    if ((GClass62.int_8 % Class15.smethod_0(15) == 0 ? 0 : 1) != 0)
      return;
    this.timePaint += Class15.smethod_0(1);
    this.timeUpdate = this.timePaint;
  }

  public void method_1(
    GClass98 g,
    int transform,
    int f,
    int x,
    int y,
    int w,
    int h,
    int anchor)
  {
    this.method_2(g, transform, f, x, y, w, h, anchor, Class15.smethod_0(0) != 0);
  }

  public void method_2(
    GClass98 g,
    int transform,
    int f,
    int x,
    int y,
    int w,
    int h,
    int anchor,
    bool isClip)
  {
    if (GClass98.smethod_0(this.img) == Class15.smethod_0(1))
      return;
    g.method_26(this.img, Class15.smethod_0(0), f * w, w, h, transform, x, y, anchor, isClip);
    if ((GClass62.int_8 % Class15.smethod_0(15) == 0 ? 0 : 1) != 0)
      return;
    this.timePaint += Class15.smethod_0(1);
    this.timeUpdate = this.timePaint;
  }

  public void method_3()
  {
    this.timeUpdate += Class15.smethod_0(1);
    if (this.timeUpdate - this.timePaint <= Class15.smethod_0(1) || (!GClass20.smethod_1().method_91(this.id) ? 0 : 1) != 0)
      return;
    GClass169.gclass192_0[this.id] = (GClass192) null;
  }
}
