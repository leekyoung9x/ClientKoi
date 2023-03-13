// Decompiled with JetBrains decompiler
// Type: GClass145
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass145
{
  public GClass20 charBelong;
  public GClass34 info;
  public GClass134 darts = new GClass134();
  public int angle;
  public int vx;
  public int vy;
  public int va;
  public int x;
  public int y;
  public int z;
  private int int_0;
  private int int_1;
  private int int_2;
  public bool isActive = Class15.smethod_0(1) != 0;
  public bool isSpeedUp;
  public GClass165 skillPaint;

  public GClass145(GClass20 charBelong, int dartType, GClass165 sp, int x, int y)
  {
    this.skillPaint = sp;
    this.charBelong = charBelong;
    this.info = GClass116.gclass34_0[dartType];
    this.va = this.info.va;
    this.x = x;
    this.y = y;
    GInterface3 ginterface3 = (charBelong.mobFocus == null ? 0 : 1) != 0 ? (GInterface3) charBelong.mobFocus : (GInterface3) charBelong.charFocus;
    this.method_0(GClass151.smethod_5(ginterface3.imethod_0() - x, ginterface3.imethod_1() - y));
  }

  public void method_0(int angle)
  {
    this.angle = angle;
    this.vx = this.va * GClass151.smethod_2(angle) >> Class15.smethod_0(31);
    this.vy = this.va * GClass151.smethod_1(angle) >> Class15.smethod_0(31);
  }

  public void method_1()
  {
    if ((!this.isActive ? 0 : 1) == 0)
      return;
    if ((this.charBelong.mobFocus == null ? 0 : 1) == 0 && (this.charBelong.charFocus == null ? 0 : 1) == 0)
    {
      this.method_2();
    }
    else
    {
      GInterface3 ginterface3 = (this.charBelong.mobFocus == null ? 0 : 1) != 0 ? (GInterface3) this.charBelong.mobFocus : (GInterface3) this.charBelong.charFocus;
      for (int index = Class15.smethod_0(0); index < (int) this.info.nUpdate; index += Class15.smethod_0(1))
      {
        if ((this.info.tail.Length == 0 ? 1 : 0) == 0)
          this.darts.method_0((object) new GClass168(this.x, this.y));
        int num1 = this.charBelong.imethod_0() <= ginterface3.imethod_0() ? Class15.smethod_0(136) : Class15.smethod_0(31);
        this.int_1 = ginterface3.imethod_0() + num1 - this.x;
        this.int_2 = ginterface3.imethod_1() - ginterface3.imethod_3() / Class15.smethod_0(7) - this.y;
        this.int_0 += Class15.smethod_0(1);
        if (GClass151.smethod_25(this.int_1) >= Class15.smethod_0(51) || GClass151.smethod_25(this.int_2) >= Class15.smethod_0(51))
        {
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
        else
        {
          if ((this.charBelong.charFocus == null ? 1 : 0) == 0 && (!this.charBelong.charFocus.me ? 1 : 0) == 0)
            this.charBelong.charFocus.method_108(this.charBelong.charFocus.damHP, Class15.smethod_0(0), this.charBelong.charFocus.isCrit, this.charBelong.charFocus.isMob);
          this.method_2();
          return;
        }
      }
      for (int index = Class15.smethod_0(0); index < this.darts.method_2(); index += Class15.smethod_0(1))
      {
        GClass168 gclass168 = (GClass168) this.darts.method_3(index);
        gclass168.index += Class15.smethod_0(1);
        if (gclass168.index >= this.info.tail.Length)
          this.darts.method_7(index);
      }
    }
  }

  private void method_2()
  {
    if ((!this.charBelong.isUseSkillAfterCharge ? 0 : 1) == 0 && this.x >= GClass116.int_22 && this.x <= GClass116.int_22 + GClass62.int_10)
      GClass172.smethod_1().method_22();
    this.charBelong.method_72();
    if ((!this.charBelong.me ? 1 : 0) == 0)
      this.charBelong.method_25();
    if ((!this.charBelong.isUseSkillAfterCharge ? 1 : 0) == 0)
    {
      this.charBelong.isUseSkillAfterCharge = Class15.smethod_0(0) != 0;
      if ((!this.charBelong.isLockMove ? 1 : 0) == 0 && (!this.charBelong.me ? 1 : 0) == 0 && this.charBelong.statusMe != Class15.smethod_0(49) && this.charBelong.statusMe != Class15.smethod_0(3))
        this.charBelong.isLockMove = Class15.smethod_0(0) != 0;
      GClass116.smethod_6().method_50(this.x, this.y);
    }
    this.charBelong.dart = (GClass145) null;
    this.charBelong.isCreateDark = Class15.smethod_0(0) != 0;
    this.charBelong.skillPaint = (GClass165) null;
    this.charBelong.skillPaintRandomPaint = (GClass165) null;
  }

  public void method_3(GClass98 g)
  {
    if ((!this.isActive ? 0 : 1) == 0)
      return;
    int index1 = GClass46.smethod_2(Class15.smethod_0(229) - this.angle);
    int index2 = (int) GClass46.sbyte_0[index1];
    int transform = GClass46.int_4[index1];
    for (int index3 = this.darts.method_2() / Class15.smethod_0(7); index3 < this.darts.method_2(); index3 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index3);
      GClass169.smethod_6(g, (int) this.info.tailBorder[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
    int index4 = GClass62.int_8 % this.info.headBorder.Length;
    GClass169.smethod_6(g, (int) this.info.headBorder[index4][index2], this.x, this.y, transform, Class15.smethod_0(5));
    for (int index5 = Class15.smethod_0(0); index5 < this.darts.method_2(); index5 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index5);
      GClass169.smethod_6(g, (int) this.info.tail[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
    GClass169.smethod_6(g, (int) this.info.head[index4][index2], this.x, this.y, transform, Class15.smethod_0(5));
    for (int index6 = Class15.smethod_0(0); index6 < this.darts.method_2(); index6 += Class15.smethod_0(1))
    {
      GClass168 gclass168 = (GClass168) this.darts.method_3(index6);
      if (GClass151.smethod_25(GClass46.gclass130_0.method_1(Class15.smethod_0(21))) < (int) this.info.xdPercent)
        GClass169.smethod_6(g, (GClass62.int_8 % Class15.smethod_0(7) == 0 ? 0 : 1) != 0 ? (int) this.info.xd2[gclass168.index] : (int) this.info.xd1[gclass168.index], gclass168.x, gclass168.y, Class15.smethod_0(0), Class15.smethod_0(5));
    }
    g.method_16(Class15.smethod_0(133));
  }
}
