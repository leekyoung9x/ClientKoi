// Decompiled with JetBrains decompiler
// Type: GClass130
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass130
{
  public Random r;

  public GClass130() => this.r = new Random();

  public int method_0() => this.r.Next();

  public int method_1(int a) => this.r.Next(a);

  public int method_2(int a, int b) => this.r.Next(a, b);
}
