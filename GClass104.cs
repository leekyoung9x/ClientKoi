// Decompiled with JetBrains decompiler
// Type: GClass104
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass104 : GClass100, GInterface3
{
  public static GClass66 gclass66_1 = GClass62.smethod_40(Class13.smethod_0(142141));
  public static GClass50 gclass50_0;
  public int xTo;
  public int yTo;
  public bool haftBody;
  public bool change;
  public new int xSd;
  public new int ySd;
  private bool bool_3;
  private int int_9;
  public new bool isShadown;
  private int int_10;
  private int int_11;
  private bool bool_4;
  private int int_12;
  private int int_13;
  private int int_14;
  public new int typeSuperEff;
  private GClass20 gclass20_0;
  private bool bool_5;
  private bool bool_6;
  private int int_15;
  public bool changePos;
  private int int_16;
  public new bool isBusyAttackSomeOne;
  private int int_17;
  private GClass20[] gclass20_1;
  private int[] int_18;
  private sbyte sbyte_15;
  public new int[] stand;
  public int[] stand_1;
  public new int[] move;
  public new int[] moveFast;
  public new int[] attack1;
  public new int[] attack2;
  public int[] attack3;
  public int[] attack2_1;
  public int[] attack3_1;
  public int[] fly;
  public int[] hitground;
  private bool bool_7;
  private sbyte[] sbyte_16;
  public new GClass20 injureBy;
  public new bool injureThenDie;
  public new GClass100 mobToAttack;
  public new int forceWait;
  public new bool blindEff;
  public new bool sleepEff;

  public GClass104(int id, short px, short py, int templateID, int hp, int maxhp, int s)
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.iqknYosCRHGA));
    this.stand = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(257)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.UwEmXqhrsfZU));
    this.stand_1 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.pmUfMStrXCdL));
    this.move = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.uioLwWGUemPc));
    this.moveFast = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.KGxxSdMIzGQm));
    this.attack1 = (int[]) Class15.smethod_4(byte_0_5);
    byte[] byte_0_6 = new byte[Class15.smethod_0(82)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.sUAEfhAHqbJO));
    this.attack2 = (int[]) Class15.smethod_4(byte_0_6);
    byte[] byte_0_7 = new byte[Class15.smethod_0(101)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.QstqGLUJYCLM));
    this.attack3 = (int[]) Class15.smethod_4(byte_0_7);
    byte[] byte_0_8 = new byte[Class15.smethod_0(23)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.MKdygDVpLOsI));
    this.attack2_1 = (int[]) Class15.smethod_4(byte_0_8);
    byte[] byte_0_9 = new byte[Class15.smethod_0(623)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.xLBfWliOoCNV));
    this.attack3_1 = (int[]) Class15.smethod_4(byte_0_9);
    byte[] byte_0_10 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.SbsiwrTsBJCl));
    this.fly = (int[]) Class15.smethod_4(byte_0_10);
    byte[] byte_0_11 = new byte[Class15.smethod_0(101)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.QstqGLUJYCLM));
    this.hitground = (int[]) Class15.smethod_4(byte_0_11);
    sbyte[] numArray = new sbyte[Class15.smethod_0(7)];
    numArray[Class15.smethod_0(0)] = (sbyte) -1;
    numArray[Class15.smethod_0(1)] = (sbyte) Class15.smethod_0(1);
    this.sbyte_16 = numArray;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.xFirst = this.x = (int) px + Class15.smethod_0(51);
    this.yFirst = this.y = (int) py;
    this.mobId = id;
    this.hp = hp;
    this.maxHp = maxhp;
    this.templateId = templateID;
    this.w_hp_bar = Class15.smethod_0(21);
    this.h_hp_bar = (byte) Class15.smethod_0(37);
    this.len = this.w_hp_bar;
    this.method_22();
    if ((s == 0 ? 0 : 1) == 0)
      this.method_32();
    if (s == Class15.smethod_0(1))
      this.method_31();
    if (s == Class15.smethod_0(7))
    {
      this.method_31();
      this.haftBody = Class15.smethod_0(1) != 0;
    }
    this.status = Class15.smethod_0(7);
  }

  public void method_31()
  {
    GClass104.gclass50_0 = (GClass50) null;
    GClass104.gclass50_0 = new GClass50();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(139322);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(139307);
    strArray[Class15.smethod_0(5)] = Class15.smethod_0(21).ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(139284);
    string patch = string.Concat(strArray);
    try
    {
      GClass104.gclass50_0.method_4(patch);
      GClass104.gclass50_0.img = GClass62.smethod_40(Class13.smethod_0(139307) + Class15.smethod_0(21).ToString() + Class13.smethod_0(140257));
    }
    catch (Exception ex)
    {
      GClass156.smethod_0().method_49(this.templateId);
    }
    this.status = Class15.smethod_0(7);
    this.w = GClass104.gclass50_0.width;
    this.h = GClass104.gclass50_0.height;
  }

  public void method_32()
  {
    GClass104.gclass50_0 = (GClass50) null;
    GClass104.gclass50_0 = new GClass50();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(140244);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(141359);
    strArray[Class15.smethod_0(5)] = Class15.smethod_0(444).ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(141342);
    string patch = string.Concat(strArray);
    try
    {
      GClass104.gclass50_0.method_4(patch);
      GClass104.gclass50_0.img = GClass62.smethod_40(Class13.smethod_0(141359) + Class15.smethod_0(444).ToString() + Class13.smethod_0(141331));
      GClass151.smethod_7(Class13.smethod_0(141318));
    }
    catch (Exception ex)
    {
      GClass156.smethod_0().method_49(this.templateId);
    }
    this.w = GClass104.gclass50_0.width;
    this.h = GClass104.gclass50_0.height;
  }

  public void method_33(short id)
  {
    this.changBody = Class15.smethod_0(1) != 0;
    this.smallBody = id;
  }

  public void method_34() => this.changBody = Class15.smethod_0(0) != 0;

  public static bool smethod_6(string id)
  {
    for (int index = Class15.smethod_0(0); index < GClass100.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass100.gclass134_1.method_3(index)).Equals(id) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public void method_35(int[] array)
  {
    this.int_10 += Class15.smethod_0(1);
    if (this.int_10 > array.Length - Class15.smethod_0(1))
      this.int_10 = Class15.smethod_0(0);
    this.int_11 = array[this.int_10];
  }

  private void method_36()
  {
    int sbyte0 = (int) GClass185.sbyte_0;
    this.xSd = this.x;
    this.int_9 = Class15.smethod_0(0);
    if (this.ySd <= Class15.smethod_0(0) || (!GClass185.smethod_27(this.xSd, this.ySd, Class15.smethod_0(7)) ? 1 : 0) == 0)
      return;
    if ((GClass185.smethod_25(this.xSd / sbyte0, this.ySd / sbyte0) == 0 ? 0 : 1) == 0)
      this.bool_3 = Class15.smethod_0(1) != 0;
    else if ((GClass185.smethod_25(this.xSd / sbyte0, this.ySd / sbyte0) == 0 ? 1 : 0) == 0 && (!GClass185.smethod_27(this.xSd, this.ySd, Class15.smethod_0(7)) ? 0 : 1) == 0)
    {
      this.xSd = this.x;
      this.ySd = this.y;
      this.bool_3 = Class15.smethod_0(0) != 0;
    }
    while ((!this.bool_3 ? 1 : 0) == 0 && this.int_9 < Class15.smethod_0(31))
    {
      this.int_9 += Class15.smethod_0(1);
      this.ySd += Class15.smethod_0(40);
      if ((!GClass185.smethod_27(this.xSd, this.ySd, Class15.smethod_0(7)) ? 1 : 0) == 0)
      {
        if ((this.ySd % Class15.smethod_0(40) == 0 ? 1 : 0) != 0)
          break;
        this.ySd -= this.ySd % Class15.smethod_0(40);
        break;
      }
    }
  }

  private void method_37(GClass98 gclass98_0)
  {
    gclass98_0.method_32(GClass104.gclass66_1, this.xSd, this.yFirst, Class15.smethod_0(5));
    gclass98_0.method_5(GClass116.int_22, GClass116.int_23 - GClass62.int_52, GClass116.int_6, GClass116.int_7 + Class15.smethod_0(7) * GClass62.int_52);
  }

  public void method_38()
  {
  }

  public override void vmethod_0()
  {
    if ((!this.method_51() ? 0 : 1) == 0)
      return;
    this.method_36();
    switch (this.status)
    {
      case 0:
      case 1:
        this.method_39();
        break;
      case 2:
        this.method_45();
        break;
      case 3:
        this.method_48();
        break;
      case 4:
        this.timeStatus = Class15.smethod_0(0);
        this.method_40();
        break;
      case 5:
        this.timeStatus = Class15.smethod_0(0);
        this.method_49();
        break;
      case 6:
        this.timeStatus = Class15.smethod_0(0);
        this.p1 += Class15.smethod_0(1);
        this.y += this.p1;
        if (this.y < this.yFirst)
          break;
        this.y = this.yFirst;
        this.p1 = Class15.smethod_0(0);
        this.status = Class15.smethod_0(3);
        break;
      case 7:
        this.method_44();
        break;
    }
  }

  private void method_39()
  {
    this.method_35((!this.haftBody ? 1 : 0) != 0 ? this.stand : this.stand_1);
    if ((GClass62.int_8 % Class15.smethod_0(3) == 0 ? 0 : 1) == 0)
      GClass47.smethod_0(Class15.smethod_0(128), GClass151.smethod_18(this.x - this.imethod_2() / Class15.smethod_0(7), this.x + this.imethod_2() / Class15.smethod_0(7)), GClass151.smethod_18(this.imethod_1() + this.imethod_3() / Class15.smethod_0(7), this.imethod_1() + this.imethod_3()), Class15.smethod_0(1));
    if (this.x == this.xFirst && this.y == this.yFirst)
      return;
    this.x += (this.xFirst - this.x) / Class15.smethod_0(2);
    this.y += (this.yFirst - this.y) / Class15.smethod_0(2);
  }

  private void method_40()
  {
    if ((!this.bool_5 ? 1 : 0) == 0)
    {
      this.int_15 += Class15.smethod_0(1);
      this.y -= this.int_15;
      this.method_35(this.fly);
      if (this.y <= Class15.smethod_0(178))
      {
        this.bool_5 = Class15.smethod_0(0) != 0;
        this.bool_6 = Class15.smethod_0(1) != 0;
        this.int_15 = Class15.smethod_0(0);
      }
    }
    if ((!this.bool_6 ? 1 : 0) != 0)
      return;
    this.x = this.xTo;
    this.int_15 += Class15.smethod_0(7);
    this.y += this.int_15;
    this.method_35(this.hitground);
    if (this.y <= this.yFirst)
      return;
    this.y = this.yFirst;
    this.bool_6 = Class15.smethod_0(0) != 0;
    this.int_15 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(7);
    GClass116.int_89 = Class15.smethod_0(31);
    this.bool_7 = Class15.smethod_0(1) != 0;
  }

  public void method_41()
  {
  }

  public void method_42(GClass20 cFocus)
  {
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.mobToAttack = (GClass100) null;
    this.cFocus = cFocus;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_10 = Class15.smethod_0(0);
    this.dir = cFocus.cx > this.x ? Class15.smethod_0(1) : -1;
    int cx = cFocus.cx;
    int cy = cFocus.cy;
    if (GClass151.smethod_25(cx - this.x) < this.w * Class15.smethod_0(7) && GClass151.smethod_25(cy - this.y) < this.h * Class15.smethod_0(7))
    {
      if (this.x < cx)
        this.x = cx - this.w;
      else
        this.x = cx + this.w;
      this.p3 = Class15.smethod_0(0);
    }
    else
      this.p3 = Class15.smethod_0(1);
  }

  private bool method_43() => (this.templateId < Class15.smethod_0(129) || this.templateId > Class15.smethod_0(130)) && this.templateId != Class15.smethod_0(131) && this.templateId != Class15.smethod_0(11) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  private void method_44()
  {
  }

  private void method_45()
  {
    this.method_35((!this.haftBody ? 1 : 0) != 0 ? this.stand : this.stand_1);
    if (this.x == this.xFirst && this.y == this.yFirst)
      return;
    this.x += (this.xFirst - this.x) / Class15.smethod_0(2);
    this.y += (this.yFirst - this.y) / Class15.smethod_0(2);
  }

  public void method_46()
  {
    this.status = Class15.smethod_0(2);
    this.bool_5 = Class15.smethod_0(1) != 0;
  }

  public void method_47(GClass20[] cAttack, int[] dame, sbyte type)
  {
    this.gclass20_1 = cAttack;
    this.int_18 = dame;
    this.sbyte_15 = type;
    this.int_10 = Class15.smethod_0(0);
    if ((int) type < Class15.smethod_0(5))
      this.status = Class15.smethod_0(5);
    if ((int) type == Class15.smethod_0(5))
    {
      this.bool_5 = Class15.smethod_0(1) != 0;
      this.status = Class15.smethod_0(2);
    }
    if ((int) type == Class15.smethod_0(2))
    {
      for (int index = Class15.smethod_0(0); index < this.gclass20_1.Length; index += Class15.smethod_0(1))
        this.gclass20_1[index].method_108(this.int_18[index], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
    }
    if ((int) type != Class15.smethod_0(38))
      return;
    this.status = Class15.smethod_0(5);
  }

  public void method_48()
  {
    if ((int) this.sbyte_15 == Class15.smethod_0(38))
    {
      if (this.int_10 > Class15.smethod_0(88))
        this.int_10 = Class15.smethod_0(88);
      this.method_35(this.attack1);
      if ((GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
        GClass47.smethod_0(Class15.smethod_0(152), this.x + (this.dir != Class15.smethod_0(1) ? Class15.smethod_0(206) : Class15.smethod_0(9)), this.y - Class15.smethod_0(54), Class15.smethod_0(1));
    }
    if ((this.sbyte_15 == (sbyte) 0 ? 0 : 1) == 0)
    {
      if (this.int_10 == this.attack1.Length - Class15.smethod_0(1))
        this.status = Class15.smethod_0(7);
      this.dir = this.x < this.gclass20_1[Class15.smethod_0(0)].cx ? Class15.smethod_0(1) : -1;
      this.method_35(this.attack1);
      if (this.int_10 == Class15.smethod_0(88))
      {
        for (int index = Class15.smethod_0(0); index < this.gclass20_1.Length; index += Class15.smethod_0(1))
          GClass46.smethod_0(this.x + (this.dir != Class15.smethod_0(1) ? Class15.smethod_0(179) : Class15.smethod_0(70)), this.y - Class15.smethod_0(6), Class15.smethod_0(1) != 0, this.int_18[index], Class15.smethod_0(0), this.gclass20_1[index], Class15.smethod_0(40));
      }
    }
    if ((int) this.sbyte_15 == Class15.smethod_0(1))
    {
      if (this.int_10 == ((!this.haftBody ? 1 : 0) != 0 ? this.attack2.Length - Class15.smethod_0(1) : this.attack2_1.Length - Class15.smethod_0(1)))
        this.status = Class15.smethod_0(7);
      this.dir = this.x < this.gclass20_1[Class15.smethod_0(0)].cx ? Class15.smethod_0(1) : -1;
      this.method_35((!this.haftBody ? 1 : 0) != 0 ? this.attack2 : this.attack2_1);
      this.x += (this.gclass20_1[Class15.smethod_0(0)].cx - this.x) / Class15.smethod_0(2);
      this.y += (this.gclass20_1[Class15.smethod_0(0)].cy - this.y) / Class15.smethod_0(2);
      if (this.int_10 == Class15.smethod_0(124))
      {
        for (int index = Class15.smethod_0(0); index < this.gclass20_1.Length; index += Class15.smethod_0(1))
        {
          this.gclass20_1[index].method_108(this.int_18[index], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
          GClass47.smethod_0(Class15.smethod_0(68), this.gclass20_1[index].cx, this.gclass20_1[index].cy, Class15.smethod_0(1));
        }
      }
    }
    Class15.smethod_0(88);
    if ((int) this.sbyte_15 != Class15.smethod_0(7))
      return;
    if (this.int_10 == ((!this.haftBody ? 1 : 0) != 0 ? this.attack3.Length - Class15.smethod_0(1) : this.attack3_1.Length - Class15.smethod_0(1)))
      this.status = Class15.smethod_0(7);
    this.dir = this.x < this.gclass20_1[Class15.smethod_0(0)].cx ? Class15.smethod_0(1) : -1;
    this.method_35((!this.haftBody ? 1 : 0) != 0 ? this.attack3 : this.attack3_1);
    if (this.int_10 != Class15.smethod_0(47))
      return;
    GClass116.int_89 = Class15.smethod_0(31);
    this.bool_7 = Class15.smethod_0(1) != 0;
    for (int index = Class15.smethod_0(0); index < this.gclass20_1.Length; index += Class15.smethod_0(1))
      this.gclass20_1[index].method_108(this.int_18[index], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
  }

  public void method_49()
  {
  }

  public bool method_50()
  {
    if (this.x < GClass116.int_22)
      return Class15.smethod_0(0) != 0;
    if (this.x > GClass116.int_22 + GClass116.int_6)
      return Class15.smethod_0(0) != 0;
    if (this.y < GClass116.int_23)
      return Class15.smethod_0(0) != 0;
    if (this.y > GClass116.int_23 + GClass116.int_7 + Class15.smethod_0(6))
      return Class15.smethod_0(0) != 0;
    return (this.status == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public bool method_51() => (this.status == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public bool method_52() => (!this.isBoss ? 0 : 1) == 0 && (int) this.levelBoss <= Class15.smethod_0(0) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public override void vmethod_1(GClass98 g)
  {
    if ((GClass104.gclass50_0 == null ? 0 : 1) == 0)
      return;
    if ((!this.isShadown ? 1 : 0) == 0 && (this.status == 0 ? 1 : 0) == 0)
      this.method_37(g);
    g.method_1(Class15.smethod_0(0), GClass62.int_52);
    GClass104.gclass50_0.method_9(g, this.int_11, this.x, this.y + this.int_13, this.dir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(7));
    g.method_1(Class15.smethod_0(0), -GClass62.int_52);
    int num1 = GClass98.smethod_0(this.imgHPtem);
    int h0 = GClass98.smethod_1(this.imgHPtem);
    int w0_1 = num1;
    int x = this.x - num1;
    int y = this.y - this.h - Class15.smethod_0(3);
    int num2 = num1 * Class15.smethod_0(7) * this.per / Class15.smethod_0(21);
    int w0_2;
    if (num2 > w0_1)
    {
      w0_2 = num2 - w0_1;
      if (w0_2 <= Class15.smethod_0(0))
        w0_2 = Class15.smethod_0(0);
    }
    else
    {
      w0_1 = num2;
      w0_2 = Class15.smethod_0(0);
    }
    g.method_32(GClass116.gclass66_37, x, y, GClass98.int_4 | GClass98.int_2);
    g.method_32(GClass116.gclass66_37, x + num1, y, GClass98.int_4 | GClass98.int_2);
    g.method_24(this.imgHPtem, Class15.smethod_0(0), Class15.smethod_0(0), w0_1, h0, Class15.smethod_0(0), x, y, GClass98.int_4 | GClass98.int_2);
    g.method_24(this.imgHPtem, Class15.smethod_0(0), Class15.smethod_0(0), w0_2, h0, Class15.smethod_0(0), x + num1, y, GClass98.int_4 | GClass98.int_2);
    if ((!this.bool_7 ? 1 : 0) != 0)
      return;
    GClass151.smethod_7(Class13.smethod_0(141492) + this.sbyte_15.ToString());
    this.int_16 += Class15.smethod_0(1);
    GClass40.smethod_0(new GClass41((int) this.sbyte_15 != Class15.smethod_0(7) ? Class15.smethod_0(28) : Class15.smethod_0(65), this.x + this.int_16 * Class15.smethod_0(32), this.y + Class15.smethod_0(46), Class15.smethod_0(7), Class15.smethod_0(1), -1));
    GClass40.smethod_0(new GClass41((int) this.sbyte_15 != Class15.smethod_0(7) ? Class15.smethod_0(28) : Class15.smethod_0(65), this.x - this.int_16 * Class15.smethod_0(32), this.y + Class15.smethod_0(46), Class15.smethod_0(7), Class15.smethod_0(1), -1));
    if (this.int_16 != Class15.smethod_0(32))
      return;
    this.int_16 = Class15.smethod_0(0);
    this.bool_7 = Class15.smethod_0(0) != 0;
  }

  public int method_53() => Class15.smethod_0(133);

  public void method_54()
  {
    this.hp = Class15.smethod_0(0);
    this.injureThenDie = Class15.smethod_0(1) != 0;
    this.hp = Class15.smethod_0(0);
    this.status = Class15.smethod_0(1);
    this.p1 = Class15.smethod_0(134);
    this.p2 = -this.dir;
    this.p3 = Class15.smethod_0(0);
  }

  public void method_55(GClass100 mobToAttack)
  {
    this.mobToAttack = mobToAttack;
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.cFocus = (GClass20) null;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_10 = Class15.smethod_0(0);
    this.dir = mobToAttack.x > this.x ? Class15.smethod_0(1) : -1;
    int x = mobToAttack.x;
    int y = mobToAttack.y;
    if (GClass151.smethod_25(x - this.x) < this.w * Class15.smethod_0(7) && GClass151.smethod_25(y - this.y) < this.h * Class15.smethod_0(7))
    {
      if (this.x < x)
        this.x = x - this.w;
      else
        this.x = x + this.w;
      this.p3 = Class15.smethod_0(0);
    }
    else
      this.p3 = Class15.smethod_0(1);
  }

  public new int imethod_0() => this.x;

  public new int imethod_1() => (!this.haftBody ? 1 : 0) == 0 ? this.y - Class15.smethod_0(51) : this.y - Class15.smethod_0(4);

  public new int imethod_3() => Class15.smethod_0(54);

  public new int imethod_2() => Class15.smethod_0(4);

  public new void imethod_4()
  {
    if (this.status != Class15.smethod_0(3))
      return;
    this.status = Class15.smethod_0(7);
    this.p1 = this.p2 = this.p3 = Class15.smethod_0(0);
    this.forceWait = Class15.smethod_0(32);
  }

  public new bool imethod_5() => (this.status == 0 ? 1 : 0) == 0 ? this.status == Class15.smethod_0(1) : Class15.smethod_0(1) != 0;

  public void method_56()
  {
    if ((this.holdEffID == 0 ? 1 : 0) != 0)
      return;
    this.holdEffID = Class15.smethod_0(0);
  }

  public void method_57() => this.blindEff = Class15.smethod_0(0) != 0;

  public void method_58() => this.sleepEff = Class15.smethod_0(0) != 0;
}
