// Decompiled with JetBrains decompiler
// Type: GClass23
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass23 : GInterface0
{
  private static GClass23 gclass23_0;
  public GClass184 tfChat;
  public bool isShow;
  public GInterface1 parentScreen;
  private long long_0;
  public GClass31 left;
  public GClass31 cmdChat;
  public GClass31 right;
  public GClass31 center;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private bool bool_0;
  public GClass31 cmdChat2;
  public int yBegin;
  public int yUp;
  public int KC;
  public string to;
  public string strChat = Class13.smethod_0(24770);

  public GClass23()
  {
    this.tfChat = new GClass184();
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfChat.isPaintMouse = Class15.smethod_0(0) != 0;
    this.tfChat.name = Class13.smethod_0(25395);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.strInfo = this.tfChat.name;
    this.tfChat.width = GClass62.int_10 - Class15.smethod_0(37);
    if ((!Main.bool_3 ? 1 : 0) == 0 && this.tfChat.width > Class15.smethod_0(262))
      this.tfChat.width = Class15.smethod_0(262);
    this.tfChat.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfChat.x = GClass62.int_10 / Class15.smethod_0(7) - this.tfChat.width / Class15.smethod_0(7);
    this.tfChat.isFocus = Class15.smethod_0(1) != 0;
    this.tfChat.method_26(Class15.smethod_0(25));
  }

  public void method_0()
  {
    this.left = new GClass31(GClass109.string_140, (GInterface0) this, Class15.smethod_0(260), (object) null, Class15.smethod_0(1), GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(1));
    this.right = new GClass31(GClass109.string_129, (GInterface0) this, Class15.smethod_0(263), (object) null, GClass62.int_10 - Class15.smethod_0(152), GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(1));
    this.center = (GClass31) null;
    this.int_2 = this.tfChat.width + Class15.smethod_0(51);
    this.int_3 = this.tfChat.height + Class15.smethod_0(50);
    this.int_0 = GClass62.int_10 / Class15.smethod_0(7) - this.int_2 / Class15.smethod_0(7);
    this.int_1 = this.tfChat.y - Class15.smethod_0(124);
    if ((!Main.bool_3 ? 1 : 0) == 0 && this.int_2 > Class15.smethod_0(197))
      this.int_2 = Class15.smethod_0(197);
    this.left.x = this.int_0;
    this.right.x = this.int_0 + this.int_2 - Class15.smethod_0(11);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.tfChat.y -= Class15.smethod_0(3);
      this.int_1 -= Class15.smethod_0(51);
      this.int_3 += Class15.smethod_0(6);
      this.left.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(11) - Class15.smethod_0(3);
      this.right.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(3);
      this.left.y = GClass62.int_11 - Class15.smethod_0(6);
      this.right.y = GClass62.int_11 - Class15.smethod_0(6);
    }
    this.cmdChat = new GClass31();
    this.cmdChat.actionChat = (GDelegate0) (string_0 =>
    {
      this.tfChat.justReturnFromTextBox = Class15.smethod_0(0) != 0;
      this.tfChat.method_23(string_0);
      this.parentScreen.imethod_1(string_0, this.to);
      this.tfChat.method_23(string.Empty);
      this.right.caption = GClass109.string_125;
    });
    this.cmdChat2 = new GClass31();
    this.cmdChat2.actionChat = (GDelegate0) (string_0 =>
    {
      this.tfChat.justReturnFromTextBox = Class15.smethod_0(0) != 0;
      if ((this.parentScreen == null ? 1 : 0) == 0)
      {
        this.tfChat.method_23(string_0);
        this.parentScreen.imethod_1(string_0, this.to);
        this.tfChat.method_23(string.Empty);
        this.tfChat.method_22();
        if ((this.right == null ? 1 : 0) == 0)
          this.right.method_1();
      }
      this.isShow = Class15.smethod_0(0) != 0;
    });
    this.yBegin = this.tfChat.y;
    this.yUp = GClass62.int_11 / Class15.smethod_0(7) - Class15.smethod_0(7) * this.tfChat.height;
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) != 0)
      return;
    this.tfChat.isPaintMouse = Class15.smethod_0(0) != 0;
  }

  public void method_1()
  {
  }

  public void method_2(int keyCode)
  {
    if ((!this.isShow ? 1 : 0) == 0)
      this.tfChat.method_10(keyCode);
    if ((!this.tfChat.method_21().Equals(string.Empty) ? 1 : 0) == 0)
      this.right.caption = GClass109.string_125;
    else
      this.right.caption = GClass109.string_129;
  }

  public static GClass23 smethod_0() => (GClass23.gclass23_0 == null ? 0 : 1) == 0 ? (GClass23.gclass23_0 = new GClass23()) : GClass23.gclass23_0;

  public void method_3(int firstCharacter, GInterface1 parentScreen, string to)
  {
    this.right.caption = GClass109.string_125;
    this.to = to;
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfChat.isPaintMouse = Class15.smethod_0(0) != 0;
    this.tfChat.method_10(firstCharacter);
    if ((!this.tfChat.method_21().Equals(string.Empty) ? 0 : 1) != 0 || (GClass62.gclass37_0 == null ? 0 : 1) != 0)
      return;
    this.parentScreen = parentScreen;
    this.isShow = Class15.smethod_0(1) != 0;
  }

  public void method_4(GInterface1 parentScreen, string to)
  {
    this.right.caption = GClass109.string_125;
    this.to = to;
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfChat.isPaintMouse = Class15.smethod_0(0) != 0;
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      this.isShow = Class15.smethod_0(1) != 0;
      this.tfChat.isFocus = Class15.smethod_0(1) != 0;
      if ((!Main.bool_3 ? 0 : 1) == 0)
      {
        GClass79.smethod_0(this.strChat, GClass79.int_0, string.Empty, this.cmdChat);
        this.tfChat.method_20(Class15.smethod_0(1) != 0);
      }
    }
    this.tfChat.method_23(string.Empty);
    this.tfChat.method_5();
    this.bool_0 = Class15.smethod_0(0) != 0;
  }

  public void method_5(GInterface1 parentScreen, string to)
  {
    this.tfChat.method_20(Class15.smethod_0(1) != 0);
    this.to = to;
    this.parentScreen = parentScreen;
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.tfChat.showSubTextField = Class15.smethod_0(0) != 0;
    if ((!Main.bool_5 ? 1 : 0) == 0)
      this.tfChat.isPaintMouse = Class15.smethod_0(0) != 0;
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      this.isShow = Class15.smethod_0(1) != 0;
      if ((!Main.bool_3 ? 0 : 1) == 0)
      {
        GClass79.smethod_0(this.strChat, GClass79.int_0, string.Empty, this.cmdChat2);
        this.tfChat.method_20(Class15.smethod_0(1) != 0);
      }
    }
    this.tfChat.method_23(string.Empty);
    this.tfChat.method_5();
    this.bool_0 = Class15.smethod_0(0) != 0;
  }

  public void method_6()
  {
    if ((!this.isShow ? 1 : 0) != 0)
      return;
    if ((this.left == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.left) ? 1 : 0) == 0) && (this.left == null ? 1 : 0) == 0)
      this.left.method_1();
    if ((this.right == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.right) ? 1 : 0) == 0) && (this.right == null ? 1 : 0) == 0)
      this.right.method_1();
    if ((this.center == null ? 1 : 0) == 0 && ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.center) ? 1 : 0) == 0) && (this.center == null ? 1 : 0) == 0)
      this.center.method_1();
    if ((!this.isShow ? 1 : 0) == 0 && (GClass62.int_65 == 0 ? 1 : 0) == 0)
    {
      this.method_2(GClass62.int_65);
      GClass62.int_65 = Class15.smethod_0(0);
    }
    GClass62.smethod_25();
    GClass62.smethod_24();
  }

  public void method_7()
  {
    if ((!this.isShow ? 0 : 1) == 0)
      return;
    this.tfChat.method_17();
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.method_1();
    if ((!this.tfChat.justReturnFromTextBox ? 1 : 0) == 0)
    {
      this.tfChat.justReturnFromTextBox = Class15.smethod_0(0) != 0;
      this.parentScreen.imethod_1(this.tfChat.method_21(), this.to);
      this.tfChat.method_23(string.Empty);
      this.right.caption = GClass109.string_125;
    }
    if ((!Main.bool_3 ? 0 : 1) == 0)
      return;
    if ((!GClass62.bool_11[Class15.smethod_0(9)] ? 1 : 0) == 0)
    {
      if ((this.left == null ? 1 : 0) == 0 && (!(this.tfChat.method_21() != string.Empty) ? 1 : 0) == 0)
        this.left.method_1();
      GClass62.bool_11[Class15.smethod_0(9)] = Class15.smethod_0(0) != 0;
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
    }
    if ((!GClass62.bool_11[Class15.smethod_0(49)] ? 1 : 0) != 0)
      return;
    if ((this.right == null ? 1 : 0) == 0)
      this.right.method_1();
    GClass62.bool_11[Class15.smethod_0(49)] = Class15.smethod_0(0) != 0;
  }

  public void method_8()
  {
    this.tfChat.method_23(string.Empty);
    this.isShow = Class15.smethod_0(0) != 0;
  }

  public void method_9(GClass98 g)
  {
    if ((!this.isShow ? 1 : 0) != 0 || (!Main.bool_5 ? 0 : 1) != 0)
      return;
    int y = (!Main.bool_4 ? 1 : 0) != 0 ? this.int_1 - this.KC : this.tfChat.y - Class15.smethod_0(3);
    int x = (!Main.bool_4 ? 1 : 0) != 0 ? this.int_0 : Class15.smethod_0(0);
    int w = (!Main.bool_4 ? 1 : 0) != 0 ? this.int_2 : GClass62.int_10;
    GClass148.smethod_4(g, x, y, w, this.int_3, -1, Class15.smethod_0(1) != 0);
    if ((!Main.bool_3 ? 1 : 0) == 0)
    {
      GClass97.gclass97_7.method_6(g, this.strChat + this.to, this.tfChat.x, this.tfChat.y - ((!GClass62.bool_5 ? 1 : 0) != 0 ? Class15.smethod_0(66) : Class15.smethod_0(186)), Class15.smethod_0(0));
      GClass62.gclass140_0.method_7(g, this.left, this.center, this.right);
    }
    this.tfChat.method_13(g);
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(260))
    {
      case 0:
        GClass33.smethod_2(Class13.smethod_0(25438));
        if ((this.parentScreen == null ? 1 : 0) != 0)
          break;
        long num = GClass126.smethod_18();
        if (num - this.long_0 < (long) Class15.smethod_0(15))
          break;
        this.long_0 = num;
        this.parentScreen.imethod_1(this.tfChat.method_21(), this.to);
        this.tfChat.method_23(string.Empty);
        this.right.caption = GClass109.string_125;
        this.tfChat.method_22();
        break;
      case 1:
        GClass33.smethod_2(Class13.smethod_0(25518));
        if ((!this.tfChat.method_21().Equals(string.Empty) ? 1 : 0) == 0)
        {
          this.isShow = Class15.smethod_0(0) != 0;
          this.parentScreen.imethod_2();
        }
        this.tfChat.method_4();
        break;
    }
  }
}
