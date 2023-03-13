// Decompiled with JetBrains decompiler
// Type: GClass76
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Runtime.InteropServices;
using UnityEngine;

public class GClass76
{
  public static string string_0;
  public static string string_1;

  [DllImport("__Internal")]
  private static extern void _SMSsend(string string_2, string string_3, int int_0);

  [DllImport("__Internal")]
  private static extern int _unpause();

  [DllImport("__Internal")]
  private static extern int _checkRotation();

  [DllImport("__Internal")]
  private static extern int _back();

  [DllImport("__Internal")]
  private static extern int _Send();

  [DllImport("__Internal")]
  private static extern void _purchaseItem(string string_2, string string_3, string string_4);

  public static int smethod_0()
  {
    if (Application.platform == (RuntimePlatform) Class15.smethod_0(88))
      return GClass76.smethod_1();
    GClass76.string_0 = GClass78.iPhoneGeneration_0.ToString();
    string empty1 = string.Empty;
    char ch = GClass76.string_0[Class15.smethod_0(7)];
    string str1 = ch.ToString();
    if ((!(empty1 + str1 == Class13.smethod_0(120882)) ? 1 : 0) == 0 && GClass76.string_0.Length > Class15.smethod_0(37))
    {
      GClass76.string_1 = SystemInfo.operatingSystem.ToString();
      string empty2 = string.Empty;
      ch = GClass76.string_1[Class15.smethod_0(31)];
      string str2 = ch.ToString();
      string str3 = empty2 + str2;
      return (!(str3 != Class13.smethod_0(120877)) ? 1 : 0) == 0 && (!(str3 != Class13.smethod_0(120871)) ? 1 : 0) == 0 ? Class15.smethod_0(0) : Class15.smethod_0(1);
    }
    GClass33.smethod_0(GClass76.string_0 + Class13.smethod_0(120869));
    return (!(GClass76.string_0 == Class13.smethod_0(120862)) ? 1 : 0) == 0 && (double) GClass153.float_0 * (double) GClass153.float_1 < (double) Class15.smethod_2(22) ? Class15.smethod_0(0) : -1;
  }

  public static int smethod_1() => GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(5) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(88) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(67) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(47) ? -1 : Class15.smethod_0(0);

  public static void smethod_2(string phonenumber, string bodytext, int n)
  {
    if ((Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) != 0)
      return;
    GClass76._SMSsend(phonenumber, bodytext, n);
  }

  public static void smethod_3()
  {
    if ((Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) != 0)
      return;
    GClass76._back();
  }

  public static void smethod_4()
  {
    if ((Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) != 0)
      return;
    GClass76._Send();
  }

  public static int smethod_5() => (Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) == 0 ? GClass76._unpause() : Class15.smethod_0(0);

  public static int smethod_6() => (Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) == 0 ? GClass76._checkRotation() : Class15.smethod_0(0);

  public static void smethod_7(string itemID, string userName, string gameID)
  {
    if ((Application.platform == RuntimePlatform.OSXEditor ? 1 : 0) != 0)
      return;
    GClass76._purchaseItem(itemID, userName, gameID);
  }
}
