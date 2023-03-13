// Decompiled with JetBrains decompiler
// Type: GClass167
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass167
{
  public sbyte id;
  public int classId;
  public string name;
  public int maxPoint;
  public int manaUseType;
  public int type;
  public int iconId;
  public string[] description;
  public GClass161[] skills;
  public string damInfo;

  public bool method_0() => this.type == Class15.smethod_0(7) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public bool method_1() => this.type == Class15.smethod_0(5) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public bool method_2() => this.type == Class15.smethod_0(1) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
}
