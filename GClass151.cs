// Decompiled with JetBrains decompiler
// Type: GClass151
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GClass151
{
  private static short[] short_0;
  private static short[] short_1;
  private static int[] int_0;
  public static string[] string_0;
  public static int int_1;
  public static bool bool_0;
  public static bool bool_1;
  public static GClass134 gclass134_0;
  public static GClass130 gclass130_0;

  public static void smethod_0()
  {
    GClass151.short_1 = new short[Class15.smethod_0(82)];
    GClass151.int_0 = new int[Class15.smethod_0(82)];
    for (int index = Class15.smethod_0(0); index <= Class15.smethod_0(23); index += Class15.smethod_0(1))
    {
      GClass151.short_1[index] = GClass151.short_0[Class15.smethod_0(23) - index];
      int num = GClass151.short_1[index] == (short) 0 ? 0 : 1;
      GClass151.int_0[index] = num != 0 ? ((int) GClass151.short_0[index] << Class15.smethod_0(31)) / (int) GClass151.short_1[index] : Class15.smethod_0(559);
    }
  }

  public static int smethod_1(int a)
  {
    a = GClass151.smethod_6(a);
    if (a >= Class15.smethod_0(0) && a < Class15.smethod_0(23))
      return (int) GClass151.short_0[a];
    if (a >= Class15.smethod_0(23) && a < Class15.smethod_0(96))
      return (int) GClass151.short_0[Class15.smethod_0(96) - a];
    return a >= Class15.smethod_0(96) && a < Class15.smethod_0(196) ? (int) -GClass151.short_0[a - Class15.smethod_0(96)] : (int) -GClass151.short_0[Class15.smethod_0(229) - a];
  }

  public static int smethod_2(int a)
  {
    a = GClass151.smethod_6(a);
    if (a >= Class15.smethod_0(0) && a < Class15.smethod_0(23))
      return (int) GClass151.short_1[a];
    if (a >= Class15.smethod_0(23) && a < Class15.smethod_0(96))
      return (int) -GClass151.short_1[Class15.smethod_0(96) - a];
    return a >= Class15.smethod_0(96) && a < Class15.smethod_0(196) ? (int) -GClass151.short_1[a - Class15.smethod_0(96)] : (int) GClass151.short_1[Class15.smethod_0(229) - a];
  }

  public static int smethod_3(int a)
  {
    a = GClass151.smethod_6(a);
    if (a >= Class15.smethod_0(0) && a < Class15.smethod_0(23))
      return GClass151.int_0[a];
    if (a >= Class15.smethod_0(23) && a < Class15.smethod_0(96))
      return -GClass151.int_0[Class15.smethod_0(96) - a];
    return a >= Class15.smethod_0(96) && a < Class15.smethod_0(196) ? GClass151.int_0[a - Class15.smethod_0(96)] : -GClass151.int_0[Class15.smethod_0(229) - a];
  }

  public static int smethod_4(int a)
  {
    for (int index = Class15.smethod_0(0); index <= Class15.smethod_0(23); index += Class15.smethod_0(1))
    {
      if (GClass151.int_0[index] >= a)
        return index;
    }
    return Class15.smethod_0(0);
  }

  public static int smethod_5(int dx, int dy)
  {
    int num;
    if ((dx == 0 ? 1 : 0) == 0)
    {
      num = GClass151.smethod_4(GClass93.smethod_0((dy << Class15.smethod_0(31)) / dx));
      if (dy >= Class15.smethod_0(0) && dx < Class15.smethod_0(0))
        num = Class15.smethod_0(96) - num;
      if (dy < Class15.smethod_0(0) && dx < Class15.smethod_0(0))
        num = Class15.smethod_0(96) + num;
      if (dy < Class15.smethod_0(0) && dx >= Class15.smethod_0(0))
        num = Class15.smethod_0(229) - num;
    }
    else
      num = dy <= Class15.smethod_0(0) ? Class15.smethod_0(196) : Class15.smethod_0(23);
    return num;
  }

  public static int smethod_6(int angle)
  {
    if (angle >= Class15.smethod_0(229))
      angle -= Class15.smethod_0(229);
    if (angle < Class15.smethod_0(0))
      angle += Class15.smethod_0(229);
    return angle;
  }

  public static void smethod_7(string s)
  {
    if ((!GClass126.bool_0 ? 1 : 0) != 0)
      return;
    Debug.Log((object) s);
  }

  public static void smethod_8(string s, int logIndex)
  {
    if ((!GClass126.bool_0 ? 1 : 0) != 0)
      return;
    Debug.Log((object) (GClass151.string_0[logIndex] + s));
  }

  public static void smethod_9(string s)
  {
    if ((!GClass126.bool_0 ? 1 : 0) != 0)
      return;
    Debug.LogError((object) s);
  }

  public static void smethod_10(string s)
  {
  }

  public static void smethod_11(string s)
  {
  }

  public static void smethod_12(GClass98 g)
  {
  }

  public static void smethod_13()
  {
  }

  public static string smethod_14(string str) => str;

  public static string smethod_15(string _text, string _searchStr, string _replacementStr) => _text.Replace(_searchStr, _replacementStr);

  public static int smethod_16(int goc, int d) => GClass151.smethod_2(GClass151.smethod_6(goc)) * d >> Class15.smethod_0(31);

  public static int smethod_17(int goc, int d) => GClass151.smethod_1(GClass151.smethod_6(goc)) * d >> Class15.smethod_0(31);

  public static int smethod_18(int a, int b) => a == b ? a : a + GClass151.gclass130_0.method_1(b - a);

  public static int smethod_19(int a) => GClass151.gclass130_0.method_1(a);

  public static int smethod_20(int a)
  {
    int num = Class15.smethod_0(0);
    while ((num == 0 ? 1 : 0) != 0)
      num = GClass151.gclass130_0.method_0() % a;
    return num;
  }

  public static int smethod_21(int currentTimeMillis)
  {
    Class15.smethod_0(0);
    int num = currentTimeMillis * Class15.smethod_0(10) / Class15.smethod_0(15);
    if (currentTimeMillis * Class15.smethod_0(10) % Class15.smethod_0(15) >= Class15.smethod_0(3))
      num += Class15.smethod_0(1);
    return num;
  }

  public static int smethod_22(int x1, int y1, int x2, int y2) => GClass151.smethod_23((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

  public static int smethod_23(int a)
  {
    if (a <= Class15.smethod_0(0))
      return Class15.smethod_0(0);
    int num1 = (a + Class15.smethod_0(1)) / Class15.smethod_0(7);
    int num2;
    do
    {
      num2 = num1;
      num1 = num1 / Class15.smethod_0(7) + a / (Class15.smethod_0(7) * num1);
    }
    while (GClass93.smethod_0(num2 - num1) > Class15.smethod_0(1));
    return num1;
  }

  public static int smethod_24(int a) => GClass151.gclass130_0.method_1(a);

  public static int smethod_25(int i) => i > Class15.smethod_0(0) ? i : -i;

  public static bool smethod_26(int x1, int y1, int width, int height, int x2, int y2) => x2 >= x1 && x2 <= x1 + width && y2 >= y1 ? (y2 > y1 + height ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  public static string[] smethod_27(string original, string separator, int count)
  {
    int length = original.IndexOf(separator);
    string[] strArray;
    if (length >= Class15.smethod_0(0))
    {
      strArray = GClass151.smethod_27(original.Substring(length + separator.Length), separator, count + Class15.smethod_0(1));
    }
    else
    {
      strArray = new string[count + Class15.smethod_0(1)];
      length = original.Length;
    }
    strArray[count] = original.Substring(Class15.smethod_0(0), length);
    return strArray;
  }

  public static string smethod_28(long number)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    empty1 = string.Empty;
    if (number >= (long) Class15.smethod_0(291))
    {
      string string122 = GClass109.string_122;
      long num = number % (long) Class15.smethod_0(291) / (long) Class15.smethod_0(105);
      number /= (long) Class15.smethod_0(291);
      string str = number.ToString() + string.Empty;
      return num > (long) Class15.smethod_0(0) ? str + Class13.smethod_0(150087) + num.ToString() + string122 : str + string122;
    }
    if (number < (long) Class15.smethod_0(442))
      return number.ToString() + string.Empty;
    string string123 = GClass109.string_123;
    long num1 = number % (long) Class15.smethod_0(442) / (long) Class15.smethod_0(17);
    number /= (long) Class15.smethod_0(442);
    string str1 = number.ToString() + string.Empty;
    return num1 > (long) Class15.smethod_0(0) ? str1 + Class13.smethod_0(150087) + num1.ToString() + string123 : str1 + string123;
  }

  public static string smethod_29(long number)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    empty1 = string.Empty;
    if (number >= (long) Class15.smethod_0(291))
    {
      string string122 = GClass109.string_122;
      long num = number % (long) Class15.smethod_0(291) / (long) Class15.smethod_0(261);
      number /= (long) Class15.smethod_0(291);
      string str = number.ToString() + string.Empty;
      if (num >= (long) Class15.smethod_0(31))
      {
        if ((num % (long) Class15.smethod_0(31) == 0L ? 0 : 1) == 0)
          num /= (long) Class15.smethod_0(31);
        return str + Class13.smethod_0(151312) + num.ToString() + string122;
      }
      return num > (long) Class15.smethod_0(0) ? str + Class13.smethod_0(151412) + num.ToString() + string122 : str + string122;
    }
    if (number >= (long) Class15.smethod_0(442))
    {
      string string123 = GClass109.string_123;
      long num = number % (long) Class15.smethod_0(442) / (long) Class15.smethod_0(181);
      number /= (long) Class15.smethod_0(442);
      string str = number.ToString() + string.Empty;
      if (num >= (long) Class15.smethod_0(31))
      {
        if ((num % (long) Class15.smethod_0(31) == 0L ? 0 : 1) == 0)
          num /= (long) Class15.smethod_0(31);
        return str + Class13.smethod_0(151312) + num.ToString() + string123;
      }
      return num > (long) Class15.smethod_0(0) ? str + Class13.smethod_0(151412) + num.ToString() + string123 : str + string123;
    }
    if (number < (long) Class15.smethod_0(181))
      return number.ToString() + string.Empty;
    string str1 = Class13.smethod_0(151409);
    long num1 = number % (long) Class15.smethod_0(15) / (long) Class15.smethod_0(31);
    number /= (long) Class15.smethod_0(15);
    string str2 = number.ToString() + string.Empty;
    if (num1 >= (long) Class15.smethod_0(31))
    {
      if ((num1 % (long) Class15.smethod_0(31) == 0L ? 0 : 1) == 0)
        num1 /= (long) Class15.smethod_0(31);
      return str2 + Class13.smethod_0(151312) + num1.ToString() + str1;
    }
    return num1 > (long) Class15.smethod_0(0) ? str2 + Class13.smethod_0(151412) + num1.ToString() + str1 : str2 + str1;
  }

  static GClass151()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(560)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.mBqmnnbYPbRH));
    GClass151.short_0 = (short[]) Class15.smethod_4(byte_0);
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(151475);
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(151542);
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(151501);
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(151069);
    strArray[Class15.smethod_0(2)] = string.Empty;
    GClass151.string_0 = strArray;
    GClass151.gclass134_0 = new GClass134();
    GClass151.gclass130_0 = new GClass130();
  }
}
