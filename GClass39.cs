// Decompiled with JetBrains decompiler
// Type: GClass39
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass39 : GClass37
{
  public string[] info;
  public bool isWait;
  private int int_1;
  private int int_2;
  private long long_0 = -1;

  public GClass39()
  {
    this.int_2 = Class15.smethod_0(95);
    if (GClass62.int_10 <= Class15.smethod_0(314))
      this.int_2 = Class15.smethod_0(31);
    if (GClass62.int_10 <= Class15.smethod_0(197))
      return;
    this.int_2 = Class15.smethod_0(25);
  }

  public void method_0()
  {
    this.method_2(GClass109.string_83, (GClass31) null, (GClass31) null, (GClass31) null);
    GClass62.gclass37_0 = (GClass37) this;
    this.long_0 = GClass126.smethod_18() + (long) Class15.smethod_0(14);
  }

  public override void vmethod_3()
  {
    GClass62.gclass37_0 = (GClass37) this;
    this.long_0 = -1L;
  }

  public void method_1(string info)
  {
    this.info = GClass97.gclass97_21.method_15(info, GClass62.int_10 - (this.int_2 * Class15.smethod_0(7) + Class15.smethod_0(51)));
    this.int_1 = Class15.smethod_0(25);
    if (this.info.Length < Class15.smethod_0(3))
      return;
    this.int_1 = this.info.Length * GClass97.gclass97_21.method_20() + Class15.smethod_0(51);
  }

  public void method_2(string info, GClass31 left, GClass31 center, GClass31 right)
  {
    this.info = GClass97.gclass97_21.method_15(info, GClass62.int_10 - (this.int_2 * Class15.smethod_0(7) + Class15.smethod_0(51)));
    this.left = left;
    this.center = center;
    this.right = right;
    this.int_1 = Class15.smethod_0(25);
    if (this.info.Length >= Class15.smethod_0(3))
      this.int_1 = this.info.Length * GClass97.gclass97_21.method_20() + Class15.smethod_0(51);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((left == null ? 1 : 0) == 0)
      {
        this.left.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(11) - Class15.smethod_0(3);
        this.left.y = GClass62.int_11 - Class15.smethod_0(32);
      }
      if ((right == null ? 1 : 0) == 0)
      {
        this.right.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(3);
        this.right.y = GClass62.int_11 - Class15.smethod_0(32);
      }
      if ((center == null ? 1 : 0) == 0)
      {
        this.center.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(95);
        this.center.y = GClass62.int_11 - Class15.smethod_0(32);
      }
    }
    this.isWait = Class15.smethod_0(0) != 0;
    this.long_0 = -1L;
  }

  public override void vmethod_0(GClass98 g)
  {
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    if ((!GClass117.bool_0 ? 0 : 1) != 0)
      return;
    int y1 = GClass62.int_11 - this.int_1 - Class15.smethod_0(34);
    int w = GClass62.int_10 - this.int_2 * Class15.smethod_0(7);
    GClass62.gclass140_0.method_33(this.int_2, y1, w, this.int_1, g);
    int num = y1 + (this.int_1 - this.info.Length * GClass97.gclass97_21.method_20()) / Class15.smethod_0(7) - Class15.smethod_0(7);
    if ((!this.isWait ? 1 : 0) == 0)
    {
      num += Class15.smethod_0(88);
      GClass62.smethod_44(GClass62.int_12, num - Class15.smethod_0(66), g);
    }
    int index = Class15.smethod_0(0);
    int y2 = num;
    while (index < this.info.Length)
    {
      GClass97.gclass97_6.method_6(g, this.info[index], GClass62.int_12, y2, Class15.smethod_0(7));
      index += Class15.smethod_0(1);
      y2 += GClass97.gclass97_21.method_20();
    }
    base.vmethod_0(g);
  }

  public override void vmethod_2()
  {
    base.vmethod_2();
    if (this.long_0 == -1L || GClass126.smethod_18() <= this.long_0)
      return;
    GClass62.smethod_27();
  }
}
