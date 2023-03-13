// Decompiled with JetBrains decompiler
// Type: GClass17
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass17
{
  public int x;
  public int y;
  public int xTo = Class15.smethod_0(147);
  public int yTo = Class15.smethod_0(147);
  public int count;
  public int vy;
  public int vx;
  public int dir;
  public int idImg;
  public bool isPaint = Class15.smethod_0(1) != 0;
  public bool isDone;
  public bool isSetImg;
  public GClass20 cFocus;

  public void method_0()
  {
    this.cFocus = new GClass20();
    this.cFocus.charID = GClass151.smethod_18(Class15.smethod_0(147), Class15.smethod_0(148));
    this.cFocus.head = -1;
    this.cFocus.body = -1;
    this.cFocus.leg = -1;
    this.cFocus.bag = -1;
    this.cFocus.cName = string.Empty;
    this.cFocus.cHP = this.cFocus.cHPFull = Class15.smethod_0(51);
  }

  public void method_1()
  {
    this.cFocus.cx = this.x;
    this.cFocus.cy = this.y;
  }
}
