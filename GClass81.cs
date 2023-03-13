// Decompiled with JetBrains decompiler
// Type: GClass81
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass81 : GInterface3
{
  public int x;
  public int y;
  public int xEnd;
  public int yEnd;
  public int f;
  public int vx;
  public int vy;
  public int playerId;
  public int itemMapID;
  public int IdCharMove;
  public GClass85 template;
  public sbyte status;
  public bool isHintFocus;
  public int rO;
  public int xO;
  public int yO;
  public int angle;
  public int iAngle;
  public int iDot;
  public int[] xArg;
  public int[] yArg;
  public int[] xDot;
  public int[] yDot;
  public int count;
  public int countAura;
  public static GClass66 gclass66_0 = GClass62.smethod_40(Class13.smethod_0(159015));
  public static GClass66 gclass66_1 = GClass62.smethod_40(Class13.smethod_0(159148));
  public static GClass66 gclass66_2 = GClass62.smethod_40(Class13.smethod_0(159206));
  public static GClass66 gclass66_3 = GClass62.smethod_40(Class13.smethod_0(158752));

  public GClass81(short itemMapID, short itemTemplateID, int x, int y, int xEnd, int yEnd)
  {
    this.itemMapID = (int) itemMapID;
    this.template = GClass86.smethod_1(itemTemplateID);
    this.x = xEnd;
    this.y = y;
    this.xEnd = xEnd;
    this.yEnd = yEnd;
    this.vx = xEnd - x >> Class15.smethod_0(7);
    this.vy = Class15.smethod_0(3);
    GClass151.smethod_7(Class13.smethod_0(157243) + this.playerId.ToString() + Class13.smethod_0(157231) + GClass20.smethod_1().charID.ToString());
  }

  public GClass81(int playerId, short itemMapID, short itemTemplateID, int x, int y, short r)
  {
    string[] strArray = new string[Class15.smethod_0(88)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(157306);
    strArray[Class15.smethod_0(1)] = itemMapID.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(158314);
    strArray[Class15.smethod_0(5)] = itemTemplateID.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(158388);
    strArray[Class15.smethod_0(3)] = x.ToString();
    strArray[Class15.smethod_0(37)] = Class13.smethod_0(158338);
    strArray[Class15.smethod_0(38)] = y.ToString();
    GClass151.smethod_7(string.Concat(strArray));
    this.itemMapID = (int) itemMapID;
    this.template = GClass86.smethod_1(itemTemplateID);
    GClass151.smethod_7(Class13.smethod_0(158423) + playerId.ToString() + Class13.smethod_0(158411) + GClass20.smethod_1().charID.ToString());
    this.x = this.xEnd = x;
    this.y = this.yEnd = y;
    this.status = (sbyte) Class15.smethod_0(1);
    this.playerId = playerId;
    if ((!this.method_3() ? 1 : 0) != 0)
      return;
    this.rO = (int) r;
    this.method_4();
  }

  public void method_0(int xEnd, int yEnd)
  {
    this.xEnd = xEnd;
    this.yEnd = yEnd;
    this.vx = xEnd - this.x >> Class15.smethod_0(7);
    this.vy = yEnd - this.y >> Class15.smethod_0(7);
    this.status = (sbyte) Class15.smethod_0(7);
  }

  public void method_1()
  {
    if ((int) this.status == Class15.smethod_0(7) && this.x == this.xEnd && this.y == this.yEnd)
    {
      GClass116.gclass134_6.method_8((object) this);
      if ((GClass20.smethod_1().itemFocus == null ? 1 : 0) != 0 || (!GClass20.smethod_1().itemFocus.Equals((object) this) ? 1 : 0) != 0)
        return;
      GClass20.smethod_1().itemFocus = (GClass81) null;
    }
    else
    {
      if ((int) this.status > Class15.smethod_0(0))
      {
        if ((this.vx == 0 ? 0 : 1) == 0)
          this.x = this.xEnd;
        if ((this.vy == 0 ? 0 : 1) == 0)
          this.y = this.yEnd;
        if (this.x != this.xEnd)
        {
          this.x += this.vx;
          if (this.vx > Class15.smethod_0(0) && this.x > this.xEnd || this.vx < Class15.smethod_0(0) && this.x < this.xEnd)
            this.x = this.xEnd;
        }
        if (this.y != this.yEnd)
        {
          this.y += this.vy;
          if (this.vy > Class15.smethod_0(0) && this.y > this.yEnd || this.vy < Class15.smethod_0(0) && this.y < this.yEnd)
            this.y = this.yEnd;
        }
      }
      else
      {
        this.status -= (sbyte) Class15.smethod_0(2);
        if ((int) this.status < Class15.smethod_0(138))
        {
          this.y -= Class15.smethod_0(66);
          this.status = (sbyte) Class15.smethod_0(1);
        }
      }
      if ((!this.method_3() ? 1 : 0) != 0)
        return;
      this.method_5();
    }
  }

  public void method_2(GClass98 g)
  {
    if ((!this.method_3() ? 1 : 0) == 0)
    {
      g.method_32(GClass185.gclass66_10, this.x + Class15.smethod_0(5), this.y, GClass98.int_1 | GClass98.int_0);
      if ((int) this.status <= Class15.smethod_0(0))
      {
        if (this.countAura < Class15.smethod_0(31))
          g.method_32(GClass81.gclass66_1, this.x, this.y + (int) this.status + Class15.smethod_0(5), GClass98.int_5 | GClass98.int_0);
        else
          g.method_32(GClass81.gclass66_2, this.x, this.y + (int) this.status + Class15.smethod_0(5), GClass98.int_5 | GClass98.int_0);
      }
      else if (this.countAura < Class15.smethod_0(31))
        g.method_32(GClass81.gclass66_1, this.x, this.y + Class15.smethod_0(5), GClass98.int_5 | GClass98.int_0);
      else
        g.method_32(GClass81.gclass66_2, this.x, this.y + Class15.smethod_0(5), GClass98.int_5 | GClass98.int_0);
    }
    else
    {
      if ((!this.method_3() ? 0 : 1) != 0)
        return;
      if ((GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
        g.method_32(GClass81.gclass66_0, this.x, this.y + (int) this.status + Class15.smethod_0(47), GClass98.int_5 | GClass98.int_0);
      if ((int) this.status <= Class15.smethod_0(0))
        GClass169.smethod_6(g, (int) this.template.iconID, this.x, this.y + (int) this.status + Class15.smethod_0(5), Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
      else
        GClass169.smethod_6(g, (int) this.template.iconID, this.x, this.y + Class15.smethod_0(5), Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
      if ((GClass20.smethod_1().itemFocus == null ? 1 : 0) != 0 || (!GClass20.smethod_1().itemFocus.Equals((object) this) ? 1 : 0) != 0 || (int) this.status == Class15.smethod_0(7))
        return;
      g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(40), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.x, this.y - Class15.smethod_0(186), Class15.smethod_0(5));
    }
  }

  private bool method_3() => (int) this.template.type == Class15.smethod_0(28) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  private void method_4()
  {
    this.xO = this.x;
    this.yO = this.y;
    this.iDot = Class15.smethod_0(98);
    this.angle = Class15.smethod_0(0);
    if ((!GClass62.bool_1 ? 0 : 1) != 0)
      return;
    this.iAngle = Class15.smethod_0(229) / this.iDot;
    this.xArg = new int[this.iDot];
    this.yArg = new int[this.iDot];
    this.xDot = new int[this.iDot];
    this.yDot = new int[this.iDot];
    this.method_7();
  }

  private void method_5()
  {
    this.count += Class15.smethod_0(1);
    this.countAura += Class15.smethod_0(1);
    if (this.countAura >= Class15.smethod_0(54))
      this.countAura = Class15.smethod_0(0);
    if (this.count >= this.iDot)
      this.count = Class15.smethod_0(0);
    if ((this.count % Class15.smethod_0(31) == 0 ? 0 : 1) != 0 || (!GClass62.bool_1 ? 0 : 1) != 0)
      return;
    GClass47.smethod_0(Class15.smethod_0(24), this.x - Class15.smethod_0(3), this.y - Class15.smethod_0(6), Class15.smethod_0(1));
  }

  public void method_6(GClass98 g)
  {
    if ((!GClass62.bool_1 ? 0 : 1) != 0 || (!this.method_3() ? 0 : 1) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < this.yArg.Length; index += Class15.smethod_0(1))
    {
      if (this.count == index)
      {
        if (this.countAura <= Class15.smethod_0(51))
          g.method_32(GClass81.gclass66_3, this.xDot[index], this.yDot[index] + Class15.smethod_0(5), GClass98.int_5 | GClass98.int_0);
        else
          GClass169.smethod_6(g, (int) this.template.iconID, this.xDot[index], this.yDot[index] + Class15.smethod_0(5), Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
      }
    }
  }

  private void method_7()
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < this.yArg.Length; index += Class15.smethod_0(1))
    {
      this.yArg[index] = GClass151.smethod_25(this.rO * GClass151.smethod_1(this.angle) / Class15.smethod_0(246));
      this.xArg[index] = GClass151.smethod_25(this.rO * GClass151.smethod_2(this.angle) / Class15.smethod_0(246));
      if (this.angle < Class15.smethod_0(23))
      {
        this.xDot[index] = this.xO + this.xArg[index];
        this.yDot[index] = this.yO - this.yArg[index];
      }
      else if (this.angle >= Class15.smethod_0(23) && this.angle < Class15.smethod_0(96))
      {
        this.xDot[index] = this.xO - this.xArg[index];
        this.yDot[index] = this.yO - this.yArg[index];
      }
      else if (this.angle >= Class15.smethod_0(96) && this.angle < Class15.smethod_0(196))
      {
        this.xDot[index] = this.xO - this.xArg[index];
        this.yDot[index] = this.yO + this.yArg[index];
      }
      else
      {
        this.xDot[index] = this.xO + this.xArg[index];
        this.yDot[index] = this.yO + this.yArg[index];
      }
      this.angle += this.iAngle;
    }
  }

  public int imethod_0() => this.x;

  public int imethod_1() => this.y;

  public int imethod_3() => Class15.smethod_0(51);

  public int imethod_2() => Class15.smethod_0(51);

  public void imethod_4()
  {
  }

  public bool imethod_5() => Class15.smethod_0(0) != 0;
}
