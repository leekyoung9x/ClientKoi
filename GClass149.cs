// Decompiled with JetBrains decompiler
// Type: GClass149
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass149 : GInterface0
{
  public GClass31 cmdYes;
  public GClass31 cmdNo;
  public string[] info;
  private int int_0;
  private int int_1;
  private int int_2 = Class15.smethod_0(98);
  private int int_3;
  private int int_4;
  private long long_0;
  private long long_1;

  public void method_0(string info, GClass31 cmdYes, GClass31 cmdNo)
  {
    string[] strArray = new string[Class15.smethod_0(1)];
    strArray[Class15.smethod_0(0)] = info;
    this.info = strArray;
    this.int_3 = Class15.smethod_0(36);
    this.cmdYes = cmdYes;
    this.cmdNo = cmdNo;
    this.cmdYes.img = this.cmdNo.img = GClass116.gclass66_42;
    this.cmdYes.imgFocus = this.cmdNo.imgFocus = GClass116.gclass66_43;
    this.cmdYes.w = GClass98.smethod_0(cmdYes.img);
    this.cmdNo.w = GClass98.smethod_0(cmdYes.img);
    this.cmdYes.h = GClass98.smethod_1(cmdYes.img);
    this.cmdNo.h = GClass98.smethod_1(cmdYes.img);
    this.long_0 = GClass126.smethod_18();
    this.int_4 = this.info[Class15.smethod_0(0)].Length / Class15.smethod_0(5);
    if (this.int_4 < Class15.smethod_0(9))
      this.int_4 = Class15.smethod_0(9);
    GClass183.smethod_0();
  }

  public void method_1(GClass98 g)
  {
    GClass148.smethod_4(g, this.int_0, this.int_1, this.int_2, this.int_3 + ((!GClass62.bool_5 ? 1 : 0) != 0 ? Class15.smethod_0(31) : Class15.smethod_0(0)), Class15.smethod_0(142), Class15.smethod_0(0) != 0);
    if ((this.info == null ? 1 : 0) != 0)
      return;
    GClass183.smethod_1(g, this.info[Class15.smethod_0(0)], this.int_0 + Class15.smethod_0(3), this.int_1 + this.int_3 / Class15.smethod_0(7) - ((!GClass62.bool_5 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(2)), this.int_2 - Class15.smethod_0(31), this.int_3, GClass97.gclass97_11);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.cmdYes.method_3(g);
      GClass97.gclass97_15.method_10(g, this.int_4.ToString() + string.Empty, this.cmdYes.x + this.cmdYes.w / Class15.smethod_0(7), this.cmdYes.y + this.cmdYes.h + Class15.smethod_0(3), Class15.smethod_0(7), GClass97.gclass97_16);
    }
    else if ((!GClass184.bool_0 ? 1 : 0) == 0)
      GClass97.gclass97_2.method_6(g, GClass109.string_238 + this.int_4.ToString() + Class13.smethod_0(147965), this.int_0 + this.int_2 / Class15.smethod_0(7), this.int_1 + this.int_3 - Class15.smethod_0(37), Class15.smethod_0(7));
    else
      GClass97.gclass97_2.method_6(g, GClass109.string_239 + this.int_4.ToString() + Class13.smethod_0(147965), this.int_0 + this.int_2 / Class15.smethod_0(7), this.int_1 + this.int_3 - Class15.smethod_0(37), Class15.smethod_0(7));
  }

  public void method_2()
  {
    if ((this.info == null ? 1 : 0) != 0)
      return;
    this.int_0 = GClass62.int_10 - Class15.smethod_0(3) - this.int_2;
    this.int_1 = Class15.smethod_0(70);
    if (GClass62.int_10 - Class15.smethod_0(32) > Class15.smethod_0(402) + this.int_2)
    {
      this.int_0 = GClass62.int_10 - Class15.smethod_0(280) - this.int_2;
      this.int_1 = Class15.smethod_0(3);
    }
    this.cmdYes.x = this.int_0 - Class15.smethod_0(95);
    this.cmdYes.y = this.int_1;
    this.long_1 = GClass126.smethod_18();
    GClass151.smethod_7(Class13.smethod_0(147701) + (this.long_1 - this.long_0).ToString());
    if (this.long_1 - this.long_0 >= (long) Class15.smethod_0(15))
    {
      this.long_0 = GClass126.smethod_18();
      this.int_4 -= Class15.smethod_0(1);
    }
    if ((this.int_4 == 0 ? 0 : 1) != 0)
      return;
    GClass116.smethod_6().popUpYesNo = (GClass149) null;
  }

  public void imethod_0(int idAction, object p)
  {
  }
}
