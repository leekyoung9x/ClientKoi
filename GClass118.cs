// Decompiled with JetBrains decompiler
// Type: GClass118
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass118 : GClass113, GInterface0
{
  public static GClass118 gclass118_0;
  public GClass184 tfSerial;
  public GClass184 tfCode;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  private string[] string_0;
  private int int_10;
  private int int_11;
  private int int_12;
  private int int_13 = GClass62.int_13 - GClass113.int_0 - Class15.smethod_0(3);
  private int int_14;

  public GClass118()
  {
    this.int_8 = GClass62.int_10 - Class15.smethod_0(51);
    if (this.int_8 > Class15.smethod_0(197))
      this.int_8 = Class15.smethod_0(197);
    this.string_0 = GClass97.gclass97_7.method_15(GClass109.string_118, this.int_8 - Class15.smethod_0(51));
    this.int_6 = (GClass62.int_10 - this.int_8) / Class15.smethod_0(7);
    this.int_7 = GClass62.int_11 - Class15.smethod_0(19) - (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51);
    this.int_9 = Class15.smethod_0(80) + (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51);
    this.int_14 = this.int_7;
    this.tfSerial = new GClass184();
    this.tfSerial.name = GClass109.string_116;
    this.tfSerial.x = this.int_6 + Class15.smethod_0(31);
    this.tfSerial.y = this.int_7 + Class15.smethod_0(95) + (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51);
    this.int_11 = this.tfSerial.y;
    this.tfSerial.width = this.int_8 - Class15.smethod_0(51);
    this.tfSerial.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfSerial.isFocus = (!GClass62.bool_5 ? 1 : 0) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
    this.tfSerial.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfSerial.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfSerial.isPaintMouse = Class15.smethod_0(0) != 0;
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
      this.right = this.tfSerial.cmdClear;
    this.tfCode = new GClass184();
    this.tfCode.name = GClass109.string_117;
    this.tfCode.x = this.int_6 + Class15.smethod_0(31);
    this.tfCode.y = this.tfSerial.y + Class15.smethod_0(95);
    this.tfCode.width = this.int_8 - Class15.smethod_0(51);
    this.tfCode.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfCode.isFocus = Class15.smethod_0(0) != 0;
    this.tfCode.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfCode.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfCode.isPaintMouse = Class15.smethod_0(0) != 0;
    this.left = new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(1), (object) null);
    this.center = new GClass31(GClass109.string_119, (GInterface0) this, Class15.smethod_0(7), (object) null);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.center.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(124);
      this.left.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(81);
      this.center.y = this.left.y = this.int_7 + this.int_9 + Class15.smethod_0(3);
    }
    this.int_12 = this.tfSerial.y - (Class15.smethod_0(2) * this.tfSerial.height - Class15.smethod_0(31));
    this.int_14 = this.tfSerial.y;
  }

  public static GClass118 smethod_2()
  {
    if ((GClass118.gclass118_0 == null ? 0 : 1) == 0)
      GClass118.gclass118_0 = new GClass118();
    return GClass118.gclass118_0;
  }

  public override void vmethod_0()
  {
    this.int_10 = Class15.smethod_0(0);
    base.vmethod_0();
  }

  public void method_0()
  {
  }

  public override void vmethod_5(GClass98 g)
  {
    GClass116.smethod_6().vmethod_5(g);
    GClass148.smethod_4(g, this.int_6, this.int_7, this.int_8, this.int_9, -1, Class15.smethod_0(1) != 0);
    for (int index = Class15.smethod_0(0); index < this.string_0.Length; index += Class15.smethod_0(1))
      GClass97.gclass97_7.method_6(g, this.string_0[index], GClass62.int_10 / Class15.smethod_0(7), this.int_7 + Class15.smethod_0(9) + index * Class15.smethod_0(51), GClass97.int_2);
    this.tfSerial.method_13(g);
    this.tfCode.method_13(g);
    base.vmethod_5(g);
  }

  public override void vmethod_3()
  {
    GClass116.smethod_6().vmethod_3();
    this.tfSerial.method_17();
    this.tfCode.method_17();
    if ((!Main.bool_4 ? 1 : 0) != 0)
      return;
    this.method_0();
  }

  public override void vmethod_2(int keyCode)
  {
    if ((!this.tfSerial.isFocus ? 1 : 0) == 0)
      this.tfSerial.method_10(keyCode);
    else if ((!this.tfCode.isFocus ? 1 : 0) == 0)
      this.tfCode.method_10(keyCode);
    base.vmethod_2(keyCode);
  }

  public override void vmethod_4()
  {
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      this.int_10 -= Class15.smethod_0(1);
      if (this.int_10 < Class15.smethod_0(0))
        this.int_10 = Class15.smethod_0(1);
    }
    else if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      this.int_10 += Class15.smethod_0(1);
      if (this.int_10 > Class15.smethod_0(1))
        this.int_10 = Class15.smethod_0(1);
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 0 : 1) != 0 || (!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      GClass62.smethod_24();
      if (this.int_10 == Class15.smethod_0(1))
      {
        this.tfSerial.isFocus = Class15.smethod_0(0) != 0;
        this.tfCode.isFocus = Class15.smethod_0(1) != 0;
        if ((!GClass62.bool_5 ? 0 : 1) == 0)
          this.right = this.tfCode.cmdClear;
      }
      else if ((this.int_10 == 0 ? 0 : 1) == 0)
      {
        this.tfSerial.isFocus = Class15.smethod_0(1) != 0;
        this.tfCode.isFocus = Class15.smethod_0(0) != 0;
        if ((!GClass62.bool_5 ? 0 : 1) == 0)
          this.right = this.tfSerial.cmdClear;
      }
      else
      {
        this.tfSerial.isFocus = Class15.smethod_0(0) != 0;
        this.tfCode.isFocus = Class15.smethod_0(0) != 0;
      }
    }
    if ((!GClass62.bool_16 ? 1 : 0) == 0)
    {
      if ((!GClass62.smethod_22(this.tfSerial.x, this.tfSerial.y, this.tfSerial.width, this.tfSerial.height) ? 1 : 0) == 0)
        this.int_10 = Class15.smethod_0(0);
      else if ((!GClass62.smethod_22(this.tfCode.x, this.tfCode.y, this.tfCode.width, this.tfCode.height) ? 1 : 0) == 0)
        this.int_10 = Class15.smethod_0(1);
    }
    base.vmethod_4();
    GClass62.smethod_24();
  }

  public void method_1() => GClass118.gclass118_0 = (GClass118) null;

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(1))
    {
      GClass116.gclass116_0.vmethod_0();
      this.method_1();
    }
    if (idAction != Class15.smethod_0(7))
      return;
    if ((this.tfSerial.method_21() == null ? 1 : 0) == 0 && (!this.tfSerial.method_21().Equals(string.Empty) ? 1 : 0) != 0)
    {
      if ((this.tfCode.method_21() == null ? 1 : 0) == 0 && (!this.tfCode.method_21().Equals(string.Empty) ? 1 : 0) != 0)
      {
        GClass156.smethod_0().method_101(this.tfSerial.method_21(), this.tfCode.method_21());
        GClass116.gclass116_0.vmethod_0();
        this.method_1();
      }
      else
        GClass62.smethod_28(GClass109.string_121);
    }
    else
      GClass62.smethod_28(GClass109.string_120);
  }
}
