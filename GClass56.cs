// Decompiled with JetBrains decompiler
// Type: GClass56
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass56
{
  public int w;
  public int h;
  public int v;
  public int x0;
  public int x;
  public int y;
  public int y0;
  public int angle;
  public int t;
  public int cl = Class15.smethod_0(133);
  private float float_0;
  private long long_0;
  private long long_1 = (long) Class15.smethod_0(19);
  private bool bool_0 = Class15.smethod_0(1) != 0;
  private int[] int_0 = new int[Class15.smethod_0(7)];
  private int[] int_1 = new int[Class15.smethod_0(7)];

  public GClass56(int x0, int y0, int v, int angle, int cl)
  {
    this.y0 = y0;
    this.x0 = x0;
    this.float_0 = Class15.smethod_2(16);
    this.v = v;
    this.angle = angle;
    this.w = GClass62.int_10;
    this.h = GClass62.int_11;
    this.long_0 = this.method_2();
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(7); index += Class15.smethod_0(1))
    {
      this.int_0[index] = x0;
      this.int_1[index] = y0;
    }
    this.cl = cl;
  }

  public void method_0()
  {
    if (this.method_2() - this.long_0 < this.long_1)
      return;
    this.t += Class15.smethod_0(1);
    this.long_0 = this.method_2();
    this.int_0[Class15.smethod_0(1)] = this.int_0[Class15.smethod_0(0)];
    this.int_1[Class15.smethod_0(1)] = this.int_1[Class15.smethod_0(0)];
    this.int_0[Class15.smethod_0(0)] = this.x;
    this.int_1[Class15.smethod_0(0)] = this.y;
    this.x = GClass151.smethod_2((int) ((double) this.angle * Class15.smethod_3(4) / Class15.smethod_3(5))) * this.v * this.t + this.x0;
    this.y = (int) ((double) (this.v * GClass151.smethod_1((int) ((double) this.angle * Class15.smethod_3(4) / Class15.smethod_3(5))) * this.t) - (double) this.float_0 * (double) this.t * (double) this.t / (double) Class15.smethod_2(17)) + this.y0;
  }

  public void method_1(GClass98 g)
  {
    this.method_3(g, this.w - this.x, this.h - this.y, this.cl);
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(7); index += Class15.smethod_0(1))
      this.method_3(g, this.w - this.int_0[index], this.h - this.int_1[index], this.cl);
    if ((!this.bool_0 ? 1 : 0) != 0)
      return;
    this.method_0();
  }

  public long method_2() => GClass126.smethod_18();

  public void method_3(GClass98 g, int x, int y, int color)
  {
    g.method_16(color);
    g.method_15(x, y, Class15.smethod_0(1), Class15.smethod_0(7));
  }
}
