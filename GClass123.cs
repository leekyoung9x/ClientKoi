// Decompiled with JetBrains decompiler
// Type: GClass123
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass123 : GClass113, GInterface0
{
  public static GClass123 gclass123_0;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public sbyte type;
  public int speed = Class15.smethod_0(3);
  public int[] posX;
  public int[] posY;
  public int[] posX2;
  public int[] posY2;
  private int int_6;
  private int int_7 = Class15.smethod_0(51);
  public short time;
  public short maxTime;
  public long last;
  public long curr;
  private bool bool_0;
  private bool bool_1;
  private int int_8;

  public GClass123()
  {
    this.posX = new int[this.int_7];
    this.posY = new int[this.int_7];
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      this.posX[index] = GClass151.smethod_18(Class15.smethod_0(0), GClass62.int_10);
      this.posY[index] = index * (GClass62.int_11 / this.int_7);
    }
    this.posX2 = new int[this.int_7];
    this.posY2 = new int[this.int_7];
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      this.posX2[index] = GClass151.smethod_18(Class15.smethod_0(0), GClass62.int_10);
      this.posY2[index] = index * (GClass62.int_11 / this.int_7);
    }
  }

  public static GClass123 smethod_2()
  {
    if ((GClass123.gclass123_0 == null ? 0 : 1) == 0)
      GClass123.gclass123_0 = new GClass123();
    return GClass123.gclass123_0;
  }

  public override void vmethod_0()
  {
    if ((GClass123.gclass66_0 == null ? 0 : 1) == 0)
      GClass123.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(147227));
    if ((GClass123.gclass66_1 == null ? 0 : 1) == 0)
      GClass123.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(147313));
    this.bool_0 = Class15.smethod_0(0) != 0;
    this.bool_1 = Class15.smethod_0(0) != 0;
    if (GClass20.smethod_1().method_141() > Class15.smethod_0(0) && (this.type == (sbyte) 0 ? 0 : 1) == 0)
      this.center = new GClass31(GClass109.string_423, (GInterface0) this, Class15.smethod_0(1), (object) null);
    else
      this.center = (GClass31) null;
    this.int_8 = Class15.smethod_0(0);
    base.vmethod_0();
  }

  public override void vmethod_5(GClass98 g)
  {
    g.method_16((this.type == (sbyte) 0 ? 0 : 1) != 0 ? Class15.smethod_0(637) : Class15.smethod_0(0));
    g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      g.method_16((this.type == (sbyte) 0 ? 0 : 1) != 0 ? Class15.smethod_0(639) : Class15.smethod_0(638));
      g.method_15(this.posX[index], this.posY[index], Class15.smethod_0(31), Class15.smethod_0(7));
    }
    if ((this.type == (sbyte) 0 ? 0 : 1) == 0)
      g.method_24(GClass123.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(107), Class15.smethod_0(101), Class15.smethod_0(38), this.int_6 + this.int_8, GClass62.int_11 / Class15.smethod_0(7), Class15.smethod_0(5));
    if ((int) this.type == Class15.smethod_0(1))
      g.method_24(GClass123.gclass66_1, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(640), Class15.smethod_0(61), Class15.smethod_0(7), this.int_6 + this.int_8, GClass62.int_11 / Class15.smethod_0(7), Class15.smethod_0(5));
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      g.method_16((this.type == (sbyte) 0 ? 0 : 1) != 0 ? Class15.smethod_0(642) : Class15.smethod_0(641));
      g.method_15(this.posX2[index], this.posY2[index], Class15.smethod_0(124), Class15.smethod_0(5));
    }
    base.vmethod_5(g);
  }

  public override void vmethod_3()
  {
    if ((this.type == (sbyte) 0 ? 0 : 1) == 0)
    {
      if ((!this.bool_0 ? 0 : 1) == 0)
        this.int_8 = GClass62.int_10 / Class15.smethod_0(7) * (int) this.time / (int) this.maxTime;
    }
    else
      this.int_8 += Class15.smethod_0(7);
    GClass32.bool_5 = Class15.smethod_0(0) != 0;
    this.int_6 = (((GClass62.int_10 / Class15.smethod_0(7) + this.int_6) / Class15.smethod_0(7) + this.int_6) / Class15.smethod_0(7) + this.int_6) / Class15.smethod_0(7);
    if ((int) this.type == Class15.smethod_0(1))
      this.int_6 = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      this.posX[index] -= this.speed / Class15.smethod_0(7);
      if (this.posX[index] < Class15.smethod_0(188))
        this.posX[index] = GClass62.int_10;
    }
    for (int index = Class15.smethod_0(0); index < this.int_7; index += Class15.smethod_0(1))
    {
      this.posX2[index] -= this.speed;
      if (this.posX2[index] < Class15.smethod_0(188))
        this.posX2[index] = GClass62.int_10;
    }
    if ((GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
      this.speed += (!this.bool_0 ? 1 : 0) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(7);
    if (this.speed > ((!this.bool_0 ? 1 : 0) != 0 ? Class15.smethod_0(46) : Class15.smethod_0(25)))
      this.speed = (!this.bool_0 ? 1 : 0) != 0 ? Class15.smethod_0(46) : Class15.smethod_0(25);
    this.curr = GClass126.smethod_18();
    if (this.curr - this.last >= (long) Class15.smethod_0(15))
    {
      this.time += (short) Class15.smethod_0(1);
      this.last = this.curr;
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      this.int_8 += Class15.smethod_0(5);
    if (this.int_8 >= GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(6) && (!this.bool_1 ? 0 : 1) == 0)
    {
      this.bool_1 = Class15.smethod_0(1) != 0;
      GClass156.smethod_0().method_134();
    }
    base.vmethod_3();
  }

  public override void vmethod_4() => base.vmethod_4();

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(1))
      GClass62.smethod_34(GClass109.string_424, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(7), (object) null), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(5), (object) null));
    if (idAction == Class15.smethod_0(7) && GClass20.smethod_1().method_141() > Class15.smethod_0(0))
    {
      this.bool_0 = Class15.smethod_0(1) != 0;
      GClass62.smethod_27();
      this.center = (GClass31) null;
    }
    if (idAction != Class15.smethod_0(5))
      return;
    GClass62.smethod_27();
  }
}
