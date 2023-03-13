// Decompiled with JetBrains decompiler
// Type: GClass35
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Threading;
using UnityEngine;

public class GClass35
{
  public GClass131 r;
  private const int int_0 = 5;
  private const int int_1 = 500;
  public static GClass35 gclass35_0;
  private static int int_2;
  private static string string_0;

  public GClass35(string filename) => this.r = new GClass131(GClass1.smethod_0(((TextAsset) Resources.Load(filename, typeof (TextAsset))).bytes));

  public GClass35(sbyte[] data) => this.r = new GClass131(data);

  public static void smethod_0()
  {
    if (GClass35.int_2 != Class15.smethod_0(7))
      return;
    GClass35.int_2 = Class15.smethod_0(1);
    GClass35.gclass35_0 = GClass35.smethod_3(GClass35.string_0);
    GClass35.int_2 = Class15.smethod_0(0);
  }

  public static GClass35 smethod_1(string filename) => GClass35.smethod_3(filename);

  private static GClass35 smethod_2(string string_1)
  {
    if ((GClass35.int_2 == 0 ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < Class15.smethod_0(16); index += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass35.int_2 == 0 ? 1 : 0) != 0)
          break;
      }
      if ((GClass35.int_2 == 0 ? 1 : 0) == 0)
      {
        Debug.LogError((object) (Class13.smethod_0(26806) + string_1 + Class13.smethod_0(26782) + GClass35.string_0));
        return (GClass35) null;
      }
    }
    GClass35.gclass35_0 = (GClass35) null;
    GClass35.string_0 = string_1;
    GClass35.int_2 = Class15.smethod_0(7);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass35.int_2 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num != Class15.smethod_0(16))
      return GClass35.gclass35_0;
    Debug.LogError((object) (Class13.smethod_0(26767) + string_1));
    GClass35.int_2 = Class15.smethod_0(0);
    return (GClass35) null;
  }

  private static GClass35 smethod_3(string string_1)
  {
    try
    {
      return new GClass35(string_1);
    }
    catch (Exception ex)
    {
      return (GClass35) null;
    }
  }

  public short method_0() => this.r.method_6();

  public int method_1() => this.r.method_8();

  public int method_2() => (int) this.r.method_5();

  public void method_3(ref sbyte[] data) => this.r.method_16(ref data);

  public void method_4() => this.r.method_19();

  public void method_5() => this.r.method_19();

  public string method_6() => this.r.method_14();

  public sbyte method_7() => this.r.method_2();

  public long method_8() => this.r.method_9();

  public bool method_9() => this.r.method_11();

  public int method_10() => (int) (byte) this.r.method_2();

  public int method_11() => (int) this.r.method_7();

  public void method_12(ref sbyte[] data) => this.r.method_16(ref data);

  public int method_13() => this.r.method_18();

  internal void method_14(ref sbyte[] sbyte_0, int int_3, int int_4) => throw new NotImplementedException();
}
