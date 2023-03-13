// Decompiled with JetBrains decompiler
// Type: GClass14
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;
using System.Threading;

public class GClass14 : GInterface0, GInterface1
{
  public static GClass14 gclass14_0 = new GClass14();
  private bool bool_0;
  private bool bool_1;
  private long[] long_0;
  private bool bool_2;
  private bool bool_3;
  private bool[] bool_4;
  private long[] long_1;
  private long[] long_2;
  private int int_0;
  private bool bool_5;
  private long long_3;
  private long long_4;
  private List<GClass20> list_0;
  private int int_1;
  private bool bool_6;
  private string[] string_0;
  private bool bool_7;
  private long long_5;
  private long long_6;
  private int int_2;
  private string[] string_1;

  public GClass14()
  {
    this.bool_0 = Class15.smethod_0(1) != 0;
    this.long_0 = new long[Class15.smethod_0(31)];
    this.bool_4 = new bool[Class15.smethod_0(31)];
    this.long_1 = new long[Class15.smethod_0(31)];
    this.long_2 = new long[Class15.smethod_0(31)];
    this.list_0 = new List<GClass20>();
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(29027);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(30682);
    this.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(30669);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(31248);
    this.string_1 = strArray2;
    this.method_3();
  }

  public void method_0()
  {
    if ((!this.bool_1 ? 1 : 0) == 0)
      this.method_6();
    if ((!this.bool_6 ? 1 : 0) == 0)
      this.method_17();
    if (this.int_2 > Class15.smethod_0(0))
      this.method_19();
    if ((!this.bool_2 ? 1 : 0) == 0)
      this.method_7();
    if ((!GClass20.smethod_1().meDead ? 0 : 1) == 0)
    {
      for (int int_3 = Class15.smethod_0(0); int_3 < GClass116.gclass161_0.Length; int_3 += Class15.smethod_0(1))
      {
        if ((!this.bool_4[int_3] ? 1 : 0) == 0)
          this.method_8(int_3);
      }
    }
    if ((!this.bool_0 ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
    {
      this.bool_0 = Class15.smethod_0(0) != 0;
      this.method_5();
    }
    if ((!this.bool_5 ? 1 : 0) != 0)
      return;
    this.method_15();
  }

  public void imethod_1(string text, string to)
  {
    GClass23 gclass23 = GClass13.gclass13_0.method_31();
    if ((gclass23.tfChat.method_21() == null ? 1 : 0) == 0 && (!gclass23.tfChat.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0 && (text == null ? 0 : 1) != 0)
    {
      if ((!gclass23.strChat.Equals(this.string_0[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          long m = long.Parse(gclass23.tfChat.method_21());
          this.long_2[this.int_0] = m;
          this.bool_4[this.int_0] = Class15.smethod_0(1) != 0;
          GClass73 gclass730 = GClass116.gclass73_0;
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = Class13.smethod_0(31348);
          strArray[Class15.smethod_0(1)] = GClass116.gclass161_0[this.int_0].template.name;
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(25453);
          strArray[Class15.smethod_0(5)] = GClass138.smethod_9(m);
          strArray[Class15.smethod_0(2)] = Class13.smethod_0(25450);
          string s = string.Concat(strArray);
          int Type = Class15.smethod_0(0);
          gclass730.method_7(s, Type);
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(25420), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_1[Class15.smethod_0(0)]) ? 1 : 0) != 0)
          return;
        try
        {
          int m = this.int_2 = int.Parse(gclass23.tfChat.method_21());
          GClass73 gclass730 = GClass116.gclass73_0;
          string[] strArray = new string[Class15.smethod_0(5)];
          strArray[Class15.smethod_0(0)] = Class13.smethod_0(25500);
          strArray[Class15.smethod_0(1)] = GClass138.smethod_9((long) m);
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(27726);
          string s = string.Concat(strArray);
          int Type = Class15.smethod_0(0);
          gclass730.method_7(s, Type);
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(27799), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
    }
    else
      gclass23.isShow = Class15.smethod_0(0) != 0;
  }

  public void imethod_2()
  {
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(1))
    {
      case 0:
        this.bool_1 = (this.bool_1 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28539) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(28500) : Class13.smethod_0(28506)), Class15.smethod_0(0));
        if ((!this.bool_1 ? 1 : 0) != 0)
          break;
        this.bool_5 = Class15.smethod_0(0) != 0;
        break;
      case 1:
        this.bool_2 = (this.bool_2 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28495) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(28500) : Class13.smethod_0(28506)), Class15.smethod_0(0));
        break;
      case 2:
        GClass134 menuItems = new GClass134();
        for (int p1 = Class15.smethod_0(0); p1 < GClass116.gclass161_0.Length; p1 += Class15.smethod_0(1))
          menuItems.method_0((object) new GClass31(((GClass116.gclass161_0[p1] == null ? 0 : 1) != 0 ? GClass116.gclass161_0[p1].template.name : Class13.smethod_0(28583)) + Class13.smethod_0(28336) + (p1 + Class15.smethod_0(1)).ToString() + Class13.smethod_0(28316), (GInterface0) this, Class15.smethod_0(31), (object) p1));
        GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
        break;
      case 3:
        this.bool_6 = (this.bool_6 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(28306) + ((!this.bool_6 ? 0 : 1) != 0 ? Class13.smethod_0(28500) : Class13.smethod_0(28506)), Class15.smethod_0(0));
        break;
      case 4:
        GClass116.gclass73_0.method_7(Class13.smethod_0(28401), Class15.smethod_0(0));
        break;
      case 5:
        this.bool_5 = (this.bool_5 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(20798) + ((!this.bool_5 ? 0 : 1) != 0 ? Class13.smethod_0(28500) : Class13.smethod_0(28506)), Class15.smethod_0(0));
        if ((!this.bool_5 ? 1 : 0) != 0)
          break;
        this.bool_1 = Class15.smethod_0(0) != 0;
        break;
      case 6:
        this.list_0.Clear();
        GClass116.gclass73_0.method_7(Class13.smethod_0(120527), Class15.smethod_0(0));
        break;
      case 7:
        if ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0)
          break;
        this.list_0.Remove(GClass20.smethod_1().charFocus);
        GClass73 gclass730_1 = GClass116.gclass73_0;
        string[] strArray1 = new string[Class15.smethod_0(3)];
        strArray1[Class15.smethod_0(0)] = Class13.smethod_0(121114);
        strArray1[Class15.smethod_0(1)] = GClass20.smethod_1().charFocus.cName;
        strArray1[Class15.smethod_0(7)] = Class13.smethod_0(157249);
        strArray1[Class15.smethod_0(5)] = GClass20.smethod_1().charFocus.charID.ToString();
        strArray1[Class15.smethod_0(2)] = Class13.smethod_0(158378);
        string s1 = string.Concat(strArray1);
        int Type1 = Class15.smethod_0(0);
        gclass730_1.method_7(s1, Type1);
        break;
      case 8:
        if ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0)
          break;
        this.list_0.Add(GClass20.smethod_1().charFocus);
        GClass73 gclass730_2 = GClass116.gclass73_0;
        string[] strArray2 = new string[Class15.smethod_0(3)];
        strArray2[Class15.smethod_0(0)] = Class13.smethod_0(159366);
        strArray2[Class15.smethod_0(1)] = GClass20.smethod_1().charFocus.cName;
        strArray2[Class15.smethod_0(7)] = Class13.smethod_0(157249);
        strArray2[Class15.smethod_0(5)] = GClass20.smethod_1().charFocus.charID.ToString();
        strArray2[Class15.smethod_0(2)] = Class13.smethod_0(158378);
        string s2 = string.Concat(strArray2);
        int Type2 = Class15.smethod_0(0);
        gclass730_2.method_7(s2, Type2);
        break;
      case 9:
        this.method_2((int) p);
        break;
      case 10:
        int index1 = (int) p;
        this.bool_4[index1] = (this.bool_4[index1] ? 1 : 0) == Class15.smethod_0(0);
        if ((!this.bool_4[index1] ? 1 : 0) == 0)
          this.long_2[index1] = -1L;
        GClass116.gclass73_0.method_7(Class13.smethod_0(151562) + GClass116.gclass161_0[index1].template.name + ((!this.bool_4[index1] ? 0 : 1) != 0 ? Class13.smethod_0(152387) + GClass138.smethod_9(this.long_2[index1]) + Class13.smethod_0(152816) : Class13.smethod_0(152430)), Class15.smethod_0(0));
        break;
      case 11:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
        this.int_0 = (int) p;
        break;
      case 12:
        int index2 = (int) p;
        GClass116.gclass161_0[index2].coolDown = Class15.smethod_0(0);
        GClass116.gclass161_0[index2].manaUse = Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(152789) + GClass116.gclass161_0[index2].template.name, Class15.smethod_0(0));
        break;
      case 13:
        if (this.int_2 <= Class15.smethod_0(0))
          GClass13.gclass13_0.method_10((GInterface1) this, this.string_1[Class15.smethod_0(0)], this.string_1[Class15.smethod_0(1)], GClass184.int_8);
        if (this.int_2 <= Class15.smethod_0(0))
          break;
        this.int_2 = Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(152775), Class15.smethod_0(0));
        break;
    }
  }

  public void method_1()
  {
    this.method_3();
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(153111) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(153174) : Class13.smethod_0(153180)), (GInterface0) this, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(153169) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(153174) : Class13.smethod_0(153180)), (GInterface0) this, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(GClass116.gclass161_0.Length.ToString() + Class13.smethod_0(153273), (GInterface0) this, Class15.smethod_0(5), (object) null));
    if (GClass20.smethod_1().cgender == Class15.smethod_0(7))
      menuItems.method_0((object) new GClass31(Class13.smethod_0(153222) + GClass138.smethod_9((long) this.int_2) + Class13.smethod_0(153333), (GInterface0) this, Class15.smethod_0(49), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(154975) + ((!this.bool_7 ? 0 : 1) != 0 ? Class13.smethod_0(153174) : Class13.smethod_0(153180)), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(155071) + ((!this.bool_5 ? 0 : 1) != 0 ? Class13.smethod_0(153174) : Class13.smethod_0(153180)), (GInterface0) this, Class15.smethod_0(37), (object) null));
    if (this.list_0.Count > Class15.smethod_0(0))
      menuItems.method_0((object) new GClass31(Class13.smethod_0(147946), (GInterface0) this, Class15.smethod_0(38), (object) null));
    if ((GClass20.smethod_1().charFocus == null ? 1 : 0) == 0)
    {
      if ((!this.list_0.Contains(GClass20.smethod_1().charFocus) ? 1 : 0) == 0)
        menuItems.method_0((object) new GClass31(Class13.smethod_0(147908), (GInterface0) this, Class15.smethod_0(88), (object) null));
      else
        menuItems.method_0((object) new GClass31(Class13.smethod_0(147578), (GInterface0) this, Class15.smethod_0(45), (object) null));
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2(int int_3)
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(147663) + ((!this.bool_4[int_3] ? 0 : 1) != 0 ? Class13.smethod_0(148270) + GClass138.smethod_9(this.long_2[int_3]) + Class13.smethod_0(148259) : Class13.smethod_0(148276)), (GInterface0) this, Class15.smethod_0(67), (object) int_3));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(148048), (GInterface0) this, Class15.smethod_0(66), (object) int_3));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(150033) + GClass116.gclass161_0[int_3].template.name, (GInterface0) this, Class15.smethod_0(47), (object) int_3));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_3()
  {
  }

  private void method_4()
  {
  }

  private void method_5()
  {
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().nClass.skillTemplates.Length; index += Class15.smethod_0(1))
    {
      GClass167 skillTemplate = GClass20.smethod_1().nClass.skillTemplates[index];
      GClass161 gclass161 = GClass20.smethod_1().method_12(skillTemplate);
      GClass116.gclass161_0[index] = gclass161;
      GClass116.smethod_6().method_13();
    }
  }

  public void method_6()
  {
    if ((!GClass20.smethod_1().meDead ? 0 : 1) != 0 || GClass20.smethod_1().cHP <= Class15.smethod_0(0) || GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3) || GClass20.smethod_1().myskill.template.type == Class15.smethod_0(5) || (int) GClass20.smethod_1().myskill.template.id == Class15.smethod_0(31) || (int) GClass20.smethod_1().myskill.template.id == Class15.smethod_0(67) || (!GClass20.smethod_1().myskill.paintCanNotUseSkill ? 1 : 0) == 0 && (!GClass62.gclass141_0.isShow ? 0 : 1) == 0)
      return;
    int index = this.method_14();
    if (GClass126.smethod_18() - this.long_0[index] <= this.method_13(GClass20.smethod_1().myskill))
      return;
    if ((!GClass116.smethod_6().method_31(GClass20.smethod_1().mobFocus) ? 1 : 0) == 0 && (double) GClass93.smethod_0(GClass20.smethod_1().mobFocus.xFirst - GClass20.smethod_1().cx) < (double) GClass20.smethod_1().myskill.dx * Class15.smethod_3(0))
    {
      GClass20.smethod_1().myskill.lastTimeUseThisSkill = GClass126.smethod_18();
      this.method_12();
      this.long_0[index] = GClass126.smethod_18();
    }
    else
    {
      if ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0 || (!this.method_9(GClass20.smethod_1().charFocus) ? 1 : 0) != 0 || (double) GClass93.smethod_0(GClass20.smethod_1().charFocus.cx - GClass20.smethod_1().cx) >= (double) GClass20.smethod_1().myskill.dx * Class15.smethod_3(0))
        return;
      GClass20.smethod_1().myskill.lastTimeUseThisSkill = GClass126.smethod_18();
      this.method_11();
      this.long_0[index] = GClass126.smethod_18();
    }
  }

  private void method_7()
  {
    if ((!this.bool_3 ? 1 : 0) != 0 || (GClass116.gclass134_9.method_2() == 0 ? 1 : 0) != 0 || GClass20.smethod_1().myskill.template.type == Class15.smethod_0(5))
      return;
    GClass100 gclass100_1 = (GClass100) GClass116.gclass134_9.method_3(Class15.smethod_0(0));
    int num1 = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 gclass100_2 = (GClass100) GClass116.gclass134_9.method_3(index);
      int num2 = GClass93.smethod_0(GClass20.smethod_1().cx - gclass100_2.x);
      int num3 = GClass93.smethod_0(GClass20.smethod_1().cy - gclass100_2.y);
      int num4 = num2 * num2 + num3 * num3;
      if (num1 < num4)
      {
        num1 = num4;
        gclass100_1 = gclass100_2;
      }
    }
    GClass20.smethod_1().mobFocus = gclass100_1;
    int index1 = this.method_14();
    if (GClass126.smethod_18() - this.long_0[index1] <= (long) (GClass20.smethod_1().myskill.coolDown + Class15.smethod_0(21)) || (!GClass116.smethod_6().method_31(GClass20.smethod_1().mobFocus) ? 1 : 0) != 0)
      return;
    this.method_12();
    this.long_0[index1] = GClass126.smethod_18();
    this.bool_3 = Class15.smethod_0(0) != 0;
  }

  private void method_8(int int_3)
  {
    if (GClass185.int_37 == Class15.smethod_0(27) || GClass185.int_37 == Class15.smethod_0(28) || GClass185.int_37 == Class15.smethod_0(29))
      return;
    if (int_3 >= GClass116.gclass161_0.Length)
      int_3 = GClass116.gclass161_0.Length - Class15.smethod_0(1);
    if (int_3 < Class15.smethod_0(0))
      int_3 = Class15.smethod_0(0);
    if ((GClass116.gclass161_0[int_3] == null ? 1 : 0) != 0 || (!GClass116.gclass161_0[int_3].paintCanNotUseSkill ? 1 : 0) == 0)
      return;
    if ((GClass116.gclass161_0[int_3].coolDown == 0 ? 0 : 1) == 0)
    {
      this.long_2[int_3] = (long) Class15.smethod_0(16);
    }
    else
    {
      if ((!this.method_10(GClass116.gclass161_0[int_3]) ? 1 : 0) != 0 || (!GClass116.smethod_6().method_60() ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_5 <= (long) Class15.smethod_0(19))
        return;
      if (this.long_2[int_3] == -1L && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
      {
        this.long_1[int_3] = GClass126.smethod_18();
        this.long_5 = GClass126.smethod_18();
        GClass116.smethod_6().method_61(GClass116.gclass161_0[int_3], Class15.smethod_0(1) != 0);
      }
      if (GClass126.smethod_18() - this.long_1[int_3] <= this.long_2[int_3])
        return;
      this.long_1[int_3] = GClass126.smethod_18();
      this.long_5 = GClass126.smethod_18();
      GClass116.smethod_6().method_61(GClass116.gclass161_0[int_3], Class15.smethod_0(1) != 0);
    }
  }

  public bool method_9(GClass20 @char)
  {
    if (GClass185.int_37 == Class15.smethod_0(76))
    {
      if ((@char == null ? 1 : 0) != 0 || (GClass20.smethod_1().myskill == null ? 1 : 0) != 0)
        return Class15.smethod_0(0) != 0;
      return (int) @char.cTypePk != Class15.smethod_0(3) ? (int) @char.cTypePk == Class15.smethod_0(5) : Class15.smethod_0(1) != 0;
    }
    if ((@char == null ? 1 : 0) != 0 || (GClass20.smethod_1().myskill == null ? 1 : 0) != 0)
      return Class15.smethod_0(0) != 0;
    if (@char.statusMe != Class15.smethod_0(49) && @char.statusMe != Class15.smethod_0(3) && GClass20.smethod_1().myskill.template.type != Class15.smethod_0(7) && ((int) GClass20.smethod_1().cFlag == Class15.smethod_0(88) && (@char.cFlag == (sbyte) 0 ? 0 : 1) != 0 || (GClass20.smethod_1().cFlag == (sbyte) 0 ? 1 : 0) == 0 && (int) @char.cFlag == Class15.smethod_0(88) || (int) GClass20.smethod_1().cFlag != (int) @char.cFlag && (GClass20.smethod_1().cFlag == (sbyte) 0 ? 1 : 0) == 0 && (@char.cFlag == (sbyte) 0 ? 0 : 1) != 0 || (int) @char.cTypePk == Class15.smethod_0(5) && (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(5) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(3) || (int) @char.cTypePk == Class15.smethod_0(3) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(1) && (int) @char.cTypePk == Class15.smethod_0(1) || (int) GClass20.smethod_1().cTypePk == Class15.smethod_0(2) && (int) @char.cTypePk == Class15.smethod_0(2)))
      return Class15.smethod_0(1) != 0;
    return GClass20.smethod_1().myskill.template.type == Class15.smethod_0(7) ? ((int) @char.cTypePk == Class15.smethod_0(3) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;
  }

  private bool method_10(GClass161 gclass161_0)
  {
    if (gclass161_0.template.manaUseType == Class15.smethod_0(7))
      return Class15.smethod_0(1) != 0;
    return gclass161_0.template.manaUseType != Class15.smethod_0(1) ? (GClass20.smethod_1().cMP < gclass161_0.manaUse ? 1 : 0) == Class15.smethod_0(0) : (GClass20.smethod_1().cMP < gclass161_0.manaUse * GClass20.smethod_1().cMPFull / Class15.smethod_0(21) ? 1 : 0) == Class15.smethod_0(0);
  }

  private void method_11()
  {
    try
    {
      GClass134 vChar = new GClass134();
      vChar.method_0((object) GClass20.smethod_1().charFocus);
      GClass156.smethod_0().method_74(new GClass134(), vChar, Class15.smethod_0(7));
    }
    catch
    {
    }
  }

  private void method_12()
  {
    try
    {
      GClass134 vMob = new GClass134();
      vMob.method_0((object) GClass20.smethod_1().mobFocus);
      GClass156.smethod_0().method_74(vMob, new GClass134(), Class15.smethod_0(1));
    }
    catch
    {
    }
  }

  private long method_13(GClass161 gclass161_0)
  {
    if ((int) gclass161_0.template.id == Class15.smethod_0(51) || (int) gclass161_0.template.id == Class15.smethod_0(28) || (int) gclass161_0.template.id == Class15.smethod_0(38) || (int) gclass161_0.template.id == Class15.smethod_0(124) || (int) gclass161_0.template.id == Class15.smethod_0(29))
      return (long) gclass161_0.coolDown + (long) Class15.smethod_0(16);
    long num = (long) ((double) gclass161_0.coolDown * Class15.smethod_3(1));
    return num < (long) Class15.smethod_0(125) ? (long) Class15.smethod_0(125) : num;
  }

  private int method_14()
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass161_0.Length; index += Class15.smethod_0(1))
    {
      if (GClass116.gclass161_0[index] == GClass20.smethod_1().myskill)
        return index;
    }
    return Class15.smethod_0(0);
  }

  private void method_15()
  {
    if ((this.list_0.Count == 0 ? 0 : 1) == 0)
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(150128), Class15.smethod_0(0));
      this.bool_5 = Class15.smethod_0(0) != 0;
    }
    else
    {
      if ((!GClass20.smethod_1().meDead ? 0 : 1) != 0 || GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3) || GClass20.smethod_1().myskill.template.type == Class15.smethod_0(5) || (int) GClass20.smethod_1().myskill.template.id == Class15.smethod_0(31) || (int) GClass20.smethod_1().myskill.template.id == Class15.smethod_0(67) || (!GClass20.smethod_1().myskill.paintCanNotUseSkill ? 1 : 0) == 0)
        return;
      this.long_3 = this.method_16(GClass20.smethod_1().myskill);
      if (this.int_1 >= this.list_0.Count)
        this.int_1 = Class15.smethod_0(0);
      if (GClass126.smethod_18() - this.long_4 < this.long_3)
        return;
      this.long_4 = GClass126.smethod_18();
      GClass20.smethod_1().charFocus = GClass116.smethod_12(this.list_0[this.int_1].charID);
      this.int_1 += Class15.smethod_0(1);
      if (this.int_1 >= this.list_0.Count)
        this.int_1 = Class15.smethod_0(0);
      if ((GClass20.smethod_1().charFocus == null ? 1 : 0) != 0 || (!this.method_9(GClass20.smethod_1().charFocus) ? 1 : 0) != 0 || (double) GClass93.smethod_0(GClass20.smethod_1().charFocus.cx - GClass20.smethod_1().cx) >= (double) GClass20.smethod_1().myskill.dx * Class15.smethod_3(2))
        return;
      GClass20.smethod_1().myskill.lastTimeUseThisSkill = GClass126.smethod_18();
      this.method_11();
    }
  }

  private long method_16(GClass161 gclass161_0) => gclass161_0.coolDown <= Class15.smethod_0(16) ? (long) Class15.smethod_0(15) : (long) ((double) gclass161_0.coolDown * Class15.smethod_3(1) + Class15.smethod_3(3));

  private void method_17()
  {
  }

  public void method_18()
  {
    int index = this.method_14();
    GClass116.gclass161_0[index].coolDown = Class15.smethod_0(0);
    GClass116.gclass161_0[index].manaUse = Class15.smethod_0(0);
    GClass116.gclass73_0.method_7(Class13.smethod_0(150195) + GClass116.gclass161_0[index].template.name, Class15.smethod_0(0));
  }

  private void method_19()
  {
    if (this.int_2 <= Class15.smethod_0(0) || (GClass20.smethod_1().charFocus == null ? 1 : 0) != 0 || (!this.method_20(GClass20.smethod_1().charFocus) ? 0 : 1) == 0 && GClass20.smethod_1().charFocus.cHP <= Class15.smethod_0(0) || GClass20.smethod_1().charFocus.cHP > this.int_2 || (!GClass116.gclass161_0[Class15.smethod_0(2)].paintCanNotUseSkill ? 0 : 1) != 0 || GClass126.smethod_18() - this.long_6 <= (long) Class15.smethod_0(21))
      return;
    this.long_6 = GClass126.smethod_18();
    // ISSUE: reference to a compiler-generated field
    ThreadStart start = GClass14.\u003C\u003Ec.\u003C\u003E9__45_0;
    if ((start == null ? 0 : 1) == 0)
    {
      // ISSUE: reference to a compiler-generated field
      start = GClass14.\u003C\u003Ec.\u003C\u003E9__45_0 = (ThreadStart) (() =>
      {
        if (GClass20.smethod_1().myskill != GClass116.gclass161_0[Class15.smethod_0(2)])
        {
          GClass116.smethod_6().method_61(GClass116.gclass161_0[Class15.smethod_0(2)], Class15.smethod_0(1) != 0);
        }
        else
        {
          GClass116.smethod_6().method_61(GClass116.gclass161_0[Class15.smethod_0(2)], Class15.smethod_0(1) != 0);
          Thread.Sleep(Class15.smethod_0(96));
          GClass116.smethod_6().method_61(GClass116.gclass161_0[Class15.smethod_0(2)], Class15.smethod_0(1) != 0);
        }
      });
    }
    new Thread(start)
    {
      IsBackground = (Class15.smethod_0(1) != 0)
    }.Start();
  }

  private bool method_20(GClass20 gclass20_0) => (gclass20_0.cName == null ? 1 : 0) == 0 && (!(gclass20_0.cName != "") ? 1 : 0) == 0 && (!gclass20_0.isPet ? 0 : 1) == 0 && (!gclass20_0.isMiniPet ? 0 : 1) == 0 && (!char.IsUpper(char.Parse(gclass20_0.cName.Substring(Class15.smethod_0(0), Class15.smethod_0(1)))) ? 1 : 0) == 0 && (!(gclass20_0.cName != Class13.smethod_0(150177)) ? 1 : 0) == 0 && (!gclass20_0.cName.StartsWith(Class13.smethod_0(150164)) ? 0 : 1) == 0 ? (gclass20_0.cName.StartsWith(Class13.smethod_0(150269)) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  public bool[] method_21() => this.bool_4;

  public bool method_22() => this.bool_3;

  public void method_23(bool isPetRequestAttack) => this.bool_3 = isPetRequestAttack;

  public bool method_24() => this.bool_2;

  public void method_25(bool isAutoAttack) => this.bool_1 = isAutoAttack;

  public bool method_26() => this.bool_1;
}
