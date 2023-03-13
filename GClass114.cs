// Decompiled with JetBrains decompiler
// Type: GClass114
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass114 : GClass113
{
  public static GClass114 gclass114_0;
  private GClass17[] gclass17_0;
  private byte byte_0;
  private byte byte_1;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  private int int_10;
  private int int_11;
  private int int_12;
  private int int_13;
  private int int_14;
  private int int_15;
  private int int_16;
  private int int_17;
  private int int_18;
  private int int_19;
  private int int_20;
  private int int_21;
  private int int_22;
  private int int_23;
  private int int_24;
  private int int_25;
  private int[] int_26;
  private int[] int_27;
  private int[] int_28;
  private int[] int_29;
  private short[] short_0;
  private long long_0;
  private long long_1;
  private bool bool_0;
  private bool bool_1;
  private bool bool_2;
  private short short_1;
  private static int int_30;
  private static int[] int_31;
  private static GClass60 gclass60_0;
  private static GClass60 gclass60_1;
  private static GClass60 gclass60_2;
  private static GClass66 gclass66_0;
  private static GClass66 gclass66_1;
  private byte[] byte_2;
  private byte[] byte_3;

  public GClass114()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(39)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.jHDAXaQshhth));
    this.byte_2 = (byte[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.EpGkZwvIuiSy));
    this.byte_3 = (byte[]) Class15.smethod_4(byte_0_2);
    // ISSUE: explicit constructor call
    base.\u002Ector();
    GClass114.int_31 = new int[Class15.smethod_0(7)];
    GClass114.int_31[Class15.smethod_0(0)] = Class15.smethod_0(10);
    GClass114.int_30 = GClass62.int_11 - Class15.smethod_0(55);
    GClass114.int_31[Class15.smethod_0(1)] = GClass62.int_10 - Class15.smethod_0(54);
    GClass114.gclass60_0 = new GClass60(GClass62.smethod_40(Class13.smethod_0(27070)), Class15.smethod_0(6), Class15.smethod_0(6));
    GClass114.gclass60_1 = new GClass60(GClass62.smethod_40(Class13.smethod_0(27019)), Class15.smethod_0(11), Class15.smethod_0(130));
    GClass114.gclass60_2 = new GClass60(GClass62.smethod_40(Class13.smethod_0(27111)), Class15.smethod_0(283), Class15.smethod_0(152));
    GClass114.gclass66_1 = GClass62.smethod_40(Class13.smethod_0(27100));
    GClass114.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(27088));
    this.int_18 = Class15.smethod_0(298);
    this.int_16 = GClass62.int_12 - this.int_18 / Class15.smethod_0(7);
    this.int_19 = Class15.smethod_0(54);
    this.int_17 = -this.int_19;
  }

  public static GClass114 smethod_2()
  {
    if ((GClass114.gclass114_0 == null ? 0 : 1) == 0)
      GClass114.gclass114_0 = new GClass114();
    return GClass114.gclass114_0;
  }

  public void method_0(short[] idImage, byte typePrice, int price, short idTicket)
  {
    if ((idImage == null ? 1 : 0) != 0 || (idImage.Length == 0 ? 1 : 0) != 0)
      return;
    this.int_12 = GClass20.smethod_1().cy - Class15.smethod_0(31);
    this.method_1();
    this.gclass17_0 = new GClass17[idImage.Length];
    for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
    {
      this.gclass17_0[index] = new GClass17();
      this.gclass17_0[index].idImg = (int) idImage[index];
      this.gclass17_0[index].count = index * Class15.smethod_0(46);
      this.gclass17_0[index].yTo = Class15.smethod_0(147);
      this.gclass17_0[index].vx = GClass151.smethod_18(Class15.smethod_0(7), Class15.smethod_0(3));
      this.gclass17_0[index].dir = GClass151.smethod_18(-1, Class15.smethod_0(7));
      this.gclass17_0[index].method_0();
    }
    this.bool_1 = Class15.smethod_0(0) != 0;
    this.bool_0 = Class15.smethod_0(0) != 0;
    this.bool_2 = Class15.smethod_0(0) != 0;
    this.long_0 = GClass62.long_0 + (long) GClass151.smethod_18(Class15.smethod_0(15), Class15.smethod_0(20));
    this.byte_0 = (byte) Class15.smethod_0(0);
    this.int_13 = -1;
    this.int_14 = -1;
    this.byte_1 = typePrice;
    this.int_20 = price;
    this.int_21 = Class15.smethod_0(0);
    GClass20.smethod_1().method_96(Class15.smethod_0(299), Class15.smethod_0(300), Class15.smethod_0(1));
    GClass20.smethod_1().cdir = Class15.smethod_0(7);
    GClass20.smethod_1().statusMe = Class15.smethod_0(1);
    this.int_22 = Class15.smethod_0(0);
    this.int_23 = Class15.smethod_0(0);
    this.int_24 = Class15.smethod_0(0);
    this.int_25 = Class15.smethod_0(0);
    this.int_17 = -this.int_19;
    this.short_1 = idTicket;
    this.int_15 = Class15.smethod_0(0);
    this.method_10();
    this.vmethod_0();
    GClass172.smethod_1().method_43();
  }

  private void method_1()
  {
    this.int_6 = GClass62.int_13 / Class15.smethod_0(5) + Class15.smethod_0(31);
    if (this.int_6 > Class15.smethod_0(32))
      this.int_6 = Class15.smethod_0(32);
    this.int_7 = Class15.smethod_0(229);
    GClass116.int_22 = GClass116.int_30 / Class15.smethod_0(7);
    this.int_8 = GClass116.int_23 + GClass62.int_13 / Class15.smethod_0(5) + Class15.smethod_0(6);
    this.int_11 = Class15.smethod_0(301);
    this.int_9 = Class15.smethod_0(0);
    this.int_10 = Class15.smethod_0(229) / this.int_11;
    this.int_26 = new int[this.int_11];
    this.int_27 = new int[this.int_11];
    this.int_28 = new int[this.int_11];
    this.int_29 = new int[this.int_11];
    this.method_2();
  }

  private void method_2()
  {
    if ((!GClass62.bool_1 ? 1 : 0) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < this.int_27.Length; index += Class15.smethod_0(1))
    {
      this.int_27[index] = GClass151.smethod_25(this.int_6 * GClass151.smethod_1(this.int_9) / Class15.smethod_0(246));
      this.int_26[index] = GClass151.smethod_25(this.int_6 * GClass151.smethod_2(this.int_9) / Class15.smethod_0(246));
      if (this.int_9 < Class15.smethod_0(23))
      {
        this.int_28[index] = this.int_7 + this.int_26[index];
        this.int_29[index] = this.int_8 - this.int_27[index];
      }
      else if (this.int_9 >= Class15.smethod_0(23) && this.int_9 < Class15.smethod_0(96))
      {
        this.int_28[index] = this.int_7 - this.int_26[index];
        this.int_29[index] = this.int_8 - this.int_27[index];
      }
      else if (this.int_9 >= Class15.smethod_0(96) && this.int_9 < Class15.smethod_0(196))
      {
        this.int_28[index] = this.int_7 - this.int_26[index];
        this.int_29[index] = this.int_8 + this.int_27[index];
      }
      else
      {
        this.int_28[index] = this.int_7 + this.int_26[index];
        this.int_29[index] = this.int_8 + this.int_27[index];
      }
      this.int_9 += this.int_10;
    }
  }

  public void method_3(int idAction, object p)
  {
  }

  public override void vmethod_3()
  {
    try
    {
      this.int_21 = this.int_20 * (int) this.method_9();
      this.method_10();
      GClass116.smethod_6().vmethod_3();
      if (this.long_0 - GClass62.long_0 > (long) Class15.smethod_0(0))
      {
        for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
        {
          this.gclass17_0[index].count += Class15.smethod_0(7);
          if (this.gclass17_0[index].count >= this.int_11)
            this.gclass17_0[index].count = Class15.smethod_0(0);
          this.gclass17_0[index].x = this.int_28[this.gclass17_0[index].count];
          this.gclass17_0[index].y = this.int_29[this.gclass17_0[index].count];
        }
      }
      else
      {
        if (this.byte_0 == (byte) 0)
          this.byte_0 = (byte) Class15.smethod_0(1);
        if ((int) this.byte_0 == Class15.smethod_0(1))
        {
          for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
          {
            if (this.gclass17_0[index].yTo != Class15.smethod_0(147) && !this.gclass17_0[index].isDone)
            {
              if (this.gclass17_0[index].y < this.gclass17_0[index].yTo)
              {
                if (this.gclass17_0[index].vy < Class15.smethod_0(0))
                  this.gclass17_0[index].vy = Class15.smethod_0(0);
                if (this.gclass17_0[index].y + this.gclass17_0[index].vy > this.gclass17_0[index].yTo)
                  this.gclass17_0[index].y = this.gclass17_0[index].yTo;
                else
                  this.gclass17_0[index].y += this.gclass17_0[index].vy;
                this.gclass17_0[index].vy += Class15.smethod_0(1);
              }
              else
              {
                if (this.gclass17_0[index].vy > Class15.smethod_0(0))
                  this.gclass17_0[index].vy = Class15.smethod_0(0);
                this.gclass17_0[index].y += this.gclass17_0[index].vy;
                this.gclass17_0[index].vy -= Class15.smethod_0(1);
              }
              if (this.gclass17_0[index].y == this.gclass17_0[index].yTo)
              {
                GClass40.smethod_0(new GClass41(Class15.smethod_0(65), this.gclass17_0[index].x - Class15.smethod_0(3), this.gclass17_0[index].y + Class15.smethod_0(46), Class15.smethod_0(7), Class15.smethod_0(1), -1));
                GClass172.smethod_1().method_31();
                this.gclass17_0[index].isDone = Class15.smethod_0(1) != 0;
                if (!this.bool_1)
                  this.bool_1 = Class15.smethod_0(1) != 0;
              }
            }
          }
        }
        if ((int) this.byte_0 == Class15.smethod_0(7))
        {
          for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
          {
            if (!this.gclass17_0[index].isDone)
            {
              if (this.gclass17_0[index].y > Class15.smethod_0(136))
              {
                if (this.gclass17_0[index].vy > Class15.smethod_0(0))
                  this.gclass17_0[index].vy = Class15.smethod_0(0);
                this.gclass17_0[index].y += this.gclass17_0[index].vy;
                this.gclass17_0[index].vy -= Class15.smethod_0(1);
                this.gclass17_0[index].x += this.gclass17_0[index].vx * this.gclass17_0[index].dir;
                this.gclass17_0[index].vx -= Class15.smethod_0(5);
              }
              if (this.gclass17_0[index].y == Class15.smethod_0(136))
                this.gclass17_0[index].isPaint = Class15.smethod_0(0) != 0;
            }
          }
          this.int_22 += Class15.smethod_0(1);
          if (this.int_22 > this.byte_2.Length - Class15.smethod_0(1))
          {
            this.int_22 = this.byte_2.Length - Class15.smethod_0(1);
            this.bool_0 = Class15.smethod_0(1) != 0;
            GClass172.smethod_1().method_53();
            if (!this.bool_2 && this.long_1 - GClass62.long_0 < (long) Class15.smethod_0(0))
            {
              GClass156.smethod_0().method_145((byte) Class15.smethod_0(7), (byte) ((uint) this.method_8() + (uint) this.method_9()));
              this.bool_2 = Class15.smethod_0(1) != 0;
            }
          }
          GClass20.smethod_1().cf = (int) this.byte_2[this.int_22];
          this.int_23 += Class15.smethod_0(1);
          if (this.int_23 > Class15.smethod_0(3))
            this.int_23 = Class15.smethod_0(0);
          this.int_24 = (int) this.byte_3[this.int_23];
        }
        if ((int) this.byte_0 == Class15.smethod_0(5))
        {
          if (this.int_23 <= Class15.smethod_0(3))
            this.int_23 = Class15.smethod_0(3);
          this.int_23 += Class15.smethod_0(1);
          if (this.int_23 > this.byte_3.Length - Class15.smethod_0(1))
          {
            this.int_23 = this.byte_3.Length - Class15.smethod_0(1);
            this.byte_0 = (byte) Class15.smethod_0(2);
            this.bool_0 = Class15.smethod_0(0) != 0;
            int index1 = Class15.smethod_0(0);
            for (int index2 = Class15.smethod_0(0); index2 < this.gclass17_0.Length; index2 += Class15.smethod_0(1))
            {
              if (this.gclass17_0[index2].isDone && !this.gclass17_0[index2].isSetImg)
              {
                this.gclass17_0[index2].idImg = (int) this.short_0[index1];
                this.gclass17_0[index2].isSetImg = Class15.smethod_0(1) != 0;
                index1 += Class15.smethod_0(1);
              }
            }
          }
          this.int_24 = (int) this.byte_3[this.int_23];
        }
        if ((int) this.byte_0 == Class15.smethod_0(2))
        {
          for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
          {
            if (this.gclass17_0[index].isPaint)
              this.gclass17_0[index].xTo = GClass20.smethod_1().cx;
          }
          this.byte_0 = (byte) Class15.smethod_0(3);
        }
        if ((int) this.byte_0 != Class15.smethod_0(3))
          return;
        this.int_25 += Class15.smethod_0(1);
        if (this.int_17 < GClass62.int_13 / Class15.smethod_0(5))
        {
          if (this.int_17 + this.int_25 > GClass62.int_13 / Class15.smethod_0(5))
            this.int_17 = GClass62.int_13 / Class15.smethod_0(5);
          else
            this.int_17 += this.int_25;
        }
        for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
        {
          if (this.gclass17_0[index].isPaint)
          {
            if (this.gclass17_0[index].x < this.gclass17_0[index].xTo)
            {
              if (this.gclass17_0[index].vx < Class15.smethod_0(0))
                this.gclass17_0[index].vx = Class15.smethod_0(0);
              if (this.gclass17_0[index].x + this.gclass17_0[index].vx > this.gclass17_0[index].xTo)
                this.gclass17_0[index].x = this.gclass17_0[index].xTo;
              else
                this.gclass17_0[index].x += this.gclass17_0[index].vx;
              this.gclass17_0[index].vx += Class15.smethod_0(1);
            }
            else
            {
              if (this.gclass17_0[index].vx > Class15.smethod_0(0))
                this.gclass17_0[index].vx = Class15.smethod_0(0);
              this.gclass17_0[index].x += this.gclass17_0[index].vx;
              this.gclass17_0[index].vx -= Class15.smethod_0(1);
            }
            if (this.gclass17_0[index].x == this.gclass17_0[index].xTo)
              this.gclass17_0[index].isPaint = Class15.smethod_0(0) != 0;
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
  }

  public override void vmethod_4()
  {
    if ((!GClass71.bool_1 ? 1 : 0) == 0)
      return;
    if ((!GClass62.bool_5 ? 1 : 0) == 0 && (!GClass23.smethod_0().isShow ? 0 : 1) == 0 && (!GClass62.gclass95_0.showMenu ? 0 : 1) == 0)
      this.method_4();
    for (int index = Class15.smethod_0(1); index < Class15.smethod_0(88); index += Class15.smethod_0(1))
    {
      if ((!GClass62.bool_11[index] ? 1 : 0) == 0)
      {
        GClass62.bool_11[index] = Class15.smethod_0(0) != 0;
        this.method_5(index - Class15.smethod_0(1));
      }
    }
    if ((!GClass62.bool_11[Class15.smethod_0(66)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[Class15.smethod_0(66)] = Class15.smethod_0(0) != 0;
      this.method_6(Class15.smethod_0(0));
    }
    if ((!GClass62.bool_11[Class15.smethod_0(47)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(0) != 0;
      this.method_6(Class15.smethod_0(1));
    }
    GClass62.smethod_24();
  }

  private void method_4()
  {
    if ((int) this.byte_0 == Class15.smethod_0(1) && (!GClass62.bool_15 ? 1 : 0) == 0)
    {
      for (int int_32 = Class15.smethod_0(0); int_32 < this.gclass17_0.Length; int_32 += Class15.smethod_0(1))
      {
        if ((!GClass62.smethod_22(this.gclass17_0[int_32].x - Class15.smethod_0(51) - GClass116.int_22, this.gclass17_0[int_32].y - Class15.smethod_0(31) - GClass116.int_23, Class15.smethod_0(6), Class15.smethod_0(6)) ? 1 : 0) == 0 && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
          this.method_5(int_32);
      }
    }
    if ((!GClass62.bool_15 ? 0 : 1) == 0)
      return;
    for (int int_32 = Class15.smethod_0(0); int_32 < GClass114.int_31.Length; int_32 += Class15.smethod_0(1))
    {
      if ((!GClass62.smethod_22(GClass114.int_31[int_32], GClass114.int_30, Class15.smethod_0(86), Class15.smethod_0(86)) ? 1 : 0) == 0 && (!GClass62.bool_15 ? 1 : 0) == 0 && (!GClass62.bool_16 ? 1 : 0) == 0)
        this.method_6(int_32);
    }
  }

  private void method_5(int int_32)
  {
    if ((!this.gclass17_0[int_32].isDone ? 0 : 1) != 0)
      return;
    GClass172.smethod_1().method_9();
    long num = (this.byte_1 == (byte) 0 ? 0 : 1) != 0 ? (long) GClass20.smethod_1().method_141() : GClass20.smethod_1().xu;
    if ((int) this.method_8() >= this.int_15 && num < (long) (this.int_21 + this.int_20))
    {
      string s = GClass109.string_6 + Class13.smethod_0(26649) + ((this.byte_1 == (byte) 0 ? 0 : 1) != 0 ? GClass109.string_157 : GClass109.string_156);
      GClass116.gclass73_0.method_7(s, Class15.smethod_0(0));
    }
    else
    {
      this.int_13 = int_32;
      this.gclass17_0[this.int_13].yTo = this.int_12 + GClass151.smethod_18(Class15.smethod_0(134), Class15.smethod_0(5));
    }
  }

  private void method_6(int int_32)
  {
    if (this.int_14 != int_32)
      this.int_14 = int_32;
    else if ((int_32 == 0 ? 0 : 1) == 0)
    {
      if ((int) this.byte_0 < Class15.smethod_0(7))
      {
        if ((int) this.method_8() + (int) this.method_9() <= Class15.smethod_0(0))
          return;
        this.byte_0 = (byte) Class15.smethod_0(7);
        GClass172.smethod_1().method_8();
        GClass20.smethod_1().method_65(GClass116.gclass165_0[Class15.smethod_0(47)], Class15.smethod_0(0));
        this.long_1 = GClass62.long_0 + (long) GClass151.smethod_18(Class15.smethod_0(20), Class15.smethod_0(302));
      }
      else
      {
        if (this.int_17 != GClass62.int_13 / Class15.smethod_0(5))
          return;
        GClass156.smethod_0().method_145(this.byte_1, (byte) Class15.smethod_0(0));
      }
    }
    else
    {
      GClass116.smethod_6().isRongThanXuatHien = Class15.smethod_0(0) != 0;
      GClass116.smethod_6().vmethod_0();
    }
  }

  public override void vmethod_5(GClass98 g)
  {
    try
    {
      GClass116.smethod_6().vmethod_5(g);
      g.method_1(-GClass116.int_22, -GClass116.int_23);
      g.method_1(Class15.smethod_0(0), GClass62.int_52);
      for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
      {
        if (this.gclass17_0[index].isPaint && this.gclass17_0[index].y > this.gclass17_0[index].yTo - Class15.smethod_0(51))
          g.method_32(GClass185.gclass66_10, this.gclass17_0[index].x, this.gclass17_0[index].yTo + Class15.smethod_0(38), GClass98.int_1 | GClass98.int_0);
      }
      for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
      {
        if (this.gclass17_0[index].isPaint)
          GClass169.smethod_6(g, this.gclass17_0[index].idImg, this.gclass17_0[index].x, this.gclass17_0[index].y, Class15.smethod_0(0), GClass98.int_1 | GClass98.int_0);
      }
      if (this.bool_0)
      {
        if (GClass114.gclass60_0 != null)
        {
          int num = GClass20.smethod_1().cx - GClass114.gclass60_0.frameWidth - Class15.smethod_0(35);
          for (int index = Class15.smethod_0(0); index < GClass62.int_10 / GClass114.gclass60_0.frameWidth + Class15.smethod_0(1); index += Class15.smethod_0(1))
            GClass114.gclass60_0.method_0(this.int_24, num - index * (GClass114.gclass60_0.frameWidth - Class15.smethod_0(1)), GClass20.smethod_1().cy - GClass114.gclass60_0.frameHeight / Class15.smethod_0(7) - Class15.smethod_0(66) + Class15.smethod_0(7), Class15.smethod_0(0), Class15.smethod_0(0), g);
        }
        if (GClass114.gclass60_1 != null)
        {
          int num = GClass20.smethod_1().cx - GClass114.gclass60_1.frameWidth - Class15.smethod_0(31);
          GClass114.gclass60_1.method_0(this.int_24, num - Class15.smethod_0(3), GClass20.smethod_1().cy - GClass114.gclass60_1.frameHeight / Class15.smethod_0(7) - Class15.smethod_0(66), Class15.smethod_0(0), Class15.smethod_0(0), g);
        }
      }
      GClass116.smethod_16(g);
      int w1 = Class15.smethod_0(194);
      int x1 = GClass62.int_10 - w1;
      int y = Class15.smethod_0(9);
      g.method_16(Class15.smethod_0(303));
      g.method_15(x1, y - Class15.smethod_0(9), w1, Class15.smethod_0(9));
      g.method_32(GClass141.gclass66_7, x1 + Class15.smethod_0(67), y - Class15.smethod_0(38), Class15.smethod_0(5));
      g.method_32(GClass141.gclass66_9, x1 + Class15.smethod_0(23), y - Class15.smethod_0(88), Class15.smethod_0(5));
      GClass97.gclass97_15.method_10(g, GClass20.smethod_1().xuStr + string.Empty, x1 + Class15.smethod_0(40), y - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
      GClass97.gclass97_15.method_10(g, GClass20.smethod_1().luongStr + string.Empty, x1 + Class15.smethod_0(21), y - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
      g.method_32(GClass141.gclass66_10, x1 + Class15.smethod_0(19), y - Class15.smethod_0(38), Class15.smethod_0(5));
      GClass97.gclass97_15.method_10(g, GClass20.smethod_1().luongKhoaStr + string.Empty, x1 + Class15.smethod_0(195), y - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
      g.method_32(GClass141.gclass66_8, x1 + Class15.smethod_0(90), y - Class15.smethod_0(38), Class15.smethod_0(5));
      GClass97.gclass97_15.method_10(g, this.int_15.ToString() + string.Empty, x1 + Class15.smethod_0(100), y - Class15.smethod_0(47), GClass97.int_0, GClass97.gclass97_16);
      if ((int) this.byte_0 < Class15.smethod_0(2))
      {
        int w2 = w1 / Class15.smethod_0(7) + Class15.smethod_0(51);
        int x2 = GClass62.int_10 - w2;
        g.method_16(Class15.smethod_0(304));
        g.method_15(x2, y, w2, Class15.smethod_0(9));
        if (this.byte_1 == (byte) 0)
        {
          g.method_32(GClass141.gclass66_7, x2 + Class15.smethod_0(27), y + Class15.smethod_0(88), Class15.smethod_0(5));
        }
        else
        {
          g.method_32(GClass141.gclass66_10, x2 + Class15.smethod_0(27), y + Class15.smethod_0(38), Class15.smethod_0(5));
          g.method_32(GClass141.gclass66_9, x2 + Class15.smethod_0(124), y + Class15.smethod_0(38), Class15.smethod_0(5));
        }
        GClass97.gclass97_17.method_10(g, Class13.smethod_0(26809) + this.int_21.ToString(), x2 + Class15.smethod_0(6), y + Class15.smethod_0(7), GClass97.int_0, GClass97.gclass97_16);
        g.method_32(GClass141.gclass66_8, x2 + Class15.smethod_0(25), y + Class15.smethod_0(38), Class15.smethod_0(5));
        GClass97.gclass97_17.method_10(g, Class13.smethod_0(26809) + this.method_8().ToString(), x2 + Class15.smethod_0(23), y + Class15.smethod_0(7), GClass97.int_0, GClass97.gclass97_16);
      }
      g.method_32(GClass116.gclass66_14, GClass114.int_31[Class15.smethod_0(0)], GClass114.int_30, Class15.smethod_0(0));
      if (this.int_14 == 0)
        g.method_32(GClass116.gclass66_15, GClass114.int_31[Class15.smethod_0(0)], GClass114.int_30, Class15.smethod_0(0));
      if ((int) this.byte_0 < Class15.smethod_0(5))
        GClass169.smethod_6(g, Class15.smethod_0(305), GClass114.int_31[Class15.smethod_0(0)] + Class15.smethod_0(49), GClass114.int_30 + Class15.smethod_0(49), Class15.smethod_0(0), GClass177.int_6);
      else
        g.method_32(GClass114.gclass66_1, GClass114.int_31[Class15.smethod_0(0)] + Class15.smethod_0(49) - Class15.smethod_0(31), GClass114.int_30 + Class15.smethod_0(49) - Class15.smethod_0(31), Class15.smethod_0(0));
      g.method_32(GClass116.gclass66_14, GClass114.int_31[Class15.smethod_0(1)], GClass114.int_30, Class15.smethod_0(0));
      if (this.int_14 == Class15.smethod_0(1))
        g.method_32(GClass116.gclass66_15, GClass114.int_31[Class15.smethod_0(1)], GClass114.int_30, Class15.smethod_0(0));
      g.method_32(GClass114.gclass66_0, GClass114.int_31[Class15.smethod_0(1)] + Class15.smethod_0(49) - Class15.smethod_0(31), GClass114.int_30 + Class15.smethod_0(49) - Class15.smethod_0(31), Class15.smethod_0(0));
      if ((int) this.byte_0 <= Class15.smethod_0(5))
        return;
      GClass62.gclass140_0.method_35(this.int_16, this.int_17, this.int_18, this.int_19, g);
      int num1 = GClass62.int_12 - this.short_0.Length * Class15.smethod_0(6) / Class15.smethod_0(7);
      for (int index = Class15.smethod_0(0); index < this.short_0.Length; index += Class15.smethod_0(1))
        GClass169.smethod_6(g, (int) this.short_0[index], num1 + Class15.smethod_0(3) + index * Class15.smethod_0(6), this.int_17 + Class15.smethod_0(31), Class15.smethod_0(0), Class15.smethod_0(0));
    }
    catch (Exception ex)
    {
    }
  }

  public void method_7(short[] idImage)
  {
    this.byte_0 = (byte) Class15.smethod_0(5);
    this.short_0 = idImage;
  }

  public override void vmethod_0()
  {
    GClass116.bool_0 = Class15.smethod_0(1) != 0;
    GClass116.smethod_6().isRongThanXuatHien = Class15.smethod_0(1) != 0;
    base.vmethod_0();
  }

  private byte method_8()
  {
    byte num = (byte) Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
    {
      if ((!this.gclass17_0[index].isDone ? 1 : 0) == 0)
        num += (byte) Class15.smethod_0(1);
    }
    if ((int) num > this.int_15)
      num = (byte) this.int_15;
    return num;
  }

  private byte method_9()
  {
    byte num1 = (byte) Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < this.gclass17_0.Length; index += Class15.smethod_0(1))
    {
      if ((!this.gclass17_0[index].isDone ? 1 : 0) == 0)
        num1 += (byte) Class15.smethod_0(1);
    }
    byte num2 = (byte) ((uint) num1 - (uint) this.method_8());
    if ((int) num2 <= Class15.smethod_0(0))
      num2 = (byte) Class15.smethod_0(0);
    return num2;
  }

  private void method_10()
  {
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      if ((GClass20.smethod_1().arrItemBag[index] == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().arrItemBag[index].template.id == (int) this.short_1)
      {
        this.int_15 = GClass20.smethod_1().arrItemBag[index].quantity;
        break;
      }
    }
  }
}
