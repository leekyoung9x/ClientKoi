// Decompiled with JetBrains decompiler
// Type: GClass126
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Text;
using UnityEngine;

public class GClass126
{
  public static bool bool_0;
  public static string string_0;
  public static bool bool_1;
  public static string string_1;
  public static string string_2;
  public static int int_0 = Class15.smethod_0(2);
  public static sbyte sbyte_0;
  public static sbyte sbyte_1;
  public static sbyte sbyte_2 = (sbyte) Class15.smethod_0(3);
  public const int int_1 = 1;
  public const int int_2 = 2;
  public const int int_3 = 3;
  public const int int_4 = 4;
  public const int int_5 = 5;
  public const int int_6 = 6;
  public const int int_7 = 7;
  public static GClass126 gclass126_0;

  public static void smethod_0() => GClass126.sbyte_1 = (sbyte) Class15.smethod_0(0);

  public static int smethod_1(GClass66 img)
  {
    Class15.smethod_0(3);
    return img.method_0();
  }

  public static int smethod_2(GClass66 img) => GClass126.int_0 == Class15.smethod_0(3) ? img.method_1() : img.method_0();

  public static void smethod_3(string st)
  {
  }

  public static string smethod_4(
    long timeStart,
    int secondCount,
    bool isOnlySecond,
    bool isShortText)
  {
    string str = string.Empty;
    long num1 = (timeStart + (long) (secondCount * Class15.smethod_0(15)) - GClass126.smethod_18()) / (long) Class15.smethod_0(15);
    if (num1 <= (long) Class15.smethod_0(0))
      return string.Empty;
    long num2 = (long) Class15.smethod_0(0);
    long num3 = (long) Class15.smethod_0(0);
    long num4 = num1 / (long) Class15.smethod_0(4);
    long num5 = num1;
    if ((!isOnlySecond ? 1 : 0) == 0)
      return num5.ToString() + string.Empty;
    if (num1 >= (long) Class15.smethod_0(440))
    {
      num2 = num1 / (long) Class15.smethod_0(440);
      num3 = num1 % (long) Class15.smethod_0(440) / (long) Class15.smethod_0(441);
    }
    else if (num1 >= (long) Class15.smethod_0(441))
    {
      num3 = num1 / (long) Class15.smethod_0(441);
      num4 = num1 % (long) Class15.smethod_0(441) / (long) Class15.smethod_0(4);
    }
    else if (num1 >= (long) Class15.smethod_0(4))
    {
      num4 = num1 / (long) Class15.smethod_0(4);
      num5 = num1 % (long) Class15.smethod_0(4);
    }
    else
      num5 = num1;
    if ((!isShortText ? 1 : 0) == 0)
    {
      if (num2 > (long) Class15.smethod_0(0))
        return num2.ToString() + Class13.smethod_0(154284);
      if (num3 > (long) Class15.smethod_0(0))
        return num3.ToString() + Class13.smethod_0(154282);
      if (num4 > (long) Class15.smethod_0(0))
        return num4.ToString() + Class13.smethod_0(154272);
      if (num5 > (long) Class15.smethod_0(0))
        return num5.ToString() + Class13.smethod_0(154241);
    }
    if (num2 > (long) Class15.smethod_0(0))
    {
      if (num2 >= (long) Class15.smethod_0(31))
        str = num3 < (long) Class15.smethod_0(1) ? num2.ToString() + Class13.smethod_0(154284) : (num3 >= (long) Class15.smethod_0(31) ? num2.ToString() + Class13.smethod_0(154284) + num3.ToString() + Class13.smethod_0(154282) : num2.ToString() + Class13.smethod_0(154350) + num3.ToString() + Class13.smethod_0(154282));
      else if (num2 < (long) Class15.smethod_0(31))
        str = num3 < (long) Class15.smethod_0(1) ? num2.ToString() + Class13.smethod_0(154284) : (num3 >= (long) Class15.smethod_0(31) ? num2.ToString() + Class13.smethod_0(154284) + num3.ToString() + Class13.smethod_0(154282) : num2.ToString() + Class13.smethod_0(154350) + num3.ToString() + Class13.smethod_0(154282));
    }
    else if (num3 > (long) Class15.smethod_0(0))
    {
      if (num3 >= (long) Class15.smethod_0(31))
        str = num4 < (long) Class15.smethod_0(1) ? num3.ToString() + Class13.smethod_0(154282) : (num4 >= (long) Class15.smethod_0(31) ? num3.ToString() + Class13.smethod_0(154282) + num4.ToString() + Class13.smethod_0(154272) : num3.ToString() + Class13.smethod_0(154309) + num4.ToString() + Class13.smethod_0(154272));
      else if (num3 < (long) Class15.smethod_0(31))
        str = num4 < (long) Class15.smethod_0(1) ? num3.ToString() + Class13.smethod_0(154282) : (num4 >= (long) Class15.smethod_0(31) ? num3.ToString() + Class13.smethod_0(154282) + num4.ToString() + Class13.smethod_0(154272) : num3.ToString() + Class13.smethod_0(154309) + num4.ToString() + Class13.smethod_0(154272));
    }
    else if (num4 > (long) Class15.smethod_0(0))
    {
      if (num4 >= (long) Class15.smethod_0(31))
      {
        if (num5 >= (long) Class15.smethod_0(31))
          str = num4.ToString() + Class13.smethod_0(154272) + num5.ToString() + string.Empty;
        else if (num5 < (long) Class15.smethod_0(31))
          str = num4.ToString() + Class13.smethod_0(154940) + num5.ToString() + string.Empty;
      }
      else if (num4 < (long) Class15.smethod_0(31))
      {
        if (num5 >= (long) Class15.smethod_0(31))
          str = num4.ToString() + Class13.smethod_0(154272) + num5.ToString() + string.Empty;
        else if (num5 < (long) Class15.smethod_0(31))
          str = num4.ToString() + Class13.smethod_0(154940) + num5.ToString() + string.Empty;
      }
    }
    else
      str = num5 >= (long) Class15.smethod_0(31) ? num5.ToString() + string.Empty : Class13.smethod_0(154913) + num5.ToString() + string.Empty;
    return str;
  }

