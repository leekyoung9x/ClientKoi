// Decompiled with JetBrains decompiler
// Type: GClass113
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass113
{
  public GClass31 left;
  public GClass31 center;
  public GClass31 right;
  public GClass31 cmdClose;
  public static int int_0;
  public static int int_1 = Class15.smethod_0(21);
  public static int int_2 = Class15.smethod_0(11);
  public static int int_3 = Class15.smethod_0(50);
  public static int int_4 = -1;
  public static int int_5 = -1;

  public virtual void vmethod_0()
  {
    GClass62.smethod_24();
    GClass62.smethod_25();
    if ((GClass62.gclass113_0 == null ? 1 : 0) == 0)
      GClass62.gclass113_0.vmethod_1();
    GClass62.gclass113_0 = this;
    string str1 = Class13.smethod_0(153766);
    GClass113 gclass1130 = GClass62.gclass113_0;
    string str2 = (gclass1130 == null ? 0 : 1) != 0 ? gclass1130.ToString() : (string) null;
    GClass33.smethod_4(str1 + str2);
  }

  public virtual void vmethod_1()
  {
  }

  public static void smethod_0()
  {
  }

  public virtual void vmethod_2(int keyCode)
  {
  }

  public virtual void vmethod_3()
  {
  }

  public virtual void vmethod_4()
  {
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(GClass62.gclass113_0.center) ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if ((this.center == null ? 1 : 0) == 0)
        this.center.method_1();
    }
    if ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass113.smethod_1(GClass62.gclass113_0.left) ? 1 : 0) == 0)
    {
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if ((!GClass23.smethod_0().isShow ? 1 : 0) == 0)
      {
        if ((GClass23.smethod_0().left == null ? 1 : 0) == 0)
          GClass23.smethod_0().left.method_1();
      }
      else if ((this.left == null ? 1 : 0) == 0)
        this.left.method_1();
    }
    if ((!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) == 0 && (!GClass113.smethod_1(GClass62.gclass113_0.right) ? 0 : 1) == 0)
      return;
    GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(0) != 0;
    GClass113.int_4 = -1;
    GClass62.bool_16 = Class15.smethod_0(0) != 0;
    if ((!GClass23.smethod_0().isShow ? 1 : 0) == 0)
    {
      if ((GClass23.smethod_0().right == null ? 1 : 0) != 0)
        return;
      GClass23.smethod_0().right.method_1();
    }
    else
    {
      if ((this.right == null ? 1 : 0) != 0)
        return;
      this.right.method_1();
    }
  }

  public static bool smethod_1(GClass31 cmd)
  {
    if ((cmd == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if (cmd.x >= Class15.smethod_0(0) && (cmd.y == 0 ? 1 : 0) == 0)
      return cmd.method_4();
    if ((GClass62.gclass37_0 == null ? 1 : 0) == 0)
    {
      if ((GClass62.gclass37_0.center == null ? 1 : 0) == 0 && (!GClass62.smethod_22(GClass62.int_10 - GClass113.int_2 >> Class15.smethod_0(1), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(1);
        if (cmd == GClass62.gclass37_0.center && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
      if ((GClass62.gclass37_0.left == null ? 1 : 0) == 0 && (!GClass62.smethod_22(Class15.smethod_0(0), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(0);
        if (cmd == GClass62.gclass37_0.left && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
      if ((GClass62.gclass37_0.right == null ? 1 : 0) == 0 && (!GClass62.smethod_22(GClass62.int_10 - GClass113.int_2, GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(7);
        if ((cmd == GClass62.gclass37_0.right || cmd == GClass23.smethod_0().right) && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
    }
    else
    {
      if (cmd == GClass62.gclass113_0.left && (!GClass62.smethod_22(Class15.smethod_0(0), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(0);
        if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
      if (cmd == GClass62.gclass113_0.right && (!GClass62.smethod_22(GClass62.int_10 - GClass113.int_2, GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(7);
        if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
      if ((cmd == GClass62.gclass113_0.center || (GClass43.gclass43_0 == null ? 1 : 0) == 0) && (!GClass62.smethod_22(GClass62.int_10 - GClass113.int_2 >> Class15.smethod_0(1), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(3), GClass113.int_2, GClass113.int_3 + Class15.smethod_0(31)) ? 1 : 0) == 0)
      {
        GClass113.int_4 = Class15.smethod_0(1);
        if ((!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          return Class15.smethod_0(1) != 0;
      }
    }
    return Class15.smethod_0(0) != 0;
  }

  public virtual void vmethod_5(GClass98 g)
  {
    g.method_1(-g.method_3(), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11 + Class15.smethod_0(1));
    if ((!GClass23.smethod_0().isShow ? 1 : 0) == 0 && (!Main.bool_3 ? 0 : 1) != 0 || (GClass62.gclass37_0 == null ? 0 : 1) != 0 || (!GClass62.gclass95_0.showMenu ? 0 : 1) != 0)
      return;
    GClass62.gclass140_0.method_7(g, this.left, this.center, this.right);
  }
}
