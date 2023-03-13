// Decompiled with JetBrains decompiler
// Type: GClass152
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class GClass152
{
  public static int int_0;
  public static sbyte[] sbyte_0;
  public static string string_0;
  private const int int_1 = 5;
  private const int int_2 = 500;

  public static void smethod_0(string filename, sbyte[] data)
  {
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0)
      GClass152.smethod_11(filename, data);
    else
      GClass152.smethod_5(filename, data);
  }

  public static sbyte[] smethod_1(string filename) => (!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0 ? GClass152.smethod_12(filename) : GClass152.smethod_6(filename);

  public static string smethod_2(string fileName)
  {
    sbyte[] data = GClass152.smethod_1(fileName);
    if ((data == null ? 0 : 1) == 0)
      return (string) null;
    GClass35 gclass35 = new GClass35(data);
    try
    {
      string str = gclass35.method_6();
      gclass35.method_4();
      return str;
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.StackTrace);
    }
    return (string) null;
  }

  public static byte[] smethod_3(sbyte[] var)
  {
    byte[] numArray = new byte[var.Length];
    for (int index = Class15.smethod_0(0); index < var.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) var[index] <= Class15.smethod_0(0) ? (byte) ((uint) var[index] + (uint) Class15.smethod_0(290)) : (byte) var[index];
    return numArray;
  }

  public static void smethod_4(string filename, string data)
  {
    GClass36 gclass36 = new GClass36();
    try
    {
      gclass36.method_6(data);
      GClass152.smethod_0(filename, gclass36.method_3());
      gclass36.method_4();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.StackTrace);
    }
  }

  private static void smethod_5(string string_1, sbyte[] sbyte_1)
  {
    if ((GClass152.int_0 == 0 ? 1 : 0) == 0)
    {
      Debug.LogError((object) (Class13.smethod_0(147963) + string_1 + Class13.smethod_0(147480) + GClass152.string_0));
    }
    else
    {
      GClass152.string_0 = string_1;
      GClass152.sbyte_0 = sbyte_1;
      GClass152.int_0 = Class15.smethod_0(7);
      int num;
      for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass152.int_0 == 0 ? 1 : 0) != 0)
          break;
      }
      if (num != Class15.smethod_0(16))
        return;
      Debug.LogError((object) (Class13.smethod_0(147535) + string_1));
    }
  }

  private static sbyte[] smethod_6(string string_1)
  {
    if ((GClass152.int_0 == 0 ? 1 : 0) == 0)
    {
      Debug.LogError((object) (Class13.smethod_0(147638) + string_1 + Class13.smethod_0(148457) + GClass152.string_0));
      return (sbyte[]) null;
    }
    GClass152.string_0 = string_1;
    GClass152.sbyte_0 = (sbyte[]) null;
    GClass152.int_0 = Class15.smethod_0(5);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass152.int_0 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
      Debug.LogError((object) (Class13.smethod_0(149483) + string_1));
    return GClass152.sbyte_0;
  }

  public static void smethod_7()
  {
    if (GClass152.int_0 == Class15.smethod_0(7))
    {
      GClass152.int_0 = Class15.smethod_0(1);
      GClass152.smethod_11(GClass152.string_0, GClass152.sbyte_0);
      GClass152.int_0 = Class15.smethod_0(0);
    }
    else
    {
      if (GClass152.int_0 != Class15.smethod_0(5))
        return;
      GClass152.int_0 = Class15.smethod_0(1);
      GClass152.sbyte_0 = GClass152.smethod_12(GClass152.string_0);
      GClass152.int_0 = Class15.smethod_0(0);
    }
  }

  public static int smethod_8(string file)
  {
    sbyte[] numArray = GClass152.smethod_1(file);
    return (numArray == null ? 0 : 1) == 0 ? -1 : (int) numArray[Class15.smethod_0(0)];
  }

  public static void smethod_9(string file, int x)
  {
    try
    {
      string filename = file;
      sbyte[] data = new sbyte[Class15.smethod_0(1)];
      data[Class15.smethod_0(0)] = (sbyte) x;
      GClass152.smethod_0(filename, data);
    }
    catch (Exception ex)
    {
    }
  }

  public static string smethod_10() => Application.persistentDataPath;

  private static void smethod_11(string string_1, sbyte[] sbyte_1)
  {
    string path = GClass152.smethod_10() + Class13.smethod_0(149041) + string_1;
    FileStream fileStream = new FileStream(path, (FileMode) Class15.smethod_0(7));
    fileStream.Write(GClass1.smethod_1(sbyte_1), Class15.smethod_0(0), sbyte_1.Length);
    fileStream.Flush();
    fileStream.Close();
    Main.smethod_0(path);
  }

  private static sbyte[] smethod_12(string string_1)
  {
    try
    {
      FileStream fileStream = new FileStream(GClass152.smethod_10() + Class13.smethod_0(149011) + string_1, (FileMode) Class15.smethod_0(5));
      byte[] numArray = new byte[fileStream.Length];
      fileStream.Read(numArray, Class15.smethod_0(0), numArray.Length);
      fileStream.Close();
      GClass1.smethod_0(numArray);
      return GClass1.smethod_0(numArray);
    }
    catch (Exception ex)
    {
      return (sbyte[]) null;
    }
  }

  public static void smethod_13()
  {
    GClass33.smethod_4(Class13.smethod_0(149001));
    FileInfo[] files = new DirectoryInfo(GClass152.smethod_10() + Class13.smethod_0(149105)).GetFiles();
    for (int index = Class15.smethod_0(0); index < files.Length; index += Class15.smethod_0(1))
      files[index].Delete();
  }

  public static void smethod_14(string path)
  {
    try
    {
      File.Delete(GClass152.smethod_10() + Class13.smethod_0(149084) + path);
    }
    catch (Exception ex)
    {
    }
  }

  public static string smethod_15(byte[] ba) => BitConverter.ToString(ba).Replace(Class13.smethod_0(149177), string.Empty);

  public static byte[] smethod_16(string hex)
  {
    int length = hex.Length;
    byte[] numArray = new byte[length / Class15.smethod_0(7)];
    for (int startIndex = Class15.smethod_0(0); startIndex < length; startIndex += Class15.smethod_0(7))
      numArray[startIndex / Class15.smethod_0(7)] = Convert.ToByte(hex.Substring(startIndex, Class15.smethod_0(7)), Class15.smethod_0(10));
    return numArray;
  }

  public static void smethod_17(string name)
  {
    try
    {
      PlayerPrefs.DeleteKey(name);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(150500) + ex.ToString());
    }
  }

  public static void smethod_18()
  {
    GClass152.smethod_17(Class13.smethod_0(150064));
    GClass152.smethod_17(Class13.smethod_0(150676));
    GClass152.smethod_17(Class13.smethod_0(150768));
    GClass152.smethod_17(Class13.smethod_0(150756));
    GClass152.smethod_17(Class13.smethod_0(150745));
    GClass152.smethod_17(Class13.smethod_0(150737));
    GClass152.smethod_17(Class13.smethod_0(151359));
    GClass152.smethod_17(Class13.smethod_0(151349));
  }

  public static void smethod_19(string strID) => GClass152.smethod_4(Class13.smethod_0(151337), strID);

  public static string smethod_20()
  {
    string str = GClass152.smethod_2(Class13.smethod_0(151328));
    return (str == null ? 0 : 1) == 0 ? (string) null : str;
  }
}
