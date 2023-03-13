// Decompiled with JetBrains decompiler
// Type: GClass11
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;

public class GClass11 : GInterface0, GInterface1
{
  public static GClass11 gclass11_0 = new GClass11();
  private bool bool_0;
  private long long_0;
  private int int_0;
  private bool bool_1;
  private bool bool_2;
  private int int_1;
  private List<int> list_0;
  private string[] string_0;
  private string[] string_1;
  private long long_1;

  public GClass11()
  {
    this.int_0 = Class15.smethod_0(32);
    this.list_0 = new List<int>();
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(28934);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(29665);
    this.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(29637);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(29232);
    this.string_1 = strArray2;
  }

  public void method_0()
  {
    if ((!GClass116.bool_54 ? 1 : 0) == 0 && ((!GClass116.bool_55 ? 0 : 1) != 0 || (!GClass15.gclass15_0.method_11() ? 0 : 1) != 0) || (!this.bool_0 ? 0 : 1) == 0)
      return;
    this.method_4();
    if ((GClass20.smethod_1().itemFocus == null ? 1 : 0) != 0)
      return;
    this.method_5();
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
          int num = this.int_0 = int.Parse(gclass23.tfChat.method_21());
          GClass116.gclass73_0.method_7(Class13.smethod_0(29229) + num.ToString(), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29284), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_1[Class15.smethod_0(0)]) ? 1 : 0) != 0)
          return;
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          this.list_0.Add(num);
          GClass116.gclass73_0.method_7(Class13.smethod_0(29364) + num.ToString(), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29284), Class15.smethod_0(0));
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
        this.bool_0 = (this.bool_0 ? 1 : 0) == Class15.smethod_0(0);
        this.int_1 = Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(29970) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(30055) : Class13.smethod_0(29957)), Class15.smethod_0(0));
        break;
      case 1:
        this.bool_2 = (this.bool_2 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(30050) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(30055) : Class13.smethod_0(29957)), Class15.smethod_0(0));
        break;
      case 2:
        this.bool_0 = (this.bool_0 ? 1 : 0) == Class15.smethod_0(0);
        this.int_1 = Class15.smethod_0(1);
        GClass116.gclass73_0.method_7(Class13.smethod_0(30031) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(30055) : Class13.smethod_0(29957)), Class15.smethod_0(0));
        break;
      case 3:
        this.bool_1 = (this.bool_1 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(30135) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(30055) : Class13.smethod_0(29957)), Class15.smethod_0(0));
        break;
      case 4:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 5:
        if ((this.list_0.Count == 0 ? 0 : 1) == 0)
          GClass116.gclass73_0.method_7(Class13.smethod_0(30188), Class15.smethod_0(0));
        if (this.list_0.Count <= Class15.smethod_0(0))
          break;
        string s1 = "";
        for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
          s1 = s1 + this.list_0[index].ToString() + Class13.smethod_0(29751);
        GClass116.gclass73_0.method_7(s1, Class15.smethod_0(0));
        break;
      case 6:
        this.list_0.Clear();
        GClass116.gclass73_0.method_7(Class13.smethod_0(29730), Class15.smethod_0(0));
        break;
      case 7:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_1[Class15.smethod_0(0)], this.string_1[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 8:
        this.list_0.Add((int) GClass20.smethod_1().itemFocus.template.id);
        GClass73 gclass730 = GClass116.gclass73_0;
        string[] strArray = new string[Class15.smethod_0(3)];
        strArray[Class15.smethod_0(0)] = Class13.smethod_0(29778);
        strArray[Class15.smethod_0(1)] = GClass20.smethod_1().itemFocus.template.name;
        strArray[Class15.smethod_0(7)] = Class13.smethod_0(29870);
        strArray[Class15.smethod_0(5)] = GClass20.smethod_1().itemFocus.template.id.ToString();
        strArray[Class15.smethod_0(2)] = Class13.smethod_0(29842);
        string s2 = string.Concat(strArray);
        int Type = Class15.smethod_0(0);
        gclass730.method_7(s2, Type);
        break;
      case 9:
        this.method_11();
        break;
    }
  }

  public void method_1()
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30548) + ((!this.bool_0 ? 1 : 0) != 0 || (this.int_1 == 0 ? 1 : 0) == 0 ? Class13.smethod_0(30655) : Class13.smethod_0(31623)), (GInterface0) this, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(25063) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(31623) : Class13.smethod_0(30655)), (GInterface0) this, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(25044) + ((!this.bool_0 ? 1 : 0) != 0 || this.int_1 != Class15.smethod_0(1) ? Class13.smethod_0(30655) : Class13.smethod_0(31623)), (GInterface0) this, Class15.smethod_0(5), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(24636) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(31623) : Class13.smethod_0(30655)), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(24616) + this.int_0.ToString() + Class13.smethod_0(24579), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(24697), (GInterface0) this, Class15.smethod_0(37), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(26237), (GInterface0) this, Class15.smethod_0(38), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(26200), (GInterface0) this, Class15.smethod_0(31), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27001), (GInterface0) this, Class15.smethod_0(88), (object) null));
    if ((GClass20.smethod_1().itemFocus == null ? 1 : 0) == 0)
    {
      GClass134 gclass134 = menuItems;
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(26988);
      strArray[Class15.smethod_0(1)] = GClass20.smethod_1().itemFocus.template.name;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(26980);
      strArray[Class15.smethod_0(5)] = GClass20.smethod_1().itemFocus.template.id.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(26977);
      GClass31 o = new GClass31(string.Concat(strArray), (GInterface0) this, Class15.smethod_0(45), (object) null);
      gclass134.method_0((object) o);
    }
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
  }

  private void method_3()
  {
  }

  public void method_4()
  {
    if ((GClass20.smethod_1().itemFocus == null ? 1 : 0) == 0)
      return;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
    {
      GClass81 gclass81_0 = (GClass81) GClass116.gclass134_6.method_3(index);
      int num1 = GClass93.smethod_0(GClass20.smethod_1().cx - gclass81_0.x);
      int num2 = GClass93.smethod_0(GClass20.smethod_1().cy - gclass81_0.y);
      int int0 = this.int_0;
      if (num1 <= int0 && num2 <= this.int_0 && (!this.method_7(gclass81_0) ? 1 : 0) == 0 && (int) gclass81_0.template.id != Class15.smethod_0(91))
      {
        GClass20.smethod_1().itemFocus = gclass81_0;
        break;
      }
    }
  }

  public void method_5()
  {
    if (GClass126.smethod_18() - this.long_0 < (long) Class15.smethod_0(92) || (GClass20.smethod_1().itemFocus == null ? 0 : 1) == 0)
      return;
    if ((!this.bool_1 ? 1 : 0) == 0 && (!GClass20.bool_3 ? 0 : 1) == 0)
    {
      this.method_6(GClass20.smethod_1().itemFocus.x, GClass20.smethod_1().itemFocus.y);
      GClass62.smethod_25();
      GClass62.smethod_24();
      if ((int) GClass20.smethod_1().itemFocus.template.id == Class15.smethod_0(91))
        return;
      GClass156.smethod_0().method_75(GClass20.smethod_1().itemFocus.itemMapID);
      this.long_0 = GClass126.smethod_18();
    }
    else
    {
      GClass20.smethod_1().cdir = GClass20.smethod_1().cx >= GClass20.smethod_1().itemFocus.x ? -1 : Class15.smethod_0(1);
      int num1 = GClass93.smethod_0(GClass20.smethod_1().cx - GClass20.smethod_1().itemFocus.x);
      int num2 = GClass93.smethod_0(GClass20.smethod_1().cy - GClass20.smethod_1().itemFocus.y);
      int num3 = Class15.smethod_0(54);
      if (num1 <= num3 && num2 < Class15.smethod_0(54))
      {
        GClass62.smethod_25();
        GClass62.smethod_24();
        if ((int) GClass20.smethod_1().itemFocus.template.id == Class15.smethod_0(91))
          return;
        GClass156.smethod_0().method_75(GClass20.smethod_1().itemFocus.itemMapID);
        this.long_0 = GClass126.smethod_18();
      }
      else
      {
        GClass20.smethod_1().currentMovePoint = new GClass108(GClass20.smethod_1().itemFocus.x, GClass20.smethod_1().itemFocus.y);
        GClass20.smethod_1().endMovePointCommand = new GClass31((string) null, (GInterface0) null, Class15.smethod_0(93), (object) null);
        GClass62.smethod_25();
        GClass62.smethod_24();
      }
    }
  }

  private void method_6(int int_2, int int_3)
  {
    GClass20.smethod_1().cx = int_2;
    GClass20.smethod_1().cy = int_3;
    GClass156.smethod_0().method_45();
    GClass20.smethod_1().cx = int_2;
    GClass20.smethod_1().cy = int_3 + Class15.smethod_0(1);
    GClass156.smethod_0().method_45();
    GClass20.smethod_1().cx = int_2;
    GClass20.smethod_1().cy = int_3;
    GClass156.smethod_0().method_45();
  }

  private bool method_7(GClass81 gclass81_0)
  {
    if ((!this.bool_2 ? 1 : 0) == 0)
      return Class15.smethod_0(1) != 0;
    if ((this.int_1 == 0 ? 0 : 1) == 0)
      return gclass81_0.playerId != GClass20.smethod_1().charID ? gclass81_0.playerId == -1 : Class15.smethod_0(1) != 0;
    if (this.int_1 != Class15.smethod_0(1) || (!this.list_0.Contains((int) gclass81_0.template.id) ? 1 : 0) != 0)
      return Class15.smethod_0(0) != 0;
    return gclass81_0.playerId != GClass20.smethod_1().charID ? gclass81_0.playerId == -1 : Class15.smethod_0(1) != 0;
  }

  private bool method_8(int int_2) => int_2 >= Class15.smethod_0(81) ? (int_2 > Class15.smethod_0(82) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  private bool method_9(GClass81 gclass81_0) => (int) gclass81_0.template.id >= Class15.smethod_0(83) ? ((int) gclass81_0.template.id > Class15.smethod_0(84) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;

  private void method_10()
  {
    try
    {
      if (GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3) || GClass20.smethod_1().cHP <= Class15.smethod_0(0))
        return;
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
      {
        GClass81 gclass81_0 = (GClass81) GClass116.gclass134_6.method_3(index);
        int num1 = GClass93.smethod_0(GClass20.smethod_1().cx - gclass81_0.x);
        int num2 = GClass93.smethod_0(GClass20.smethod_1().cy - gclass81_0.y);
        if ((gclass81_0 == null ? 1 : 0) == 0 && (!this.method_9(gclass81_0) ? 1 : 0) == 0)
        {
          if (num1 <= Class15.smethod_0(4) && num2 <= Class15.smethod_0(4))
          {
            if (GClass126.smethod_18() - this.long_0 <= (long) Class15.smethod_0(92))
              break;
            GClass156.smethod_0().method_75(gclass81_0.itemMapID);
            this.long_0 = GClass126.smethod_18();
            break;
          }
          if ((!GClass20.bool_3 ? 0 : 1) != 0 || GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3) || GClass126.smethod_18() - this.long_1 <= (long) Class15.smethod_0(21))
            break;
          this.long_1 = GClass126.smethod_18();
          this.method_6(gclass81_0.x, gclass81_0.y);
          break;
        }
      }
    }
    catch
    {
    }
  }

  private void method_11()
  {
    try
    {
      string str = "";
      for (short id = (short) Class15.smethod_0(0); (int) id < GClass86.gclass128_0.method_3(); id += (short) Class15.smethod_0(1))
      {
        try
        {
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = str;
          strArray[Class15.smethod_0(1)] = id.ToString();
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(27076);
          strArray[Class15.smethod_0(5)] = GClass86.smethod_1(id).name.Replace(Class13.smethod_0(26683), Class13.smethod_0(26681));
          strArray[Class15.smethod_0(2)] = Class13.smethod_0(26683);
          str = string.Concat(strArray);
        }
        catch
        {
        }
      }
      string chat = str.Trim().Replace(Class13.smethod_0(26683), Class13.smethod_0(26689)).Replace(Class13.smethod_0(26681), Class13.smethod_0(26683));
      if ((!(chat != "") ? 1 : 0) != 0)
        return;
      GClass43.smethod_1(chat, Class15.smethod_0(17), new GClass21(-1, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0)));
      GClass43.gclass43_1.cmdMsg1 = new GClass31(GClass109.string_125, (GInterface0) GClass43.gclass43_1, Class15.smethod_0(94), (object) null);
      GClass43.gclass43_1.cmdMsg1.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(95);
      GClass43.gclass43_1.cmdMsg1.y = GClass62.int_11 - Class15.smethod_0(95);
    }
    catch
    {
    }
  }

  public bool method_12() => this.bool_0;

  public void method_13(bool isAutoPick) => this.bool_0 = isAutoPick;
}
