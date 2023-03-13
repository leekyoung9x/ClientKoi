// Decompiled with JetBrains decompiler
// Type: GClass153
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;
using UnityEngine;

public class GClass153
{
  public static bool bool_0;
  public static float float_0;
  public static float float_1;
  private static List<Matrix4x4> list_0 = new List<Matrix4x4>();

  public static void smethod_0()
  {
    string str1 = Class13.smethod_0(151310);
    int num = Screen.width;
    string str2 = num.ToString();
    string str3 = Class13.smethod_0(151403);
    num = Screen.height;
    string str4 = num.ToString();
    GClass33.smethod_0(str1 + str2 + str3 + str4);
    GClass153.float_0 = (float) Screen.width;
    GClass153.float_1 = (float) Screen.height;
    GClass153.bool_0 = Class15.smethod_0(0) != 0;
    int width = Screen.width;
    Class15.smethod_0(561);
  }

  public static void smethod_1()
  {
    if ((!GClass153.bool_0 ? 1 : 0) != 0)
      return;
    GClass153.list_0.Add(GUI.matrix);
    Matrix4x4 matrix4x4 = new Matrix4x4();
    double num1 = (double) Screen.width / (double) Screen.height;
    Class15.smethod_2(16);
    Vector3 zero = Vector3.zero;
    double num2 = (double) GClass153.float_0 / (double) GClass153.float_1;
    float num3 = num1 >= num2 ? (float) Screen.height / GClass153.float_1 : (float) Screen.width / GClass153.float_0;
    matrix4x4.SetTRS(zero, Quaternion.identity, Vector3.one * num3);
    GUI.matrix *= matrix4x4;
  }

  public static void smethod_2()
  {
    if ((!GClass153.bool_0 ? 1 : 0) != 0)
      return;
    GUI.matrix = GClass153.list_0[GClass153.list_0.Count - Class15.smethod_0(1)];
    GClass153.list_0.RemoveAt(GClass153.list_0.Count - Class15.smethod_0(1));
  }

  public static float smethod_3(float x)
  {
    if ((!GClass153.bool_0 ? 0 : 1) == 0)
      return x;
    x = x * GClass153.float_0 / (float) Screen.width;
    return x;
  }

  public static float smethod_4(float y)
  {
    if ((!GClass153.bool_0 ? 0 : 1) == 0)
      return y;
    y = y * GClass153.float_1 / (float) Screen.height;
    return y;
  }
}
