// Decompiled with JetBrains decompiler
// Type: GClass31
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass31
{
  public GDelegate0 actionChat;
  public string caption;
  public string[] subCaption;
  public GInterface0 actionListener;
  public int idAction;
  public bool isPlaySoundButton = Class15.smethod_0(1) != 0;
  public GClass66 img;
  public GClass66 imgFocus;
  public int x;
  public int y;
  public int w = GClass113.int_2;
  public int h = GClass113.int_3;
  public int hw;
  private int int_0;
  public bool isFocus;
  public object p;
  public int type;
  public string caption2 = string.Empty;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public static GClass66 gclass66_3;
  public static GClass66 gclass66_4;
  public static GClass66 gclass66_5;
  public bool cmdClosePanel;

  public GClass31(
    string caption,
    GInterface0 actionListener,
    int action,
    object p,
    int x,
    int y)
  {
    this.caption = caption;
    this.idAction = action;
    this.actionListener = actionListener;
    this.p = p;
    this.x = x;
    this.y = y;
  }

  public GClass31()
  {
  }

  public GClass31(string caption, GInterface0 actionListener, int action, object p)
  {
    this.caption = caption;
    this.idAction = action;
    this.actionListener = actionListener;
    this.p = p;
  }

  public GClass31(string caption, int action, object p)
  {
    this.caption = caption;
    this.idAction = action;
    this.p = p;
  }

  public GClass31(string caption, int action)
  {
    this.caption = caption;
    this.idAction = action;
  }

  public GClass31(string caption, int action, int x, int y)
  {
    this.caption = caption;
    this.idAction = action;
    this.x = x;
    this.y = y;
  }

  public void method_0(string str)
  {
    if ((this.actionChat == null ? 1 : 0) != 0)
      return;
    this.actionChat(str);
  }

  public void method_1()
  {
    GClass62.smethod_46();
    if ((!this.isPlaySoundButton ? 1 : 0) == 0 && ((this.caption == null ? 1 : 0) == 0 && (!this.caption.Equals(string.Empty) ? 0 : 1) == 0 && (!this.caption.Equals(GClass109.string_232) ? 1 : 0) != 0 || (this.img == null ? 1 : 0) == 0))
      GClass172.smethod_1().method_35();
    if (this.idAction <= Class15.smethod_0(0))
      return;
    if ((this.actionListener == null ? 1 : 0) == 0)
      this.actionListener.imethod_0(this.idAction, this.p);
    else
      GClass116.smethod_6().method_116(this.idAction, this.p);
  }

  public void method_2()
  {
    this.type = Class15.smethod_0(1);
    this.w = Class15.smethod_0(195);
    this.hw = Class15.smethod_0(25);
  }

  public void method_3(GClass98 g)
  {
    if ((this.img == null ? 1 : 0) == 0)
    {
      g.method_32(this.img, this.x, this.y + GClass98.int_20, Class15.smethod_0(0));
      if ((!this.isFocus ? 1 : 0) == 0)
      {
        if ((this.imgFocus == null ? 0 : 1) == 0)
        {
          if ((!this.cmdClosePanel ? 1 : 0) == 0)
            g.method_32(GClass81.gclass66_0, this.x + Class15.smethod_0(88), this.y + GClass98.int_20 + Class15.smethod_0(88), Class15.smethod_0(5));
          else
            g.method_32(GClass81.gclass66_0, this.x - ((!this.img.Equals((object) GClass116.gclass66_11) ? 0 : 1) != 0 ? Class15.smethod_0(31) : Class15.smethod_0(0)), this.y + GClass98.int_20, Class15.smethod_0(0));
        }
        else
          g.method_32(this.imgFocus, this.x, this.y + GClass98.int_20, Class15.smethod_0(0));
      }
      if ((!(this.caption != Class13.smethod_0(26947)) ? 1 : 0) != 0 || (this.caption == null ? 1 : 0) != 0)
        return;
      if ((!this.isFocus ? 0 : 1) == 0)
        GClass97.gclass97_6.method_6(g, this.caption, this.x + GClass98.smethod_0(this.img) / Class15.smethod_0(7), this.y + GClass98.smethod_1(this.img) / Class15.smethod_0(7) - Class15.smethod_0(3), Class15.smethod_0(7));
      else
        GClass97.gclass97_7.method_6(g, this.caption, this.x + GClass98.smethod_0(this.img) / Class15.smethod_0(7), this.y + GClass98.smethod_1(this.img) / Class15.smethod_0(7) - Class15.smethod_0(3), Class15.smethod_0(7));
    }
    else
    {
      if ((!(this.caption != string.Empty) ? 1 : 0) == 0)
      {
        if (this.type == Class15.smethod_0(1))
        {
          if ((!this.isFocus ? 0 : 1) == 0)
            GClass31.smethod_0(GClass31.gclass66_0, GClass31.gclass66_1, GClass31.gclass66_2, this.x, this.y, Class15.smethod_0(195), g);
          else
            GClass31.smethod_0(GClass31.gclass66_3, GClass31.gclass66_4, GClass31.gclass66_5, this.x, this.y, Class15.smethod_0(195), g);
        }
        else if ((!this.isFocus ? 0 : 1) == 0)
          GClass31.smethod_0(GClass31.gclass66_0, GClass31.gclass66_1, GClass31.gclass66_2, this.x, this.y, Class15.smethod_0(177), g);
        else
          GClass31.smethod_0(GClass31.gclass66_3, GClass31.gclass66_4, GClass31.gclass66_5, this.x, this.y, Class15.smethod_0(177), g);
      }
      int x = this.type != Class15.smethod_0(1) ? this.x + Class15.smethod_0(34) : this.x + this.hw;
      if ((!this.isFocus ? 0 : 1) == 0)
        GClass97.gclass97_6.method_6(g, this.caption, x, this.y + Class15.smethod_0(38), Class15.smethod_0(7));
      else
        GClass97.gclass97_7.method_6(g, this.caption, x, this.y + Class15.smethod_0(38), Class15.smethod_0(7));
    }
  }

  public static void smethod_0(
    GClass66 img0,
    GClass66 img1,
    GClass66 img2,
    int x,
    int y,
    int size,
    GClass98 g)
  {
    for (int index = Class15.smethod_0(31); index <= size - Class15.smethod_0(51); index += Class15.smethod_0(31))
      g.method_32(img1, x + index, y, Class15.smethod_0(0));
    int w0 = size % Class15.smethod_0(31);
    if (w0 > Class15.smethod_0(0))
      g.method_24(img1, Class15.smethod_0(0), Class15.smethod_0(0), w0, Class15.smethod_0(40), Class15.smethod_0(0), x + size - Class15.smethod_0(31) - w0, y, Class15.smethod_0(0));
    g.method_32(img0, x, y, Class15.smethod_0(0));
    g.method_32(img2, x + size - Class15.smethod_0(31), y, Class15.smethod_0(0));
  }

  public bool method_4()
  {
    this.isFocus = Class15.smethod_0(0) != 0;
    if ((!GClass62.smethod_22(this.x, this.y, this.w, this.h) ? 1 : 0) == 0)
    {
      if ((!GClass62.bool_14 ? 1 : 0) == 0)
        this.isFocus = Class15.smethod_0(1) != 0;
      if ((!GClass62.bool_16 ? 1 : 0) == 0 && (!GClass62.bool_15 ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_5(int cmx, int cmy)
  {
    this.isFocus = Class15.smethod_0(0) != 0;
    if ((!GClass62.smethod_22(this.x - cmx, this.y - cmy, this.w, this.h) ? 1 : 0) == 0)
    {
      GClass151.smethod_7(Class13.smethod_0(26813) + this.w.ToString());
      if ((!GClass62.bool_14 ? 1 : 0) == 0)
        this.isFocus = Class15.smethod_0(1) != 0;
      if ((!GClass62.bool_16 ? 1 : 0) == 0 && (!GClass62.bool_15 ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }
}
