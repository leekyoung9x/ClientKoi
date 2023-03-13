// Decompiled with JetBrains decompiler
// Type: GClass107
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass107
{
  public static GClass107 gclass107_0;
  public GClass62 tCanvas;
  public int zoomLevel = Class15.smethod_0(1);
  public GClass66 imgCache;
  private int[] int_0;
  private int int_1;
  private int int_2;
  private int[] int_3;
  private int int_4 = Class15.smethod_0(51);

  public GClass107() => this.method_0(this.method_1(), this.method_2());

  public void method_0(int w, int h)
  {
    if ((!Main.bool_4 ? 1 : 0) == 0)
    {
      GClass98.int_8 = Class15.smethod_0(7);
      if (w * h >= Class15.smethod_0(435))
      {
        GClass98.int_8 = Class15.smethod_0(2);
      }
      else
      {
        if (w * h <= Class15.smethod_0(436))
          return;
        GClass98.int_8 = Class15.smethod_0(5);
      }
    }
    else if ((!Main.bool_3 ? 0 : 1) == 0)
    {
      if ((!Main.bool_1 ? 1 : 0) == 0)
        GClass98.int_8 = Class15.smethod_0(7);
      else if (w * h >= Class15.smethod_0(435))
        GClass98.int_8 = Class15.smethod_0(2);
      else if (w * h >= Class15.smethod_0(437))
      {
        GClass98.int_8 = Class15.smethod_0(5);
      }
      else
      {
        if (w * h <= Class15.smethod_0(438))
          return;
        GClass98.int_8 = Class15.smethod_0(7);
      }
    }
    else
    {
      GClass98.int_8 = Class15.smethod_0(7);
      if (w * h >= Class15.smethod_0(439))
        return;
      GClass98.int_8 = Class15.smethod_0(1);
    }
  }

  public int method_1() => (int) GClass153.float_0;

  public int method_2() => (int) GClass153.float_1;

  public void method_3(GClass62 tCanvas) => this.tCanvas = tCanvas;

  protected void method_4(GClass98 g) => this.tCanvas.method_20(g);

  protected void method_5(int keyCode) => this.tCanvas.method_10(keyCode);

  protected void method_6(int keyCode) => this.tCanvas.method_12(keyCode);

  protected void method_7(int x, int y)
  {
    x /= GClass98.int_8;
    y /= GClass98.int_8;
    this.tCanvas.method_16(x, y);
  }

  protected void method_8(int x, int y)
  {
    x /= GClass98.int_8;
    y /= GClass98.int_8;
    this.tCanvas.method_17(x, y);
  }

  protected void method_9(int x, int y)
  {
    x /= GClass98.int_8;
    y /= GClass98.int_8;
    this.tCanvas.method_18(x, y);
  }

  public int method_10()
  {
    int num = this.method_1();
    return num / GClass98.int_8 + num % GClass98.int_8;
  }

  public int method_11()
  {
    int num = this.method_2();
    return num / GClass98.int_8 + num % GClass98.int_8;
  }
}
