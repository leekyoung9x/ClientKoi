// Decompiled with JetBrains decompiler
// Type: GClass44
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass44 : GClass42
{
  private int int_0;
  private int int_1;
  private int int_2;
  private long long_0;
  private bool bool_0;
  public static GClass66 gclass66_0 = GClass62.smethod_40(Class13.smethod_0(27516));
  public static GClass66 gclass66_1 = GClass62.smethod_40(Class13.smethod_0(27470));

  public static void smethod_0(int cx, int cy, int ctrans, int timeLengthInSecond, bool isCF) => GClass42.gclass134_5.method_0((object) new GClass44()
  {
    int_0 = cx,
    int_1 = cy,
    int_2 = ctrans,
    bool_0 = isCF,
    long_0 = (GClass126.smethod_18() + (long) (timeLengthInSecond * Class15.smethod_0(15)))
  });

  public override void vmethod_0()
  {
    if (GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(0))
      return;
    GClass42.gclass134_5.method_8((object) this);
  }

  public override void vmethod_1(GClass98 g)
  {
    int sbyte0 = (int) GClass185.sbyte_0;
    if ((!GClass185.smethod_27(this.int_0 + sbyte0 / Class15.smethod_0(7), this.int_1 + Class15.smethod_0(1), Class15.smethod_0(2)) ? 1 : 0) == 0)
      g.method_5(this.int_0 / sbyte0 * sbyte0, (this.int_1 - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    else if ((GClass185.smethod_25((this.int_0 - sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.int_1 + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
      g.method_5(this.int_0 / sbyte0 * sbyte0, (this.int_1 - Class15.smethod_0(6)) / sbyte0 * sbyte0, Class15.smethod_0(21), Class15.smethod_0(21));
    else if ((GClass185.smethod_25((this.int_0 + sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.int_1 + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
      g.method_5(this.int_0 / sbyte0 * sbyte0, (this.int_1 - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    else if ((!GClass185.smethod_27(this.int_0 - sbyte0 / Class15.smethod_0(7), this.int_1 + Class15.smethod_0(1), Class15.smethod_0(88)) ? 1 : 0) == 0)
      g.method_5(this.int_0 / Class15.smethod_0(40) * sbyte0, (this.int_1 - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    g.method_24((!this.bool_0 ? 1 : 0) != 0 ? GClass44.gclass66_1 : GClass44.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), GClass44.gclass66_0.method_0(), GClass44.gclass66_0.method_1(), this.int_2, this.int_0, this.int_1, GClass98.int_5 | GClass98.int_0);
    g.method_5(GClass116.int_22, GClass116.int_23 - GClass62.int_52, GClass116.int_6, GClass116.int_7 + Class15.smethod_0(7) * GClass62.int_52);
  }
}
