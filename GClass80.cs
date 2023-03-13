// Decompiled with JetBrains decompiler
// Type: GClass80
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass80
{
  public const int int_0 = 34;
  public const int int_1 = 35;
  public const int int_2 = 36;
  public const int int_3 = 41;
  public const int int_4 = 72;
  public const int int_5 = 102;
  public const int int_6 = 107;
  public const int int_7 = 0;
  public const int int_8 = 6;
  public const int int_9 = 0;
  public const int int_10 = 1;
  public const int int_11 = 2;
  public const int int_12 = 3;
  public const int int_13 = 4;
  public const int int_14 = 5;
  public const int int_15 = 6;
  public const int int_16 = 12;
  public const int int_17 = 7;
  public const int int_18 = 8;
  public const int int_19 = 9;
  public const int int_20 = 10;
  public const int int_21 = 11;
  public const int int_22 = 23;
  public const int int_23 = 24;
  public const int int_24 = 34;
  public const int int_25 = 32;
  public const int int_26 = 35;
  public const sbyte sbyte_0 = 2;
  public const sbyte sbyte_1 = 3;
  public const sbyte sbyte_2 = 4;
  public const sbyte sbyte_3 = 5;
  public const sbyte sbyte_4 = 6;
  public const sbyte sbyte_5 = 7;
  public const sbyte sbyte_6 = 8;
  public const sbyte sbyte_7 = 9;
  public const sbyte sbyte_8 = 10;
  public const sbyte sbyte_9 = 11;
  public const sbyte sbyte_10 = 12;
  public const sbyte sbyte_11 = 13;
  public const sbyte sbyte_12 = 14;
  public const sbyte sbyte_13 = 15;
  public const sbyte sbyte_14 = 16;
  public const sbyte sbyte_15 = 17;
  public const sbyte sbyte_16 = 18;
  public const sbyte sbyte_17 = 19;
  public const sbyte sbyte_18 = 20;
  public const sbyte sbyte_19 = 21;
  public const sbyte sbyte_20 = 22;
  public const sbyte sbyte_21 = 23;
  public const sbyte sbyte_22 = 24;
  public const sbyte sbyte_23 = 25;
  public const sbyte sbyte_24 = 26;
  public const sbyte sbyte_25 = 27;
  public const sbyte sbyte_26 = 28;
  public const sbyte sbyte_27 = 29;
  public const sbyte sbyte_28 = 30;
  public const sbyte sbyte_29 = 31;
  public const sbyte sbyte_30 = 32;
  public const sbyte sbyte_31 = 33;
  public GClass83[] itemOption;
  public GClass85 template;
  public GClass134 options;
  public int itemId;
  public int playerId;
  public bool isSelect;
  public int indexUI;
  public int quantity;
  public int quantilyToBuy;
  public long powerRequire;
  public bool isLock;
  public int sys;
  public int upgrade;
  public int buyCoin;
  public int buyCoinLock;
  public int buyGold;
  public int buyGoldLock;
  public int saleCoinLock;
  public int buySpec;
  public int buyRuby;
  public short iconSpec;
  public sbyte buyType;
  public int typeUI;
  public bool isExpires;
  public bool isBuySpec;
  public GClass49 eff;
  public int indexEff;
  public GClass66 img;
  public string info;
  public string content;
  public string reason;
  public int compare;
  public sbyte isMe;
  public bool newItem;
  public int headTemp;
  public int bodyTemp;
  public int legTemp;
  public int bagTemp;
  public int wpTemp;
  private int[] int_27;
  private int[][] int_28;
  private int[] int_29;

  public void method_0() => this.compare = GClass62.gclass141_0.method_124(this);

  public string method_1()
  {
    string str = string.Empty;
    if (this.buyCoin <= Class15.smethod_0(0) && this.buyGold <= Class15.smethod_0(0))
      return (string) null;
    if (this.buyCoin > Class15.smethod_0(0) && this.buyGold <= Class15.smethod_0(0))
      str = this.buyCoin.ToString() + GClass109.string_156;
    else if (this.buyGold > Class15.smethod_0(0) && this.buyCoin <= Class15.smethod_0(0))
      str = this.buyGold.ToString() + GClass109.string_157;
    else if (this.buyCoin > Class15.smethod_0(0) && this.buyGold > Class15.smethod_0(0))
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = this.buyCoin.ToString();
      strArray[Class15.smethod_0(1)] = GClass109.string_156;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(120987);
      strArray[Class15.smethod_0(5)] = this.buyGold.ToString();
      strArray[Class15.smethod_0(2)] = GClass109.string_157;
      str = string.Concat(strArray);
    }
    return str;
  }

  public void method_2(int x, int y, int upgrade, GClass98 g)
  {
    int num1 = GClass116.int_42 - Class15.smethod_0(7);
    int num2 = Class15.smethod_0(0);
    int index1 = upgrade >= Class15.smethod_0(2) ? (upgrade < Class15.smethod_0(88) ? Class15.smethod_0(1) : (upgrade < Class15.smethod_0(66) ? Class15.smethod_0(7) : (upgrade > Class15.smethod_0(49) ? Class15.smethod_0(2) : Class15.smethod_0(5)))) : Class15.smethod_0(0);
    for (int index2 = num2; index2 < this.int_29.Length; index2 += Class15.smethod_0(1))
    {
      int num3 = x - num1 / Class15.smethod_0(7) + this.method_4(GClass62.int_8 - index2 * Class15.smethod_0(2));
      int num4 = y - num1 / Class15.smethod_0(7) + this.method_3(GClass62.int_8 - index2 * Class15.smethod_0(2));
      g.method_16(this.int_28[index1][index2]);
      g.method_15(num3 - this.int_29[index2] / Class15.smethod_0(7), num4 - this.int_29[index2] / Class15.smethod_0(7), this.int_29[index2], this.int_29[index2]);
    }
    if (upgrade == Class15.smethod_0(2) || upgrade == Class15.smethod_0(88))
    {
      for (int index3 = num2; index3 < this.int_29.Length; index3 += Class15.smethod_0(1))
      {
        int num5 = x - num1 / Class15.smethod_0(7) + this.method_4(GClass62.int_8 - num1 * Class15.smethod_0(7) - index3 * Class15.smethod_0(2));
        int num6 = y - num1 / Class15.smethod_0(7) + this.method_3(GClass62.int_8 - num1 * Class15.smethod_0(7) - index3 * Class15.smethod_0(2));
        g.method_16(this.int_28[index1 - Class15.smethod_0(1)][index3]);
        g.method_15(num5 - this.int_29[index3] / Class15.smethod_0(7), num6 - this.int_29[index3] / Class15.smethod_0(7), this.int_29[index3], this.int_29[index3]);
      }
    }
    if (upgrade != Class15.smethod_0(1) && upgrade != Class15.smethod_0(2) && upgrade != Class15.smethod_0(88))
    {
      for (int index4 = num2; index4 < this.int_29.Length; index4 += Class15.smethod_0(1))
      {
        int num7 = x - num1 / Class15.smethod_0(7) + this.method_4(GClass62.int_8 - num1 * Class15.smethod_0(7) - index4 * Class15.smethod_0(2));
        int num8 = y - num1 / Class15.smethod_0(7) + this.method_3(GClass62.int_8 - num1 * Class15.smethod_0(7) - index4 * Class15.smethod_0(2));
        g.method_16(this.int_28[index1][index4]);
        g.method_15(num7 - this.int_29[index4] / Class15.smethod_0(7), num8 - this.int_29[index4] / Class15.smethod_0(7), this.int_29[index4], this.int_29[index4]);
      }
    }
    if (upgrade != Class15.smethod_0(1) && upgrade != Class15.smethod_0(2) && upgrade != Class15.smethod_0(88) && upgrade != Class15.smethod_0(66) && upgrade != Class15.smethod_0(7) && upgrade != Class15.smethod_0(3) && upgrade != Class15.smethod_0(45))
    {
      for (int index5 = num2; index5 < this.int_29.Length; index5 += Class15.smethod_0(1))
      {
        int num9 = x - num1 / Class15.smethod_0(7) + this.method_4(GClass62.int_8 - num1 - index5 * Class15.smethod_0(2));
        int num10 = y - num1 / Class15.smethod_0(7) + this.method_3(GClass62.int_8 - num1 - index5 * Class15.smethod_0(2));
        g.method_16(this.int_28[index1][index5]);
        g.method_15(num9 - this.int_29[index5] / Class15.smethod_0(7), num10 - this.int_29[index5] / Class15.smethod_0(7), this.int_29[index5], this.int_29[index5]);
      }
    }
    if (upgrade == Class15.smethod_0(1) || upgrade == Class15.smethod_0(2) || upgrade == Class15.smethod_0(88) || upgrade == Class15.smethod_0(66) || upgrade == Class15.smethod_0(7) || upgrade == Class15.smethod_0(3) || upgrade == Class15.smethod_0(45) || upgrade == Class15.smethod_0(47) || upgrade == Class15.smethod_0(5) || upgrade == Class15.smethod_0(37) || upgrade == Class15.smethod_0(31) || upgrade == Class15.smethod_0(9))
      return;
    for (int index6 = num2; index6 < this.int_29.Length; index6 += Class15.smethod_0(1))
    {
      int num11 = x - num1 / Class15.smethod_0(7) + this.method_4(GClass62.int_8 - num1 * Class15.smethod_0(5) - index6 * Class15.smethod_0(2));
      int num12 = y - num1 / Class15.smethod_0(7) + this.method_3(GClass62.int_8 - num1 * Class15.smethod_0(5) - index6 * Class15.smethod_0(2));
      g.method_16(this.int_28[index1][index6]);
      g.method_15(num11 - this.int_29[index6] / Class15.smethod_0(7), num12 - this.int_29[index6] / Class15.smethod_0(7), this.int_29[index6], this.int_29[index6]);
    }
  }

  private int method_3(int int_30)
  {
    int num1 = GClass116.int_42 - Class15.smethod_0(7);
    int num2 = int_30 % (Class15.smethod_0(2) * num1);
    if (Class15.smethod_0(0) <= num2 && num2 < num1)
      return Class15.smethod_0(0);
    if (num1 <= num2 && num2 < num1 * Class15.smethod_0(7))
      return num2 % num1;
    return num1 * Class15.smethod_0(7) <= num2 && num2 < num1 * Class15.smethod_0(5) ? num1 : num1 - num2 % num1;
  }

  private int method_4(int int_30)
  {
    int num1 = GClass116.int_42 - Class15.smethod_0(7);
    int num2 = int_30 % (Class15.smethod_0(2) * num1);
    if (Class15.smethod_0(0) <= num2 && num2 < num1)
      return num2 % num1;
    if (num1 <= num2 && num2 < num1 * Class15.smethod_0(7))
      return num1;
    return num1 * Class15.smethod_0(7) <= num2 && num2 < num1 * Class15.smethod_0(5) ? num1 - num2 % num1 : Class15.smethod_0(0);
  }

  public bool method_5(int id)
  {
    for (int index = Class15.smethod_0(0); index < this.itemOption.Length; index += Class15.smethod_0(1))
    {
      GClass83 gclass83 = this.itemOption[index];
      if ((gclass83 == null ? 1 : 0) == 0 && gclass83.optionTemplate.id == id)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public GClass80 method_6()
  {
    GClass80 gclass80 = new GClass80();
    gclass80.template = this.template;
    if ((this.options == null ? 1 : 0) == 0)
    {
      gclass80.options = new GClass134();
      for (int index = Class15.smethod_0(0); index < this.options.method_2(); index += Class15.smethod_0(1))
        gclass80.options.method_0((object) new GClass83()
        {
          optionTemplate = ((GClass83) this.options.method_3(index)).optionTemplate,
          param = ((GClass83) this.options.method_3(index)).param
        });
    }
    gclass80.itemId = this.itemId;
    gclass80.playerId = this.playerId;
    gclass80.indexUI = this.indexUI;
    gclass80.quantity = this.quantity;
    gclass80.isLock = this.isLock;
    gclass80.sys = this.sys;
    gclass80.upgrade = this.upgrade;
    gclass80.buyCoin = this.buyCoin;
    gclass80.buyCoinLock = this.buyCoinLock;
    gclass80.buyGold = this.buyGold;
    gclass80.buyGoldLock = this.buyGoldLock;
    gclass80.saleCoinLock = this.saleCoinLock;
    gclass80.typeUI = this.typeUI;
    gclass80.isExpires = this.isExpires;
    return gclass80;
  }

  public bool method_7() => (Class15.smethod_0(0) > (int) this.template.type || (int) this.template.type >= Class15.smethod_0(37)) && (int) this.template.type != Class15.smethod_0(120) && (int) this.template.type != Class15.smethod_0(95) && (int) this.template.type != Class15.smethod_0(67) && (int) this.template.type != Class15.smethod_0(29) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public string method_8() => (!this.isLock ? 1 : 0) == 0 ? GClass109.string_152 : GClass109.string_155;

  public string method_9()
  {
    if ((int) this.template.level < Class15.smethod_0(31) || (int) this.template.type >= Class15.smethod_0(31))
      return GClass109.string_223;
    return (this.upgrade == 0 ? 0 : 1) == 0 ? GClass109.string_222 : (string) null;
  }

  public bool method_10() => this.typeUI != Class15.smethod_0(3) && this.typeUI != Class15.smethod_0(5) && this.typeUI != Class15.smethod_0(2) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public bool method_11()
  {
    if ((!this.method_12() ? 1 : 0) == 0)
      return Class15.smethod_0(1) != 0;
    return (!this.method_14() ? 0 : 1) == 0 && (!this.method_15() ? 0 : 1) == 0 && (!this.method_16() ? 1 : 0) != 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public bool method_12() => this.typeUI != Class15.smethod_0(51) && this.typeUI != Class15.smethod_0(27) && this.typeUI != Class15.smethod_0(28) && this.typeUI != Class15.smethod_0(29) && this.typeUI != Class15.smethod_0(40) && this.typeUI != Class15.smethod_0(46) && this.typeUI != Class15.smethod_0(50) && this.typeUI != Class15.smethod_0(33) && this.typeUI != Class15.smethod_0(35) && this.typeUI != Class15.smethod_0(36) && this.typeUI != Class15.smethod_0(10) && this.typeUI != Class15.smethod_0(186) && this.typeUI != Class15.smethod_0(124) && this.typeUI != Class15.smethod_0(65) && this.typeUI != Class15.smethod_0(7) && this.typeUI != Class15.smethod_0(37) && this.typeUI != Class15.smethod_0(88) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public bool method_13() => this.typeUI != Class15.smethod_0(38) && this.typeUI != Class15.smethod_0(45) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;

  public bool method_14() => this.typeUI == Class15.smethod_0(49) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public bool method_15() => this.typeUI == Class15.smethod_0(9) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public bool method_16() => this.typeUI == Class15.smethod_0(120) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public bool method_17() => this.method_18() == this.upgrade ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public int method_18()
  {
    if ((int) this.template.level >= Class15.smethod_0(1) && (int) this.template.level < Class15.smethod_0(51))
      return Class15.smethod_0(2);
    if ((int) this.template.level >= Class15.smethod_0(51) && (int) this.template.level < Class15.smethod_0(54))
      return Class15.smethod_0(88);
    if ((int) this.template.level >= Class15.smethod_0(54) && (int) this.template.level < Class15.smethod_0(32))
      return Class15.smethod_0(66);
    return (int) this.template.level >= Class15.smethod_0(32) && (int) this.template.level < Class15.smethod_0(4) ? Class15.smethod_0(49) : Class15.smethod_0(10);
  }

  public void method_19(int headTemp, int bodyTemp, int legTemp, int bagTemp)
  {
    this.headTemp = headTemp;
    this.bodyTemp = bodyTemp;
    this.legTemp = legTemp;
    this.bagTemp = bagTemp;
  }

  private int method_20(int int_30)
  {
    int num1 = Class15.smethod_0(120);
    int num2 = int_30 % (Class15.smethod_0(2) * num1);
    if (Class15.smethod_0(0) <= num2 && num2 < num1)
      return num2 % num1;
    if (num1 <= num2 && num2 < num1 * Class15.smethod_0(7))
      return num1;
    return num1 * Class15.smethod_0(7) <= num2 && num2 < num1 * Class15.smethod_0(5) ? num1 - num2 % num1 : Class15.smethod_0(0);
  }

  private int method_21(int int_30)
  {
    int num1 = Class15.smethod_0(28);
    int num2 = int_30 % (Class15.smethod_0(2) * num1);
    if (Class15.smethod_0(0) <= num2 && num2 < num1)
      return Class15.smethod_0(0);
    if (num1 <= num2 && num2 < num1 * Class15.smethod_0(7))
      return num2 % num1;
    return num1 * Class15.smethod_0(7) <= num2 && num2 < num1 * Class15.smethod_0(5) ? num1 : num1 - num2 % num1;
  }

  public void method_22(GClass98 g, int x, int y, int upgrade)
  {
    if (upgrade > Class15.smethod_0(38))
      upgrade = Class15.smethod_0(38);
    if (upgrade < Class15.smethod_0(0))
      upgrade = Class15.smethod_0(0);
    byte[] byte_0_1 = new byte[Class15.smethod_0(135)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.QyuOuSDtjBLb));
    int[] numArray1 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(25)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.ZUJicrSCzzBz));
    int[] numArray2 = (int[]) Class15.smethod_4(byte_0_2);
    int[] numArray3 = new int[Class15.smethod_0(2)];
    numArray3[Class15.smethod_0(1)] = Class15.smethod_0(11);
    numArray3[Class15.smethod_0(7)] = Class15.smethod_0(11);
    int[] numArray4 = numArray3;
    int[] numArray5 = new int[Class15.smethod_0(2)];
    numArray5[Class15.smethod_0(1)] = Class15.smethod_0(154);
    numArray5[Class15.smethod_0(5)] = Class15.smethod_0(154);
    int[] numArray6 = numArray5;
    if (upgrade >= Class15.smethod_0(2))
    {
      g.method_16(numArray2[upgrade]);
      g.method_15(x - Class15.smethod_0(124), y - Class15.smethod_0(66), Class15.smethod_0(117), Class15.smethod_0(29));
    }
    if (upgrade < Class15.smethod_0(2))
    {
      if (upgrade != Class15.smethod_0(1))
      {
        if (upgrade != Class15.smethod_0(7))
        {
          for (int index1 = Class15.smethod_0(0); index1 < Class15.smethod_0(7); index1 += Class15.smethod_0(1))
          {
            for (int index2 = Class15.smethod_0(0); index2 < this.int_29.Length; index2 += Class15.smethod_0(1))
            {
              int num1 = x - Class15.smethod_0(186) + this.method_20(GClass62.int_8 + numArray4[index1] - index2 * Class15.smethod_0(2));
              int num2 = y - Class15.smethod_0(66) + this.method_21(GClass62.int_8 + numArray6[index1] - index2 * Class15.smethod_0(2));
              g.method_16(this.int_28[Class15.smethod_0(0)][index2]);
              g.method_15(num1 - this.int_29[index2] / Class15.smethod_0(7), num2 - this.int_29[index2] / Class15.smethod_0(7), this.int_29[index2], this.int_29[index2]);
            }
          }
          for (int index3 = Class15.smethod_0(7); index3 < Class15.smethod_0(2); index3 += Class15.smethod_0(1))
          {
            for (int index4 = Class15.smethod_0(0); index4 < this.int_29.Length; index4 += Class15.smethod_0(1))
            {
              int num3 = x - Class15.smethod_0(186) + this.method_20(GClass62.int_8 + numArray4[index3] - index4 * Class15.smethod_0(2));
              int num4 = y - Class15.smethod_0(66) + this.method_21(GClass62.int_8 + numArray6[index3] - index4 * Class15.smethod_0(2));
              g.method_16(this.int_28[Class15.smethod_0(1)][index4]);
              g.method_15(num3 - this.int_29[index4] / Class15.smethod_0(7), num4 - this.int_29[index4] / Class15.smethod_0(7), this.int_29[index4], this.int_29[index4]);
            }
          }
          return;
        }
      }
      else
      {
        for (int index5 = Class15.smethod_0(0); index5 < Class15.smethod_0(7); index5 += Class15.smethod_0(1))
        {
          for (int index6 = Class15.smethod_0(0); index6 < this.int_29.Length; index6 += Class15.smethod_0(1))
          {
            int num5 = x - Class15.smethod_0(186) + this.method_20(GClass62.int_8 + numArray4[index5] - index6 * Class15.smethod_0(2));
            int num6 = y - Class15.smethod_0(66) + this.method_21(GClass62.int_8 + numArray6[index5] - index6 * Class15.smethod_0(2));
            g.method_16(this.int_28[numArray1[upgrade - Class15.smethod_0(1)]][index6]);
            g.method_15(num5 - this.int_29[index6] / Class15.smethod_0(7), num6 - this.int_29[index6] / Class15.smethod_0(7), this.int_29[index6], this.int_29[index6]);
          }
        }
        return;
      }
    }
    for (int index7 = Class15.smethod_0(0); index7 < Class15.smethod_0(2); index7 += Class15.smethod_0(1))
    {
      for (int index8 = Class15.smethod_0(0); index8 < this.int_29.Length; index8 += Class15.smethod_0(1))
      {
        int num7 = x - Class15.smethod_0(186) + this.method_20(GClass62.int_8 + numArray4[index7] - index8 * Class15.smethod_0(2));
        int num8 = y - Class15.smethod_0(66) + this.method_21(GClass62.int_8 + numArray6[index7] - index8 * Class15.smethod_0(2));
        g.method_16(this.int_28[numArray1[upgrade - Class15.smethod_0(1)]][index8]);
        g.method_15(num7 - this.int_29[index8] / Class15.smethod_0(7), num8 - this.int_29[index8] / Class15.smethod_0(7), this.int_29[index8], this.int_29[index8]);
      }
    }
  }

  public string method_23()
  {
    string str1 = this.template.name;
    if ((this.itemOption == null ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < this.itemOption.Length; index += Class15.smethod_0(1))
      {
        if (this.itemOption[index].optionTemplate.id == Class15.smethod_0(107))
        {
          str1 = str1 + Class13.smethod_0(121671) + this.itemOption[index].param.ToString() + Class13.smethod_0(121764);
          break;
        }
      }
    }
    if ((this.itemOption == null ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < this.itemOption.Length; index += Class15.smethod_0(1))
      {
        if ((!this.itemOption[index].optionTemplate.name.StartsWith(Class13.smethod_0(121748)) ? 1 : 0) == 0)
        {
          string str2 = this.itemOption[index].method_2();
          if (this.itemOption[index].param == Class15.smethod_0(1))
            str1 = str1 + Class13.smethod_0(121746) + str2;
          if ((this.itemOption[index].param == 0 ? 0 : 1) == 0)
            str1 = str1 + Class13.smethod_0(121746) + str2;
        }
        else
        {
          string str3 = this.itemOption[index].method_0();
          if ((!str3.Equals(string.Empty) ? 0 : 1) == 0 && this.itemOption[index].optionTemplate.id != Class15.smethod_0(107))
            str1 = str1 + Class13.smethod_0(121746) + str3;
        }
      }
    }
    if (this.template.strRequire > Class15.smethod_0(1))
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = str1;
      strArray[Class15.smethod_0(1)] = Class13.smethod_0(121746);
      strArray[Class15.smethod_0(7)] = GClass109.string_217;
      strArray[Class15.smethod_0(5)] = Class13.smethod_0(121740);
      strArray[Class15.smethod_0(2)] = this.template.strRequire.ToString();
      str1 = string.Concat(strArray);
    }
    return str1 + Class13.smethod_0(121746) + this.template.description;
  }

  public GClass80()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(57)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.pQjGINkdQdKR));
    this.int_27 = (int[]) Class15.smethod_4(byte_0_1);
    int[][] numArray1 = new int[Class15.smethod_0(3)][];
    int index1 = Class15.smethod_0(0);
    byte[] byte_0_2 = new byte[Class15.smethod_0(119)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.ebFXZbKKgQLI));
    int[] numArray2 = (int[]) Class15.smethod_4(byte_0_2);
    numArray1[index1] = numArray2;
    int index2 = Class15.smethod_0(1);
    byte[] byte_0_3 = new byte[Class15.smethod_0(25)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.utKgNtoPOaVQ));
    int[] numArray3 = (int[]) Class15.smethod_4(byte_0_3);
    numArray1[index2] = numArray3;
    int index3 = Class15.smethod_0(7);
    byte[] byte_0_4 = new byte[Class15.smethod_0(119)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.sMOHmJOFqAuG));
    int[] numArray4 = (int[]) Class15.smethod_4(byte_0_4);
    numArray1[index3] = numArray4;
    int index4 = Class15.smethod_0(5);
    byte[] byte_0_5 = new byte[Class15.smethod_0(121)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.GTdcjoRLvPUL));
    int[] numArray5 = (int[]) Class15.smethod_4(byte_0_5);
    numArray1[index4] = numArray5;
    int index5 = Class15.smethod_0(2);
    byte[] byte_0_6 = new byte[Class15.smethod_0(39)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.bNsdYSFbgpfX));
    int[] numArray6 = (int[]) Class15.smethod_4(byte_0_6);
    numArray1[index5] = numArray6;
    this.int_28 = numArray1;
    byte[] byte_0_7 = new byte[Class15.smethod_0(151)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.GygbOVXKqEqP));
    this.int_29 = (int[]) Class15.smethod_4(byte_0_7);
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }
}
