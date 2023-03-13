// Decompiled with JetBrains decompiler
// Type: GClass73
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass73
{
  public static GClass73 gclass73_0;
  public int[][] charId = new int[Class15.smethod_0(5)][];
  public GClass70 info = new GClass70();
  public int dir;
  public int f;
  public int tF;
  public int cmtoY;
  public int cmy;
  public int cmdy;
  public int cmvy;
  public int cmyLim;
  public int cmtoX;
  public int cmx;
  public int cmdx;
  public int cmvx;
  public int cmxLim;
  public bool isDone;
  public bool isUpdate = Class15.smethod_0(1) != 0;
  public int timeDelay;
  public int playerID;
  public int timeCount;
  public GClass31 cmdChat;
  public bool isShow;

  public GClass73()
  {
    for (int index = Class15.smethod_0(0); index < this.charId.Length; index += Class15.smethod_0(1))
      this.charId[index] = new int[Class15.smethod_0(5)];
  }

  public static GClass73 smethod_0()
  {
    if ((GClass73.gclass73_0 == null ? 0 : 1) == 0)
      GClass73.gclass73_0 = new GClass73();
    return GClass73.gclass73_0;
  }

  public void method_0()
  {
    for (int index = Class15.smethod_0(0); index < this.charId.Length; index += Class15.smethod_0(1))
      this.charId[index] = new int[Class15.smethod_0(5)];
  }

  public void method_1(GClass98 g)
  {
    if ((!this.Equals((object) GClass116.gclass73_1) ? 1 : 0) == 0 && (!GClass116.smethod_6().method_94() ? 0 : 1) != 0 || (!this.Equals((object) GClass116.gclass73_1) ? 1 : 0) == 0 && (GClass116.smethod_6().popUpYesNo == null ? 0 : 1) != 0 || (!GClass116.bool_58 ? 1 : 0) != 0 || GClass62.gclass113_0 != GClass116.smethod_6() && GClass62.gclass113_0 != GClass114.smethod_2() || (GClass43.gclass43_1 == null ? 0 : 1) != 0 || (!this.isUpdate ? 1 : 0) != 0 || (!GClass20.bool_2 ? 0 : 1) != 0 || (!GClass62.gclass141_0.isShow ? 1 : 0) == 0 && (!this.Equals((object) GClass116.gclass73_1) ? 1 : 0) == 0)
      return;
    g.method_1(-g.method_3(), -g.method_4());
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    if ((this.info == null ? 1 : 0) == 0)
    {
      this.info.method_1(g, this.cmx, this.cmy, this.dir);
      if ((this.info.info == null ? 1 : 0) != 0 || (this.info.info.charInfo == null ? 1 : 0) != 0 || (this.cmdChat == null ? 0 : 1) != 0)
        ;
      if ((this.info.info == null ? 1 : 0) != 0 || (this.info.info.charInfo == null ? 1 : 0) != 0)
        ;
    }
    if ((this.info.info == null ? 1 : 0) == 0 && (this.info.info.charInfo == null ? 0 : 1) == 0 && (this.charId == null ? 1 : 0) == 0)
      GClass169.smethod_6(g, this.charId[GClass20.smethod_1().cgender][this.f], this.cmx, this.cmy + Class15.smethod_0(5) + (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0)), this.dir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass177.int_6);
    g.method_1(-g.method_3(), -g.method_4());
  }

  public void method_2() => this.info.method_0();

  public void method_3()
  {
    if (this.cmy != this.cmtoY)
    {
      this.cmvy = this.cmtoY - this.cmy << Class15.smethod_0(7);
      this.cmdy += this.cmvy;
      this.cmy += this.cmdy >> Class15.smethod_0(2);
      this.cmdy &= Class15.smethod_0(9);
    }
    if (this.cmx != this.cmtoX)
    {
      this.cmvx = this.cmtoX - this.cmx << Class15.smethod_0(7);
      this.cmdx += this.cmvx;
      this.cmx += this.cmdx >> Class15.smethod_0(2);
      this.cmdx &= Class15.smethod_0(9);
    }
    this.tF += Class15.smethod_0(1);
    if (this.tF != Class15.smethod_0(3))
      return;
    this.tF = Class15.smethod_0(0);
    if ((this.f == 0 ? 0 : 1) == 0)
      this.f = Class15.smethod_0(1);
    else
      this.f = Class15.smethod_0(0);
  }

  public void method_4(int t) => this.timeDelay = t;

  public void method_5()
  {
    if (this.info != null && this.info.infoWaitToShow != null && this.info.infoWaitToShow.method_2() == 0 && this.cmy != Class15.smethod_0(268))
    {
      this.info.timeW -= Class15.smethod_0(1);
      if (this.info.timeW <= Class15.smethod_0(0))
      {
        this.cmy = Class15.smethod_0(268);
        this.info.time = Class15.smethod_0(0);
        this.info.infoWaitToShow.method_9();
        this.info.says = (string[]) null;
        this.info.timeW = Class15.smethod_0(90);
      }
    }
    if (this.Equals((object) GClass116.gclass73_1) && GClass116.smethod_6().popUpYesNo != null || !this.isUpdate)
      return;
    this.method_3();
    if (this.info == null || this.info != null && this.info.info == null)
      return;
    if (!this.isDone)
    {
      if (this.timeDelay > Class15.smethod_0(0))
      {
        this.timeDelay -= Class15.smethod_0(1);
        if (this.timeDelay == 0)
        {
          GClass62.gclass141_0.method_25();
          GClass62.gclass141_0.method_44();
        }
      }
      if (GClass62.int_8 % Class15.smethod_0(5) == 0)
      {
        if (GClass20.smethod_1().cdir == Class15.smethod_0(1))
          this.cmtoX = GClass20.smethod_1().cx - Class15.smethod_0(51) - GClass116.int_22;
        if (GClass20.smethod_1().cdir == -1)
          this.cmtoX = GClass20.smethod_1().cx + Class15.smethod_0(51) - GClass116.int_22;
        if (this.cmtoX <= Class15.smethod_0(40))
          this.cmtoX += this.info.sayWidth / Class15.smethod_0(7);
        if (this.cmtoX >= GClass62.int_10 - Class15.smethod_0(40))
          this.cmtoX -= this.info.sayWidth / Class15.smethod_0(7);
        this.cmtoY = GClass20.smethod_1().cy - Class15.smethod_0(54) - GClass116.int_23;
        if (this.info.says != null && this.cmtoY < (this.info.says.Length + Class15.smethod_0(1)) * Class15.smethod_0(66) + Class15.smethod_0(31))
          this.cmtoY = (this.info.says.Length + Class15.smethod_0(1)) * Class15.smethod_0(66) + Class15.smethod_0(31);
        if (this.info.info.charInfo != null)
        {
          if (GClass62.int_10 - Class15.smethod_0(32) > Class15.smethod_0(402) + this.info.W)
          {
            this.cmtoX = GClass62.int_10 - Class15.smethod_0(4) - this.info.W / Class15.smethod_0(7);
            this.cmtoY = this.info.H + Class15.smethod_0(31);
          }
          else
          {
            this.cmtoX = GClass62.int_10 - Class15.smethod_0(51) - this.info.W / Class15.smethod_0(7);
            this.cmtoY = Class15.smethod_0(70) + this.info.H;
            if (GClass62.int_10 > GClass62.int_11 || GClass62.int_10 < Class15.smethod_0(99))
            {
              this.cmtoX = GClass62.int_10 - Class15.smethod_0(51) - this.info.W / Class15.smethod_0(7);
              this.cmtoY = this.info.H + Class15.smethod_0(31);
            }
          }
        }
      }
      this.dir = this.cmx <= GClass20.smethod_1().cx - GClass116.int_22 ? Class15.smethod_0(1) : -1;
    }
    if (this.info.info == null)
      return;
    if (this.info.infoWaitToShow.method_2() > Class15.smethod_0(1))
    {
      if (this.info.info.timeCount == 0)
      {
        this.info.time += Class15.smethod_0(1);
        if (this.info.time < this.info.info.speed)
          return;
        this.info.time = Class15.smethod_0(0);
        this.info.infoWaitToShow.method_7(Class15.smethod_0(0));
        this.info.info = (GClass72) this.info.infoWaitToShow.method_11();
        this.info.method_3();
      }
      else
      {
        this.info.info.curr = GClass126.smethod_18();
        if (this.info.info.curr - this.info.info.last >= (long) Class15.smethod_0(21))
        {
          this.info.info.last = GClass126.smethod_18();
          this.info.info.timeCount -= Class15.smethod_0(1);
        }
        if (this.info.info.timeCount != 0)
          return;
        this.info.infoWaitToShow.method_7(Class15.smethod_0(0));
        if (this.info.infoWaitToShow.method_2() == 0)
          return;
        this.info.info = (GClass72) this.info.infoWaitToShow.method_11();
        this.info.method_3();
      }
    }
    else
    {
      if (this.info.infoWaitToShow.method_2() != Class15.smethod_0(1))
        return;
      if (this.info.info.timeCount == 0)
      {
        this.info.time += Class15.smethod_0(1);
        if (this.info.time >= this.info.info.speed)
          this.isDone = Class15.smethod_0(1) != 0;
        if (this.info.time == this.info.info.speed)
        {
          this.cmtoY = Class15.smethod_0(268);
          this.cmtoX = GClass20.smethod_1().cx - GClass116.int_22 + (GClass20.smethod_1().cdir != Class15.smethod_0(1) ? Class15.smethod_0(51) : Class15.smethod_0(188));
        }
        if (this.info.time < this.info.info.speed + Class15.smethod_0(51))
          return;
        this.info.time = Class15.smethod_0(0);
        this.info.infoWaitToShow.method_9();
        this.info.says = (string[]) null;
        this.info.timeW = Class15.smethod_0(90);
      }
      else
      {
        this.info.info.curr = GClass126.smethod_18();
        if (this.info.info.curr - this.info.info.last >= (long) Class15.smethod_0(21))
        {
          this.info.info.last = GClass126.smethod_18();
          this.info.info.timeCount -= Class15.smethod_0(1);
        }
        if (this.info.info.timeCount != 0)
          return;
        this.isDone = Class15.smethod_0(1) != 0;
        this.cmtoY = Class15.smethod_0(268);
        this.cmtoX = GClass20.smethod_1().cx - GClass116.int_22 + (GClass20.smethod_1().cdir != Class15.smethod_0(1) ? Class15.smethod_0(51) : Class15.smethod_0(188));
        this.info.time = Class15.smethod_0(0);
        this.info.infoWaitToShow.method_9();
        this.info.says = (string[]) null;
        this.cmdChat = (GClass31) null;
      }
    }
  }

  public void method_6(string s, GClass20 c, bool isChatServer)
  {
    this.playerID = c.charID;
    this.info.method_4(s, Class15.smethod_0(5), c, isChatServer);
    this.isDone = Class15.smethod_0(0) != 0;
  }

  public void method_7(string s, int Type)
  {
    s = GClass151.smethod_14(s);
    if (this.info.infoWaitToShow.method_2() > Class15.smethod_0(0) && (!s.Equals(((GClass72) this.info.infoWaitToShow.method_12()).s) ? 1 : 0) == 0)
      return;
    if (this.info.infoWaitToShow.method_2() > Class15.smethod_0(31))
    {
      for (int index = Class15.smethod_0(0); index < Class15.smethod_0(3); index += Class15.smethod_0(1))
        this.info.infoWaitToShow.method_7(Class15.smethod_0(0));
    }
    GClass20 cInfo = (GClass20) null;
    this.info.method_4(s, Type, cInfo, Class15.smethod_0(0) != 0);
    if (this.info.infoWaitToShow.method_2() == Class15.smethod_0(1))
    {
      this.cmy = Class15.smethod_0(0);
      this.cmx = GClass20.smethod_1().cx - GClass116.int_22 + (GClass20.smethod_1().cdir != Class15.smethod_0(1) ? Class15.smethod_0(51) : Class15.smethod_0(188));
    }
    this.isDone = Class15.smethod_0(0) != 0;
  }
}
