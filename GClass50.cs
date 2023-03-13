// Decompiled with JetBrains decompiler
// Type: GClass50
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass50
{
  public GClass66 img;
  public GClass67[] imgInfo;
  public GClass59[] frame;
  public short[] arrFrame;
  public short[][] anim_data = new short[Class15.smethod_0(10)][];
  public int ID;
  public int typeData;
  public int width;
  public int height;

  public GClass67 method_0(sbyte id)
  {
    for (int index = Class15.smethod_0(0); index < this.imgInfo.Length; index += Class15.smethod_0(1))
    {
      if (this.imgInfo[index].ID == (int) id)
        return this.imgInfo[index];
    }
    return (GClass67) null;
  }

  public short[] method_1() => this.arrFrame;

  public short[] method_2(int index)
  {
    if (index >= this.anim_data.Length)
      index = Class15.smethod_0(0);
    return (this.anim_data[index] == null ? 0 : 1) == 0 ? new short[Class15.smethod_0(1)] : this.anim_data[index];
  }

  public void method_3(string patch)
  {
    GClass35 gclass35;
    try
    {
      gclass35 = GClass133.smethod_0(patch);
    }
    catch (Exception ex)
    {
      return;
    }
    this.method_6(gclass35.r);
  }

  public void method_4(string patch)
  {
    GClass35 gclass35;
    try
    {
      gclass35 = GClass133.smethod_0(patch);
    }
    catch (Exception ex)
    {
      return;
    }
    this.method_5(gclass35.r);
  }

  public void method_5(GClass131 msg)
  {
    int num1 = Class15.smethod_0(0);
    int num2 = Class15.smethod_0(0);
    int num3 = Class15.smethod_0(0);
    int num4 = Class15.smethod_0(0);
    try
    {
      sbyte length1 = msg.method_2();
      GClass151.smethod_7(Class13.smethod_0(27444) + length1.ToString());
      this.imgInfo = new GClass67[(int) length1];
      for (int index = Class15.smethod_0(0); index < (int) length1; index += Class15.smethod_0(1))
      {
        this.imgInfo[index] = new GClass67();
        this.imgInfo[index].ID = (int) msg.method_2();
        this.imgInfo[index].x0 = (int) msg.method_5();
        this.imgInfo[index].y0 = (int) msg.method_5();
        this.imgInfo[index].w = (int) msg.method_5();
        this.imgInfo[index].h = (int) msg.method_5();
      }
      this.frame = new GClass59[(int) msg.method_6()];
      for (int index1 = Class15.smethod_0(0); index1 < this.frame.Length; index1 += Class15.smethod_0(1))
      {
        this.frame[index1] = new GClass59();
        sbyte length2 = msg.method_2();
        this.frame[index1].dx = new short[(int) length2];
        this.frame[index1].dy = new short[(int) length2];
        this.frame[index1].idImg = new sbyte[(int) length2];
        for (int index2 = Class15.smethod_0(0); index2 < (int) length2; index2 += Class15.smethod_0(1))
        {
          this.frame[index1].dx[index2] = msg.method_6();
          this.frame[index1].dy[index2] = msg.method_6();
          this.frame[index1].idImg[index2] = msg.method_2();
          if ((index1 == 0 ? 0 : 1) == 0)
          {
            if (num1 > (int) this.frame[index1].dx[index2])
              num1 = (int) this.frame[index1].dx[index2];
            if (num2 > (int) this.frame[index1].dy[index2])
              num2 = (int) this.frame[index1].dy[index2];
            if (num3 < (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w)
              num3 = (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w;
            if (num4 < (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h)
              num4 = (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h;
            this.width = num3 - num1;
            this.height = num4 - num2;
          }
        }
      }
      this.arrFrame = new short[(int) msg.method_6()];
      for (int index = Class15.smethod_0(0); index < this.arrFrame.Length; index += Class15.smethod_0(1))
        this.arrFrame[index] = msg.method_6();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
      GClass151.smethod_7(Class13.smethod_0(27425));
    }
  }

  public void method_6(GClass131 iss)
  {
    int num1 = Class15.smethod_0(0);
    int num2 = Class15.smethod_0(0);
    int num3 = Class15.smethod_0(0);
    int num4 = Class15.smethod_0(0);
    try
    {
      sbyte length1 = iss.method_2();
      this.imgInfo = new GClass67[(int) length1];
      for (int index = Class15.smethod_0(0); index < (int) length1; index += Class15.smethod_0(1))
      {
        this.imgInfo[index] = new GClass67();
        this.imgInfo[index].ID = (int) iss.method_2();
        this.imgInfo[index].x0 = (int) iss.method_5();
        this.imgInfo[index].y0 = (int) iss.method_5();
        this.imgInfo[index].w = (int) iss.method_5();
        this.imgInfo[index].h = (int) iss.method_5();
      }
      short length2 = iss.method_6();
      this.frame = new GClass59[(int) length2];
      for (int index1 = Class15.smethod_0(0); index1 < (int) length2; index1 += Class15.smethod_0(1))
      {
        this.frame[index1] = new GClass59();
        sbyte length3 = iss.method_2();
        this.frame[index1].dx = new short[(int) length3];
        this.frame[index1].dy = new short[(int) length3];
        this.frame[index1].idImg = new sbyte[(int) length3];
        for (int index2 = Class15.smethod_0(0); index2 < (int) length3; index2 += Class15.smethod_0(1))
        {
          this.frame[index1].dx[index2] = iss.method_6();
          this.frame[index1].dy[index2] = iss.method_6();
          this.frame[index1].idImg[index2] = iss.method_2();
          if ((index1 == 0 ? 0 : 1) == 0)
          {
            if (num1 > (int) this.frame[index1].dx[index2])
              num1 = (int) this.frame[index1].dx[index2];
            if (num2 > (int) this.frame[index1].dy[index2])
              num2 = (int) this.frame[index1].dy[index2];
            if (num3 < (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w)
              num3 = (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w;
            if (num4 < (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h)
              num4 = (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h;
            this.width = num3 - num1;
            this.height = num4 - num2;
          }
        }
      }
      short num5 = (short) Class15.smethod_0(0);
      short length4 = iss.method_6();
      this.arrFrame = new short[(int) length4];
      if (this.ID >= Class15.smethod_0(218))
      {
        short index3 = (short) Class15.smethod_0(0);
        short[] sourceArray = new short[(int) length4];
        int length5 = Class15.smethod_0(0);
        string str = string.Empty;
        bool flag = Class15.smethod_0(0) != 0;
        for (int index4 = Class15.smethod_0(0); index4 < (int) length4; index4 += Class15.smethod_0(1))
        {
          short num6 = iss.method_6();
          str = str + num6.ToString() + Class13.smethod_0(27555);
          this.arrFrame[index4] = num6;
          if ((int) num6 + Class15.smethod_0(16) >= Class15.smethod_0(16))
          {
            short[] numArray = sourceArray;
            int index5 = length5;
            length5 = index5 + Class15.smethod_0(1);
            int num7 = (int) num6;
            numArray[index5] = (short) num7;
            flag = Class15.smethod_0(1) != 0;
          }
          else
          {
            index3 = (short) GClass151.smethod_25((int) num6 + Class15.smethod_0(16));
            this.anim_data[(int) index3] = new short[length5];
            Array.Copy((Array) sourceArray, Class15.smethod_0(0), (Array) this.anim_data[(int) index3], Class15.smethod_0(0), length5);
            length5 = Class15.smethod_0(0);
          }
        }
        if ((!flag ? 0 : 1) != 0)
          return;
        this.anim_data[Class15.smethod_0(0)] = new short[length5];
        Array.Copy((Array) sourceArray, Class15.smethod_0(0), (Array) this.anim_data[(int) index3], Class15.smethod_0(0), length5);
      }
      else
      {
        for (int index = Class15.smethod_0(0); index < (int) length4; index += Class15.smethod_0(1))
          this.arrFrame[index] = iss.method_6();
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(27553) + ex.ToString());
    }
  }

  public void method_7(sbyte[] data) => this.method_6(new GClass131(data));

  public void method_8(sbyte[] data, sbyte typeread) => this.method_10(new GClass131(data), typeread);

  public void method_9(GClass98 g, int f, int x, int y, int trans, int layer)
  {
    if ((this.frame == null ? 1 : 0) != 0 || (this.frame.Length == 0 ? 0 : 1) == 0)
      return;
    GClass59 gclass59 = this.frame[f];
    for (int index = Class15.smethod_0(0); index < gclass59.dx.Length; index += Class15.smethod_0(1))
    {
      GClass67 gclass67 = this.method_0(gclass59.idImg[index]);
      try
      {
        if (trans == -1)
          g.method_24(this.img, gclass67.x0, gclass67.y0, gclass67.w, gclass67.h, Class15.smethod_0(0), x + (int) gclass59.dx[index], y + (int) gclass59.dy[index], Class15.smethod_0(0));
        if ((trans == 0 ? 0 : 1) == 0)
          g.method_24(this.img, gclass67.x0, gclass67.y0, gclass67.w, gclass67.h, Class15.smethod_0(0), x + (int) gclass59.dx[index], y + (int) gclass59.dy[index] - (layer >= Class15.smethod_0(2) || layer <= Class15.smethod_0(0) ? Class15.smethod_0(0) : GClass62.int_52), Class15.smethod_0(0));
        if (trans == Class15.smethod_0(1))
          g.method_24(this.img, gclass67.x0, gclass67.y0, gclass67.w, gclass67.h, Class15.smethod_0(7), x - (int) gclass59.dx[index], y + (int) gclass59.dy[index] - (layer >= Class15.smethod_0(2) || layer <= Class15.smethod_0(0) ? Class15.smethod_0(0) : GClass62.int_52), GClass177.int_2);
        if (trans == Class15.smethod_0(7))
          g.method_24(this.img, gclass67.x0, gclass67.y0, gclass67.w, gclass67.h, Class15.smethod_0(38), x - (int) gclass59.dx[index], y + (int) gclass59.dy[index] - (layer >= Class15.smethod_0(2) || layer <= Class15.smethod_0(0) ? Class15.smethod_0(0) : GClass62.int_52), GClass177.int_6);
      }
      catch (Exception ex)
      {
      }
    }
  }

  public void method_10(GClass131 msg, sbyte typeread)
  {
    int num1 = Class15.smethod_0(0);
    int num2 = Class15.smethod_0(0);
    int num3 = Class15.smethod_0(0);
    int num4 = Class15.smethod_0(0);
    try
    {
      sbyte length1 = msg.method_2();
      this.imgInfo = new GClass67[(int) length1];
      for (int index = Class15.smethod_0(0); index < (int) length1; index += Class15.smethod_0(1))
      {
        this.imgInfo[index] = new GClass67();
        this.imgInfo[index].ID = (int) msg.method_2();
        if ((int) typeread == Class15.smethod_0(1))
        {
          this.imgInfo[index].x0 = (int) msg.method_5();
          this.imgInfo[index].y0 = (int) msg.method_5();
        }
        else
        {
          this.imgInfo[index].x0 = (int) msg.method_6();
          this.imgInfo[index].y0 = (int) msg.method_6();
        }
        this.imgInfo[index].w = (int) msg.method_5();
        this.imgInfo[index].h = (int) msg.method_5();
      }
      this.frame = new GClass59[(int) msg.method_6()];
      for (int index1 = Class15.smethod_0(0); index1 < this.frame.Length; index1 += Class15.smethod_0(1))
      {
        this.frame[index1] = new GClass59();
        sbyte length2 = msg.method_2();
        this.frame[index1].dx = new short[(int) length2];
        this.frame[index1].dy = new short[(int) length2];
        this.frame[index1].idImg = new sbyte[(int) length2];
        for (int index2 = Class15.smethod_0(0); index2 < (int) length2; index2 += Class15.smethod_0(1))
        {
          this.frame[index1].dx[index2] = msg.method_6();
          this.frame[index1].dy[index2] = msg.method_6();
          this.frame[index1].idImg[index2] = msg.method_2();
          if ((index1 == 0 ? 0 : 1) == 0)
          {
            if (num1 > (int) this.frame[index1].dx[index2])
              num1 = (int) this.frame[index1].dx[index2];
            if (num2 > (int) this.frame[index1].dy[index2])
              num2 = (int) this.frame[index1].dy[index2];
            if (num3 < (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w)
              num3 = (int) this.frame[index1].dx[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].w;
            if (num4 < (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h)
              num4 = (int) this.frame[index1].dy[index2] + this.imgInfo[(int) this.frame[index1].idImg[index2]].h;
            this.width = num3 - num1;
            this.height = num4 - num2;
          }
        }
      }
      this.arrFrame = new short[(int) msg.method_6()];
      for (int index = Class15.smethod_0(0); index < this.arrFrame.Length; index += Class15.smethod_0(1))
        this.arrFrame[index] = msg.method_6();
    }
    catch (Exception ex)
    {
    }
  }
}
