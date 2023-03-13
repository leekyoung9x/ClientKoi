// Decompiled with JetBrains decompiler
// Type: GClass22
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass22 : GClass21, GInterface0
{
  public static GClass66 gclass66_13;
  public static GClass66 gclass66_14 = GClass62.smethod_40(Class13.smethod_0(159062));
  public int id;
  public int level;
  public int x;
  public int y;
  public int currPeas;
  public int remainPeas;
  public int maxPeas;
  public new string strInfo;
  public string name;
  public int timeToRecieve;
  public bool isUpdate;
  public int[] peaPostionX;
  public int[] peaPostionY;
  private int int_32;
  public GClass148 p;
  public bool isUpdateTree;
  public static bool bool_21 = Class15.smethod_0(1) != 0;
  public bool isPeasEffect;
  public new int seconds;
  public new long last;
  public new long cur;
  private int int_33;
  private bool bool_22;
  private int int_34;

  public GClass22(int npcId, int status, int cx, int cy, int templateId, int iconId)
    : base(npcId, status, cx, cy, templateId, iconId)
  {
    this.p = new GClass148(string.Empty, Class15.smethod_0(0), Class15.smethod_0(0));
    this.p.command = new GClass31((string) null, (GInterface0) this, Class15.smethod_0(1), (object) null);
    GClass148.smethod_2(this.p);
  }

  public override void vmethod_1(GClass98 g)
  {
    if ((this.id == 0 ? 0 : 1) == 0)
      return;
    GClass169.smethod_6(g, this.id, this.cx, this.cy, Class15.smethod_0(0), GClass177.int_3);
    if ((GClass20.smethod_1().npcFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().npcFocus.Equals((object) this) ? 1 : 0) == 0)
    {
      g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.cx, this.cy - GClass169.int_0[this.id][Class15.smethod_0(2)] - Class15.smethod_0(1), GClass98.int_5 | GClass98.int_0);
      if ((this.name == null ? 1 : 0) == 0)
        GClass97.gclass97_3.method_10(g, this.name, this.cx, this.cy - GClass169.int_0[this.id][Class15.smethod_0(2)] - Class15.smethod_0(51), GClass97.int_2, GClass97.gclass97_16);
    }
    else if ((this.name == null ? 1 : 0) == 0)
      GClass97.gclass97_3.method_10(g, this.name, this.cx, this.cy - GClass169.int_0[this.id][Class15.smethod_0(2)] - Class15.smethod_0(186), GClass97.int_2, GClass97.gclass97_16);
    try
    {
      for (int index = Class15.smethod_0(0); index < this.currPeas; index += Class15.smethod_0(1))
        g.method_32(GClass22.gclass66_14, this.cx + this.peaPostionX[index] - GClass169.int_0[this.id][Class15.smethod_0(5)] / Class15.smethod_0(7), this.cy + this.peaPostionY[index] - GClass169.int_0[this.id][Class15.smethod_0(2)], Class15.smethod_0(0));
    }
    catch (Exception ex)
    {
    }
    if (this.indexEffTask < Class15.smethod_0(0) || (this.effTask == null ? 1 : 0) != 0 || (this.cTypePk == (sbyte) 0 ? 1 : 0) == 0)
      return;
    GClass169.smethod_6(g, this.effTask.arrEfInfo[this.indexEffTask].idImg, this.cx + this.effTask.arrEfInfo[this.indexEffTask].dx + GClass169.int_0[this.id][Class15.smethod_0(5)] / Class15.smethod_0(7) + Class15.smethod_0(3), this.cy - Class15.smethod_0(9) + this.effTask.arrEfInfo[this.indexEffTask].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
    if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) != 0)
      return;
    this.indexEffTask += Class15.smethod_0(1);
    if (this.indexEffTask < this.effTask.arrEfInfo.Length)
      return;
    this.indexEffTask = Class15.smethod_0(0);
  }

  public override void vmethod_0()
  {
    this.p.isPaint = GClass22.bool_21;
    this.cur = GClass126.smethod_18();
    if (this.cur - this.last >= (long) Class15.smethod_0(15))
    {
      this.seconds -= Class15.smethod_0(1);
      this.last = this.cur;
      if (this.seconds < Class15.smethod_0(0))
        this.seconds = Class15.smethod_0(0);
    }
    if ((!this.isUpdate ? 0 : 1) == 0)
    {
      if (this.currPeas < this.maxPeas && (this.seconds == 0 ? 0 : 1) == 0)
        this.bool_22 = Class15.smethod_0(1) != 0;
    }
    else if ((this.seconds == 0 ? 0 : 1) == 0)
    {
      this.isUpdate = Class15.smethod_0(0) != 0;
      this.bool_22 = Class15.smethod_0(1) != 0;
    }
    if ((!this.bool_22 ? 1 : 0) == 0)
    {
      this.int_34 += Class15.smethod_0(1);
      if (this.int_34 == Class15.smethod_0(51))
      {
        this.int_34 = Class15.smethod_0(0);
        this.bool_22 = Class15.smethod_0(0) != 0;
        GClass156.smethod_0().method_123((sbyte) Class15.smethod_0(7));
      }
    }
    this.int_32 = (this.peaPostionX == null ? 0 : 1) != 0 ? this.peaPostionX.Length * this.currPeas / this.maxPeas : Class15.smethod_0(0);
    if ((!this.isUpdateTree ? 1 : 0) == 0)
    {
      this.isUpdateTree = Class15.smethod_0(0) != 0;
      if (this.seconds >= Class15.smethod_0(0) && this.currPeas < this.maxPeas || this.seconds >= Class15.smethod_0(0) && (!this.isUpdate ? 0 : 1) != 0 || (!this.isPeasEffect ? 1 : 0) == 0)
      {
        GClass148 p = this.p;
        string[] info = new string[Class15.smethod_0(7)];
        info[Class15.smethod_0(0)] = (!this.isUpdate ? 0 : 1) != 0 ? GClass109.string_225 : this.currPeas.ToString() + Class13.smethod_0(158581) + this.maxPeas.ToString();
        info[Class15.smethod_0(1)] = GClass138.smethod_8(this.seconds);
        int cx = this.cx;
        int y = this.cy - Class15.smethod_0(51) - GClass169.int_0[this.id][Class15.smethod_0(2)];
        p.method_0(info, cx, y);
      }
      else if (this.currPeas == this.maxPeas && (!this.isUpdate ? 0 : 1) == 0)
      {
        GClass148 p = this.p;
        string[] info = new string[Class15.smethod_0(7)];
        info[Class15.smethod_0(0)] = GClass109.string_237;
        info[Class15.smethod_0(1)] = this.currPeas.ToString() + Class13.smethod_0(158581) + this.maxPeas.ToString();
        int cx = this.cx;
        int y = this.cy - Class15.smethod_0(51) - GClass169.int_0[this.id][Class15.smethod_0(2)];
        p.method_0(info, cx, y);
      }
    }
    if (this.seconds >= Class15.smethod_0(0) && this.currPeas < this.maxPeas || this.seconds >= Class15.smethod_0(0) && (!this.isUpdate ? 1 : 0) == 0)
      this.p.says[this.p.says.Length - Class15.smethod_0(1)] = GClass138.smethod_8(this.seconds);
    if ((!this.isPeasEffect ? 1 : 0) == 0)
    {
      this.p.isPaint = Class15.smethod_0(0) != 0;
      GClass47.smethod_0(Class15.smethod_0(419), this.cx + this.peaPostionX[this.currPeas - Class15.smethod_0(1)] - GClass169.int_0[this.id][Class15.smethod_0(5)] / Class15.smethod_0(7), this.cy + this.peaPostionY[this.currPeas - Class15.smethod_0(1)] - GClass169.int_0[this.id][Class15.smethod_0(2)], Class15.smethod_0(1));
      this.currPeas -= Class15.smethod_0(1);
      if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
        GClass172.smethod_1().method_3();
      if (this.currPeas == this.remainPeas)
      {
        this.p.isPaint = Class15.smethod_0(1) != 0;
        this.isUpdateTree = Class15.smethod_0(1) != 0;
        this.isPeasEffect = Class15.smethod_0(0) != 0;
      }
    }
    base.vmethod_0();
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction != Class15.smethod_0(1))
      return;
    GClass156.smethod_0().method_42((sbyte) Class15.smethod_0(1));
  }
}
