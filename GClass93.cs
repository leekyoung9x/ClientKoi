// Decompiled with JetBrains decompiler
// Type: GClass93
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass93
{
  public const double double_0 = 3.1415926535897931;

  public static int smethod_0(int i) => i > Class15.smethod_0(0) ? i : -i;

  public static int smethod_1(int x, int y) => x < y ? x : y;

  public static int smethod_2(int x, int y) => x > y ? x : y;

  public static int smethod_3(int data, int x)
  {
    int num = Class15.smethod_0(1);
    for (int index = Class15.smethod_0(0); index < x; index += Class15.smethod_0(1))
      num *= data;
    return num;
  }
}
