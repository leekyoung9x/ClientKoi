// Decompiled with JetBrains decompiler
// Type: GClass41
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass41
{
  public int effId;
  public int typeEff;
  public int indexFrom;
  public int indexTo;
  public bool isNearPlayer;
  public const int int_0 = 0;
  public const int int_1 = 1;
  public const int int_2 = 2;
  public const int int_3 = 3;
  public const int int_4 = 4;
  public const int int_5 = 5;
  public const int int_6 = 0;
  public const int int_7 = 1;
  public const int int_8 = 2;
  public const int int_9 = 3;
  public const int int_10 = 5;
  public const int int_11 = 4;
  public const int int_12 = 6;
  public const int int_13 = 7;
  public const int int_14 = 8;
  public const int int_15 = 9;
  public const int int_16 = 10;
  public const int int_17 = 11;
  public const int int_18 = 12;
  public const int int_19 = 13;
  public const int int_20 = 14;
  public const int int_21 = 15;
  public const int int_22 = 16;
  public const int int_23 = 17;
  public const int int_24 = 26;
  public const int int_25 = 27;
  public const int int_26 = 28;
  public const int int_27 = 29;
  public const int int_28 = 30;
  public const int int_29 = 31;
  public const int int_30 = 42;
  public const int int_31 = 43;
  public const int int_32 = 44;
  public const int int_33 = 45;
  public const int int_34 = 46;
  public GClass20 c;
  public int t;
  public int currFrame;
  public int x;
  public int y;
  public int loop;
  public int tLoop;
  public int tLoopCount;
  private bool bool_0;
  public int layer;
  public int isStand;
  public static GClass134 gclass134_0 = new GClass134();
  public int trans;
  public static GClass134 gclass134_1 = new GClass134();
  public static GClass134 gclass134_2 = new GClass134();
  private int[] int_35;
  private int[] int_36;
  private int[] int_37;
  private int[] int_38;
  private int[] int_39;
  private bool bool_1;
  private short[] short_0;
  public int cLastStatusMe;
  public long cur_time_cLastStatusMe;

  public GClass41()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.taZaMaITCHJW));
    this.int_35 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.RwCunQMgDVER));
    this.int_36 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.IhDvdwpzFMTK));
    this.int_37 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.LDAAAuFBKrbG));
    this.int_38 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.TcAMMOOeARNJ));
    this.int_39 = (int[]) Class15.smethod_4(byte_0_5);
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public GClass41(int id, GClass20 c, int layer, int loop, int loopCount, sbyte isStand)
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.taZaMaITCHJW));
    this.int_35 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.RwCunQMgDVER));
    this.int_36 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.IhDvdwpzFMTK));
    this.int_37 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.LDAAAuFBKrbG));
    this.int_38 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.TcAMMOOeARNJ));
    this.int_39 = (int[]) Class15.smethod_4(byte_0_5);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.c = c;
    this.effId = id;
    this.layer = layer;
    this.loop = loop;
    this.tLoop = loopCount;
    this.isStand = (int) isStand;
    if ((GClass41.smethod_2(id) == null ? 0 : 1) == 0)
    {
      GClass50 eff = new GClass50() { ID = id };
      if (id >= Class15.smethod_0(108) && id <= Class15.smethod_0(71))
        id = Class15.smethod_0(58);
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(26835);
      strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(26832);
      strArray[Class15.smethod_0(5)] = id.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(26819);
      string str = string.Concat(strArray);
      if ((GClass133.smethod_0(str) == null ? 1 : 0) == 0)
      {
        if (id > Class15.smethod_0(21) && id < Class15.smethod_0(90))
          eff.method_4(str);
        else
          eff.method_3(str);
        eff.img = GClass62.smethod_40(Class13.smethod_0(26832) + id.ToString() + Class13.smethod_0(27453));
      }
      else
        GClass156.smethod_0().method_58((short) id);
      GClass41.smethod_1(eff);
    }
    this.indexFrom = -1;
    this.indexTo = -1;
    this.trans = -1;
    this.typeEff = Class15.smethod_0(2);
    if (id != Class15.smethod_0(63))
      return;
    this.typeEff = Class15.smethod_0(3);
  }

  public GClass41(int id, int x, int y, int layer, int loop, int loopCount)
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.taZaMaITCHJW));
    this.int_35 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.RwCunQMgDVER));
    this.int_36 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.IhDvdwpzFMTK));
    this.int_37 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.LDAAAuFBKrbG));
    this.int_38 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.TcAMMOOeARNJ));
    this.int_39 = (int[]) Class15.smethod_4(byte_0_5);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.x = x;
    this.y = y;
    this.effId = id;
    this.layer = layer;
    this.loop = loop;
    this.tLoop = loopCount;
    if ((GClass41.smethod_2(id) == null ? 0 : 1) == 0)
    {
      GClass50 eff = new GClass50() { ID = id };
      if (id >= Class15.smethod_0(108) && id <= Class15.smethod_0(71))
        id = Class15.smethod_0(58);
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(27420);
      strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(27415);
      strArray[Class15.smethod_0(5)] = id.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(27394);
      string str = string.Concat(strArray);
      if ((GClass133.smethod_0(str) == null ? 1 : 0) == 0)
      {
        if (id > Class15.smethod_0(21) && id < Class15.smethod_0(90))
          eff.method_4(str);
        else
          eff.method_3(str);
        eff.img = GClass62.smethod_40(Class13.smethod_0(27415) + id.ToString() + Class13.smethod_0(27597));
      }
      else
        GClass156.smethod_0().method_58((short) id);
      GClass41.smethod_1(eff);
      GClass41.gclass134_1.method_0((object) (this.effId.ToString() + string.Empty));
    }
    this.indexFrom = -1;
    this.indexTo = -1;
    this.typeEff = id != Class15.smethod_0(63) ? Class15.smethod_0(1) : Class15.smethod_0(3);
    if ((!GClass41.smethod_3(this.effId.ToString() + string.Empty) ? 0 : 1) != 0)
      return;
    GClass41.gclass134_2.method_0((object) (this.effId.ToString() + string.Empty));
  }

  public static void smethod_0(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass41.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass50 o = (GClass50) GClass41.gclass134_0.method_3(index);
      if (o.ID == id)
      {
        GClass41.gclass134_0.method_8((object) o);
        break;
      }
    }
  }

  public static void smethod_1(GClass50 eff)
  {
    GClass41.gclass134_0.method_0((object) eff);
    if (GClass185.int_37 == Class15.smethod_0(288) || GClass41.gclass134_0.method_2() <= Class15.smethod_0(31))
      return;
    for (int index = Class15.smethod_0(0); index < Class15.smethod_0(3); index += Class15.smethod_0(1))
      GClass41.gclass134_0.method_7(Class15.smethod_0(0));
  }

  public static GClass50 smethod_2(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass41.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass50 gclass50 = (GClass50) GClass41.gclass134_0.method_3(index);
      if (gclass50.ID == id)
        return gclass50;
    }
    return (GClass50) null;
  }

  public static bool smethod_3(string id)
  {
    for (int index = Class15.smethod_0(0); index < GClass41.gclass134_2.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass41.gclass134_2.method_3(index)).Equals(id) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_0() => (!this.bool_0 ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public void method_1(GClass98 g, int xLayer, int yLayer)
  {
    if ((!this.method_0() ? 1 : 0) != 0 || (GClass41.smethod_2(this.effId).img == null ? 1 : 0) != 0)
      return;
    GClass41.smethod_2(this.effId).method_9(g, this.currFrame, this.x + xLayer, this.y + yLayer, this.trans, this.layer);
  }

  public void method_2()
  {
    if (this.effId == Class15.smethod_0(108))
      this.currFrame = this.int_35[this.t];
    if (this.effId == Class15.smethod_0(248))
      this.currFrame = this.int_36[this.t];
    if (this.effId == Class15.smethod_0(74))
      this.currFrame = this.int_37[this.t];
    if (this.effId == Class15.smethod_0(70))
      this.currFrame = this.int_38[this.t];
    if (this.effId == Class15.smethod_0(71))
      this.currFrame = this.int_39[this.t];
    this.t += Class15.smethod_0(1);
    if (this.t <= this.int_35.Length - Class15.smethod_0(1))
      return;
    this.t = Class15.smethod_0(0);
  }

  public void method_3(GClass98 g)
  {
    if ((!this.bool_0 ? 1 : 0) != 0 || (GClass41.smethod_2(this.effId) == null ? 1 : 0) != 0)
      return;
    if ((GClass41.smethod_2(this.effId).img == null ? 0 : 1) == 0)
      return;
    try
    {
      GClass41.smethod_2(this.effId).method_9(g, this.currFrame, this.x, this.y, this.trans, this.layer);
    }
    catch (Exception ex)
    {
    }
  }

  public void method_4()
  {
    try
    {
      if (this.effId >= Class15.smethod_0(108) && this.effId <= Class15.smethod_0(71))
      {
        this.method_2();
      }
      else
      {
        if (GClass41.smethod_2(this.effId) == null || GClass41.smethod_2(this.effId).img == null)
          return;
        this.short_0 = this.typeEff != Class15.smethod_0(3) ? GClass41.smethod_2(this.effId).method_1() : GClass41.smethod_2(this.effId).method_2(this.c.statusMe);
        if (this.short_0 != null)
        {
          if (!this.bool_1)
          {
            this.bool_1 = Class15.smethod_0(1) != 0;
            int b = this.short_0.Length - Class15.smethod_0(1);
            if (b > Class15.smethod_0(0) && this.typeEff != Class15.smethod_0(1))
              this.t = GClass151.smethod_18(Class15.smethod_0(0), b);
            if (this.typeEff == 0)
              this.t = GClass151.smethod_18(this.indexFrom, this.indexTo);
          }
          switch (this.typeEff)
          {
            case 0:
              if (GClass151.smethod_26(this.x - Class15.smethod_0(32), this.y - Class15.smethod_0(32), Class15.smethod_0(21), Class15.smethod_0(21), GClass20.smethod_1().cx, GClass20.smethod_1().cy) && this.t > this.indexFrom && this.t < this.indexTo)
              {
                if (this.t < this.indexTo)
                  this.t = this.indexTo;
                this.isNearPlayer = Class15.smethod_0(1) != 0;
              }
              if (!this.isNearPlayer)
              {
                this.t += Class15.smethod_0(1);
                if (this.t == this.indexTo)
                {
                  this.t = this.indexFrom;
                  break;
                }
                break;
              }
              if (this.t < this.short_0.Length)
              {
                this.t += Class15.smethod_0(1);
                break;
              }
              break;
            case 1:
            case 3:
              if (this.t < this.short_0.Length)
              {
                this.t += Class15.smethod_0(1);
                break;
              }
              break;
            case 2:
              if (this.t < this.short_0.Length)
                this.t += Class15.smethod_0(1);
              this.tLoopCount += Class15.smethod_0(1);
              if (this.tLoopCount == this.tLoop)
              {
                this.tLoopCount = Class15.smethod_0(0);
                this.trans = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7));
                break;
              }
              break;
            case 4:
              this.x = this.c.cx;
              this.y = this.c.cy;
              if (this.t < this.short_0.Length)
              {
                this.t += Class15.smethod_0(1);
                break;
              }
              break;
            case 5:
              this.trans = this.c.cdir != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(0);
              this.x = this.c.cdir != Class15.smethod_0(1) ? this.c.cx + Class15.smethod_0(9) : this.c.cx - Class15.smethod_0(9);
              this.y = this.c.isMonkey != (sbyte) 0 ? this.c.cy - Class15.smethod_0(95) : this.c.cy - Class15.smethod_0(46);
              if (this.t < this.short_0.Length)
              {
                this.t += Class15.smethod_0(1);
                break;
              }
              break;
          }
          if (this.t == this.short_0.Length / Class15.smethod_0(7) && (this.effId == Class15.smethod_0(106) || this.effId == Class15.smethod_0(182) || this.effId == Class15.smethod_0(199) || this.effId == Class15.smethod_0(130)))
            GClass172.smethod_2(this.x, this.y, GClass172.int_35, GClass172.float_0);
          if (this.t <= this.short_0.Length - Class15.smethod_0(1))
            this.currFrame = (int) this.short_0[this.t];
        }
        if (this.t >= this.short_0.Length - Class15.smethod_0(1))
        {
          if (this.typeEff == 0 || this.typeEff == Class15.smethod_0(5))
            this.bool_0 = Class15.smethod_0(0) != 0;
          if (this.tLoop == -1)
            GClass40.gclass134_0.method_8((object) this);
          if (this.typeEff == Class15.smethod_0(7))
          {
            this.t = Class15.smethod_0(0);
          }
          else
          {
            if (this.typeEff == Class15.smethod_0(1) && this.loop == Class15.smethod_0(1))
              this.bool_0 = Class15.smethod_0(0) != 0;
            if (this.typeEff != Class15.smethod_0(2) && this.typeEff != Class15.smethod_0(3))
            {
              this.isNearPlayer = Class15.smethod_0(0) != 0;
              if (this.loop == -1)
              {
                this.tLoopCount += Class15.smethod_0(1);
                if (this.tLoopCount != this.tLoop)
                  return;
                this.tLoopCount = Class15.smethod_0(0);
                this.t = Class15.smethod_0(0);
                if (this.tLoop <= Class15.smethod_0(1))
                  return;
                this.trans = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(7));
              }
              else
              {
                this.tLoopCount += Class15.smethod_0(1);
                if (this.tLoopCount != this.tLoop)
                  return;
                this.tLoopCount = Class15.smethod_0(0);
                this.loop -= Class15.smethod_0(1);
                this.t = Class15.smethod_0(0);
                if (this.loop != 0)
                  return;
                GClass40.gclass134_0.method_8((object) this);
              }
            }
            else if (this.loop == -1)
            {
              this.t = Class15.smethod_0(0);
            }
            else
            {
              this.tLoopCount += Class15.smethod_0(1);
              if (this.tLoopCount != this.tLoop)
                return;
              this.tLoopCount = Class15.smethod_0(0);
              this.loop -= Class15.smethod_0(1);
              this.t = Class15.smethod_0(0);
              if (this.loop != 0)
                return;
              this.c.method_137(Class15.smethod_0(0), this.effId);
            }
          }
        }
        else
          this.bool_0 = Class15.smethod_0(1) != 0;
      }
    }
    catch (Exception ex)
    {
      GClass40.gclass134_0.method_8((object) this);
    }
  }
}
