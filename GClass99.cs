// Decompiled with JetBrains decompiler
// Type: GClass99
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass99
{
  public int x1;
  public int x2;
  public int y1;
  public int y2;
  public float r;
  public float b;
  public float g;
  public float a;

  public GClass99(int x1, int y1, int x2, int y2, int cl)
  {
    this.x1 = x1;
    this.y1 = y1;
    this.x2 = x2;
    this.y2 = y2;
    this.method_0(cl);
  }

  public void method_0(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    this.b = (float) num1 / Class15.smethod_2(21);
    this.g = (float) num2 / Class15.smethod_2(21);
    this.r = (float) num3 / Class15.smethod_2(21);
    this.a = Class15.smethod_2(8);
  }
}
