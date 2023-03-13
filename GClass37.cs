// Decompiled with JetBrains decompiler
// Type: GClass37
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public abstract class GClass37
{
  public GClass31 left;
  public GClass31 center;
  public GClass31 right;
  private int int_0;

  public virtual void vmethod_0(GClass98 g)
  {
    g.method_1(-g.method_3(), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    GClass62.gclass140_0.method_8(g);
    GClass62.gclass140_0.method_7(g, this.left, this.center, this.right);
  }

  public virtual void vmethod_1(int keyCode)
  {
    if (keyCode <= Class15.smethod_0(309))
    {
      if (keyCode != Class15.smethod_0(310))
      {
        if (keyCode != Class15.smethod_0(205))
        {
          if (keyCode != Class15.smethod_0(309))
            return;
        }
        else
          goto label_12;
      }
      else
        goto label_11;
    }
    else
    {
      if (keyCode != Class15.smethod_0(311))
      {
        switch (keyCode - Class15.smethod_0(252))
        {
          case 0:
            goto label_9;
          case 1:
            break;
          case 2:
            GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(1) != 0;
            GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(1) != 0;
            return;
          case 3:
            return;
          case 4:
            return;
          case 5:
            goto label_11;
          case 6:
            goto label_12;
          default:
            if (keyCode != Class15.smethod_0(31))
              return;
            goto case 2;
        }
      }
      GClass62.bool_13[Class15.smethod_0(66)] = Class15.smethod_0(1) != 0;
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(1) != 0;
      return;
    }
label_9:
    GClass62.bool_13[Class15.smethod_0(47)] = Class15.smethod_0(1) != 0;
    GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(1) != 0;
    return;
label_11:
    GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(1) != 0;
    GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(1) != 0;
    return;
label_12:
    GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
    GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(1) != 0;
  }

  public virtual void vmethod_2()
  {
    if ((this.center == null ? 1 : 0) == 0 && ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.center) ? 1 : 0) == 0))
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
      GClass62.bool_15 = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if ((this.center == null ? 1 : 0) == 0)
        this.center.method_1();
      GClass113.int_4 = -1;
    }
    if ((this.left == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.left) ? 1 : 0) == 0))
    {
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(0) != 0;
      GClass62.bool_15 = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if ((this.left == null ? 1 : 0) == 0)
        this.left.method_1();
      GClass113.int_4 = -1;
    }
    if ((this.right == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.right) ? 1 : 0) == 0))
    {
      GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(0) != 0;
      GClass62.bool_15 = Class15.smethod_0(0) != 0;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      if ((this.right == null ? 1 : 0) == 0)
        this.right.method_1();
      GClass113.int_4 = -1;
    }
    GClass62.smethod_24();
    GClass62.smethod_25();
  }

  public virtual void vmethod_3()
  {
  }
}
