// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass1
{
  public static sbyte[] smethod_0(byte[] data)
  {
    sbyte[] numArray = new sbyte[data.Length];
    for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
      numArray[index] = (sbyte) data[index];
    return numArray;
  }

  public static byte[] smethod_1(sbyte[] data)
  {
    byte[] numArray = new byte[data.Length];
    for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
      numArray[index] = (byte) data[index];
    return numArray;
  }

  public static char[] smethod_2(sbyte[] data)
  {
    char[] chArray = new char[data.Length];
    for (int index = Class15.smethod_0(0); index < chArray.Length; index += Class15.smethod_0(1))
      chArray[index] = (char) data[index];
    return chArray;
  }
}
