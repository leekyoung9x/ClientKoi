// Decompiled with JetBrains decompiler
// Type: Class3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using UnityEngine;

internal class Class3
{
  public static WWW www_0;
  public static GClass31 gclass31_0;

  public static void smethod_0()
  {
    if ((Class3.www_0 == null ? 1 : 0) != 0 || (!Class3.www_0.isDone ? 1 : 0) != 0)
      return;
    string str = string.Empty;
    if ((Class3.www_0.error == null ? 1 : 0) != 0 || (!Class3.www_0.error.Equals(string.Empty) ? 1 : 0) == 0)
      str = Class3.www_0.text;
    Class3.www_0 = (WWW) null;
    if ((Class3.gclass31_0 == null ? 1 : 0) != 0)
      return;
    Class3.gclass31_0.method_0(str);
  }

  public static void smethod_1(string string_0, GClass31 gclass31_1)
  {
    if ((Class3.www_0 == null ? 1 : 0) == 0)
      GClass33.smethod_2(Class13.smethod_0(154957));
    Class3.www_0 = new WWW(string_0);
    Class3.gclass31_0 = gclass31_1;
  }

  public static void smethod_2(string string_0, GClass31 gclass31_1)
  {
    Class3.gclass31_0 = gclass31_1;
    if ((string_0 == null ? 1 : 0) != 0)
      return;
    gclass31_1.method_0(string_0);
  }
}
