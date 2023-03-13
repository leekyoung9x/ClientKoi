// Decompiled with JetBrains decompiler
// Type: GClass8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public class GClass8 : GInterface0
{
  public static GClass8 gclass8_0 = new GClass8();
  private Dictionary<int, List<GClass8.GClass9>> dictionary_0;
  private Dictionary<string, int[]> dictionary_1;
  private bool bool_0;
  private int int_0;
  private int[] int_1;
  private int[] int_2;
  private int[] int_3;
  private bool bool_1;
  private bool bool_2;
  private bool bool_3;
  private bool bool_4;
  private bool bool_5;
  private long long_0;
  private bool bool_6;
  private long long_1;
  private int[] int_4;
  private int[] int_5;
  private int[] int_6;
  private int[] int_7;
  private int[] int_8;
  private int[] int_9;

  public GClass8()
  {
    this.dictionary_0 = new Dictionary<int, List<GClass8.GClass9>>();
    this.dictionary_1 = new Dictionary<string, int[]>();
    this.bool_1 = Class15.smethod_0(1) != 0;
    this.bool_3 = Class15.smethod_0(1) != 0;
    byte[] byte_0_1 = new byte[Class15.smethod_0(23)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.sgHvbzeHgRif));
    this.int_4 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(21)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.IpREvPhakZIA));
    this.int_5 = (int[]) Class15.smethod_4(byte_0_2);
    byte[] byte_0_3 = new byte[Class15.smethod_0(24)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.FnBSvybkZRcF));
    this.int_6 = (int[]) Class15.smethod_4(byte_0_3);
    byte[] byte_0_4 = new byte[Class15.smethod_0(25)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.MOMITAkEijHa));
    this.int_7 = (int[]) Class15.smethod_4(byte_0_4);
    byte[] byte_0_5 = new byte[Class15.smethod_0(26)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.dxxfHcFIOPFF));
    this.int_8 = (int[]) Class15.smethod_4(byte_0_5);
    byte[] byte_0_6 = new byte[Class15.smethod_0(21)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.gclCKXyrXjYc));
    this.int_9 = (int[]) Class15.smethod_4(byte_0_6);
    this.method_12();
    this.method_13();
    this.method_14();
    this.method_10();
  }

  public void method_0()
  {
    if ((!GClass20.smethod_1().meDead ? 1 : 0) == 0)
      this.long_1 = GClass126.smethod_18() + (long) Class15.smethod_0(15);
    if (GClass185.int_37 == this.int_0)
    {
      this.method_5();
    }
    else
    {
      bool flag1 = Class15.smethod_0(0) != 0;
      if (GClass185.int_37 == Class15.smethod_0(27) || GClass185.int_37 == Class15.smethod_0(28) || GClass185.int_37 == Class15.smethod_0(29))
      {
        if ((!this.bool_1 ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
          {
            GClass81 gclass81 = (GClass81) GClass116.gclass134_6.method_3(index);
            if ((gclass81.playerId == GClass20.smethod_1().charID || gclass81.playerId == -1) && (int) gclass81.template.id == Class15.smethod_0(26))
            {
              flag1 = Class15.smethod_0(1) != 0;
              GClass20.smethod_1().itemFocus = gclass81;
              if (GClass126.smethod_18() - this.long_1 > (long) Class15.smethod_0(30))
              {
                this.long_1 = GClass126.smethod_18();
                GClass156.smethod_0().method_75(GClass20.smethod_1().itemFocus.itemMapID);
                return;
              }
            }
          }
        }
        if ((!this.bool_0 ? 1 : 0) == 0 && (!this.bool_2 ? 1 : 0) == 0 && GClass116.int_37 < Class15.smethod_0(31) && GClass116.smethod_6().magicTree.currPeas > Class15.smethod_0(0) && GClass126.smethod_18() - this.long_1 > (long) Class15.smethod_0(16))
        {
          this.long_1 = GClass126.smethod_18();
          GClass156.smethod_0().method_61(Class15.smethod_0(2));
          GClass156.smethod_0().method_62(Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
        }
      }
      if ((!((this.bool_0 ? 1 : 0) == Class15.smethod_0(0) | flag1) ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_1 <= (long) Class15.smethod_0(15) || (GClass62.int_8 % Class15.smethod_0(32) == 0 ? 1 : 0) == 0)
        return;
      bool flag2 = Class15.smethod_0(1) != 0;
      if ((!this.method_29(this.int_0) ? 1 : 0) == 0)
      {
        if ((!flag2 ? 1 : 0) == 0 && GClass185.int_37 == Class15.smethod_0(33) && (GClass116.smethod_11((short) Class15.smethod_0(34)) == null ? 0 : 1) == 0)
        {
          flag2 = Class15.smethod_0(0) != 0;
          this.method_6(Class15.smethod_0(35));
        }
        if ((!flag2 ? 1 : 0) == 0 && GClass185.int_37 == Class15.smethod_0(36) && (GClass116.smethod_11((short) Class15.smethod_0(34)) == null ? 0 : 1) == 0)
        {
          flag2 = Class15.smethod_0(0) != 0;
          this.method_6(Class15.smethod_0(35));
        }
        if ((!flag2 ? 1 : 0) == 0 && GClass185.int_37 == Class15.smethod_0(35) && (GClass116.smethod_11((short) Class15.smethod_0(34)) == null ? 0 : 1) == 0)
        {
          flag2 = Class15.smethod_0(0) != 0;
          if (GClass20.smethod_1().cx < GClass185.int_23 / Class15.smethod_0(7))
            this.method_6(Class15.smethod_0(36));
          else
            this.method_6(Class15.smethod_0(33));
        }
      }
      if ((!flag2 ? 1 : 0) != 0)
        return;
      this.method_6(this.int_0);
    }
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(1))
    {
      case 0:
        this.method_2();
        break;
      case 1:
        this.bool_1 = (this.bool_1 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28949) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(29135) : Class13.smethod_0(29167)), Class15.smethod_0(0));
        if ((!this.bool_6 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(29130), (!this.bool_1 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 2:
        this.bool_2 = (this.bool_2 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28726) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(29135) : Class13.smethod_0(29167)), Class15.smethod_0(0));
        if ((!this.bool_6 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(28700), (!this.bool_2 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 3:
        this.bool_3 = (this.bool_3 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28770) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(29135) : Class13.smethod_0(29167)), Class15.smethod_0(0));
        if ((!this.bool_6 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(29613), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 4:
        this.bool_6 = (this.bool_6 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(29597) + ((!this.bool_6 ? 0 : 1) != 0 ? Class13.smethod_0(29135) : Class13.smethod_0(29167)), Class15.smethod_0(0));
        GClass152.smethod_9(Class13.smethod_0(29570), (!this.bool_6 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        if ((!this.bool_6 ? 1 : 0) != 0)
          break;
        this.method_11();
        break;
      case 5:
        this.method_3((int[]) p);
        break;
      case 6:
        this.bool_0 = Class15.smethod_0(1) != 0;
        this.int_0 = (int) p;
        GClass116.gclass73_0.method_7(Class13.smethod_0(29675) + GClass185.string_2[this.int_0], Class15.smethod_0(0));
        break;
    }
  }

  public void method_1()
  {
    this.method_10();
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30144), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(29894) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(30894) : Class13.smethod_0(30906)), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30889) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(30894) : Class13.smethod_0(30906)), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(5), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30877) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(30894) : Class13.smethod_0(30906)), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30856) + ((!this.bool_6 ? 0 : 1) != 0 ? Class13.smethod_0(30894) : Class13.smethod_0(30906)), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(3), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
    GClass134 menuItems = new GClass134();
    using (Dictionary<string, int[]>.Enumerator enumerator = this.dictionary_1.GetEnumerator())
    {
      while ((!enumerator.MoveNext() ? 0 : 1) != 0)
      {
        KeyValuePair<string, int[]> current = enumerator.Current;
        menuItems.method_0((object) new GClass31(current.Key, (GInterface0) GClass8.gclass8_0, Class15.smethod_0(37), (object) current.Value));
      }
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_3(int[] int_10)
  {
    GClass134 menuItems = new GClass134();
    for (int index = Class15.smethod_0(0); index < int_10.Length; index += Class15.smethod_0(1))
    {
      if (((GClass20.smethod_1().cgender == 0 ? 0 : 1) != 0 || int_10[index] != Class15.smethod_0(28) && int_10[index] != Class15.smethod_0(29)) && (GClass20.smethod_1().cgender != Class15.smethod_0(1) || int_10[index] != Class15.smethod_0(27) && int_10[index] != Class15.smethod_0(29)) && (GClass20.smethod_1().cgender != Class15.smethod_0(7) || int_10[index] != Class15.smethod_0(27) && int_10[index] != Class15.smethod_0(28)))
        menuItems.method_0((object) new GClass31(this.method_23(int_10[index]), (GInterface0) GClass8.gclass8_0, Class15.smethod_0(38), (object) int_10[index]));
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  public void method_4(int mapId)
  {
    this.bool_0 = Class15.smethod_0(1) != 0;
    this.int_0 = mapId;
  }

  public void method_5()
  {
    this.bool_0 = Class15.smethod_0(0) != 0;
    this.bool_4 = Class15.smethod_0(0) != 0;
    this.bool_5 = Class15.smethod_0(0) != 0;
  }

  public void method_6(int mapId)
  {
    if ((!this.dictionary_0.ContainsKey(Class15.smethod_0(39)) ? 1 : 0) == 0)
      this.dictionary_0.Remove(Class15.smethod_0(39));
    this.dictionary_0.Add(Class15.smethod_0(39), new List<GClass8.GClass9>());
    this.dictionary_0[Class15.smethod_0(39)].Add(new GClass8.GClass9(Class15.smethod_0(40) + GClass20.smethod_1().cgender, Class15.smethod_0(31), Class15.smethod_0(0)));
    int[] numArray = this.method_19(mapId);
    if ((numArray == null ? 0 : 1) == 0)
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(30964), Class15.smethod_0(0));
    }
    else
    {
      if ((!this.bool_3 ? 1 : 0) == 0)
      {
        if ((!this.bool_4 ? 0 : 1) == 0 && numArray.Length > Class15.smethod_0(5))
        {
          for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
          {
            GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
            if ((gclass80 == null ? 1 : 0) == 0 && ((int) gclass80.template.id == Class15.smethod_0(41) || (int) gclass80.template.id == Class15.smethod_0(42) && gclass80.quantity > Class15.smethod_0(31)))
            {
              this.bool_4 = Class15.smethod_0(1) != 0;
              this.bool_5 = Class15.smethod_0(0) != 0;
              this.long_0 = GClass126.smethod_18();
              GClass62.gclass141_0.mapNames = (string[]) null;
              GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) -1, gclass80.template.id);
              return;
            }
          }
        }
        if ((!this.bool_4 ? 1 : 0) == 0 && (!this.bool_5 ? 0 : 1) == 0 && ((GClass62.gclass141_0.mapNames == null ? 1 : 0) != 0 || GClass126.smethod_18() - this.long_0 < (long) Class15.smethod_0(16)))
          return;
        if ((!this.bool_4 ? 1 : 0) == 0 && (!this.bool_5 ? 0 : 1) == 0)
        {
          for (int index = numArray.Length - Class15.smethod_0(1); index >= Class15.smethod_0(7); index -= Class15.smethod_0(1))
          {
            for (int selected = Class15.smethod_0(0); selected < GClass62.gclass141_0.mapNames.Length; selected += Class15.smethod_0(1))
            {
              if ((!GClass62.gclass141_0.mapNames[selected].Contains(GClass185.string_2[numArray[index]]) ? 1 : 0) == 0)
              {
                this.bool_5 = Class15.smethod_0(1) != 0;
                GClass156.smethod_0().method_126(selected);
                return;
              }
            }
          }
          this.bool_5 = Class15.smethod_0(1) != 0;
        }
      }
      if (GClass185.int_37 != numArray[Class15.smethod_0(0)] || (!GClass20.bool_2 ? 0 : 1) != 0 || (!GClass32.bool_5 ? 0 : 1) != 0)
        return;
      this.method_18(numArray[Class15.smethod_0(1)]);
    }
  }

  public void method_7() => this.method_31(Class15.smethod_0(0));

  public void method_8() => this.method_31(Class15.smethod_0(7));

  public void method_9() => this.method_31(Class15.smethod_0(1));

  private void method_10()
  {
    this.bool_6 = GClass152.smethod_8(Class13.smethod_0(31700)) == Class15.smethod_0(1);
    if ((!this.bool_6 ? 1 : 0) != 0)
      return;
    this.bool_1 = GClass152.smethod_8(Class13.smethod_0(31274)) != -1 ? GClass152.smethod_8(Class13.smethod_0(31274)) == Class15.smethod_0(1) : Class15.smethod_0(1) != 0;
    this.bool_3 = GClass152.smethod_8(Class13.smethod_0(31382)) != -1 ? GClass152.smethod_8(Class13.smethod_0(31382)) == Class15.smethod_0(1) : Class15.smethod_0(1) != 0;
    this.bool_2 = GClass152.smethod_8(Class13.smethod_0(31883)) == Class15.smethod_0(1);
  }

  private void method_11()
  {
    GClass152.smethod_9(Class13.smethod_0(32527), (!this.bool_1 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(32630), (!this.bool_2 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(32421), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
  }

  private void method_12()
  {
    int[] numArray1 = new int[Class15.smethod_0(7)];
    numArray1[Class15.smethod_0(1)] = Class15.smethod_0(27);
    this.method_15(numArray1);
    int[] numArray2 = new int[Class15.smethod_0(7)];
    numArray2[Class15.smethod_0(0)] = Class15.smethod_0(1);
    numArray2[Class15.smethod_0(1)] = Class15.smethod_0(43);
    this.method_15(numArray2);
    int[] numArray3 = new int[Class15.smethod_0(7)];
    numArray3[Class15.smethod_0(0)] = Class15.smethod_0(43);
    numArray3[Class15.smethod_0(1)] = Class15.smethod_0(44);
    this.method_15(numArray3);
    int[] numArray4 = new int[Class15.smethod_0(7)];
    numArray4[Class15.smethod_0(0)] = Class15.smethod_0(7);
    numArray4[Class15.smethod_0(1)] = Class15.smethod_0(40);
    this.method_15(numArray4);
    int[] numArray5 = new int[Class15.smethod_0(7)];
    numArray5[Class15.smethod_0(0)] = Class15.smethod_0(3);
    numArray5[Class15.smethod_0(1)] = Class15.smethod_0(36);
    this.method_15(numArray5);
    int[] numArray6 = new int[Class15.smethod_0(7)];
    numArray6[Class15.smethod_0(0)] = Class15.smethod_0(38);
    numArray6[Class15.smethod_0(1)] = Class15.smethod_0(28);
    this.method_15(numArray6);
    int[] numArray7 = new int[Class15.smethod_0(7)];
    numArray7[Class15.smethod_0(0)] = Class15.smethod_0(45);
    numArray7[Class15.smethod_0(1)] = Class15.smethod_0(46);
    this.method_15(numArray7);
    int[] numArray8 = new int[Class15.smethod_0(7)];
    numArray8[Class15.smethod_0(0)] = Class15.smethod_0(47);
    numArray8[Class15.smethod_0(1)] = Class15.smethod_0(48);
    this.method_15(numArray8);
    int[] numArray9 = new int[Class15.smethod_0(7)];
    numArray9[Class15.smethod_0(0)] = Class15.smethod_0(49);
    numArray9[Class15.smethod_0(1)] = Class15.smethod_0(29);
    this.method_15(numArray9);
    int[] numArray10 = new int[Class15.smethod_0(7)];
    numArray10[Class15.smethod_0(0)] = Class15.smethod_0(10);
    numArray10[Class15.smethod_0(1)] = Class15.smethod_0(50);
    this.method_15(numArray10);
    int[] numArray11 = new int[Class15.smethod_0(7)];
    numArray11[Class15.smethod_0(0)] = Class15.smethod_0(51);
    numArray11[Class15.smethod_0(1)] = Class15.smethod_0(52);
    this.method_15(numArray11);
    int[] numArray12 = new int[Class15.smethod_0(7)];
    numArray12[Class15.smethod_0(0)] = Class15.smethod_0(53);
    numArray12[Class15.smethod_0(1)] = Class15.smethod_0(27);
    this.method_15(numArray12);
    int[] numArray13 = new int[Class15.smethod_0(7)];
    numArray13[Class15.smethod_0(0)] = Class15.smethod_0(54);
    numArray13[Class15.smethod_0(1)] = Class15.smethod_0(28);
    this.method_15(numArray13);
    int[] numArray14 = new int[Class15.smethod_0(7)];
    numArray14[Class15.smethod_0(0)] = Class15.smethod_0(55);
    numArray14[Class15.smethod_0(1)] = Class15.smethod_0(29);
    this.method_15(numArray14);
    int[] numArray15 = new int[Class15.smethod_0(7)];
    numArray15[Class15.smethod_0(0)] = Class15.smethod_0(56);
    numArray15[Class15.smethod_0(1)] = Class15.smethod_0(57);
    this.method_15(numArray15);
    int[] numArray16 = new int[Class15.smethod_0(7)];
    numArray16[Class15.smethod_0(0)] = Class15.smethod_0(56);
    numArray16[Class15.smethod_0(1)] = Class15.smethod_0(58);
    this.method_15(numArray16);
    int[] numArray17 = new int[Class15.smethod_0(7)];
    numArray17[Class15.smethod_0(0)] = Class15.smethod_0(58);
    numArray17[Class15.smethod_0(1)] = Class15.smethod_0(12);
    this.method_15(numArray17);
    int[] numArray18 = new int[Class15.smethod_0(7)];
    numArray18[Class15.smethod_0(0)] = Class15.smethod_0(59);
    numArray18[Class15.smethod_0(1)] = Class15.smethod_0(57);
    this.method_15(numArray18);
    int[] numArray19 = new int[Class15.smethod_0(7)];
    numArray19[Class15.smethod_0(0)] = Class15.smethod_0(25);
    numArray19[Class15.smethod_0(1)] = Class15.smethod_0(57);
    this.method_15(numArray19);
    byte[] byte_0_1 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.jwfTzKBGaVwf));
    this.method_15((int[]) Class15.smethod_4(byte_0_1));
    byte[] byte_0_2 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.PjOMMTIiBoIF));
    this.method_15((int[]) Class15.smethod_4(byte_0_2));
    byte[] byte_0_3 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_3, __fieldref (Class12.FKDxQkSfJFFl));
    this.method_15((int[]) Class15.smethod_4(byte_0_3));
    byte[] byte_0_4 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_4, __fieldref (Class12.OAEXjnosCpYP));
    this.method_15((int[]) Class15.smethod_4(byte_0_4));
    byte[] byte_0_5 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_5, __fieldref (Class12.PmwVISmUeejv));
    this.method_15((int[]) Class15.smethod_4(byte_0_5));
    byte[] byte_0_6 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_6, __fieldref (Class12.ziLkxTmIySFt));
    this.method_15((int[]) Class15.smethod_4(byte_0_6));
    byte[] byte_0_7 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_7, __fieldref (Class12.TbEIKibCyexh));
    this.method_15((int[]) Class15.smethod_4(byte_0_7));
    byte[] byte_0_8 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_8, __fieldref (Class12.qnqpUIVtJGPy));
    this.method_15((int[]) Class15.smethod_4(byte_0_8));
    byte[] byte_0_9 = new byte[Class15.smethod_0(63)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_9, __fieldref (Class12.voPgpeKyZZsB));
    this.method_15((int[]) Class15.smethod_4(byte_0_9));
    byte[] byte_0_10 = new byte[Class15.smethod_0(61)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_10, __fieldref (Class12.CGBtGUuNVfEd));
    this.method_15((int[]) Class15.smethod_4(byte_0_10));
    byte[] byte_0_11 = new byte[Class15.smethod_0(64)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_11, __fieldref (Class12.bJAzkVvaGHIO));
    this.method_15((int[]) Class15.smethod_4(byte_0_11));
    byte[] byte_0_12 = new byte[Class15.smethod_0(25)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_12, __fieldref (Class12.MOMITAkEijHa));
    this.method_15((int[]) Class15.smethod_4(byte_0_12));
  }

  private void method_13()
  {
    this.method_16(Class15.smethod_0(65), Class15.smethod_0(11), Class15.smethod_0(66), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(65), Class15.smethod_0(56), Class15.smethod_0(66), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(40), Class15.smethod_0(46), Class15.smethod_0(31), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(40), Class15.smethod_0(50), Class15.smethod_0(31), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(40), Class15.smethod_0(39), Class15.smethod_0(31), Class15.smethod_0(7));
    this.method_16(Class15.smethod_0(46), Class15.smethod_0(40), Class15.smethod_0(67), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(46), Class15.smethod_0(50), Class15.smethod_0(67), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(46), Class15.smethod_0(39), Class15.smethod_0(67), Class15.smethod_0(7));
    this.method_16(Class15.smethod_0(50), Class15.smethod_0(40), Class15.smethod_0(66), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(50), Class15.smethod_0(46), Class15.smethod_0(66), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(50), Class15.smethod_0(39), Class15.smethod_0(66), Class15.smethod_0(7));
    this.method_16(Class15.smethod_0(33), Class15.smethod_0(68), Class15.smethod_0(34), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(33), Class15.smethod_0(69), Class15.smethod_0(46), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(35), Class15.smethod_0(68), Class15.smethod_0(34), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(36), Class15.smethod_0(68), Class15.smethod_0(34), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(70), Class15.smethod_0(71), Class15.smethod_0(65), Class15.smethod_0(5));
    this.method_16(Class15.smethod_0(72), Class15.smethod_0(73), Class15.smethod_0(74), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(72), Class15.smethod_0(75), Class15.smethod_0(29), Class15.smethod_0(5));
    this.method_16(Class15.smethod_0(72), Class15.smethod_0(76), Class15.smethod_0(29), Class15.smethod_0(7));
    this.method_16(Class15.smethod_0(11), Class15.smethod_0(65), Class15.smethod_0(66), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(25), Class15.smethod_0(77), Class15.smethod_0(4), Class15.smethod_0(0));
    this.method_16(Class15.smethod_0(68), Class15.smethod_0(33), Class15.smethod_0(34), Class15.smethod_0(1));
    this.method_16(Class15.smethod_0(76), Class15.smethod_0(72), Class15.smethod_0(28), Class15.smethod_0(2));
    this.method_16(Class15.smethod_0(73), Class15.smethod_0(72), Class15.smethod_0(74), Class15.smethod_0(7));
    this.method_16(Class15.smethod_0(75), Class15.smethod_0(72), Class15.smethod_0(29), Class15.smethod_0(5));
    this.method_16(Class15.smethod_0(77), Class15.smethod_0(25), Class15.smethod_0(4), Class15.smethod_0(1));
    int int_10 = Class15.smethod_0(3);
    int int_11 = Class15.smethod_0(78);
    int int_12 = Class15.smethod_0(47);
    int int_13 = Class15.smethod_0(7);
    string[] strArray = new string[Class15.smethod_0(7)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(25011);
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(25083);
    this.method_17(int_10, int_11, int_12, int_13, strArray);
  }

  private void method_14()
  {
    this.dictionary_1.Add(Class13.smethod_0(24592), this.int_6);
    this.dictionary_1.Add(Class13.smethod_0(24577), this.int_4);
    this.dictionary_1.Add(Class13.smethod_0(24675), this.int_5);
    this.dictionary_1.Add(Class13.smethod_0(24669), this.int_9);
    this.dictionary_1.Add(Class13.smethod_0(24664), this.int_7);
    this.dictionary_1.Add(Class13.smethod_0(24652), this.int_8);
  }

  private void method_15(params int[] int_10)
  {
    for (int index = Class15.smethod_0(0); index < int_10.Length; index += Class15.smethod_0(1))
    {
      if ((!this.dictionary_0.ContainsKey(int_10[index]) ? 0 : 1) == 0)
        this.dictionary_0.Add(int_10[index], new List<GClass8.GClass9>());
      if ((index == 0 ? 1 : 0) == 0)
        this.dictionary_0[int_10[index]].Add(new GClass8.GClass9(int_10[index - Class15.smethod_0(1)], -1, -1));
      if (index != int_10.Length - Class15.smethod_0(1))
        this.dictionary_0[int_10[index]].Add(new GClass8.GClass9(int_10[index + Class15.smethod_0(1)], -1, -1));
    }
  }

  private void method_16(int int_10, int int_11, int int_12, int int_13)
  {
    if ((!this.dictionary_0.ContainsKey(int_10) ? 0 : 1) == 0)
      this.dictionary_0.Add(int_10, new List<GClass8.GClass9>());
    this.dictionary_0[int_10].Add(new GClass8.GClass9(int_11, int_12, int_13));
  }

  private void method_17(
    int int_10,
    int int_11,
    int int_12,
    int int_13,
    params string[] string_0)
  {
  }

  private void method_18(int int_10)
  {
    using (List<GClass8.GClass9>.Enumerator enumerator = this.dictionary_0[GClass185.int_37].GetEnumerator())
    {
      while ((!enumerator.MoveNext() ? 0 : 1) != 0)
      {
        GClass8.GClass9 current = enumerator.Current;
        if (current.mapId == int_10)
        {
          current.method_0();
          return;
        }
      }
    }
    GClass116.gclass73_0.method_7(Class13.smethod_0(24647), Class15.smethod_0(0));
  }

  private int[] method_19(int int_10)
  {
    int int_10_1 = int_10;
    int[] int_11 = new int[Class15.smethod_0(1)];
    int_11[Class15.smethod_0(0)] = GClass185.int_37;
    return this.method_20(int_10_1, int_11);
  }

  private int[] method_20(int int_10, int[] int_11)
  {
    List<int[]> numArrayList = new List<int[]>();
    List<int> collection = new List<int>();
    collection.AddRange((IEnumerable<int>) int_11);
    using (List<GClass8.GClass9>.Enumerator enumerator = this.dictionary_0[int_11[int_11.Length - Class15.smethod_0(1)]].GetEnumerator())
    {
      while ((!enumerator.MoveNext() ? 0 : 1) != 0)
      {
        GClass8.GClass9 current = enumerator.Current;
        if (int_10 != current.mapId)
        {
          if ((!collection.Contains(current.mapId) ? 0 : 1) == 0)
          {
            List<int> intList = new List<int>((IEnumerable<int>) collection)
            {
              current.mapId
            };
            int[] numArray = this.method_20(int_10, intList.ToArray());
            if ((numArray == null ? 1 : 0) == 0)
              numArrayList.Add(numArray);
          }
        }
        else
        {
          collection.Add(int_10);
          return collection.ToArray();
        }
      }
    }
    int num = Class15.smethod_0(79);
    int[] numArray1 = (int[]) null;
    using (List<int[]>.Enumerator enumerator = numArrayList.GetEnumerator())
    {
      while ((!enumerator.MoveNext() ? 0 : 1) != 0)
      {
        int[] current = enumerator.Current;
        if ((!this.method_21(current) ? 0 : 1) == 0 && ((int) GClass20.smethod_1().taskMaint.taskId > Class15.smethod_0(6) || (!this.method_22(current) ? 0 : 1) == 0) && current.Length < num)
        {
          num = current.Length;
          numArray1 = current;
        }
      }
    }
    return numArray1;
  }

  private bool method_21(int[] int_10)
  {
    for (int index = Class15.smethod_0(1); index < int_10.Length - Class15.smethod_0(1); index += Class15.smethod_0(1))
    {
      if (int_10[index] == Class15.smethod_0(68) && int_10[index + Class15.smethod_0(1)] == Class15.smethod_0(40) && (int_10[index - Class15.smethod_0(1)] == Class15.smethod_0(33) || int_10[index - Class15.smethod_0(1)] == Class15.smethod_0(35) || int_10[index - Class15.smethod_0(1)] == Class15.smethod_0(36)))
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  private bool method_22(int[] int_10)
  {
    for (int index = Class15.smethod_0(0); index < int_10.Length; index += Class15.smethod_0(1))
    {
      if (int_10[index] >= Class15.smethod_0(57) && int_10[index] <= Class15.smethod_0(80))
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  private string method_23(int int_10)
  {
    string str;
    if (int_10 != Class15.smethod_0(76))
    {
      str = int_10 != Class15.smethod_0(75) ? GClass185.string_2[int_10] + Class13.smethod_0(24825) + int_10.ToString() + Class13.smethod_0(24714) : GClass185.string_2[int_10] + Class13.smethod_0(24736) + int_10.ToString() + Class13.smethod_0(24714);
    }
    else
    {
      object[] objArray = new object[Class15.smethod_0(5)];
      objArray[Class15.smethod_0(0)] = (object) Class13.smethod_0(24712);
      objArray[Class15.smethod_0(1)] = (object) int_10;
      objArray[Class15.smethod_0(7)] = (object) Class13.smethod_0(24714);
      str = string.Concat(objArray);
    }
    return str;
  }

  private void method_24()
  {
    this.method_27();
    int num = GClass185.gclass134_0.method_2();
    if (num != Class15.smethod_0(7))
    {
      for (int index = Class15.smethod_0(0); index < num; index += Class15.smethod_0(1))
      {
        GClass190 gclass190 = (GClass190) GClass185.gclass134_0.method_3(index);
        if ((int) gclass190.maxX < Class15.smethod_0(4))
        {
          this.int_1[Class15.smethod_0(0)] = (int) gclass190.minX + Class15.smethod_0(9);
          this.int_1[Class15.smethod_0(1)] = (int) gclass190.maxY;
        }
        else if ((int) gclass190.maxX > GClass185.int_23 - Class15.smethod_0(4))
        {
          this.int_3[Class15.smethod_0(0)] = (int) gclass190.maxX - Class15.smethod_0(9);
          this.int_3[Class15.smethod_0(1)] = (int) gclass190.maxY;
        }
        else
        {
          this.int_2[Class15.smethod_0(0)] = (int) gclass190.minX + Class15.smethod_0(9);
          this.int_2[Class15.smethod_0(1)] = (int) gclass190.maxY;
        }
      }
    }
    else
    {
      GClass190 gclass190_1 = (GClass190) GClass185.gclass134_0.method_3(Class15.smethod_0(0));
      GClass190 gclass190_2 = (GClass190) GClass185.gclass134_0.method_3(Class15.smethod_0(1));
      if ((int) gclass190_1.maxX < Class15.smethod_0(4) && (int) gclass190_2.maxX < Class15.smethod_0(4) || (int) gclass190_1.minX > GClass185.int_23 - Class15.smethod_0(4) && (int) gclass190_2.minX > GClass185.int_23 - Class15.smethod_0(4))
      {
        this.int_1[Class15.smethod_0(0)] = (int) gclass190_1.minX + Class15.smethod_0(9);
        this.int_1[Class15.smethod_0(1)] = (int) gclass190_1.maxY;
        this.int_3[Class15.smethod_0(0)] = (int) gclass190_2.maxX - Class15.smethod_0(9);
        this.int_3[Class15.smethod_0(1)] = (int) gclass190_2.maxY;
      }
      else if ((int) gclass190_1.maxX < (int) gclass190_2.maxX)
      {
        this.int_1[Class15.smethod_0(0)] = (int) gclass190_1.minX + Class15.smethod_0(9);
        this.int_1[Class15.smethod_0(1)] = (int) gclass190_1.maxY;
        this.int_3[Class15.smethod_0(0)] = (int) gclass190_2.maxX - Class15.smethod_0(9);
        this.int_3[Class15.smethod_0(1)] = (int) gclass190_2.maxY;
      }
      else
      {
        this.int_1[Class15.smethod_0(0)] = (int) gclass190_2.minX + Class15.smethod_0(9);
        this.int_1[Class15.smethod_0(1)] = (int) gclass190_2.maxY;
        this.int_3[Class15.smethod_0(0)] = (int) gclass190_1.maxX - Class15.smethod_0(9);
        this.int_3[Class15.smethod_0(1)] = (int) gclass190_1.maxY;
      }
    }
  }

  private int method_25(int int_10)
  {
    int py = Class15.smethod_0(32);
    int num = Class15.smethod_0(0);
    while (num < Class15.smethod_0(6))
    {
      num += Class15.smethod_0(1);
      py += Class15.smethod_0(40);
      if ((!GClass185.smethod_27(int_10, py, Class15.smethod_0(7)) ? 1 : 0) == 0)
      {
        if ((py % Class15.smethod_0(40) == 0 ? 1 : 0) == 0)
        {
          py -= py % Class15.smethod_0(40);
          break;
        }
        break;
      }
    }
    return py;
  }

  private void method_26(int int_10, int int_11)
  {
    if ((!GClass116.bool_55 ? 1 : 0) == 0)
    {
      GClass20.smethod_1().cx = int_10;
      GClass20.smethod_1().cy = int_11;
      GClass156.smethod_0().method_45();
    }
    else
    {
      GClass20.smethod_1().cx = int_10;
      GClass20.smethod_1().cy = int_11;
      GClass156.smethod_0().method_45();
      GClass20.smethod_1().cx = int_10;
      GClass20.smethod_1().cy = int_11 + Class15.smethod_0(1);
      GClass156.smethod_0().method_45();
      GClass20.smethod_1().cx = int_10;
      GClass20.smethod_1().cy = int_11;
      GClass156.smethod_0().method_45();
    }
  }

  private void method_27()
  {
    this.int_1 = new int[Class15.smethod_0(7)];
    this.int_2 = new int[Class15.smethod_0(7)];
    this.int_3 = new int[Class15.smethod_0(7)];
  }

  private bool method_28(int int_10) => int_10 >= Class15.smethod_0(81) ? (int_10 > Class15.smethod_0(82) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  private bool method_29(int int_10)
  {
    for (int index = Class15.smethod_0(0); index < this.int_7.Length; index += Class15.smethod_0(1))
    {
      if (this.int_7[index] == int_10)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  private bool method_30(GClass81 gclass81_0) => (int) gclass81_0.template.id >= Class15.smethod_0(83) ? ((int) gclass81_0.template.id > Class15.smethod_0(84) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  private void method_31(int int_10)
  {
    if ((!this.method_28(GClass185.int_37) ? 1 : 0) == 0)
    {
      this.method_32(int_10);
    }
    else
    {
      this.method_24();
      switch (int_10)
      {
        case 0:
          if ((this.int_1[Class15.smethod_0(0)] == 0 ? 1 : 0) == 0 && (this.int_1[Class15.smethod_0(1)] == 0 ? 1 : 0) == 0)
          {
            this.method_26(this.int_1[Class15.smethod_0(0)], this.int_1[Class15.smethod_0(1)]);
            break;
          }
          this.method_26(Class15.smethod_0(4), this.method_25(Class15.smethod_0(4)));
          break;
        case 1:
          if ((this.int_3[Class15.smethod_0(0)] == 0 ? 1 : 0) == 0 && (this.int_3[Class15.smethod_0(1)] == 0 ? 1 : 0) == 0)
          {
            this.method_26(this.int_3[Class15.smethod_0(0)], this.int_3[Class15.smethod_0(1)]);
            break;
          }
          this.method_26(GClass185.int_23 - Class15.smethod_0(4), this.method_25(GClass185.int_23 - Class15.smethod_0(4)));
          break;
        case 2:
          if ((this.int_2[Class15.smethod_0(0)] == 0 ? 1 : 0) == 0 && (this.int_2[Class15.smethod_0(1)] == 0 ? 1 : 0) == 0)
          {
            this.method_26(this.int_2[Class15.smethod_0(0)], this.int_2[Class15.smethod_0(1)]);
            break;
          }
          this.method_26(GClass185.int_23 / Class15.smethod_0(7), this.method_25(GClass185.int_23 / Class15.smethod_0(7)));
          break;
      }
      if (GClass185.int_37 != Class15.smethod_0(38) && GClass185.int_37 != Class15.smethod_0(49) && (GClass185.int_37 == 0 ? 0 : 1) != 0)
        GClass156.smethod_0().method_41();
      else
        GClass156.smethod_0().method_115();
    }
  }

  private void method_32(int int_10)
  {
    if ((int_10 == 0 ? 1 : 0) == 0)
    {
      if (int_10 != Class15.smethod_0(7))
      {
        this.method_26(GClass185.int_23 - Class15.smethod_0(4), this.method_25(GClass185.int_23 - Class15.smethod_0(4)));
      }
      else
      {
        if (GClass20.smethod_1().bag >= Class15.smethod_0(0) && (!GClass26.gclass128_0.method_7((object) GClass20.smethod_1().bag.ToString()) ? 1 : 0) == 0)
        {
          GClass26 gclass26 = (GClass26) GClass26.gclass128_0.method_0((object) GClass20.smethod_1().bag.ToString());
          if ((gclass26.idImage == null ? 1 : 0) == 0)
          {
            for (int index1 = Class15.smethod_0(0); index1 < gclass26.idImage.Length; index1 += Class15.smethod_0(1))
            {
              if ((int) gclass26.idImage[index1] == Class15.smethod_0(85))
              {
                for (int index2 = Class15.smethod_0(0); index2 < GClass116.gclass134_10.method_2(); index2 += Class15.smethod_0(1))
                {
                  GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index2);
                  if (gclass21.template.npcTemplateId >= Class15.smethod_0(6) && gclass21.template.npcTemplateId <= Class15.smethod_0(86))
                  {
                    GClass20.smethod_1().npcFocus = gclass21;
                    this.method_26(gclass21.cx, gclass21.cy - Class15.smethod_0(5));
                    return;
                  }
                }
              }
            }
          }
        }
        for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
        {
          GClass81 gclass81_0 = (GClass81) GClass116.gclass134_6.method_3(index);
          if ((gclass81_0 == null ? 1 : 0) == 0 && (!this.method_30(gclass81_0) ? 1 : 0) == 0)
          {
            GClass20.smethod_1().itemFocus = gclass81_0;
            this.method_26(gclass81_0.x, gclass81_0.y);
            break;
          }
        }
      }
    }
    else
      this.method_26(Class15.smethod_0(4), this.method_25(Class15.smethod_0(4)));
  }

  public bool method_33() => this.bool_0;

  public class GClass9
  {
    public int mapId;
    private int int_0;
    private int int_1;
    private List<string> list_0;
    private int int_2;
    private int int_3;
    private long long_0;

    public GClass9(int mapID, int npc, int index)
    {
      this.mapId = mapID;
      this.int_0 = npc;
      this.int_1 = index;
    }

    public void method_0()
    {
      if ((GClass62.gclass113_0 == null ? 1 : 0) == 0 && (!GClass62.gclass113_0.Equals((object) GClass123.smethod_2()) ? 1 : 0) == 0)
        return;
      if (this.int_1 == -1 && this.int_0 == -1)
      {
        GClass190 waypoint = this.method_1();
        if ((waypoint == null ? 1 : 0) != 0)
          return;
        this.method_3(waypoint);
      }
      else
      {
        if (this.int_0 == -1)
          return;
        if (this.int_1 != -1)
        {
          GClass156.smethod_0().method_61(this.int_0);
          GClass156.smethod_0().method_60((short) Class15.smethod_0(0), (sbyte) this.int_1);
        }
        else
        {
          if ((this.list_0 == null ? 1 : 0) != 0 || this.list_0.Count <= Class15.smethod_0(0))
            return;
          long num = GClass126.smethod_18();
          if ((this.int_3 == 0 ? 0 : 1) == 0 && (!GClass62.gclass95_0.showMenu ? 0 : 1) == 0)
          {
            this.int_3 += Class15.smethod_0(1);
            this.long_0 = num;
            GClass156.smethod_0().method_61(this.int_0);
          }
          else
          {
            if (num - this.long_0 <= (long) Class15.smethod_0(15))
              return;
            this.long_0 = num;
            if (this.int_3 > this.int_2)
            {
              this.int_3 = Class15.smethod_0(0);
            }
            else
            {
              this.int_3 += Class15.smethod_0(1);
              for (int index = Class15.smethod_0(0); index < GClass62.gclass95_0.menuItems.method_2(); index += Class15.smethod_0(1))
              {
                if ((!this.list_0.Contains(((GClass31) GClass62.gclass95_0.menuItems.method_3(index)).caption.Trim().ToLower().Replace(Class13.smethod_0(29175), Class13.smethod_0(30671)).Replace(Class13.smethod_0(30270), Class13.smethod_0(30671))) ? 1 : 0) == 0)
                {
                  GClass156.smethod_0().method_60((short) this.int_0, (sbyte) index);
                  break;
                }
              }
            }
          }
        }
      }
    }

    public GClass190 method_1()
    {
      for (int index = Class15.smethod_0(0); index < GClass185.gclass134_0.method_2(); index += Class15.smethod_0(1))
      {
        GClass190 gclass190 = (GClass190) GClass185.gclass134_0.method_3(index);
        if ((!this.method_2().Equals(this.method_4(gclass190.popup)) ? 1 : 0) == 0)
          return gclass190;
      }
      return (GClass190) null;
    }

    public string method_2() => GClass185.string_2[this.mapId];

    public void method_3(GClass190 waypoint)
    {
      int x = (int) waypoint.maxX < Class15.smethod_0(4) ? Class15.smethod_0(9) : ((int) waypoint.minX <= GClass185.int_23 - Class15.smethod_0(4) ? ((int) waypoint.minX + (int) waypoint.maxX) / Class15.smethod_0(7) : GClass185.int_23 - Class15.smethod_0(9));
      int maxY = (int) waypoint.maxY;
      if (x != -1 && maxY != -1)
      {
        this.method_5(x, maxY);
        if ((!waypoint.isOffline ? 1 : 0) == 0)
          GClass156.smethod_0().method_115();
        else
          GClass156.smethod_0().method_41();
      }
      else
        GClass116.gclass73_0.method_7(Class13.smethod_0(30298), Class15.smethod_0(0));
    }

    public string method_4(GClass148 popUp)
    {
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = Class15.smethod_0(0); index < popUp.says.Length; index += Class15.smethod_0(1))
      {
        stringBuilder.Append(popUp.says[index]);
        stringBuilder.Append(Class13.smethod_0(30392));
      }
      return stringBuilder.ToString().Trim();
    }

    public void method_5(int x, int y)
    {
      if ((!GClass116.bool_55 ? 1 : 0) == 0)
      {
        GClass20.smethod_1().cx = x;
        GClass20.smethod_1().cy = y;
        GClass156.smethod_0().method_45();
      }
      else
      {
        GClass20.smethod_1().cx = x;
        GClass20.smethod_1().cy = y;
        GClass156.smethod_0().method_45();
        GClass20.smethod_1().cx = x;
        GClass20.smethod_1().cy = y + Class15.smethod_0(1);
        GClass156.smethod_0().method_45();
        GClass20.smethod_1().cx = x;
        GClass20.smethod_1().cy = y;
        GClass156.smethod_0().method_45();
      }
    }
  }
}
