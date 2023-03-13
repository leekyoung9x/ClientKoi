// Decompiled with JetBrains decompiler
// Type: GClass10
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass10 : GInterface0, GInterface1
{
  public static GClass10 gclass10_0 = new GClass10();
  private bool bool_0;
  private long long_0;
  private bool bool_1;
  private bool bool_2;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private bool bool_3;
  private string[] string_0;
  private string[] string_1;
  private string[] string_2;
  private string[] string_3;
  private bool bool_4;

  public GClass10()
  {
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(29063);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(30696);
    this.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(30252);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(30302);
    this.string_1 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(7)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(30279);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(30359);
    this.string_2 = strArray3;
    string[] strArray4 = new string[Class15.smethod_0(7)];
    strArray4[Class15.smethod_0(0)] = Class13.smethod_0(31843);
    strArray4[Class15.smethod_0(1)] = Class13.smethod_0(31828);
    this.string_3 = strArray4;
    this.method_2();
  }

  public void method_0()
  {
    if ((!this.bool_4 ? 1 : 0) == 0 && (!GClass20.smethod_1().havePet ? 1 : 0) == 0)
    {
      int num = GClass62.int_8 % Class15.smethod_0(51);
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      this.method_4();
    if ((!this.bool_1 ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
      this.method_5();
    if ((!this.bool_2 ? 1 : 0) == 0)
      this.method_6();
    if ((!GClass20.smethod_1().meDead ? 0 : 1) != 0)
      return;
    this.method_7();
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
          int num = int.Parse(gclass23.tfChat.method_21());
          if (num >= Class15.smethod_0(21))
            num = Class15.smethod_0(87);
          if (num <= Class15.smethod_0(0))
            num = Class15.smethod_0(1);
          this.int_0 = num;
          GClass116.gclass73_0.method_7(Class13.smethod_0(31910) + num.ToString() + Class13.smethod_0(31952), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) == 0)
            GClass152.smethod_9(Class13.smethod_0(25475), this.int_0);
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(25585), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_1[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (num >= Class15.smethod_0(21))
            num = Class15.smethod_0(87);
          if (num <= Class15.smethod_0(0))
            num = Class15.smethod_0(1);
          this.int_1 = num;
          GClass116.gclass73_0.method_7(Class13.smethod_0(25539) + num.ToString() + Class13.smethod_0(31952), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) == 0)
            GClass152.smethod_9(Class13.smethod_0(25128), this.int_1);
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(25108), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_2[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int m = this.int_2 = int.Parse(gclass23.tfChat.method_21());
          if ((!this.bool_3 ? 1 : 0) == 0)
            GClass152.smethod_4(Class13.smethod_0(25188), this.int_2.ToString());
          GClass116.gclass73_0.method_7(Class13.smethod_0(31910) + GClass138.smethod_9((long) m) + Class13.smethod_0(25177), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(25174), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_3[Class15.smethod_0(0)]) ? 0 : 1) == 0)
          return;
        try
        {
          int m = this.int_3 = int.Parse(gclass23.tfChat.method_21());
          if ((!this.bool_3 ? 1 : 0) == 0)
            GClass152.smethod_4(Class13.smethod_0(25257), this.int_3.ToString());
          GClass116.gclass73_0.method_7(Class13.smethod_0(25539) + GClass138.smethod_9((long) m) + Class13.smethod_0(25246), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(25224), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
    }
    else
      GClass13.gclass13_0.method_12();
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
        GClass116.gclass73_0.method_7(Class13.smethod_0(26547) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(26516) : Class13.smethod_0(26522)), Class15.smethod_0(0));
        if ((!this.bool_3 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(26511), (!this.bool_0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 1:
        this.bool_1 = (this.bool_1 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(26583) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(26516) : Class13.smethod_0(26522)), Class15.smethod_0(0));
        if ((!this.bool_3 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(26170), (!this.bool_1 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 2:
        this.bool_2 = (this.bool_2 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(26133) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(26516) : Class13.smethod_0(26522)), Class15.smethod_0(0));
        if ((!this.bool_3 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(26251), (!this.bool_2 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 3:
        if ((this.int_2 == 0 ? 1 : 0) == 0)
        {
          this.int_2 = Class15.smethod_0(0);
          GClass116.gclass73_0.method_7(Class13.smethod_0(26339), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) != 0)
            break;
          GClass152.smethod_4(Class13.smethod_0(27588), this.int_2.ToString());
          break;
        }
        if ((this.int_2 == 0 ? 0 : 1) != 0)
          break;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_2[Class15.smethod_0(0)], this.string_2[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 4:
        if ((this.int_0 == 0 ? 1 : 0) == 0)
        {
          this.int_0 = Class15.smethod_0(0);
          GClass116.gclass73_0.method_7(Class13.smethod_0(27193), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) != 0)
            break;
          GClass152.smethod_9(Class13.smethod_0(27174), this.int_0);
          break;
        }
        if ((this.int_0 == 0 ? 0 : 1) != 0)
          break;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 5:
        if ((this.int_3 == 0 ? 1 : 0) == 0)
        {
          this.int_3 = Class15.smethod_0(0);
          GClass116.gclass73_0.method_7(Class13.smethod_0(27136), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) != 0)
            break;
          GClass152.smethod_4(Class13.smethod_0(27247), this.int_3.ToString());
          break;
        }
        if ((this.int_3 == 0 ? 0 : 1) != 0)
          break;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_3[Class15.smethod_0(0)], this.string_3[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 6:
        if ((this.int_1 == 0 ? 1 : 0) == 0)
        {
          this.int_1 = Class15.smethod_0(0);
          GClass116.gclass73_0.method_7(Class13.smethod_0(27230), Class15.smethod_0(0));
          if ((!this.bool_3 ? 1 : 0) != 0)
            break;
          GClass152.smethod_9(Class13.smethod_0(27201), this.int_1);
          break;
        }
        if ((this.int_1 == 0 ? 0 : 1) != 0)
          break;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_1[Class15.smethod_0(0)], this.string_1[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 7:
        this.bool_3 = (this.bool_3 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(27301) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(26516) : Class13.smethod_0(26522)), Class15.smethod_0(0));
        GClass152.smethod_9(Class13.smethod_0(27378), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        if ((!this.bool_3 ? 1 : 0) != 0)
          break;
        this.method_3();
        break;
      case 8:
        this.bool_4 = (this.bool_4 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(27360) + ((!this.bool_4 ? 0 : 1) != 0 ? Class13.smethod_0(26516) : Class13.smethod_0(26522)), Class15.smethod_0(0));
        break;
    }
  }

  public void method_1()
  {
    this.method_2();
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28568) + ((!this.bool_4 ? 0 : 1) != 0 ? Class13.smethod_0(28661) : Class13.smethod_0(28667)), (GInterface0) this, Class15.smethod_0(45), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28654) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(28661) : Class13.smethod_0(28667)), (GInterface0) this, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28642) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(28661) : Class13.smethod_0(28667)), (GInterface0) this, Class15.smethod_0(7), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28628) + ((!this.bool_2 ? 0 : 1) != 0 ? Class13.smethod_0(28661) : Class13.smethod_0(28667)), (GInterface0) this, Class15.smethod_0(5), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28616) + GClass138.smethod_9((long) this.int_2) + Class13.smethod_0(28204), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28616) + this.int_0.ToString() + Class13.smethod_0(28201), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28199) + GClass138.smethod_9((long) this.int_3) + Class13.smethod_0(28171), (GInterface0) this, Class15.smethod_0(37), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28199) + this.int_1.ToString() + Class13.smethod_0(28201), (GInterface0) this, Class15.smethod_0(38), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28164) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(28661) : Class13.smethod_0(28667)), (GInterface0) this, Class15.smethod_0(88), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
    this.bool_3 = GClass152.smethod_8(Class13.smethod_0(28238)) == Class15.smethod_0(1);
    if ((!this.bool_3 ? 1 : 0) != 0)
      return;
    this.bool_0 = GClass152.smethod_8(Class13.smethod_0(20769)) == Class15.smethod_0(1);
    this.bool_1 = GClass152.smethod_8(Class13.smethod_0(20743)) == Class15.smethod_0(1);
    this.bool_2 = GClass152.smethod_8(Class13.smethod_0(20924)) == Class15.smethod_0(1);
    this.int_0 = GClass152.smethod_8(Class13.smethod_0(20866)) != -1 ? GClass152.smethod_8(Class13.smethod_0(20866)) : Class15.smethod_0(0);
    this.int_1 = GClass152.smethod_8(Class13.smethod_0(20976)) != -1 ? GClass152.smethod_8(Class13.smethod_0(20976)) : Class15.smethod_0(0);
    this.int_2 = (GClass152.smethod_2(Class13.smethod_0(20938)) == null ? 0 : 1) != 0 ? int.Parse(GClass152.smethod_2(Class13.smethod_0(20938))) : Class15.smethod_0(0);
    if ((GClass152.smethod_2(Class13.smethod_0(20543)) == null ? 0 : 1) == 0)
      this.int_3 = Class15.smethod_0(0);
    else
      this.int_3 = int.Parse(GClass152.smethod_2(Class13.smethod_0(20543)));
  }

  private void method_3()
  {
    GClass152.smethod_9(Class13.smethod_0(20509), (!this.bool_0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(20595), (!this.bool_1 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(20572), (!this.bool_2 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_4(Class13.smethod_0(20653), this.int_2.ToString());
    GClass152.smethod_9(Class13.smethod_0(21275), this.int_0);
    GClass152.smethod_4(Class13.smethod_0(21328), this.int_3.ToString());
    GClass152.smethod_9(Class13.smethod_0(21477), this.int_1);
  }

  private void method_4()
  {
    if (GClass126.smethod_18() - this.long_0 < (long) Class15.smethod_0(89))
      return;
    this.long_0 = GClass126.smethod_18();
    GClass156.smethod_0().method_20(Class15.smethod_0(1), "", -1);
  }

  private void method_5()
  {
    for (int index = Class15.smethod_0(0); index < GClass28.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass28 gclass28 = (GClass28) GClass28.gclass134_0.method_3(index);
      if ((gclass28.maxCap == 0 ? 1 : 0) == 0 && (!(gclass28.playerName != GClass20.smethod_1().cName) ? 1 : 0) == 0 && gclass28.recieve != gclass28.maxCap)
      {
        GClass156.smethod_0().method_19(gclass28.id);
        break;
      }
    }
  }

  private void method_6()
  {
    if (GClass185.int_37 != Class15.smethod_0(27) && GClass185.int_37 != Class15.smethod_0(28) && GClass185.int_37 != Class15.smethod_0(29))
      return;
    int num = Class15.smethod_0(0);
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBox.Length; index += Class15.smethod_0(1))
    {
      if ((GClass20.smethod_1().arrItemBox[index] == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().arrItemBox[index].template.type == Class15.smethod_0(37))
        num += GClass20.smethod_1().arrItemBox[index].quantity;
    }
    if (num < Class15.smethod_0(51) && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
    {
      for (int id = Class15.smethod_0(0); id < GClass20.smethod_1().arrItemBag.Length; id += Class15.smethod_0(1))
      {
        if ((GClass20.smethod_1().arrItemBag[id] == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().arrItemBag[id].template.type == Class15.smethod_0(37))
        {
          GClass156.smethod_0().method_31((sbyte) Class15.smethod_0(1), (sbyte) id);
          break;
        }
      }
    }
    if (GClass116.smethod_6().magicTree.currPeas <= Class15.smethod_0(0) || GClass116.int_37 >= Class15.smethod_0(31) && num >= Class15.smethod_0(51) || (GClass62.int_8 % Class15.smethod_0(90) == 0 ? 0 : 1) != 0)
      return;
    GClass156.smethod_0().method_61(Class15.smethod_0(2));
    GClass156.smethod_0().method_62(Class15.smethod_0(2), Class15.smethod_0(0), Class15.smethod_0(0));
  }

  private void method_7()
  {
    if (GClass116.int_37 <= Class15.smethod_0(0))
      return;
    if ((this.int_0 == 0 ? 1 : 0) == 0 && (!this.method_10(this.int_2, this.int_0) ? 1 : 0) == 0 && (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) == 0)
    {
      GClass116.smethod_6().method_49();
    }
    else
    {
      if ((this.int_1 == 0 ? 1 : 0) != 0 || (!this.method_11(this.int_3, this.int_1) ? 1 : 0) != 0 || (GClass62.int_8 % Class15.smethod_0(51) == 0 ? 0 : 1) != 0)
        return;
      GClass116.smethod_6().method_49();
    }
  }

  private int method_8() => (int) ((long) GClass20.smethod_1().cHP * (long) Class15.smethod_0(21) / (long) GClass20.smethod_1().cHPFull);

  private int method_9() => (int) ((long) GClass20.smethod_1().cMP * (long) Class15.smethod_0(21) / (long) GClass20.smethod_1().cMPFull);

  private bool method_10(int int_4, int int_5)
  {
    if (GClass20.smethod_1().cHP <= Class15.smethod_0(0))
      return Class15.smethod_0(0) != 0;
    return this.method_8() > int_5 ? GClass20.smethod_1().cHP < int_4 : Class15.smethod_0(1) != 0;
  }

  private bool method_11(int int_4, int int_5)
  {
    if (GClass20.smethod_1().cHP <= Class15.smethod_0(0))
      return Class15.smethod_0(0) != 0;
    return this.method_9() > int_5 ? GClass20.smethod_1().cMP < int_4 : Class15.smethod_0(1) != 0;
  }
}
