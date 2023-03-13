// Decompiled with JetBrains decompiler
// Type: GClass72
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass72
{
  public string s;
  private GClass97 gclass97_0;
  public int speed = Class15.smethod_0(152);
  public GClass20 charInfo;
  public bool isChatServer;
  public bool isOnline;
  public int timeCount;
  public int maxTime;
  public long last;
  public long curr;

  public GClass72(string s)
  {
    this.gclass97_0 = GClass97.gclass97_14;
    this.s = s;
    this.speed = Class15.smethod_0(51);
  }

  public GClass72(string s, GClass97 f, int speed)
  {
    this.gclass97_0 = f;
    this.s = s;
    this.speed = speed;
  }
}
