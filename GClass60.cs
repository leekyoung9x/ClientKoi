// Decompiled with JetBrains decompiler
// Type: GClass60
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass60
{
  public int frameWidth;
  public int frameHeight;
  public int nFrame;
  public GClass66 imgFrame;
  public int Id = -1;
  public int numWidth;
  public int numHeight;

  public GClass60(int ID)
  {
    this.Id = ID;
    GClass66 gclass66 = GClass54.smethod_0(ID);
    if ((gclass66 == null ? 1 : 0) != 0)
      return;
    this.imgFrame = gclass66;
    this.frameWidth = (int) GClass54.short_4[ID][Class15.smethod_0(0)];
    this.frameHeight = (int) GClass54.short_4[ID][Class15.smethod_0(1)] / (int) GClass54.short_4[ID][Class15.smethod_0(7)];
    this.nFrame = (int) GClass54.short_4[ID][Class15.smethod_0(7)];
  }

  public GClass60(GClass66 img, int width, int height)
  {
    if ((img == null ? 1 : 0) != 0)
      return;
    this.imgFrame = img;
    this.frameWidth = width;
    this.frameHeight = height;
    this.nFrame = img.method_1() / height;
    if (this.nFrame >= Class15.smethod_0(1))
      return;
    this.nFrame = Class15.smethod_0(1);
  }

  public GClass60(GClass66 img, int numW, int numH, int numNull)
  {
    if ((img == null ? 1 : 0) != 0)
      return;
    this.imgFrame = img;
    this.numWidth = numW;
    this.numHeight = numH;
    this.frameWidth = this.imgFrame.method_0() / numW;
    this.frameHeight = this.imgFrame.method_1() / numH;
    this.nFrame = numW * numH - numNull;
  }

  public void method_0(int idx, int x, int y, int trans, int anchor, GClass98 g)
  {
    try
    {
      if ((this.imgFrame == null ? 1 : 0) != 0)
        return;
      if (idx > this.nFrame)
        idx = this.nFrame;
      int num1 = idx * this.frameHeight;
      if (num1 > this.frameHeight * (this.nFrame - Class15.smethod_0(1)) || num1 < Class15.smethod_0(0))
      {
        int num2 = this.frameHeight * (this.nFrame - Class15.smethod_0(1));
      }
      g.method_24(this.imgFrame, Class15.smethod_0(0), idx * this.frameHeight, this.frameWidth, this.frameHeight, trans, x, y, anchor);
    }
    catch (Exception ex)
    {
    }
  }
}
