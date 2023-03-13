// Decompiled with JetBrains decompiler
// Type: GClass64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass64
{
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private int int_5;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  private int int_10;
  private int int_11;
  private int int_12;
  private int int_13;
  private int int_14;
  public int xZone;
  public int yZone;
  public int wZone;
  public int hZone;
  private bool bool_0;
  public bool isSmallGamePad;
  public bool isMediumGamePad;
  public bool isLargeGamePad;

  public GClass64()
  {
    this.int_6 = Class15.smethod_0(35);
    if (GClass62.int_10 < Class15.smethod_0(137))
    {
      this.isSmallGamePad = Class15.smethod_0(1) != 0;
      this.isMediumGamePad = Class15.smethod_0(0) != 0;
      this.isLargeGamePad = Class15.smethod_0(0) != 0;
    }
    if (GClass62.int_10 >= Class15.smethod_0(137) && GClass62.int_10 <= Class15.smethod_0(339))
    {
      this.isSmallGamePad = Class15.smethod_0(0) != 0;
      this.isMediumGamePad = Class15.smethod_0(1) != 0;
      this.isLargeGamePad = Class15.smethod_0(0) != 0;
    }
    if (GClass62.int_10 > Class15.smethod_0(339))
    {
      this.isSmallGamePad = Class15.smethod_0(0) != 0;
      this.isMediumGamePad = Class15.smethod_0(0) != 0;
      this.isLargeGamePad = Class15.smethod_0(1) != 0;
    }
    if ((!this.isLargeGamePad ? 0 : 1) == 0)
    {
      this.xZone = Class15.smethod_0(0);
      this.wZone = GClass62.int_12;
      this.yZone = GClass62.int_13 >> Class15.smethod_0(1);
      this.hZone = GClass62.int_11 - Class15.smethod_0(25);
    }
    else
    {
      this.xZone = Class15.smethod_0(0);
      this.wZone = GClass62.int_12 / Class15.smethod_0(2) * Class15.smethod_0(5) - Class15.smethod_0(51);
      this.yZone = GClass62.int_13 >> Class15.smethod_0(1);
      this.hZone = GClass62.int_11;
    }
  }

  public void method_0()
  {
    try
    {
      if (GClass116.int_62 == 0)
        return;
      if (GClass62.bool_14 && !GClass62.bool_16)
      {
        this.int_9 = GClass62.int_2;
        this.int_10 = GClass62.int_3;
        if (this.int_9 < this.xZone || this.int_9 > this.wZone || this.int_10 < this.yZone || this.int_10 > this.hZone)
          return;
        if (!this.bool_0)
        {
          this.int_0 = this.int_2 = this.int_9;
          this.int_1 = this.int_3 = this.int_10;
        }
        this.bool_0 = Class15.smethod_0(1) != 0;
        this.int_11 = GClass62.int_0 - this.int_0;
        this.int_12 = GClass62.int_1 - this.int_1;
        this.int_13 = GClass93.smethod_3(this.int_11, Class15.smethod_0(7)) + GClass93.smethod_3(this.int_12, Class15.smethod_0(7));
        this.int_8 = GClass151.smethod_23(this.int_13);
        if (GClass93.smethod_0(this.int_11) <= Class15.smethod_0(2) && GClass93.smethod_0(this.int_12) <= Class15.smethod_0(2))
          return;
        this.int_14 = GClass151.smethod_5(this.int_11, this.int_12);
        if (!GClass62.smethod_22(this.int_0 - this.int_6, this.int_1 - this.int_6, Class15.smethod_0(7) * this.int_6, Class15.smethod_0(7) * this.int_6))
        {
          if (this.int_8 != 0)
          {
            this.int_3 = this.int_12 * this.int_6 / this.int_8;
            this.int_2 = this.int_11 * this.int_6 / this.int_8;
            this.int_2 += this.int_0;
            this.int_3 += this.int_1;
            if (!GClass151.smethod_26(this.int_0 - this.int_6, this.int_1 - this.int_6, Class15.smethod_0(7) * this.int_6, Class15.smethod_0(7) * this.int_6, this.int_2, this.int_3))
            {
              this.int_2 = this.int_4;
              this.int_3 = this.int_5;
            }
            else
            {
              this.int_4 = this.int_2;
              this.int_5 = this.int_3;
            }
          }
          else
          {
            this.int_2 = this.int_4;
            this.int_3 = this.int_5;
          }
        }
        else
        {
          this.int_2 = GClass62.int_0;
          this.int_3 = GClass62.int_1;
        }
        this.method_2();
        if (this.method_1(Class15.smethod_0(7)))
        {
          if (this.int_14 <= Class15.smethod_0(229) && this.int_14 >= Class15.smethod_0(340) || this.int_14 >= Class15.smethod_0(0) && this.int_14 <= Class15.smethod_0(51))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 > Class15.smethod_0(54) && this.int_14 < Class15.smethod_0(152))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 >= Class15.smethod_0(152) && this.int_14 <= Class15.smethod_0(80))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 > Class15.smethod_0(80) && this.int_14 < Class15.smethod_0(98))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 >= Class15.smethod_0(98) && this.int_14 <= Class15.smethod_0(90))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 > Class15.smethod_0(90) && this.int_14 < Class15.smethod_0(262))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(2) : Class15.smethod_0(29)] = Class15.smethod_0(1) != 0;
          }
          else if (this.int_14 >= Class15.smethod_0(262) && this.int_14 <= Class15.smethod_0(234))
          {
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
          }
          else
          {
            if (this.int_14 <= Class15.smethod_0(234) || this.int_14 >= Class15.smethod_0(340))
              return;
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
            GClass62.bool_13[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(37) : Class15.smethod_0(40)] = Class15.smethod_0(1) != 0;
          }
        }
        else
          this.method_2();
      }
      else
      {
        this.int_2 = this.int_0 = Class15.smethod_0(70);
        this.int_3 = this.isLargeGamePad ? (this.int_1 = GClass62.int_11 - Class15.smethod_0(70)) : (this.int_1 = GClass62.int_11 - Class15.smethod_0(23));
        this.bool_0 = Class15.smethod_0(0) != 0;
        this.method_2();
      }
    }
    catch (Exception ex)
    {
    }
  }

  private bool method_1(int int_15)
  {
    if ((GClass116.int_62 == 0 ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if (GClass20.smethod_1().statusMe == Class15.smethod_0(5))
      return Class15.smethod_0(1) != 0;
    try
    {
      for (int index = Class15.smethod_0(7); index > Class15.smethod_0(0); index -= Class15.smethod_0(1))
      {
        int i1 = GClass62.gclass150_0[index].x - GClass62.gclass150_0[index - Class15.smethod_0(1)].x;
        int i2 = GClass62.gclass150_0[index].y - GClass62.gclass150_0[index - Class15.smethod_0(1)].y;
        if (GClass151.smethod_25(i1) > int_15 && GClass151.smethod_25(i2) > int_15)
          return Class15.smethod_0(0) != 0;
      }
    }
    catch (Exception ex)
    {
    }
    return Class15.smethod_0(1) != 0;
  }

  private void method_2() => GClass62.smethod_25();

  public void method_3(GClass98 g)
  {
    if ((GClass116.int_62 == 0 ? 1 : 0) != 0)
      return;
    g.method_32(GClass116.gclass66_26, this.int_0, this.int_1, GClass98.int_0 | GClass98.int_1);
    g.method_32(GClass116.gclass66_27, this.int_2, this.int_3, GClass98.int_0 | GClass98.int_1);
  }

  public bool method_4() => (GClass116.int_62 == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : this.bool_0;

  public bool method_5()
  {
    try
    {
      return (GClass116.int_62 == 0 ? 0 : 1) == 0 || (GClass62.int_0 < this.xZone || GClass62.int_0 > this.wZone || GClass62.int_1 < this.yZone || GClass62.int_1 > this.hZone) && GClass62.int_0 < GClass62.int_10 - Class15.smethod_0(32) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(0) != 0;
    }
  }
}
