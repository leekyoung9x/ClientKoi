// Decompiled with JetBrains decompiler
// Type: GClass13
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;

public class GClass13 : GInterface0, GInterface1
{
  public static GClass13 gclass13_0 = new GClass13();
  private GClass23 gclass23_0;
  private List<GClass24> list_0;
  private bool bool_0;
  private string string_0;
  private bool bool_1;
  private bool bool_2;
  private List<GClass20> list_1;
  private int int_0;
  private int int_1;
  private List<Color> list_2;
  private Dictionary<string, string> dictionary_0;
  private List<string> list_3;
  private bool bool_3;
  private int int_2;
  private int int_3;
  private int int_4;
  private bool bool_4;
  private bool bool_5;
  private string[] string_1;
  private bool bool_6;
  private bool bool_7;
  private int int_5;
  private string[] string_2;
  private GClass66 gclass66_0;
  private GClass66 gclass66_1;
  private List<GClass66> list_4;
  private long long_0;
  private int int_6;
  private string string_3;
  private string string_4;
  private bool bool_8;
  private long long_1;
  private bool bool_9;
  private string string_5;
  private string string_6;
  private int int_7;

  public GClass13()
  {
    this.string_4 = Class13.smethod_0(29033);
    this.string_3 = Class13.smethod_0(30630);
    this.gclass23_0 = new GClass23();
    this.gclass23_0.tfChat.y = GClass62.int_11 - Class15.smethod_0(95) - this.gclass23_0.tfChat.height;
    this.gclass23_0.method_0();
    this.list_0 = new List<GClass24>();
    this.list_1 = new List<GClass20>();
    this.list_4 = new List<GClass66>();
    this.int_0 = Class15.smethod_0(98);
    this.int_1 = Class15.smethod_0(38);
    this.int_2 = Class15.smethod_0(88);
    this.string_5 = string.Empty;
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(30450);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(31487);
    this.string_2 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(38)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(32104);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(32089);
    strArray2[Class15.smethod_0(7)] = Class13.smethod_0(32070);
    strArray2[Class15.smethod_0(5)] = Class13.smethod_0(32151);
    strArray2[Class15.smethod_0(2)] = Class13.smethod_0(31778);
    strArray2[Class15.smethod_0(3)] = Class13.smethod_0(31759);
    strArray2[Class15.smethod_0(37)] = Class13.smethod_0(31870);
    this.string_1 = strArray2;
    this.list_2 = new List<Color>();
    this.list_2.Add(Color.black);
    this.list_2.Add(new Color(Class15.smethod_2(0), Class15.smethod_2(1), Class15.smethod_2(1)));
    this.list_2.Add(Color.red);
    this.list_2.Add(new Color(Class15.smethod_2(2), Class15.smethod_2(0), Class15.smethod_2(2)));
    this.list_2.Add(Color.yellow);
    this.list_2.Add(Color.green);
    this.list_2.Add(new Color(Class15.smethod_2(1), Class15.smethod_2(3), Class15.smethod_2(4)));
    this.list_2.Add(new Color(Class15.smethod_2(5), Class15.smethod_2(6), Class15.smethod_2(0)));
    this.list_2.Add(Color.black);
    this.list_2.Add(Color.blue);
    this.list_2.Add(Color.red);
    this.list_2.Add(Color.blue);
    this.list_2.Add(Color.white);
    this.list_2.Add(Color.black);
    this.list_3 = new List<string>();
    this.list_3.Add(Class13.smethod_0(31852));
    this.list_3.Add(Class13.smethod_0(31950));
    this.list_3.Add(Class13.smethod_0(31939));
    this.list_3.Add(Class13.smethod_0(32569));
    this.list_3.Add(Class13.smethod_0(32559));
    this.list_3.Add(Class13.smethod_0(32548));
    this.list_3.Add(Class13.smethod_0(32538));
    this.list_3.Add(Class13.smethod_0(32635));
    this.dictionary_0 = new Dictionary<string, string>();
    this.dictionary_0.Add(Class13.smethod_0(32609), Class13.smethod_0(32696));
    this.dictionary_0.Add(Class13.smethod_0(32677), Class13.smethod_0(32648));
    this.dictionary_0.Add(Class13.smethod_0(32752), Class13.smethod_0(32729));
    this.dictionary_0.Add(Class13.smethod_0(32288), Class13.smethod_0(32265));
    this.dictionary_0.Add(Class13.smethod_0(32349), Class13.smethod_0(32334));
    this.dictionary_0.Add(Class13.smethod_0(32405), Class13.smethod_0(30630));
    this.dictionary_0.Add(Class13.smethod_0(32498), Class13.smethod_0(32477));
    this.dictionary_0.Add(Class13.smethod_0(24868), Class13.smethod_0(24838));
    this.dictionary_0.Add(Class13.smethod_0(24941), Class13.smethod_0(24908));
    this.dictionary_0.Add(Class13.smethod_0(24997), Class13.smethod_0(25884));
  }

