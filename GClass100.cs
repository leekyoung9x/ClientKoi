// Decompiled with JetBrains decompiler
// Type: GClass100
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass100 : GInterface3
{
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 1;
  public const sbyte sbyte_2 = 2;
  public const sbyte sbyte_3 = 3;
  public const sbyte sbyte_4 = 4;
  public const sbyte sbyte_5 = 5;
  public static GClass106[] gclass106_0;
  public const sbyte sbyte_6 = 0;
  public const sbyte sbyte_7 = 1;
  public const sbyte sbyte_8 = 2;
  public const sbyte sbyte_9 = 3;
  public const sbyte sbyte_10 = 4;
  public const sbyte sbyte_11 = 5;
  public const sbyte sbyte_12 = 6;
  public const sbyte sbyte_13 = 7;
  public bool changBody;
  public short smallBody;
  public bool isHintFocus;
  public string flystring;
  public int flyx;
  public int flyy;
  public int flyIndex;
  public bool isFreez;
  public int seconds;
  public long last;
  public long cur;
  public int holdEffID;
  public int hp;
  public int maxHp;
  public int x;
  public int y;
  public int dir;
  public int dirV;
  public int status;
  public int p1;
  public int p2;
  public int p3;
  public int xFirst;
  public int yFirst;
  public int vy;
  public int exp;
  public int w;
  public int h;
  public int hpInjure;
  public int charIndex;
  public int timeStatus;
  public int mobId;
  public bool isx;
  public bool isy;
  public bool isDisable;
  public bool isDontMove;
  public bool isFire;
  public bool isIce;
  public bool isWind;
  public bool isDie;
  public GClass134 vMobMove;
  public bool isGo;
  public string mobName;
  public int templateId;
  public short pointx;
  public short pointy;
  public GClass20 cFocus;
  public int dame;
  public int dameMp;
  public int sys;
  public sbyte levelBoss;
  public sbyte level;
  public bool isBoss;
  public bool isMobMe;
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass134 gclass134_1 = new GClass134();
  public int xSd;
  public int ySd;
  private bool bool_0;
  private int int_0;
  public bool isShadown;
  private int int_1;
  private int int_2;
  public static GClass66 gclass66_0 = GClass62.smethod_40(Class13.smethod_0(153610));
  private bool bool_1;
  private int int_3;
  private int int_4;
  private int int_5;
  public int typeSuperEff;
  public bool isBusyAttackSomeOne;
  public int[] stand;
  public int[] move;
  public int[] moveFast;
  public int[] attack1;
  public int[] attack2;
  public int[] hurt;
  private int int_6;
  public int len;
  public int w_hp_bar;
  public int per;
  public int per_tem;
  public byte h_hp_bar;
  public GClass66 imgHPtem;
  private int int_7;
  private sbyte[] sbyte_14;
  public GClass20 injureBy;
  public bool injureThenDie;
  public GClass100 mobToAttack;
  public int forceWait;
  public bool blindEff;
  public bool sleepEff;
  private int[][] int_8;
  private bool bool_2;
  public long cTimeDie;

  public GClass100()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.iqknYosCRHGA));
    this.stand = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.pmUfMStrXCdL));
    this.move = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.uioLwWGUemPc));
    this.moveFast = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.CmbsxQpMmtSD));
    this.attack1 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.ntBxAyroXqdu));
    this.attack2 = (int[]) Class15.smethod_4(byte_0_5);
    this.hurt = new int[Class15.smethod_0(1)];
    this.int_6 = Class15.smethod_0(398);
    this.len = Class15.smethod_0(40);
    this.w_hp_bar = Class15.smethod_0(40);
    this.per = Class15.smethod_0(21);
    this.per_tem = Class15.smethod_0(21);
    this.h_hp_bar = (byte) Class15.smethod_0(2);
    sbyte[] numArray1 = new sbyte[Class15.smethod_0(7)];
    numArray1[Class15.smethod_0(0)] = (sbyte) -1;
    numArray1[Class15.smethod_0(1)] = (sbyte) Class15.smethod_0(1);
    this.sbyte_14 = numArray1;
    int[][] numArray2 = new int[Class15.smethod_0(37)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_6 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray3 = (int[]) Class15.smethod_4(byte_0_6);
    numArray2[index1] = numArray3;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_7 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_7);
    numArray2[index2] = numArray4;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_8 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_8);
    numArray2[index3] = numArray5;
    int index4 = Class15.smethod_0(5);
    byte[] byte_0_9 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_9);
    numArray2[index4] = numArray6;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_10 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray7 = (int[]) Class15.smethod_4(byte_0_10);
    numArray2[index5] = numArray7;
    int index6 = Class15.smethod_0(3);
    byte[] byte_0_11 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray8 = (int[]) Class15.smethod_4(byte_0_11);
    numArray2[index6] = numArray8;
    this.int_8 = numArray2;
    this.bool_2 = Class15.smethod_0(1) != 0;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public GClass100(
    int mobId,
    bool isDisable,
    bool isDontMove,
    bool isFire,
    bool isIce,
    bool isWind,
    int templateId,
    int sys,
    int hp,
    sbyte level,
    int maxp,
    short pointx,
    short pointy,
    sbyte status,
    sbyte levelBoss)
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.iqknYosCRHGA));
    this.stand = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.pmUfMStrXCdL));
    this.move = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.uioLwWGUemPc));
    this.moveFast = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.CmbsxQpMmtSD));
    this.attack1 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.ntBxAyroXqdu));
    this.attack2 = (int[]) Class15.smethod_4(byte_0_5);
    this.hurt = new int[Class15.smethod_0(1)];
    this.int_6 = Class15.smethod_0(398);
    this.len = Class15.smethod_0(40);
    this.w_hp_bar = Class15.smethod_0(40);
    this.per = Class15.smethod_0(21);
    this.per_tem = Class15.smethod_0(21);
    this.h_hp_bar = (byte) Class15.smethod_0(2);
    sbyte[] numArray1 = new sbyte[Class15.smethod_0(7)];
    numArray1[Class15.smethod_0(0)] = (sbyte) -1;
    numArray1[Class15.smethod_0(1)] = (sbyte) Class15.smethod_0(1);
    this.sbyte_14 = numArray1;
    int[][] numArray2 = new int[Class15.smethod_0(37)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_6 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray3 = (int[]) Class15.smethod_4(byte_0_6);
    numArray2[index1] = numArray3;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_7 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_7);
    numArray2[index2] = numArray4;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_8 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_8);
    numArray2[index3] = numArray5;
    int index4 = Class15.smethod_0(5);
    byte[] byte_0_9 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_9);
    numArray2[index4] = numArray6;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_10 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray7 = (int[]) Class15.smethod_4(byte_0_10);
    numArray2[index5] = numArray7;
    int index6 = Class15.smethod_0(3);
    byte[] byte_0_11 = new byte[Class15.smethod_0(152)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.TVRTVuxFSFFk));
    int[] numArray8 = (int[]) Class15.smethod_4(byte_0_11);
    numArray2[index6] = numArray8;
    this.int_8 = numArray2;
    this.bool_2 = Class15.smethod_0(1) != 0;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.isDisable = isDisable;
    this.isDontMove = isDontMove;
    this.isFire = isFire;
    this.isIce = isIce;
    this.isWind = isWind;
    this.sys = sys;
    this.mobId = mobId;
    this.templateId = templateId;
    this.hp = hp;
    this.level = level;
    this.xFirst = this.x = (int) (this.pointx = pointx);
    this.yFirst = this.y = (int) (this.pointy = pointy);
    this.status = (int) status;
    if (templateId != Class15.smethod_0(152))
    {
      this.method_4();
      this.method_1();
    }
    if (!GClass100.smethod_0(templateId.ToString() + string.Empty))
      GClass100.gclass134_1.method_0((object) (templateId.ToString() + string.Empty));
    this.maxHp = maxp;
    this.levelBoss = levelBoss;
    this.method_22();
    this.per_tem = (int) ((long) hp * (long) Class15.smethod_0(21) / (long) this.maxHp);
    this.isDie = Class15.smethod_0(0) != 0;
    this.xSd = (int) pointx;
    this.ySd = (int) pointy;
    if (this.method_12())
    {
      byte[] byte_0_12 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_12, __fieldref (Class12.jivtHTpTVpGv));
      this.stand = (int[]) Class15.smethod_4(byte_0_12);
      byte[] byte_0_13 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_13, __fieldref (Class12.jivtHTpTVpGv));
      this.move = (int[]) Class15.smethod_4(byte_0_13);
      byte[] byte_0_14 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_14, __fieldref (Class12.jivtHTpTVpGv));
      this.moveFast = (int[]) Class15.smethod_4(byte_0_14);
      byte[] byte_0_15 = new byte[Class15.smethod_0(107)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_15, __fieldref (Class12.aCmecplBqGLu));
      this.attack1 = (int[]) Class15.smethod_4(byte_0_15);
      byte[] byte_0_16 = new byte[Class15.smethod_0(107)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_16, __fieldref (Class12.aCmecplBqGLu));
      this.attack2 = (int[]) Class15.smethod_4(byte_0_16);
    }
    else if (this.method_13())
    {
      byte[] byte_0_17 = new byte[Class15.smethod_0(135)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_17, __fieldref (Class12.iqknYosCRHGA));
      this.stand = (int[]) Class15.smethod_4(byte_0_17);
      byte[] byte_0_18 = new byte[Class15.smethod_0(62)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_18, __fieldref (Class12.qHKLOhkextQw));
      this.move = (int[]) Class15.smethod_4(byte_0_18);
      byte[] byte_0_19 = new byte[Class15.smethod_0(107)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_19, __fieldref (Class12.skBgQWTaydvf));
      this.moveFast = (int[]) Class15.smethod_4(byte_0_19);
      byte[] byte_0_20 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_20, __fieldref (Class12.WcIQOOkWZGCi));
      this.attack1 = (int[]) Class15.smethod_4(byte_0_20);
      byte[] byte_0_21 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_21, __fieldref (Class12.HfnPfPLSggSB));
      this.attack2 = (int[]) Class15.smethod_4(byte_0_21);
    }
    else if (this.method_11())
    {
      byte[] byte_0_22 = new byte[Class15.smethod_0(135)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_22, __fieldref (Class12.iqknYosCRHGA));
      this.stand = (int[]) Class15.smethod_4(byte_0_22);
      byte[] byte_0_23 = new byte[Class15.smethod_0(216)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_23, __fieldref (Class12.ufHpeVcCXkqj));
      this.move = (int[]) Class15.smethod_4(byte_0_23);
      byte[] byte_0_24 = new byte[Class15.smethod_0(184)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_24, __fieldref (Class12.kVwCzwjrzTjY));
      this.moveFast = (int[]) Class15.smethod_4(byte_0_24);
      byte[] byte_0_25 = new byte[Class15.smethod_0(184)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_25, __fieldref (Class12.jSTNpRdPujWO));
      this.attack1 = (int[]) Class15.smethod_4(byte_0_25);
      byte[] byte_0_26 = new byte[Class15.smethod_0(61)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_26, __fieldref (Class12.yzihjNoDJKTW));
      this.attack2 = (int[]) Class15.smethod_4(byte_0_26);
    }
    else
    {
      byte[] byte_0_27 = new byte[Class15.smethod_0(135)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_27, __fieldref (Class12.iqknYosCRHGA));
      this.stand = (int[]) Class15.smethod_4(byte_0_27);
      byte[] byte_0_28 = new byte[Class15.smethod_0(26)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_28, __fieldref (Class12.pmUfMStrXCdL));
      this.move = (int[]) Class15.smethod_4(byte_0_28);
      byte[] byte_0_29 = new byte[Class15.smethod_0(135)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_29, __fieldref (Class12.uioLwWGUemPc));
      this.moveFast = (int[]) Class15.smethod_4(byte_0_29);
      byte[] byte_0_30 = new byte[Class15.smethod_0(62)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_30, __fieldref (Class12.CmbsxQpMmtSD));
      this.attack1 = (int[]) Class15.smethod_4(byte_0_30);
      byte[] byte_0_31 = new byte[Class15.smethod_0(62)];
      // ISSUE: field reference
      RuntimeHelpers.InitializeArray((Array) byte_0_31, __fieldref (Class12.ntBxAyroXqdu));
      this.attack2 = (int[]) Class15.smethod_4(byte_0_31);
    }
  }

  public bool method_0() => (!(this is GClass101) ? 0 : 1) == 0 && (!(this is GClass102) ? 0 : 1) == 0 && (!(this is GClass104) ? 0 : 1) == 0 ? this is GClass103 : Class15.smethod_0(1) != 0;

  public void method_1()
  {
    if ((GClass100.gclass106_0[this.templateId].data == null ? 0 : 1) == 0)
    {
      GClass100.gclass106_0[this.templateId].data = new GClass50();
      string path = Class13.smethod_0(153560) + this.templateId.ToString();
      if ((GClass133.smethod_0(path) == null ? 1 : 0) == 0)
      {
        GClass100.gclass106_0[this.templateId].data.method_3(path + Class13.smethod_0(153554));
        GClass100.gclass106_0[this.templateId].data.img = GClass62.smethod_40(path + Class13.smethod_0(153539));
      }
      else
        GClass156.smethod_0().method_49(this.templateId);
      GClass100.gclass134_0.method_0((object) (this.templateId.ToString() + string.Empty));
    }
    else
    {
      this.w = GClass100.gclass106_0[this.templateId].data.width;
      this.h = GClass100.gclass106_0[this.templateId].data.height;
    }
  }

  public void method_2(short id)
  {
    this.changBody = Class15.smethod_0(1) != 0;
    this.smallBody = id;
  }

  public void method_3() => this.changBody = Class15.smethod_0(0) != 0;

  public static bool smethod_0(string id)
  {
    for (int index = Class15.smethod_0(0); index < GClass100.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass100.gclass134_1.method_3(index)).Equals(id) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public void method_4()
  {
    int num = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < GClass100.gclass106_0.Length; index += Class15.smethod_0(1))
    {
      if ((GClass100.gclass106_0[index].data == null ? 1 : 0) == 0)
        num += Class15.smethod_0(1);
    }
    if (num < Class15.smethod_0(31))
      return;
    for (int index = Class15.smethod_0(0); index < GClass100.gclass106_0.Length; index += Class15.smethod_0(1))
    {
      if ((GClass100.gclass106_0[index].data == null ? 1 : 0) == 0 && num > Class15.smethod_0(3))
        GClass100.gclass106_0[index].data = (GClass50) null;
    }
  }

  public void method_5(int[] array)
  {
    if (this.int_1 > array.Length - Class15.smethod_0(1))
      this.int_1 = Class15.smethod_0(0);
    this.int_2 = array[this.int_1];
    this.int_1 += Class15.smethod_0(1);
  }

  private void method_6()
  {
    int sbyte0 = (int) GClass185.sbyte_0;
    this.xSd = this.x;
    this.int_0 = Class15.smethod_0(0);
    if (this.ySd <= Class15.smethod_0(0) || (!GClass185.smethod_27(this.xSd, this.ySd, Class15.smethod_0(7)) ? 1 : 0) == 0)
      return;
    if ((GClass185.smethod_25(this.xSd / sbyte0, this.ySd / sbyte0) == 0 ? 0 : 1) == 0)
      this.bool_0 = Class15.smethod_0(1) != 0;
    else if ((GClass185.smethod_25(this.xSd / sbyte0, this.ySd / sbyte0) == 0 ? 1 : 0) == 0 && (!GClass185.smethod_27(this.xSd, this.ySd, Class15.smethod_0(7)) ? 0 : 1) == 0)
    {
      this.xSd = this.x;
      this.ySd = this.y;
      this.bool_0 = Class15.smethod_0(0) != 0;
    }
    while ((!this.bool_0 ? 1 : 0) == 0 && this.int_0 < Class15.smethod_0(31))
    {
      this.int_0 += Class15.smethod_0(1);
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

  private void method_7(GClass98 gclass98_0)
  {
    int sbyte0 = (int) GClass185.sbyte_0;
    if ((!GClass185.smethod_27(this.xSd + sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(2)) ? 1 : 0) == 0)
      gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    else if ((GClass185.smethod_25((this.xSd - sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
      gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, Class15.smethod_0(21), Class15.smethod_0(21));
    else if ((GClass185.smethod_25((this.xSd + sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
      gclass98_0.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    else if ((!GClass185.smethod_27(this.xSd - sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(88)) ? 1 : 0) == 0)
      gclass98_0.method_5(this.xSd / Class15.smethod_0(40) * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    gclass98_0.method_32(GClass185.gclass66_10, this.xSd, this.ySd, Class15.smethod_0(5));
    gclass98_0.method_5(GClass116.int_22, GClass116.int_23 - GClass62.int_52, GClass116.int_6, GClass116.int_7 + Class15.smethod_0(7) * GClass62.int_52);
  }

  public void method_8()
  {
    if ((this.typeSuperEff == 0 ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(46) == 0 ? 0 : 1) == 0)
      GClass47.smethod_2(Class15.smethod_0(24), this, Class15.smethod_0(1));
    if (this.typeSuperEff == Class15.smethod_0(1) && (GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
      GClass47.smethod_2(Class15.smethod_0(198), this, Class15.smethod_0(1));
    if (this.typeSuperEff != Class15.smethod_0(7) || (GClass62.int_8 % Class15.smethod_0(38) == 0 ? 0 : 1) != 0)
      return;
    GClass47.smethod_2(Class15.smethod_0(77), this, Class15.smethod_0(1));
  }

  public virtual void vmethod_0()
  {
    this.method_29();
    if (this.blindEff && GClass62.int_8 % Class15.smethod_0(3) == 0)
      GClass47.smethod_0(Class15.smethod_0(76), this.x, this.y, Class15.smethod_0(1));
    if (this.sleepEff && GClass62.int_8 % Class15.smethod_0(31) == 0)
      GClass40.smethod_0(new GClass41(Class15.smethod_0(55), this.x, this.y, Class15.smethod_0(5), Class15.smethod_0(1), Class15.smethod_0(1)));
    if (!GClass62.bool_1 && this.status != Class15.smethod_0(1) && this.status != 0 && !GClass62.bool_1 && GClass62.int_8 % (Class15.smethod_0(9) + this.mobId * Class15.smethod_0(7)) == 0)
    {
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
      {
        GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
        if (gclass20 != null && gclass20.isFlyAndCharge && gclass20.cf == Class15.smethod_0(120))
        {
          GClass20 c = new GClass20();
          c.cx = gclass20.cx;
          c.cy = gclass20.cy - gclass20.ch;
          if (gclass20.cgender == 0)
            GClass46.smethod_0(this.x + this.dir * this.w, this.y, this.method_21(), Class15.smethod_0(143), Class15.smethod_0(143), c, Class15.smethod_0(46));
        }
      }
      if (GClass20.smethod_1().isFlyAndCharge && GClass20.smethod_1().cf == Class15.smethod_0(120))
      {
        GClass20 c = new GClass20();
        c.cx = GClass20.smethod_1().cx;
        c.cy = GClass20.smethod_1().cy - GClass20.smethod_1().ch;
        if (GClass20.smethod_1().cgender == 0)
          GClass46.smethod_0(this.x + this.dir * this.w, this.y, this.method_21(), Class15.smethod_0(143), Class15.smethod_0(143), c, Class15.smethod_0(46));
      }
    }
    if (this.holdEffID != 0 && GClass62.int_8 % Class15.smethod_0(3) == 0)
      GClass40.smethod_0(new GClass41(this.holdEffID, this.x, this.y + Class15.smethod_0(40), Class15.smethod_0(5), Class15.smethod_0(3), Class15.smethod_0(1)));
    if (this.isFreez)
    {
      if (GClass62.int_8 % Class15.smethod_0(3) == 0)
        GClass47.smethod_0(Class15.smethod_0(76), this.x, this.y, Class15.smethod_0(1));
      long num = GClass126.smethod_18();
      if (num - this.last >= (long) Class15.smethod_0(15))
      {
        this.seconds -= Class15.smethod_0(1);
        this.last = num;
        if (this.seconds < Class15.smethod_0(0))
        {
          this.isFreez = Class15.smethod_0(0) != 0;
          this.seconds = Class15.smethod_0(0);
        }
      }
      this.int_2 = !this.method_30() ? (!this.method_12() ? (!this.method_13() ? (!this.method_11() ? (GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(3) ? Class15.smethod_0(31) : Class15.smethod_0(67)) : (GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(3) ? Class15.smethod_0(9) : Class15.smethod_0(1))) : (GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(3) ? Class15.smethod_0(31) : Class15.smethod_0(67))) : this.attack1[GClass62.int_8 % this.attack1.Length]) : this.hurt[GClass62.int_8 % this.hurt.Length];
    }
    if (!this.method_20())
      return;
    if (this.isShadown)
      this.method_6();
    if (this.vMobMove == null && GClass100.gclass106_0[this.templateId].rangeMove != (sbyte) 0)
      return;
    if (this.status != Class15.smethod_0(5) && this.isBusyAttackSomeOne)
    {
      if (this.cFocus != null)
        this.cFocus.method_108(this.dame, this.dameMp, Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
      else if (this.mobToAttack != null)
        this.mobToAttack.method_9();
      this.isBusyAttackSomeOne = Class15.smethod_0(0) != 0;
    }
    if ((int) this.levelBoss > Class15.smethod_0(0))
      this.method_8();
    switch (this.status - Class15.smethod_0(1))
    {
      case 0:
        this.isDisable = Class15.smethod_0(0) != 0;
        this.isDontMove = Class15.smethod_0(0) != 0;
        this.isFire = Class15.smethod_0(0) != 0;
        this.isIce = Class15.smethod_0(0) != 0;
        this.isWind = Class15.smethod_0(0) != 0;
        this.y += this.p1;
        if (GClass62.int_8 % Class15.smethod_0(7) == 0)
        {
          if (this.p2 > Class15.smethod_0(1))
            this.p2 -= Class15.smethod_0(1);
          else if (this.p2 < -1)
            this.p2 += Class15.smethod_0(1);
        }
        this.x += this.p2;
        this.int_2 = !this.method_30() ? (!this.method_12() ? (!this.method_13() ? (!this.method_11() ? Class15.smethod_0(67) : Class15.smethod_0(9)) : Class15.smethod_0(67)) : this.attack1[GClass62.int_8 % this.attack1.Length]) : this.hurt[GClass62.int_8 % this.hurt.Length];
        if (this.isDie)
        {
          this.isDie = Class15.smethod_0(0) != 0;
          if (this.isMobMe)
          {
            for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
            {
              if (((GClass100) GClass116.gclass134_9.method_3(index)).mobId == this.mobId)
                GClass116.gclass134_9.method_7(index);
            }
          }
          this.p1 = Class15.smethod_0(0);
          this.p2 = Class15.smethod_0(0);
          this.x = this.y = Class15.smethod_0(0);
          this.hp = this.method_18().hp;
          this.status = Class15.smethod_0(0);
          this.timeStatus = Class15.smethod_0(0);
          break;
        }
        if ((GClass185.smethod_26(this.x, this.y) & Class15.smethod_0(7)) == Class15.smethod_0(7))
        {
          this.p1 = this.p1 <= Class15.smethod_0(2) ? -this.p1 : Class15.smethod_0(200);
          if (this.p3 == 0)
            this.p3 = Class15.smethod_0(10);
        }
        else
          this.p1 += Class15.smethod_0(1);
        if (this.p3 <= Class15.smethod_0(0))
          break;
        this.p3 -= Class15.smethod_0(1);
        if (this.p3 != 0)
          break;
        this.isDie = Class15.smethod_0(1) != 0;
        break;
      case 1:
        if (this.holdEffID != 0 || this.isFreez || this.blindEff || this.sleepEff)
          break;
        this.timeStatus = Class15.smethod_0(0);
        this.method_15();
        break;
      case 2:
        if (this.holdEffID != 0 || this.blindEff || this.sleepEff || this.isFreez)
          break;
        this.method_16();
        break;
      case 3:
        if (this.holdEffID != 0 || this.blindEff || this.sleepEff || this.isFreez)
          break;
        this.timeStatus = Class15.smethod_0(0);
        this.p1 += Class15.smethod_0(1);
        if (this.p1 <= Class15.smethod_0(54) + this.mobId % Class15.smethod_0(3))
          break;
        this.y -= Class15.smethod_0(7);
        this.status = Class15.smethod_0(3);
        this.p1 = Class15.smethod_0(0);
        break;
      case 4:
        if (this.holdEffID != 0 || this.blindEff || this.sleepEff)
          break;
        if (this.isFreez)
        {
          if ((int) GClass100.gclass106_0[this.templateId].type != Class15.smethod_0(2))
            break;
          this.int_5 += Class15.smethod_0(1);
          this.int_3 += Class15.smethod_0(1);
          this.int_4 += !this.bool_1 ? Class15.smethod_0(1) : -1;
          if (this.int_3 != Class15.smethod_0(31))
            break;
          this.int_3 = Class15.smethod_0(0);
          this.bool_1 = (this.bool_1 ? 1 : 0) == Class15.smethod_0(0);
          break;
        }
        this.timeStatus = Class15.smethod_0(0);
        this.method_17();
        break;
      case 5:
        this.timeStatus = Class15.smethod_0(0);
        this.p1 += Class15.smethod_0(1);
        this.y += this.p1;
        if (this.y < this.yFirst)
          break;
        this.y = this.yFirst;
        this.p1 = Class15.smethod_0(0);
        this.status = Class15.smethod_0(3);
        break;
      case 6:
        this.method_14();
        break;
    }
  }

  public void method_9()
  {
    if (this.hp <= Class15.smethod_0(0) || this.status == Class15.smethod_0(5))
      return;
    this.timeStatus = Class15.smethod_0(2);
    this.status = Class15.smethod_0(38);
    if ((this.method_18().type == (sbyte) 0 ? 1 : 0) != 0 || GClass151.smethod_25(this.x - this.xFirst) >= Class15.smethod_0(6))
      return;
    this.x -= Class15.smethod_0(31) * this.dir;
  }

  public static GClass104 smethod_1()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
      if ((!(gclass100 is GClass104) ? 1 : 0) == 0)
        return (GClass104) gclass100;
    }
    return (GClass104) null;
  }

  public static GClass102 smethod_2()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
      if ((!(gclass100 is GClass102) ? 1 : 0) == 0)
        return (GClass102) gclass100;
    }
    return (GClass102) null;
  }

  public static GClass101 smethod_3()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
      if ((!(gclass100 is GClass101) ? 1 : 0) == 0)
        return (GClass101) gclass100;
    }
    return (GClass101) null;
  }

  public static GClass103 smethod_4(sbyte idBoss)
  {
    GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3((int) idBoss);
    return (!(gclass100 is GClass103) ? 1 : 0) == 0 ? (GClass103) gclass100 : (GClass103) null;
  }

  public static void smethod_5()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 o = (GClass100) GClass116.gclass134_9.method_3(index);
      if ((!(o is GClass104) ? 1 : 0) == 0)
      {
        GClass116.gclass134_9.method_8((object) o);
        break;
      }
    }
  }

  public void method_10(GClass20 cFocus)
  {
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.mobToAttack = (GClass100) null;
    this.cFocus = cFocus;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_1 = Class15.smethod_0(0);
    this.dir = cFocus.cx > this.x ? Class15.smethod_0(1) : -1;
    int cx = cFocus.cx;
    int cy = cFocus.cy;
    if (GClass151.smethod_25(cx - this.x) < this.w * Class15.smethod_0(7) && GClass151.smethod_25(cy - this.y) < this.h * Class15.smethod_0(7))
    {
      this.x = this.x >= cx ? cx + this.w : cx - this.w;
      this.p3 = Class15.smethod_0(0);
    }
    else
      this.p3 = Class15.smethod_0(1);
  }

  private bool method_11() => (this.templateId < Class15.smethod_0(129) || this.templateId > Class15.smethod_0(130)) && this.templateId != Class15.smethod_0(131) && this.templateId != Class15.smethod_0(11) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  private bool method_12() => this.templateId == Class15.smethod_0(177);

  private bool method_13() => this.templateId >= Class15.smethod_0(184) && (!this.method_12() ? 0 : 1) == 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  private void method_14()
  {
    if ((!this.isBusyAttackSomeOne ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
      this.int_2 = (!this.method_30() ? 1 : 0) != 0 ? ((!this.method_12() ? 1 : 0) != 0 ? ((!this.method_13() ? 1 : 0) != 0 ? ((!this.method_11() ? 1 : 0) != 0 ? (this.int_2 == Class15.smethod_0(31) ? Class15.smethod_0(67) : Class15.smethod_0(31)) : (this.int_2 == Class15.smethod_0(1) ? Class15.smethod_0(9) : Class15.smethod_0(1))) : (this.int_2 == Class15.smethod_0(31) ? Class15.smethod_0(67) : Class15.smethod_0(31))) : this.attack1[GClass62.int_8 % this.attack1.Length]) : this.hurt[GClass62.int_8 % this.hurt.Length];
    this.timeStatus -= Class15.smethod_0(1);
    if (this.timeStatus <= Class15.smethod_0(0) && ((!this.method_30() ? 0 : 1) != 0 || (!this.method_12() ? 0 : 1) != 0 || (!this.method_13() ? 1 : 0) == 0 && this.int_2 == Class15.smethod_0(67) || (!this.method_11() ? 1 : 0) == 0 && this.int_2 == Class15.smethod_0(9) || this.templateId < Class15.smethod_0(129) && this.int_2 == Class15.smethod_0(67)))
    {
      if ((this.injureBy == null ? 1 : 0) == 0 && (!this.injureThenDie ? 0 : 1) != 0 || (this.hp == 0 ? 0 : 1) == 0)
      {
        this.status = Class15.smethod_0(1);
        this.p2 = this.injureBy.cdir << Class15.smethod_0(1);
        this.p1 = Class15.smethod_0(134);
        this.p3 = Class15.smethod_0(0);
      }
      else
      {
        this.status = Class15.smethod_0(3);
        if ((this.injureBy == null ? 1 : 0) == 0)
        {
          this.dir = -this.injureBy.cdir;
          if (GClass151.smethod_25(this.x - this.injureBy.cx) < Class15.smethod_0(40))
            this.status = Class15.smethod_0(7);
        }
        this.p1 = this.p2 = this.p3 = Class15.smethod_0(0);
        this.timeStatus = Class15.smethod_0(0);
      }
      this.injureBy = (GClass20) null;
    }
    else
    {
      if ((GClass100.gclass106_0[this.templateId].type == (sbyte) 0 ? 1 : 0) != 0 || (this.injureBy == null ? 1 : 0) != 0)
        return;
      int num = -this.injureBy.cdir << Class15.smethod_0(1);
      if (this.x <= this.xFirst - (int) GClass100.gclass106_0[this.templateId].rangeMove || this.x >= this.xFirst + (int) GClass100.gclass106_0[this.templateId].rangeMove)
        return;
      this.x -= num;
    }
  }

  private void method_15()
  {
    this.method_5(this.stand);
    sbyte type = GClass100.gclass106_0[this.templateId].type;
    if ((uint) type > (uint) Class15.smethod_0(5))
    {
      if ((uint) type - (uint) Class15.smethod_0(2) <= (uint) Class15.smethod_0(1))
      {
        this.p1 += Class15.smethod_0(1);
        if (this.p1 > this.mobId % Class15.smethod_0(5) && ((this.cFocus == null ? 1 : 0) != 0 || GClass151.smethod_25(this.cFocus.cx - this.x) > Class15.smethod_0(25)) && ((this.mobToAttack == null ? 1 : 0) != 0 || GClass151.smethod_25(this.mobToAttack.x - this.x) > Class15.smethod_0(25)))
          this.status = Class15.smethod_0(3);
      }
    }
    else
    {
      this.p1 += Class15.smethod_0(1);
      if (this.p1 > Class15.smethod_0(31) + this.mobId % Class15.smethod_0(31) && ((this.cFocus == null ? 1 : 0) != 0 || GClass151.smethod_25(this.cFocus.cx - this.x) > Class15.smethod_0(25)) && ((this.mobToAttack == null ? 1 : 0) != 0 || GClass151.smethod_25(this.mobToAttack.x - this.x) > Class15.smethod_0(25)))
        this.status = Class15.smethod_0(3);
    }
    if ((this.cFocus == null ? 1 : 0) == 0 && (GClass62.int_8 % (Class15.smethod_0(31) + this.p1 % Class15.smethod_0(51)) == 0 ? 0 : 1) == 0)
      this.dir = this.cFocus.cx <= this.x ? -1 : Class15.smethod_0(1);
    else if ((this.mobToAttack == null ? 1 : 0) == 0 && (GClass62.int_8 % (Class15.smethod_0(31) + this.p1 % Class15.smethod_0(51)) == 0 ? 0 : 1) == 0)
      this.dir = this.mobToAttack.x <= this.x ? -1 : Class15.smethod_0(1);
    if (this.forceWait <= Class15.smethod_0(0))
      return;
    this.forceWait -= Class15.smethod_0(1);
    this.status = Class15.smethod_0(7);
  }

  public void method_16()
  {
    int[] array = (this.p3 == 0 ? 0 : 1) != 0 ? this.attack2 : this.attack1;
    if (this.int_1 < array.Length)
    {
      this.method_5(array);
      if (this.x >= GClass116.int_22 && this.x <= GClass116.int_22 + GClass62.int_10 && (this.p3 == 0 ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
        GClass172.smethod_1().method_4(Class15.smethod_0(0) != 0, Class15.smethod_2(15));
    }
    if ((this.p1 == 0 ? 0 : 1) == 0)
    {
      Class15.smethod_0(0);
      Class15.smethod_0(0);
      int num1 = (this.cFocus == null ? 1 : 0) != 0 ? this.mobToAttack.x : this.cFocus.cx;
      int num2 = (this.cFocus == null ? 1 : 0) != 0 ? this.mobToAttack.y : this.cFocus.cy;
      if ((!this.method_13() ? 0 : 1) == 0)
      {
        if (this.x > this.xFirst + (int) GClass100.gclass106_0[this.templateId].rangeMove)
          this.p1 = Class15.smethod_0(1);
        if (this.x < this.xFirst - (int) GClass100.gclass106_0[this.templateId].rangeMove)
          this.p1 = Class15.smethod_0(1);
      }
      if (((int) GClass100.gclass106_0[this.templateId].type == Class15.smethod_0(2) || (int) GClass100.gclass106_0[this.templateId].type == Class15.smethod_0(3)) && (!this.isDontMove ? 0 : 1) == 0)
        this.y += (num2 - this.y) / Class15.smethod_0(51);
      this.p2 += Class15.smethod_0(1);
      if (this.p2 > array.Length - Class15.smethod_0(1) || this.p1 == Class15.smethod_0(1))
      {
        this.p1 = Class15.smethod_0(1);
        if ((this.p3 == 0 ? 0 : 1) == 0)
        {
          if ((this.cFocus == null ? 1 : 0) == 0)
            this.cFocus.method_108(this.dame, this.dameMp, Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
          else
            this.mobToAttack.method_9();
          this.isBusyAttackSomeOne = Class15.smethod_0(0) != 0;
        }
        else
        {
          if ((this.cFocus == null ? 1 : 0) == 0)
            GClass46.smethod_0(this.x + this.dir * this.w, this.y, this.method_21(), this.dame, this.dameMp, this.cFocus, (int) this.method_18().dartType);
          else
            GClass46.smethod_0(this.x + this.dir * this.w, this.y, this.method_21(), this.dame, this.dameMp, new GClass20()
            {
              cx = this.mobToAttack.x,
              cy = this.mobToAttack.y,
              charID = Class15.smethod_0(143)
            }, (int) this.method_18().dartType);
          this.isBusyAttackSomeOne = Class15.smethod_0(0) != 0;
        }
      }
      this.dir = this.x < num1 ? Class15.smethod_0(1) : -1;
    }
    else
    {
      if (this.p1 != Class15.smethod_0(1))
        return;
      if ((GClass100.gclass106_0[this.templateId].type == (sbyte) 0 ? 1 : 0) == 0 && (!this.isDontMove ? 0 : 1) == 0 && (!this.isIce ? 0 : 1) == 0 && (!this.isWind ? 0 : 1) == 0)
      {
        this.x += (this.xFirst - this.x) / Class15.smethod_0(2);
        this.y += (this.yFirst - this.y) / Class15.smethod_0(2);
      }
      if (GClass151.smethod_25(this.xFirst - this.x) >= Class15.smethod_0(3) || GClass151.smethod_25(this.yFirst - this.y) >= Class15.smethod_0(3) || this.int_1 != array.Length)
        return;
      this.status = Class15.smethod_0(7);
      this.p1 = Class15.smethod_0(0);
      this.p2 = Class15.smethod_0(0);
      this.int_1 = Class15.smethod_0(0);
    }
  }

  public void method_17()
  {
    int num1 = Class15.smethod_0(0);
    try
    {
      if (this.injureThenDie)
      {
        this.status = Class15.smethod_0(1);
        this.p2 = this.injureBy.cdir << Class15.smethod_0(5);
        this.p1 = Class15.smethod_0(192);
        this.p3 = Class15.smethod_0(0);
      }
      num1 = Class15.smethod_0(1);
      if (this.isIce)
        return;
      if (!this.isDontMove && !this.isWind)
      {
        switch (GClass100.gclass106_0[this.templateId].type)
        {
          case 0:
            this.int_2 = !this.method_12() ? Class15.smethod_0(0) : this.stand[GClass62.int_8 % this.stand.Length];
            Class15.smethod_0(7);
            break;
          case 1:
          case 2:
          case 3:
            num1 = Class15.smethod_0(5);
            sbyte speed = GClass100.gclass106_0[this.templateId].speed;
            if ((int) speed == Class15.smethod_0(1))
            {
              if (GClass62.int_8 % Class15.smethod_0(7) == Class15.smethod_0(1))
                break;
            }
            else if ((int) speed > Class15.smethod_0(7))
              speed += (sbyte) (this.mobId % Class15.smethod_0(7));
            else if (GClass62.int_8 % Class15.smethod_0(7) == Class15.smethod_0(1))
              speed -= (sbyte) Class15.smethod_0(1);
            this.x += (int) speed * this.dir;
            if (this.x > this.xFirst + (int) GClass100.gclass106_0[this.templateId].rangeMove)
              this.dir = -1;
            else if (this.x < this.xFirst - (int) GClass100.gclass106_0[this.templateId].rangeMove)
              this.dir = Class15.smethod_0(1);
            if (GClass151.smethod_25(this.x - GClass20.smethod_1().cx) < Class15.smethod_0(54) && GClass151.smethod_25(this.x - this.xFirst) < (int) GClass100.gclass106_0[this.templateId].rangeMove)
            {
              this.dir = this.x <= GClass20.smethod_1().cx ? Class15.smethod_0(1) : -1;
              if (GClass151.smethod_25(this.x - GClass20.smethod_1().cx) < Class15.smethod_0(51))
                this.x -= this.dir * Class15.smethod_0(31);
              this.status = Class15.smethod_0(7);
              this.forceWait = Class15.smethod_0(51);
            }
            this.method_5(this.w <= Class15.smethod_0(6) ? this.moveFast : this.move);
            break;
          case 4:
            num1 = Class15.smethod_0(2);
            sbyte num2 = (sbyte) ((int) GClass100.gclass106_0[this.templateId].speed + (int) (sbyte) (this.mobId % Class15.smethod_0(7)));
            this.x += (int) num2 * this.dir;
            if (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(7))
              this.y += (int) num2 * this.dirV;
            sbyte num3 = (sbyte) ((int) num2 + (int) (sbyte) ((GClass62.int_8 + this.mobId) % Class15.smethod_0(7)));
            if (this.x > this.xFirst + (int) GClass100.gclass106_0[this.templateId].rangeMove)
            {
              this.dir = -1;
              this.status = Class15.smethod_0(7);
              this.forceWait = GClass62.int_8 % Class15.smethod_0(51) + Class15.smethod_0(51);
              this.p1 = Class15.smethod_0(0);
            }
            else if (this.x < this.xFirst - (int) GClass100.gclass106_0[this.templateId].rangeMove)
            {
              this.dir = Class15.smethod_0(1);
              this.status = Class15.smethod_0(7);
              this.forceWait = GClass62.int_8 % Class15.smethod_0(51) + Class15.smethod_0(51);
              this.p1 = Class15.smethod_0(0);
            }
            if (this.y > this.yFirst + Class15.smethod_0(40))
              this.dirV = -1;
            else if (this.y < this.yFirst - (Class15.smethod_0(51) + GClass62.int_8 % Class15.smethod_0(31)))
              this.dirV = Class15.smethod_0(1);
            this.method_5(this.move);
            break;
          case 5:
            num1 = Class15.smethod_0(3);
            sbyte num4 = (sbyte) ((int) GClass100.gclass106_0[this.templateId].speed + (int) (sbyte) (this.mobId % Class15.smethod_0(7)));
            this.x += (int) num4 * this.dir;
            sbyte num5 = (sbyte) ((int) num4 + (int) (sbyte) ((GClass62.int_8 + this.mobId) % Class15.smethod_0(7)));
            if (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(7))
              this.y += (int) num5 * this.dirV;
            if (this.x > this.xFirst + (int) GClass100.gclass106_0[this.templateId].rangeMove)
            {
              this.dir = -1;
              this.status = Class15.smethod_0(7);
              this.forceWait = GClass62.int_8 % Class15.smethod_0(51) + Class15.smethod_0(51);
              this.p1 = Class15.smethod_0(0);
            }
            else if (this.x < this.xFirst - (int) GClass100.gclass106_0[this.templateId].rangeMove)
            {
              this.dir = Class15.smethod_0(1);
              this.status = Class15.smethod_0(7);
              this.forceWait = GClass62.int_8 % Class15.smethod_0(51) + Class15.smethod_0(51);
              this.p1 = Class15.smethod_0(0);
            }
            if (this.y > this.yFirst + Class15.smethod_0(40))
              this.dirV = -1;
            else if (this.y < this.yFirst - (Class15.smethod_0(51) + GClass62.int_8 % Class15.smethod_0(31)))
              this.dirV = Class15.smethod_0(1);
            if (!GClass185.smethod_27(this.x, this.y, Class15.smethod_0(7)))
              break;
            if (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3))
            {
              this.y = GClass185.smethod_31(this.y);
              this.status = Class15.smethod_0(2);
              this.p1 = Class15.smethod_0(0);
              this.dirV = -1;
              break;
            }
            this.dirV = -1;
            break;
        }
      }
      else
        this.method_5(this.stand);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(153231) + num1.ToString());
    }
  }

  public GClass106 method_18() => GClass100.gclass106_0[this.templateId];

  public bool method_19()
  {
    if (this.x < GClass116.int_22)
      return Class15.smethod_0(0) != 0;
    if (this.x > GClass116.int_22 + GClass116.int_6)
      return Class15.smethod_0(0) != 0;
    if (this.y < GClass116.int_23)
      return Class15.smethod_0(0) != 0;
    if (this.y > GClass116.int_23 + GClass116.int_7 + Class15.smethod_0(6))
      return Class15.smethod_0(0) != 0;
    if ((GClass100.gclass106_0[this.templateId] == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if ((GClass100.gclass106_0[this.templateId].data == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if ((GClass100.gclass106_0[this.templateId].data.img == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    return (this.status == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public bool method_20()
  {
    if ((GClass100.gclass106_0[this.templateId] == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if ((GClass100.gclass106_0[this.templateId].data == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    return (this.status == 0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public bool method_21() => (!this.isBoss ? 0 : 1) == 0 && (int) this.levelBoss <= Class15.smethod_0(0) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public void method_22()
  {
    this.len = (int) ((long) this.hp * (long) Class15.smethod_0(21) / (long) this.maxHp * (long) this.w_hp_bar) / Class15.smethod_0(21);
    this.per = (int) ((long) this.hp * (long) Class15.smethod_0(21) / (long) this.maxHp);
    if (this.per == Class15.smethod_0(21))
      this.per_tem = this.per;
    if (this.per >= Class15.smethod_0(21))
      this.per_tem = this.per;
    this.int_7 = Class15.smethod_0(0);
    if (this.per < Class15.smethod_0(6))
    {
      this.int_6 = Class15.smethod_0(429);
      this.imgHPtem = GClass116.gclass66_35;
    }
    else if (this.per < Class15.smethod_0(4))
    {
      this.int_6 = Class15.smethod_0(430);
      this.imgHPtem = GClass116.gclass66_36;
    }
    else
    {
      this.int_6 = Class15.smethod_0(431);
      this.imgHPtem = GClass116.gclass66_38;
    }
  }

  public virtual void vmethod_1(GClass98 g)
  {
    if ((!this.isShadown ? 1 : 0) == 0 && (this.status == 0 ? 1 : 0) == 0)
      this.method_7(g);
    if ((!this.method_19() ? 1 : 0) != 0 || this.status == Class15.smethod_0(1) && this.p3 > Class15.smethod_0(0) && (GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
      return;
    g.method_1(Class15.smethod_0(0), GClass62.int_52);
    if ((!this.changBody ? 0 : 1) == 0)
      GClass100.gclass106_0[this.templateId].data.method_9(g, this.int_2, this.x, this.y + this.int_4, this.dir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(7));
    else
      GClass169.smethod_6(g, (int) this.smallBody, this.x, this.y + this.int_4 - Class15.smethod_0(49), Class15.smethod_0(0), Class15.smethod_0(5));
    g.method_1(Class15.smethod_0(0), -GClass62.int_52);
    if ((GClass20.smethod_1().mobFocus == null ? 1 : 0) != 0 || (!GClass20.smethod_1().mobFocus.Equals((object) this) ? 1 : 0) != 0 || this.status == Class15.smethod_0(1) || this.hp <= Class15.smethod_0(0) || (this.imgHPtem == null ? 0 : 1) == 0)
      return;
    int num1 = GClass98.smethod_0(this.imgHPtem);
    int h0 = GClass98.smethod_1(this.imgHPtem);
    int w0 = num1 * this.per / Class15.smethod_0(21);
    int w = w0;
    if (this.per_tem >= this.per)
    {
      int num2 = num1;
      int perTem = this.per_tem;
      int num3;
      if (GClass62.int_8 % Class15.smethod_0(37) > Class15.smethod_0(5))
      {
        int int7 = this.int_7;
        this.int_7 = int7 + Class15.smethod_0(1);
        num3 = int7;
      }
      else
        num3 = this.int_7;
      int num4 = this.per_tem = perTem - num3;
      w = num2 * num4 / Class15.smethod_0(21);
      if (this.per_tem <= Class15.smethod_0(0))
        this.per_tem = Class15.smethod_0(0);
      if (this.per_tem < this.per)
        this.per_tem = this.per;
      if (this.int_7 >= Class15.smethod_0(5))
        this.int_7 = Class15.smethod_0(5);
    }
    g.method_32(GClass116.gclass66_37, this.x - (num1 >> Class15.smethod_0(1)), this.y - this.h - Class15.smethod_0(3), GClass98.int_4 | GClass98.int_2);
    g.method_16(Class15.smethod_0(142));
    g.method_15(this.x - (num1 >> Class15.smethod_0(1)), this.y - this.h - Class15.smethod_0(3), w, Class15.smethod_0(7));
    g.method_24(this.imgHPtem, Class15.smethod_0(0), Class15.smethod_0(0), w0, h0, Class15.smethod_0(0), this.x - (num1 >> Class15.smethod_0(1)), this.y - this.h - Class15.smethod_0(3), GClass98.int_4 | GClass98.int_2);
  }

  public int method_23() => Class15.smethod_0(133);

  public void method_24()
  {
    this.cTimeDie = GClass126.smethod_18();
    this.hp = Class15.smethod_0(0);
    this.injureThenDie = Class15.smethod_0(1) != 0;
    this.hp = Class15.smethod_0(0);
    this.status = Class15.smethod_0(1);
    GClass151.smethod_7(Class13.smethod_0(153659));
    this.p1 = Class15.smethod_0(134);
    this.p2 = -this.dir;
    this.p3 = Class15.smethod_0(0);
  }

  public void method_25(GClass100 mobToAttack)
  {
    this.mobToAttack = mobToAttack;
    this.isBusyAttackSomeOne = Class15.smethod_0(1) != 0;
    this.cFocus = (GClass20) null;
    this.p1 = Class15.smethod_0(0);
    this.p2 = Class15.smethod_0(0);
    this.status = Class15.smethod_0(5);
    this.int_1 = Class15.smethod_0(0);
    this.dir = mobToAttack.x > this.x ? Class15.smethod_0(1) : -1;
    int x = mobToAttack.x;
    int y = mobToAttack.y;
    if (GClass151.smethod_25(x - this.x) < this.w * Class15.smethod_0(7) && GClass151.smethod_25(y - this.y) < this.h * Class15.smethod_0(7))
    {
      this.x = this.x >= x ? x + this.w : x - this.w;
      this.p3 = Class15.smethod_0(0);
    }
    else
      this.p3 = Class15.smethod_0(1);
  }

  public int imethod_0() => this.x;

  public int imethod_1() => this.y;

  public int imethod_3() => this.h;

  public int imethod_2() => this.w;

  public void imethod_4()
  {
    if (this.status != Class15.smethod_0(3))
      return;
    this.status = Class15.smethod_0(7);
    this.p1 = this.p2 = this.p3 = Class15.smethod_0(0);
    this.forceWait = Class15.smethod_0(32);
  }

  public bool imethod_5() => (this.status == 0 ? 1 : 0) == 0 ? this.status == Class15.smethod_0(1) : Class15.smethod_0(1) != 0;

  public void method_26()
  {
    if ((this.holdEffID == 0 ? 1 : 0) != 0)
      return;
    this.holdEffID = Class15.smethod_0(0);
  }

  public void method_27() => this.blindEff = Class15.smethod_0(0) != 0;

  public void method_28() => this.sleepEff = Class15.smethod_0(0) != 0;

  public void method_29()
  {
    if ((!this.bool_2 ? 1 : 0) != 0 || (!this.method_30() ? 1 : 0) != 0 || (GClass100.gclass106_0[this.templateId].data == null ? 1 : 0) != 0)
      return;
    this.int_8 = (int[][]) GClass32.gclass128_0.method_0((object) (this.templateId.ToString() + string.Empty));
    this.stand = this.int_8[Class15.smethod_0(0)];
    this.move = this.int_8[Class15.smethod_0(1)];
    this.moveFast = this.int_8[Class15.smethod_0(7)];
    this.attack1 = this.int_8[Class15.smethod_0(5)];
    this.attack2 = this.int_8[Class15.smethod_0(2)];
    this.hurt = this.int_8[Class15.smethod_0(3)];
    this.bool_2 = Class15.smethod_0(0) != 0;
  }

  private bool method_30() => (GClass100.gclass106_0[this.templateId].data == null ? 1 : 0) == 0 && GClass100.gclass106_0[this.templateId].data.typeData == Class15.smethod_0(7) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
}
