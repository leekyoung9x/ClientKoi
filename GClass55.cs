// Decompiled with JetBrains decompiler
// Type: GClass55
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass55
{
  public int x;
  public int y;
  public int anchor;
  public sbyte follow;
  public sbyte count;
  public sbyte dir = (sbyte) Class15.smethod_0(1);
  public short index = -1;

  public GClass55(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public GClass55(int x, int y, int fol)
  {
    this.x = x;
    this.y = y;
    this.follow = (sbyte) fol;
  }

  public GClass55()
  {
  }
}
