// Decompiled with JetBrains decompiler
// Type: GClass141
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GClass141 : GInterface0, GInterface1
{
  public bool isShow;
  public int X;
  public int Y;
  public int W;
  public int H;
  public int ITEM_HEIGHT;
  public int TAB_W;
  public int TAB_W_NEW;
  public int cmtoY;
  public int cmy;
  public int cmdy;
  public int cmvy;
  public int cmyLim;
  public int xc;
  public int[] cmyLast;
  public int cmtoX;
  public int cmx;
  public int cmxLim;
  public int cmxMap;
  public int cmyMap;
  public int cmxMapLim;
  public int cmyMapLim;
  public int cmyQuest;
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public GClass178 tabIcon;
  public GClass134 vItemCombine;
  public int moneyGD;
  public int friendMoneyGD;
  public bool isLock;
  public bool isFriendLock;
  public bool isAccept;
  public bool isFriendAccep;
  public string topName;
  public GClass23 chatTField;
  public static string string_0;
  public static short short_0;
  public static GClass66 gclass66_3;
  public static GClass66 gclass66_4;
  public static GClass66 gclass66_5;
  public static GClass66 gclass66_6;
  public static GClass66 gclass66_7;
  public static GClass66 gclass66_8;
  public static GClass66 gclass66_9;
  public static GClass66 gclass66_10;
  private static GClass66 gclass66_11;
  private static GClass66 gclass66_12;
  private int int_0;
  private int int_1;
  private bool bool_0;
  private int int_2;
  private int int_3;
  private GClass31 gclass31_0;
  public int type;
  public int currentTabIndex;
  public int startTabPos;
  public int[] lastTabIndex;
  public string[][] currentTabName;
  private int[] int_4;
  public int mainTabPos;
  public int shopTabPos;
  public int boxTabPos;
  public string[][] mainTabName;
  public string[] mapNames;
  public string[] planetNames;
  public static string[] string_1;
  public static string[] string_2;
  public static string[] string_3;
  public static string[] string_4;
  public static int int_5;
  public string[][] shopTabName;
  public int[] maxPageShop;
  public int[] currPageShop;
  private static string[][] string_5;
  private static string[][] string_6;
  private static string[][] string_7;
  private static string[][] string_8;
  private static string[][] string_9;
  public int zoneID;
  public bool isShowZone;
  public bool isShowPet;
  private static string[][] string_10;
  public string[][][] tabName;
  private static sbyte sbyte_0;
  private static sbyte sbyte_1;
  private static sbyte sbyte_2;
  private static sbyte sbyte_3;
  private static sbyte sbyte_4;
  private static sbyte sbyte_5;
  private static sbyte sbyte_6;
  private static sbyte sbyte_7;
  public int hasUse;
  public int hasUseBag;
  public int currentListLength;
  private int[] int_6;
  public static int[] int_7;
  public static int[] int_8;
  public static int[] int_9;
  public static int[] int_10;
  public static int[] int_11;
  public static int[] int_12;
  public static int[] int_13;
  public static int[] int_14;
  public static int[] int_15;
  public static int[][] int_16;
  public static int[][] int_17;
  public static int[][] int_18;
  public GClass80 currItem;
  public GClass25 currClan;
  public GClass28 currMess;
  public GClass94 currMem;
  public GClass25[] clans;
  public GClass134 member;
  public GClass134 myMember;
  public GClass134 logChat;
  public GClass134 vPlayerMenu;
  public GClass134 vFriend;
  public GClass134 vMyGD;
  public GClass134 vFriendGD;
  public GClass134 vTop;
  public GClass134 vEnemy;
  public GClass134 vFlag;
  public GClass31 cmdClose;
  public static bool bool_1;
  public static int int_19;
  private int int_20;
  public GClass20 charMenu;
  private bool bool_2;
  public int typeShop;
  public int xScroll;
  public int yScroll;
  public int wScroll;
  public int hScroll;
  public GClass43 cp;
  public int idIcon;
  public int[] partID;
  private int int_21;
  public bool isBoxClan;
  public int w;
  private int int_22;
  public int selected;
  private int int_23;
  private int int_24;
  private bool bool_3;
  public bool isSearchClan;
  public bool isMessage;
  public bool isViewMember;
  public const int int_25 = 0;
  public const int int_26 = 1;
  public const int int_27 = 2;
  public const int int_28 = 3;
  public const int int_29 = 4;
  public const int int_30 = 5;
  public const int int_31 = 6;
  public const int int_32 = 7;
  public const int int_33 = 8;
  public const int int_34 = 9;
  public const int int_35 = 10;
  public const int int_36 = 11;
  public const int int_37 = 12;
  public const int int_38 = 13;
  public const int int_39 = 14;
  public const int int_40 = 15;
  public const int int_41 = 16;
  public const int int_42 = 17;
  public const int int_43 = 18;
  public const int int_44 = 19;
  public const int int_45 = 20;
  public const int int_46 = 21;
  public const int int_47 = 22;
  public const int int_48 = 23;
  public const int int_49 = 24;
  public const int int_50 = 25;
  private int int_51;
  private int int_52;
  private int[] int_53;
  private bool bool_4;
  private bool bool_5;
  private bool bool_6;
  private int int_54;
  private int int_55;
  private int int_56;
  private int int_57;
  private int int_58;
  private int int_59;
  public int indexMouse;
  private bool bool_7;
  private int int_60;
  public string[][] clansOption;
  public string clanInfo;
  public string clanReport;
  private bool bool_8;
  private GClass154 gclass154_0;
  private int int_61;
  private int int_62;
  private bool bool_9;
  private string[] string_11;
  private int int_63;
  public static long[] long_0;
  private int[] int_64;
  public string[] combineInfo;
  public string[] combineTopInfo;
  public static int[] int_65;
  public static int[] int_66;
  private bool bool_10;
  private int int_67;
  public static string string_12;
  public int xstart;
  public int ystart;
  public int popupW;
  public int popupH;
  public int cmySK;
  public int cmtoYSK;
  public int cmdySK;
  public int cmvySK;
  public int cmyLimSK;
  public int popupY;
  public int popupX;
  public int isborderIndex;
  public int isselectedRow;
  public int indexSize;
  public int indexTitle;
  public int indexSelect;
  public int indexRow;
  public int indexRowMax;
  public int indexMenu;
  public int columns;
  public int rows;
  public int inforX;
  public int inforY;
  public int inforW;
  public int inforH;
  private int int_68;
  private int int_69;
  private int int_70;
  private int int_71;
  private int int_72;
  private int int_73;
  private int int_74;
  public static bool bool_11;
  public bool isClose;
  private int int_75;
  public static GClass134 gclass134_0;
  public static string[] string_13;
  public bool isViewChatServer;
  private int int_76;
  public GClass20 charInfo;
  private bool bool_12;
  private bool bool_13;
  private bool bool_14;
  private int int_77;
  public sbyte combineSuccess;
  public int idNPC;
  public int xS;
  public int yS;
  private int int_78;
  private int int_79;
  private int int_80;
  private int int_81;
  private int int_82;
  private int int_83;
  private int[] int_84;
  private int[] int_85;
  private int[] int_86;
  private int[] int_87;
  private int int_88;
  private int int_89;
  private int int_90;
  private int int_91;
  private int int_92;
  private bool bool_15;
  private bool bool_16;
  private bool bool_17;
  public bool isDoneCombine;
  public short iconID1;
  public short iconID2;
  public short iconID3;
  public short[] iconID;
  public string[][] speacialTabName;
  public static int[] int_93;
  public static int int_94;
  public const sbyte sbyte_8 = 0;
  public const sbyte sbyte_9 = 1;
  public const sbyte sbyte_10 = 2;
  public const sbyte sbyte_11 = 3;
  public const sbyte sbyte_12 = 4;
  public const sbyte sbyte_13 = 5;
  public const sbyte sbyte_14 = 6;
  public const sbyte sbyte_15 = 7;
  public static int[][] int_95;
  public const int int_96 = 15987701;
  public const int int_97 = 2786816;
  public const int int_98 = 7078041;
  public const int int_99 = 12537346;
  public const int int_100 = 1269146;
  public const int int_101 = 13279744;
  public const int int_102 = 11599872;
  public const int int_103 = 2039326;
  private GClass66 gclass66_13;
  private GClass66 gclass66_14;
  private GClass66 gclass66_15;
  private GClass66 gclass66_16;
  public const int int_104 = 20;
  public const sbyte sbyte_16 = 1;
  public sbyte size_tab;

  public GClass141()
  {
    string[][][] strArray1 = new string[Class15.smethod_0(33)][][];
    strArray1[Class15.smethod_0(7)] = GClass141.string_5;
    strArray1[Class15.smethod_0(5)] = GClass141.string_7;
    strArray1[Class15.smethod_0(2)] = GClass141.string_8;
    int index1 = Class15.smethod_0(38);
    string[][] strArray2 = new string[Class15.smethod_0(1)][];
    int index2 = Class15.smethod_0(0);
    string[] strArray3 = new string[Class15.smethod_0(1)];
    strArray3[Class15.smethod_0(0)] = string.Empty;
    strArray2[index2] = strArray3;
    strArray1[index1] = strArray2;
    int index3 = Class15.smethod_0(88);
    string[][] strArray4 = new string[Class15.smethod_0(1)][];
    int index4 = Class15.smethod_0(0);
    string[] strArray5 = new string[Class15.smethod_0(1)];
    strArray5[Class15.smethod_0(0)] = string.Empty;
    strArray4[index4] = strArray5;
    strArray1[index3] = strArray4;
    int index5 = Class15.smethod_0(45);
    string[][] strArray6 = new string[Class15.smethod_0(1)][];
    int index6 = Class15.smethod_0(0);
    string[] strArray7 = new string[Class15.smethod_0(1)];
    strArray7[Class15.smethod_0(0)] = string.Empty;
    strArray6[index6] = strArray7;
    strArray1[index5] = strArray6;
    int index7 = Class15.smethod_0(31);
    string[][] strArray8 = new string[Class15.smethod_0(1)][];
    int index8 = Class15.smethod_0(0);
    string[] strArray9 = new string[Class15.smethod_0(1)];
    strArray9[Class15.smethod_0(0)] = string.Empty;
    strArray8[index8] = strArray9;
    strArray1[index7] = strArray8;
    int index9 = Class15.smethod_0(67);
    string[][] strArray10 = new string[Class15.smethod_0(1)][];
    int index10 = Class15.smethod_0(0);
    string[] strArray11 = new string[Class15.smethod_0(1)];
    strArray11[Class15.smethod_0(0)] = string.Empty;
    strArray10[index10] = strArray11;
    strArray1[index9] = strArray10;
    strArray1[Class15.smethod_0(66)] = GClass141.string_6;
    strArray1[Class15.smethod_0(47)] = GClass141.string_9;
    int index11 = Class15.smethod_0(49);
    string[][] strArray12 = new string[Class15.smethod_0(1)][];
    int index12 = Class15.smethod_0(0);
    string[] strArray13 = new string[Class15.smethod_0(1)];
    strArray13[Class15.smethod_0(0)] = string.Empty;
    strArray12[index12] = strArray13;
    strArray1[index11] = strArray12;
    int index13 = Class15.smethod_0(9);
    string[][] strArray14 = new string[Class15.smethod_0(1)][];
    int index14 = Class15.smethod_0(0);
    string[] strArray15 = new string[Class15.smethod_0(1)];
    strArray15[Class15.smethod_0(0)] = string.Empty;
    strArray14[index14] = strArray15;
    strArray1[index13] = strArray14;
    int index15 = Class15.smethod_0(10);
    string[][] strArray16 = new string[Class15.smethod_0(1)][];
    int index16 = Class15.smethod_0(0);
    string[] strArray17 = new string[Class15.smethod_0(1)];
    strArray17[Class15.smethod_0(0)] = string.Empty;
    strArray16[index16] = strArray17;
    strArray1[index15] = strArray16;
    int index17 = Class15.smethod_0(186);
    string[][] strArray18 = new string[Class15.smethod_0(1)][];
    int index18 = Class15.smethod_0(0);
    string[] strArray19 = new string[Class15.smethod_0(1)];
    strArray19[Class15.smethod_0(0)] = string.Empty;
    strArray18[index18] = strArray19;
    strArray1[index17] = strArray18;
    int index19 = Class15.smethod_0(124);
    string[][] strArray20 = new string[Class15.smethod_0(1)][];
    int index20 = Class15.smethod_0(0);
    string[] strArray21 = new string[Class15.smethod_0(1)];
    strArray21[Class15.smethod_0(0)] = string.Empty;
    strArray20[index20] = strArray21;
    strArray1[index19] = strArray20;
    int index21 = Class15.smethod_0(65);
    string[][] strArray22 = new string[Class15.smethod_0(1)][];
    int index22 = Class15.smethod_0(0);
    string[] strArray23 = new string[Class15.smethod_0(1)];
    strArray23[Class15.smethod_0(0)] = string.Empty;
    strArray22[index22] = strArray23;
    strArray1[index21] = strArray22;
    int index23 = Class15.smethod_0(51);
    string[][] strArray24 = new string[Class15.smethod_0(1)][];
    int index24 = Class15.smethod_0(0);
    string[] strArray25 = new string[Class15.smethod_0(1)];
    strArray25[Class15.smethod_0(0)] = string.Empty;
    strArray24[index24] = strArray25;
    strArray1[index23] = strArray24;
    strArray1[Class15.smethod_0(27)] = GClass141.string_10;
    int index25 = Class15.smethod_0(28);
    string[][] strArray26 = new string[Class15.smethod_0(1)][];
    int index26 = Class15.smethod_0(0);
    string[] strArray27 = new string[Class15.smethod_0(1)];
    strArray27[Class15.smethod_0(0)] = string.Empty;
    strArray26[index26] = strArray27;
    strArray1[index25] = strArray26;
    int index27 = Class15.smethod_0(29);
    string[][] strArray28 = new string[Class15.smethod_0(1)][];
    int index28 = Class15.smethod_0(0);
    string[] strArray29 = new string[Class15.smethod_0(1)];
    strArray29[Class15.smethod_0(0)] = string.Empty;
    strArray28[index28] = strArray29;
    strArray1[index27] = strArray28;
    int index29 = Class15.smethod_0(40);
    string[][] strArray30 = new string[Class15.smethod_0(1)][];
    int index30 = Class15.smethod_0(0);
    string[] strArray31 = new string[Class15.smethod_0(1)];
    strArray31[Class15.smethod_0(0)] = string.Empty;
    strArray30[index30] = strArray31;
    strArray1[index29] = strArray30;
    int index31 = Class15.smethod_0(46);
    string[][] strArray32 = new string[Class15.smethod_0(1)][];
    int index32 = Class15.smethod_0(0);
    string[] strArray33 = new string[Class15.smethod_0(1)];
    strArray33[Class15.smethod_0(0)] = string.Empty;
    strArray32[index32] = strArray33;
    strArray1[index31] = strArray32;
    int index33 = Class15.smethod_0(50);
    string[][] strArray34 = new string[Class15.smethod_0(1)][];
    int index34 = Class15.smethod_0(0);
    string[] strArray35 = new string[Class15.smethod_0(1)];
    strArray35[Class15.smethod_0(0)] = string.Empty;
    strArray34[index34] = strArray35;
    strArray1[index33] = strArray34;
    this.tabName = strArray1;
    this.logChat = new GClass134();
    this.vPlayerMenu = new GClass134();
    this.vFriend = new GClass134();
    this.vMyGD = new GClass134();
    this.vFriendGD = new GClass134();
    this.vTop = new GClass134();
    this.vEnemy = new GClass134();
    this.vFlag = new GClass134();
    this.typeShop = -1;
    this.int_53 = new int[Class15.smethod_0(5)];
    this.int_56 = -1;
    this.int_57 = -1;
    this.int_58 = -1;
    this.int_59 = -1;
    this.indexMouse = -1;
    this.int_60 = -1;
    string[][] strArray36 = new string[Class15.smethod_0(7)][];
    strArray36[Class15.smethod_0(0)] = GClass109.string_264;
    strArray36[Class15.smethod_0(1)] = GClass109.string_263;
    this.clansOption = strArray36;
    this.clanInfo = string.Empty;
    this.clanReport = string.Empty;
    string[] strArray37 = new string[Class15.smethod_0(37)];
    strArray37[Class15.smethod_0(0)] = GClass109.string_16;
    strArray37[Class15.smethod_0(1)] = GClass109.string_15;
    strArray37[Class15.smethod_0(7)] = GClass109.string_14;
    strArray37[Class15.smethod_0(5)] = GClass109.string_18;
    strArray37[Class15.smethod_0(2)] = GClass109.string_436;
    strArray37[Class15.smethod_0(3)] = GClass109.string_438;
    this.string_11 = strArray37;
    byte[] byte_0 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.lDZNcPJEtfPd));
    this.int_64 = (int[]) Class15.smethod_4(byte_0);
    this.popupW = Class15.smethod_0(399);
    this.popupH = Class15.smethod_0(195);
    this.indexSize = Class15.smethod_0(35);
    this.indexRow = -1;
    this.columns = Class15.smethod_0(37);
    this.combineSuccess = (sbyte) -1;
    this.bool_16 = Class15.smethod_0(1) != 0;
    this.isDoneCombine = Class15.smethod_0(1) != 0;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.method_0();
    this.cmdClose = new GClass31(string.Empty, (GInterface0) this, Class15.smethod_0(410), (object) null);
    this.cmdClose.img = GClass62.smethod_40(Class13.smethod_0(155531));
    this.cmdClose.cmdClosePanel = Class15.smethod_0(1) != 0;
  }

  public static void smethod_0()
  {
    GClass141.gclass66_2 = GClass62.smethod_40(Class13.smethod_0(155621) + GClass185.sbyte_2.ToString() + Class13.smethod_0(155610));
    GClass141.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(155595));
    GClass141.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(155158));
    GClass141.gclass66_7 = GClass62.smethod_40(Class13.smethod_0(155256));
    GClass141.gclass66_9 = GClass62.smethod_40(Class13.smethod_0(155221));
    GClass141.gclass66_10 = GClass62.smethod_40(Class13.smethod_0(155310));
    GClass141.gclass66_11 = GClass62.smethod_40(Class13.smethod_0(147758));
    GClass141.gclass66_12 = GClass62.smethod_40(Class13.smethod_0(147729));
    GClass141.gclass66_3 = GClass62.smethod_40(Class13.smethod_0(147826));
    GClass141.gclass66_4 = GClass62.smethod_40(Class13.smethod_0(147806));
    GClass141.gclass66_5 = GClass62.smethod_40(Class13.smethod_0(147785));
    GClass141.gclass66_6 = GClass62.smethod_40(Class13.smethod_0(147892));
    GClass141.gclass66_8 = GClass62.smethod_40(Class13.smethod_0(147873));
  }

  public void method_0()
  {
    this.int_2 = GClass62.int_4 + this.cmxMap;
    this.int_3 = GClass62.int_5 + this.cmyMap;
    this.lastTabIndex = new int[this.tabName.Length];
    for (int index = Class15.smethod_0(0); index < this.lastTabIndex.Length; index += Class15.smethod_0(1))
      this.lastTabIndex[index] = -1;
  }

  public int method_1()
  {
    for (int index = Class15.smethod_0(0); index < GClass141.int_16[(int) GClass185.sbyte_2].Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass141.int_16[(int) GClass185.sbyte_2][index])
        return GClass141.int_17[(int) GClass185.sbyte_2][index];
    }
    return -1;
  }

  public int method_2()
  {
    for (int index = Class15.smethod_0(0); index < GClass141.int_16[(int) GClass185.sbyte_2].Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass141.int_16[(int) GClass185.sbyte_2][index])
        return GClass141.int_18[(int) GClass185.sbyte_2][index];
    }
    return -1;
  }

  public int method_3()
  {
    if ((GClass20.smethod_1().taskMaint == null ? 0 : 1) == 0)
      return -1;
    for (int index = Class15.smethod_0(0); index < GClass141.int_16[(int) GClass185.sbyte_2].Length; index += Class15.smethod_0(1))
    {
      if (GClass116.int_60[GClass20.smethod_1().taskMaint.index] == GClass141.int_16[(int) GClass185.sbyte_2][index])
        return GClass141.int_17[(int) GClass185.sbyte_2][index];
    }
    return -1;
  }

  public int method_4()
  {
    if ((GClass20.smethod_1().taskMaint == null ? 0 : 1) == 0)
      return -1;
    for (int index = Class15.smethod_0(0); index < GClass141.int_16[(int) GClass185.sbyte_2].Length; index += Class15.smethod_0(1))
    {
      if (GClass116.int_60[GClass20.smethod_1().taskMaint.index] == GClass141.int_16[(int) GClass185.sbyte_2][index])
        return GClass141.int_18[(int) GClass185.sbyte_2][index];
    }
    return -1;
  }

  private void method_5(int int_105)
  {
    this.typeShop = -1;
    this.W = GClass141.int_19;
    this.H = GClass62.int_11;
    this.X = Class15.smethod_0(0);
    this.Y = Class15.smethod_0(0);
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.int_20 = int_105;
    if ((int_105 == 0 ? 1 : 0) == 0)
    {
      if (int_105 == Class15.smethod_0(1))
      {
        this.wScroll = this.W - Class15.smethod_0(2);
        this.xScroll = GClass62.int_10 - this.wScroll;
        this.yScroll = Class15.smethod_0(25);
        this.hScroll = this.H - Class15.smethod_0(150);
        this.X = this.xScroll - Class15.smethod_0(7);
        this.cmx = -(GClass62.int_10 + this.W);
        this.cmtoX = GClass62.int_10 - this.W;
      }
    }
    else
    {
      this.xScroll = Class15.smethod_0(7);
      this.yScroll = Class15.smethod_0(25);
      this.wScroll = this.W - Class15.smethod_0(2);
      this.hScroll = this.H - Class15.smethod_0(150);
      this.cmx = this.wScroll;
      this.cmtoX = Class15.smethod_0(0);
      this.X = Class15.smethod_0(0);
    }
    this.TAB_W = this.W / Class15.smethod_0(3) - Class15.smethod_0(1);
    this.currentTabIndex = Class15.smethod_0(0);
    this.currentTabName = this.tabName[this.type];
    if (this.currentTabName.Length < Class15.smethod_0(3))
      this.TAB_W += Class15.smethod_0(3);
    this.startTabPos = this.xScroll + this.wScroll / Class15.smethod_0(7) - this.currentTabName.Length * this.TAB_W / Class15.smethod_0(7);
    this.int_6 = new int[this.currentTabName.Length];
    this.cmyLast = new int[this.currentTabName.Length];
    for (int index = Class15.smethod_0(0); index < this.currentTabName.Length; index += Class15.smethod_0(1))
      this.int_6[index] = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    if (this.lastTabIndex[this.type] != -1)
      this.currentTabIndex = this.lastTabIndex[this.type];
    if (this.currentTabIndex < Class15.smethod_0(0))
      this.currentTabIndex = Class15.smethod_0(0);
    if (this.currentTabIndex > this.currentTabName.Length - Class15.smethod_0(1))
      this.currentTabIndex = this.currentTabName.Length - Class15.smethod_0(1);
    this.gclass154_0 = (GClass154) null;
  }

  public void method_6()
  {
    this.type = Class15.smethod_0(49);
    this.method_5(Class15.smethod_0(0));
    this.method_78();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_7()
  {
    this.type = Class15.smethod_0(37);
    this.cmx = this.wScroll;
    this.cmtoX = Class15.smethod_0(0);
  }

  public void method_8()
  {
    if ((!GClass116.smethod_6().method_3() ? 0 : 1) != 0 || (!GClass141.bool_11 ? 1 : 0) != 0)
      return;
    if ((!GClass65.smethod_0(Class15.smethod_0(7), Class15.smethod_0(0)) ? 1 : 0) == 0)
    {
      GClass65.bool_2 = Class15.smethod_0(1) != 0;
      GClass116.gclass73_0.method_7(GClass109.string_212, Class15.smethod_0(0));
    }
    if ((!GClass65.smethod_0(Class15.smethod_0(5), Class15.smethod_0(0)) ? 1 : 0) == 0)
      GClass65.bool_4 = Class15.smethod_0(1) != 0;
    this.type = Class15.smethod_0(2);
    this.currentTabName = this.tabName[this.type];
    this.startTabPos = this.xScroll + this.wScroll / Class15.smethod_0(7) - this.currentTabName.Length * this.TAB_W / Class15.smethod_0(7);
    this.cmx = this.cmtoX = Class15.smethod_0(0);
    this.method_83();
  }

  public void method_9()
  {
    this.currentListLength = GClass20.smethod_1().arrArchive.Length;
    this.method_5(Class15.smethod_0(0));
    this.type = Class15.smethod_0(45);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public void method_10()
  {
    this.type = Class15.smethod_0(186);
    this.method_5(Class15.smethod_0(1));
    this.method_11();
    this.typeShop = Class15.smethod_0(7);
    this.currentTabIndex = Class15.smethod_0(0);
  }

  public void method_11()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = GClass20.smethod_1().arrItemShop[Class15.smethod_0(2)].Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public void method_12()
  {
    this.type = Class15.smethod_0(38);
    this.method_5(Class15.smethod_0(1));
    this.method_82();
    this.currentTabIndex = Class15.smethod_0(0);
  }

  public void method_13(GClass72 info)
  {
    this.logChat.method_10((object) info, Class15.smethod_0(0));
    if (this.logChat.method_2() <= Class15.smethod_0(51))
      return;
    this.logChat.method_7(this.logChat.method_2() - Class15.smethod_0(1));
  }

  public void method_14(GClass31 pm) => this.vPlayerMenu.method_0((object) pm);

  public void method_15()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = this.vPlayerMenu.method_2();
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public void method_16()
  {
    this.type = Class15.smethod_0(124);
    this.method_5(Class15.smethod_0(0));
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.method_17();
  }

  public void method_17()
  {
    this.currentListLength = this.vFlag.method_2();
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    if (this.selected > this.currentListLength - Class15.smethod_0(1))
      this.selected = this.currentListLength - Class15.smethod_0(1);
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_18(GClass20 c)
  {
    this.type = Class15.smethod_0(31);
    this.method_5(Class15.smethod_0(0));
    this.method_15();
    this.charMenu = c;
  }

  public void method_19()
  {
    this.type = Class15.smethod_0(67);
    this.method_5(Class15.smethod_0(0));
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.method_23();
  }

  public void method_20()
  {
    this.type = Class15.smethod_0(10);
    this.method_5(Class15.smethod_0(0));
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.method_24();
  }

  public void method_21(sbyte t)
  {
    this.type = Class15.smethod_0(9);
    this.method_5(Class15.smethod_0(0));
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.method_22();
    this.bool_2 = (t == (sbyte) 0 ? 0 : 1) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public void method_22()
  {
    this.currentListLength = this.vTop.method_2();
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    if (this.selected > this.currentListLength - Class15.smethod_0(1))
      this.selected = this.currentListLength - Class15.smethod_0(1);
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_23()
  {
    this.currentListLength = this.vFriend.method_2();
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    if (this.selected > this.currentListLength - Class15.smethod_0(1))
      this.selected = this.currentListLength - Class15.smethod_0(1);
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_24()
  {
    this.currentListLength = this.vEnemy.method_2();
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    if (this.selected > this.currentListLength - Class15.smethod_0(1))
      this.selected = this.currentListLength - Class15.smethod_0(1);
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_25()
  {
    this.type = Class15.smethod_0(88);
    this.method_5(Class15.smethod_0(0));
    this.method_75();
    this.currentTabIndex = Class15.smethod_0(0);
  }

  public void method_26()
  {
    this.type = Class15.smethod_0(88);
    this.method_5(Class15.smethod_0(0));
    this.method_75();
    this.currentTabIndex = Class15.smethod_0(0);
  }

  public void method_27(int typeShop)
  {
    this.type = Class15.smethod_0(1);
    this.method_5(Class15.smethod_0(0));
    this.method_76();
    this.currentTabIndex = Class15.smethod_0(0);
    this.typeShop = typeShop;
  }

  public void method_28()
  {
    this.type = Class15.smethod_0(7);
    if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
    {
      string[][] strArray = new string[Class15.smethod_0(1)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_197;
      GClass141.string_5 = strArray;
    }
    else
    {
      string[][] strArray = new string[Class15.smethod_0(7)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_197;
      strArray[Class15.smethod_0(1)] = GClass109.string_198;
      GClass141.string_5 = strArray;
    }
    this.tabName[Class15.smethod_0(7)] = GClass141.string_5;
    this.method_5(Class15.smethod_0(0));
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
      this.method_80();
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_82();
    if (GClass62.int_10 <= Class15.smethod_0(7) * GClass141.int_19)
      return;
    GClass62.gclass141_1 = new GClass141();
    string[][][] tabName = GClass62.gclass141_1.tabName;
    int index1 = Class15.smethod_0(38);
    string[][] strArray1 = new string[Class15.smethod_0(1)][];
    int index2 = Class15.smethod_0(0);
    string[] strArray2 = new string[Class15.smethod_0(1)];
    strArray2[Class15.smethod_0(0)] = string.Empty;
    strArray1[index2] = strArray2;
    tabName[index1] = strArray1;
    GClass62.gclass141_1.method_12();
    GClass62.gclass141_1.method_44();
  }

  public void method_29()
  {
    this.type = Class15.smethod_0(66);
    if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
    {
      string[][] strArray = new string[Class15.smethod_0(1)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_199;
      GClass141.string_6 = strArray;
    }
    else
    {
      string[][] strArray = new string[Class15.smethod_0(7)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_199;
      strArray[Class15.smethod_0(1)] = GClass109.string_198;
      GClass141.string_6 = strArray;
    }
    this.tabName[this.type] = GClass141.string_6;
    this.method_5(Class15.smethod_0(0));
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
      this.method_30();
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_82();
    if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
    {
      GClass62.gclass141_1 = new GClass141();
      string[][][] tabName = GClass62.gclass141_1.tabName;
      int index1 = Class15.smethod_0(38);
      string[][] strArray1 = new string[Class15.smethod_0(1)][];
      int index2 = Class15.smethod_0(0);
      string[] strArray2 = new string[Class15.smethod_0(1)];
      strArray2[Class15.smethod_0(0)] = string.Empty;
      strArray1[index2] = strArray2;
      tabName[index1] = strArray1;
      GClass62.gclass141_1.method_12();
      GClass62.gclass141_1.method_44();
    }
    this.combineSuccess = (sbyte) -1;
    this.isDoneCombine = Class15.smethod_0(1) != 0;
  }

  public void method_30()
  {
    this.currentListLength = this.vItemCombine.method_2() + Class15.smethod_0(1);
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(45);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public void method_31()
  {
    this.type = Class15.smethod_0(28);
    this.method_5(Class15.smethod_0(0));
    this.method_32();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  private void method_32()
  {
    this.currentListLength = GClass141.string_4.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  public void method_33()
  {
    this.type = Class15.smethod_0(27);
    GClass141.string_10 = (GClass62.gclass141_1 == null ? 1 : 0) != 0 ? GClass109.string_104 : GClass109.string_105;
    this.tabName[Class15.smethod_0(27)] = GClass141.string_10;
    if (GClass20.smethod_1().cgender == Class15.smethod_0(1))
    {
      string[] strArray = new string[Class15.smethod_0(37)];
      strArray[Class15.smethod_0(0)] = GClass109.string_16;
      strArray[Class15.smethod_0(1)] = GClass109.string_15;
      strArray[Class15.smethod_0(7)] = GClass109.string_14;
      strArray[Class15.smethod_0(5)] = GClass109.string_18;
      strArray[Class15.smethod_0(2)] = GClass109.string_436;
      strArray[Class15.smethod_0(3)] = GClass109.string_438;
      this.string_11 = strArray;
    }
    else
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = GClass109.string_16;
      strArray[Class15.smethod_0(1)] = GClass109.string_15;
      strArray[Class15.smethod_0(7)] = GClass109.string_14;
      strArray[Class15.smethod_0(5)] = GClass109.string_18;
      strArray[Class15.smethod_0(2)] = GClass109.string_436;
      this.string_11 = strArray;
    }
    this.method_5(Class15.smethod_0(7));
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
      this.method_81();
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_69();
    if (this.currentTabIndex != Class15.smethod_0(7))
      return;
    this.method_82();
  }

  public void method_34()
  {
    this.type = Class15.smethod_0(0);
    this.method_5(Class15.smethod_0(0));
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_82();
    if (this.currentTabIndex == Class15.smethod_0(7))
      this.method_77();
    if (this.currentTabIndex == Class15.smethod_0(5))
    {
      if (this.mainTabName.Length == Class15.smethod_0(2))
        this.method_71();
      else
        this.method_73();
    }
    if (this.currentTabIndex != Class15.smethod_0(2))
      return;
    this.method_71();
  }

  public void method_35()
  {
    this.type = Class15.smethod_0(5);
    this.method_5(Class15.smethod_0(0));
    this.method_79();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  public void method_36(GClass80 item)
  {
    try
    {
      this.cp = new GClass43();
      string empty = string.Empty;
      string str1 = string.Empty;
      if ((int) item.template.gender != GClass20.smethod_1().cgender)
      {
        if ((item.template.gender == (sbyte) 0 ? 0 : 1) == 0)
          str1 = str1 + Class13.smethod_0(147844) + GClass109.string_213;
        else if ((int) item.template.gender == Class15.smethod_0(1))
          str1 = str1 + Class13.smethod_0(147844) + GClass109.string_214;
        else if ((int) item.template.gender == Class15.smethod_0(7))
          str1 = str1 + Class13.smethod_0(147844) + GClass109.string_215;
      }
      string str2 = string.Empty;
      if ((item.itemOption == null ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < item.itemOption.Length; index += Class15.smethod_0(1))
        {
          if (item.itemOption[index].optionTemplate.id == Class15.smethod_0(107))
            str2 = Class13.smethod_0(148414) + item.itemOption[index].param.ToString() + Class13.smethod_0(148397);
        }
      }
      bool flag = Class15.smethod_0(0) != 0;
      if ((item.itemOption == null ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < item.itemOption.Length; index += Class15.smethod_0(1))
        {
          if (item.itemOption[index].optionTemplate.id == Class15.smethod_0(55))
          {
            flag = Class15.smethod_0(1) != 0;
            if (item.itemOption[index].param == Class15.smethod_0(1))
              str1 = str1 + Class13.smethod_0(149534) + item.template.name + str2;
            if (item.itemOption[index].param == Class15.smethod_0(7))
              str1 = str1 + Class13.smethod_0(149513) + item.template.name + str2;
            if (item.itemOption[index].param == Class15.smethod_0(5))
              str1 = str1 + Class13.smethod_0(149507) + item.template.name + str2;
            if (item.itemOption[index].param == Class15.smethod_0(2))
              str1 = str1 + Class13.smethod_0(149629) + item.template.name + str2;
          }
        }
      }
      if ((!flag ? 0 : 1) == 0)
        str1 = str1 + Class13.smethod_0(149534) + item.template.name + str2;
      if ((item.itemOption == null ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < item.itemOption.Length; index += Class15.smethod_0(1))
        {
          if ((((!item.itemOption[index].optionTemplate.name.StartsWith(Class13.smethod_0(149612)) ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0)) == 0 ? 1 : 0) == 0)
          {
            string str3 = item.itemOption[index].method_2();
            if (item.itemOption[index].param == Class15.smethod_0(1))
              str1 = str1 + Class13.smethod_0(149610) + str3;
            if ((item.itemOption[index].param == 0 ? 0 : 1) == 0)
              str1 = str1 + Class13.smethod_0(149603) + str3;
          }
          else
          {
            string str4 = item.itemOption[index].method_0();
            if ((!str4.Equals(string.Empty) ? 0 : 1) == 0 && item.itemOption[index].optionTemplate.id != Class15.smethod_0(107))
            {
              if (item.itemOption[index].optionTemplate.id == Class15.smethod_0(68))
              {
                this.cp.starSlot = (sbyte) item.itemOption[index].param;
                GClass151.smethod_7(Class13.smethod_0(149584) + this.cp.starSlot.ToString());
              }
              else if (item.itemOption[index].optionTemplate.id == Class15.smethod_0(12))
              {
                this.cp.maxStarSlot = (sbyte) item.itemOption[index].param;
                GClass151.smethod_7(Class13.smethod_0(149584) + this.cp.maxStarSlot.ToString());
              }
              else
                str1 = str1 + Class13.smethod_0(149610) + str4;
            }
          }
        }
      }
      string str5;
      if (this.currItem.template.strRequire > Class15.smethod_0(1))
      {
        string str6 = GClass109.string_217 + Class13.smethod_0(149572) + this.currItem.template.strRequire.ToString();
        if ((long) this.currItem.template.strRequire > GClass20.smethod_1().cPower)
        {
          string str7 = str1 + Class13.smethod_0(149693) + str6;
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = str7;
          strArray[Class15.smethod_0(1)] = Class13.smethod_0(149693);
          strArray[Class15.smethod_0(7)] = GClass109.string_218;
          strArray[Class15.smethod_0(5)] = Class13.smethod_0(149572);
          strArray[Class15.smethod_0(2)] = GClass20.smethod_1().cPower.ToString();
          str5 = string.Concat(strArray);
        }
        else
          str5 = str1 + Class13.smethod_0(149677) + str6;
      }
      else
        str5 = str1 + Class13.smethod_0(149677);
      this.currItem.compare = this.method_124(this.currItem);
      string chat = str5 + Class13.smethod_0(150137) + Class13.smethod_0(150133) + item.template.description;
      if ((!item.reason.Equals(string.Empty) ? 0 : 1) == 0)
      {
        if ((!item.template.description.Equals(string.Empty) ? 0 : 1) == 0)
          chat += Class13.smethod_0(150137);
        chat = chat + Class13.smethod_0(150085) + item.reason;
      }
      if ((int) this.cp.maxStarSlot > Class15.smethod_0(0))
        chat += Class13.smethod_0(150080);
      this.method_37(this.cp, chat);
      this.idIcon = (int) item.template.iconID;
      this.partID = (int[]) null;
      this.charInfo = (GClass20) null;
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(150199) + ex.StackTrace);
    }
  }

  public void method_37(GClass43 cp, string chat)
  {
    cp.isClip = Class15.smethod_0(0) != 0;
    cp.sayWidth = Class15.smethod_0(96);
    cp.cx = Class15.smethod_0(5) + this.X - ((this.X == 0 ? 0 : 1) != 0 ? GClass151.smethod_25(cp.sayWidth - this.W) + Class15.smethod_0(88) : Class15.smethod_0(0));
    cp.says = GClass97.gclass97_17.method_15(chat, cp.sayWidth - Class15.smethod_0(31));
    cp.delay = Class15.smethod_0(261);
    cp.c = (GClass21) null;
    cp.sayRun = Class15.smethod_0(38);
    cp.ch = Class15.smethod_0(9) - cp.sayRun + cp.says.Length * Class15.smethod_0(66) + Class15.smethod_0(31);
    if (cp.ch > GClass62.int_11 - Class15.smethod_0(25))
    {
      cp.ch = GClass62.int_11 - Class15.smethod_0(25);
      cp.lim = cp.says.Length * Class15.smethod_0(66) - cp.ch + Class15.smethod_0(186);
      if (cp.lim < Class15.smethod_0(0))
        cp.lim = Class15.smethod_0(0);
      GClass43.int_7 = Class15.smethod_0(0);
      cp.isClip = Class15.smethod_0(1) != 0;
    }
    cp.cy = GClass62.gclass95_0.menuY - cp.ch;
    while (cp.cy < Class15.smethod_0(31))
    {
      cp.cy += Class15.smethod_0(1);
      GClass62.gclass95_0.menuY += Class15.smethod_0(1);
    }
    cp.mH = Class15.smethod_0(0);
    cp.strY = Class15.smethod_0(31);
  }

  public void method_38(GClass43 cp, string[] chat)
  {
    cp.sayWidth = Class15.smethod_0(195);
    cp.cx = Class15.smethod_0(5) + this.X;
    cp.says = chat;
    cp.delay = Class15.smethod_0(261);
    cp.c = (GClass21) null;
    cp.sayRun = Class15.smethod_0(38);
    cp.ch = Class15.smethod_0(9) - cp.sayRun + cp.says.Length * Class15.smethod_0(66) + Class15.smethod_0(31);
    cp.cy = GClass62.gclass95_0.menuY - cp.ch;
    cp.mH = Class15.smethod_0(0);
    cp.strY = Class15.smethod_0(31);
  }

  public void method_39(GClass28 cm)
  {
    this.cp = new GClass43();
    string str1 = Class13.smethod_0(150570) + cm.playerName + Class13.smethod_0(150540) + GClass94.smethod_0((int) cm.role);
    for (int index = Class15.smethod_0(0); index < this.myMember.method_2(); index += Class15.smethod_0(1))
    {
      GClass94 gclass94 = (GClass94) this.myMember.method_3(index);
      if (cm.playerId == gclass94.ID)
      {
        string str2 = str1;
        string[] strArray1 = new string[Class15.smethod_0(3)];
        strArray1[Class15.smethod_0(0)] = str2;
        strArray1[Class15.smethod_0(1)] = Class13.smethod_0(150650);
        strArray1[Class15.smethod_0(7)] = GClass109.string_246;
        strArray1[Class15.smethod_0(5)] = Class13.smethod_0(150645);
        strArray1[Class15.smethod_0(2)] = gclass94.clanPoint.ToString();
        string str3 = string.Concat(strArray1);
        string[] strArray2 = new string[Class15.smethod_0(3)];
        strArray2[Class15.smethod_0(0)] = str3;
        strArray2[Class15.smethod_0(1)] = Class13.smethod_0(150650);
        strArray2[Class15.smethod_0(7)] = GClass109.string_247;
        strArray2[Class15.smethod_0(5)] = Class13.smethod_0(150645);
        strArray2[Class15.smethod_0(2)] = gclass94.curClanPoint.ToString();
        string str4 = string.Concat(strArray2);
        string[] strArray3 = new string[Class15.smethod_0(37)];
        strArray3[Class15.smethod_0(0)] = str4;
        strArray3[Class15.smethod_0(1)] = Class13.smethod_0(150642);
        strArray3[Class15.smethod_0(7)] = GClass109.string_249;
        strArray3[Class15.smethod_0(5)] = Class13.smethod_0(150645);
        strArray3[Class15.smethod_0(2)] = gclass94.donate.ToString();
        strArray3[Class15.smethod_0(3)] = GClass109.string_252;
        string str5 = string.Concat(strArray3);
        string[] strArray4 = new string[Class15.smethod_0(37)];
        strArray4[Class15.smethod_0(0)] = str5;
        strArray4[Class15.smethod_0(1)] = Class13.smethod_0(150642);
        strArray4[Class15.smethod_0(7)] = GClass109.string_250;
        strArray4[Class15.smethod_0(5)] = Class13.smethod_0(150645);
        strArray4[Class15.smethod_0(2)] = gclass94.receive_donate.ToString();
        strArray4[Class15.smethod_0(3)] = GClass109.string_252;
        str1 = string.Concat(strArray4);
        int[] numArray = new int[Class15.smethod_0(5)];
        numArray[Class15.smethod_0(0)] = (int) gclass94.head;
        numArray[Class15.smethod_0(1)] = (int) gclass94.leg;
        numArray[Class15.smethod_0(7)] = (int) gclass94.body;
        this.partID = numArray;
        break;
      }
    }
    string chat = str1 + Class13.smethod_0(150637);
    for (int index = Class15.smethod_0(0); index < cm.chat.Length; index += Class15.smethod_0(1))
      chat = chat + Class13.smethod_0(143724) + cm.chat[index];
    if (cm.type == Class15.smethod_0(1))
    {
      string str6 = chat;
      string[] strArray = new string[Class15.smethod_0(38)];
      strArray[Class15.smethod_0(0)] = str6;
      strArray[Class15.smethod_0(1)] = Class13.smethod_0(143718);
      strArray[Class15.smethod_0(7)] = GClass109.string_253;
      strArray[Class15.smethod_0(5)] = Class13.smethod_0(143766);
      strArray[Class15.smethod_0(2)] = cm.recieve.ToString();
      strArray[Class15.smethod_0(3)] = Class13.smethod_0(143751);
      strArray[Class15.smethod_0(37)] = cm.maxCap.ToString();
      chat = string.Concat(strArray);
    }
    this.method_37(this.cp, chat);
    this.charInfo = (GClass20) null;
  }

  public void method_40(GClass187 t)
  {
    string chat = Class13.smethod_0(143861) + t.name + Class13.smethod_0(143851) + t.rank.ToString() + Class13.smethod_0(143823) + t.info + Class13.smethod_0(143593) + t.info2;
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
    int[] numArray = new int[Class15.smethod_0(5)];
    numArray[Class15.smethod_0(0)] = t.headID;
    numArray[Class15.smethod_0(1)] = (int) t.leg;
    numArray[Class15.smethod_0(7)] = (int) t.body;
    this.partID = numArray;
    this.currItem = (GClass80) null;
    this.charInfo = (GClass20) null;
  }

  public void method_41(GClass94 m)
  {
    string str1 = Class13.smethod_0(143556) + m.name;
    string str2 = Class13.smethod_0(144237);
    if ((m.role == (sbyte) 0 ? 0 : 1) == 0)
      str2 = Class13.smethod_0(144230);
    if ((int) m.role == Class15.smethod_0(1))
      str2 = Class13.smethod_0(144223);
    if ((int) m.role == Class15.smethod_0(7))
      str2 = Class13.smethod_0(144216);
    string str3 = str1 + str2 + GClass94.smethod_0((int) m.role);
    string[] strArray1 = new string[Class15.smethod_0(3)];
    strArray1[Class15.smethod_0(0)] = str3;
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(144237);
    strArray1[Class15.smethod_0(7)] = GClass109.string_254;
    strArray1[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray1[Class15.smethod_0(2)] = m.powerPoint;
    string str4 = string.Concat(strArray1) + Class13.smethod_0(144206);
    string[] strArray2 = new string[Class15.smethod_0(3)];
    strArray2[Class15.smethod_0(0)] = str4;
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(144202);
    strArray2[Class15.smethod_0(7)] = GClass109.string_246;
    strArray2[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray2[Class15.smethod_0(2)] = m.clanPoint.ToString();
    string str5 = string.Concat(strArray2);
    string[] strArray3 = new string[Class15.smethod_0(3)];
    strArray3[Class15.smethod_0(0)] = str5;
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(144202);
    strArray3[Class15.smethod_0(7)] = GClass109.string_247;
    strArray3[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray3[Class15.smethod_0(2)] = m.curClanPoint.ToString();
    string str6 = string.Concat(strArray3);
    string[] strArray4 = new string[Class15.smethod_0(37)];
    strArray4[Class15.smethod_0(0)] = str6;
    strArray4[Class15.smethod_0(1)] = Class13.smethod_0(144197);
    strArray4[Class15.smethod_0(7)] = GClass109.string_249;
    strArray4[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray4[Class15.smethod_0(2)] = m.donate.ToString();
    strArray4[Class15.smethod_0(3)] = GClass109.string_252;
    string str7 = string.Concat(strArray4);
    string[] strArray5 = new string[Class15.smethod_0(37)];
    strArray5[Class15.smethod_0(0)] = str7;
    strArray5[Class15.smethod_0(1)] = Class13.smethod_0(144197);
    strArray5[Class15.smethod_0(7)] = GClass109.string_250;
    strArray5[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray5[Class15.smethod_0(2)] = m.receive_donate.ToString();
    strArray5[Class15.smethod_0(3)] = GClass109.string_252;
    string str8 = string.Concat(strArray5);
    string[] strArray6 = new string[Class15.smethod_0(3)];
    strArray6[Class15.smethod_0(0)] = str8;
    strArray6[Class15.smethod_0(1)] = Class13.smethod_0(144192);
    strArray6[Class15.smethod_0(7)] = GClass109.string_255;
    strArray6[Class15.smethod_0(5)] = Class13.smethod_0(144209);
    strArray6[Class15.smethod_0(2)] = m.joinTime;
    string chat = string.Concat(strArray6);
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
    int[] numArray = new int[Class15.smethod_0(5)];
    numArray[Class15.smethod_0(0)] = (int) m.head;
    numArray[Class15.smethod_0(1)] = (int) m.leg;
    numArray[Class15.smethod_0(7)] = (int) m.body;
    this.partID = numArray;
    this.currItem = (GClass80) null;
    this.charInfo = (GClass20) null;
  }

  public void method_42(GClass25 cl)
  {
    try
    {
      string str1 = Class13.smethod_0(144299) + cl.name;
      string[] strArray1 = GClass97.gclass97_19.method_15(cl.slogan, this.wScroll - Class15.smethod_0(4));
      for (int index = Class15.smethod_0(0); index < strArray1.Length; index += Class15.smethod_0(1))
        str1 = str1 + Class13.smethod_0(144277) + strArray1[index];
      string str2 = str1 + Class13.smethod_0(144380);
      string[] strArray2 = new string[Class15.smethod_0(3)];
      strArray2[Class15.smethod_0(0)] = str2;
      strArray2[Class15.smethod_0(1)] = Class13.smethod_0(144376);
      strArray2[Class15.smethod_0(7)] = GClass109.string_256;
      strArray2[Class15.smethod_0(5)] = Class13.smethod_0(144365);
      strArray2[Class15.smethod_0(2)] = cl.leaderName;
      string str3 = string.Concat(strArray2);
      string[] strArray3 = new string[Class15.smethod_0(3)];
      strArray3[Class15.smethod_0(0)] = str3;
      strArray3[Class15.smethod_0(1)] = Class13.smethod_0(144362);
      strArray3[Class15.smethod_0(7)] = GClass109.string_258;
      strArray3[Class15.smethod_0(5)] = Class13.smethod_0(144365);
      strArray3[Class15.smethod_0(2)] = cl.powerPoint;
      string str4 = string.Concat(strArray3);
      string[] strArray4 = new string[Class15.smethod_0(38)];
      strArray4[Class15.smethod_0(0)] = str4;
      strArray4[Class15.smethod_0(1)] = Class13.smethod_0(144357);
      strArray4[Class15.smethod_0(7)] = GClass109.string_259;
      strArray4[Class15.smethod_0(5)] = Class13.smethod_0(144365);
      strArray4[Class15.smethod_0(2)] = cl.currMember.ToString();
      strArray4[Class15.smethod_0(3)] = Class13.smethod_0(144352);
      strArray4[Class15.smethod_0(37)] = cl.maxMember.ToString();
      string str5 = string.Concat(strArray4);
      string[] strArray5 = new string[Class15.smethod_0(3)];
      strArray5[Class15.smethod_0(0)] = str5;
      strArray5[Class15.smethod_0(1)] = Class13.smethod_0(144357);
      strArray5[Class15.smethod_0(7)] = GClass109.string_268;
      strArray5[Class15.smethod_0(5)] = Class13.smethod_0(144365);
      strArray5[Class15.smethod_0(2)] = cl.level.ToString();
      string str6 = string.Concat(strArray5);
      string[] strArray6 = new string[Class15.smethod_0(3)];
      strArray6[Class15.smethod_0(0)] = str6;
      strArray6[Class15.smethod_0(1)] = Class13.smethod_0(144357);
      strArray6[Class15.smethod_0(7)] = GClass109.string_269;
      strArray6[Class15.smethod_0(5)] = Class13.smethod_0(144365);
      strArray6[Class15.smethod_0(2)] = GClass138.smethod_6(cl.date);
      string chat = string.Concat(strArray6);
      this.cp = new GClass43();
      this.method_37(this.cp, chat);
      this.idIcon = (int) GClass26.smethod_1((short) cl.imgID).idImage[Class15.smethod_0(0)];
      this.currItem = (GClass80) null;
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(144350) + ex.StackTrace);
    }
  }

  public void method_43(GClass167 tp, GClass161 skill, GClass161 nextSkill)
  {
    string str1 = Class13.smethod_0(143906) + tp.name;
    for (int index = Class15.smethod_0(0); index < tp.description.Length; index += Class15.smethod_0(1))
      str1 = str1 + Class13.smethod_0(144932) + tp.description[index];
    string str2 = str1 + Class13.smethod_0(144927);
    string chat;
    if ((skill == null ? 1 : 0) == 0)
    {
      string str3 = str2;
      string[] strArray1 = new string[Class15.smethod_0(3)];
      strArray1[Class15.smethod_0(0)] = str3;
      strArray1[Class15.smethod_0(1)] = Class13.smethod_0(144923);
      strArray1[Class15.smethod_0(7)] = GClass109.string_375;
      strArray1[Class15.smethod_0(5)] = Class13.smethod_0(144918);
      strArray1[Class15.smethod_0(2)] = skill.point.ToString();
      string str4 = string.Concat(strArray1) + Class13.smethod_0(144915) + GClass138.smethod_4(tp.damInfo, Class13.smethod_0(144910), skill.damage.ToString() + string.Empty);
      string[] strArray2 = new string[Class15.smethod_0(3)];
      strArray2[Class15.smethod_0(0)] = str4;
      strArray2[Class15.smethod_0(1)] = Class13.smethod_0(144915);
      strArray2[Class15.smethod_0(7)] = GClass109.string_376;
      strArray2[Class15.smethod_0(5)] = skill.manaUse.ToString();
      strArray2[Class15.smethod_0(2)] = tp.manaUseType != Class15.smethod_0(1) ? string.Empty : Class13.smethod_0(144908);
      string str5 = string.Concat(strArray2);
      string[] strArray3 = new string[Class15.smethod_0(37)];
      strArray3[Class15.smethod_0(0)] = str5;
      strArray3[Class15.smethod_0(1)] = Class13.smethod_0(144915);
      strArray3[Class15.smethod_0(7)] = GClass109.string_377;
      strArray3[Class15.smethod_0(5)] = Class13.smethod_0(144918);
      strArray3[Class15.smethod_0(2)] = skill.coolDown.ToString();
      strArray3[Class15.smethod_0(3)] = GClass109.string_378;
      string str6 = string.Concat(strArray3) + Class13.smethod_0(144927);
      if (skill.point == tp.maxPoint)
      {
        chat = str6 + Class13.smethod_0(144906) + GClass109.string_379;
      }
      else
      {
        string str7 = str6;
        string[] strArray4 = new string[Class15.smethod_0(37)];
        strArray4[Class15.smethod_0(0)] = str7;
        strArray4[Class15.smethod_0(1)] = Class13.smethod_0(144901);
        strArray4[Class15.smethod_0(7)] = GClass109.string_380;
        strArray4[Class15.smethod_0(5)] = GClass151.smethod_28(nextSkill.powRequire);
        strArray4[Class15.smethod_0(2)] = Class13.smethod_0(147229);
        strArray4[Class15.smethod_0(3)] = GClass109.string_381;
        chat = string.Concat(strArray4) + Class13.smethod_0(144932) + GClass138.smethod_4(tp.damInfo, Class13.smethod_0(144910), nextSkill.damage.ToString() + string.Empty);
      }
    }
    else
    {
      string str8 = str2 + Class13.smethod_0(144923) + GClass109.string_382;
      string[] strArray5 = new string[Class15.smethod_0(37)];
      strArray5[Class15.smethod_0(0)] = str8;
      strArray5[Class15.smethod_0(1)] = Class13.smethod_0(144901);
      strArray5[Class15.smethod_0(7)] = GClass109.string_383;
      strArray5[Class15.smethod_0(5)] = GClass151.smethod_28(nextSkill.powRequire);
      strArray5[Class15.smethod_0(2)] = Class13.smethod_0(147229);
      strArray5[Class15.smethod_0(3)] = GClass109.string_381;
      string str9 = string.Concat(strArray5) + Class13.smethod_0(144932) + GClass138.smethod_4(tp.damInfo, Class13.smethod_0(144910), nextSkill.damage.ToString() + string.Empty);
      string[] strArray6 = new string[Class15.smethod_0(3)];
      strArray6[Class15.smethod_0(0)] = str9;
      strArray6[Class15.smethod_0(1)] = Class13.smethod_0(144932);
      strArray6[Class15.smethod_0(7)] = GClass109.string_376;
      strArray6[Class15.smethod_0(5)] = nextSkill.manaUse.ToString();
      strArray6[Class15.smethod_0(2)] = tp.manaUseType != Class15.smethod_0(1) ? string.Empty : Class13.smethod_0(144908);
      string str10 = string.Concat(strArray6);
      string[] strArray7 = new string[Class15.smethod_0(37)];
      strArray7[Class15.smethod_0(0)] = str10;
      strArray7[Class15.smethod_0(1)] = Class13.smethod_0(144932);
      strArray7[Class15.smethod_0(7)] = GClass109.string_377;
      strArray7[Class15.smethod_0(5)] = Class13.smethod_0(144918);
      strArray7[Class15.smethod_0(2)] = nextSkill.coolDown.ToString();
      strArray7[Class15.smethod_0(3)] = GClass109.string_378;
      chat = string.Concat(strArray7);
    }
    this.currItem = (GClass80) null;
    this.partID = (int[]) null;
    this.charInfo = (GClass20) null;
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
    this.idIcon = Class15.smethod_0(0);
  }

  public void method_44()
  {
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.cmdClose.x = Class15.smethod_0(156);
      this.cmdClose.y = Class15.smethod_0(5);
    }
    else
    {
      this.cmdClose.x = GClass62.int_10 - Class15.smethod_0(65);
      this.cmdClose.y = GClass62.int_11 - Class15.smethod_0(65);
    }
    this.cmdClose.isPlaySoundButton = Class15.smethod_0(0) != 0;
    GClass43.gclass43_0 = (GClass43) null;
    GClass71.smethod_5();
    this.int_21 = Class15.smethod_0(51);
    this.isShow = Class15.smethod_0(1) != 0;
    this.isClose = Class15.smethod_0(0) != 0;
    GClass172.smethod_1().method_33();
    if ((!this.method_202() ? 1 : 0) != 0)
      return;
    GClass20.smethod_1().method_132();
  }

  public void method_45()
  {
    if ((this.chatTField == null ? 1 : 0) != 0 || (!this.chatTField.isShow ? 1 : 0) != 0)
      return;
    if ((this.chatTField.left == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.chatTField.left) ? 1 : 0) == 0) && (this.chatTField.left == null ? 1 : 0) == 0)
      this.chatTField.left.method_1();
    if ((this.chatTField.right == null ? 1 : 0) == 0 && ((!GClass62.bool_11[Class15.smethod_0(47)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.chatTField.right) ? 1 : 0) == 0) && (this.chatTField.right == null ? 1 : 0) == 0)
      this.chatTField.right.method_1();
    if ((this.chatTField.center == null ? 1 : 0) == 0 && ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 0 : 1) != 0 || (!GClass113.smethod_1(this.chatTField.center) ? 1 : 0) == 0) && (this.chatTField.center == null ? 1 : 0) == 0)
      this.chatTField.center.method_1();
    if ((!this.chatTField.isShow ? 1 : 0) == 0 && (GClass62.int_65 == 0 ? 1 : 0) == 0)
    {
      this.chatTField.method_2(GClass62.int_65);
      GClass62.int_65 = Class15.smethod_0(0);
    }
    GClass62.smethod_25();
    GClass62.smethod_24();
  }

  public void method_46()
  {
    if ((this.chatTField == null ? 1 : 0) == 0 && (!this.chatTField.isShow ? 0 : 1) != 0 || (!GClass62.gclass141_0.isDoneCombine ? 1 : 0) != 0 || (!GClass71.bool_0 ? 1 : 0) == 0)
      return;
    if ((this.tabIcon == null ? 1 : 0) == 0 && (!this.tabIcon.isShow ? 1 : 0) == 0)
    {
      this.tabIcon.method_8();
    }
    else
    {
      if ((!this.isClose ? 0 : 1) != 0 || (!this.isShow ? 0 : 1) == 0)
        return;
      if ((!this.cmdClose.method_4() ? 1 : 0) == 0)
      {
        this.cmdClose.method_1();
      }
      else
      {
        if ((!GClass62.bool_11[Class15.smethod_0(47)] ? 1 : 0) == 0)
        {
          if (this.type != Class15.smethod_0(2))
          {
            this.method_141();
            return;
          }
          this.method_34();
          this.cmx = this.cmtoX = Class15.smethod_0(0);
        }
        if ((!GClass62.bool_11[Class15.smethod_0(66)] ? 0 : 1) != 0 || (!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 1 : 0) == 0)
        {
          if (this.gclass31_0.idAction > Class15.smethod_0(0))
            this.imethod_0(this.gclass31_0.idAction, this.gclass31_0.p);
          else
            this.int_54 = Class15.smethod_0(7);
        }
        if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0 && (GClass62.gclass141_1 == null ? 0 : 1) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0 && (!GClass62.smethod_45(this.X, this.Y, this.W, this.H) ? 0 : 1) == 0 && (!this.bool_4 ? 0 : 1) == 0)
        {
          this.method_141();
        }
        else
        {
          if ((!this.bool_3 ? 0 : 1) == 0)
            this.method_68();
          switch (this.type)
          {
            case 0:
              if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
              {
                this.method_60();
                GClass62.smethod_24();
                return;
              }
              if (this.currentTabIndex == Class15.smethod_0(1))
                this.method_208();
              if (this.currentTabIndex == Class15.smethod_0(7))
                this.method_53();
              if (this.currentTabIndex == Class15.smethod_0(5))
              {
                if (this.mainTabName.Length == Class15.smethod_0(2))
                  this.method_52();
                else
                  this.method_63();
              }
              if (this.currentTabIndex == Class15.smethod_0(2))
              {
                this.method_52();
                break;
              }
              break;
            case 1:
            case 17:
            case 25:
              if (this.currentTabIndex < this.currentTabName.Length - ((GClass62.gclass141_1 == null ? 1 : 0) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0)) && this.type != Class15.smethod_0(186))
              {
                this.method_66();
                break;
              }
              if ((this.typeShop == 0 ? 0 : 1) == 0)
              {
                this.method_208();
                break;
              }
              this.method_66();
              break;
            case 2:
              this.method_208();
              break;
            case 3:
              this.method_66();
              break;
            case 4:
              this.method_58();
              GClass62.smethod_24();
              return;
            case 7:
              this.method_208();
              break;
            case 8:
              this.method_66();
              break;
            case 9:
              this.method_66();
              break;
            case 10:
              this.method_66();
              break;
            case 11:
            case 16:
              this.method_66();
              break;
            case 12:
              this.method_59();
              break;
            case 13:
              this.method_51();
              break;
            case 14:
              this.method_66();
              break;
            case 15:
              this.method_66();
              break;
            case 18:
              this.method_66();
              break;
            case 19:
              this.method_199();
              break;
            case 20:
              this.method_199();
              break;
            case 21:
              if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
                this.method_66();
              if (this.currentTabIndex == Class15.smethod_0(1))
                this.method_48();
              if (this.currentTabIndex == Class15.smethod_0(7))
              {
                this.method_66();
                break;
              }
              break;
            case 22:
              this.method_47();
              break;
            case 23:
            case 24:
              this.method_66();
              break;
          }
          GClass62.smethod_25();
          for (int index = Class15.smethod_0(0); index < GClass62.bool_11.Length; index += Class15.smethod_0(1))
            GClass62.bool_11[index] = Class15.smethod_0(0) != 0;
        }
      }
    }
  }

  private void method_47()
  {
  }

  private void method_48() => this.method_66();

  private void method_49()
  {
  }

  private void method_50() => this.method_66();

  private void method_51()
  {
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
    {
      if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0)
        this.method_208();
      if ((!this.Equals((object) GClass62.gclass141_1) ? 1 : 0) == 0)
        this.method_50();
    }
    if (this.currentTabIndex != Class15.smethod_0(1) && this.currentTabIndex != Class15.smethod_0(7))
      return;
    this.method_50();
  }

  private void method_52() => this.method_66();

  private void method_53() => this.method_66();

  private void method_54() => this.method_66();

  public void method_55(bool isMe)
  {
    this.currentListLength = (!isMe ? 1 : 0) != 0 ? this.vFriendGD.method_2() + Class15.smethod_0(5) : this.vMyGD.method_2() + Class15.smethod_0(5);
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  public void method_56(GClass20 cGD)
  {
    this.type = Class15.smethod_0(47);
    this.tabName[this.type] = GClass141.string_9;
    this.isAccept = Class15.smethod_0(0) != 0;
    this.isLock = Class15.smethod_0(0) != 0;
    this.isFriendLock = Class15.smethod_0(0) != 0;
    this.vMyGD.method_9();
    this.vFriendGD.method_9();
    this.moneyGD = Class15.smethod_0(0);
    this.friendMoneyGD = Class15.smethod_0(0);
    if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
    {
      GClass62.gclass141_1 = new GClass141();
      GClass62.gclass141_1.type = Class15.smethod_0(47);
      string[][][] tabName1 = GClass62.gclass141_1.tabName;
      int type1 = this.type;
      string[][] strArray1 = new string[Class15.smethod_0(1)][];
      strArray1[Class15.smethod_0(0)] = GClass109.string_202;
      tabName1[type1] = strArray1;
      GClass62.gclass141_1.method_5(Class15.smethod_0(1));
      GClass62.gclass141_1.method_55(Class15.smethod_0(0) != 0);
      string[][][] tabName2 = GClass62.gclass141_0.tabName;
      int type2 = this.type;
      string[][] strArray2 = new string[Class15.smethod_0(7)][];
      strArray2[Class15.smethod_0(0)] = GClass109.string_198;
      strArray2[Class15.smethod_0(1)] = GClass109.string_201;
      tabName2[type2] = strArray2;
      GClass62.gclass141_1.method_44();
      GClass62.gclass141_1.charMenu = cGD;
    }
    if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0)
      this.method_5(Class15.smethod_0(0));
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
      this.method_82();
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_55(Class15.smethod_0(1) != 0);
    if (this.currentTabIndex == Class15.smethod_0(7))
      this.method_55(Class15.smethod_0(0) != 0);
    this.charMenu = cGD;
  }

  private void method_57(GClass98 gclass98_0, bool bool_18)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    GClass134 gclass134 = !bool_18 ? this.vFriendGD : this.vMyGD;
    for (int index1 = Class15.smethod_0(0); index1 < this.currentListLength; index1 += Class15.smethod_0(1))
    {
      int x = this.xScroll + Class15.smethod_0(86);
      int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w1 = this.wScroll - Class15.smethod_0(86);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int xScroll = this.xScroll;
      int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w2 = Class15.smethod_0(117);
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        if (index1 == this.currentListLength - Class15.smethod_0(1))
        {
          if (bool_18)
          {
            gclass98_0.method_16(Class15.smethod_0(485));
            gclass98_0.method_15(xScroll, y1, this.wScroll, h1);
            if (!this.isLock)
            {
              if (!this.isFriendLock)
                GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_305 + GClass109.string_295, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
              else
                GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_305 + GClass109.string_297, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
            }
            else if (this.isFriendLock)
            {
              gclass98_0.method_16(Class15.smethod_0(485));
              gclass98_0.method_15(xScroll, y1, this.wScroll, h1);
              gclass98_0.method_32(index1 != this.selected ? GClass116.gclass66_24 : GClass116.gclass66_25, this.xScroll + this.wScroll - Class15.smethod_0(3), y1 + Class15.smethod_0(7), GClass177.int_2);
              (index1 != this.selected ? GClass97.gclass97_6 : GClass97.gclass97_7).method_6(gclass98_0, GClass109.string_304, this.xScroll + this.wScroll - Class15.smethod_0(28), y1 + Class15.smethod_0(38), Class15.smethod_0(7));
              GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_305 + GClass109.string_297, this.xScroll + Class15.smethod_0(3), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_0);
            }
            else
              GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_305 + GClass109.string_295, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
          }
        }
        else if (index1 == this.currentListLength - Class15.smethod_0(7))
        {
          if (bool_18)
          {
            gclass98_0.method_16(Class15.smethod_0(485));
            gclass98_0.method_15(xScroll, y1, this.wScroll, h1);
            if (!this.isAccept)
            {
              if (!this.isLock)
              {
                gclass98_0.method_32(index1 != this.selected ? GClass116.gclass66_24 : GClass116.gclass66_25, this.xScroll + this.wScroll - Class15.smethod_0(3), y1 + Class15.smethod_0(7), GClass177.int_2);
                (index1 != this.selected ? GClass97.gclass97_6 : GClass97.gclass97_7).method_6(gclass98_0, GClass109.string_307, this.xScroll + this.wScroll - Class15.smethod_0(28), y1 + Class15.smethod_0(38), Class15.smethod_0(7));
                GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_306 + GClass109.string_295, this.xScroll + Class15.smethod_0(3), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_0);
              }
              else
              {
                gclass98_0.method_32(index1 != this.selected ? GClass116.gclass66_24 : GClass116.gclass66_25, this.xScroll + this.wScroll - Class15.smethod_0(3), y1 + Class15.smethod_0(7), GClass177.int_2);
                (index1 != this.selected ? GClass97.gclass97_6 : GClass97.gclass97_7).method_6(gclass98_0, GClass109.string_145, this.xScroll + this.wScroll - Class15.smethod_0(28), y1 + Class15.smethod_0(38), Class15.smethod_0(7));
                GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_306 + GClass109.string_297, this.xScroll + Class15.smethod_0(3), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_0);
              }
            }
          }
          else if (!this.isFriendLock)
            GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_296, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
          else
            GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_298, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
        }
        else if (index1 == this.currentListLength - Class15.smethod_0(5))
        {
          if (this.isLock)
            gclass98_0.method_16(Class15.smethod_0(486));
          else
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
          gclass98_0.method_15(x, y1, w1, h1);
          if (this.isLock)
            gclass98_0.method_16(Class15.smethod_0(486));
          else
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(487));
          gclass98_0.method_15(xScroll, y2, w2, h2);
          gclass98_0.method_32(GClass141.gclass66_7, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(5));
          GClass97.gclass97_14.method_6(gclass98_0, GClass138.smethod_9(!bool_18 ? (long) this.friendMoneyGD : (long) this.moneyGD) + Class13.smethod_0(147343) + GClass109.string_156, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), Class15.smethod_0(0));
          GClass97.gclass97_19.method_6(gclass98_0, GClass109.string_308, x + Class15.smethod_0(3), y1, Class15.smethod_0(0));
        }
        else
        {
          if (gclass134.method_2() == 0)
            return;
          if (this.isLock)
            gclass98_0.method_16(Class15.smethod_0(486));
          else
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
          gclass98_0.method_15(x, y1, w1, h1);
          if (this.isLock)
            gclass98_0.method_16(Class15.smethod_0(486));
          else
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
          GClass80 gclass80 = (GClass80) gclass134.method_3(index1);
          gclass98_0.method_15(xScroll, y2, w2, h2);
          if (gclass80 != null)
          {
            string str = string.Empty;
            GClass97 gclass97_1 = GClass97.gclass97_14;
            if (gclass80.itemOption != null)
            {
              for (int index2 = Class15.smethod_0(0); index2 < gclass80.itemOption.Length; index2 += Class15.smethod_0(1))
              {
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(107))
                {
                  str = Class13.smethod_0(147337) + gclass80.itemOption[index2].param.ToString() + Class13.smethod_0(147330);
                  gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index2].param);
                }
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(55))
                {
                  if (gclass80.itemOption[index2].param == Class15.smethod_0(1))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(7))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(5))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(2))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
                }
              }
            }
            gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
            string st = string.Empty;
            if (gclass80.itemOption != null)
            {
              if (gclass80.itemOption.Length != 0 && gclass80.itemOption[Class15.smethod_0(0)] != null)
                st += gclass80.itemOption[Class15.smethod_0(0)].method_0();
              GClass97 gclass97_2 = GClass97.gclass97_18;
              if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
                gclass97_2 = GClass97.gclass97_17;
              if (gclass80.itemOption.Length > Class15.smethod_0(1))
              {
                for (int index3 = Class15.smethod_0(1); index3 < gclass80.itemOption.Length; index3 += Class15.smethod_0(1))
                {
                  if (gclass80.itemOption[index3] != null && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(12))
                    st = st + Class13.smethod_0(147452) + gclass80.itemOption[index3].method_0();
                }
              }
              gclass97_2.method_6(gclass98_0, st, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), GClass97.int_0);
            }
            GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
            if (gclass80.itemOption != null)
            {
              for (int index4 = Class15.smethod_0(0); index4 < gclass80.itemOption.Length; index4 += Class15.smethod_0(1))
                this.method_204(gclass98_0, gclass80.itemOption[index4].optionTemplate.id, gclass80.itemOption[index4].param, xScroll, y2, w2, h2);
              for (int index5 = Class15.smethod_0(0); index5 < gclass80.itemOption.Length; index5 += Class15.smethod_0(1))
                this.method_205(gclass98_0, gclass80.itemOption[index5].optionTemplate.id, gclass80.itemOption[index5].param, xScroll, y2, w2, h2);
            }
            if (gclass80.quantity > Class15.smethod_0(1))
              GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
          }
        }
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_58()
  {
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      this.int_74 -= Class15.smethod_0(3);
      this.cmyMap = this.int_74 - (this.yScroll + this.hScroll / Class15.smethod_0(7));
      if (this.int_74 < this.yScroll)
        this.int_74 = this.yScroll;
    }
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      this.int_74 += Class15.smethod_0(3);
      this.cmyMap = this.int_74 - (this.yScroll + this.hScroll / Class15.smethod_0(7));
      if (this.int_74 > this.yScroll + Class15.smethod_0(90))
        this.int_74 = this.yScroll + Class15.smethod_0(90);
    }
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
    {
      this.int_73 -= Class15.smethod_0(3);
      this.cmxMap = this.int_73 - this.wScroll / Class15.smethod_0(7);
      if (this.int_73 < Class15.smethod_0(10))
        this.int_73 = Class15.smethod_0(10);
    }
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) == 0)
    {
      this.int_73 += Class15.smethod_0(3);
      this.cmxMap = this.int_73 - this.wScroll / Class15.smethod_0(7);
      if (this.int_73 > Class15.smethod_0(262))
        this.int_73 = Class15.smethod_0(262);
    }
    if ((!GClass62.bool_14 ? 1 : 0) == 0)
    {
      this.bool_4 = Class15.smethod_0(1) != 0;
      if ((!this.bool_0 ? 0 : 1) == 0)
      {
        this.int_0 = this.cmxMap;
        this.int_1 = this.cmyMap;
        this.bool_0 = Class15.smethod_0(1) != 0;
      }
      this.cmxMap = this.int_0 + (GClass62.int_4 - GClass62.int_0);
      this.cmyMap = this.int_1 + (GClass62.int_5 - GClass62.int_1);
    }
    if ((!GClass62.bool_16 ? 1 : 0) == 0)
    {
      this.bool_0 = Class15.smethod_0(0) != 0;
      GClass62.int_4 = GClass62.int_0;
      GClass62.int_5 = GClass62.int_1;
      this.int_2 = GClass62.int_4 + this.cmxMap;
      this.int_3 = GClass62.int_5 + this.cmyMap;
    }
    if ((!GClass62.bool_15 ? 1 : 0) == 0)
      this.bool_4 = Class15.smethod_0(0) != 0;
    if (this.cmxMap < Class15.smethod_0(0))
      this.cmxMap = Class15.smethod_0(0);
    if (this.cmxMap > this.cmxMapLim)
      this.cmxMap = this.cmxMapLim;
    if (this.cmyMap < Class15.smethod_0(0))
      this.cmyMap = Class15.smethod_0(0);
    if (this.cmyMap <= this.cmyMapLim)
      return;
    this.cmyMap = this.cmyMapLim;
  }

  private void method_59()
  {
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
    {
      this.method_66();
      this.int_58 = -1;
      if (this.selected == this.vItemCombine.method_2() && (!GClass62.bool_15 ? 1 : 0) == 0)
      {
        GClass62.bool_15 = Class15.smethod_0(0) != 0;
        this.int_58 = Class15.smethod_0(1);
      }
    }
    if (this.currentTabIndex != Class15.smethod_0(1))
      return;
    this.method_66();
  }

  private void method_60()
  {
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
      this.cmyQuest -= Class15.smethod_0(3);
    if ((!GClass62.bool_13[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 1 : 0) == 0)
      this.cmyQuest += Class15.smethod_0(3);
    if (this.cmyQuest < Class15.smethod_0(0))
      this.cmyQuest = Class15.smethod_0(0);
    int num1 = this.indexRowMax * Class15.smethod_0(66) - (this.hScroll - Class15.smethod_0(4));
    if (num1 < Class15.smethod_0(0))
      num1 = Class15.smethod_0(0);
    if (this.cmyQuest > num1)
      this.cmyQuest = num1;
    if ((this.gclass154_0 == null ? 1 : 0) == 0)
    {
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        this.gclass154_0.cmy = this.cmyQuest;
      this.gclass154_0.method_1();
    }
    int num2 = this.xScroll + this.wScroll / Class15.smethod_0(7) - Class15.smethod_0(95);
    int num3 = this.yScroll + this.hScroll - (GClass62.int_11 <= Class15.smethod_0(137) ? Class15.smethod_0(9) : Class15.smethod_0(51)) - Class15.smethod_0(9);
    int int0 = GClass62.int_0;
    int int1 = GClass62.int_1;
    this.int_59 = -1;
    if ((!GClass141.bool_11 ? 1 : 0) != 0 || (!GClass116.smethod_6().method_2() ? 0 : 1) != 0 || int0 < num2 || int0 > num2 + Class15.smethod_0(152) || int1 < num3 || int1 > num3 + Class15.smethod_0(6) || (this.gclass154_0 == null ? 1 : 0) == 0 && (!this.gclass154_0.pointerIsDowning ? 0 : 1) != 0)
      return;
    this.int_59 = Class15.smethod_0(1);
    if ((!GClass62.bool_16 ? 1 : 0) != 0)
      return;
    GClass172.smethod_1().method_35();
    this.int_54 = Class15.smethod_0(7);
    GClass62.smethod_46();
  }

  private void method_61()
  {
    this.bool_3 = Class15.smethod_0(0) != 0;
    if ((this.type == 0 ? 0 : 1) != 0 || this.mainTabName.Length != Class15.smethod_0(3) || this.currentTabIndex != Class15.smethod_0(5))
      return;
    this.bool_3 = Class15.smethod_0(0) != 0;
    if ((this.selected == 0 ? 0 : 1) == 0)
    {
      this.int_4 = new int[this.clansOption.Length];
      for (int index = Class15.smethod_0(0); index < this.int_4.Length; index += Class15.smethod_0(1))
        this.int_4[index] = index;
      if ((!this.isViewMember ? 0 : 1) != 0)
        return;
      this.bool_3 = Class15.smethod_0(1) != 0;
    }
    else
    {
      if (this.selected == Class15.smethod_0(1) || (!this.isSearchClan ? 0 : 1) != 0 || this.selected <= Class15.smethod_0(0))
        return;
      this.int_4 = new int[Class15.smethod_0(1)];
      for (int index = Class15.smethod_0(0); index < this.int_4.Length; index += Class15.smethod_0(1))
        this.int_4[index] = index;
      this.bool_3 = Class15.smethod_0(1) != 0;
    }
  }

  private void method_62()
  {
    if ((this.int_4 == null ? 0 : 1) == 0)
      return;
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
    {
      this.currMess = this.method_104();
      this.int_23 -= Class15.smethod_0(1);
      if ((this.selected == 0 ? 0 : 1) == 0 && this.int_23 < Class15.smethod_0(0))
        this.int_23 = this.int_4.Length - Class15.smethod_0(1);
      if (this.selected <= Class15.smethod_0(1) || (!this.isMessage ? 1 : 0) != 0 || (this.currMess.option == null ? 1 : 0) != 0 || this.int_23 >= Class15.smethod_0(0))
        return;
      this.int_23 = this.currMess.option.Length - Class15.smethod_0(1);
    }
    else
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) != 0)
        return;
      this.currMess = this.method_104();
      this.int_23 += Class15.smethod_0(1);
      if ((this.selected == 0 ? 0 : 1) == 0 && this.int_23 > this.int_4.Length - Class15.smethod_0(1))
        this.int_23 = Class15.smethod_0(0);
      if (this.selected <= Class15.smethod_0(1) || (!this.isMessage ? 1 : 0) != 0 || (this.currMess.option == null ? 1 : 0) != 0 || this.int_23 <= this.currMess.option.Length - Class15.smethod_0(1))
        return;
      this.int_23 = Class15.smethod_0(0);
    }
  }

  private void method_63()
  {
    this.method_66();
    this.method_62();
  }

  private void method_64()
  {
    try
    {
      if ((this.type == 0 ? 0 : 1) != 0 || this.currentTabIndex != Class15.smethod_0(5) || this.mainTabName.Length != Class15.smethod_0(3) || this.selected == -1)
        return;
      int num = Class15.smethod_0(0);
      if ((this.selected == 0 ? 0 : 1) == 0)
      {
        num = this.xScroll + this.wScroll / Class15.smethod_0(7) - this.clansOption.Length * this.TAB_W / Class15.smethod_0(7);
        this.int_23 = (GClass62.int_0 - num) / this.TAB_W;
      }
      else
      {
        this.currMess = this.method_104();
        if ((this.currMess == null ? 1 : 0) == 0 && (this.currMess.option == null ? 1 : 0) == 0)
        {
          num = this.xScroll + this.wScroll - Class15.smethod_0(7) - this.currMess.option.Length * Class15.smethod_0(54);
          this.int_23 = (GClass62.int_0 - num) / Class15.smethod_0(54);
        }
      }
      if (GClass62.int_0 >= num)
        return;
      this.int_23 = -1;
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(139737) + ex.StackTrace);
    }
  }

  public void method_65(int a)
  {
    bool flag = Class15.smethod_0(0) != 0;
    if (GClass62.int_6 > this.wScroll)
      return;
    if (this.indexMouse == -1)
      this.indexMouse = this.selected;
    if (a > Class15.smethod_0(0))
    {
      this.indexMouse -= a;
      flag = Class15.smethod_0(1) != 0;
    }
    else if (a < Class15.smethod_0(0))
    {
      this.indexMouse += -a;
      flag = Class15.smethod_0(1) != 0;
    }
    if (this.indexMouse < Class15.smethod_0(0))
      this.indexMouse = Class15.smethod_0(0);
    if ((!flag ? 1 : 0) != 0)
      return;
    this.cmtoY = this.indexMouse * Class15.smethod_0(66);
    if (this.cmtoY > this.cmyLim)
      this.cmtoY = this.cmyLim;
    if (this.cmtoY >= Class15.smethod_0(0))
      return;
    this.cmtoY = Class15.smethod_0(0);
  }

  private void method_66()
  {
    if (this.currentListLength <= Class15.smethod_0(0))
      return;
    bool flag = Class15.smethod_0(0) != 0;
    if (GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(7) : Class15.smethod_0(27)])
    {
      flag = Class15.smethod_0(1) != 0;
      this.selected -= Class15.smethod_0(1);
      if (this.type == Class15.smethod_0(40))
      {
        this.selected -= Class15.smethod_0(7);
        if (this.selected < Class15.smethod_0(0))
          this.selected = Class15.smethod_0(0);
      }
      else if (this.selected < Class15.smethod_0(0))
      {
        if (this.Equals((object) GClass62.gclass141_0) && this.typeShop == Class15.smethod_0(7) && this.currentTabIndex <= Class15.smethod_0(5) && this.maxPageShop[this.currentTabIndex] > Class15.smethod_0(1))
        {
          GClass71.smethod_1();
          if (this.currPageShop[this.currentTabIndex] <= Class15.smethod_0(0))
          {
            GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.maxPageShop[this.currentTabIndex] - Class15.smethod_0(1), -1);
            return;
          }
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.currPageShop[this.currentTabIndex] - Class15.smethod_0(1), -1);
          return;
        }
        this.selected = this.currentListLength - Class15.smethod_0(1);
        if (this.bool_3)
          this.selected = -1;
        if ((int) this.size_tab > Class15.smethod_0(0))
          this.selected = -1;
      }
      this.int_6[this.currentTabIndex] = this.selected;
      this.int_23 = Class15.smethod_0(0);
      this.method_61();
    }
    else if (GClass62.bool_11[!Main.bool_3 ? Class15.smethod_0(88) : Class15.smethod_0(28)])
    {
      flag = Class15.smethod_0(1) != 0;
      this.selected += Class15.smethod_0(1);
      if (this.type == Class15.smethod_0(40))
      {
        this.selected += Class15.smethod_0(7);
        if (this.selected > this.currentListLength - Class15.smethod_0(1))
          this.selected = this.currentListLength - Class15.smethod_0(1);
      }
      else if (this.selected > this.currentListLength - Class15.smethod_0(1))
      {
        if (this.Equals((object) GClass62.gclass141_0) && this.typeShop == Class15.smethod_0(7) && this.currentTabIndex <= Class15.smethod_0(5) && this.maxPageShop[this.currentTabIndex] > Class15.smethod_0(1))
        {
          GClass71.smethod_1();
          if (this.currPageShop[this.currentTabIndex] >= this.maxPageShop[this.currentTabIndex] - Class15.smethod_0(1))
          {
            GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, Class15.smethod_0(0), -1);
            return;
          }
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.currPageShop[this.currentTabIndex] + Class15.smethod_0(1), -1);
          return;
        }
        this.selected = Class15.smethod_0(0);
      }
      this.int_6[this.currentTabIndex] = this.selected;
      this.int_23 = Class15.smethod_0(0);
      this.method_61();
    }
    if (flag)
    {
      this.cmtoY = this.selected * this.ITEM_HEIGHT - this.hScroll / Class15.smethod_0(7);
      if (this.cmtoY > this.cmyLim)
        this.cmtoY = this.cmyLim;
      if (this.cmtoY < Class15.smethod_0(0))
        this.cmtoY = Class15.smethod_0(0);
      this.cmy = this.cmtoY;
    }
    if (GClass62.bool_14)
    {
      this.bool_7 = Class15.smethod_0(0) != 0;
      if (!this.bool_4 && GClass62.smethod_45(this.xScroll, this.yScroll, this.wScroll, this.hScroll))
      {
        for (int index = Class15.smethod_0(0); index < this.int_53.Length; index += Class15.smethod_0(1))
          this.int_53[Class15.smethod_0(0)] = GClass62.int_1;
        this.int_52 = GClass62.int_1;
        this.bool_4 = Class15.smethod_0(1) != 0;
        this.bool_5 = (uint) this.int_55 > (uint) Class15.smethod_0(0);
        this.int_55 = Class15.smethod_0(0);
      }
      else if (this.bool_4)
      {
        if (GClass126.bool_0 && (GClass62.int_1 - this.yScroll) / this.ITEM_HEIGHT == 0)
        {
          this.int_51 = Class15.smethod_0(38);
          this.int_52 = GClass62.int_1;
          this.bool_5 = Class15.smethod_0(0) != 0;
        }
        this.int_51 += Class15.smethod_0(1);
        if (this.int_51 > Class15.smethod_0(3) && this.int_52 == GClass62.int_1 && !this.bool_5)
        {
          this.int_52 = Class15.smethod_0(223);
          this.selected = (this.cmtoY + GClass62.int_1 - this.yScroll) / this.ITEM_HEIGHT;
          if (this.selected >= this.currentListLength)
            this.selected = -1;
          this.method_64();
        }
        else
          this.indexMouse = -1;
        int num = GClass62.int_1 - this.int_53[Class15.smethod_0(0)];
        if (num != 0 && this.selected != -1)
        {
          this.selected = -1;
          this.int_23 = -1;
        }
        for (int index = this.int_53.Length - Class15.smethod_0(1); index > Class15.smethod_0(0); index -= Class15.smethod_0(1))
          this.int_53[index] = this.int_53[index - Class15.smethod_0(1)];
        this.int_53[Class15.smethod_0(0)] = GClass62.int_1;
        this.cmtoY -= num;
        if (this.cmtoY < Class15.smethod_0(0))
          this.cmtoY = Class15.smethod_0(0);
        if (this.cmtoY > this.cmyLim)
          this.cmtoY = this.cmyLim;
        if (this.cmy < Class15.smethod_0(0) || this.cmy > this.cmyLim)
          num /= Class15.smethod_0(7);
        this.cmy -= num;
        this.bool_6 = this.cmy >= -(GClass62.int_11 / Class15.smethod_0(5)) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
      }
    }
    if (!GClass62.bool_16 || !this.bool_4)
      return;
    this.bool_7 = Class15.smethod_0(1) != 0;
    int i = GClass62.int_1 - this.int_53[Class15.smethod_0(0)];
    GClass62.bool_16 = Class15.smethod_0(0) != 0;
    if (GClass151.smethod_25(i) < Class15.smethod_0(51) && GClass151.smethod_25(GClass62.int_1 - this.int_52) < Class15.smethod_0(51) && !this.bool_5)
    {
      this.int_55 = Class15.smethod_0(0);
      this.cmtoY = this.cmy;
      this.int_52 = Class15.smethod_0(223);
      this.selected = (this.cmtoY + GClass62.int_1 - this.yScroll) / this.ITEM_HEIGHT;
      if (this.selected >= this.currentListLength)
        this.selected = -1;
      this.method_64();
      this.int_51 = Class15.smethod_0(0);
      this.int_54 = Class15.smethod_0(31);
      GClass172.smethod_1().method_40();
    }
    else if (this.selected != -1 && this.int_51 > Class15.smethod_0(3))
    {
      this.int_51 = Class15.smethod_0(0);
      this.int_54 = Class15.smethod_0(1);
    }
    else if (this.selected == -1 && !this.bool_5)
    {
      if (this.cmy < Class15.smethod_0(0))
        this.cmtoY = Class15.smethod_0(0);
      else if (this.cmy > this.cmyLim)
      {
        this.cmtoY = this.cmyLim;
      }
      else
      {
        int num = GClass62.int_1 - this.int_53[Class15.smethod_0(0)] + (this.int_53[Class15.smethod_0(0)] - this.int_53[Class15.smethod_0(1)]) + (this.int_53[Class15.smethod_0(1)] - this.int_53[Class15.smethod_0(7)]);
        this.int_55 = -(num > Class15.smethod_0(31) ? Class15.smethod_0(31) : (num < Class15.smethod_0(136) ? Class15.smethod_0(136) : Class15.smethod_0(0))) * Class15.smethod_0(21);
      }
    }
    if (this.method_206() && GClass62.int_1 < this.yScroll + Class15.smethod_0(27))
    {
      this.selected = Class15.smethod_0(0);
      this.method_207();
    }
    this.bool_4 = Class15.smethod_0(0) != 0;
    this.int_51 = Class15.smethod_0(0);
    GClass62.bool_16 = Class15.smethod_0(0) != 0;
  }

  public string method_67(string[] str) => (string) null;

  private void method_68()
  {
    if ((this.gclass154_0 == null ? 1 : 0) == 0 && (!this.gclass154_0.pointerIsDowning ? 0 : 1) != 0 || (!this.bool_4 ? 1 : 0) == 0)
      return;
    int currentTabIndex = this.currentTabIndex;
    if ((!this.method_209() ? 0 : 1) == 0)
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 1 : 0) == 0)
      {
        if ((!this.method_206() ? 1 : 0) == 0)
        {
          if (this.selected >= Class15.smethod_0(0))
          {
            this.method_207();
          }
          else
          {
            this.currentTabIndex += Class15.smethod_0(1);
            if (this.currentTabIndex >= this.currentTabName.Length)
            {
              if ((GClass62.gclass141_1 == null ? 1 : 0) == 0)
              {
                this.currentTabIndex = this.currentTabName.Length - Class15.smethod_0(1);
                GClass62.bool_22 = Class15.smethod_0(1) != 0;
              }
              else
                this.currentTabIndex = Class15.smethod_0(0);
            }
            this.selected = this.int_6[this.currentTabIndex];
            this.lastTabIndex[this.type] = this.currentTabIndex;
          }
        }
        else
        {
          this.currentTabIndex += Class15.smethod_0(1);
          if (this.currentTabIndex >= this.currentTabName.Length)
          {
            if ((GClass62.gclass141_1 == null ? 1 : 0) == 0)
            {
              this.currentTabIndex = this.currentTabName.Length - Class15.smethod_0(1);
              GClass62.bool_22 = Class15.smethod_0(1) != 0;
            }
            else
              this.currentTabIndex = Class15.smethod_0(0);
          }
          this.selected = this.int_6[this.currentTabIndex];
          this.lastTabIndex[this.type] = this.currentTabIndex;
        }
      }
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
      {
        this.currentTabIndex -= Class15.smethod_0(1);
        if (this.currentTabIndex < Class15.smethod_0(0))
          this.currentTabIndex = this.currentTabName.Length - Class15.smethod_0(1);
        if ((!GClass62.bool_22 ? 1 : 0) == 0)
          GClass62.bool_22 = Class15.smethod_0(0) != 0;
        this.selected = this.int_6[this.currentTabIndex];
        this.lastTabIndex[this.type] = this.currentTabIndex;
      }
    }
    this.int_60 = -1;
    for (int index = Class15.smethod_0(0); index < this.currentTabName.Length; index += Class15.smethod_0(1))
    {
      if ((!GClass62.smethod_45(this.startTabPos + index * this.TAB_W, Class15.smethod_0(72), this.TAB_W - Class15.smethod_0(1), Class15.smethod_0(46)) ? 1 : 0) == 0)
      {
        this.int_60 = index;
        if ((!GClass62.bool_16 ? 1 : 0) == 0)
        {
          this.currentTabIndex = index;
          this.lastTabIndex[this.type] = index;
          GClass62.bool_16 = Class15.smethod_0(0) != 0;
          this.selected = this.int_6[this.currentTabIndex];
          if (currentTabIndex == this.currentTabIndex && (this.int_55 == 0 ? 0 : 1) == 0)
          {
            this.cmtoY = Class15.smethod_0(0);
            this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
            break;
          }
          break;
        }
      }
    }
    if (currentTabIndex == this.currentTabIndex)
      return;
    this.size_tab = (sbyte) Class15.smethod_0(0);
    GClass172.smethod_1().method_40();
    int type = this.type;
    if (type <= Class15.smethod_0(66))
    {
      switch (type)
      {
        case 0:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_84();
          if (this.currentTabIndex == Class15.smethod_0(1))
            this.method_82();
          if (this.currentTabIndex == Class15.smethod_0(7))
            this.method_77();
          if (this.currentTabIndex == Class15.smethod_0(5))
          {
            if (this.mainTabName.Length > Class15.smethod_0(2))
              this.method_73();
            else
              this.method_71();
          }
          if (this.currentTabIndex == Class15.smethod_0(2))
          {
            this.method_71();
            break;
          }
          break;
        case 1:
          this.method_76();
          break;
        case 2:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_80();
          if (this.currentTabIndex == Class15.smethod_0(1))
          {
            this.method_82();
            break;
          }
          break;
        case 3:
          this.method_79();
          break;
        default:
          if (type == Class15.smethod_0(66))
          {
            if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
              this.method_30();
            if (this.currentTabIndex == Class15.smethod_0(1))
            {
              this.method_82();
              break;
            }
            break;
          }
          break;
      }
    }
    else if (type != Class15.smethod_0(47))
    {
      if (type != Class15.smethod_0(27))
      {
        if (type == Class15.smethod_0(46))
          this.method_201();
      }
      else
      {
        if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
          this.method_81();
        if (this.currentTabIndex == Class15.smethod_0(1))
          this.method_69();
        if (this.currentTabIndex == Class15.smethod_0(7))
          this.method_82();
      }
    }
    else
    {
      if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
      {
        if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0)
          this.method_82();
        else if ((!this.Equals((object) GClass62.gclass141_1) ? 1 : 0) == 0)
          this.method_55(Class15.smethod_0(0) != 0);
      }
      if (this.currentTabIndex == Class15.smethod_0(1))
        this.method_55(Class15.smethod_0(1) != 0);
      if (this.currentTabIndex == Class15.smethod_0(7))
        this.method_55(Class15.smethod_0(0) != 0);
    }
    this.selected = this.int_6[this.currentTabIndex];
  }

  private void method_69()
  {
    this.currentListLength = this.string_11.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  private void method_70()
  {
  }

  private void method_71()
  {
    GClass172.smethod_1().method_1();
    this.currentListLength = GClass141.string_1.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  public void method_72()
  {
    if ((!this.isSearchClan ? 1 : 0) == 0)
    {
      this.currentListLength = (this.clans == null ? 0 : 1) != 0 ? this.clans.Length + Class15.smethod_0(7) : Class15.smethod_0(7);
      this.clanInfo = GClass109.string_270;
    }
    else if ((!this.isViewMember ? 1 : 0) == 0)
    {
      this.clanReport = string.Empty;
      this.currentListLength = ((this.member == null ? 0 : 1) != 0 ? this.member.method_2() : this.myMember.method_2()) + Class15.smethod_0(7);
      this.clanInfo = GClass109.string_259 + Class13.smethod_0(139265) + ((this.currClan == null ? 1 : 0) != 0 ? GClass20.smethod_1().clan.name : this.currClan.name);
    }
    else if ((!this.isMessage ? 1 : 0) == 0)
    {
      this.currentListLength = GClass28.gclass134_0.method_2() + Class15.smethod_0(7);
      this.clanInfo = GClass109.string_60;
      this.clanReport = string.Empty;
    }
    if ((GClass20.smethod_1().clan == null ? 0 : 1) == 0)
    {
      string[][] strArray = new string[Class15.smethod_0(7)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_264;
      strArray[Class15.smethod_0(1)] = GClass109.string_263;
      this.clansOption = strArray;
    }
    else if ((!this.isViewMember ? 0 : 1) == 0)
    {
      if (this.myMember.method_2() > Class15.smethod_0(1))
      {
        string[][] strArray = new string[Class15.smethod_0(5)][];
        strArray[Class15.smethod_0(0)] = GClass109.string_261;
        strArray[Class15.smethod_0(1)] = GClass109.string_267;
        strArray[Class15.smethod_0(7)] = GClass109.string_260;
        this.clansOption = strArray;
      }
      else
      {
        string[][] strArray = new string[Class15.smethod_0(1)][];
        strArray[Class15.smethod_0(0)] = GClass109.string_260;
        this.clansOption = strArray;
      }
    }
    else if ((int) GClass20.smethod_1().role > Class15.smethod_0(0))
    {
      string[][] strArray = new string[Class15.smethod_0(7)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_61;
      strArray[Class15.smethod_0(1)] = GClass109.string_262;
      this.clansOption = strArray;
    }
    else if (this.myMember.method_2() > Class15.smethod_0(1))
    {
      string[][] strArray = new string[Class15.smethod_0(2)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_61;
      strArray[Class15.smethod_0(1)] = GClass109.string_262;
      strArray[Class15.smethod_0(7)] = GClass109.string_265;
      strArray[Class15.smethod_0(5)] = GClass109.string_266;
      this.clansOption = strArray;
    }
    else
    {
      string[][] strArray = new string[Class15.smethod_0(5)][];
      strArray[Class15.smethod_0(0)] = GClass109.string_61;
      strArray[Class15.smethod_0(1)] = GClass109.string_265;
      strArray[Class15.smethod_0(7)] = GClass109.string_266;
      this.clansOption = strArray;
    }
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  public void method_73()
  {
    GClass116.bool_53 = Class15.smethod_0(0) != 0;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    if ((this.int_6 == null ? 1 : 0) == 0 && (this.int_6[Class15.smethod_0(5)] == 0 ? 0 : 1) == 0)
      this.int_6[Class15.smethod_0(5)] = -1;
    this.currentListLength = Class15.smethod_0(7);
    if ((GClass20.smethod_1().clan == null ? 1 : 0) == 0)
    {
      this.isMessage = Class15.smethod_0(1) != 0;
      this.isViewMember = Class15.smethod_0(0) != 0;
      this.isSearchClan = Class15.smethod_0(0) != 0;
    }
    else
    {
      this.isMessage = Class15.smethod_0(0) != 0;
      this.isViewMember = Class15.smethod_0(0) != 0;
      this.isSearchClan = Class15.smethod_0(1) != 0;
    }
    if ((GClass20.smethod_1().clan == null ? 1 : 0) == 0)
      this.currentListLength = GClass28.gclass134_0.method_2() + Class15.smethod_0(7);
    this.method_72();
    this.int_23 = -1;
    if ((this.chatTField == null ? 0 : 1) == 0)
    {
      this.chatTField = new GClass23();
      this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
      this.chatTField.method_0();
      this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
    }
    if ((GClass20.smethod_1().clan == null ? 0 : 1) == 0)
    {
      this.clanReport = GClass109.string_293;
      GClass156.smethod_0().method_24(string.Empty);
    }
    this.selected = this.int_6[this.currentTabIndex];
    if ((!GClass62.bool_5 ? 1 : 0) != 0)
      return;
    this.selected = -1;
  }

  public void method_74()
  {
    this.currentListLength = this.logChat.method_2() + Class15.smethod_0(1);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  private void method_75()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.method_74();
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public void method_76()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = this.currentTabIndex != this.currentTabName.Length - Class15.smethod_0(1) || (GClass62.gclass141_1 == null ? 0 : 1) != 0 || this.typeShop == Class15.smethod_0(7) ? GClass20.smethod_1().arrItemShop[this.currentTabIndex].Length : GClass20.smethod_1().arrItemBody.Length + GClass20.smethod_1().arrItemBag.Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_77()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(6);
    this.currentListLength = GClass20.smethod_1().nClass.skillTemplates.Length + Class15.smethod_0(37);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_78()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = this.mapNames.Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    this.cmy = this.cmtoY = Class15.smethod_0(0);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_79()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = GClass116.smethod_6().zones.Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    this.cmy = this.cmtoY = Class15.smethod_0(0);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_80()
  {
    this.currentListLength = GClass20.smethod_1().arrItemBox.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(45);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_81()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = GClass20.smethod_2().arrItemBody.Length + GClass20.smethod_2().arrPetSkill.Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_82()
  {
    this.currentListLength = GClass20.smethod_1().arrItemBody.Length + GClass20.smethod_1().arrItemBag.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  private void method_83()
  {
    if ((!GClass141.bool_11 ? 0 : 1) == 0)
      return;
    if ((int) GClass185.sbyte_3 != (int) GClass185.sbyte_2)
    {
      GClass151.smethod_7(Class13.smethod_0(140188));
      GClass141.gclass66_2 = GClass62.smethod_39(Class13.smethod_0(139777) + GClass185.sbyte_2.ToString() + Class13.smethod_0(139878));
      GClass185.sbyte_3 = GClass185.sbyte_2;
    }
    this.cmxMap = this.method_1() - this.wScroll / Class15.smethod_0(7);
    this.cmyMap = this.method_2() + this.yScroll - (this.yScroll + this.hScroll / Class15.smethod_0(7));
    this.int_0 = this.cmxMap;
    this.int_1 = this.cmyMap;
    this.cmxMapLim = Class15.smethod_0(262) - this.wScroll;
    this.cmyMapLim = Class15.smethod_0(99) - this.hScroll;
    if (this.cmxMapLim < Class15.smethod_0(0))
      this.cmxMapLim = Class15.smethod_0(0);
    if (this.cmyMapLim < Class15.smethod_0(0))
      this.cmyMapLim = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < GClass141.int_16[(int) GClass185.sbyte_2].Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass141.int_16[(int) GClass185.sbyte_2][index])
      {
        this.int_73 = GClass141.int_17[(int) GClass185.sbyte_2][index] + this.xScroll;
        this.int_74 = GClass141.int_18[(int) GClass185.sbyte_2][index] + this.yScroll + Class15.smethod_0(3);
        break;
      }
    }
    this.int_69 = this.method_1() + this.xScroll;
    this.int_70 = this.method_2() + this.yScroll;
    this.int_71 = this.method_3() + this.xScroll;
    this.int_72 = this.method_4() + this.yScroll;
    Resources.UnloadUnusedAssets();
    GC.Collect();
  }

  private void method_84() => this.cmyQuest = Class15.smethod_0(0);

  public void method_85()
  {
    if (this.int_21 > Class15.smethod_0(0))
      this.int_21 -= Class15.smethod_0(1);
    if ((!this.bool_7 ? 1 : 0) == 0 && (!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0 && this.typeShop == Class15.smethod_0(7) && this.maxPageShop[this.currentTabIndex] > Class15.smethod_0(1))
    {
      if (this.cmy < Class15.smethod_0(141))
      {
        GClass71.smethod_1();
        this.bool_7 = Class15.smethod_0(0) != 0;
        if (this.currPageShop[this.currentTabIndex] <= Class15.smethod_0(0))
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.maxPageShop[this.currentTabIndex] - Class15.smethod_0(1), -1);
        else
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.currPageShop[this.currentTabIndex] - Class15.smethod_0(1), -1);
      }
      else if (this.cmy > this.cmyLim + Class15.smethod_0(32))
      {
        this.bool_7 = Class15.smethod_0(0) != 0;
        GClass71.smethod_1();
        if (this.currPageShop[this.currentTabIndex] >= this.maxPageShop[this.currentTabIndex] - Class15.smethod_0(1))
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, Class15.smethod_0(0), -1);
        else
          GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(2), -1, (sbyte) this.currentTabIndex, this.currPageShop[this.currentTabIndex] + Class15.smethod_0(1), -1);
      }
    }
    if (this.cmx != this.cmtoX && (!this.bool_4 ? 0 : 1) == 0)
    {
      this.int_61 = this.cmtoX - this.cmx << Class15.smethod_0(7);
      this.int_62 += this.int_61;
      this.cmx += this.int_62 >> Class15.smethod_0(5);
      this.int_62 &= Class15.smethod_0(9);
    }
    if (GClass93.smethod_0(this.cmtoX - this.cmx) < Class15.smethod_0(31))
      this.cmx = this.cmtoX;
    if ((!this.isClose ? 1 : 0) == 0)
    {
      this.isClose = Class15.smethod_0(0) != 0;
      this.cmtoX = this.wScroll;
    }
    if (this.cmtoX >= this.wScroll - Class15.smethod_0(31) && this.cmx >= this.wScroll - Class15.smethod_0(31) && (this.int_20 == 0 ? 0 : 1) == 0)
    {
      this.isShow = Class15.smethod_0(0) != 0;
      this.method_139();
      if ((!this.bool_12 ? 1 : 0) == 0)
      {
        this.bool_12 = Class15.smethod_0(0) != 0;
        if (GClass20.smethod_1().cHP > Class15.smethod_0(0) && GClass20.smethod_1().statusMe != Class15.smethod_0(49))
        {
          GClass71.smethod_1();
          if (this.type == Class15.smethod_0(5))
          {
            if (GClass116.smethod_6().numPlayer[this.selected] >= GClass116.smethod_6().maxPlayer[this.selected] && GClass185.int_39 != this.selected)
            {
              this.zoneID = this.selected;
              GClass62.gclass141_0.method_35();
              GClass62.gclass141_0.method_44();
            }
            else
            {
              GClass71.smethod_1();
              GClass156.smethod_0().method_43(this.selected, -1);
            }
          }
          else if (this.type == Class15.smethod_0(49))
            GClass156.smethod_0().method_126(this.selected);
        }
      }
      if ((!this.bool_9 ? 1 : 0) == 0)
      {
        this.bool_9 = Class15.smethod_0(0) != 0;
        ((GClass31) this.vPlayerMenu.method_3(this.selected)).method_1();
      }
      this.vPlayerMenu.method_9();
      this.charMenu = (GClass20) null;
    }
    if ((this.int_55 == 0 ? 1 : 0) == 0 && (!this.bool_4 ? 0 : 1) == 0)
    {
      this.cmtoY += this.int_55 / Class15.smethod_0(21);
      if (this.cmtoY < Class15.smethod_0(0))
        this.cmtoY = Class15.smethod_0(0);
      else if (this.cmtoY > this.cmyLim)
        this.cmtoY = this.cmyLim;
      else
        this.cmy = this.cmtoY;
      this.int_55 = this.int_55 * Class15.smethod_0(45) / Class15.smethod_0(31);
      if (this.int_55 < Class15.smethod_0(21) && this.int_55 > Class15.smethod_0(143))
        this.int_55 = Class15.smethod_0(0);
    }
    if (this.cmy != this.cmtoY && (!this.bool_4 ? 0 : 1) == 0)
    {
      this.cmvy = this.cmtoY - this.cmy << Class15.smethod_0(7);
      this.cmdy += this.cmvy;
      this.cmy += this.cmdy >> Class15.smethod_0(2);
      this.cmdy &= Class15.smethod_0(9);
    }
    this.cmyLast[this.currentTabIndex] = this.cmy;
  }

  public void method_86(GClass98 g)
  {
    if ((this.cp == null ? 1 : 0) != 0 || (this.cp.says == null ? 0 : 1) == 0)
      return;
    this.cp.vmethod_1(g);
    int x = this.cp.cx + Class15.smethod_0(47);
    int y = this.cp.cy + Class15.smethod_0(67);
    if (this.type == Class15.smethod_0(9))
    {
      x += Class15.smethod_0(3);
      y += Class15.smethod_0(50);
    }
    if ((this.type == 0 ? 0 : 1) == 0 && this.currentTabIndex == Class15.smethod_0(5))
    {
      if ((!this.isSearchClan ? 1 : 0) == 0)
        x -= Class15.smethod_0(3);
      else if ((this.partID == null ? 0 : 1) != 0 || (this.charInfo == null ? 1 : 0) == 0)
      {
        x = this.cp.cx + Class15.smethod_0(27);
        y = this.cp.cy + Class15.smethod_0(54);
      }
    }
    if ((this.partID == null ? 1 : 0) == 0)
    {
      GClass142 gclass142_1 = GClass116.gclass142_0[this.partID[Class15.smethod_0(0)]];
      GClass142 gclass142_2 = GClass116.gclass142_0[this.partID[Class15.smethod_0(1)]];
      GClass142 gclass142_3 = GClass116.gclass142_0[this.partID[Class15.smethod_0(7)]];
      GClass169.smethod_6(g, (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, x + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(1)] + (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(7)] + (int) gclass142_1.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
      GClass169.smethod_6(g, (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].id, x + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(1)] + (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].dx, y - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(7)] + (int) gclass142_2.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(1)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
      GClass169.smethod_6(g, (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].id, x + GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(1)] + (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].dx, y - GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(7)] + (int) gclass142_3.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(7)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
    }
    else if ((this.charInfo == null ? 1 : 0) == 0)
      this.charInfo.method_94(g, x + Class15.smethod_0(3), y + Class15.smethod_0(46), Class15.smethod_0(1), Class15.smethod_0(0), Class15.smethod_0(1) != 0);
    else if (this.idIcon != -1)
      GClass169.smethod_6(g, this.idIcon, x, y, Class15.smethod_0(0), Class15.smethod_0(5));
    if ((this.currItem == null ? 1 : 0) != 0 || (int) this.currItem.template.type == Class15.smethod_0(3))
      return;
    if (this.currItem.compare > Class15.smethod_0(0))
    {
      g.method_32(GClass141.gclass66_11, x - Class15.smethod_0(38), y + Class15.smethod_0(47), Class15.smethod_0(5));
      GClass97.gclass97_8.method_6(g, GClass151.smethod_25(this.currItem.compare).ToString() + string.Empty, x + Class15.smethod_0(1), y + Class15.smethod_0(88), Class15.smethod_0(0));
    }
    else
    {
      if (this.currItem.compare >= Class15.smethod_0(0) || this.currItem.compare == -1)
        return;
      g.method_32(GClass141.gclass66_12, x - Class15.smethod_0(38), y + Class15.smethod_0(47), Class15.smethod_0(5));
      GClass97.gclass97_1.method_6(g, GClass151.smethod_25(this.currItem.compare).ToString() + string.Empty, x + Class15.smethod_0(1), y + Class15.smethod_0(88), Class15.smethod_0(0));
    }
  }

  public void method_87(GClass98 g)
  {
    g.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    g.method_1(Class15.smethod_0(0), -this.cmy);
    g.method_16(Class15.smethod_0(0));
    if ((this.currentListLength == 0 ? 0 : 1) == 0)
      return;
    int num1 = (this.cmy + this.hScroll) / Class15.smethod_0(40) + Class15.smethod_0(1);
    if (num1 < this.hScroll / Class15.smethod_0(40) + Class15.smethod_0(1))
      num1 = this.hScroll / Class15.smethod_0(40) + Class15.smethod_0(1);
    if (num1 > this.currentListLength)
      num1 = this.currentListLength;
    int num2 = this.cmy / Class15.smethod_0(40);
    if (num2 >= num1)
      num2 = num1 - Class15.smethod_0(1);
    if (num2 < Class15.smethod_0(0))
      num2 = Class15.smethod_0(0);
    for (int index = num2; index < num1; index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y1 = this.yScroll + index * this.ITEM_HEIGHT;
      int w1 = Class15.smethod_0(40);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int x = this.xScroll + w1;
      int y2 = this.yScroll + index * this.ITEM_HEIGHT;
      int w2 = this.wScroll - w1;
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      g.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
      g.method_15(x, y2, w2, h2);
      g.method_16(index != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
      g.method_15(xScroll, y1, w1, h1);
      GClass187 gclass187 = (GClass187) this.vTop.method_3(index);
      if (gclass187.headICON != -1)
      {
        GClass169.smethod_6(g, gclass187.headICON, xScroll, y1, Class15.smethod_0(0), Class15.smethod_0(0));
      }
      else
      {
        GClass142 gclass142 = GClass116.gclass142_0[gclass187.headID];
        GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, xScroll + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y1 + h2 - Class15.smethod_0(1), Class15.smethod_0(0), GClass98.int_5 | GClass98.int_2);
      }
      g.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
      if (gclass187.pId != GClass20.smethod_1().charID)
        GClass97.gclass97_8.method_6(g, gclass187.name, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
      else
        GClass97.gclass97_1.method_6(g, gclass187.name, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
      GClass97.gclass97_18.method_6(g, gclass187.info, x + w2 - Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(1));
      GClass97.gclass97_14.method_6(g, GClass109.string_170 + Class13.smethod_0(140584) + gclass187.rank.ToString() + string.Empty, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
    }
    this.method_94(g);
  }

  public void method_88(GClass98 g)
  {
    g.method_1(-g.method_3(), -g.method_4() + GClass98.int_20);
    g.method_1(-this.cmx, Class15.smethod_0(0));
    g.method_1(this.X, this.Y);
    if (GClass62.gclass141_0.combineSuccess != (sbyte) -1)
    {
      if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) != 0)
        return;
      this.method_187(g);
    }
    else
    {
      GClass62.gclass140_0.method_35(this.X, this.Y, this.W, this.H, g);
      this.method_130(g);
      this.method_116(g);
      this.method_115(g);
      switch (this.type)
      {
        case 0:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_136(g);
          if (this.currentTabIndex == Class15.smethod_0(1))
            this.method_114(g);
          if (this.currentTabIndex == Class15.smethod_0(7))
            this.method_98(g);
          if (this.currentTabIndex == Class15.smethod_0(5))
          {
            if (this.mainTabName.Length == Class15.smethod_0(2))
              this.method_95(g);
            else
              this.method_111(g);
          }
          if (this.currentTabIndex == Class15.smethod_0(2))
          {
            this.method_95(g);
            break;
          }
          break;
        case 1:
          this.method_89(g);
          break;
        case 2:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_102(g);
          if (this.currentTabIndex == Class15.smethod_0(1))
          {
            this.method_114(g);
            break;
          }
          break;
        case 3:
          this.method_100(g);
          break;
        case 4:
          this.method_135(g);
          break;
        case 7:
          this.method_114(g);
          break;
        case 8:
          this.method_106(g);
          break;
        case 9:
          this.method_112(g);
          break;
        case 10:
          this.method_110(g);
          break;
        case 11:
          this.method_109(g);
          break;
        case 12:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_113(g);
          if (this.currentTabIndex == Class15.smethod_0(1))
          {
            this.method_114(g);
            break;
          }
          break;
        case 13:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
          {
            if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0)
              this.method_114(g);
            else
              this.method_57(g, Class15.smethod_0(0) != 0);
          }
          if (this.currentTabIndex == Class15.smethod_0(1))
            this.method_57(g, Class15.smethod_0(1) != 0);
          if (this.currentTabIndex == Class15.smethod_0(7))
          {
            this.method_57(g, Class15.smethod_0(0) != 0);
            break;
          }
          break;
        case 14:
          this.method_99(g);
          break;
        case 15:
          this.method_87(g);
          break;
        case 16:
          this.method_108(g);
          break;
        case 17:
          this.method_89(g);
          break;
        case 18:
          this.method_107(g);
          break;
        case 19:
          this.method_193(g);
          break;
        case 20:
          this.method_197(g);
          break;
        case 21:
          if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
            this.method_93(g);
          if (this.currentTabIndex == Class15.smethod_0(1))
            this.method_91(g);
          if (this.currentTabIndex == Class15.smethod_0(7))
          {
            this.method_114(g);
            break;
          }
          break;
        case 22:
          this.method_90(g);
          break;
        case 23:
          this.method_97(g);
          break;
        case 24:
          this.method_96(g);
          break;
        case 25:
          this.method_101(g);
          break;
      }
      GClass116.smethod_16(g);
      this.method_86(g);
      if (this.cmx == this.cmtoX)
        this.cmdClose.method_3(g);
      if ((this.tabIcon == null ? 1 : 0) != 0 || (!this.tabIcon.isShow ? 1 : 0) != 0)
        return;
      this.tabIcon.method_6(g);
    }
  }

  private void method_89(GClass98 gclass98_0)
  {
    if (this.type == Class15.smethod_0(1) && this.currentTabIndex == this.currentTabName.Length - Class15.smethod_0(1) && GClass62.gclass141_1 == null && this.typeShop != Class15.smethod_0(7))
    {
      this.method_114(gclass98_0);
    }
    else
    {
      gclass98_0.method_16(Class15.smethod_0(133));
      gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
      if (this.typeShop == Class15.smethod_0(7) && this.Equals((object) GClass62.gclass141_0))
      {
        if (this.currentTabIndex <= Class15.smethod_0(5) && GClass62.bool_5)
        {
          if (this.cmy < Class15.smethod_0(141))
            GClass62.smethod_44(this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + Class15.smethod_0(6), gclass98_0);
          else if (this.cmy < Class15.smethod_0(0))
            GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_415, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + Class15.smethod_0(9), Class15.smethod_0(7));
          else if (this.cmyLim >= Class15.smethod_0(0))
          {
            if (this.cmy > this.cmyLim + Class15.smethod_0(32))
              GClass62.smethod_44(this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll - Class15.smethod_0(6), gclass98_0);
            else if (this.cmy > this.cmyLim)
              GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_416, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll - Class15.smethod_0(46), Class15.smethod_0(7));
          }
        }
        if (GClass20.smethod_1().arrItemShop[this.currentTabIndex].Length == 0 && this.type != Class15.smethod_0(186))
        {
          GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_417, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - Class15.smethod_0(31), Class15.smethod_0(7));
          return;
        }
      }
      gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
      GClass80[] gclass80Array = GClass20.smethod_1().arrItemShop[this.currentTabIndex];
      if (this.typeShop == Class15.smethod_0(7) && (this.currentTabIndex == Class15.smethod_0(2) || this.type == Class15.smethod_0(186)))
      {
        gclass80Array = GClass20.smethod_1().arrItemShop[Class15.smethod_0(2)];
        if (gclass80Array.Length == 0)
        {
          GClass97.gclass97_16.method_6(gclass98_0, GClass109.string_417, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - Class15.smethod_0(31), Class15.smethod_0(7));
          return;
        }
      }
      int length = gclass80Array.Length;
      for (int index1 = Class15.smethod_0(0); index1 < length; index1 += Class15.smethod_0(1))
      {
        int x = this.xScroll + Class15.smethod_0(86);
        int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w1 = this.wScroll - Class15.smethod_0(86);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int xScroll = this.xScroll;
        int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w2 = Class15.smethod_0(117);
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
        {
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
          gclass98_0.method_15(x, y1, w1, h1);
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
          gclass98_0.method_15(xScroll, y2, w2, h2);
          GClass97.gclass97_17.method_6(gclass98_0, (index1 + Class15.smethod_0(1)).ToString() + string.Empty, xScroll + w2 - Class15.smethod_0(48), y2 - Class15.smethod_0(5), Class15.smethod_0(0));
          GClass80 gclass80 = gclass80Array[index1];
          if (gclass80 != null)
          {
            string str = string.Empty;
            GClass97 gclass97_1 = GClass97.gclass97_14;
            if (gclass80.isMe != (sbyte) 0 && this.typeShop == Class15.smethod_0(7) && this.currentTabIndex <= Class15.smethod_0(5) && !this.Equals((object) GClass62.gclass141_1))
              gclass97_1 = GClass97.gclass97_8;
            if (gclass80.itemOption != null)
            {
              for (int index2 = Class15.smethod_0(0); index2 < gclass80.itemOption.Length; index2 += Class15.smethod_0(1))
              {
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(107))
                {
                  str = Class13.smethod_0(140684) + gclass80.itemOption[index2].param.ToString() + Class13.smethod_0(140797);
                  gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index2].param);
                }
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(55))
                {
                  if (gclass80.itemOption[index2].param == Class15.smethod_0(1))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(7))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(5))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(2))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
                }
              }
            }
            gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
            string empty = string.Empty;
            if (gclass80.itemOption != null && gclass80.itemOption.Length >= Class15.smethod_0(1))
            {
              if (gclass80.itemOption[Class15.smethod_0(0)] != null && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(12))
                empty += gclass80.itemOption[Class15.smethod_0(0)].method_0();
              GClass97 gclass97_2 = GClass97.gclass97_18;
              if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
                gclass97_2 = GClass97.gclass97_17;
              if (this.typeShop == Class15.smethod_0(7) && gclass80.itemOption.Length > Class15.smethod_0(1) && gclass80.buyType != (sbyte) -1)
                empty += string.Empty;
              if (this.typeShop != Class15.smethod_0(7) || this.typeShop == Class15.smethod_0(7) && (int) gclass80.buyType <= Class15.smethod_0(1))
                gclass97_2.method_6(gclass98_0, empty, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), Class15.smethod_0(0));
            }
            if (gclass80.buySpec > Class15.smethod_0(0))
            {
              GClass169.smethod_6(gclass98_0, (int) gclass80.iconSpec, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(45), Class15.smethod_0(0), Class15.smethod_0(5));
              GClass97.gclass97_2.method_6(gclass98_0, GClass151.smethod_28((long) gclass80.buySpec), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
            }
            if (gclass80.buyCoin != 0 || gclass80.buyGold != 0)
            {
              if (this.typeShop != Class15.smethod_0(7) && gclass80.powerRequire == 0L)
              {
                if (gclass80.buyCoin > Class15.smethod_0(0) && gclass80.buyGold > Class15.smethod_0(0))
                {
                  if (gclass80.buyCoin > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_28((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                  if (gclass80.buyGold > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_9, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38) + Class15.smethod_0(67), Class15.smethod_0(5));
                    GClass97.gclass97_8.method_6(gclass98_0, GClass151.smethod_28((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(66), GClass97.int_1);
                  }
                }
                else
                {
                  if (gclass80.buyCoin > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_28((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                  if (gclass80.buyGold > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_9, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_8.method_6(gclass98_0, GClass151.smethod_28((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                }
              }
              if (this.typeShop == Class15.smethod_0(7) && this.currentTabIndex <= Class15.smethod_0(5) && !this.Equals((object) GClass62.gclass141_1))
              {
                if (gclass80.buyCoin > Class15.smethod_0(0) && gclass80.buyGold > Class15.smethod_0(0))
                {
                  if (gclass80.buyCoin > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                  if (gclass80.buyGold > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_9, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38) + Class15.smethod_0(67), Class15.smethod_0(5));
                    GClass97.gclass97_8.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(66), GClass97.int_1);
                  }
                }
                else
                {
                  if (gclass80.buyCoin > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                  if (gclass80.buyGold > Class15.smethod_0(0))
                  {
                    gclass98_0.method_32(GClass141.gclass66_9, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(38), Class15.smethod_0(5));
                    GClass97.gclass97_8.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(1), GClass97.int_1);
                  }
                }
              }
            }
            GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
            if (gclass80.quantity > Class15.smethod_0(1))
              GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
            if (gclass80.newItem && GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3))
              gclass98_0.method_32(GClass141.gclass66_6, xScroll + w2 / Class15.smethod_0(7), y1 + Class15.smethod_0(65), Class15.smethod_0(5));
          }
          if (this.typeShop == Class15.smethod_0(7) && (this.Equals((object) GClass62.gclass141_1) || this.currentTabIndex == Class15.smethod_0(2)) && gclass80.buyType != (sbyte) 0)
          {
            if ((int) gclass80.buyType == Class15.smethod_0(1))
            {
              GClass97.gclass97_19.method_6(gclass98_0, GClass109.string_410, x + w1 - Class15.smethod_0(3), y1 + Class15.smethod_0(1), GClass97.int_1);
              if (gclass80.buyCoin != -1)
              {
                gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(65), Class15.smethod_0(5));
                GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(47), GClass97.int_1);
              }
              else if (gclass80.buyGold != -1)
              {
                gclass98_0.method_32(GClass141.gclass66_10, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(186), Class15.smethod_0(5));
                GClass97.gclass97_1.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(67), GClass97.int_1);
              }
            }
            else if ((int) gclass80.buyType == Class15.smethod_0(7))
            {
              GClass97.gclass97_2.method_6(gclass98_0, GClass109.string_411, x + w1 - Class15.smethod_0(3), y1 + Class15.smethod_0(1), GClass97.int_1);
              if (gclass80.buyCoin != -1)
              {
                gclass98_0.method_32(GClass141.gclass66_7, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(186), Class15.smethod_0(5));
                GClass97.gclass97_4.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyCoin), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(67), GClass97.int_1);
              }
              else if (gclass80.buyGold != -1)
              {
                gclass98_0.method_32(GClass141.gclass66_10, x + w1 - Class15.smethod_0(38), y1 + Class15.smethod_0(186), Class15.smethod_0(5));
                GClass97.gclass97_1.method_6(gclass98_0, GClass151.smethod_29((long) gclass80.buyGold), x + w1 - Class15.smethod_0(9), y1 + Class15.smethod_0(67), GClass97.int_1);
              }
            }
          }
        }
      }
      this.method_94(gclass98_0);
    }
  }

  private void method_90(GClass98 gclass98_0)
  {
  }

  private void method_91(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < this.string_11.Length; index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, w, h);
        GClass97.gclass97_6.method_6(gclass98_0, this.string_11[index], this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(37), GClass97.int_2);
      }
    }
    this.isShowPet = Class15.smethod_0(0) != 0;
    if ((GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
      GClass156.smethod_0().method_127();
    this.method_94(gclass98_0);
  }

  private void method_92()
  {
  }

  private void method_93(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    GClass80[] arrItemBody = GClass20.smethod_2().arrItemBody;
    GClass161[] arrPetSkill = GClass20.smethod_2().arrPetSkill;
    for (int index1 = Class15.smethod_0(0); index1 < arrItemBody.Length + arrPetSkill.Length; index1 += Class15.smethod_0(1))
    {
      bool flag = index1 < arrItemBody.Length;
      int index2 = index1;
      int index3 = index1 - arrItemBody.Length;
      int x = this.xScroll + Class15.smethod_0(86);
      int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w1 = this.wScroll - Class15.smethod_0(86);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int xScroll = this.xScroll;
      int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w2 = Class15.smethod_0(117);
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        GClass80 gclass80 = !flag ? (GClass80) null : arrItemBody[index2];
        gclass98_0.method_16(index1 == this.selected ? Class15.smethod_0(104) : (!flag ? Class15.smethod_0(490) : Class15.smethod_0(485)));
        gclass98_0.method_15(x, y1, w1, h1);
        gclass98_0.method_16(index1 == this.selected ? Class15.smethod_0(489) : (!flag ? Class15.smethod_0(304) : Class15.smethod_0(488)));
        gclass98_0.method_15(xScroll, y2, w2, h2);
        if (gclass80 != null && gclass80.isSelect && GClass62.gclass141_0.type == Class15.smethod_0(66))
        {
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(492) : Class15.smethod_0(491));
          gclass98_0.method_15(xScroll, y2, w2, h2);
        }
        if (gclass80 != null)
        {
          string str = string.Empty;
          GClass97 gclass97_1 = GClass97.gclass97_14;
          if (gclass80.itemOption != null)
          {
            for (int index4 = Class15.smethod_0(0); index4 < gclass80.itemOption.Length; index4 += Class15.smethod_0(1))
            {
              if (gclass80.itemOption[index4].optionTemplate.id == Class15.smethod_0(107))
              {
                str = Class13.smethod_0(141834) + gclass80.itemOption[index4].param.ToString() + Class13.smethod_0(141945);
                gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index4].param);
              }
              if (gclass80.itemOption[index4].optionTemplate.id == Class15.smethod_0(55))
              {
                if (gclass80.itemOption[index4].param == Class15.smethod_0(1))
                  gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                else if (gclass80.itemOption[index4].param == Class15.smethod_0(7))
                  gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                else if (gclass80.itemOption[index4].param == Class15.smethod_0(5))
                  gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                else if (gclass80.itemOption[index4].param == Class15.smethod_0(2))
                  gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
              }
            }
          }
          gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
          string st = string.Empty;
          if (gclass80.itemOption != null)
          {
            if (gclass80.itemOption.Length != 0 && gclass80.itemOption[Class15.smethod_0(0)] != null && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(12))
              st += gclass80.itemOption[Class15.smethod_0(0)].method_0();
            GClass97 gclass97_2 = GClass97.gclass97_18;
            if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
              gclass97_2 = GClass97.gclass97_17;
            if (gclass80.itemOption.Length > Class15.smethod_0(1))
            {
              for (int index5 = Class15.smethod_0(1); index5 < Class15.smethod_0(7); index5 += Class15.smethod_0(1))
              {
                if (gclass80.itemOption[index5] != null && gclass80.itemOption[index5].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[index5].optionTemplate.id != Class15.smethod_0(12))
                  st = st + Class13.smethod_0(141931) + gclass80.itemOption[index5].method_0();
              }
            }
            gclass97_2.method_6(gclass98_0, st, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), GClass97.int_0);
          }
          GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
          if (gclass80.itemOption != null)
          {
            for (int index6 = Class15.smethod_0(0); index6 < gclass80.itemOption.Length; index6 += Class15.smethod_0(1))
              this.method_204(gclass98_0, gclass80.itemOption[index6].optionTemplate.id, gclass80.itemOption[index6].param, xScroll, y2, w2, h2);
            for (int index7 = Class15.smethod_0(0); index7 < gclass80.itemOption.Length; index7 += Class15.smethod_0(1))
              this.method_205(gclass98_0, gclass80.itemOption[index7].optionTemplate.id, gclass80.itemOption[index7].param, xScroll, y2, w2, h2);
          }
          if (gclass80.quantity > Class15.smethod_0(1))
            GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
        }
        else if (!flag)
        {
          GClass161 gclass161 = arrPetSkill[index3];
          if (gclass161.template != null)
          {
            GClass97.gclass97_18.method_6(gclass98_0, gclass161.template.name, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
            GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_268 + Class13.smethod_0(141929) + gclass161.point.ToString() + string.Empty, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), Class15.smethod_0(0));
            GClass169.smethod_6(gclass98_0, gclass161.template.iconId, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
          }
          else
          {
            GClass97.gclass97_14.method_6(gclass98_0, gclass161.moreInfo, x + Class15.smethod_0(3), y1 + Class15.smethod_0(3), Class15.smethod_0(0));
            GClass169.smethod_6(gclass98_0, GClass116.gclass49_0[Class15.smethod_0(419)].arrEfInfo[Class15.smethod_0(0)].idImg, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
          }
        }
      }
    }
    this.isShowPet = Class15.smethod_0(0) != 0;
    if (GClass62.int_8 % Class15.smethod_0(51) == 0)
      GClass156.smethod_0().method_127();
    this.method_94(gclass98_0);
  }

  private void method_94(GClass98 gclass98_0)
  {
    gclass98_0.method_1(-gclass98_0.method_3(), -gclass98_0.method_4());
    if (this.cmy > Class15.smethod_0(40) && this.currentListLength > Class15.smethod_0(0) || (!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0 && this.typeShop == Class15.smethod_0(7) && this.maxPageShop[this.currentTabIndex] > Class15.smethod_0(1))
      gclass98_0.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(1), this.xScroll + this.wScroll - Class15.smethod_0(66), this.yScroll + Class15.smethod_0(5), Class15.smethod_0(0));
    if ((this.cmy >= this.cmyLim || this.currentListLength <= Class15.smethod_0(0)) && ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) != 0 || this.typeShop != Class15.smethod_0(7) || this.maxPageShop[this.currentTabIndex] <= Class15.smethod_0(1)))
      return;
    gclass98_0.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.xScroll + this.wScroll - Class15.smethod_0(66), this.yScroll + this.hScroll - Class15.smethod_0(88), Class15.smethod_0(0));
  }

  private void method_95(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index1 = Class15.smethod_0(0); index1 < GClass141.string_1.Length; index1 += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, w, h);
        GClass97.gclass97_6.method_6(gclass98_0, GClass141.string_1[index1], this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(37), GClass97.int_2);
        if ((!GClass141.string_1[index1].Equals(GClass109.string_177) ? 1 : 0) == 0)
        {
          for (int index2 = Class15.smethod_0(0); index2 < GClass141.gclass134_0.method_2(); index2 += Class15.smethod_0(1))
          {
            if ((!((Class7) GClass141.gclass134_0.method_3(index2)).hasRead ? 0 : 1) == 0)
            {
              if (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31))
              {
                gclass98_0.method_32(GClass141.gclass66_6, xScroll + Class15.smethod_0(31), y + Class15.smethod_0(31), Class15.smethod_0(5));
                break;
              }
              break;
            }
          }
        }
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_96(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < GClass141.string_13.Length; index += Class15.smethod_0(1))
    {
      int num = this.yScroll + index * Class15.smethod_0(9);
      if (num - this.cmy <= this.yScroll + this.hScroll && num - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
        GClass97.gclass97_6.method_6(gclass98_0, GClass141.string_13[index], this.xScroll + Class15.smethod_0(3), num + Class15.smethod_0(37), GClass97.int_0);
    }
    this.method_94(gclass98_0);
  }

  private void method_97(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < GClass141.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      Class7 class7 = (Class7) GClass141.gclass134_0.method_3(index);
      int xScroll = this.xScroll;
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, w, h);
        GClass97.gclass97_6.method_6(gclass98_0, class7.main, this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(37), GClass97.int_2);
        if ((!class7.hasRead ? 0 : 1) == 0 && GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31))
          gclass98_0.method_32(GClass141.gclass66_6, xScroll + Class15.smethod_0(31), y + Class15.smethod_0(31), Class15.smethod_0(5));
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_98(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    int length = GClass20.smethod_1().nClass.skillTemplates.Length;
    for (int index1 = Class15.smethod_0(0); index1 < length + Class15.smethod_0(37); index1 += Class15.smethod_0(1))
    {
      int x1 = this.xScroll + Class15.smethod_0(6);
      int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(6);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int xScroll = this.xScroll;
      int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
      if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        if (index1 == Class15.smethod_0(3))
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(494) : Class15.smethod_0(493));
        gclass98_0.method_15(x1, y1, w, h);
        gclass98_0.method_32(GClass116.gclass66_14, xScroll, y2, Class15.smethod_0(0));
        if (index1 == 0)
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(495), xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          string[] strArray1 = new string[Class15.smethod_0(3)];
          strArray1[Class15.smethod_0(0)] = GClass109.string_369;
          strArray1[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray1[Class15.smethod_0(7)] = GClass109.string_330;
          strArray1[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray1[Class15.smethod_0(2)] = GClass138.smethod_9((long) GClass20.smethod_1().cHPGoc);
          string st1 = string.Concat(strArray1);
          GClass97.gclass97_2.method_6(gclass98_0, st1, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
          GClass97 gclass9714 = GClass97.gclass97_14;
          GClass98 g = gclass98_0;
          string[] strArray2 = new string[Class15.smethod_0(38)];
          strArray2[Class15.smethod_0(0)] = GClass138.smethod_9((long) (GClass20.smethod_1().cHPGoc + Class15.smethod_0(15)));
          strArray2[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray2[Class15.smethod_0(7)] = GClass109.string_381;
          strArray2[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray2[Class15.smethod_0(2)] = GClass109.string_355;
          strArray2[Class15.smethod_0(3)] = Class13.smethod_0(142452);
          strArray2[Class15.smethod_0(37)] = GClass20.smethod_1().hpFrom1000TiemNang.ToString();
          string st2 = string.Concat(strArray2);
          int x2 = x1 + Class15.smethod_0(3);
          int y3 = y1 + Class15.smethod_0(9);
          int align = Class15.smethod_0(0);
          gclass9714.method_6(g, st2, x2, y3, align);
        }
        if (index1 == Class15.smethod_0(1))
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(496), xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          string[] strArray3 = new string[Class15.smethod_0(3)];
          strArray3[Class15.smethod_0(0)] = GClass109.string_370;
          strArray3[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray3[Class15.smethod_0(7)] = GClass109.string_330;
          strArray3[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray3[Class15.smethod_0(2)] = GClass138.smethod_9((long) GClass20.smethod_1().cMPGoc);
          string st3 = string.Concat(strArray3);
          GClass97.gclass97_2.method_6(gclass98_0, st3, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
          GClass97 gclass9714 = GClass97.gclass97_14;
          GClass98 g = gclass98_0;
          string[] strArray4 = new string[Class15.smethod_0(38)];
          strArray4[Class15.smethod_0(0)] = GClass138.smethod_9((long) (GClass20.smethod_1().cMPGoc + Class15.smethod_0(15)));
          strArray4[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray4[Class15.smethod_0(7)] = GClass109.string_381;
          strArray4[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray4[Class15.smethod_0(2)] = GClass109.string_355;
          strArray4[Class15.smethod_0(3)] = Class13.smethod_0(142452);
          strArray4[Class15.smethod_0(37)] = GClass20.smethod_1().mpFrom1000TiemNang.ToString();
          string st4 = string.Concat(strArray4);
          int x3 = x1 + Class15.smethod_0(3);
          int y4 = y1 + Class15.smethod_0(9);
          int align = Class15.smethod_0(0);
          gclass9714.method_6(g, st4, x3, y4, align);
        }
        if (index1 == Class15.smethod_0(7))
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(497), xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          string[] strArray5 = new string[Class15.smethod_0(3)];
          strArray5[Class15.smethod_0(0)] = GClass109.string_371;
          strArray5[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray5[Class15.smethod_0(7)] = GClass109.string_330;
          strArray5[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray5[Class15.smethod_0(2)] = GClass138.smethod_9((long) GClass20.smethod_1().cDamGoc);
          string st5 = string.Concat(strArray5);
          GClass97.gclass97_2.method_6(gclass98_0, st5, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
          GClass97 gclass9714 = GClass97.gclass97_14;
          GClass98 g = gclass98_0;
          string[] strArray6 = new string[Class15.smethod_0(38)];
          strArray6[Class15.smethod_0(0)] = GClass138.smethod_9((long) (GClass20.smethod_1().cDamGoc * Class15.smethod_0(21)));
          strArray6[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray6[Class15.smethod_0(7)] = GClass109.string_381;
          strArray6[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray6[Class15.smethod_0(2)] = GClass109.string_355;
          strArray6[Class15.smethod_0(3)] = Class13.smethod_0(142452);
          strArray6[Class15.smethod_0(37)] = GClass20.smethod_1().damFrom1000TiemNang.ToString();
          string st6 = string.Concat(strArray6);
          int x4 = x1 + Class15.smethod_0(3);
          int y5 = y1 + Class15.smethod_0(9);
          int align = Class15.smethod_0(0);
          gclass9714.method_6(g, st6, x4, y5, align);
        }
        if (index1 == Class15.smethod_0(5))
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(498), xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          string[] strArray7 = new string[Class15.smethod_0(3)];
          strArray7[Class15.smethod_0(0)] = GClass109.string_372;
          strArray7[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray7[Class15.smethod_0(7)] = GClass109.string_330;
          strArray7[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray7[Class15.smethod_0(2)] = GClass138.smethod_9((long) GClass20.smethod_1().cDefGoc);
          string st7 = string.Concat(strArray7);
          GClass97.gclass97_2.method_6(gclass98_0, st7, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
          GClass97 gclass9714 = GClass97.gclass97_14;
          GClass98 g = gclass98_0;
          string[] strArray8 = new string[Class15.smethod_0(38)];
          strArray8[Class15.smethod_0(0)] = GClass138.smethod_9((long) (Class15.smethod_0(499) + GClass20.smethod_1().cDefGoc * Class15.smethod_0(17)));
          strArray8[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray8[Class15.smethod_0(7)] = GClass109.string_381;
          strArray8[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray8[Class15.smethod_0(2)] = GClass109.string_355;
          strArray8[Class15.smethod_0(3)] = Class13.smethod_0(142452);
          strArray8[Class15.smethod_0(37)] = GClass20.smethod_1().defFrom1000TiemNang.ToString();
          string st8 = string.Concat(strArray8);
          int x5 = x1 + Class15.smethod_0(3);
          int y6 = y1 + Class15.smethod_0(9);
          int align = Class15.smethod_0(0);
          gclass9714.method_6(g, st8, x5, y6, align);
        }
        if (index1 == Class15.smethod_0(2))
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(500), xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          string[] strArray9 = new string[Class15.smethod_0(37)];
          strArray9[Class15.smethod_0(0)] = GClass109.string_374;
          strArray9[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray9[Class15.smethod_0(7)] = GClass109.string_330;
          strArray9[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray9[Class15.smethod_0(2)] = GClass20.smethod_1().cCriticalGoc.ToString();
          strArray9[Class15.smethod_0(3)] = Class13.smethod_0(135351);
          string st9 = string.Concat(strArray9);
          int index2 = GClass20.smethod_1().cCriticalGoc;
          if (index2 > GClass141.long_0.Length - Class15.smethod_0(1))
            index2 = GClass141.long_0.Length - Class15.smethod_0(1);
          long num = GClass141.long_0[index2];
          GClass97.gclass97_2.method_6(gclass98_0, st9, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
          long number = num;
          GClass97 gclass9714 = GClass97.gclass97_14;
          GClass98 g = gclass98_0;
          string[] strArray10 = new string[Class15.smethod_0(38)];
          strArray10[Class15.smethod_0(0)] = GClass151.smethod_29(number);
          strArray10[Class15.smethod_0(1)] = Class13.smethod_0(142452);
          strArray10[Class15.smethod_0(7)] = GClass109.string_381;
          strArray10[Class15.smethod_0(5)] = Class13.smethod_0(142423);
          strArray10[Class15.smethod_0(2)] = GClass109.string_355;
          strArray10[Class15.smethod_0(3)] = Class13.smethod_0(142452);
          strArray10[Class15.smethod_0(37)] = GClass20.smethod_1().criticalFrom1000Tiemnang.ToString();
          string st10 = string.Concat(strArray10);
          int x6 = x1 + Class15.smethod_0(3);
          int y7 = y1 + Class15.smethod_0(9);
          int align = Class15.smethod_0(0);
          gclass9714.method_6(g, st10, x6, y7, align);
        }
        if (index1 == Class15.smethod_0(3))
        {
          if (GClass141.string_0 != null)
          {
            GClass169.smethod_6(gclass98_0, (int) GClass141.short_0, xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
            string[] strArray = GClass97.gclass97_11.method_15(GClass141.string_0, Class15.smethod_0(98));
            for (int index3 = Class15.smethod_0(0); index3 < strArray.Length; index3 += Class15.smethod_0(1))
              GClass97.gclass97_14.method_6(gclass98_0, strArray[index3], x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5) + index3 * Class15.smethod_0(66), Class15.smethod_0(0));
          }
          else
            GClass97.gclass97_14.method_6(gclass98_0, string.Empty, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(45), Class15.smethod_0(0));
        }
        if (index1 >= Class15.smethod_0(37))
        {
          int index4 = index1 - Class15.smethod_0(37);
          GClass167 skillTemplate = GClass20.smethod_1().nClass.skillTemplates[index4];
          GClass169.smethod_6(gclass98_0, skillTemplate.iconId, xScroll + Class15.smethod_0(2), y2 + Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
          GClass161 gclass161 = GClass20.smethod_1().method_12(skillTemplate);
          if (gclass161 != null)
          {
            GClass97.gclass97_2.method_6(gclass98_0, skillTemplate.name, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
            GClass97.gclass97_18.method_6(gclass98_0, GClass109.string_268 + Class13.smethod_0(142423) + gclass161.point.ToString(), x1 + w - Class15.smethod_0(3), y1 + Class15.smethod_0(5), GClass97.int_1);
            if (gclass161.point == skillTemplate.maxPoint)
            {
              GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_379, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(9), Class15.smethod_0(0));
            }
            else
            {
              GClass161 skill = skillTemplate.skills[gclass161.point];
              GClass97 gclass9714 = GClass97.gclass97_14;
              GClass98 g = gclass98_0;
              string[] strArray = new string[Class15.smethod_0(45)];
              strArray[Class15.smethod_0(0)] = GClass109.string_268;
              strArray[Class15.smethod_0(1)] = Class13.smethod_0(142452);
              strArray[Class15.smethod_0(7)] = (gclass161.point + Class15.smethod_0(1)).ToString();
              strArray[Class15.smethod_0(5)] = Class13.smethod_0(142452);
              strArray[Class15.smethod_0(2)] = GClass109.string_331;
              strArray[Class15.smethod_0(3)] = Class13.smethod_0(142452);
              strArray[Class15.smethod_0(37)] = GClass151.smethod_29(skill.powRequire);
              strArray[Class15.smethod_0(38)] = Class13.smethod_0(142452);
              strArray[Class15.smethod_0(88)] = GClass109.string_381;
              string st = string.Concat(strArray);
              int x7 = x1 + Class15.smethod_0(3);
              int y8 = y1 + Class15.smethod_0(9);
              int align = Class15.smethod_0(0);
              gclass9714.method_6(g, st, x7, y8, align);
            }
          }
          else
          {
            GClass161 skill = skillTemplate.skills[Class15.smethod_0(0)];
            GClass97.gclass97_8.method_6(gclass98_0, skillTemplate.name, x1 + Class15.smethod_0(3), y1 + Class15.smethod_0(5), Class15.smethod_0(0));
            GClass97 gclass9714 = GClass97.gclass97_14;
            GClass98 g = gclass98_0;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_332;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(142452);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29(skill.powRequire);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(142452);
            strArray[Class15.smethod_0(2)] = GClass109.string_352;
            string st = string.Concat(strArray);
            int x8 = x1 + Class15.smethod_0(3);
            int y9 = y1 + Class15.smethod_0(9);
            int align = Class15.smethod_0(0);
            gclass9714.method_6(g, st, x8, y9, align);
          }
        }
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_99(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < this.mapNames.Length; index += Class15.smethod_0(1))
    {
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(this.xScroll, y, this.wScroll, h);
        GClass97.gclass97_2.method_6(gclass98_0, this.mapNames[index], Class15.smethod_0(3), y + Class15.smethod_0(1), Class15.smethod_0(0));
        GClass97.gclass97_16.method_6(gclass98_0, this.planetNames[index], Class15.smethod_0(3), y + Class15.smethod_0(67), Class15.smethod_0(0));
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_100(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    int[] zones = GClass116.smethod_6().zones;
    int[] pts = GClass116.smethod_6().pts;
    for (int zoneId = Class15.smethod_0(0); zoneId < pts.Length; zoneId += Class15.smethod_0(1))
    {
      int x = this.xScroll + Class15.smethod_0(86);
      int y1 = this.yScroll + zoneId * this.ITEM_HEIGHT;
      int w1 = this.wScroll - Class15.smethod_0(86);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int xScroll = this.xScroll;
      int y2 = this.yScroll + zoneId * this.ITEM_HEIGHT;
      int w2 = Class15.smethod_0(117);
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(zoneId != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(x, y1, w1, h1);
        gclass98_0.method_16(this.int_64[pts[zoneId]]);
        gclass98_0.method_15(xScroll, y2, w2, h2);
        if (zones[zoneId] != -1)
        {
          if (pts[zoneId] != Class15.smethod_0(1))
            GClass97.gclass97_15.method_6(gclass98_0, zones[zoneId].ToString() + string.Empty, xScroll + w2 / Class15.smethod_0(7), y1 + Class15.smethod_0(37), GClass97.int_2);
          else
            GClass97.gclass97_16.method_6(gclass98_0, zones[zoneId].ToString() + string.Empty, xScroll + w2 / Class15.smethod_0(7), y1 + Class15.smethod_0(37), GClass97.int_2);
          if (this.zoneID != -1 && this.zoneID == zoneId)
          {
            GClass97.gclass97_1.method_6(gclass98_0, GClass116.smethod_6().numPlayer[zoneId].ToString() + Class13.smethod_0(135960) + GClass116.smethod_6().maxPlayer[zoneId].ToString() + Class13.smethod_0(135954), x + Class15.smethod_0(3), y1 + Class15.smethod_0(37), Class15.smethod_0(0));
            if (GClass116.smethod_6().numPlayer[zoneId] < GClass116.smethod_6().maxPlayer[zoneId])
            {
              this.zoneID = -1;
              GClass156.smethod_0().method_43(zoneId, -1);
            }
          }
          else
            GClass97.gclass97_14.method_6(gclass98_0, GClass116.smethod_6().numPlayer[zoneId].ToString() + Class13.smethod_0(135960) + GClass116.smethod_6().maxPlayer[zoneId].ToString() + (GClass116.smethod_6().numPlayer[zoneId] < GClass116.smethod_6().maxPlayer[zoneId] || GClass185.int_39 == zoneId ? "" : Class13.smethod_0(136051)), x + Class15.smethod_0(3), y1 + Class15.smethod_0(37), Class15.smethod_0(0));
        }
        if ((GClass116.smethod_6().rankName1[zoneId] == null ? 1 : 0) == 0)
        {
          GClass97.gclass97_16.method_6(gclass98_0, GClass116.smethod_6().rankName1[zoneId] + Class13.smethod_0(136017) + GClass116.smethod_6().rank1[zoneId].ToString() + Class13.smethod_0(136011), x + w1 - Class15.smethod_0(7), y1 + Class15.smethod_0(1), GClass97.int_1);
          GClass97.gclass97_16.method_6(gclass98_0, GClass116.smethod_6().rankName2[zoneId] + Class13.smethod_0(136017) + GClass116.smethod_6().rank2[zoneId].ToString() + Class13.smethod_0(136011), x + w1 - Class15.smethod_0(7), y1 + Class15.smethod_0(67), GClass97.int_1);
        }
      }
    }
    this.isShowZone = Class15.smethod_0(0) != 0;
    this.method_94(gclass98_0);
    if ((GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) != 0)
      return;
    GClass156.smethod_0().method_59();
  }

  private void method_101(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    if ((this.currentListLength == 0 ? 0 : 1) == 0)
      return;
    int num1 = (this.cmy + this.hScroll) / Class15.smethod_0(40) + Class15.smethod_0(1);
    if (num1 < this.hScroll / Class15.smethod_0(40) + Class15.smethod_0(1))
      num1 = this.hScroll / Class15.smethod_0(40) + Class15.smethod_0(1);
    if (num1 > this.currentListLength)
      num1 = this.currentListLength;
    int num2 = this.cmy / Class15.smethod_0(40);
    if (num2 >= num1)
      num2 = num1 - Class15.smethod_0(1);
    if (num2 < Class15.smethod_0(0))
      num2 = Class15.smethod_0(0);
    for (int index1 = num2; index1 < num1; index1 += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w1 = Class15.smethod_0(40);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int x = this.xScroll + w1;
      int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w2 = this.wScroll - w1;
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
      gclass98_0.method_15(x, y2, w2, h2);
      gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
      gclass98_0.method_15(xScroll, y1, w1, h1);
      GClass169.smethod_6(gclass98_0, (int) GClass20.smethod_1().imgSpeacialSkill[this.currentTabIndex][index1], xScroll + w1 / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
      string[] strArray = GClass97.gclass97_16.method_15(GClass20.smethod_1().infoSpeacialSkill[this.currentTabIndex][index1], Class15.smethod_0(399));
      for (int index2 = Class15.smethod_0(0); index2 < strArray.Length; index2 += Class15.smethod_0(1))
        GClass97.gclass97_16.method_6(gclass98_0, strArray[index2], x + Class15.smethod_0(3), y2 + Class15.smethod_0(1) + index2 * Class15.smethod_0(67), Class15.smethod_0(0));
    }
    this.method_94(gclass98_0);
  }

  private void method_102(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    try
    {
      GClass80[] arrItemBox = GClass20.smethod_1().arrItemBox;
      this.currentListLength = arrItemBox.Length;
      this.TAB_W_NEW = this.wScroll / (arrItemBox.Length / Class15.smethod_0(51) + (arrItemBox.Length % Class15.smethod_0(51) > Class15.smethod_0(0) ? Class15.smethod_0(1) : Class15.smethod_0(0)));
      for (int index1 = Class15.smethod_0(0); index1 < this.currentListLength; index1 += Class15.smethod_0(1))
      {
        int x = this.xScroll + Class15.smethod_0(86);
        int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w1 = this.wScroll - Class15.smethod_0(86);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int xScroll = this.xScroll;
        int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w2 = Class15.smethod_0(117);
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
        {
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
          gclass98_0.method_15(x, y1, w1, h1);
          gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
          GClass80 gclass80 = arrItemBox[index1];
          gclass98_0.method_15(xScroll, y2, w2, h2);
          GClass97.gclass97_17.method_6(gclass98_0, (index1 + Class15.smethod_0(1)).ToString() + string.Empty, xScroll + w2 - Class15.smethod_0(48), y2 - Class15.smethod_0(5), Class15.smethod_0(0));
          if (gclass80 != null)
          {
            string str = string.Empty;
            GClass97 gclass97_1 = GClass97.gclass97_14;
            if (gclass80.itemOption != null)
            {
              for (int index2 = Class15.smethod_0(0); index2 < gclass80.itemOption.Length; index2 += Class15.smethod_0(1))
              {
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(107))
                {
                  str = Class13.smethod_0(136009) + gclass80.itemOption[index2].param.ToString() + Class13.smethod_0(136949);
                  gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index2].param);
                }
                if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(55))
                {
                  if (gclass80.itemOption[index2].param == Class15.smethod_0(1))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(7))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(5))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                  else if (gclass80.itemOption[index2].param == Class15.smethod_0(2))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
                }
              }
            }
            gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
            string st = string.Empty;
            if (gclass80.itemOption != null)
            {
              if (gclass80.itemOption.Length != 0 && gclass80.itemOption[Class15.smethod_0(0)] != null)
                st += gclass80.itemOption[Class15.smethod_0(0)].method_0();
              GClass97 gclass97_2 = GClass97.gclass97_18;
              if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
                gclass97_2 = GClass97.gclass97_17;
              if (gclass80.itemOption.Length > Class15.smethod_0(1))
              {
                for (int index3 = Class15.smethod_0(1); index3 < gclass80.itemOption.Length; index3 += Class15.smethod_0(1))
                {
                  if (gclass80.itemOption[index3] != null && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(12))
                    st = st + Class13.smethod_0(136947) + gclass80.itemOption[index3].method_0();
                }
              }
              gclass97_2.method_6(gclass98_0, st, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), GClass97.int_0);
            }
            GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
            if (gclass80.itemOption != null)
            {
              for (int index4 = Class15.smethod_0(0); index4 < gclass80.itemOption.Length; index4 += Class15.smethod_0(1))
                this.method_204(gclass98_0, gclass80.itemOption[index4].optionTemplate.id, gclass80.itemOption[index4].param, xScroll, y2, w2, h2);
              for (int index5 = Class15.smethod_0(0); index5 < gclass80.itemOption.Length; index5 += Class15.smethod_0(1))
                this.method_205(gclass98_0, gclass80.itemOption[index5].optionTemplate.id, gclass80.itemOption[index5].param, xScroll, y2, w2, h2);
            }
            if (gclass80.quantity > Class15.smethod_0(1))
              GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    this.method_94(gclass98_0);
  }

  public GClass94 method_103()
  {
    if (this.selected < Class15.smethod_0(7))
      return (GClass94) null;
    if (this.selected > ((this.member == null ? 1 : 0) != 0 ? this.myMember.method_2() : this.member.method_2()) + Class15.smethod_0(1))
      return (GClass94) null;
    return (this.member == null ? 1 : 0) == 0 ? (GClass94) this.member.method_3(this.selected - Class15.smethod_0(7)) : (GClass94) this.myMember.method_3(this.selected - Class15.smethod_0(7));
  }

  public GClass28 method_104()
  {
    if (this.selected < Class15.smethod_0(7))
      return (GClass28) null;
    return this.selected > GClass28.gclass134_0.method_2() + Class15.smethod_0(1) ? (GClass28) null : (GClass28) GClass28.gclass134_0.method_3(this.selected - Class15.smethod_0(7));
  }

  public GClass25 method_105()
  {
    if (this.selected < Class15.smethod_0(7))
      return (GClass25) null;
    return this.selected > this.clans.Length + Class15.smethod_0(1) ? (GClass25) null : this.clans[this.selected - Class15.smethod_0(7)];
  }

  private void method_106(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    if ((this.logChat.method_2() == 0 ? 0 : 1) == 0)
      GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_62, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - GClass97.gclass97_11.method_20() / Class15.smethod_0(7) + Class15.smethod_0(40), Class15.smethod_0(7));
    for (int index = Class15.smethod_0(0); index < this.currentListLength; index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y1 = this.yScroll + index * this.ITEM_HEIGHT;
      int w1 = Class15.smethod_0(40);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int x = this.xScroll + w1;
      int y2 = this.yScroll + index * this.ITEM_HEIGHT;
      int w2 = this.wScroll - w1;
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if ((index == 0 ? 0 : 1) == 0)
      {
        gclass98_0.method_16(Class15.smethod_0(485));
        gclass98_0.method_15(xScroll, y2, this.wScroll, h2);
        gclass98_0.method_32(index != this.selected ? GClass116.gclass66_24 : GClass116.gclass66_25, this.xScroll + this.wScroll - Class15.smethod_0(3), y2 + Class15.smethod_0(7), GClass177.int_2);
        (index != this.selected ? GClass97.gclass97_6 : GClass97.gclass97_7).method_6(gclass98_0, (!this.isViewChatServer ? 1 : 0) != 0 ? GClass109.string_397 : GClass109.string_396, this.xScroll + this.wScroll - Class15.smethod_0(28), y2 + Class15.smethod_0(38), Class15.smethod_0(7));
        GClass97.gclass97_16.method_6(gclass98_0, (!this.isViewChatServer ? 1 : 0) != 0 ? GClass109.string_400 : GClass109.string_399, this.xScroll + Class15.smethod_0(3), y2 + h2 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_0);
      }
      else
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(x, y2, w2, h2);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
        gclass98_0.method_15(xScroll, y1, w1, h1);
        GClass72 gclass72 = (GClass72) this.logChat.method_3(index - Class15.smethod_0(1));
        if (gclass72.charInfo.headICON != -1)
        {
          GClass169.smethod_6(gclass98_0, gclass72.charInfo.headICON, xScroll, y1, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        else
        {
          GClass142 gclass142 = GClass116.gclass142_0[gclass72.charInfo.head];
          GClass169.smethod_6(gclass98_0, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, xScroll + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y1 + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        gclass98_0.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
        GClass97.gclass97_7.method_6(gclass98_0, gclass72.charInfo.cName, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
        if ((!gclass72.isChatServer ? 0 : 1) == 0)
          GClass97.gclass97_18.method_6(gclass98_0, GClass151.smethod_27(gclass72.s, Class13.smethod_0(137426), Class15.smethod_0(0))[Class15.smethod_0(7)], x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
        else
          GClass97.gclass97_17.method_6(gclass98_0, GClass151.smethod_27(gclass72.s, Class13.smethod_0(137426), Class15.smethod_0(0))[Class15.smethod_0(7)], x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_107(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    for (int index = Class15.smethod_0(0); index < this.currentListLength; index += Class15.smethod_0(1))
    {
      int x = this.xScroll + Class15.smethod_0(50);
      int y1 = this.yScroll + index * this.ITEM_HEIGHT;
      int w1 = this.wScroll - Class15.smethod_0(50);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int xScroll = this.xScroll;
      int y2 = this.yScroll + index * this.ITEM_HEIGHT;
      int w2 = Class15.smethod_0(40);
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(x, y1, w1, h1);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
        gclass98_0.method_15(xScroll, y2, w2, h2);
        GClass80 gclass80 = (GClass80) this.vFlag.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
        {
          GClass97.gclass97_14.method_6(gclass98_0, gclass80.template.name, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
          string empty = string.Empty;
          if ((gclass80.itemOption == null ? 1 : 0) == 0 && gclass80.itemOption.Length >= Class15.smethod_0(1))
          {
            if ((gclass80.itemOption[Class15.smethod_0(0)] == null ? 1 : 0) == 0 && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(12))
              empty += gclass80.itemOption[Class15.smethod_0(0)].method_0();
            GClass97.gclass97_18.method_6(gclass98_0, empty, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), Class15.smethod_0(0));
            GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
          }
        }
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_108(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    if ((this.currentListLength == 0 ? 0 : 1) == 0)
    {
      GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_402, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - GClass97.gclass97_11.method_20() / Class15.smethod_0(7), Class15.smethod_0(7));
    }
    else
    {
      for (int index = Class15.smethod_0(0); index < this.currentListLength; index += Class15.smethod_0(1))
      {
        int xScroll = this.xScroll;
        int y1 = this.yScroll + index * this.ITEM_HEIGHT;
        int w1 = Class15.smethod_0(40);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int x = this.xScroll + w1;
        int y2 = this.yScroll + index * this.ITEM_HEIGHT;
        int w2 = this.wScroll - w1;
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(x, y2, w2, h2);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
        gclass98_0.method_15(xScroll, y1, w1, h1);
        GClass72 gclass72 = (GClass72) this.vEnemy.method_3(index);
        if (gclass72.charInfo.headICON != -1)
        {
          GClass169.smethod_6(gclass98_0, gclass72.charInfo.headICON, xScroll, y1, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        else
        {
          GClass142 gclass142 = GClass116.gclass142_0[gclass72.charInfo.head];
          GClass169.smethod_6(gclass98_0, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, xScroll + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y1 + Class15.smethod_0(5) + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        gclass98_0.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
        if ((!gclass72.isOnline ? 1 : 0) == 0)
        {
          GClass97.gclass97_8.method_6(gclass98_0, gclass72.charInfo.cName, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
          GClass97.gclass97_18.method_6(gclass98_0, gclass72.s, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
        }
        else
        {
          GClass97.gclass97_16.method_6(gclass98_0, gclass72.charInfo.cName, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
          GClass97.gclass97_16.method_6(gclass98_0, gclass72.s, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
        }
      }
      this.method_94(gclass98_0);
    }
  }

  private void method_109(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    if ((this.currentListLength == 0 ? 0 : 1) == 0)
    {
      GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_174, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - GClass97.gclass97_11.method_20() / Class15.smethod_0(7), Class15.smethod_0(7));
    }
    else
    {
      for (int index = Class15.smethod_0(0); index < this.currentListLength; index += Class15.smethod_0(1))
      {
        int xScroll = this.xScroll;
        int y1 = this.yScroll + index * this.ITEM_HEIGHT;
        int w1 = Class15.smethod_0(40);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int x = this.xScroll + w1;
        int y2 = this.yScroll + index * this.ITEM_HEIGHT;
        int w2 = this.wScroll - w1;
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(x, y2, w2, h2);
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
        gclass98_0.method_15(xScroll, y1, w1, h1);
        GClass72 gclass72 = (GClass72) this.vFriend.method_3(index);
        if (gclass72.charInfo.headICON != -1)
        {
          GClass169.smethod_6(gclass98_0, gclass72.charInfo.headICON, xScroll, y1, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        else
        {
          GClass142 gclass142 = GClass116.gclass142_0[gclass72.charInfo.head];
          GClass169.smethod_6(gclass98_0, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, xScroll + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y1 + Class15.smethod_0(5) + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
        }
        gclass98_0.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
        if ((!gclass72.isOnline ? 1 : 0) == 0)
        {
          GClass97.gclass97_8.method_6(gclass98_0, gclass72.charInfo.cName, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
          GClass97.gclass97_18.method_6(gclass98_0, gclass72.s, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
        }
        else
        {
          GClass97.gclass97_16.method_6(gclass98_0, gclass72.charInfo.cName, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
          GClass97.gclass97_16.method_6(gclass98_0, gclass72.s, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
        }
      }
      this.method_94(gclass98_0);
    }
  }

  public void method_110(GClass98 g)
  {
    g.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    g.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < this.vPlayerMenu.method_2(); index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        GClass31 gclass31 = (GClass31) this.vPlayerMenu.method_3(index);
        g.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        g.method_15(xScroll, y, w, h);
        if ((!gclass31.caption2.Equals(string.Empty) ? 1 : 0) == 0)
        {
          GClass97.gclass97_6.method_6(g, gclass31.caption, this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(37), GClass97.int_2);
        }
        else
        {
          GClass97.gclass97_6.method_6(g, gclass31.caption, this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(1), GClass97.int_2);
          GClass97.gclass97_6.method_6(g, gclass31.caption2, this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(67), GClass97.int_2);
        }
      }
    }
    this.method_94(g);
  }

  private void method_111(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(-this.cmx, -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    int num1 = this.xScroll + this.wScroll / Class15.smethod_0(7) - this.clansOption.Length * this.TAB_W / Class15.smethod_0(7);
    if (this.currentListLength == Class15.smethod_0(7))
    {
      GClass97.gclass97_14.method_6(gclass98_0, this.clanReport, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + Class15.smethod_0(40) + this.hScroll / Class15.smethod_0(7) - GClass97.gclass97_11.method_20() / Class15.smethod_0(7), Class15.smethod_0(7));
      if (this.isMessage && this.myMember.method_2() == Class15.smethod_0(1))
      {
        for (int index = Class15.smethod_0(0); index < GClass109.string_275.Length; index += Class15.smethod_0(1))
          GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_275[index], this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + Class15.smethod_0(40) + this.hScroll / Class15.smethod_0(7) - GClass109.string_275.Length * Class15.smethod_0(66) / Class15.smethod_0(7) + index * Class15.smethod_0(66), GClass97.int_2);
      }
    }
    if (this.isMessage)
      this.currentListLength = GClass28.gclass134_0.method_2() + Class15.smethod_0(7);
    for (int index1 = Class15.smethod_0(0); index1 < this.currentListLength; index1 += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w1 = Class15.smethod_0(40);
      int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      int x = this.xScroll + w1;
      int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
      int w2 = this.wScroll - w1;
      int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y2 - this.cmy <= this.yScroll + this.hScroll && y2 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        if (index1 != 0)
        {
          if (index1 != Class15.smethod_0(1))
          {
            if (this.isSearchClan)
            {
              if (this.clans != null && this.clans.Length != 0)
              {
                gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
                gclass98_0.method_15(x, y2, w2, h2);
                gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
                gclass98_0.method_15(xScroll, y1, w1, h1);
                if (GClass26.smethod_2(this.clans[index1 - Class15.smethod_0(7)].imgID))
                {
                  if (GClass26.smethod_1((short) this.clans[index1 - Class15.smethod_0(7)].imgID).idImage != null)
                    GClass169.smethod_6(gclass98_0, (int) GClass26.smethod_1((short) this.clans[index1 - Class15.smethod_0(7)].imgID).idImage[Class15.smethod_0(0)], xScroll + w1 / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7), Class15.smethod_0(0), GClass177.int_6);
                }
                else
                {
                  GClass26 cm = new GClass26();
                  cm.ID = this.clans[index1 - Class15.smethod_0(7)].imgID;
                  if (!GClass26.smethod_2(cm.ID))
                    GClass26.smethod_0(cm);
                }
                string st = this.clans[index1 - Class15.smethod_0(7)].name.Length <= Class15.smethod_0(29) ? this.clans[index1 - Class15.smethod_0(7)].name : this.clans[index1 - Class15.smethod_0(7)].name.Substring(Class15.smethod_0(0), Class15.smethod_0(29)) + Class13.smethod_0(137809);
                GClass97.gclass97_7.method_6(gclass98_0, st, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
                gclass98_0.method_5(x, y2, w2 - Class15.smethod_0(31), h2);
                GClass97.gclass97_18.method_6(gclass98_0, this.clans[index1 - Class15.smethod_0(7)].slogan, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
                gclass98_0.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
                GClass97.gclass97_14.method_6(gclass98_0, this.clans[index1 - Class15.smethod_0(7)].currMember.ToString() + Class13.smethod_0(137856) + this.clans[index1 - Class15.smethod_0(7)].maxMember.ToString(), x + w2 - Class15.smethod_0(3), y2, GClass97.int_1);
              }
            }
            else if (this.isViewMember)
            {
              gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
              gclass98_0.method_15(x, y2, w2, h2);
              gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
              gclass98_0.method_15(xScroll, y1, w1, h1);
              GClass94 gclass94 = this.member == null ? (GClass94) this.myMember.method_3(index1 - Class15.smethod_0(7)) : (GClass94) this.member.method_3(index1 - Class15.smethod_0(7));
              if (gclass94.headICON != (short) -1)
              {
                GClass169.smethod_6(gclass98_0, (int) gclass94.headICON, xScroll, y1, Class15.smethod_0(0), Class15.smethod_0(0));
              }
              else
              {
                GClass142 gclass142 = GClass116.gclass142_0[(int) gclass94.head];
                GClass169.smethod_6(gclass98_0, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, xScroll + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dx, y1 + Class15.smethod_0(5) + (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].dy, Class15.smethod_0(0), Class15.smethod_0(0));
              }
              gclass98_0.method_5(this.xScroll, this.yScroll + this.cmy, this.wScroll, this.hScroll);
              GClass97 gclass97 = GClass97.gclass97_6;
              if (gclass94.role == (sbyte) 0)
                gclass97 = GClass97.gclass97_1;
              else if ((int) gclass94.role == Class15.smethod_0(1))
                gclass97 = GClass97.gclass97_8;
              else if ((int) gclass94.role == Class15.smethod_0(7))
                gclass97 = GClass97.gclass97_7;
              gclass97.method_6(gclass98_0, gclass94.name, x + Class15.smethod_0(3), y2, Class15.smethod_0(0));
              GClass97.gclass97_18.method_6(gclass98_0, GClass109.string_254 + Class13.smethod_0(137971) + gclass94.powerPoint, x + Class15.smethod_0(3), y2 + Class15.smethod_0(67), Class15.smethod_0(0));
              GClass169.smethod_6(gclass98_0, Class15.smethod_0(501), x + w2 - Class15.smethod_0(38), y2 + Class15.smethod_0(66), Class15.smethod_0(0), Class15.smethod_0(5));
              GClass97.gclass97_18.method_6(gclass98_0, string.Empty + gclass94.clanPoint.ToString(), x + w2 - Class15.smethod_0(9), y2 + Class15.smethod_0(37), GClass97.int_1);
            }
            else if (this.isMessage && GClass28.gclass134_0.method_2() != 0)
            {
              GClass28 gclass28 = (GClass28) GClass28.gclass134_0.method_3(index1 - Class15.smethod_0(7));
              gclass98_0.method_16(index1 != this.selected || gclass28.option != null ? Class15.smethod_0(485) : Class15.smethod_0(104));
              gclass98_0.method_15(xScroll, y1, w2 + w1, h2);
              gclass28.method_0(gclass98_0, xScroll, y1);
              if (gclass28.option != null)
              {
                int num2 = this.xScroll + this.wScroll - Class15.smethod_0(7) - gclass28.option.Length * Class15.smethod_0(54);
                for (int index2 = Class15.smethod_0(0); index2 < gclass28.option.Length; index2 += Class15.smethod_0(1))
                {
                  if (index2 == this.int_23 && index1 == this.selected)
                  {
                    gclass98_0.method_32(GClass116.gclass66_25, num2 + index2 * Class15.smethod_0(54) + Class15.smethod_0(51), y2 + h2 / Class15.smethod_0(7), GClass177.int_6);
                    GClass97.gclass97_7.method_6(gclass98_0, gclass28.option[index2], num2 + index2 * Class15.smethod_0(54) + Class15.smethod_0(51), y2 + Class15.smethod_0(37), GClass97.int_2);
                  }
                  else
                  {
                    gclass98_0.method_32(GClass116.gclass66_24, num2 + index2 * Class15.smethod_0(54) + Class15.smethod_0(51), y2 + h2 / Class15.smethod_0(7), GClass177.int_6);
                    GClass97.gclass97_6.method_6(gclass98_0, gclass28.option[index2], num2 + index2 * Class15.smethod_0(54) + Class15.smethod_0(51), y2 + Class15.smethod_0(37), GClass97.int_2);
                  }
                }
              }
            }
          }
          else
          {
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
            gclass98_0.method_15(this.xScroll, y2, this.wScroll, h2);
            if (this.clanInfo != null)
              GClass97.gclass97_6.method_6(gclass98_0, this.clanInfo, this.xScroll + this.wScroll / Class15.smethod_0(7), y2 + Class15.smethod_0(37), GClass97.int_2);
          }
        }
        else
        {
          for (int index3 = Class15.smethod_0(0); index3 < this.clansOption.Length; index3 += Class15.smethod_0(1))
          {
            gclass98_0.method_16(index3 != this.int_23 || index1 != this.selected ? Class15.smethod_0(490) : Class15.smethod_0(104));
            gclass98_0.method_15(num1 + index3 * this.TAB_W, y2, this.TAB_W - Class15.smethod_0(1), Class15.smethod_0(29));
            for (int index4 = Class15.smethod_0(0); index4 < this.clansOption[index3].Length; index4 += Class15.smethod_0(1))
              GClass97.gclass97_16.method_6(gclass98_0, this.clansOption[index3][index4], num1 + index3 * this.TAB_W + this.TAB_W / Class15.smethod_0(7), this.yScroll + index4 * Class15.smethod_0(67), GClass97.int_2);
          }
        }
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_112(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    gclass98_0.method_16(Class15.smethod_0(0));
    if ((this.currentListLength == 0 ? 0 : 1) == 0)
    {
      GClass97.gclass97_14.method_6(gclass98_0, GClass109.string_391, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - GClass97.gclass97_11.method_20() / Class15.smethod_0(7), Class15.smethod_0(7));
    }
    else
    {
      if ((GClass20.smethod_1().arrArchive == null ? 1 : 0) != 0 || GClass20.smethod_1().arrArchive.Length != this.currentListLength)
        return;
      for (int index = Class15.smethod_0(0); index < this.currentListLength; index += Class15.smethod_0(1))
      {
        int xScroll = this.xScroll;
        int y = this.yScroll + index * this.ITEM_HEIGHT;
        int wScroll = this.wScroll;
        int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
        GClass0 gclass0 = GClass20.smethod_1().arrArchive[index];
        gclass98_0.method_16(index != this.selected || ((!gclass0.isRecieve ? 0 : 1) != 0 || (!gclass0.isFinish ? 1 : 0) == 0) && ((!gclass0.isRecieve ? 1 : 0) != 0 || (!gclass0.isFinish ? 1 : 0) != 0) ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, wScroll, h);
        if ((gclass0 == null ? 1 : 0) == 0)
        {
          if ((!gclass0.isFinish ? 0 : 1) == 0)
          {
            GClass97.gclass97_11.method_6(gclass98_0, gclass0.info1, xScroll + Class15.smethod_0(3), y, Class15.smethod_0(0));
            GClass97.gclass97_19.method_6(gclass98_0, gclass0.money.ToString() + Class13.smethod_0(138877) + GClass109.string_158, xScroll + wScroll - Class15.smethod_0(3), y, GClass97.int_1);
            GClass97.gclass97_17.method_6(gclass98_0, gclass0.info2, xScroll + Class15.smethod_0(3), y + Class15.smethod_0(67), Class15.smethod_0(0));
          }
          else if ((!gclass0.isFinish ? 1 : 0) == 0 && (!gclass0.isRecieve ? 0 : 1) == 0)
          {
            GClass97.gclass97_11.method_6(gclass98_0, gclass0.info1, xScroll + Class15.smethod_0(3), y, Class15.smethod_0(0));
            GClass97.gclass97_18.method_6(gclass98_0, GClass109.string_392 + gclass0.money.ToString() + Class13.smethod_0(138877) + GClass109.string_158, xScroll + Class15.smethod_0(3), y + Class15.smethod_0(67), Class15.smethod_0(0));
            if (index == this.selected)
            {
              GClass97.gclass97_7.method_6(gclass98_0, GClass109.string_209, xScroll + wScroll - Class15.smethod_0(51), y + Class15.smethod_0(37), GClass97.int_2);
              GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_209, xScroll + wScroll - Class15.smethod_0(51), y + Class15.smethod_0(37), GClass97.int_2);
            }
            else
            {
              gclass98_0.method_32(GClass116.gclass66_24, xScroll + wScroll - Class15.smethod_0(51), y + h / Class15.smethod_0(7), GClass177.int_6);
              GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_209, xScroll + wScroll - Class15.smethod_0(51), y + Class15.smethod_0(37), GClass97.int_2);
            }
          }
          else if ((!gclass0.isFinish ? 1 : 0) == 0 && (!gclass0.isRecieve ? 1 : 0) == 0)
          {
            GClass97.gclass97_19.method_6(gclass98_0, gclass0.info1, xScroll + Class15.smethod_0(3), y, Class15.smethod_0(0));
            GClass97.gclass97_19.method_6(gclass98_0, gclass0.info2, xScroll + Class15.smethod_0(3), y + Class15.smethod_0(67), Class15.smethod_0(0));
          }
        }
      }
      this.method_94(gclass98_0);
    }
  }

  private void method_113(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    if (this.vItemCombine.method_2() == 0)
    {
      if (this.combineInfo == null)
        return;
      for (int index = Class15.smethod_0(0); index < this.combineInfo.Length; index += Class15.smethod_0(1))
        GClass97.gclass97_6.method_6(gclass98_0, this.combineInfo[index], this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll / Class15.smethod_0(7) - this.combineInfo.Length * Class15.smethod_0(49) / Class15.smethod_0(7) + index * Class15.smethod_0(49) + Class15.smethod_0(3), Class15.smethod_0(7));
    }
    else
    {
      for (int index1 = Class15.smethod_0(0); index1 < this.vItemCombine.method_2() + Class15.smethod_0(1); index1 += Class15.smethod_0(1))
      {
        int x = this.xScroll + Class15.smethod_0(86);
        int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w1 = this.wScroll - Class15.smethod_0(86);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int xScroll = this.xScroll;
        int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w2 = Class15.smethod_0(117);
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
        {
          if (index1 == this.vItemCombine.method_2())
          {
            if (this.vItemCombine.method_2() > Class15.smethod_0(0))
            {
              if (!GClass62.bool_5 && index1 == this.selected)
              {
                gclass98_0.method_16(Class15.smethod_0(104));
                gclass98_0.method_15(xScroll, y1, this.wScroll, h1 + Class15.smethod_0(7));
              }
              if (index1 == this.selected && this.int_58 == Class15.smethod_0(1) || !GClass62.bool_5 && index1 == this.selected)
              {
                gclass98_0.method_32(GClass116.gclass66_23, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) + Class15.smethod_0(1), GClass177.int_6);
                GClass97.gclass97_7.method_6(gclass98_0, GClass109.string_224, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
              }
              else
              {
                gclass98_0.method_32(GClass116.gclass66_22, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) + Class15.smethod_0(1), GClass177.int_6);
                GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_224, this.xScroll + this.wScroll / Class15.smethod_0(7), y1 + h1 / Class15.smethod_0(7) - Class15.smethod_0(2), GClass97.int_2);
              }
            }
          }
          else
          {
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
            gclass98_0.method_15(x, y1, w1, h1);
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(488) : Class15.smethod_0(489));
            GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index1);
            gclass98_0.method_15(xScroll, y2, w2, h2);
            if (gclass80 != null)
            {
              string str = string.Empty;
              GClass97 gclass97_1 = GClass97.gclass97_14;
              if (gclass80.itemOption != null)
              {
                for (int index2 = Class15.smethod_0(0); index2 < gclass80.itemOption.Length; index2 += Class15.smethod_0(1))
                {
                  if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(107))
                  {
                    str = Class13.smethod_0(131507) + gclass80.itemOption[index2].param.ToString() + Class13.smethod_0(131499);
                    gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index2].param);
                  }
                  if (gclass80.itemOption[index2].optionTemplate.id == Class15.smethod_0(55))
                  {
                    if (gclass80.itemOption[index2].param == Class15.smethod_0(1))
                      gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                    else if (gclass80.itemOption[index2].param == Class15.smethod_0(7))
                      gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                    else if (gclass80.itemOption[index2].param == Class15.smethod_0(5))
                      gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                    else if (gclass80.itemOption[index2].param == Class15.smethod_0(2))
                      gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
                  }
                }
              }
              gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
              string st = string.Empty;
              if (gclass80.itemOption != null)
              {
                if (gclass80.itemOption.Length != 0 && gclass80.itemOption[Class15.smethod_0(0)] != null && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(12))
                  st += gclass80.itemOption[Class15.smethod_0(0)].method_0();
                GClass97 gclass97_2 = GClass97.gclass97_18;
                if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
                  gclass97_2 = GClass97.gclass97_17;
                if (gclass80.itemOption.Length > Class15.smethod_0(1))
                {
                  for (int index3 = Class15.smethod_0(1); index3 < gclass80.itemOption.Length; index3 += Class15.smethod_0(1))
                  {
                    if (gclass80.itemOption[index3] != null && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[index3].optionTemplate.id != Class15.smethod_0(12))
                      st = st + Class13.smethod_0(131497) + gclass80.itemOption[index3].method_0();
                  }
                }
                gclass97_2.method_6(gclass98_0, st, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), GClass97.int_0);
              }
              GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
              if (gclass80.itemOption != null)
              {
                for (int index4 = Class15.smethod_0(0); index4 < gclass80.itemOption.Length; index4 += Class15.smethod_0(1))
                  this.method_204(gclass98_0, gclass80.itemOption[index4].optionTemplate.id, gclass80.itemOption[index4].param, xScroll, y2, w2, h2);
                for (int index5 = Class15.smethod_0(0); index5 < gclass80.itemOption.Length; index5 += Class15.smethod_0(1))
                  this.method_205(gclass98_0, gclass80.itemOption[index5].optionTemplate.id, gclass80.itemOption[index5].param, xScroll, y2, w2, h2);
              }
              if (gclass80.quantity > Class15.smethod_0(1))
                GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
            }
          }
        }
      }
      this.method_94(gclass98_0);
    }
  }

  private void method_114(GClass98 gclass98_0)
  {
    gclass98_0.method_16(Class15.smethod_0(133));
    GClass80[] arrItemBody = GClass20.smethod_1().arrItemBody;
    GClass80[] arrItemBag = GClass20.smethod_1().arrItemBag;
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    try
    {
      for (int index1 = Class15.smethod_0(0); index1 < this.currentListLength; index1 += Class15.smethod_0(1))
      {
        bool flag1 = index1 < arrItemBody.Length;
        int index2 = index1;
        int index3 = index1 - arrItemBody.Length;
        int x = this.xScroll + Class15.smethod_0(86);
        int y1 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w1 = this.wScroll - Class15.smethod_0(86);
        int h1 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        int xScroll = this.xScroll;
        int y2 = this.yScroll + index1 * this.ITEM_HEIGHT;
        int w2 = Class15.smethod_0(117);
        int h2 = this.ITEM_HEIGHT - Class15.smethod_0(1);
        if (y1 - this.cmy <= this.yScroll + this.hScroll && y1 - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
        {
          GClass80 gclass80 = !flag1 ? arrItemBag[index3] : arrItemBody[index2];
          gclass98_0.method_16(index1 == this.selected ? Class15.smethod_0(104) : (!flag1 ? Class15.smethod_0(490) : Class15.smethod_0(485)));
          if (gclass80 != null && (int) gclass80.template.type <= Class15.smethod_0(3))
          {
            int num = GClass5.gclass5_0.method_9().Contains(gclass80.method_23()) ? 1 : 0;
            bool flag2 = GClass5.gclass5_0.method_10().Contains(gclass80.method_23());
            if (num != 0 && !flag2)
              gclass98_0.method_16(index1 != this.selected ? GClass141.int_65[Class15.smethod_0(0)] : GClass141.int_66[Class15.smethod_0(0)]);
            if (num == Class15.smethod_0(0) & flag2)
              gclass98_0.method_16(index1 != this.selected ? GClass141.int_65[Class15.smethod_0(1)] : GClass141.int_66[Class15.smethod_0(1)]);
            if ((num & (flag2 ? 1 : 0)) != 0)
              gclass98_0.method_16(index1 != this.selected ? GClass141.int_65[Class15.smethod_0(7)] : GClass141.int_66[Class15.smethod_0(7)]);
          }
          gclass98_0.method_15(x, y1, w1, h1);
          gclass98_0.method_16(index1 == this.selected ? Class15.smethod_0(489) : (!flag1 ? Class15.smethod_0(304) : Class15.smethod_0(488)));
          gclass98_0.method_15(xScroll, y2, w2, h2);
          if (gclass80 != null && gclass80.isSelect && GClass62.gclass141_0.type == Class15.smethod_0(66))
          {
            gclass98_0.method_16(index1 != this.selected ? Class15.smethod_0(492) : Class15.smethod_0(491));
            gclass98_0.method_15(xScroll, y2, w2, h2);
          }
          if (!flag1)
            GClass97.gclass97_17.method_6(gclass98_0, (index1 + Class15.smethod_0(1) - arrItemBody.Length).ToString() + string.Empty, xScroll + w2 - Class15.smethod_0(48), y2 - Class15.smethod_0(5), Class15.smethod_0(0));
          if (gclass80 != null)
          {
            string str = string.Empty;
            GClass97 gclass97_1 = GClass97.gclass97_14;
            if (gclass80.itemOption != null)
            {
              for (int index4 = Class15.smethod_0(0); index4 < gclass80.itemOption.Length; index4 += Class15.smethod_0(1))
              {
                if (gclass80.itemOption[index4].optionTemplate.id == Class15.smethod_0(107))
                {
                  str = Class13.smethod_0(131903) + gclass80.itemOption[index4].param.ToString() + Class13.smethod_0(131870);
                  gclass80.method_22(gclass98_0, xScroll + Class15.smethod_0(124), y2 + Class15.smethod_0(66), gclass80.itemOption[index4].param);
                }
                if (gclass80.itemOption[index4].optionTemplate.id == Class15.smethod_0(55))
                {
                  if (gclass80.itemOption[index4].param == Class15.smethod_0(1))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(0));
                  else if (gclass80.itemOption[index4].param == Class15.smethod_0(7))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(7));
                  else if (gclass80.itemOption[index4].param == Class15.smethod_0(5))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(88));
                  else if (gclass80.itemOption[index4].param == Class15.smethod_0(2))
                    gclass97_1 = GClass141.smethod_6(Class15.smethod_0(38));
                }
              }
            }
            if (GClass5.gclass5_0.method_9().Contains(gclass80.method_23()))
              str = !GClass5.gclass5_0.method_10().Contains(gclass80.method_23()) ? str + Class13.smethod_0(131857) : str + Class13.smethod_0(131868);
            else if (GClass5.gclass5_0.method_10().Contains(gclass80.method_23()))
              str += Class13.smethod_0(131848);
            gclass97_1.method_6(gclass98_0, gclass80.template.name + str, x + Class15.smethod_0(3), y1 + Class15.smethod_0(1), Class15.smethod_0(0));
            string st = string.Empty;
            if (gclass80.itemOption != null)
            {
              if (gclass80.itemOption.Length != 0 && gclass80.itemOption[Class15.smethod_0(0)] != null && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[Class15.smethod_0(0)].optionTemplate.id != Class15.smethod_0(12))
                st += gclass80.itemOption[Class15.smethod_0(0)].method_0();
              GClass97 gclass97_2 = GClass97.gclass97_18;
              if (gclass80.compare < Class15.smethod_0(0) && (int) gclass80.template.type != Class15.smethod_0(3))
                gclass97_2 = GClass97.gclass97_17;
              if (gclass80.itemOption.Length > Class15.smethod_0(1))
              {
                for (int index5 = Class15.smethod_0(1); index5 < Class15.smethod_0(7); index5 += Class15.smethod_0(1))
                {
                  if (gclass80.itemOption[index5] != null && gclass80.itemOption[index5].optionTemplate.id != Class15.smethod_0(68) && gclass80.itemOption[index5].optionTemplate.id != Class15.smethod_0(12))
                    st = st + Class13.smethod_0(131958) + gclass80.itemOption[index5].method_0();
                }
              }
              gclass97_2.method_6(gclass98_0, st, x + Class15.smethod_0(3), y1 + Class15.smethod_0(67), GClass97.int_0);
            }
            GClass169.smethod_6(gclass98_0, (int) gclass80.template.iconID, xScroll + w2 / Class15.smethod_0(7), y2 + h2 / Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(5));
            if (gclass80.itemOption != null)
            {
              for (int index6 = Class15.smethod_0(0); index6 < gclass80.itemOption.Length; index6 += Class15.smethod_0(1))
                this.method_204(gclass98_0, gclass80.itemOption[index6].optionTemplate.id, gclass80.itemOption[index6].param, xScroll, y2, w2, h2);
              for (int index7 = Class15.smethod_0(0); index7 < gclass80.itemOption.Length; index7 += Class15.smethod_0(1))
                this.method_205(gclass98_0, gclass80.itemOption[index7].optionTemplate.id, gclass80.itemOption[index7].param, xScroll, y2, w2, h2);
            }
            if (gclass80.quantity > Class15.smethod_0(1))
              GClass97.gclass97_15.method_6(gclass98_0, string.Empty + gclass80.quantity.ToString(), xScroll + w2, y2 + h2 - GClass97.gclass97_15.method_20(), Class15.smethod_0(1));
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    this.method_94(gclass98_0);
  }

  private void method_115(GClass98 gclass98_0)
  {
    if (this.type != Class15.smethod_0(29) && this.type != Class15.smethod_0(40))
    {
      if (this.type == Class15.smethod_0(51))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_72, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(28))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_12, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(65))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_179, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(124))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_176, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(47) && this.Equals((object) GClass62.gclass141_1))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_206, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(66) && GClass62.gclass141_1 != null)
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_224, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(67))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_172, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(10))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_173, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(9))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, this.topName, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(7) && GClass62.gclass141_1 != null)
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_196, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(45))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_393, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(5))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_94, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(49))
      {
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_398, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
      }
      else if (this.type == Class15.smethod_0(2))
      {
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_205, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
      else if (this.type == Class15.smethod_0(38))
      {
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_394, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
      else if (this.type == Class15.smethod_0(186))
      {
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_403, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
      else if (this.type == Class15.smethod_0(88))
      {
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_60, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
      else if (this.type == Class15.smethod_0(31))
      {
        GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_395, this.startTabPos + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
      else
      {
        if (this.currentTabIndex == Class15.smethod_0(5) && this.mainTabName.Length != Class15.smethod_0(2))
          gclass98_0.method_1(-this.cmx, Class15.smethod_0(0));
        for (int index = Class15.smethod_0(0); index < this.currentTabName.Length; index += Class15.smethod_0(1))
        {
          gclass98_0.method_16(index != this.currentTabIndex ? Class15.smethod_0(503) : Class15.smethod_0(502));
          GClass148.smethod_4(gclass98_0, this.startTabPos + index * this.TAB_W, Class15.smethod_0(72), this.TAB_W - Class15.smethod_0(1), Class15.smethod_0(46), index == this.currentTabIndex ? Class15.smethod_0(1) : Class15.smethod_0(0), Class15.smethod_0(1) != 0);
          if (index == this.int_60)
            gclass98_0.method_32(GClass81.gclass66_0, this.startTabPos + index * this.TAB_W + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(106), Class15.smethod_0(5));
          GClass97 gclass97 = index != this.currentTabIndex ? GClass97.gclass97_16 : GClass97.gclass97_14;
          if (!this.currentTabName[index][Class15.smethod_0(1)].Equals(string.Empty))
          {
            gclass97.method_6(gclass98_0, this.currentTabName[index][Class15.smethod_0(0)], this.startTabPos + index * this.TAB_W + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(69), GClass97.int_2);
            gclass97.method_6(gclass98_0, this.currentTabName[index][Class15.smethod_0(1)], this.startTabPos + index * this.TAB_W + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(199), GClass97.int_2);
          }
          else
            gclass97.method_6(gclass98_0, this.currentTabName[index][Class15.smethod_0(0)], this.startTabPos + index * this.TAB_W + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
          if (this.type == 0 && this.currentTabName.Length == Class15.smethod_0(3) && GClass116.bool_53 && GClass62.int_8 % Class15.smethod_0(2) == 0)
            gclass98_0.method_32(GClass81.gclass66_0, this.startTabPos + Class15.smethod_0(5) * this.TAB_W + this.TAB_W / Class15.smethod_0(7), Class15.smethod_0(216), GClass98.int_5 | GClass98.int_0);
        }
        gclass98_0.method_16(Class15.smethod_0(303));
        gclass98_0.method_15(Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      }
    }
    else
    {
      gclass98_0.method_16(Class15.smethod_0(303));
      gclass98_0.method_15(this.X + Class15.smethod_0(1), Class15.smethod_0(63), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
      GClass97.gclass97_6.method_6(gclass98_0, GClass109.string_177, this.xScroll + this.wScroll / Class15.smethod_0(7), Class15.smethod_0(211), GClass97.int_2);
    }
  }

  private void method_116(GClass98 gclass98_0)
  {
    if (this.type == Class15.smethod_0(47) && (this.currentTabIndex == Class15.smethod_0(7) || (!this.Equals((object) GClass62.gclass141_1) ? 0 : 1) != 0))
      return;
    gclass98_0.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    gclass98_0.method_16(Class15.smethod_0(304));
    gclass98_0.method_15(this.X + Class15.smethod_0(1), this.H - Class15.smethod_0(9), this.W - Class15.smethod_0(7), Class15.smethod_0(49));
    gclass98_0.method_16(Class15.smethod_0(303));
    gclass98_0.method_15(this.X + Class15.smethod_0(1), this.H - Class15.smethod_0(9), this.W - Class15.smethod_0(7), Class15.smethod_0(1));
    gclass98_0.method_32(GClass141.gclass66_7, this.X + Class15.smethod_0(31), this.H - Class15.smethod_0(38), Class15.smethod_0(5));
    gclass98_0.method_32(GClass141.gclass66_9, this.X + Class15.smethod_0(25), this.H - Class15.smethod_0(88), Class15.smethod_0(5));
    GClass97.gclass97_15.method_10(gclass98_0, GClass138.smethod_9(GClass20.smethod_1().xu) + string.Empty, this.X + Class15.smethod_0(51), this.H - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass138.smethod_9((long) GClass20.smethod_1().luong) + string.Empty, this.X + Class15.smethod_0(23), this.H - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
    gclass98_0.method_32(GClass141.gclass66_10, this.X + Class15.smethod_0(288), this.H - Class15.smethod_0(88), Class15.smethod_0(5));
    GClass97.gclass97_15.method_10(gclass98_0, GClass138.smethod_9((long) GClass20.smethod_1().luongKhoa) + string.Empty, this.X + Class15.smethod_0(399), this.H - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
  }

  private void method_117(GClass98 gclass98_0)
  {
    if ((GClass20.smethod_1().clan == null ? 0 : 1) == 0)
    {
      GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
      GClass97.gclass97_3.method_6(gclass98_0, GClass109.string_274, (this.wScroll - Class15.smethod_0(32)) / Class15.smethod_0(7) + Class15.smethod_0(32), Class15.smethod_0(51), GClass97.int_2);
    }
    else if ((!this.isViewMember ? 0 : 1) == 0)
    {
      GClass25 clan = GClass20.smethod_1().clan;
      if ((clan == null ? 1 : 0) != 0)
        return;
      GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
      GClass97.gclass97_3.method_10(gclass98_0, clan.name, Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_6);
      GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_354 + Class13.smethod_0(132552) + clan.powerPoint, Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
      GClass97 gclass9715 = GClass97.gclass97_15;
      GClass98 g = gclass98_0;
      string[] strArray = new string[Class15.smethod_0(38)];
      strArray[Class15.smethod_0(0)] = GClass109.string_248;
      strArray[Class15.smethod_0(1)] = Class13.smethod_0(132552);
      strArray[Class15.smethod_0(7)] = clan.clanPoint.ToString();
      strArray[Class15.smethod_0(5)] = Class13.smethod_0(132544);
      strArray[Class15.smethod_0(2)] = GClass109.string_268;
      strArray[Class15.smethod_0(3)] = Class13.smethod_0(132552);
      strArray[Class15.smethod_0(37)] = clan.level.ToString();
      string st = string.Concat(strArray);
      int x = Class15.smethod_0(4);
      int y = Class15.smethod_0(33);
      int int0 = GClass97.int_0;
      GClass97 gclass9716 = GClass97.gclass97_16;
      gclass9715.method_10(g, st, x, y, int0, gclass9716);
      GClass183.smethod_1(gclass98_0, clan.slogan, Class15.smethod_0(4), Class15.smethod_0(34), this.wScroll - Class15.smethod_0(152), this.ITEM_HEIGHT, GClass97.gclass97_15);
    }
    else
    {
      GClass25 gclass25 = (this.currClan == null ? 1 : 0) != 0 ? GClass20.smethod_1().clan : this.currClan;
      GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), Class15.smethod_0(46), Class15.smethod_0(190), Class15.smethod_0(0), Class15.smethod_0(48));
      GClass97.gclass97_3.method_10(gclass98_0, gclass25.name, Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_6);
      GClass97 gclass9715 = GClass97.gclass97_15;
      GClass98 g = gclass98_0;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = GClass109.string_259;
      strArray[Class15.smethod_0(1)] = Class13.smethod_0(132552);
      strArray[Class15.smethod_0(7)] = gclass25.currMember.ToString();
      strArray[Class15.smethod_0(5)] = Class13.smethod_0(132154);
      strArray[Class15.smethod_0(2)] = gclass25.maxMember.ToString();
      string st = string.Concat(strArray);
      int x = Class15.smethod_0(4);
      int y = Class15.smethod_0(10);
      int int0 = GClass97.int_0;
      GClass97 gclass9716 = GClass97.gclass97_16;
      gclass9715.method_10(g, st, x, y, int0, gclass9716);
      GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_256 + Class13.smethod_0(132552) + gclass25.leaderName, Class15.smethod_0(4), Class15.smethod_0(33), GClass97.int_0, GClass97.gclass97_16);
      GClass183.smethod_1(gclass98_0, gclass25.slogan, Class15.smethod_0(4), Class15.smethod_0(34), this.wScroll - Class15.smethod_0(152), this.ITEM_HEIGHT, GClass97.gclass97_15);
    }
  }

  private void method_118(GClass98 gclass98_0)
  {
    GClass97.gclass97_3.method_10(gclass98_0, GClass109.string_70 + Class13.smethod_0(132333) + GClass63.string_2, Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_6);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_71 + Class13.smethod_0(133883) + GClass20.smethod_1().cName, Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_73 + Class13.smethod_0(132333) + GClass120.string_0[GClass120.int_12] + Class13.smethod_0(133880), Class15.smethod_0(4), Class15.smethod_0(33), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_434, Class15.smethod_0(4), Class15.smethod_0(53), GClass97.int_0, GClass97.gclass97_16);
  }

  private void method_119(GClass98 gclass98_0)
  {
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_336, Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_299, Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_300, Class15.smethod_0(4), Class15.smethod_0(33), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_301, Class15.smethod_0(4), Class15.smethod_0(34), GClass97.int_0, GClass97.gclass97_16);
  }

  private void method_120(GClass98 gclass98_0) => this.method_122(gclass98_0, GClass20.smethod_1());

  private void method_121(GClass98 gclass98_0)
  {
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_254 + Class13.smethod_0(134450) + GClass138.smethod_9(GClass20.smethod_2().cPower), this.X + Class15.smethod_0(72), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_16);
    if (GClass20.smethod_2().cPower > (long) Class15.smethod_0(0))
      GClass97.gclass97_15.method_10(gclass98_0, (!GClass20.smethod_2().me ? 1 : 0) != 0 ? GClass20.smethod_2().currStrLevel : GClass20.smethod_2().method_3(), this.X + Class15.smethod_0(72), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
    if (GClass20.smethod_2().cDamFull > Class15.smethod_0(0))
      GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_371 + Class13.smethod_0(134450) + GClass138.smethod_9((long) GClass20.smethod_2().cDamFull), this.X + Class15.smethod_0(72), Class15.smethod_0(33), GClass97.int_0, GClass97.gclass97_16);
    if ((int) GClass20.smethod_2().cMaxStamina > Class15.smethod_0(0))
    {
      GClass97 gclass9715 = GClass97.gclass97_15;
      GClass98 g = gclass98_0;
      object[] objArray = new object[Class15.smethod_0(3)];
      objArray[Class15.smethod_0(0)] = (object) GClass109.string_373;
      objArray[Class15.smethod_0(1)] = (object) Class13.smethod_0(134450);
      objArray[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cStamina);
      objArray[Class15.smethod_0(5)] = (object) Class13.smethod_0(134438);
      objArray[Class15.smethod_0(2)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cMaxStamina);
      string st = string.Concat(objArray);
      int x = this.X + Class15.smethod_0(72);
      int y = Class15.smethod_0(34);
      int int0 = GClass97.int_0;
      GClass97 gclass9716 = GClass97.gclass97_16;
      gclass9715.method_10(g, st, x, y, int0, gclass9716);
    }
    gclass98_0.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
  }

  private void method_122(GClass98 gclass98_0, GClass20 gclass20_0)
  {
    GClass97.gclass97_3.method_10(gclass98_0, ((int) GClass116.sbyte_12 == Class15.smethod_0(1) ? Class13.smethod_0(134260) : string.Empty) + gclass20_0.cName, this.X + Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_6);
    if ((int) GClass116.sbyte_12 == Class15.smethod_0(1))
      GClass169.smethod_6(gclass98_0, Class15.smethod_0(504), this.X + Class15.smethod_0(280), Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
    if ((int) gclass20_0.cMaxStamina > Class15.smethod_0(0))
    {
      GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_373, this.X + Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
      gclass98_0.method_32(GClass116.gclass66_34, this.X + Class15.smethod_0(101), Class15.smethod_0(65), Class15.smethod_0(0));
      int w = gclass20_0.cStamina * GClass98.smethod_0(GClass116.gclass66_31) / (int) gclass20_0.cMaxStamina;
      gclass98_0.method_5(Class15.smethod_0(101), this.X + Class15.smethod_0(65), w, Class15.smethod_0(51));
      gclass98_0.method_32(GClass116.gclass66_31, this.X + Class15.smethod_0(101), Class15.smethod_0(65), Class15.smethod_0(0));
    }
    gclass98_0.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    if (gclass20_0.cPower > (long) Class15.smethod_0(0))
      GClass97.gclass97_15.method_10(gclass98_0, (!gclass20_0.me ? 1 : 0) != 0 ? gclass20_0.currStrLevel : gclass20_0.method_3(), this.X + Class15.smethod_0(4), Class15.smethod_0(33), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_254 + Class13.smethod_0(134241) + GClass138.smethod_9(gclass20_0.cPower), this.X + Class15.smethod_0(4), Class15.smethod_0(34), GClass97.int_0, GClass97.gclass97_16);
  }

  private void method_123(GClass98 gclass98_0)
  {
    GClass97.gclass97_3.method_10(gclass98_0, GClass109.string_204 + Class13.smethod_0(134219) + GClass185.int_39.ToString(), Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0, GClass97.gclass97_6);
    GClass97.gclass97_15.method_10(gclass98_0, GClass185.string_1, Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0, GClass97.gclass97_16);
    GClass97.gclass97_3.method_6(gclass98_0, GClass185.int_39.ToString() + string.Empty, Class15.smethod_0(46), Class15.smethod_0(33), GClass97.int_2);
  }

  public int method_124(GClass80 item)
  {
    if ((item == null ? 0 : 1) == 0)
      return -1;
    if ((!item.method_7() ? 1 : 0) != 0)
      return Class15.smethod_0(0);
    if ((item.itemOption == null ? 0 : 1) == 0)
      return -1;
    GClass83 gclass83 = item.itemOption[Class15.smethod_0(0)];
    if (gclass83.optionTemplate.id == Class15.smethod_0(28))
    {
      gclass83.optionTemplate = GClass116.smethod_6().iOptionTemplates[Class15.smethod_0(37)];
      gclass83.param *= Class15.smethod_0(15);
    }
    if (gclass83.optionTemplate.id == Class15.smethod_0(29))
    {
      gclass83.optionTemplate = GClass116.smethod_6().iOptionTemplates[Class15.smethod_0(38)];
      gclass83.param *= Class15.smethod_0(15);
    }
    GClass80 gclass80_1 = (GClass80) null;
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBody.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80_2 = GClass20.smethod_1().arrItemBody[index];
      if (gclass83.optionTemplate.id == Class15.smethod_0(28))
      {
        gclass83.optionTemplate = GClass116.smethod_6().iOptionTemplates[Class15.smethod_0(37)];
        gclass83.param *= Class15.smethod_0(15);
      }
      if (gclass83.optionTemplate.id == Class15.smethod_0(29))
      {
        gclass83.optionTemplate = GClass116.smethod_6().iOptionTemplates[Class15.smethod_0(38)];
        gclass83.param *= Class15.smethod_0(15);
      }
      if ((gclass80_2 == null ? 1 : 0) == 0 && (gclass80_2.itemOption == null ? 1 : 0) == 0 && (int) gclass80_2.template.type == (int) item.template.type)
      {
        gclass80_1 = gclass80_2;
        break;
      }
    }
    if ((gclass80_1 == null ? 0 : 1) == 0)
    {
      GClass151.smethod_7(Class13.smethod_0(134212));
      this.bool_10 = Class15.smethod_0(1) != 0;
      return gclass83.param;
    }
    int num = (gclass80_1 == null ? 1 : 0) != 0 || (gclass80_1.itemOption == null ? 1 : 0) != 0 ? gclass83.param : gclass83.param - gclass80_1.itemOption[Class15.smethod_0(0)].param;
    if (num < Class15.smethod_0(0))
    {
      this.bool_10 = Class15.smethod_0(0) != 0;
      return num;
    }
    this.bool_10 = Class15.smethod_0(1) != 0;
    return num;
  }

  private void method_125(GClass98 gclass98_0)
  {
    GClass97.gclass97_3.method_6(gclass98_0, GClass109.string_100[(int) GClass185.sbyte_2], Class15.smethod_0(4), Class15.smethod_0(2), GClass97.int_0);
    string str = string.Empty;
    if (GClass185.int_37 >= Class15.smethod_0(371) && GClass185.int_37 <= Class15.smethod_0(505))
      str = Class13.smethod_0(134356) + GClass109.string_9 + GClass185.int_39.ToString();
    GClass97.gclass97_15.method_6(gclass98_0, GClass185.string_1 + str, Class15.smethod_0(4), Class15.smethod_0(10), GClass97.int_0);
    GClass97.gclass97_3.method_6(gclass98_0, GClass109.string_390 + Class13.smethod_0(134354), Class15.smethod_0(4), Class15.smethod_0(33), GClass97.int_0);
    if (GClass116.smethod_25() >= Class15.smethod_0(0) && GClass116.smethod_25() <= GClass185.string_2.Length - Class15.smethod_0(1))
      GClass97.gclass97_15.method_6(gclass98_0, GClass185.string_2[GClass116.smethod_25()], Class15.smethod_0(4), Class15.smethod_0(34), GClass97.int_0);
    else
      GClass97.gclass97_15.method_6(gclass98_0, GClass109.string_337, Class15.smethod_0(4), Class15.smethod_0(34), GClass97.int_0);
  }

  private void method_126(GClass98 gclass98_0)
  {
    if (this.currentTabIndex == this.currentTabName.Length - Class15.smethod_0(1) && (GClass62.gclass141_1 == null ? 0 : 1) == 0)
      this.method_120(gclass98_0);
    else if (this.selected < Class15.smethod_0(0))
    {
      if (this.typeShop != Class15.smethod_0(7))
      {
        GClass97.gclass97_20.method_6(gclass98_0, GClass109.string_338, this.X + Class15.smethod_0(4), Class15.smethod_0(49), Class15.smethod_0(0));
        GClass97.gclass97_20.method_6(gclass98_0, GClass141.string_12, this.X + Class15.smethod_0(4), Class15.smethod_0(50), Class15.smethod_0(0));
      }
      else
      {
        GClass97.gclass97_20.method_6(gclass98_0, GClass109.string_338, this.X + Class15.smethod_0(4), Class15.smethod_0(3), Class15.smethod_0(0));
        GClass97.gclass97_20.method_6(gclass98_0, GClass141.string_12, this.X + Class15.smethod_0(4), Class15.smethod_0(186), Class15.smethod_0(0));
        GClass97 gclass9720 = GClass97.gclass97_20;
        GClass98 g = gclass98_0;
        string[] strArray = new string[Class15.smethod_0(3)];
        strArray[Class15.smethod_0(0)] = GClass109.string_414;
        strArray[Class15.smethod_0(1)] = Class13.smethod_0(134963);
        strArray[Class15.smethod_0(7)] = (this.currPageShop[this.currentTabIndex] + Class15.smethod_0(1)).ToString();
        strArray[Class15.smethod_0(5)] = Class13.smethod_0(134944);
        strArray[Class15.smethod_0(2)] = this.maxPageShop[this.currentTabIndex].ToString();
        string st = string.Concat(strArray);
        int x = this.X + Class15.smethod_0(4);
        int y = Class15.smethod_0(36);
        int align = Class15.smethod_0(0);
        gclass9720.method_6(g, st, x, y, align);
      }
    }
    else
    {
      if (this.currentTabIndex < Class15.smethod_0(0) || this.currentTabIndex > GClass20.smethod_1().arrItemShop.Length - Class15.smethod_0(1) || this.selected < Class15.smethod_0(0) || this.selected > GClass20.smethod_1().arrItemShop[this.currentTabIndex].Length - Class15.smethod_0(1))
        return;
      GClass80 gclass80 = GClass20.smethod_1().arrItemShop[this.currentTabIndex][this.selected];
      if ((gclass80 == null ? 1 : 0) != 0)
        return;
      if ((!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0 && this.currentTabIndex <= Class15.smethod_0(5) && this.typeShop == Class15.smethod_0(7))
      {
        GClass97 gclass973 = GClass97.gclass97_3;
        GClass98 g = gclass98_0;
        string[] strArray = new string[Class15.smethod_0(3)];
        strArray[Class15.smethod_0(0)] = GClass109.string_414;
        strArray[Class15.smethod_0(1)] = Class13.smethod_0(134963);
        strArray[Class15.smethod_0(7)] = (this.currPageShop[this.currentTabIndex] + Class15.smethod_0(1)).ToString();
        strArray[Class15.smethod_0(5)] = Class13.smethod_0(134944);
        strArray[Class15.smethod_0(2)] = this.maxPageShop[this.currentTabIndex].ToString();
        string st = string.Concat(strArray);
        int x = this.X + Class15.smethod_0(280);
        int y = Class15.smethod_0(2);
        int align = Class15.smethod_0(0);
        gclass973.method_6(g, st, x, y, align);
      }
      GClass97.gclass97_3.method_6(gclass98_0, gclass80.template.name, this.X + Class15.smethod_0(280), Class15.smethod_0(40), Class15.smethod_0(0));
      string st1 = GClass109.string_217 + Class13.smethod_0(134963) + GClass151.smethod_28((long) gclass80.template.strRequire);
      if ((long) gclass80.template.strRequire > GClass20.smethod_1().cPower)
        GClass97.gclass97_15.method_6(gclass98_0, st1, this.X + Class15.smethod_0(280), Class15.smethod_0(95), Class15.smethod_0(0));
      else
        GClass97.gclass97_19.method_6(gclass98_0, st1, this.X + Class15.smethod_0(280), Class15.smethod_0(95), Class15.smethod_0(0));
    }
  }

  private void method_127(GClass98 gclass98_0)
  {
    string[] strArray = new string[Class15.smethod_0(38)];
    strArray[Class15.smethod_0(0)] = GClass109.string_219;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(135083);
    strArray[Class15.smethod_0(7)] = this.hasUse.ToString();
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(135080);
    strArray[Class15.smethod_0(2)] = GClass20.smethod_1().arrItemBox.Length.ToString();
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(135078);
    strArray[Class15.smethod_0(37)] = GClass109.string_220;
    string st = string.Concat(strArray);
    GClass97.gclass97_3.method_6(gclass98_0, GClass109.string_196, Class15.smethod_0(4), Class15.smethod_0(2), Class15.smethod_0(0));
    GClass97.gclass97_15.method_6(gclass98_0, st, Class15.smethod_0(4), Class15.smethod_0(10), Class15.smethod_0(0));
  }

  private void method_128(GClass98 gclass98_0)
  {
    GClass97.gclass97_20.method_6(gclass98_0, Class13.smethod_0(135076) + GClass20.smethod_1().rank.ToString(), this.X + Class15.smethod_0(70) + (this.W - Class15.smethod_0(32)) / Class15.smethod_0(7), Class15.smethod_0(7), GClass97.int_2);
    GClass97.gclass97_15.method_6(gclass98_0, GClass109.string_353, this.X + Class15.smethod_0(70) + (this.W - Class15.smethod_0(32)) / Class15.smethod_0(7), Class15.smethod_0(49), GClass97.int_2);
    GClass97.gclass97_20.method_6(gclass98_0, string.Empty + GClass138.smethod_9(GClass20.smethod_1().cTiemNang), this.X + (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31) ? GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7) : Class15.smethod_0(0)) + Class15.smethod_0(70) + (this.W - Class15.smethod_0(32)) / Class15.smethod_0(7), Class15.smethod_0(50), GClass97.int_2);
    GClass97.gclass97_15.method_6(gclass98_0, GClass109.string_171 + Class13.smethod_0(135071) + GClass138.smethod_9(GClass20.smethod_1().cNangdong), this.X + (GClass62.int_8 % Class15.smethod_0(51) > Class15.smethod_0(31) ? GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7) : Class15.smethod_0(0)) + Class15.smethod_0(70) + (this.W - Class15.smethod_0(32)) / Class15.smethod_0(7), Class15.smethod_0(34), GClass97.int_2);
  }

  private void method_129(GClass98 gclass98_0)
  {
    GClass97 gclass9715_1 = GClass97.gclass97_15;
    GClass98 g1 = gclass98_0;
    object[] objArray1 = new object[Class15.smethod_0(3)];
    objArray1[Class15.smethod_0(0)] = (object) GClass109.string_369;
    objArray1[Class15.smethod_0(1)] = (object) Class13.smethod_0(135049);
    objArray1[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cHP);
    objArray1[Class15.smethod_0(5)] = (object) Class13.smethod_0(135041);
    objArray1[Class15.smethod_0(2)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cHPFull);
    string st1 = string.Concat(objArray1);
    int x1 = this.X + Class15.smethod_0(72);
    int y1 = Class15.smethod_0(7);
    int int0_1 = GClass97.int_0;
    GClass97 gclass9716_1 = GClass97.gclass97_16;
    gclass9715_1.method_10(g1, st1, x1, y1, int0_1, gclass9716_1);
    GClass97 gclass9715_2 = GClass97.gclass97_15;
    GClass98 g2 = gclass98_0;
    object[] objArray2 = new object[Class15.smethod_0(3)];
    objArray2[Class15.smethod_0(0)] = (object) GClass109.string_370;
    objArray2[Class15.smethod_0(1)] = (object) Class13.smethod_0(135049);
    objArray2[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cMP);
    objArray2[Class15.smethod_0(5)] = (object) Class13.smethod_0(135041);
    objArray2[Class15.smethod_0(2)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cMPFull);
    string st2 = string.Concat(objArray2);
    int x2 = this.X + Class15.smethod_0(72);
    int y2 = Class15.smethod_0(49);
    int int0_2 = GClass97.int_0;
    GClass97 gclass9716_2 = GClass97.gclass97_16;
    gclass9715_2.method_10(g2, st2, x2, y2, int0_2, gclass9716_2);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_371 + Class13.smethod_0(135049) + GClass138.smethod_9((long) GClass20.smethod_1().cDamFull), this.X + Class15.smethod_0(72), Class15.smethod_0(50), GClass97.int_0, GClass97.gclass97_16);
    GClass97 gclass9715_3 = GClass97.gclass97_15;
    GClass98 g3 = gclass98_0;
    object[] objArray3 = new object[Class15.smethod_0(88)];
    objArray3[Class15.smethod_0(0)] = (object) GClass109.string_372;
    objArray3[Class15.smethod_0(1)] = (object) Class13.smethod_0(135049);
    objArray3[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cDefull);
    objArray3[Class15.smethod_0(5)] = (object) Class13.smethod_0(135160);
    objArray3[Class15.smethod_0(2)] = (object) GClass109.string_374;
    objArray3[Class15.smethod_0(3)] = (object) Class13.smethod_0(135049);
    objArray3[Class15.smethod_0(37)] = (object) GClass138.smethod_9((long) GClass20.smethod_1().cCriticalFull);
    objArray3[Class15.smethod_0(38)] = (object) Class13.smethod_0(134669);
    string st3 = string.Concat(objArray3);
    int x3 = this.X + Class15.smethod_0(72);
    int y3 = Class15.smethod_0(34);
    int int0_3 = GClass97.int_0;
    GClass97 gclass9716_3 = GClass97.gclass97_16;
    gclass9715_3.method_10(g3, st3, x3, y3, int0_3, gclass9716_3);
  }

  private void method_130(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.X + Class15.smethod_0(1), this.Y, this.W - Class15.smethod_0(7), this.yScroll - Class15.smethod_0(7));
    gclass98_0.method_16(Class15.smethod_0(488));
    gclass98_0.method_15(this.X, this.Y, this.W - Class15.smethod_0(7), Class15.smethod_0(32));
    switch (this.type)
    {
      case 0:
        if (this.currentTabIndex == 0)
        {
          GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_120(gclass98_0);
        }
        if (this.currentTabIndex == Class15.smethod_0(1))
        {
          GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_129(gclass98_0);
        }
        if (this.currentTabIndex == Class15.smethod_0(7))
        {
          GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_128(gclass98_0);
        }
        if (this.currentTabIndex == Class15.smethod_0(5))
        {
          if (this.mainTabName.Length == Class15.smethod_0(3))
          {
            this.method_117(gclass98_0);
          }
          else
          {
            GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
            this.method_118(gclass98_0);
          }
        }
        if (this.currentTabIndex != Class15.smethod_0(2))
          break;
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_118(gclass98_0);
        break;
      case 1:
        if (this.currentTabIndex == this.currentTabName.Length - Class15.smethod_0(1) && GClass62.gclass141_1 == null)
          GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        else
          GClass169.smethod_6(gclass98_0, GClass20.smethod_1().npcFocus.avatar, this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_126(gclass98_0);
        break;
      case 2:
        if (this.currentTabIndex == 0)
        {
          GClass169.smethod_6(gclass98_0, Class15.smethod_0(507), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_127(gclass98_0);
        }
        if (this.currentTabIndex != Class15.smethod_0(1))
          break;
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_129(gclass98_0);
        break;
      case 3:
        GClass169.smethod_6(gclass98_0, Class15.smethod_0(508), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_123(gclass98_0);
        break;
      case 4:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_125(gclass98_0);
        break;
      case 7:
      case 17:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 8:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 9:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 10:
        if (this.charMenu == null)
          break;
        GClass169.smethod_6(gclass98_0, this.charMenu.method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_122(gclass98_0, this.charMenu);
        break;
      case 11:
      case 16:
      case 23:
      case 24:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 12:
        if (this.currentTabIndex == 0)
        {
          int id = Class15.smethod_0(506);
          for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
          {
            GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
            if (gclass21.template.npcTemplateId == this.idNPC)
              id = gclass21.avatar;
          }
          GClass169.smethod_6(gclass98_0, id, this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_133(gclass98_0);
        }
        if (this.currentTabIndex != Class15.smethod_0(1))
          break;
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 13:
        if (this.currentTabIndex == 0 || this.currentTabIndex == Class15.smethod_0(1))
        {
          if (this.Equals((object) GClass62.gclass141_0))
          {
            GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
            this.method_119(gclass98_0);
          }
          if (this.Equals((object) GClass62.gclass141_1) && this.charMenu != null)
          {
            GClass169.smethod_6(gclass98_0, this.charMenu.method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
            this.method_122(gclass98_0, this.charMenu);
          }
        }
        if (this.currentTabIndex != Class15.smethod_0(7) || this.charMenu == null)
          break;
        GClass169.smethod_6(gclass98_0, this.charMenu.method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_122(gclass98_0, this.charMenu);
        break;
      case 14:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_125(gclass98_0);
        break;
      case 15:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 18:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
      case 19:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_118(gclass98_0);
        break;
      case 20:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_118(gclass98_0);
        break;
      case 21:
        if (this.currentTabIndex == 0)
        {
          GClass169.smethod_6(gclass98_0, GClass20.smethod_2().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_121(gclass98_0);
        }
        if (this.currentTabIndex == Class15.smethod_0(1))
        {
          GClass169.smethod_6(gclass98_0, GClass20.smethod_2().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
          this.method_132(gclass98_0);
        }
        if (this.currentTabIndex != Class15.smethod_0(7))
          break;
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_129(gclass98_0);
        break;
      case 22:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_118(gclass98_0);
        break;
      case 25:
        GClass169.smethod_6(gclass98_0, GClass20.smethod_1().method_4(), this.X + Class15.smethod_0(46), Class15.smethod_0(32), Class15.smethod_0(0), Class15.smethod_0(48));
        this.method_120(gclass98_0);
        break;
    }
  }

  private string method_131(int int_105)
  {
    string str;
    switch (int_105)
    {
      case 0:
        str = GClass109.string_16;
        break;
      case 1:
        str = GClass109.string_15;
        break;
      case 2:
        str = GClass109.string_14;
        break;
      case 3:
        str = GClass109.string_18;
        break;
      default:
        str = Class13.smethod_0(134904);
        break;
    }
    return str;
  }

  private void method_132(GClass98 gclass98_0)
  {
    GClass97 gclass973_1 = GClass97.gclass97_3;
    GClass98 g1 = gclass98_0;
    object[] objArray1 = new object[Class15.smethod_0(2)];
    objArray1[Class15.smethod_0(0)] = (object) Class13.smethod_0(193011);
    objArray1[Class15.smethod_0(1)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cHP);
    objArray1[Class15.smethod_0(7)] = (object) Class13.smethod_0(193002);
    objArray1[Class15.smethod_0(5)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cHPFull);
    string st1 = string.Concat(objArray1);
    int x1 = this.X + Class15.smethod_0(72);
    int y1 = Class15.smethod_0(2);
    int int0_1 = GClass97.int_0;
    GClass97 gclass976_1 = GClass97.gclass97_6;
    gclass973_1.method_10(g1, st1, x1, y1, int0_1, gclass976_1);
    GClass97 gclass973_2 = GClass97.gclass97_3;
    GClass98 g2 = gclass98_0;
    object[] objArray2 = new object[Class15.smethod_0(2)];
    objArray2[Class15.smethod_0(0)] = (object) Class13.smethod_0(192573);
    objArray2[Class15.smethod_0(1)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cMP);
    objArray2[Class15.smethod_0(7)] = (object) Class13.smethod_0(193002);
    objArray2[Class15.smethod_0(5)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cMPFull);
    string st2 = string.Concat(objArray2);
    int x2 = this.X + Class15.smethod_0(72);
    int y2 = Class15.smethod_0(10);
    int int0_2 = GClass97.int_0;
    GClass97 gclass976_2 = GClass97.gclass97_6;
    gclass973_2.method_10(g2, st2, x2, y2, int0_2, gclass976_2);
    GClass97 gclass9715 = GClass97.gclass97_15;
    GClass98 g3 = gclass98_0;
    object[] objArray3 = new object[Class15.smethod_0(38)];
    objArray3[Class15.smethod_0(0)] = (object) GClass109.string_374;
    objArray3[Class15.smethod_0(1)] = (object) Class13.smethod_0(192518);
    objArray3[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cCriticalFull);
    objArray3[Class15.smethod_0(5)] = (object) Class13.smethod_0(192515);
    objArray3[Class15.smethod_0(2)] = (object) GClass109.string_372;
    objArray3[Class15.smethod_0(3)] = (object) Class13.smethod_0(192518);
    objArray3[Class15.smethod_0(37)] = (object) GClass138.smethod_9((long) GClass20.smethod_2().cDefull);
    string st3 = string.Concat(objArray3);
    int x3 = this.X + Class15.smethod_0(72);
    int y3 = Class15.smethod_0(33);
    int int0_3 = GClass97.int_0;
    GClass97 gclass9716 = GClass97.gclass97_16;
    gclass9715.method_10(g3, st3, x3, y3, int0_3, gclass9716);
    GClass97.gclass97_15.method_10(gclass98_0, GClass109.string_17 + Class13.smethod_0(192518) + this.string_11[(int) GClass20.smethod_2().petStatus], this.X + Class15.smethod_0(72), Class15.smethod_0(34), GClass97.int_0, GClass97.gclass97_16);
  }

  private void method_133(GClass98 gclass98_0)
  {
    if ((this.combineTopInfo == null ? 1 : 0) != 0)
      return;
    for (int index = Class15.smethod_0(0); index < this.combineTopInfo.Length; index += Class15.smethod_0(1))
      GClass97.gclass97_20.method_6(gclass98_0, this.combineTopInfo[index], this.X + Class15.smethod_0(70) + (this.W - Class15.smethod_0(32)) / Class15.smethod_0(7), Class15.smethod_0(3) + index * Class15.smethod_0(49), GClass97.int_2);
  }

  private void method_134(GClass98 gclass98_0)
  {
  }

  public void method_135(GClass98 g)
  {
    g.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    g.method_1(-this.cmxMap, -this.cmyMap);
    g.method_32(GClass141.gclass66_2, this.xScroll, this.yScroll, Class15.smethod_0(0));
    int head = GClass20.smethod_1().head;
    GClass142 gclass142 = GClass116.gclass142_0[head];
    GClass169.smethod_6(g, (int) gclass142.pi[GClass20.int_0[Class15.smethod_0(0)][Class15.smethod_0(0)][Class15.smethod_0(0)]].id, this.int_69, this.int_70 + Class15.smethod_0(3), Class15.smethod_0(0), Class15.smethod_0(5));
    int align1 = GClass97.int_2;
    if (this.int_69 <= Class15.smethod_0(54))
      align1 = GClass97.int_0;
    if (this.int_69 >= Class15.smethod_0(99))
      align1 = GClass97.int_1;
    GClass97.gclass97_4.method_10(g, GClass185.string_1, this.int_69, this.int_70 - Class15.smethod_0(66), align1, GClass97.gclass97_16);
    int index1 = -1;
    if (GClass116.smethod_25() != -1)
    {
      for (int index2 = Class15.smethod_0(0); index2 < GClass141.int_16[(int) GClass185.sbyte_2].Length; index2 += Class15.smethod_0(1))
      {
        if (GClass141.int_16[(int) GClass185.sbyte_2][index2] != GClass116.smethod_25())
        {
          index1 = Class15.smethod_0(2);
        }
        else
        {
          index1 = index2;
          break;
        }
      }
      if (GClass62.int_8 % Class15.smethod_0(2) > Class15.smethod_0(0))
        g.method_32(GClass81.gclass66_0, this.xScroll + GClass141.int_17[(int) GClass185.sbyte_2][index1], this.yScroll + GClass141.int_18[(int) GClass185.sbyte_2][index1], Class15.smethod_0(5));
    }
    if (!GClass62.bool_5)
    {
      g.method_32(GClass141.gclass66_0, this.int_73, this.int_74, GClass177.int_2);
      for (int index3 = Class15.smethod_0(0); index3 < GClass141.int_17[(int) GClass185.sbyte_2].Length; index3 += Class15.smethod_0(1))
      {
        int x = GClass141.int_17[(int) GClass185.sbyte_2][index3] + this.xScroll;
        int num = GClass141.int_18[(int) GClass185.sbyte_2][index3] + this.yScroll;
        if (GClass151.smethod_26(x - Class15.smethod_0(9), num - Class15.smethod_0(9), Class15.smethod_0(6), Class15.smethod_0(6), this.int_73, this.int_74))
        {
          int align2 = GClass97.int_2;
          if (x <= Class15.smethod_0(51))
            align2 = GClass97.int_0;
          if (x >= Class15.smethod_0(99))
            align2 = GClass97.int_1;
          GClass97.gclass97_4.method_10(g, GClass185.string_2[GClass141.int_16[(int) GClass185.sbyte_2][index3]], x, num - Class15.smethod_0(66), align2, GClass97.gclass97_16);
          break;
        }
      }
    }
    else if (!this.bool_0)
    {
      for (int index4 = Class15.smethod_0(0); index4 < GClass141.int_17[(int) GClass185.sbyte_2].Length; index4 += Class15.smethod_0(1))
      {
        int x = GClass141.int_17[(int) GClass185.sbyte_2][index4] + this.xScroll;
        int y = GClass141.int_18[(int) GClass185.sbyte_2][index4] + this.yScroll;
        if (GClass151.smethod_26(x - Class15.smethod_0(9), y - Class15.smethod_0(9), Class15.smethod_0(6), Class15.smethod_0(6), this.int_2, this.int_3))
        {
          int align3 = GClass97.int_2;
          if (x <= Class15.smethod_0(6))
            align3 = GClass97.int_0;
          if (x >= Class15.smethod_0(99))
            align3 = GClass97.int_1;
          g.method_32(GClass141.gclass66_0, x, y, GClass177.int_2);
          GClass97.gclass97_4.method_10(g, GClass185.string_2[GClass141.int_16[(int) GClass185.sbyte_2][index4]], x, y - Class15.smethod_0(66), align3, GClass97.gclass97_16);
          break;
        }
      }
    }
    g.method_1(-g.method_3(), -g.method_4());
    if (index1 == -1)
      return;
    if (GClass141.int_17[(int) GClass185.sbyte_2][index1] + this.xScroll < this.cmxMap)
      g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(3), this.xScroll + Class15.smethod_0(3), this.yScroll + this.hScroll / Class15.smethod_0(7) - Class15.smethod_0(2), Class15.smethod_0(0));
    if (this.cmxMap + this.wScroll < GClass141.int_17[(int) GClass185.sbyte_2][index1] + this.xScroll)
      g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(37), this.xScroll + this.wScroll - Class15.smethod_0(3), this.yScroll + this.hScroll / Class15.smethod_0(7) - Class15.smethod_0(2), GClass177.int_2);
    if (GClass141.int_18[(int) GClass185.sbyte_2][index1] < this.cmyMap)
      g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(1), this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + Class15.smethod_0(3), GClass177.int_0);
    if (GClass141.int_18[(int) GClass185.sbyte_2][index1] <= this.cmyMap + this.hScroll)
      return;
    g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll - Class15.smethod_0(3), GClass177.int_3);
  }

  public void method_136(GClass98 g)
  {
    int num = GClass62.int_11 <= Class15.smethod_0(137) ? Class15.smethod_0(9) : Class15.smethod_0(51);
    if (GClass141.bool_11 && !GClass116.smethod_6().method_2() && !GClass116.smethod_6().method_3())
    {
      g.method_32(this.int_59 != Class15.smethod_0(1) ? GClass116.gclass66_22 : GClass116.gclass66_23, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll - num, Class15.smethod_0(5));
      GClass97.gclass97_6.method_6(g, GClass109.string_205, this.xScroll + this.wScroll / Class15.smethod_0(7), this.yScroll + this.hScroll - (num + Class15.smethod_0(3)), GClass97.int_2);
    }
    this.xstart = this.xScroll + Class15.smethod_0(3);
    this.ystart = this.yScroll + Class15.smethod_0(49);
    this.int_68 = this.ystart;
    g.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll - Class15.smethod_0(95));
    if (this.gclass154_0 != null)
    {
      if (this.gclass154_0.cmy > Class15.smethod_0(0))
        g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(1), this.xScroll + this.wScroll - Class15.smethod_0(66), this.yScroll + Class15.smethod_0(5), Class15.smethod_0(0));
      if (this.gclass154_0.cmy < this.gclass154_0.cmyLim)
        g.method_24(GClass100.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(45), Class15.smethod_0(37), Class15.smethod_0(0), this.xScroll + this.wScroll - Class15.smethod_0(66), this.yScroll + this.hScroll - Class15.smethod_0(70), Class15.smethod_0(0));
      g.method_1(Class15.smethod_0(0), -this.gclass154_0.cmy);
    }
    this.indexRowMax = Class15.smethod_0(0);
    if (this.indexMenu == 0)
    {
      bool flag = Class15.smethod_0(0) != 0;
      if (GClass20.smethod_1().taskMaint != null)
      {
        for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().taskMaint.names.Length; index += Class15.smethod_0(1))
        {
          GClass97.gclass97_16.method_6(g, GClass20.smethod_1().taskMaint.names[index], this.xScroll + this.wScroll / Class15.smethod_0(7), this.int_68 - Class15.smethod_0(3) + index * Class15.smethod_0(66), GClass97.int_2);
          this.indexRowMax += Class15.smethod_0(1);
        }
        this.int_68 += (GClass20.smethod_1().taskMaint.names.Length - Class15.smethod_0(1)) * Class15.smethod_0(66);
        int index1 = Class15.smethod_0(0);
        string empty = string.Empty;
        for (int index2 = Class15.smethod_0(0); index2 < GClass20.smethod_1().taskMaint.subNames.Length; index2 += Class15.smethod_0(1))
        {
          if (GClass20.smethod_1().taskMaint.subNames[index2] != null)
          {
            index1 = index2;
            string st = Class13.smethod_0(192632) + GClass20.smethod_1().taskMaint.subNames[index2];
            if (GClass20.smethod_1().taskMaint.counts[index2] != (short) -1)
            {
              if (GClass20.smethod_1().taskMaint.index == index2)
              {
                if ((int) GClass20.smethod_1().taskMaint.counts[index2] != Class15.smethod_0(1))
                {
                  string str = st;
                  string[] strArray = new string[Class15.smethod_0(37)];
                  strArray[Class15.smethod_0(0)] = str;
                  strArray[Class15.smethod_0(1)] = Class13.smethod_0(192629);
                  strArray[Class15.smethod_0(7)] = GClass20.smethod_1().taskMaint.count.ToString();
                  strArray[Class15.smethod_0(5)] = Class13.smethod_0(192623);
                  strArray[Class15.smethod_0(2)] = GClass20.smethod_1().taskMaint.counts[index2].ToString();
                  strArray[Class15.smethod_0(3)] = Class13.smethod_0(194363);
                  st = string.Concat(strArray);
                }
                if ((int) GClass20.smethod_1().taskMaint.count == (int) GClass20.smethod_1().taskMaint.counts[index2])
                {
                  GClass97.gclass97_11.method_6(g, st, this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
                }
                else
                {
                  GClass97 gclass9716 = GClass97.gclass97_16;
                  if (!flag)
                  {
                    flag = Class15.smethod_0(1) != 0;
                    GClass97 gclass9718 = GClass97.gclass97_18;
                    gclass9718.method_6(g, st, this.xstart + Class15.smethod_0(3) + (gclass9718 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
                  }
                  else
                    gclass9716.method_6(g, Class13.smethod_0(194361), this.xstart + Class15.smethod_0(3) + (gclass9716 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
                }
              }
              else if (GClass20.smethod_1().taskMaint.index > index2)
              {
                if ((int) GClass20.smethod_1().taskMaint.counts[index2] != Class15.smethod_0(1))
                {
                  string str = st;
                  string[] strArray = new string[Class15.smethod_0(37)];
                  strArray[Class15.smethod_0(0)] = str;
                  strArray[Class15.smethod_0(1)] = Class13.smethod_0(192629);
                  strArray[Class15.smethod_0(7)] = GClass20.smethod_1().taskMaint.counts[index2].ToString();
                  strArray[Class15.smethod_0(5)] = Class13.smethod_0(192623);
                  strArray[Class15.smethod_0(2)] = GClass20.smethod_1().taskMaint.counts[index2].ToString();
                  strArray[Class15.smethod_0(3)] = Class13.smethod_0(194363);
                  st = string.Concat(strArray);
                }
                GClass97.gclass97_20.method_6(g, st, this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
              }
              else
              {
                if ((int) GClass20.smethod_1().taskMaint.counts[index2] != Class15.smethod_0(1))
                  st = st + Class13.smethod_0(194355) + GClass20.smethod_1().taskMaint.counts[index2].ToString();
                GClass97 gclass9716 = GClass97.gclass97_16;
                if (!flag)
                {
                  flag = Class15.smethod_0(1) != 0;
                  GClass97 gclass9718 = GClass97.gclass97_18;
                  gclass9718.method_6(g, st, this.xstart + Class15.smethod_0(3) + (gclass9718 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
                }
                else
                  gclass9716.method_6(g, Class13.smethod_0(194361), this.xstart + Class15.smethod_0(3) + (gclass9716 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
              }
            }
            else if (GClass20.smethod_1().taskMaint.index > index2)
            {
              GClass97.gclass97_20.method_6(g, st, this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
            }
            else
            {
              GClass97 gclass9716 = GClass97.gclass97_16;
              if (!flag)
              {
                flag = Class15.smethod_0(1) != 0;
                GClass97 gclass9718 = GClass97.gclass97_18;
                gclass9718.method_6(g, st, this.xstart + Class15.smethod_0(3) + (gclass9718 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
              }
              else
                gclass9716.method_6(g, Class13.smethod_0(194361), this.xstart + Class15.smethod_0(3) + (gclass9716 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
            }
            this.indexRowMax += Class15.smethod_0(1);
          }
          else if (GClass20.smethod_1().taskMaint.index <= index2)
          {
            string st = Class13.smethod_0(192632) + GClass20.smethod_1().taskMaint.subNames[index1];
            GClass97 gclass97 = GClass97.gclass97_16;
            if (!flag)
            {
              flag = Class15.smethod_0(1) != 0;
              gclass97 = GClass97.gclass97_18;
            }
            gclass97.method_6(g, st, this.xstart + Class15.smethod_0(3) + (gclass97 != GClass97.gclass97_18 || GClass62.int_8 % Class15.smethod_0(51) <= Class15.smethod_0(31) ? Class15.smethod_0(0) : GClass62.int_8 % Class15.smethod_0(2) / Class15.smethod_0(7)), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
          }
        }
        this.int_68 += Class15.smethod_0(3);
        for (int index3 = Class15.smethod_0(0); index3 < GClass20.smethod_1().taskMaint.details.Length; index3 += Class15.smethod_0(1))
        {
          GClass97.gclass97_14.method_6(g, GClass20.smethod_1().taskMaint.details[index3], this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
          this.indexRowMax += Class15.smethod_0(1);
        }
      }
      else
      {
        int index4 = GClass116.smethod_25();
        sbyte index5 = GClass116.smethod_26();
        string empty = string.Empty;
        string src;
        if (index4 != Class15.smethod_0(134) && (int) index5 != Class15.smethod_0(134))
        {
          if (GClass20.smethod_1().taskMaint == null && GClass20.smethod_1().ctaskId == Class15.smethod_0(45) && GClass20.smethod_1().nClass.classId == 0)
          {
            src = GClass109.string_115;
          }
          else
          {
            if ((int) index5 < Class15.smethod_0(0) || index4 < Class15.smethod_0(0))
              return;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_111[Class15.smethod_0(0)];
            strArray[Class15.smethod_0(1)] = GClass21.gclass139_0[(int) index5].name;
            strArray[Class15.smethod_0(7)] = GClass109.string_111[Class15.smethod_0(1)];
            strArray[Class15.smethod_0(5)] = GClass185.string_2[index4];
            strArray[Class15.smethod_0(2)] = GClass109.string_111[Class15.smethod_0(7)];
            src = string.Concat(strArray);
          }
        }
        else
          src = GClass109.string_111[Class15.smethod_0(5)];
        string[] strArray1 = GClass97.gclass97_20.method_15(src, Class15.smethod_0(19));
        for (int index6 = Class15.smethod_0(0); index6 < strArray1.Length; index6 += Class15.smethod_0(1))
        {
          if (index6 == 0)
            GClass97.gclass97_20.method_6(g, strArray1[index6], this.xstart + Class15.smethod_0(3), this.int_68 = this.ystart, Class15.smethod_0(0));
          else
            GClass97.gclass97_20.method_6(g, strArray1[index6], this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
        }
      }
    }
    else if (this.indexMenu == Class15.smethod_0(1))
    {
      this.int_68 = this.ystart - Class15.smethod_0(66);
      for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().taskOrders.method_2(); index += Class15.smethod_0(1))
      {
        GClass180 gclass180 = (GClass180) GClass20.smethod_1().taskOrders.method_3(index);
        GClass97.gclass97_20.method_6(g, gclass180.name, this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
        if (gclass180.count == (int) gclass180.maxCount)
        {
          GClass97 gclass9720 = GClass97.gclass97_20;
          GClass98 g1 = g;
          string[] strArray = new string[Class15.smethod_0(88)];
          strArray[Class15.smethod_0(0)] = gclass180.taskId != 0 ? GClass109.string_154 : GClass109.string_153;
          strArray[Class15.smethod_0(1)] = Class13.smethod_0(194411);
          strArray[Class15.smethod_0(7)] = GClass100.gclass106_0[gclass180.killId].name;
          strArray[Class15.smethod_0(5)] = Class13.smethod_0(192629);
          strArray[Class15.smethod_0(2)] = gclass180.count.ToString();
          strArray[Class15.smethod_0(3)] = Class13.smethod_0(192623);
          strArray[Class15.smethod_0(37)] = gclass180.maxCount.ToString();
          strArray[Class15.smethod_0(38)] = Class13.smethod_0(194363);
          string st = string.Concat(strArray);
          int x = this.xstart + Class15.smethod_0(3);
          int y = this.int_68 += Class15.smethod_0(66);
          int align = Class15.smethod_0(0);
          gclass9720.method_6(g1, st, x, y, align);
        }
        else
        {
          GClass97 gclass9718 = GClass97.gclass97_18;
          GClass98 g2 = g;
          string[] strArray = new string[Class15.smethod_0(88)];
          strArray[Class15.smethod_0(0)] = gclass180.taskId != 0 ? GClass109.string_154 : GClass109.string_153;
          strArray[Class15.smethod_0(1)] = Class13.smethod_0(194411);
          strArray[Class15.smethod_0(7)] = GClass100.gclass106_0[gclass180.killId].name;
          strArray[Class15.smethod_0(5)] = Class13.smethod_0(192629);
          strArray[Class15.smethod_0(2)] = gclass180.count.ToString();
          strArray[Class15.smethod_0(3)] = Class13.smethod_0(192623);
          strArray[Class15.smethod_0(37)] = gclass180.maxCount.ToString();
          strArray[Class15.smethod_0(38)] = Class13.smethod_0(194363);
          string st = string.Concat(strArray);
          int x = this.xstart + Class15.smethod_0(3);
          int y = this.int_68 += Class15.smethod_0(66);
          int align = Class15.smethod_0(0);
          gclass9718.method_6(g2, st, x, y, align);
        }
        this.indexRowMax += Class15.smethod_0(5);
        this.inforW = this.popupW - Class15.smethod_0(46);
        this.method_138(g, GClass97.gclass97_16, gclass180.description, this.xstart + Class15.smethod_0(3), this.int_68 += Class15.smethod_0(66), Class15.smethod_0(0));
        this.int_68 += Class15.smethod_0(66);
      }
    }
    if (this.gclass154_0 != null)
      return;
    this.gclass154_0 = new GClass154();
    this.gclass154_0.method_6(this.indexRowMax, Class15.smethod_0(66), this.xScroll, this.yScroll, this.wScroll, this.hScroll - num - Class15.smethod_0(54), Class15.smethod_0(1) != 0, Class15.smethod_0(1));
  }

  public void method_137(
    GClass98 g,
    GClass97 f,
    string[] arr,
    string str,
    int x,
    int y,
    int align)
  {
    for (int index = Class15.smethod_0(0); index < arr.Length; index += Class15.smethod_0(1))
    {
      string st = arr[index];
      if ((!st.StartsWith(Class13.smethod_0(195513)) ? 1 : 0) == 0)
      {
        if ((!st.StartsWith(Class13.smethod_0(196548)) ? 1 : 0) == 0)
        {
          st = st.Substring(Class15.smethod_0(7));
          f = GClass97.gclass97_6;
        }
        else if ((!st.StartsWith(Class13.smethod_0(196545)) ? 1 : 0) == 0)
        {
          st = st.Substring(Class15.smethod_0(7));
          f = GClass97.gclass97_4;
        }
        else if ((!st.StartsWith(Class13.smethod_0(196158)) ? 1 : 0) == 0)
        {
          st = st.Substring(Class15.smethod_0(7));
          f = GClass97.gclass97_8;
        }
      }
      if ((index == 0 ? 0 : 1) == 0)
      {
        f.method_6(g, st, x, y, align);
      }
      else
      {
        if (index < this.indexRow + Class15.smethod_0(6) && index > this.indexRow - Class15.smethod_0(6))
          f.method_6(g, st, x, y += Class15.smethod_0(66), align);
        else
          y += Class15.smethod_0(66);
        this.int_68 += Class15.smethod_0(66);
        this.indexRowMax += Class15.smethod_0(1);
      }
    }
  }

  public void method_138(GClass98 g, GClass97 f, string str, int x, int y, int align)
  {
    int num = (!GClass62.bool_5 ? 1 : 0) != 0 || GClass62.int_10 < Class15.smethod_0(197) ? Class15.smethod_0(31) : Class15.smethod_0(51);
    string[] strArray = f.method_15(str, this.inforW - num);
    for (int index = Class15.smethod_0(0); index < strArray.Length; index += Class15.smethod_0(1))
    {
      if ((index == 0 ? 0 : 1) == 0)
      {
        f.method_6(g, strArray[index], x, y, align);
      }
      else
      {
        if (index < this.indexRow + Class15.smethod_0(9) && index > this.indexRow - Class15.smethod_0(9))
          f.method_6(g, strArray[index], x, y += Class15.smethod_0(66), align);
        else
          y += Class15.smethod_0(66);
        this.int_68 += Class15.smethod_0(66);
        this.indexRowMax += Class15.smethod_0(1);
      }
    }
  }

  public void method_139()
  {
    for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      ((GClass80) this.vItemCombine.method_3(index)).isSelect = Class15.smethod_0(0) != 0;
    this.vItemCombine.method_9();
  }

  public void method_140()
  {
    if (this.int_21 > Class15.smethod_0(0))
    {
      this.isClose = Class15.smethod_0(0) != 0;
    }
    else
    {
      if ((!this.method_202() ? 1 : 0) == 0)
        GClass20.smethod_1().method_134();
      if ((this.chatTField == null ? 1 : 0) == 0 && this.type == Class15.smethod_0(47) && (!this.chatTField.isShow ? 1 : 0) == 0)
        this.chatTField = (GClass23) null;
      if (this.type == Class15.smethod_0(47) && (!this.isAccept ? 0 : 1) == 0)
        GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(5), -1, (sbyte) -1, -1);
      GClass151.smethod_7(Class13.smethod_0(196103));
      GClass172.smethod_1().method_34();
      GClass116.bool_58 = Class15.smethod_0(1) != 0;
      GClass185.sbyte_3 = (sbyte) -1;
      GClass141.gclass66_2 = (GClass66) null;
      GClass126.smethod_26();
      this.bool_3 = Class15.smethod_0(0) != 0;
      this.isClose = Class15.smethod_0(1) != 0;
      this.method_139();
      GClass65.smethod_2();
      GClass62.gclass141_1 = (GClass141) null;
      GClass62.smethod_46();
      GClass62.smethod_24();
      this.int_51 = this.int_52 = Class15.smethod_0(0);
      this.bool_4 = Class15.smethod_0(0) != 0;
      this.isShow = Class15.smethod_0(0) != 0;
      if (GClass20.smethod_1().cHP > Class15.smethod_0(0) && GClass20.smethod_1().statusMe != Class15.smethod_0(49) && GClass20.smethod_1().statusMe != Class15.smethod_0(3) || (!GClass20.smethod_1().meDead ? 1 : 0) != 0)
        return;
      GClass31 gclass31 = new GClass31(GClass109.string_112[Class15.smethod_0(0)], Class15.smethod_0(366), (object) GClass116.smethod_6());
      GClass116.smethod_6().center = gclass31;
      GClass20.smethod_1().cHP = Class15.smethod_0(0);
    }
  }

  public void method_141()
  {
    if (this.int_21 > Class15.smethod_0(0))
    {
      this.isClose = Class15.smethod_0(0) != 0;
    }
    else
    {
      if ((!this.method_202() ? 1 : 0) == 0)
        GClass20.smethod_1().method_134();
      if ((this.chatTField == null ? 1 : 0) == 0 && this.type == Class15.smethod_0(47) && (!this.chatTField.isShow ? 1 : 0) == 0)
        this.chatTField = (GClass23) null;
      if (this.type == Class15.smethod_0(47) && (!this.isAccept ? 0 : 1) == 0)
        GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(5), -1, (sbyte) -1, -1);
      if (this.type == Class15.smethod_0(9))
        GClass156.smethod_0().method_141(-1);
      GClass172.smethod_1().method_34();
      GClass116.bool_58 = Class15.smethod_0(1) != 0;
      GClass185.sbyte_3 = (sbyte) -1;
      if ((GClass141.gclass66_2 == null ? 1 : 0) == 0)
      {
        GClass141.gclass66_2.texture = (Texture2D) null;
        GClass141.gclass66_2 = (GClass66) null;
      }
      GClass126.smethod_26();
      this.bool_3 = Class15.smethod_0(0) != 0;
      if (this.type != Class15.smethod_0(2))
      {
        if (this.type == Class15.smethod_0(40))
          this.method_159();
        else if (this.type == Class15.smethod_0(29))
          this.method_34();
        else if (this.type != Class15.smethod_0(5) && this.type != Class15.smethod_0(49))
        {
          if (this.type != Class15.smethod_0(124) && this.type != Class15.smethod_0(65) && this.type != Class15.smethod_0(51) && this.type != Class15.smethod_0(27))
          {
            if (this.type != Class15.smethod_0(88) && this.type != Class15.smethod_0(67) && this.type != Class15.smethod_0(10))
            {
              this.isClose = Class15.smethod_0(1) != 0;
            }
            else
            {
              this.method_195();
              this.cmx = this.cmtoX = Class15.smethod_0(0);
            }
          }
          else
          {
            this.method_34();
            this.cmx = this.cmtoX = Class15.smethod_0(0);
          }
        }
        else if ((!this.bool_12 ? 1 : 0) == 0)
        {
          this.isClose = Class15.smethod_0(1) != 0;
        }
        else
        {
          this.method_34();
          this.cmx = this.cmtoX = Class15.smethod_0(0);
        }
      }
      else
      {
        this.method_34();
        this.cmx = this.cmtoX = Class15.smethod_0(0);
      }
      GClass65.smethod_2();
      GClass62.gclass141_1 = (GClass141) null;
      GClass62.smethod_46();
      GClass62.smethod_24();
      GClass62.bool_22 = Class15.smethod_0(0) != 0;
      this.int_51 = this.int_52 = Class15.smethod_0(0);
      this.bool_4 = Class15.smethod_0(0) != 0;
      if (GClass20.smethod_1().cHP > Class15.smethod_0(0) && GClass20.smethod_1().statusMe != Class15.smethod_0(49) && GClass20.smethod_1().statusMe != Class15.smethod_0(3) || (!GClass20.smethod_1().meDead ? 1 : 0) != 0)
        return;
      GClass31 gclass31 = new GClass31(GClass109.string_112[Class15.smethod_0(0)], Class15.smethod_0(366), (object) GClass116.smethod_6());
      GClass116.smethod_6().center = gclass31;
      GClass20.smethod_1().cHP = Class15.smethod_0(0);
    }
  }

  public void method_142()
  {
    if ((this.chatTField == null ? 1 : 0) == 0 && (!this.chatTField.isShow ? 1 : 0) == 0)
      this.chatTField.method_7();
    else if ((!this.bool_13 ? 1 : 0) == 0)
    {
      this.int_77 += Class15.smethod_0(1);
      if (this.int_77 != Class15.smethod_0(31))
        return;
      this.int_77 = Class15.smethod_0(0);
      this.bool_13 = Class15.smethod_0(0) != 0;
      this.chatTField.tfChat.method_23(string.Empty);
      this.chatTField.strChat = GClass109.string_406 + Class13.smethod_0(196195);
      this.chatTField.tfChat.name = GClass109.string_322;
      this.chatTField.to = string.Empty;
      this.chatTField.isShow = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.method_28(GClass184.int_8);
      this.chatTField.tfChat.method_26(Class15.smethod_0(45));
      if ((!GClass62.bool_5 ? 1 : 0) == 0)
        this.chatTField.tfChat.method_0();
      if ((!Main.bool_4 ? 1 : 0) == 0)
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
      if ((!Main.bool_3 ? 0 : 1) != 0)
        return;
      this.chatTField.method_5((GInterface1) this, string.Empty);
    }
    else if ((!this.bool_14 ? 1 : 0) == 0)
    {
      this.int_77 += Class15.smethod_0(1);
      if (this.int_77 != Class15.smethod_0(31))
        return;
      this.int_77 = Class15.smethod_0(0);
      this.bool_14 = Class15.smethod_0(0) != 0;
      this.chatTField.tfChat.method_23(string.Empty);
      this.chatTField.strChat = GClass109.string_407 + Class13.smethod_0(196193);
      this.chatTField.tfChat.name = GClass109.string_322;
      this.chatTField.to = string.Empty;
      this.chatTField.isShow = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.method_28(GClass184.int_8);
      this.chatTField.tfChat.method_26(Class15.smethod_0(45));
      if ((!GClass62.bool_5 ? 1 : 0) == 0)
        this.chatTField.tfChat.method_0();
      if ((!Main.bool_4 ? 1 : 0) == 0)
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
      if ((!Main.bool_3 ? 0 : 1) != 0)
        return;
      this.chatTField.method_5((GInterface1) this, string.Empty);
    }
    else
    {
      if ((this.gclass154_0 == null ? 1 : 0) == 0)
        this.gclass154_0.method_5();
      if ((this.tabIcon == null ? 1 : 0) == 0 && (!this.tabIcon.isShow ? 1 : 0) == 0)
      {
        this.tabIcon.method_7();
      }
      else
      {
        this.method_85();
        if (this.int_54 > Class15.smethod_0(0))
        {
          this.int_54 -= Class15.smethod_0(1);
          if ((this.int_54 == 0 ? 0 : 1) == 0)
          {
            this.int_6[this.currentTabIndex] = this.selected;
            switch (this.type)
            {
              case 0:
                this.method_174();
                break;
              case 1:
              case 17:
                this.method_153();
                break;
              case 2:
                this.method_182();
                break;
              case 3:
                this.method_180();
                break;
              case 4:
                this.method_179();
                break;
              case 7:
                if ((!this.Equals((object) GClass62.gclass141_1) ? 1 : 0) == 0 && GClass62.gclass141_0.type == Class15.smethod_0(7))
                {
                  this.method_182();
                  return;
                }
                this.method_155();
                break;
              case 8:
                this.method_172();
                break;
              case 9:
                this.method_154();
                break;
              case 10:
                this.method_152();
                break;
              case 11:
                this.method_170();
                break;
              case 12:
                this.method_151();
                break;
              case 13:
                this.method_150();
                break;
              case 14:
                this.method_149();
                break;
              case 15:
                this.method_148();
                break;
              case 16:
                this.method_169();
                break;
              case 18:
                this.method_171();
                break;
              case 19:
                this.method_194();
                break;
              case 20:
                this.method_198();
                break;
              case 21:
                this.method_146();
                break;
              case 22:
                this.method_145();
                break;
              case 23:
                this.method_144();
                break;
              case 25:
                this.method_143();
                break;
            }
          }
        }
        for (int index = Class15.smethod_0(0); index < GClass28.gclass134_0.method_2(); index += Class15.smethod_0(1))
          ((GClass28) GClass28.gclass134_0.method_3(index)).method_1();
        this.method_186();
      }
    }
  }

  private void method_143()
  {
  }

  private void method_144()
  {
    if (this.selected == -1)
      return;
    this.int_75 = this.selected;
    ((Class7) GClass141.gclass134_0.method_3(this.int_75)).hasRead = Class15.smethod_0(1) != 0;
    GClass152.smethod_9(((Class7) GClass141.gclass134_0.method_3(this.int_75)).id.ToString() + string.Empty, Class15.smethod_0(1));
    this.method_158();
  }

  private void method_145()
  {
  }

  private void method_146()
  {
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
    {
      if (this.selected == -1 || this.selected > GClass20.smethod_2().arrItemBody.Length - Class15.smethod_0(1))
        return;
      GClass134 menuItems = new GClass134(string.Empty);
      this.currItem = GClass20.smethod_2().arrItemBody[this.selected];
      if ((this.currItem == null ? 1 : 0) == 0)
      {
        menuItems.method_0((object) new GClass31(GClass109.string_310, (GInterface0) this, Class15.smethod_0(509), (object) this.currItem));
        GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
        this.method_36(this.currItem);
      }
      else
        this.cp = (GClass43) null;
    }
    if (this.currentTabIndex == Class15.smethod_0(1))
      this.method_147();
    if (this.currentTabIndex != Class15.smethod_0(7))
      return;
    this.method_155();
  }

  private void method_147()
  {
    if (this.selected == -1)
      return;
    if (this.selected == Class15.smethod_0(3))
    {
      GClass62.smethod_34(GClass109.string_437, new GClass31(GClass109.string_135, Class15.smethod_0(396)), new GClass31(GClass109.string_136, Class15.smethod_0(406)));
    }
    else
    {
      GClass156.smethod_0().method_133((sbyte) this.selected);
      if (this.selected >= Class15.smethod_0(2))
        return;
      GClass20.smethod_2().petStatus = (sbyte) this.selected;
    }
  }

  private void method_148()
  {
    if (this.selected < -1)
      return;
    if ((!this.bool_2 ? 1 : 0) == 0)
    {
      GClass156.smethod_0().method_128(this.topName, (sbyte) this.selected);
    }
    else
    {
      GClass134 menuItems = new GClass134(string.Empty);
      menuItems.method_0((object) new GClass31(GClass109.string_101[Class15.smethod_0(0)], (GInterface0) this, Class15.smethod_0(79), (object) (GClass187) this.vTop.method_3(this.selected)));
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_40((GClass187) this.vTop.method_3(this.selected));
    }
  }

  private void method_149() => this.method_180();

  private void method_150()
  {
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0 && (!this.Equals((object) GClass62.gclass141_0) ? 1 : 0) == 0)
    {
      this.method_155();
    }
    else
    {
      if ((this.currentTabIndex == 0 ? 0 : 1) == 0 && (!this.Equals((object) GClass62.gclass141_1) ? 0 : 1) != 0 || this.currentTabIndex == Class15.smethod_0(7))
      {
        this.currItem = (!this.Equals((object) GClass62.gclass141_1) ? 1 : 0) != 0 ? (GClass80) GClass62.gclass141_0.vFriendGD.method_3(this.selected) : (GClass80) GClass62.gclass141_1.vFriendGD.method_3(this.selected);
        GClass151.smethod_10(Class13.smethod_0(188905) + this.selected.ToString());
        GClass134 menuItems = new GClass134();
        menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currItem));
        if ((this.currItem == null ? 1 : 0) == 0)
        {
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_36(this.currItem);
        }
        else
          this.cp = (GClass43) null;
      }
      if (this.currentTabIndex == Class15.smethod_0(1))
      {
        if (this.selected == this.currentListLength - Class15.smethod_0(5))
        {
          if ((!this.isLock ? 1 : 0) == 0)
            return;
          this.method_164();
        }
        else if (this.selected == this.currentListLength - Class15.smethod_0(7))
        {
          if ((!this.isAccept ? 0 : 1) == 0)
          {
            this.isLock = (this.isLock ? 1 : 0) == Class15.smethod_0(0);
            if ((!this.isLock ? 1 : 0) == 0)
            {
              GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(3), -1, (sbyte) -1, -1);
            }
            else
            {
              this.method_141();
              GClass71.smethod_1();
              GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(5), -1, (sbyte) -1, -1);
            }
          }
          else
            this.isAccept = Class15.smethod_0(0) != 0;
        }
        else if (this.selected == this.currentListLength - Class15.smethod_0(1))
        {
          if ((!this.isLock ? 1 : 0) == 0 && (!this.isAccept ? 0 : 1) == 0 && (!this.isFriendLock ? 1 : 0) == 0)
            GClass62.smethod_34(GClass109.string_341, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(510), (object) null), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) null));
        }
        else
        {
          if ((!this.isLock ? 1 : 0) == 0)
            return;
          this.currItem = (GClass80) GClass62.gclass141_0.vMyGD.method_3(this.selected);
          GClass134 menuItems = new GClass134();
          menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currItem));
          if ((this.currItem == null ? 1 : 0) == 0)
          {
            GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
            this.method_36(this.currItem);
          }
          else
            this.cp = (GClass43) null;
        }
      }
      if ((!GClass62.bool_5 ? 1 : 0) != 0)
        return;
      this.selected = -1;
    }
  }

  private void method_151()
  {
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
    {
      if (this.selected == -1 || (this.vItemCombine.method_2() == 0 ? 0 : 1) == 0)
        return;
      if (this.selected == this.vItemCombine.method_2())
      {
        this.int_58 = -1;
        this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
        GClass71.smethod_1();
        GClass156.smethod_0().method_6((sbyte) Class15.smethod_0(1), this.vItemCombine);
        return;
      }
      if (this.selected > this.vItemCombine.method_2() - Class15.smethod_0(1))
        return;
      this.currItem = (GClass80) GClass62.gclass141_0.vItemCombine.method_3(this.selected);
      GClass134 menuItems = new GClass134();
      menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(512), (object) this.currItem));
      if ((this.currItem == null ? 1 : 0) == 0)
      {
        GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
        this.method_36(this.currItem);
      }
      else
        this.cp = (GClass43) null;
    }
    if (this.currentTabIndex != Class15.smethod_0(1))
      return;
    this.method_155();
  }

  private void method_152()
  {
    if (this.selected == -1)
      return;
    this.bool_9 = Class15.smethod_0(1) != 0;
    this.method_141();
  }

  private void method_153()
  {
    this.currItem = (GClass80) null;
    if (this.selected < Class15.smethod_0(0))
      return;
    GClass134 menuItems = new GClass134();
    if (this.currentTabIndex < this.currentTabName.Length - (GClass62.gclass141_1 == null ? Class15.smethod_0(1) : Class15.smethod_0(0)) && this.type != Class15.smethod_0(186))
    {
      this.currItem = GClass20.smethod_1().arrItemShop[this.currentTabIndex][this.selected];
      if (this.currItem != null)
      {
        if (this.currItem.isBuySpec)
        {
          if (this.currItem.buySpec > Class15.smethod_0(0))
            menuItems.method_0((object) new GClass31(GClass109.string_343 + Class13.smethod_0(189772) + GClass151.smethod_29((long) this.currItem.buySpec), (GInterface0) this, Class15.smethod_0(513), (object) this.currItem));
        }
        else if (this.typeShop == Class15.smethod_0(2))
        {
          menuItems.method_0((object) new GClass31(GClass109.string_209, (GInterface0) this, Class15.smethod_0(514), (object) this.currItem));
          menuItems.method_0((object) new GClass31(GClass109.string_129, (GInterface0) this, Class15.smethod_0(515), (object) this.currItem));
          menuItems.method_0((object) new GClass31(GClass109.string_210, (GInterface0) this, Class15.smethod_0(516), (object) this.currItem));
        }
        else if (this.currItem.buyCoin == 0 && this.currItem.buyGold == 0)
        {
          if (this.currItem.powerRequire != 0L)
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_342;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_28(this.currItem.powerRequire);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189904);
            strArray[Class15.smethod_0(2)] = GClass109.string_381;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(517), (object) this.currItem);
            gclass134.method_0((object) o);
          }
          else
          {
            menuItems.method_0((object) new GClass31(GClass109.string_209 + Class13.smethod_0(189772) + GClass109.string_333, (GInterface0) this, Class15.smethod_0(302), (object) this.currItem));
            menuItems.method_0((object) new GClass31(Class13.smethod_0(189544), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(5), (object) new GClass5.GClass6((int) this.currItem.template.id, (short) -1, Class15.smethod_0(1) != 0, Class15.smethod_0(0) != 0)));
          }
        }
        else if (this.typeShop == Class15.smethod_0(88))
        {
          if (this.currItem.buyCoin > Class15.smethod_0(0))
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyCoin);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_156;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(514), (object) this.currItem);
            gclass134.method_0((object) o);
          }
          if (this.currItem.buyGold > Class15.smethod_0(0))
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyGold);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_157;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(515), (object) this.currItem);
            gclass134.method_0((object) o);
          }
        }
        else if (this.typeShop != Class15.smethod_0(7))
        {
          if (this.currItem.buyCoin > Class15.smethod_0(0))
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyCoin);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_156;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(302), (object) this.currItem);
            gclass134.method_0((object) o);
            menuItems.method_0((object) new GClass31(Class13.smethod_0(189675) + GClass151.smethod_29((long) this.currItem.buyCoin) + Class13.smethod_0(190244), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(5), (object) new GClass5.GClass6((int) this.currItem.template.id, (short) -1, Class15.smethod_0(1) != 0, Class15.smethod_0(0) != 0)));
          }
          if (this.currItem.buyGold > Class15.smethod_0(0))
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyGold);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_157;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(518), (object) this.currItem);
            gclass134.method_0((object) o);
            menuItems.method_0((object) new GClass31(Class13.smethod_0(189675) + GClass151.smethod_29((long) this.currItem.buyGold) + Class13.smethod_0(190235), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(5), (object) new GClass5.GClass6((int) this.currItem.template.id, (short) -1, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0)));
          }
        }
        else
        {
          if (this.currItem.buyCoin != -1)
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyCoin);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_156;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(519), (object) this.currItem);
            gclass134.method_0((object) o);
          }
          if (this.currItem.buyGold != -1)
          {
            GClass134 gclass134 = menuItems;
            string[] strArray = new string[Class15.smethod_0(3)];
            strArray[Class15.smethod_0(0)] = GClass109.string_343;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(7)] = GClass151.smethod_29((long) this.currItem.buyGold);
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(189772);
            strArray[Class15.smethod_0(2)] = GClass109.string_157;
            GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(520), (object) this.currItem);
            gclass134.method_0((object) o);
          }
        }
      }
    }
    else if (this.typeShop == 0)
    {
      GClass80[] arrItemBody = GClass20.smethod_1().arrItemBody;
      if (this.selected >= arrItemBody.Length)
      {
        sbyte index = (sbyte) (this.selected - arrItemBody.Length);
        GClass80 gclass80 = GClass20.smethod_1().arrItemBag[(int) index];
        if (gclass80 != null)
          this.currItem = gclass80;
      }
      else
      {
        GClass80 gclass80 = GClass20.smethod_1().arrItemBody[this.selected];
        if (gclass80 != null)
          this.currItem = gclass80;
      }
      if (this.currItem != null)
        menuItems.method_0((object) new GClass31(GClass109.string_316, (GInterface0) this, Class15.smethod_0(521), (object) this.currItem));
    }
    else
    {
      this.currItem = this.type != Class15.smethod_0(186) ? GClass20.smethod_1().arrItemShop[this.currentTabIndex][this.selected] : GClass20.smethod_1().arrItemShop[Class15.smethod_0(2)][this.selected];
      if (this.currItem.buyType == (sbyte) 0)
      {
        if (this.currItem.method_5(Class15.smethod_0(121)))
          menuItems.method_0((object) new GClass31(GClass109.string_405, (GInterface0) this, Class15.smethod_0(522), (object) this.currItem));
        else
          menuItems.method_0((object) new GClass31(GClass109.string_404, (GInterface0) this, Class15.smethod_0(523), (object) this.currItem));
      }
      else if ((int) this.currItem.buyType == Class15.smethod_0(1))
      {
        menuItems.method_0((object) new GClass31(GClass109.string_408, (GInterface0) this, Class15.smethod_0(524), (object) this.currItem));
        menuItems.method_0((object) new GClass31(GClass109.string_413, (GInterface0) this, Class15.smethod_0(525), (object) this.currItem));
      }
      else if ((int) this.currItem.buyType == Class15.smethod_0(7))
        menuItems.method_0((object) new GClass31(GClass109.string_409, (GInterface0) this, Class15.smethod_0(526), (object) this.currItem));
    }
    if (this.currItem != null)
    {
      GClass20.smethod_1().method_133(this.currItem.headTemp, this.currItem.bodyTemp, this.currItem.legTemp, this.currItem.bagTemp);
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_36(this.currItem);
    }
    else
      this.cp = (GClass43) null;
  }

  private void method_154()
  {
    if (this.selected < Class15.smethod_0(0) || (!GClass20.smethod_1().arrArchive[this.selected].isFinish ? 1 : 0) != 0 || (!GClass20.smethod_1().arrArchive[this.selected].isRecieve ? 0 : 1) != 0)
      return;
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
    {
      GClass156.smethod_0().method_15(this.selected);
    }
    else
    {
      if (GClass62.int_0 <= this.xScroll + this.wScroll - Class15.smethod_0(54))
        return;
      GClass156.smethod_0().method_15(this.selected);
    }
  }

  private void method_155()
  {
    GClass151.smethod_7(Class13.smethod_0(190320));
    if (this.selected == -1)
      return;
    this.currItem = (GClass80) null;
    GClass134 menuItems = new GClass134();
    GClass80[] arrItemBody = GClass20.smethod_1().arrItemBody;
    if (this.selected >= arrItemBody.Length)
    {
      sbyte index = (sbyte) (this.selected - arrItemBody.Length);
      GClass80 gclass80 = GClass20.smethod_1().arrItemBag[(int) index];
      if ((gclass80 == null ? 1 : 0) == 0)
      {
        this.currItem = gclass80;
        if (GClass62.gclass141_0.type == Class15.smethod_0(66))
          menuItems.method_0((object) new GClass31(GClass109.string_345, (GInterface0) this, Class15.smethod_0(116), (object) this.currItem));
        else if (GClass62.gclass141_0.type == Class15.smethod_0(47))
          menuItems.method_0((object) new GClass31(GClass109.string_346, (GInterface0) this, Class15.smethod_0(527), (object) this.currItem));
        else if ((!gclass80.method_7() ? 1 : 0) == 0)
        {
          menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(20), (object) this.currItem));
          if ((!GClass20.smethod_1().havePet ? 1 : 0) == 0)
            menuItems.method_0((object) new GClass31(GClass109.string_311, (GInterface0) this, Class15.smethod_0(390), (object) this.currItem));
        }
        else
        {
          menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(406), (object) this.currItem));
          if ((int) this.currItem.template.id != Class15.smethod_0(235))
          {
            if ((!GClass5.gclass5_0.method_1((int) this.currItem.template.id) ? 1 : 0) == 0)
              menuItems.method_0((object) new GClass31(Class13.smethod_0(190461), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(7), (object) (int) this.currItem.template.id));
            else
              menuItems.method_0((object) new GClass31(Class13.smethod_0(190427), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(1), (object) new GClass5.GClass6((int) this.currItem.template.id, this.currItem.template.name)));
          }
        }
      }
    }
    else
    {
      GClass80 gclass80 = GClass20.smethod_1().arrItemBody[this.selected];
      if ((gclass80 == null ? 1 : 0) == 0)
      {
        this.currItem = gclass80;
        menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(407), (object) this.currItem));
      }
    }
    if ((this.currItem == null ? 1 : 0) == 0)
    {
      GClass20.smethod_1().method_133(this.currItem.headTemp, this.currItem.bodyTemp, this.currItem.legTemp, this.currItem.bagTemp);
      if (GClass62.gclass141_0.type != Class15.smethod_0(66) && GClass62.gclass141_0.type != Class15.smethod_0(47))
      {
        if ((this.int_20 == 0 ? 0 : 1) == 0)
          menuItems.method_0((object) new GClass31(GClass109.string_310, (GInterface0) this, Class15.smethod_0(363), (object) this.currItem));
        if (this.int_20 == Class15.smethod_0(1))
          menuItems.method_0((object) new GClass31(GClass109.string_316, (GInterface0) this, Class15.smethod_0(521), (object) this.currItem));
        if ((int) this.currItem.template.id == Class15.smethod_0(235) && this.currItem.quantity > Class15.smethod_0(1))
          menuItems.method_0((object) new GClass31(Class13.smethod_0(190400), (GInterface0) GClass5.gclass5_0, Class15.smethod_0(5), (object) new GClass5.GClass6((int) this.currItem.template.id, (short) this.currItem.indexUI, Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0)));
      }
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_36(this.currItem);
    }
    else
      this.cp = (GClass43) null;
  }

  private void method_156()
  {
    this.method_141();
    if ((GClass119.gclass134_0 == null ? 1 : 0) == 0 && (GClass119.gclass134_0.method_2() == 0 ? 0 : 1) != 0)
    {
      GClass119.smethod_2().vmethod_0();
    }
    else
    {
      GClass156.smethod_0().method_146(Class15.smethod_0(0), -1);
      GClass119.smethod_2().vmethod_0();
    }
  }

  private void method_157()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    if ((!GClass172.bool_0 ? 1 : 0) == 0 && this.selected == GClass141.string_1.Length - Class15.smethod_0(1))
      GClass156.smethod_0().method_148();
    else if ((!GClass20.smethod_1().havePet ? 0 : 1) == 0)
    {
      switch (this.selected)
      {
        case 0:
          this.method_156();
          break;
        case 1:
          this.method_141();
          GClass156.smethod_0().method_61(Class15.smethod_0(271));
          break;
        case 2:
          this.method_159();
          break;
        case 3:
          GClass156.smethod_0().method_131((sbyte) Class15.smethod_0(0), (sbyte) -1);
          GClass71.smethod_1();
          break;
        case 4:
          this.isShowZone = Class15.smethod_0(1) != 0;
          GClass156.smethod_0().method_59();
          break;
        case 5:
          GClass62.smethod_27();
          if (GClass20.smethod_1().method_141() < Class15.smethod_0(3))
          {
            GClass62.smethod_28(GClass109.string_347);
            break;
          }
          if ((this.chatTField == null ? 0 : 1) == 0)
          {
            this.chatTField = new GClass23();
            this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
            this.chatTField.method_0();
            this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
          }
          this.chatTField.strChat = GClass109.string_348;
          this.chatTField.tfChat.name = GClass109.string_138;
          this.chatTField.to = string.Empty;
          this.chatTField.isShow = Class15.smethod_0(1) != 0;
          this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
          if ((!Main.bool_4 ? 1 : 0) == 0)
            this.chatTField.tfChat.strInfo = this.chatTField.strChat;
          if ((!Main.bool_3 ? 0 : 1) == 0)
          {
            this.chatTField.method_5((GInterface1) this, string.Empty);
            break;
          }
          if ((!GClass62.bool_5 ? 1 : 0) != 0)
            break;
          this.chatTField.tfChat.method_0();
          break;
        case 6:
          this.method_195();
          break;
        case 7:
          this.method_191();
          break;
        case 8:
          GClass62.gclass117_0.method_16();
          break;
        case 9:
          if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) != 0)
            break;
          GClass172.smethod_1().method_52();
          break;
      }
    }
    else
    {
      switch (this.selected)
      {
        case 0:
          this.method_156();
          break;
        case 1:
          this.method_141();
          GClass156.smethod_0().method_61(Class15.smethod_0(271));
          break;
        case 2:
          this.method_159();
          break;
        case 3:
          this.isShowPet = Class15.smethod_0(1) != 0;
          this.method_160();
          break;
        case 4:
          GClass156.smethod_0().method_131((sbyte) Class15.smethod_0(0), (sbyte) -1);
          GClass71.smethod_1();
          break;
        case 5:
          this.isShowZone = Class15.smethod_0(1) != 0;
          GClass156.smethod_0().method_59();
          break;
        case 6:
          GClass62.smethod_27();
          if (GClass20.smethod_1().method_141() < Class15.smethod_0(3))
          {
            GClass62.smethod_28(GClass109.string_347);
            break;
          }
          if ((this.chatTField == null ? 0 : 1) == 0)
          {
            this.chatTField = new GClass23();
            this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
            this.chatTField.method_0();
            this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
          }
          this.chatTField.strChat = GClass109.string_348;
          this.chatTField.tfChat.name = GClass109.string_138;
          this.chatTField.to = string.Empty;
          this.chatTField.isShow = Class15.smethod_0(1) != 0;
          this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
          if ((!Main.bool_4 ? 1 : 0) == 0)
            this.chatTField.tfChat.strInfo = this.chatTField.strChat;
          if ((!Main.bool_3 ? 0 : 1) == 0)
          {
            this.chatTField.method_5((GInterface1) this, string.Empty);
            break;
          }
          if ((!GClass62.bool_5 ? 1 : 0) != 0)
            break;
          this.chatTField.tfChat.method_0();
          break;
        case 7:
          this.method_195();
          break;
        case 8:
          this.method_191();
          break;
        case 9:
          GClass62.gclass117_0.method_16();
          break;
        case 10:
          if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) != 0)
            break;
          GClass172.smethod_1().method_52();
          break;
      }
    }
  }

  private void method_158()
  {
    string content = ((Class7) GClass141.gclass134_0.method_3(this.int_75)).content;
    GClass141.string_13 = GClass97.gclass97_16.method_15(content, this.wScroll - Class15.smethod_0(54));
    this.currentListLength = GClass141.string_13.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(10);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.type = Class15.smethod_0(40);
    this.method_5(Class15.smethod_0(0));
  }

  private void method_159()
  {
    this.currentListLength = GClass141.gclass134_0.method_2();
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.type = Class15.smethod_0(29);
    this.method_5(Class15.smethod_0(0));
  }

  private void method_160()
  {
    GClass71.smethod_1();
    GClass156.smethod_0().method_127();
    this.int_21 = Class15.smethod_0(51);
  }

  private void method_161()
  {
    this.chatTField.strChat = GClass109.string_276;
    this.chatTField.tfChat.name = GClass109.string_277;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  private void method_162()
  {
    this.chatTField.strChat = GClass109.string_278;
    this.chatTField.tfChat.name = GClass109.string_138;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  public void method_163()
  {
    this.chatTField.strChat = GClass109.string_279;
    this.chatTField.tfChat.name = GClass109.string_276;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  public void method_164()
  {
    if ((this.chatTField == null ? 0 : 1) == 0)
    {
      this.chatTField = new GClass23();
      this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
      this.chatTField.method_0();
      this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
    }
    this.chatTField.strChat = GClass109.string_321;
    this.chatTField.tfChat.name = GClass109.string_322;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_8);
    this.chatTField.tfChat.method_26(Class15.smethod_0(45));
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
      this.chatTField.tfChat.method_0();
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  public void method_165()
  {
    if ((this.chatTField == null ? 0 : 1) == 0)
    {
      this.chatTField = new GClass23();
      this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
      this.chatTField.method_0();
      this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
    }
    this.chatTField.strChat = GClass109.string_325;
    this.chatTField.tfChat.name = GClass109.string_326;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_8);
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
      this.chatTField.tfChat.method_0();
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  public void method_166()
  {
    this.chatTField.strChat = GClass109.string_280;
    this.chatTField.tfChat.name = GClass109.string_280;
    this.chatTField.to = string.Empty;
    this.chatTField.isShow = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
    this.chatTField.tfChat.method_28(GClass184.int_7);
    if ((!Main.bool_4 ? 1 : 0) == 0)
      this.chatTField.tfChat.strInfo = this.chatTField.strChat;
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    this.chatTField.method_5((GInterface1) this, string.Empty);
  }

  public void method_167()
  {
    if ((this.tabIcon == null ? 0 : 1) == 0)
      this.tabIcon = new GClass178();
    this.tabIcon.text = this.chatTField.tfChat.method_21();
    this.tabIcon.method_1(Class15.smethod_0(0) != 0);
    this.chatTField.isShow = Class15.smethod_0(0) != 0;
  }

  private void method_168(GClass72 gclass72_0)
  {
    string str1 = Class13.smethod_0(190187) + gclass72_0.charInfo.cName + Class13.smethod_0(190145);
    string str2 = ((!gclass72_0.isOnline ? 1 : 0) != 0 ? str1 + Class13.smethod_0(190730) + GClass109.string_242 : str1 + Class13.smethod_0(190750) + GClass109.string_241) + Class13.smethod_0(190844);
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = str2;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(190820);
    strArray[Class15.smethod_0(7)] = GClass109.string_254;
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(190806);
    strArray[Class15.smethod_0(2)] = gclass72_0.s;
    string chat = string.Concat(strArray);
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
    this.charInfo = gclass72_0.charInfo;
    this.currItem = (GClass80) null;
  }

  private void method_169()
  {
    if (this.selected < Class15.smethod_0(0) || (this.vEnemy.method_2() == 0 ? 1 : 0) != 0)
      return;
    GClass134 menuItems = new GClass134();
    this.int_76 = this.selected;
    menuItems.method_0((object) new GClass31(GClass109.string_139, (GInterface0) this, Class15.smethod_0(181), (object) (GClass72) this.vEnemy.method_3(this.int_76)));
    menuItems.method_0((object) new GClass31(GClass109.string_129, (GInterface0) this, Class15.smethod_0(528), (object) (GClass72) this.vEnemy.method_3(this.int_76)));
    menuItems.method_0((object) new GClass31(GClass109.string_440, (GInterface0) this, Class15.smethod_0(529), (object) (GClass72) this.vEnemy.method_3(this.int_76)));
    GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
    this.method_168((GClass72) this.vEnemy.method_3(this.selected));
  }

  private void method_170()
  {
    if (this.selected < Class15.smethod_0(0) || (this.vFriend.method_2() == 0 ? 1 : 0) != 0)
      return;
    GClass134 menuItems = new GClass134();
    this.int_76 = this.selected;
    menuItems.method_0((object) new GClass31(GClass109.string_138, (GInterface0) this, Class15.smethod_0(263), (object) (GClass72) this.vFriend.method_3(this.int_76)));
    menuItems.method_0((object) new GClass31(GClass109.string_129, (GInterface0) this, Class15.smethod_0(93), (object) (GClass72) this.vFriend.method_3(this.int_76)));
    menuItems.method_0((object) new GClass31(GClass109.string_440, (GInterface0) this, Class15.smethod_0(529), (object) (GClass72) this.vFriend.method_3(this.int_76)));
    GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
    this.method_168((GClass72) this.vFriend.method_3(this.selected));
  }

  private void method_171()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    GClass134 menuItems = new GClass134();
    this.int_76 = this.selected;
    menuItems.method_0((object) new GClass31(GClass109.string_176, (GInterface0) this, Class15.smethod_0(530), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_151, (GInterface0) this, Class15.smethod_0(531), (object) null));
    GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
  }

  private void method_172()
  {
    if ((this.selected == 0 ? 0 : 1) == 0)
    {
      this.isViewChatServer = (this.isViewChatServer ? 1 : 0) == Class15.smethod_0(0);
      GClass152.smethod_9(Class13.smethod_0(190897), (!this.isViewChatServer ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
      if ((!GClass62.bool_5 ? 1 : 0) != 0)
        return;
      this.selected = -1;
    }
    else
    {
      if (this.selected < Class15.smethod_0(0) || (this.logChat.method_2() == 0 ? 1 : 0) != 0)
        return;
      GClass134 menuItems = new GClass134();
      this.int_76 = this.selected - Class15.smethod_0(1);
      menuItems.method_0((object) new GClass31(GClass109.string_138, (GInterface0) this, Class15.smethod_0(263), (object) (GClass72) this.logChat.method_3(this.int_76)));
      menuItems.method_0((object) new GClass31(GClass109.string_243, (GInterface0) this, Class15.smethod_0(532), (object) (GClass72) this.logChat.method_3(this.int_76)));
      menuItems.method_0((object) new GClass31(GClass109.string_440, (GInterface0) this, Class15.smethod_0(529), (object) (GClass72) this.logChat.method_3(this.int_76)));
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_176((GClass72) this.logChat.method_3(this.selected - Class15.smethod_0(1)));
    }
  }

  private void method_173()
  {
    try
    {
      this.partID = (int[]) null;
      this.charInfo = (GClass20) null;
      GClass151.smethod_7(Class13.smethod_0(190934) + this.int_23.ToString());
      if (this.selected < Class15.smethod_0(0))
      {
        this.int_23 = -1;
      }
      else
      {
        if (GClass20.smethod_1().clan == null)
        {
          if (this.selected == 0)
          {
            if (this.int_23 == 0)
              this.method_161();
            else if (this.int_23 == Class15.smethod_0(1))
            {
              GClass71.smethod_1();
              this.method_163();
              GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(1), (sbyte) -1, (string) null);
            }
          }
          else if (this.selected != -1)
          {
            if (this.selected == Class15.smethod_0(1))
            {
              if (this.isSearchClan)
                GClass156.smethod_0().method_24(string.Empty);
              else if (this.isViewMember && this.currClan != null)
                GClass62.smethod_34(GClass109.string_281 + this.currClan.name, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(370), (object) this.currClan), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) this.currClan));
            }
            else if (this.isSearchClan)
            {
              this.currClan = this.method_105();
              if (this.currClan != null)
              {
                GClass134 menuItems = new GClass134();
                menuItems.method_0((object) new GClass31(GClass109.string_283, (GInterface0) this, Class15.smethod_0(370), (object) this.currClan));
                menuItems.method_0((object) new GClass31(GClass109.string_284, (GInterface0) this, Class15.smethod_0(533), (object) this.currClan));
                GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
                this.method_42(this.method_105());
              }
            }
            else if (this.isViewMember)
            {
              this.currMem = this.method_103();
              if (this.currMem != null)
              {
                GClass134 menuItems = new GClass134();
                menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currClan));
                GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
                GClass62.gclass95_0.method_1(menuItems, Class15.smethod_0(0), (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
                this.method_41(this.currMem);
              }
            }
          }
        }
        else if (this.selected == 0)
        {
          if (this.isMessage)
          {
            if (this.int_23 == 0)
            {
              if (this.myMember.method_2() > Class15.smethod_0(1))
              {
                this.method_162();
              }
              else
              {
                this.member = (GClass134) null;
                this.isSearchClan = Class15.smethod_0(0) != 0;
                this.isViewMember = Class15.smethod_0(1) != 0;
                this.isMessage = Class15.smethod_0(0) != 0;
                this.currentListLength = this.myMember.method_2() + Class15.smethod_0(7);
                this.method_72();
              }
            }
            if (this.int_23 == Class15.smethod_0(1))
              GClass156.smethod_0().method_20(Class15.smethod_0(1), (string) null, -1);
            if (this.int_23 == Class15.smethod_0(7))
            {
              this.member = (GClass134) null;
              this.isSearchClan = Class15.smethod_0(0) != 0;
              this.isViewMember = Class15.smethod_0(1) != 0;
              this.isMessage = Class15.smethod_0(0) != 0;
              this.currentListLength = this.myMember.method_2() + Class15.smethod_0(7);
              this.method_72();
              this.method_61();
            }
          }
          else if (this.isViewMember)
          {
            if (this.int_23 == 0)
            {
              this.isSearchClan = Class15.smethod_0(0) != 0;
              this.isViewMember = Class15.smethod_0(0) != 0;
              this.isMessage = Class15.smethod_0(1) != 0;
              this.currentListLength = GClass28.gclass134_0.method_2() + Class15.smethod_0(7);
              this.method_72();
            }
            if (this.int_23 == Class15.smethod_0(1))
            {
              if (this.myMember.method_2() > Class15.smethod_0(1))
                GClass156.smethod_0().method_27();
              else
                this.method_166();
            }
            if (this.int_23 == Class15.smethod_0(7))
            {
              if (this.myMember.method_2() > Class15.smethod_0(1))
                this.method_166();
              else
                GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(5), (sbyte) -1, (string) null);
            }
            if (this.int_23 == Class15.smethod_0(5))
              GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(5), (sbyte) -1, (string) null);
          }
        }
        else if (this.selected == Class15.smethod_0(1))
        {
          if (this.isSearchClan)
            GClass156.smethod_0().method_24(string.Empty);
        }
        else if (this.isSearchClan)
        {
          this.currClan = this.method_105();
          if (this.currClan != null)
          {
            GClass134 menuItems = new GClass134();
            menuItems.method_0((object) new GClass31(GClass109.string_284, (GInterface0) this, Class15.smethod_0(533), (object) this.currClan));
            GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
            this.method_42(this.method_105());
          }
        }
        else if (this.isViewMember)
        {
          GClass151.smethod_7(Class13.smethod_0(190499));
          this.currMem = this.method_103();
          if (this.currMem != null)
          {
            GClass134 menuItems = new GClass134();
            GClass151.smethod_7(Class13.smethod_0(190483));
            if (this.member != null)
            {
              menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) null));
              GClass151.smethod_7(Class13.smethod_0(190588));
            }
            else if (this.myMember != null)
            {
              GClass151.smethod_7(Class13.smethod_0(190573));
              GClass151.smethod_7(Class13.smethod_0(190559) + GClass20.smethod_1().role.ToString());
              if (GClass20.smethod_1().charID == this.currMem.ID || (int) GClass20.smethod_1().role == Class15.smethod_0(7))
                menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currMem));
              if ((int) GClass20.smethod_1().role < Class15.smethod_0(7) && GClass20.smethod_1().charID != this.currMem.ID)
              {
                GClass151.smethod_7(Class13.smethod_0(190653));
                if (this.currMem.role == (sbyte) 0 || (int) this.currMem.role == Class15.smethod_0(1))
                  menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currMem));
                if ((int) this.currMem.role == Class15.smethod_0(7))
                  menuItems.method_0((object) new GClass31(GClass109.string_285, (GInterface0) this, Class15.smethod_0(285), (object) this.currMem));
                if (GClass20.smethod_1().role == (sbyte) 0)
                {
                  menuItems.method_0((object) new GClass31(GClass109.string_286, (GInterface0) this, Class15.smethod_0(296), (object) this.currMem));
                  if ((int) this.currMem.role == Class15.smethod_0(1))
                    menuItems.method_0((object) new GClass31(GClass109.string_287, (GInterface0) this, Class15.smethod_0(295), (object) this.currMem));
                }
              }
              if ((int) GClass20.smethod_1().role < (int) this.currMem.role)
                menuItems.method_0((object) new GClass31(GClass109.string_288, (GInterface0) this, Class15.smethod_0(534), (object) this.currMem));
            }
            GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
            this.method_41(this.currMem);
          }
        }
        else if (this.isMessage)
        {
          this.currMess = this.method_104();
          if (this.currMess != null)
          {
            if (this.currMess.type == 0)
            {
              GClass134 menuItems = new GClass134();
              menuItems.method_0((object) new GClass31(GClass109.string_125, (GInterface0) this, Class15.smethod_0(260), (object) this.currMess));
              GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
              this.method_39(this.currMess);
            }
            else if (this.currMess.type == Class15.smethod_0(1))
            {
              if (this.currMess.playerId != GClass20.smethod_1().charID && this.int_23 != -1)
                GClass156.smethod_0().method_19(this.currMess.id);
            }
            else if (this.currMess.type == Class15.smethod_0(7) && this.currMess.option != null)
            {
              if (this.int_23 == 0)
                GClass156.smethod_0().method_22(this.currMess.id, (sbyte) Class15.smethod_0(1));
              else if (this.int_23 == Class15.smethod_0(1))
                GClass156.smethod_0().method_22(this.currMess.id, (sbyte) Class15.smethod_0(0));
            }
          }
        }
        if (!GClass62.bool_5)
          return;
        this.int_23 = -1;
        this.selected = -1;
      }
    }
    catch (Exception ex)
    {
      throw;
    }
  }

  private void method_174()
  {
    try
    {
      if ((this.currentTabIndex == 0 ? 0 : 1) == 0)
        this.method_8();
      if (this.currentTabIndex == Class15.smethod_0(1))
        this.method_155();
      if (this.currentTabIndex == Class15.smethod_0(7))
        this.method_175();
      if (this.currentTabIndex == Class15.smethod_0(5))
      {
        if (this.mainTabName.Length == Class15.smethod_0(2))
          this.method_157();
        else
          this.method_173();
      }
      if (this.currentTabIndex != Class15.smethod_0(2))
        return;
      this.method_157();
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(191397) + ex.StackTrace);
    }
  }

  private void method_175()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    if (this.selected != 0 && this.selected != Class15.smethod_0(1) && this.selected != Class15.smethod_0(7) && this.selected != Class15.smethod_0(5) && this.selected != Class15.smethod_0(2) && this.selected != Class15.smethod_0(3))
    {
      int index = this.selected - Class15.smethod_0(37);
      GClass167 skillTemplate = GClass20.smethod_1().nClass.skillTemplates[index];
      GClass161 skill = GClass20.smethod_1().method_12(skillTemplate);
      GClass161 gclass161 = (GClass161) null;
      GClass134 menuItems = new GClass134(string.Empty);
      if (skill != null)
      {
        if (skill.point == skillTemplate.maxPoint)
        {
          menuItems.method_0((object) new GClass31(GClass109.string_226, (GInterface0) this, Class15.smethod_0(539), (object) skill.template));
          menuItems.method_0((object) new GClass31(GClass109.string_125, Class15.smethod_0(7)));
        }
        else
        {
          gclass161 = skillTemplate.skills[skill.point];
          menuItems.method_0((object) new GClass31(GClass109.string_224, (GInterface0) this, Class15.smethod_0(540), (object) gclass161));
          menuItems.method_0((object) new GClass31(GClass109.string_226, (GInterface0) this, Class15.smethod_0(539), (object) skill.template));
        }
      }
      else
      {
        gclass161 = skillTemplate.skills[Class15.smethod_0(0)];
        menuItems.method_0((object) new GClass31(GClass109.string_384, (GInterface0) this, Class15.smethod_0(541), (object) gclass161));
      }
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_43(skillTemplate, skill, gclass161);
    }
    else
    {
      long cTiemNang = GClass20.smethod_1().cTiemNang;
      int cHpGoc = GClass20.smethod_1().cHPGoc;
      int cMpGoc = GClass20.smethod_1().cMPGoc;
      int cDamGoc = GClass20.smethod_1().cDamGoc;
      int cDefGoc = GClass20.smethod_1().cDefGoc;
      int cCriticalGoc = GClass20.smethod_1().cCriticalGoc;
      int num1 = Class15.smethod_0(15);
      if (this.selected == 0)
      {
        if (cTiemNang < (long) (GClass20.smethod_1().cHPGoc + num1))
        {
          GClass62.smethod_28(GClass109.string_357 + GClass20.smethod_1().cTiemNang.ToString() + GClass109.string_358 + (GClass20.smethod_1().cHPGoc + num1).ToString());
          return;
        }
        if (cTiemNang > (long) cHpGoc && cTiemNang < (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)))
        {
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = GClass109.string_359;
          strArray[Class15.smethod_0(1)] = (cHpGoc + num1).ToString();
          strArray[Class15.smethod_0(7)] = GClass109.string_360;
          strArray[Class15.smethod_0(5)] = GClass20.smethod_1().hpFrom1000TiemNang.ToString();
          strArray[Class15.smethod_0(2)] = GClass109.string_361;
          GClass62.smethod_34(string.Concat(strArray), new GClass31(GClass109.string_356, (GInterface0) this, Class15.smethod_0(331), (object) null), new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(535), (object) null));
          return;
        }
        if (cTiemNang >= (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)) && cTiemNang < (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_1 = menuItems;
          string[] strArray1 = new string[Class15.smethod_0(37)];
          strArray1[Class15.smethod_0(0)] = GClass109.string_356;
          strArray1[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray1[Class15.smethod_0(7)] = GClass20.smethod_1().hpFrom1000TiemNang.ToString();
          strArray1[Class15.smethod_0(5)] = GClass109.string_369;
          strArray1[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray1[Class15.smethod_0(3)] = GClass151.smethod_29((long) (cHpGoc + num1));
          GClass31 o1 = new GClass31(string.Concat(strArray1), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_1.method_0((object) o1);
          GClass134 gclass134_2 = menuItems;
          string[] strArray2 = new string[Class15.smethod_0(37)];
          strArray2[Class15.smethod_0(0)] = GClass109.string_356;
          strArray2[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray2[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().hpFrom1000TiemNang).ToString();
          strArray2[Class15.smethod_0(5)] = GClass109.string_369;
          strArray2[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray2[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)));
          GClass31 o2 = new GClass31(string.Concat(strArray2), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_2.method_0((object) o2);
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
        if (cTiemNang >= (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_3 = menuItems;
          string[] strArray3 = new string[Class15.smethod_0(37)];
          strArray3[Class15.smethod_0(0)] = GClass109.string_356;
          strArray3[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray3[Class15.smethod_0(7)] = GClass20.smethod_1().hpFrom1000TiemNang.ToString();
          strArray3[Class15.smethod_0(5)] = GClass109.string_369;
          strArray3[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray3[Class15.smethod_0(3)] = GClass151.smethod_29((long) (cHpGoc + num1));
          GClass31 o3 = new GClass31(string.Concat(strArray3), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_3.method_0((object) o3);
          GClass134 gclass134_4 = menuItems;
          string[] strArray4 = new string[Class15.smethod_0(37)];
          strArray4[Class15.smethod_0(0)] = GClass109.string_356;
          strArray4[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray4[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().hpFrom1000TiemNang).ToString();
          strArray4[Class15.smethod_0(5)] = GClass109.string_369;
          strArray4[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray4[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)));
          GClass31 o4 = new GClass31(string.Concat(strArray4), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_4.method_0((object) o4);
          GClass134 gclass134_5 = menuItems;
          string[] strArray5 = new string[Class15.smethod_0(37)];
          strArray5[Class15.smethod_0(0)] = GClass109.string_356;
          strArray5[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray5[Class15.smethod_0(7)] = (Class15.smethod_0(21) * (int) GClass20.smethod_1().hpFrom1000TiemNang).ToString();
          strArray5[Class15.smethod_0(5)] = GClass109.string_369;
          strArray5[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray5[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)));
          GClass31 o5 = new GClass31(string.Concat(strArray5), (GInterface0) this, Class15.smethod_0(537), (object) null);
          gclass134_5.method_0((object) o5);
          menuItems.method_0((object) new GClass31(Class13.smethod_0(185239), (GInterface0) GClass12.gclass12_0, Class15.smethod_0(47), (object) this.selected));
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
      }
      if (this.selected == Class15.smethod_0(1))
      {
        if (GClass20.smethod_1().cTiemNang < (long) (GClass20.smethod_1().cMPGoc + num1))
        {
          GClass62.smethod_28(GClass109.string_357 + GClass20.smethod_1().cTiemNang.ToString() + GClass109.string_358 + (GClass20.smethod_1().cMPGoc + num1).ToString());
          return;
        }
        if (cTiemNang > (long) cMpGoc && cTiemNang < (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)))
        {
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = GClass109.string_359;
          strArray[Class15.smethod_0(1)] = (cMpGoc + num1).ToString();
          strArray[Class15.smethod_0(7)] = GClass109.string_360;
          strArray[Class15.smethod_0(5)] = GClass20.smethod_1().mpFrom1000TiemNang.ToString();
          strArray[Class15.smethod_0(2)] = GClass109.string_362;
          GClass62.smethod_34(string.Concat(strArray), new GClass31(GClass109.string_356, (GInterface0) this, Class15.smethod_0(331), (object) null), new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(535), (object) null));
          return;
        }
        if (cTiemNang >= (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)) && cTiemNang < (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_6 = menuItems;
          string[] strArray6 = new string[Class15.smethod_0(37)];
          strArray6[Class15.smethod_0(0)] = GClass109.string_356;
          strArray6[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray6[Class15.smethod_0(7)] = GClass20.smethod_1().mpFrom1000TiemNang.ToString();
          strArray6[Class15.smethod_0(5)] = GClass109.string_370;
          strArray6[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray6[Class15.smethod_0(3)] = GClass151.smethod_29((long) (cHpGoc + num1));
          GClass31 o6 = new GClass31(string.Concat(strArray6), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_6.method_0((object) o6);
          GClass134 gclass134_7 = menuItems;
          string[] strArray7 = new string[Class15.smethod_0(37)];
          strArray7[Class15.smethod_0(0)] = GClass109.string_356;
          strArray7[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray7[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().mpFrom1000TiemNang).ToString();
          strArray7[Class15.smethod_0(5)] = GClass109.string_370;
          strArray7[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray7[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cHpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)));
          GClass31 o7 = new GClass31(string.Concat(strArray7), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_7.method_0((object) o7);
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
        if (cTiemNang >= (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_8 = menuItems;
          string[] strArray8 = new string[Class15.smethod_0(37)];
          strArray8[Class15.smethod_0(0)] = GClass109.string_356;
          strArray8[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray8[Class15.smethod_0(7)] = GClass20.smethod_1().mpFrom1000TiemNang.ToString();
          strArray8[Class15.smethod_0(5)] = GClass109.string_370;
          strArray8[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray8[Class15.smethod_0(3)] = GClass151.smethod_29((long) (cMpGoc + num1));
          GClass31 o8 = new GClass31(string.Concat(strArray8), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_8.method_0((object) o8);
          GClass134 gclass134_9 = menuItems;
          string[] strArray9 = new string[Class15.smethod_0(37)];
          strArray9[Class15.smethod_0(0)] = GClass109.string_356;
          strArray9[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray9[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().mpFrom1000TiemNang).ToString();
          strArray9[Class15.smethod_0(5)] = GClass109.string_370;
          strArray9[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray9[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(96)) / Class15.smethod_0(7)));
          GClass31 o9 = new GClass31(string.Concat(strArray9), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_9.method_0((object) o9);
          GClass134 gclass134_10 = menuItems;
          string[] strArray10 = new string[Class15.smethod_0(37)];
          strArray10[Class15.smethod_0(0)] = GClass109.string_356;
          strArray10[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray10[Class15.smethod_0(7)] = (Class15.smethod_0(21) * (int) GClass20.smethod_1().mpFrom1000TiemNang).ToString();
          strArray10[Class15.smethod_0(5)] = GClass109.string_370;
          strArray10[Class15.smethod_0(2)] = Class13.smethod_0(185271);
          strArray10[Class15.smethod_0(3)] = GClass151.smethod_29((long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * (cMpGoc + num1) + Class15.smethod_0(97)) / Class15.smethod_0(7)));
          GClass31 o10 = new GClass31(string.Concat(strArray10), (GInterface0) this, Class15.smethod_0(537), (object) null);
          gclass134_10.method_0((object) o10);
          menuItems.method_0((object) new GClass31(Class13.smethod_0(185239), (GInterface0) GClass12.gclass12_0, Class15.smethod_0(47), (object) this.selected));
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
      }
      if (this.selected == Class15.smethod_0(7))
      {
        if (GClass20.smethod_1().cTiemNang < (long) (GClass20.smethod_1().cDamGoc * (int) GClass20.smethod_1().expForOneAdd))
        {
          GClass62.smethod_28(GClass109.string_357 + GClass20.smethod_1().cTiemNang.ToString() + GClass109.string_358 + (cDamGoc * Class15.smethod_0(21)).ToString());
          return;
        }
        if (cTiemNang > (long) cDamGoc && cTiemNang < (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(45)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd))
        {
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = GClass109.string_359;
          strArray[Class15.smethod_0(1)] = (cDamGoc * Class15.smethod_0(21)).ToString();
          strArray[Class15.smethod_0(7)] = GClass109.string_360;
          strArray[Class15.smethod_0(5)] = GClass20.smethod_1().damFrom1000TiemNang.ToString();
          strArray[Class15.smethod_0(2)] = GClass109.string_363;
          GClass62.smethod_34(string.Concat(strArray), new GClass31(GClass109.string_356, (GInterface0) this, Class15.smethod_0(331), (object) null), new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(535), (object) null));
          return;
        }
        if (cTiemNang >= (long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(45)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd) && cTiemNang < (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(87)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_11 = menuItems;
          string[] strArray11 = new string[Class15.smethod_0(38)];
          strArray11[Class15.smethod_0(0)] = GClass109.string_356;
          strArray11[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray11[Class15.smethod_0(7)] = GClass20.smethod_1().damFrom1000TiemNang.ToString();
          strArray11[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray11[Class15.smethod_0(2)] = GClass109.string_371;
          strArray11[Class15.smethod_0(3)] = Class13.smethod_0(185271);
          strArray11[Class15.smethod_0(37)] = GClass151.smethod_29((long) (cDamGoc * Class15.smethod_0(21)));
          GClass31 o11 = new GClass31(string.Concat(strArray11), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_11.method_0((object) o11);
          GClass134 gclass134_12 = menuItems;
          string[] strArray12 = new string[Class15.smethod_0(38)];
          strArray12[Class15.smethod_0(0)] = GClass109.string_356;
          strArray12[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray12[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().damFrom1000TiemNang).ToString();
          strArray12[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray12[Class15.smethod_0(2)] = GClass109.string_371;
          strArray12[Class15.smethod_0(3)] = Class13.smethod_0(185271);
          strArray12[Class15.smethod_0(37)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(45)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd));
          GClass31 o12 = new GClass31(string.Concat(strArray12), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_12.method_0((object) o12);
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
        if (cTiemNang >= (long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(87)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd))
        {
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_13 = menuItems;
          string[] strArray13 = new string[Class15.smethod_0(38)];
          strArray13[Class15.smethod_0(0)] = GClass109.string_356;
          strArray13[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray13[Class15.smethod_0(7)] = GClass20.smethod_1().damFrom1000TiemNang.ToString();
          strArray13[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray13[Class15.smethod_0(2)] = GClass109.string_371;
          strArray13[Class15.smethod_0(3)] = Class13.smethod_0(185271);
          strArray13[Class15.smethod_0(37)] = GClass151.smethod_29((long) (cDamGoc * Class15.smethod_0(21)));
          GClass31 o13 = new GClass31(string.Concat(strArray13), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_13.method_0((object) o13);
          GClass134 gclass134_14 = menuItems;
          string[] strArray14 = new string[Class15.smethod_0(38)];
          strArray14[Class15.smethod_0(0)] = GClass109.string_356;
          strArray14[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray14[Class15.smethod_0(7)] = (Class15.smethod_0(31) * (int) GClass20.smethod_1().damFrom1000TiemNang).ToString();
          strArray14[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray14[Class15.smethod_0(2)] = GClass109.string_371;
          strArray14[Class15.smethod_0(3)] = Class13.smethod_0(185271);
          strArray14[Class15.smethod_0(37)] = GClass151.smethod_29((long) (Class15.smethod_0(31) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(45)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd));
          GClass31 o14 = new GClass31(string.Concat(strArray14), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_14.method_0((object) o14);
          GClass134 gclass134_15 = menuItems;
          string[] strArray15 = new string[Class15.smethod_0(38)];
          strArray15[Class15.smethod_0(0)] = GClass109.string_356;
          strArray15[Class15.smethod_0(1)] = Class13.smethod_0(191861);
          strArray15[Class15.smethod_0(7)] = (Class15.smethod_0(21) * (int) GClass20.smethod_1().damFrom1000TiemNang).ToString();
          strArray15[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray15[Class15.smethod_0(2)] = GClass109.string_371;
          strArray15[Class15.smethod_0(3)] = Class13.smethod_0(185271);
          strArray15[Class15.smethod_0(37)] = GClass151.smethod_29((long) (Class15.smethod_0(21) * (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(87)) / Class15.smethod_0(7) * (int) GClass20.smethod_1().expForOneAdd));
          GClass31 o15 = new GClass31(string.Concat(strArray15), (GInterface0) this, Class15.smethod_0(537), (object) null);
          gclass134_15.method_0((object) o15);
          menuItems.method_0((object) new GClass31(Class13.smethod_0(185239), (GInterface0) GClass12.gclass12_0, Class15.smethod_0(47), (object) this.selected));
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
      }
      if (this.selected == Class15.smethod_0(5))
      {
        if (GClass20.smethod_1().cTiemNang < (long) (Class15.smethod_0(214) + GClass20.smethod_1().cDefGoc * Class15.smethod_0(15)))
        {
          GClass62.smethod_28(GClass109.string_357 + GClass138.smethod_9(GClass20.smethod_1().cTiemNang) + GClass109.string_358 + GClass138.smethod_9((long) (Class15.smethod_0(214) + GClass20.smethod_1().cDefGoc * Class15.smethod_0(15))));
        }
        else
        {
          long number1 = (long) (Class15.smethod_0(7) * (cDefGoc + Class15.smethod_0(3))) / (long) Class15.smethod_0(7) * (long) Class15.smethod_0(17);
          long number2 = (long) Class15.smethod_0(31) * (long) (Class15.smethod_0(7) * (cDefGoc + Class15.smethod_0(3)) + Class15.smethod_0(45)) / (long) Class15.smethod_0(7) * (long) Class15.smethod_0(17);
          long number3 = (long) Class15.smethod_0(21) * (long) (Class15.smethod_0(7) * (cDefGoc + Class15.smethod_0(3)) + Class15.smethod_0(87)) / (long) Class15.smethod_0(7) * (long) Class15.smethod_0(17);
          GClass109.string_359 = GClass109.string_356;
          GClass134 menuItems = new GClass134(string.Empty);
          GClass134 gclass134_16 = menuItems;
          string[] strArray16 = new string[Class15.smethod_0(3)];
          strArray16[Class15.smethod_0(0)] = GClass109.string_359;
          strArray16[Class15.smethod_0(1)] = Class13.smethod_0(184997);
          strArray16[Class15.smethod_0(7)] = GClass109.string_372;
          strArray16[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray16[Class15.smethod_0(2)] = GClass151.smethod_29(number1);
          GClass31 o16 = new GClass31(string.Concat(strArray16), (GInterface0) this, Class15.smethod_0(331), (object) null);
          gclass134_16.method_0((object) o16);
          GClass134 gclass134_17 = menuItems;
          string[] strArray17 = new string[Class15.smethod_0(3)];
          strArray17[Class15.smethod_0(0)] = GClass109.string_359;
          strArray17[Class15.smethod_0(1)] = Class13.smethod_0(184970);
          strArray17[Class15.smethod_0(7)] = GClass109.string_372;
          strArray17[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray17[Class15.smethod_0(2)] = GClass151.smethod_29(number2);
          GClass31 o17 = new GClass31(string.Concat(strArray17), (GInterface0) this, Class15.smethod_0(536), (object) null);
          gclass134_17.method_0((object) o17);
          GClass134 gclass134_18 = menuItems;
          string[] strArray18 = new string[Class15.smethod_0(3)];
          strArray18[Class15.smethod_0(0)] = GClass109.string_359;
          strArray18[Class15.smethod_0(1)] = Class13.smethod_0(185068);
          strArray18[Class15.smethod_0(7)] = GClass109.string_372;
          strArray18[Class15.smethod_0(5)] = Class13.smethod_0(191861);
          strArray18[Class15.smethod_0(2)] = GClass151.smethod_29(number3);
          GClass31 o18 = new GClass31(string.Concat(strArray18), (GInterface0) this, Class15.smethod_0(537), (object) null);
          gclass134_18.method_0((object) o18);
          menuItems.method_0((object) new GClass31(Class13.smethod_0(185239), (GInterface0) GClass12.gclass12_0, Class15.smethod_0(47), (object) this.selected));
          GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
          this.method_177(this.selected);
        }
      }
      else if (this.selected == Class15.smethod_0(2))
      {
        long num2 = (long) Class15.smethod_0(538);
        int index = GClass20.smethod_1().cCriticalGoc;
        if (index > GClass141.long_0.Length - Class15.smethod_0(1))
          index = GClass141.long_0.Length - Class15.smethod_0(1);
        long number = GClass141.long_0[index];
        if (GClass20.smethod_1().cTiemNang < number)
        {
          GClass62.smethod_28(GClass109.string_357 + GClass151.smethod_29(GClass20.smethod_1().cTiemNang) + GClass109.string_358 + GClass151.smethod_29(number));
        }
        else
        {
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = GClass109.string_359;
          strArray[Class15.smethod_0(1)] = GClass151.smethod_28(number);
          strArray[Class15.smethod_0(7)] = GClass109.string_360;
          strArray[Class15.smethod_0(5)] = GClass20.smethod_1().criticalFrom1000Tiemnang.ToString();
          strArray[Class15.smethod_0(2)] = GClass109.string_365;
          GClass62.smethod_34(string.Concat(strArray), new GClass31(GClass109.string_356, (GInterface0) this, Class15.smethod_0(331), (object) null), new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(535), (object) null));
        }
      }
      else
      {
        if (this.selected != Class15.smethod_0(3))
          return;
        GClass156.smethod_0().method_9((sbyte) Class15.smethod_0(0));
      }
    }
  }

  private void method_176(GClass72 gclass72_0)
  {
    string chat = Class13.smethod_0(185865) + gclass72_0.charInfo.cName + Class13.smethod_0(185922) + Class13.smethod_0(180723) + Class13.smethod_0(180703) + GClass151.smethod_27(gclass72_0.s, Class13.smethod_0(180224), Class15.smethod_0(0))[Class15.smethod_0(7)];
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
    this.charInfo = gclass72_0.charInfo;
    this.currItem = (GClass80) null;
  }

  private void method_177(int int_105)
  {
    string empty = string.Empty;
    int num = Class15.smethod_0(0);
    if ((this.selected == 0 ? 0 : 1) == 0)
      num = GClass20.smethod_1().cHPGoc + Class15.smethod_0(15);
    if (this.selected == Class15.smethod_0(1))
      num = GClass20.smethod_1().cMPGoc + Class15.smethod_0(15);
    if (this.selected == Class15.smethod_0(7))
      num = GClass20.smethod_1().cDamGoc * (int) GClass20.smethod_1().expForOneAdd;
    if (this.selected == Class15.smethod_0(5))
      num = Class15.smethod_0(499) + GClass20.smethod_1().cDefGoc * Class15.smethod_0(17);
    string str = empty;
    string[] strArray = new string[Class15.smethod_0(38)];
    strArray[Class15.smethod_0(0)] = str;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(180350);
    strArray[Class15.smethod_0(7)] = GClass109.string_133;
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(180476);
    strArray[Class15.smethod_0(2)] = num.ToString();
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(180476);
    strArray[Class15.smethod_0(37)] = GClass109.string_381;
    string chat = string.Concat(strArray);
    if ((int_105 == 0 ? 0 : 1) == 0)
      chat = chat + Class13.smethod_0(180474) + GClass109.string_385;
    if (int_105 == Class15.smethod_0(1))
      chat = chat + Class13.smethod_0(180474) + GClass109.string_386;
    if (int_105 == Class15.smethod_0(7))
      chat = chat + Class13.smethod_0(180474) + GClass109.string_387;
    if (int_105 == Class15.smethod_0(5))
      chat = chat + Class13.smethod_0(180474) + GClass109.string_387;
    this.currItem = (GClass80) null;
    this.partID = (int[]) null;
    this.charInfo = (GClass20) null;
    this.idIcon = -1;
    this.cp = new GClass43();
    this.method_37(this.cp, chat);
  }

  private void method_178()
  {
  }

  private void method_179()
  {
    if ((GClass141.gclass66_2 == null ? 1 : 0) == 0)
    {
      GClass141.gclass66_2.texture = (Texture2D) null;
      GClass141.gclass66_2 = (GClass66) null;
    }
    GClass185.sbyte_3 = (sbyte) -1;
    GClass126.smethod_26();
    GClass169.smethod_0();
    this.method_34();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  private void method_180()
  {
    if (this.selected == -1)
      return;
    GClass151.smethod_7(Class13.smethod_0(181125));
    this.bool_12 = Class15.smethod_0(1) != 0;
    GClass62.gclass141_0.method_141();
  }

  public void method_181(int recieve, int maxCap)
  {
    string[] says = this.cp.says;
    int index = this.cp.says.Length - Class15.smethod_0(1);
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = GClass109.string_253;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(181232);
    strArray[Class15.smethod_0(7)] = recieve.ToString();
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(181221);
    strArray[Class15.smethod_0(2)] = maxCap.ToString();
    string str = string.Concat(strArray);
    says[index] = str;
  }

  private void method_182()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    this.currItem = (GClass80) null;
    GClass134 menuItems = new GClass134();
    if ((this.currentTabIndex == 0 ? 0 : 1) == 0 && (!this.Equals((object) GClass62.gclass141_1) ? 0 : 1) == 0)
    {
      GClass80 p = GClass20.smethod_1().arrItemBox[this.selected];
      if ((p == null ? 1 : 0) == 0)
      {
        if ((!p.method_7() ? 1 : 0) == 0)
        {
          if ((GClass20.smethod_1().arrItemBody[p.itemOption[Class15.smethod_0(0)].optionTemplate.type] == null ? 1 : 0) == 0)
            menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(15), (object) p));
          else
            menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(15), (object) p));
        }
        else if ((!this.isBoxClan ? 1 : 0) == 0)
        {
          menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(15), (object) p));
          menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(542), (object) p));
        }
        else
        {
          menuItems.method_0((object) new GClass31(GClass109.string_309, (GInterface0) this, Class15.smethod_0(15), (object) p));
          menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(542), (object) p));
        }
        this.currItem = p;
      }
    }
    if (this.currentTabIndex == Class15.smethod_0(1) || (!this.Equals((object) GClass62.gclass141_1) ? 1 : 0) == 0)
    {
      GClass80[] arrItemBody = GClass20.smethod_1().arrItemBody;
      if (this.selected >= arrItemBody.Length)
      {
        sbyte index = (sbyte) (this.selected - arrItemBody.Length);
        GClass80 p = GClass20.smethod_1().arrItemBag[(int) index];
        if ((p == null ? 1 : 0) == 0)
        {
          menuItems.method_0((object) new GClass31(GClass109.string_228, (GInterface0) this, Class15.smethod_0(94), (object) p));
          if ((!p.method_7() ? 1 : 0) == 0)
            menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(20), (object) p));
          else
            menuItems.method_0((object) new GClass31(GClass109.string_133, (GInterface0) this, Class15.smethod_0(406), (object) p));
          this.currItem = p;
        }
      }
      else
      {
        GClass80 p = GClass20.smethod_1().arrItemBody[this.selected];
        if ((p == null ? 1 : 0) == 0)
        {
          menuItems.method_0((object) new GClass31(GClass109.string_229, (GInterface0) this, Class15.smethod_0(543), (object) p));
          this.currItem = p;
        }
      }
    }
    if ((this.currItem == null ? 1 : 0) == 0)
    {
      GClass20.smethod_1().method_133(this.currItem.headTemp, this.currItem.bodyTemp, this.currItem.legTemp, this.currItem.bagTemp);
      if ((!this.isBoxClan ? 1 : 0) == 0)
        menuItems.method_0((object) new GClass31(GClass109.string_310, (GInterface0) this, Class15.smethod_0(544), (object) this.currItem));
      GClass62.gclass95_0.method_1(menuItems, this.X, (this.selected + Class15.smethod_0(1)) * this.ITEM_HEIGHT - this.cmy + this.yScroll);
      this.method_36(this.currItem);
    }
    else
      this.cp = (GClass43) null;
  }

  public void method_183(sbyte itemAction, string info, sbyte where, sbyte index)
  {
    GClass62.smethod_27();
    GClass62.smethod_34(info, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(364), (object) new GClass82()
    {
      type = (int) itemAction,
      id = (int) index,
      where = (int) where
    }), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) null));
  }

  public void method_184(sbyte type, string info, short id) => GClass62.smethod_34(info, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(545), (object) new GClass82()
  {
    type = (int) type,
    id = (int) id
  }), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) null));

  public void imethod_0(int idAction, object p)
  {
    if (idAction == Class15.smethod_0(79))
    {
      GClass187 gclass187 = (GClass187) p;
      GClass156.smethod_0().method_141(gclass187.pId);
    }
    if (idAction == Class15.smethod_0(546))
    {
      GClass152.smethod_13();
      if (GClass98.int_8 > Class15.smethod_0(1))
        GClass152.smethod_9(Class13.smethod_0(180779), Class15.smethod_0(1));
      else
        GClass152.smethod_9(Class13.smethod_0(180779), Class15.smethod_0(0));
      GClass63.gclass63_0.method_1();
    }
    if (idAction == Class15.smethod_0(512))
    {
      GClass80 o = (GClass80) p;
      o.isSelect = Class15.smethod_0(0) != 0;
      GClass62.gclass141_0.vItemCombine.method_8((object) o);
      if (GClass62.gclass141_0.currentTabIndex == 0)
        GClass62.gclass141_0.method_30();
    }
    if (idAction == Class15.smethod_0(116))
    {
      GClass80 o = (GClass80) p;
      for (int index = Class15.smethod_0(0); index < GClass62.gclass141_0.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        if ((int) ((GClass80) GClass62.gclass141_0.vItemCombine.method_3(index)).template.id == (int) o.template.id)
        {
          GClass62.smethod_28(GClass109.string_328);
          return;
        }
      }
      o.isSelect = Class15.smethod_0(1) != 0;
      GClass62.gclass141_0.vItemCombine.method_0((object) o);
      if (GClass62.gclass141_0.currentTabIndex == 0)
        GClass62.gclass141_0.method_30();
    }
    if (idAction == Class15.smethod_0(527))
    {
      if (this.isLock)
      {
        GClass62.smethod_28(GClass109.string_329);
        return;
      }
      GClass80 gclass80 = (GClass80) p;
      for (int index = Class15.smethod_0(0); index < GClass62.gclass141_0.vMyGD.method_2(); index += Class15.smethod_0(1))
      {
        if (((GClass80) GClass62.gclass141_0.vMyGD.method_3(index)).indexUI == gclass80.indexUI)
        {
          GClass62.smethod_28(GClass109.string_328);
          return;
        }
      }
      if (gclass80.quantity > Class15.smethod_0(1))
      {
        this.method_165();
        return;
      }
      gclass80.isSelect = Class15.smethod_0(1) != 0;
      GClass80 o = new GClass80();
      o.template = gclass80.template;
      o.itemOption = gclass80.itemOption;
      o.indexUI = gclass80.indexUI;
      GClass62.gclass141_0.vMyGD.method_0((object) o);
      GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(7), -1, (sbyte) o.indexUI, o.quantity);
    }
    if (idAction == Class15.smethod_0(547))
    {
      GClass80 o = (GClass80) p;
      o.isSelect = Class15.smethod_0(0) != 0;
      GClass62.gclass141_0.vMyGD.method_8((object) o);
      if (GClass62.gclass141_0.currentTabIndex == Class15.smethod_0(1))
        GClass62.gclass141_0.method_55(Class15.smethod_0(1) != 0);
      GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(2), -1, (sbyte) o.indexUI, -1);
    }
    if (idAction == Class15.smethod_0(510))
    {
      this.isAccept = Class15.smethod_0(1) != 0;
      GClass62.smethod_27();
      GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(38), -1, (sbyte) -1, -1);
      this.method_141();
    }
    if (idAction == Class15.smethod_0(532))
    {
      GClass72 gclass72 = (GClass72) p;
      GClass156.smethod_0().method_14((sbyte) Class15.smethod_0(1), gclass72.charInfo.charID);
      Class15.smethod_0(88);
    }
    if (idAction == Class15.smethod_0(93))
    {
      GClass72 gclass72 = (GClass72) p;
      GClass156.smethod_0().method_14((sbyte) Class15.smethod_0(7), gclass72.charInfo.charID);
    }
    if (idAction == Class15.smethod_0(529))
    {
      GClass72 gclass72 = (GClass72) p;
      GClass156.smethod_0().method_1(gclass72.charInfo.charID);
    }
    if (idAction == Class15.smethod_0(263))
    {
      GClass151.smethod_7(Class13.smethod_0(180749));
      GClass72 gclass72 = (GClass72) p;
      if (this.chatTField == null)
      {
        this.chatTField = new GClass23();
        this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
        this.chatTField.method_0();
        this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
      }
      this.chatTField.strChat = GClass109.string_244;
      this.chatTField.tfChat.name = GClass109.string_245 + Class13.smethod_0(182285) + gclass72.charInfo.cName;
      this.chatTField.to = string.Empty;
      this.chatTField.isShow = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.method_28(GClass184.int_7);
      if (Main.bool_4)
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
      if (!Main.bool_3)
        this.chatTField.method_5((GInterface1) this, string.Empty);
    }
    if (idAction == Class15.smethod_0(15))
      GClass156.smethod_0().method_31(GClass141.sbyte_0, (sbyte) this.selected);
    if (idAction == Class15.smethod_0(94))
    {
      sbyte id = (sbyte) (this.selected - GClass20.smethod_1().arrItemBody.Length);
      GClass156.smethod_0().method_31(GClass141.sbyte_1, id);
    }
    if (idAction == Class15.smethod_0(410))
      this.method_141();
    if (idAction == Class15.smethod_0(543))
      GClass156.smethod_0().method_31(GClass141.sbyte_3, (sbyte) this.selected);
    if (idAction == Class15.smethod_0(544))
      GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(1), (sbyte) Class15.smethod_0(7), (sbyte) this.selected, (short) -1);
    if (idAction == Class15.smethod_0(542))
    {
      GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(7), (sbyte) this.selected, (short) -1);
      GClass80 gclass80 = (GClass80) p;
      if (gclass80 != null && ((int) gclass80.template.id == Class15.smethod_0(42) || (int) gclass80.template.id == Class15.smethod_0(41)))
        GClass62.gclass141_0.method_141();
    }
    if (idAction == Class15.smethod_0(20))
    {
      sbyte id = (sbyte) (this.selected - GClass20.smethod_1().arrItemBody.Length);
      GClass156.smethod_0().method_31(GClass141.sbyte_4, id);
    }
    if (idAction == Class15.smethod_0(406))
    {
      GClass151.smethod_7(Class13.smethod_0(182379));
      GClass80 gclass80 = (GClass80) p;
      bool flag = this.selected < GClass20.smethod_1().arrItemBody.Length;
      sbyte num = (sbyte) Class15.smethod_0(0);
      if (!flag)
        num = (sbyte) (this.selected - GClass20.smethod_1().arrItemBody.Length);
      GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), !flag ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0), !flag ? num : (sbyte) this.selected, (short) -1);
      if ((int) gclass80.template.id == Class15.smethod_0(42) || (int) gclass80.template.id == Class15.smethod_0(41))
        GClass62.gclass141_0.method_141();
    }
    if (idAction == Class15.smethod_0(407))
      GClass156.smethod_0().method_31(GClass141.sbyte_5, (sbyte) this.selected);
    if (idAction == Class15.smethod_0(363))
    {
      GClass151.smethod_7(Class13.smethod_0(182361));
      bool flag = this.selected < GClass20.smethod_1().arrItemBody.Length;
      sbyte num = (sbyte) Class15.smethod_0(0);
      if (!flag)
        num = (sbyte) (this.selected - GClass20.smethod_1().arrItemBody.Length);
      GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(1), !flag ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0), !flag ? num : (sbyte) this.selected, (short) -1);
    }
    if (idAction == Class15.smethod_0(364))
    {
      GClass62.smethod_27();
      GClass82 gclass82 = (GClass82) p;
      sbyte where = (sbyte) gclass82.where;
      sbyte id = (sbyte) gclass82.id;
      GClass156.smethod_0().method_21(gclass82.type != 0 ? (sbyte) Class15.smethod_0(7) : (sbyte) Class15.smethod_0(5), where, id, (short) -1);
    }
    if (idAction == Class15.smethod_0(390))
    {
      sbyte id = (sbyte) (this.selected - GClass20.smethod_1().arrItemBody.Length);
      GClass156.smethod_0().method_31(GClass141.sbyte_6, id);
    }
    if (idAction == Class15.smethod_0(509))
    {
      GClass80[] arrItemBody = GClass20.smethod_2().arrItemBody;
      sbyte selected = (sbyte) this.selected;
      GClass156.smethod_0().method_31(GClass141.sbyte_7, selected);
    }
    if (idAction == Class15.smethod_0(514))
    {
      GClass151.smethod_7(Class13.smethod_0(182340));
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(0), this.selected, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(515))
    {
      GClass151.smethod_7(Class13.smethod_0(182460));
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(1), this.selected, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(516))
    {
      GClass151.smethod_7(Class13.smethod_0(182453));
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(7), this.selected, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(302))
    {
      GClass151.smethod_7(Class13.smethod_0(182444));
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(0), (int) gclass80.template.id, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(518))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass62.gclass39_0.method_0();
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(1), (int) gclass80.template.id, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(521))
    {
      GClass62.smethod_27();
      int length = GClass20.smethod_1().arrItemBody.Length;
      GClass156.smethod_0().method_55((sbyte) Class15.smethod_0(0), this.selected >= length ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0), this.selected >= length ? (short) (this.selected - length) : (short) this.selected);
    }
    if (idAction == Class15.smethod_0(545))
    {
      GClass62.smethod_27();
      GClass82 gclass82 = (GClass82) p;
      GClass156.smethod_0().method_55((sbyte) Class15.smethod_0(1), (sbyte) gclass82.type, (short) gclass82.id);
    }
    if (idAction == Class15.smethod_0(517))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(5), (int) gclass80.template.id, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(513))
    {
      GClass151.smethod_7(Class13.smethod_0(182444));
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_56((sbyte) Class15.smethod_0(5), (int) gclass80.template.id, Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(370))
    {
      GClass25 gclass25 = (GClass25) p;
      if (gclass25 != null)
      {
        GClass62.smethod_27();
        GClass156.smethod_0().method_20(Class15.smethod_0(7), (string) null, gclass25.ID);
      }
    }
    if (idAction == Class15.smethod_0(533))
    {
      GClass25 gclass25 = (GClass25) p;
      if (gclass25 != null)
      {
        GClass71.smethod_1();
        this.clanReport = GClass109.string_83;
        GClass156.smethod_0().method_23(gclass25.ID);
      }
    }
    if (idAction == Class15.smethod_0(511))
      GClass62.smethod_27();
    if (idAction == Class15.smethod_0(535))
      GClass62.smethod_27();
    if (idAction == Class15.smethod_0(548))
    {
      GClass28 gclass28 = (GClass28) p;
      GClass156.smethod_0().method_19(gclass28.id);
    }
    if (idAction == Class15.smethod_0(296))
    {
      GClass94 gclass94 = (GClass94) p;
      GClass156.smethod_0().method_26(gclass94.ID, (sbyte) Class15.smethod_0(0));
    }
    if (idAction == Class15.smethod_0(285))
    {
      GClass94 gclass94 = (GClass94) p;
      GClass156.smethod_0().method_26(gclass94.ID, (sbyte) Class15.smethod_0(1));
    }
    if (idAction == Class15.smethod_0(295))
    {
      GClass94 gclass94 = (GClass94) p;
      GClass156.smethod_0().method_26(gclass94.ID, (sbyte) Class15.smethod_0(7));
    }
    if (idAction == Class15.smethod_0(534))
    {
      GClass94 gclass94 = (GClass94) p;
      GClass156.smethod_0().method_26(gclass94.ID, (sbyte) -1);
    }
    if (idAction == Class15.smethod_0(331))
    {
      GClass156.smethod_0().method_124(this.selected, Class15.smethod_0(1));
      GClass62.smethod_27();
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(536))
    {
      GClass156.smethod_0().method_124(this.selected, Class15.smethod_0(31));
      GClass62.smethod_27();
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(537))
    {
      GClass156.smethod_0().method_124(this.selected, Class15.smethod_0(21));
      GClass62.smethod_27();
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(540))
    {
      GClass161 gclass161 = (GClass161) p;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = GClass109.string_366;
      strArray[Class15.smethod_0(1)] = gclass161.powRequire.ToString();
      strArray[Class15.smethod_0(7)] = GClass109.string_367;
      strArray[Class15.smethod_0(5)] = gclass161.moreInfo;
      strArray[Class15.smethod_0(2)] = GClass109.string_368;
      GClass62.smethod_28(string.Concat(strArray));
    }
    if (idAction == Class15.smethod_0(539))
    {
      if (GClass62.bool_5 && !Main.bool_3)
        GClass116.smethod_6().method_10((GClass167) p);
      else
        GClass116.smethod_6().method_11((GClass167) p);
    }
    if (idAction == Class15.smethod_0(541))
    {
      GClass161 gclass161 = (GClass161) p;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = GClass109.string_366;
      strArray[Class15.smethod_0(1)] = gclass161.powRequire.ToString();
      strArray[Class15.smethod_0(7)] = GClass109.string_367;
      strArray[Class15.smethod_0(5)] = gclass161.moreInfo;
      strArray[Class15.smethod_0(2)] = GClass109.string_368;
      GClass62.smethod_28(string.Concat(strArray));
    }
    if (idAction == Class15.smethod_0(181))
    {
      GClass72 gclass72 = (GClass72) p;
      GClass156.smethod_0().method_129((sbyte) Class15.smethod_0(1), gclass72.charInfo.charID);
      GClass62.gclass141_0.method_140();
    }
    if (idAction == Class15.smethod_0(528))
    {
      GClass72 gclass72 = (GClass72) p;
      GClass156.smethod_0().method_129((sbyte) Class15.smethod_0(7), gclass72.charInfo.charID);
      GClass71.smethod_1();
    }
    Class15.smethod_0(408);
    if (idAction == Class15.smethod_0(523))
    {
      if (this.chatTField == null)
      {
        this.chatTField = new GClass23();
        this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
        this.chatTField.method_0();
        this.chatTField.parentScreen = GClass62.gclass141_1 != null ? (GInterface1) GClass62.gclass141_1 : (GInterface1) GClass62.gclass141_0;
      }
      if (this.currItem.quantity == Class15.smethod_0(1))
      {
        this.chatTField.strChat = GClass109.string_406;
        this.chatTField.tfChat.name = GClass109.string_322;
      }
      else
      {
        this.chatTField.strChat = GClass109.string_326 + Class13.smethod_0(182285);
        this.chatTField.tfChat.name = GClass109.string_326;
      }
      this.chatTField.tfChat.method_26(Class15.smethod_0(45));
      this.chatTField.to = string.Empty;
      this.chatTField.isShow = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.method_28(GClass184.int_8);
      if (GClass62.bool_5)
        this.chatTField.tfChat.method_0();
      if (Main.bool_4)
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
      if (!Main.bool_3)
        this.chatTField.method_5((GInterface1) this, string.Empty);
    }
    if (idAction == Class15.smethod_0(522))
    {
      if (this.chatTField == null)
      {
        this.chatTField = new GClass23();
        this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
        this.chatTField.method_0();
        this.chatTField.parentScreen = GClass62.gclass141_1 != null ? (GInterface1) GClass62.gclass141_1 : (GInterface1) GClass62.gclass141_0;
      }
      if (this.currItem.quantity == Class15.smethod_0(1))
      {
        this.chatTField.strChat = GClass109.string_407;
        this.chatTField.tfChat.name = GClass109.string_322;
      }
      else
      {
        this.chatTField.strChat = GClass109.string_326 + Class13.smethod_0(182437);
        this.chatTField.tfChat.name = GClass109.string_326;
      }
      this.chatTField.to = string.Empty;
      this.chatTField.isShow = Class15.smethod_0(1) != 0;
      this.chatTField.tfChat.method_28(GClass184.int_8);
      if (GClass62.bool_5)
        this.chatTField.tfChat.method_0();
      if (Main.bool_4)
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
      if (!Main.bool_3)
        this.chatTField.method_5((GInterface1) this, string.Empty);
    }
    if (idAction == Class15.smethod_0(524))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(1), gclass80.itemId, (sbyte) -1, -1, -1);
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(526))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(7), gclass80.itemId, (sbyte) -1, -1, -1);
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(519))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(5), gclass80.itemId, (sbyte) Class15.smethod_0(0), gclass80.buyCoin, -1);
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(520))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(5), gclass80.itemId, (sbyte) Class15.smethod_0(1), gclass80.buyGold, -1);
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(525))
    {
      GClass80 gclass80 = (GClass80) p;
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(3), gclass80.itemId, (sbyte) -1, -1, -1);
      GClass71.smethod_1();
    }
    if (idAction == Class15.smethod_0(307))
    {
      GClass157.smethod_0().imethod_4();
      GClass152.smethod_4(Class13.smethod_0(182434), string.Empty);
      GClass152.smethod_4(Class13.smethod_0(182405), string.Empty);
      GClass62.gclass117_0.tfPass.method_23(string.Empty);
      GClass62.gclass117_0.tfUser.method_23(string.Empty);
      GClass62.gclass117_0.isLogin2 = Class15.smethod_0(0) != 0;
      GClass62.gclass117_0.vmethod_0();
      GClass62.smethod_27();
      this.method_141();
    }
    if (idAction == Class15.smethod_0(308))
      GClass62.smethod_27();
    if (idAction == Class15.smethod_0(530))
    {
      GClass156.smethod_0().method_131((sbyte) Class15.smethod_0(1), (sbyte) this.selected);
      GClass62.gclass141_0.method_140();
    }
    if (idAction == Class15.smethod_0(531))
      GClass157.smethod_0().imethod_4();
    if (idAction == Class15.smethod_0(342))
    {
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(0), this.currItem.itemId, (sbyte) Class15.smethod_0(1), this.currItem.buyRuby, Class15.smethod_0(1));
      GClass62.smethod_27();
    }
    if (idAction == Class15.smethod_0(343))
    {
      GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(0), this.currItem.itemId, (sbyte) Class15.smethod_0(1), this.currItem.buyRuby, this.currItem.quantilyToBuy);
      GClass62.smethod_27();
    }
    if (idAction != Class15.smethod_0(549))
      return;
    this.chatTField.isShow = Class15.smethod_0(0) != 0;
    GClass62.smethod_27();
  }

  public void imethod_1(string text, string to)
  {
    if (this.chatTField.tfChat.method_21() != null && !this.chatTField.tfChat.method_21().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
    {
      if (this.chatTField.strChat.Equals(GClass109.string_276))
      {
        GClass71.smethod_1();
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
        GClass156.smethod_0().method_24(text);
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_278))
      {
        GClass71.smethod_1();
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
        GClass156.smethod_0().method_20(Class15.smethod_0(0), text, -1);
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_279))
      {
        if (this.chatTField.tfChat.method_21() == string.Empty)
        {
          GClass116.gclass73_0.method_7(GClass109.string_289, Class15.smethod_0(0));
        }
        else
        {
          if (this.tabIcon == null)
            this.tabIcon = new GClass178();
          this.tabIcon.text = this.chatTField.tfChat.method_21();
          this.tabIcon.method_1(Class15.smethod_0(0) != 0);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
        }
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_280))
      {
        if (this.chatTField.tfChat.method_21() == string.Empty)
        {
          GClass116.gclass73_0.method_7(GClass109.string_290, Class15.smethod_0(0));
        }
        else
        {
          GClass156.smethod_0().method_29((sbyte) Class15.smethod_0(2), (sbyte) GClass20.smethod_1().clan.imgID, this.chatTField.tfChat.method_21());
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
        }
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_30))
      {
        try
        {
          int pass = int.Parse(this.chatTField.tfChat.method_21());
          if (this.chatTField.tfChat.method_21().Length == Class15.smethod_0(37) && !this.chatTField.tfChat.method_21().Equals(string.Empty))
          {
            GClass156.smethod_0().method_132(pass);
            this.chatTField.isShow = Class15.smethod_0(0) != 0;
            this.chatTField.tfChat.method_28(GClass184.int_7);
            this.method_141();
          }
          else
            GClass62.smethod_28(GClass109.string_31);
        }
        catch (Exception ex)
        {
          GClass62.smethod_28(GClass109.string_44);
        }
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_348))
      {
        if (this.chatTField.tfChat.method_21().Equals(string.Empty))
          return;
        GClass156.smethod_0().method_99(this.chatTField.tfChat.method_21());
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
        this.method_141();
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_244))
      {
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
        GClass72 gclass72 = (GClass72) null;
        if (this.type == Class15.smethod_0(88))
          gclass72 = (GClass72) this.logChat.method_3(this.int_76);
        else if (this.type == Class15.smethod_0(67))
          gclass72 = (GClass72) this.vFriend.method_3(this.int_76);
        if (gclass72.charInfo.charID == GClass20.smethod_1().charID)
          return;
        GClass156.smethod_0().method_98(text, gclass72.charInfo.charID);
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_325))
      {
        Class15.smethod_0(0);
        int num;
        try
        {
          num = int.Parse(this.chatTField.tfChat.method_21());
        }
        catch (Exception ex)
        {
          GClass62.smethod_28(GClass109.string_327);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
          return;
        }
        if (num > Class15.smethod_0(0) && num <= this.currItem.quantity)
        {
          this.currItem.isSelect = Class15.smethod_0(1) != 0;
          GClass80 o = new GClass80();
          o.template = this.currItem.template;
          o.quantity = num;
          o.indexUI = this.currItem.indexUI;
          o.itemOption = this.currItem.itemOption;
          GClass62.gclass141_0.vMyGD.method_0((object) o);
          GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(7), -1, (sbyte) o.indexUI, o.quantity);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
        }
        else
        {
          GClass62.smethod_28(GClass109.string_327);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
        }
      }
      else if (this.chatTField.strChat == GClass109.string_321)
      {
        Class15.smethod_0(0);
        int num;
        try
        {
          num = int.Parse(this.chatTField.tfChat.method_21());
        }
        catch (Exception ex)
        {
          GClass62.smethod_28(GClass109.string_323);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
          return;
        }
        if ((long) num > GClass20.smethod_1().xu)
        {
          GClass62.smethod_28(GClass109.string_324);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
        }
        else
        {
          this.moneyGD = num;
          GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(7), -1, (sbyte) -1, num);
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
          this.chatTField.tfChat.method_28(GClass184.int_7);
        }
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_406))
      {
        GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(0), this.currItem.itemId, (sbyte) Class15.smethod_0(0), int.Parse(this.chatTField.tfChat.method_21()), Class15.smethod_0(1));
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_406 + Class13.smethod_0(177907)))
      {
        GClass156.smethod_0().method_130((sbyte) Class15.smethod_0(0), this.currItem.itemId, (sbyte) Class15.smethod_0(0), int.Parse(this.chatTField.tfChat.method_21()), this.currItem.quantilyToBuy);
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_407))
      {
        this.method_203(Class15.smethod_0(0));
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_407 + Class13.smethod_0(179684)))
      {
        this.method_203(Class15.smethod_0(1));
        this.chatTField.isShow = Class15.smethod_0(0) != 0;
      }
      else if (this.chatTField.strChat.Equals(GClass109.string_326 + Class13.smethod_0(177907)))
      {
        this.currItem.quantilyToBuy = int.Parse(this.chatTField.tfChat.method_21());
        if (this.currItem.quantilyToBuy > this.currItem.quantity)
        {
          GClass62.smethod_28(GClass109.string_327);
        }
        else
        {
          this.bool_13 = Class15.smethod_0(1) != 0;
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
        }
      }
      else
      {
        if (!this.chatTField.strChat.Equals(GClass109.string_326 + Class13.smethod_0(179684)))
          return;
        this.currItem.quantilyToBuy = int.Parse(this.chatTField.tfChat.method_21());
        if (this.currItem.quantilyToBuy > this.currItem.quantity)
        {
          GClass62.smethod_28(GClass109.string_327);
        }
        else
        {
          this.bool_14 = Class15.smethod_0(1) != 0;
          this.chatTField.isShow = Class15.smethod_0(0) != 0;
        }
      }
    }
    else
      this.chatTField.isShow = Class15.smethod_0(0) != 0;
  }

  public void imethod_2() => this.chatTField.tfChat.method_28(GClass184.int_7);

  public void method_185(int type)
  {
    this.int_89 = type;
    this.int_78 = Class15.smethod_0(23);
    if ((this.int_89 == 0 ? 0 : 1) == 0)
    {
      this.int_82 = Class15.smethod_0(3);
      this.int_79 = this.int_80 = Class15.smethod_0(23);
      this.int_88 = Class15.smethod_0(7);
      for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
        {
          if ((int) gclass80.template.type == Class15.smethod_0(49))
            this.iconID2 = gclass80.template.iconID;
          else
            this.iconID1 = gclass80.template.iconID;
        }
      }
    }
    else if (this.int_89 == Class15.smethod_0(1))
    {
      this.int_82 = Class15.smethod_0(7);
      this.int_79 = this.int_80 = Class15.smethod_0(0);
      this.int_88 = Class15.smethod_0(1);
      for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
        {
          if ((index == 0 ? 0 : 1) == 0)
            this.iconID1 = gclass80.template.iconID;
          else
            this.iconID2 = gclass80.template.iconID;
        }
      }
    }
    else if (this.int_89 == Class15.smethod_0(7))
    {
      this.int_82 = Class15.smethod_0(38);
      this.int_79 = this.int_80 = Class15.smethod_0(46);
      this.int_88 = Class15.smethod_0(1);
      for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
          this.iconID1 = gclass80.template.iconID;
      }
    }
    else if (this.int_89 == Class15.smethod_0(5))
    {
      this.xS = GClass62.int_12;
      this.yS = GClass62.int_13;
      this.int_82 = Class15.smethod_0(1);
      this.int_79 = this.int_80 = Class15.smethod_0(1);
      this.int_88 = Class15.smethod_0(2);
      for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
          this.iconID1 = gclass80.template.iconID;
      }
    }
    else if (this.int_89 == Class15.smethod_0(2))
    {
      this.int_82 = this.vItemCombine.method_2();
      this.iconID = new short[this.int_82];
      this.int_79 = this.int_80 = Class15.smethod_0(46);
      this.int_88 = Class15.smethod_0(1);
      for (int index = Class15.smethod_0(0); index < this.vItemCombine.method_2(); index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = (GClass80) this.vItemCombine.method_3(index);
        if ((gclass80 == null ? 1 : 0) == 0)
          this.iconID[index] = gclass80.template.iconID;
      }
    }
    this.int_83 = Class15.smethod_0(1);
    this.bool_15 = Class15.smethod_0(1) != 0;
    this.isDoneCombine = Class15.smethod_0(0) != 0;
    this.bool_16 = Class15.smethod_0(0) != 0;
    this.int_81 = Class15.smethod_0(229) / this.int_82;
    this.int_84 = new int[this.int_82];
    this.int_85 = new int[this.int_82];
    this.int_86 = new int[this.int_82];
    this.int_87 = new int[this.int_82];
    this.method_188();
    this.bool_17 = Class15.smethod_0(1) != 0;
    this.int_90 = Class15.smethod_0(31);
    this.int_91 = Class15.smethod_0(6);
    this.int_92 = Class15.smethod_0(31);
    this.method_190(this.idNPC, GClass109.string_23);
  }

  private void method_186()
  {
    this.int_90 -= Class15.smethod_0(1);
    if (this.int_90 < Class15.smethod_0(0))
      this.int_90 = Class15.smethod_0(0);
    this.int_91 -= Class15.smethod_0(1);
    if (this.int_91 < Class15.smethod_0(0))
      this.int_91 = Class15.smethod_0(0);
    if (this.int_90 != 0)
      return;
    if (!this.bool_16)
    {
      if (this.int_88 > Class15.smethod_0(0))
      {
        if (this.combineSuccess != (sbyte) -1)
        {
          if (this.int_89 == Class15.smethod_0(5))
          {
            if (GClass62.int_8 % Class15.smethod_0(31) == 0)
            {
              GClass40.smethod_0(new GClass41(Class15.smethod_0(27), this.xS - Class15.smethod_0(31), this.yS + Class15.smethod_0(46), Class15.smethod_0(2), Class15.smethod_0(1), Class15.smethod_0(1)));
              this.int_88 -= Class15.smethod_0(1);
            }
          }
          else
          {
            if (GClass62.int_8 % Class15.smethod_0(7) == 0)
            {
              if (this.bool_15)
              {
                if (this.int_83 < Class15.smethod_0(54))
                  this.int_83 += Class15.smethod_0(7);
              }
              else if (this.int_83 > Class15.smethod_0(31))
                this.int_83 -= Class15.smethod_0(7);
            }
            if (this.int_91 == 0)
            {
              if (this.bool_15)
              {
                if (this.int_78 > Class15.smethod_0(0))
                  this.int_78 -= Class15.smethod_0(3);
                else if (GClass62.int_8 % Class15.smethod_0(31) == 0)
                {
                  this.bool_15 = Class15.smethod_0(0) != 0;
                  this.int_88 -= Class15.smethod_0(1);
                  this.int_91 = Class15.smethod_0(3);
                  this.int_92 = Class15.smethod_0(31);
                }
              }
              else if (this.int_78 < Class15.smethod_0(23))
                this.int_78 += Class15.smethod_0(3);
              else if (GClass62.int_8 % Class15.smethod_0(31) == 0)
              {
                this.bool_15 = Class15.smethod_0(1) != 0;
                this.int_91 = Class15.smethod_0(31);
              }
            }
            this.int_79 = this.int_80;
            this.int_79 -= this.int_83;
            if (this.int_79 >= Class15.smethod_0(229))
              this.int_79 -= Class15.smethod_0(229);
            if (this.int_79 < Class15.smethod_0(0))
              this.int_79 = Class15.smethod_0(229) + this.int_79;
            this.int_80 = this.int_79;
            this.method_188();
          }
        }
      }
      else if (GClass62.int_8 % Class15.smethod_0(51) == 0)
        this.bool_16 = Class15.smethod_0(1) != 0;
      if (GClass62.int_8 % Class15.smethod_0(51) != 0)
        return;
      if (this.int_89 != Class15.smethod_0(5))
        GClass45.smethod_0(Class15.smethod_0(198), this.xS, this.yS, Class15.smethod_0(7));
      GClass45.smethod_0(Class15.smethod_0(24), this.xS, this.yS + Class15.smethod_0(51), Class15.smethod_0(7));
    }
    else
    {
      if (!this.bool_16)
        return;
      if ((int) this.combineSuccess == Class15.smethod_0(1))
      {
        if (this.int_92 == Class15.smethod_0(31))
          GClass40.smethod_0(new GClass41(Class15.smethod_0(28), this.xS - Class15.smethod_0(5), this.yS + Class15.smethod_0(46), Class15.smethod_0(2), Class15.smethod_0(1), Class15.smethod_0(1)));
        this.int_92 -= Class15.smethod_0(1);
        if (this.int_92 < Class15.smethod_0(0))
          this.int_92 = Class15.smethod_0(0);
        if (this.int_78 < Class15.smethod_0(137))
        {
          this.int_78 = GClass151.smethod_25(this.int_78 + Class15.smethod_0(31));
          if (this.int_78 == Class15.smethod_0(51))
            this.method_190(this.idNPC, GClass109.string_24);
        }
        else if (GClass62.int_8 % Class15.smethod_0(51) == 0)
        {
          if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
          {
            GClass62.gclass141_1 = new GClass141();
            string[][][] tabName = GClass62.gclass141_1.tabName;
            int index1 = Class15.smethod_0(38);
            string[][] strArray1 = new string[Class15.smethod_0(1)][];
            int index2 = Class15.smethod_0(0);
            string[] strArray2 = new string[Class15.smethod_0(1)];
            strArray2[Class15.smethod_0(0)] = string.Empty;
            strArray1[index2] = strArray2;
            tabName[index1] = strArray1;
            GClass62.gclass141_1.method_12();
            GClass62.gclass141_1.method_44();
          }
          this.combineSuccess = (sbyte) -1;
          this.isDoneCombine = Class15.smethod_0(1) != 0;
          if (this.int_89 == Class15.smethod_0(2))
            GClass62.gclass141_0.method_140();
        }
        this.method_188();
      }
      else
      {
        if (this.combineSuccess != (sbyte) 0)
          return;
        if (this.int_92 == Class15.smethod_0(31))
        {
          if (this.int_89 == Class15.smethod_0(7))
            GClass40.smethod_0(new GClass41(Class15.smethod_0(51), this.xS - Class15.smethod_0(5), this.yS + Class15.smethod_0(9), Class15.smethod_0(2), Class15.smethod_0(7), Class15.smethod_0(1)));
          else
            GClass40.smethod_0(new GClass41(Class15.smethod_0(27), this.xS - Class15.smethod_0(31), this.yS + Class15.smethod_0(46), Class15.smethod_0(2), Class15.smethod_0(1), Class15.smethod_0(1)));
          this.method_190(this.idNPC, GClass109.string_25);
          this.bool_17 = Class15.smethod_0(0) != 0;
        }
        if (this.bool_17)
          return;
        this.int_92 -= Class15.smethod_0(1);
        if (this.int_92 >= Class15.smethod_0(141))
          return;
        this.int_92 = Class15.smethod_0(141);
        if (this.int_89 < Class15.smethod_0(5) && GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
        {
          GClass62.gclass141_1 = new GClass141();
          string[][][] tabName = GClass62.gclass141_1.tabName;
          int index3 = Class15.smethod_0(38);
          string[][] strArray3 = new string[Class15.smethod_0(1)][];
          int index4 = Class15.smethod_0(0);
          string[] strArray4 = new string[Class15.smethod_0(1)];
          strArray4[Class15.smethod_0(0)] = string.Empty;
          strArray3[index4] = strArray4;
          tabName[index3] = strArray3;
          GClass62.gclass141_1.method_12();
          GClass62.gclass141_1.method_44();
        }
        this.combineSuccess = (sbyte) -1;
        this.isDoneCombine = Class15.smethod_0(1) != 0;
        if (this.int_89 != Class15.smethod_0(2))
          return;
        GClass62.gclass141_0.method_140();
      }
    }
  }

  public void method_187(GClass98 g)
  {
    GClass116.smethod_6().method_79(g);
    this.method_189(g);
    if ((this.int_89 == 0 ? 0 : 1) == 0)
    {
      for (int index = Class15.smethod_0(0); index < this.int_85.Length; index += Class15.smethod_0(1))
      {
        GClass169.smethod_6(g, (int) this.iconID1, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        if ((!this.bool_17 ? 1 : 0) == 0)
          GClass169.smethod_6(g, (int) this.iconID2, this.int_86[index], this.int_87[index], Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
    }
    else if (this.int_89 == Class15.smethod_0(1))
    {
      if ((!this.bool_17 ? 0 : 1) == 0)
      {
        GClass169.smethod_6(g, (int) this.iconID3, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
      else
      {
        for (int index = Class15.smethod_0(0); index < this.int_85.Length; index += Class15.smethod_0(1))
        {
          GClass169.smethod_6(g, (int) this.iconID1, this.int_86[Class15.smethod_0(0)], this.int_87[Class15.smethod_0(0)], Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
          GClass169.smethod_6(g, (int) this.iconID2, this.int_86[Class15.smethod_0(1)], this.int_87[Class15.smethod_0(1)], Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
        }
      }
    }
    else if (this.int_89 == Class15.smethod_0(7))
    {
      if ((!this.bool_17 ? 0 : 1) == 0)
      {
        GClass169.smethod_6(g, (int) this.iconID3, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
      else
      {
        for (int index = Class15.smethod_0(0); index < this.int_85.Length; index += Class15.smethod_0(1))
          GClass169.smethod_6(g, (int) this.iconID1, this.int_86[index], this.int_87[index], Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
    }
    else if (this.int_89 == Class15.smethod_0(5))
    {
      if ((!this.bool_17 ? 0 : 1) == 0)
        GClass169.smethod_6(g, (int) this.iconID3, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      else
        GClass169.smethod_6(g, (int) this.iconID1, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
    }
    else
    {
      if (this.int_89 != Class15.smethod_0(2))
        return;
      if ((!this.bool_17 ? 0 : 1) == 0)
      {
        if (this.iconID3 == (short) -1)
          return;
        GClass169.smethod_6(g, (int) this.iconID3, this.xS, this.yS, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
      else
      {
        for (int index = Class15.smethod_0(0); index < this.iconID.Length; index += Class15.smethod_0(1))
          GClass169.smethod_6(g, (int) this.iconID[index], this.int_86[index], this.int_87[index], Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
    }
  }

  private void method_188()
  {
    for (int index = Class15.smethod_0(0); index < this.int_85.Length; index += Class15.smethod_0(1))
    {
      if (this.int_79 >= Class15.smethod_0(229))
        this.int_79 -= Class15.smethod_0(229);
      if (this.int_79 < Class15.smethod_0(0))
        this.int_79 = Class15.smethod_0(229) + this.int_79;
      this.int_85[index] = GClass151.smethod_25(this.int_78 * GClass151.smethod_1(this.int_79) / Class15.smethod_0(246));
      this.int_84[index] = GClass151.smethod_25(this.int_78 * GClass151.smethod_2(this.int_79) / Class15.smethod_0(246));
      if (this.int_79 < Class15.smethod_0(23))
      {
        this.int_86[index] = this.xS + this.int_84[index];
        this.int_87[index] = this.yS - this.int_85[index];
      }
      else if (this.int_79 >= Class15.smethod_0(23) && this.int_79 < Class15.smethod_0(96))
      {
        this.int_86[index] = this.xS - this.int_84[index];
        this.int_87[index] = this.yS - this.int_85[index];
      }
      else if (this.int_79 >= Class15.smethod_0(96) && this.int_79 < Class15.smethod_0(196))
      {
        this.int_86[index] = this.xS - this.int_84[index];
        this.int_87[index] = this.yS + this.int_85[index];
      }
      else
      {
        this.int_86[index] = this.xS + this.int_84[index];
        this.int_87[index] = this.yS + this.int_85[index];
      }
      this.int_79 -= this.int_81;
    }
  }

  public void method_189(GClass98 g)
  {
    g.method_1(-GClass116.int_22, -GClass116.int_23);
    if (this.int_89 < Class15.smethod_0(5))
    {
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
      {
        GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
        if (gclass21.template.npcTemplateId == this.idNPC)
        {
          gclass21.vmethod_1(g);
          if ((gclass21.chatInfo == null ? 1 : 0) == 0)
            gclass21.chatInfo.method_1(g, gclass21.cx, gclass21.cy - gclass21.ch - GClass62.int_52, gclass21.cdir);
        }
      }
    }
    GClass62.smethod_6(g);
    if ((GClass62.int_8 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0)
    {
      g.method_32(GClass81.gclass66_0, this.xS - Class15.smethod_0(3), this.yS + Class15.smethod_0(9), GClass98.int_5 | GClass98.int_0);
      g.method_32(GClass81.gclass66_0, this.xS + Class15.smethod_0(3), this.yS + Class15.smethod_0(9), GClass98.int_5 | GClass98.int_0);
      g.method_32(GClass81.gclass66_0, this.xS, this.yS + Class15.smethod_0(9), GClass98.int_5 | GClass98.int_0);
    }
    for (int index = Class15.smethod_0(0); index < GClass42.gclass134_0.method_2(); index += Class15.smethod_0(1))
      ((GClass42) GClass42.gclass134_0.method_3(index)).vmethod_1(g);
  }

  public void method_190(int idNPC, string text)
  {
    if (this.int_89 >= Class15.smethod_0(5))
      return;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
    {
      GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
      if (gclass21.template.npcTemplateId == idNPC)
        gclass21.method_7(text);
    }
  }

  public void method_191()
  {
    this.type = Class15.smethod_0(65);
    this.method_5(Class15.smethod_0(0));
    this.method_192();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  private void method_192()
  {
    GClass172.smethod_1().method_2();
    this.currentListLength = GClass141.string_2.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  private void method_193(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < GClass141.string_2.Length; index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, w, h);
        GClass97.gclass97_6.method_6(gclass98_0, GClass141.string_2[index], this.xScroll + Class15.smethod_0(31), y + Class15.smethod_0(37), GClass97.int_0);
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_194()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    switch (this.selected)
    {
      case 0:
        GClass172.smethod_1().method_15();
        break;
      case 1:
        GClass172.smethod_1().method_16();
        break;
      case 2:
        GClass172.smethod_1().method_10();
        break;
      case 3:
        if ((!Main.bool_3 ? 1 : 0) == 0)
        {
          GClass62.smethod_34(GClass109.string_189, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(546), (object) null), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) null));
          break;
        }
        GClass172.smethod_1().method_14();
        break;
      case 4:
        if ((!Main.bool_3 ? 1 : 0) == 0)
        {
          GClass62.smethod_34(GClass109.string_189, new GClass31(GClass109.string_135, (GInterface0) this, Class15.smethod_0(546), (object) null), new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(511), (object) null));
          break;
        }
        GClass172.smethod_1().method_14();
        break;
      case 5:
        GClass172.smethod_1().method_13();
        break;
    }
  }

  public void method_195()
  {
    this.type = Class15.smethod_0(51);
    this.method_5(Class15.smethod_0(0));
    this.method_196();
    this.cmx = this.cmtoX = Class15.smethod_0(0);
  }

  private void method_196()
  {
    if ((!Main.bool_6 ? 1 : 0) == 0)
    {
      string[] strArray1 = new string[Class15.smethod_0(2)];
      strArray1[Class15.smethod_0(0)] = GClass109.string_29;
      strArray1[Class15.smethod_0(1)] = GClass109.string_172;
      strArray1[Class15.smethod_0(7)] = GClass109.string_173;
      strArray1[Class15.smethod_0(5)] = GClass109.string_60;
      GClass141.string_3 = strArray1;
      if ((!GClass116.bool_55 ? 1 : 0) == 0)
      {
        string[] strArray2 = new string[Class15.smethod_0(3)];
        strArray2[Class15.smethod_0(0)] = GClass109.string_29;
        strArray2[Class15.smethod_0(1)] = GClass109.string_172;
        strArray2[Class15.smethod_0(7)] = GClass109.string_173;
        strArray2[Class15.smethod_0(5)] = GClass109.string_60;
        strArray2[Class15.smethod_0(2)] = GClass109.string_12;
        GClass141.string_3 = strArray2;
      }
    }
    else
    {
      string[] strArray3 = new string[Class15.smethod_0(3)];
      strArray3[Class15.smethod_0(0)] = GClass109.string_29;
      strArray3[Class15.smethod_0(1)] = GClass109.string_172;
      strArray3[Class15.smethod_0(7)] = GClass109.string_173;
      strArray3[Class15.smethod_0(5)] = GClass109.string_60;
      strArray3[Class15.smethod_0(2)] = GClass109.string_418;
      GClass141.string_3 = strArray3;
      if ((!GClass116.bool_55 ? 1 : 0) == 0)
      {
        string[] strArray4 = new string[Class15.smethod_0(37)];
        strArray4[Class15.smethod_0(0)] = GClass109.string_29;
        strArray4[Class15.smethod_0(1)] = GClass109.string_172;
        strArray4[Class15.smethod_0(7)] = GClass109.string_173;
        strArray4[Class15.smethod_0(5)] = GClass109.string_60;
        strArray4[Class15.smethod_0(2)] = GClass109.string_418;
        strArray4[Class15.smethod_0(3)] = GClass109.string_12;
        GClass141.string_3 = strArray4;
      }
      if ((GClass126.int_0 == Class15.smethod_0(7) || GClass126.int_0 == Class15.smethod_0(38)) && (int) GClass109.sbyte_0 != Class15.smethod_0(7))
      {
        string[] strArray5 = new string[Class15.smethod_0(3)];
        strArray5[Class15.smethod_0(0)] = GClass109.string_29;
        strArray5[Class15.smethod_0(1)] = GClass109.string_172;
        strArray5[Class15.smethod_0(7)] = GClass109.string_173;
        strArray5[Class15.smethod_0(5)] = GClass109.string_60;
        strArray5[Class15.smethod_0(2)] = GClass109.string_418;
        GClass141.string_3 = strArray5;
        if ((!GClass116.bool_55 ? 1 : 0) == 0)
        {
          string[] strArray6 = new string[Class15.smethod_0(37)];
          strArray6[Class15.smethod_0(0)] = GClass109.string_29;
          strArray6[Class15.smethod_0(1)] = GClass109.string_172;
          strArray6[Class15.smethod_0(7)] = GClass109.string_173;
          strArray6[Class15.smethod_0(5)] = GClass109.string_60;
          strArray6[Class15.smethod_0(2)] = GClass109.string_418;
          strArray6[Class15.smethod_0(3)] = GClass109.string_12;
          GClass141.string_3 = strArray6;
        }
      }
    }
    this.currentListLength = GClass141.string_3.Length;
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy <= this.cmyLim)
      return;
    this.cmy = this.cmtoY = this.cmyLim;
  }

  private void method_197(GClass98 gclass98_0)
  {
    gclass98_0.method_5(this.xScroll, this.yScroll, this.wScroll, this.hScroll);
    gclass98_0.method_1(Class15.smethod_0(0), -this.cmy);
    for (int index = Class15.smethod_0(0); index < GClass141.string_3.Length; index += Class15.smethod_0(1))
    {
      int xScroll = this.xScroll;
      int y = this.yScroll + index * this.ITEM_HEIGHT;
      int w = this.wScroll - Class15.smethod_0(1);
      int h = this.ITEM_HEIGHT - Class15.smethod_0(1);
      if (y - this.cmy <= this.yScroll + this.hScroll && y - this.cmy >= this.yScroll - this.ITEM_HEIGHT)
      {
        gclass98_0.method_16(index != this.selected ? Class15.smethod_0(485) : Class15.smethod_0(104));
        gclass98_0.method_15(xScroll, y, w, h);
        GClass97.gclass97_6.method_6(gclass98_0, GClass141.string_3[index], this.xScroll + this.wScroll / Class15.smethod_0(7), y + Class15.smethod_0(37), GClass97.int_2);
      }
    }
    this.method_94(gclass98_0);
  }

  private void method_198()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    switch (this.selected)
    {
      case 0:
        GClass62.smethod_27();
        if ((this.chatTField == null ? 0 : 1) == 0)
        {
          this.chatTField = new GClass23();
          this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
          this.chatTField.method_0();
          this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
        }
        this.chatTField.tfChat.method_23(string.Empty);
        this.chatTField.strChat = GClass109.string_30;
        this.chatTField.tfChat.name = GClass109.string_30;
        this.chatTField.to = string.Empty;
        this.chatTField.isShow = Class15.smethod_0(1) != 0;
        this.chatTField.tfChat.isFocus = Class15.smethod_0(1) != 0;
        this.chatTField.tfChat.method_28(GClass184.int_8);
        if ((!GClass62.bool_5 ? 1 : 0) == 0)
          this.chatTField.tfChat.method_0();
        if ((!Main.bool_3 ? 0 : 1) == 0)
          this.chatTField.method_5((GInterface1) this, string.Empty);
        if ((!Main.bool_4 ? 1 : 0) != 0)
          break;
        this.chatTField.tfChat.strInfo = this.chatTField.strChat;
        break;
      case 1:
        GClass156.smethod_0().method_14((sbyte) Class15.smethod_0(0), -1);
        GClass71.smethod_1();
        break;
      case 2:
        GClass156.smethod_0().method_129((sbyte) Class15.smethod_0(0), -1);
        GClass71.smethod_1();
        break;
      case 3:
        this.method_25();
        if ((this.chatTField == null ? 0 : 1) != 0)
          break;
        this.chatTField = new GClass23();
        this.chatTField.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - GClass23.smethod_0().tfChat.height;
        this.chatTField.method_0();
        this.chatTField.parentScreen = (GInterface1) GClass62.gclass141_0;
        break;
      case 4:
        if ((int) GClass109.sbyte_0 == Class15.smethod_0(7))
        {
          string url = Class13.smethod_0(179208) + GClass62.gclass117_0.tfUser.method_21();
          this.method_140();
          try
          {
            GClass63.gclass63_0.method_3(url);
            break;
          }
          catch (Exception ex)
          {
            ex.StackTrace.ToString();
            break;
          }
        }
        else
        {
          this.method_140();
          if ((int) GClass20.smethod_1().taskMaint.taskId <= Class15.smethod_0(31))
          {
            GClass62.smethod_28(GClass109.string_419);
            break;
          }
          GClass118.smethod_2().vmethod_0();
          break;
        }
      case 5:
        this.method_31();
        break;
    }
  }

  private void method_199() => this.method_66();

  public void method_200()
  {
    this.type = Class15.smethod_0(46);
    this.method_5(Class15.smethod_0(0));
    this.method_201();
    this.currentTabIndex = Class15.smethod_0(0);
  }

  private void method_201()
  {
    this.ITEM_HEIGHT = Class15.smethod_0(40);
    this.currentListLength = GClass20.smethod_1().infoSpeacialSkill[this.currentTabIndex].Length;
    this.cmyLim = this.currentListLength * this.ITEM_HEIGHT - this.hScroll;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    this.cmy = this.cmtoY = this.cmyLast[this.currentTabIndex];
    if (this.cmy < Class15.smethod_0(0))
      this.cmy = this.cmtoY = Class15.smethod_0(0);
    if (this.cmy > this.cmyLim)
      this.cmy = this.cmtoY = this.cmyLim;
    this.selected = (!GClass62.bool_5 ? 0 : 1) != 0 ? -1 : Class15.smethod_0(0);
  }

  public bool method_202() => this.type == Class15.smethod_0(1) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  private void method_203(int int_105)
  {
    try
    {
      this.currItem.buyRuby = int.Parse(this.chatTField.tfChat.method_21());
    }
    catch (Exception ex)
    {
      GClass62.smethod_28(GClass109.string_323);
      this.chatTField.isShow = Class15.smethod_0(0) != 0;
      return;
    }
    GClass31 cmdYes = new GClass31(GClass109.string_135, (GInterface0) this, (int_105 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(343) : Class15.smethod_0(342), (object) null);
    GClass31 cmdNo = new GClass31(GClass109.string_136, (GInterface0) this, Class15.smethod_0(549), (object) null);
    GClass62.smethod_34(GClass109.string_2, cmdYes, cmdNo);
  }

  public static void smethod_1(
    int x,
    int y,
    int wItem,
    int hItem,
    int nline,
    int cl,
    GClass98 g)
  {
    try
    {
      int num = ((wItem << Class15.smethod_0(1)) + (hItem << Class15.smethod_0(1))) / nline;
      GClass141.int_94 = GClass141.int_93.Length;
      if (nline > Class15.smethod_0(2))
        GClass141.int_94 = Class15.smethod_0(7);
      for (int index1 = Class15.smethod_0(0); index1 < nline; index1 += Class15.smethod_0(1))
      {
        for (int index2 = Class15.smethod_0(0); index2 < GClass141.int_94; index2 += Class15.smethod_0(1))
        {
          int int_109 = GClass141.int_93[index2] <= Class15.smethod_0(1) ? Class15.smethod_0(1) : (GClass141.int_93[index2] >> Class15.smethod_0(1)) + Class15.smethod_0(1);
          int x1 = x + GClass141.smethod_2(num * index1, GClass62.int_8 - index2 * Class15.smethod_0(2), wItem, hItem, int_109);
          int y1 = y + GClass141.smethod_3(num * index1, GClass62.int_8 - index2 * Class15.smethod_0(2), wItem, hItem, int_109);
          g.method_16(GClass141.int_95[cl][index2]);
          g.method_15(x1, y1, GClass141.int_93[index2], GClass141.int_93[index2]);
        }
      }
    }
    catch (Exception ex)
    {
    }
  }

  private static int smethod_2(int int_105, int int_106, int int_107, int int_108, int int_109)
  {
    int num = (int_106 + int_105) % ((int_107 << Class15.smethod_0(1)) + (int_108 << Class15.smethod_0(1)));
    if (Class15.smethod_0(0) <= num && num < int_107)
      return num % int_107;
    if (int_107 <= num && num < int_107 + int_108)
      return int_107 - int_109;
    return int_107 + int_108 <= num && num < (int_107 << Class15.smethod_0(1)) + int_108 ? int_107 - (num - int_108) % int_107 - int_109 : Class15.smethod_0(0);
  }

  private static int smethod_3(int int_105, int int_106, int int_107, int int_108, int int_109)
  {
    int num = (int_106 + int_105) % ((int_107 << Class15.smethod_0(1)) + (int_108 << Class15.smethod_0(1)));
    if (Class15.smethod_0(0) <= num && num < int_107)
      return Class15.smethod_0(0);
    if (int_107 <= num && num < int_107 + int_108)
      return num % int_107;
    return int_107 + int_108 <= num && num < (int_107 << Class15.smethod_0(1)) + int_108 ? int_108 - int_109 : int_108 - (num - (int_107 << Class15.smethod_0(1))) % int_108 - int_109;
  }

  public static int smethod_4(int id)
  {
    int num;
    switch (id - Class15.smethod_0(1))
    {
      case 0:
        num = Class15.smethod_0(551);
        break;
      case 1:
        num = Class15.smethod_0(554);
        break;
      case 2:
        num = Class15.smethod_0(553);
        break;
      case 3:
        num = Class15.smethod_0(550);
        break;
      case 4:
        num = Class15.smethod_0(552);
        break;
      case 5:
        num = Class15.smethod_0(555);
        break;
      default:
        num = -1;
        break;
    }
    return num;
  }

  public static sbyte smethod_5(int lv)
  {
    if (lv < Class15.smethod_0(0))
      return (sbyte) Class15.smethod_0(0);
    switch (lv)
    {
      case 0:
      case 1:
      case 2:
      case 3:
      case 4:
      case 5:
      case 6:
      case 7:
      case 8:
        return (sbyte) Class15.smethod_0(0);
      case 9:
        return (sbyte) Class15.smethod_0(2);
      case 10:
        return (sbyte) Class15.smethod_0(1);
      case 11:
        return (sbyte) Class15.smethod_0(3);
      case 12:
        return (sbyte) Class15.smethod_0(5);
      case 13:
        return (sbyte) Class15.smethod_0(7);
      default:
        return (sbyte) Class15.smethod_0(37);
    }
  }

  public static GClass97 smethod_6(int color)
  {
    GClass97 gclass97 = GClass97.gclass97_11;
    switch (color)
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
    return gclass97;
  }

  public void method_204(GClass98 g, int idOpt, int param, int x, int y, int w, int h)
  {
    switch (idOpt - Class15.smethod_0(117))
    {
      case 0:
        if ((this.gclass66_13 == null ? 1 : 0) == 0)
          g.method_34(this.gclass66_13, x, y + h - this.gclass66_13.method_1());
        else
          this.gclass66_13 = GClass126.smethod_35(Class13.smethod_0(179329));
        if ((this.gclass66_14 == null ? 1 : 0) == 0)
        {
          g.method_34(this.gclass66_14, x, y + h - this.gclass66_14.method_1());
          break;
        }
        this.gclass66_14 = GClass126.smethod_35(Class13.smethod_0(179419));
        break;
      case 1:
        if ((this.gclass66_13 == null ? 1 : 0) == 0)
          g.method_34(this.gclass66_13, x, y + h - this.gclass66_13.method_1());
        else
          this.gclass66_13 = GClass126.smethod_35(Class13.smethod_0(179329));
        if ((this.gclass66_15 == null ? 1 : 0) == 0)
        {
          g.method_34(this.gclass66_15, x, y + h - this.gclass66_15.method_1());
          break;
        }
        this.gclass66_15 = GClass126.smethod_35(Class13.smethod_0(179400));
        break;
      case 2:
        if ((this.gclass66_13 == null ? 1 : 0) == 0)
          g.method_34(this.gclass66_13, x, y + h - this.gclass66_13.method_1());
        else
          this.gclass66_13 = GClass126.smethod_35(Class13.smethod_0(179329));
        if ((this.gclass66_16 == null ? 1 : 0) == 0)
        {
          g.method_34(this.gclass66_16, x, y + h - this.gclass66_16.method_1());
          break;
        }
        this.gclass66_16 = GClass126.smethod_35(Class13.smethod_0(180021));
        break;
    }
  }

  public void method_205(GClass98 g, int idOpt, int param, int x, int y, int w, int h)
  {
    if (idOpt != Class15.smethod_0(68) || param <= GClass43.int_2)
      return;
    sbyte cl = GClass141.smethod_5(param);
    int nline = param - GClass43.int_2;
    GClass141.smethod_1(x, y, w, h, nline, (int) cl, g);
  }

  public static GClass97 smethod_7(int id, int type)
  {
    if ((type == 0 ? 0 : 1) == 0)
    {
      GClass97 gclass97;
      switch (id)
      {
        case 0:
          gclass97 = GClass97.gclass97_28;
          break;
        case 1:
          gclass97 = GClass97.gclass97_30;
          break;
        case 3:
          gclass97 = GClass97.gclass97_31;
          break;
        case 4:
          gclass97 = GClass97.gclass97_32;
          break;
        case 5:
          gclass97 = GClass97.gclass97_29;
          break;
        case 6:
          gclass97 = GClass97.gclass97_27;
          break;
        default:
          gclass97 = GClass97.gclass97_28;
          break;
      }
      return gclass97;
    }
    GClass97 gclass97_1;
    switch (id)
    {
      case 0:
        gclass97_1 = GClass97.gclass97_3;
        break;
      case 1:
        gclass97_1 = GClass97.gclass97_8;
        break;
      case 3:
        gclass97_1 = GClass97.gclass97_38;
        break;
      case 4:
        gclass97_1 = GClass97.gclass97_2;
        break;
      case 5:
        gclass97_1 = GClass97.gclass97_4;
        break;
      case 6:
        gclass97_1 = GClass97.gclass97_1;
        break;
      case 7:
        gclass97_1 = GClass97.gclass97_6;
        break;
      default:
        gclass97_1 = GClass97.gclass97_3;
        break;
    }
    return gclass97_1;
  }

  private bool method_206() => (this.type == 0 ? 0 : 1) == 0 && this.currentTabIndex == Class15.smethod_0(1) || this.type == Class15.smethod_0(38) && (this.currentTabIndex == 0 ? 0 : 1) == 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  private void method_207()
  {
    if (this.selected < Class15.smethod_0(0))
      return;
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(2) : Class15.smethod_0(29)] ? 1 : 0) == 0)
    {
      this.int_24 -= Class15.smethod_0(1);
      if (this.int_24 >= Class15.smethod_0(0))
        return;
      this.int_24 = Class15.smethod_0(0);
      if ((!GClass62.bool_22 ? 1 : 0) != 0)
        return;
      GClass62.bool_22 = Class15.smethod_0(0) != 0;
      GClass62.gclass141_0.selected = Class15.smethod_0(0);
    }
    else
    {
      if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(37) : Class15.smethod_0(40)] ? 0 : 1) == 0)
        return;
      this.int_24 += Class15.smethod_0(1);
      if (this.int_24 <= (int) this.size_tab - Class15.smethod_0(1))
        return;
      this.int_24 = (int) this.size_tab - Class15.smethod_0(1);
      if ((GClass62.gclass141_1 == null ? 1 : 0) != 0)
        return;
      GClass62.bool_22 = Class15.smethod_0(1) != 0;
      GClass62.gclass141_1.selected = Class15.smethod_0(0);
    }
  }

  private void method_208()
  {
    this.method_66();
    if ((this.selected == 0 ? 0 : 1) != 0)
      return;
    this.method_207();
  }

  private bool method_209()
  {
    if ((int) this.size_tab > Class15.smethod_0(0))
    {
      if (this.currentTabName.Length > Class15.smethod_0(1))
      {
        if ((this.selected == 0 ? 0 : 1) == 0)
          return Class15.smethod_0(1) != 0;
      }
      else if (this.selected >= Class15.smethod_0(0))
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  static GClass141()
  {
    string[] strArray1 = new string[Class15.smethod_0(38)];
    strArray1[Class15.smethod_0(0)] = GClass109.string_177;
    strArray1[Class15.smethod_0(1)] = GClass109.string_176;
    strArray1[Class15.smethod_0(7)] = GClass109.string_93;
    strArray1[Class15.smethod_0(5)] = GClass109.string_175;
    strArray1[Class15.smethod_0(2)] = GClass109.string_72;
    strArray1[Class15.smethod_0(3)] = GClass109.string_179;
    strArray1[Class15.smethod_0(37)] = GClass109.string_46;
    GClass141.string_1 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(2)];
    strArray2[Class15.smethod_0(0)] = (!GClass62.bool_21 ? 1 : 0) != 0 ? GClass109.string_33 : GClass109.string_34;
    strArray2[Class15.smethod_0(1)] = GClass109.string_183;
    strArray2[Class15.smethod_0(7)] = GClass109.string_28;
    strArray2[Class15.smethod_0(5)] = GClass98.int_8 <= Class15.smethod_0(1) ? GClass109.string_187 : GClass109.string_188;
    GClass141.string_2 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(3)];
    strArray3[Class15.smethod_0(0)] = GClass109.string_29;
    strArray3[Class15.smethod_0(1)] = GClass109.string_172;
    strArray3[Class15.smethod_0(7)] = GClass109.string_173;
    strArray3[Class15.smethod_0(5)] = GClass109.string_60;
    strArray3[Class15.smethod_0(2)] = GClass109.string_418;
    GClass141.string_3 = strArray3;
    string[] strArray4 = new string[Class15.smethod_0(1)];
    strArray4[Class15.smethod_0(0)] = GClass109.string_11;
    GClass141.string_4 = strArray4;
    GClass141.int_5 = Class15.smethod_0(0);
    string[][] strArray5 = new string[Class15.smethod_0(7)][];
    strArray5[Class15.smethod_0(0)] = GClass109.string_197;
    strArray5[Class15.smethod_0(1)] = GClass109.string_198;
    GClass141.string_5 = strArray5;
    string[][] strArray6 = new string[Class15.smethod_0(7)][];
    strArray6[Class15.smethod_0(0)] = GClass109.string_199;
    strArray6[Class15.smethod_0(1)] = GClass109.string_198;
    GClass141.string_6 = strArray6;
    string[][] strArray7 = new string[Class15.smethod_0(1)][];
    strArray7[Class15.smethod_0(0)] = GClass109.string_203;
    GClass141.string_7 = strArray7;
    string[][] strArray8 = new string[Class15.smethod_0(1)][];
    strArray8[Class15.smethod_0(0)] = GClass109.string_200;
    GClass141.string_8 = strArray8;
    string[][] strArray9 = new string[Class15.smethod_0(5)][];
    strArray9[Class15.smethod_0(0)] = GClass109.string_198;
    strArray9[Class15.smethod_0(1)] = GClass109.string_201;
    strArray9[Class15.smethod_0(7)] = GClass109.string_202;
    GClass141.string_9 = strArray9;
    GClass141.string_10 = GClass109.string_104;
    GClass141.sbyte_0 = (sbyte) Class15.smethod_0(0);
    GClass141.sbyte_1 = (sbyte) Class15.smethod_0(1);
    GClass141.sbyte_2 = (sbyte) Class15.smethod_0(7);
    GClass141.sbyte_3 = (sbyte) Class15.smethod_0(5);
    GClass141.sbyte_4 = (sbyte) Class15.smethod_0(2);
    GClass141.sbyte_5 = (sbyte) Class15.smethod_0(3);
    GClass141.sbyte_6 = (sbyte) Class15.smethod_0(37);
    GClass141.sbyte_7 = (sbyte) Class15.smethod_0(38);
    byte[] byte_0_1 = new byte[Class15.smethod_0(64)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.ePczGuMEuENV));
    GClass141.int_7 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(87)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.XhqcsiuGgNPQ));
    GClass141.int_8 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(444)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.OidkQjJdAzKH));
    GClass141.int_9 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(121)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.GjqJdXfFJXIW));
    GClass141.int_10 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(150)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.tYqfdNkYRhNR));
    GClass141.int_11 = (int[]) Class15.smethod_4(byte_0_5);
    byte[] byte_0_6 = new byte[Class15.smethod_0(150)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.hdNqWpvaDiNU));
    GClass141.int_12 = (int[]) Class15.smethod_4(byte_0_6);
    byte[] byte_0_7 = new byte[Class15.smethod_0(121)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.CoJoiUvpXYbP));
    GClass141.int_13 = (int[]) Class15.smethod_4(byte_0_7);
    byte[] byte_0_8 = new byte[Class15.smethod_0(87)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.XURFyFmqogiw));
    GClass141.int_14 = (int[]) Class15.smethod_4(byte_0_8);
    byte[] byte_0_9 = new byte[Class15.smethod_0(101)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.XnjEIUNnHAop));
    GClass141.int_15 = (int[]) Class15.smethod_4(byte_0_9);
    int[][] numArray1 = new int[Class15.smethod_0(5)][];
    numArray1[Class15.smethod_0(0)] = GClass141.int_7;
    numArray1[Class15.smethod_0(1)] = GClass141.int_10;
    numArray1[Class15.smethod_0(7)] = GClass141.int_13;
    GClass141.int_16 = numArray1;
    int[][] numArray2 = new int[Class15.smethod_0(5)][];
    numArray2[Class15.smethod_0(0)] = GClass141.int_8;
    numArray2[Class15.smethod_0(1)] = GClass141.int_11;
    numArray2[Class15.smethod_0(7)] = GClass141.int_14;
    GClass141.int_17 = numArray2;
    int[][] numArray3 = new int[Class15.smethod_0(5)][];
    numArray3[Class15.smethod_0(0)] = GClass141.int_9;
    numArray3[Class15.smethod_0(1)] = GClass141.int_12;
    numArray3[Class15.smethod_0(7)] = GClass141.int_15;
    GClass141.int_18 = numArray3;
    GClass141.bool_1 = Class15.smethod_0(0) != 0;
    GClass141.int_19 = Class15.smethod_0(194);
    byte[] byte_0_10 = new byte[Class15.smethod_0(195)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.XKduLxngqeHZ));
    GClass141.long_0 = (long[]) Class15.smethod_4(byte_0_10);
    byte[] byte_0_11 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.KtvkhNqeYIZM));
    GClass141.int_65 = (int[]) Class15.smethod_4(byte_0_11);
    byte[] byte_0_12 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_12, __fieldref (Class12.gQtfUzbAGbdx));
    GClass141.int_66 = (int[]) Class15.smethod_4(byte_0_12);
    GClass141.string_12 = string.Empty;
    GClass141.bool_11 = Class15.smethod_0(1) != 0;
    GClass141.gclass134_0 = new GClass134(string.Empty);
    byte[] byte_0_13 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_13, __fieldref (Class12.aOkstbWsFqIH));
    GClass141.int_93 = (int[]) Class15.smethod_4(byte_0_13);
    GClass141.int_94 = Class15.smethod_0(1);
    int[][] numArray4 = new int[Class15.smethod_0(38)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_14 = new byte[Class15.smethod_0(39)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_14, __fieldref (Class12.ZexWgbFCcrfW));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_14);
    numArray4[index1] = numArray5;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_15 = new byte[Class15.smethod_0(25)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_15, __fieldref (Class12.bbpsrPamRkQE));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_15);
    numArray4[index2] = numArray6;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_16 = new byte[Class15.smethod_0(121)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_16, __fieldref (Class12.GTdcjoRLvPUL));
    int[] numArray7 = (int[]) Class15.smethod_4(byte_0_16);
    numArray4[index3] = numArray7;
    int index4 = Class15.smethod_0(5);
    byte[] byte_0_17 = new byte[Class15.smethod_0(119)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_17, __fieldref (Class12.sMOHmJOFqAuG));
    int[] numArray8 = (int[]) Class15.smethod_4(byte_0_17);
    numArray4[index4] = numArray8;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_18 = new byte[Class15.smethod_0(118)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_18, __fieldref (Class12.PVYogvSVfqTz));
    int[] numArray9 = (int[]) Class15.smethod_4(byte_0_18);
    numArray4[index5] = numArray9;
    int index6 = Class15.smethod_0(3);
    byte[] byte_0_19 = new byte[Class15.smethod_0(119)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_19, __fieldref (Class12.xSuJpvNqqVoO));
    int[] numArray10 = (int[]) Class15.smethod_4(byte_0_19);
    numArray4[index6] = numArray10;
    int index7 = Class15.smethod_0(37);
    byte[] byte_0_20 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_20, __fieldref (Class12.JATsFMaCzVcH));
    int[] numArray11 = (int[]) Class15.smethod_4(byte_0_20);
    numArray4[index7] = numArray11;
    GClass141.int_95 = numArray4;
  }
}
