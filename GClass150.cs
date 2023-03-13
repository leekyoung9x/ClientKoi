// Decompiled with JetBrains decompiler
// Type: GClass150
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass150
{
  public int x;
  public int y;
  public int anchor;
  public int g;
  public int v;
  public int w;
  public int h;
  public int color;
  public int limitY;
  public GClass90 layer;
  public short yTo;
  public short xTo;
  public short distant;

  public GClass150()
  {
    this.x = Class15.smethod_0(0);
    this.y = Class15.smethod_0(0);
  }

  public GClass150(int x, int y, int anchor)
  {
    this.x = x;
    this.y = y;
    this.anchor = anchor;
  }

  public GClass150(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public void method_0(int xT, int yT)
  {
    this.xTo = (short) xT;
    this.yTo = (short) yT;
    this.distant = (short) GClass151.smethod_22(this.x, this.y, (int) this.xTo, (int) this.yTo);
  }

  public int method_1()
  {
    if (this.x == (int) this.xTo && this.y == (int) this.yTo)
      return -1;
    if (GClass93.smethod_0(((int) this.xTo - this.x) / Class15.smethod_0(7)) <= Class15.smethod_0(1) && GClass93.smethod_0(((int) this.yTo - this.y) / Class15.smethod_0(7)) <= Class15.smethod_0(1))
    {
      this.x = (int) this.xTo;
      this.y = (int) this.yTo;
      return Class15.smethod_0(0);
    }
    if (this.x != (int) this.xTo)
      this.x += ((int) this.xTo - this.x) / Class15.smethod_0(7);
    if (this.y != (int) this.yTo)
      this.y += ((int) this.yTo - this.y) / Class15.smethod_0(7);
    return GClass151.smethod_22(this.x, this.y, (int) this.xTo, (int) this.yTo) <= (int) this.distant / Class15.smethod_0(3) ? Class15.smethod_0(7) : Class15.smethod_0(1);
  }

  public void method_2() => this.layer.method_0();

  public void method_3(GClass98 g) => this.layer.method_1(g, this.x, this.y);
}
