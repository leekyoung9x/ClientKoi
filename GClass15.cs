// Decompiled with JetBrains decompiler
// Type: GClass15
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;

public class GClass15 : GInterface0, GInterface1
{
  public static GClass15 gclass15_0 = new GClass15();
  private bool bool_0;
  private bool bool_1;
  private bool bool_2;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private bool bool_3;
  private int int_4;
  private string[] string_0;
  private List<int> list_0;
  private long long_0;
  private long long_1;

  public GClass15()
  {
    this.list_0 = new List<int>();
    this.int_4 = Class15.smethod_0(3);
    string[] strArray = new string[Class15.smethod_0(7)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(29074);
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(30686);
    this.string_0 = strArray;
  }

  public void method_0()
  {
    if ((!GClass116.bool_54 ? 1 : 0) == 0 && ((!GClass116.bool_55 ? 0 : 1) != 0 || (!this.bool_3 ? 1 : 0) == 0))
    {
      if ((GClass20.smethod_1().mobFocus == null ? 1 : 0) == 0 && (!GClass116.bool_55 ? 0 : 1) == 0)
      {
        if (GClass20.smethod_1().mobFocus.x > GClass20.smethod_1().cx && GClass20.smethod_1().cdir == Class15.smethod_0(1) && (!GClass185.smethod_27(GClass20.smethod_1().cx + GClass20.smethod_1().chw, GClass20.smethod_1().cy - GClass20.smethod_1().chh, Class15.smethod_0(2)) ? 1 : 0) == 0)
          GClass20.smethod_1().currentMovePoint = new GClass108(GClass20.smethod_1().cx + Class15.smethod_0(51), this.method_10(GClass20.smethod_1().cx + Class15.smethod_0(51)));
        if (GClass20.smethod_1().mobFocus.x < GClass20.smethod_1().cx && GClass20.smethod_1().cdir == -1 && (!GClass185.smethod_27(GClass20.smethod_1().cx - GClass20.smethod_1().chw - Class15.smethod_0(1), GClass20.smethod_1().cy - GClass20.smethod_1().chh, Class15.smethod_0(88)) ? 1 : 0) == 0)
          GClass20.smethod_1().currentMovePoint = new GClass108(GClass20.smethod_1().cx - Class15.smethod_0(51), this.method_10(GClass20.smethod_1().cx - Class15.smethod_0(51)));
      }
      if ((GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
        this.method_8();
    }
    if (GClass20.smethod_1().cStamina <= Class15.smethod_0(3) && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
      this.method_9();
    if ((!this.bool_1 ? 0 : 1) == 0)
      return;
    if ((!GClass20.smethod_1().meDead ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
      GClass156.smethod_0().method_77();
    if ((!this.method_5() ? 1 : 0) == 0)
    {
      int mapId = Class15.smethod_0(27) + GClass20.smethod_1().cgender;
      if (GClass185.int_37 == mapId)
        return;
      GClass116.bool_54 = Class15.smethod_0(0) != 0;
      GClass20.smethod_1().mobFocus = (GClass100) null;
      if ((GClass62.int_8 % Class15.smethod_0(32) == 0 ? 0 : 1) != 0)
        return;
      GClass8.gclass8_0.method_4(mapId);
    }
    else
    {
      if ((!this.method_5() ? 1 : 0) == 0)
        return;
      if (GClass185.int_37 != this.int_2)
      {
        GClass116.bool_54 = Class15.smethod_0(0) != 0;
        GClass8.gclass8_0.method_4(this.int_2);
      }
      if (GClass185.int_37 != this.int_2)
        return;
      if ((!this.bool_2 ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
        GClass116.bool_54 = Class15.smethod_0(1) != 0;
      if (GClass185.int_39 != this.int_3 && (!GClass20.bool_2 ? 0 : 1) == 0 && (!GClass32.bool_5 ? 0 : 1) == 0 && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
        GClass156.smethod_0().method_43(this.int_3, -1);
      if ((!this.bool_2 ? 1 : 0) != 0 || GClass20.smethod_1().cx == this.int_0 && GClass20.smethod_1().cy == this.int_1 || (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) != 0)
        return;
      this.method_3(this.int_0, this.int_1);
    }
  }

  public void imethod_1(string text, string to)
  {
    GClass23 gclass23 = GClass13.gclass13_0.method_31();
    if ((gclass23.tfChat.method_21() == null ? 1 : 0) == 0 && (!gclass23.tfChat.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0 && (text == null ? 0 : 1) != 0)
    {
      if ((!gclass23.strChat.Equals(this.string_0[Class15.smethod_0(0)]) ? 1 : 0) != 0)
        return;
      try
      {
        int num = this.int_4 = int.Parse(gclass23.tfChat.method_21());
        GClass116.gclass73_0.method_7(Class13.smethod_0(31082) + num.ToString() + Class13.smethod_0(31049), Class15.smethod_0(0));
      }
      catch
      {
        GClass116.gclass73_0.method_7(Class13.smethod_0(31041), Class15.smethod_0(0));
      }
      GClass13.gclass13_0.method_12();
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
        int num = (int) p;
        this.list_0.Clear();
        for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
        {
          GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
          if ((!gclass100.isMobMe ? 0 : 1) == 0 && gclass100.templateId == num)
            this.list_0.Add(gclass100.mobId);
        }
        this.method_7();
        break;
      case 1:
        this.list_0.Clear();
        for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
        {
          GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
          if ((!gclass100.isMobMe ? 0 : 1) == 0)
            this.list_0.Add(gclass100.mobId);
        }
        this.method_7();
        break;
      case 2:
        this.method_7();
        break;
      case 3:
        this.bool_0 = (this.bool_0 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(31105) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(31211) : Class13.smethod_0(31216)), Class15.smethod_0(0));
        break;
      case 4:
        this.method_2();
        break;
      case 5:
        this.list_0.Clear();
        this.bool_3 = Class15.smethod_0(0) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(31205), Class15.smethod_0(0));
        break;
      case 6:
        if ((GClass20.smethod_1().mobFocus == null ? 0 : 1) == 0)
          GClass116.gclass73_0.method_7(Class13.smethod_0(31176), Class15.smethod_0(0));
        if ((GClass20.smethod_1().mobFocus == null ? 1 : 0) != 0)
          break;
        this.list_0.Add(GClass20.smethod_1().mobFocus.mobId);
        GClass116.gclass73_0.method_7(Class13.smethod_0(30768) + GClass20.smethod_1().mobFocus.mobId.ToString(), Class15.smethod_0(0));
        break;
      case 7:
        this.bool_3 = Class15.smethod_0(0) != 0;
        GClass20.smethod_1().mobFocus = (GClass100) null;
        GClass116.gclass73_0.method_7(Class13.smethod_0(30749), Class15.smethod_0(0));
        break;
      case 8:
        if ((!this.bool_1 ? 1 : 0) == 0)
        {
          this.bool_1 = Class15.smethod_0(0) != 0;
          GClass116.gclass73_0.method_7(Class13.smethod_0(30726), Class15.smethod_0(0));
          break;
        }
        if ((!this.bool_1 ? 0 : 1) != 0)
          break;
        this.bool_2 = Class15.smethod_0(0) != 0;
        this.bool_1 = Class15.smethod_0(1) != 0;
        this.int_2 = GClass185.int_37;
        this.int_3 = GClass185.int_39;
        GClass73 gclass730_1 = GClass116.gclass73_0;
        string[] strArray1 = new string[Class15.smethod_0(3)];
        strArray1[Class15.smethod_0(0)] = Class13.smethod_0(30841);
        strArray1[Class15.smethod_0(1)] = GClass185.string_2[this.int_2];
        strArray1[Class15.smethod_0(7)] = Class13.smethod_0(30832);
        strArray1[Class15.smethod_0(5)] = this.int_3.ToString();
        strArray1[Class15.smethod_0(2)] = Class13.smethod_0(30828);
        string s1 = string.Concat(strArray1);
        int Type1 = Class15.smethod_0(0);
        gclass730_1.method_7(s1, Type1);
        break;
      case 9:
        if ((!this.bool_1 ? 1 : 0) == 0)
        {
          this.bool_1 = Class15.smethod_0(0) != 0;
          GClass116.gclass73_0.method_7(Class13.smethod_0(30726), Class15.smethod_0(0));
          break;
        }
        if ((!this.bool_1 ? 0 : 1) != 0)
          break;
        this.bool_2 = Class15.smethod_0(1) != 0;
        this.bool_1 = Class15.smethod_0(1) != 0;
        this.int_2 = GClass185.int_37;
        this.int_3 = GClass185.int_39;
        this.int_0 = GClass20.smethod_1().cx;
        this.int_1 = GClass20.smethod_1().cy;
        GClass73 gclass730_2 = GClass116.gclass73_0;
        string[] strArray2 = new string[Class15.smethod_0(3)];
        strArray2[Class15.smethod_0(0)] = Class13.smethod_0(30826);
        strArray2[Class15.smethod_0(1)] = this.int_0.ToString();
        strArray2[Class15.smethod_0(7)] = Class13.smethod_0(30803);
        strArray2[Class15.smethod_0(5)] = this.int_1.ToString();
        strArray2[Class15.smethod_0(2)] = Class13.smethod_0(30828);
        string s2 = string.Concat(strArray2);
        int Type2 = Class15.smethod_0(0);
        gclass730_2.method_7(s2, Type2);
        break;
      case 10:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
        break;
    }
  }

  public void method_1()
  {
    GClass134 menuItems = new GClass134();
    List<GClass100> gclass100List = new List<GClass100>();
    if ((!this.bool_3 ? 1 : 0) == 0 && (!GClass116.bool_55 ? 0 : 1) == 0)
      menuItems.method_0((object) new GClass31(Class13.smethod_0(31562), (GInterface0) this, Class15.smethod_0(88), (object) null));
    for (int index1 = Class15.smethod_0(0); index1 < GClass116.gclass134_9.method_2(); index1 += Class15.smethod_0(1))
    {
      GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index1);
      if ((!gclass100.isMobMe ? 0 : 1) == 0)
      {
        bool flag = Class15.smethod_0(0) != 0;
        for (int index2 = Class15.smethod_0(0); index2 < gclass100List.Count; index2 += Class15.smethod_0(1))
        {
          if (gclass100.templateId == gclass100List[index2].templateId)
          {
            flag = Class15.smethod_0(1) != 0;
            break;
          }
        }
        if ((!flag ? 0 : 1) == 0)
        {
          gclass100List.Add(gclass100);
          GClass134 gclass134 = menuItems;
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = Class13.smethod_0(31634);
          strArray[Class15.smethod_0(1)] = gclass100.method_18().name;
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(31618);
          strArray[Class15.smethod_0(5)] = GClass138.smethod_9((long) gclass100.maxHp);
          strArray[Class15.smethod_0(2)] = Class13.smethod_0(31743);
          GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(1), (object) gclass100.templateId);
          gclass134.method_0((object) o);
        }
      }
    }
    menuItems.method_0((object) new GClass31(Class13.smethod_0(31739), (GInterface0) this, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(31683), (GInterface0) this, Class15.smethod_0(5), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(31317) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(24748) : Class13.smethod_0(31400)), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(24730), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(26274), (GInterface0) this, Class15.smethod_0(37), (object) null));
    if ((GClass20.smethod_1().mobFocus == null ? 1 : 0) == 0)
    {
      GClass134 gclass134 = menuItems;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(26353);
      strArray[Class15.smethod_0(1)] = GClass20.smethod_1().mobFocus.method_18().name;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(26925);
      strArray[Class15.smethod_0(5)] = GClass20.smethod_1().mobFocus.mobId.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(26891);
      GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(38), (object) null);
      gclass134.method_0((object) o);
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
    GClass134 menuItems = new GClass134();
    GClass134 gclass134_1 = menuItems;
    string str1 = Class13.smethod_0(27132);
    string str2;
    if ((!this.bool_1 ? 0 : 1) == 0)
    {
      str2 = Class13.smethod_0(27073);
    }
    else
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(26679);
      strArray[Class15.smethod_0(1)] = GClass185.string_2[this.int_2];
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(26653);
      strArray[Class15.smethod_0(5)] = this.int_3.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(120561);
      str2 = string.Concat(strArray);
    }
    GClass31 o1 = new GClass31(str1 + str2, (GInterface0) this, Class15.smethod_0(45), (object) null);
    gclass134_1.method_0((object) o1);
    GClass134 gclass134_2 = menuItems;
    string str3 = Class13.smethod_0(121103);
    string str4;
    if ((!this.bool_1 ? 1 : 0) == 0 && (!this.bool_2 ? 0 : 1) != 0)
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(26679);
      strArray[Class15.smethod_0(1)] = this.int_0.ToString();
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(121195);
      strArray[Class15.smethod_0(5)] = this.int_1.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(120561);
      str4 = string.Concat(strArray);
    }
    else
      str4 = Class13.smethod_0(27073);
    GClass31 o2 = new GClass31(str3 + str4, (GInterface0) this, Class15.smethod_0(31), (object) null);
    gclass134_2.method_0((object) o2);
    menuItems.method_0((object) new GClass31(Class13.smethod_0(121270) + this.int_4.ToString() + Class13.smethod_0(157407), (GInterface0) this, Class15.smethod_0(67), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_3(int int_5, int int_6)
  {
    GClass20.smethod_1().cx = int_5;
    GClass20.smethod_1().cy = int_6;
    GClass156.smethod_0().method_45();
    GClass20.smethod_1().cx = int_5;
    GClass20.smethod_1().cy = int_6 + Class15.smethod_0(1);
    GClass156.smethod_0().method_45();
    GClass20.smethod_1().cx = int_5;
    GClass20.smethod_1().cy = int_6;
    GClass156.smethod_0().method_45();
  }

  private bool method_4(GClass100 gclass100_0)
  {
    if ((!GClass116.bool_55 ? 0 : 1) != 0 || (!gclass100_0.method_21() ? 1 : 0) != 0)
      return Class15.smethod_0(1) != 0;
    return (!gclass100_0.method_21() ? 1 : 0) == 0 ? this.bool_0 : Class15.smethod_0(0) != 0;
  }

  private bool method_5() => GClass20.smethod_1().cMP < GClass20.smethod_1().cMPFull * this.int_4 / Class15.smethod_0(21);

  private GClass100 method_6(int int_5)
  {
    if (int_5 == Class15.smethod_0(1))
    {
      long num = GClass126.smethod_18();
      GClass100 gclass100_1 = (GClass100) null;
      for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
      {
        GClass100 gclass100_2 = (GClass100) GClass116.gclass134_9.method_3(this.list_0[index]);
        long cTimeDie = gclass100_2.cTimeDie;
        if ((!gclass100_2.isMobMe ? 0 : 1) == 0 && cTimeDie < num)
        {
          gclass100_1 = gclass100_2;
          num = cTimeDie;
        }
      }
      return gclass100_1;
    }
    GClass100 gclass100 = (GClass100) null;
    int num1 = Class15.smethod_0(79);
    for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
    {
      GClass100 gclass100_0 = (GClass100) GClass116.gclass134_9.method_3(this.list_0[index]);
      if ((gclass100_0.status == 0 ? 1 : 0) == 0 && gclass100_0.status != Class15.smethod_0(1) && gclass100_0.hp > Class15.smethod_0(0) && (!gclass100_0.isMobMe ? 0 : 1) == 0 && (!this.method_4(gclass100_0) ? 1 : 0) == 0)
      {
        int num2 = GClass93.smethod_0(GClass20.smethod_1().cx - gclass100_0.x);
        if (num1 > num2)
        {
          gclass100 = gclass100_0;
          num1 = num2;
        }
      }
    }
    return gclass100;
  }

  private void method_7()
  {
    if ((this.list_0.Count == 0 ? 0 : 1) == 0)
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(157908), Class15.smethod_0(0));
      this.bool_3 = Class15.smethod_0(0) != 0;
    }
    else
    {
      this.bool_3 = (!GClass116.bool_55 ? 0 : 1) != 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
      GClass116.bool_54 = Class15.smethod_0(1) != 0;
    }
  }

  private void method_8()
  {
    if (!this.bool_3 && !GClass116.bool_55 || GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3))
      return;
    if (this.list_0.Count == 0)
    {
      if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(14))
      {
        this.long_0 = GClass126.smethod_18();
        GClass116.gclass73_0.method_7(Class13.smethod_0(158511), Class15.smethod_0(0));
      }
      this.bool_3 = Class15.smethod_0(0) != 0;
    }
    else
    {
      if (GClass20.smethod_1().mobFocus != null && (GClass20.smethod_1().mobFocus == null || !GClass20.smethod_1().mobFocus.isMobMe))
      {
        if (GClass20.smethod_1().mobFocus.hp <= Class15.smethod_0(0) || GClass20.smethod_1().mobFocus.status == Class15.smethod_0(1) || GClass20.smethod_1().mobFocus.status == 0 || !this.method_4(GClass20.smethod_1().mobFocus))
          GClass20.smethod_1().mobFocus = (GClass100) null;
      }
      else
      {
        if (!GClass116.bool_55 && GClass11.gclass11_0.method_12())
        {
          GClass11.gclass11_0.method_4();
          if (GClass20.smethod_1().itemFocus != null)
          {
            GClass11.gclass11_0.method_5();
            GClass11.gclass11_0.method_4();
          }
        }
        else
          GClass20.smethod_1().itemFocus = (GClass81) null;
        if (GClass20.smethod_1().itemFocus == null)
        {
          GClass100 gclass100_1 = this.method_6(Class15.smethod_0(0));
          if (gclass100_1 == null)
          {
            GClass100 gclass100_2 = this.method_6(Class15.smethod_0(1));
            if (GClass116.bool_55)
            {
              GClass20.smethod_1().cx = gclass100_2.xFirst;
              GClass20.smethod_1().cy = gclass100_2.yFirst;
              GClass156.smethod_0().method_45();
            }
            else if (gclass100_2.xFirst > GClass20.smethod_1().cx && GClass20.smethod_1().cdir == Class15.smethod_0(1) && GClass185.smethod_27(GClass20.smethod_1().cx + GClass20.smethod_1().chw, GClass20.smethod_1().cy - GClass20.smethod_1().chh, Class15.smethod_0(2)))
              GClass20.smethod_1().currentMovePoint = new GClass108(GClass20.smethod_1().cx + Class15.smethod_0(51), this.method_10(GClass20.smethod_1().cx + Class15.smethod_0(51)));
            else if (gclass100_2.xFirst < GClass20.smethod_1().cx && GClass20.smethod_1().cdir == -1 && GClass185.smethod_27(GClass20.smethod_1().cx - GClass20.smethod_1().chw - Class15.smethod_0(1), GClass20.smethod_1().cy - GClass20.smethod_1().chh, Class15.smethod_0(88)))
            {
              GClass20.smethod_1().currentMovePoint = new GClass108(GClass20.smethod_1().cx - Class15.smethod_0(51), this.method_10(GClass20.smethod_1().cx - Class15.smethod_0(51)));
            }
            else
            {
              GClass20.smethod_1().currentMovePoint = new GClass108(gclass100_2.xFirst, gclass100_2.yFirst);
              GClass20.smethod_1().endMovePointCommand = new GClass31((string) null, (GInterface0) null, Class15.smethod_0(93), (object) null);
            }
          }
          else
          {
            GClass20.smethod_1().mobFocus = gclass100_1;
            if (GClass116.bool_55)
            {
              GClass20.smethod_1().cx = gclass100_1.x;
              GClass20.smethod_1().cy = gclass100_1.y;
              GClass156.smethod_0().method_45();
            }
          }
        }
      }
      if (GClass20.smethod_1().mobFocus == null || GClass20.smethod_1().method_71() != null && GClass20.smethod_1().indexSkill < GClass20.smethod_1().method_71().Length && GClass20.smethod_1().dart != null && GClass20.smethod_1().arr != null)
        return;
      if (GClass20.smethod_1().mobFocus != null && GClass116.bool_55 && (GClass93.smethod_0(GClass20.smethod_1().mobFocus.x - GClass20.smethod_1().cx) > Class15.smethod_0(21) || GClass93.smethod_0(GClass20.smethod_1().mobFocus.y - GClass20.smethod_1().cy) > Class15.smethod_0(21)) && GClass126.smethod_18() - this.long_1 > (long) Class15.smethod_0(21))
      {
        this.long_1 = GClass126.smethod_18();
        GClass20.smethod_1().cx = GClass20.smethod_1().mobFocus.x;
        GClass20.smethod_1().cy = GClass20.smethod_1().mobFocus.y;
        GClass156.smethod_0().method_45();
      }
      GClass161 skill = (GClass161) null;
      for (int index = Class15.smethod_0(0); index < GClass116.gclass161_0.Length; index += Class15.smethod_0(1))
      {
        if (GClass116.gclass161_0[index] != null && !GClass116.gclass161_0[index].paintCanNotUseSkill && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(31) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(67) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(49) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(29) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(38) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(5) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(1) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(3) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(51) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(45) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(28) && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(124) && (GClass20.smethod_1().cgender != Class15.smethod_0(1) || GClass20.smethod_1().cgender == Class15.smethod_0(1) && (GClass20.smethod_1().method_12(GClass20.smethod_1().nClass.skillTemplates[Class15.smethod_0(3)]) == null || GClass20.smethod_1().method_12(GClass20.smethod_1().nClass.skillTemplates[Class15.smethod_0(3)]) != null && (int) GClass116.gclass161_0[index].template.id != Class15.smethod_0(7))) && GClass20.smethod_1().method_71() == null)
        {
          int num = GClass116.gclass161_0[index].template.manaUseType == Class15.smethod_0(7) ? Class15.smethod_0(1) : (GClass116.gclass161_0[index].template.manaUseType == Class15.smethod_0(1) ? GClass116.gclass161_0[index].manaUse * GClass20.smethod_1().cMPFull / Class15.smethod_0(21) : GClass116.gclass161_0[index].manaUse);
          if (GClass20.smethod_1().cMP >= num)
          {
            if (skill == null)
              skill = GClass116.gclass161_0[index];
            else if (skill.coolDown < GClass116.gclass161_0[index].coolDown)
              skill = GClass116.gclass161_0[index];
          }
        }
      }
      if (skill == null)
        return;
      GClass116.smethod_6().method_61(skill, Class15.smethod_0(1) != 0);
      GClass116.smethod_6().method_43((GInterface3) GClass20.smethod_1().mobFocus);
    }
  }

  private void method_9()
  {
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
      if ((gclass80 == null ? 1 : 0) == 0 && (int) gclass80.template.id == Class15.smethod_0(126))
      {
        GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) gclass80.indexUI, (short) -1);
        return;
      }
    }
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
      if ((gclass80 == null ? 1 : 0) == 0 && (int) gclass80.template.id == Class15.smethod_0((int) sbyte.MaxValue))
      {
        GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) gclass80.indexUI, (short) -1);
        break;
      }
    }
  }

  private int method_10(int int_5)
  {
    int py = Class15.smethod_0(32);
    int num = Class15.smethod_0(0);
    while (num < Class15.smethod_0(6))
    {
      num += Class15.smethod_0(1);
      py += Class15.smethod_0(40);
      if ((!GClass185.smethod_27(int_5, py, Class15.smethod_0(7)) ? 1 : 0) == 0)
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

  public bool method_11() => this.bool_3;
}
