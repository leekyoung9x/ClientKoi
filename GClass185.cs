// Decompiled with JetBrains decompiler
// Type: GClass185
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GClass185
{
  public const int int_0 = 0;
  public const int int_1 = 2;
  public const int int_2 = 4;
  public const int int_3 = 8;
  public const int int_4 = 16;
  public const int int_5 = 32;
  public const int int_6 = 64;
  public const int int_7 = 128;
  public const int int_8 = 256;
  public const int int_9 = 512;
  public const int int_10 = 1024;
  public const int int_11 = 2048;
  public const int int_12 = 4096;
  public const int int_13 = 8192;
  public const int int_14 = 16384;
  public const int int_15 = 32768;
  public const int int_16 = 65536;
  public const int int_17 = 131072;
  public const int int_18 = 262144;
  public const int int_19 = 524288;
  public const int int_20 = 1;
  public static int int_21;
  public static int int_22;
  public static int int_23;
  public static int int_24;
  public static int int_25;
  public static int int_26 = -1;
  public static int[] int_27;
  public static int[] int_28;
  public static GClass66[] gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public static GClass66 gclass66_3;
  public static GClass66 gclass66_4;
  public static GClass66 gclass66_5;
  public static GClass66 gclass66_6;
  public static GClass66 gclass66_7;
  public static GClass66 gclass66_8;
  public static GClass66 gclass66_9;
  public static sbyte sbyte_0 = (sbyte) Class15.smethod_0(40);
  private static int int_29;
  private static int int_30;
  private static int int_31;
  private static int int_32;
  public static string[] string_0;
  public static int[] int_33;
  public static int[] int_34;
  public static int[] int_35;
  public static int int_36;
  public static bool bool_0 = Class15.smethod_0(0) != 0;
  public static string string_1 = string.Empty;
  public static sbyte sbyte_1 = (sbyte) Class15.smethod_0(1);
  public static int int_37;
  public static int int_38 = -1;
  public static int int_39;
  public static int int_40;
  public static int int_41;
  public static int int_42 = -1;
  public static int int_43;
  public static sbyte sbyte_2;
  public static sbyte sbyte_3 = -1;
  public static long long_0;
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass134 gclass134_1 = new GClass134();
  public static GClass134 gclass134_2 = new GClass134();
  public static string[] string_2;
  public static sbyte sbyte_4 = (sbyte) Class15.smethod_0(0);
  public static GClass66 gclass66_10;
  public const int int_44 = 0;
  public const int int_45 = 1;
  public const int int_46 = 2;
  public const int int_47 = 3;
  public const int int_48 = 5;
  public const int int_49 = 4;
  public const int int_50 = 6;
  public const int int_51 = 7;
  public const int int_52 = 8;
  public const int int_53 = 9;
  public const int int_54 = 10;
  public const int int_55 = 11;
  public const int int_56 = 12;
  public const int int_57 = 13;
  public const int int_58 = 15;
  public const int int_59 = 16;
  public static GClass66[] gclass66_11 = new GClass66[Class15.smethod_0(88)];
  public static GClass134 gclass134_3 = new GClass134();
  public static int[] int_60;
  public static int[] int_61;
  public static int[] int_62;
  public static int[][] int_63;
  public static int[][][] int_64;
  public static GClass66 gclass66_12;
  public static int int_65;
  public static int int_66;
  public static int int_67;
  public static int int_68;
  public static int int_69;
  public static int int_70;
  public static int int_71;
  private static int[] int_72;
  public static int int_73;

  public static void smethod_0()
  {
    GClass185.gclass66_10 = GClass62.smethod_40(Class13.smethod_0(141621));
    if (GClass98.int_8 == Class15.smethod_0(1) || (!Main.bool_1 ? 0 : 1) != 0 || (!Main.bool_2 ? 0 : 1) != 0)
      return;
    GClass185.gclass66_12 = GClass62.smethod_40(Class13.smethod_0(141921));
  }

  public static bool smethod_1() => GClass185.int_37 != Class15.smethod_0(190) && GClass185.int_37 != Class15.smethod_0(323) && GClass185.int_37 != Class15.smethod_0(265) && GClass185.int_37 != Class15.smethod_0(76) && GClass185.int_37 != Class15.smethod_0(75) && GClass185.int_37 != Class15.smethod_0(288) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public static bool smethod_2() => GClass185.int_37 != Class15.smethod_0(53) && GClass185.int_37 != Class15.smethod_0(54) && GClass185.int_37 != Class15.smethod_0(55) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public static bool smethod_3() => (GClass116.gclass74_0 == null ? 1 : 0) == 0 && GClass185.int_37 == (int) GClass116.gclass74_0.idmapPaint ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public static GClass18 smethod_4(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass185.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      GClass18 gclass18 = (GClass18) GClass185.gclass134_1.method_3(index);
      if (gclass18.id == id)
        return gclass18;
    }
    return (GClass18) null;
  }

  public static bool smethod_5()
  {
    for (int index = Class15.smethod_0(0); index < GClass185.int_60.Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass185.int_60[index])
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static bool smethod_6()
  {
    for (int index = Class15.smethod_0(0); index < GClass185.int_60.Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass185.int_61[index])
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static bool smethod_7()
  {
    for (int index = Class15.smethod_0(0); index < GClass185.int_62.Length; index += Class15.smethod_0(1))
    {
      if (GClass185.int_37 == GClass185.int_62[index])
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static void smethod_8()
  {
    GClass185.gclass66_0 = (GClass66[]) null;
    GClass126.smethod_26();
  }

  public static void smethod_9()
  {
  }

  public static bool smethod_10(int id)
  {
    if (id == Class15.smethod_0(156) || id == Class15.smethod_0(629) || id == Class15.smethod_0(630) || id == Class15.smethod_0(631))
      return Class15.smethod_0(0) != 0;
    if (GClass185.int_37 == Class15.smethod_0(271) || GClass185.int_37 == Class15.smethod_0(280) || GClass185.int_37 == Class15.smethod_0(368) || GClass185.int_37 == Class15.smethod_0(210) || GClass185.int_37 == Class15.smethod_0(129) || GClass185.int_37 == Class15.smethod_0(211) || GClass185.int_37 == Class15.smethod_0(323))
      return Class15.smethod_0(0) != 0;
    int num = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < GClass185.gclass134_2.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass18) GClass185.gclass134_2.method_3(index)).id == id)
        num += Class15.smethod_0(1);
    }
    return num > Class15.smethod_0(7) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
  }

  public static void smethod_11()
  {
    if ((GClass185.gclass66_3 == null ? 0 : 1) == 0)
      GClass185.gclass66_3 = GClass62.smethod_39(Class13.smethod_0(142004));
    if ((GClass185.gclass66_4 == null ? 0 : 1) == 0)
      GClass185.gclass66_4 = GClass62.smethod_39(Class13.smethod_0(141988));
    if ((GClass185.gclass66_5 == null ? 0 : 1) == 0)
      GClass185.gclass66_5 = GClass62.smethod_39(Class13.smethod_0(141953));
    if ((GClass185.gclass66_6 == null ? 0 : 1) == 0)
      GClass185.gclass66_6 = GClass62.smethod_39(Class13.smethod_0(142021));
    if ((GClass185.gclass66_7 == null ? 0 : 1) == 0)
      GClass185.gclass66_7 = GClass62.smethod_39(Class13.smethod_0(142644));
    GClass126.smethod_26();
  }

  public static void smethod_12(int index, int[] mapsArr, int type)
  {
    for (int index1 = Class15.smethod_0(0); index1 < mapsArr.Length; index1 += Class15.smethod_0(1))
    {
      if (GClass185.int_27[index] == mapsArr[index1])
      {
        GClass185.int_28[index] |= type;
        break;
      }
    }
  }

  public static void smethod_13(int tileId)
  {
    GClass185.int_24 = GClass185.int_22 * (int) GClass185.sbyte_0;
    GClass185.int_23 = GClass185.int_21 * (int) GClass185.sbyte_0;
    GClass151.smethod_7(Class13.smethod_0(142717) + GClass185.int_25.ToString());
    int index1 = tileId - Class15.smethod_0(1);
    try
    {
      for (int index2 = Class15.smethod_0(0); index2 < GClass185.int_21 * GClass185.int_22; index2 += Class15.smethod_0(1))
      {
        for (int index3 = Class15.smethod_0(0); index3 < GClass185.int_63[index1].Length; index3 += Class15.smethod_0(1))
          GClass185.smethod_12(index2, GClass185.int_64[index1][index3], GClass185.int_63[index1][index3]);
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(142781));
      GClass63.gclass63_0.method_1();
    }
  }

  public static bool smethod_14() => GClass185.int_37 != Class15.smethod_0(70) && GClass185.int_37 != Class15.smethod_0(71) && GClass185.int_37 != Class15.smethod_0(154) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public static bool smethod_15() => (!GClass185.bool_0 ? 0 : 1) == 0 && GClass185.int_37 != Class15.smethod_0(70) && GClass185.int_37 != Class15.smethod_0(71) && GClass185.int_37 != Class15.smethod_0(154) && GClass185.int_37 != Class15.smethod_0(190) && GClass185.int_37 != Class15.smethod_0(72) && GClass185.int_37 != Class15.smethod_0(323) && GClass185.int_37 != Class15.smethod_0(265) && GClass185.int_37 != Class15.smethod_0(76) && GClass185.int_37 != Class15.smethod_0(373) && GClass185.int_37 != Class15.smethod_0(446) && GClass185.int_37 != Class15.smethod_0(447) && GClass185.int_37 != Class15.smethod_0(448) && GClass185.int_37 != Class15.smethod_0(98) && GClass185.int_37 != Class15.smethod_0(367) && GClass185.int_37 != Class15.smethod_0(614) && GClass185.int_37 != Class15.smethod_0(75) && GClass185.int_37 != Class15.smethod_0(288) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public static void smethod_16()
  {
    if (Main.int_2 != Class15.smethod_0(5) && Main.int_2 != Class15.smethod_0(3))
    {
      if (GClass98.int_8 == Class15.smethod_0(1))
      {
        if ((GClass185.gclass66_0 == null ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < GClass185.gclass66_0.Length; index += Class15.smethod_0(1))
          {
            if ((GClass185.gclass66_0[index] == null ? 1 : 0) == 0)
            {
              GClass185.gclass66_0[index].texture = (Texture2D) null;
              GClass185.gclass66_0[index] = (GClass66) null;
            }
          }
          GClass126.smethod_26();
        }
        GClass185.gclass66_0 = new GClass66[Class15.smethod_0(21)];
        string empty = string.Empty;
        for (int index = Class15.smethod_0(0); index < GClass185.gclass66_0.Length; index += Class15.smethod_0(1))
        {
          string path = index >= Class15.smethod_0(45) ? Class13.smethod_0(142805) + GClass185.int_25.ToString() + Class13.smethod_0(142530) + (index + Class15.smethod_0(1)).ToString() : Class13.smethod_0(142805) + GClass185.int_25.ToString() + Class13.smethod_0(142539) + (index + Class15.smethod_0(1)).ToString();
          GClass185.gclass66_0[index] = GClass62.smethod_40(path);
        }
      }
      else if ((GClass62.smethod_39(Class13.smethod_0(142805) + GClass185.int_25.ToString() + Class13.smethod_0(143142)) == null ? 1 : 0) == 0)
      {
        GClass152.smethod_14(Class13.smethod_0(143121) + GClass98.int_8.ToString() + Class13.smethod_0(143119) + GClass185.int_25.ToString());
        GClass185.gclass66_0 = new GClass66[Class15.smethod_0(21)];
        for (int index1 = Class15.smethod_0(0); index1 < GClass185.gclass66_0.Length; index1 += Class15.smethod_0(1))
        {
          GClass66[] gclass660 = GClass185.gclass66_0;
          int index2 = index1;
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = Class13.smethod_0(142805);
          strArray[Class15.smethod_0(1)] = GClass185.int_25.ToString();
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(143117);
          strArray[Class15.smethod_0(5)] = (index1 + Class15.smethod_0(1)).ToString();
          strArray[Class15.smethod_0(2)] = Class13.smethod_0(142371);
          GClass66 gclass66 = GClass62.smethod_39(string.Concat(strArray));
          gclass660[index2] = gclass66;
        }
      }
      else
      {
        GClass66 gclass66 = GClass62.smethod_39(Class13.smethod_0(142805) + GClass185.int_25.ToString() + Class13.smethod_0(142371));
        if ((gclass66 == null ? 1 : 0) != 0)
          return;
        GClass152.smethod_14(Class13.smethod_0(143117));
        GClass185.gclass66_0 = new GClass66[Class15.smethod_0(1)];
        GClass185.gclass66_0[Class15.smethod_0(0)] = gclass66;
      }
    }
    else if (GClass98.int_8 == Class15.smethod_0(1))
    {
      GClass185.gclass66_0 = new GClass66[Class15.smethod_0(1)];
      GClass185.gclass66_0[Class15.smethod_0(0)] = GClass62.smethod_40(Class13.smethod_0(142805) + GClass185.int_25.ToString() + Class13.smethod_0(142371));
    }
    else
    {
      GClass185.gclass66_0 = new GClass66[Class15.smethod_0(21)];
      for (int index3 = Class15.smethod_0(0); index3 < GClass185.gclass66_0.Length; index3 += Class15.smethod_0(1))
      {
        GClass66[] gclass660 = GClass185.gclass66_0;
        int index4 = index3;
        string[] strArray = new string[Class15.smethod_0(3)];
        strArray[Class15.smethod_0(0)] = Class13.smethod_0(142805);
        strArray[Class15.smethod_0(1)] = GClass185.int_25.ToString();
        strArray[Class15.smethod_0(7)] = Class13.smethod_0(142566);
        strArray[Class15.smethod_0(5)] = (index3 + Class15.smethod_0(1)).ToString();
        strArray[Class15.smethod_0(2)] = Class13.smethod_0(142371);
        GClass66 gclass66 = GClass62.smethod_40(string.Concat(strArray));
        gclass660[index4] = gclass66;
      }
    }
  }

  public static void smethod_17(GClass98 g, int frame, int indexX, int indexY)
  {
    if ((GClass185.gclass66_0 == null ? 1 : 0) != 0)
      return;
    if (GClass185.gclass66_0.Length == Class15.smethod_0(1))
      g.method_24(GClass185.gclass66_0[Class15.smethod_0(0)], Class15.smethod_0(0), frame * (int) GClass185.sbyte_0, (int) GClass185.sbyte_0, (int) GClass185.sbyte_0, Class15.smethod_0(0), indexX * (int) GClass185.sbyte_0, indexY * (int) GClass185.sbyte_0, Class15.smethod_0(0));
    else
      g.method_32(GClass185.gclass66_0[frame], indexX * (int) GClass185.sbyte_0, indexY * (int) GClass185.sbyte_0, Class15.smethod_0(0));
  }

  public static void smethod_18(GClass98 g, int frame, int x, int y, int w, int h)
  {
    if ((GClass185.gclass66_0 == null ? 1 : 0) != 0)
      return;
    if (GClass185.gclass66_0.Length == Class15.smethod_0(1))
      g.method_24(GClass185.gclass66_0[Class15.smethod_0(0)], Class15.smethod_0(0), frame * w, w, w, Class15.smethod_0(0), x, y, Class15.smethod_0(0));
    else
      g.method_32(GClass185.gclass66_0[frame], x, y, Class15.smethod_0(0));
  }

  public static void smethod_19(GClass98 g)
  {
    for (int int32 = GClass116.int_32; int32 < GClass116.int_34; int32 += Class15.smethod_0(1))
    {
      for (int int33 = GClass116.int_33; int33 < GClass116.int_35; int33 += Class15.smethod_0(1))
      {
        int frame = GClass185.int_27[int33 * GClass185.int_21 + int32] - Class15.smethod_0(1);
        if (frame != -1)
          GClass185.smethod_17(g, frame, int32, int33);
        if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(120)) == Class15.smethod_0(120))
          g.method_24(GClass185.gclass66_3, Class15.smethod_0(0), Class15.smethod_0(40) * (GClass62.int_8 % Class15.smethod_0(2)), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
        else if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(199)) == Class15.smethod_0(199))
        {
          if ((GClass185.smethod_25(int32, int33 - Class15.smethod_0(1)) & Class15.smethod_0(120)) == Class15.smethod_0(120))
            g.method_24(GClass185.gclass66_3, Class15.smethod_0(0), Class15.smethod_0(40) * (GClass62.int_8 % Class15.smethod_0(2)), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
          else if ((GClass185.smethod_25(int32, int33 - Class15.smethod_0(1)) & Class15.smethod_0(432)) == Class15.smethod_0(432))
            GClass185.smethod_17(g, Class15.smethod_0(27), int32, int33);
          GClass66 gclass66 = GClass185.int_25 == Class15.smethod_0(3) ? GClass185.gclass66_6 : (GClass185.int_25 != Class15.smethod_0(88) ? GClass185.gclass66_5 : GClass185.gclass66_7);
          g.method_24(gclass66, Class15.smethod_0(0), (GClass62.int_8 % Class15.smethod_0(88) >> Class15.smethod_0(7)) * Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
        }
        if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(459)) == Class15.smethod_0(459))
        {
          if ((GClass185.smethod_25(int32, int33 - Class15.smethod_0(1)) & Class15.smethod_0(120)) == Class15.smethod_0(120))
            g.method_24(GClass185.gclass66_3, Class15.smethod_0(0), Class15.smethod_0(40) * (GClass62.int_8 % Class15.smethod_0(2)), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
          else if ((GClass185.smethod_25(int32, int33 - Class15.smethod_0(1)) & Class15.smethod_0(432)) == Class15.smethod_0(432))
            GClass185.smethod_17(g, Class15.smethod_0(27), int32, int33);
          GClass185.smethod_17(g, GClass185.int_27[int33 * GClass185.int_21 + int32] - Class15.smethod_0(1), int32, int33);
        }
      }
    }
  }

  public static void smethod_20(GClass98 g)
  {
    if ((!GClass20.bool_4 ? 1 : 0) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
      ((GClass81) GClass116.gclass134_6.method_3(index)).method_6(g);
    for (int int32 = GClass116.int_32; int32 < GClass116.int_34; int32 += Class15.smethod_0(1))
    {
      for (int int33 = GClass116.int_33; int33 < GClass116.int_35; int33 += Class15.smethod_0(1))
      {
        if ((int32 == 0 ? 1 : 0) == 0 && int32 != GClass185.int_21 - Class15.smethod_0(1))
        {
          int frame = GClass185.int_27[int33 * GClass185.int_21 + int32] - Class15.smethod_0(1);
          if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(290)) != Class15.smethod_0(290))
          {
            if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(120)) == Class15.smethod_0(120))
              g.method_24(GClass185.gclass66_3, Class15.smethod_0(0), Class15.smethod_0(40) * (GClass62.int_8 % Class15.smethod_0(88) >> Class15.smethod_0(1)), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
            else if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(212)) == Class15.smethod_0(212))
              g.method_24(GClass185.gclass66_4, Class15.smethod_0(0), Class15.smethod_0(40) * (GClass62.int_8 % Class15.smethod_0(88) >> Class15.smethod_0(1)), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(0));
            else if (GClass185.int_25 != Class15.smethod_0(47) || frame == -1)
            {
              if (GClass185.int_25 == Class15.smethod_0(7) && (GClass185.smethod_25(int32, int33) & Class15.smethod_0(247)) == Class15.smethod_0(247) && frame != -1)
              {
                GClass185.smethod_18(g, frame, int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(40), Class15.smethod_0(1));
                GClass185.smethod_18(g, frame, int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0 + Class15.smethod_0(1), Class15.smethod_0(40), Class15.smethod_0(40));
              }
              Class15.smethod_0(5);
              if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(10)) == Class15.smethod_0(10))
              {
                GClass185.int_29 = int32 * (int) GClass185.sbyte_0 - GClass116.int_22;
                GClass185.int_30 = GClass185.int_29 - GClass116.int_8;
                GClass185.int_32 = ((int) GClass185.sbyte_0 - Class15.smethod_0(7)) * GClass185.int_30 / (int) GClass185.sbyte_0;
                GClass185.int_31 = GClass185.int_32 + GClass116.int_8;
                GClass185.smethod_18(g, frame, GClass185.int_31 + GClass116.int_22, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(40), Class15.smethod_0(40));
              }
              else if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(247)) == Class15.smethod_0(247))
              {
                if (frame != -1)
                {
                  GClass185.smethod_18(g, frame, int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0, Class15.smethod_0(40), Class15.smethod_0(1));
                  GClass185.smethod_18(g, frame, int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0 + Class15.smethod_0(1), Class15.smethod_0(40), Class15.smethod_0(40));
                }
              }
              else if (frame != -1)
                GClass185.smethod_17(g, frame, int32, int33);
            }
          }
        }
      }
    }
    if (GClass116.int_22 < Class15.smethod_0(40))
    {
      for (int int33 = GClass116.int_33; int33 < GClass116.int_35; int33 += Class15.smethod_0(1))
      {
        int frame = GClass185.int_27[int33 * GClass185.int_21 + Class15.smethod_0(1)] - Class15.smethod_0(1);
        if (frame != -1)
          GClass185.smethod_17(g, frame, Class15.smethod_0(0), int33);
      }
    }
    if (GClass116.int_22 <= GClass116.int_30)
      return;
    int num = GClass185.int_21 - Class15.smethod_0(7);
    for (int int33 = GClass116.int_33; int33 < GClass116.int_35; int33 += Class15.smethod_0(1))
    {
      int frame = GClass185.int_27[int33 * GClass185.int_21 + num] - Class15.smethod_0(1);
      if (frame != -1)
        GClass185.smethod_17(g, frame, num + Class15.smethod_0(1), int33);
    }
  }

  public static bool smethod_21() => GClass185.int_37 != Class15.smethod_0(271) && GClass185.int_37 != Class15.smethod_0(280) && GClass185.int_37 != Class15.smethod_0(368) && GClass185.int_37 != Class15.smethod_0(210) && GClass185.int_37 != Class15.smethod_0(505) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public static void smethod_22(GClass98 g)
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
      return;
    int num = Class15.smethod_0(0);
    for (int int32 = GClass116.int_32; int32 < GClass116.int_34; int32 += Class15.smethod_0(1))
    {
      for (int int33 = GClass116.int_33; int33 < GClass116.int_35; int33 += Class15.smethod_0(1))
      {
        num += Class15.smethod_0(1);
        if ((GClass185.smethod_25(int32, int33) & Class15.smethod_0(199)) == Class15.smethod_0(199))
        {
          GClass66 gclass66 = GClass185.int_25 == Class15.smethod_0(3) ? GClass185.gclass66_6 : (GClass185.int_25 != Class15.smethod_0(88) ? GClass185.gclass66_5 : GClass185.gclass66_7);
          if ((!GClass185.smethod_21() ? 0 : 1) == 0)
          {
            g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0 - Class15.smethod_0(1), Class15.smethod_0(0));
            g.method_24(gclass66, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0 - Class15.smethod_0(5), Class15.smethod_0(0));
          }
          g.method_24(gclass66, Class15.smethod_0(0), (GClass62.int_8 % Class15.smethod_0(88) >> Class15.smethod_0(7)) * Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), int32 * (int) GClass185.sbyte_0, int33 * (int) GClass185.sbyte_0 - Class15.smethod_0(66), Class15.smethod_0(0));
          if ((GClass185.int_73 == 0 ? 0 : 1) == 0 && (!GClass185.smethod_21() ? 1 : 0) == 0)
          {
            GClass185.int_73 = int33 * (int) GClass185.sbyte_0 - Class15.smethod_0(66);
            int color = Class15.smethod_0(142);
            if (GClass62.int_51 == Class15.smethod_0(7))
              color = Class15.smethod_0(632);
            else if (GClass62.int_51 == Class15.smethod_0(2))
              color = Class15.smethod_0(633);
            else if (GClass62.int_51 == Class15.smethod_0(38))
              color = Class15.smethod_0(634);
            GClass16.smethod_8(color, GClass185.int_73 + Class15.smethod_0(9));
          }
        }
      }
    }
    GClass16.smethod_9(g);
  }

  public static void smethod_23(int mapID)
  {
    GClass35 gclass35 = GClass133.smethod_0(Class13.smethod_0(143268) + mapID.ToString());
    GClass185.int_21 = (int) (ushort) gclass35.method_2();
    GClass185.int_22 = (int) (ushort) gclass35.method_2();
    GClass185.int_27 = new int[gclass35.method_13()];
    for (int index = Class15.smethod_0(0); index < GClass185.int_21 * GClass185.int_22; index += Class15.smethod_0(1))
      GClass185.int_27[index] = (int) (ushort) gclass35.method_2();
    GClass185.int_28 = new int[GClass185.int_27.Length];
  }

  public static int smethod_24(int x, int y)
  {
    try
    {
      return GClass185.int_27[y * GClass185.int_21 + x];
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(15);
    }
  }

  public static int smethod_25(int x, int y)
  {
    try
    {
      return GClass185.int_28[y * GClass185.int_21 + x];
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(15);
    }
  }

  public static int smethod_26(int px, int py)
  {
    try
    {
      return GClass185.int_28[py / (int) GClass185.sbyte_0 * GClass185.int_21 + px / (int) GClass185.sbyte_0];
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(15);
    }
  }

  public static bool smethod_27(int px, int py, int t)
  {
    try
    {
      return (GClass185.int_28[py / (int) GClass185.sbyte_0 * GClass185.int_21 + px / (int) GClass185.sbyte_0] & t) == t;
    }
    catch (Exception ex)
    {
      return Class15.smethod_0(0) != 0;
    }
  }

  public static void smethod_28(int px, int py, int t) => GClass185.int_28[py / (int) GClass185.sbyte_0 * GClass185.int_21 + px / (int) GClass185.sbyte_0] |= t;

  public static void smethod_29(int x, int y, int t) => GClass185.int_28[y * GClass185.int_21 + x] = t;

  public static void smethod_30(int px, int py, int t) => GClass185.int_28[py / (int) GClass185.sbyte_0 * GClass185.int_21 + px / (int) GClass185.sbyte_0] &= ~t;

  public static int smethod_31(int py) => py / (int) GClass185.sbyte_0 * (int) GClass185.sbyte_0;

  public static int smethod_32(int px) => px / (int) GClass185.sbyte_0 * (int) GClass185.sbyte_0;

  public static void smethod_33()
  {
    if (GClass185.int_26 == GClass185.int_25)
      return;
    GClass185.smethod_16();
    GClass185.int_26 = GClass185.int_25;
  }

  static GClass185()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.lbkzjysZVxNT));
    GClass185.int_60 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.IhpUIXzfnvFM));
    GClass185.int_61 = (int[]) Class15.smethod_4(byte_0_2);
    int[] numArray1 = new int[Class15.smethod_0(5)];
    numArray1[Class15.smethod_0(1)] = Class15.smethod_0(38);
    numArray1[Class15.smethod_0(7)] = Class15.smethod_0(49);
    GClass185.int_62 = numArray1;
    GClass185.gclass66_12 = GClass62.smethod_40(Class13.smethod_0(143335));
    GClass185.int_65 = Class15.smethod_0(7);
    int[] numArray2 = new int[Class15.smethod_0(7)];
    numArray2[Class15.smethod_0(0)] = Class15.smethod_0(635);
    numArray2[Class15.smethod_0(1)] = Class15.smethod_0(636);
    GClass185.int_72 = numArray2;
    GClass185.int_73 = Class15.smethod_0(0);
  }
}
