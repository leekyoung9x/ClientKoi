// Decompiled with JetBrains decompiler
// Type: GClass38
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass38 : GClass37
{
  protected string[] string_0;
  public GClass184 tfInput;
  private int int_1;

  public GClass38()
  {
    this.int_1 = Class15.smethod_0(54);
    if (GClass62.int_10 <= Class15.smethod_0(314))
      this.int_1 = Class15.smethod_0(31);
    this.tfInput = new GClass184();
    this.tfInput.x = this.int_1 + Class15.smethod_0(31);
    this.tfInput.y = GClass62.int_11 - GClass113.int_0 - Class15.smethod_0(248);
    this.tfInput.width = GClass62.int_10 - Class15.smethod_0(7) * (this.int_1 + Class15.smethod_0(31));
    this.tfInput.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfInput.isFocus = Class15.smethod_0(1) != 0;
    this.right = this.tfInput.cmdClear;
  }

  public void method_0(string info, GClass31 ok, int type)
  {
    this.tfInput.method_23(string.Empty);
    this.tfInput.method_28(type);
    this.string_0 = GClass97.gclass97_21.method_15(info, GClass62.int_10 - this.int_1 * Class15.smethod_0(7));
    this.left = new GClass31(GClass109.string_125, (GInterface0) GClass62.smethod_1(), Class15.smethod_0(327), (object) null);
    this.center = ok;
    this.vmethod_3();
  }

  public override void vmethod_0(GClass98 g)
  {
    GClass62.gclass140_0.method_19(g, this.int_1, GClass62.int_11 - Class15.smethod_0(216) - GClass113.int_3, GClass62.int_10 - this.int_1 * Class15.smethod_0(7), Class15.smethod_0(151), this.string_0);
    this.tfInput.method_13(g);
    base.vmethod_0(g);
  }

  public override void vmethod_1(int keyCode)
  {
    this.tfInput.method_10(keyCode);
    base.vmethod_1(keyCode);
  }

  public override void vmethod_2()
  {
    this.tfInput.method_17();
    base.vmethod_2();
  }

  public override void vmethod_3() => GClass62.gclass37_0 = (GClass37) this;

  public void method_1() => GClass62.smethod_27();
}
