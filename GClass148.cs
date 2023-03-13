// Decompiled with JetBrains decompiler
// Type: GClass148
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass148
{
  public static GClass134 gclass134_0 = new GClass134();
  public int sayWidth;
  public int sayRun;
  public string[] says;
  public int cx;
  public int cy;
  public int cw;
  public int ch;
  public static int int_0;
  public static int int_1;
  public static int int_2;
  public bool isWayPoint;
  public int tDelay;
  private int int_3;
  public GClass31 command;
  public bool isPaint = Class15.smethod_0(1) != 0;
  public bool isHide;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public GClass66 imgFocus;
  public GClass66 imgUnFocus;

  public GClass148(string info, int x, int y)
  {
    this.sayWidth = Class15.smethod_0(21);
    if (info.Length < Class15.smethod_0(31))
      this.sayWidth = Class15.smethod_0(4);
    if (GClass62.int_10 == Class15.smethod_0(212))
      this.sayWidth = Class15.smethod_0(212);
    this.says = GClass97.gclass97_6.method_15(info, this.sayWidth - Class15.smethod_0(31));
    this.sayRun = Class15.smethod_0(38);
    this.cx = x - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
    this.cy = y - Class15.smethod_0(9) + this.sayRun - this.says.Length * Class15.smethod_0(66) - Class15.smethod_0(31);
    this.cw = this.sayWidth + Class15.smethod_0(7);
    this.ch = (this.says.Length + Class15.smethod_0(1)) * Class15.smethod_0(66) + Class15.smethod_0(1);
    while ((this.cw % Class15.smethod_0(31) == 0 ? 0 : 1) != 0)
      this.cw += Class15.smethod_0(1);
    while ((this.ch % Class15.smethod_0(31) == 0 ? 0 : 1) != 0)
      this.ch += Class15.smethod_0(1);
    if (x >= Class15.smethod_0(0) && x <= Class15.smethod_0(40))
      this.cx += this.cw / Class15.smethod_0(7) + Class15.smethod_0(6);
    if (x <= GClass185.int_21 * Class15.smethod_0(40) && x >= GClass185.int_21 * Class15.smethod_0(40) - Class15.smethod_0(40))
      this.cx -= this.cw / Class15.smethod_0(7) + Class15.smethod_0(37);
    while (this.cx <= Class15.smethod_0(6))
      this.cx += Class15.smethod_0(7);
    while (this.cx + this.cw >= GClass185.int_21 * Class15.smethod_0(40) - Class15.smethod_0(6))
      this.cx -= Class15.smethod_0(7);
  }

  public static void smethod_0()
  {
    if ((GClass148.gclass66_0 == null ? 0 : 1) == 0)
      GClass148.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(155285));
    if ((GClass148.gclass66_1 == null ? 0 : 1) == 0)
      GClass148.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(155381));
    if ((GClass148.gclass66_2 == null ? 0 : 1) != 0)
      return;
    GClass148.gclass66_2 = GClass62.smethod_40(Class13.smethod_0(155346));
  }

  public void method_0(string[] info, int x, int y)
  {
    this.sayWidth = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < info.Length; index += Class15.smethod_0(1))
    {
      if (this.sayWidth < GClass97.gclass97_6.method_17(info[index]))
        this.sayWidth = GClass97.gclass97_6.method_17(info[index]);
    }
    this.sayWidth += Class15.smethod_0(51);
    this.says = info;
    this.sayRun = Class15.smethod_0(38);
    this.cx = x - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
    this.cy = y - Class15.smethod_0(9) + this.sayRun - this.says.Length * Class15.smethod_0(66) - Class15.smethod_0(31);
    this.cw = this.sayWidth + Class15.smethod_0(7);
    this.ch = (this.says.Length + Class15.smethod_0(1)) * Class15.smethod_0(66) + Class15.smethod_0(1);
    while ((this.cw % Class15.smethod_0(31) == 0 ? 0 : 1) != 0)
      this.cw += Class15.smethod_0(1);
    while ((this.ch % Class15.smethod_0(31) == 0 ? 0 : 1) != 0)
      this.ch += Class15.smethod_0(1);
    if (x >= Class15.smethod_0(0) && x <= Class15.smethod_0(40))
      this.cx += this.cw / Class15.smethod_0(7) + Class15.smethod_0(6);
    if (x <= GClass185.int_21 * Class15.smethod_0(40) && x >= GClass185.int_21 * Class15.smethod_0(40) - Class15.smethod_0(40))
      this.cx -= this.cw / Class15.smethod_0(7) + Class15.smethod_0(37);
    while (this.cx <= Class15.smethod_0(6))
      this.cx += Class15.smethod_0(7);
    while (this.cx + this.cw >= GClass185.int_21 * Class15.smethod_0(40) - Class15.smethod_0(6))
      this.cx -= Class15.smethod_0(7);
  }

  public static void smethod_1(int x, int y, string info) => GClass148.gclass134_0.method_0((object) new GClass148(info, x, y));

  public static void smethod_2(GClass148 p) => GClass148.gclass134_0.method_0((object) p);

  public static void smethod_3(GClass148 p) => GClass148.gclass134_0.method_8((object) p);

  public void method_1(GClass98 g, int x, int y, int w, int h, int color, bool isFocus)
  {
    if (color == Class15.smethod_0(1))
      g.method_10(x, y, w, h, Class15.smethod_0(142), Class15.smethod_0(23));
    else
      g.method_10(x, y, w, h, Class15.smethod_0(0), Class15.smethod_0(216));
  }

  public static void smethod_4(
    GClass98 g,
    int x,
    int y,
    int w,
    int h,
    int color,
    bool isButton)
  {
    if (!isButton)
    {
      g.method_16(Class15.smethod_0(0));
      g.method_15(x + Class15.smethod_0(37), y, w - Class15.smethod_0(49) + Class15.smethod_0(1), h);
      g.method_15(x, y + Class15.smethod_0(37), w, h - Class15.smethod_0(66) + Class15.smethod_0(1));
      g.method_16(color);
      g.method_15(x + Class15.smethod_0(37), y + Class15.smethod_0(1), w - Class15.smethod_0(66), h - Class15.smethod_0(7));
      g.method_15(x + Class15.smethod_0(1), y + Class15.smethod_0(37), w - Class15.smethod_0(7), h - Class15.smethod_0(66));
      g.method_24(GClass148.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(38), Class15.smethod_0(37), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
      g.method_24(GClass148.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(38), Class15.smethod_0(37), Class15.smethod_0(7), x + w - Class15.smethod_0(38), y, Class15.smethod_0(0));
      g.method_24(GClass148.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(38), Class15.smethod_0(37), Class15.smethod_0(1), x, y + h - Class15.smethod_0(37), Class15.smethod_0(0));
      g.method_24(GClass148.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(38), Class15.smethod_0(37), Class15.smethod_0(5), x + w - Class15.smethod_0(38), y + h - Class15.smethod_0(37), Class15.smethod_0(0));
    }
    else
    {
      GClass66 gclass66 = color != Class15.smethod_0(1) ? GClass148.gclass66_1 : GClass148.gclass66_2;
      g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
      g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(51), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x + w - Class15.smethod_0(31), y, Class15.smethod_0(0));
      g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(32), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x, y + h - Class15.smethod_0(31), Class15.smethod_0(0));
      g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(152), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x + w - Class15.smethod_0(31), y + h - Class15.smethod_0(31), Class15.smethod_0(0));
      int num1 = (w - Class15.smethod_0(51)) % Class15.smethod_0(31) != 0 ? (w - Class15.smethod_0(51)) / Class15.smethod_0(31) + Class15.smethod_0(1) : (w - Class15.smethod_0(51)) / Class15.smethod_0(31);
      int num2 = (h - Class15.smethod_0(51)) % Class15.smethod_0(31) != 0 ? (h - Class15.smethod_0(51)) / Class15.smethod_0(31) + Class15.smethod_0(1) : (h - Class15.smethod_0(51)) / Class15.smethod_0(31);
      for (int index = Class15.smethod_0(0); index < num1; index += Class15.smethod_0(1))
        g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x + Class15.smethod_0(31) + index * Class15.smethod_0(31), y, Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < num2; index += Class15.smethod_0(1))
        g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(6), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x, y + Class15.smethod_0(31) + index * Class15.smethod_0(31), Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < num1; index += Class15.smethod_0(1))
        g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(4), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x + Class15.smethod_0(31) + index * Class15.smethod_0(31), y + h - Class15.smethod_0(31), Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < num2; index += Class15.smethod_0(1))
        g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(54), Class15.smethod_0(31), Class15.smethod_0(31), Class15.smethod_0(0), x + w - Class15.smethod_0(31), y + Class15.smethod_0(31) + index * Class15.smethod_0(31), Class15.smethod_0(0));
      g.method_16(color != Class15.smethod_0(1) ? Class15.smethod_0(557) : Class15.smethod_0(556));
      g.method_15(x + Class15.smethod_0(31), y + Class15.smethod_0(31), w - Class15.smethod_0(51), h - Class15.smethod_0(51));
    }
  }

  public void method_2(GClass98 g)
  {
    if ((!this.isPaint ? 1 : 0) != 0 || (this.says == null ? 1 : 0) != 0 || (GClass43.gclass43_0 == null ? 0 : 1) != 0 || (!this.isHide ? 0 : 1) != 0)
      return;
    this.method_1(g, this.cx, this.cy - GClass62.int_52, this.cw, this.ch, (this.int_3 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(1) != 0);
    for (int index = Class15.smethod_0(0); index < this.says.Length; index += Class15.smethod_0(1))
      ((this.int_3 == 0 ? 0 : 1) != 0 ? GClass97.gclass97_7 : GClass97.gclass97_3).method_6(g, this.says[index], this.cx + this.cw / Class15.smethod_0(7), this.cy + (this.ch / Class15.smethod_0(7) - this.says.Length * Class15.smethod_0(66) / Class15.smethod_0(7)) + index * Class15.smethod_0(66) - GClass62.int_52, Class15.smethod_0(7));
  }

  private void method_3()
  {
    if ((GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && (GClass20.smethod_1().taskMaint.taskId == (short) 0 ? 0 : 1) == 0)
      this.isHide = this.cx + this.cw < GClass116.int_22 || this.cx > GClass62.int_10 + GClass116.int_22 || this.cy + this.ch < GClass116.int_23 || this.cy > GClass62.int_11 + GClass116.int_23 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
    if ((GClass20.smethod_1().taskMaint == null ? 1 : 0) != 0 || (GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && (GClass20.smethod_1().taskMaint.taskId == (short) 0 ? 1 : 0) == 0)
      this.isHide = this.cx + this.cw / Class15.smethod_0(7) < GClass20.smethod_1().cx - Class15.smethod_0(21) || this.cx + this.cw / Class15.smethod_0(7) > GClass20.smethod_1().cx + Class15.smethod_0(21) || this.cy + this.ch < GClass116.int_23 || this.cy > GClass62.int_11 + GClass116.int_23 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
    if (this.int_3 > Class15.smethod_0(0))
    {
      this.int_3 -= Class15.smethod_0(1);
      if ((this.int_3 == 0 ? 0 : 1) == 0 && (this.command == null ? 1 : 0) == 0)
        this.command.method_1();
    }
    if ((!this.isWayPoint ? 0 : 1) == 0)
      return;
    if ((GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0)
    {
      if ((GClass20.smethod_1().taskMaint.taskId == (short) 0 ? 0 : 1) == 0)
      {
        if ((GClass20.smethod_1().taskMaint.index == 0 ? 0 : 1) == 0)
          this.isPaint = Class15.smethod_0(0) != 0;
        if (GClass20.smethod_1().taskMaint.index == Class15.smethod_0(1))
          this.isPaint = Class15.smethod_0(1) != 0;
        if (GClass20.smethod_1().taskMaint.index <= Class15.smethod_0(1) || GClass20.smethod_1().taskMaint.index >= Class15.smethod_0(37))
          return;
        this.isPaint = Class15.smethod_0(0) != 0;
      }
      else
      {
        if ((!this.isPaint ? 0 : 1) != 0)
          return;
        this.tDelay += Class15.smethod_0(1);
        if (this.tDelay != Class15.smethod_0(32))
          return;
        this.isPaint = Class15.smethod_0(1) != 0;
      }
    }
    else
    {
      if ((!this.isPaint ? 0 : 1) != 0)
        return;
      GClass65.bool_5 = Class15.smethod_0(0) != 0;
      this.tDelay += Class15.smethod_0(1);
      if (this.tDelay != Class15.smethod_0(32))
        return;
      this.isPaint = Class15.smethod_0(1) != 0;
      GClass65.bool_5 = Class15.smethod_0(1) != 0;
    }
  }

  public void method_4(int timeDelay) => this.int_3 = timeDelay;

  public static void smethod_5(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < GClass148.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass148) GClass148.gclass134_0.method_3(index)).method_2(g);
  }

  public static void smethod_6()
  {
    for (int index = Class15.smethod_0(0); index < GClass148.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass148) GClass148.gclass134_0.method_3(index)).method_3();
  }
}
