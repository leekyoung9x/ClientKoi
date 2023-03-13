// Decompiled with JetBrains decompiler
// Type: GClass191
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass191
{
  public short smallID;
  public GClass70 info;
  public int dir;
  public int f;
  public int tF;
  public int cmtoY;
  public int cmy;
  public int cmdy;
  public int cmvy;
  public int cmyLim;
  public int cmtoX;
  public int cmx;
  public int cmdx;
  public int cmvx;
  public int cmxLim;
  public int fimg;
  public int wimg;
  public int himg;
  private int[] int_0;
  private int int_1;

  public GClass191()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.LJNNAsxGblQy));
    this.int_0 = (int[]) Class15.smethod_4(byte_0);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.f = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
  }

  public void method_0(int fimg, int[] frameNew, int wimg, int himg)
  {
    if (fimg < Class15.smethod_0(1))
      return;
    this.fimg = fimg;
    this.int_0 = frameNew;
    this.wimg = wimg;
    this.himg = himg;
  }

  public void method_1(GClass98 g)
  {
    int w = Class15.smethod_0(120);
    int h = Class15.smethod_0(120);
    int num = GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0);
    if (this.fimg > Class15.smethod_0(0))
    {
      w = this.wimg;
      h = this.himg;
      num = Class15.smethod_0(0);
    }
    GClass169.smethod_7(g, (int) this.smallID, this.f, this.cmx, this.cmy + Class15.smethod_0(5) + num, w, h, this.dir != Class15.smethod_0(1) ? Class15.smethod_0(7) : Class15.smethod_0(0), GClass177.int_6);
  }

  public void method_2()
  {
    this.method_4();
    if ((GClass62.int_8 % Class15.smethod_0(5) == 0 ? 0 : 1) == 0)
    {
      this.f = this.int_0[this.int_1];
      this.int_1 += Class15.smethod_0(1);
    }
    if (this.int_1 < this.int_0.Length)
      return;
    this.int_1 = Class15.smethod_0(0);
  }

  public void method_3() => GClass47.smethod_0(Class15.smethod_0(4), this.cmx, this.cmy + Class15.smethod_0(5) + (GClass62.int_8 % Class15.smethod_0(31) > Class15.smethod_0(3) ? Class15.smethod_0(1) : Class15.smethod_0(0)), Class15.smethod_0(1));

  public void method_4()
  {
    if (this.cmy != this.cmtoY)
    {
      this.cmvy = this.cmtoY - this.cmy << Class15.smethod_0(7);
      this.cmdy += this.cmvy;
      this.cmy += this.cmdy >> Class15.smethod_0(2);
      this.cmdy &= Class15.smethod_0(9);
    }
    if (this.cmx == this.cmtoX)
      return;
    this.cmvx = this.cmtoX - this.cmx << Class15.smethod_0(7);
    this.cmdx += this.cmvx;
    this.cmx += this.cmdx >> Class15.smethod_0(2);
    this.cmdx &= Class15.smethod_0(9);
  }
}
