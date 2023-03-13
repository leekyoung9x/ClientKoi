// Decompiled with JetBrains decompiler
// Type: GClass54
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass54
{
  public const short short_0 = 0;
  public const short short_1 = 1;
  public const short short_2 = 2;
  public const short short_3 = 3;
  public const sbyte sbyte_0 = -1;
  public const sbyte sbyte_1 = 0;
  public const sbyte sbyte_2 = 1;
  public const sbyte sbyte_3 = 2;
  private GClass134 gclass134_0 = new GClass134(Class13.smethod_0(27156));
  public byte[] nFrame = new byte[Class15.smethod_0(31)];
  public int id = -1;
  public int typeEffect;
  public int typeSub;
  public GClass60 fraImgEff;
  public GClass60 fraImgSubEff;
  public int fRemove;
  public int fMove;
  public int x;
  public int y;
  public int dir;
  public int dir_nguoc;
  public int levelPaint;
  public int f;
  public int vx;
  public int vy;
  public int x1000;
  public int y1000;
  public int vx1000;
  public int vy1000;
  public int dy_throw;
  public long time;
  public bool isRemove;
  public bool isAddSub;
  public static short[][] short_4;

  public GClass54(int type, int subtype, int x, int y, int levelPaint, int dir)
  {
    this.f = Class15.smethod_0(0);
    this.typeEffect = type;
    this.typeSub = subtype;
    this.x = x;
    this.y = y;
    this.levelPaint = levelPaint;
    this.dir = dir;
    this.dir_nguoc = (dir == 0 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0);
    this.time = GClass126.smethod_18();
    this.isRemove = this.isAddSub = Class15.smethod_0(0) != 0;
    this.method_0();
  }

  public static GClass66 smethod_0(int id)
  {
    if (id < Class15.smethod_0(0))
      return (GClass66) null;
    string path = Class13.smethod_0(27236) + id.ToString() + Class13.smethod_0(27206);
    GClass66 gclass66 = (GClass66) null;
    try
    {
      return GClass126.smethod_35(path);
    }
    catch (Exception ex)
    {
      return gclass66;
    }
  }

  public static void smethod_1(int x, int y, int typeEffect)
  {
    try
    {
      int id = -1;
      GClass151.smethod_19(Class15.smethod_0(5));
      if (-1 < Class15.smethod_0(0))
        return;
      GClass172.smethod_2(x, y, id, GClass172.float_0);
    }
    catch (Exception ex)
    {
    }
  }

  public void method_0()
  {
    GClass54.smethod_1(this.x, this.y, this.typeEffect);
    int typeEffect = this.typeEffect;
    if ((uint) typeEffect > (uint) Class15.smethod_0(7))
    {
      if (typeEffect != Class15.smethod_0(5))
        return;
      this.method_7();
    }
    else
      this.method_4(this.typeEffect);
  }

  public void method_1()
  {
    this.f += Class15.smethod_0(1);
    int typeEffect = this.typeEffect;
    if ((uint) typeEffect > (uint) Class15.smethod_0(7))
    {
      if (typeEffect != Class15.smethod_0(5))
        return;
      this.method_8();
    }
    else
      this.method_5();
  }

  public void method_2(GClass98 g)
  {
    try
    {
      if ((!this.isRemove ? 0 : 1) != 0 || this.f < Class15.smethod_0(0))
        return;
      int typeEffect = this.typeEffect;
      if ((uint) typeEffect > (uint) Class15.smethod_0(7))
      {
        if (typeEffect != Class15.smethod_0(5))
          return;
        this.method_9(g);
      }
      else
        this.method_6(g);
    }
    catch (Exception ex)
    {
    }
  }

  public void method_3() => this.isRemove = Class15.smethod_0(1) != 0;

  private void method_4(int int_0)
  {
    switch (int_0)
    {
      case 0:
        this.fraImgEff = new GClass60(Class15.smethod_0(2));
        break;
      case 1:
        this.fraImgEff = new GClass60(Class15.smethod_0(3));
        break;
      case 2:
        this.fraImgEff = new GClass60(Class15.smethod_0(37));
        break;
    }
    this.fRemove = Class15.smethod_0(21);
    this.dy_throw = GClass62.int_11 / Class15.smethod_0(5) + Class15.smethod_0(31);
    this.vy = Class15.smethod_0(31);
    this.y1000 = Class15.smethod_0(0);
    this.isAddSub = Class15.smethod_0(0) != 0;
  }

  private void method_5()
  {
    this.x = GClass62.int_12;
    this.y = this.y1000;
    if (this.f > this.fRemove)
      this.method_3();
    this.vy += Class15.smethod_0(1);
    if (this.vy > Class15.smethod_0(9))
      this.vy = Class15.smethod_0(9);
    if (this.y1000 + this.vy < this.dy_throw)
    {
      this.y1000 += this.vy;
    }
    else
    {
      this.y1000 = this.dy_throw;
      if ((!this.isAddSub ? 0 : 1) != 0)
        return;
      this.isAddSub = Class15.smethod_0(1) != 0;
      if (this.typeSub == -1)
        return;
      GClass116.smethod_34(this.typeSub, Class15.smethod_0(0), this.x, this.y, this.levelPaint, Class15.smethod_0(0));
    }
  }

  private void method_6(GClass98 gclass98_0)
  {
    if ((this.fraImgEff == null ? 1 : 0) != 0)
      return;
    this.fraImgEff.method_0(this.f / Class15.smethod_0(3) % this.fraImgEff.nFrame, this.x, this.y, Class15.smethod_0(0), Class15.smethod_0(48), gclass98_0);
  }

  private void method_7()
  {
    Class15.smethod_0(0);
    int num1 = GClass151.smethod_18(Class15.smethod_0(5), Class15.smethod_0(3));
    this.fRemove = Class15.smethod_0(23);
    for (int index = Class15.smethod_0(0); index < num1; index += Class15.smethod_0(1))
    {
      GClass147 o = new GClass147();
      o.x = this.x + GClass151.smethod_20(Class15.smethod_0(2));
      o.y = this.y + GClass151.smethod_20(Class15.smethod_0(3));
      if ((this.typeSub == 0 ? 0 : 1) == 0)
      {
        o.fRe = GClass151.smethod_19(Class15.smethod_0(31));
        int num2 = Class15.smethod_0(1);
        if ((index % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
          num2 = -1;
        o.x = this.x + GClass151.smethod_19((int) GClass54.short_4[Class15.smethod_0(3)][Class15.smethod_0(0)] / Class15.smethod_0(7)) * num2;
        o.y = this.y - GClass151.smethod_19((int) GClass54.short_4[Class15.smethod_0(3)][Class15.smethod_0(1)] / Class15.smethod_0(7));
        o.fraImgEff = new GClass60(Class15.smethod_0(38));
      }
      this.gclass134_0.method_0((object) o);
    }
  }

  private void method_8()
  {
    for (int index = Class15.smethod_0(0); index < this.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass147 gclass147 = (GClass147) this.gclass134_0.method_3(index);
      gclass147.method_0();
      if (gclass147.f == gclass147.fRe)
        GClass172.smethod_2(gclass147.x, gclass147.y, GClass172.int_35, GClass172.float_0);
      if (gclass147.f - gclass147.fRe > gclass147.fraImgEff.nFrame * Class15.smethod_0(5) - Class15.smethod_0(1))
      {
        gclass147.f = Class15.smethod_0(0);
        if ((this.typeSub == 0 ? 0 : 1) == 0)
        {
          gclass147.fRe = GClass151.smethod_19(Class15.smethod_0(31));
          int num = Class15.smethod_0(1);
          if ((index % Class15.smethod_0(7) == 0 ? 0 : 1) == 0)
            num = -1;
          gclass147.x = this.x + GClass151.smethod_19((int) GClass54.short_4[Class15.smethod_0(3)][Class15.smethod_0(0)] / Class15.smethod_0(7)) * num;
          gclass147.y = this.y - GClass151.smethod_19((int) GClass54.short_4[Class15.smethod_0(3)][Class15.smethod_0(1)] / Class15.smethod_0(7));
        }
      }
    }
    if (this.f < this.fRemove)
      return;
    this.method_3();
  }

  private void method_9(GClass98 gclass98_0)
  {
    for (int index = Class15.smethod_0(0); index < this.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass147 gclass147 = (GClass147) this.gclass134_0.method_3(index);
      if (gclass147.f - gclass147.fRe > -1 && (gclass147.fraImgEff == null ? 1 : 0) == 0)
        gclass147.fraImgEff.method_0((gclass147.f - gclass147.fRe) / Class15.smethod_0(5) % gclass147.fraImgEff.nFrame, gclass147.x, gclass147.y, Class15.smethod_0(0), Class15.smethod_0(5), gclass98_0);
    }
  }

  static GClass54()
  {
    short[][] numArray1 = new short[Class15.smethod_0(45)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_1 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.IfxAJRObaCNC));
    short[] numArray2 = (short[]) Class15.smethod_4(byte_0_1);
    numArray1[index1] = numArray2;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.rCprqVyypfHg));
    short[] numArray3 = (short[]) Class15.smethod_4(byte_0_2);
    numArray1[index2] = numArray3;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_3 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.mAaTNaTKgglt));
    short[] numArray4 = (short[]) Class15.smethod_4(byte_0_3);
    numArray1[index3] = numArray4;
    int index4 = Class15.smethod_0(5);
    short[] numArray5 = new short[Class15.smethod_0(5)];
    numArray5[Class15.smethod_0(7)] = (short) Class15.smethod_0(1);
    numArray1[index4] = numArray5;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_4 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.AKykYyzMKzDA));
    short[] numArray6 = (short[]) Class15.smethod_4(byte_0_4);
    numArray1[index5] = numArray6;
    int index6 = Class15.smethod_0(3);
    byte[] byte_0_5 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.lmqtBgqfaNmt));
    short[] numArray7 = (short[]) Class15.smethod_4(byte_0_5);
    numArray1[index6] = numArray7;
    int index7 = Class15.smethod_0(37);
    byte[] byte_0_6 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.hjLwQMcmreVM));
    short[] numArray8 = (short[]) Class15.smethod_4(byte_0_6);
    numArray1[index7] = numArray8;
    int index8 = Class15.smethod_0(38);
    byte[] byte_0_7 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.iptaADtIBssh));
    short[] numArray9 = (short[]) Class15.smethod_4(byte_0_7);
    numArray1[index8] = numArray9;
    numArray1[Class15.smethod_0(88)] = new short[Class15.smethod_0(7)];
    GClass54.short_4 = numArray1;
  }
}
