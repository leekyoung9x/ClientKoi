// Decompiled with JetBrains decompiler
// Type: GClass178
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass178 : GInterface0
{
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private GClass31 gclass31_0;
  private GClass31 gclass31_1;
  private GClass31 gclass31_2;
  private int int_4 = Class15.smethod_0(40);
  public int nItem;
  private int int_5 = Class15.smethod_0(32);
  public static GClass154 gclass154_0;
  public int cmtoX;
  public int cmx;
  public int cmvx;
  public int cmdx;
  public bool isShow;
  public bool isGetName;
  public string text;
  private bool bool_0;
  private bool bool_1;
  public GClass134 vItems = new GClass134();
  private int int_6;
  private int int_7;
  private int int_8;
  private GClass155 gclass155_0;

  public GClass178()
  {
    this.gclass31_0 = new GClass31(GClass109.string_146, (GInterface0) this, Class15.smethod_0(1), (object) null);
    this.gclass31_1 = new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(7), (object) null);
  }

  public void method_0()
  {
    if ((!this.isGetName ? 1 : 0) == 0)
    {
      this.int_2 = Class15.smethod_0(162);
      this.int_3 = Class15.smethod_0(447);
      this.int_0 = GClass62.int_10 / Class15.smethod_0(7) - this.int_2 / Class15.smethod_0(7);
      this.int_1 = GClass62.int_11 / Class15.smethod_0(7) - this.int_3 / Class15.smethod_0(7);
    }
    else
    {
      this.int_2 = Class15.smethod_0(162);
      this.int_3 = Class15.smethod_0(162);
      this.int_0 = GClass62.int_10 / Class15.smethod_0(7) - this.int_2 / Class15.smethod_0(7);
      this.int_1 = GClass62.int_11 / Class15.smethod_0(7) - this.int_3 / Class15.smethod_0(7);
      if (GClass62.int_11 < Class15.smethod_0(194))
        this.int_1 -= Class15.smethod_0(31);
    }
    this.cmx = this.int_0;
    this.cmtoX = Class15.smethod_0(0);
    this.nItem = (!this.bool_0 ? 0 : 1) != 0 ? this.vItems.method_2() : GClass26.gclass134_0.method_2();
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.gclass31_0.x = this.int_0;
      this.gclass31_0.y = this.int_1 + this.int_3 + Class15.smethod_0(3);
      this.gclass31_1.x = this.int_0 + this.int_2 - Class15.smethod_0(11);
      this.gclass31_1.y = this.int_1 + this.int_3 + Class15.smethod_0(3);
    }
    GClass178.gclass154_0 = new GClass154();
    GClass178.gclass154_0.method_6(this.nItem, this.int_4, this.int_0, this.int_1 + this.int_5, this.int_2, this.int_3 - this.int_5, Class15.smethod_0(1) != 0, Class15.smethod_0(1));
  }

  public void method_1(bool isGetName)
  {
    if ((GClass20.smethod_1().clan == null ? 1 : 0) == 0)
      this.bool_1 = Class15.smethod_0(1) != 0;
    this.isShow = Class15.smethod_0(1) != 0;
    this.isGetName = isGetName;
    this.method_0();
  }

  public void method_2(int msgID)
  {
    this.isShow = Class15.smethod_0(1) != 0;
    this.bool_0 = Class15.smethod_0(1) != 0;
    this.int_6 = msgID;
    this.method_0();
  }

  public void method_3()
  {
    this.cmtoX = this.int_0 + this.int_2;
    GClass169.smethod_4();
  }

  public void method_4(GClass98 g)
  {
  }

  public void method_5(GClass98 g)
  {
    g.method_1(-this.cmx, Class15.smethod_0(0));
    GClass148.smethod_4(g, this.int_0, this.int_1 - Class15.smethod_0(186), this.int_2, this.int_3 + Class15.smethod_0(186), -1, Class15.smethod_0(1) != 0);
    GClass97.gclass97_6.method_6(g, GClass109.string_282, this.int_0 + this.int_2 / Class15.smethod_0(7), this.int_1 - Class15.smethod_0(38), Class15.smethod_0(7));
    if (this.int_8 >= Class15.smethod_0(0) && this.int_8 <= GClass26.gclass134_0.method_2() - Class15.smethod_0(1))
    {
      GClass26 gclass26 = (GClass26) GClass26.gclass134_0.method_3(this.int_8);
      if ((gclass26.idImage == null ? 1 : 0) == 0)
        GClass20.smethod_1().method_90(g, gclass26.idImage, GClass62.int_10 / Class15.smethod_0(7), this.int_1 + Class15.smethod_0(70), Class15.smethod_0(1), Class15.smethod_0(0) != 0);
    }
    GClass20.smethod_1().method_94(g, GClass62.int_10 / Class15.smethod_0(7), this.int_1 + Class15.smethod_0(70), Class15.smethod_0(1), GClass20.smethod_1().cf, Class15.smethod_0(0) != 0);
    g.method_5(this.int_0, this.int_1 + this.int_5, this.int_2, this.int_3 - this.int_5 - Class15.smethod_0(31));
    if ((GClass178.gclass154_0 == null ? 1 : 0) == 0)
      g.method_1(Class15.smethod_0(0), -GClass178.gclass154_0.cmy);
    for (int index = Class15.smethod_0(0); index < this.nItem; index += Class15.smethod_0(1))
    {
      int x = this.int_0 + Class15.smethod_0(31);
      int y = this.int_1 + index * this.int_4 + this.int_5;
      if (y + this.int_4 - ((GClass178.gclass154_0 == null ? 0 : 1) != 0 ? GClass178.gclass154_0.cmy : Class15.smethod_0(0)) >= this.int_1 + this.int_5 && y - ((GClass178.gclass154_0 == null ? 0 : 1) != 0 ? GClass178.gclass154_0.cmy : Class15.smethod_0(0)) <= this.int_1 + this.int_5 + this.int_3)
      {
        GClass26 gclass26 = (GClass26) GClass26.gclass134_0.method_3(index);
        GClass97 gclass97 = GClass97.gclass97_16;
        if (index == this.int_8)
          gclass97 = GClass97.gclass97_18;
        if ((gclass26.name == null ? 1 : 0) == 0)
          gclass97.method_6(g, gclass26.name, x + Class15.smethod_0(51), y, Class15.smethod_0(0));
        if (gclass26.xu > Class15.smethod_0(0))
          gclass97.method_6(g, gclass26.xu.ToString() + Class13.smethod_0(174207) + GClass109.string_156, x + this.int_2 - Class15.smethod_0(51), y, GClass97.int_1);
        else if (gclass26.luong > Class15.smethod_0(0))
          gclass97.method_6(g, gclass26.luong.ToString() + Class13.smethod_0(174207) + GClass109.string_157, x + this.int_2 - Class15.smethod_0(51), y, GClass97.int_1);
        if ((gclass26.idImage == null ? 1 : 0) == 0)
          GClass169.smethod_6(g, (int) gclass26.idImage[Class15.smethod_0(0)], x, y, Class15.smethod_0(0), Class15.smethod_0(0));
      }
    }
    g.method_1(Class15.smethod_0(0), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    GClass62.gclass140_0.method_7(g, this.gclass31_0, this.gclass31_2, this.gclass31_1);
  }

  public void method_6(GClass98 g)
  {
    if ((!this.bool_0 ? 0 : 1) == 0)
      this.method_5(g);
    else
      this.method_4(g);
  }

  public void method_7()
  {
    if ((GClass178.gclass154_0 == null ? 1 : 0) == 0)
      GClass178.gclass154_0.method_5();
    if (this.cmx != this.cmtoX)
    {
      this.cmvx = this.cmtoX - this.cmx << Class15.smethod_0(7);
      this.cmdx += this.cmvx;
      this.cmx += this.cmdx >> Class15.smethod_0(5);
      this.cmdx &= Class15.smethod_0(9);
    }
    if (GClass93.smethod_0(this.cmtoX - this.cmx) < Class15.smethod_0(31))
      this.cmx = this.cmtoX;
    if (this.cmx < this.int_0 + this.int_2 - Class15.smethod_0(31) || this.cmtoX < this.int_0 + this.int_2 - Class15.smethod_0(31))
      return;
    this.isShow = Class15.smethod_0(0) != 0;
  }

  public void method_8()
  {
    if ((this.gclass31_0 == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.gclass31_0) ? 1 : 0) == 0))
      this.gclass31_0.method_1();
    if ((this.gclass31_1 == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.gclass31_1) ? 1 : 0) == 0))
      this.gclass31_1.method_1();
    if ((this.gclass31_2 == null ? 1 : 0) == 0 && ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.gclass31_2) ? 1 : 0) == 0))
      this.gclass31_2.method_1();
    if ((!this.isGetName ? 0 : 1) == 0)
    {
      if ((GClass178.gclass154_0 == null ? 0 : 1) == 0)
        return;
      if ((!GClass62.bool_5 ? 1 : 0) == 0)
      {
        GClass178.gclass154_0.method_1();
        this.int_7 = GClass178.gclass154_0.selectedItem;
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
      {
        GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(0) != 0;
        this.int_7 -= Class15.smethod_0(1);
        if (this.int_7 < Class15.smethod_0(0))
          this.int_7 = this.nItem - Class15.smethod_0(1);
        GClass178.gclass154_0.method_7(this.int_7 * GClass178.gclass154_0.ITEM_SIZE);
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
      {
        GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(0) != 0;
        this.int_7 += Class15.smethod_0(1);
        if (this.int_7 > this.nItem - Class15.smethod_0(1))
          this.int_7 = Class15.smethod_0(0);
        GClass178.gclass154_0.method_7(this.int_7 * GClass178.gclass154_0.ITEM_SIZE);
      }
      if (this.int_7 != -1)
        this.int_8 = this.int_7;
    }
    GClass62.smethod_25();
    GClass62.smethod_24();
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(7))
      this.method_3();
    if (idAction != Class15.smethod_0(1) || (!this.isGetName ? 1 : 0) == 0)
      return;
    if ((!this.bool_0 ? 0 : 1) == 0)
    {
      if (this.int_8 < Class15.smethod_0(0))
        return;
      this.method_3();
      if ((GClass20.smethod_1().clan == null ? 0 : 1) == 0)
        GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(7), (sbyte) ((GClass26) GClass26.gclass134_0.method_3(this.int_8)).ID, this.text);
      else
        GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(2), (sbyte) ((GClass26) GClass26.gclass134_0.method_3(this.int_8)).ID, string.Empty);
    }
    else
    {
      if (this.int_8 < Class15.smethod_0(0))
        return;
      GClass80 gclass80 = (GClass80) this.vItems.method_3(this.int_7);
    }
  }
}