  public static string smethod_5(int aa)
  {
    try
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      string str3 = aa.ToString() + string.Empty;
      if ((!str3.Equals(string.Empty) ? 1 : 0) == 0)
        return str1;
      if ((int) str3[Class15.smethod_0(0)] == Class15.smethod_0(70))
      {
        str2 = Class13.smethod_0(155430);
        str3 = str3.Substring(Class15.smethod_0(1));
      }
      for (int index = str3.Length - Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      {
        char ch;
        string str4;
        if (((str3.Length - Class15.smethod_0(1) - index) % Class15.smethod_0(5) == 0 ? 0 : 1) == 0 && str3.Length - Class15.smethod_0(1) - index > Class15.smethod_0(0))
        {
          ch = str3[index];
          str4 = ch.ToString() + Class13.smethod_0(155176) + str1;
        }
        else
        {
          ch = str3[index];
          str4 = ch.ToString() + str1;
        }
        str1 = str4;
      }
      return str2 + str1;
    }
    catch (Exception ex)
    {
      return aa.ToString() + string.Empty;
    }
  }

  public static string smethod_6(long number)
  {
    string str1 = string.Empty + number.ToString();
    bool flag = Class15.smethod_0(0) != 0;
    try
    {
      string empty = string.Empty;
      if (number < (long) Class15.smethod_0(0))
      {
        flag = Class15.smethod_0(1) != 0;
        number = -number;
        str1 = string.Empty + number.ToString();
      }
      Class15.smethod_0(0);
      string str2;
      int length;
      if (number >= (long) Class15.smethod_0(291))
      {
        str2 = Class13.smethod_0(147580);
        number /= (long) Class15.smethod_0(291);
        length = (string.Empty + number.ToString()).Length;
      }
      else if (number >= (long) Class15.smethod_0(442))
      {
        str2 = Class13.smethod_0(148363);
        number /= (long) Class15.smethod_0(442);
        length = (string.Empty + number.ToString()).Length;
      }
      else
      {
        if (number < (long) Class15.smethod_0(15))
          return (!flag ? 1 : 0) == 0 ? Class13.smethod_0(148361) + str1 : str1;
        str2 = Class13.smethod_0(148478);
        number /= (long) Class15.smethod_0(15);
        length = (string.Empty + number.ToString()).Length;
      }
      int num = int.Parse(str1.Substring(length, Class15.smethod_0(7)));
      str1 = (num == 0 ? 1 : 0) != 0 ? str1.Substring(Class15.smethod_0(0), length) + str2 : ((num % Class15.smethod_0(31) == 0 ? 0 : 1) != 0 ? str1.Substring(Class15.smethod_0(0), length) + Class13.smethod_0(148476) + str1.Substring(length, Class15.smethod_0(7)) + str2 : str1.Substring(Class15.smethod_0(0), length) + Class13.smethod_0(148476) + str1.Substring(length, Class15.smethod_0(1)) + str2);
    }
    catch (Exception ex)
    {
    }
    return (!flag ? 1 : 0) == 0 ? Class13.smethod_0(148361) + str1 : str1;
  }

