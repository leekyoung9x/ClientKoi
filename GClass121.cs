// Decompiled with JetBrains decompiler
// Type: GClass121
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass121 : GClass113, GInterface0
{
  private int int_6;
  private GClass31[] gclass31_0;
  private GClass31 gclass31_1;
  public const int int_7 = 100;
  private int int_8;
  private int int_9;
  private int int_10;
  private int int_11;
  private int int_12;

  public GClass121()
  {
    GClass185.int_40 = (int) (byte) ((ulong) GClass126.smethod_18() % (ulong) Class15.smethod_0(45));
    if (GClass185.int_40 == Class15.smethod_0(3) || GClass185.int_40 == Class15.smethod_0(37))
      GClass185.int_40 = Class15.smethod_0(2);
    GClass116.smethod_8(Class15.smethod_0(1) != 0, -1, -1);
    GClass116.int_22 = Class15.smethod_0(21);
    GClass116.int_23 = Class15.smethod_0(90);
  }

  public override void vmethod_0()
  {
    GClass172.smethod_1().method_51();
    base.vmethod_0();
    this.gclass31_0 = new GClass31[GClass120.string_0.Length];
    for (int index = Class15.smethod_0(0); index < GClass120.string_0.Length; index += Class15.smethod_0(1))
      this.gclass31_0[index] = new GClass31(Class13.smethod_0(149139) + (index + Class15.smethod_0(1)).ToString() + Class13.smethod_0(149121) + GClass120.string_0[index], (GInterface0) this, Class15.smethod_0(21) + index, (object) null);
    this.int_6 = GClass120.int_12;
    this.int_10 = Class15.smethod_0(3);
    this.int_8 = Class15.smethod_0(177);
    this.int_9 = GClass113.int_3;
    this.int_11 = Class15.smethod_0(7);
    if (GClass62.int_10 > Class15.smethod_0(5) * (this.int_8 + this.int_10))
      this.int_11 = Class15.smethod_0(5);
    this.int_12 = this.gclass31_0.Length / this.int_11 + ((this.gclass31_0.Length % this.int_11 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    for (int index = Class15.smethod_0(0); index < this.gclass31_0.Length; index += Class15.smethod_0(1))
    {
      if ((this.gclass31_0[index] == null ? 1 : 0) == 0)
      {
        int num1 = GClass62.int_12 - this.int_11 * (this.int_8 + this.int_10) / Class15.smethod_0(7) + index % this.int_11 * (this.int_8 + this.int_10);
        int num2 = GClass62.int_13 - this.int_12 * (this.int_9 + this.int_10) / Class15.smethod_0(7) + index / this.int_11 * (this.int_9 + this.int_10);
        this.gclass31_0[index].x = num1;
        this.gclass31_0[index].y = num2;
      }
    }
    if ((!GClass62.bool_5 ? 0 : 1) != 0)
      return;
    this.gclass31_1 = new GClass31(GClass109.string_146, (GInterface0) this, Class15.smethod_0(87), (object) null);
    this.center = this.gclass31_1;
  }

  public override void vmethod_3()
  {
    GClass116.int_22 += Class15.smethod_0(1);
    if (GClass116.int_22 > GClass62.int_10 * Class15.smethod_0(5) + Class15.smethod_0(21))
      GClass116.int_22 = Class15.smethod_0(21);
    for (int index = Class15.smethod_0(0); index < this.gclass31_0.Length; index += Class15.smethod_0(1))
    {
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        this.gclass31_0[index].isFocus = index != this.int_6 ? Class15.smethod_0(0) != 0 : (GClass62.int_8 % Class15.smethod_0(31) >= Class15.smethod_0(2) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0);
      else if ((this.gclass31_0[index] == null ? 1 : 0) == 0 && (!this.gclass31_0[index].method_4() ? 1 : 0) == 0)
        this.gclass31_0[index].method_1();
    }
  }

  public override void vmethod_5(GClass98 g)
  {
    GClass62.smethod_16(g);
    for (int index = Class15.smethod_0(0); index < this.gclass31_0.Length; index += Class15.smethod_0(1))
    {
      if ((this.gclass31_0[index] == null ? 1 : 0) == 0)
        this.gclass31_0[index].method_3(g);
    }
    base.vmethod_5(g);
  }

  public override void vmethod_4()
  {
    base.vmethod_4();
    int index = this.int_6 % this.int_11;
    int num = this.int_6 / this.int_11;
    if ((!GClass62.bool_11[Class15.smethod_0(2)] ? 1 : 0) == 0)
    {
      if (index > Class15.smethod_0(0))
        this.int_6 -= Class15.smethod_0(1);
      GClass62.bool_11[Class15.smethod_0(2)] = Class15.smethod_0(0) != 0;
    }
    else if ((!GClass62.bool_11[Class15.smethod_0(37)] ? 1 : 0) == 0)
    {
      if (index < this.int_11 - Class15.smethod_0(1))
        this.int_6 += Class15.smethod_0(1);
      GClass62.bool_11[Class15.smethod_0(37)] = Class15.smethod_0(0) != 0;
    }
    else if ((!GClass62.bool_11[Class15.smethod_0(7)] ? 1 : 0) == 0)
    {
      if (num > Class15.smethod_0(0))
        this.int_6 -= this.int_11;
      GClass62.bool_11[Class15.smethod_0(7)] = Class15.smethod_0(0) != 0;
    }
    else if ((!GClass62.bool_11[Class15.smethod_0(88)] ? 1 : 0) == 0)
    {
      if (num < this.int_12 - Class15.smethod_0(1))
        this.int_6 += this.int_11;
      GClass62.bool_11[Class15.smethod_0(88)] = Class15.smethod_0(0) != 0;
    }
    if (this.int_6 < Class15.smethod_0(0))
      this.int_6 = Class15.smethod_0(0);
    if (this.int_6 >= this.gclass31_0.Length)
      this.int_6 = this.gclass31_0.Length - Class15.smethod_0(1);
    if ((!GClass62.bool_11[Class15.smethod_0(3)] ? 1 : 0) == 0)
    {
      this.gclass31_0[index].method_1();
      GClass62.bool_11[Class15.smethod_0(3)] = Class15.smethod_0(0) != 0;
    }
    GClass62.smethod_24();
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(87))
    {
      GClass120.int_12 = this.int_6;
      GClass62.gclass120_0.method_1();
      GClass62.gclass120_0.vmethod_0();
    }
    else
    {
      GClass120.int_12 = idAction - Class15.smethod_0(21);
      GClass62.gclass120_0.method_1();
      GClass62.gclass120_0.vmethod_0();
    }
  }
}
