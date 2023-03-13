// Decompiled with JetBrains decompiler
// Type: GClass124
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass124 : GClass113, GInterface0
{
  public static GClass124 gclass124_0;
  public GClass184[] tf;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  private string[] string_0;
  private int int_10;
  private int int_11;

  private void method_0(string string_1)
  {
    this.int_8 = GClass62.int_10 - Class15.smethod_0(51);
    if (this.int_8 > Class15.smethod_0(197))
      this.int_8 = Class15.smethod_0(197);
    GClass151.smethod_7(Class13.smethod_0(142111) + string_1);
    this.string_0 = GClass97.gclass97_6.method_15(string_1, this.int_8 - Class15.smethod_0(51));
    this.int_6 = (GClass62.int_10 - this.int_8) / Class15.smethod_0(7);
    this.tf = new GClass184[this.int_11];
    this.int_9 = this.tf.Length * Class15.smethod_0(95) + (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51) + Class15.smethod_0(54);
    this.int_7 = GClass62.int_11 - this.int_9 - Class15.smethod_0(54) - (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51);
    for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
    {
      this.tf[index] = new GClass184();
      this.tf[index].name = string.Empty;
      this.tf[index].x = this.int_6 + Class15.smethod_0(31);
      this.tf[index].y = this.int_7 + Class15.smethod_0(95) + (this.string_0.Length - Class15.smethod_0(1)) * Class15.smethod_0(51) + index * Class15.smethod_0(95);
      this.tf[index].width = this.int_8 - Class15.smethod_0(51);
      this.tf[index].height = GClass113.int_0 + Class15.smethod_0(7);
      int num = !GClass62.bool_5 ? 1 : 0;
      this.tf[Class15.smethod_0(0)].isFocus = num != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        this.right = this.tf[Class15.smethod_0(0)].cmdClear;
    }
    this.left = new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(1), (object) null);
    this.center = new GClass31(GClass109.string_140, (GInterface0) this, Class15.smethod_0(7), (object) null);
    if ((!GClass62.bool_5 ? 1 : 0) != 0)
      return;
    this.center.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(124);
    this.left.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(81);
    this.center.y = this.left.y = this.int_7 + this.int_9 + Class15.smethod_0(3);
  }

  public static GClass124 smethod_2()
  {
    if ((GClass124.gclass124_0 == null ? 0 : 1) == 0)
      GClass124.gclass124_0 = new GClass124();
    return GClass124.gclass124_0;
  }

  public override void vmethod_0()
  {
    this.int_10 = Class15.smethod_0(0);
    base.vmethod_0();
  }

  public void method_1(int type, string title)
  {
    this.int_11 = type;
    this.method_0(title);
    this.vmethod_0();
  }

  public override void vmethod_5(GClass98 g)
  {
    GClass116.smethod_6().vmethod_5(g);
    GClass148.smethod_4(g, this.int_6, this.int_7, this.int_8, this.int_9, -1, Class15.smethod_0(1) != 0);
    for (int index = Class15.smethod_0(0); index < this.string_0.Length; index += Class15.smethod_0(1))
      GClass97.gclass97_7.method_6(g, this.string_0[index], GClass62.int_10 / Class15.smethod_0(7), this.int_7 + Class15.smethod_0(9) + index * Class15.smethod_0(51), GClass97.int_2);
    for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
      this.tf[index].method_13(g);
    base.vmethod_5(g);
  }

  public override void vmethod_3()
  {
    GClass116.smethod_6().vmethod_3();
    for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
      this.tf[index].method_17();
  }

  public override void vmethod_2(int keyCode)
  {
    for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
    {
      if ((!this.tf[index].isFocus ? 1 : 0) == 0)
      {
        this.tf[index].method_10(keyCode);
        break;
      }
    }
    base.vmethod_2(keyCode);
  }

  public override void vmethod_4()
  {
    if ((!GClass62.bool_11[Class15.smethod_0(7)] ? 1 : 0) == 0)
    {
      this.int_10 -= Class15.smethod_0(1);
      if (this.int_10 < Class15.smethod_0(0))
        this.int_10 = this.tf.Length - Class15.smethod_0(1);
    }
    else if ((!GClass62.bool_11[Class15.smethod_0(88)] ? 1 : 0) == 0)
    {
      this.int_10 += Class15.smethod_0(1);
      if (this.int_10 > this.tf.Length - Class15.smethod_0(1))
        this.int_10 = Class15.smethod_0(0);
    }
    if ((!GClass62.bool_11[Class15.smethod_0(7)] ? 0 : 1) != 0 || (!GClass62.bool_11[Class15.smethod_0(88)] ? 1 : 0) == 0)
    {
      GClass62.smethod_24();
      for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
      {
        if (this.int_10 == index)
        {
          this.tf[index].isFocus = Class15.smethod_0(1) != 0;
          if ((!GClass62.bool_5 ? 0 : 1) == 0)
            this.right = this.tf[index].cmdClear;
        }
        else
          this.tf[index].isFocus = Class15.smethod_0(0) != 0;
        if ((!GClass62.bool_16 ? 1 : 0) == 0 && (!GClass62.smethod_22(this.tf[index].x, this.tf[index].y, this.tf[index].width, this.tf[index].height) ? 1 : 0) == 0)
        {
          this.int_10 = index;
          break;
        }
      }
    }
    base.vmethod_4();
    GClass62.smethod_24();
  }

  public void method_2() => GClass124.gclass124_0 = (GClass124) null;

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(1))
    {
      GClass116.gclass116_0.vmethod_0();
      this.method_2();
    }
    if (idAction != Class15.smethod_0(7))
      return;
    for (int index = Class15.smethod_0(0); index < this.tf.Length; index += Class15.smethod_0(1))
    {
      if ((this.tf[index].method_21() == null ? 1 : 0) != 0 || (!this.tf[index].method_21().Equals(string.Empty) ? 1 : 0) == 0)
      {
        GClass62.smethod_28(GClass109.string_433);
        return;
      }
    }
    GClass156.smethod_0().method_8(this.tf);
    GClass116.gclass116_0.vmethod_0();
  }
}
