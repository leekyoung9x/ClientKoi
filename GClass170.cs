// Decompiled with JetBrains decompiler
// Type: GClass170
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Threading;
using UnityEngine;

public class GClass170
{
  private const int int_0 = 5;
  private const int int_1 = 500;
  private static int int_2;
  private static int int_3;
  private static string string_0;
  private static string string_1;
  private static bool bool_0;
  private static int int_4;
  public static bool bool_1;
  private static int int_5;

  public static int smethod_0(string content, string to) => (!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0 ? GClass170.smethod_2(content, to) : GClass170.smethod_1(content, to);

  private static int smethod_1(string string_2, string string_3)
  {
    if ((GClass170.int_2 == 0 ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < Class15.smethod_0(16); index += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass170.int_2 == 0 ? 1 : 0) != 0)
          break;
      }
      if ((GClass170.int_2 == 0 ? 1 : 0) == 0)
      {
        GClass33.smethod_2(Class13.smethod_0(151208) + string_2 + Class13.smethod_0(151171) + GClass170.string_1);
        return -1;
      }
    }
    GClass170.string_1 = string_2;
    GClass170.string_0 = string_3;
    GClass170.int_3 = -1;
    GClass170.int_2 = Class15.smethod_0(7);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass170.int_2 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      Debug.LogError((object) (Class13.smethod_0(151284) + string_2));
      GClass170.int_2 = Class15.smethod_0(0);
    }
    else
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(151261);
      strArray[Class15.smethod_0(1)] = string_2;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(143679);
      strArray[Class15.smethod_0(5)] = (num * Class15.smethod_0(3)).ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(143661);
      Debug.Log((object) string.Concat(strArray));
    }
    return GClass170.int_3;
  }

  private static int smethod_2(string string_2, string string_3)
  {
    int n = GClass76.smethod_0();
    GClass33.smethod_0(Class13.smethod_0(143621) + n.ToString());
    if (n >= Class15.smethod_0(0))
    {
      GClass170.bool_0 = Class15.smethod_0(1) != 0;
      GClass170.bool_1 = Class15.smethod_0(1) != 0;
      GClass76.smethod_2(string_3, string_2, n);
      Screen.orientation = (ScreenOrientation) Class15.smethod_0(3);
    }
    return n;
  }

  public static void smethod_3()
  {
    if ((double) Time.time - (double) GClass170.int_4 > (double) Class15.smethod_2(16))
      GClass170.int_4 += Class15.smethod_0(1);
    if ((!GClass170.bool_0 ? 1 : 0) == 0)
      GClass170.smethod_4();
    if (GClass170.int_2 != Class15.smethod_0(7))
      return;
    GClass170.int_2 = Class15.smethod_0(1);
    try
    {
      GClass170.int_3 = GClass170.smethod_2(GClass170.string_1, GClass170.string_0);
    }
    catch (Exception ex)
    {
      Debug.Log((object) Class13.smethod_0(143803));
    }
    GClass170.int_2 = Class15.smethod_0(0);
  }

  private static void smethod_4()
  {
    if ((!GClass170.bool_1 ? 1 : 0) == 0)
    {
      if (GClass76.smethod_6() == Class15.smethod_0(1))
        Screen.orientation = (ScreenOrientation) Class15.smethod_0(5);
      else if (GClass76.smethod_6() == -1)
        Screen.orientation = (ScreenOrientation) Class15.smethod_0(1);
      else if ((GClass76.smethod_6() == 0 ? 0 : 1) == 0)
        Screen.orientation = (ScreenOrientation) Class15.smethod_0(3);
      else if (GClass76.smethod_6() == Class15.smethod_0(7))
        Screen.orientation = (ScreenOrientation) Class15.smethod_0(2);
      else if (GClass76.smethod_6() == Class15.smethod_0(5))
        Screen.orientation = (ScreenOrientation) Class15.smethod_0(7);
      if (GClass170.int_5 < Class15.smethod_0(3))
      {
        GClass170.int_5 += Class15.smethod_0(1);
      }
      else
      {
        GClass76.smethod_4();
        GClass170.bool_1 = Class15.smethod_0(0) != 0;
        GClass170.int_5 = Class15.smethod_0(0);
      }
    }
    if (GClass76.smethod_5() != Class15.smethod_0(1))
      return;
    Screen.orientation = (ScreenOrientation) Class15.smethod_0(5);
    if (GClass170.int_5 < Class15.smethod_0(3))
    {
      GClass170.int_5 += Class15.smethod_0(1);
    }
    else
    {
      GClass170.bool_0 = Class15.smethod_0(0) != 0;
      GClass76.smethod_3();
      GClass170.int_5 = Class15.smethod_0(0);
    }
  }
}
