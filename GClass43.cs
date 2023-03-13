// Decompiled with JetBrains decompiler
// Type: GClass43
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass43 : GClass42, GInterface0
{
  public int sayWidth = Class15.smethod_0(21);
  public int delay;
  public int sayRun;
  public string[] says;
  public int cx;
  public int cy;
  public int ch;
  public int cmx;
  public int cmy;
  public int lim;
  public GClass21 c;
  private bool bool_0;
  public static long long_0;
  public static long long_1;
  private int int_0;
  private string[] string_0;
  public GClass31 cmdNextLine;
  public GClass31 cmdMsg1;
  public GClass31 cmdMsg2;
  public static GClass43 gclass43_0;
  public static GClass43 gclass43_1;
  public static string string_1;
  public static GClass21 gclass21_0;
  public bool isShopDetail;
  public sbyte starSlot;
  public sbyte maxStarSlot;
  public static GClass154 gclass154_0;
  public static bool bool_1;
  public int mH;
  public static int int_1;
  public int dx;
  public int dy;
  public int second;
  public static int int_2 = Class15.smethod_0(38);
  private int int_3;
  private int int_4;
  private int int_5;
  private GClass66 gclass66_0;
  public int strY;
  private int int_6;
  public bool isClip;
  public static int int_7;
  private int int_8;
  private int int_9;

  public static void smethod_0(string strNext, GClass21 next)
  {
    GClass43.string_1 = strNext;
    GClass43.gclass21_0 = next;
    if ((GClass43.gclass43_0 == null ? 0 : 1) != 0)
      return;
    GClass43.smethod_3(GClass43.string_1, Class15.smethod_0(17), GClass43.gclass21_0);
    GClass43.string_1 = (string) null;
    GClass43.gclass21_0 = (GClass21) null;
  }

  public static void smethod_1(string chat, int howLong, GClass21 c)
  {
    string[] strArray1 = new string[Class15.smethod_0(1)];
    strArray1[Class15.smethod_0(0)] = chat;
    string[] strArray2 = strArray1;
    if (c.charID != Class15.smethod_0(3) && (!GClass116.gclass73_0.isDone ? 1 : 0) == 0)
      GClass116.gclass73_0.isUpdate = Class15.smethod_0(0) != 0;
    GClass20.bool_3 = Class15.smethod_0(1) != 0;
    GClass43.gclass43_1 = GClass43.smethod_5(strArray2[Class15.smethod_0(0)], howLong, c);
    GClass43.gclass43_1.strY = Class15.smethod_0(3);
    GClass43.gclass43_1.cx = GClass62.int_10 / Class15.smethod_0(7) - GClass43.gclass43_1.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
    GClass43.gclass43_1.cy = GClass62.int_11 - Class15.smethod_0(51) - GClass43.gclass43_1.ch;
    GClass43.gclass43_1.int_0 = Class15.smethod_0(0);
    GClass43.gclass43_1.string_0 = strArray2;
    GClass43.gclass154_0 = new GClass154();
    int length = GClass43.gclass43_1.says.Length;
    GClass43.gclass154_0.method_6(length, Class15.smethod_0(66), GClass43.gclass43_1.cx, GClass43.gclass43_1.cy - GClass43.gclass43_1.strY + Class15.smethod_0(66), GClass43.gclass43_1.sayWidth + Class15.smethod_0(7), GClass43.gclass43_1.ch - Class15.smethod_0(46), Class15.smethod_0(1) != 0, Class15.smethod_0(1));
    GClass172.smethod_1().method_42();
  }

  public static void smethod_2(string chat, int howLong, GClass21 c)
  {
  }

  public static void smethod_3(string chat, int howLong, GClass21 c) => GClass116.gclass73_0.method_7(chat, Class15.smethod_0(0));

  public static GClass43 smethod_4(string chat, int howLong, GClass21 c, int idIcon)
  {
    GClass43.int_1 = Class15.smethod_0(31);
    GClass43 o = new GClass43();
    o.sayWidth = GClass62.int_10 - Class15.smethod_0(6) - ((!GClass62.gclass95_0.showMenu ? 0 : 1) != 0 ? GClass62.gclass95_0.menuX : Class15.smethod_0(0));
    if (o.sayWidth > Class15.smethod_0(197))
      o.sayWidth = Class15.smethod_0(197);
    if (chat.Length < Class15.smethod_0(31))
      o.sayWidth = Class15.smethod_0(199);
    if (GClass62.int_10 == Class15.smethod_0(212))
      o.sayWidth = Class15.smethod_0(212);
    o.says = GClass97.gclass97_17.method_15(chat, o.sayWidth - Class15.smethod_0(31));
    o.delay = howLong;
    o.c = c;
    o.int_6 = idIcon;
    GClass20.gclass43_0 = o;
    o.ch = Class15.smethod_0(9) - o.sayRun + o.says.Length * Class15.smethod_0(66) + Class15.smethod_0(31);
    if (o.ch > GClass62.int_11 - Class15.smethod_0(25))
      o.ch = GClass62.int_11 - Class15.smethod_0(25);
    o.mH = Class15.smethod_0(31);
    if ((!GClass62.gclass95_0.showMenu ? 1 : 0) == 0)
      o.mH = Class15.smethod_0(0);
    GClass42.gclass134_1.method_0((object) o);
    GClass43.bool_1 = Class15.smethod_0(0) != 0;
    if ((c == null ? 1 : 0) == 0 && c.charID == Class15.smethod_0(3))
    {
      GClass43.bool_1 = Class15.smethod_0(1) != 0;
      GClass116.gclass73_0.method_7(string.Empty, Class15.smethod_0(1));
    }
    GClass43.long_0 = GClass43.long_1 = GClass126.smethod_18();
    o.ch += Class15.smethod_0(9);
    return o;
  }

  public static GClass43 smethod_5(string chat, int howLong, GClass21 c)
  {
    GClass43.int_1 = Class15.smethod_0(31);
    GClass43 o = new GClass43();
    o.sayWidth = GClass62.int_10 - Class15.smethod_0(6) - ((!GClass62.gclass95_0.showMenu ? 0 : 1) != 0 ? GClass62.gclass95_0.menuX : Class15.smethod_0(0));
    if (o.sayWidth > Class15.smethod_0(197))
      o.sayWidth = Class15.smethod_0(197);
    if (chat.Length < Class15.smethod_0(31))
      o.sayWidth = Class15.smethod_0(199);
    if (GClass62.int_10 == Class15.smethod_0(212))
      o.sayWidth = Class15.smethod_0(212);
    o.says = GClass97.gclass97_17.method_15(chat, o.sayWidth - Class15.smethod_0(31));
    o.delay = howLong;
    o.c = c;
    GClass20.gclass43_0 = o;
    o.ch = Class15.smethod_0(9) - o.sayRun + o.says.Length * Class15.smethod_0(66) + Class15.smethod_0(31);
    if (o.ch > GClass62.int_11 - Class15.smethod_0(25))
      o.ch = GClass62.int_11 - Class15.smethod_0(25);
    o.mH = Class15.smethod_0(31);
    if ((!GClass62.gclass95_0.showMenu ? 1 : 0) == 0)
      o.mH = Class15.smethod_0(0);
    GClass42.gclass134_1.method_0((object) o);
    GClass43.bool_1 = Class15.smethod_0(0) != 0;
    if ((c == null ? 1 : 0) == 0 && c.charID == Class15.smethod_0(3))
    {
      GClass43.bool_1 = Class15.smethod_0(1) != 0;
      GClass116.gclass73_0.method_7(string.Empty, Class15.smethod_0(1));
    }
    GClass43.long_0 = GClass43.long_1 = GClass126.smethod_18();
    return o;
  }

  public override void vmethod_0()
  {
    if ((GClass43.gclass154_0 == null ? 1 : 0) == 0)
    {
      GClass116.gclass73_0.isUpdate = Class15.smethod_0(0) != 0;
      GClass43.gclass154_0.method_5();
    }
    else
      GClass116.gclass73_0.isUpdate = Class15.smethod_0(1) != 0;
    if ((!GClass62.gclass95_0.showMenu ? 1 : 0) == 0)
    {
      this.strY = Class15.smethod_0(0);
      this.cx = GClass62.int_10 / Class15.smethod_0(7) - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
      this.cy = GClass62.gclass95_0.menuY - this.ch;
    }
    else
    {
      this.strY = Class15.smethod_0(0);
      if ((GClass116.smethod_6().right == null ? 0 : 1) == 0 && (GClass116.smethod_6().left == null ? 0 : 1) == 0 && (GClass116.smethod_6().center == null ? 0 : 1) == 0 && (this.cmdNextLine == null ? 0 : 1) == 0 && (this.cmdMsg1 == null ? 1 : 0) != 0)
      {
        this.cx = GClass62.int_10 / Class15.smethod_0(7) - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
        this.cy = GClass62.int_11 - Class15.smethod_0(3) - this.ch;
      }
      else
      {
        this.strY = Class15.smethod_0(3);
        this.cx = GClass62.int_10 / Class15.smethod_0(7) - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
        this.cy = GClass62.int_11 - Class15.smethod_0(51) - this.ch;
      }
    }
    if (this.delay > Class15.smethod_0(0))
      this.delay -= Class15.smethod_0(1);
    if (GClass43.int_1 > Class15.smethod_0(0))
      GClass43.int_1 -= Class15.smethod_0(1);
    if (this.sayRun > Class15.smethod_0(1))
      this.sayRun -= Class15.smethod_0(1);
    if (((this.c == null ? 1 : 0) != 0 || (GClass20.gclass43_0 == null ? 1 : 0) != 0 || GClass20.gclass43_0 == this) && ((this.c == null ? 1 : 0) != 0 || (GClass20.gclass43_0 == null ? 1 : 0) == 0) && (this.delay == 0 ? 0 : 1) != 0)
      return;
    GClass42.gclass134_3.method_8((object) this);
    GClass42.gclass134_1.method_8((object) this);
  }

  public override void vmethod_1(GClass98 g)
  {
    if (GClass116.smethod_6().activeRongThan && GClass116.smethod_6().isUseFreez)
      return;
    GClass62.smethod_6(g);
    int cx = this.cx;
    int cy = this.cy;
    int w = this.sayWidth + Class15.smethod_0(7);
    int ch = this.ch;
    if ((cx <= Class15.smethod_0(0) || cy <= Class15.smethod_0(0)) && !GClass62.gclass141_0.isShow)
      return;
    GClass148.smethod_4(g, cx, cy, w, ch, Class15.smethod_0(142), Class15.smethod_0(0) != 0);
    if (this.c != null)
      GClass169.smethod_6(g, this.c.avatar, this.cx + Class15.smethod_0(49), this.cy, Class15.smethod_0(0), GClass177.int_4);
    if (this.int_6 != 0)
      GClass169.smethod_6(g, this.int_6, this.cx + w / Class15.smethod_0(7), this.cy + this.ch - Class15.smethod_0(9), Class15.smethod_0(0), GClass177.int_6);
    if (GClass43.gclass154_0 != null)
    {
      g.method_5(cx, cy, w, ch - Class15.smethod_0(10));
      g.method_1(Class15.smethod_0(0), -GClass43.gclass154_0.cmy);
    }
    int tx = Class15.smethod_0(0);
    int ty = Class15.smethod_0(0);
    if (this.isClip)
    {
      tx = g.method_3();
      ty = g.method_4();
      g.method_5(cx, cy + Class15.smethod_0(1), w, ch - Class15.smethod_0(186));
      g.method_1(Class15.smethod_0(0), -GClass43.int_7);
    }
    int num1 = -1;
    for (int index = Class15.smethod_0(0); index < this.says.Length; index += Class15.smethod_0(1))
    {
      if (this.says[index].StartsWith(Class13.smethod_0(24773)))
      {
        g.method_16(Class15.smethod_0(0));
        g.method_15(cx + Class15.smethod_0(31), this.cy + this.sayRun + index * Class15.smethod_0(66) + Class15.smethod_0(37), w - Class15.smethod_0(51), Class15.smethod_0(1));
      }
      else
      {
        GClass97 gclass97 = GClass97.gclass97_11;
        int align = Class15.smethod_0(7);
        string say = this.says[index];
        Class15.smethod_0(0);
        int num2;
        if (this.says[index].StartsWith(Class13.smethod_0(25397)))
        {
          string[] strArray = GClass151.smethod_27(this.says[index], Class13.smethod_0(25397), Class15.smethod_0(0));
          if (strArray.Length == Class15.smethod_0(5))
            say = strArray[Class15.smethod_0(7)];
          if (strArray.Length == Class15.smethod_0(2))
          {
            say = strArray[Class15.smethod_0(5)];
            align = int.Parse(strArray[Class15.smethod_0(7)]);
          }
          num2 = int.Parse(strArray[Class15.smethod_0(1)]);
          num1 = num2;
        }
        else
          num2 = num1;
        switch (num2)
        {
          case -1:
            gclass97 = GClass97.gclass97_11;
            break;
          case 0:
            gclass97 = GClass97.gclass97_6;
            break;
          case 1:
            gclass97 = GClass97.gclass97_8;
            break;
          case 2:
            gclass97 = GClass97.gclass97_2;
            break;
          case 3:
            gclass97 = GClass97.gclass97_17;
            break;
          case 4:
            gclass97 = GClass97.gclass97_19;
            break;
          case 5:
            gclass97 = GClass97.gclass97_18;
            break;
          case 7:
            gclass97 = GClass97.gclass97_1;
            break;
          case 8:
            gclass97 = GClass97.gclass97_4;
            break;
        }
        if (this.says[index].StartsWith(Class13.smethod_0(26896)))
        {
          string[] strArray = GClass151.smethod_27(GClass151.smethod_27(this.says[index], Class13.smethod_0(26896), Class15.smethod_0(0))[Class15.smethod_0(1)], Class13.smethod_0(26889), Class15.smethod_0(1));
          if (this.second == 0)
          {
            this.second = int.Parse(strArray[Class15.smethod_0(1)]);
          }
          else
          {
            GClass43.long_0 = GClass126.smethod_18();
            if (GClass43.long_0 - GClass43.long_1 >= (long) Class15.smethod_0(15))
            {
              GClass43.long_1 = GClass43.long_0;
              this.second -= Class15.smethod_0(1);
            }
          }
          string st = this.second.ToString() + Class13.smethod_0(26887) + strArray[Class15.smethod_0(7)];
          gclass97.method_6(g, st, this.cx + this.sayWidth / Class15.smethod_0(7), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY + Class15.smethod_0(66), align);
        }
        else
        {
          if (align == Class15.smethod_0(7))
            gclass97.method_6(g, say, this.cx + this.sayWidth / Class15.smethod_0(7), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY + Class15.smethod_0(66), align);
          if (align == Class15.smethod_0(1))
            gclass97.method_6(g, say, this.cx + this.sayWidth - Class15.smethod_0(3), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY + Class15.smethod_0(66), align);
        }
      }
    }
    if (this.isClip)
    {
      GClass62.smethod_6(g);
      g.method_1(tx, ty);
    }
    for (int index = Class15.smethod_0(0); index < (int) this.maxStarSlot; index += Class15.smethod_0(1))
      g.method_32(index < (int) this.starSlot ? GClass141.gclass66_3 : GClass141.gclass66_4, cx + w / Class15.smethod_0(7) - (int) this.maxStarSlot * Class15.smethod_0(51) / Class15.smethod_0(7) + index * Class15.smethod_0(51) + GClass98.smethod_0(GClass141.gclass66_4), cy + ch - Class15.smethod_0(47), Class15.smethod_0(5));
    this.method_3(g);
  }

  public void method_0(GClass98 g, int cmyText)
  {
    int cx = this.cx;
    int cy = this.cy;
    int sayWidth = this.sayWidth;
    Class15.smethod_0(0);
    Class15.smethod_0(0);
    int tx = g.method_3();
    int ty = g.method_4();
    g.method_1(Class15.smethod_0(0), -cmyText);
    if ((cx <= Class15.smethod_0(0) || cy <= Class15.smethod_0(0)) && (!GClass62.gclass141_0.isShow ? 0 : 1) == 0)
      return;
    int num1 = -1;
    for (int index = Class15.smethod_0(0); index < this.says.Length; index += Class15.smethod_0(1))
    {
      if ((!this.says[index].StartsWith(Class13.smethod_0(27423)) ? 1 : 0) == 0)
      {
        g.method_16(Class15.smethod_0(142));
        g.method_15(cx + Class15.smethod_0(31), this.cy + this.sayRun + index * Class15.smethod_0(66) - Class15.smethod_0(37), sayWidth - Class15.smethod_0(51), Class15.smethod_0(1));
      }
      else
      {
        GClass97 gclass97 = GClass97.gclass97_20;
        int align = Class15.smethod_0(7);
        string say = this.says[index];
        Class15.smethod_0(0);
        int num2;
        if ((!this.says[index].StartsWith(Class13.smethod_0(27417)) ? 1 : 0) == 0)
        {
          string[] strArray = GClass151.smethod_27(this.says[index], Class13.smethod_0(27417), Class15.smethod_0(0));
          if (strArray.Length == Class15.smethod_0(5))
            say = strArray[Class15.smethod_0(7)];
          if (strArray.Length == Class15.smethod_0(2))
          {
            say = strArray[Class15.smethod_0(5)];
            align = int.Parse(strArray[Class15.smethod_0(7)]);
          }
          num2 = int.Parse(strArray[Class15.smethod_0(1)]);
          num1 = num2;
        }
        else
          num2 = num1;
        switch (num2)
        {
          case -1:
            gclass97 = GClass97.gclass97_20;
            break;
          case 0:
            gclass97 = GClass97.gclass97_3;
            break;
          case 1:
            gclass97 = GClass97.gclass97_8;
            break;
          case 2:
            gclass97 = GClass97.gclass97_1;
            break;
        }
        if ((!this.says[index].StartsWith(Class13.smethod_0(28570)) ? 1 : 0) == 0)
        {
          string[] strArray = GClass151.smethod_27(GClass151.smethod_27(this.says[index], Class13.smethod_0(28570), Class15.smethod_0(0))[Class15.smethod_0(1)], Class13.smethod_0(28545), Class15.smethod_0(1));
          if ((this.second == 0 ? 0 : 1) == 0)
          {
            this.second = int.Parse(strArray[Class15.smethod_0(1)]);
          }
          else
          {
            GClass43.long_0 = GClass126.smethod_18();
            if (GClass43.long_0 - GClass43.long_1 >= (long) Class15.smethod_0(15))
            {
              GClass43.long_1 = GClass43.long_0;
              this.second -= Class15.smethod_0(1);
            }
          }
          string st = this.second.ToString() + Class13.smethod_0(21921) + strArray[Class15.smethod_0(7)];
          gclass97.method_6(g, st, this.cx + this.sayWidth / Class15.smethod_0(7), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY, align);
        }
        else
        {
          if (align == Class15.smethod_0(7))
            gclass97.method_6(g, say, this.cx + this.sayWidth / Class15.smethod_0(7), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY, align);
          if (align == Class15.smethod_0(1))
            gclass97.method_6(g, say, this.cx + this.sayWidth - Class15.smethod_0(3), this.cy + this.sayRun + index * Class15.smethod_0(66) - this.strY, align);
        }
      }
    }
    GClass62.smethod_6(g);
    g.method_1(tx, ty);
  }

  private void method_1(int int_10)
  {
    GClass43.int_7 += Class15.smethod_0(66) * int_10;
    if (GClass43.int_7 < Class15.smethod_0(0))
      GClass43.int_7 = Class15.smethod_0(0);
    if (GClass43.int_7 <= this.lim)
      return;
    GClass43.int_7 = this.lim;
  }

  public void method_2()
  {
    if ((!this.isClip ? 1 : 0) == 0)
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
      {
        GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(0) != 0;
        this.method_1(Class15.smethod_0(1));
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
      {
        GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] = Class15.smethod_0(0) != 0;
        this.method_1(-1);
      }
      if ((!GClass62.smethod_22(this.cx, Class15.smethod_0(0), this.sayWidth + Class15.smethod_0(7), this.ch) ? 1 : 0) == 0)
      {
        if ((!GClass62.bool_17 ? 1 : 0) == 0)
        {
          if ((this.int_9 == 0 ? 0 : 1) == 0)
            this.int_9 = GClass62.int_1;
          this.int_8 = this.int_9 - GClass62.int_1;
          if ((this.int_8 == 0 ? 1 : 0) == 0)
          {
            GClass43.int_7 += this.int_8;
            this.int_9 = GClass62.int_1;
          }
          if (GClass43.int_7 < Class15.smethod_0(0))
            GClass43.int_7 = Class15.smethod_0(0);
          if (GClass43.int_7 > this.lim)
            GClass43.int_7 = this.lim;
        }
        else
        {
          this.int_9 = Class15.smethod_0(0);
          this.int_9 = Class15.smethod_0(0);
        }
      }
    }
    if ((GClass43.gclass154_0 == null ? 1 : 0) == 0)
    {
      if ((!GClass62.bool_5 ? 1 : 0) == 0)
        GClass43.gclass154_0.method_1();
      if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
      {
        GClass43.gclass154_0.cmtoY -= Class15.smethod_0(66);
        if (GClass43.gclass154_0.cmtoY < Class15.smethod_0(0))
          GClass43.gclass154_0.cmtoY = Class15.smethod_0(0);
      }
      if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
      {
        GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] = Class15.smethod_0(0) != 0;
        GClass43.gclass154_0.cmtoY += Class15.smethod_0(66);
        if (GClass43.gclass154_0.cmtoY > GClass43.gclass154_0.cmyLim)
          GClass43.gclass154_0.cmtoY = GClass43.gclass154_0.cmyLim;
      }
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(GClass62.gclass113_0.center) ? 1 : 0) == 0)
    {
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
      GClass113.int_4 = -1;
      if ((this.cmdNextLine == null ? 1 : 0) == 0)
        this.cmdNextLine.method_1();
      else if ((this.cmdMsg1 == null ? 1 : 0) == 0)
        this.cmdMsg1.method_1();
      else if ((this.cmdMsg2 == null ? 1 : 0) == 0)
        this.cmdMsg2.method_1();
    }
    if ((GClass43.gclass154_0 == null ? 1 : 0) == 0 && (!GClass43.gclass154_0.pointerIsDowning ? 0 : 1) != 0)
      return;
    if ((this.cmdMsg1 == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.cmdMsg1) ? 1 : 0) == 0))
    {
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(0) != 0;
      GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] = Class15.smethod_0(0) != 0;
      GClass62.bool_15 = Class15.smethod_0(0) != 0;
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      this.cmdMsg1.method_1();
      GClass113.int_4 = -1;
    }
    if ((this.cmdMsg2 == null ? 1 : 0) != 0 || (!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) == 0 && (!GClass113.smethod_1(this.cmdMsg2) ? 1 : 0) != 0)
      return;
    GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(0) != 0;
    GClass62.bool_15 = Class15.smethod_0(0) != 0;
    GClass62.bool_16 = Class15.smethod_0(0) != 0;
    this.cmdMsg2.method_1();
    GClass113.int_4 = -1;
  }

  public void method_3(GClass98 g)
  {
    g.method_1(-g.method_3(), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    GClass62.gclass140_0.method_8(g);
    if ((this.cmdNextLine == null ? 1 : 0) == 0)
      GClass62.gclass140_0.method_7(g, (GClass31) null, this.cmdNextLine, (GClass31) null);
    if ((this.cmdMsg1 == null ? 1 : 0) != 0)
      return;
    GClass62.gclass140_0.method_7(g, this.cmdMsg1, (GClass31) null, this.cmdMsg2);
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(15))
    {
      try
      {
        GClass63.gclass63_0.method_3((string) p);
      }
      catch (Exception ex)
      {
      }
      if ((!Main.bool_3 ? 0 : 1) == 0)
        GClass63.gclass63_0.method_2();
      else
        idAction = Class15.smethod_0(94);
      GClass62.smethod_27();
    }
    if (idAction == Class15.smethod_0(94))
    {
      GClass43.gclass154_0 = (GClass154) null;
      GClass20.gclass43_0 = (GClass43) null;
      GClass43.gclass43_1 = (GClass43) null;
      GClass116.gclass73_0.isUpdate = Class15.smethod_0(1) != 0;
      GClass20.bool_3 = Class15.smethod_0(0) != 0;
      if ((!GClass43.bool_1 ? 1 : 0) == 0)
      {
        GClass116.gclass73_0.info.time = Class15.smethod_0(0);
        GClass116.gclass73_0.info.info.speed = Class15.smethod_0(31);
      }
    }
    if (idAction != Class15.smethod_0(260) || GClass43.int_1 > Class15.smethod_0(0))
      return;
    int index1 = GClass43.gclass43_0.int_0 + Class15.smethod_0(1);
    if (index1 >= GClass43.gclass43_0.string_0.Length)
    {
      GClass20.gclass43_0 = (GClass43) null;
      GClass43.gclass43_0 = (GClass43) null;
      GClass116.gclass73_0.isUpdate = Class15.smethod_0(1) != 0;
      GClass20.bool_3 = Class15.smethod_0(0) != 0;
      if ((GClass43.string_1 == null ? 1 : 0) == 0)
      {
        Class15.smethod_0(0);
        GClass43.smethod_3(GClass43.string_1, Class15.smethod_0(17), GClass43.gclass21_0);
        GClass43.string_1 = (string) null;
        GClass43.gclass21_0 = (GClass21) null;
      }
      else
      {
        if ((!GClass43.bool_1 ? 0 : 1) == 0)
          return;
        GClass116.gclass73_0.info.time = Class15.smethod_0(0);
        for (int index2 = Class15.smethod_0(0); index2 < GClass116.gclass73_0.info.infoWaitToShow.method_2(); index2 += Class15.smethod_0(1))
        {
          if (((GClass72) GClass116.gclass73_0.info.infoWaitToShow.method_3(index2)).speed == Class15.smethod_0(261))
            ((GClass72) GClass116.gclass73_0.info.infoWaitToShow.method_3(index2)).speed = Class15.smethod_0(31);
        }
      }
    }
    else
    {
      GClass43 gclass43 = GClass43.smethod_5(GClass43.gclass43_0.string_0[index1], GClass43.gclass43_0.delay, GClass43.gclass43_0.c);
      gclass43.int_0 = index1;
      gclass43.string_0 = GClass43.gclass43_0.string_0;
      gclass43.cmdNextLine = GClass43.gclass43_0.cmdNextLine;
      GClass43.gclass43_0 = gclass43;
    }
  }
}
