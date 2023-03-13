// Decompiled with JetBrains decompiler
// Type: Class21
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Reflection;

[DefaultMember("\uE99E\uF06D\uEFC0\uEFF5\uEBD3\uF0EA\uEAD3\uE052\uF012\uF121\uF0DD\uE573\uE016\uE787\uE96B\uE912\uE4CE\uE84A\uE638\uEC5D")]
internal class Class21
{
  private int[] int_0;
  private int int_1;

  public int Int32_0 => this.int_1;

  public int get_Item(int index) => this.int_0[index];

  public Class21() => this.int_0 = new int[16];

  public int method_0(int int_2)
  {
    if (this.int_1 == this.int_0.Length)
    {
      int[] destinationArray = new int[this.int_1 * 2];
      Array.Copy((Array) this.int_0, 0, (Array) destinationArray, 0, this.int_1);
      this.int_0 = destinationArray;
    }
    this.int_0[this.int_1] = int_2;
    return this.int_1++;
  }

  public int[] method_1()
  {
    int[] destinationArray = new int[this.int_1];
    Array.Copy((Array) this.int_0, 0, (Array) destinationArray, 0, this.int_1);
    return destinationArray;
  }
}
