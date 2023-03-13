// Decompiled with JetBrains decompiler
// Type: GClass20
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass20 : GInterface3
{
  public string xuStr;
  public string luongStr;
  public string luongKhoaStr;
  public long lastUpdateTime;
  public bool meLive;
  public bool isMask;
  public bool isTeleport;
  public bool isUsePlane;
  public int shadowX;
  public int shadowY;
  public int shadowLife;
  public bool isNhapThe;
  public GClass191 petFollow;
  public int rank;
  public const sbyte sbyte_0 = 1;
  public const sbyte sbyte_1 = 2;
  public const sbyte sbyte_2 = 3;
  public const sbyte sbyte_3 = 4;
  public const sbyte sbyte_4 = 5;
  public const sbyte sbyte_5 = 6;
  public const sbyte sbyte_6 = 7;
  public const sbyte sbyte_7 = 8;
  public const sbyte sbyte_8 = 9;
  public const sbyte sbyte_9 = 10;
  public const sbyte sbyte_10 = 12;
  public const sbyte sbyte_11 = 13;
  public const sbyte sbyte_12 = 14;
  public const sbyte sbyte_13 = 15;
  public const sbyte sbyte_14 = 16;
  public static GClass43 gclass43_0;
  public long cPower;
  public GClass70 chatInfo;
  public sbyte petStatus;
  public int cx;
  public int cy;
  public int cvx;
  public int cvy;
  public int cp1;
  public int cp2;
  public int cp3;
  public int statusMe;
  public int cdir;
  public int charID;
  public int cgender;
  public int ctaskId;
  public int menuSelect;
  public int cBonusSpeed;
  public int cspeed;
  public int ccurrentAttack;
  public int cDamFull;
  public int cDefull;
  public int cCriticalFull;
  public int clevel;
  public int cMP;
  public int cHP;
  public int cHPNew;
  public int cMaxEXP;
  public int cHPShow;
  public int xReload;
  public int yReload;
  public int cyStartFall;
  public int saveStatus;
  public int eff5BuffHp;
  public int eff5BuffMp;
  public int cHPFull;
  public int cMPFull;
  public int cdameDown;
  public int cStr;
  public long cLevelPercent;
  public long cTiemNang;
  public long cNangdong;
  public int damHP;
  public int damMP;
  public bool isMob;
  public bool isCrit;
  public bool isDie;
  public int pointUydanh;
  public int pointNon;
  public int pointVukhi;
  public int pointAo;
  public int pointLien;
  public int pointGangtay;
  public int pointNhan;
  public int pointQuan;
  public int pointNgocboi;
  public int pointGiay;
  public int pointPhu;
  public int countFinishDay;
  public int countLoopBoos;
  public int limitTiemnangso;
  public int limitKynangso;
  public short[] potential;
  public string cName;
  public int clanID;
  public sbyte ctypeClan;
  public GClass25 clan;
  public sbyte role;
  public int cw;
  public int ch;
  public int chw;
  public int chh;
  public GClass31 cmdMenu;
  public bool canFly;
  public bool cmtoChar;
  public bool me;
  public bool cFinishedAttack;
  public bool cchistlast;
  public bool isAttack;
  public bool isAttFly;
  public int cwpt;
  public int cwplv;
  public int cf;
  public int tick;
  public static bool bool_0;
  public bool isJump;
  public bool autoFall;
  public bool attack;
  public long xu;
  public int xuInBox;
  public int yen;
  public int gold_lock;
  public int luong;
  public int luongKhoa;
  public GClass137 nClass;
  public GClass31 endMovePointCommand;
  public GClass134 vSkill;
  public GClass134 vSkillFight;
  public GClass134 vEff;
  public GClass161 myskill;
  public GClass179 taskMaint;
  public bool paintName;
  public GClass0[] arrArchive;
  public GClass80[] arrItemBag;
  public GClass80[] arrItemBox;
  public GClass80[] arrItemBody;
  public GClass161[] arrPetSkill;
  public GClass80[][] arrItemShop;
  public string[][] infoSpeacialSkill;
  public short[][] imgSpeacialSkill;
  public short cResFire;
  public short cResIce;
  public short cResWind;
  public short cMiss;
  public short cExactly;
  public short cFatal;
  public sbyte cPk;
  public sbyte cTypePk;
  public short cReactDame;
  public short sysUp;
  public short sysDown;
  public int avatar;
  public int skillTemplateId;
  public GClass100 mobFocus;
  public GClass100 mobMe;
  public int tMobMeBorn;
  public GClass21 npcFocus;
  public GClass20 charFocus;
  public GClass81 itemFocus;
  public GClass134 focus;
  public GClass100[] attMobs;
  public GClass20[] attChars;
  public short[] moveFast;
  public int testCharId;
  public int killCharId;
  public sbyte resultTest;
  public int countKill;
  public int countKillMax;
  public bool isInvisiblez;
  public bool isShadown;
  public const sbyte sbyte_15 = 0;
  public const sbyte sbyte_16 = 1;
  public const sbyte sbyte_17 = 2;
  public const sbyte sbyte_18 = 3;
  public const sbyte sbyte_19 = 4;
  public const sbyte sbyte_20 = 5;
  public GClass134 taskOrders;
  public int cStamina;
  public static short[] short_0;
  public static short[] short_1;
  public int exp;
  public string[] strLevel;
  public string currStrLevel;
  public static GClass66 gclass66_0 = GClass62.smethod_40(Class13.smethod_0(136003));
  public static GClass66 gclass66_1 = GClass62.smethod_40(Class13.smethod_0(136092));
  public bool isFreez;
  public bool isCharge;
  public int seconds;
  public int freezSeconds;
  public long last;
  public long cur;
  public long lastFreez;
  public long currFreez;
  public bool isFlyUp;
  public static GClass134 gclass134_0 = new GClass134();
  public static short short_2 = (short) Class15.smethod_0(115);
  public short idMount;
  public bool isHaveMount;
  public bool isMountVip;
  public bool isEventMount;
  public bool isSpeacialMount;
  public static GClass66 gclass66_2 = GClass62.smethod_40(Class13.smethod_0(136177));
  public static GClass66 gclass66_3 = GClass62.smethod_40(Class13.smethod_0(136141));
  public static GClass66 gclass66_4 = GClass62.smethod_40(Class13.smethod_0(135721));
  public static GClass66 gclass66_5 = GClass62.smethod_40(Class13.smethod_0(135685));
  public static GClass66 gclass66_6 = GClass62.smethod_40(Class13.smethod_0(135777));
  public static GClass66 gclass66_7 = GClass62.smethod_40(Class13.smethod_0(135869));
  public static GClass66 gclass66_8 = GClass62.smethod_40(Class13.smethod_0(135833));
  public static GClass66 gclass66_9 = GClass62.smethod_40(Class13.smethod_0(135925));
  public static GClass66 gclass66_10 = GClass62.smethod_40(Class13.smethod_0(136509));
  public static GClass66 gclass66_11 = GClass62.smethod_40(Class13.smethod_0(136478));
  public sbyte[] FrameMount;
  public int frameMount;
  public int frameNewMount;
  public int transMount;
  public int genderMount;
  public int idcharMount;
  public int xMount;
  public int yMount;
  public int dxMount;
  public int dyMount;
  public int xChar;
  public int xdis;
  public int speedMount;
  public bool isStartMount;
  public bool isMount;
  public bool isEndMount;
  public sbyte cFlag;
  public int flagImage;
  public short x_hint;
  public short y_hint;
  public static int[][][] int_0;
  public static int[] int_1;
  public static int[] int_2;
  private static GClass20 gclass20_0;
  private static GClass20 gclass20_1;
  public static int[] int_3;
  public static int[][] int_4;
  public int cvyJump;
  private int int_5;
  public int cxSend;
  public int cySend;
  public int cdirSend;
  public int cxFocus;
  public int cyFocus;
  public int cactFirst;
  public GClass134 vMovePoints;
  public static string[][] string_0;
  public static int[][] int_6;
  public static bool bool_1;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  public bool isLockMove;
  public bool isLockAttack;
  public string strInfo;
  public short powerPoint;
  public short maxPowerPoint;
  public short secondPower;
  public long lastS;
  public long currS;
  public bool havePet;
  public GClass108 currentMovePoint;
  public int bom;
  public int delayFall;
  private bool bool_5;
  public int lastFrame;
  private GClass41 gclass41_0;
  private int int_7;
  public bool isInjureHp;
  public bool changePos;
  private bool bool_6;
  private bool bool_7;
  public int wt;
  public int fy;
  public int ty;
  private int int_8;
  private int int_9;
  public int[] move;
  private string string_1;
  public int headICON;
  public int head;
  public int leg;
  public int body;
  public int bag;
  public int wp;
  public int indexEff;
  public int indexEffTask;
  public GClass49 eff;
  public GClass49 effTask;
  public int indexSkill;
  public int i0;
  public int i1;
  public int i2;
  public int dx0;
  public int dx1;
  public int dx2;
  public int dy0;
  public int dy1;
  public int dy2;
  public GClass49 eff0;
  public GClass49 eff1;
  public GClass49 eff2;
  public GClass2 arr;
  public GClass145 dart;
  public bool isCreateDark;
  public GClass165 skillPaint;
  public GClass165 skillPaintRandomPaint;
  public GClass52[] effPaints;
  public int sType;
  public sbyte isInjure;
  public bool isUseSkillAfterCharge;
  public bool isFlyAndCharge;
  public bool isStandAndCharge;
  private bool bool_8;
  public int posDisY;
  private int int_10;
  private bool bool_9;
  public bool isMabuHold;
  private long long_0;
  private int int_11;
  private bool bool_10;
  private bool bool_11;
  public int len;
  public int w_hp_bar;
  private int int_12;
  private int int_13;
  private GClass66 gclass66_12;
  public bool isPet;
  public bool isMiniPet;
  public int xSd;
  public int ySd;
  private bool bool_12;
  private int int_14;
  private GClass142 gclass142_0;
  private GClass142 gclass142_1;
  private GClass142 gclass142_2;
  public int cH_new;
  private int int_15;
  private int int_16;
  public static bool bool_13;
  private GClass20 gclass20_2;
  private GClass100 gclass100_0;
  private int int_17;
  public short wdx;
  public short wdy;
  public bool isDirtyPostion;
  public GClass161 lastNormalSkill;
  public bool currentFireByShortcut;
  public int cDamGoc;
  public int cHPGoc;
  public int cMPGoc;
  public int cDefGoc;
  public int cCriticalGoc;
  public sbyte hpFrom1000TiemNang;
  public sbyte mpFrom1000TiemNang;
  public sbyte damFrom1000TiemNang;
  public sbyte defFrom1000TiemNang;
  public sbyte criticalFrom1000Tiemnang;
  public short cMaxStamina;
  public short expForOneAdd;
  public sbyte isMonkey;
  public bool isCopy;
  public bool isWaitMonkey;
  private bool bool_14;
  public bool meDead;
  public int holdEffID;
  public bool holder;
  public bool protectEff;
  private bool bool_15;
  private int int_18;
  private short short_3;
  private short short_4;
  private sbyte sbyte_21;
  private bool bool_16;
  public bool isFusion;
  public int tFusion;
  public bool huytSao;
  public bool blindEff;
  public bool telePortSkill;
  public bool sleepEff;
  public bool stone;
  public int perCentMp;
  public int dHP;
  public int headTemp;
  public int bodyTemp;
  public int legTemp;
  public int bagTemp;
  public int wpTemp;
  public GClass134 vEffChar;
  public static GClass60 gclass60_0;
  private int int_19;
  private bool bool_17;
  private long long_1;
  private int[] int_20;
  private int[] int_21;
  private int[] int_22;
  public static int[][] int_23;
  private int int_24;
  private string string_2;
  public short idAuraEff;
  public static bool bool_18;
  public static bool bool_19;
  private GClass60 gclass60_1;
  private GClass60 gclass60_2;
  private string string_3;
  public short idEff_Set_Item;
  private GClass60 gclass60_3;
  private GClass60 gclass60_4;
  private GClass60 gclass60_5;
  private GClass60 gclass60_6;
  private string string_4;
  private string string_5;
  private string string_6;
  public short idHat;
  public static int[][] int_25;
  public bool isNrd;
  public int timeNRD;
  public long currentTimeNRD;
  public bool isBlind;

  public GClass20()
  {
    sbyte[] numArray = new sbyte[Class15.smethod_0(88)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) numArray, __fieldref (Class12.long_0));
    this.FrameMount = numArray;
    this.int_5 = -1;
    this.cdirSend = Class15.smethod_0(1);
    this.cactFirst = Class15.smethod_0(3);
    this.vMovePoints = new GClass134();
    this.havePet = Class15.smethod_0(1) != 0;
    byte[] byte_0_1 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.pmUfMStrXCdL));
    this.move = (int[]) Class15.smethod_4(byte_0_1);
    this.string_1 = Class13.smethod_0(31366);
    this.headICON = -1;
    this.indexEff = -1;
    this.indexEffTask = -1;
    this.len = Class15.smethod_0(40);
    this.w_hp_bar = Class15.smethod_0(40);
    this.int_12 = Class15.smethod_0(21);
    this.int_13 = Class15.smethod_0(21);
    this.cH_new = Class15.smethod_0(120);
    this.defFrom1000TiemNang = (sbyte) Class15.smethod_0(1);
    this.criticalFrom1000Tiemnang = (sbyte) Class15.smethod_0(1);
    this.perCentMp = Class15.smethod_0(21);
    this.headTemp = -1;
    this.bodyTemp = -1;
    this.legTemp = -1;
    this.bagTemp = -1;
    this.wpTemp = -1;
    this.vEffChar = new GClass134(Class13.smethod_0(31480));
    byte[] byte_0_2 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.YqfVvsigXrPw));
    this.int_20 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.guSnutIXHUpj));
    this.int_21 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.XtssTKOFJJIV));
    this.int_22 = (int[]) Class15.smethod_4(byte_0_4);
    this.string_2 = Class13.smethod_0(31475);
    this.idAuraEff = (short) -1;
    this.string_3 = Class13.smethod_0(31469);
    this.idEff_Set_Item = (short) -1;
    this.string_4 = Class13.smethod_0(31460);
    this.string_5 = Class13.smethod_0(31427);
    this.string_6 = Class13.smethod_0(32056);
    this.idHat = (short) -1;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.statusMe = Class15.smethod_0(37);
  }

  public void method_0()
  {
    try
    {
      long num1 = (long) Class15.smethod_0(1);
      long num2 = (long) Class15.smethod_0(0);
      int num3 = Class15.smethod_0(0);
      for (int index = GClass116.long_0.Length - Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      {
        if (this.cPower >= GClass116.long_0[index])
        {
          num1 = index != GClass116.long_0.Length - Class15.smethod_0(1) ? GClass116.long_0[index + Class15.smethod_0(1)] - GClass116.long_0[index] : (long) Class15.smethod_0(1);
          num2 = this.cPower - GClass116.long_0[index];
          num3 = index;
          break;
        }
      }
      this.clevel = num3;
      this.cLevelPercent = (long) (int) (num2 * (long) Class15.smethod_0(181) / num1);
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(32001) + ex.ToString());
    }
  }

  public int method_1() => (this.myskill == null ? 1 : 0) == 0 ? this.myskill.dx : Class15.smethod_0(0);

  public int method_2() => (this.myskill == null ? 1 : 0) == 0 ? this.myskill.dy : Class15.smethod_0(0);

  public static void smethod_0(bool isNextStep)
  {
    GClass179 taskMaint = GClass20.smethod_1().taskMaint;
    if (taskMaint.index > taskMaint.contentInfo.Length - Class15.smethod_0(1))
      taskMaint.index = taskMaint.contentInfo.Length - Class15.smethod_0(1);
    string str = taskMaint.contentInfo[taskMaint.index];
    if ((str == null ? 1 : 0) == 0 && (!str.Equals(string.Empty) ? 0 : 1) == 0)
    {
      if ((!str.StartsWith(Class13.smethod_0(24775)) ? 1 : 0) == 0)
      {
        string strNext = GClass138.smethod_4(str, Class13.smethod_0(24775), string.Empty);
        GClass21 next = new GClass21(Class15.smethod_0(3), Class15.smethod_0(0), Class15.smethod_0(143), Class15.smethod_0(143), Class15.smethod_0(3), GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(7)]);
        next.cx = next.cy = Class15.smethod_0(143);
        next.avatar = GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(7)];
        next.charID = Class15.smethod_0(3);
        if (GClass62.gclass113_0 == GClass116.gclass116_0)
          GClass43.smethod_0(strNext, next);
      }
      else if ((!isNextStep ? 1 : 0) == 0)
        GClass116.gclass73_0.method_7(str, Class15.smethod_0(0));
    }
    GClass116.bool_16 = Class15.smethod_0(1) != 0;
    GClass33.smethod_0(Class13.smethod_0(25404) + GClass20.smethod_1().taskMaint.taskId.ToString());
    GClass20.smethod_1().canFly = (int) GClass20.smethod_1().taskMaint.taskId > Class15.smethod_0(7) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
    GClass116.smethod_6().left = (GClass31) null;
    if ((taskMaint.taskId == (short) 0 ? 0 : 1) == 0)
    {
      GClass65.bool_2 = Class15.smethod_0(0) != 0;
      GClass65.bool_4 = Class15.smethod_0(0) != 0;
      GClass116.smethod_6().right = (GClass31) null;
      GClass116.bool_16 = Class15.smethod_0(0) != 0;
      GClass116.smethod_6().left = (GClass31) null;
      if (taskMaint.index < Class15.smethod_0(2))
      {
        GClass22.bool_21 = Class15.smethod_0(0) != 0;
        GClass116.int_87 = -1;
      }
      if (taskMaint.index == Class15.smethod_0(2))
      {
        GClass116.int_87 = Class15.smethod_0(1);
        GClass22.bool_21 = Class15.smethod_0(1) != 0;
      }
      if (taskMaint.index >= Class15.smethod_0(3))
        GClass116.smethod_6().right = GClass116.smethod_6().cmdFocus;
    }
    if ((int) taskMaint.taskId == Class15.smethod_0(1))
      GClass116.bool_16 = Class15.smethod_0(1) != 0;
    if ((int) taskMaint.taskId >= Class15.smethod_0(1))
    {
      GClass116.smethod_6().right = GClass116.smethod_6().cmdFocus;
      GClass116.smethod_6().left = GClass116.smethod_6().cmdMenu;
    }
    GClass141.bool_11 = (int) taskMaint.taskId < Class15.smethod_0(0) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    GClass62.gclass141_0.mainTabName = (int) taskMaint.taskId >= Class15.smethod_0(66) ? GClass109.string_103 : GClass109.string_102;
    GClass62.gclass141_0.tabName[Class15.smethod_0(0)] = GClass62.gclass141_0.mainTabName;
    if ((int) GClass20.gclass20_0.taskMaint.taskId <= Class15.smethod_0(31))
      return;
    GClass152.smethod_4(Class13.smethod_0(25365), Class13.smethod_0(25456));
  }

  public string method_3()
  {
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = this.strLevel[this.clevel];
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(25110);
    strArray[Class15.smethod_0(7)] = (this.cLevelPercent / (long) Class15.smethod_0(21)).ToString();
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(25190);
    strArray[Class15.smethod_0(2)] = (this.cLevelPercent % (long) Class15.smethod_0(21)).ToString();
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(27008);
    return string.Concat(strArray);
  }

  public int method_4() => this.method_5(this.head);

  public int method_5(int headId)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.short_0.Length; index += Class15.smethod_0(1))
    {
      if (headId == (int) GClass20.short_0[index])
        return (int) GClass20.short_1[index];
    }
    return -1;
  }

  public void method_6(string info, short p, short maxP, short sc)
  {
    this.powerPoint = p;
    this.strInfo = info;
    this.maxPowerPoint = maxP;
    this.secondPower = sc;
    this.lastS = this.currS = GClass126.smethod_18();
  }

  public void method_7(string info)
  {
    if ((this.chatInfo == null ? 0 : 1) == 0)
      this.chatInfo = new GClass70();
    GClass20 cInfo = (GClass20) null;
    this.chatInfo.method_4(info, Class15.smethod_0(0), cInfo, Class15.smethod_0(0) != 0);
  }

  public int method_8()
  {
    if (this.nClass.classId == Class15.smethod_0(1) || this.nClass.classId == Class15.smethod_0(7))
      return Class15.smethod_0(1);
    if (this.nClass.classId == Class15.smethod_0(5) || this.nClass.classId == Class15.smethod_0(2))
      return Class15.smethod_0(7);
    return this.nClass.classId != Class15.smethod_0(3) && this.nClass.classId != Class15.smethod_0(37) ? Class15.smethod_0(0) : Class15.smethod_0(5);
  }

  public static GClass20 smethod_1()
  {
    if ((GClass20.gclass20_0 == null ? 0 : 1) == 0)
    {
      GClass20.gclass20_0 = new GClass20();
      GClass20.gclass20_0.me = Class15.smethod_0(1) != 0;
      GClass20.gclass20_0.cmtoChar = Class15.smethod_0(1) != 0;
    }
    return GClass20.gclass20_0;
  }

  public static GClass20 smethod_2()
  {
    if ((GClass20.gclass20_1 == null ? 0 : 1) == 0)
    {
      GClass20.gclass20_1 = new GClass20();
      GClass20.gclass20_1.me = Class15.smethod_0(0) != 0;
    }
    return GClass20.gclass20_1;
  }

  public static void smethod_3() => GClass20.gclass20_0 = (GClass20) null;

  public void method_9()
  {
    try
    {
      GClass134 gclass134 = new GClass134();
      for (int index = Class15.smethod_0(0); index < this.arrItemBag.Length; index += Class15.smethod_0(1))
      {
        GClass80 o = this.arrItemBag[index];
        if ((o == null ? 1 : 0) == 0 && (!o.template.isUpToUp ? 1 : 0) == 0 && (!o.isExpires ? 0 : 1) == 0)
          gclass134.method_0((object) o);
      }
      for (int index1 = Class15.smethod_0(0); index1 < gclass134.method_2(); index1 += Class15.smethod_0(1))
      {
        GClass80 gclass80_1 = (GClass80) gclass134.method_3(index1);
        if ((gclass80_1 == null ? 1 : 0) == 0)
        {
          for (int index2 = index1 + Class15.smethod_0(1); index2 < gclass134.method_2(); index2 += Class15.smethod_0(1))
          {
            GClass80 gclass80_2 = (GClass80) gclass134.method_3(index2);
            if ((gclass80_2 == null ? 1 : 0) == 0 && (!gclass80_1.template.Equals((object) gclass80_2.template) ? 1 : 0) == 0 && gclass80_1.isLock == gclass80_2.isLock)
            {
              gclass80_1.quantity += gclass80_2.quantity;
              this.arrItemBag[gclass80_2.indexUI] = (GClass80) null;
              gclass134.method_5((object) null, index2);
            }
          }
        }
      }
      for (int index3 = Class15.smethod_0(0); index3 < this.arrItemBag.Length; index3 += Class15.smethod_0(1))
      {
        if ((this.arrItemBag[index3] == null ? 1 : 0) == 0)
        {
          for (int index4 = Class15.smethod_0(0); index4 <= index3; index4 += Class15.smethod_0(1))
          {
            if ((this.arrItemBag[index4] == null ? 0 : 1) == 0)
            {
              this.arrItemBag[index4] = this.arrItemBag[index3];
              this.arrItemBag[index4].indexUI = index4;
              this.arrItemBag[index3] = (GClass80) null;
              break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(28066));
    }
  }

  public void method_10()
  {
    try
    {
      GClass134 gclass134 = new GClass134();
      for (int index = Class15.smethod_0(0); index < this.arrItemBox.Length; index += Class15.smethod_0(1))
      {
        GClass80 o = this.arrItemBox[index];
        if ((o == null ? 1 : 0) == 0 && (!o.template.isUpToUp ? 1 : 0) == 0 && (!o.isExpires ? 0 : 1) == 0)
          gclass134.method_0((object) o);
      }
      for (int index1 = Class15.smethod_0(0); index1 < gclass134.method_2(); index1 += Class15.smethod_0(1))
      {
        GClass80 gclass80_1 = (GClass80) gclass134.method_3(index1);
        if ((gclass80_1 == null ? 1 : 0) == 0)
        {
          for (int index2 = index1 + Class15.smethod_0(1); index2 < gclass134.method_2(); index2 += Class15.smethod_0(1))
          {
            GClass80 gclass80_2 = (GClass80) gclass134.method_3(index2);
            if ((gclass80_2 == null ? 1 : 0) == 0 && (!gclass80_1.template.Equals((object) gclass80_2.template) ? 1 : 0) == 0 && gclass80_1.isLock == gclass80_2.isLock)
            {
              gclass80_1.quantity += gclass80_2.quantity;
              this.arrItemBox[gclass80_2.indexUI] = (GClass80) null;
              gclass134.method_5((object) null, index2);
            }
          }
        }
      }
      for (int index3 = Class15.smethod_0(0); index3 < this.arrItemBox.Length; index3 += Class15.smethod_0(1))
      {
        if ((this.arrItemBox[index3] == null ? 1 : 0) == 0)
        {
          for (int index4 = Class15.smethod_0(0); index4 <= index3; index4 += Class15.smethod_0(1))
          {
            if ((this.arrItemBox[index4] == null ? 0 : 1) == 0)
            {
              this.arrItemBox[index4] = this.arrItemBox[index3];
              this.arrItemBox[index4].indexUI = index4;
              this.arrItemBox[index3] = (GClass80) null;
              break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(27825));
    }
  }

  public void method_11(int indexUI)
  {
    GClass80 gclass80_1 = this.arrItemBag[indexUI];
    if ((!gclass80_1.method_7() ? 0 : 1) == 0)
      return;
    gclass80_1.isLock = Class15.smethod_0(1) != 0;
    gclass80_1.typeUI = Class15.smethod_0(3);
    GClass80 gclass80_2 = this.arrItemBody[(int) gclass80_1.template.type];
    this.arrItemBag[indexUI] = (GClass80) null;
    if ((gclass80_2 == null ? 1 : 0) == 0)
    {
      gclass80_2.typeUI = Class15.smethod_0(5);
      this.arrItemBody[(int) gclass80_1.template.type] = (GClass80) null;
      gclass80_2.indexUI = indexUI;
      this.arrItemBag[indexUI] = gclass80_2;
    }
    gclass80_1.indexUI = (int) gclass80_1.template.type;
    this.arrItemBody[gclass80_1.indexUI] = gclass80_1;
    for (int index = Class15.smethod_0(0); index < this.arrItemBody.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80_3 = this.arrItemBody[index];
      if ((gclass80_3 == null ? 1 : 0) == 0)
      {
        if ((gclass80_3.template.type == (sbyte) 0 ? 0 : 1) == 0)
          this.body = (int) gclass80_3.template.part;
        else if ((int) gclass80_3.template.type == Class15.smethod_0(1))
          this.leg = (int) gclass80_3.template.part;
      }
    }
  }

  public GClass161 method_12(GClass167 skillTemplate)
  {
    for (int index = Class15.smethod_0(0); index < this.vSkill.method_2(); index += Class15.smethod_0(1))
    {
      if ((int) ((GClass161) this.vSkill.method_3(index)).template.id == (int) skillTemplate.id)
        return (GClass161) this.vSkill.method_3(index);
    }
    return (GClass161) null;
  }

  public GClass190 method_13()
  {
    GClass179 taskMaint = GClass20.gclass20_0.taskMaint;
    if ((taskMaint == null ? 1 : 0) == 0 && (taskMaint.taskId == (short) 0 ? 0 : 1) == 0 && taskMaint.index < Class15.smethod_0(37))
      return (GClass190) null;
    int num = GClass185.gclass134_0.method_2();
    for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < num; index += (sbyte) Class15.smethod_0(1))
    {
      GClass190 gclass190 = (GClass190) GClass185.gclass134_0.method_3((int) index);
      if (GClass148.gclass134_0.method_2() >= num && (!((GClass148) GClass148.gclass134_0.method_3((int) index)).isPaint ? 0 : 1) == 0)
        return (GClass190) null;
      if (this.cx >= (int) gclass190.minX && this.cx <= (int) gclass190.maxX && this.cy >= (int) gclass190.minY && this.cy <= (int) gclass190.maxY && (!gclass190.isEnter ? 1 : 0) == 0 && (!gclass190.isOffline ? 1 : 0) == 0)
        return gclass190;
    }
    return (GClass190) null;
  }

  public GClass190 method_14()
  {
    GClass179 taskMaint = GClass20.gclass20_0.taskMaint;
    if ((taskMaint == null ? 1 : 0) == 0 && (taskMaint.taskId == (short) 0 ? 0 : 1) == 0 && taskMaint.index < Class15.smethod_0(37))
      return (GClass190) null;
    int num = GClass185.gclass134_0.method_2();
    for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < num; index += (sbyte) Class15.smethod_0(1))
    {
      GClass190 gclass190 = (GClass190) GClass185.gclass134_0.method_3((int) index);
      if (GClass148.gclass134_0.method_2() >= num && (!((GClass148) GClass148.gclass134_0.method_3((int) index)).isPaint ? 0 : 1) == 0)
        return (GClass190) null;
      if (this.cx >= (int) gclass190.minX && this.cx <= (int) gclass190.maxX && this.cy >= (int) gclass190.minY && this.cy <= (int) gclass190.maxY && (!gclass190.isEnter ? 1 : 0) == 0 && (!gclass190.isOffline ? 0 : 1) == 0)
        return gclass190;
    }
    return (GClass190) null;
  }

  public bool method_15()
  {
    if ((!GClass185.smethod_14() ? 1 : 0) == 0 && this.cy >= GClass185.int_24 - Class15.smethod_0(154))
      return Class15.smethod_0(1) != 0;
    if ((!this.isTeleport ? 0 : 1) != 0 || (!this.isUsePlane ? 1 : 0) == 0)
      return Class15.smethod_0(0) != 0;
    int num = GClass185.gclass134_0.method_2();
    for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < num; index += (sbyte) Class15.smethod_0(1))
    {
      GClass190 gclass190 = (GClass190) GClass185.gclass134_0.method_3((int) index);
      if (GClass185.int_37 != Class15.smethod_0(43) && (!GClass185.smethod_14() ? 1 : 0) != 0 || this.cy > (int) gclass190.minY + (int) gclass190.maxY || this.cx <= (int) gclass190.minX || this.cx >= (int) gclass190.maxX)
      {
        if (this.cx >= (int) gclass190.minX && this.cx <= (int) gclass190.maxX && this.cy >= (int) gclass190.minY && this.cy <= (int) gclass190.maxY && (!gclass190.isEnter ? 0 : 1) == 0)
          return Class15.smethod_0(1) != 0;
      }
      else
        return (!GClass185.smethod_14() ? 1 : 0) == 0 && (this.cTypePk == (sbyte) 0 ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_16()
  {
    if ((this.skillPaint == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    if (this.skillPaint.id >= Class15.smethod_0(0) && this.skillPaint.id <= Class15.smethod_0(37))
      return Class15.smethod_0(1) != 0;
    if (this.skillPaint.id >= Class15.smethod_0(49) && this.skillPaint.id <= Class15.smethod_0(51))
      return Class15.smethod_0(1) != 0;
    if (this.skillPaint.id >= Class15.smethod_0(35) && this.skillPaint.id <= Class15.smethod_0(117))
      return Class15.smethod_0(1) != 0;
    return this.skillPaint.id >= Class15.smethod_0(182) && this.skillPaint.id <= Class15.smethod_0(151) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public void method_17()
  {
    if ((!this.me ? 1 : 0) == 0 && this.statusMe == Class15.smethod_0(31) && this.cf == Class15.smethod_0(88) && this.ty > Class15.smethod_0(51) && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
      GClass172.smethod_1().method_37();
    if ((this.skillPaint == null ? 1 : 0) != 0 || (this.method_71() == null ? 1 : 0) != 0 || this.indexSkill >= this.method_71().Length || (!this.method_16() ? 1 : 0) != 0 || (!this.me ? 0 : 1) == 0 && ((!this.me ? 0 : 1) != 0 || this.cx < GClass116.int_22 || this.cx > GClass116.int_22 + GClass62.int_10) || (GClass62.int_8 % Class15.smethod_0(3) == 0 ? 0 : 1) != 0)
      return;
    if (this.cf != Class15.smethod_0(45) && this.cf != Class15.smethod_0(31) && this.cf != Class15.smethod_0(67))
      GClass172.smethod_1().method_4(Class15.smethod_0(0) != 0, (!this.me ? 1 : 0) != 0 ? Class15.smethod_2(15) : Class15.smethod_2(12));
    else
      GClass172.smethod_1().method_4(Class15.smethod_0(1) != 0, (!this.me ? 1 : 0) != 0 ? Class15.smethod_2(15) : Class15.smethod_2(12));
  }

  public void method_18()
  {
  }

  public bool method_19() => GClass185.int_37 >= Class15.smethod_0(81) ? (GClass185.int_37 > Class15.smethod_0(82) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  public virtual void vmethod_0()
  {
    if (this.method_19() && this.bag >= Class15.smethod_0(0) && GClass26.gclass128_0.method_7((object) (this.bag.ToString() + string.Empty)))
    {
      GClass26 gclass26 = (GClass26) GClass26.gclass128_0.method_0((object) (this.bag.ToString() + string.Empty));
      bool flag = Class15.smethod_0(0) != 0;
      if (gclass26.idImage != null)
      {
        for (int index = Class15.smethod_0(0); index < gclass26.idImage.Length; index += Class15.smethod_0(1))
        {
          if ((int) gclass26.idImage[index] == Class15.smethod_0(85))
          {
            this.isNrd = Class15.smethod_0(1) != 0;
            flag = Class15.smethod_0(1) != 0;
            if (this.timeNRD == 0)
            {
              this.timeNRD = Class15.smethod_0(183);
              break;
            }
            break;
          }
        }
      }
      if (!flag)
      {
        this.isNrd = Class15.smethod_0(0) != 0;
        this.timeNRD = Class15.smethod_0(0);
      }
    }
    if (this.timeNRD > Class15.smethod_0(0) && GClass126.smethod_18() - this.currentTimeNRD >= (long) Class15.smethod_0(15))
    {
      this.currentTimeNRD = GClass126.smethod_18();
      this.timeNRD -= Class15.smethod_0(1);
    }
    if (this.bool_6 || this.isMabuHold)
      return;
    if ((this.isCopy || this.clevel >= Class15.smethod_0(49)) && this.statusMe != Class15.smethod_0(1))
      Class15.smethod_0(37);
    if (this.petFollow != null)
    {
      if (GClass62.int_8 % Class15.smethod_0(5) == 0)
      {
        if (GClass20.smethod_1().cdir == Class15.smethod_0(1))
          this.petFollow.cmtoX = this.cx - Class15.smethod_0(51);
        if (GClass20.smethod_1().cdir == -1)
          this.petFollow.cmtoX = this.cx + Class15.smethod_0(51);
        this.petFollow.cmtoY = this.cy - Class15.smethod_0(54);
        this.petFollow.dir = this.petFollow.cmx <= this.cx ? Class15.smethod_0(1) : -1;
        if (this.petFollow.cmtoX < Class15.smethod_0(21))
          this.petFollow.cmtoX = Class15.smethod_0(21);
        if (this.petFollow.cmtoX > GClass185.int_23 - Class15.smethod_0(21))
          this.petFollow.cmtoX = GClass185.int_23 - Class15.smethod_0(21);
      }
      this.petFollow.method_2();
    }
    if (!this.me && this.cHP <= Class15.smethod_0(0) && this.clanID != Class15.smethod_0(143) && this.statusMe != Class15.smethod_0(49) && this.statusMe != Class15.smethod_0(3))
      this.method_110((short) this.cx, (short) this.cy);
    if (this.isInjureHp)
    {
      this.int_7 += Class15.smethod_0(1);
      if (this.int_7 == Class15.smethod_0(51))
      {
        this.int_7 = Class15.smethod_0(0);
        this.isInjureHp = Class15.smethod_0(0) != 0;
      }
    }
    else if (this.dHP > this.cHP)
    {
      int num = this.dHP - this.cHP >> Class15.smethod_0(1);
      if (num < Class15.smethod_0(1))
        num = Class15.smethod_0(1);
      this.dHP -= num;
    }
    else
      this.dHP = this.cHP;
    if (this.secondPower != (short) 0)
    {
      this.currS = GClass126.smethod_18();
      if (this.currS - this.lastS >= (long) Class15.smethod_0(15))
      {
        this.lastS = GClass126.smethod_18();
        this.secondPower -= (short) Class15.smethod_0(1);
      }
    }
    if (!this.me && GClass116.bool_59)
      return;
    if (this.sleepEff && GClass62.int_8 % Class15.smethod_0(31) == 0)
      GClass40.smethod_0(new GClass41(Class15.smethod_0(55), this.cx, this.cy, Class15.smethod_0(5), Class15.smethod_0(1), Class15.smethod_0(1)));
    if (this.huytSao)
    {
      this.huytSao = Class15.smethod_0(0) != 0;
      GClass40.smethod_0(new GClass41(Class15.smethod_0(53), this.cx, this.cy, Class15.smethod_0(5), Class15.smethod_0(5), Class15.smethod_0(1)));
    }
    if (this.blindEff && GClass62.int_8 % Class15.smethod_0(3) == 0)
      GClass47.smethod_3(Class15.smethod_0(76), this, Class15.smethod_0(1));
    if (this.protectEff)
    {
      int y = this.cH_new + Class15.smethod_0(184);
      if (GClass62.int_8 % Class15.smethod_0(3) == 0)
        this.gclass41_0 = new GClass41(Class15.smethod_0(48), this.cx, y, Class15.smethod_0(5), Class15.smethod_0(5), Class15.smethod_0(1));
      if (this.gclass41_0 != null)
      {
        this.gclass41_0.method_4();
        this.gclass41_0.x = this.cx;
        this.gclass41_0.y = y;
      }
    }
    if (this.charFocus != null && this.charFocus.cy < Class15.smethod_0(0))
      this.charFocus = (GClass20) null;
    if (this.isFusion)
      this.tFusion += Class15.smethod_0(1);
    if (this.isNhapThe && GClass62.int_8 % Class15.smethod_0(46) == 0)
      GClass47.smethod_3(Class15.smethod_0(24), this, Class15.smethod_0(1));
    if (this.bool_15)
    {
      this.int_18 += Class15.smethod_0(1);
      if (this.int_18 != Class15.smethod_0(1))
        return;
      this.int_18 = Class15.smethod_0(0);
      this.bool_15 = Class15.smethod_0(0) != 0;
      this.cx = (int) this.short_3;
      this.cy = (int) this.short_4;
      this.cp1 = this.cp2 = this.cp3 = Class15.smethod_0(0);
      if ((int) this.sbyte_21 == Class15.smethod_0(1))
      {
        if (this.me)
        {
          this.cxSend = this.cx;
          this.cySend = this.cy;
        }
        this.currentMovePoint = (GClass108) null;
        this.telePortSkill = Class15.smethod_0(0) != 0;
        GClass47.smethod_0(Class15.smethod_0(185), this.cx, this.cy, Class15.smethod_0(1));
      }
      else
        GClass47.smethod_0(Class15.smethod_0(4), this.cx, this.cy, Class15.smethod_0(1));
      if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
        this.statusMe = Class15.smethod_0(1);
      else
        this.statusMe = Class15.smethod_0(2);
    }
    else
    {
      this.method_17();
      if (this.stone)
        return;
      if (this.isFreez)
      {
        if (GClass62.int_8 % Class15.smethod_0(3) == 0)
          GClass47.smethod_0(Class15.smethod_0(76), this.cx, this.cy, Class15.smethod_0(1));
        this.cf = Class15.smethod_0(29);
        long num = GClass126.smethod_18();
        if (num - this.lastFreez >= (long) Class15.smethod_0(15))
        {
          this.freezSeconds -= Class15.smethod_0(1);
          this.lastFreez = num;
          if (this.freezSeconds < Class15.smethod_0(0))
          {
            this.isFreez = Class15.smethod_0(0) != 0;
            this.seconds = Class15.smethod_0(0);
            if (this.me)
            {
              GClass20.smethod_1().isLockMove = Class15.smethod_0(0) != 0;
              GClass116.smethod_6().dem = Class15.smethod_0(0);
              GClass116.smethod_6().isFreez = Class15.smethod_0(0) != 0;
            }
          }
        }
        if (GClass185.smethod_25(this.cx / (int) GClass185.sbyte_0, this.cy / (int) GClass185.sbyte_0) != 0)
          return;
        this.ty += Class15.smethod_0(1);
        this.wt += Class15.smethod_0(1);
        this.fy += !this.bool_7 ? Class15.smethod_0(1) : -1;
        if (this.wt != Class15.smethod_0(31))
          return;
        this.wt = Class15.smethod_0(0);
        this.bool_7 = (this.bool_7 ? 1 : 0) == Class15.smethod_0(0);
      }
      else if (this.isWaitMonkey)
      {
        this.isLockMove = Class15.smethod_0(1) != 0;
        this.cf = Class15.smethod_0(186);
        if (GClass62.int_8 % Class15.smethod_0(3) == 0)
          GClass47.smethod_0(Class15.smethod_0(187), this.cx, this.cy - Class15.smethod_0(31), Class15.smethod_0(7));
        if (GClass62.int_8 % Class15.smethod_0(3) == 0)
          GClass47.smethod_0(Class15.smethod_0(1), this.cx, this.cy + Class15.smethod_0(31), Class15.smethod_0(1));
        this.int_10 += Class15.smethod_0(1);
        if (this.int_10 != Class15.smethod_0(16))
          return;
        this.isWaitMonkey = Class15.smethod_0(0) != 0;
        this.isLockMove = Class15.smethod_0(0) != 0;
      }
      else if (this.isStandAndCharge)
      {
        this.int_10 += Class15.smethod_0(1);
        bool flag = (GClass185.smethod_27(GClass20.smethod_1().cx, GClass20.smethod_1().cy, Class15.smethod_0(7)) ? 1 : 0) == Class15.smethod_0(0);
        this.method_20();
        this.method_24();
        this.moveFast = (short[]) null;
        this.currentMovePoint = (GClass108) null;
        this.cf = Class15.smethod_0(186);
        if (flag && this.cgender != Class15.smethod_0(7))
          this.cf = Class15.smethod_0(66);
        if (this.cgender == Class15.smethod_0(7))
        {
          if (GClass62.int_8 % Class15.smethod_0(5) == 0)
            GClass47.smethod_0(Class15.smethod_0(187), this.cx, this.cy - this.ch / Class15.smethod_0(7) + Class15.smethod_0(31), Class15.smethod_0(1));
          if (GClass62.int_8 % Class15.smethod_0(3) == 0)
            GClass47.smethod_0(Class15.smethod_0(24), this.cx + GClass151.smethod_18(Class15.smethod_0(188), Class15.smethod_0(51)), this.cy + GClass151.smethod_18(Class15.smethod_0(188), Class15.smethod_0(51)), Class15.smethod_0(1));
        }
        if (this.cgender == Class15.smethod_0(1))
        {
          int num = GClass62.int_8 % Class15.smethod_0(2);
          if (GClass62.int_8 % Class15.smethod_0(7) == 0)
          {
            if (this.cdir == Class15.smethod_0(1))
            {
              GClass47.smethod_0(Class15.smethod_0(152), this.cx - Class15.smethod_0(124), this.cy - this.ch / Class15.smethod_0(7) + Class15.smethod_0(88), Class15.smethod_0(1));
              GClass47.smethod_0(Class15.smethod_0(152), this.cx + Class15.smethod_0(29), this.cy - this.ch / Class15.smethod_0(7) + Class15.smethod_0(9), Class15.smethod_0(1));
            }
            else
            {
              GClass47.smethod_0(Class15.smethod_0(152), this.cx + Class15.smethod_0(124), this.cy - this.ch / Class15.smethod_0(7) + Class15.smethod_0(88), Class15.smethod_0(1));
              GClass47.smethod_0(Class15.smethod_0(152), this.cx - Class15.smethod_0(29), this.cy - this.ch / Class15.smethod_0(7) + Class15.smethod_0(9), Class15.smethod_0(1));
            }
          }
        }
        this.cur = GClass126.smethod_18();
        if (this.cur - this.last > (long) this.seconds || this.cur - this.last > (long) Class15.smethod_0(181))
        {
          this.method_68();
          if (this.me)
          {
            GClass116.smethod_6().auto = Class15.smethod_0(0);
            if (this.cgender == Class15.smethod_0(7))
            {
              GClass20.smethod_1().method_70(GClass116.gclass165_0[(int) GClass20.smethod_1().myskill.skillId], flag ? Class15.smethod_0(1) : Class15.smethod_0(0));
              GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(88));
            }
            if (this.cgender == Class15.smethod_0(1))
            {
              GClass151.smethod_7(Class13.smethod_0(28599));
              this.isCreateDark = Class15.smethod_0(1) != 0;
              GClass20.smethod_1().method_65(GClass116.gclass165_0[(int) GClass20.smethod_1().myskill.skillId], flag ? Class15.smethod_0(1) : Class15.smethod_0(0));
            }
          }
          else if (this.cgender == Class15.smethod_0(7))
            this.method_70(GClass116.gclass165_0[this.skillTemplateId], flag ? Class15.smethod_0(1) : Class15.smethod_0(0));
          if (this.cgender == Class15.smethod_0(7) && this.statusMe != Class15.smethod_0(49) && this.statusMe != Class15.smethod_0(3))
            GClass116.smethod_6().method_50(this.cx, this.cy);
        }
        this.int_10 += Class15.smethod_0(1);
        if (this.int_10 != Class15.smethod_0(16))
          return;
        this.method_68();
      }
      else if (this.isFlyAndCharge)
      {
        this.method_20();
        this.method_24();
        this.moveFast = (short[]) null;
        this.currentMovePoint = (GClass108) null;
        this.posDisY += Class15.smethod_0(1);
        if (GClass185.smethod_27(this.cx, this.cy - this.ch, Class15.smethod_0(189)))
        {
          this.method_68();
        }
        else
        {
          if (this.posDisY == Class15.smethod_0(51))
            this.last = GClass126.smethod_18();
          if (this.posDisY > Class15.smethod_0(51))
          {
            this.cur = GClass126.smethod_18();
            if (this.cur - this.last <= (long) this.seconds && this.cur - this.last <= (long) Class15.smethod_0(181))
            {
              this.cf = Class15.smethod_0(120);
              if (this.cgender == 0 && GClass62.int_8 % Class15.smethod_0(5) == 0)
                GClass47.smethod_0(Class15.smethod_0(78), this.cx, this.cy - this.ch, Class15.smethod_0(7));
              this.int_10 += Class15.smethod_0(1);
              if (this.int_10 != Class15.smethod_0(16))
                return;
              this.method_68();
            }
            else
            {
              this.isFlyAndCharge = Class15.smethod_0(0) != 0;
              if (!this.me)
                return;
              this.isCreateDark = Class15.smethod_0(1) != 0;
              bool flag = GClass185.smethod_27(GClass20.smethod_1().cx, GClass20.smethod_1().cy, Class15.smethod_0(7));
              this.isUseSkillAfterCharge = Class15.smethod_0(1) != 0;
              GClass20.smethod_1().method_65(GClass116.gclass165_0[(int) GClass20.smethod_1().myskill.skillId], !flag ? Class15.smethod_0(1) : Class15.smethod_0(0));
            }
          }
          else
          {
            if (this.statusMe != Class15.smethod_0(49))
              this.statusMe = Class15.smethod_0(5);
            this.cvy = Class15.smethod_0(134);
            this.cy += this.cvy;
            this.cf = Class15.smethod_0(38);
          }
        }
      }
      else
      {
        if (this.me && GClass62.bool_5)
        {
          if (this.charFocus != null && this.charFocus.charID >= Class15.smethod_0(0) && this.charFocus.cx > Class15.smethod_0(21) && this.charFocus.cx < GClass185.int_23 - Class15.smethod_0(21) && this.method_14() == null && this.method_13() == null && !this.method_101() && GClass185.int_37 != Class15.smethod_0(190) && GClass185.int_37 != Class15.smethod_0(72) && GClass62.gclass141_0.vPlayerMenu.method_2() > Class15.smethod_0(0) && GClass116.smethod_6().popUpYesNo == null)
          {
            int num1 = GClass93.smethod_0(this.cx - this.charFocus.cx);
            int num2 = GClass93.smethod_0(this.cy - this.charFocus.cy);
            int num3 = Class15.smethod_0(4);
            if (num1 < num3 && num2 < Class15.smethod_0(54))
            {
              if (this.cmdMenu == null)
              {
                this.cmdMenu = new GClass31(GClass109.string_124, Class15.smethod_0(191));
                this.cmdMenu.isPlaySoundButton = Class15.smethod_0(0) != 0;
              }
              this.cmdMenu.x = this.charFocus.cx - GClass116.int_22;
              this.cmdMenu.y = this.charFocus.cy - this.charFocus.ch - Class15.smethod_0(6) - GClass116.int_23;
            }
            else
              this.cmdMenu = (GClass31) null;
          }
          else
            this.cmdMenu = (GClass31) null;
        }
        if (this.isShadown)
          this.method_88();
        if (this.isTeleport)
          return;
        if (this.chatInfo != null)
          this.chatInfo.method_2();
        if (this.shadowLife > Class15.smethod_0(0))
          this.shadowLife -= Class15.smethod_0(1);
        if ((int) this.resultTest > Class15.smethod_0(0) && GClass62.int_8 % Class15.smethod_0(7) == 0)
        {
          this.resultTest -= (sbyte) Class15.smethod_0(1);
          if ((int) this.resultTest == Class15.smethod_0(6) || (int) this.resultTest == Class15.smethod_0(4))
            this.resultTest = (sbyte) Class15.smethod_0(0);
        }
        this.method_24();
        if (this.mobMe != null)
          this.method_23();
        if (this.arr != null)
          this.arr.method_0();
        if (this.dart != null)
          this.dart.method_1();
        this.method_20();
        if (this.holdEffID != 0)
        {
          if (GClass62.int_8 % Class15.smethod_0(3) != 0)
            return;
          GClass40.smethod_0(new GClass41(Class15.smethod_0(120), this.cx, this.cy + Class15.smethod_0(40), Class15.smethod_0(5), Class15.smethod_0(3), Class15.smethod_0(1)));
        }
        else
        {
          if (this.blindEff || this.sleepEff)
            return;
          if (this.holder)
          {
            if (this.gclass20_2 != null && (this.gclass20_2.statusMe == Class15.smethod_0(49) || this.gclass20_2.statusMe == Class15.smethod_0(3)))
              this.method_123();
            if (this.gclass100_0 != null && this.gclass100_0.status == Class15.smethod_0(1))
              this.method_123();
            if (this.me && this.statusMe == Class15.smethod_0(7) && this.currentMovePoint != null)
            {
              this.holder = Class15.smethod_0(0) != 0;
              this.gclass20_2 = (GClass20) null;
              this.gclass100_0 = (GClass100) null;
            }
            if (GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)))
              this.cf = Class15.smethod_0(10);
            else
              this.cf = Class15.smethod_0(8);
          }
          else
          {
            if (this.cHP > Class15.smethod_0(0))
            {
              for (int index = Class15.smethod_0(0); index < this.vEff.method_2(); index += Class15.smethod_0(1))
              {
                GClass48 gclass48 = (GClass48) this.vEff.method_3(index);
                if (gclass48.template.type != (sbyte) 0 && (int) gclass48.template.type != Class15.smethod_0(66))
                {
                  if ((int) gclass48.template.type != Class15.smethod_0(2) && (int) gclass48.template.type != Class15.smethod_0(186))
                  {
                    if ((int) gclass48.template.type == Class15.smethod_0(47) && GClass62.bool_18)
                    {
                      this.cHP -= this.cHPFull * Class15.smethod_0(5) / Class15.smethod_0(21);
                      if (this.cHP < Class15.smethod_0(1))
                        this.cHP = Class15.smethod_0(1);
                    }
                  }
                  else if (GClass62.bool_18)
                    this.cHP += (int) gclass48.param;
                }
                else if (GClass62.bool_18)
                {
                  this.cHP += (int) gclass48.param;
                  this.cMP += (int) gclass48.param;
                }
              }
              if (this.eff5BuffHp > Class15.smethod_0(0) && GClass62.bool_19)
                this.cHP += this.eff5BuffHp;
              if (this.eff5BuffMp > Class15.smethod_0(0) && GClass62.bool_19)
                this.cMP += this.eff5BuffMp;
              if (this.cHP > this.cHPFull)
                this.cHP = this.cHPFull;
              if (this.cMP > this.cMPFull)
                this.cMP = this.cMPFull;
            }
            if (this.cmtoChar)
            {
              GClass116.int_28 = this.cx - GClass116.int_8;
              GClass116.int_29 = this.cy - GClass116.int_14;
              if (!GClass62.bool_6)
                GClass116.int_28 += GClass116.int_20 * this.cdir;
            }
            this.tick = (this.tick + Class15.smethod_0(1)) % Class15.smethod_0(21);
            if (this.me)
            {
              if (this.charFocus != null && !GClass116.gclass134_5.method_1((object) this.charFocus))
                this.charFocus = (GClass20) null;
              if (this.cx < Class15.smethod_0(31))
              {
                this.cvx = Class15.smethod_0(0);
                this.cx = Class15.smethod_0(31);
              }
              else if (this.cx > GClass185.int_23 - Class15.smethod_0(31))
              {
                this.cx = GClass185.int_23 - Class15.smethod_0(31);
                this.cvx = Class15.smethod_0(0);
              }
              if (this.me && !GClass20.bool_2 && this.method_15())
              {
                GClass156.smethod_0().method_45();
                if (GClass185.smethod_2())
                {
                  GClass156.smethod_0().method_115();
                  GClass20.bool_2 = Class15.smethod_0(1) != 0;
                }
                else
                  GClass156.smethod_0().method_41();
                GClass20.bool_3 = Class15.smethod_0(1) != 0;
                GClass20.bool_2 = Class15.smethod_0(1) != 0;
                GClass62.smethod_25();
                GClass62.smethod_24();
                GClass71.smethod_1();
                return;
              }
              if (this.statusMe != Class15.smethod_0(2) && GClass151.smethod_25(this.cx - this.cxSend) + GClass151.smethod_25(this.cy - this.cySend) >= Class15.smethod_0(152) && this.cy - this.cySend <= Class15.smethod_0(0) && this.me)
                GClass156.smethod_0().method_45();
              if (this.isLockMove)
                this.currentMovePoint = (GClass108) null;
              if (this.currentMovePoint != null)
              {
                if (GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) <= Class15.smethod_0(10) && GClass20.smethod_4(this.cy - this.currentMovePoint.yEnd) <= Class15.smethod_0(10))
                {
                  this.cx = (this.currentMovePoint.xEnd + this.cx) / Class15.smethod_0(7);
                  this.cy = this.currentMovePoint.yEnd;
                  this.currentMovePoint = (GClass108) null;
                  GClass116.gclass116_0.clickMoving = Class15.smethod_0(0) != 0;
                  this.method_21();
                  this.cvx = this.cvy = Class15.smethod_0(0);
                  if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
                    this.statusMe = Class15.smethod_0(1);
                  else
                    this.method_45();
                  GClass156.smethod_0().method_45();
                }
                else
                {
                  this.cdir = this.currentMovePoint.xEnd > this.cx ? Class15.smethod_0(1) : -1;
                  if (GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)))
                  {
                    this.statusMe = Class15.smethod_0(7);
                    if (this.currentMovePoint != null)
                    {
                      this.cvx = this.cspeed * this.cdir;
                      this.cvy = Class15.smethod_0(0);
                    }
                    if (GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) <= Class15.smethod_0(31))
                    {
                      if (this.currentMovePoint.yEnd > this.cy)
                      {
                        bool flag = Class15.smethod_0(0) != 0;
                        sbyte num4 = (sbyte) Class15.smethod_0(1);
                        sbyte num5 = this.cdir == Class15.smethod_0(1) ? (sbyte) Class15.smethod_0(1) : (sbyte) -1;
                        for (int index = Class15.smethod_0(0); index < Class15.smethod_0(7); index += Class15.smethod_0(1))
                        {
                          if (GClass185.smethod_27(this.currentMovePoint.xEnd + this.chw * (int) num5, this.cy + this.chh * index, Class15.smethod_0(7)))
                          {
                            flag = Class15.smethod_0(1) != 0;
                            break;
                          }
                        }
                        if (flag)
                        {
                          this.currentMovePoint = (GClass108) null;
                          GClass116.gclass116_0.clickMoving = Class15.smethod_0(0) != 0;
                          this.statusMe = Class15.smethod_0(1);
                          this.cvx = this.cvy = Class15.smethod_0(0);
                          this.method_21();
                        }
                        else
                        {
                          GClass172.smethod_1().method_32();
                          this.cx = this.currentMovePoint.xEnd;
                          this.statusMe = Class15.smethod_0(31);
                          this.cvy = Class15.smethod_0(192);
                          this.cvx = Class15.smethod_0(0);
                          GClass151.smethod_7(Class13.smethod_0(28578));
                        }
                      }
                      else
                      {
                        GClass172.smethod_1().method_32();
                        this.cx = this.currentMovePoint.xEnd;
                        this.statusMe = Class15.smethod_0(31);
                        this.cvy = Class15.smethod_0(192);
                        this.cvx = Class15.smethod_0(0);
                      }
                    }
                    if (this.cdir == Class15.smethod_0(1))
                    {
                      if (GClass185.smethod_27(this.cx + this.chw, this.cy - this.chh, Class15.smethod_0(2)))
                      {
                        this.cvx = this.cspeed * this.cdir;
                        this.statusMe = Class15.smethod_0(31);
                        this.cvy = Class15.smethod_0(192);
                      }
                    }
                    else if (GClass185.smethod_27(this.cx - this.chw - Class15.smethod_0(1), this.cy - this.chh, Class15.smethod_0(88)))
                    {
                      this.cvx = this.cspeed * this.cdir;
                      this.statusMe = Class15.smethod_0(31);
                      this.cvy = Class15.smethod_0(192);
                    }
                  }
                  else
                  {
                    if (this.currentMovePoint.yEnd < this.cy + Class15.smethod_0(31))
                    {
                      this.statusMe = Class15.smethod_0(31);
                      this.cvy = Class15.smethod_0(192);
                      if (GClass20.smethod_4(this.cy - this.currentMovePoint.yEnd) <= Class15.smethod_0(31))
                      {
                        this.cy = this.currentMovePoint.yEnd;
                        this.cvy = Class15.smethod_0(0);
                      }
                      this.cvx = GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) > Class15.smethod_0(31) ? this.cspeed * this.cdir : Class15.smethod_0(0);
                    }
                    else if (GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)))
                    {
                      this.currentMovePoint = (GClass108) null;
                      GClass116.gclass116_0.clickMoving = Class15.smethod_0(0) != 0;
                      this.statusMe = Class15.smethod_0(1);
                      this.cvx = this.cvy = Class15.smethod_0(0);
                      this.method_21();
                    }
                    else
                    {
                      if (this.statusMe == Class15.smethod_0(31) || this.statusMe == Class15.smethod_0(7))
                        this.cvy = Class15.smethod_0(0);
                      this.statusMe = Class15.smethod_0(2);
                    }
                    if (this.currentMovePoint.yEnd > this.cy)
                    {
                      if (this.cdir == Class15.smethod_0(1))
                      {
                        if (GClass185.smethod_27(this.cx + this.chw, this.cy - this.chh, Class15.smethod_0(2)))
                        {
                          this.cvx = this.cvy = Class15.smethod_0(0);
                          this.statusMe = Class15.smethod_0(2);
                          this.currentMovePoint = (GClass108) null;
                          GClass116.gclass116_0.clickMoving = Class15.smethod_0(0) != 0;
                          this.method_21();
                        }
                      }
                      else if (GClass185.smethod_27(this.cx - this.chw - Class15.smethod_0(1), this.cy - this.chh, Class15.smethod_0(88)))
                      {
                        this.cvx = this.cvy = Class15.smethod_0(0);
                        this.statusMe = Class15.smethod_0(2);
                        this.currentMovePoint = (GClass108) null;
                        GClass116.gclass116_0.clickMoving = Class15.smethod_0(0) != 0;
                        this.method_21();
                      }
                    }
                  }
                }
              }
              this.method_99();
            }
            else
            {
              this.method_22();
              if (this.statusMe == Class15.smethod_0(1) || this.statusMe == Class15.smethod_0(37))
              {
                bool flag = Class15.smethod_0(0) != 0;
                if (this.currentMovePoint != null)
                {
                  if (GClass20.smethod_4(this.currentMovePoint.xEnd - this.cx) < Class15.smethod_0(186) && GClass20.smethod_4(this.currentMovePoint.yEnd - this.cy) < Class15.smethod_0(46))
                  {
                    this.cx = this.currentMovePoint.xEnd;
                    this.cy = this.currentMovePoint.yEnd;
                    this.currentMovePoint = (GClass108) null;
                    if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
                    {
                      this.statusMe = Class15.smethod_0(1);
                      this.cp3 = Class15.smethod_0(0);
                      GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
                      GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
                    }
                    else
                    {
                      this.statusMe = Class15.smethod_0(2);
                      this.cvy = Class15.smethod_0(0);
                      this.cp1 = Class15.smethod_0(0);
                    }
                    flag = Class15.smethod_0(1) != 0;
                  }
                  else if ((this.int_15 == Class15.smethod_0(31) || this.cf == Class15.smethod_0(88)) && this.vMovePoints.method_2() > Class15.smethod_0(0))
                    flag = Class15.smethod_0(1) != 0;
                  else if (this.cy == this.currentMovePoint.yEnd)
                  {
                    if (this.cx != this.currentMovePoint.xEnd)
                    {
                      this.cx = (this.cx + this.currentMovePoint.xEnd) / Class15.smethod_0(7);
                      this.cf = GClass62.int_8 % Class15.smethod_0(3) + Class15.smethod_0(7);
                    }
                  }
                  else if (this.cy < this.currentMovePoint.yEnd)
                  {
                    this.cf = Class15.smethod_0(66);
                    this.cx = (this.cx + this.currentMovePoint.xEnd) / Class15.smethod_0(7);
                    if (this.cvy < Class15.smethod_0(0))
                      this.cvy = Class15.smethod_0(0);
                    this.cy += this.cvy;
                    if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
                    {
                      GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
                      GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
                    }
                    this.cvy += Class15.smethod_0(1);
                    if (this.cvy > Class15.smethod_0(10))
                      this.cy = (this.cy + this.currentMovePoint.yEnd) / Class15.smethod_0(7);
                  }
                  else
                  {
                    this.cf = Class15.smethod_0(38);
                    this.cx = (this.cx + this.currentMovePoint.xEnd) / Class15.smethod_0(7);
                    this.cy = (this.cy + this.currentMovePoint.yEnd) / Class15.smethod_0(7);
                  }
                }
                else
                  flag = Class15.smethod_0(1) != 0;
                if (flag && this.vMovePoints.method_2() > Class15.smethod_0(0))
                {
                  this.currentMovePoint = (GClass108) this.vMovePoints.method_11();
                  this.vMovePoints.method_7(Class15.smethod_0(0));
                  if (this.currentMovePoint.status == Class15.smethod_0(7))
                  {
                    if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(66)) & Class15.smethod_0(7)) != Class15.smethod_0(7))
                    {
                      this.statusMe = Class15.smethod_0(31);
                      this.cp1 = Class15.smethod_0(0);
                      this.cp2 = Class15.smethod_0(0);
                      this.cvx = -(this.cx - this.currentMovePoint.xEnd) / Class15.smethod_0(31);
                      this.cvy = -(this.cy - this.currentMovePoint.yEnd) / Class15.smethod_0(31);
                      if (this.cx - this.currentMovePoint.xEnd > Class15.smethod_0(0))
                        this.cdir = -1;
                      else if (this.cx - this.currentMovePoint.xEnd < Class15.smethod_0(0))
                        this.cdir = Class15.smethod_0(1);
                    }
                    else
                    {
                      this.statusMe = Class15.smethod_0(7);
                      if (this.cx - this.currentMovePoint.xEnd > Class15.smethod_0(0))
                        this.cdir = -1;
                      else if (this.cx - this.currentMovePoint.xEnd < Class15.smethod_0(0))
                        this.cdir = Class15.smethod_0(1);
                      this.cvx = this.cspeed * this.cdir;
                      this.cvy = Class15.smethod_0(0);
                    }
                  }
                  else if (this.currentMovePoint.status == Class15.smethod_0(5))
                  {
                    if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(29)) & Class15.smethod_0(7)) != Class15.smethod_0(7))
                    {
                      this.statusMe = Class15.smethod_0(31);
                      this.cp1 = Class15.smethod_0(0);
                      this.cp2 = Class15.smethod_0(0);
                      this.cvx = -(this.cx - this.currentMovePoint.xEnd) / Class15.smethod_0(31);
                      this.cvy = -(this.cy - this.currentMovePoint.yEnd) / Class15.smethod_0(31);
                      if (this.cx - this.currentMovePoint.xEnd > Class15.smethod_0(0))
                        this.cdir = -1;
                      else if (this.cx - this.currentMovePoint.xEnd < Class15.smethod_0(0))
                        this.cdir = Class15.smethod_0(1);
                    }
                    else
                    {
                      this.statusMe = Class15.smethod_0(5);
                      GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
                      GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
                      if (this.cx - this.currentMovePoint.xEnd > Class15.smethod_0(0))
                        this.cdir = -1;
                      else if (this.cx - this.currentMovePoint.xEnd < Class15.smethod_0(0))
                        this.cdir = Class15.smethod_0(1);
                      this.cvx = GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) / Class15.smethod_0(31) * this.cdir;
                      this.cvy = Class15.smethod_0(136);
                    }
                  }
                  else if (this.currentMovePoint.status == Class15.smethod_0(2))
                  {
                    this.statusMe = Class15.smethod_0(2);
                    if (this.cx - this.currentMovePoint.xEnd > Class15.smethod_0(0))
                      this.cdir = -1;
                    else if (this.cx - this.currentMovePoint.xEnd < Class15.smethod_0(0))
                      this.cdir = Class15.smethod_0(1);
                    this.cvx = GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) / Class15.smethod_0(45) * this.cdir;
                    this.cvy = Class15.smethod_0(0);
                  }
                  else
                  {
                    this.cx = this.currentMovePoint.xEnd;
                    this.cy = this.currentMovePoint.yEnd;
                    this.currentMovePoint = (GClass108) null;
                  }
                }
              }
            }
            switch (this.statusMe - Class15.smethod_0(1))
            {
              case 0:
                this.method_38();
                break;
              case 1:
                this.method_41();
                break;
              case 2:
                this.method_43();
                break;
              case 3:
                this.method_46();
                break;
              case 4:
                this.method_27();
                break;
              case 5:
                if ((int) this.isInjure <= Class15.smethod_0(0))
                  this.cf = Class15.smethod_0(0);
                else if (this.int_15 == Class15.smethod_0(31))
                  this.cx += this.cvx;
                else if (this.cf <= Class15.smethod_0(1))
                {
                  this.cp1 += Class15.smethod_0(1);
                  this.cf = this.cp1 <= Class15.smethod_0(37) ? Class15.smethod_0(1) : Class15.smethod_0(0);
                  if (this.cp1 > Class15.smethod_0(31))
                    this.cp1 = Class15.smethod_0(0);
                }
                if (this.cf != Class15.smethod_0(38) && this.cf != Class15.smethod_0(66) && (GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(1)) & Class15.smethod_0(7)) != Class15.smethod_0(7))
                {
                  this.cvx = Class15.smethod_0(0);
                  this.cvy = Class15.smethod_0(0);
                  this.statusMe = Class15.smethod_0(2);
                  this.cf = Class15.smethod_0(38);
                }
                if (!this.me)
                {
                  this.cp3 += Class15.smethod_0(1);
                  if (this.cp3 > Class15.smethod_0(31))
                  {
                    if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(1)) & Class15.smethod_0(7)) != Class15.smethod_0(7))
                      this.cy += Class15.smethod_0(3);
                    else
                      this.cf = Class15.smethod_0(0);
                  }
                  if (this.cp3 > Class15.smethod_0(32))
                  {
                    this.cp3 = Class15.smethod_0(0);
                    this.currentMovePoint = (GClass108) null;
                    break;
                  }
                  break;
                }
                break;
              case 8:
                this.method_31();
                break;
              case 9:
                this.method_47();
                break;
              case 11:
                this.method_30();
                break;
              case 12:
                this.method_29();
                break;
              case 13:
                this.cp1 += Class15.smethod_0(1);
                if (this.cp1 > Class15.smethod_0(6))
                  this.cp1 = Class15.smethod_0(0);
                this.cf = this.cp1 % Class15.smethod_0(9) >= Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0);
                break;
              case 15:
                this.method_28();
                break;
            }
            if ((int) this.isInjure > Class15.smethod_0(0))
            {
              this.cf = Class15.smethod_0(29);
              this.isInjure -= (sbyte) Class15.smethod_0(1);
            }
            if (this.wdx != (short) 0 || this.wdy != (short) 0)
            {
              this.method_110(this.wdx, this.wdy);
              this.wdx = (short) Class15.smethod_0(0);
              this.wdy = (short) Class15.smethod_0(0);
            }
            if (this.moveFast != null)
            {
              if (this.moveFast[Class15.smethod_0(0)] == (short) 0)
              {
                this.moveFast[Class15.smethod_0(0)] += (short) Class15.smethod_0(1);
                GClass47.smethod_3(Class15.smethod_0(4), this, Class15.smethod_0(1));
              }
              else if ((int) this.moveFast[Class15.smethod_0(0)] < Class15.smethod_0(31))
              {
                this.moveFast[Class15.smethod_0(0)] += (short) Class15.smethod_0(1);
              }
              else
              {
                this.cx = (int) this.moveFast[Class15.smethod_0(1)];
                this.cy = (int) this.moveFast[Class15.smethod_0(7)];
                this.moveFast = (short[]) null;
                GClass47.smethod_3(Class15.smethod_0(4), this, Class15.smethod_0(1));
                if (this.me)
                {
                  if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7))
                  {
                    this.statusMe = Class15.smethod_0(2);
                    GClass20.smethod_1().method_70(GClass116.gclass165_0[Class15.smethod_0(34)], Class15.smethod_0(1));
                  }
                  else
                  {
                    GClass156.smethod_0().method_45();
                    GClass20.smethod_1().method_70(GClass116.gclass165_0[Class15.smethod_0(34)], Class15.smethod_0(0));
                  }
                }
              }
            }
            if (this.statusMe != Class15.smethod_0(31))
              this.fy = Class15.smethod_0(0);
            if (this.isCharge)
            {
              this.cf = Class15.smethod_0(186);
              if (GClass62.int_8 % Class15.smethod_0(2) == 0)
                GClass47.smethod_0(Class15.smethod_0(1), this.cx, this.cy + GClass62.int_52, Class15.smethod_0(1));
              if (this.me)
              {
                long num = GClass126.smethod_18();
                if (num - this.last >= (long) Class15.smethod_0(15))
                {
                  GClass151.smethod_7(Class13.smethod_0(28671) + this.myskill.damage.ToString());
                  this.last = num;
                  this.cHP += this.cHPFull * (int) this.myskill.damage / Class15.smethod_0(21);
                  this.cMP += this.cMPFull * (int) this.myskill.damage / Class15.smethod_0(21);
                  if (this.cHP < this.cHPFull)
                    GClass116.smethod_17(Class13.smethod_0(28656) + (this.cHPFull * (int) this.myskill.damage / Class15.smethod_0(21)).ToString() + Class13.smethod_0(28630) + GClass109.string_369, this.cx, this.cy - this.ch - Class15.smethod_0(51), Class15.smethod_0(0), -1, GClass97.int_12);
                  if (this.cMP < this.cMPFull)
                    GClass116.smethod_17(Class13.smethod_0(28656) + (this.cMPFull * (int) this.myskill.damage / Class15.smethod_0(21)).ToString() + Class13.smethod_0(28630) + GClass109.string_370, this.cx, this.cy - this.ch - Class15.smethod_0(51), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_13);
                  GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(7));
                }
              }
            }
            if (this.isFlyUp)
            {
              if (this.me)
              {
                GClass20.bool_3 = Class15.smethod_0(1) != 0;
                this.statusMe = Class15.smethod_0(5);
                this.cvy = Class15.smethod_0(193);
                if (this.cy <= GClass185.int_24 - Class15.smethod_0(194))
                {
                  this.isFlyUp = Class15.smethod_0(0) != 0;
                  GClass20.bool_3 = Class15.smethod_0(0) != 0;
                  this.statusMe = Class15.smethod_0(2);
                }
              }
              else
              {
                this.statusMe = Class15.smethod_0(5);
                this.cvy = Class15.smethod_0(193);
                if (this.cy <= GClass185.int_24 - Class15.smethod_0(194))
                {
                  this.cvy = Class15.smethod_0(0);
                  this.isFlyUp = Class15.smethod_0(0) != 0;
                  this.cvy = Class15.smethod_0(0);
                  this.statusMe = Class15.smethod_0(1);
                }
              }
            }
            this.method_49();
            this.method_140();
            this.method_142();
            this.method_145();
          }
        }
      }
    }
  }

  private void method_20()
  {
    if ((this.effPaints == null ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < this.effPaints.Length; index += Class15.smethod_0(1))
      {
        if ((this.effPaints[index] == null ? 1 : 0) == 0)
        {
          if ((this.effPaints[index].eMob == null ? 1 : 0) == 0)
          {
            if ((!this.effPaints[index].isFly ? 0 : 1) == 0)
            {
              this.effPaints[index].eMob.method_9();
              this.effPaints[index].eMob.injureBy = this;
              if ((!this.me ? 1 : 0) == 0)
                this.effPaints[index].eMob.hpInjure = GClass20.smethod_1().cDamFull / Class15.smethod_0(7) - GClass20.smethod_1().cDamFull * GClass138.smethod_1(Class15.smethod_0(67)) / Class15.smethod_0(21);
              int num = this.effPaints[index].eMob.h >> Class15.smethod_0(1);
              if ((!this.effPaints[index].eMob.method_0() ? 1 : 0) == 0)
                num = this.effPaints[index].eMob.imethod_1() + Class15.smethod_0(51);
              GClass116.smethod_20(this.effPaints[index].eMob.x, this.effPaints[index].eMob.y - num, this.cdir);
              this.effPaints[index].isFly = Class15.smethod_0(1) != 0;
            }
          }
          else if ((this.effPaints[index].eChar == null ? 1 : 0) == 0 && (!this.effPaints[index].isFly ? 0 : 1) == 0)
          {
            if (this.effPaints[index].eChar.charID >= Class15.smethod_0(0))
              this.effPaints[index].eChar.method_109();
            GClass116.smethod_20(this.effPaints[index].eChar.cx, this.effPaints[index].eChar.cy - (this.effPaints[index].eChar.ch >> Class15.smethod_0(1)), this.cdir);
            this.effPaints[index].isFly = Class15.smethod_0(1) != 0;
          }
          this.effPaints[index].index += Class15.smethod_0(1);
          if (this.effPaints[index].index >= this.effPaints[index].effCharPaint.arrEfInfo.Length)
            this.effPaints[index] = (GClass52) null;
        }
      }
    }
    if (this.indexEff >= Class15.smethod_0(0) && (this.eff == null ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
    {
      this.indexEff += Class15.smethod_0(1);
      if (this.indexEff >= this.eff.arrEfInfo.Length)
      {
        this.indexEff = -1;
        this.eff = (GClass49) null;
      }
    }
    if (this.indexEffTask < Class15.smethod_0(0) || (this.effTask == null ? 1 : 0) != 0 || (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) != 0)
      return;
    this.indexEffTask += Class15.smethod_0(1);
    if (this.indexEffTask < this.effTask.arrEfInfo.Length)
      return;
    this.indexEffTask = -1;
    this.effTask = (GClass49) null;
  }

  private void method_21()
  {
    if ((this.endMovePointCommand == null ? 1 : 0) != 0)
      return;
    GClass31 movePointCommand = this.endMovePointCommand;
    this.endMovePointCommand = (GClass31) null;
    movePointCommand.method_1();
  }

  private void method_22()
  {
    if ((GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) != 0 || this.charID < Class15.smethod_0(0))
      return;
    this.paintName = Class15.smethod_0(1) != 0;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
    {
      GClass20 gclass20 = (GClass20) null;
      try
      {
        gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
      }
      catch (Exception ex)
      {
      }
      if ((gclass20 == null ? 1 : 0) == 0 && (!gclass20.Equals((object) this) ? 0 : 1) == 0 && (gclass20.cy == this.cy && GClass151.smethod_25(gclass20.cx - this.cx) < Class15.smethod_0(95) || this.cy - gclass20.cy < Class15.smethod_0(120) && this.cy - gclass20.cy > Class15.smethod_0(0) && GClass151.smethod_25(gclass20.cx - this.cx) < Class15.smethod_0(40)))
        this.paintName = Class15.smethod_0(0) != 0;
    }
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
    {
      GClass21 gclass21 = (GClass21) null;
      try
      {
        gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
      }
      catch (Exception ex)
      {
      }
      if ((gclass21 == null ? 1 : 0) == 0 && gclass21.cy == this.cy && GClass151.smethod_25(gclass21.cx - this.cx) < Class15.smethod_0(40))
        this.paintName = Class15.smethod_0(0) != 0;
    }
  }

  private void method_23()
  {
    if ((this.tMobMeBorn == 0 ? 1 : 0) == 0)
      this.tMobMeBorn -= Class15.smethod_0(1);
    if ((this.tMobMeBorn == 0 ? 0 : 1) != 0)
      return;
    this.mobMe.xFirst = this.cdir != Class15.smethod_0(1) ? this.cx + Class15.smethod_0(6) : this.cx - Class15.smethod_0(6);
    this.mobMe.yFirst = this.cy - Class15.smethod_0(4);
    int num1 = this.mobMe.xFirst - this.mobMe.x;
    int num2 = this.mobMe.yFirst - this.mobMe.y;
    this.mobMe.x += num1 / Class15.smethod_0(2);
    this.mobMe.y += num2 / Class15.smethod_0(2);
    this.mobMe.dir = this.cdir;
  }

  private void method_24()
  {
    if (this.statusMe == Class15.smethod_0(49) || this.statusMe == Class15.smethod_0(3))
      return;
    if (this.skillPaint != null && (this.charFocus != null && this.method_115(this.charFocus) && this.charFocus.statusMe == Class15.smethod_0(49) || this.mobFocus != null && this.mobFocus.status == 0))
    {
      if (!this.me)
      {
        this.statusMe = (GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7) ? Class15.smethod_0(37) : Class15.smethod_0(1);
        this.cp3 = Class15.smethod_0(0);
      }
      this.indexSkill = Class15.smethod_0(0);
      this.skillPaint = (GClass165) null;
      this.skillPaintRandomPaint = (GClass165) null;
      this.eff0 = this.eff1 = this.eff2 = (GClass49) null;
      this.i0 = this.i1 = this.i2 = Class15.smethod_0(0);
      this.mobFocus = (GClass100) null;
      this.charFocus = (GClass20) null;
      this.effPaints = (GClass52[]) null;
      this.currentMovePoint = (GClass108) null;
      this.arr = (GClass2) null;
      if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7))
        this.delayFall = Class15.smethod_0(3);
    }
    if (this.skillPaint != null && this.arr == null && this.method_71() != null && this.indexSkill >= this.method_71().Length)
    {
      if (!this.me)
      {
        this.statusMe = (GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7) ? Class15.smethod_0(37) : Class15.smethod_0(1);
        this.cp3 = Class15.smethod_0(0);
      }
      this.indexSkill = Class15.smethod_0(0);
      GClass151.smethod_7(Class13.smethod_0(143737));
      this.skillPaint = (GClass165) null;
      this.skillPaintRandomPaint = (GClass165) null;
      this.eff0 = this.eff1 = this.eff2 = (GClass49) null;
      this.i0 = this.i1 = this.i2 = Class15.smethod_0(0);
      this.arr = (GClass2) null;
      if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7))
        this.delayFall = Class15.smethod_0(3);
    }
    GClass162[] gclass162Array1 = this.method_71();
    if (gclass162Array1 == null || this.indexSkill < Class15.smethod_0(0) || this.indexSkill > gclass162Array1.Length - Class15.smethod_0(1))
      return;
    if (gclass162Array1[this.indexSkill].effS0Id != 0)
    {
      this.eff0 = GClass116.gclass49_0[gclass162Array1[this.indexSkill].effS0Id - Class15.smethod_0(1)];
      this.i0 = this.dx0 = this.dy0 = Class15.smethod_0(0);
    }
    if (gclass162Array1[this.indexSkill].effS1Id != 0)
    {
      this.eff1 = GClass116.gclass49_0[gclass162Array1[this.indexSkill].effS1Id - Class15.smethod_0(1)];
      this.i1 = this.dx1 = this.dy1 = Class15.smethod_0(0);
    }
    if (gclass162Array1[this.indexSkill].effS2Id != 0)
    {
      this.eff2 = GClass116.gclass49_0[gclass162Array1[this.indexSkill].effS2Id - Class15.smethod_0(1)];
      this.i2 = this.dx2 = this.dy2 = Class15.smethod_0(0);
    }
    GClass162[] gclass162Array2 = gclass162Array1;
    int indexSkill = this.indexSkill;
    if (gclass162Array2 != null && gclass162Array2[indexSkill] != null && indexSkill >= Class15.smethod_0(0) && indexSkill <= gclass162Array2.Length - Class15.smethod_0(1) && gclass162Array2[indexSkill].arrowId != 0)
    {
      int arrowId = gclass162Array2[indexSkill].arrowId;
      if (arrowId >= Class15.smethod_0(21))
      {
        GInterface3 ginterface3 = this.mobFocus != null ? (GInterface3) this.mobFocus : (GInterface3) this.charFocus;
        if (ginterface3 != null)
        {
          Class15.smethod_0(0);
          int num1 = GClass151.smethod_25(ginterface3.imethod_0() - this.cx);
          int num2 = GClass151.smethod_25(ginterface3.imethod_1() - this.cy);
          int num3 = Class15.smethod_0(2) * num2;
          int num4;
          if (num1 > num3)
          {
            num4 = Class15.smethod_0(0);
          }
          else
          {
            num4 = ginterface3.imethod_1() >= this.cy ? Class15.smethod_0(5) : Class15.smethod_0(134);
            if (ginterface3 is GClass104 && ((GClass104) ginterface3).haftBody)
              num4 = Class15.smethod_0(188);
          }
          this.dart = new GClass145(this, arrowId - Class15.smethod_0(21), this.skillPaintRandomPaint, this.cx + (gclass162Array2[indexSkill].adx - Class15.smethod_0(31)) * this.cdir, this.cy + gclass162Array2[indexSkill].ady + num4);
          if (this.myskill != null)
          {
            if ((int) this.myskill.template.id == Class15.smethod_0(1))
              GClass172.smethod_1().method_24();
            else if ((int) this.myskill.template.id == Class15.smethod_0(5))
              GClass172.smethod_1().method_25();
            else if ((int) this.myskill.template.id == Class15.smethod_0(3))
              GClass172.smethod_1().method_27();
            else if ((int) this.myskill.template.id == Class15.smethod_0(67))
              GClass172.smethod_1().method_26();
          }
        }
        else if (this.isFlyAndCharge || this.isUseSkillAfterCharge)
          this.method_68();
      }
      else
      {
        GClass151.smethod_7(Class13.smethod_0(143709));
        this.arr = new GClass2(this, GClass116.gclass3_0[arrowId - Class15.smethod_0(1)]);
        this.arr.life = Class15.smethod_0(31);
        this.arr.ax = this.cx + gclass162Array2[indexSkill].adx;
        this.arr.ay = this.cy + gclass162Array2[indexSkill].ady;
      }
    }
    if ((this.mobFocus != null || !this.me && this.charFocus != null || this.me && this.charFocus != null && (this.method_115(this.charFocus) || this.method_63()) && this.arr == null && this.dart == null) && this.indexSkill == gclass162Array1.Length - Class15.smethod_0(1))
    {
      this.method_72();
      if (this.me && this.myskill.template.method_2())
        this.method_25();
    }
    if (this.me)
      return;
    GInterface3 ginterface3_1 = (GInterface3) null;
    if (this.mobFocus != null)
      ginterface3_1 = (GInterface3) this.mobFocus;
    else if (this.charFocus != null)
      ginterface3_1 = (GInterface3) this.charFocus;
    if (ginterface3_1 == null)
      return;
    if (GClass151.smethod_25(ginterface3_1.imethod_0() - this.cx) < Class15.smethod_0(31))
    {
      if (ginterface3_1.imethod_0() > this.cx)
        this.cx -= Class15.smethod_0(31);
      else
        this.cx += Class15.smethod_0(31);
    }
    if (ginterface3_1.imethod_0() > this.cx)
      this.cdir = Class15.smethod_0(1);
    else
      this.cdir = -1;
  }

  public void method_25()
  {
  }

  public void method_26(int x, int y)
  {
    GClass71.smethod_5();
    this.currentMovePoint = (GClass108) null;
    if ((this.cy - y == 0 ? 0 : 1) == 0)
    {
      this.cx = x;
      GClass20.bool_2 = Class15.smethod_0(0) != 0;
      GClass20.bool_3 = Class15.smethod_0(0) != 0;
    }
    else
    {
      this.statusMe = Class15.smethod_0(10);
      this.cp2 = x;
      this.cp3 = y;
      this.cp1 = Class15.smethod_0(0);
      GClass20.smethod_1().cxSend = x;
      GClass20.smethod_1().cySend = y;
    }
  }

  private void method_27()
  {
    this.isFreez = Class15.smethod_0(0) != 0;
    if ((!this.isCharge ? 1 : 0) == 0)
    {
      this.isCharge = Class15.smethod_0(0) != 0;
      GClass172.smethod_1().method_45();
      GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(5));
    }
    this.cp1 += Class15.smethod_0(1);
    this.cx += (this.cp2 - this.cx) / Class15.smethod_0(2);
    if (this.cp1 > Class15.smethod_0(38))
      this.cy += (this.cp3 - this.cy) / Class15.smethod_0(2);
    else
      this.cy += this.cp1 - Class15.smethod_0(31);
    if (GClass151.smethod_25(this.cp2 - this.cx) < Class15.smethod_0(2) && GClass151.smethod_25(this.cp3 - this.cy) < Class15.smethod_0(31))
    {
      this.cx = this.cp2;
      this.cy = this.cp3;
      this.statusMe = Class15.smethod_0(49);
      if ((!this.me ? 1 : 0) == 0)
      {
        GClass116.smethod_6().method_34();
        GClass156.smethod_0().method_45();
      }
    }
    this.cf = Class15.smethod_0(29);
  }

  private void method_28()
  {
    GClass71.smethod_5();
    GClass62.smethod_46();
    this.currentMovePoint = (GClass108) null;
    this.cp1 += Class15.smethod_0(1);
    this.cx += (this.cp2 - this.cx) / Class15.smethod_0(2);
    if (this.cp1 > Class15.smethod_0(38))
      this.cy += (this.cp3 - this.cy) / Class15.smethod_0(2);
    else
      this.cy += this.cp1 - Class15.smethod_0(31);
    if (GClass151.smethod_25(this.cp2 - this.cx) < Class15.smethod_0(2) && GClass151.smethod_25(this.cp3 - this.cy) < Class15.smethod_0(31))
    {
      this.cx = this.cp2;
      this.cy = this.cp3;
      this.statusMe = Class15.smethod_0(1);
      this.cp3 = Class15.smethod_0(0);
      GClass20.bool_2 = Class15.smethod_0(0) != 0;
      GClass156.smethod_0().method_45();
    }
    this.cf = Class15.smethod_0(29);
  }

  public void method_29()
  {
  }

  public void method_30()
  {
    this.ty = Class15.smethod_0(0);
    this.cp1 += Class15.smethod_0(1);
    if (this.cdir == Class15.smethod_0(1))
    {
      if ((GClass185.smethod_26(this.cx + this.chw, this.cy - this.chh) & Class15.smethod_0(2)) == Class15.smethod_0(2))
        this.cvx = Class15.smethod_0(0);
    }
    else if ((GClass185.smethod_26(this.cx - this.chw, this.cy - this.chh) & Class15.smethod_0(88)) == Class15.smethod_0(88))
      this.cvx = Class15.smethod_0(0);
    if (this.cy > this.ch && (!GClass185.smethod_27(this.cx, this.cy - this.ch + Class15.smethod_0(40), Class15.smethod_0(189)) ? 1 : 0) == 0)
    {
      if ((!GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)) ? 0 : 1) == 0)
      {
        this.statusMe = Class15.smethod_0(2);
        this.cp1 = Class15.smethod_0(0);
        this.cp2 = Class15.smethod_0(0);
        this.cvy = Class15.smethod_0(1);
      }
      else
        this.cy = GClass185.smethod_31(this.cy);
    }
    this.cx += this.cvx;
    this.cy += this.cvy;
    if (this.cy < Class15.smethod_0(0))
      this.cy = this.cvy = Class15.smethod_0(0);
    if ((this.cvy == 0 ? 0 : 1) == 0)
    {
      if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7))
      {
        this.statusMe = Class15.smethod_0(2);
        this.cvx = (this.cspeed >> Class15.smethod_0(1)) * this.cdir;
        this.cp1 = this.cp2 = Class15.smethod_0(0);
      }
    }
    else if (this.cvy < Class15.smethod_0(0))
    {
      this.cvy += Class15.smethod_0(1);
      if ((this.cvy == 0 ? 0 : 1) == 0)
        this.cvy = Class15.smethod_0(1);
    }
    else
    {
      if (this.cvy < Class15.smethod_0(51) && (this.cp1 % Class15.smethod_0(3) == 0 ? 0 : 1) == 0)
        this.cvy += Class15.smethod_0(1);
      if (this.cvy > Class15.smethod_0(5))
        this.cvy = Class15.smethod_0(5);
      if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(5)) & Class15.smethod_0(7)) == Class15.smethod_0(7) && this.cy <= GClass185.smethod_32(this.cy + Class15.smethod_0(5)))
      {
        this.cvx = this.cvy = Class15.smethod_0(0);
        this.cy = GClass185.smethod_32(this.cy + Class15.smethod_0(5));
      }
    }
    if (this.cvx > Class15.smethod_0(0))
    {
      this.cvx -= Class15.smethod_0(1);
    }
    else
    {
      if (this.cvx >= Class15.smethod_0(0))
        return;
      this.cvx += Class15.smethod_0(1);
    }
  }

  public void method_31()
  {
    this.isFreez = Class15.smethod_0(0) != 0;
    if ((!this.isCharge ? 1 : 0) == 0)
    {
      this.isCharge = Class15.smethod_0(0) != 0;
      GClass172.smethod_1().method_45();
      GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(5));
    }
    this.cx += this.cvx * this.cdir;
    this.cy += this.cvyJump;
    this.cvyJump += Class15.smethod_0(1);
    this.cf = (this.cp1 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(29) : Class15.smethod_0(38);
    if (this.cvyJump == Class15.smethod_0(134))
      this.cf = Class15.smethod_0(88);
    else if (this.cvyJump == Class15.smethod_0(132))
      this.cf = Class15.smethod_0(45);
    else if (this.cvyJump == -1)
      this.cf = Class15.smethod_0(31);
    else if ((this.cvyJump == 0 ? 0 : 1) == 0)
      this.cf = Class15.smethod_0(67);
    if ((this.cvyJump == 0 ? 0 : 1) != 0)
      return;
    this.statusMe = Class15.smethod_0(37);
    this.cp3 = Class15.smethod_0(0);
    ((GClass108) this.vMovePoints.method_11()).status = Class15.smethod_0(2);
    this.isJump = Class15.smethod_0(1) != 0;
    this.cp1 = Class15.smethod_0(0);
    this.cvy = Class15.smethod_0(1);
  }

  public int method_32(int size, int dx, int dy)
  {
    if (dy > Class15.smethod_0(0) && (!GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)) ? 0 : 1) == 0)
    {
      if (dx - dy <= Class15.smethod_0(31))
        return Class15.smethod_0(3);
      if (dx - dy <= Class15.smethod_0(6))
        return Class15.smethod_0(37);
      if (dx - dy <= Class15.smethod_0(32))
        return Class15.smethod_0(38);
      if (dx - dy <= Class15.smethod_0(152))
        return Class15.smethod_0(88);
    }
    if (dx <= Class15.smethod_0(6))
      return Class15.smethod_0(2);
    if (dx <= Class15.smethod_0(195))
      return Class15.smethod_0(3);
    if (dx <= Class15.smethod_0(196))
      return Class15.smethod_0(37);
    return dx <= Class15.smethod_0(197) ? Class15.smethod_0(38) : Class15.smethod_0(88);
  }

  public void method_33()
  {
    this.bool_6 = Class15.smethod_0(1) != 0;
    GClass40.smethod_0(new GClass41(Class15.smethod_0(12), this.cx, this.cy + Class15.smethod_0(46), Class15.smethod_0(5), Class15.smethod_0(9), Class15.smethod_0(1)));
  }

  public void method_34()
  {
    this.bool_6 = Class15.smethod_0(0) != 0;
    GClass40.smethod_0(new GClass41(Class15.smethod_0(12), this.cx, this.cy + Class15.smethod_0(46), Class15.smethod_0(5), Class15.smethod_0(31), Class15.smethod_0(1)));
  }

  public int method_35(int size, int dx, int dy)
  {
    if (dy <= Class15.smethod_0(31))
      return Class15.smethod_0(3);
    if (dy <= Class15.smethod_0(51))
      return Class15.smethod_0(37);
    if (dy <= Class15.smethod_0(6))
      return Class15.smethod_0(38);
    if (dy <= Class15.smethod_0(54))
      return Class15.smethod_0(88);
    return dy <= Class15.smethod_0(32) ? Class15.smethod_0(45) : Class15.smethod_0(31);
  }

  public int method_36(int xFirst, int yFirst, int xEnd, int yEnd)
  {
    int num1 = xEnd - xFirst;
    int num2 = yEnd - yFirst;
    if ((num1 == 0 ? 0 : 1) == 0 && (num2 == 0 ? 0 : 1) == 0)
      return Class15.smethod_0(1);
    if ((num2 == 0 ? 0 : 1) == 0 && (yFirst % Class15.smethod_0(40) == 0 ? 0 : 1) == 0 && (!GClass185.smethod_27(xFirst, yFirst, Class15.smethod_0(7)) ? 1 : 0) == 0)
      return Class15.smethod_0(7);
    if (num2 > Class15.smethod_0(0) && ((yFirst % Class15.smethod_0(40) == 0 ? 0 : 1) != 0 || (!GClass185.smethod_27(xFirst, yFirst, Class15.smethod_0(7)) ? 0 : 1) == 0))
      return Class15.smethod_0(2);
    this.cvy = Class15.smethod_0(136);
    this.cp1 = Class15.smethod_0(0);
    this.cdir = num1 > Class15.smethod_0(0) ? Class15.smethod_0(1) : -1;
    this.cvx = num1 > Class15.smethod_0(3) ? (num1 > Class15.smethod_0(31) ? Class15.smethod_0(3) : Class15.smethod_0(5)) : Class15.smethod_0(0);
    return Class15.smethod_0(45);
  }

  public void method_37()
  {
    int num = ((GClass108) this.vMovePoints.method_11()).xEnd - this.cx;
    this.cvyJump = Class15.smethod_0(136);
    this.cp1 = Class15.smethod_0(0);
    this.cdir = num > Class15.smethod_0(0) ? Class15.smethod_0(1) : -1;
    if (num <= Class15.smethod_0(37))
      this.cvx = Class15.smethod_0(0);
    else if (num <= Class15.smethod_0(51))
      this.cvx = Class15.smethod_0(5);
    else
      this.cvx = Class15.smethod_0(3);
  }

  public void method_38()
  {
    this.bool_5 = Class15.smethod_0(0) != 0;
    this.isAttack = Class15.smethod_0(0) != 0;
    this.isAttFly = Class15.smethod_0(0) != 0;
    this.cvx = Class15.smethod_0(0);
    this.cvy = Class15.smethod_0(0);
    this.cp1 += Class15.smethod_0(1);
    if (this.cp1 > Class15.smethod_0(6))
      this.cp1 = Class15.smethod_0(0);
    this.cf = this.cp1 % Class15.smethod_0(9) >= Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0);
    this.method_106();
    if ((!this.me ? 0 : 1) == 0)
    {
      this.cp3 += Class15.smethod_0(1);
      if (this.cp3 > Class15.smethod_0(32))
      {
        this.cp3 = Class15.smethod_0(0);
        this.currentMovePoint = (GClass108) null;
      }
    }
    this.method_39();
    if ((!this.me ? 1 : 0) != 0 || (GClass116.gclass134_5.method_2() == 0 ? 1 : 0) != 0 || GClass185.int_37 != Class15.smethod_0(32))
      return;
    GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(Class15.smethod_0(0));
    if ((!gclass20.changePos ? 0 : 1) == 0)
    {
      if (gclass20.statusMe != Class15.smethod_0(7))
        gclass20.method_96(this.cx - Class15.smethod_0(70), this.cy, Class15.smethod_0(0));
      gclass20.lastUpdateTime = GClass126.smethod_18();
      if (GClass151.smethod_25(this.cx - Class15.smethod_0(70) - gclass20.cx) <= Class15.smethod_0(31))
        gclass20.changePos = Class15.smethod_0(1) != 0;
    }
    else
    {
      if (gclass20.statusMe != Class15.smethod_0(7))
        gclass20.method_96(this.cx + Class15.smethod_0(70), this.cy, Class15.smethod_0(0));
      gclass20.lastUpdateTime = GClass126.smethod_18();
      if (GClass151.smethod_25(this.cx + Class15.smethod_0(70) - gclass20.cx) <= Class15.smethod_0(31))
        gclass20.changePos = Class15.smethod_0(0) != 0;
    }
    if ((GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) != 0)
      return;
    gclass20.method_7(Class13.smethod_0(144392));
  }

  public void method_39()
  {
    if ((!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || (!this.isCopy ? 0 : 1) != 0 || (!this.isFusion ? 0 : 1) != 0 || (!this.bool_15 ? 0 : 1) != 0 || (!this.isPet ? 0 : 1) != 0 || (!this.isMiniPet ? 0 : 1) != 0 || (int) this.isMonkey == Class15.smethod_0(1))
      return;
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((!GClass20.bool_18 ? 0 : 1) == 0 && this.idAuraEff > (short) -1)
        return;
    }
    else if (this.idAuraEff > (short) -1)
      return;
    this.ty += Class15.smethod_0(1);
    if (this.clevel >= Class15.smethod_0(49))
      return;
    if (this.clevel >= Class15.smethod_0(45) && (!GClass62.bool_1 ? 0 : 1) == 0 && (this.ty == Class15.smethod_0(54) || this.ty == Class15.smethod_0(32)))
    {
      GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
      GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
      this.method_120(Class15.smethod_0(1));
    }
    if (this.ty <= Class15.smethod_0(32) || this.clevel < Class15.smethod_0(45))
      return;
    if ((this.cgender == 0 ? 0 : 1) == 0)
    {
      if ((GClass62.int_8 % Class15.smethod_0(46) == 0 ? 0 : 1) == 0)
        GClass47.smethod_3(Class15.smethod_0(24), this, Class15.smethod_0(1));
      if (this.clevel >= Class15.smethod_0(47) && (GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
        GClass47.smethod_3(Class15.smethod_0(198), this, Class15.smethod_0(1));
    }
    if (this.cgender == Class15.smethod_0(1))
    {
      if ((GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
        GClass47.smethod_3(Class15.smethod_0(198), this, Class15.smethod_0(1));
      if (this.clevel >= Class15.smethod_0(47) && (GClass62.int_8 % Class15.smethod_0(38) == 0 ? 0 : 1) == 0)
        GClass47.smethod_3(Class15.smethod_0(77), this, Class15.smethod_0(1));
    }
    if (this.cgender != Class15.smethod_0(7))
      return;
    if ((GClass62.int_8 % Class15.smethod_0(38) == 0 ? 0 : 1) == 0)
      GClass47.smethod_3(Class15.smethod_0(77), this, Class15.smethod_0(1));
    if (this.clevel < Class15.smethod_0(47) || (GClass62.int_8 % Class15.smethod_0(46) == 0 ? 0 : 1) != 0)
      return;
    GClass47.smethod_3(Class15.smethod_0(24), this, Class15.smethod_0(1));
  }

  public float method_40()
  {
    if ((!this.me ? 1 : 0) == 0)
      return Class15.smethod_2(12);
    int num = GClass151.smethod_25(GClass20.gclass20_0.cx - this.cx);
    return num >= Class15.smethod_0(0) && num <= Class15.smethod_0(32) ? Class15.smethod_2(12) : Class15.smethod_2(15);
  }

  public void method_41()
  {
    int num1 = (int) this.isMonkey != Class15.smethod_0(1) || (!this.me ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(7);
    if (this.cx >= GClass116.int_22 && this.cx <= GClass116.int_22 + GClass62.int_10)
    {
      if ((this.isMonkey == (sbyte) 0 ? 0 : 1) == 0)
        GClass172.smethod_1().method_29(this.method_40());
      else
        GClass172.smethod_1().method_30(this.method_40());
    }
    this.ty = Class15.smethod_0(0);
    this.isFreez = Class15.smethod_0(0) != 0;
    if ((!this.isCharge ? 1 : 0) == 0)
    {
      this.isCharge = Class15.smethod_0(0) != 0;
      GClass172.smethod_1().method_45();
      GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(5));
    }
    int num2 = Class15.smethod_0(0);
    if ((!this.me ? 0 : 1) == 0 && (this.currentMovePoint == null ? 1 : 0) == 0)
      num2 = GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd);
    this.cp1 += Class15.smethod_0(1);
    if (this.cp1 >= Class15.smethod_0(31))
    {
      this.cp1 = Class15.smethod_0(0);
      this.cBonusSpeed = Class15.smethod_0(0);
    }
    this.cf = (this.cp1 >> Class15.smethod_0(1)) + Class15.smethod_0(7);
    if ((GClass185.smethod_26(this.cx, this.cy - Class15.smethod_0(1)) & Class15.smethod_0(199)) == Class15.smethod_0(199))
      this.cx += this.cvx * num1 >> Class15.smethod_0(1);
    else
      this.cx += this.cvx * num1;
    if (this.cdir == Class15.smethod_0(1))
    {
      if ((!GClass185.smethod_27(this.cx + this.chw, this.cy - this.chh, Class15.smethod_0(2)) ? 1 : 0) == 0)
      {
        if ((!this.me ? 1 : 0) == 0)
        {
          this.cvx = Class15.smethod_0(0);
          this.cx = GClass185.smethod_32(this.cx + this.chw) - this.chw;
        }
        else
          this.method_42();
      }
    }
    else if ((!GClass185.smethod_27(this.cx - this.chw - Class15.smethod_0(1), this.cy - this.chh, Class15.smethod_0(88)) ? 1 : 0) == 0)
    {
      if ((!this.me ? 1 : 0) == 0)
      {
        this.cvx = Class15.smethod_0(0);
        this.cx = GClass185.smethod_32(this.cx - this.chw - Class15.smethod_0(1)) + (int) GClass185.sbyte_0 + this.chw;
      }
      else
        this.method_42();
    }
    if ((!this.me ? 1 : 0) == 0)
    {
      if (this.cvx > Class15.smethod_0(0))
        this.cvx -= Class15.smethod_0(1);
      else if (this.cvx < Class15.smethod_0(0))
      {
        this.cvx += Class15.smethod_0(1);
      }
      else
      {
        if ((this.cx - this.cxSend == 0 ? 1 : 0) == 0 && (!this.me ? 1 : 0) == 0)
          GClass156.smethod_0().method_45();
        this.statusMe = Class15.smethod_0(1);
        this.cBonusSpeed = Class15.smethod_0(0);
      }
    }
    if ((GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) != Class15.smethod_0(7))
    {
      if ((!this.me ? 1 : 0) == 0)
      {
        if ((this.cx - this.cxSend == 0 ? 0 : 1) != 0 || (this.cy - this.cySend == 0 ? 1 : 0) == 0)
          GClass156.smethod_0().method_45();
        this.cf = Class15.smethod_0(38);
        this.statusMe = Class15.smethod_0(2);
        this.delayFall = Class15.smethod_0(0);
        this.cvx = Class15.smethod_0(5) * this.cdir;
        this.cp2 = Class15.smethod_0(0);
      }
      else
        this.method_42();
    }
    if ((!this.me ? 0 : 1) == 0 && (this.currentMovePoint == null ? 1 : 0) == 0 && GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd) > num2)
      this.method_42();
    GClass62.smethod_1().method_23(this.cdir, this.cx - (this.cdir << Class15.smethod_0(5)), this.cy);
    this.method_106();
    this.method_120(Class15.smethod_0(7));
  }

  private void method_42()
  {
    this.statusMe = Class15.smethod_0(37);
    this.cp3 = Class15.smethod_0(0);
    this.cvx = Class15.smethod_0(0);
    this.cvy = Class15.smethod_0(0);
    this.cp1 = this.cp2 = Class15.smethod_0(0);
  }

  public static int smethod_4(int i) => i > Class15.smethod_0(0) ? i : -i;

  public void method_43()
  {
    this.method_54();
    this.ty = Class15.smethod_0(0);
    this.isFreez = Class15.smethod_0(0) != 0;
    if ((!this.isCharge ? 1 : 0) == 0)
    {
      this.isCharge = Class15.smethod_0(0) != 0;
      GClass172.smethod_1().method_45();
      GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(5));
    }
    this.method_120(Class15.smethod_0(5));
    this.cx += this.cvx;
    this.cy += this.cvy;
    if (this.cy < Class15.smethod_0(0))
    {
      this.cy = Class15.smethod_0(0);
      this.cvy = -1;
    }
    this.cvy += Class15.smethod_0(1);
    if (this.cvy > Class15.smethod_0(0))
      this.cvy = Class15.smethod_0(0);
    if ((!this.me ? 0 : 1) == 0 && (this.currentMovePoint == null ? 1 : 0) == 0)
    {
      int num = this.currentMovePoint.xEnd - this.cx;
      if (num > Class15.smethod_0(0))
      {
        if (this.cvx > num)
          this.cvx = num;
        if (this.cvx < Class15.smethod_0(0))
          this.cvx = num;
      }
      else if (num < Class15.smethod_0(0))
      {
        if (this.cvx < num)
          this.cvx = num;
        if (this.cvx > Class15.smethod_0(0))
          this.cvx = num;
      }
      else
        this.cvx = num;
    }
    if (this.cdir == Class15.smethod_0(1))
    {
      if ((GClass185.smethod_26(this.cx + this.chw, this.cy - Class15.smethod_0(1)) & Class15.smethod_0(2)) == Class15.smethod_0(2) && this.cx <= GClass185.smethod_32(this.cx + this.chw) + Class15.smethod_0(66))
      {
        this.cx = GClass185.smethod_32(this.cx + this.chw) - this.chw;
        this.cvx = Class15.smethod_0(0);
      }
    }
    else if ((GClass185.smethod_26(this.cx - this.chw, this.cy - Class15.smethod_0(1)) & Class15.smethod_0(88)) == Class15.smethod_0(88) && this.cx >= GClass185.smethod_32(this.cx - this.chw) + Class15.smethod_0(66))
    {
      this.cx = GClass185.smethod_32(this.cx + Class15.smethod_0(40) - this.chw) + this.chw;
      this.cvx = Class15.smethod_0(0);
    }
    if ((this.cvy == 0 ? 0 : 1) == 0)
    {
      if ((!this.isAttFly ? 0 : 1) == 0)
      {
        if ((!this.me ? 1 : 0) == 0)
          this.method_45();
        else
          this.method_42();
      }
      else
        this.method_45();
    }
    if ((!this.me ? 1 : 0) == 0 && (!GClass20.bool_2 ? 0 : 1) == 0 && (!this.method_15() ? 1 : 0) == 0)
    {
      GClass156.smethod_0().method_45();
      if ((!GClass185.smethod_2() ? 1 : 0) == 0)
      {
        GClass20.bool_2 = Class15.smethod_0(1) != 0;
        GClass156.smethod_0().method_115();
      }
      else
        GClass156.smethod_0().method_41();
      GClass20.bool_3 = Class15.smethod_0(1) != 0;
      GClass20.bool_2 = Class15.smethod_0(1) != 0;
      GClass62.smethod_25();
      GClass62.smethod_24();
      GClass71.smethod_1();
    }
    else
    {
      if (this.statusMe != Class15.smethod_0(10) && ((!GClass185.smethod_27(this.cx, this.cy - this.ch + Class15.smethod_0(40), Class15.smethod_0(189)) ? 0 : 1) != 0 || this.cy < Class15.smethod_0(0)))
      {
        this.statusMe = Class15.smethod_0(2);
        this.cp1 = Class15.smethod_0(0);
        this.cp2 = Class15.smethod_0(0);
        this.cvy = Class15.smethod_0(1);
        this.delayFall = Class15.smethod_0(0);
        if (this.cy < Class15.smethod_0(0))
          this.cy = Class15.smethod_0(0);
        this.cy = GClass185.smethod_31(this.cy + Class15.smethod_0(46));
        GClass62.smethod_25();
      }
      if (this.cp3 < Class15.smethod_0(0))
        this.cp3 += Class15.smethod_0(1);
      this.cf = Class15.smethod_0(38);
      if ((!this.me ? 0 : 1) != 0 || (this.currentMovePoint == null ? 1 : 0) != 0 || this.cy >= this.currentMovePoint.yEnd)
        return;
      this.method_42();
    }
  }

  public bool method_44(int x1, int xw1, int xmob, int y1, int yh1, int ymob) => xmob <= xw1 && xmob >= x1 && ymob <= y1 && ymob >= yh1 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public void method_45()
  {
    this.cyStartFall = this.cy;
    this.cp1 = Class15.smethod_0(0);
    this.cp2 = Class15.smethod_0(0);
    this.statusMe = Class15.smethod_0(31);
    this.cvx = this.cdir << Class15.smethod_0(7);
    this.cvy = Class15.smethod_0(0);
    this.cy = GClass185.smethod_31(this.cy) + Class15.smethod_0(66);
    if ((!this.me ? 1 : 0) != 0 || (this.cx - this.cxSend == 0 ? 0 : 1) == 0 && (this.cy - this.cySend == 0 ? 1 : 0) != 0 || GClass151.smethod_25(GClass20.smethod_1().cx - GClass20.smethod_1().cxSend) <= Class15.smethod_0(150) && GClass151.smethod_25(GClass20.smethod_1().cy - GClass20.smethod_1().cySend) <= Class15.smethod_0(40))
      return;
    GClass156.smethod_0().method_45();
  }

  public void method_46()
  {
    if (this.holder)
      return;
    this.ty = Class15.smethod_0(0);
    if (this.cy + Class15.smethod_0(2) >= GClass185.int_24)
    {
      this.statusMe = Class15.smethod_0(1);
      if (this.me)
        GClass172.smethod_1().method_31();
      this.cvx = this.cvy = Class15.smethod_0(0);
      this.cp3 = Class15.smethod_0(0);
    }
    else
    {
      if (this.cy % Class15.smethod_0(40) == 0 && (GClass185.smethod_26(this.cx, this.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
      {
        this.delayFall = Class15.smethod_0(0);
        if (this.me)
        {
          if (this.cy - this.cySend > Class15.smethod_0(0))
            GClass156.smethod_0().method_45();
          else if (this.cx - this.cxSend != 0 || this.cy - this.cySend < Class15.smethod_0(0))
            GClass156.smethod_0().method_45();
          this.cvx = this.cvy = Class15.smethod_0(0);
          this.cp1 = this.cp2 = Class15.smethod_0(0);
          this.statusMe = Class15.smethod_0(1);
          this.cp3 = Class15.smethod_0(0);
          return;
        }
        this.method_42();
        this.cf = Class15.smethod_0(0);
        GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
        GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
        this.method_120(Class15.smethod_0(1));
      }
      if (this.delayFall > Class15.smethod_0(0))
      {
        this.delayFall -= Class15.smethod_0(1);
        if (this.delayFall % Class15.smethod_0(31) > Class15.smethod_0(3))
          this.cy += Class15.smethod_0(1);
        else
          this.cy -= Class15.smethod_0(1);
      }
      else
      {
        this.cf = this.cvy >= Class15.smethod_0(200) ? Class15.smethod_0(66) : Class15.smethod_0(38);
        this.cx += this.cvx;
        if (!this.me && this.currentMovePoint != null)
        {
          int num = this.currentMovePoint.xEnd - this.cx;
          if (num > Class15.smethod_0(0))
          {
            if (this.cvx > num)
              this.cvx = num;
            if (this.cvx < Class15.smethod_0(0))
              this.cvx = num;
          }
          else if (num < Class15.smethod_0(0))
          {
            if (this.cvx < num)
              this.cvx = num;
            if (this.cvx > Class15.smethod_0(0))
              this.cvx = num;
          }
          else
            this.cvx = num;
        }
        this.cvy += Class15.smethod_0(1);
        if (this.cvy > Class15.smethod_0(88))
          this.cvy = Class15.smethod_0(88);
        if (this.skillPaintRandomPaint == null)
          this.cy += this.cvy;
        if (this.cdir == Class15.smethod_0(1))
        {
          if ((GClass185.smethod_26(this.cx + this.chw, this.cy - Class15.smethod_0(1)) & Class15.smethod_0(2)) == Class15.smethod_0(2) && this.cx <= GClass185.smethod_32(this.cx + this.chw) + Class15.smethod_0(66))
          {
            this.cx = GClass185.smethod_32(this.cx + this.chw) - this.chw;
            this.cvx = Class15.smethod_0(0);
          }
        }
        else if ((GClass185.smethod_26(this.cx - this.chw, this.cy - Class15.smethod_0(1)) & Class15.smethod_0(88)) == Class15.smethod_0(88) && this.cx >= GClass185.smethod_32(this.cx - this.chw) + Class15.smethod_0(66))
        {
          this.cx = GClass185.smethod_32(this.cx + Class15.smethod_0(40) - this.chw) + this.chw;
          this.cvx = Class15.smethod_0(0);
        }
        if (this.cvy > Class15.smethod_0(5) && (this.cyStartFall == 0 || this.cyStartFall <= GClass185.smethod_31(this.cy + Class15.smethod_0(5))) && (GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(5)) & Class15.smethod_0(7)) == Class15.smethod_0(7))
        {
          if (this.me)
          {
            this.cyStartFall = Class15.smethod_0(0);
            this.cvx = this.cvy = Class15.smethod_0(0);
            this.cp1 = this.cp2 = Class15.smethod_0(0);
            this.cy = GClass185.smethod_32(this.cy + Class15.smethod_0(5));
            this.statusMe = Class15.smethod_0(1);
            if (this.me)
              GClass172.smethod_1().method_31();
            this.cp3 = Class15.smethod_0(0);
            GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
            GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
            this.method_120(Class15.smethod_0(1));
            if (this.cy - this.cySend > Class15.smethod_0(0))
            {
              if (!this.me)
                return;
              GClass156.smethod_0().method_45();
            }
            else
            {
              if (this.cx - this.cxSend == 0 && this.cy - this.cySend >= Class15.smethod_0(0) || !this.me)
                return;
              GClass156.smethod_0().method_45();
            }
          }
          else
          {
            this.method_42();
            this.cy = GClass185.smethod_32(this.cy + Class15.smethod_0(5));
            this.cf = Class15.smethod_0(0);
            GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
            GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
            this.method_120(Class15.smethod_0(1));
          }
        }
        else
        {
          this.cf = Class15.smethod_0(66);
          if (this.me)
            return;
          if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(1)) & Class15.smethod_0(7)) == Class15.smethod_0(7))
            this.cf = Class15.smethod_0(0);
          if (this.currentMovePoint == null || this.cy <= this.currentMovePoint.yEnd)
            return;
          this.method_42();
        }
      }
    }
  }

  public void method_47()
  {
    int num1 = (int) this.isMonkey != Class15.smethod_0(1) || this.me ? Class15.smethod_0(1) : Class15.smethod_0(7);
    this.method_54();
    if (this.statusMe != Class15.smethod_0(10) && (GClass185.smethod_27(this.cx, this.cy - this.ch + Class15.smethod_0(40), Class15.smethod_0(189)) || this.cy < Class15.smethod_0(0)))
    {
      if (this.cy - this.ch < Class15.smethod_0(0))
        this.cy = this.ch;
      this.cf = Class15.smethod_0(38);
      this.statusMe = Class15.smethod_0(2);
      this.cvx = Class15.smethod_0(0);
      this.cp2 = Class15.smethod_0(0);
      this.currentMovePoint = (GClass108) null;
    }
    else
    {
      int cy = this.cy;
      this.cp1 += Class15.smethod_0(1);
      if (this.cp1 >= Class15.smethod_0(45))
      {
        this.cp1 = Class15.smethod_0(0);
        if (!this.me)
          this.cvx = this.cvy = Class15.smethod_0(0);
        this.cBonusSpeed = Class15.smethod_0(0);
      }
      this.cf = Class15.smethod_0(88);
      if (GClass151.smethod_25(this.cvx) <= Class15.smethod_0(2) && this.me)
      {
        if (this.currentMovePoint != null)
        {
          int num2 = GClass20.smethod_4(this.cx - this.currentMovePoint.xEnd);
          int num3 = GClass20.smethod_4(this.cy - this.currentMovePoint.yEnd);
          this.cf = num2 <= num3 * Class15.smethod_0(31) ? (num2 <= num3 || num2 <= Class15.smethod_0(154) || num3 <= Class15.smethod_0(120) ? Class15.smethod_0(38) : Class15.smethod_0(88)) : Class15.smethod_0(88);
        }
        else
        {
          if (this.cvy < Class15.smethod_0(0))
            this.cvy = Class15.smethod_0(0);
          if (this.cvy > Class15.smethod_0(10))
            this.cvy = Class15.smethod_0(10);
          this.cf = Class15.smethod_0(38);
        }
      }
      if (!this.me)
      {
        if (GClass20.smethod_4(this.cvx) < Class15.smethod_0(7))
          this.cvx = (this.cdir << Class15.smethod_0(1)) * num1;
        if (this.cvy != 0)
          this.cf = Class15.smethod_0(38);
        if (GClass20.smethod_4(this.cvx) <= Class15.smethod_0(7))
        {
          this.cp2 += Class15.smethod_0(1);
          if (this.cp2 > Class15.smethod_0(120))
          {
            this.statusMe = Class15.smethod_0(2);
            this.cvx = Class15.smethod_0(0);
            this.cvy = Class15.smethod_0(0);
          }
        }
      }
      if (this.cdir == Class15.smethod_0(1))
      {
        if (GClass185.smethod_27(this.cx + this.chw, this.cy - Class15.smethod_0(1), Class15.smethod_0(2)))
        {
          this.cvx = Class15.smethod_0(0);
          this.cx = GClass185.smethod_32(this.cx + this.chw) - this.chw;
          if (this.cvy == 0)
            this.currentMovePoint = (GClass108) null;
        }
      }
      else if (GClass185.smethod_27(this.cx - this.chw - Class15.smethod_0(1), this.cy - Class15.smethod_0(1), Class15.smethod_0(88)))
      {
        this.cvx = Class15.smethod_0(0);
        this.cx = GClass185.smethod_32(this.cx - this.chw - Class15.smethod_0(1)) + (int) GClass185.sbyte_0 + this.chw;
        if (this.cvy == 0)
          this.currentMovePoint = (GClass108) null;
      }
      this.cx += this.cvx * num1;
      this.cy += this.cvy * num1;
      if (!this.isMount && cy - this.cy == 0)
      {
        this.ty += Class15.smethod_0(1);
        this.wt += Class15.smethod_0(1);
        this.fy += !this.bool_7 ? Class15.smethod_0(1) : -1;
        if (this.wt == Class15.smethod_0(31))
        {
          this.wt = Class15.smethod_0(0);
          this.bool_7 = (this.bool_7 ? 1 : 0) == Class15.smethod_0(0);
        }
        if (this.ty > Class15.smethod_0(51))
        {
          this.delayFall = Class15.smethod_0(31);
          if (GClass62.int_8 % Class15.smethod_0(5) == 0)
            GClass47.smethod_1(Class15.smethod_0(44), this.cx + (this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(33) : Class15.smethod_0(201)), this.cy + this.fy + Class15.smethod_0(47), Class15.smethod_0(1), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0));
        }
      }
      if (!this.me)
        return;
      if (this.cvx > Class15.smethod_0(0))
        this.cvx -= Class15.smethod_0(1);
      else if (this.cvx < Class15.smethod_0(0))
        this.cvx += Class15.smethod_0(1);
      else if (this.cvy == 0)
      {
        this.statusMe = Class15.smethod_0(2);
        this.method_57();
        GClass156.smethod_0().method_45();
      }
      if ((GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(51)) & Class15.smethod_0(7)) == Class15.smethod_0(7) || (GClass185.smethod_26(this.cx, this.cy + Class15.smethod_0(54)) & Class15.smethod_0(7)) == Class15.smethod_0(7))
      {
        if (this.cvy == 0)
          this.delayFall = Class15.smethod_0(0);
        this.cyStartFall = Class15.smethod_0(0);
        this.cvx = this.cvy = Class15.smethod_0(0);
        this.cp1 = this.cp2 = Class15.smethod_0(0);
        this.statusMe = Class15.smethod_0(2);
        this.method_120(Class15.smethod_0(5));
      }
      if (GClass20.smethod_4(this.cx - this.cxSend) <= Class15.smethod_0(150) && GClass20.smethod_4(this.cy - this.cySend) <= Class15.smethod_0(40))
        return;
      GClass156.smethod_0().method_45();
    }
  }

  public void method_48(int cid, int ctrans, int cgender)
  {
    this.idcharMount = cid;
    this.transMount = ctrans;
    this.genderMount = cgender;
    this.speedMount = Class15.smethod_0(6);
    if (this.transMount < Class15.smethod_0(0))
    {
      this.transMount = Class15.smethod_0(0);
      this.xMount = GClass116.int_22 + GClass62.int_10 + Class15.smethod_0(32);
      this.dxMount = Class15.smethod_0(202);
    }
    else if (this.transMount == Class15.smethod_0(1))
    {
      this.transMount = Class15.smethod_0(7);
      this.xMount = GClass116.int_22 - Class15.smethod_0(21);
      this.dxMount = Class15.smethod_0(203);
    }
    this.dyMount = Class15.smethod_0(201);
    this.yMount = this.cy;
    this.frameMount = Class15.smethod_0(0);
    this.frameNewMount = Class15.smethod_0(0);
    this.isMount = Class15.smethod_0(0) != 0;
    this.isEndMount = Class15.smethod_0(0) != 0;
  }

  public void method_49()
  {
    this.frameMount += Class15.smethod_0(1);
    if (this.frameMount > this.FrameMount.Length - Class15.smethod_0(1))
      this.frameMount = Class15.smethod_0(0);
    this.frameNewMount += Class15.smethod_0(1);
    if (this.frameNewMount > Class15.smethod_0(15))
      this.frameNewMount = Class15.smethod_0(0);
    if ((!this.isStartMount ? 1 : 0) == 0 && (!this.isMount ? 0 : 1) == 0)
    {
      this.yMount = this.cy;
      if ((this.transMount == 0 ? 0 : 1) == 0)
      {
        if (this.xMount - this.cx >= this.speedMount)
        {
          this.xMount -= this.speedMount;
        }
        else
        {
          this.xMount = this.cx;
          this.isMount = Class15.smethod_0(1) != 0;
          this.isEndMount = Class15.smethod_0(0) != 0;
        }
      }
      else
      {
        if (this.transMount != Class15.smethod_0(7))
          return;
        if (this.cx - this.xMount >= this.speedMount)
        {
          this.xMount += this.speedMount;
        }
        else
        {
          this.xMount = this.cx;
          this.isMount = Class15.smethod_0(1) != 0;
          this.isEndMount = Class15.smethod_0(0) != 0;
        }
      }
    }
    else if ((!this.isMount ? 1 : 0) == 0)
    {
      if (this.statusMe == Class15.smethod_0(49) || this.ySd - this.cy < Class15.smethod_0(40))
        this.method_55();
      this.cf = this.cp1 % Class15.smethod_0(9) >= Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0);
      this.transMount = this.cdir;
      this.method_39();
      if (this.transMount < Class15.smethod_0(0))
      {
        this.transMount = Class15.smethod_0(0);
        this.dxMount = Class15.smethod_0(202);
      }
      else if (this.transMount == Class15.smethod_0(1))
      {
        this.transMount = Class15.smethod_0(7);
        this.dxMount = Class15.smethod_0(204);
        if ((!this.isEventMount ? 1 : 0) == 0)
          this.dxMount = Class15.smethod_0(205);
      }
      this.dyMount = (this.method_71() == null ? 1 : 0) != 0 ? Class15.smethod_0(201) : Class15.smethod_0(206);
      this.yMount = this.cy;
      this.xMount = this.cx;
    }
    else if ((!this.isEndMount ? 1 : 0) == 0)
    {
      if ((this.transMount == 0 ? 0 : 1) == 0)
      {
        if (this.xMount > GClass116.int_22 - Class15.smethod_0(21))
        {
          this.xMount -= Class15.smethod_0(51);
        }
        else
        {
          this.isStartMount = Class15.smethod_0(0) != 0;
          this.isMount = Class15.smethod_0(0) != 0;
          this.isEndMount = Class15.smethod_0(0) != 0;
        }
      }
      else
      {
        if (this.transMount != Class15.smethod_0(7))
          return;
        if (this.xMount < GClass116.int_22 + GClass62.int_10 + Class15.smethod_0(32))
        {
          this.xMount += Class15.smethod_0(51);
        }
        else
        {
          this.isStartMount = Class15.smethod_0(0) != 0;
          this.isMount = Class15.smethod_0(0) != 0;
          this.isEndMount = Class15.smethod_0(0) != 0;
        }
      }
    }
    else
    {
      if ((!this.isStartMount ? 1 : 0) == 0 && (!this.isMount ? 1 : 0) == 0 && (!this.isEndMount ? 0 : 1) != 0)
        return;
      this.xMount = GClass116.int_22 - Class15.smethod_0(21);
      this.yMount = GClass116.int_23 - Class15.smethod_0(21);
    }
  }

  public void method_50()
  {
    if ((GClass100.gclass106_0[Class15.smethod_0(32)].data == null ? 0 : 1) != 0)
      return;
    GClass100.gclass106_0[Class15.smethod_0(32)].data = new GClass50();
    string path = Class13.smethod_0(145048) + Class15.smethod_0(32).ToString();
    if ((GClass133.smethod_0(path) == null ? 1 : 0) == 0)
    {
      GClass100.gclass106_0[Class15.smethod_0(32)].data.method_3(path + Class13.smethod_0(145030));
      GClass100.gclass106_0[Class15.smethod_0(32)].data.img = GClass62.smethod_40(path + Class13.smethod_0(145148));
    }
    else
      GClass156.smethod_0().method_49(Class15.smethod_0(32));
    GClass100.gclass134_0.method_0((object) (Class15.smethod_0(32).ToString() + string.Empty));
  }

  public void method_51(int[] array)
  {
    this.int_8 += Class15.smethod_0(1);
    if (this.int_8 > array.Length - Class15.smethod_0(1))
      this.int_8 = Class15.smethod_0(0);
    this.int_9 = array[this.int_8];
  }

  public void method_52(GClass98 g)
  {
    if (this.xMount <= GClass116.int_22 || this.xMount >= GClass116.int_22 + GClass62.int_10)
      return;
    if (this.me)
    {
      if (!this.isEndMount && !this.isStartMount && !this.isMount)
        return;
      if ((int) this.idMount >= (int) GClass20.short_2)
      {
        GClass60 gclass60 = GClass126.smethod_34(this.string_1 + ((int) this.idMount - (int) GClass20.short_2).ToString() + Class13.smethod_0(145139));
        gclass60?.method_0(this.frameNewMount / Class15.smethod_0(7) % gclass60.nFrame, this.xMount, this.yMount + this.fy, this.transMount, Class15.smethod_0(5), g);
      }
      else
      {
        if (this.isSpeacialMount)
          return;
        if (this.isEventMount)
          g.method_24(GClass20.gclass66_11, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(4), Class15.smethod_0(4), Class15.smethod_0(4), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        else if (this.genderMount == Class15.smethod_0(7))
        {
          if (!this.isMountVip)
            g.method_24(GClass20.gclass66_5, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          else
            g.method_24(GClass20.gclass66_9, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        }
        else
        {
          if (this.genderMount != Class15.smethod_0(1))
            return;
          if (!this.isMountVip)
            g.method_24(GClass20.gclass66_3, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          else
            g.method_24(GClass20.gclass66_7, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        }
      }
    }
    else
    {
      if (this.me)
        return;
      if ((int) this.idMount >= (int) GClass20.short_2)
      {
        GClass60 gclass60 = GClass126.smethod_34(this.string_1 + ((int) this.idMount - (int) GClass20.short_2).ToString() + Class13.smethod_0(145139));
        gclass60?.method_0(this.frameNewMount / Class15.smethod_0(7) % gclass60.nFrame, this.xMount, this.yMount + this.fy, this.transMount, Class15.smethod_0(5), g);
      }
      else
      {
        if (this.isSpeacialMount)
          return;
        if (this.isEventMount)
        {
          g.method_24(GClass20.gclass66_11, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(4), Class15.smethod_0(4), Class15.smethod_0(4), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        }
        else
        {
          if (!this.isMount)
            return;
          if (this.genderMount == Class15.smethod_0(7))
          {
            if (!this.isMountVip)
              g.method_24(GClass20.gclass66_5, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
            else
              g.method_24(GClass20.gclass66_9, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          }
          else
          {
            if (this.genderMount != Class15.smethod_0(1))
              return;
            if (!this.isMountVip)
              g.method_24(GClass20.gclass66_3, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
            else
              g.method_24(GClass20.gclass66_7, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          }
        }
      }
    }
  }

  public void method_53(GClass98 g)
  {
    if (this.xMount <= GClass116.int_22 || this.xMount >= GClass116.int_22 + GClass62.int_10)
      return;
    if (this.me)
    {
      if (!this.isEndMount && !this.isStartMount && !this.isMount)
        return;
      if ((int) this.idMount >= (int) GClass20.short_2)
      {
        GClass60 gclass60 = GClass126.smethod_34(this.string_1 + ((int) this.idMount - (int) GClass20.short_2).ToString() + Class13.smethod_0(146266));
        gclass60?.method_0(this.frameNewMount / Class15.smethod_0(7) % gclass60.nFrame, this.xMount, this.yMount + this.fy, this.transMount, Class15.smethod_0(5), g);
      }
      else if (this.isSpeacialMount)
      {
        this.method_51(this.move);
        if (GClass100.gclass106_0[Class15.smethod_0(32)] != null && GClass100.gclass106_0[Class15.smethod_0(32)].data != null)
          GClass100.gclass106_0[Class15.smethod_0(32)].data.method_9(g, this.int_9, this.xMount + (this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(88) : Class15.smethod_0(193)), this.yMount + Class15.smethod_0(95), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(0));
        else
          this.method_50();
      }
      else if (this.isEventMount)
        g.method_24(GClass20.gclass66_10, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(4), Class15.smethod_0(4), Class15.smethod_0(4), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
      else if (this.genderMount == 0)
      {
        if (!this.isMountVip)
          g.method_24(GClass20.gclass66_2, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        else
          g.method_24(GClass20.gclass66_6, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
      }
      else
      {
        if (this.genderMount != Class15.smethod_0(1))
          return;
        if (!this.isMountVip)
          g.method_24(GClass20.gclass66_4, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        else
          g.method_24(GClass20.gclass66_8, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
      }
    }
    else
    {
      if (this.me)
        return;
      if ((int) this.idMount >= (int) GClass20.short_2)
      {
        GClass60 gclass60 = GClass126.smethod_34(this.string_1 + ((int) this.idMount - (int) GClass20.short_2).ToString() + Class13.smethod_0(146266));
        gclass60?.method_0(this.frameNewMount / Class15.smethod_0(7) % gclass60.nFrame, this.xMount, this.yMount + this.fy, this.transMount, Class15.smethod_0(5), g);
      }
      else if (this.isSpeacialMount)
      {
        this.method_51(this.move);
        if (GClass100.gclass106_0[Class15.smethod_0(32)] != null && GClass100.gclass106_0[Class15.smethod_0(32)].data != null)
          GClass100.gclass106_0[Class15.smethod_0(32)].data.method_9(g, this.int_9, this.xMount + (this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(88) : Class15.smethod_0(193)), this.yMount + Class15.smethod_0(95), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(0));
        else
          this.method_50();
      }
      else
      {
        if (this.isEventMount)
          g.method_24(GClass20.gclass66_10, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(4), Class15.smethod_0(4), Class15.smethod_0(4), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        if (!this.isMount)
          return;
        if (this.genderMount == 0)
        {
          if (!this.isMountVip)
            g.method_24(GClass20.gclass66_2, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          else
            g.method_24(GClass20.gclass66_6, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        }
        else
        {
          if (this.genderMount != Class15.smethod_0(1))
            return;
          if (!this.isMountVip)
            g.method_24(GClass20.gclass66_4, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
          else
            g.method_24(GClass20.gclass66_8, Class15.smethod_0(0), (int) this.FrameMount[this.frameMount] * Class15.smethod_0(54), Class15.smethod_0(32), Class15.smethod_0(54), this.transMount, this.xMount + this.dxMount, this.yMount + this.dyMount + this.fy, Class15.smethod_0(0));
        }
      }
    }
  }

  public void method_54()
  {
    if ((!this.me ? 1 : 0) == 0)
    {
      this.isHaveMount = this.method_56();
      if ((!GClass185.smethod_1() ? 1 : 0) == 0)
        this.isHaveMount = Class15.smethod_0(0) != 0;
    }
    if ((!this.isHaveMount ? 1 : 0) != 0)
      return;
    if (this.ySd - this.cy <= Class15.smethod_0(51))
      this.xChar = this.cx;
    if (this.xdis < Class15.smethod_0(21))
      this.xdis = GClass151.smethod_25(this.xChar - this.cx);
    if (this.xdis < Class15.smethod_0(152) || this.ySd - this.cy <= Class15.smethod_0(6) || (!this.isStartMount ? 0 : 1) != 0 || (!this.isEndMount ? 0 : 1) != 0)
      return;
    this.method_48(this.charID, this.cdir, this.cgender);
    this.isStartMount = Class15.smethod_0(1) != 0;
  }

  public void method_55()
  {
    if (this.ySd - this.cy >= Class15.smethod_0(40) || (!this.isEndMount ? 0 : 1) != 0)
      return;
    this.isStartMount = Class15.smethod_0(0) != 0;
    this.isMount = Class15.smethod_0(0) != 0;
    this.isEndMount = Class15.smethod_0(1) != 0;
    this.xdis = Class15.smethod_0(0);
  }

  public bool method_56()
  {
    bool flag = Class15.smethod_0(0) != 0;
    short num = -1;
    GClass80[] arrItemBody = this.arrItemBody;
    for (int index = Class15.smethod_0(0); index < arrItemBody.Length; index += Class15.smethod_0(1))
    {
      if ((arrItemBody[index] == null ? 1 : 0) == 0 && ((int) arrItemBody[index].template.type == Class15.smethod_0(40) || (int) arrItemBody[index].template.type == Class15.smethod_0(29)))
      {
        num = (int) arrItemBody[index].template.part < Class15.smethod_0(0) ? arrItemBody[index].template.id : (short) ((int) GClass20.short_2 + (int) arrItemBody[index].template.part);
        flag = Class15.smethod_0(1) != 0;
        break;
      }
    }
    this.isMountVip = Class15.smethod_0(0) != 0;
    this.isSpeacialMount = Class15.smethod_0(0) != 0;
    this.isEventMount = Class15.smethod_0(0) != 0;
    this.idMount = (short) -1;
    if ((uint) num - (uint) Class15.smethod_0(207) > (uint) Class15.smethod_0(7))
    {
      if ((int) num != Class15.smethod_0(208))
      {
        if ((int) num != Class15.smethod_0(209))
        {
          if ((int) num >= (int) GClass20.short_2)
            this.idMount = num;
        }
        else
          this.isSpeacialMount = Class15.smethod_0(1) != 0;
      }
      else
        this.isEventMount = Class15.smethod_0(1) != 0;
    }
    else
      this.isMountVip = Class15.smethod_0(1) != 0;
    return flag;
  }

  private void method_57()
  {
    bool flag = Class15.smethod_0(1) != 0;
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(19); index += Class15.smethod_0(40))
    {
      if ((GClass185.smethod_26(this.cx, this.cy + index) & Class15.smethod_0(7)) == Class15.smethod_0(7) || this.cy + index > GClass185.int_22 * (int) GClass185.sbyte_0 - Class15.smethod_0(40))
      {
        flag = Class15.smethod_0(0) != 0;
        break;
      }
    }
    if ((!flag ? 1 : 0) != 0)
      return;
    this.delayFall = Class15.smethod_0(54);
  }

  public void method_58()
  {
    this.method_59();
    this.method_60();
    this.method_61();
  }

  public void method_59()
  {
    if ((this.cgender == 0 ? 0 : 1) != 0)
      return;
    this.wp = Class15.smethod_0(0);
  }

  public void method_60()
  {
    if ((this.cgender == 0 ? 0 : 1) == 0)
      this.body = Class15.smethod_0(210);
    else if (this.cgender == Class15.smethod_0(1))
    {
      this.body = Class15.smethod_0(211);
    }
    else
    {
      if (this.cgender != Class15.smethod_0(7))
        return;
      this.body = Class15.smethod_0(210);
    }
  }

  public void method_61()
  {
    if ((this.cgender == 0 ? 0 : 1) == 0)
      this.leg = Class15.smethod_0(129);
    else if (this.cgender == Class15.smethod_0(1))
    {
      this.leg = Class15.smethod_0(4);
    }
    else
    {
      if (this.cgender != Class15.smethod_0(7))
        return;
      this.leg = Class15.smethod_0(129);
    }
  }

  public bool method_62() => (this.myskill == null ? 1 : 0) == 0 ? this.myskill.template.method_1() : Class15.smethod_0(0) != 0;

  public bool method_63() => (this.myskill == null ? 1 : 0) == 0 ? this.myskill.template.method_0() : Class15.smethod_0(0) != 0;

  public bool method_64()
  {
    if ((!this.isUseSkillAfterCharge ? 0 : 1) != 0 || (this.myskill == null ? 1 : 0) != 0)
      return Class15.smethod_0(0) != 0;
    return (int) this.myskill.template.id != Class15.smethod_0(31) ? (int) this.myskill.template.id == Class15.smethod_0(67) : Class15.smethod_0(1) != 0;
  }

  public void method_65(GClass165 skillPaint, int sType)
  {
    this.bool_9 = Class15.smethod_0(0) != 0;
    if ((!this.stone ? 0 : 1) != 0 || (!this.me ? 1 : 0) == 0 && (int) this.myskill.template.id == Class15.smethod_0(45) && this.cHP <= this.cHPFull / Class15.smethod_0(31))
      return;
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((this.mobFocus == null ? 0 : 1) == 0 && (this.charFocus == null ? 0 : 1) == 0)
        this.method_68();
      if ((this.mobFocus == null ? 1 : 0) == 0 && (this.mobFocus.status == Class15.smethod_0(1) || (this.mobFocus.status == 0 ? 0 : 1) == 0))
        this.method_68();
      if ((this.charFocus == null ? 1 : 0) == 0 && (this.charFocus.statusMe == Class15.smethod_0(49) || this.charFocus.statusMe == Class15.smethod_0(3)))
        this.method_68();
      if ((int) this.myskill.template.id == Class15.smethod_0(29) && ((this.charFocus == null ? 1 : 0) == 0 && (this.charFocus.holdEffID == 0 ? 0 : 1) != 0 || (this.mobFocus == null ? 1 : 0) == 0 && (this.mobFocus.holdEffID == 0 ? 0 : 1) != 0 || (this.holdEffID == 0 ? 0 : 1) != 0) || (!this.sleepEff ? 0 : 1) != 0 || (!this.blindEff ? 1 : 0) == 0)
        return;
    }
    GClass151.smethod_7(Class13.smethod_0(146704) + skillPaint.id.ToString());
    if ((!this.me ? 1 : 0) == 0 && (this.dart == null ? 0 : 1) != 0 || (!GClass185.smethod_5() ? 1 : 0) == 0)
      return;
    long num = GClass126.smethod_18();
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((!this.method_63() ? 1 : 0) == 0 && (this.charFocus == null ? 0 : 1) == 0)
        return;
      if (num - this.myskill.lastTimeUseThisSkill < (long) this.myskill.coolDown)
      {
        this.myskill.paintCanNotUseSkill = Class15.smethod_0(1) != 0;
        return;
      }
      this.myskill.lastTimeUseThisSkill = num;
      if (this.myskill.template.manaUseType == Class15.smethod_0(7))
        this.cMP = Class15.smethod_0(1);
      else if (this.myskill.template.manaUseType != Class15.smethod_0(1))
        this.cMP -= this.myskill.manaUse;
      else
        this.cMP -= this.myskill.manaUse * this.cMPFull / Class15.smethod_0(21);
      GClass20.smethod_1().cStamina -= Class15.smethod_0(1);
      GClass116.smethod_6().isInjureMp = Class15.smethod_0(1) != 0;
      GClass116.smethod_6().twMp = Class15.smethod_0(0);
      if (this.cMP < Class15.smethod_0(0))
        this.cMP = Class15.smethod_0(0);
    }
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((int) this.myskill.template.id == Class15.smethod_0(38))
        GClass172.smethod_1().method_43();
      if ((int) this.myskill.template.id == Class15.smethod_0(37))
      {
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(0));
        GClass116.smethod_6().isUseFreez = Class15.smethod_0(1) != 0;
        GClass172.smethod_1().method_5();
      }
      if ((int) this.myskill.template.id == Class15.smethod_0(88))
      {
        if ((!this.isCharge ? 0 : 1) == 0)
        {
          GClass172.smethod_1().method_45();
          GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(1));
          this.isCharge = Class15.smethod_0(1) != 0;
          this.last = this.cur = GClass126.smethod_18();
        }
        else
        {
          GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(5));
          this.isCharge = Class15.smethod_0(0) != 0;
          GClass172.smethod_1().method_45();
        }
      }
      if ((int) this.myskill.template.id == Class15.smethod_0(47))
      {
        if ((this.isMonkey == (sbyte) 0 ? 1 : 0) == 0)
        {
          GClass116.smethod_6().auto = Class15.smethod_0(0);
          return;
        }
        if ((!this.isCreateDark ? 0 : 1) != 0)
          return;
        GClass172.smethod_1().method_8();
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(37));
        this.int_10 = Class15.smethod_0(0);
        this.isWaitMonkey = Class15.smethod_0(1) != 0;
        return;
      }
      if ((int) this.myskill.template.id == Class15.smethod_0(49))
      {
        GClass172.smethod_1().method_8();
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(38));
        this.method_69(Class15.smethod_0(1) != 0);
      }
      if ((int) this.myskill.template.id == Class15.smethod_0(27))
      {
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(31));
        return;
      }
      if ((int) this.myskill.template.id == Class15.smethod_0(66))
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(88));
      if ((int) this.myskill.template.id == Class15.smethod_0(65))
      {
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(45));
        return;
      }
    }
    if ((int) this.isMonkey == Class15.smethod_0(1) && skillPaint.id >= Class15.smethod_0(95) && skillPaint.id <= Class15.smethod_0(55))
      skillPaint = GClass116.gclass165_0[Class15.smethod_0(58)];
    if (skillPaint.id >= Class15.smethod_0(212) && skillPaint.id <= Class15.smethod_0(213))
    {
      skillPaint = GClass116.gclass165_0[skillPaint.id - Class15.smethod_0(130)];
      if ((this.charFocus == null ? 1 : 0) == 0)
      {
        this.cx = this.charFocus.cx;
        this.cy = this.charFocus.cy;
        this.currentMovePoint = (GClass108) null;
      }
      if ((this.mobFocus == null ? 1 : 0) == 0)
      {
        this.cx = this.mobFocus.x;
        this.cy = this.mobFocus.y;
        this.currentMovePoint = (GClass108) null;
      }
      GClass47.smethod_0(Class15.smethod_0(4), this.cx, this.cy, Class15.smethod_0(1));
      this.telePortSkill = Class15.smethod_0(1) != 0;
    }
    if (skillPaint.id >= Class15.smethod_0(12) && skillPaint.id <= Class15.smethod_0(76))
    {
      skillPaint = GClass116.gclass165_0[skillPaint.id - Class15.smethod_0(74)];
      GClass40.smethod_0(new GClass41(Class15.smethod_0(29), this.cx, this.cy + this.ch / Class15.smethod_0(7), Class15.smethod_0(5), Class15.smethod_0(7), Class15.smethod_0(1)));
    }
    this.method_70(skillPaint, sType);
  }

  public void method_66()
  {
    GClass116.smethod_6().auto = Class15.smethod_0(0);
    GClass20.smethod_1().method_65(GClass116.gclass165_0[(int) GClass20.smethod_1().myskill.skillId], (!GClass185.smethod_27(GClass20.smethod_1().cx, GClass20.smethod_1().cy, Class15.smethod_0(7)) ? 1 : 0) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
  }

  public void method_67()
  {
    if ((!this.me ? 1 : 0) == 0 && ((!this.isFreez ? 0 : 1) != 0 || (!this.isUsePlane ? 1 : 0) == 0))
    {
      GClass116.smethod_6().auto = Class15.smethod_0(0);
    }
    else
    {
      long num = GClass126.smethod_18();
      if ((!this.me ? 1 : 0) == 0 && num - this.myskill.lastTimeUseThisSkill < (long) this.myskill.coolDown)
      {
        this.myskill.paintCanNotUseSkill = Class15.smethod_0(1) != 0;
      }
      else
      {
        if ((int) this.myskill.template.id == Class15.smethod_0(31))
          this.method_69(Class15.smethod_0(0) != 0);
        if ((int) this.myskill.template.id != Class15.smethod_0(67))
          return;
        this.method_69(Class15.smethod_0(1) != 0);
      }
    }
  }

  public void method_68()
  {
    this.isFlyAndCharge = Class15.smethod_0(0) != 0;
    this.isStandAndCharge = Class15.smethod_0(0) != 0;
    this.isUseSkillAfterCharge = Class15.smethod_0(0) != 0;
    this.isCreateDark = Class15.smethod_0(0) != 0;
    if ((!this.me ? 1 : 0) == 0 && this.statusMe != Class15.smethod_0(49) && this.statusMe != Class15.smethod_0(3))
      this.isLockMove = Class15.smethod_0(0) != 0;
    GClass116.smethod_6().auto = Class15.smethod_0(0);
  }

  public void method_69(bool isGround)
  {
    if ((!this.isCreateDark ? 1 : 0) == 0)
      return;
    GClass116.smethod_6().auto = Class15.smethod_0(0);
    if ((!isGround ? 1 : 0) == 0)
    {
      if ((!this.isStandAndCharge ? 1 : 0) == 0)
        return;
      this.int_10 = Class15.smethod_0(0);
      this.seconds = Class15.smethod_0(214);
      this.posDisY = Class15.smethod_0(0);
      this.last = GClass126.smethod_18();
      if ((!this.me ? 1 : 0) == 0)
      {
        this.isLockMove = Class15.smethod_0(1) != 0;
        if (this.cgender == Class15.smethod_0(1))
          GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(2));
      }
      if (this.cgender == Class15.smethod_0(1))
        GClass172.smethod_1().method_7();
      this.isStandAndCharge = Class15.smethod_0(1) != 0;
    }
    else
    {
      if ((!this.isFlyAndCharge ? 0 : 1) != 0)
        return;
      if ((!this.me ? 1 : 0) == 0)
      {
        GClass116.smethod_6().auto = Class15.smethod_0(0);
        this.isLockMove = Class15.smethod_0(1) != 0;
        GClass156.smethod_0().method_18((sbyte) Class15.smethod_0(2));
      }
      this.isUseSkillAfterCharge = Class15.smethod_0(0) != 0;
      this.int_10 = Class15.smethod_0(0);
      this.isFlyAndCharge = Class15.smethod_0(1) != 0;
      this.posDisY = Class15.smethod_0(0);
      this.seconds = Class15.smethod_0(214);
      this.bool_8 = GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7));
    }
  }

  public void method_70(GClass165 skillPaint, int sType)
  {
    this.skillPaint = skillPaint;
    GClass151.smethod_7(Class13.smethod_0(139598) + ((skillPaint == null ? 1 : 0) != 0 ? Class13.smethod_0(141766) : Class13.smethod_0(141776)));
    if (skillPaint.id >= Class15.smethod_0(0) && skillPaint.id <= Class15.smethod_0(37))
    {
      int index = GClass151.smethod_18(Class15.smethod_0(0), skillPaint.id + Class15.smethod_0(2)) - Class15.smethod_0(1);
      if (index < Class15.smethod_0(0))
        index = Class15.smethod_0(0);
      if (index > Class15.smethod_0(37))
        index = Class15.smethod_0(37);
      this.skillPaintRandomPaint = GClass116.gclass165_0[index];
    }
    else if (skillPaint.id >= Class15.smethod_0(49) && skillPaint.id <= Class15.smethod_0(51))
    {
      int num = GClass151.smethod_18(Class15.smethod_0(0), skillPaint.id - Class15.smethod_0(49) + Class15.smethod_0(2)) - Class15.smethod_0(1);
      if (num < Class15.smethod_0(0))
        num = Class15.smethod_0(0);
      if (num > Class15.smethod_0(37))
        num = Class15.smethod_0(37);
      this.skillPaintRandomPaint = GClass116.gclass165_0[num + Class15.smethod_0(49)];
    }
    else if (skillPaint.id >= Class15.smethod_0(35) && skillPaint.id <= Class15.smethod_0(117))
    {
      int num = GClass151.smethod_18(Class15.smethod_0(0), ((int) this.isMonkey != Class15.smethod_0(1) ? skillPaint.id : Class15.smethod_0(57)) - ((int) this.isMonkey != Class15.smethod_0(1) ? Class15.smethod_0(35) : Class15.smethod_0(57)) + Class15.smethod_0(2)) - Class15.smethod_0(1);
      if (num < Class15.smethod_0(0))
        num = Class15.smethod_0(0);
      if (num > Class15.smethod_0(37))
        num = Class15.smethod_0(37);
      if ((int) this.isMonkey == Class15.smethod_0(1))
        num = Class15.smethod_0(0);
      this.skillPaintRandomPaint = GClass116.gclass165_0[num + ((int) this.isMonkey != Class15.smethod_0(1) ? Class15.smethod_0(35) : Class15.smethod_0(57))];
    }
    else if (skillPaint.id >= Class15.smethod_0(182) && skillPaint.id <= Class15.smethod_0(151))
    {
      int num = GClass151.smethod_18(Class15.smethod_0(0), skillPaint.id - Class15.smethod_0(182) + Class15.smethod_0(2)) - Class15.smethod_0(1);
      if (num < Class15.smethod_0(0))
        num = Class15.smethod_0(0);
      if (num > Class15.smethod_0(37))
        num = Class15.smethod_0(37);
      this.skillPaintRandomPaint = GClass116.gclass165_0[num + Class15.smethod_0(182)];
    }
    else if (skillPaint.id >= Class15.smethod_0(12) && skillPaint.id <= Class15.smethod_0(56))
    {
      int num = GClass151.smethod_18(Class15.smethod_0(0), skillPaint.id - Class15.smethod_0(12) + Class15.smethod_0(2)) - Class15.smethod_0(1);
      if (num < Class15.smethod_0(0))
        num = Class15.smethod_0(0);
      if (num > Class15.smethod_0(37))
        num = Class15.smethod_0(37);
      this.skillPaintRandomPaint = GClass116.gclass165_0[num + Class15.smethod_0(12)];
    }
    else
      this.skillPaintRandomPaint = skillPaint;
    this.sType = sType;
    this.indexSkill = Class15.smethod_0(0);
    this.i0 = this.i1 = this.i2 = this.dx0 = this.dx1 = this.dx2 = this.dy0 = this.dy1 = this.dy2 = Class15.smethod_0(0);
    this.eff0 = (GClass49) null;
    this.eff1 = (GClass49) null;
    this.eff2 = (GClass49) null;
    this.cvy = Class15.smethod_0(0);
  }

  public GClass162[] method_71()
  {
    if ((this.skillPaint == null ? 0 : 1) == 0)
      return (GClass162[]) null;
    if ((this.skillPaintRandomPaint == null ? 0 : 1) == 0)
      return (GClass162[]) null;
    return (this.sType == 0 ? 0 : 1) == 0 ? this.skillPaintRandomPaint.skillStand : this.skillPaintRandomPaint.skillfly;
  }

  public void method_72()
  {
    if ((!this.me ? 1 : 0) == 0)
    {
      GClass165 gclass165 = this.skillPaintRandomPaint;
      if ((this.dart == null ? 1 : 0) == 0)
        gclass165 = this.dart.skillPaint;
      if ((gclass165 == null ? 0 : 1) == 0)
        return;
      GClass134 vMob = new GClass134();
      GClass134 vChar = new GClass134();
      if ((this.charFocus == null ? 1 : 0) == 0)
        vChar.method_0((object) this.charFocus);
      else if ((this.mobFocus == null ? 1 : 0) == 0)
        vMob.method_0((object) this.mobFocus);
      this.effPaints = new GClass52[vMob.method_2() + vChar.method_2()];
      for (int index = Class15.smethod_0(0); index < vMob.method_2(); index += Class15.smethod_0(1))
      {
        this.effPaints[index] = new GClass52();
        this.effPaints[index].effCharPaint = GClass116.gclass49_0[gclass165.effectHappenOnMob - Class15.smethod_0(1)];
        if ((!this.method_62() ? 0 : 1) == 0)
          this.effPaints[index].eMob = (GClass100) vMob.method_3(index);
      }
      for (int index = Class15.smethod_0(0); index < vChar.method_2(); index += Class15.smethod_0(1))
      {
        this.effPaints[index + vMob.method_2()] = new GClass52();
        this.effPaints[index + vMob.method_2()].effCharPaint = GClass116.gclass49_0[gclass165.effectHappenOnMob - Class15.smethod_0(1)];
        this.effPaints[index + vMob.method_2()].eChar = (GClass20) vChar.method_3(index);
      }
      int type = Class15.smethod_0(0);
      if ((this.mobFocus == null ? 1 : 0) == 0)
        type = Class15.smethod_0(1);
      else if ((this.charFocus == null ? 1 : 0) == 0)
        type = Class15.smethod_0(7);
      if ((vMob.method_2() == 0 ? 0 : 1) == 0 && (vChar.method_2() == 0 ? 0 : 1) == 0)
        this.method_68();
      if ((!this.me ? 1 : 0) != 0 || (!this.method_62() ? 0 : 1) != 0 || (!this.bool_9 ? 0 : 1) != 0)
        return;
      GClass156.smethod_0().method_74(vMob, vChar, type);
      this.bool_9 = Class15.smethod_0(1) != 0;
    }
    else
    {
      GClass165 gclass165 = this.skillPaintRandomPaint;
      if ((this.dart == null ? 1 : 0) == 0)
        gclass165 = this.dart.skillPaint;
      if ((gclass165 == null ? 0 : 1) == 0)
        return;
      if ((this.attMobs == null ? 1 : 0) == 0)
      {
        this.effPaints = new GClass52[this.attMobs.Length];
        for (int index = Class15.smethod_0(0); index < this.attMobs.Length; index += Class15.smethod_0(1))
        {
          this.effPaints[index] = new GClass52();
          this.effPaints[index].effCharPaint = GClass116.gclass49_0[gclass165.effectHappenOnMob - Class15.smethod_0(1)];
          this.effPaints[index].eMob = this.attMobs[index];
        }
        this.attMobs = (GClass100[]) null;
      }
      else
      {
        if ((this.attChars == null ? 1 : 0) != 0)
          return;
        this.effPaints = new GClass52[this.attChars.Length];
        for (int index = Class15.smethod_0(0); index < this.attChars.Length; index += Class15.smethod_0(1))
        {
          this.effPaints[index] = new GClass52();
          this.effPaints[index].effCharPaint = GClass116.gclass49_0[gclass165.effectHappenOnMob - Class15.smethod_0(1)];
          this.effPaints[index].eChar = this.attChars[index];
        }
        this.attChars = (GClass20[]) null;
      }
    }
  }

  public bool method_73()
  {
    if (this.cx < GClass116.int_22)
      return Class15.smethod_0(1) != 0;
    return this.cx > GClass116.int_22 + GClass116.int_6 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public bool method_74()
  {
    if (this.cy < GClass116.int_23)
      return Class15.smethod_0(0) != 0;
    if (this.cy > GClass116.int_23 + GClass116.int_7 + Class15.smethod_0(6))
      return Class15.smethod_0(0) != 0;
    if ((!this.method_73() ? 1 : 0) == 0)
      return Class15.smethod_0(0) != 0;
    if ((!this.bool_15 ? 1 : 0) == 0)
      return Class15.smethod_0(0) != 0;
    return (!this.isFusion ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public void method_75(int x, int y, int life)
  {
    this.shadowX = x;
    this.shadowY = y;
    this.shadowLife = life;
  }

  public void method_76(bool m) => this.isMabuHold = m;

  public virtual void vmethod_1(GClass98 g)
  {
    if ((!this.bool_6 ? 1 : 0) == 0)
      return;
    if ((!this.isMabuHold ? 1 : 0) == 0)
    {
      if ((!this.cmtoChar ? 1 : 0) != 0)
        return;
      GClass116.int_28 = this.cx - GClass116.int_8;
      GClass116.int_29 = this.cy - GClass116.int_14;
      if ((!GClass62.bool_6 ? 0 : 1) != 0)
        return;
      GClass116.int_28 += GClass116.int_20 * this.cdir;
    }
    else
    {
      if ((!this.method_74() ? 1 : 0) != 0 || (!this.me ? 0 : 1) == 0 && (!GClass116.bool_59 ? 1 : 0) == 0)
        return;
      if ((this.petFollow == null ? 1 : 0) == 0)
        this.petFollow.method_1(g);
      this.method_52(g);
      if ((!GClass185.smethod_14() ? 1 : 0) == 0 && this.cy >= GClass185.int_24 - Class15.smethod_0(154) || (!this.isTeleport ? 1 : 0) == 0)
        return;
      if ((!this.holder ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
      {
        g.method_16(Class15.smethod_0(215));
        if ((this.gclass20_2 == null ? 1 : 0) == 0)
          g.method_11(this.cx, this.cy - this.ch / Class15.smethod_0(7), this.gclass20_2.cx, this.gclass20_2.cy - this.gclass20_2.ch / Class15.smethod_0(7));
        if ((this.gclass100_0 == null ? 1 : 0) == 0)
          g.method_11(this.cx, this.cy - this.ch / Class15.smethod_0(7), this.gclass100_0.x, this.gclass100_0.y - this.gclass100_0.h / Class15.smethod_0(7));
      }
      this.method_79(g);
      this.method_147(g);
      this.method_138(g);
      this.method_149(g);
      if (this.shadowLife > Class15.smethod_0(0))
      {
        if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
          this.method_94(g, this.shadowX, this.shadowY, this.cdir, Class15.smethod_0(46), Class15.smethod_0(1) != 0);
        else if (this.shadowLife > Class15.smethod_0(3))
          this.method_94(g, this.shadowX, this.shadowY, this.cdir, Class15.smethod_0(38), Class15.smethod_0(1) != 0);
      }
      if ((!this.method_74() ? 0 : 1) == 0 && (this.skillPaint == null ? 1 : 0) == 0 && (this.skillPaint.id < Class15.smethod_0(152) || this.skillPaint.id > Class15.smethod_0(177)) && (this.skillPaint.id < Class15.smethod_0(216) || this.skillPaint.id > Class15.smethod_0(60)))
      {
        if ((this.skillPaint == null ? 1 : 0) == 0)
        {
          this.indexSkill = this.method_71().Length;
          this.skillPaint = (GClass165) null;
        }
        this.effPaints = (GClass52[]) null;
        this.eff = (GClass49) null;
        this.effTask = (GClass49) null;
        this.indexEff = -1;
        this.indexEffTask = -1;
      }
      else
      {
        if (this.statusMe == Class15.smethod_0(9) || (this.moveFast == null ? 1 : 0) == 0 && (int) this.moveFast[Class15.smethod_0(0)] > Class15.smethod_0(0))
          return;
        this.method_86(g);
        if ((this.skillPaint == null ? 1 : 0) != 0 || (this.method_71() == null ? 1 : 0) != 0 || this.indexSkill >= this.method_71().Length)
          this.method_89(g);
        if ((this.arr == null ? 1 : 0) == 0)
          this.arr.method_2(g);
        if ((this.dart == null ? 1 : 0) == 0)
          this.dart.method_3(g);
        this.method_81(g);
        this.method_53(g);
        this.method_78(g);
        this.method_150(g);
        this.method_80(g);
        this.method_148(g);
        this.method_139(g);
        this.method_77(g);
      }
    }
  }

  private void method_77(GClass98 gclass98_0)
  {
    if ((this.x_hint == (short) 0 ? 1 : 0) != 0 || (this.y_hint == (short) 0 ? 1 : 0) != 0 || this.statusMe == Class15.smethod_0(49))
      return;
    int num1 = Class15.smethod_0(0);
    int x = this.cx - Class15.smethod_0(6);
    int y = this.cy - Class15.smethod_0(9);
    int num2 = Class15.smethod_0(217);
    int num3 = Class15.smethod_0(3);
    if (GClass151.smethod_25(this.cy - (int) this.y_hint) > Class15.smethod_0(19))
    {
      if (this.cy > (int) this.y_hint)
      {
        num1 = Class15.smethod_0(38);
        x = this.cx;
        y = this.cy - Class15.smethod_0(9) - Class15.smethod_0(4);
      }
      else
      {
        num1 = Class15.smethod_0(3);
        x = this.cx;
        y = this.cy - Class15.smethod_0(9) + Class15.smethod_0(4);
      }
    }
    else if (this.cx > (int) this.x_hint)
      num1 = Class15.smethod_0(7);
    else if (this.cx <= (int) this.x_hint)
      x = this.cx + Class15.smethod_0(6);
    if (GClass62.int_8 % Class15.smethod_0(31) < Class15.smethod_0(3))
      return;
    if (GClass151.smethod_25(this.cx - (int) this.x_hint) > Class15.smethod_0(21))
      gclass98_0.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), num1, x, y, GClass177.int_6);
    else
      gclass98_0.method_32(GClass141.gclass66_0, (int) this.x_hint + num2, (int) this.y_hint - Class15.smethod_0(4) + num3, Class15.smethod_0(0));
  }

  private void method_78(GClass98 gclass98_0)
  {
    for (int index = Class15.smethod_0(0); index < this.vEffChar.method_2(); index += Class15.smethod_0(1))
    {
      GClass41 gclass41 = (GClass41) this.vEffChar.method_3(index);
      if (gclass41.effId >= Class15.smethod_0(218))
        gclass41.method_3(gclass98_0);
    }
  }

  private void method_79(GClass98 gclass98_0)
  {
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((!GClass20.bool_18 ? 0 : 1) == 0 && this.idAuraEff > (short) -1)
        return;
    }
    else if (this.idAuraEff > (short) -1)
      return;
    if ((!GClass20.bool_19 ? 1 : 0) != 0 || this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37) || (!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(0) || (!this.isCopy ? 0 : 1) != 0 || this.clevel < Class15.smethod_0(10))
      return;
    int id = Class15.smethod_0(219);
    int num = Class15.smethod_0(2);
    if (this.clevel >= Class15.smethod_0(65))
      id = Class15.smethod_0(220);
    if (this.clevel >= Class15.smethod_0(28))
      id = Class15.smethod_0(221);
    if (this.clevel >= Class15.smethod_0(46))
      id = Class15.smethod_0(222);
    if (id == -1)
      return;
    GClass192 gclass192 = GClass169.gclass192_0[id];
    if ((gclass192 == null ? 0 : 1) == 0)
    {
      GClass169.smethod_5(id);
    }
    else
    {
      int y0 = GClass62.int_8 / Class15.smethod_0(2) % num * (GClass98.smethod_1(gclass192.img) / num);
      gclass98_0.method_24(gclass192.img, Class15.smethod_0(0), y0, GClass98.smethod_0(gclass192.img), GClass98.smethod_1(gclass192.img) / num, Class15.smethod_0(0), this.cx, this.cy + Class15.smethod_0(7), GClass98.int_5 | GClass98.int_0);
    }
  }

  private void method_80(GClass98 gclass98_0)
  {
    if ((!this.me ? 1 : 0) == 0)
    {
      if ((!GClass20.bool_18 ? 0 : 1) == 0 && this.idAuraEff > (short) -1)
        return;
    }
    else if (this.idAuraEff > (short) -1)
      return;
    if ((!GClass20.bool_19 ? 0 : 1) == 0)
      return;
    if (this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37))
    {
      this.long_0 = GClass126.smethod_18() + (long) Class15.smethod_0(225);
      this.bool_10 = Class15.smethod_0(1) != 0;
      this.bool_11 = Class15.smethod_0(1) != 0;
    }
    else
    {
      if ((!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(0))
        return;
      if ((!this.isCopy ? 1 : 0) == 0)
      {
        if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
          this.int_11 += Class15.smethod_0(1);
        if (this.int_11 > Class15.smethod_0(37))
          this.int_11 = Class15.smethod_0(0);
        gclass98_0.method_32(GClass62.gclass66_3[this.int_11], this.cx, this.cy + Class15.smethod_0(45), GClass98.int_5 | GClass98.int_0);
      }
      else
      {
        if (this.clevel >= Class15.smethod_0(49) && (!GClass62.bool_1 ? 0 : 1) == 0)
        {
          bool flag = Class15.smethod_0(0) != 0;
          if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(223) && (!this.bool_10 ? 1 : 0) == 0)
          {
            flag = Class15.smethod_0(1) != 0;
            this.bool_10 = Class15.smethod_0(0) != 0;
          }
          if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(178) && (!this.bool_11 ? 1 : 0) == 0)
          {
            flag = Class15.smethod_0(1) != 0;
            this.bool_11 = Class15.smethod_0(0) != 0;
          }
          if ((!flag ? 1 : 0) == 0)
          {
            GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
            GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
            this.method_120(Class15.smethod_0(1));
          }
        }
        if (this.clevel == Class15.smethod_0(49))
        {
          if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
            this.int_11 += Class15.smethod_0(1);
          if (this.int_11 > Class15.smethod_0(37))
            this.int_11 = Class15.smethod_0(0);
          gclass98_0.method_32(GClass62.gclass66_2[this.int_11], this.cx, this.cy + Class15.smethod_0(45), GClass98.int_5 | GClass98.int_0);
        }
        else if (this.clevel == Class15.smethod_0(9))
        {
          if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
            this.int_11 += Class15.smethod_0(1);
          if (this.int_11 > Class15.smethod_0(37))
            this.int_11 = Class15.smethod_0(0);
          gclass98_0.method_32(GClass62.gclass66_3[this.int_11], this.cx, this.cy + Class15.smethod_0(45), GClass98.int_5 | GClass98.int_0);
        }
        else
        {
          if (this.clevel < Class15.smethod_0(10))
            return;
          int id = -1;
          int num = Class15.smethod_0(2);
          if (this.clevel >= Class15.smethod_0(10) && this.clevel < Class15.smethod_0(28))
          {
            id = Class15.smethod_0(224);
            num = Class15.smethod_0(2);
          }
          if (id == -1)
            return;
          GClass192 gclass192 = GClass169.gclass192_0[id];
          if ((gclass192 == null ? 0 : 1) == 0)
          {
            GClass169.smethod_5(id);
          }
          else
          {
            int y0 = GClass62.int_8 / Class15.smethod_0(2) % num * (GClass98.smethod_1(gclass192.img) / num);
            gclass98_0.method_24(gclass192.img, Class15.smethod_0(0), y0, GClass98.smethod_0(gclass192.img), GClass98.smethod_1(gclass192.img) / num, Class15.smethod_0(0), this.cx, this.cy + Class15.smethod_0(7), GClass98.int_5 | GClass98.int_0);
          }
        }
      }
    }
  }

  private void method_81(GClass98 gclass98_0)
  {
    if ((this.effPaints == null ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < this.effPaints.Length; index += Class15.smethod_0(1))
      {
        if ((this.effPaints[index] == null ? 1 : 0) == 0)
        {
          if ((this.effPaints[index].eMob == null ? 1 : 0) == 0)
          {
            int y = this.effPaints[index].eMob.y;
            if ((!(this.effPaints[index].eMob is GClass104) ? 1 : 0) == 0)
              y = this.effPaints[index].eMob.y - Class15.smethod_0(4);
            if ((!(this.effPaints[index].eMob is GClass102) ? 1 : 0) == 0)
              y = this.effPaints[index].eMob.y - Class15.smethod_0(32);
            if ((!(this.effPaints[index].eMob is GClass101) ? 1 : 0) == 0)
              y = this.effPaints[index].eMob.y - Class15.smethod_0(54);
            GClass169.smethod_6(gclass98_0, this.effPaints[index].method_0(), this.effPaints[index].eMob.x, y, Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
          }
          else if ((this.effPaints[index].eChar == null ? 1 : 0) == 0)
            GClass169.smethod_6(gclass98_0, this.effPaints[index].method_0(), this.effPaints[index].eChar.cx, this.effPaints[index].eChar.cy, Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
        }
      }
    }
    if (this.indexEff >= Class15.smethod_0(0) && (this.eff == null ? 1 : 0) == 0)
      GClass169.smethod_6(gclass98_0, this.eff.arrEfInfo[this.indexEff].idImg, this.cx + this.eff.arrEfInfo[this.indexEff].dx, this.cy + this.eff.arrEfInfo[this.indexEff].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
    if (this.indexEffTask < Class15.smethod_0(0) || (this.effTask == null ? 1 : 0) != 0)
      return;
    GClass169.smethod_6(gclass98_0, this.effTask.arrEfInfo[this.indexEffTask].idImg, this.cx + this.effTask.arrEfInfo[this.indexEffTask].dx, this.cy + this.effTask.arrEfInfo[this.indexEffTask].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
  }

  private void method_82(GClass98 gclass98_0)
  {
  }

  public void method_83(GClass98 g, int x, int y)
  {
    int num1 = this.cHP * Class15.smethod_0(21) / this.cHPFull / Class15.smethod_0(31) - Class15.smethod_0(1);
    if (num1 < Class15.smethod_0(0))
      num1 = Class15.smethod_0(0);
    if (num1 > Class15.smethod_0(45))
      num1 = Class15.smethod_0(45);
    g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(37) * (Class15.smethod_0(45) - num1), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), x, y, Class15.smethod_0(5));
    if ((this.cTypePk == (sbyte) 0 ? 0 : 1) == 0 && ((GClass20.smethod_1().cFlag == (sbyte) 0 ? 1 : 0) != 0 || (this.cFlag == (sbyte) 0 ? 1 : 0) != 0 || (int) this.cFlag != Class15.smethod_0(88) && (int) GClass20.smethod_1().cFlag != Class15.smethod_0(88) && (int) this.cFlag == (int) GClass20.smethod_1().cFlag))
      return;
    this.len = (int) ((long) this.cHP * (long) Class15.smethod_0(21) / (long) this.cHPFull * (long) this.w_hp_bar) / Class15.smethod_0(21);
    int num2 = (int) ((long) this.cHP * (long) Class15.smethod_0(21) / (long) this.cHPFull);
    this.gclass66_12 = num2 >= Class15.smethod_0(6) ? (num2 >= Class15.smethod_0(4) ? GClass116.gclass66_38 : GClass116.gclass66_36) : GClass116.gclass66_35;
    int num3 = GClass98.smethod_0(GClass116.gclass66_35);
    int h0 = GClass98.smethod_1(GClass116.gclass66_35);
    int w0 = num3 * num2 / Class15.smethod_0(21);
    g.method_32(GClass116.gclass66_37, x - (num3 >> Class15.smethod_0(1)), y - Class15.smethod_0(1), GClass98.int_4 | GClass98.int_2);
    if (this.len < Class15.smethod_0(3))
    {
      if (GClass62.int_8 % Class15.smethod_0(37) >= Class15.smethod_0(5))
        return;
      g.method_24(this.gclass66_12, Class15.smethod_0(0), Class15.smethod_0(0), w0, h0, Class15.smethod_0(0), x - (num3 >> Class15.smethod_0(1)), y - Class15.smethod_0(1), GClass98.int_4 | GClass98.int_2);
    }
    else
      g.method_24(this.gclass66_12, Class15.smethod_0(0), Class15.smethod_0(0), w0, h0, Class15.smethod_0(0), x - (num3 >> Class15.smethod_0(1)), y - Class15.smethod_0(1), GClass98.int_4 | GClass98.int_2);
  }

  public int method_84()
  {
    int num = Class15.smethod_0(226);
    if (this.nClass.classId != Class15.smethod_0(1) && this.nClass.classId != Class15.smethod_0(7))
    {
      if (this.nClass.classId != Class15.smethod_0(5) && this.nClass.classId != Class15.smethod_0(2))
      {
        if (this.nClass.classId == Class15.smethod_0(3) || this.nClass.classId == Class15.smethod_0(37))
          num = Class15.smethod_0(228);
      }
      else
        num = Class15.smethod_0(227);
    }
    else
      num = Class15.smethod_0(133);
    return num;
  }

  public void method_85(GClass98 g)
  {
    if ((int) this.cTypePk == Class15.smethod_0(5) || (int) this.cTypePk == Class15.smethod_0(3) || (!this.method_74() ? 1 : 0) != 0)
      return;
    if ((GClass20.smethod_1().charFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().charFocus.Equals((object) this) ? 0 : 1) != 0)
    {
      if ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0 || (!GClass20.smethod_1().charFocus.Equals((object) this) ? 1 : 0) != 0)
        return;
      GClass97.gclass97_15.method_10(g, this.cName, this.cx, this.cy - this.ch - GClass97.gclass97_19.method_20() - Class15.smethod_0(31), GClass97.int_2, GClass97.gclass97_16);
    }
    else
      GClass97.gclass97_15.method_10(g, this.cName, this.cx, this.cy - this.ch - GClass97.gclass97_19.method_20() - Class15.smethod_0(3), GClass97.int_2, GClass97.gclass97_16);
  }

  private void method_86(GClass98 gclass98_0)
  {
    GClass142 gclass142 = GClass116.gclass142_0[this.method_146(this.head)];
    int num1 = GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(7)] - (int) gclass142.pi[GClass20.int_0[this.cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy + Class15.smethod_0(3);
    if ((!this.isInvisiblez ? 1 : 0) == 0 && (!this.me ? 1 : 0) != 0 || (!this.me ? 0 : 1) == 0 && GClass185.int_37 == Class15.smethod_0(76) && this.cy >= Class15.smethod_0(229) || (!this.me ? 1 : 0) == 0)
      return;
    bool flag1 = (GClass20.gclass20_0.clan == null ? 1 : 0) != 0 ? Class15.smethod_0(0) != 0 : this.clanID == GClass20.gclass20_0.clan.ID;
    bool flag2 = (int) this.cTypePk == Class15.smethod_0(5) ? Class15.smethod_0(1) != 0 : (int) this.cTypePk == Class15.smethod_0(3);
    bool flag3 = (int) this.cTypePk == Class15.smethod_0(2);
    if ((!this.cName.StartsWith(Class13.smethod_0(141464)) ? 1 : 0) == 0)
    {
      this.cName = this.cName.Substring(Class15.smethod_0(1));
      this.isPet = Class15.smethod_0(1) != 0;
    }
    if ((!this.cName.StartsWith(Class13.smethod_0(141446)) ? 1 : 0) == 0)
    {
      this.cName = this.cName.Substring(Class15.smethod_0(1));
      this.isMiniPet = Class15.smethod_0(1) != 0;
    }
    if ((GClass20.smethod_1().charFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().charFocus.Equals((object) this) ? 1 : 0) == 0)
    {
      num1 += Class15.smethod_0(3);
      this.method_83(gclass98_0, this.cx, this.cy - num1 + Class15.smethod_0(5));
    }
    int num2 = num1 + GClass97.gclass97_20.method_20();
    GClass97 gclass97 = GClass97.gclass97_40;
    if ((!this.isPet ? 0 : 1) == 0 && (!this.isMiniPet ? 1 : 0) != 0)
    {
      if ((!flag2 ? 1 : 0) == 0)
        gclass97 = GClass97.gclass97_34;
      else if ((!flag3 ? 1 : 0) == 0)
        gclass97 = GClass97.gclass97_35;
      else if ((!flag1 ? 1 : 0) == 0)
        gclass97 = GClass97.gclass97_36;
    }
    else
      gclass97 = GClass97.gclass97_13;
    if ((!(this.paintName | flag2 | flag3) ? 1 : 0) == 0 && (!flag1 ? 0 : 1) == 0)
    {
      if (GClass126.int_0 == Class15.smethod_0(1))
        gclass97.method_10(gclass98_0, this.cName, this.cx, this.cy - num2, GClass97.int_2, GClass97.gclass97_37);
      else
        gclass97.method_6(gclass98_0, this.cName, this.cx, this.cy - num2, GClass97.int_2);
      num2 += GClass97.gclass97_11.method_20();
    }
    if ((!flag1 ? 1 : 0) != 0)
      return;
    if ((GClass20.smethod_1().charFocus == null ? 1 : 0) == 0 && (!GClass20.smethod_1().charFocus.Equals((object) this) ? 1 : 0) == 0)
    {
      gclass97.method_10(gclass98_0, this.cName, this.cx, this.cy - num2, GClass97.int_2, GClass97.gclass97_37);
    }
    else
    {
      if ((this.charFocus == null ? 0 : 1) != 0)
        return;
      gclass97.method_10(gclass98_0, this.cName, this.cx - Class15.smethod_0(31), this.cy - num2 + Class15.smethod_0(5), GClass97.int_0, GClass97.gclass97_16);
      this.method_83(gclass98_0, this.cx - Class15.smethod_0(10), this.cy - num2 + Class15.smethod_0(31));
    }
  }

  public void method_87(GClass98 g)
  {
    if ((!this.isMabuHold ? 0 : 1) != 0 || this.head == Class15.smethod_0(230) || this.leg == Class15.smethod_0(231) || (!this.isTeleport ? 0 : 1) != 0 || (!this.isFlyUp ? 1 : 0) == 0)
      return;
    int sbyte0 = (int) GClass185.sbyte_0;
    if ((GClass185.int_37 < Class15.smethod_0(24) || GClass185.int_37 > Class15.smethod_0(98)) && GClass185.int_37 != Class15.smethod_0(73) && GClass185.int_37 != Class15.smethod_0(212))
    {
      if ((!GClass185.smethod_27(this.xSd + sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(2)) ? 1 : 0) == 0)
        g.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
      else if ((GClass185.smethod_25((this.xSd - sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
        g.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, Class15.smethod_0(21), Class15.smethod_0(21));
      else if ((GClass185.smethod_25((this.xSd + sbyte0 / Class15.smethod_0(7)) / sbyte0, (this.ySd + Class15.smethod_0(1)) / sbyte0) == 0 ? 0 : 1) == 0)
        g.method_5(this.xSd / sbyte0 * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
      else if ((!GClass185.smethod_27(this.xSd - sbyte0 / Class15.smethod_0(7), this.ySd + Class15.smethod_0(1), Class15.smethod_0(88)) ? 1 : 0) == 0)
        g.method_5(this.xSd / Class15.smethod_0(40) * sbyte0, (this.ySd - Class15.smethod_0(6)) / sbyte0 * sbyte0, sbyte0, Class15.smethod_0(21));
    }
    g.method_32(GClass185.gclass66_10, this.xSd, this.ySd, Class15.smethod_0(5));
    g.method_5(GClass116.int_22, GClass116.int_23 - GClass62.int_52, GClass116.int_6, GClass116.int_7 + Class15.smethod_0(7) * GClass62.int_52);
  }

  public void method_88()
  {
    int num = Class15.smethod_0(0);
    this.xSd = this.cx;
    if ((!GClass185.smethod_27(this.cx, this.cy, Class15.smethod_0(7)) ? 1 : 0) == 0)
    {
      this.ySd = this.cy;
    }
    else
    {
      this.ySd = this.cy;
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

  private void method_89(GClass98 gclass98_0)
  {
    try
    {
      if ((!this.isInvisiblez ? 1 : 0) == 0)
      {
        if ((!this.me ? 1 : 0) == 0)
        {
          if (GClass62.int_8 % Class15.smethod_0(32) != Class15.smethod_0(154) && GClass62.int_8 % Class15.smethod_0(32) != Class15.smethod_0(23))
            GClass169.smethod_6(gclass98_0, Class15.smethod_0(233), this.cx, this.cy - Class15.smethod_0(124), Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
          else
            GClass169.smethod_6(gclass98_0, Class15.smethod_0(232), this.cx, this.cy - Class15.smethod_0(124), Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        }
      }
      else
        this.method_94(gclass98_0, this.cx, this.cy + this.fy, this.cdir, this.cf, Class15.smethod_0(1) != 0);
      if ((!this.isLockAttack ? 1 : 0) != 0)
        return;
      GClass169.smethod_6(gclass98_0, Class15.smethod_0(234), this.cx, this.cy, Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0);
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(141907) + ex.ToString());
    }
  }

  public void method_90(GClass98 g, short[] id, int x, int y, int dir, bool isPaintChar)
  {
    int num1 = Class15.smethod_0(0);
    int num2 = Class15.smethod_0(0);
    if (this.statusMe == Class15.smethod_0(37))
    {
      num1 = Class15.smethod_0(88);
      num2 = Class15.smethod_0(186);
    }
    if (this.statusMe == Class15.smethod_0(1))
    {
      if (this.cp1 % Class15.smethod_0(9) < Class15.smethod_0(3))
      {
        num1 = Class15.smethod_0(88);
        num2 = Class15.smethod_0(186);
      }
      else
      {
        num1 = Class15.smethod_0(88);
        num2 = Class15.smethod_0(124);
      }
    }
    if (this.statusMe == Class15.smethod_0(7))
    {
      if (this.cf <= Class15.smethod_0(5))
      {
        num1 = Class15.smethod_0(38);
        num2 = Class15.smethod_0(186);
      }
      else
      {
        num1 = Class15.smethod_0(38);
        num2 = Class15.smethod_0(124);
      }
    }
    if (this.statusMe == Class15.smethod_0(5) || this.statusMe == Class15.smethod_0(45))
    {
      num1 = Class15.smethod_0(3);
      num2 = Class15.smethod_0(51);
    }
    if (this.statusMe == Class15.smethod_0(2))
    {
      if (this.cf == Class15.smethod_0(88))
      {
        num1 = Class15.smethod_0(3);
        num2 = Class15.smethod_0(10);
      }
      else
      {
        num1 = Class15.smethod_0(3);
        num2 = Class15.smethod_0(51);
      }
    }
    if (this.statusMe == Class15.smethod_0(31))
    {
      GClass151.smethod_7(Class13.smethod_0(142065) + this.cf.ToString());
      if (this.cf == Class15.smethod_0(88))
      {
        num1 = Class15.smethod_0(0);
        num2 = Class15.smethod_0(29);
      }
      else
      {
        num1 = Class15.smethod_0(3);
        num2 = Class15.smethod_0(28);
      }
    }
    if ((int) this.isInjure > Class15.smethod_0(0))
    {
      num1 = Class15.smethod_0(3);
      num2 = Class15.smethod_0(124);
    }
    if ((this.skillPaint == null ? 1 : 0) == 0 && (this.method_71() == null ? 1 : 0) == 0 && this.indexSkill < this.method_71().Length)
    {
      num1 = -1;
      num2 = Class15.smethod_0(186);
    }
    this.int_14 += Class15.smethod_0(1);
    if (this.int_14 > Class15.smethod_0(181))
      this.int_14 = Class15.smethod_0(0);
    sbyte index = (sbyte) (this.int_14 / Class15.smethod_0(2) % id.Length);
    if ((!isPaintChar ? 0 : 1) == 0)
    {
      if (id.Length == Class15.smethod_0(7))
        index = (sbyte) Class15.smethod_0(1);
      if (id.Length == Class15.smethod_0(5))
      {
        if ((int) id[Class15.smethod_0(7)] >= Class15.smethod_0(0))
        {
          index = (sbyte) Class15.smethod_0(7);
          if (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3))
            index = (sbyte) Class15.smethod_0(1);
        }
        else
          index = (sbyte) Class15.smethod_0(1);
      }
    }
    else if (id.Length > Class15.smethod_0(1) && ((index == (sbyte) 0 ? 1 : 0) != 0 || (int) index == Class15.smethod_0(1)) && this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37))
    {
      this.int_14 = Class15.smethod_0(0);
      index = (sbyte) Class15.smethod_0(0);
      if (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3))
        index = (sbyte) Class15.smethod_0(1);
    }
    GClass169.smethod_6(g, (int) id[(int) index], x + (dir != Class15.smethod_0(1) ? num1 : -num1), y - num2, dir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass177.int_6);
  }

  public bool method_91(int id)
  {
    GClass142 gclass142_1 = GClass116.gclass142_0[this.head];
    GClass142 gclass142_2 = GClass116.gclass142_0[this.leg];
    GClass142 gclass142_3 = GClass116.gclass142_0[this.body];
    for (int index = Class15.smethod_0(0); index < GClass20.int_0.Length; index += Class15.smethod_0(1))
    {
      if (id == (int) gclass142_1.pi[GClass20.int_0[index][Class15.smethod_0(0)][Class15.smethod_0(0)]].id)
        return Class15.smethod_0(1) != 0;
      if (id == (int) gclass142_2.pi[GClass20.int_0[index][Class15.smethod_0(1)][Class15.smethod_0(0)]].id)
        return Class15.smethod_0(1) != 0;
      if (id == (int) gclass142_3.pi[GClass20.int_0[index][Class15.smethod_0(7)][Class15.smethod_0(0)]].id)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public void method_92(GClass98 g, int cx, int cy, int look)
  {
    GClass142 gclass142 = GClass116.gclass142_0[this.head];
    GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx, cy, (look == 0 ? 0 : 1) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_3 | GClass98.int_1);
  }

  public void method_93(GClass98 g, int x, int y, int look)
  {
    GClass142 gclass142 = GClass116.gclass142_0[this.head];
    GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, x + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx - Class15.smethod_0(5), y + Class15.smethod_0(5), look, GClass98.int_2 | GClass98.int_5);
  }

  public void method_94(GClass98 g, int cx, int cy, int cdir, int cf, bool isPaintBag)
  {
    this.gclass142_0 = GClass116.gclass142_0[this.head];
    this.gclass142_1 = GClass116.gclass142_0[this.leg];
    this.gclass142_2 = GClass116.gclass142_0[this.body];
    if (this.bag >= Class15.smethod_0(0) && this.statusMe != Class15.smethod_0(49))
    {
      if (!GClass26.gclass128_0.method_7((object) (this.bag.ToString() + string.Empty)))
      {
        GClass26.gclass128_0.method_4((object) (this.bag.ToString() + string.Empty), (object) new GClass26());
        GClass156.smethod_0().method_119((sbyte) this.bag);
      }
      else
      {
        GClass26 gclass26 = (GClass26) GClass26.gclass128_0.method_0((object) (this.bag.ToString() + string.Empty));
        if (gclass26.idImage != null & isPaintBag)
          this.method_90(g, gclass26.idImage, cx, cy, cdir, Class15.smethod_0(1) != 0);
      }
    }
    int num1 = Class15.smethod_0(7);
    int num2 = Class15.smethod_0(40);
    int anchor = GClass177.int_2;
    int num3 = -1;
    if (cdir == Class15.smethod_0(1))
    {
      num1 = Class15.smethod_0(0);
      num2 = Class15.smethod_0(0);
      anchor = Class15.smethod_0(0);
      num3 = Class15.smethod_0(1);
    }
    if (this.statusMe == Class15.smethod_0(49))
    {
      if (GClass62.int_8 % Class15.smethod_0(2) > Class15.smethod_0(0))
        g.method_32(GClass81.gclass66_0, cx, cy - this.ch - Class15.smethod_0(67), GClass98.int_0 | GClass98.int_1);
      int num4 = Class15.smethod_0(0);
      if (this.head == Class15.smethod_0(118) || this.head == Class15.smethod_0(235) || this.head == Class15.smethod_0(236) || this.head == Class15.smethod_0(237) || this.head == Class15.smethod_0(238) || this.head == Class15.smethod_0(239) || this.head == Class15.smethod_0(240) || this.head == Class15.smethod_0(241) || this.head == Class15.smethod_0(242))
        num4 = Class15.smethod_0(9);
      GClass169.smethod_6(g, Class15.smethod_0(243), cx, cy - GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy - Class15.smethod_0(7) + num4, num1, GClass177.int_0);
      GClass169.smethod_6(g, Class15.smethod_0(61), cx, cy - this.ch - Class15.smethod_0(88), Class15.smethod_0(0), GClass98.int_0 | GClass98.int_5);
      GClass169.smethod_6(g, (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
      this.method_151(g, cf, cy - GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy);
      if (this.method_144(this.head))
      {
        GClass142 gclass142 = GClass116.gclass142_0[this.method_146(this.head)];
        GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
      }
      else
        GClass169.smethod_6(g, (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
      this.method_152(g, cf, cy - GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy);
      this.method_143(g, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
    }
    else
    {
      this.method_151(g, cf, cy - GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy);
      if (this.method_144(this.head))
      {
        GClass142 gclass142 = GClass116.gclass142_0[this.method_146(this.head)];
        GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
      }
      else
        GClass169.smethod_6(g, (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
      GClass169.smethod_6(g, (int) this.gclass142_1.pi[GClass20.int_0[cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(1)][Class15.smethod_0(1)] + (int) this.gclass142_1.pi[GClass20.int_0[cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) this.gclass142_1.pi[GClass20.int_0[cf][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy, num1, num2);
      GClass169.smethod_6(g, (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, cx + (GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(1)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) this.gclass142_2.pi[GClass20.int_0[cf][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy, num1, num2);
      this.method_143(g, cx + (GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx) * num3, cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, num1, num2);
    }
    this.ch = (int) this.isMonkey == Class15.smethod_0(1) || this.isFusion ? Class15.smethod_0(4) : GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) this.gclass142_0.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy + Class15.smethod_0(31);
    int num5 = GClass151.smethod_25((int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy) < Class15.smethod_0(28) ? (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy : ((int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy >= Class15.smethod_0(0) ? (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy - Class15.smethod_0(3) : (int) this.gclass142_0.pi[GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy + Class15.smethod_0(3));
    this.cH_new = cy - GClass20.int_0[cf][Class15.smethod_0(0)][Class15.smethod_0(7)] + num5;
    if (this.statusMe == Class15.smethod_0(1) && this.charID > Class15.smethod_0(0) && !this.isMask && !this.method_64() && !this.isWaitMonkey && this.skillPaint == null && cf != Class15.smethod_0(29) && this.bag < Class15.smethod_0(0) && ((GClass62.int_8 + this.charID) % Class15.smethod_0(6) == 0 || this.isFreez))
      g.method_32(this.cgender != Class15.smethod_0(1) ? GClass20.gclass66_0 : GClass20.gclass66_1, cx + -(this.cgender != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(7)) * num3, cy - Class15.smethod_0(120) + (this.cgender != Class15.smethod_0(1) ? Class15.smethod_0(67) : Class15.smethod_0(31)) - cf, anchor);
    if (this.gclass41_0 != null)
      this.gclass41_0.method_3(g);
    this.method_122(g);
  }

  public void method_95(GClass98 g)
  {
    this.ty = Class15.smethod_0(0);
    GClass162[] gclass162Array = this.method_71();
    this.cf = gclass162Array[this.indexSkill].status;
    this.method_89(g);
    if (this.cdir == Class15.smethod_0(1))
    {
      if (this.eff0 != null)
      {
        if (this.dx0 == 0)
          this.dx0 = gclass162Array[this.indexSkill].e0dx;
        if (this.dy0 == 0)
          this.dy0 = gclass162Array[this.indexSkill].e0dy;
        GClass169.smethod_6(g, this.eff0.arrEfInfo[this.i0].idImg, this.cx + this.dx0 + this.eff0.arrEfInfo[this.i0].dx, this.cy + this.dy0 + this.eff0.arrEfInfo[this.i0].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        this.i0 += Class15.smethod_0(1);
        if (this.i0 >= this.eff0.arrEfInfo.Length)
        {
          this.eff0 = (GClass49) null;
          this.i0 = this.dx0 = this.dy0 = Class15.smethod_0(0);
        }
      }
      if (this.eff1 != null)
      {
        if (this.dx1 == 0)
          this.dx1 = gclass162Array[this.indexSkill].e1dx;
        if (this.dy1 == 0)
          this.dy1 = gclass162Array[this.indexSkill].e1dy;
        GClass169.smethod_6(g, this.eff1.arrEfInfo[this.i1].idImg, this.cx + this.dx1 + this.eff1.arrEfInfo[this.i1].dx, this.cy + this.dy1 + this.eff1.arrEfInfo[this.i1].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        this.i1 += Class15.smethod_0(1);
        if (this.i1 >= this.eff1.arrEfInfo.Length)
        {
          this.eff1 = (GClass49) null;
          this.i1 = this.dx1 = this.dy1 = Class15.smethod_0(0);
        }
      }
      if (this.eff2 != null)
      {
        if (this.dx2 == 0)
          this.dx2 = gclass162Array[this.indexSkill].e2dx;
        if (this.dy2 == 0)
          this.dy2 = gclass162Array[this.indexSkill].e2dy;
        GClass169.smethod_6(g, this.eff2.arrEfInfo[this.i2].idImg, this.cx + this.dx2 + this.eff2.arrEfInfo[this.i2].dx, this.cy + this.dy2 + this.eff2.arrEfInfo[this.i2].dy, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        this.i2 += Class15.smethod_0(1);
        if (this.i2 >= this.eff2.arrEfInfo.Length)
        {
          this.eff2 = (GClass49) null;
          this.i2 = this.dx2 = this.dy2 = Class15.smethod_0(0);
        }
      }
    }
    else
    {
      if (this.eff0 != null)
      {
        if (this.dx0 == 0)
          this.dx0 = gclass162Array[this.indexSkill].e0dx;
        if (this.dy0 == 0)
          this.dy0 = gclass162Array[this.indexSkill].e0dy;
        GClass169.smethod_6(g, this.eff0.arrEfInfo[this.i0].idImg, this.cx - this.dx0 - this.eff0.arrEfInfo[this.i0].dx, this.cy + this.dy0 + this.eff0.arrEfInfo[this.i0].dy, Class15.smethod_0(7), GClass98.int_1 | GClass98.int_0);
        this.i0 += Class15.smethod_0(1);
        if (this.i0 >= this.eff0.arrEfInfo.Length)
        {
          this.eff0 = (GClass49) null;
          this.i0 = Class15.smethod_0(0);
          this.dx0 = Class15.smethod_0(0);
          this.dy0 = Class15.smethod_0(0);
        }
      }
      if (this.eff1 != null)
      {
        if (this.dx1 == 0)
          this.dx1 = gclass162Array[this.indexSkill].e1dx;
        if (this.dy1 == 0)
          this.dy1 = gclass162Array[this.indexSkill].e1dy;
        GClass169.smethod_6(g, this.eff1.arrEfInfo[this.i1].idImg, this.cx - this.dx1 - this.eff1.arrEfInfo[this.i1].dx, this.cy + this.dy1 + this.eff1.arrEfInfo[this.i1].dy, Class15.smethod_0(7), GClass98.int_1 | GClass98.int_0);
        this.i1 += Class15.smethod_0(1);
        if (this.i1 >= this.eff1.arrEfInfo.Length)
        {
          this.eff1 = (GClass49) null;
          this.i1 = Class15.smethod_0(0);
          this.dx1 = Class15.smethod_0(0);
          this.dy1 = Class15.smethod_0(0);
        }
      }
      if (this.eff2 != null)
      {
        if (this.dx2 == 0)
          this.dx2 = gclass162Array[this.indexSkill].e2dx;
        if (this.dy2 == 0)
          this.dy2 = gclass162Array[this.indexSkill].e2dy;
        GClass169.smethod_6(g, this.eff2.arrEfInfo[this.i2].idImg, this.cx - this.dx2 - this.eff2.arrEfInfo[this.i2].dx, this.cy + this.dy2 + this.eff2.arrEfInfo[this.i2].dy, Class15.smethod_0(7), GClass98.int_1 | GClass98.int_0);
        this.i2 += Class15.smethod_0(1);
        if (this.i2 >= this.eff2.arrEfInfo.Length)
        {
          this.eff2 = (GClass49) null;
          this.i2 = Class15.smethod_0(0);
          this.dx2 = Class15.smethod_0(0);
          this.dy2 = Class15.smethod_0(0);
        }
      }
    }
    this.indexSkill += Class15.smethod_0(1);
  }

  public static int smethod_5(int ID)
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass20) GClass116.gclass134_5.method_3(index)).charID == ID)
        return index;
    }
    return -1;
  }

  public void method_96(int toX, int toY, int type)
  {
    if (type != Class15.smethod_0(1) && GClass151.smethod_25(toX - this.cx) <= Class15.smethod_0(21) && GClass151.smethod_25(toY - this.cy) <= Class15.smethod_0(137))
    {
      int dir = Class15.smethod_0(0);
      int act = Class15.smethod_0(0);
      int num1 = toX - this.cx;
      int num2 = toY - this.cy;
      if ((num1 == 0 ? 0 : 1) == 0 && (num2 == 0 ? 0 : 1) == 0)
      {
        act = Class15.smethod_0(1);
        this.cp3 = Class15.smethod_0(0);
      }
      else if ((num2 == 0 ? 0 : 1) == 0)
      {
        act = Class15.smethod_0(7);
        if (num1 > Class15.smethod_0(0))
          dir = Class15.smethod_0(1);
        if (num1 < Class15.smethod_0(0))
          dir = -1;
      }
      else if ((num2 == 0 ? 1 : 0) == 0)
      {
        if (num2 < Class15.smethod_0(0))
          act = Class15.smethod_0(5);
        if (num2 > Class15.smethod_0(0))
          act = Class15.smethod_0(2);
        if (num1 < Class15.smethod_0(0))
          dir = -1;
        if (num1 > Class15.smethod_0(0))
          dir = Class15.smethod_0(1);
      }
      this.vMovePoints.method_0((object) new GClass108(toX, toY, act, dir));
      if (this.statusMe != Class15.smethod_0(37))
        this.int_15 = this.statusMe;
      this.statusMe = Class15.smethod_0(37);
      this.cp3 = Class15.smethod_0(0);
    }
    else
    {
      this.method_75(this.cx, this.cy, Class15.smethod_0(31));
      this.cx = toX;
      this.cy = toY;
      this.vMovePoints.method_9();
      this.statusMe = Class15.smethod_0(37);
      this.cp3 = Class15.smethod_0(0);
      this.currentMovePoint = (GClass108) null;
      this.cf = Class15.smethod_0(46);
    }
  }

  public static void smethod_6(int cID, int dx, int dy, int HP)
  {
    GClass20 gclass20_1 = (GClass20) GClass116.gclass134_5.method_3(cID);
    if ((gclass20_1.vMovePoints.method_2() == 0 ? 1 : 0) != 0)
      return;
    GClass108 gclass108 = (GClass108) gclass20_1.vMovePoints.method_12();
    int xEnd = gclass108.xEnd + dx;
    int yEnd = gclass108.yEnd + dy;
    GClass20 gclass20_2 = (GClass20) GClass116.gclass134_5.method_3(cID);
    gclass20_2.cHP -= HP;
    if (gclass20_2.cHP < Class15.smethod_0(0))
      gclass20_2.cHP = Class15.smethod_0(0);
    gclass20_2.cHPShow = ((GClass20) GClass116.gclass134_5.method_3(cID)).cHP - HP;
    gclass20_2.statusMe = Class15.smethod_0(37);
    gclass20_2.cp3 = Class15.smethod_0(0);
    gclass20_2.vMovePoints.method_0((object) new GClass108(xEnd, yEnd, Class15.smethod_0(88), gclass20_2.cdir));
  }

  public bool method_97()
  {
    if ((GClass116.smethod_6().magicTree == null ? 1 : 0) != 0)
      return Class15.smethod_0(0) != 0;
    int x = GClass116.smethod_6().magicTree.x;
    int y = GClass116.smethod_6().magicTree.y;
    return this.cx > x - Class15.smethod_0(6) && this.cx < x + Class15.smethod_0(6) && this.cy > y - Class15.smethod_0(6) && this.cy < y + Class15.smethod_0(6) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public void method_98()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.RssOvFwMUexn));
    int[] numArray = (int[]) Class15.smethod_4(byte_0);
    if ((this.itemFocus == null ? 1 : 0) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
    {
      GClass81 gclass81 = (GClass81) GClass116.gclass134_6.method_3(index);
      int num1 = GClass93.smethod_0(GClass20.smethod_1().cx - gclass81.x);
      int num2 = GClass93.smethod_0(GClass20.smethod_1().cy - gclass81.y);
      int num3 = num1 <= num2 ? num2 : num1;
      if (num1 <= Class15.smethod_0(154) && num2 <= Class15.smethod_0(154) && ((this.itemFocus == null ? 1 : 0) != 0 || num3 < numArray[Class15.smethod_0(5)]))
      {
        if ((GClass116.smethod_6().auto == 0 ? 1 : 0) == 0 && (!GClass116.smethod_6().method_16() ? 1 : 0) == 0)
        {
          if ((int) gclass81.template.type == Class15.smethod_0(45))
          {
            this.itemFocus = gclass81;
            numArray[Class15.smethod_0(5)] = num3;
          }
        }
        else
        {
          this.itemFocus = gclass81;
          numArray[Class15.smethod_0(5)] = num3;
        }
      }
    }
  }

  public void method_99()
  {
    if ((GClass20.smethod_1().skillPaint == null ? 0 : 1) == 0 && (GClass20.smethod_1().arr == null ? 0 : 1) == 0 && (GClass20.smethod_1().dart == null ? 1 : 0) != 0)
    {
      if (this.int_16 > Class15.smethod_0(0))
      {
        this.int_16 -= Class15.smethod_0(1);
      }
      else
      {
        if ((!GClass20.bool_13 ? 1 : 0) == 0 && (this.charFocus == null ? 1 : 0) == 0 && (this.charFocus.statusMe == Class15.smethod_0(9) || (!this.charFocus.isInvisiblez ? 1 : 0) == 0))
          this.charFocus = (GClass20) null;
        if ((GClass62.int_8 % Class15.smethod_0(7) == 0 ? 1 : 0) != 0 || (!this.method_115(this.charFocus) ? 1 : 0) == 0)
          return;
        int num1 = Class15.smethod_0(0);
        if ((this.nClass.classId == 0 ? 1 : 0) != 0 || this.nClass.classId == Class15.smethod_0(1) || this.nClass.classId == Class15.smethod_0(5) || this.nClass.classId == Class15.smethod_0(3))
          num1 = Class15.smethod_0(54);
        byte[] byte_0 = new byte[Class15.smethod_0(61)];
        // ISSUE: field reference
        RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.RssOvFwMUexn));
        int[] numArray = (int[]) Class15.smethod_4(byte_0);
        int num2 = GClass116.int_22 - Class15.smethod_0(31);
        int num3 = GClass116.int_22 + GClass62.int_10 + Class15.smethod_0(31);
        int int23 = GClass116.int_23;
        int num4 = GClass116.int_23 + GClass62.int_11 - GClass116.int_18 + Class15.smethod_0(31);
        if ((!GClass20.bool_13 ? 1 : 0) == 0)
        {
          if ((this.mobFocus == null ? 1 : 0) == 0 && this.mobFocus.status != Class15.smethod_0(1) && (this.mobFocus.status == 0 ? 1 : 0) == 0 && num2 <= this.mobFocus.x && this.mobFocus.x <= num3 && int23 <= this.mobFocus.y && this.mobFocus.y <= num4 || (this.npcFocus == null ? 1 : 0) == 0 && num2 <= this.npcFocus.cx && this.npcFocus.cx <= num3 && int23 <= this.npcFocus.cy && this.npcFocus.cy <= num4 || (this.charFocus == null ? 1 : 0) == 0 && num2 <= this.charFocus.cx && this.charFocus.cx <= num3 && int23 <= this.charFocus.cy && this.charFocus.cy <= num4 || (this.itemFocus == null ? 1 : 0) == 0 && num2 <= this.itemFocus.x && this.itemFocus.x <= num3 && int23 <= this.itemFocus.y && this.itemFocus.y <= num4)
            return;
          GClass20.bool_13 = Class15.smethod_0(0) != 0;
        }
        int num5 = GClass20.smethod_1().cx - Class15.smethod_0(25);
        int num6 = GClass20.smethod_1().cx + Class15.smethod_0(25);
        int num7 = GClass20.smethod_1().cy - Class15.smethod_0(6);
        int num8 = GClass20.smethod_1().cy + Class15.smethod_0(6);
        if ((this.npcFocus == null ? 1 : 0) == 0 && this.npcFocus.template.npcTemplateId == Class15.smethod_0(37))
        {
          num5 = GClass20.smethod_1().cx - Class15.smethod_0(51);
          num6 = GClass20.smethod_1().cx + Class15.smethod_0(51);
          num7 = GClass20.smethod_1().cy - Class15.smethod_0(31);
          num8 = GClass20.smethod_1().cy + Class15.smethod_0(31);
        }
        num5 = GClass20.smethod_1().cx - GClass20.smethod_1().method_1() - Class15.smethod_0(31);
        num6 = GClass20.smethod_1().cx + GClass20.smethod_1().method_1() + Class15.smethod_0(31);
        num7 = GClass20.smethod_1().cy - GClass20.smethod_1().method_2() - num1 - Class15.smethod_0(51);
        if (GClass20.smethod_1().cy + GClass20.smethod_1().method_2() + Class15.smethod_0(51) > GClass20.smethod_1().cy + Class15.smethod_0(6))
          num8 = GClass20.smethod_1().cy + Class15.smethod_0(6);
        int index1 = -1;
        for (int index2 = Class15.smethod_0(0); index2 < numArray.Length; index2 += Class15.smethod_0(1))
        {
          if (index1 == -1)
          {
            if (numArray[index2] != -1)
              index1 = index2;
          }
          else if (numArray[index2] < numArray[index1] && numArray[index2] != -1)
            index1 = index2;
        }
        this.method_100(index1);
        if ((!this.me ? 1 : 0) != 0 || (!this.method_101() ? 1 : 0) != 0)
          return;
        if ((this.mobFocus == null ? 1 : 0) == 0 && (!this.mobFocus.isMobMe ? 0 : 1) == 0)
          this.mobFocus = (GClass100) null;
        this.npcFocus = (GClass21) null;
        this.itemFocus = (GClass81) null;
      }
    }
    else
      this.int_16 = Class15.smethod_0(90);
  }

  public void method_100(int index)
  {
    switch (index)
    {
      case 0:
        this.method_105();
        this.charFocus = (GClass20) null;
        this.itemFocus = (GClass81) null;
        break;
      case 1:
        this.mobFocus = (GClass100) null;
        this.charFocus = (GClass20) null;
        this.itemFocus = (GClass81) null;
        break;
      case 2:
        this.mobFocus = (GClass100) null;
        this.method_105();
        this.itemFocus = (GClass81) null;
        break;
      case 3:
        this.mobFocus = (GClass100) null;
        this.method_105();
        this.charFocus = (GClass20) null;
        break;
    }
  }

  public static bool smethod_7(GClass20 c)
  {
    int int22 = GClass116.int_22;
    int num1 = GClass116.int_22 + GClass62.int_10;
    int num2 = GClass116.int_23 + Class15.smethod_0(31);
    int num3 = GClass116.int_23 + GClass116.int_7;
    return c.statusMe != Class15.smethod_0(9) && (!c.isInvisiblez ? 0 : 1) == 0 && int22 <= c.cx && c.cx <= num1 && num2 <= c.cy && c.cy <= num3 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public bool method_101() => (int) this.cTypePk != Class15.smethod_0(2) ? (int) this.cTypePk == Class15.smethod_0(5) : Class15.smethod_0(1) != 0;

  public void method_102(GClass20 r)
  {
    this.cdir = this.cx >= r.cx ? -1 : Class15.smethod_0(1);
    this.gclass20_2 = r;
    this.holder = Class15.smethod_0(1) != 0;
  }

  public void method_103(GClass100 r)
  {
    this.cdir = this.cx >= r.x ? -1 : Class15.smethod_0(1);
    this.gclass100_0 = r;
    this.holder = Class15.smethod_0(1) != 0;
  }

  public void method_104()
  {
    GClass151.smethod_7(Class13.smethod_0(142366) + this.focus.method_2().ToString());
    if (((GClass20.smethod_1().skillPaint == null ? 0 : 1) != 0 || (GClass20.smethod_1().arr == null ? 0 : 1) != 0 || (GClass20.smethod_1().dart == null ? 0 : 1) != 0 || (GClass20.smethod_1().method_71() == null ? 1 : 0) == 0) && (this.focus.method_2() == 0 ? 0 : 1) == 0)
      return;
    this.focus.method_9();
    int index1 = Class15.smethod_0(0);
    int num1 = GClass116.int_22 + Class15.smethod_0(31);
    int num2 = GClass116.int_22 + GClass62.int_10 - Class15.smethod_0(31);
    int num3 = GClass116.int_23 + Class15.smethod_0(31);
    int num4 = GClass116.int_23 + GClass116.int_7;
    for (int index2 = Class15.smethod_0(0); index2 < GClass116.gclass134_5.method_2(); index2 += Class15.smethod_0(1))
    {
      GClass20 o = (GClass20) GClass116.gclass134_5.method_3(index2);
      if (o.statusMe != Class15.smethod_0(9) && (!o.isInvisiblez ? 0 : 1) == 0 && num1 <= o.cx && o.cx <= num2 && num3 <= o.cy && o.cy <= num4 && o.charID != Class15.smethod_0(244) && (GClass185.int_37 != Class15.smethod_0(75) || GClass185.int_37 == Class15.smethod_0(75) && GClass20.smethod_1().cy > Class15.smethod_0(245)))
      {
        this.focus.method_0((object) o);
        if ((this.charFocus == null ? 1 : 0) == 0 && (!o.Equals((object) this.charFocus) ? 1 : 0) == 0)
          index1 = this.focus.method_2();
      }
    }
    if ((!this.me ? 1 : 0) == 0 && (!this.method_101() ? 1 : 0) == 0)
    {
      GClass151.smethod_7(Class13.smethod_0(142346));
      for (int index3 = Class15.smethod_0(0); index3 < GClass116.gclass134_9.method_2(); index3 += Class15.smethod_0(1))
      {
        GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index3);
        if ((!GClass116.smethod_6().method_31(gclass100) ? 0 : 1) == 0)
        {
          GClass151.smethod_7(Class13.smethod_0(142447));
          this.mobFocus = (GClass100) null;
        }
        else
        {
          GClass151.smethod_7(Class13.smethod_0(142420));
          this.focus.method_0((object) gclass100);
          if ((this.mobFocus == null ? 1 : 0) == 0)
            index1 = this.focus.method_2();
        }
      }
      this.npcFocus = (GClass21) null;
      this.itemFocus = (GClass81) null;
      if (this.focus.method_2() > Class15.smethod_0(0))
      {
        if (index1 >= this.focus.method_2())
          index1 = Class15.smethod_0(0);
        this.method_117(this.focus.method_3(index1));
      }
      else
      {
        this.mobFocus = (GClass100) null;
        this.method_105();
        this.charFocus = (GClass20) null;
        this.itemFocus = (GClass81) null;
        GClass20.bool_13 = Class15.smethod_0(0) != 0;
      }
    }
    else
    {
      for (int index4 = Class15.smethod_0(0); index4 < GClass116.gclass134_6.method_2(); index4 += Class15.smethod_0(1))
      {
        GClass81 o = (GClass81) GClass116.gclass134_6.method_3(index4);
        if (num1 <= o.x && o.x <= num2 && num3 <= o.y && o.y <= num4)
        {
          this.focus.method_0((object) o);
          if ((this.itemFocus == null ? 1 : 0) == 0 && (!o.Equals((object) this.itemFocus) ? 1 : 0) == 0)
            index1 = this.focus.method_2();
        }
      }
      for (int index5 = Class15.smethod_0(0); index5 < GClass116.gclass134_9.method_2(); index5 += Class15.smethod_0(1))
      {
        GClass100 o = (GClass100) GClass116.gclass134_9.method_3(index5);
        if (o.status != Class15.smethod_0(1) && (o.status == 0 ? 1 : 0) == 0 && num1 <= o.x && o.x <= num2 && num3 <= o.y && o.y <= num4)
        {
          this.focus.method_0((object) o);
          if ((this.mobFocus == null ? 1 : 0) == 0 && (!o.Equals((object) this.mobFocus) ? 1 : 0) == 0)
            index1 = this.focus.method_2();
        }
      }
      for (int index6 = Class15.smethod_0(0); index6 < GClass116.gclass134_10.method_2(); index6 += Class15.smethod_0(1))
      {
        GClass21 o = (GClass21) GClass116.gclass134_10.method_3(index6);
        if (o.statusMe != Class15.smethod_0(9) && num1 <= o.cx && o.cx <= num2 && num3 <= o.cy && o.cy <= num4)
        {
          this.focus.method_0((object) o);
          if ((this.npcFocus == null ? 1 : 0) == 0 && (!o.Equals((object) this.npcFocus) ? 1 : 0) == 0)
            index1 = this.focus.method_2();
        }
      }
      if (this.focus.method_2() > Class15.smethod_0(0))
      {
        if (index1 >= this.focus.method_2())
          index1 = Class15.smethod_0(0);
        this.method_117(this.focus.method_3(index1));
      }
      else
      {
        this.mobFocus = (GClass100) null;
        this.method_105();
        this.charFocus = (GClass20) null;
        this.itemFocus = (GClass81) null;
        GClass20.bool_13 = Class15.smethod_0(0) != 0;
      }
    }
  }

  public void method_105()
  {
    if ((!this.me ? 1 : 0) != 0 || (this.npcFocus == null ? 1 : 0) != 0)
      return;
    if ((!GClass62.gclass95_0.showMenu ? 0 : 1) == 0)
      GClass20.gclass43_0 = (GClass43) null;
    this.npcFocus = (GClass21) null;
  }

  public void method_106()
  {
    if ((!GClass62.bool_1 ? 0 : 1) != 0)
      return;
    if ((!GClass185.smethod_27(this.cx, this.cy + Class15.smethod_0(1), Class15.smethod_0(246)) ? 1 : 0) == 0)
    {
      GClass185.smethod_28(this.cx, this.cy + Class15.smethod_0(1), Class15.smethod_0(247));
      GClass185.smethod_28(this.cx, this.cy - Class15.smethod_0(7), Class15.smethod_0(247));
    }
    if ((!GClass185.smethod_27(this.cx - (int) GClass185.sbyte_0, this.cy + Class15.smethod_0(1), Class15.smethod_0(247)) ? 1 : 0) == 0)
    {
      GClass185.smethod_30(this.cx - (int) GClass185.sbyte_0, this.cy + Class15.smethod_0(1), Class15.smethod_0(247));
      GClass185.smethod_30(this.cx - (int) GClass185.sbyte_0, this.cy - Class15.smethod_0(7), Class15.smethod_0(247));
    }
    if ((!GClass185.smethod_27(this.cx + (int) GClass185.sbyte_0, this.cy + Class15.smethod_0(1), Class15.smethod_0(247)) ? 1 : 0) != 0)
      return;
    GClass185.smethod_30(this.cx + (int) GClass185.sbyte_0, this.cy + Class15.smethod_0(1), Class15.smethod_0(247));
    GClass185.smethod_30(this.cx + (int) GClass185.sbyte_0, this.cy - Class15.smethod_0(7), Class15.smethod_0(247));
  }

  public static void smethod_8(int[] data)
  {
    int num1 = Class15.smethod_0(3);
    for (int index1 = Class15.smethod_0(0); index1 < num1 - Class15.smethod_0(1); index1 += Class15.smethod_0(1))
    {
      for (int index2 = index1 + Class15.smethod_0(1); index2 < num1; index2 += Class15.smethod_0(1))
      {
        if (data[index1] < data[index2])
        {
          int num2 = data[index2];
          data[index2] = data[index1];
          data[index1] = num2;
        }
      }
    }
  }

  public static bool smethod_9(int cmX, int cmWx, int x, int cmy, int cmyH, int y) => x <= cmWx && x >= cmX && y <= cmyH && y >= cmy ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public void method_107(GClass80 item, int maxKick)
  {
    int num = Class15.smethod_0(0);
    if ((item == null ? 1 : 0) != 0 || (item.options == null ? 0 : 1) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < item.options.method_2(); index += Class15.smethod_0(1))
    {
      GClass83 gclass83 = (GClass83) item.options.method_3(index);
      gclass83.active = (sbyte) Class15.smethod_0(0);
      if (gclass83.optionTemplate.type == Class15.smethod_0(7))
      {
        if (num < maxKick)
        {
          gclass83.active = (sbyte) Class15.smethod_0(1);
          num += Class15.smethod_0(1);
        }
      }
      else if (gclass83.optionTemplate.type == Class15.smethod_0(5) && item.upgrade >= Class15.smethod_0(2))
        gclass83.active = (sbyte) Class15.smethod_0(1);
      else if (gclass83.optionTemplate.type == Class15.smethod_0(2) && item.upgrade >= Class15.smethod_0(88))
        gclass83.active = (sbyte) Class15.smethod_0(1);
      else if (gclass83.optionTemplate.type == Class15.smethod_0(3) && item.upgrade >= Class15.smethod_0(66))
        gclass83.active = (sbyte) Class15.smethod_0(1);
      else if (gclass83.optionTemplate.type == Class15.smethod_0(37) && item.upgrade >= Class15.smethod_0(49))
        gclass83.active = (sbyte) Class15.smethod_0(1);
      else if (gclass83.optionTemplate.type == Class15.smethod_0(38) && item.upgrade >= Class15.smethod_0(10))
        gclass83.active = (sbyte) Class15.smethod_0(1);
    }
  }

  public void method_108(int HPShow, int MPShow, bool isCrit, bool isMob)
  {
    this.isCrit = isCrit;
    this.isMob = isMob;
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(143304);
    strArray[Class15.smethod_0(1)] = this.cHP.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(143027);
    strArray[Class15.smethod_0(5)] = HPShow.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(143071);
    strArray[Class15.smethod_0(3)] = this.cHPFull.ToString();
    GClass151.smethod_7(string.Concat(strArray));
    this.cHP -= HPShow;
    this.cMP -= MPShow;
    GClass116.smethod_6().isInjureHp = Class15.smethod_0(1) != 0;
    GClass116.smethod_6().twHp = Class15.smethod_0(0);
    GClass116.smethod_6().isInjureMp = Class15.smethod_0(1) != 0;
    GClass116.smethod_6().twMp = Class15.smethod_0(0);
    if (this.cHP < Class15.smethod_0(0))
      this.cHP = Class15.smethod_0(0);
    if (this.cMP < Class15.smethod_0(0))
      this.cMP = Class15.smethod_0(0);
    if ((!isMob ? 0 : 1) != 0 || (!isMob ? 0 : 1) == 0 && (int) this.cTypePk != Class15.smethod_0(2) && this.damMP != Class15.smethod_0(143))
    {
      if (HPShow <= Class15.smethod_0(0))
      {
        if ((!this.me ? 1 : 0) == 0)
          GClass116.smethod_17(GClass109.string_233, this.cx, this.cy - this.ch, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_10);
        else
          GClass116.smethod_17(GClass109.string_233, this.cx, this.cy - this.ch, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_7);
      }
      else
        GClass116.smethod_17(Class13.smethod_0(143060) + HPShow.ToString(), this.cx, this.cy - this.ch, Class15.smethod_0(0), Class15.smethod_0(132), (!isCrit ? 0 : 1) != 0 ? GClass97.int_6 : GClass97.int_3);
    }
    if (HPShow > Class15.smethod_0(0))
      this.isInjure = (sbyte) Class15.smethod_0(37);
    GClass47.smethod_3(Class15.smethod_0(25), this, Class15.smethod_0(1));
    if ((!this.isDie ? 1 : 0) != 0)
      return;
    this.isDie = Class15.smethod_0(0) != 0;
    GClass20.bool_3 = Class15.smethod_0(0) != 0;
    this.method_110((short) this.xSd, (short) this.ySd);
  }

  public void method_109()
  {
    GClass116.smethod_6().isInjureHp = Class15.smethod_0(1) != 0;
    GClass116.smethod_6().twHp = Class15.smethod_0(0);
    GClass116.smethod_6().isInjureMp = Class15.smethod_0(1) != 0;
    GClass116.smethod_6().twMp = Class15.smethod_0(0);
    this.isInjure = (sbyte) Class15.smethod_0(37);
    GClass47.smethod_3(Class15.smethod_0(88), this, Class15.smethod_0(1));
    this.isInjureHp = Class15.smethod_0(1) != 0;
    this.int_7 = Class15.smethod_0(0);
  }

  public void method_110(short toX, short toY)
  {
    this.isMonkey = (sbyte) Class15.smethod_0(0);
    this.isWaitMonkey = Class15.smethod_0(0) != 0;
    if ((!this.me ? 1 : 0) == 0 && (!this.isDie ? 1 : 0) == 0)
      return;
    if ((!this.me ? 1 : 0) == 0)
    {
      this.isLockMove = Class15.smethod_0(1) != 0;
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
        ((GClass20) GClass116.gclass134_5.method_3(index)).killCharId = Class15.smethod_0(180);
      if ((GClass62.gclass141_0 == null ? 1 : 0) == 0 && (GClass62.gclass141_0.cp == null ? 1 : 0) == 0)
        GClass62.gclass141_0.cp = (GClass43) null;
      if ((GClass62.gclass141_1 == null ? 1 : 0) == 0 && (GClass62.gclass141_1.cp == null ? 1 : 0) == 0)
        GClass62.gclass141_1.cp = (GClass43) null;
    }
    this.statusMe = Class15.smethod_0(3);
    this.cp2 = (int) toX;
    this.cp3 = (int) toY;
    this.cp1 = Class15.smethod_0(0);
    this.cHP = Class15.smethod_0(0);
    this.testCharId = Class15.smethod_0(180);
    this.killCharId = Class15.smethod_0(180);
    if ((!this.me ? 1 : 0) == 0 && (this.myskill == null ? 1 : 0) == 0 && (int) this.myskill.template.id != Class15.smethod_0(49))
      this.method_68();
    this.cTypePk = (sbyte) Class15.smethod_0(0);
  }

  public void method_111(short toX, short toY)
  {
    this.wdx = toX;
    this.wdy = toY;
  }

  public void method_112()
  {
    this.cHP = this.cHPFull;
    this.cMP = this.cMPFull;
    this.statusMe = Class15.smethod_0(1);
    this.cp1 = this.cp2 = this.cp3 = Class15.smethod_0(0);
    GClass47.smethod_3(Class15.smethod_0(56), this, Class15.smethod_0(7));
    GClass116.smethod_6().center = (GClass31) null;
    GClass116.bool_16 = Class15.smethod_0(1) != 0;
  }

  public bool method_113()
  {
    if ((this.arrItemBag == null ? 0 : 1) == 0)
      return Class15.smethod_0(0) != 0;
    for (int index = Class15.smethod_0(0); index < this.arrItemBag.Length; index += Class15.smethod_0(1))
    {
      if ((this.arrItemBag[index] == null ? 1 : 0) == 0 && (int) this.arrItemBag[index].template.type == Class15.smethod_0(37))
      {
        GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) -1, this.arrItemBag[index].template.id);
        return Class15.smethod_0(1) != 0;
      }
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_114() => GClass185.int_37 != Class15.smethod_0(1) && GClass185.int_37 != Class15.smethod_0(33) && GClass185.int_37 != Class15.smethod_0(107) && GClass185.int_37 != Class15.smethod_0(31) && GClass185.int_37 != Class15.smethod_0(186) && GClass185.int_37 != Class15.smethod_0(28) && GClass185.int_37 != Class15.smethod_0(120) && GClass185.int_37 != Class15.smethod_0(34) && GClass185.int_37 != Class15.smethod_0(248) && GClass185.int_37 != Class15.smethod_0(154) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public bool method_115(GClass20 cAtt)
  {
    if ((cAtt == null ? 1 : 0) != 0 || (GClass20.smethod_1().myskill == null ? 1 : 0) != 0 || GClass20.smethod_1().myskill.template.type == Class15.smethod_0(7) || GClass20.smethod_1().myskill.template.type == Class15.smethod_0(2) && cAtt.statusMe != Class15.smethod_0(49) && cAtt.statusMe != Class15.smethod_0(3))
      return Class15.smethod_0(0) != 0;
    return ((int) cAtt.cTypePk == Class15.smethod_0(5) && (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(5) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(3) || (int) cAtt.cTypePk == Class15.smethod_0(3) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(1) && (int) cAtt.cTypePk == Class15.smethod_0(1) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(2) && (int) cAtt.cTypePk == Class15.smethod_0(2) || GClass20.smethod_1().testCharId >= Class15.smethod_0(0) && GClass20.smethod_1().testCharId == cAtt.charID || GClass20.smethod_1().killCharId >= Class15.smethod_0(0) && GClass20.smethod_1().killCharId == cAtt.charID && (!this.method_114() ? 1 : 0) != 0 || cAtt.killCharId >= Class15.smethod_0(0) && cAtt.killCharId == GClass20.smethod_1().charID && (!this.method_114() ? 1 : 0) != 0 || (int) GClass20.smethod_1().cFlag == Class15.smethod_0(88) && (cAtt.cFlag == (sbyte) 0 ? 0 : 1) != 0 || (GClass20.smethod_1().cFlag == (sbyte) 0 ? 1 : 0) == 0 && (int) cAtt.cFlag == Class15.smethod_0(88) || (int) GClass20.smethod_1().cFlag != (int) cAtt.cFlag && (GClass20.smethod_1().cFlag == (sbyte) 0 ? 1 : 0) == 0 && (cAtt.cFlag == (sbyte) 0 ? 1 : 0) == 0) && cAtt.statusMe != Class15.smethod_0(49) ? (cAtt.statusMe == Class15.smethod_0(3) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;
  }

  public void method_116()
  {
    GClass20.smethod_1().taskMaint = (GClass179) null;
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      if ((GClass20.smethod_1().arrItemBag[index] == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().arrItemBag[index].template.type == Class15.smethod_0(88))
        GClass20.smethod_1().arrItemBag[index] = (GClass80) null;
    }
    GClass21.smethod_10();
  }

  public int imethod_0() => this.cx;

  public int imethod_1() => this.cy;

  public int imethod_3() => Class15.smethod_0(120);

  public int imethod_2() => Class15.smethod_0(40);

  public void method_117(object objectz)
  {
    if ((!(objectz is GClass100) ? 1 : 0) == 0)
    {
      this.mobFocus = (GClass100) objectz;
      this.method_105();
      this.charFocus = (GClass20) null;
      this.itemFocus = (GClass81) null;
    }
    else if ((!(objectz is GClass21) ? 1 : 0) == 0)
    {
      GClass20.smethod_1().mobFocus = (GClass100) null;
      GClass20.smethod_1().method_105();
      GClass20.smethod_1().npcFocus = (GClass21) objectz;
      GClass20.smethod_1().charFocus = (GClass20) null;
      GClass20.smethod_1().itemFocus = (GClass81) null;
    }
    else if ((!(objectz is GClass20) ? 1 : 0) == 0)
    {
      GClass20.smethod_1().mobFocus = (GClass100) null;
      GClass20.smethod_1().method_105();
      GClass20.smethod_1().charFocus = (GClass20) objectz;
      GClass20.smethod_1().itemFocus = (GClass81) null;
    }
    else if ((!(objectz is GClass81) ? 1 : 0) == 0)
    {
      GClass20.smethod_1().mobFocus = (GClass100) null;
      GClass20.smethod_1().method_105();
      GClass20.smethod_1().charFocus = (GClass20) null;
      GClass20.smethod_1().itemFocus = (GClass81) objectz;
    }
    GClass20.bool_13 = Class15.smethod_0(1) != 0;
  }

  public void imethod_4()
  {
  }

  public void method_118()
  {
  }

  public bool imethod_5() => Class15.smethod_0(0) != 0;

  public bool method_119()
  {
    if ((this.mobFocus == null ? 0 : 1) != 0)
      return Class15.smethod_0(1) != 0;
    return (this.charFocus == null ? 1 : 0) == 0 ? this.method_115(this.charFocus) : Class15.smethod_0(0) != 0;
  }

  public void method_120(int type)
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
      return;
    switch (type - Class15.smethod_0(1))
    {
      case 0:
        if (this.clevel < Class15.smethod_0(45))
          break;
        GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.cx - Class15.smethod_0(3), this.cy + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1));
        break;
      case 1:
        if ((!this.me ? 1 : 0) == 0 && (int) this.isMonkey == Class15.smethod_0(1) || (!this.isNhapThe ? 1 : 0) != 0 || (GClass62.int_8 % Class15.smethod_0(3) == 0 ? 0 : 1) != 0)
          break;
        GClass40.smethod_0(new GClass41(Class15.smethod_0(28), this.cx - Class15.smethod_0(3), this.cy + Class15.smethod_0(95), Class15.smethod_0(7), Class15.smethod_0(1), -1));
        break;
      case 2:
        if (this.clevel < Class15.smethod_0(45) || this.ySd - this.cy > Class15.smethod_0(3))
          break;
        GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.cx - Class15.smethod_0(3), this.ySd + Class15.smethod_0(51), Class15.smethod_0(7), Class15.smethod_0(1), -1));
        break;
    }
  }

  public bool method_121(sbyte getFlag)
  {
    bool flag = Class15.smethod_0(1) != 0;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_11.method_2(); index += Class15.smethod_0(1))
    {
      GClass144 gclass144 = (GClass144) GClass116.gclass134_11.method_3(index);
      if ((gclass144 == null ? 1 : 0) == 0)
      {
        if ((int) gclass144.cflag == (int) getFlag)
          return Class15.smethod_0(1) != 0;
        flag = Class15.smethod_0(0) != 0;
      }
    }
    return flag;
  }

  private void method_122(GClass98 gclass98_0)
  {
    if (this.cdir == Class15.smethod_0(1))
    {
      if ((this.cFlag == (sbyte) 0 ? 1 : 0) != 0 || this.cFlag == (sbyte) -1)
        return;
      GClass169.smethod_6(gclass98_0, this.flagImage, this.cx - Class15.smethod_0(31), this.cy - this.ch - ((!this.me ? 1 : 0) != 0 ? Class15.smethod_0(6) : Class15.smethod_0(6)) + (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31) ? GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7) : Class15.smethod_0(0)), Class15.smethod_0(7), Class15.smethod_0(0));
    }
    else
    {
      if ((this.cFlag == (sbyte) 0 ? 1 : 0) != 0 || this.cFlag == (sbyte) -1)
        return;
      GClass169.smethod_6(gclass98_0, this.flagImage, this.cx, this.cy - this.ch - ((!this.me ? 1 : 0) != 0 ? Class15.smethod_0(6) : Class15.smethod_0(6)) + (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31) ? GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7) : Class15.smethod_0(0)), Class15.smethod_0(0), Class15.smethod_0(0));
    }
  }

  public void method_123()
  {
    if ((!this.holder ? 1 : 0) == 0)
    {
      this.holder = Class15.smethod_0(0) != 0;
      this.gclass20_2 = (GClass20) null;
      this.gclass100_0 = (GClass100) null;
    }
    else
    {
      this.holdEffID = Class15.smethod_0(0);
      this.gclass20_2 = (GClass20) null;
      this.gclass100_0 = (GClass100) null;
    }
  }

  public void method_124()
  {
    this.protectEff = Class15.smethod_0(0) != 0;
    this.gclass41_0 = (GClass41) null;
  }

  public void method_125() => this.blindEff = Class15.smethod_0(0) != 0;

  public void method_126()
  {
    if ((this.holdEffID == 0 ? 1 : 0) == 0)
      this.holdEffID = Class15.smethod_0(0);
    if ((!this.holder ? 1 : 0) == 0)
      this.holder = Class15.smethod_0(0) != 0;
    if ((!this.protectEff ? 1 : 0) == 0)
      this.protectEff = Class15.smethod_0(0) != 0;
    this.gclass41_0 = (GClass41) null;
    this.gclass20_2 = (GClass20) null;
    this.gclass100_0 = (GClass100) null;
    this.blindEff = Class15.smethod_0(0) != 0;
    this.sleepEff = Class15.smethod_0(0) != 0;
  }

  public void method_127(short xPos, short yPos, sbyte typePos)
  {
    this.bool_15 = Class15.smethod_0(1) != 0;
    this.short_3 = xPos;
    this.short_4 = yPos;
    this.sbyte_21 = typePos;
    this.int_18 = Class15.smethod_0(0);
    if ((!this.me ? 1 : 0) != 0)
      return;
    if ((GClass62.gclass141_0 == null ? 1 : 0) == 0)
      GClass62.gclass141_0.method_141();
    if ((GClass62.gclass141_1 == null ? 1 : 0) != 0)
      return;
    GClass62.gclass141_1.method_141();
  }

  public void method_128() => this.huytSao = Class15.smethod_0(0) != 0;

  public void method_129()
  {
    this.isFusion = Class15.smethod_0(0) != 0;
    GClass20.bool_3 = Class15.smethod_0(0) != 0;
    this.tFusion = Class15.smethod_0(0);
  }

  public void method_130(sbyte fusion)
  {
    this.tFusion = Class15.smethod_0(0);
    if ((int) fusion == Class15.smethod_0(2) || (int) fusion == Class15.smethod_0(3))
    {
      if ((!this.me ? 1 : 0) == 0)
        GClass156.smethod_0().method_135(fusion);
      GClass40.smethod_0(new GClass41(Class15.smethod_0(117), this.cx, this.cy + Class15.smethod_0(66), Class15.smethod_0(7), Class15.smethod_0(1), -1));
    }
    if ((int) fusion == Class15.smethod_0(37))
      GClass40.smethod_0(new GClass41(Class15.smethod_0(34), this.cx, this.cy + Class15.smethod_0(66), Class15.smethod_0(7), Class15.smethod_0(1), -1));
    if ((!this.me ? 1 : 0) == 0)
    {
      GClass62.gclass141_0.method_140();
      GClass20.bool_3 = Class15.smethod_0(1) != 0;
    }
    this.isFusion = Class15.smethod_0(1) != 0;
    if ((int) fusion == Class15.smethod_0(1))
      this.isNhapThe = Class15.smethod_0(0) != 0;
    else
      this.isNhapThe = Class15.smethod_0(1) != 0;
  }

  public void method_131() => this.sleepEff = Class15.smethod_0(0) != 0;

  public void method_132()
  {
    this.headTemp = this.head;
    this.bodyTemp = this.body;
    this.legTemp = this.leg;
    this.bagTemp = this.bag;
  }

  public void method_133(int head, int body, int leg, int bag)
  {
    if (head != -1)
      this.head = head;
    if (body != -1)
      this.body = body;
    if (leg != -1)
      this.leg = leg;
    if (bag == -1)
      return;
    this.bag = bag;
  }

  public void method_134()
  {
    if (this.headTemp != -1)
    {
      this.head = this.headTemp;
      this.headTemp = -1;
    }
    if (this.bodyTemp != -1)
    {
      this.body = this.bodyTemp;
      this.bodyTemp = -1;
    }
    if (this.legTemp != -1)
    {
      this.leg = this.legTemp;
      this.legTemp = -1;
    }
    if (this.bagTemp == -1)
      return;
    this.bag = this.bagTemp;
    this.bagTemp = -1;
  }

  public GClass41 method_135(int id)
  {
    for (int index = Class15.smethod_0(0); index < this.vEffChar.method_2(); index += Class15.smethod_0(1))
    {
      GClass41 gclass41 = (GClass41) this.vEffChar.method_3(index);
      if (gclass41.effId == id)
        return gclass41;
    }
    return (GClass41) null;
  }

  public void method_136(GClass41 e)
  {
    this.method_137(Class15.smethod_0(0), e.effId);
    this.vEffChar.method_0((object) e);
  }

  public void method_137(int type, int id)
  {
    if (type == -1)
    {
      this.vEffChar.method_9();
    }
    else
    {
      if ((this.method_135(id) == null ? 1 : 0) != 0)
        return;
      this.vEffChar.method_8((object) this.method_135(id));
    }
  }

  public void method_138(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < this.vEffChar.method_2(); index += Class15.smethod_0(1))
    {
      GClass41 gclass41 = (GClass41) this.vEffChar.method_3(index);
      if ((gclass41.layer == 0 ? 0 : 1) == 0)
      {
        bool flag = Class15.smethod_0(1) != 0;
        if ((gclass41.isStand == 0 ? 0 : 1) == 0)
          flag = this.statusMe == Class15.smethod_0(1) || this.statusMe == Class15.smethod_0(37) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
        if ((!flag ? 1 : 0) == 0)
          gclass41.method_3(g);
      }
    }
  }

  public void method_139(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < this.vEffChar.method_2(); index += Class15.smethod_0(1))
    {
      GClass41 gclass41 = (GClass41) this.vEffChar.method_3(index);
      if (gclass41.layer == Class15.smethod_0(1))
      {
        bool flag = Class15.smethod_0(1) != 0;
        if ((gclass41.isStand == 0 ? 0 : 1) == 0)
          flag = this.statusMe == Class15.smethod_0(1) || this.statusMe == Class15.smethod_0(37) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
        if ((!flag ? 1 : 0) == 0)
          gclass41.method_3(g);
      }
    }
  }

  public void method_140()
  {
    for (int index = Class15.smethod_0(0); index < this.vEffChar.method_2(); index += Class15.smethod_0(1))
      ((GClass41) this.vEffChar.method_3(index)).method_4();
  }

  public int method_141() => this.luong + this.luongKhoa;

  public void method_142()
  {
    if (this.head != Class15.smethod_0(249))
      return;
    if (GClass62.long_0 - this.long_1 > (long) Class15.smethod_0(0))
    {
      this.int_19 += Class15.smethod_0(1);
      if (this.int_19 <= this.int_22.Length - Class15.smethod_0(1))
        return;
      this.int_19 = Class15.smethod_0(0);
      this.long_1 = GClass62.long_0 + (long) GClass151.smethod_18(Class15.smethod_0(20), Class15.smethod_0(123));
      this.int_22 = this.int_21;
      if ((GClass151.smethod_19(Class15.smethod_0(7)) == 0 ? 0 : 1) != 0)
        return;
      this.int_22 = this.int_20;
    }
    else
      this.int_19 = Class15.smethod_0(0);
  }

  private void method_143(GClass98 gclass98_0, int int_26, int int_27, int int_28, int int_29)
  {
    if (this.head != Class15.smethod_0(249) || this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37))
      return;
    if ((GClass20.gclass60_0 == null ? 1 : 0) == 0 && (GClass20.gclass60_0.imgFrame == null ? 0 : 1) != 0)
    {
      if (this.int_22[this.int_19] == -1)
        return;
      int num1 = Class15.smethod_0(88);
      int num2 = Class15.smethod_0(9);
      if (int_28 == Class15.smethod_0(7))
        num1 = Class15.smethod_0(193);
      GClass20.gclass60_0.method_0(this.int_22[this.int_19], int_26 + num1, int_27 + num2, int_28, int_29, gclass98_0);
    }
    else
      GClass20.gclass60_0 = new GClass60(GClass126.smethod_35(Class13.smethod_0(135293)), Class15.smethod_0(49), Class15.smethod_0(31));
  }

  public bool method_144(int idHead)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.int_23.Length; index += Class15.smethod_0(1))
    {
      if (GClass20.int_23[index][Class15.smethod_0(0)] == idHead)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  private void method_145()
  {
    if ((!this.method_144(this.head) ? 1 : 0) == 0)
    {
      this.int_24 += Class15.smethod_0(1);
      if (this.int_24 <= Class15.smethod_0(181))
        return;
      this.int_24 = Class15.smethod_0(0);
    }
    else
      this.int_24 = Class15.smethod_0(0);
  }

  private int method_146(int int_26)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.int_23.Length; index += Class15.smethod_0(1))
    {
      if (GClass20.int_23[index][Class15.smethod_0(0)] == int_26)
        return GClass20.int_23[index][this.int_24 / Class15.smethod_0(2) % GClass20.int_23[index].Length];
    }
    return int_26;
  }

  public void method_147(GClass98 g)
  {
    if ((!this.me ? 1 : 0) == 0 && (!GClass20.bool_18 ? 0 : 1) != 0 || this.idAuraEff <= (short) -1 || this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37) || (!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(0))
      return;
    GClass60 gclass60 = GClass126.smethod_34(this.string_2 + this.idAuraEff.ToString() + Class13.smethod_0(135263));
    if ((gclass60 == null ? 1 : 0) != 0)
      return;
    gclass60.method_0(GClass62.int_8 / Class15.smethod_0(2) % gclass60.nFrame, this.cx, this.cy, this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
  }

  public void method_148(GClass98 g)
  {
    if ((!this.me ? 1 : 0) == 0 && (!GClass20.bool_18 ? 1 : 0) != 0 || this.idAuraEff <= (short) -1)
      return;
    if (this.statusMe != Class15.smethod_0(1) && this.statusMe != Class15.smethod_0(37))
    {
      this.long_0 = GClass126.smethod_18() + (long) Class15.smethod_0(225);
      this.bool_10 = Class15.smethod_0(1) != 0;
      this.bool_11 = Class15.smethod_0(1) != 0;
    }
    else
    {
      if ((!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || (!GClass62.bool_1 ? 0 : 1) != 0)
        return;
      bool flag = Class15.smethod_0(0) != 0;
      if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(223) && (!this.bool_10 ? 1 : 0) == 0)
      {
        flag = Class15.smethod_0(1) != 0;
        this.bool_10 = Class15.smethod_0(0) != 0;
      }
      if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(178) && (!this.bool_11 ? 1 : 0) == 0)
      {
        flag = Class15.smethod_0(1) != 0;
        this.bool_11 = Class15.smethod_0(0) != 0;
      }
      if ((!flag ? 1 : 0) == 0)
      {
        GClass62.smethod_1().method_23(-1, this.cx - Class15.smethod_0(193), this.cy);
        GClass62.smethod_1().method_23(Class15.smethod_0(1), this.cx - Class15.smethod_0(88), this.cy);
        this.method_120(Class15.smethod_0(1));
      }
      if (GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(0))
        return;
      GClass60 gclass60 = GClass126.smethod_34(this.string_2 + this.idAuraEff.ToString() + Class13.smethod_0(135419));
      if ((gclass60 == null ? 1 : 0) != 0)
        return;
      gclass60.method_0(GClass62.int_8 / Class15.smethod_0(2) % gclass60.nFrame, this.cx, this.cy + Class15.smethod_0(7), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
    }
  }

  public void method_149(GClass98 g)
  {
    if (this.idEff_Set_Item == (short) -1)
      return;
    if ((this.gclass60_1 == null ? 1 : 0) == 0)
      this.gclass60_1.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_1.nFrame, this.cx, this.cy + Class15.smethod_0(5), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
    else
      this.gclass60_1 = GClass126.smethod_34(this.string_3 + this.idEff_Set_Item.ToString() + Class13.smethod_0(135988));
  }

  public void method_150(GClass98 g)
  {
    if (this.idEff_Set_Item == (short) -1)
      return;
    if ((this.gclass60_2 == null ? 1 : 0) == 0)
      this.gclass60_2.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_2.nFrame, this.cx, this.cy + Class15.smethod_0(88), this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
    else
      this.gclass60_2 = GClass126.smethod_34(this.string_3 + this.idEff_Set_Item.ToString() + Class13.smethod_0(135975));
  }

  public void method_151(GClass98 g, int cf, int yh)
  {
    try
    {
      if (this.idHat == (short) -1)
        return;
      if ((!this.method_153(cf) ? 1 : 0) == 0)
      {
        if ((this.gclass60_5 == null ? 1 : 0) == 0)
          this.gclass60_5.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_5.nFrame, this.cx + GClass20.int_25[cf][Class15.smethod_0(0)] * (this.cdir == Class15.smethod_0(1) ? Class15.smethod_0(1) : -1), yh + GClass20.int_25[cf][Class15.smethod_0(1)], this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
        else
          this.gclass60_5 = GClass126.smethod_34(this.string_4 + this.string_6 + this.idHat.ToString());
      }
      else if ((this.gclass60_3 == null ? 1 : 0) == 0)
        this.gclass60_3.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_3.nFrame, this.cx + GClass20.int_25[cf][Class15.smethod_0(0)] * (this.cdir == Class15.smethod_0(1) ? Class15.smethod_0(1) : -1), yh + GClass20.int_25[cf][Class15.smethod_0(1)], this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
      else
        this.gclass60_3 = GClass126.smethod_34(this.string_4 + this.idHat.ToString());
    }
    catch (Exception ex)
    {
    }
  }

  public void method_152(GClass98 g, int cf, int yh)
  {
    try
    {
      if (this.idHat == (short) -1)
        return;
      if ((!this.method_153(cf) ? 1 : 0) == 0)
      {
        if ((this.gclass60_6 == null ? 1 : 0) == 0)
          this.gclass60_6.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_6.nFrame, this.cx + GClass20.int_25[cf][Class15.smethod_0(0)] * (this.cdir == Class15.smethod_0(1) ? Class15.smethod_0(1) : -1), yh + GClass20.int_25[cf][Class15.smethod_0(1)], this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
        else
          this.gclass60_6 = GClass126.smethod_34(this.string_5 + this.string_6 + this.idHat.ToString());
      }
      else if ((this.gclass60_4 == null ? 1 : 0) == 0)
        this.gclass60_4.method_0(GClass62.int_8 / Class15.smethod_0(2) % this.gclass60_4.nFrame, this.cx + GClass20.int_25[cf][Class15.smethod_0(0)] * (this.cdir == Class15.smethod_0(1) ? Class15.smethod_0(1) : -1), yh + GClass20.int_25[cf][Class15.smethod_0(1)], this.cdir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass98.int_5 | GClass98.int_0, g);
      else
        this.gclass60_4 = GClass126.smethod_34(this.string_5 + this.idHat.ToString());
    }
    catch (Exception ex)
    {
    }
  }

  public bool method_153(int fr) => fr != Class15.smethod_0(7) && fr != Class15.smethod_0(5) && fr != Class15.smethod_0(2) && fr != Class15.smethod_0(3) && fr != Class15.smethod_0(37) && fr != Class15.smethod_0(45) && fr != Class15.smethod_0(31) && fr != Class15.smethod_0(47) && fr != Class15.smethod_0(49) && fr != Class15.smethod_0(9) && fr != Class15.smethod_0(10) && fr != Class15.smethod_0(50) && fr != Class15.smethod_0(33) && fr != Class15.smethod_0(35) && fr != Class15.smethod_0(36) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public string method_154()
  {
    if ((this.cgender == 0 ? 0 : 1) == 0)
      return Class13.smethod_0(135958);
    return this.cgender == Class15.smethod_0(1) ? Class13.smethod_0(136059) : Class13.smethod_0(136056);
  }

  public string method_155() => (this.cName == null ? 1 : 0) == 0 && (!(this.cName == "") ? 0 : 1) == 0 && (!this.cName.StartsWith(Class13.smethod_0(136053)) ? 0 : 1) != 0 ? this.cName.Substring(Class15.smethod_0(0), this.cName.IndexOf(Class13.smethod_0(136019)) + Class15.smethod_0(1)) : "";

  static GClass20()
  {
    int[][][] numArray1 = new int[Class15.smethod_0(48)][][];
    int index1 = Class15.smethod_0(0);
    int[][] numArray2 = new int[Class15.smethod_0(2)][];
    int index2 = Class15.smethod_0(0);
    int[] numArray3 = new int[Class15.smethod_0(5)];
    numArray3[Class15.smethod_0(1)] = Class15.smethod_0(250);
    numArray3[Class15.smethod_0(7)] = Class15.smethod_0(117);
    numArray2[index2] = numArray3;
    int index3 = Class15.smethod_0(1);
    byte[] byte_0_1 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.OfapvDlLrTHx));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_1);
    numArray2[index3] = numArray4;
    int index4 = Class15.smethod_0(7);
    byte[] byte_0_2 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.prIzINjKHCIS));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_2);
    numArray2[index4] = numArray5;
    int index5 = Class15.smethod_0(5);
    byte[] byte_0_3 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.cqWYIrMqFKiO));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_3);
    numArray2[index5] = numArray6;
    numArray1[index1] = numArray2;
    int index6 = Class15.smethod_0(1);
    int[][] numArray7 = new int[Class15.smethod_0(2)][];
    int index7 = Class15.smethod_0(0);
    int[] numArray8 = new int[Class15.smethod_0(5)];
    numArray8[Class15.smethod_0(1)] = Class15.smethod_0(250);
    numArray8[Class15.smethod_0(7)] = Class15.smethod_0(95);
    numArray7[index7] = numArray8;
    int index8 = Class15.smethod_0(1);
    byte[] byte_0_4 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.OfapvDlLrTHx));
    int[] numArray9 = (int[]) Class15.smethod_4(byte_0_4);
    numArray7[index8] = numArray9;
    int index9 = Class15.smethod_0(7);
    byte[] byte_0_5 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.AdbLcpqdFSBy));
    int[] numArray10 = (int[]) Class15.smethod_4(byte_0_5);
    numArray7[index9] = numArray10;
    int index10 = Class15.smethod_0(5);
    byte[] byte_0_6 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.vPKkqhnJIZvk));
    int[] numArray11 = (int[]) Class15.smethod_4(byte_0_6);
    numArray7[index10] = numArray11;
    numArray1[index6] = numArray7;
    int index11 = Class15.smethod_0(7);
    int[][] numArray12 = new int[Class15.smethod_0(2)][];
    int index12 = Class15.smethod_0(0);
    byte[] byte_0_7 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.hjquVIjKOqpG));
    int[] numArray13 = (int[]) Class15.smethod_4(byte_0_7);
    numArray12[index12] = numArray13;
    int index13 = Class15.smethod_0(1);
    byte[] byte_0_8 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.KfVvjptiMQEe));
    int[] numArray14 = (int[]) Class15.smethod_4(byte_0_8);
    numArray12[index13] = numArray14;
    int index14 = Class15.smethod_0(7);
    byte[] byte_0_9 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.ruaEIAgrBpEM));
    int[] numArray15 = (int[]) Class15.smethod_4(byte_0_9);
    numArray12[index14] = numArray15;
    int index15 = Class15.smethod_0(5);
    byte[] byte_0_10 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.tCjDKQVGvjCd));
    int[] numArray16 = (int[]) Class15.smethod_4(byte_0_10);
    numArray12[index15] = numArray16;
    numArray1[index11] = numArray12;
    int index16 = Class15.smethod_0(5);
    int[][] numArray17 = new int[Class15.smethod_0(2)][];
    int index17 = Class15.smethod_0(0);
    byte[] byte_0_11 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.DJFxzeXkWKHY));
    int[] numArray18 = (int[]) Class15.smethod_4(byte_0_11);
    numArray17[index17] = numArray18;
    int index18 = Class15.smethod_0(1);
    byte[] byte_0_12 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_12, __fieldref (Class12.YfCnyzSKyUca));
    int[] numArray19 = (int[]) Class15.smethod_4(byte_0_12);
    numArray17[index18] = numArray19;
    int index19 = Class15.smethod_0(7);
    byte[] byte_0_13 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_13, __fieldref (Class12.jHXaNonbszYk));
    int[] numArray20 = (int[]) Class15.smethod_4(byte_0_13);
    numArray17[index19] = numArray20;
    int index20 = Class15.smethod_0(5);
    byte[] byte_0_14 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_14, __fieldref (Class12.ptAKcePrRGRa));
    int[] numArray21 = (int[]) Class15.smethod_4(byte_0_14);
    numArray17[index20] = numArray21;
    numArray1[index16] = numArray17;
    int index21 = Class15.smethod_0(2);
    int[][] numArray22 = new int[Class15.smethod_0(2)][];
    int index22 = Class15.smethod_0(0);
    byte[] byte_0_15 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_15, __fieldref (Class12.nlCOPtiAUwOl));
    int[] numArray23 = (int[]) Class15.smethod_4(byte_0_15);
    numArray22[index22] = numArray23;
    int index23 = Class15.smethod_0(1);
    byte[] byte_0_16 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_16, __fieldref (Class12.gMoLEclHrKAp));
    int[] numArray24 = (int[]) Class15.smethod_4(byte_0_16);
    numArray22[index23] = numArray24;
    int index24 = Class15.smethod_0(7);
    byte[] byte_0_17 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_17, __fieldref (Class12.QbjZoTBlqlFd));
    int[] numArray25 = (int[]) Class15.smethod_4(byte_0_17);
    numArray22[index24] = numArray25;
    int index25 = Class15.smethod_0(5);
    byte[] byte_0_18 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_18, __fieldref (Class12.LmLdvypYtDif));
    int[] numArray26 = (int[]) Class15.smethod_4(byte_0_18);
    numArray22[index25] = numArray26;
    numArray1[index21] = numArray22;
    int index26 = Class15.smethod_0(3);
    int[][] numArray27 = new int[Class15.smethod_0(2)][];
    int index27 = Class15.smethod_0(0);
    byte[] byte_0_19 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_19, __fieldref (Class12.nlCOPtiAUwOl));
    int[] numArray28 = (int[]) Class15.smethod_4(byte_0_19);
    numArray27[index27] = numArray28;
    int index28 = Class15.smethod_0(1);
    byte[] byte_0_20 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_20, __fieldref (Class12.fgPophdyxDeS));
    int[] numArray29 = (int[]) Class15.smethod_4(byte_0_20);
    numArray27[index28] = numArray29;
    int index29 = Class15.smethod_0(7);
    byte[] byte_0_21 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_21, __fieldref (Class12.EMsKknWYgGEV));
    int[] numArray30 = (int[]) Class15.smethod_4(byte_0_21);
    numArray27[index29] = numArray30;
    int index30 = Class15.smethod_0(5);
    byte[] byte_0_22 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_22, __fieldref (Class12.MmsElEIOpQXz));
    int[] numArray31 = (int[]) Class15.smethod_4(byte_0_22);
    numArray27[index30] = numArray31;
    numArray1[index26] = numArray27;
    int index31 = Class15.smethod_0(37);
    int[][] numArray32 = new int[Class15.smethod_0(2)][];
    int index32 = Class15.smethod_0(0);
    byte[] byte_0_23 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_23, __fieldref (Class12.hjquVIjKOqpG));
    int[] numArray33 = (int[]) Class15.smethod_4(byte_0_23);
    numArray32[index32] = numArray33;
    int index33 = Class15.smethod_0(1);
    byte[] byte_0_24 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_24, __fieldref (Class12.sPNxKoeQwMnx));
    int[] numArray34 = (int[]) Class15.smethod_4(byte_0_24);
    numArray32[index33] = numArray34;
    int index34 = Class15.smethod_0(7);
    byte[] byte_0_25 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_25, __fieldref (Class12.JQVuLikAxebB));
    int[] numArray35 = (int[]) Class15.smethod_4(byte_0_25);
    numArray32[index34] = numArray35;
    int index35 = Class15.smethod_0(5);
    byte[] byte_0_26 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_26, __fieldref (Class12.LmLdvypYtDif));
    int[] numArray36 = (int[]) Class15.smethod_4(byte_0_26);
    numArray32[index35] = numArray36;
    numArray1[index31] = numArray32;
    int index36 = Class15.smethod_0(38);
    int[][] numArray37 = new int[Class15.smethod_0(2)][];
    int index37 = Class15.smethod_0(0);
    int[] numArray38 = new int[Class15.smethod_0(5)];
    numArray38[Class15.smethod_0(1)] = Class15.smethod_0(251);
    numArray38[Class15.smethod_0(7)] = Class15.smethod_0(86);
    numArray37[index37] = numArray38;
    int index38 = Class15.smethod_0(1);
    byte[] byte_0_27 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_27, __fieldref (Class12.PjoJjnKizZSK));
    int[] numArray39 = (int[]) Class15.smethod_4(byte_0_27);
    numArray37[index38] = numArray39;
    int index39 = Class15.smethod_0(7);
    byte[] byte_0_28 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_28, __fieldref (Class12.uqHaFIIGkRwg));
    int[] numArray40 = (int[]) Class15.smethod_4(byte_0_28);
    numArray37[index39] = numArray40;
    int index40 = Class15.smethod_0(5);
    byte[] byte_0_29 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_29, __fieldref (Class12.shSpcTnMTzxO));
    int[] numArray41 = (int[]) Class15.smethod_4(byte_0_29);
    numArray37[index40] = numArray41;
    numArray1[index36] = numArray37;
    int index41 = Class15.smethod_0(88);
    int[][] numArray42 = new int[Class15.smethod_0(2)][];
    int index42 = Class15.smethod_0(0);
    int[] numArray43 = new int[Class15.smethod_0(5)];
    numArray43[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray43[Class15.smethod_0(7)] = Class15.smethod_0(95);
    numArray42[index42] = numArray43;
    int index43 = Class15.smethod_0(1);
    int[] numArray44 = new int[Class15.smethod_0(5)];
    numArray44[Class15.smethod_0(1)] = Class15.smethod_0(253);
    numArray44[Class15.smethod_0(7)] = Class15.smethod_0(28);
    numArray42[index43] = numArray44;
    int index44 = Class15.smethod_0(7);
    byte[] byte_0_30 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_30, __fieldref (Class12.LJIKpCvwOHLe));
    int[] numArray45 = (int[]) Class15.smethod_4(byte_0_30);
    numArray42[index44] = numArray45;
    int index45 = Class15.smethod_0(5);
    byte[] byte_0_31 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_31, __fieldref (Class12.agFqnhhKCsbe));
    int[] numArray46 = (int[]) Class15.smethod_4(byte_0_31);
    numArray42[index45] = numArray46;
    numArray1[index41] = numArray42;
    int index46 = Class15.smethod_0(45);
    int[][] numArray47 = new int[Class15.smethod_0(2)][];
    int index47 = Class15.smethod_0(0);
    byte[] byte_0_32 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_32, __fieldref (Class12.oLtEhpTmbKdA));
    int[] numArray48 = (int[]) Class15.smethod_4(byte_0_32);
    numArray47[index47] = numArray48;
    int index48 = Class15.smethod_0(1);
    byte[] byte_0_33 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_33, __fieldref (Class12.uzAnpjWOnMnB));
    int[] numArray49 = (int[]) Class15.smethod_4(byte_0_33);
    numArray47[index48] = numArray49;
    int index49 = Class15.smethod_0(7);
    byte[] byte_0_34 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_34, __fieldref (Class12.aTKxyaqmloUG));
    int[] numArray50 = (int[]) Class15.smethod_4(byte_0_34);
    numArray47[index49] = numArray50;
    numArray47[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index46] = numArray47;
    int index50 = Class15.smethod_0(31);
    int[][] numArray51 = new int[Class15.smethod_0(2)][];
    int index51 = Class15.smethod_0(0);
    byte[] byte_0_35 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_35, __fieldref (Class12.XGunuwRwyege));
    int[] numArray52 = (int[]) Class15.smethod_4(byte_0_35);
    numArray51[index51] = numArray52;
    int index52 = Class15.smethod_0(1);
    byte[] byte_0_36 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_36, __fieldref (Class12.bqtygpqjPazL));
    int[] numArray53 = (int[]) Class15.smethod_4(byte_0_36);
    numArray51[index52] = numArray53;
    int index53 = Class15.smethod_0(7);
    byte[] byte_0_37 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_37, __fieldref (Class12.fjEgsOCDdgnG));
    int[] numArray54 = (int[]) Class15.smethod_4(byte_0_37);
    numArray51[index53] = numArray54;
    numArray51[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index50] = numArray51;
    int index54 = Class15.smethod_0(67);
    int[][] numArray55 = new int[Class15.smethod_0(2)][];
    int index55 = Class15.smethod_0(0);
    int[] numArray56 = new int[Class15.smethod_0(5)];
    numArray56[Class15.smethod_0(1)] = Class15.smethod_0(254);
    numArray56[Class15.smethod_0(7)] = Class15.smethod_0(117);
    numArray55[index55] = numArray56;
    int index56 = Class15.smethod_0(1);
    byte[] byte_0_38 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_38, __fieldref (Class12.nPmouvvIbKZE));
    int[] numArray57 = (int[]) Class15.smethod_4(byte_0_38);
    numArray55[index56] = numArray57;
    int index57 = Class15.smethod_0(7);
    byte[] byte_0_39 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_39, __fieldref (Class12.KsnCbUzIAqrb));
    int[] numArray58 = (int[]) Class15.smethod_4(byte_0_39);
    numArray55[index57] = numArray58;
    numArray55[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index54] = numArray55;
    int index58 = Class15.smethod_0(66);
    int[][] numArray59 = new int[Class15.smethod_0(2)][];
    int index59 = Class15.smethod_0(0);
    int[] numArray60 = new int[Class15.smethod_0(5)];
    numArray60[Class15.smethod_0(1)] = Class15.smethod_0(138);
    numArray60[Class15.smethod_0(7)] = Class15.smethod_0(95);
    numArray59[index59] = numArray60;
    int index60 = Class15.smethod_0(1);
    byte[] byte_0_40 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_40, __fieldref (Class12.BJPfcQKDzLpz));
    int[] numArray61 = (int[]) Class15.smethod_4(byte_0_40);
    numArray59[index60] = numArray61;
    int index61 = Class15.smethod_0(7);
    byte[] byte_0_41 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_41, __fieldref (Class12.inKrzeyOSlkA));
    int[] numArray62 = (int[]) Class15.smethod_4(byte_0_41);
    numArray59[index61] = numArray62;
    int index62 = Class15.smethod_0(5);
    byte[] byte_0_42 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_42, __fieldref (Class12.CuaTBvipTyFb));
    int[] numArray63 = (int[]) Class15.smethod_4(byte_0_42);
    numArray59[index62] = numArray63;
    numArray1[index58] = numArray59;
    int index63 = Class15.smethod_0(47);
    int[][] numArray64 = new int[Class15.smethod_0(2)][];
    int index64 = Class15.smethod_0(0);
    byte[] byte_0_43 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_43, __fieldref (Class12.ordogNPumqKP));
    int[] numArray65 = (int[]) Class15.smethod_4(byte_0_43);
    numArray64[index64] = numArray65;
    int index65 = Class15.smethod_0(1);
    byte[] byte_0_44 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_44, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray66 = (int[]) Class15.smethod_4(byte_0_44);
    numArray64[index65] = numArray66;
    int index66 = Class15.smethod_0(7);
    byte[] byte_0_45 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_45, __fieldref (Class12.miKNaEtClKLR));
    int[] numArray67 = (int[]) Class15.smethod_4(byte_0_45);
    numArray64[index66] = numArray67;
    numArray64[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index63] = numArray64;
    int index67 = Class15.smethod_0(49);
    int[][] numArray68 = new int[Class15.smethod_0(2)][];
    int index68 = Class15.smethod_0(0);
    byte[] byte_0_46 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_46, __fieldref (Class12.NLZHKzBsBtCa));
    int[] numArray69 = (int[]) Class15.smethod_4(byte_0_46);
    numArray68[index68] = numArray69;
    int index69 = Class15.smethod_0(1);
    byte[] byte_0_47 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_47, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray70 = (int[]) Class15.smethod_4(byte_0_47);
    numArray68[index69] = numArray70;
    int index70 = Class15.smethod_0(7);
    byte[] byte_0_48 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_48, __fieldref (Class12.xXODYWGlToZu));
    int[] numArray71 = (int[]) Class15.smethod_4(byte_0_48);
    numArray68[index70] = numArray71;
    numArray68[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index67] = numArray68;
    int index71 = Class15.smethod_0(9);
    int[][] numArray72 = new int[Class15.smethod_0(2)][];
    int index72 = Class15.smethod_0(0);
    byte[] byte_0_49 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_49, __fieldref (Class12.HXGliyYgshiE));
    int[] numArray73 = (int[]) Class15.smethod_4(byte_0_49);
    numArray72[index72] = numArray73;
    int index73 = Class15.smethod_0(1);
    byte[] byte_0_50 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_50, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray74 = (int[]) Class15.smethod_4(byte_0_50);
    numArray72[index73] = numArray74;
    int index74 = Class15.smethod_0(7);
    byte[] byte_0_51 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_51, __fieldref (Class12.TafCRtQdAuOm));
    int[] numArray75 = (int[]) Class15.smethod_4(byte_0_51);
    numArray72[index74] = numArray75;
    numArray72[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index71] = numArray72;
    int index75 = Class15.smethod_0(10);
    int[][] numArray76 = new int[Class15.smethod_0(2)][];
    int index76 = Class15.smethod_0(0);
    byte[] byte_0_52 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_52, __fieldref (Class12.HXGliyYgshiE));
    int[] numArray77 = (int[]) Class15.smethod_4(byte_0_52);
    numArray76[index76] = numArray77;
    int index77 = Class15.smethod_0(1);
    byte[] byte_0_53 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_53, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray78 = (int[]) Class15.smethod_4(byte_0_53);
    numArray76[index77] = numArray78;
    int index78 = Class15.smethod_0(7);
    byte[] byte_0_54 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_54, __fieldref (Class12.qpQWKPQcqSxx));
    int[] numArray79 = (int[]) Class15.smethod_4(byte_0_54);
    numArray76[index78] = numArray79;
    numArray76[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index75] = numArray76;
    int index79 = Class15.smethod_0(186);
    int[][] numArray80 = new int[Class15.smethod_0(2)][];
    int index80 = Class15.smethod_0(0);
    int[] numArray81 = new int[Class15.smethod_0(5)];
    numArray81[Class15.smethod_0(1)] = Class15.smethod_0(136);
    numArray81[Class15.smethod_0(7)] = Class15.smethod_0(8);
    numArray80[index80] = numArray81;
    int index81 = Class15.smethod_0(1);
    byte[] byte_0_55 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_55, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray82 = (int[]) Class15.smethod_4(byte_0_55);
    numArray80[index81] = numArray82;
    int index82 = Class15.smethod_0(7);
    byte[] byte_0_56 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_56, __fieldref (Class12.tRkJCfjGgMkc));
    int[] numArray83 = (int[]) Class15.smethod_4(byte_0_56);
    numArray80[index82] = numArray83;
    numArray80[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index79] = numArray80;
    int index83 = Class15.smethod_0(124);
    int[][] numArray84 = new int[Class15.smethod_0(2)][];
    int index84 = Class15.smethod_0(0);
    int[] numArray85 = new int[Class15.smethod_0(5)];
    numArray85[Class15.smethod_0(1)] = Class15.smethod_0(145);
    numArray85[Class15.smethod_0(7)] = Class15.smethod_0(120);
    numArray84[index84] = numArray85;
    int index85 = Class15.smethod_0(1);
    byte[] byte_0_57 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_57, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray86 = (int[]) Class15.smethod_4(byte_0_57);
    numArray84[index85] = numArray86;
    int index86 = Class15.smethod_0(7);
    byte[] byte_0_58 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_58, __fieldref (Class12.GsdyTEiLJGEo));
    int[] numArray87 = (int[]) Class15.smethod_4(byte_0_58);
    numArray84[index86] = numArray87;
    numArray84[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index83] = numArray84;
    int index87 = Class15.smethod_0(65);
    int[][] numArray88 = new int[Class15.smethod_0(2)][];
    int index88 = Class15.smethod_0(0);
    int[] numArray89 = new int[Class15.smethod_0(5)];
    numArray89[Class15.smethod_0(1)] = Class15.smethod_0(251);
    numArray89[Class15.smethod_0(7)] = Class15.smethod_0(48);
    numArray88[index88] = numArray89;
    int index89 = Class15.smethod_0(1);
    byte[] byte_0_59 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_59, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray90 = (int[]) Class15.smethod_4(byte_0_59);
    numArray88[index89] = numArray90;
    int index90 = Class15.smethod_0(7);
    byte[] byte_0_60 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_60, __fieldref (Class12.DeIckDcpxOZl));
    int[] numArray91 = (int[]) Class15.smethod_4(byte_0_60);
    numArray88[index90] = numArray91;
    numArray88[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index87] = numArray88;
    int index91 = Class15.smethod_0(51);
    int[][] numArray92 = new int[Class15.smethod_0(2)][];
    int index92 = Class15.smethod_0(0);
    int[] numArray93 = new int[Class15.smethod_0(5)];
    numArray93[Class15.smethod_0(1)] = Class15.smethod_0(145);
    numArray93[Class15.smethod_0(7)] = Class15.smethod_0(48);
    numArray92[index92] = numArray93;
    int index93 = Class15.smethod_0(1);
    byte[] byte_0_61 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_61, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray94 = (int[]) Class15.smethod_4(byte_0_61);
    numArray92[index93] = numArray94;
    int index94 = Class15.smethod_0(7);
    byte[] byte_0_62 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_62, __fieldref (Class12.SStfKskXArCF));
    int[] numArray95 = (int[]) Class15.smethod_4(byte_0_62);
    numArray92[index94] = numArray95;
    numArray92[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index91] = numArray92;
    int index95 = Class15.smethod_0(27);
    int[][] numArray96 = new int[Class15.smethod_0(2)][];
    int index96 = Class15.smethod_0(0);
    int[] numArray97 = new int[Class15.smethod_0(5)];
    numArray97[Class15.smethod_0(1)] = Class15.smethod_0((int) byte.MaxValue);
    numArray97[Class15.smethod_0(7)] = Class15.smethod_0(8);
    numArray96[index96] = numArray97;
    int index97 = Class15.smethod_0(1);
    byte[] byte_0_63 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_63, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray98 = (int[]) Class15.smethod_4(byte_0_63);
    numArray96[index97] = numArray98;
    int index98 = Class15.smethod_0(7);
    byte[] byte_0_64 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_64, __fieldref (Class12.tnsRtByAUbIB));
    int[] numArray99 = (int[]) Class15.smethod_4(byte_0_64);
    numArray96[index98] = numArray99;
    numArray96[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index95] = numArray96;
    int index99 = Class15.smethod_0(28);
    int[][] numArray100 = new int[Class15.smethod_0(2)][];
    int index100 = Class15.smethod_0(0);
    int[] numArray101 = new int[Class15.smethod_0(5)];
    numArray101[Class15.smethod_0(1)] = Class15.smethod_0(254);
    numArray101[Class15.smethod_0(7)] = Class15.smethod_0(117);
    numArray100[index100] = numArray101;
    int index101 = Class15.smethod_0(1);
    byte[] byte_0_65 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_65, __fieldref (Class12.OfapvDlLrTHx));
    int[] numArray102 = (int[]) Class15.smethod_4(byte_0_65);
    numArray100[index101] = numArray102;
    int index102 = Class15.smethod_0(7);
    byte[] byte_0_66 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_66, __fieldref (Class12.MNArTkrlPGVm));
    int[] numArray103 = (int[]) Class15.smethod_4(byte_0_66);
    numArray100[index102] = numArray103;
    numArray100[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index99] = numArray100;
    int index103 = Class15.smethod_0(29);
    int[][] numArray104 = new int[Class15.smethod_0(2)][];
    int index104 = Class15.smethod_0(0);
    int[] numArray105 = new int[Class15.smethod_0(5)];
    numArray105[Class15.smethod_0(1)] = Class15.smethod_0(193);
    numArray105[Class15.smethod_0(7)] = Class15.smethod_0(86);
    numArray104[index104] = numArray105;
    int index105 = Class15.smethod_0(1);
    byte[] byte_0_67 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_67, __fieldref (Class12.PjoJjnKizZSK));
    int[] numArray106 = (int[]) Class15.smethod_4(byte_0_67);
    numArray104[index105] = numArray106;
    int index106 = Class15.smethod_0(7);
    int[] numArray107 = new int[Class15.smethod_0(5)];
    numArray107[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray107[Class15.smethod_0(7)] = Class15.smethod_0(46);
    numArray104[index106] = numArray107;
    numArray104[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index103] = numArray104;
    int index107 = Class15.smethod_0(40);
    int[][] numArray108 = new int[Class15.smethod_0(2)][];
    int index108 = Class15.smethod_0(0);
    int[] numArray109 = new int[Class15.smethod_0(5)];
    numArray109[Class15.smethod_0(1)] = Class15.smethod_0(251);
    numArray109[Class15.smethod_0(7)] = Class15.smethod_0(8);
    numArray108[index108] = numArray109;
    int index109 = Class15.smethod_0(1);
    byte[] byte_0_68 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_68, __fieldref (Class12.gZNCLgFivzwd));
    int[] numArray110 = (int[]) Class15.smethod_4(byte_0_68);
    numArray108[index109] = numArray110;
    int index110 = Class15.smethod_0(7);
    int[] numArray111 = new int[Class15.smethod_0(5)];
    numArray111[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray111[Class15.smethod_0(7)] = Class15.smethod_0(51);
    numArray108[index110] = numArray111;
    numArray108[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index107] = numArray108;
    int index111 = Class15.smethod_0(46);
    int[][] numArray112 = new int[Class15.smethod_0(2)][];
    int index112 = Class15.smethod_0(0);
    byte[] byte_0_69 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_69, __fieldref (Class12.AbEtGSfBPsoc));
    int[] numArray113 = (int[]) Class15.smethod_4(byte_0_69);
    numArray112[index112] = numArray113;
    int index113 = Class15.smethod_0(1);
    byte[] byte_0_70 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_70, __fieldref (Class12.oIvAxdQnSRxB));
    int[] numArray114 = (int[]) Class15.smethod_4(byte_0_70);
    numArray112[index113] = numArray114;
    int index114 = Class15.smethod_0(7);
    byte[] byte_0_71 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_71, __fieldref (Class12.tiLSVgpvxFSU));
    int[] numArray115 = (int[]) Class15.smethod_4(byte_0_71);
    numArray112[index114] = numArray115;
    numArray112[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index111] = numArray112;
    int index115 = Class15.smethod_0(50);
    int[][] numArray116 = new int[Class15.smethod_0(2)][];
    int index116 = Class15.smethod_0(0);
    byte[] byte_0_72 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_72, __fieldref (Class12.ordogNPumqKP));
    int[] numArray117 = (int[]) Class15.smethod_4(byte_0_72);
    numArray116[index116] = numArray117;
    int index117 = Class15.smethod_0(1);
    byte[] byte_0_73 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_73, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray118 = (int[]) Class15.smethod_4(byte_0_73);
    numArray116[index117] = numArray118;
    int index118 = Class15.smethod_0(7);
    byte[] byte_0_74 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_74, __fieldref (Class12.miKNaEtClKLR));
    int[] numArray119 = (int[]) Class15.smethod_4(byte_0_74);
    numArray116[index118] = numArray119;
    numArray116[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index115] = numArray116;
    int index119 = Class15.smethod_0(33);
    int[][] numArray120 = new int[Class15.smethod_0(2)][];
    int index120 = Class15.smethod_0(0);
    byte[] byte_0_75 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_75, __fieldref (Class12.NLZHKzBsBtCa));
    int[] numArray121 = (int[]) Class15.smethod_4(byte_0_75);
    numArray120[index120] = numArray121;
    int index121 = Class15.smethod_0(1);
    byte[] byte_0_76 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_76, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray122 = (int[]) Class15.smethod_4(byte_0_76);
    numArray120[index121] = numArray122;
    int index122 = Class15.smethod_0(7);
    byte[] byte_0_77 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_77, __fieldref (Class12.xXODYWGlToZu));
    int[] numArray123 = (int[]) Class15.smethod_4(byte_0_77);
    numArray120[index122] = numArray123;
    numArray120[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index119] = numArray120;
    int index123 = Class15.smethod_0(35);
    int[][] numArray124 = new int[Class15.smethod_0(2)][];
    int index124 = Class15.smethod_0(0);
    byte[] byte_0_78 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_78, __fieldref (Class12.HXGliyYgshiE));
    int[] numArray125 = (int[]) Class15.smethod_4(byte_0_78);
    numArray124[index124] = numArray125;
    int index125 = Class15.smethod_0(1);
    byte[] byte_0_79 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_79, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray126 = (int[]) Class15.smethod_4(byte_0_79);
    numArray124[index125] = numArray126;
    int index126 = Class15.smethod_0(7);
    byte[] byte_0_80 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_80, __fieldref (Class12.TafCRtQdAuOm));
    int[] numArray127 = (int[]) Class15.smethod_4(byte_0_80);
    numArray124[index126] = numArray127;
    numArray124[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index123] = numArray124;
    int index127 = Class15.smethod_0(36);
    int[][] numArray128 = new int[Class15.smethod_0(2)][];
    int index128 = Class15.smethod_0(0);
    byte[] byte_0_81 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_81, __fieldref (Class12.HXGliyYgshiE));
    int[] numArray129 = (int[]) Class15.smethod_4(byte_0_81);
    numArray128[index128] = numArray129;
    int index129 = Class15.smethod_0(1);
    byte[] byte_0_82 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_82, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray130 = (int[]) Class15.smethod_4(byte_0_82);
    numArray128[index129] = numArray130;
    int index130 = Class15.smethod_0(7);
    byte[] byte_0_83 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_83, __fieldref (Class12.qpQWKPQcqSxx));
    int[] numArray131 = (int[]) Class15.smethod_4(byte_0_83);
    numArray128[index130] = numArray131;
    numArray128[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index127] = numArray128;
    int index131 = Class15.smethod_0(6);
    int[][] numArray132 = new int[Class15.smethod_0(2)][];
    int index132 = Class15.smethod_0(0);
    int[] numArray133 = new int[Class15.smethod_0(5)];
    numArray133[Class15.smethod_0(1)] = Class15.smethod_0(251);
    numArray133[Class15.smethod_0(7)] = Class15.smethod_0(48);
    numArray132[index132] = numArray133;
    int index133 = Class15.smethod_0(1);
    byte[] byte_0_84 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_84, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray134 = (int[]) Class15.smethod_4(byte_0_84);
    numArray132[index133] = numArray134;
    int index134 = Class15.smethod_0(7);
    byte[] byte_0_85 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_85, __fieldref (Class12.DeIckDcpxOZl));
    int[] numArray135 = (int[]) Class15.smethod_4(byte_0_85);
    numArray132[index134] = numArray135;
    numArray132[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index131] = numArray132;
    int index135 = Class15.smethod_0(8);
    int[][] numArray136 = new int[Class15.smethod_0(2)][];
    int index136 = Class15.smethod_0(0);
    int[] numArray137 = new int[Class15.smethod_0(5)];
    numArray137[Class15.smethod_0(1)] = Class15.smethod_0(145);
    numArray137[Class15.smethod_0(7)] = Class15.smethod_0(48);
    numArray136[index136] = numArray137;
    int index137 = Class15.smethod_0(1);
    byte[] byte_0_86 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_86, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray138 = (int[]) Class15.smethod_4(byte_0_86);
    numArray136[index137] = numArray138;
    int index138 = Class15.smethod_0(7);
    byte[] byte_0_87 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_87, __fieldref (Class12.SStfKskXArCF));
    int[] numArray139 = (int[]) Class15.smethod_4(byte_0_87);
    numArray136[index138] = numArray139;
    numArray136[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index135] = numArray136;
    int index139 = Class15.smethod_0(120);
    int[][] numArray140 = new int[Class15.smethod_0(2)][];
    int index140 = Class15.smethod_0(0);
    int[] numArray141 = new int[Class15.smethod_0(5)];
    numArray141[Class15.smethod_0(1)] = Class15.smethod_0((int) byte.MaxValue);
    numArray141[Class15.smethod_0(7)] = Class15.smethod_0(120);
    numArray140[index140] = numArray141;
    int index141 = Class15.smethod_0(1);
    byte[] byte_0_88 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_88, __fieldref (Class12.frQKnrtEzdWz));
    int[] numArray142 = (int[]) Class15.smethod_4(byte_0_88);
    numArray140[index141] = numArray142;
    int index142 = Class15.smethod_0(7);
    byte[] byte_0_89 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_89, __fieldref (Class12.wiyHAeAxmHdn));
    int[] numArray143 = (int[]) Class15.smethod_4(byte_0_89);
    numArray140[index142] = numArray143;
    numArray140[Class15.smethod_0(5)] = new int[Class15.smethod_0(5)];
    numArray1[index139] = numArray140;
    GClass20.int_0 = numArray1;
    byte[] byte_0_90 = new byte[Class15.smethod_0(257)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_90, __fieldref (Class12.niEuSQgHzWSf));
    GClass20.int_1 = (int[]) Class15.smethod_4(byte_0_90);
    byte[] byte_0_91 = new byte[Class15.smethod_0(39)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_91, __fieldref (Class12.kKtnCcxmNnfD));
    GClass20.int_2 = (int[]) Class15.smethod_4(byte_0_91);
    string[][] strArray1 = new string[Class15.smethod_0(7)][];
    int index143 = Class15.smethod_0(0);
    string[] strArray2 = new string[Class15.smethod_0(2)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(136566);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(136566);
    strArray2[Class15.smethod_0(7)] = Class13.smethod_0(136564);
    strArray2[Class15.smethod_0(5)] = Class13.smethod_0(136532);
    strArray1[index143] = strArray2;
    int index144 = Class15.smethod_0(1);
    string[] strArray3 = new string[Class15.smethod_0(2)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(136631);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(136631);
    strArray3[Class15.smethod_0(7)] = Class13.smethod_0(136607);
    strArray3[Class15.smethod_0(5)] = Class13.smethod_0(136988);
    strArray1[index144] = strArray3;
    GClass20.string_0 = strArray1;
    int[][] numArray144 = new int[Class15.smethod_0(31)][];
    int index145 = Class15.smethod_0(0);
    byte[] byte_0_92 = new byte[Class15.smethod_0(13)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_92, __fieldref (Class12.GDAViKMwPCeN));
    int[] numArray145 = (int[]) Class15.smethod_4(byte_0_92);
    numArray144[index145] = numArray145;
    int index146 = Class15.smethod_0(1);
    byte[] byte_0_93 = new byte[Class15.smethod_0(13)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_93, __fieldref (Class12.hBDZfqiNGxso));
    int[] numArray146 = (int[]) Class15.smethod_4(byte_0_93);
    numArray144[index146] = numArray146;
    int index147 = Class15.smethod_0(7);
    byte[] byte_0_94 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_94, __fieldref (Class12.IZsDbzwTERzU));
    int[] numArray147 = (int[]) Class15.smethod_4(byte_0_94);
    numArray144[index147] = numArray147;
    int index148 = Class15.smethod_0(5);
    byte[] byte_0_95 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_95, __fieldref (Class12.ajXOQXgXLBix));
    int[] numArray148 = (int[]) Class15.smethod_4(byte_0_95);
    numArray144[index148] = numArray148;
    int index149 = Class15.smethod_0(2);
    byte[] byte_0_96 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_96, __fieldref (Class12.CvnHGPqWKTdn));
    int[] numArray149 = (int[]) Class15.smethod_4(byte_0_96);
    numArray144[index149] = numArray149;
    int index150 = Class15.smethod_0(3);
    byte[] byte_0_97 = new byte[Class15.smethod_0(257)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_97, __fieldref (Class12.ePUFQQxtJLjF));
    int[] numArray150 = (int[]) Class15.smethod_4(byte_0_97);
    numArray144[index150] = numArray150;
    int index151 = Class15.smethod_0(37);
    byte[] byte_0_98 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_98, __fieldref (Class12.wlPQJJepLmVS));
    int[] numArray151 = (int[]) Class15.smethod_4(byte_0_98);
    numArray144[index151] = numArray151;
    int index152 = Class15.smethod_0(38);
    byte[] byte_0_99 = new byte[Class15.smethod_0(257)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_99, __fieldref (Class12.ZLWUwhLjIHeT));
    int[] numArray152 = (int[]) Class15.smethod_4(byte_0_99);
    numArray144[index152] = numArray152;
    int index153 = Class15.smethod_0(88);
    byte[] byte_0_100 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_100, __fieldref (Class12.xTanejWFQiyS));
    int[] numArray153 = (int[]) Class15.smethod_4(byte_0_100);
    numArray144[index153] = numArray153;
    int index154 = Class15.smethod_0(45);
    byte[] byte_0_101 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_101, __fieldref (Class12.WexjVHMEqRBW));
    int[] numArray154 = (int[]) Class15.smethod_4(byte_0_101);
    numArray144[index154] = numArray154;
    GClass20.int_6 = numArray144;
    GClass20.bool_13 = Class15.smethod_0(0) != 0;
    int[][] numArray155 = new int[Class15.smethod_0(1)][];
    int index155 = Class15.smethod_0(0);
    int[] numArray156 = new int[Class15.smethod_0(7)];
    numArray156[Class15.smethod_0(0)] = Class15.smethod_0(258);
    numArray156[Class15.smethod_0(1)] = Class15.smethod_0(259);
    numArray155[index155] = numArray156;
    GClass20.int_23 = numArray155;
    GClass20.bool_18 = Class15.smethod_0(1) != 0;
    GClass20.bool_19 = Class15.smethod_0(1) != 0;
    int[][] numArray157 = new int[Class15.smethod_0(120)][];
    int index156 = Class15.smethod_0(0);
    int[] numArray158 = new int[Class15.smethod_0(7)];
    numArray158[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray158[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index156] = numArray158;
    int index157 = Class15.smethod_0(1);
    int[] numArray159 = new int[Class15.smethod_0(7)];
    numArray159[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray159[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index157] = numArray159;
    int index158 = Class15.smethod_0(7);
    int[] numArray160 = new int[Class15.smethod_0(7)];
    numArray160[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray160[Class15.smethod_0(1)] = Class15.smethod_0(193);
    numArray157[index158] = numArray160;
    int index159 = Class15.smethod_0(5);
    int[] numArray161 = new int[Class15.smethod_0(7)];
    numArray161[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray161[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index159] = numArray161;
    int index160 = Class15.smethod_0(2);
    int[] numArray162 = new int[Class15.smethod_0(7)];
    numArray162[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray162[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray157[index160] = numArray162;
    int index161 = Class15.smethod_0(3);
    int[] numArray163 = new int[Class15.smethod_0(7)];
    numArray163[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray163[Class15.smethod_0(1)] = Class15.smethod_0(193);
    numArray157[index161] = numArray163;
    int index162 = Class15.smethod_0(37);
    int[] numArray164 = new int[Class15.smethod_0(7)];
    numArray164[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray164[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index162] = numArray164;
    int index163 = Class15.smethod_0(38);
    int[] numArray165 = new int[Class15.smethod_0(7)];
    numArray165[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray157[index163] = numArray165;
    int index164 = Class15.smethod_0(88);
    int[] numArray166 = new int[Class15.smethod_0(7)];
    numArray166[Class15.smethod_0(0)] = Class15.smethod_0(67);
    numArray166[Class15.smethod_0(1)] = Class15.smethod_0(1);
    numArray157[index164] = numArray166;
    int index165 = Class15.smethod_0(45);
    int[] numArray167 = new int[Class15.smethod_0(7)];
    numArray167[Class15.smethod_0(0)] = Class15.smethod_0(2);
    numArray157[index165] = numArray167;
    int index166 = Class15.smethod_0(31);
    int[] numArray168 = new int[Class15.smethod_0(7)];
    numArray168[Class15.smethod_0(0)] = Class15.smethod_0(2);
    numArray168[Class15.smethod_0(1)] = -1;
    numArray157[index166] = numArray168;
    int index167 = Class15.smethod_0(67);
    int[] numArray169 = new int[Class15.smethod_0(7)];
    numArray169[Class15.smethod_0(0)] = Class15.smethod_0(2);
    numArray169[Class15.smethod_0(1)] = Class15.smethod_0(88);
    numArray157[index167] = numArray169;
    int index168 = Class15.smethod_0(66);
    int[] numArray170 = new int[Class15.smethod_0(7)];
    numArray170[Class15.smethod_0(0)] = Class15.smethod_0(37);
    numArray170[Class15.smethod_0(1)] = Class15.smethod_0(3);
    numArray157[index168] = numArray170;
    int index169 = Class15.smethod_0(47);
    int[] numArray171 = new int[Class15.smethod_0(7)];
    numArray171[Class15.smethod_0(0)] = Class15.smethod_0(37);
    numArray171[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray157[index169] = numArray171;
    int index170 = Class15.smethod_0(49);
    int[] numArray172 = new int[Class15.smethod_0(7)];
    numArray172[Class15.smethod_0(0)] = Class15.smethod_0(7);
    numArray172[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray157[index170] = numArray172;
    int index171 = Class15.smethod_0(9);
    int[] numArray173 = new int[Class15.smethod_0(7)];
    numArray173[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray173[Class15.smethod_0(1)] = Class15.smethod_0(193);
    numArray157[index171] = numArray173;
    int index172 = Class15.smethod_0(10);
    int[] numArray174 = new int[Class15.smethod_0(7)];
    numArray174[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray174[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray157[index172] = numArray174;
    int index173 = Class15.smethod_0(186);
    int[] numArray175 = new int[Class15.smethod_0(7)];
    numArray175[Class15.smethod_0(0)] = Class15.smethod_0(88);
    numArray157[index173] = numArray175;
    int index174 = Class15.smethod_0(124);
    int[] numArray176 = new int[Class15.smethod_0(7)];
    numArray176[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray176[Class15.smethod_0(1)] = Class15.smethod_0(3);
    numArray157[index174] = numArray176;
    int index175 = Class15.smethod_0(65);
    int[] numArray177 = new int[Class15.smethod_0(7)];
    numArray177[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray177[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index175] = numArray177;
    int index176 = Class15.smethod_0(51);
    int[] numArray178 = new int[Class15.smethod_0(7)];
    numArray178[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray178[Class15.smethod_0(1)] = Class15.smethod_0(134);
    numArray157[index176] = numArray178;
    int index177 = Class15.smethod_0(27);
    int[] numArray179 = new int[Class15.smethod_0(7)];
    numArray179[Class15.smethod_0(0)] = Class15.smethod_0(7);
    numArray179[Class15.smethod_0(1)] = Class15.smethod_0(88);
    numArray157[index177] = numArray179;
    int index178 = Class15.smethod_0(28);
    int[] numArray180 = new int[Class15.smethod_0(7)];
    numArray180[Class15.smethod_0(0)] = Class15.smethod_0(2);
    numArray180[Class15.smethod_0(1)] = Class15.smethod_0(3);
    numArray157[index178] = numArray180;
    int index179 = Class15.smethod_0(29);
    int[] numArray181 = new int[Class15.smethod_0(7)];
    numArray181[Class15.smethod_0(0)] = Class15.smethod_0(31);
    numArray181[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray157[index179] = numArray181;
    int index180 = Class15.smethod_0(40);
    int[] numArray182 = new int[Class15.smethod_0(7)];
    numArray182[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray182[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray157[index180] = numArray182;
    int index181 = Class15.smethod_0(46);
    int[] numArray183 = new int[Class15.smethod_0(7)];
    numArray183[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray183[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray157[index181] = numArray183;
    int index182 = Class15.smethod_0(50);
    int[] numArray184 = new int[Class15.smethod_0(7)];
    numArray184[Class15.smethod_0(0)] = Class15.smethod_0(37);
    numArray184[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray157[index182] = numArray184;
    int index183 = Class15.smethod_0(33);
    int[] numArray185 = new int[Class15.smethod_0(7)];
    numArray185[Class15.smethod_0(0)] = Class15.smethod_0(7);
    numArray185[Class15.smethod_0(1)] = Class15.smethod_0(192);
    numArray157[index183] = numArray185;
    int index184 = Class15.smethod_0(35);
    int[] numArray186 = new int[Class15.smethod_0(7)];
    numArray186[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray186[Class15.smethod_0(1)] = Class15.smethod_0(193);
    numArray157[index184] = numArray186;
    int index185 = Class15.smethod_0(36);
    int[] numArray187 = new int[Class15.smethod_0(7)];
    numArray187[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray187[Class15.smethod_0(1)] = Class15.smethod_0(256);
    numArray157[index185] = numArray187;
    int index186 = Class15.smethod_0(6);
    int[] numArray188 = new int[Class15.smethod_0(7)];
    numArray188[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray188[Class15.smethod_0(1)] = Class15.smethod_0(252);
    numArray157[index186] = numArray188;
    int index187 = Class15.smethod_0(8);
    int[] numArray189 = new int[Class15.smethod_0(7)];
    numArray189[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray189[Class15.smethod_0(1)] = Class15.smethod_0(134);
    numArray157[index187] = numArray189;
    GClass20.int_25 = numArray157;
  }
}
