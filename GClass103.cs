// Decompiled with JetBrains decompiler
// Type: GClass103
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass103 : GClass100, GInterface3
{
  public static GClass66 gclass66_1 = GClass126.smethod_35(Class13.smethod_0(155124));
  public int xTo;
  public int yTo;
  public bool haftBody;
  public bool change;
  public new int xSd;
  public new int ySd;
  private int int_9;
  public new bool isShadown;
  private int int_10;
  private int int_11;
  public static GClass66 gclass66_2 = GClass126.smethod_35(Class13.smethod_0(154692));
  private bool bool_3;
  private int int_12;
  private int int_13;
  private int int_14;
  public new int typeSuperEff;
  private GClass20 gclass20_0;
  private bool bool_4;
  private bool bool_5;
  private int int_15;
  public bool changePos;
  private int int_16;
  public new bool isBusyAttackSomeOne;
  private int int_17;
  private GClass20[] gclass20_1;
  private int[] int_18;
  private sbyte sbyte_15;
  private int int_19;
  private sbyte[] sbyte_16;
  public new GClass20 injureBy;
  public new bool injureThenDie;
  public new GClass100 mobToAttack;
  public new int forceWait;
  public new bool blindEff;
  public new bool sleepEff;
  private int[][] int_20;
  public const sbyte sbyte_17 = 0;
  public const sbyte sbyte_18 = 1;
  public const sbyte sbyte_19 = 2;
  public const sbyte sbyte_20 = 3;
  public const sbyte sbyte_21 = 4;
  public const sbyte sbyte_22 = 5;
  public const sbyte sbyte_23 = 6;
  public const sbyte sbyte_24 = 7;
  public const sbyte sbyte_25 = 8;
  public const sbyte sbyte_26 = 9;
  public const sbyte sbyte_27 = 10;
  public const sbyte sbyte_28 = 11;
  public const sbyte sbyte_29 = 12;
  public const sbyte sbyte_30 = 13;
  public const sbyte sbyte_31 = 14;
  public const sbyte sbyte_32 = 15;
  public const sbyte sbyte_33 = 16;

  public GClass103(int id, short px, short py, int templateID, int hp, int maxHp, int s)
  {
    sbyte[] numArray1 = new sbyte[Class15.smethod_0(7)];
    numArray1[Class15.smethod_0(0)] = (sbyte) -1;
    numArray1[Class15.smethod_0(1)] = (sbyte) Class15.smethod_0(1);
    this.sbyte_16 = numArray1;
    int[][] numArray2 = new int[Class15.smethod_0(186)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_1 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray3 = (int[]) Class15.smethod_4(byte_0_1);
    numArray2[index1] = numArray3;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_2);
    numArray2[index2] = numArray4;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_3 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_3);
    numArray2[index3] = numArray5;
    int index4 = Class15.smethod_0(5);
    byte[] byte_0_4 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_4);
    numArray2[index4] = numArray6;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_5 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray7 = (int[]) Class15.smethod_4(byte_0_5);
    numArray2[index5] = numArray7;
    int index6 = Class15.smethod_0(3);
    byte[] byte_0_6 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray8 = (int[]) Class15.smethod_4(byte_0_6);
    numArray2[index6] = numArray8;
    int index7 = Class15.smethod_0(37);
    byte[] byte_0_7 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray9 = (int[]) Class15.smethod_4(byte_0_7);
    numArray2[index7] = numArray9;
    int index8 = Class15.smethod_0(38);
    byte[] byte_0_8 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray10 = (int[]) Class15.smethod_4(byte_0_8);
    numArray2[index8] = numArray10;
    int index9 = Class15.smethod_0(88);
    byte[] byte_0_9 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray11 = (int[]) Class15.smethod_4(byte_0_9);
    numArray2[index9] = numArray11;
    int index10 = Class15.smethod_0(45);
    byte[] byte_0_10 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray12 = (int[]) Class15.smethod_4(byte_0_10);
    numArray2[index10] = numArray12;
    int index11 = Class15.smethod_0(31);
    byte[] byte_0_11 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray13 = (int[]) Class15.smethod_4(byte_0_11);
    numArray2[index11] = numArray13;
    int index12 = Class15.smethod_0(67);
    byte[] byte_0_12 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_12, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray14 = (int[]) Class15.smethod_4(byte_0_12);
    numArray2[index12] = numArray14;
    int index13 = Class15.smethod_0(66);
    byte[] byte_0_13 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_13, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray15 = (int[]) Class15.smethod_4(byte_0_13);
    numArray2[index13] = numArray15;
    int index14 = Class15.smethod_0(47);
    byte[] byte_0_14 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_14, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray16 = (int[]) Class15.smethod_4(byte_0_14);
    numArray2[index14] = numArray16;
    int index15 = Class15.smethod_0(49);
    byte[] byte_0_15 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_15, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray17 = (int[]) Class15.smethod_4(byte_0_15);
    numArray2[index15] = numArray17;
    int index16 = Class15.smethod_0(9);
    byte[] byte_0_16 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_16, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray18 = (int[]) Class15.smethod_4(byte_0_16);
    numArray2[index16] = numArray18;
    int index17 = Class15.smethod_0(10);
    byte[] byte_0_17 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_17, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray19 = (int[]) Class15.smethod_4(byte_0_17);
    numArray2[index17] = numArray19;
    this.int_20 = numArray2;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.mobId = id;
    this.x = this.xFirst = (int) px + Class15.smethod_0(51);
    this.y = this.yFirst = (int) py;
    this.xTo = this.x;
    this.yTo = this.y;
    this.maxHp = maxHp;
    this.hp = hp;
    this.templateId = templateID;
    this.h_hp_bar = (byte) Class15.smethod_0(37);
    this.w_hp_bar = Class15.smethod_0(21);
    this.len = this.w_hp_bar;
    this.method_22();
    if ((GClass100.gclass106_0[this.templateId].data == null ? 0 : 1) == 0)
      GClass156.smethod_0().method_49(this.templateId);
    this.status = Class15.smethod_0(7);
    this.int_20 = (int[][]) null;
  }

  public void method_31(short id)
  {
    this.changBody = Class15.smethod_0(1) != 0;
    this.smallBody = id;
  }

  public void method_32() => this.changBody = Class15.smethod_0(0) != 0;

  public static bool smethod_6(string id)
  {
    for (int index = Class15.smethod_0(0); index < GClass100.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass100.gclass134_1.method_3(index)).Equals(id) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public void method_33(int[] array)
  {
    this.int_10 += Class15.smethod_0(1);
    if (this.int_10 > array.Length - Class15.smethod_0(1))
      this.int_10 = Class15.smethod_0(0);
    this.int_11 = array[this.int_10];
  }

  public void method_34()
  {
    int num = Class15.smethod_0(0);
    this.xSd = this.x;
    if ((!GClass185.smethod_27(this.x, this.y, Class15.smethod_0(7)) ? 1 : 0) == 0)
    {
      this.ySd = this.y;
    }
    else
    {
      this.ySd = this.y;
      while (num < Class15.smethod_0(6))
      {
        num += Class15.smethod_0(1);
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
  }

  private void method_35(GClass98 gclass98_0)
  {
    int sbyte0 = (int) GClass185.sbyte_0;
    if ((GClass185.int_37 < Class15.smethod_0(24) || GClass185.int_37 > Class15.smethod_0(98)) && GClass185.int_37 != Class15.smethod_0(73) && GClass185.int_37 != Class15.smethod_0(212))
    {
      if ((!GClass185.smethod_27(this.xSd + sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(2)) ? 1 : 0) == 0)
        gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
      else if ((GClass185.smethod_25((this.xSd - sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
        gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, Class15.smethod_0(21), Class15.smethod_0(21));
      else if ((GClass185.smethod_25((this.xSd + sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
        gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
      else if ((!GClass185.smethod_27(this.xSd - sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(88)) ? 1 : 0) == 0)
        gclass98_0.method_5(this.xSd / Class15.smethod_0(40) * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    }
    gclass98_0.method_32(GClass103.gclass66_1, this.xSd, this.ySd - Class15.smethod_0(3), Class15.smethod_0(5));
    gclass98_0.method_5(GClass116.int_22, GClass116.int_23 - GClass62.int_52, GClass116.int_6, GClass116.int_7 + Class15.smethod_0(7) * GClass62.int_52);
  }

  public void method_36()
  {
  }

  public override void vmethod_0()
  {
    if ((this.int_20 == null ? 0 : 1) == 0 && (GClass100.gclass106_0[this.templateId].data == null ? 1 : 0) == 0)
      this.method_55();
    if ((this.int_20 == null ? 1 : 0) != 0 || (!this.method_47() ? 0 : 1) == 0)
      return;
    this.method_34();
    switch (this.status)
    {
      case 0:
      case 1:
        this.method_37();
        break;
      case 2:
        this.method_41();
        break;
      case 3:
        this.method_44();
        break;
      case 4:
        this.method_38();
        break;
      case 5:
        this.timeStatus = Class15.smethod_0(0);
        this.method_45();
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
        this.method_40();
        break;
    }
  }

  private void method_37()
  {
    this.int_10 += Class15.smethod_0(1);
    if (this.int_10 > this.int_20[Class15.smethod_0(47)].Length - Class15.smethod_0(1))
      this.int_10 = this.int_20[Class15.smethod_0(47)].Length - Class15.smethod_0(1);
    this.int_11 = this.int_20[Class15.smethod_0(47)][this.int_10];
    if (this.x == this.xTo && this.y == this.yTo)
      return;
    this.x += (this.xTo - this.x) / Class15.smethod_0(2);
    this.y += (this.yTo - this.y) / Class15.smethod_0(2);
  }

  private void method_38()
  {
  }

  public void method_39(GClass20 cFocus)
  {
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.mobToAttack = (GClass100) null;
    this.cFocus = cFocus;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_10 = Class15.smethod_0(0);
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

  private void method_40()
  {
  }

  private void method_41()
  {
    this.method_33(this.int_20[Class15.smethod_0(0)]);
    if (this.x == this.xTo && this.y == this.yTo)
      return;
    this.x += (this.xTo - this.x) / Class15.smethod_0(2);
    this.y += (this.yTo - this.y) / Class15.smethod_0(2);
  }

  public void method_42()
  {
    this.status = Class15.smethod_0(2);
    this.bool_4 = Class15.smethod_0(1) != 0;
  }

  public void method_43(GClass20[] cAttack, int[] dame, sbyte type, sbyte dir)
  {
    this.gclass20_1 = cAttack;
    this.int_18 = dame;
    this.sbyte_15 = type;
    this.dir = (int) dir;
    this.status = Class15.smethod_0(5);
    if (this.x == this.xTo && this.y == this.yTo)
      return;
    this.x += (this.xTo - this.x) / Class15.smethod_0(2);
    this.y += (this.yTo - this.y) / Class15.smethod_0(2);
  }

  public void method_44()
  {
    if (this.int_10 == this.int_20[(int) this.sbyte_15 + Class15.smethod_0(1)].Length - Class15.smethod_0(1))
      this.status = Class15.smethod_0(7);
    this.method_33(this.int_20[(int) this.sbyte_15 + Class15.smethod_0(1)]);
    if (this.int_10 != this.int_20[Class15.smethod_0(9)][(int) this.sbyte_15 - Class15.smethod_0(1)])
      return;
    for (int index = Class15.smethod_0(0); index < this.gclass20_1.Length; index += Class15.smethod_0(1))
    {
      this.gclass20_1[index].method_108(this.int_18[index], Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0);
      GClass47.smethod_0(this.int_20[Class15.smethod_0(10)][(int) this.sbyte_15 - Class15.smethod_0(1)], this.gclass20_1[index].cx, this.gclass20_1[index].cy, Class15.smethod_0(1));
    }
  }

  public void method_45()
  {
    this.method_33(this.int_20[Class15.smethod_0(1)]);
    sbyte speed = GClass100.gclass106_0[this.templateId].speed;
    int num = (int) speed;
    if (GClass151.smethod_25(this.x - this.xTo) < (int) speed)
      num = GClass151.smethod_25(this.x - this.xTo);
    this.x += this.x >= this.xTo ? -num : num;
    this.y = this.yTo;
    if (this.x < this.xTo)
      this.dir = Class15.smethod_0(1);
    else if (this.x > this.xTo)
      this.dir = -1;
    if (GClass151.smethod_25(this.x - this.xTo) > Class15.smethod_0(1))
      return;
    this.x = this.xTo;
    this.status = Class15.smethod_0(7);
  }

  public bool method_46()
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

  public bool method_47() => (this.status == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public override void vmethod_1(GClass98 g)
  {
    if ((GClass100.gclass106_0[this.templateId].data == null ? 0 : 1) == 0)
      return;
    if ((!this.isShadown ? 1 : 0) == 0)
      this.method_35(g);
    g.method_1(Class15.smethod_0(0), GClass62.int_52);
    GClass100.gclass106_0[this.templateId].data.method_9(g, this.int_11, this.x, this.y + this.int_13, this.dir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(7));
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
  }

  public int method_48() => Class15.smethod_0(133);

  public void method_49()
  {
    this.hp = Class15.smethod_0(0);
    this.injureThenDie = Class15.smethod_0(1) != 0;
    this.hp = Class15.smethod_0(0);
    this.status = Class15.smethod_0(1);
    this.p1 = Class15.smethod_0(134);
    this.p2 = -this.dir;
    this.p3 = Class15.smethod_0(0);
  }

  public void method_50(GClass100 mobToAttack)
  {
    this.mobToAttack = mobToAttack;
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.cFocus = (GClass20) null;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_10 = Class15.smethod_0(0);
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

  public new int imethod_1() => this.y;

  public new int imethod_3() => this.h;

  public new int imethod_2() => this.w;

  public new void imethod_4()
  {
    if (this.status != Class15.smethod_0(3))
      return;
    this.status = Class15.smethod_0(7);
    this.p1 = this.p2 = this.p3 = Class15.smethod_0(0);
    this.forceWait = Class15.smethod_0(32);
  }

  public new bool imethod_5() => (this.status == 0 ? 1 : 0) == 0 ? this.status == Class15.smethod_0(1) : Class15.smethod_0(1) != 0;

  public void method_51()
  {
    if ((this.holdEffID == 0 ? 1 : 0) != 0)
      return;
    this.holdEffID = Class15.smethod_0(0);
  }

  public void method_52() => this.blindEff = Class15.smethod_0(0) != 0;

  public void method_53() => this.sleepEff = Class15.smethod_0(0) != 0;

  public void method_54(short xMoveTo, short yMoveTo)
  {
    if (yMoveTo != (short) -1)
    {
      if (GClass151.smethod_22(this.x, this.y, this.xTo, this.yTo) > Class15.smethod_0(21))
      {
        this.x = (int) xMoveTo;
        this.y = (int) yMoveTo;
        this.status = Class15.smethod_0(7);
      }
      else
      {
        this.xTo = (int) xMoveTo;
        this.yTo = (int) yMoveTo;
        this.status = Class15.smethod_0(3);
      }
    }
    else
    {
      this.xTo = (int) xMoveTo;
      this.status = Class15.smethod_0(3);
    }
  }

  public void method_55()
  {
    this.int_20 = (int[][]) GClass32.gclass128_0.method_0((object) (this.templateId.ToString() + string.Empty));
    this.w = GClass100.gclass106_0[this.templateId].data.width;
    this.h = GClass100.gclass106_0[this.templateId].data.height;
  }

  public void method_56() => this.status = Class15.smethod_0(0);
}
