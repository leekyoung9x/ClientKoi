// Decompiled with JetBrains decompiler
// Type: GClass172
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass172
{
  public static bool bool_0;
  public static GClass172 gclass172_0;
  public static bool bool_1 = Class15.smethod_0(1) != 0;
  public static float float_0 = Class15.smethod_2(7);
  private static int int_0 = Class15.smethod_0(31);
  public static GClass172.GClass173[] gclass173_0;
  public static GClass172.GClass174[] gclass174_0;
  public static int[] int_1;
  public static int int_2;
  public static int int_3 = Class15.smethod_0(1);
  public static int int_4 = Class15.smethod_0(7);
  public static int int_5;
  public static int int_6 = Class15.smethod_0(1);
  public static int int_7 = Class15.smethod_0(7);
  public static int int_8 = Class15.smethod_0(5);
  public static int int_9 = Class15.smethod_0(2);
  public static int int_10 = Class15.smethod_0(3);
  public static int int_11 = Class15.smethod_0(37);
  public static int int_12 = Class15.smethod_0(38);
  public static int int_13 = Class15.smethod_0(88);
  public static int int_14 = Class15.smethod_0(45);
  public static int int_15 = Class15.smethod_0(31);
  public static int int_16 = Class15.smethod_0(67);
  public static int int_17 = Class15.smethod_0(66);
  public static int int_18 = Class15.smethod_0(47);
  public static int int_19 = Class15.smethod_0(49);
  public static int int_20 = Class15.smethod_0(9);
  public static int int_21 = Class15.smethod_0(10);
  public static int int_22 = Class15.smethod_0(186);
  public static int int_23 = Class15.smethod_0(124);
  public static int int_24 = Class15.smethod_0(65);
  public static int int_25 = Class15.smethod_0(51);
  public static int int_26 = Class15.smethod_0(27);
  public static int int_27 = Class15.smethod_0(28);
  public static int int_28 = Class15.smethod_0(29);
  public static int int_29 = Class15.smethod_0(40);
  public static int int_30 = Class15.smethod_0(46);
  public static int int_31 = Class15.smethod_0(50);
  public static int int_32 = Class15.smethod_0(33);
  public static int int_33 = Class15.smethod_0(35);
  public static int int_34 = Class15.smethod_0(36);
  public static int int_35 = Class15.smethod_0(6);
  public bool freePool;
  public int poolCount;
  public static int int_36 = Class15.smethod_0(1);

  public static void smethod_0(GClass172.GClass175 ac) => GClass171.smethod_0(ac);

  public static GClass172 smethod_1()
  {
    if ((GClass172.gclass172_0 == null ? 0 : 1) == 0)
      GClass172.gclass172_0 = new GClass172();
    return GClass172.gclass172_0;
  }

  public void method_0(int mapID)
  {
    int[] musicID = new int[Class15.smethod_0(5)];
    musicID[Class15.smethod_0(0)] = GClass172.int_2;
    musicID[Class15.smethod_0(1)] = GClass172.int_3;
    musicID[Class15.smethod_0(7)] = GClass172.int_4;
    int[] sID = new int[Class15.smethod_0(8)];
    sID[Class15.smethod_0(0)] = GClass172.int_5;
    sID[Class15.smethod_0(1)] = GClass172.int_6;
    sID[Class15.smethod_0(7)] = GClass172.int_7;
    sID[Class15.smethod_0(5)] = GClass172.int_8;
    sID[Class15.smethod_0(2)] = GClass172.int_9;
    sID[Class15.smethod_0(3)] = GClass172.int_10;
    sID[Class15.smethod_0(37)] = GClass172.int_11;
    sID[Class15.smethod_0(38)] = GClass172.int_12;
    sID[Class15.smethod_0(88)] = GClass172.int_13;
    sID[Class15.smethod_0(45)] = GClass172.int_14;
    sID[Class15.smethod_0(31)] = GClass172.int_15;
    sID[Class15.smethod_0(67)] = GClass172.int_11;
    sID[Class15.smethod_0(66)] = GClass172.int_17;
    sID[Class15.smethod_0(47)] = GClass172.int_18;
    sID[Class15.smethod_0(49)] = GClass172.int_19;
    sID[Class15.smethod_0(9)] = GClass172.int_20;
    sID[Class15.smethod_0(10)] = GClass172.int_21;
    sID[Class15.smethod_0(186)] = GClass172.int_22;
    sID[Class15.smethod_0(124)] = GClass172.int_23;
    sID[Class15.smethod_0(65)] = GClass172.int_24;
    sID[Class15.smethod_0(51)] = GClass172.int_25;
    sID[Class15.smethod_0(27)] = GClass172.int_26;
    sID[Class15.smethod_0(28)] = GClass172.int_27;
    sID[Class15.smethod_0(29)] = GClass172.int_28;
    sID[Class15.smethod_0(40)] = GClass172.int_29;
    sID[Class15.smethod_0(46)] = GClass172.int_30;
    sID[Class15.smethod_0(50)] = GClass172.int_31;
    sID[Class15.smethod_0(33)] = GClass172.int_32;
    sID[Class15.smethod_0(35)] = GClass172.int_33;
    sID[Class15.smethod_0(36)] = GClass172.int_34;
    sID[Class15.smethod_0(6)] = GClass172.int_35;
    GClass171.smethod_4(musicID, sID);
  }

  public void method_1()
  {
    if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) == 0 && (GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().taskMaint.taskId >= Class15.smethod_0(7))
    {
      string[] strArray1 = new string[Class15.smethod_0(31)];
      strArray1[Class15.smethod_0(0)] = GClass109.string_5;
      strArray1[Class15.smethod_0(1)] = GClass109.string_178;
      strArray1[Class15.smethod_0(7)] = GClass109.string_177;
      strArray1[Class15.smethod_0(5)] = GClass109.string_176;
      strArray1[Class15.smethod_0(2)] = GClass109.string_93;
      strArray1[Class15.smethod_0(3)] = GClass109.string_175;
      strArray1[Class15.smethod_0(37)] = GClass109.string_72;
      strArray1[Class15.smethod_0(38)] = GClass109.string_179;
      strArray1[Class15.smethod_0(88)] = GClass109.string_46;
      strArray1[Class15.smethod_0(45)] = GClass109.string_32;
      GClass141.string_1 = strArray1;
      if ((!GClass20.smethod_1().havePet ? 1 : 0) == 0)
      {
        string[] strArray2 = new string[Class15.smethod_0(67)];
        strArray2[Class15.smethod_0(0)] = GClass109.string_5;
        strArray2[Class15.smethod_0(1)] = GClass109.string_178;
        strArray2[Class15.smethod_0(7)] = GClass109.string_177;
        strArray2[Class15.smethod_0(5)] = GClass109.string_19;
        strArray2[Class15.smethod_0(2)] = GClass109.string_176;
        strArray2[Class15.smethod_0(3)] = GClass109.string_93;
        strArray2[Class15.smethod_0(37)] = GClass109.string_175;
        strArray2[Class15.smethod_0(38)] = GClass109.string_72;
        strArray2[Class15.smethod_0(88)] = GClass109.string_179;
        strArray2[Class15.smethod_0(45)] = GClass109.string_46;
        strArray2[Class15.smethod_0(31)] = GClass109.string_32;
        GClass141.string_1 = strArray2;
      }
    }
    else
    {
      string[] strArray3 = new string[Class15.smethod_0(45)];
      strArray3[Class15.smethod_0(0)] = GClass109.string_5;
      strArray3[Class15.smethod_0(1)] = GClass109.string_178;
      strArray3[Class15.smethod_0(7)] = GClass109.string_177;
      strArray3[Class15.smethod_0(5)] = GClass109.string_176;
      strArray3[Class15.smethod_0(2)] = GClass109.string_93;
      strArray3[Class15.smethod_0(3)] = GClass109.string_175;
      strArray3[Class15.smethod_0(37)] = GClass109.string_72;
      strArray3[Class15.smethod_0(38)] = GClass109.string_179;
      strArray3[Class15.smethod_0(88)] = GClass109.string_46;
      GClass141.string_1 = strArray3;
      if ((!GClass20.smethod_1().havePet ? 1 : 0) == 0)
      {
        string[] strArray4 = new string[Class15.smethod_0(31)];
        strArray4[Class15.smethod_0(0)] = GClass109.string_5;
        strArray4[Class15.smethod_0(1)] = GClass109.string_178;
        strArray4[Class15.smethod_0(7)] = GClass109.string_177;
        strArray4[Class15.smethod_0(5)] = GClass109.string_19;
        strArray4[Class15.smethod_0(2)] = GClass109.string_176;
        strArray4[Class15.smethod_0(3)] = GClass109.string_93;
        strArray4[Class15.smethod_0(37)] = GClass109.string_175;
        strArray4[Class15.smethod_0(38)] = GClass109.string_72;
        strArray4[Class15.smethod_0(88)] = GClass109.string_179;
        strArray4[Class15.smethod_0(45)] = GClass109.string_46;
        GClass141.string_1 = strArray4;
      }
    }
    if ((!GClass172.bool_0 ? 1 : 0) != 0)
      return;
    string[] strArray = new string[GClass141.string_1.Length + Class15.smethod_0(1)];
    for (int index = Class15.smethod_0(0); index < GClass141.string_1.Length; index += Class15.smethod_0(1))
      strArray[index] = GClass141.string_1[index];
    strArray[GClass141.string_1.Length] = GClass109.string_0;
    GClass141.string_1 = strArray;
  }

  public void method_2()
  {
    string str1 = Class13.smethod_0(151251);
    string str2 = Class13.smethod_0(143669);
    if ((!Main.bool_3 ? 1 : 0) == 0)
    {
      string[] strArray = new string[Class15.smethod_0(2)];
      strArray[Class15.smethod_0(0)] = (!GClass20.bool_18 ? 1 : 0) != 0 ? str2 + GClass109.string_190.Trim() : str1 + GClass109.string_190.Trim();
      strArray[Class15.smethod_0(1)] = (!GClass20.bool_19 ? 1 : 0) != 0 ? str2 + GClass109.string_192.Trim() : str1 + GClass109.string_192.Trim();
      strArray[Class15.smethod_0(7)] = (!GClass62.bool_21 ? 1 : 0) != 0 ? str2 + GClass109.string_34.Trim() : str1 + GClass109.string_34.Trim();
      strArray[Class15.smethod_0(5)] = GClass98.int_8 <= Class15.smethod_0(1) ? str2 + GClass109.string_187 : str1 + GClass109.string_188;
      GClass141.string_2 = strArray;
    }
    else
    {
      string str3 = (GClass116.int_62 == 0 ? 0 : 1) != 0 ? str1 + GClass109.string_27 : str2 + GClass109.string_26;
      if ((!GClass62.bool_5 ? 0 : 1) == 0)
        str3 = (!GClass116.bool_64 ? 0 : 1) != 0 ? str1 + GClass109.string_185 : str2 + GClass109.string_185;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = (!GClass20.bool_18 ? 1 : 0) != 0 ? str2 + GClass109.string_190.Trim() : str1 + GClass109.string_190.Trim();
      strArray[Class15.smethod_0(1)] = (!GClass20.bool_19 ? 1 : 0) != 0 ? str2 + GClass109.string_192.Trim() : str1 + GClass109.string_192.Trim();
      strArray[Class15.smethod_0(7)] = (!GClass62.bool_21 ? 1 : 0) != 0 ? str2 + GClass109.string_34.Trim() : str1 + GClass109.string_34.Trim();
      strArray[Class15.smethod_0(5)] = (!GClass62.bool_1 ? 1 : 0) != 0 ? str2 + GClass109.string_21.Trim() : str1 + GClass109.string_21.Trim();
      strArray[Class15.smethod_0(2)] = str3;
      GClass141.string_2 = strArray;
    }
  }

  public void method_3() => GClass171.smethod_5(GClass172.int_25, Class15.smethod_2(7));

  public void method_4(bool isKick, float volumn)
  {
    if ((!GClass20.smethod_1().me ? 0 : 1) == 0)
      GClass172.float_0 /= Class15.smethod_2(17);
    if ((double) volumn <= (double) Class15.smethod_2(0))
      volumn = Class15.smethod_2(32);
    int num = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
    if ((!isKick ? 1 : 0) == 0)
      GClass171.smethod_5((num == 0 ? 0 : 1) != 0 ? GClass172.int_15 : GClass172.int_8, Class15.smethod_2(12));
    else
      GClass171.smethod_5((num == 0 ? 0 : 1) != 0 ? GClass172.int_14 : GClass172.int_7, Class15.smethod_2(12));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_5()
  {
    GClass171.smethod_5(GClass172.int_26, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_6() => GClass171.smethod_19(GClass172.int_3, Class15.smethod_2(10), Class15.smethod_0(1) != 0);

  public void method_7()
  {
    GClass171.smethod_5(GClass172.int_32, Class15.smethod_2(10));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_8()
  {
    GClass171.smethod_5(GClass172.int_28, Class15.smethod_2(13));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_9()
  {
    GClass171.smethod_5(GClass172.int_5, Class15.smethod_2(10));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_10()
  {
    GClass62.bool_21 = (GClass62.bool_21 ? 1 : 0) == Class15.smethod_0(0);
    if ((!GClass62.bool_21 ? 1 : 0) == 0)
    {
      GClass172.smethod_1().method_0(GClass185.int_37);
      GClass152.smethod_9(Class13.smethod_0(143691), Class15.smethod_0(1));
    }
    else
    {
      GClass172.smethod_1().method_19();
      GClass152.smethod_9(Class13.smethod_0(143691), Class15.smethod_0(0));
    }
    this.method_2();
  }

  public void method_11()
  {
    GClass116.bool_64 = (GClass116.bool_64 ? 1 : 0) == Class15.smethod_0(0);
    if ((!GClass116.bool_64 ? 1 : 0) == 0)
      GClass152.smethod_9(Class13.smethod_0(143787), Class15.smethod_0(0));
    else
      GClass152.smethod_9(Class13.smethod_0(143787), Class15.smethod_0(1));
    this.method_2();
  }

  public void method_12()
  {
    if ((GClass116.int_62 == 0 ? 0 : 1) == 0)
    {
      GClass116.int_62 = Class15.smethod_0(1);
      GClass152.smethod_9(Class13.smethod_0(144332), GClass116.int_62);
      GClass116.smethod_9();
    }
    else
    {
      GClass116.int_62 = Class15.smethod_0(0);
      GClass152.smethod_9(Class13.smethod_0(144332), GClass116.int_62);
      GClass116.smethod_9();
    }
    this.method_2();
  }

  public void method_13()
  {
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
      this.method_11();
    else
      this.method_12();
  }

  public void method_14()
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
    {
      GClass152.smethod_9(Class13.smethod_0(144320), Class15.smethod_0(0));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    else
    {
      GClass152.smethod_9(Class13.smethod_0(144320), Class15.smethod_0(1));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    this.method_2();
  }

  public void method_15()
  {
    if ((!GClass20.bool_18 ? 1 : 0) == 0)
    {
      GClass152.smethod_9(Class13.smethod_0(143918), Class15.smethod_0(0));
      GClass20.bool_18 = Class15.smethod_0(0) != 0;
    }
    else
    {
      GClass152.smethod_9(Class13.smethod_0(143918), Class15.smethod_0(1));
      GClass20.bool_18 = Class15.smethod_0(1) != 0;
    }
    this.method_2();
  }

  public void method_16()
  {
    if ((!GClass20.bool_19 ? 1 : 0) == 0)
    {
      GClass152.smethod_9(Class13.smethod_0(143884), Class15.smethod_0(0));
      GClass20.bool_19 = Class15.smethod_0(0) != 0;
    }
    else
    {
      GClass152.smethod_9(Class13.smethod_0(143884), Class15.smethod_0(1));
      GClass20.bool_19 = Class15.smethod_0(1) != 0;
    }
    this.method_2();
  }

  public void method_17() => GClass156.smethod_0().method_147();

  public void method_18()
  {
  }

  public void method_19()
  {
    GClass171.bool_2 = Class15.smethod_0(1) != 0;
    this.method_51();
  }

  public void method_20()
  {
    if ((GClass171.audioClip_0 == null ? 0 : 1) == 0)
      this.method_0(Class15.smethod_0(0));
    GClass171.bool_2 = Class15.smethod_0(0) != 0;
  }

  public void method_21()
  {
    GClass171.smethod_5(GClass172.int_30, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_22()
  {
    GClass171.smethod_5(GClass172.int_22, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_23()
  {
    GClass171.smethod_5(GClass172.int_22, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_24()
  {
    GClass171.smethod_5(GClass172.int_24, Class15.smethod_2(16));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_25()
  {
    GClass171.smethod_5(GClass172.int_20, Class15.smethod_2(10));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_26()
  {
    GClass171.smethod_5(GClass172.int_31, Class15.smethod_2(10));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_27()
  {
    GClass171.smethod_5(GClass172.int_21, Class15.smethod_2(10));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_28(int type)
  {
    int id = GClass172.int_21;
    if (type == Class15.smethod_0(47))
      id = GClass172.int_19;
    GClass171.smethod_5(id, Class15.smethod_2(12));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_29(float volumn)
  {
    if ((!GClass20.smethod_1().me ? 0 : 1) == 0)
    {
      GClass172.float_0 /= Class15.smethod_2(17);
      if ((double) volumn <= (double) Class15.smethod_2(0))
        volumn = Class15.smethod_2(32);
    }
    if ((GClass62.int_8 % Class15.smethod_0(88) == 0 ? 0 : 1) != 0)
      return;
    GClass171.smethod_5(GClass172.int_6, volumn);
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_30(float volumn)
  {
    if ((GClass62.int_8 % Class15.smethod_0(88) == 0 ? 0 : 1) != 0)
      return;
    GClass171.smethod_5(GClass172.int_29, Class15.smethod_2(13));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_31()
  {
    GClass171.smethod_5(GClass172.int_6, Class15.smethod_2(12));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_32()
  {
    GClass171.smethod_5(GClass172.int_6, Class15.smethod_2(13));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_33()
  {
    GClass171.smethod_5(GClass172.int_11, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_34()
  {
    GClass171.smethod_5(GClass172.int_12, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_35()
  {
    GClass171.smethod_5(GClass172.int_13, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_36()
  {
  }

  public void method_37()
  {
    GClass171.smethod_5(GClass172.int_9, Class15.smethod_2(13));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_38()
  {
  }

  public void method_39()
  {
    GClass171.smethod_5(GClass172.int_12, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_40()
  {
    GClass171.smethod_5(GClass172.int_16, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_41()
  {
    GClass171.smethod_5(GClass172.int_17, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_42() => GClass171.smethod_5(GClass172.int_18, Class15.smethod_2(7));

  public void method_43()
  {
    GClass171.smethod_5(GClass172.int_27, Class15.smethod_2(7));
    this.poolCount += Class15.smethod_0(1);
  }

  public void method_44() => GClass171.smethod_19(GClass172.int_4, Class15.smethod_2(7), Class15.smethod_0(1) != 0);

  public void method_45()
  {
  }

  public bool method_46()
  {
    try
    {
      return GClass171.smethod_15();
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(0) != 0;
    }
  }

  public bool method_47() => Class15.smethod_0(0) != 0;

  public void method_48()
  {
    GClass172.int_36 += Class15.smethod_0(1);
    if ((GClass172.int_36 % Class15.smethod_0(7) == 0 ? 0 : 1) != 0)
      return;
    GClass171.smethod_19(GClass172.int_2, Class15.smethod_2(10), Class15.smethod_0(0) != 0);
  }

  public void method_49()
  {
  }

  public void method_50()
  {
  }

  public void method_51() => GClass171.smethod_8();

  public void method_52()
  {
    GClass157.smethod_0().imethod_4();
    GClass62.gclass141_0.method_141();
    GClass62.gclass117_0.method_15();
    GClass62.gclass117_0.vmethod_0();
  }

  public void method_53()
  {
    this.poolCount += Class15.smethod_0(1);
    if ((this.poolCount % Class15.smethod_0(9) == 0 ? 0 : 1) != 0)
      return;
    GClass171.smethod_5(GClass172.int_24, Class15.smethod_2(7));
  }

  public void method_54() => GClass171.smethod_5(GClass172.int_33, Class15.smethod_2(7));

  public void method_55() => GClass171.smethod_5(GClass172.int_34, Class15.smethod_2(7));

  public static void smethod_2(int x, int y, int id, float volume) => GClass171.smethod_5(id, volume);

  public class GClass173
  {
  }

  public class GClass174
  {
  }

  public class GClass175
  {
  }
}
