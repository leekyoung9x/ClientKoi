// Decompiled with JetBrains decompiler
// Type: Class8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

internal class Class8
{
  public sbyte version;
  public string id;
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass134 gclass134_1 = new GClass134();

  public Class8(string string_0, sbyte sbyte_0)
  {
    this.id = string_0;
    this.version = sbyte_0;
  }

  public static void smethod_0()
  {
    GClass134 vID = new GClass134();
    sbyte[] data = GClass152.smethod_1(Class13.smethod_0(139319));
    if ((data == null ? 0 : 1) == 0)
    {
      GClass156.smethod_0().method_136(vID);
    }
    else
    {
      Class8.gclass134_1 = new GClass134();
      GClass35 gclass35 = new GClass35(data);
      if ((gclass35 == null ? 0 : 1) == 0)
        return;
      try
      {
        short length = gclass35.method_0();
        string[] strArray = new string[(int) length];
        sbyte[] numArray = new sbyte[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
        {
          strArray[index] = gclass35.method_6();
          numArray[index] = gclass35.method_7();
          Class8.gclass134_1.method_0((object) new Class8(strArray[index], numArray[index]));
        }
        gclass35.method_4();
      }
      catch (Exception ex)
      {
        ex.StackTrace.ToString();
      }
      string str1 = Class13.smethod_0(139294);
      int num = Class8.gclass134_0.method_2();
      string str2 = num.ToString();
      string str3 = Class13.smethod_0(139278);
      num = Class8.gclass134_1.method_2();
      string str4 = num.ToString();
      GClass151.smethod_7(str1 + str2 + str3 + str4);
      GClass156.smethod_0().method_136(vID);
    }
  }

  public static sbyte smethod_1(string string_0)
  {
    for (int index = Class15.smethod_0(0); index < Class8.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!string_0.Equals(((Class8) Class8.gclass134_1.method_3(index)).id) ? 1 : 0) == 0)
        return ((Class8) Class8.gclass134_1.method_3(index)).version;
    }
    return -1;
  }

  public static sbyte smethod_2(string string_0)
  {
    for (int index = Class15.smethod_0(0); index < Class8.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if ((!string_0.Equals(((Class8) Class8.gclass134_0.method_3(index)).id) ? 1 : 0) == 0)
        return ((Class8) Class8.gclass134_0.method_3(index)).version;
    }
    return -1;
  }

  public static bool smethod_3(string string_0)
  {
    for (int index = Class15.smethod_0(0); index < Class8.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!string_0.Equals(((Class8) Class8.gclass134_1.method_3(index)).id) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static void smethod_4()
  {
    GClass36 gclass36 = new GClass36();
    try
    {
      gclass36.method_0((short) Class8.gclass134_0.method_2());
      for (int index = Class15.smethod_0(0); index < Class8.gclass134_0.method_2(); index += Class15.smethod_0(1))
      {
        gclass36.method_6(((Class8) Class8.gclass134_0.method_3(index)).id);
        gclass36.method_5(((Class8) Class8.gclass134_0.method_3(index)).version);
      }
      GClass152.smethod_0(Class13.smethod_0(139396), gclass36.method_3());
      gclass36.method_4();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
  }
}
