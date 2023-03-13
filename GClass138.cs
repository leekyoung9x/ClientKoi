// Decompiled with JetBrains decompiler
// Type: GClass138
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass138
{
  public static void smethod_0() => GClass62.smethod_27();

  public void method_0() => GClass62.smethod_29(GClass109.string_87);

  public static int smethod_1(int max) => new GClass130().method_1(max);

  public static sbyte[] smethod_2(GClass96 msg)
  {
    try
    {
      sbyte[] data = new sbyte[msg.method_1().method_8()];
      msg.method_1().method_16(ref data);
      return data;
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(154876));
    }
    return (sbyte[]) null;
  }

  public static sbyte[] smethod_3(GClass131 dos)
  {
    try
    {
      sbyte[] data = new sbyte[dos.method_8()];
      dos.method_16(ref data);
      return data;
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(154827));
    }
    return (sbyte[]) null;
  }

  public static string smethod_4(string text, string regex, string replacement) => text.Replace(regex, replacement);

  public static string smethod_5(string number)
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    if ((!number.Equals(string.Empty) ? 1 : 0) == 0)
      return str1;
    if ((int) number[Class15.smethod_0(0)] == Class15.smethod_0(70))
    {
      str2 = Class13.smethod_0(155428);
      number = number.Substring(Class15.smethod_0(1));
    }
    for (int index = number.Length - Class15.smethod_0(1); index >= Class15.smethod_0(0); index -= Class15.smethod_0(1))
      str1 = ((number.Length - Class15.smethod_0(1) - index) % Class15.smethod_0(5) == 0 ? 0 : 1) != 0 || number.Length - Class15.smethod_0(1) - index <= Class15.smethod_0(0) ? number[index].ToString() + str1 : number[index].ToString() + Class13.smethod_0(155426) + str1;
    return str2 + str1;
  }

  public static string smethod_6(int second)
  {
    long num = (long) second * (long) Class15.smethod_0(15);
    DateTime dateTime = new DateTime(Class15.smethod_0(443), Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), (DateTimeKind) Class15.smethod_0(1));
    dateTime = dateTime.Add(new TimeSpan(num * (long) Class15.smethod_0(181)));
    DateTime universalTime = dateTime.ToUniversalTime();
    int hour = universalTime.Hour;
    int minute = universalTime.Minute;
    int day = universalTime.Day;
    int month = universalTime.Month;
    int year = universalTime.Year;
    string[] strArray = new string[Class15.smethod_0(88)];
    strArray[Class15.smethod_0(0)] = day.ToString();
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(155512);
    strArray[Class15.smethod_0(7)] = month.ToString();
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(155512);
    strArray[Class15.smethod_0(2)] = year.ToString();
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(155582);
    strArray[Class15.smethod_0(37)] = hour.ToString();
    strArray[Class15.smethod_0(38)] = Class13.smethod_0(155569);
    return string.Concat(strArray);
  }

  public static string smethod_7(long second)
  {
    long num = second + (long) Class15.smethod_0(460);
    DateTime dateTime = new DateTime(Class15.smethod_0(443), Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), (DateTimeKind) Class15.smethod_0(1));
    dateTime = dateTime.Add(new TimeSpan(num * (long) Class15.smethod_0(181)));
    DateTime universalTime = dateTime.ToUniversalTime();
    int hour = universalTime.Hour;
    int minute = universalTime.Minute;
    return hour.ToString() + Class13.smethod_0(155535) + minute.ToString() + Class13.smethod_0(155533);
  }

  public static string smethod_8(int timeRemainS)
  {
    int num1 = Class15.smethod_0(0);
    if (timeRemainS > Class15.smethod_0(4))
    {
      num1 = timeRemainS / Class15.smethod_0(4);
      timeRemainS %= Class15.smethod_0(4);
    }
    int num2 = Class15.smethod_0(0);
    if (num1 > Class15.smethod_0(4))
    {
      num2 = num1 / Class15.smethod_0(4);
      num1 %= Class15.smethod_0(4);
    }
    int num3 = Class15.smethod_0(0);
    if (num2 > Class15.smethod_0(40))
    {
      num3 = num2 / Class15.smethod_0(40);
      num2 %= Class15.smethod_0(40);
    }
    string empty = string.Empty;
    if (num3 > Class15.smethod_0(0))
      return empty + num3.ToString() + Class13.smethod_0(155629) + num2.ToString() + Class13.smethod_0(155627);
    if (num2 > Class15.smethod_0(0))
      return empty + num2.ToString() + Class13.smethod_0(155627) + num1.ToString() + Class13.smethod_0(155625);
    string str = (num1 <= Class15.smethod_0(45) ? empty + Class13.smethod_0(155623) + num1.ToString() : empty + num1.ToString()) + Class13.smethod_0(155612);
    return timeRemainS > Class15.smethod_0(45) ? str + timeRemainS.ToString() : str + Class13.smethod_0(155623) + timeRemainS.ToString();
  }

  public static string smethod_9(long m)
  {
    string str = string.Empty;
    long num1 = m / (long) Class15.smethod_0(15) + (long) Class15.smethod_0(1);
    for (int index = Class15.smethod_0(0); (long) index < num1; index += Class15.smethod_0(1))
    {
      if (m >= (long) Class15.smethod_0(15))
      {
        long num2 = m % (long) Class15.smethod_0(15);
        str = (num2 == 0L ? 0 : 1) != 0 ? (num2 >= (long) Class15.smethod_0(31) ? (num2 >= (long) Class15.smethod_0(21) ? Class13.smethod_0(155160) + num2.ToString() + str : Class13.smethod_0(155163) + num2.ToString() + str) : Class13.smethod_0(155167) + num2.ToString() + str) : Class13.smethod_0(155174) + str;
        m /= (long) Class15.smethod_0(15);
      }
      else
      {
        str = m.ToString() + str;
        break;
      }
    }
    return str;
  }

  public static string smethod_10(int timeRemainS)
  {
    int num1 = Class15.smethod_0(0);
    if (timeRemainS > Class15.smethod_0(4))
    {
      num1 = timeRemainS / Class15.smethod_0(4);
      timeRemainS %= Class15.smethod_0(4);
    }
    int num2 = Class15.smethod_0(0);
    if (num1 > Class15.smethod_0(4))
    {
      num2 = num1 / Class15.smethod_0(4);
      num1 %= Class15.smethod_0(4);
    }
    int num3 = Class15.smethod_0(0);
    if (num2 > Class15.smethod_0(40))
    {
      num3 = num2 / Class15.smethod_0(40);
      num2 %= Class15.smethod_0(40);
    }
    string empty = string.Empty;
    if (num3 > Class15.smethod_0(0))
      return empty + num3.ToString() + Class13.smethod_0(155312) + num2.ToString() + Class13.smethod_0(155383);
    if (num2 > Class15.smethod_0(0))
      return empty + num2.ToString() + Class13.smethod_0(155383) + num1.ToString() + Class13.smethod_0(147849);
    if ((num1 == 0 ? 0 : 1) == 0)
      num1 = Class15.smethod_0(1);
    return empty + num1.ToString() + Class13.smethod_0(147847);
  }

  public static string[] smethod_11(string original, string separator)
  {
    GClass134 gclass134 = new GClass134();
    for (int length = original.IndexOf(separator); length >= Class15.smethod_0(0); length = original.IndexOf(separator))
    {
      gclass134.method_0((object) original.Substring(Class15.smethod_0(0), length));
      original = original.Substring(length + separator.Length);
    }
    gclass134.method_0((object) original);
    string[] strArray = new string[gclass134.method_2()];
    if (gclass134.method_2() > Class15.smethod_0(0))
    {
      for (int index = Class15.smethod_0(0); index < gclass134.method_2(); index += Class15.smethod_0(1))
        strArray[index] = (string) gclass134.method_3(index);
    }
    return strArray;
  }
}
