// Decompiled with JetBrains decompiler
// Type: GClass182
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass182
{
  public static GClass134 gclass134_0 = new GClass134();
  public int x;
  public int y;
  public int headId;
  public int type;
  public bool isMe;
  public int y2;
  public int id;
  public int dir;
  public int planet;
  public static GClass66[] gclass66_0 = new GClass66[Class15.smethod_0(3)];
  public static GClass66 gclass66_1;
  public bool isUp;
  public bool isDown;
  private bool bool_0;
  public bool paintFire;
  private bool bool_1;
  private int int_0;
  private int int_1 = Class15.smethod_0(1);
  private int int_2;
  private int int_3;
  private bool bool_2;
  private bool bool_3;

  public GClass182(int x, int y, int headId, int dir, int type, bool isMe, int planet)
  {
    this.x = x;
    this.y = Class15.smethod_0(3);
    this.y2 = y;
    this.headId = headId;
    this.type = type;
    this.isMe = isMe;
    this.dir = dir;
    this.planet = planet;
    this.int_0 = Class15.smethod_0(0);
    int num = Class15.smethod_0(0);
    while (num < Class15.smethod_0(21))
    {
      num += Class15.smethod_0(1);
      this.y2 += Class15.smethod_0(66);
      if ((!GClass185.smethod_27(x, this.y2, Class15.smethod_0(7)) ? 1 : 0) == 0)
      {
        if ((this.y2 % Class15.smethod_0(40) == 0 ? 1 : 0) == 0)
        {
          this.y2 -= this.y2 % Class15.smethod_0(40);
          break;
        }
        break;
      }
    }
    this.isDown = Class15.smethod_0(1) != 0;
    if (this.planet > Class15.smethod_0(7))
    {
      this.y2 += Class15.smethod_0(2);
      if ((GClass182.gclass66_0[Class15.smethod_0(5)] == null ? 0 : 1) == 0)
        GClass182.gclass66_0[Class15.smethod_0(5)] = GClass62.smethod_40(Class13.smethod_0(144664));
      if ((GClass182.gclass66_0[Class15.smethod_0(2)] == null ? 0 : 1) == 0)
        GClass182.gclass66_0[Class15.smethod_0(2)] = GClass62.smethod_40(Class13.smethod_0(146059));
      if ((GClass182.gclass66_1 == null ? 0 : 1) == 0)
        GClass182.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(146150));
    }
    else if ((GClass182.gclass66_0[planet] == null ? 0 : 1) == 0)
      GClass182.gclass66_0[planet] = GClass62.smethod_40(Class13.smethod_0(147405) + (planet + Class15.smethod_0(1)).ToString() + Class13.smethod_0(146988));
    if (x <= GClass116.int_22 || x >= GClass116.int_22 + GClass62.int_10 || this.y2 <= Class15.smethod_0(21) || (!GClass172.smethod_1().method_47() ? 0 : 1) != 0 || (!GClass172.smethod_1().method_46() ? 0 : 1) != 0)
      return;
    this.bool_0 = Class15.smethod_0(1) != 0;
    GClass172.smethod_1().method_48();
  }

  public static void smethod_0(GClass182 p) => GClass182.gclass134_0.method_0((object) p);

  public void method_0(GClass98 g)
  {
    if (this.planet <= Class15.smethod_0(7) || (!this.bool_2 ? 1 : 0) != 0)
      return;
    g.method_32(GClass182.gclass66_1, this.x, this.y2 + Class15.smethod_0(51), GClass177.int_3);
  }

  public void method_1(GClass98 g)
  {
    if ((!GClass20.bool_4 ? 0 : 1) != 0 || this.x < GClass116.int_22 || this.x > GClass116.int_22 + GClass62.int_10)
      return;
    GClass142 gclass142 = GClass116.gclass142_0[this.headId];
    int num1 = Class15.smethod_0(0);
    int num2 = Class15.smethod_0(0);
    if ((this.planet == 0 ? 0 : 1) == 0)
    {
      num1 = Class15.smethod_0(9);
      num2 = Class15.smethod_0(54);
    }
    if (this.planet == Class15.smethod_0(1))
    {
      num1 = Class15.smethod_0(38);
      num2 = Class15.smethod_0(280);
    }
    if (this.planet == Class15.smethod_0(7))
    {
      num1 = Class15.smethod_0(124);
      num2 = Class15.smethod_0(72);
    }
    if ((!this.bool_1 ? 1 : 0) == 0 && this.planet < Class15.smethod_0(5))
      GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, this.x + (this.dir != Class15.smethod_0(1) ? -num1 : num1), this.y - num2, this.dir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass177.int_0);
    if (this.planet < Class15.smethod_0(5))
      g.method_24(GClass182.gclass66_0[this.planet], Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(GClass182.gclass66_0[this.planet]), GClass98.smethod_1(GClass182.gclass66_0[this.planet]), this.dir == Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.x, this.y, GClass177.int_3);
    else if ((!this.isDown ? 1 : 0) == 0)
    {
      if (this.int_0 > Class15.smethod_0(31))
        g.method_24(GClass182.gclass66_0[Class15.smethod_0(2)], Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(GClass182.gclass66_0[Class15.smethod_0(2)]), GClass98.smethod_1(GClass182.gclass66_0[Class15.smethod_0(2)]), this.dir == Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.dir != Class15.smethod_0(1) ? this.x + Class15.smethod_0(67) : this.x - Class15.smethod_0(67), this.y + Class15.smethod_0(7), GClass177.int_3);
      else
        g.method_24(GClass182.gclass66_0[Class15.smethod_0(5)], Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(GClass182.gclass66_0[Class15.smethod_0(5)]), GClass98.smethod_1(GClass182.gclass66_0[Class15.smethod_0(5)]), this.dir == Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.x, this.y, GClass177.int_3);
    }
    else if (this.int_0 < Class15.smethod_0(51))
      g.method_24(GClass182.gclass66_0[Class15.smethod_0(2)], Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(GClass182.gclass66_0[Class15.smethod_0(2)]), GClass98.smethod_1(GClass182.gclass66_0[Class15.smethod_0(2)]), this.dir == Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.dir != Class15.smethod_0(1) ? this.x + Class15.smethod_0(67) : this.x - Class15.smethod_0(67), this.y + Class15.smethod_0(7), GClass177.int_3);
    else
      g.method_24(GClass182.gclass66_0[Class15.smethod_0(5)], Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(GClass182.gclass66_0[Class15.smethod_0(5)]), GClass98.smethod_1(GClass182.gclass66_0[Class15.smethod_0(5)]), this.dir == Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.x, this.y, GClass177.int_3);
  }

  public void method_2()
  {
    if (this.planet > Class15.smethod_0(7) && (!this.paintFire ? 1 : 0) == 0 && this.y != Class15.smethod_0(571))
    {
      if ((!this.isDown ? 1 : 0) == 0 && (this.int_0 == 0 ? 0 : 1) == 0)
      {
        if ((GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
          GClass47.smethod_1(Class15.smethod_0(1), this.x, this.y, Class15.smethod_0(1), Class15.smethod_0(0));
      }
      else if ((!this.isUp ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
        GClass47.smethod_1(Class15.smethod_0(1), this.x, this.y + Class15.smethod_0(10), Class15.smethod_0(1), Class15.smethod_0(1));
    }
    this.int_2 += Class15.smethod_0(1);
    if (this.int_2 > Class15.smethod_0(5))
      this.int_2 = Class15.smethod_0(0);
    if ((!this.isDown ? 1 : 0) == 0)
    {
      if ((!this.bool_3 ? 0 : 1) == 0)
      {
        GClass47.smethod_1(Class15.smethod_0(623), this.x + Class15.smethod_0(2), this.y + Class15.smethod_0(49), Class15.smethod_0(1), Class15.smethod_0(0));
        GClass116.int_89 = Class15.smethod_0(31);
        this.bool_3 = Class15.smethod_0(1) != 0;
      }
      this.int_0 += Class15.smethod_0(137);
      if (this.int_0 > Class15.smethod_0(6))
      {
        this.isDown = Class15.smethod_0(0) != 0;
        this.isUp = Class15.smethod_0(1) != 0;
        this.paintFire = Class15.smethod_0(0) != 0;
      }
      if (this.type == Class15.smethod_0(1))
      {
        if ((!this.isMe ? 1 : 0) == 0)
          GClass20.smethod_1().isTeleport = Class15.smethod_0(0) != 0;
        else if ((GClass116.smethod_12(this.id) == null ? 1 : 0) == 0)
          GClass116.smethod_12(this.id).isTeleport = Class15.smethod_0(0) != 0;
        this.bool_1 = Class15.smethod_0(0) != 0;
      }
    }
    else if ((!this.isUp ? 1 : 0) == 0)
    {
      if ((!this.isMe ? 1 : 0) == 0 && (this.type == 0 ? 0 : 1) == 0)
      {
        GClass32.bool_5 = Class15.smethod_0(0) != 0;
        GClass20.bool_2 = Class15.smethod_0(1) != 0;
      }
      if ((!this.isMe ? 0 : 1) == 0 && (GClass116.smethod_12(this.id) == null ? 1 : 0) == 0 && (this.type == 0 ? 0 : 1) == 0)
        GClass116.gclass134_5.method_8((object) GClass116.smethod_12(this.id));
      if (this.planet < Class15.smethod_0(5))
      {
        GClass182.gclass134_0.method_8((object) this);
      }
      else
      {
        this.y = Class15.smethod_0(571);
        this.int_3 += Class15.smethod_0(1);
        if (this.int_3 > Class15.smethod_0(25))
        {
          this.int_3 = Class15.smethod_0(0);
          GClass182.gclass134_0.method_8((object) this);
        }
      }
    }
    if ((!this.paintFire ? 1 : 0) != 0 || this.planet >= Class15.smethod_0(5) || GClass151.smethod_25(this.y - this.y2) > Class15.smethod_0(32) || (GClass62.int_8 % Class15.smethod_0(3) == 0 ? 0 : 1) != 0)
      return;
    GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.x, this.y2 + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1));
  }
}
