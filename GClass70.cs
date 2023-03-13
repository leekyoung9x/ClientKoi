// Decompiled with JetBrains decompiler
// Type: GClass70
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass70 : GInterface0
{
  public GClass134 infoWaitToShow = new GClass134();
  public GClass72 info;
  public int p1 = Class15.smethod_0(3);
  public int p2;
  public int p3;
  public int x;
  public int strWidth;
  public int limLeft = Class15.smethod_0(7);
  public int hI = Class15.smethod_0(51);
  public int xChar;
  public int yChar;
  public int sayWidth = Class15.smethod_0(21);
  public int sayRun;
  public string[] says;
  public int cx;
  public int cy;
  public int ch;
  public bool outSide;
  public int f;
  public int tF;
  public GClass66 img;
  public static GClass66 gclass66_0 = GClass62.smethod_40(Class13.smethod_0(157843));
  public int time;
  public int timeW;
  public int type;
  public int X;
  public int Y;
  public int W;
  public int H;

  public void method_0()
  {
    this.says = (string[]) null;
    this.infoWaitToShow.method_9();
  }

  public void method_1(GClass98 g, int x, int y, int dir)
  {
    if (this.infoWaitToShow.method_2() == 0)
      return;
    g.method_1(x, y);
    if (this.says != null && this.says.Length != 0 && this.type != Class15.smethod_0(1))
    {
      if (this.outSide)
      {
        this.cx -= GClass116.int_22;
        this.cy -= GClass116.int_23;
        this.cy += Class15.smethod_0(95);
      }
      int num1 = GClass98.int_8 != Class15.smethod_0(1) ? Class15.smethod_0(31) : Class15.smethod_0(0);
      if (this.info.charInfo == null)
        GClass148.smethod_4(g, this.X, this.Y, this.W, this.H, Class15.smethod_0(142), Class15.smethod_0(0) != 0);
      else
        GClass126.smethod_15(g, this.X - Class15.smethod_0(29), this.Y - num1 / Class15.smethod_0(7), this.W + Class15.smethod_0(9), this.H + (!GClass62.bool_5 ? Class15.smethod_0(49) : Class15.smethod_0(0)) + num1);
      if (this.info.charInfo == null)
        g.method_24(GClass70.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(88), dir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), this.cx - Class15.smethod_0(5) + (dir != Class15.smethod_0(1) ? Class15.smethod_0(51) : Class15.smethod_0(206)), this.cy - this.ch - Class15.smethod_0(51) + this.sayRun + Class15.smethod_0(7), GClass98.int_4 | GClass98.int_0);
      int num2 = -1;
      for (int index1 = Class15.smethod_0(0); index1 < this.says.Length; index1 += Class15.smethod_0(1))
      {
        GClass97 gclass97 = GClass97.gclass97_11;
        string say = this.says[index1];
        Class15.smethod_0(0);
        int num3;
        if (this.says[index1].StartsWith(Class13.smethod_0(121742)))
        {
          string[] strArray = GClass151.smethod_27(this.says[index1], Class13.smethod_0(121742), Class15.smethod_0(0));
          if (strArray.Length == Class15.smethod_0(5))
            say = strArray[Class15.smethod_0(7)];
          if (strArray.Length == Class15.smethod_0(2))
          {
            say = strArray[Class15.smethod_0(5)];
            int.Parse(strArray[Class15.smethod_0(7)]);
          }
          num3 = int.Parse(strArray[Class15.smethod_0(1)]);
          num2 = num3;
        }
        else
          num3 = num2;
        switch (num3)
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
        }
        if (this.info.charInfo == null)
        {
          gclass97.method_6(g, say, this.cx, this.cy - this.ch - Class15.smethod_0(9) + this.sayRun + index1 * Class15.smethod_0(66) - this.says.Length * Class15.smethod_0(66) - Class15.smethod_0(45), Class15.smethod_0(7));
        }
        else
        {
          int x1 = this.X - Class15.smethod_0(29);
          int num4 = this.Y - num1 / Class15.smethod_0(7);
          int w1 = GClass126.int_0 != Class15.smethod_0(1) ? this.W + Class15.smethod_0(46) : this.W + Class15.smethod_0(35);
          int num5 = this.H + (!GClass62.bool_5 ? Class15.smethod_0(49) : Class15.smethod_0(0)) + num1;
          g.method_16(Class15.smethod_0(400));
          g.method_15(x1, num4 + num5, w1, Class15.smethod_0(7));
          int w2 = this.info.timeCount * w1 / this.info.maxTime;
          if (w2 < Class15.smethod_0(0))
            w2 = Class15.smethod_0(0);
          g.method_16(Class15.smethod_0(401));
          g.method_15(x1, num4 + num5, w2, Class15.smethod_0(7));
          if (this.info.timeCount == 0)
            return;
          this.info.charInfo.method_92(g, this.X + Class15.smethod_0(3), this.Y + this.H / Class15.smethod_0(7), Class15.smethod_0(0));
          if (GClass98.int_8 == Class15.smethod_0(1))
            (!this.info.isChatServer ? GClass97.gclass97_41 : GClass97.gclass97_38).method_6(g, this.info.charInfo.cName, this.X + Class15.smethod_0(66), this.Y + Class15.smethod_0(5), Class15.smethod_0(0));
          else
            (!this.info.isChatServer ? GClass97.gclass97_41 : GClass97.gclass97_38).method_6(g, this.info.charInfo.cName, this.X + Class15.smethod_0(66), this.Y - Class15.smethod_0(5), Class15.smethod_0(0));
          if (!GClass62.bool_5)
          {
            if (!GClass184.bool_0)
              GClass97.gclass97_39.method_6(g, Class13.smethod_0(121737), this.X + this.W / Class15.smethod_0(7) + Class15.smethod_0(31), this.Y + this.H, GClass97.int_2);
            else
              GClass97.gclass97_39.method_6(g, Class13.smethod_0(121845), this.X + this.W / Class15.smethod_0(7) + Class15.smethod_0(31), this.Y + this.H, GClass97.int_2);
          }
          if (GClass98.int_8 == Class15.smethod_0(1))
          {
            GClass183.smethod_1(g, say, this.X + Class15.smethod_0(49), this.Y + this.H / Class15.smethod_0(7) + Class15.smethod_0(7), this.W - Class15.smethod_0(10), this.H, GClass97.gclass97_40);
          }
          else
          {
            string[] strArray = GClass97.gclass97_40.method_15(say, Class15.smethod_0(98));
            for (int index2 = Class15.smethod_0(0); index2 < strArray.Length; index2 += Class15.smethod_0(1))
              GClass97.gclass97_40.method_6(g, strArray[index2], this.X + Class15.smethod_0(66), this.Y + Class15.smethod_0(66) + index2 * Class15.smethod_0(66) - Class15.smethod_0(5), Class15.smethod_0(0));
            GClass62.smethod_6(g);
          }
        }
      }
    }
    g.method_1(-x, -y);
  }

  public void method_2()
  {
    if ((this.infoWaitToShow.method_2() == 0 ? 1 : 0) != 0 || (this.info.timeCount == 0 ? 1 : 0) == 0)
      return;
    this.time += Class15.smethod_0(1);
    if (this.time < this.info.speed)
      return;
    this.time = Class15.smethod_0(0);
    this.infoWaitToShow.method_7(Class15.smethod_0(0));
    if ((this.infoWaitToShow.method_2() == 0 ? 1 : 0) != 0)
      return;
    this.info = (GClass72) this.infoWaitToShow.method_11();
    this.method_3();
  }

  public void method_3()
  {
    this.sayWidth = Class15.smethod_0(21);
    if (GClass62.int_10 == Class15.smethod_0(212))
      this.sayWidth = Class15.smethod_0(212);
    int num;
    if ((this.info.charInfo == null ? 1 : 0) == 0)
    {
      string[] strArray = new string[Class15.smethod_0(1)];
      strArray[Class15.smethod_0(0)] = this.info.s;
      this.says = strArray;
      num = GClass98.int_8 != Class15.smethod_0(1) ? GClass97.gclass97_40.method_15(this.info.s, Class15.smethod_0(98)).Length : this.says.Length;
    }
    else
    {
      this.says = GClass97.gclass97_11.method_15(this.info.s, this.sayWidth - Class15.smethod_0(31));
      num = this.says.Length;
    }
    this.sayRun = Class15.smethod_0(38);
    this.X = this.cx - this.sayWidth / Class15.smethod_0(7) - Class15.smethod_0(1);
    this.Y = this.cy - this.ch - Class15.smethod_0(9) + this.sayRun - num * Class15.smethod_0(66) - Class15.smethod_0(9);
    this.W = this.sayWidth + Class15.smethod_0(7) + ((this.info.charInfo == null ? 0 : 1) != 0 ? Class15.smethod_0(6) : Class15.smethod_0(0));
    this.H = (num + Class15.smethod_0(1)) * Class15.smethod_0(66) + Class15.smethod_0(1) + ((this.info.charInfo == null ? 0 : 1) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(0));
  }

  public void method_4(string s, int Type, GClass20 cInfo, bool isChatServer)
  {
    this.type = Type;
    if ((!s.Contains(Class13.smethod_0(157401)) ? 1 : 0) == 0 && ((!cInfo.isPet ? 0 : 1) != 0 || (!cInfo.isMiniPet ? 1 : 0) == 0) && (!GClass14.gclass14_0.method_24() ? 1 : 0) == 0 && (!GClass14.gclass14_0.method_22() ? 0 : 1) == 0)
      GClass14.gclass14_0.method_23(Class15.smethod_0(1) != 0);
    if (GClass62.int_10 == Class15.smethod_0(212))
      this.limLeft = Class15.smethod_0(1);
    if (this.infoWaitToShow.method_2() > Class15.smethod_0(31))
      this.infoWaitToShow.method_7(Class15.smethod_0(0));
    if (this.infoWaitToShow.method_2() > Class15.smethod_0(0))
      s.Equals(((GClass72) this.infoWaitToShow.method_12()).s);
    GClass72 gclass72 = new GClass72(s);
    if ((this.type == 0 ? 0 : 1) == 0)
      gclass72.speed = s.Length;
    if (gclass72.speed < Class15.smethod_0(152))
      gclass72.speed = Class15.smethod_0(152);
    if (this.type == Class15.smethod_0(1))
      gclass72.speed = Class15.smethod_0(261);
    if (this.type == Class15.smethod_0(5))
    {
      gclass72.speed = Class15.smethod_0(137);
      gclass72.last = GClass126.smethod_18();
      gclass72.timeCount = s.Length;
      if (gclass72.timeCount < Class15.smethod_0(9))
        gclass72.timeCount = Class15.smethod_0(9);
      if (gclass72.timeCount > Class15.smethod_0(21))
        gclass72.timeCount = Class15.smethod_0(21);
      gclass72.maxTime = gclass72.timeCount;
    }
    if ((cInfo == null ? 1 : 0) == 0)
    {
      gclass72.charInfo = cInfo;
      gclass72.isChatServer = isChatServer;
      GClass62.gclass141_0.method_13(gclass72);
      if ((!GClass62.bool_5 ? 1 : 0) == 0 && (!GClass62.gclass141_0.isViewChatServer ? 1 : 0) == 0)
        GClass116.gclass73_1.cmdChat = new GClass31(GClass109.string_138, (GInterface0) this, Class15.smethod_0(15), (object) gclass72);
    }
    if ((cInfo == null ? 1 : 0) == 0 && (!GClass62.gclass141_0.isViewChatServer ? 0 : 1) != 0 || (cInfo == null ? 0 : 1) == 0)
      this.infoWaitToShow.method_0((object) gclass72);
    if (this.infoWaitToShow.method_2() == Class15.smethod_0(1))
    {
      this.info = (GClass72) this.infoWaitToShow.method_11();
      this.method_3();
    }
    if ((!GClass62.bool_5 ? 1 : 0) != 0 || (cInfo == null ? 1 : 0) != 0 || (!GClass62.gclass141_0.isViewChatServer ? 1 : 0) != 0 || GClass62.int_10 - Class15.smethod_0(32) <= Class15.smethod_0(402) + this.W)
      return;
    GClass116.gclass73_1.cmdChat.x = GClass62.int_10 - this.W - Class15.smethod_0(32);
    GClass116.gclass73_1.cmdChat.y = Class15.smethod_0(95);
  }

  public void method_5(string s, int speed, GClass97 f)
  {
    if (GClass62.int_10 == Class15.smethod_0(212))
      this.limLeft = Class15.smethod_0(1);
    if (this.infoWaitToShow.method_2() > Class15.smethod_0(31))
      this.infoWaitToShow.method_7(Class15.smethod_0(0));
    this.infoWaitToShow.method_0((object) new GClass72(s, f, speed));
  }

  public bool method_6() => this.p1 == Class15.smethod_0(3) ? this.infoWaitToShow.method_2() == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  public void imethod_0(int idAction, object p)
  {
    if (idAction != Class15.smethod_0(15))
      return;
    GClass23.smethod_0().method_4((GInterface1) GClass116.smethod_6(), GClass109.string_244);
  }

  public void method_7()
  {
  }
}
