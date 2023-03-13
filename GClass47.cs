// Decompiled with JetBrains decompiler
// Type: GClass47
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass47 : GClass42
{
  public GClass49 eff;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private GClass20 gclass20_0;
  private GClass100 gclass100_0;
  private short short_0;
  private long long_0;
  private int int_5;

  public static void smethod_0(int id, int cx, int cy, int loopCount) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    int_3 = cx,
    int_4 = cy,
    short_0 = (short) loopCount
  });

  public static void smethod_1(int id, int cx, int cy, int loopCount, int trans) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    int_3 = cx,
    int_4 = cy,
    short_0 = (short) loopCount,
    int_5 = trans
  });

  public static void smethod_2(int id, GClass100 m, int loopCount) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    gclass100_0 = m,
    short_0 = (short) loopCount
  });

  public static void smethod_3(int id, GClass20 c, int loopCount) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    gclass20_0 = c,
    short_0 = (short) loopCount
  });

  public static void smethod_4(int id, GClass20 c, int loopCount, int trans) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    gclass20_0 = c,
    short_0 = (short) loopCount,
    int_5 = trans
  });

  public static void smethod_5(int id, int cx, int cy, int timeLengthInSecond) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    int_3 = cx,
    int_4 = cy,
    long_0 = (GClass126.smethod_18() + (long) (timeLengthInSecond * Class15.smethod_0(15)))
  });

  public static void smethod_6(int id, GClass20 c, int timeLengthInSecond) => GClass42.gclass134_1.method_0((object) new GClass47()
  {
    eff = GClass116.gclass49_0[id - Class15.smethod_0(1)],
    gclass20_0 = c,
    long_0 = (GClass126.smethod_18() + (long) (timeLengthInSecond * Class15.smethod_0(15)))
  });

  public override void vmethod_1(GClass98 g)
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
      GClass116.int_61 += Class15.smethod_0(1);
    if (GClass116.int_61 >= Class15.smethod_0(88))
      return;
    if ((this.gclass20_0 == null ? 1 : 0) == 0)
    {
      this.int_3 = this.gclass20_0.cx;
      this.int_4 = this.gclass20_0.cy + GClass62.int_52;
    }
    if ((this.gclass100_0 == null ? 1 : 0) == 0)
    {
      this.int_3 = this.gclass100_0.x;
      this.int_4 = this.gclass100_0.y + GClass62.int_52;
    }
    int x = this.int_3 + this.int_1 + this.eff.arrEfInfo[this.int_0].dx;
    int y = this.int_4 + this.int_2 + this.eff.arrEfInfo[this.int_0].dy;
    if ((!GClass62.smethod_43(x, y) ? 1 : 0) != 0)
      return;
    GClass169.smethod_6(g, this.eff.arrEfInfo[this.int_0].idImg, x, y, this.int_5, GClass98.int_1 | GClass98.int_0);
  }

  public override void vmethod_0()
  {
    if ((this.long_0 == 0L ? 1 : 0) == 0)
    {
      this.int_0 += Class15.smethod_0(1);
      if (this.int_0 >= this.eff.arrEfInfo.Length)
        this.int_0 = Class15.smethod_0(0);
      if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(0))
        GClass42.gclass134_1.method_8((object) this);
    }
    else
    {
      this.int_0 += Class15.smethod_0(1);
      if (this.int_0 >= this.eff.arrEfInfo.Length)
      {
        this.short_0 -= (short) Class15.smethod_0(1);
        if ((int) this.short_0 <= Class15.smethod_0(0))
          GClass42.gclass134_1.method_8((object) this);
        else
          this.int_0 = Class15.smethod_0(0);
      }
    }
    if ((GClass62.int_8 % Class15.smethod_0(67) == 0 ? 0 : 1) != 0 || (this.gclass20_0 == null ? 1 : 0) != 0 || this.gclass20_0 == GClass20.smethod_1() || (!GClass116.gclass134_5.method_1((object) this.gclass20_0) ? 0 : 1) != 0)
      return;
    GClass42.gclass134_1.method_8((object) this);
  }
}