  public void method_0()
  {
    GClass12.gclass12_0.method_0();
    GClass8.gclass8_0.method_0();
    GClass4.gclass4_0.method_0();
    GClass5.gclass5_0.method_0();
    GClass10.gclass10_0.method_0();
    GClass14.gclass14_0.method_0();
    GClass11.gclass11_0.method_0();
    GClass15.gclass15_0.method_0();
    if (((!GClass105.bool_2 ? 1 : 0) != 0 || (!GClass105.bool_0 ? 0 : 1) == 0) && (GClass116.smethod_6().mobCapcha == null ? 1 : 0) == 0 && (!this.bool_1 ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
      new Thread((ThreadStart) (() => this.method_14()))
      {
        IsBackground = (Class15.smethod_0(1) != 0)
      }.Start();
    if ((!this.bool_2 ? 1 : 0) == 0)
    {
      this.list_1.Clear();
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
      {
        GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
        if ((gclass20.cName == null ? 1 : 0) == 0 && (!(gclass20.cName != "") ? 1 : 0) == 0 && (!gclass20.isPet ? 0 : 1) == 0 && (!gclass20.isMiniPet ? 0 : 1) == 0 && (!gclass20.cName.StartsWith(Class13.smethod_0(26457)) ? 0 : 1) == 0 && (!gclass20.cName.StartsWith(Class13.smethod_0(26436)) ? 0 : 1) == 0 && (!(gclass20.cName != Class13.smethod_0(26535)) ? 1 : 0) == 0)
          this.list_1.Add(gclass20);
      }
      this.method_9();
    }
    if ((!this.bool_6 ? 1 : 0) == 0)
      this.method_23();
    if ((!this.bool_7 ? 1 : 0) == 0)
      this.method_18(this.int_5);
    if ((!this.bool_5 ? 1 : 0) == 0)
      this.method_25();
    if ((!this.bool_9 ? 1 : 0) == 0)
      this.method_27();
    GClass20.smethod_1().cspeed = this.int_2;
  }

  public void method_1(GClass98 g)
  {
    g.method_32(this.gclass66_1, GClass62.int_10 / Class15.smethod_0(7), Class15.smethod_0(51), Class15.smethod_0(5));
    GClass97 gclass9711 = GClass97.gclass97_11;
    GClass98 g1 = g;
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(26345);
    strArray[Class15.smethod_0(1)] = GClass185.string_2[GClass185.int_37];
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(26318);
    strArray[Class15.smethod_0(5)] = GClass185.int_39.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(27134);
    string st = string.Concat(strArray);
    int x = Class15.smethod_0(46);
    int y1 = GClass62.int_11 - Class15.smethod_0(99);
    int align = Class15.smethod_0(0);
    gclass9711.method_6(g1, st, x, y1, align);
    GClass97.gclass97_11.method_6(g, Class13.smethod_0(27972) + DateTime.Now.ToString(Class13.smethod_0(20958)), Class15.smethod_0(46), GClass62.int_11 - Class15.smethod_0(100), Class15.smethod_0(0));
    GClass97.gclass97_1.method_6(g, Class13.smethod_0(20532) + Main.main_0.max.ToString(), Class15.smethod_0(81), Class15.smethod_0(6), Class15.smethod_0(0));
    this.method_4(g);
    if ((!this.bool_2 ? 1 : 0) == 0)
      this.method_2(g);
    int y2 = GClass62.int_11 - Class15.smethod_0(90);
    if ((!this.bool_9 ? 1 : 0) == 0)
    {
      GClass97.gclass97_11.method_6(g, Class13.smethod_0(20526), Class15.smethod_0(46), y2, Class15.smethod_0(0));
      y2 += Class15.smethod_0(31);
    }
    if ((!GClass14.gclass14_0.method_26() ? 1 : 0) == 0)
    {
      GClass97.gclass97_11.method_6(g, Class13.smethod_0(20483), Class15.smethod_0(46), y2, Class15.smethod_0(0));
      y2 += Class15.smethod_0(31);
    }
    if ((!this.bool_6 ? 1 : 0) == 0)
    {
      GClass97.gclass97_11.method_6(g, Class13.smethod_0(20642), Class15.smethod_0(46), y2, Class15.smethod_0(0));
      y2 += Class15.smethod_0(31);
    }
    if ((!GClass11.gclass11_0.method_12() ? 1 : 0) == 0)
    {
      GClass97.gclass97_11.method_6(g, Class13.smethod_0(20627), Class15.smethod_0(46), y2, Class15.smethod_0(0));
      y2 += Class15.smethod_0(31);
    }
    if ((!this.bool_7 ? 1 : 0) == 0)
    {
      GClass97.gclass97_11.method_6(g, Class13.smethod_0(20611) + this.int_5.ToString(), Class15.smethod_0(46), y2, Class15.smethod_0(0));
      y2 += Class15.smethod_0(31);
    }
    if ((!this.bool_5 ? 1 : 0) != 0)
      return;
    GClass97.gclass97_11.method_6(g, Class13.smethod_0(20731) + this.int_3.ToString() + Class13.smethod_0(21843) + this.int_4.ToString(), Class15.smethod_0(46), y2, Class15.smethod_0(0));
    int num = y2 + Class15.smethod_0(31);
  }

  private void method_2(GClass98 gclass98_0)
  {
    int num1 = (!this.method_13() ? 0 : 1) != 0 ? Class15.smethod_0(95) : Class15.smethod_0(101);
    int num2 = Class15.smethod_0(1);
    for (int index = Class15.smethod_0(0); index < this.list_1.Count; index += Class15.smethod_0(1))
    {
      GClass20 gclass20_0 = this.list_1[index];
      gclass98_0.method_21(Class15.smethod_0(102), Class15.smethod_2(7));
      gclass98_0.method_15(GClass62.int_10 - this.int_0, num1 + Class15.smethod_0(7), this.int_0 - Class15.smethod_0(7), this.int_1);
      if ((gclass20_0.cName == null ? 1 : 0) == 0 && (!(gclass20_0.cName != "") ? 1 : 0) == 0 && (!gclass20_0.isPet ? 0 : 1) == 0 && (!gclass20_0.isMiniPet ? 0 : 1) == 0 && (!gclass20_0.cName.StartsWith(Class13.smethod_0(21530)) ? 0 : 1) == 0 && (!gclass20_0.cName.StartsWith(Class13.smethod_0(21506)) ? 0 : 1) == 0 && (!(gclass20_0.cName != Class13.smethod_0(21504)) ? 1 : 0) == 0)
      {
        if ((!gclass20_0.isNrd ? 1 : 0) == 0)
          this.method_3(gclass98_0, gclass20_0);
        object[] objArray1 = new object[Class15.smethod_0(2)];
        objArray1[Class15.smethod_0(0)] = (object) gclass20_0.cName;
        objArray1[Class15.smethod_0(1)] = (object) Class13.smethod_0(21577);
        objArray1[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) gclass20_0.cHP);
        objArray1[Class15.smethod_0(5)] = (object) Class13.smethod_0(21574);
        string str = string.Concat(objArray1);
        bool flag;
        if ((!(flag = this.method_19(gclass20_0)) ? 0 : 1) == 0)
        {
          object[] objArray2 = new object[Class15.smethod_0(37)];
          objArray2[Class15.smethod_0(0)] = (object) gclass20_0.cName;
          objArray2[Class15.smethod_0(1)] = (object) Class13.smethod_0(21577);
          objArray2[Class15.smethod_0(7)] = (object) GClass138.smethod_9((long) gclass20_0.cHP);
          objArray2[Class15.smethod_0(5)] = (object) Class13.smethod_0(21572);
          objArray2[Class15.smethod_0(2)] = (object) gclass20_0.method_154();
          objArray2[Class15.smethod_0(3)] = (object) Class13.smethod_0(21574);
          str = string.Concat(objArray2);
        }
        int num3;
        if ((GClass20.smethod_1().charFocus == null ? 1 : 0) == 0 && (!(GClass20.smethod_1().charFocus.cName == gclass20_0.cName) ? 1 : 0) == 0)
        {
          if ((!this.method_13() ? 0 : 1) == 0)
            this.method_3(gclass98_0, gclass20_0);
          gclass98_0.method_16(Class15.smethod_0(103));
          gclass98_0.method_11(GClass20.smethod_1().cx - GClass116.int_22, GClass20.smethod_1().cy - GClass116.int_23 + Class15.smethod_0(1), gclass20_0.cx - GClass116.int_22, gclass20_0.cy - GClass116.int_23);
          GClass97 gclass9743 = GClass97.gclass97_43;
          GClass98 g = gclass98_0;
          num3 = index + Class15.smethod_0(1);
          string st = num3.ToString() + Class13.smethod_0(21568) + str;
          int x = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
          int y = num1;
          int align = Class15.smethod_0(0);
          gclass9743.method_6(g, st, x, y, align);
        }
        else if ((!flag ? 1 : 0) == 0)
        {
          gclass98_0.method_16(Class15.smethod_0(104));
          gclass98_0.method_11(GClass20.smethod_1().cx - GClass116.int_22, GClass20.smethod_1().cy - GClass116.int_23 + Class15.smethod_0(1), gclass20_0.cx - GClass116.int_22, gclass20_0.cy - GClass116.int_23);
          GClass97 gclass9744 = GClass97.gclass97_44;
          GClass98 g = gclass98_0;
          num3 = index + Class15.smethod_0(1);
          string st = num3.ToString() + Class13.smethod_0(21568) + str;
          int x = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
          int y = num1;
          int align = Class15.smethod_0(0);
          gclass9744.method_6(g, st, x, y, align);
        }
        else
        {
          gclass98_0.method_18(Color.black, Class15.smethod_2(8));
          if (gclass20_0.cHPFull > Class15.smethod_0(105) && gclass20_0.cHP > Class15.smethod_0(0) && (!this.method_13() ? 1 : 0) == 0 && (!gclass20_0.isNrd ? 0 : 1) == 0)
          {
            GClass97 gclass9744 = GClass97.gclass97_44;
            GClass98 g = gclass98_0;
            num3 = index + Class15.smethod_0(1);
            string st = num3.ToString() + Class13.smethod_0(21568) + str;
            int x = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
            int y = num1;
            int align = Class15.smethod_0(0);
            gclass9744.method_6(g, st, x, y, align);
          }
          else
          {
            GClass97 gclass9742_1 = GClass97.gclass97_42;
            GClass98 g1 = gclass98_0;
            num3 = index + Class15.smethod_0(1);
            string st1 = num3.ToString() + Class13.smethod_0(21568) + str;
            int x1 = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
            int y1 = num1 + num2;
            int align1 = Class15.smethod_0(0);
            gclass9742_1.method_6(g1, st1, x1, y1, align1);
            if (GClass98.int_8 == Class15.smethod_0(7))
            {
              GClass97 gclass9742_2 = GClass97.gclass97_42;
              GClass98 g2 = gclass98_0;
              num3 = index + Class15.smethod_0(1);
              string st2 = num3.ToString() + Class13.smethod_0(21568) + str;
              int x2 = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
              int y2 = num1 + num2;
              int align2 = Class15.smethod_0(0);
              gclass9742_2.method_6(g2, st2, x2, y2, align2);
              GClass97 gclass9742_3 = GClass97.gclass97_42;
              GClass98 g3 = gclass98_0;
              num3 = index + Class15.smethod_0(1);
              string st3 = num3.ToString() + Class13.smethod_0(21568) + str;
              int x3 = GClass62.int_10 - this.int_0 + Class15.smethod_0(7);
              int y3 = num1 + num2;
              int align3 = Class15.smethod_0(0);
              gclass9742_3.method_6(g3, st3, x3, y3, align3);
            }
          }
        }
        if ((gclass20_0.cFlag == (sbyte) 0 ? 1 : 0) == 0 && gclass20_0.cFlag != (sbyte) -1 && (int) gclass20_0.cFlag < this.list_2.Count)
        {
          gclass98_0.method_18(this.list_2[(int) gclass20_0.cFlag], Class15.smethod_2(8));
          gclass98_0.method_15(GClass62.int_10 - this.int_0 - Class15.smethod_0(37), num1 + Class15.smethod_0(5), this.int_1 - Class15.smethod_0(7), this.int_1 - Class15.smethod_0(7));
        }
        num1 += this.int_1 + Class15.smethod_0(1);
      }
    }
  }

  private void method_3(GClass98 gclass98_0, GClass20 gclass20_0)
  {
    GClass97 gclass971 = GClass97.gclass97_1;
    GClass98 g = gclass98_0;
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = gclass20_0.cName;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(121198);
    strArray[Class15.smethod_0(7)] = GClass138.smethod_9((long) gclass20_0.cHP);
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(121186);
    strArray[Class15.smethod_0(2)] = GClass138.smethod_9((long) gclass20_0.cHPFull);
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(120977);
    string st = string.Concat(strArray);
    int x = GClass62.int_10 / Class15.smethod_0(7);
    int y1 = Class15.smethod_0(106);
    int align = Class15.smethod_0(7);
    gclass971.method_6(g, st, x, y1, align);
    int y2 = Class15.smethod_0(107);
    int num1 = Class15.smethod_0(31);
    if ((!gclass20_0.isNrd ? 1 : 0) == 0)
    {
      GClass97.gclass97_1.method_6(gclass98_0, Class13.smethod_0(120975) + gclass20_0.timeNRD.ToString() + Class13.smethod_0(157216), GClass62.int_10 / Class15.smethod_0(7), y2, Class15.smethod_0(7));
      y2 += num1;
    }
    if ((int) gclass20_0.isMonkey == Class15.smethod_0(1))
    {
      GClass97.gclass97_1.method_6(gclass98_0, Class13.smethod_0(157290), GClass62.int_10 / Class15.smethod_0(7), y2, Class15.smethod_0(7));
      y2 += num1;
    }
    if ((!gclass20_0.isFreez ? 1 : 0) != 0)
      return;
    GClass97.gclass97_1.method_6(gclass98_0, Class13.smethod_0(157272) + gclass20_0.freezSeconds.ToString() + Class13.smethod_0(157216), GClass62.int_10 / Class15.smethod_0(7), y2, Class15.smethod_0(7));
    int num2 = y2 + num1;
  }

  private void method_4(GClass98 gclass98_0)
  {
    if ((!this.bool_0 ? 1 : 0) != 0 || (!this.method_13() ? 0 : 1) != 0)
      return;
    int y = Class15.smethod_0(108);
    for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
    {
      gclass98_0.method_21(Class15.smethod_0(102), Class15.smethod_2(7));
      gclass98_0.method_15(GClass62.int_10 - Class15.smethod_0(29), y + Class15.smethod_0(7), Class15.smethod_0(27), Class15.smethod_0(45));
      this.list_0[index].method_1(gclass98_0, GClass62.int_10 - Class15.smethod_0(7), y, GClass97.int_1);
      y += Class15.smethod_0(31);
    }
  }

  public bool method_5(int keyCode)
  {
    switch (keyCode - Class15.smethod_0(109))
    {
      case 0:
        GClass14.gclass14_0.method_25((GClass14.gclass14_0.method_26() ? 1 : 0) == Class15.smethod_0(0));
        GClass116.gclass73_0.method_7(Class13.smethod_0(157374) + ((!GClass14.gclass14_0.method_26() ? 0 : 1) != 0 ? Class13.smethod_0(157314) : Class13.smethod_0(157361)), Class15.smethod_0(0));
        break;
      case 1:
        GClass156.smethod_0().method_14((sbyte) Class15.smethod_0(0), -1);
        break;
      case 2:
        for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
        {
          GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
          if ((gclass80 == null ? 1 : 0) == 0 && ((int) gclass80.template.id == Class15.smethod_0(41) || (int) gclass80.template.id == Class15.smethod_0(42)))
          {
            GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) gclass80.indexUI, (short) -1);
            break;
          }
        }
        break;
      case 3:
        GClass14.gclass14_0.method_18();
        break;
      case 4:
        this.bool_6 = (this.bool_6 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(157437) + ((!this.bool_6 ? 0 : 1) != 0 ? Class13.smethod_0(157314) : Class13.smethod_0(157361)), Class15.smethod_0(0));
        break;
      case 5:
        bool isNhapThe = GClass20.smethod_1().isNhapThe;
        for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
        {
          GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
          if ((gclass80 == null ? 1 : 0) == 0 && ((int) gclass80.template.id == Class15.smethod_0(110) || (int) gclass80.template.id == Class15.smethod_0(111)))
          {
            GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) gclass80.indexUI, (short) -1);
            break;
          }
        }
        if ((!isNhapThe ? 1 : 0) == 0)
        {
          GClass156.smethod_0().method_133((sbyte) Class15.smethod_0(5));
          break;
        }
        break;
      case 6:
        if ((GClass20.smethod_1().charFocus == null ? 0 : 1) == 0)
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(158008), Class15.smethod_0(0));
          break;
        }
        GClass156.smethod_0().method_7((sbyte) Class15.smethod_0(0), GClass20.smethod_1().charFocus.charID, (sbyte) -1, -1);
        GClass116.gclass73_0.method_7(Class13.smethod_0(157978) + GClass20.smethod_1().charFocus.cName, Class15.smethod_0(0));
        break;
      case 7:
        this.method_24();
        break;
      case 8:
        this.bool_7 = (this.bool_7 ? 1 : 0) == Class15.smethod_0(0);
        if ((!this.bool_7 ? 0 : 1) == 0)
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(158062), Class15.smethod_0(0));
          break;
        }
        if ((GClass20.smethod_1().charFocus == null ? 0 : 1) == 0)
        {
          this.bool_7 = Class15.smethod_0(0) != 0;
          this.method_10((GInterface1) this, this.string_2[Class15.smethod_0(0)], this.string_2[Class15.smethod_0(0)], GClass184.int_8);
          break;
        }
        this.int_5 = GClass20.smethod_1().charFocus.charID;
        GClass116.gclass73_0.method_7(Class13.smethod_0(158038) + GClass20.smethod_1().charFocus.cName, Class15.smethod_0(0));
        break;
      case 9:
        GClass8.gclass8_0.method_7();
        break;
      case 10:
        GClass8.gclass8_0.method_8();
        break;
      case 11:
        GClass8.gclass8_0.method_9();
        break;
      case 12:
        GClass62.gclass141_0.isShowZone = Class15.smethod_0(1) != 0;
        GClass156.smethod_0().method_59();
        break;
      case 13:
        if ((!this.method_13() ? 1 : 0) == 0)
        {
          GClass11.gclass11_0.method_13((GClass11.gclass11_0.method_12() ? 1 : 0) == Class15.smethod_0(0));
          GClass116.gclass73_0.method_7(Class13.smethod_0(158025) + ((!GClass11.gclass11_0.method_12() ? 0 : 1) != 0 ? Class13.smethod_0(157314) : Class13.smethod_0(157361)), Class15.smethod_0(0));
          break;
        }
        GClass11.gclass11_0.method_1();
        break;
      case 14:
        this.bool_5 = (this.bool_5 ? 1 : 0) == Class15.smethod_0(0);
        this.bool_4 = Class15.smethod_0(1) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(158128) + ((!this.bool_5 ? 0 : 1) != 0 ? Class13.smethod_0(157314) : Class13.smethod_0(157361)), Class15.smethod_0(0));
        break;
      case 15:
        this.bool_9 = (this.bool_9 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(158481) + ((!this.bool_9 ? 0 : 1) != 0 ? Class13.smethod_0(157314) : Class13.smethod_0(157361)), Class15.smethod_0(0));
        return Class15.smethod_0(1) != 0;
      case 18:
        if ((!this.method_13() ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
          {
            GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
            if ((!gclass20.isNrd ? 1 : 0) == 0)
            {
              GClass20.smethod_1().charFocus = gclass20;
              break;
            }
          }
          break;
        }
        for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
        {
          GClass20 gclass20_0 = (GClass20) GClass116.gclass134_5.method_3(index);
          if ((!gclass20_0.cName.Equals("") ? 0 : 1) == 0 && (!this.method_19(gclass20_0) ? 1 : 0) == 0 && ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0 || (GClass20.smethod_1().charFocus == null ? 1 : 0) == 0 && (!(GClass20.smethod_1().charFocus.cName != gclass20_0.cName) ? 1 : 0) == 0))
          {
            GClass20.smethod_1().charFocus = gclass20_0;
            break;
          }
        }
        break;
      case 19:
        this.method_26(Class15.smethod_0(112));
        break;
      case 23:
        this.method_20();
        break;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_6(string text)
  {
    if ((!text.Equals("") ? 1 : 0) == 0)
      return Class15.smethod_0(0) != 0;
    if ((!text.StartsWith(Class13.smethod_0(158983)) ? 1 : 0) == 0)
    {
      try
      {
        string str = text;
        char[] chArray = new char[Class15.smethod_0(1)];
        chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
        int zoneId = int.Parse(str.Split(chArray)[Class15.smethod_0(1)]);
        GClass156.smethod_0().method_43(zoneId, -1);
      }
      catch
      {
      }
      return Class15.smethod_0(1) != 0;
    }
    if ((!text.StartsWith(Class13.smethod_0(158977)) ? 1 : 0) == 0)
    {
      try
      {
        string str = text;
        char[] chArray = new char[Class15.smethod_0(1)];
        chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
        int num = this.int_2 = int.Parse(str.Split(chArray)[Class15.smethod_0(1)]);
        GClass116.gclass73_0.method_7(Class13.smethod_0(159102) + num.ToString(), Class15.smethod_0(0));
      }
      catch
      {
      }
      return Class15.smethod_0(1) != 0;
    }
    if ((!text.StartsWith(Class13.smethod_0(159076)) ? 1 : 0) == 0)
    {
      try
      {
        string str1 = text;
        char[] chArray1 = new char[Class15.smethod_0(1)];
        chArray1[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
        int num1 = int.Parse(str1.Split(chArray1)[Class15.smethod_0(1)]);
        string str2 = text;
        char[] chArray2 = new char[Class15.smethod_0(1)];
        chArray2[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
        int num2 = int.Parse(str2.Split(chArray2)[Class15.smethod_0(7)]);
        this.int_3 = num1;
        this.int_4 = num2;
        GClass116.gclass73_0.method_7(Class13.smethod_0(159071) + num1.ToString() + Class13.smethod_0(159065) + num2.ToString(), Class15.smethod_0(0));
      }
      catch
      {
      }
      return Class15.smethod_0(1) != 0;
    }
    if ((!text.StartsWith(Class13.smethod_0(159155)) ? 1 : 0) == 0)
    {
      try
      {
        string str = text;
        char[] chArray = new char[Class15.smethod_0(1)];
        chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
        float num = Time.timeScale = float.Parse(str.Split(chArray)[Class15.smethod_0(1)]);
        GClass116.gclass73_0.method_7(Class13.smethod_0(159482) + num.ToString(), Class15.smethod_0(0));
      }
      catch
      {
      }
      return Class15.smethod_0(1) != 0;
    }
    if ((!text.StartsWith(Class13.smethod_0(151556)) ? 1 : 0) != 0)
      return Class15.smethod_0(0) != 0;
    try
    {
      string str = text;
      char[] chArray = new char[Class15.smethod_0(1)];
      chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(101);
      float num = Time.timeScale = float.Parse(str.Split(chArray)[Class15.smethod_0(1)]) / Class15.smethod_2(9);
      GClass116.gclass73_0.method_7(Class13.smethod_0(159482) + num.ToString(), Class15.smethod_0(0));
    }
    catch
    {
    }
    return Class15.smethod_0(1) != 0;
  }

  public void method_7()
  {
    try
    {
      this.string_0 = System.IO.File.ReadAllText(Class13.smethod_0(152972));
      this.bool_0 = (uint) GClass152.smethod_8(Class13.smethod_0(153084)) > (uint) Class15.smethod_0(0);
      this.bool_2 = (uint) GClass152.smethod_8(Class13.smethod_0(153076)) > (uint) Class15.smethod_0(0);
      this.bool_3 = GClass152.smethod_8(Class13.smethod_0(153057)) == Class15.smethod_0(1);
      if (GClass98.int_8 == Class15.smethod_0(1))
      {
        this.int_0 = Class15.smethod_0(113);
        this.int_1 = Class15.smethod_0(45);
      }
      FileInfo[] files = new DirectoryInfo(Class13.smethod_0(153040)).GetFiles();
      for (int index = Class15.smethod_0(0); index < files.Length; index += Class15.smethod_0(1))
      {
        FileInfo fileInfo = files[index];
        this.list_4.Add(GClass66.smethod_19(System.IO.File.ReadAllBytes(Class13.smethod_0(153029) + fileInfo.Name)));
      }
      try
      {
        this.gclass66_1 = GClass66.smethod_19(Convert.FromBase64String(GClass68.string_1));
        this.gclass66_0 = GClass66.smethod_19(Convert.FromBase64String(GClass68.string_0));
      }
      catch
      {
      }
    }
    catch
    {
    }
    try
    {
      string commandLineArg = Environment.GetCommandLineArgs()[Class15.smethod_0(1)];
      char[] chArray = new char[Class15.smethod_0(1)];
      chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(114);
      string[] strArray = commandLineArg.Split(chArray);
      this.string_5 = strArray[Class15.smethod_0(0)];
      this.int_7 = int.Parse(strArray[Class15.smethod_0(1)]);
      this.string_6 = this.method_15(strArray[Class15.smethod_0(7)], Class13.smethod_0(152613));
      new Thread(new ThreadStart(this.method_8)).Start();
    }
    catch
    {
      this.string_5 = "";
    }
  }

  public void method_8()
  {
    Thread.Sleep(Class15.smethod_0(15));
    while (true)
    {
      try
      {
        if ((!string.IsNullOrEmpty(GClass20.smethod_1().cName) ? 1 : 0) == 0)
        {
          Thread.Sleep(Class15.smethod_0(21));
          while ((!GClass120.bool_6 ? 1 : 0) != 0)
            Thread.Sleep(Class15.smethod_0(16));
          Thread.Sleep(Class15.smethod_0(16));
          GClass152.smethod_4(Class13.smethod_0(152657), Class13.smethod_0(152752));
          GClass152.smethod_4(Class13.smethod_0(152727), Class13.smethod_0(152716));
          Thread.Sleep(Class15.smethod_0(16));
          GClass152.smethod_9(Class13.smethod_0(154057), this.int_7 - Class15.smethod_0(1));
          GClass120.int_12 = this.int_7 - Class15.smethod_0(1);
          GClass62.gclass120_0.method_1();
          while ((!GClass120.bool_6 ? 1 : 0) != 0)
            Thread.Sleep(Class15.smethod_0(16));
          while ((!GClass157.smethod_0().imethod_0() ? 1 : 0) != 0)
            Thread.Sleep(Class15.smethod_0(16));
          Thread.Sleep(Class15.smethod_0(16));
          while ((!GClass120.bool_6 ? 1 : 0) != 0)
            Thread.Sleep(Class15.smethod_0(16));
          Thread.Sleep(Class15.smethod_0(15));
          GClass62.gclass120_0.imethod_0(Class15.smethod_0(5), (object) null);
          Thread.Sleep(Class15.smethod_0(15));
          GClass62.int_8 = Class15.smethod_0(0);
          Thread.Sleep(Class15.smethod_0(115));
        }
      }
      catch
      {
      }
      Thread.Sleep(Class15.smethod_0(14));
    }
  }

  private void method_9()
  {
    if (this.list_1.Count <= Class15.smethod_0(7))
      return;
    List<GClass20> gclass20List = new List<GClass20>();
    while ((this.list_1.Count == 0 ? 0 : 1) != 0)
    {
      GClass20 gclass20_1 = this.list_1[Class15.smethod_0(0)];
      gclass20List.Add(gclass20_1);
      string str = gclass20_1.method_155();
      this.list_1.RemoveAt(Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < this.list_1.Count; index += Class15.smethod_0(1))
      {
        GClass20 gclass20_2 = this.list_1[index];
        if ((!(str == gclass20_2.method_155()) ? 1 : 0) == 0)
        {
          gclass20List.Add(gclass20_2);
          this.list_1.RemoveAt(index);
          index -= Class15.smethod_0(1);
        }
      }
    }
    this.list_1.Clear();
    this.list_1 = gclass20List;
  }

  public void method_10(GInterface1 chatable, string name, string text, int typeInput)
  {
    this.gclass23_0.strChat = name;
    this.gclass23_0.tfChat.name = text;
    this.gclass23_0.tfChat.method_28(typeInput);
    this.gclass23_0.left.caption = GClass109.string_140;
    this.gclass23_0.right.caption = GClass109.string_125;
    this.gclass23_0.method_5(chatable, string.Empty);
  }

  public void method_11(GInterface1 chatable, string name, string text)
  {
    this.gclass23_0.strChat = name;
    this.gclass23_0.tfChat.name = text;
    this.gclass23_0.tfChat.method_28(GClass184.int_7);
    this.gclass23_0.left.caption = GClass109.string_140;
    this.gclass23_0.right.caption = GClass109.string_125;
    this.gclass23_0.method_5(chatable, string.Empty);
  }

  public void method_12() => this.gclass23_0.isShow = Class15.smethod_0(0) != 0;

  public bool method_13() => GClass185.int_37 >= Class15.smethod_0(81) && GClass185.int_37 <= Class15.smethod_0(82) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  private void method_14()
  {
    this.bool_1 = Class15.smethod_0(1) != 0;
    try
    {
      string str1 = Encoding.Default.GetString(new WebClient().UploadValues(this.method_16(this.method_15(Class13.smethod_0(153753), Class13.smethod_0(154412))), new NameValueCollection()
      {
        [Class13.smethod_0(153692)] = this.string_0,
        [Class13.smethod_0(153666)] = Convert.ToBase64String(GClass116.gclass66_44.texture.EncodeToPNG())
      }));
      Thread.Sleep(Class15.smethod_0(116));
      if ((!str1.StartsWith(Class13.smethod_0(154401)) ? 1 : 0) == 0)
      {
        GClass116.smethod_6().keyInput = "";
        string str2 = str1.Replace(Class13.smethod_0(154396), "").Trim();
        for (int index = Class15.smethod_0(0); index < str2.Length; index += Class15.smethod_0(1))
        {
          GClass156.smethod_0().method_13(str2[index]);
          GClass116.smethod_6().keyInput += str2[index].ToString();
          Thread.Sleep(Class15.smethod_0(21));
        }
      }
    }
    catch (Exception ex)
    {
      Thread.Sleep(Class15.smethod_0(15));
    }
    this.bool_1 = Class15.smethod_0(0) != 0;
  }

  public string method_15(string text, string key)
  {
    byte[] inputBuffer = Convert.FromBase64String(text);
    TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
    cryptoServiceProvider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
    cryptoServiceProvider.Mode = (CipherMode) Class15.smethod_0(7);
    cryptoServiceProvider.Padding = (PaddingMode) Class15.smethod_0(7);
    return Encoding.UTF8.GetString(cryptoServiceProvider.CreateDecryptor().TransformFinalBlock(inputBuffer, Class15.smethod_0(0), inputBuffer.Length));
  }

  private string method_16(string string_7)
  {
    byte[] bytes = new byte[string_7.Length / Class15.smethod_0(7)];
    for (int index = Class15.smethod_0(0); index < bytes.Length; index += Class15.smethod_0(1))
      bytes[index] = Convert.ToByte(string_7.Substring(index * Class15.smethod_0(7), Class15.smethod_0(7)), Class15.smethod_0(10));
    return Encoding.UTF8.GetString(bytes);
  }

  public void method_17(int x, int y)
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

  public void method_18(int charId)
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
    {
      GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
      if ((!gclass20.isMiniPet ? 0 : 1) == 0 && (!gclass20.isPet ? 0 : 1) == 0 && gclass20.charID == charId)
      {
        GClass20.smethod_1().mobFocus = (GClass100) null;
        GClass20.smethod_1().npcFocus = (GClass21) null;
        GClass20.smethod_1().itemFocus = (GClass81) null;
        GClass20.smethod_1().charFocus = gclass20;
        break;
      }
    }
  }

  private bool method_19(GClass20 gclass20_0) => (gclass20_0.cName == null ? 1 : 0) == 0 && (!(gclass20_0.cName != "") ? 1 : 0) == 0 && (!gclass20_0.isPet ? 0 : 1) == 0 && (!gclass20_0.isMiniPet ? 0 : 1) == 0 && (!char.IsUpper(char.Parse(gclass20_0.cName.Substring(Class15.smethod_0(0), Class15.smethod_0(1)))) ? 1 : 0) == 0 && (!(gclass20_0.cName != Class13.smethod_0(154390)) ? 1 : 0) == 0 && (!gclass20_0.cName.StartsWith(Class13.smethod_0(154484)) ? 0 : 1) == 0 ? (gclass20_0.cName.StartsWith(Class13.smethod_0(154589)) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  public void imethod_1(string text, string to)
  {
    if ((this.gclass23_0.tfChat.method_21() == null ? 1 : 0) == 0 && (!this.gclass23_0.tfChat.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0 && (text == null ? 0 : 1) != 0)
    {
      if ((!this.gclass23_0.strChat.Equals(this.string_2[Class15.smethod_0(0)]) ? 1 : 0) != 0)
        return;
      try
      {
        int num = this.int_5 = int.Parse(this.gclass23_0.tfChat.method_21());
        this.bool_7 = Class15.smethod_0(1) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(154585) + num.ToString(), Class15.smethod_0(0));
      }
      catch
      {
        GClass116.gclass73_0.method_7(Class13.smethod_0(154572), Class15.smethod_0(0));
      }
      this.method_12();
    }
    else
      this.method_12();
  }

  public void imethod_2()
  {
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(1))
    {
      case 0:
        switch ((int) p)
        {
          case 0:
            GClass8.gclass8_0.method_1();
            return;
          case 1:
            GClass14.gclass14_0.method_1();
            return;
          case 2:
            GClass10.gclass10_0.method_1();
            return;
          case 3:
            GClass11.gclass11_0.method_1();
            return;
          case 4:
            GClass15.gclass15_0.method_1();
            return;
          case 5:
            GClass4.gclass4_0.method_1();
            return;
          case 6:
            GClass12.gclass12_0.method_1();
            return;
          case 7:
            this.method_21();
            return;
          default:
            return;
        }
      case 1:
        this.method_22();
        break;
      case 2:
        string str = (string) p;
        if ((!str.StartsWith(Class13.smethod_0(154294)) ? 1 : 0) == 0)
        {
          Application.OpenURL(str);
          break;
        }
        GClass62.smethod_28(str);
        break;
      case 3:
        this.bool_0 = (this.bool_0 ? 1 : 0) == Class15.smethod_0(0);
        GClass152.smethod_9(Class13.smethod_0(154280), (!this.bool_0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 4:
        this.bool_2 = (this.bool_2 ? 1 : 0) == Class15.smethod_0(0);
        GClass152.smethod_9(Class13.smethod_0(154250), (!this.bool_2 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 5:
        this.bool_3 = (this.bool_3 ? 1 : 0) == Class15.smethod_0(0);
        GClass152.smethod_9(Class13.smethod_0(154367), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        GClass62.bool_1 = this.bool_3;
        break;
    }
  }

  public void method_20()
  {
    GClass134 menuItems = new GClass134();
    for (int index = Class15.smethod_0(0); index < this.list_3.Count; index += Class15.smethod_0(1))
      menuItems.method_0((object) new GClass31(this.list_3[index], (GInterface0) this, Class15.smethod_0(1), (object) index));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  public void method_21()
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(154347), (GInterface0) this, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(154327) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(154937) : Class13.smethod_0(154306)), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(154911) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(154937) : Class13.smethod_0(154306)), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(155030) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(154937) : Class13.smethod_0(154306)), (GInterface0) this, Class15.smethod_0(37), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  public void method_22()
  {
    GClass134 menuItems = new GClass134();
    for (int index = Class15.smethod_0(0); index < this.dictionary_0.Count; index += Class15.smethod_0(1))
    {
      GClass134 gclass134 = menuItems;
      KeyValuePair<string, string> keyValuePair = this.dictionary_0.ElementAt<KeyValuePair<string, string>>(index);
      string key = keyValuePair.Key;
      int action = Class15.smethod_0(5);
      keyValuePair = this.dictionary_0.ElementAt<KeyValuePair<string, string>>(index);
      string p = keyValuePair.Value;
      GClass31 o = new GClass31(key, (GInterface0) this, action, (object) p);
      gclass134.method_0((object) o);
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_23()
  {
    if (GClass20.smethod_1().luong + GClass20.smethod_1().luongKhoa <= Class15.smethod_0(0) || (!GClass20.smethod_1().meDead ? 1 : 0) != 0 || GClass20.smethod_1().cHP > Class15.smethod_0(0) || (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) != 0)
      return;
    GClass156.smethod_0().method_78();
    GClass20.smethod_1().meDead = Class15.smethod_0(0) != 0;
    GClass20.smethod_1().statusMe = Class15.smethod_0(1);
    GClass20.smethod_1().cHP = GClass20.smethod_1().cHPFull;
    GClass20.smethod_1().cMP = GClass20.smethod_1().cMPFull;
    GClass20.smethod_1().cp1 = GClass20.smethod_1().cp2 = GClass20.smethod_1().cp3 = Class15.smethod_0(0);
    GClass47.smethod_3(Class15.smethod_0(56), GClass20.smethod_1(), Class15.smethod_0(7));
    GClass116.smethod_6().center = (GClass31) null;
    GClass116.bool_16 = Class15.smethod_0(1) != 0;
  }

  private void method_24()
  {
    if ((!this.method_13() ? 0 : 1) == 0)
      GClass116.gclass73_0.method_7(Class13.smethod_0(155099), Class15.smethod_0(0));
    else if ((int) GClass20.smethod_1().cFlag != Class15.smethod_0(88))
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(154674), Class15.smethod_0(0));
    }
    else
    {
      bool flag1 = Class15.smethod_0(0) != 0;
      if (GClass20.smethod_1().bag >= Class15.smethod_0(0) && (!GClass26.gclass128_0.method_7((object) (GClass20.smethod_1().bag.ToString() + string.Empty)) ? 1 : 0) == 0)
      {
        GClass26 gclass26 = (GClass26) GClass26.gclass128_0.method_0((object) (GClass20.smethod_1().bag.ToString() + string.Empty));
        if ((gclass26.idImage == null ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < gclass26.idImage.Length; index += Class15.smethod_0(1))
          {
            if ((int) gclass26.idImage[index] == Class15.smethod_0(85))
            {
              flag1 = Class15.smethod_0(1) != 0;
              break;
            }
          }
        }
      }
      if ((!flag1 ? 0 : 1) == 0)
      {
        GClass116.gclass73_0.method_7(Class13.smethod_0(154674), Class15.smethod_0(0));
      }
      else
      {
        bool flag2 = Class15.smethod_0(1) != 0;
        bool flag3 = Class15.smethod_0(1) != 0;
        GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(Class15.smethod_0(0));
        for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
        {
          gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
          if (gclass21.template.npcTemplateId >= Class15.smethod_0(6) && gclass21.template.npcTemplateId <= Class15.smethod_0(86) && GClass20.smethod_1().cx > gclass21.cx - Class15.smethod_0(4) && GClass20.smethod_1().cx < gclass21.cx + Class15.smethod_0(4))
          {
            flag3 = Class15.smethod_0(0) != 0;
            break;
          }
        }
        if ((GClass20.smethod_1().holdEffID == 0 ? 0 : 1) != 0 || (!GClass20.smethod_1().sleepEff ? 0 : 1) != 0 || (!GClass20.smethod_1().blindEff ? 0 : 1) != 0 || (!GClass20.smethod_1().isFreez ? 1 : 0) == 0)
          flag2 = Class15.smethod_0(0) != 0;
        if ((!((flag2 ? 1 : 0) == Class15.smethod_0(0) & flag3) ? 1 : 0) == 0)
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(154637), Class15.smethod_0(0));
        }
        else
        {
          if ((!flag3 ? 1 : 0) == 0)
            this.method_17(gclass21.cx, gclass21.cy - Class15.smethod_0(5));
          int cHpFull1 = GClass20.smethod_1().cHPFull;
          int num = Class15.smethod_0(95);
          if (GClass185.int_37 == Class15.smethod_0(82))
            num = Class15.smethod_0(95);
          if (GClass185.int_37 == Class15.smethod_0(23))
            num = Class15.smethod_0(117);
          if (GClass185.int_37 == Class15.smethod_0(118))
            num = Class15.smethod_0(48);
          if (GClass185.int_37 == Class15.smethod_0(119))
            num = Class15.smethod_0(120);
          if (GClass185.int_37 == Class15.smethod_0(121))
            num = Class15.smethod_0(8);
          if (GClass185.int_37 == Class15.smethod_0(122))
            num = Class15.smethod_0(6);
          if (GClass185.int_37 == Class15.smethod_0(81))
            num = Class15.smethod_0(86);
          GClass156.smethod_0().method_61(num);
          GClass156.smethod_0().method_62(num, Class15.smethod_0(0), Class15.smethod_0(7));
          GClass156.smethod_0().method_63((short) Class15.smethod_0(7));
          GClass156.smethod_0().method_60((short) num, (sbyte) Class15.smethod_0(7));
          int cHpFull2 = GClass20.smethod_1().cHPFull;
          if (cHpFull1 != cHpFull2)
            GClass116.gclass73_0.method_7(Class13.smethod_0(154713), Class15.smethod_0(0));
          else
            GClass116.gclass73_0.method_7(Class13.smethod_0(154703), Class15.smethod_0(0));
        }
      }
    }
  }

  private void method_25()
  {
    if ((!this.bool_4 ? 1 : 0) == 0 && (GClass185.int_37 == Class15.smethod_0(40) || GClass185.int_37 == Class15.smethod_0(46) || GClass185.int_37 == Class15.smethod_0(50)) && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
    {
      GClass156.smethod_0().method_61(Class15.smethod_0(36));
      GClass156.smethod_0().method_60((short) Class15.smethod_0(36), (sbyte) Class15.smethod_0(1));
      if ((GClass62.gclass141_0.mapNames == null ? 1 : 0) == 0 && GClass62.gclass141_0.mapNames.Length > Class15.smethod_0(37) && (!(GClass62.gclass141_0.mapNames[this.int_3 - Class15.smethod_0(1)] == this.string_1[this.int_3 - Class15.smethod_0(1)]) ? 1 : 0) == 0)
      {
        GClass156.smethod_0().method_126(this.int_3 - Class15.smethod_0(1));
        this.bool_4 = Class15.smethod_0(0) != 0;
      }
    }
    if ((!this.method_13() ? 1 : 0) != 0 || (!GClass20.bool_4 ? 0 : 1) != 0 || (!GClass32.bool_5 ? 0 : 1) != 0 || (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) != 0)
      return;
    GClass156.smethod_0().method_43(this.int_4, -1);
    this.bool_5 = Class15.smethod_0(0) != 0;
    this.bool_4 = Class15.smethod_0(1) != 0;
  }

  private void method_26(int int_8)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
      if ((gclass80 == null ? 1 : 0) == 0 && (int) gclass80.template.id == int_8)
      {
        GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) gclass80.indexUI, (short) -1);
        break;
      }
    }
  }

  private void method_27()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass13.Class1 class1_1 = new GClass13.Class1();
    // ISSUE: reference to a compiler-generated field
    class1_1.\u003C\u003E4__this = this;
    string path = Class13.smethod_0(155605);
    if (GClass126.smethod_18() - this.long_1 < (long) Class15.smethod_0(123) || (!System.IO.File.Exists(path) ? 0 : 1) == 0)
      return;
    // ISSUE: variable of a compiler-generated type
    GClass13.Class1 class1_2 = class1_1;
    string str = System.IO.File.ReadAllText(path);
    char[] chArray = new char[Class15.smethod_0(1)];
    chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(114);
    string[] strArray = str.Split(chArray);
    // ISSUE: reference to a compiler-generated field
    class1_2.text = strArray;
    // ISSUE: reference to a compiler-generated field
    if ((!(class1_1.text[Class15.smethod_0(0)] == Class13.smethod_0(155178)) ? 1 : 0) == 0)
    {
      // ISSUE: reference to a compiler-generated field
      GClass156.smethod_0().method_43(int.Parse(class1_1.text[Class15.smethod_0(1)]), -1);
    }
    // ISSUE: reference to a compiler-generated field
    if ((!(class1_1.text[Class15.smethod_0(0)] == Class13.smethod_0(155169)) ? 1 : 0) == 0)
    {
      // ISSUE: reference to a compiler-generated method
      new Thread(new ThreadStart(class1_1.method_0)).Start();
    }
    this.long_1 = GClass126.smethod_18();
  }

  private void method_28(int int_8)
  {
    if ((!this.bool_8 ? 1 : 0) == 0)
      return;
    this.bool_8 = Class15.smethod_0(1) != 0;
    if (GClass20.smethod_1().myskill != GClass116.gclass161_0[int_8])
    {
      GClass116.smethod_6().method_61(GClass116.gclass161_0[int_8], Class15.smethod_0(1) != 0);
      Thread.Sleep(Class15.smethod_0(90));
      GClass116.smethod_6().method_61(GClass116.gclass161_0[int_8], Class15.smethod_0(1) != 0);
      this.bool_8 = Class15.smethod_0(0) != 0;
    }
    else
    {
      GClass116.smethod_6().method_61(GClass116.gclass161_0[int_8], Class15.smethod_0(1) != 0);
      this.bool_8 = Class15.smethod_0(0) != 0;
    }
  }

  public List<GClass20> method_29() => this.list_1;

  public List<GClass24> method_30() => this.list_0;

  public GClass23 method_31() => this.gclass23_0;

  public bool method_32() => this.bool_2;

  public bool method_33() => this.bool_0;

  public int method_34() => this.int_0;

  public int method_35() => this.int_1;

  public bool method_36() => this.bool_3;

  public GClass66 method_37() => this.gclass66_0;

  public GClass66 method_38() => this.gclass66_1;

  public List<GClass66> method_39() => this.list_4;

  public long method_40() => this.long_0;

  public void method_41(long lastTimeChangeBackground) => this.long_0 = lastTimeChangeBackground;

  public int method_42() => this.int_6;

  public void method_43(int indexBgr) => this.int_6 = indexBgr;

  public string method_44() => this.string_3;

  public string method_45() => this.string_4;

  public string method_46() => this.string_5;

  public string method_47() => this.string_6;
}
