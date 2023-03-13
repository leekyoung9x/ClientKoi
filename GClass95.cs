// Decompiled with JetBrains decompiler
// Type: GClass95
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass95
{
  public bool showMenu;
  public GClass134 menuItems;
  public int menuSelectedItem;
  public int menuX;
  public int menuY;
  public int menuW;
  public int menuH;
  public static int[] int_0;
  public static int int_1;
  public static int int_2;
  public static int int_3;
  public static int int_4;
  public static int int_5;
  public static int int_6;
  private GClass31 gclass31_0 = new GClass31(GClass109.string_146, Class15.smethod_0(0));
  private GClass31 gclass31_1 = new GClass31(GClass109.string_125, Class15.smethod_0(0), GClass62.int_10 - Class15.smethod_0(135), GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(1));
  private GClass31 gclass31_2;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  private bool bool_0;
  public int tDelay;
  public int w;
  private int int_7;
  private bool bool_1;
  private int int_8;
  private int int_9;
  private int[] int_10 = new int[Class15.smethod_0(5)];
  private bool bool_2;
  private bool bool_3;
  private bool bool_4;
  public int waitToPerform;
  private int int_11;
  private bool bool_5;
  private bool bool_6;
  private int int_12;
  private int int_13;
  public bool isClose;
  public bool[] isNotClose;

  public static void smethod_0()
  {
    GClass95.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(159112));
    GClass95.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(159170));
  }

  public void method_0(GClass134 menuItems, int pos)
  {
    this.method_2(menuItems, pos);
    this.bool_0 = Class15.smethod_0(1) != 0;
  }

  public void method_1(GClass134 menuItems, int x, int y)
  {
    this.method_2(menuItems, Class15.smethod_0(0));
    this.menuX = x;
    this.menuY = y;
    while (this.menuY + this.menuH > GClass62.int_11)
      this.menuY -= Class15.smethod_0(7);
  }

  public void method_2(GClass134 menuItems, int pos)
  {
    if ((!this.showMenu ? 1 : 0) == 0)
      return;
    this.isClose = Class15.smethod_0(0) != 0;
    this.bool_5 = Class15.smethod_0(0) != 0;
    this.bool_6 = Class15.smethod_0(0) != 0;
    this.tDelay = Class15.smethod_0(0);
    if (menuItems.method_2() == Class15.smethod_0(1))
    {
      this.menuSelectedItem = Class15.smethod_0(0);
      GClass31 gclass31 = (GClass31) menuItems.method_3(Class15.smethod_0(0));
      if ((gclass31 == null ? 1 : 0) == 0 && (!gclass31.caption.Equals(GClass109.string_232) ? 1 : 0) == 0)
      {
        gclass31.method_1();
        this.showMenu = Class15.smethod_0(0) != 0;
        GClass71.smethod_1();
        return;
      }
    }
    GClass172.smethod_1().method_39();
    this.isNotClose = new bool[menuItems.method_2()];
    for (int index = Class15.smethod_0(0); index < this.isNotClose.Length; index += Class15.smethod_0(1))
      this.isNotClose[index] = Class15.smethod_0(0) != 0;
    this.bool_0 = Class15.smethod_0(0) != 0;
    GClass43.gclass43_0 = (GClass43) null;
    GClass42.gclass134_1.method_9();
    GClass42.gclass134_3.method_9();
    GClass71.smethod_5();
    if ((menuItems.method_2() == 0 ? 1 : 0) != 0)
      return;
    this.menuItems = menuItems;
    this.menuW = Class15.smethod_0(4);
    this.menuH = Class15.smethod_0(4);
    for (int index = Class15.smethod_0(0); index < menuItems.method_2(); index += Class15.smethod_0(1))
    {
      GClass31 gclass31 = (GClass31) menuItems.method_3(index);
      gclass31.isPlaySoundButton = Class15.smethod_0(0) != 0;
      GClass97.gclass97_15.method_17(gclass31.caption);
      gclass31.subCaption = GClass97.gclass97_15.method_15(gclass31.caption, this.menuW - Class15.smethod_0(31));
      GClass151.smethod_7(Class13.smethod_0(153146) + gclass31.caption);
    }
    GClass95.int_0 = new int[menuItems.method_2()];
    this.menuX = (GClass62.int_10 - menuItems.method_2() * this.menuW) / Class15.smethod_0(7);
    if (this.menuX < Class15.smethod_0(1))
      this.menuX = Class15.smethod_0(1);
    this.menuY = GClass62.int_11 - this.menuH - (GClass140.int_5 + Class15.smethod_0(1)) - Class15.smethod_0(1);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
      this.menuY -= Class15.smethod_0(5);
    this.menuY += Class15.smethod_0(33);
    for (int index = Class15.smethod_0(0); index < GClass95.int_0.Length; index += Class15.smethod_0(1))
      GClass95.int_0[index] = GClass62.int_11;
    this.showMenu = Class15.smethod_0(1) != 0;
    this.menuSelectedItem = Class15.smethod_0(0);
    GClass95.int_5 = this.menuItems.method_2() * this.menuW - GClass62.int_10;
    if (GClass95.int_5 < Class15.smethod_0(0))
      GClass95.int_5 = Class15.smethod_0(0);
    GClass95.int_1 = Class15.smethod_0(0);
    GClass95.int_2 = Class15.smethod_0(0);
    GClass95.int_6 = Class15.smethod_0(32);
    this.w = menuItems.method_2() * this.menuW - Class15.smethod_0(1);
    if (this.w > GClass62.int_10 - Class15.smethod_0(7))
      this.w = GClass62.int_10 - Class15.smethod_0(7);
    if ((!GClass62.bool_5 ? 1 : 0) != 0 || (!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.menuSelectedItem = -1;
  }

  public bool method_3() => (!this.isClose ? 0 : 1) == 0 && GClass95.int_0[GClass95.int_0.Length - Class15.smethod_0(1)] > this.menuY || (!this.isClose ? 1 : 0) == 0 && GClass95.int_0[GClass95.int_0.Length - Class15.smethod_0(1)] < GClass62.int_11 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public void method_4()
  {
    if (!this.showMenu || this.method_3())
      return;
    bool flag1 = Class15.smethod_0(0) != 0;
    if (!GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] && !GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)])
    {
      if (!GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(88) : Class15.smethod_0(28)] && !GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)])
      {
        if (GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(3) : Class15.smethod_0(46)])
        {
          if (this.gclass31_2 != null)
          {
            if (this.gclass31_2.idAction > Class15.smethod_0(0))
            {
              if (this.gclass31_2.actionListener == GClass116.smethod_6())
                GClass116.smethod_6().method_116(this.gclass31_2.idAction, this.gclass31_2.p);
              else
                this.method_10(this.gclass31_2.idAction, this.gclass31_2.p);
            }
          }
          else
            this.waitToPerform = Class15.smethod_0(7);
        }
        else if (GClass62.bool_11[Class15.smethod_0(66)] && !GClass116.smethod_6().method_76())
        {
          if (this.method_3())
            return;
          if (this.gclass31_0.idAction > Class15.smethod_0(0))
            this.method_10(this.gclass31_0.idAction, this.gclass31_0.p);
          else
            this.waitToPerform = Class15.smethod_0(7);
          GClass172.smethod_1().method_34();
        }
        else if (!GClass116.smethod_6().method_76() && !this.bool_0 && (GClass62.bool_11[Class15.smethod_0(47)] || GClass113.smethod_1(this.gclass31_1)))
        {
          if (this.method_3())
            return;
          if (!this.bool_6)
            this.bool_6 = Class15.smethod_0(1) != 0;
          this.isClose = Class15.smethod_0(1) != 0;
          GClass172.smethod_1().method_34();
        }
      }
      else
      {
        flag1 = Class15.smethod_0(1) != 0;
        this.menuSelectedItem += Class15.smethod_0(1);
        if (this.menuSelectedItem > this.menuItems.method_2() - Class15.smethod_0(1))
          this.menuSelectedItem = Class15.smethod_0(0);
      }
    }
    else
    {
      flag1 = Class15.smethod_0(1) != 0;
      this.menuSelectedItem -= Class15.smethod_0(1);
      if (this.menuSelectedItem < Class15.smethod_0(0))
        this.menuSelectedItem = this.menuItems.method_2() - Class15.smethod_0(1);
    }
    if (flag1)
    {
      GClass95.int_1 = this.menuSelectedItem * this.menuW + this.menuW - GClass62.int_10 / Class15.smethod_0(7);
      if (GClass95.int_1 > GClass95.int_5)
        GClass95.int_1 = GClass95.int_5;
      if (GClass95.int_1 < Class15.smethod_0(0))
        GClass95.int_1 = Class15.smethod_0(0);
      if (this.menuSelectedItem == this.menuItems.method_2() - Class15.smethod_0(1) || this.menuSelectedItem == 0)
        GClass95.int_2 = GClass95.int_1;
    }
    bool flag2 = Class15.smethod_0(1) != 0;
    if (GClass62.gclass141_0.cp != null && GClass62.gclass141_0.cp.isClip)
    {
      if (!GClass62.smethod_22(GClass62.gclass141_0.cp.cx, Class15.smethod_0(0), GClass62.gclass141_0.cp.sayWidth + Class15.smethod_0(7), GClass62.gclass141_0.cp.ch))
      {
        flag2 = Class15.smethod_0(1) != 0;
      }
      else
      {
        flag2 = Class15.smethod_0(0) != 0;
        GClass62.gclass141_0.cp.method_2();
      }
    }
    if (((this.bool_0 || !GClass62.bool_16 || GClass62.smethod_45(this.menuX, this.menuY, this.w, this.menuH) || this.bool_2 ? Class15.smethod_0(0) : ((GClass116.smethod_6().method_76() ? 1 : 0) == Class15.smethod_0(0) ? 1 : 0)) & (flag2 ? 1 : 0)) != 0)
    {
      if (this.method_3())
        return;
      this.int_8 = this.int_9 = Class15.smethod_0(0);
      this.bool_2 = Class15.smethod_0(0) != 0;
      GClass62.smethod_46();
      GClass151.smethod_7(Class13.smethod_0(153299) + this.menuSelectedItem.ToString());
      this.isClose = Class15.smethod_0(1) != 0;
      this.bool_6 = Class15.smethod_0(1) != 0;
      GClass172.smethod_1().method_34();
    }
    else
    {
      if (GClass62.bool_14)
      {
        if (!this.bool_2 && GClass62.smethod_45(this.menuX, this.menuY, this.w, this.menuH))
        {
          for (int index = Class15.smethod_0(0); index < this.int_10.Length; index += Class15.smethod_0(1))
            this.int_10[Class15.smethod_0(0)] = GClass62.int_0;
          this.int_9 = GClass62.int_0;
          this.bool_2 = Class15.smethod_0(1) != 0;
          this.bool_3 = (uint) this.int_11 > (uint) Class15.smethod_0(0);
          this.int_11 = Class15.smethod_0(0);
        }
        else if (this.bool_2)
        {
          this.int_8 += Class15.smethod_0(1);
          if (this.int_8 > Class15.smethod_0(3) && this.int_9 == GClass62.int_0 && !this.bool_3)
          {
            this.int_9 = Class15.smethod_0(223);
            this.menuSelectedItem = (GClass95.int_1 + GClass62.int_0 - this.menuX) / this.menuW;
          }
          int num = GClass62.int_0 - this.int_10[Class15.smethod_0(0)];
          if (num != 0 && this.menuSelectedItem != -1)
            this.menuSelectedItem = -1;
          for (int index = this.int_10.Length - Class15.smethod_0(1); index > Class15.smethod_0(0); index -= Class15.smethod_0(1))
            this.int_10[index] = this.int_10[index - Class15.smethod_0(1)];
          this.int_10[Class15.smethod_0(0)] = GClass62.int_0;
          GClass95.int_1 -= num;
          if (GClass95.int_1 < Class15.smethod_0(0))
            GClass95.int_1 = Class15.smethod_0(0);
          if (GClass95.int_1 > GClass95.int_5)
            GClass95.int_1 = GClass95.int_5;
          if (GClass95.int_2 < Class15.smethod_0(0) || GClass95.int_2 > GClass95.int_5)
            num /= Class15.smethod_0(7);
          GClass95.int_2 -= num;
          this.bool_4 = GClass95.int_2 >= -(GClass62.int_11 / Class15.smethod_0(5)) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
        }
      }
      if (GClass62.bool_16 && this.bool_2)
      {
        int i = GClass62.int_0 - this.int_10[Class15.smethod_0(0)];
        GClass62.bool_16 = Class15.smethod_0(0) != 0;
        if (GClass151.smethod_25(i) < Class15.smethod_0(51) && GClass151.smethod_25(GClass62.int_0 - this.int_9) < Class15.smethod_0(51) && !this.bool_3)
        {
          this.int_11 = Class15.smethod_0(0);
          GClass95.int_1 = GClass95.int_2;
          this.int_9 = Class15.smethod_0(223);
          this.menuSelectedItem = (GClass95.int_1 + GClass62.int_0 - this.menuX) / this.menuW;
          this.int_8 = Class15.smethod_0(0);
          this.waitToPerform = Class15.smethod_0(31);
        }
        else if (this.menuSelectedItem != -1 && this.int_8 > Class15.smethod_0(3))
        {
          this.int_8 = Class15.smethod_0(0);
          this.waitToPerform = Class15.smethod_0(1);
        }
        else if (this.menuSelectedItem == -1 && !this.bool_3)
        {
          if (GClass95.int_2 < Class15.smethod_0(0))
            GClass95.int_1 = Class15.smethod_0(0);
          else if (GClass95.int_2 > GClass95.int_5)
          {
            GClass95.int_1 = GClass95.int_5;
          }
          else
          {
            int num = GClass62.int_0 - this.int_10[Class15.smethod_0(0)] + (this.int_10[Class15.smethod_0(0)] - this.int_10[Class15.smethod_0(1)]) + (this.int_10[Class15.smethod_0(1)] - this.int_10[Class15.smethod_0(7)]);
            this.int_11 = -(num > Class15.smethod_0(31) ? Class15.smethod_0(31) : (num < Class15.smethod_0(136) ? Class15.smethod_0(136) : Class15.smethod_0(0))) * Class15.smethod_0(21);
          }
        }
        this.bool_2 = Class15.smethod_0(0) != 0;
        this.int_8 = Class15.smethod_0(0);
        GClass62.bool_16 = Class15.smethod_0(0) != 0;
      }
      GClass62.smethod_24();
      GClass62.smethod_25();
    }
  }

  public void method_5()
  {
    if ((this.int_11 == 0 ? 1 : 0) == 0 && (!this.bool_2 ? 0 : 1) == 0)
    {
      GClass95.int_1 += this.int_11 / Class15.smethod_0(21);
      if (GClass95.int_1 < Class15.smethod_0(0))
        GClass95.int_1 = Class15.smethod_0(0);
      else if (GClass95.int_1 > GClass95.int_5)
        GClass95.int_1 = GClass95.int_5;
      else
        GClass95.int_2 = GClass95.int_1;
      this.int_11 = this.int_11 * Class15.smethod_0(45) / Class15.smethod_0(31);
      if (this.int_11 < Class15.smethod_0(21) && this.int_11 > Class15.smethod_0(143))
        this.int_11 = Class15.smethod_0(0);
    }
    if (GClass95.int_2 == GClass95.int_1 || (!this.bool_2 ? 0 : 1) != 0)
      return;
    this.int_12 = GClass95.int_1 - GClass95.int_2 << Class15.smethod_0(7);
    this.int_13 += this.int_12;
    GClass95.int_2 += this.int_13 >> Class15.smethod_0(2);
    this.int_13 &= Class15.smethod_0(9);
  }

  public void method_6(GClass98 g)
  {
    if ((!GClass116.smethod_6().activeRongThan ? 1 : 0) == 0 && (!GClass116.smethod_6().isUseFreez ? 1 : 0) == 0)
      return;
    g.method_1(-g.method_3(), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    g.method_1(-GClass95.int_2, Class15.smethod_0(0));
    for (int index1 = Class15.smethod_0(0); index1 < this.menuItems.method_2(); index1 += Class15.smethod_0(1))
    {
      if (index1 == this.menuSelectedItem)
        g.method_32(GClass95.gclass66_1, this.menuX + index1 * this.menuW + Class15.smethod_0(1), GClass95.int_0[index1], Class15.smethod_0(0));
      else
        g.method_32(GClass95.gclass66_0, this.menuX + index1 * this.menuW + Class15.smethod_0(1), GClass95.int_0[index1], Class15.smethod_0(0));
      string[] strArray1 = ((GClass31) this.menuItems.method_3(index1)).subCaption;
      if ((strArray1 == null ? 0 : 1) == 0)
      {
        string[] strArray2 = new string[Class15.smethod_0(1)];
        strArray2[Class15.smethod_0(0)] = ((GClass31) this.menuItems.method_3(index1)).caption;
        strArray1 = strArray2;
      }
      int num = GClass95.int_0[index1] + (this.menuH - strArray1.Length * Class15.smethod_0(49)) / Class15.smethod_0(7) + Class15.smethod_0(1);
      for (int index2 = Class15.smethod_0(0); index2 < strArray1.Length; index2 += Class15.smethod_0(1))
      {
        if (index1 == this.menuSelectedItem)
          GClass97.gclass97_7.method_6(g, strArray1[index2], this.menuX + index1 * this.menuW + this.menuW / Class15.smethod_0(7), num + index2 * Class15.smethod_0(49), Class15.smethod_0(7));
        else
          GClass97.gclass97_6.method_6(g, strArray1[index2], this.menuX + index1 * this.menuW + this.menuW / Class15.smethod_0(7), num + index2 * Class15.smethod_0(49), Class15.smethod_0(7));
      }
    }
    g.method_1(-g.method_3(), -g.method_4());
  }

  public void method_7()
  {
    GClass151.smethod_7(Class13.smethod_0(154128));
    this.isClose = Class15.smethod_0(0) != 0;
    this.showMenu = Class15.smethod_0(0) != 0;
    GClass71.smethod_5();
    if ((!this.bool_6 ? 1 : 0) == 0)
    {
      GClass62.gclass141_0.cp = (GClass43) null;
      GClass20.gclass43_0 = (GClass43) null;
      if ((GClass62.gclass141_1 == null ? 1 : 0) != 0 || (GClass62.gclass141_1.cp == null ? 1 : 0) != 0)
        return;
      GClass62.gclass141_1.cp = (GClass43) null;
    }
    else
    {
      if ((!this.bool_5 ? 0 : 1) == 0)
        return;
      GClass62.gclass141_0.cp = (GClass43) null;
      if ((GClass62.gclass141_1 == null ? 1 : 0) == 0 && (GClass62.gclass141_1.cp == null ? 1 : 0) == 0)
        GClass62.gclass141_1.cp = (GClass43) null;
      if (this.menuSelectedItem < Class15.smethod_0(0))
        return;
      GClass31 gclass31 = (GClass31) this.menuItems.method_3(this.menuSelectedItem);
      if ((gclass31 == null ? 1 : 0) != 0)
        return;
      GClass172.smethod_1().method_34();
      gclass31.method_1();
    }
  }

  public void method_8()
  {
    GClass71.smethod_5();
    if (this.menuSelectedItem < Class15.smethod_0(0))
      return;
    GClass31 gclass31 = (GClass31) this.menuItems.method_3(this.menuSelectedItem);
    if ((gclass31 == null ? 0 : 1) == 0)
      return;
    gclass31.method_1();
  }

  public void method_9()
  {
    this.method_5();
    if ((!this.isClose ? 0 : 1) == 0)
    {
      this.tDelay += Class15.smethod_0(1);
      for (int index = Class15.smethod_0(0); index < GClass95.int_0.Length; index += Class15.smethod_0(1))
      {
        if (GClass95.int_0[index] > this.menuY)
        {
          int num = GClass95.int_0[index] - this.menuY >> Class15.smethod_0(1);
          if (num < Class15.smethod_0(1))
            num = Class15.smethod_0(1);
          if (this.tDelay > index)
            GClass95.int_0[index] -= num;
        }
      }
      if (GClass95.int_0[GClass95.int_0.Length - Class15.smethod_0(1)] <= this.menuY)
        this.tDelay = Class15.smethod_0(0);
    }
    else
    {
      this.tDelay += Class15.smethod_0(1);
      for (int index = Class15.smethod_0(0); index < GClass95.int_0.Length; index += Class15.smethod_0(1))
      {
        if (GClass95.int_0[index] < GClass62.int_11)
        {
          int num = (GClass62.int_11 - GClass95.int_0[index] >> Class15.smethod_0(1)) + Class15.smethod_0(7);
          if (num < Class15.smethod_0(1))
            num = Class15.smethod_0(1);
          if (this.tDelay > index)
            GClass95.int_0[index] += num;
        }
      }
      if (GClass95.int_0[GClass95.int_0.Length - Class15.smethod_0(1)] >= GClass62.int_11)
      {
        this.tDelay = Class15.smethod_0(0);
        this.method_7();
      }
    }
    if ((GClass95.int_6 == 0 ? 1 : 0) == 0)
    {
      GClass95.int_6 >>= Class15.smethod_0(1);
      if (GClass95.int_6 < Class15.smethod_0(0))
        GClass95.int_6 = Class15.smethod_0(0);
    }
    if ((!this.method_3() ? 0 : 1) != 0 || this.waitToPerform <= Class15.smethod_0(0))
      return;
    this.waitToPerform -= Class15.smethod_0(1);
    if ((this.waitToPerform == 0 ? 0 : 1) != 0)
      return;
    if (this.menuSelectedItem >= Class15.smethod_0(0) && (!this.isNotClose[this.menuSelectedItem] ? 0 : 1) == 0)
    {
      this.isClose = Class15.smethod_0(1) != 0;
      this.bool_5 = Class15.smethod_0(1) != 0;
      GClass62.gclass141_0.cp = (GClass43) null;
    }
    else
      this.method_8();
  }

  public void method_10(int idAction, object p)
  {
  }
}