  public static void smethod_7() => Application.OpenURL(GClass13.gclass13_0.method_44());

  public static void smethod_8()
  {
  }

  public static void smethod_9()
  {
  }

  public static void smethod_10()
  {
  }

  public static void smethod_11()
  {
  }

  public static void smethod_12()
  {
  }

  public static void smethod_13()
  {
  }

  public static void smethod_14()
  {
  }

  public static void smethod_15(GClass98 g, int x, int y, int w, int h) => g.method_10(x, y, w + Class15.smethod_0(31), h, Class15.smethod_0(0), Class15.smethod_0(23));

  public static void smethod_16(sbyte[] scr, int scrPos, sbyte[] dest, int destPos, int lenght) => Array.Copy((Array) scr, scrPos, (Array) dest, destPos, lenght);

  public static void smethod_17(
    sbyte[] scr,
    int scrPos,
    ref sbyte[] dest,
    int destPos,
    int lenght)
  {
    if ((scr == null ? 1 : 0) != 0 || (dest == null ? 1 : 0) != 0 || scrPos + lenght > scr.Length)
      return;
    sbyte[] numArray = new sbyte[dest.Length + lenght];
    for (int index = Class15.smethod_0(0); index < destPos; index += Class15.smethod_0(1))
      numArray[index] = dest[index];
    for (int index = destPos; index < destPos + lenght; index += Class15.smethod_0(1))
      numArray[index] = scr[scrPos + index - destPos];
    for (int index = destPos + lenght; index < numArray.Length; index += Class15.smethod_0(1))
      numArray[index] = dest[destPos + index - lenght];
  }

