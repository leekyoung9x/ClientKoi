// Decompiled with JetBrains decompiler
// Type: GClass21
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass21 : GClass20
{
  public const sbyte sbyte_22 = 0;
  public const sbyte sbyte_23 = 1;
  public const sbyte sbyte_24 = 2;
  public const sbyte sbyte_25 = 3;
  public const sbyte sbyte_26 = 4;
  public const sbyte sbyte_27 = 5;
  public const sbyte sbyte_28 = 6;
  public GClass139 template;
  public int npcId;
  public bool isFocus = Class15.smethod_0(1) != 0;
  public static GClass139[] gclass139_0;
  public int sys;
  public bool isHide;
  private int int_26;
  private int int_27;
  public static bool bool_20;
  public static int int_28;
  private static int[] int_29;
  private static int[] int_30;
  public static int int_31;
  public int[] duahau;
  public new int seconds;
  public new long last;
  public new long cur;
  public int idItem;

  public GClass21(int npcId, int status, int cx, int cy, int templateId, int avatar)
  {
    this.isShadown = Class15.smethod_0(1) != 0;
    this.npcId = npcId;
    this.avatar = avatar;
    this.cx = cx;
    this.cy = cy;
    this.xSd = cx;
    this.ySd = cy;
    this.statusMe = status;
    if (npcId != -1)
      this.template = GClass21.gclass139_0[templateId];
    if (templateId == Class15.smethod_0(29) || templateId == Class15.smethod_0(108))
      this.ch = Class15.smethod_0(70);
    if (templateId == Class15.smethod_0(190))
    {
      this.isShadown = Class15.smethod_0(0) != 0;
      this.int_26 = status;
    }
    if ((this.template == null ? 1 : 0) != 0)
      return;
    if ((this.template.name == null ? 0 : 1) == 0)
      this.template.name = string.Empty;
    this.template.name = GClass151.smethod_14(this.template.name);
  }

  public void method_156(sbyte s, int sc)
  {
    this.int_26 = (int) s;
    this.last = this.cur = GClass126.smethod_18();
    this.seconds = sc;
  }

  public static void smethod_10()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
    {
      GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
      gclass21.effTask = (GClass49) null;
      gclass21.indexEffTask = -1;
    }
  }

  public override void vmethod_0()
  {
    if (this.template.npcTemplateId == Class15.smethod_0(190))
    {
      this.cur = GClass126.smethod_18();
      if (this.cur - this.last >= (long) Class15.smethod_0(15))
      {
        this.seconds -= Class15.smethod_0(1);
        this.last = this.cur;
        if (this.seconds < Class15.smethod_0(0))
          this.seconds = Class15.smethod_0(0);
      }
    }
    if ((!this.isShadown ? 1 : 0) == 0)
      this.method_88();
    if ((this.effTask == null ? 0 : 1) == 0)
    {
      byte[] byte_0 = new byte[Class15.smethod_0(152)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.LiyfqOobaJmE));
      sbyte[] numArray = (sbyte[]) Class15.smethod_4(byte_0);
      if (GClass20.smethod_1().ctaskId >= Class15.smethod_0(45) && GClass20.smethod_1().ctaskId <= Class15.smethod_0(31) && GClass20.smethod_1().nClass.classId > Class15.smethod_0(0) && (int) numArray[GClass20.smethod_1().nClass.classId] == this.template.npcTemplateId)
      {
        if ((GClass20.smethod_1().taskMaint == null ? 0 : 1) == 0)
        {
          this.effTask = GClass116.gclass49_0[Class15.smethod_0(210)];
          this.indexEffTask = Class15.smethod_0(0);
        }
        else if ((GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && GClass20.smethod_1().taskMaint.index + Class15.smethod_0(1) == GClass20.smethod_1().taskMaint.subNames.Length)
        {
          this.effTask = GClass116.gclass49_0[Class15.smethod_0(106)];
          this.indexEffTask = Class15.smethod_0(0);
        }
      }
      else
      {
        sbyte num = GClass116.smethod_26();
        if ((GClass20.smethod_1().taskMaint == null ? 0 : 1) == 0 && (int) num == this.template.npcTemplateId)
          this.indexEffTask = Class15.smethod_0(0);
        else if ((GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && (int) num == this.template.npcTemplateId)
        {
          if (GClass20.smethod_1().taskMaint.index + Class15.smethod_0(1) == GClass20.smethod_1().taskMaint.subNames.Length)
            this.effTask = GClass116.gclass49_0[Class15.smethod_0(419)];
          else
            this.effTask = GClass116.gclass49_0[Class15.smethod_0(419)];
          this.indexEffTask = Class15.smethod_0(0);
        }
      }
    }
    base.vmethod_0();
    if (GClass185.int_37 != Class15.smethod_0(190))
      return;
    if (this.cx > GClass20.smethod_1().cx)
      this.cdir = -1;
    else
      this.cdir = Class15.smethod_0(1);
    if ((this.template.npcTemplateId % Class15.smethod_0(7) == 0 ? 0 : 1) != 0)
      return;
    if (this.cf == Class15.smethod_0(1))
      this.cf = Class15.smethod_0(0);
    else
      this.cf = Class15.smethod_0(1);
  }

  public void method_157(GClass98 g, int xStart, int yStart)
  {
    GClass142 gclass142 = GClass116.gclass142_0[this.template.headId];
    if (this.cdir == Class15.smethod_0(1))
      GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, GClass62.int_10 - Class15.smethod_0(8) - g.method_3(), Class15.smethod_0(7) - g.method_4(), Class15.smethod_0(0), Class15.smethod_0(0));
    else
      GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, GClass62.int_10 - Class15.smethod_0(8) - g.method_3(), Class15.smethod_0(7) - g.method_4(), Class15.smethod_0(7), Class15.smethod_0(40));
  }

  public override void vmethod_1(GClass98 g)
  {
    if (GClass20.bool_4 || this.isHide || !this.method_74() || this.statusMe == Class15.smethod_0(9))
      return;
    if (this.cTypePk != (sbyte) 0)
    {
      base.vmethod_1(g);
    }
    else
    {
      if (this.template == null)
        return;
      if (this.template.npcTemplateId != Class15.smethod_0(2) && this.template.npcTemplateId != Class15.smethod_0(190) && this.template.npcTemplateId != Class15.smethod_0(32))
        g.method_32(GClass185.gclass66_10, this.cx, this.cy, Class15.smethod_0(5));
      if (this.template.npcTemplateId == Class15.smethod_0(5))
      {
        GClass169.smethod_6(g, Class15.smethod_0(461), this.cx, this.cy, Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
        if (GClass20.smethod_1().npcFocus != null && GClass20.smethod_1().npcFocus.Equals((object) this) && GClass43.gclass43_0 == null)
          g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.cx, this.cy - this.ch + Class15.smethod_0(2), GClass98.int_5 | GClass98.int_0);
        this.int_27 = Class15.smethod_0(4);
      }
      else if (this.template.npcTemplateId != Class15.smethod_0(2))
      {
        if (this.template.npcTemplateId != Class15.smethod_0(32) && this.template.npcTemplateId != Class15.smethod_0(190))
        {
          if (this.template.npcTemplateId == Class15.smethod_0(37))
          {
            GClass169.smethod_6(g, Class15.smethod_0(463), this.cx, this.cy + Class15.smethod_0(3), Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
            if (GClass20.smethod_1().npcFocus != null && GClass20.smethod_1().npcFocus.Equals((object) this) && GClass43.gclass43_0 == null)
              g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.cx, this.cy - this.ch - Class15.smethod_0(45), GClass98.int_5 | GClass98.int_0);
            GClass97.gclass97_3.method_6(g, GClass185.int_39.ToString() + string.Empty, this.cx, this.cy - this.ch + Class15.smethod_0(65) - GClass97.gclass97_11.method_20(), GClass97.int_2);
          }
          else
          {
            int headId = this.template.headId;
            int legId = this.template.legId;
            int bodyId = this.template.bodyId;
            GClass142 gclass142_1 = GClass116.gclass142_0[headId];
            GClass142 gclass142_2 = GClass116.gclass142_0[legId];
            GClass142 gclass142_3 = GClass116.gclass142_0[bodyId];
            if (this.cdir == Class15.smethod_0(1))
            {
              GClass169.smethod_6(g, (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, this.cx + GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
              GClass169.smethod_6(g, (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, this.cx + GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(1)] + (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
              GClass169.smethod_6(g, (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, this.cx + GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(1)] + (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
            }
            else
            {
              GClass169.smethod_6(g, (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, this.cx - GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(1)] - (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142_1.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(7), Class15.smethod_0(40));
              GClass169.smethod_6(g, (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, this.cx - GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(1)] - (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) gclass142_2.pi[GClass20.int_0[this.cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy, Class15.smethod_0(7), Class15.smethod_0(40));
              GClass169.smethod_6(g, (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, this.cx - GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(1)] - (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx, this.cy - GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) gclass142_3.pi[GClass20.int_0[this.cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy, Class15.smethod_0(7), Class15.smethod_0(40));
            }
            if (GClass185.int_37 != Class15.smethod_0(190))
            {
              int num1 = Class15.smethod_0(9);
              if (this.template.npcTemplateId == Class15.smethod_0(43))
                num1 = Class15.smethod_0(43);
              if (GClass20.smethod_1().npcFocus != null && GClass20.smethod_1().npcFocus.Equals((object) this))
              {
                if (GClass43.gclass43_0 == null)
                  g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.cx, this.cy - this.ch - (num1 - Class15.smethod_0(88)), GClass98.int_5 | GClass98.int_0);
              }
              else
              {
                int num2 = Class15.smethod_0(88);
                if (this.template.npcTemplateId == Class15.smethod_0(43))
                  num2 = Class15.smethod_0(54);
              }
            }
            this.int_27 = Class15.smethod_0(130);
          }
        }
        else if (this.duahau != null)
        {
          if (this.template.npcTemplateId == Class15.smethod_0(32) && GClass21.bool_20)
          {
            GClass21.int_28 += Class15.smethod_0(1);
            if (GClass62.int_8 % Class15.smethod_0(5) == 0)
              GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.cx + GClass151.smethod_18(Class15.smethod_0(141), Class15.smethod_0(32)), this.cy, Class15.smethod_0(7), Class15.smethod_0(1), -1));
            if (GClass62.int_8 % Class15.smethod_0(9) == 0)
              GClass40.smethod_0(new GClass41(Class15.smethod_0(124), this.cx + GClass151.smethod_18(Class15.smethod_0(192), Class15.smethod_0(3)), this.cy + GClass151.smethod_18(Class15.smethod_0(462), Class15.smethod_0(0)), Class15.smethod_0(7), Class15.smethod_0(1), -1));
            if (GClass21.int_28 == Class15.smethod_0(21))
              GClass116.smethod_6().method_50(this.cx, this.cy);
            if (GClass21.int_28 == Class15.smethod_0(80))
            {
              GClass21.bool_20 = Class15.smethod_0(0) != 0;
              this.template.npcTemplateId = Class15.smethod_0(2);
            }
          }
          int num = Class15.smethod_0(0);
          if (GClass169.gclass192_0[this.duahau[this.int_26]] != null && GClass169.gclass192_0[this.duahau[this.int_26]].img != null)
            num = GClass98.smethod_1(GClass169.gclass192_0[this.duahau[this.int_26]].img);
          GClass169.smethod_6(g, this.duahau[this.int_26], this.cx + GClass151.smethod_18(-1, Class15.smethod_0(1)), this.cy, Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
          if (GClass20.smethod_1().npcFocus != null && GClass20.smethod_1().npcFocus.Equals((object) this))
          {
            if (GClass43.gclass43_0 == null)
              g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.cx, this.cy - this.ch - Class15.smethod_0(45) + Class15.smethod_0(10) - num, GClass98.int_5 | GClass98.int_0);
            GClass97.gclass97_3.method_10(g, GClass138.smethod_8(this.seconds), this.cx, this.cy - this.ch - Class15.smethod_0(10) - GClass97.gclass97_11.method_20() - Class15.smethod_0(51) - num + Class15.smethod_0(10), GClass97.int_2, GClass97.gclass97_6);
          }
          else
            GClass97.gclass97_3.method_10(g, GClass138.smethod_8(this.seconds), this.cx, this.cy - this.ch - Class15.smethod_0(88) - GClass97.gclass97_11.method_20() - Class15.smethod_0(51) - num + Class15.smethod_0(10), GClass97.int_2, GClass97.gclass97_6);
        }
      }
      if (this.indexEffTask < Class15.smethod_0(0) || this.effTask == null || this.cTypePk != (sbyte) 0)
        return;
      GClass169.smethod_6(g, this.effTask.arrEfInfo[this.indexEffTask].idImg, this.cx + this.effTask.arrEfInfo[this.indexEffTask].dx, this.cy + this.effTask.arrEfInfo[this.indexEffTask].dy - this.int_27, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      if (GClass62.int_8 % Class15.smethod_0(7) != 0)
        return;
      this.indexEffTask += Class15.smethod_0(1);
      if (this.indexEffTask < this.effTask.arrEfInfo.Length)
        return;
      this.indexEffTask = Class15.smethod_0(0);
    }
  }

  public void method_158(GClass98 g)
  {
    if ((!GClass20.bool_4 ? 0 : 1) != 0 || (!this.isHide ? 0 : 1) != 0 || (!this.method_74() ? 1 : 0) != 0 || this.statusMe == Class15.smethod_0(9) || (this.template == null ? 0 : 1) == 0)
      return;
    if (this.template.npcTemplateId == Class15.smethod_0(5))
    {
      if ((GClass20.smethod_1().npcFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().npcFocus.Equals((object) this) ? 1 : 0) == 0)
        GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - GClass97.gclass97_11.method_20() - Class15.smethod_0(3), GClass97.int_2, GClass97.gclass97_16);
      else
        GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - Class15.smethod_0(5) - GClass97.gclass97_11.method_20(), GClass97.int_2, GClass97.gclass97_16);
      this.int_27 = Class15.smethod_0(4);
    }
    else
    {
      if (this.template.npcTemplateId == Class15.smethod_0(2))
        return;
      if (this.template.npcTemplateId != Class15.smethod_0(32) && this.template.npcTemplateId != Class15.smethod_0(190))
      {
        if (this.template.npcTemplateId == Class15.smethod_0(37))
        {
          if ((GClass20.smethod_1().npcFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().npcFocus.Equals((object) this) ? 1 : 0) == 0)
            GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - GClass97.gclass97_11.method_20() - Class15.smethod_0(10), GClass97.int_2, GClass97.gclass97_16);
          else
            GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - Class15.smethod_0(88) - GClass97.gclass97_11.method_20(), GClass97.int_2, GClass97.gclass97_16);
        }
        else
        {
          if (GClass185.int_37 != Class15.smethod_0(190))
          {
            int num1 = Class15.smethod_0(9);
            if (this.template.npcTemplateId == Class15.smethod_0(43))
              num1 = Class15.smethod_0(43);
            if ((GClass20.smethod_1().npcFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().npcFocus.Equals((object) this) ? 1 : 0) == 0)
            {
              if (GClass185.int_37 != Class15.smethod_0(76))
                GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - GClass97.gclass97_11.method_20() - num1, GClass97.int_2, GClass97.gclass97_16);
            }
            else
            {
              int num2 = Class15.smethod_0(88);
              if (this.template.npcTemplateId == Class15.smethod_0(43))
                num2 = Class15.smethod_0(54);
              if (GClass185.int_37 != Class15.smethod_0(76))
                GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - num2 - GClass97.gclass97_11.method_20(), GClass97.int_2, GClass97.gclass97_16);
            }
          }
          this.int_27 = Class15.smethod_0(130);
        }
      }
      else
      {
        if ((this.duahau == null ? 1 : 0) != 0)
          return;
        int num = Class15.smethod_0(0);
        if ((GClass169.gclass192_0[this.duahau[this.int_26]] == null ? 1 : 0) == 0 && (GClass169.gclass192_0[this.duahau[this.int_26]].img == null ? 1 : 0) == 0)
          num = GClass98.smethod_1(GClass169.gclass192_0[this.duahau[this.int_26]].img);
        if ((GClass20.smethod_1().npcFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().npcFocus.Equals((object) this) ? 1 : 0) == 0)
          GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - GClass97.gclass97_11.method_20() - num, GClass97.int_2, GClass97.gclass97_16);
        else
          GClass97.gclass97_15.method_10(g, this.template.name, this.cx, this.cy - this.ch - Class15.smethod_0(88) - GClass97.gclass97_11.method_20() - num + Class15.smethod_0(10), GClass97.int_2, GClass97.gclass97_16);
      }
    }
  }

  public void method_159()
  {
    this.statusMe = Class15.smethod_0(9);
    GClass20.gclass43_0 = (GClass43) null;
  }

  static GClass21()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.bgHNstQwfnBi));
    GClass21.int_29 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.eyPOBdysGHrp));
    GClass21.int_30 = (int[]) Class15.smethod_4(byte_0_2);
  }
}
