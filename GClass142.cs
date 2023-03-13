// Decompiled with JetBrains decompiler
// Type: GClass142
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass142
{
  public int type;
  public GClass143[] pi;

  public GClass142(int type)
  {
    this.type = type;
    if ((type == 0 ? 0 : 1) == 0)
      this.pi = new GClass143[Class15.smethod_0(5)];
    if (type == Class15.smethod_0(1))
      this.pi = new GClass143[Class15.smethod_0(186)];
    if (type == Class15.smethod_0(7))
      this.pi = new GClass143[Class15.smethod_0(49)];
    if (type != Class15.smethod_0(5))
      return;
    this.pi = new GClass143[Class15.smethod_0(7)];
  }
}
