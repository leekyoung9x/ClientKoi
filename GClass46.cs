// Decompiled with JetBrains decompiler
// Type: GClass46
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass46 : GClass42
{
  public int va;
  private GClass34 gclass34_0;
  public static GClass130 gclass130_0 = new GClass130();
  public int angle;
  public int vx;
  public int vy;
  public int x;
  public int y;
  public int z;
  public int xTo;
  public int yTo;
  private int int_0;
  public bool isSpeedUp;
  public int dame;
  public int dameMp;
  public GClass20 c;
  public bool isBoss;
  public GClass134 darts = new GClass134();
  private int int_1;
  private int int_2;
  public static int[] int_3;
  public static int[] int_4;
  public static sbyte[] sbyte_0;

  public GClass46(int x, int y, bool isBoss, int dame, int dameMp, GClass20 c, int dartType)
  {
    this.gclass34_0 = GClass116.gclass34_0[dartType];
    this.x = x;
    this.y = y;
    this.isBoss = isBoss;
    this.dame = dame;
    this.dameMp = dameMp;
    this.c = c;
    this.va = this.gclass34_0.va;
    this.method_0(GClass151.smethod_5(c.cx - x, c.cy - y));
    if (x < GClass116.int_22 || x > GClass116.int_22 + GClass62.int_10)
      return;
    GClass172.smethod_1().method_28(dartType);
  }

  public GClass46(
    int x,
    int y,
    bool isBoss,
    int dame,
    int dameMp,
    int xTo,
    int yTo,
    int dartType)
  {
    this.gclass34_0 = GClass116.gclass34_0[dartType];
    this.x = x;
    this.y = y;
    this.isBoss = isBoss;
    this.dame = dame;
    this.dameMp = dameMp;
    this.xTo = xTo;
    this.yTo = yTo;
    this.va = this.gclass34_0.va;
    this.method_0(GClass151.smethod_5(xTo - x, yTo - y));
    if (x >= GClass116.int_22 && x <= GClass116.int_22 + GClass62.int_10)
      GClass172.smethod_1().method_28(dartType);
    this.c = (GClass20) null;
  }

  public void method_0(int angle)
  {
    this.angle = angle;
    this.vx = this.va * GClass151.smethod_2(angle) >> Class15.smethod_0(31);
    this.vy = this.va * GClass151.smethod_1(angle) >> Class15.smethod_0(31);
  }

  public static void smethod_0(
    int x,
    int y,
    bool isBoss,
    int dame,
    int dameMp,
    GClass20 c,
    int dartType)
  {
    GClass42.gclass134_1.method_0((object) new GClass46(x, y, isBoss, dame, dameMp, c, dartType));
  }

  public static void smethod_1(
    int x,
    int y,
    bool isBoss,
    int dame,
    int dameMp,
    int xTo,
    int yTo,
    int dartType)
  {
    GClass42.gclass134_1.method_0((object) new GClass46(x, y, isBoss, dame, dameMp, xTo, yTo, dartType));
  }

  public override void vmethod_0()
  {
    for (int index = Class15.smethod_0(0); index < (int) this.gclass34_0.nUpdate; index += Class15.smethod_0(1))
    {
      if ((this.gclass34_0.tail.Length == 0 ? 1 : 0) == 0)
        this.darts.method_0((object) new GClass168(this.x, this.y));
      this.int_1 = ((this.c == null ? 1 : 0) != 0 ? this.xTo : this.c.cx) - this.x;
      this.int_2 = ((this.c == null ? 1 : 0) != 0 ? this.yTo : this.c.cy) - Class15.smethod_0(31) - this.y;
      int num1 = Class15.smethod_0(4);
      if ((GClass185.int_37 == 0 ? 0 : 1) == 0)
        num1 = Class15.smethod_0(30);
      this.int_0 += Class15.smethod_0(1);
      if ((this.c == null ? 1 : 0) == 0 && (this.c.statusMe == Class15.smethod_0(3) || this.c.statusMe == Class15.smethod_0(49)) || (this.c == null ? 0 : 1) == 0)
      {
        this.x += (((this.c == null ? 1 : 0) != 0 ? this.xTo : this.c.cx) - this.x) / Class15.smethod_0(7);
        this.y += (((this.c == null ? 1 : 0) != 0 ? this.yTo : this.c.cy) - this.y) / Class15.smethod_0(7);
      }
      if (GClass151.smethod_25(this.int_1) < Class15.smethod_0(10) && GClass151.smethod_25(this.int_2) < Class15.smethod_0(10) || this.int_0 > num1)
      {
        if ((this.c == null ? 1 : 0) == 0 && this.c.charID >= Class15.smethod_0(0) && this.dameMp != -1)
        {
          if (this.dameMp != Class15.smethod_0(143))
            this.c.method_108(this.dame, this.dameMp, Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
          else
            GClass47.smethod_3(Class15.smethod_0(25), this.c, Class15.smethod_0(1));
        }
        GClass42.gclass134_1.method_8((object) this);
        if (this.dameMp != Class15.smethod_0(143))
        {
          GClass47.smethod_3(Class15.smethod_0(13), this.c, Class15.smethod_0(1));
          if (this.x >= GClass116.int_22 && this.x <= GClass116.int_22 + GClass62.int_10)
            GClass172.smethod_1().method_23();
        }
      }
      int num2 = GClass151.smethod_5(this.int_1, this.int_2);
      if (GClass93.smethod_0(num2 - this.angle) < Class15.smethod_0(23) || this.int_1 * this.int_1 + this.int_2 * this.int_2 > Class15.smethod_0(432))
        this.angle = GClass93.smethod_0(num2 - this.angle) >= Class15.smethod_0(9) ? (num2 - this.angle >= Class15.smethod_0(0) && num2 - this.angle < Class15.smethod_0(96) || num2 - this.angle < Class15.smethod_0(433) ? GClass151.smethod_6(this.angle + Class15.smethod_0(9)) : GClass151.smethod_6(this.angle - Class15.smethod_0(9))) : num2;
      if ((!this.isSpeedUp ? 0 : 1) == 0 && this.va < Class15.smethod_0(189))
        this.va += Class15.smethod_0(246);
      this.vx = this.va * GClass151.smethod_2(this.angle) >> Class15.smethod_0(31);
      this.vy = this.va * GClass151.smethod_1(this.angle) >> Class15.smethod_0(31);
      this.int_1 += this.vx;
      this.x += this.int_1 >> Class15.smethod_0(31);
      this.int_1 &= Class15.smethod_0(434);
      this.int_2 += this.vy;
      this.y += this.int_2 >> Class15.smethod_0(31);
      this.int_2 &= Class15.smethod_0(434);
    }
    for (int index = Class15.smethod_0(0); index < this.darts.method_2(); index += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index);
      gclass168.index += Class15.smethod_0(1);
      if (gclass168.index >= this.gclass34_0.tail.Length)
        this.darts.method_7(index);
    }
  }

  public static int smethod_2(int angle)
  {
    for (int index = Class15.smethod_0(0); index < GClass46.int_3.Length - Class15.smethod_0(1); index += Class15.smethod_0(1))
    {
      if (angle >= GClass46.int_3[index] && angle <= GClass46.int_3[index + Class15.smethod_0(1)])
        return index >= Class15.smethod_0(10) ? Class15.smethod_0(0) : index;
    }
    return Class15.smethod_0(0);
  }

  public override void vmethod_1(GClass98 g)
  {
    int index1 = GClass46.smethod_2(Class15.smethod_0(229) - this.angle);
    int index2 = (int) GClass46.sbyte_0[index1];
    int transform = GClass46.int_4[index1];
    for (int index3 = this.darts.method_2() / Class15.smethod_0(7); index3 < this.darts.method_2(); index3 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index3);
      GClass169.smethod_6(g, (int) this.gclass34_0.tailBorder[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
    int index4 = GClass62.int_8 % this.gclass34_0.headBorder.Length;
    GClass169.smethod_6(g, (int) this.gclass34_0.headBorder[index4][index2], this.x, this.y, transform, Class15.smethod_0(5));
    for (int index5 = Class15.smethod_0(0); index5 < this.darts.method_2(); index5 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index5);
      GClass169.smethod_6(g, (int) this.gclass34_0.tail[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
    GClass169.smethod_6(g, (int) this.gclass34_0.head[index4][index2], this.x, this.y, transform, Class15.smethod_0(5));
    for (int index6 = Class15.smethod_0(0); index6 < this.darts.method_2(); index6 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index6);
      if (GClass151.smethod_25(GClass46.gclass130_0.method_1(Class15.smethod_0(21))) < (int) this.gclass34_0.xdPercent)
        GClass169.smethod_6(g, (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) != 0 ? (int) this.gclass34_0.xd2[gclass168.index] : (int) this.gclass34_0.xd1[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
  }

  public static void smethod_3(
    int x2,
    int y2,
    bool checkIsBoss,
    int dame2,
    int dameMp2,
    GClass100 mobToAttack,
    sbyte dartType)
  {
    GClass46.smethod_1(x2, y2, checkIsBoss, dame2, dameMp2, mobToAttack.x, mobToAttack.y, (int) dartType);
  }

  static GClass46()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(12)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.nGDptYHppRbO));
    GClass46.int_3 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(13)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.GPmQKTrjenBc));
    GClass46.int_4 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.iiBRAPPNXywI));
    GClass46.sbyte_0 = (sbyte[]) Class15.smethod_4(byte_0_3);
  }
}
