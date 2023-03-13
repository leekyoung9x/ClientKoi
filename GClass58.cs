// Decompiled with JetBrains decompiler
// Type: GClass58
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass58
{
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private GClass130 gclass130_0;
  private GClass134 gclass134_0;
  private int[] int_4;

  public GClass58(int x, int y, int goc, int n)
  {
    byte[] byte_0 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.lLIshSVeNFjI));
    this.int_4 = (int[]) Class15.smethod_4(byte_0);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.int_0 = x;
    this.int_1 = y;
    this.int_2 = goc;
    this.int_3 = n;
    for (int index = Class15.smethod_0(0); index < n; index += Class15.smethod_0(1))
      this.gclass134_0.method_0((object) new GClass56(x, y, GClass93.smethod_0(this.gclass130_0.method_0() % Class15.smethod_0(88)) + Class15.smethod_0(5), index * goc, this.int_4[GClass93.smethod_0(this.gclass130_0.method_0() % this.int_4.Length)]));
  }

  public void method_0(GClass98 g)
  {
    for (int index = Class15.smethod_0(0); index < this.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass56 gclass56 = (GClass56) this.gclass134_0.method_3(index);
      if (gclass56.y < Class15.smethod_0(313))
        this.gclass134_0.method_7(index);
      gclass56.method_1(g);
    }
  }
}