  public static long smethod_18() => (DateTime.UtcNow.Ticks - new DateTime(Class15.smethod_0(443), Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), (DateTimeKind) Class15.smethod_0(1)).Ticks) / (long) Class15.smethod_0(181);

  public static void smethod_19()
  {
    Resources.UnloadUnusedAssets();
    GC.Collect();
  }

  public static sbyte[] smethod_20(byte[] scr)
  {
    sbyte[] numArray = new sbyte[scr.Length];
    for (int index = Class15.smethod_0(0); index < scr.Length; index += Class15.smethod_0(1))
      numArray[index] = (sbyte) scr[index];
    return numArray;
  }

  public static sbyte[] smethod_21(string scr) => GClass126.smethod_20(new ASCIIEncoding().GetBytes(scr));

  public static byte[] smethod_22(sbyte[] scr)
  {
    byte[] numArray = new byte[scr.Length];
    for (int index = Class15.smethod_0(0); index < scr.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) scr[index] <= Class15.smethod_0(0) ? (byte) ((uint) scr[index] + (uint) Class15.smethod_0(290)) : (byte) scr[index];
    return numArray;
  }

  public static char[] smethod_23(sbyte[] scr)
  {
    char[] chArray = new char[scr.Length];
    for (int index = Class15.smethod_0(0); index < scr.Length; index += Class15.smethod_0(1))
      chArray[index] = (char) scr[index];
    return chArray;
  }

  public static int smethod_24() => DateTime.Now.Hour;

  public static void smethod_25(object str) => Debug.Log(str);

  public static void smethod_26()
  {
    Resources.UnloadUnusedAssets();
    GC.Collect();
  }

  public static GClass126 smethod_27()
  {
    if ((GClass126.gclass126_0 == null ? 0 : 1) == 0)
      GClass126.gclass126_0 = new GClass126();
    return GClass126.gclass126_0;
  }

  public static void smethod_28() => GClass32.bool_1 = Class15.smethod_0(1) != 0;

  public static void smethod_29() => GClass32.bool_2 = Class15.smethod_0(1) != 0;

  public static void smethod_30() => GClass32.bool_3 = Class15.smethod_0(1) != 0;

  public static void smethod_31()
  {
  }

  public static void smethod_32(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(3); index += Class15.smethod_0(1))
    {
      if (GClass116.int_118[index] != -1 && (!GClass62.smethod_43(GClass116.int_113[index], GClass116.int_114[index]) ? 1 : 0) == 0)
      {
        if (GClass116.int_119[index] == GClass97.int_3)
          GClass97.gclass97_27.method_7(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2);
        else if (GClass116.int_119[index] == GClass97.int_4)
          GClass97.gclass97_29.method_7(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2);
        else if (GClass116.int_119[index] == GClass97.int_5)
          GClass97.gclass97_30.method_7(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2);
        else if (GClass116.int_119[index] == GClass97.int_6)
          GClass97.gclass97_29.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
        else if (GClass116.int_119[index] == GClass97.int_11)
          GClass97.gclass97_30.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
        else if (GClass116.int_119[index] == GClass97.int_7)
          GClass97.gclass97_28.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_16);
        else if (GClass116.int_119[index] == GClass97.int_8)
          GClass97.gclass97_31.method_7(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2);
        else if (GClass116.int_119[index] == GClass97.int_9)
          GClass97.gclass97_29.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
        else if (GClass116.int_119[index] == GClass97.int_10)
          GClass97.gclass97_28.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
        else if (GClass116.int_119[index] == GClass97.int_12)
          GClass97.gclass97_27.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
        else if (GClass116.int_119[index] == GClass97.int_13)
          GClass97.gclass97_32.method_8(g, GClass116.string_2[index], GClass116.int_113[index], GClass116.int_114[index], GClass97.int_2, GClass97.gclass97_33);
      }
    }
  }

  public static void smethod_33()
  {
  }

  public static GClass60 smethod_34(string nameImg)
  {
    GClass60 gclass60 = (GClass60) null;
    GClass91 gclass91 = GClass69.smethod_1(nameImg, GClass69.gclass128_0);
    if ((gclass91.img == null ? 1 : 0) == 0)
    {
      int height = gclass91.img.method_1() / (int) gclass91.nFrame;
      if (height < Class15.smethod_0(1))
        height = Class15.smethod_0(1);
      gclass60 = new GClass60(gclass91.img, gclass91.img.method_0(), height);
    }
    return gclass60;
  }

  public static GClass66 smethod_35(string path) => GClass62.smethod_40(path);
}
