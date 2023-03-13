// Decompiled with JetBrains decompiler
// Type: GClass4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;
using System.IO;

public class GClass4 : GInterface0, GInterface1
{
  public static GClass4 gclass4_0 = new GClass4();
  private bool bool_0;
  private long long_0;
  private long long_1;
  private string string_0;
  private bool bool_1;
  private long long_2;
  private long long_3;
  private string string_1;
  private int int_0;
  private int int_1;
  private bool bool_2;
  private int int_2;
  private int int_3;
  private bool bool_3;
  private List<int> list_0;
  private string string_2;
  private long long_4;
  private int int_4;
  private bool bool_4;
  private string[] string_3;
  private string[] string_4;
  private string[] string_5;

  public GClass4()
  {
    this.list_0 = new List<int>();
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(28679);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(29347);
    this.string_3 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(29325);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(29347);
    this.string_4 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(7)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(29421);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(29398);
    this.string_5 = strArray3;
    this.method_2();
  }

  public void method_0()
  {
    if ((!this.bool_0 ? 1 : 0) == 0)
      this.method_4();
    if ((!this.bool_1 ? 1 : 0) == 0)
      this.method_5();
    if ((!this.bool_2 ? 1 : 0) == 0)
      this.method_6();
    if ((!this.bool_3 ? 1 : 0) != 0)
      return;
    this.method_7();
  }

  public void imethod_1(string text, string to)
  {
    GClass23 gclass23 = GClass13.gclass13_0.method_31();
    if ((gclass23.tfChat.method_21() == null ? 1 : 0) == 0 && (!gclass23.tfChat.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0 && (text == null ? 0 : 1) != 0)
    {
      if ((!gclass23.strChat.Equals(this.string_3[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        Class15.smethod_0(0);
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (num > Class15.smethod_0(0))
          {
            try
            {
              this.string_0 = File.ReadAllText(Class13.smethod_0(30079));
              this.long_0 = (long) num;
              this.bool_0 = Class15.smethod_0(1) != 0;
              GClass116.gclass73_0.method_7(Class13.smethod_0(30115) + (this.long_0 >= (long) Class15.smethod_0(14) ? GClass138.smethod_9(this.long_0) : Class13.smethod_0(30103)) + Class13.smethod_0(30097), Class15.smethod_0(0));
              if ((!this.bool_4 ? 1 : 0) == 0)
              {
                GClass152.smethod_9(Class13.smethod_0(30085), Class15.smethod_0(1));
                GClass152.smethod_4(Class13.smethod_0(30168), this.long_0.ToString());
              }
            }
            catch
            {
              GClass116.gclass73_0.method_7(Class13.smethod_0(29749), Class15.smethod_0(0));
            }
          }
          if (num <= Class15.smethod_0(0))
            GClass62.smethod_28(Class13.smethod_0(29803));
        }
        catch
        {
          GClass62.smethod_28(Class13.smethod_0(29803));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_4[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        Class15.smethod_0(0);
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (num > Class15.smethod_0(0))
          {
            try
            {
              this.string_1 = File.ReadAllText(Class13.smethod_0(29766));
              this.long_2 = (long) num;
              this.bool_1 = Class15.smethod_0(1) != 0;
              this.bool_2 = Class15.smethod_0(0) != 0;
              GClass116.gclass73_0.method_7(Class13.smethod_0(29867) + GClass138.smethod_9(this.long_2) + Class13.smethod_0(30097), Class15.smethod_0(0));
              if ((!this.bool_4 ? 1 : 0) == 0)
              {
                GClass152.smethod_9(Class13.smethod_0(29840), Class15.smethod_0(1));
                GClass152.smethod_4(Class13.smethod_0(29943), this.long_2.ToString());
              }
            }
            catch
            {
              GClass116.gclass73_0.method_7(Class13.smethod_0(29749), Class15.smethod_0(0));
            }
          }
          if (num <= Class15.smethod_0(0))
            GClass62.smethod_28(Class13.smethod_0(29803));
        }
        catch
        {
          GClass62.smethod_28(Class13.smethod_0(29803));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_5[Class15.smethod_0(0)]) ? 0 : 1) == 0)
          return;
        Class15.smethod_0(0);
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (num > Class15.smethod_0(0))
          {
            try
            {
              this.string_1 = File.ReadAllText(Class13.smethod_0(29766));
              this.int_3 = num;
              this.int_2 = Class15.smethod_0(0);
              this.int_1 = GClass20.smethod_1().luong + GClass20.smethod_1().luongKhoa;
              this.bool_1 = Class15.smethod_0(0) != 0;
              this.bool_2 = Class15.smethod_0(1) != 0;
              GClass116.gclass73_0.method_7(Class13.smethod_0(29919) + this.int_3.ToString() + Class13.smethod_0(30519), Class15.smethod_0(0));
            }
            catch
            {
              GClass116.gclass73_0.method_7(Class13.smethod_0(29749), Class15.smethod_0(0));
            }
          }
          if (num <= Class15.smethod_0(0))
            GClass62.smethod_28(Class13.smethod_0(30506));
        }
        catch
        {
          GClass62.smethod_28(Class13.smethod_0(30506));
        }
        GClass13.gclass13_0.method_12();
      }
    }
    else
    {
      gclass23.isShow = Class15.smethod_0(0) != 0;
      GClass13.gclass13_0.method_12();
    }
  }

  public void imethod_2()
  {
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(1))
    {
      case 0:
        if ((!this.bool_0 ? 0 : 1) == 0)
          GClass13.gclass13_0.method_10((GInterface1) this, this.string_3[Class15.smethod_0(0)], this.string_3[Class15.smethod_0(1)], GClass184.int_8);
        if ((!this.bool_0 ? 1 : 0) != 0)
          break;
        this.bool_0 = Class15.smethod_0(0) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(30268), Class15.smethod_0(0));
        if ((!this.bool_4 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(30236), Class15.smethod_0(0));
        break;
      case 1:
        if ((!this.bool_1 ? 0 : 1) == 0)
          GClass13.gclass13_0.method_10((GInterface1) this, this.string_4[Class15.smethod_0(0)], this.string_4[Class15.smethod_0(1)], GClass184.int_8);
        if ((!this.bool_1 ? 1 : 0) != 0)
          break;
        this.bool_1 = Class15.smethod_0(0) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(30211), Class15.smethod_0(0));
        if ((!this.bool_4 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(30390), Class15.smethod_0(0));
        break;
      case 2:
        if ((!this.bool_2 ? 0 : 1) == 0)
          GClass13.gclass13_0.method_10((GInterface1) this, this.string_5[Class15.smethod_0(0)], this.string_5[Class15.smethod_0(1)], GClass184.int_8);
        if ((!this.bool_2 ? 1 : 0) != 0)
          break;
        this.bool_2 = Class15.smethod_0(0) != 0;
        GClass116.gclass73_0.method_7(Class13.smethod_0(30356), Class15.smethod_0(0));
        break;
      case 3:
        if ((!this.bool_3 ? 1 : 0) == 0)
        {
          this.bool_3 = Class15.smethod_0(0) != 0;
          GClass116.gclass73_0.method_7(Class13.smethod_0(30431), Class15.smethod_0(0));
        }
        else
        {
          try
          {
            this.string_2 = File.ReadAllText(Class13.smethod_0(30414));
            this.bool_3 = Class15.smethod_0(1) != 0;
            GClass116.gclass73_0.method_7(Class13.smethod_0(31031), Class15.smethod_0(0));
          }
          catch
          {
            GClass116.gclass73_0.method_7(Class13.smethod_0(31015), Class15.smethod_0(0));
          }
        }
        if ((!this.bool_4 ? 1 : 0) != 0)
          break;
        GClass152.smethod_9(Class13.smethod_0(30996), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        break;
      case 4:
        this.bool_4 = (this.bool_4 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(31100) + ((!this.bool_4 ? 0 : 1) != 0 ? Class13.smethod_0(31046) : Class13.smethod_0(31055)), Class15.smethod_0(0));
        GClass152.smethod_9(Class13.smethod_0(31123), (!this.bool_4 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
        if ((!this.bool_4 ? 1 : 0) != 0)
          break;
        this.method_3();
        break;
    }
  }

  public void method_1()
  {
    this.method_2();
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30795) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(30966) + GClass138.smethod_9(this.long_0) + Class13.smethod_0(30925) : Class13.smethod_0(30900)), (GInterface0) this, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30912) + ((!this.bool_1 ? 0 : 1) != 0 ? Class13.smethod_0(30966) + GClass138.smethod_9(this.long_2) + Class13.smethod_0(30925) : Class13.smethod_0(30900)), (GInterface0) this, Class15.smethod_0(7), (object) null));
    GClass134 gclass134 = menuItems;
    string str1 = Class13.smethod_0(31528);
    string str2;
    if ((!this.bool_2 ? 0 : 1) == 0)
    {
      str2 = Class13.smethod_0(30900);
    }
    else
    {
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(30966);
      strArray[Class15.smethod_0(1)] = this.int_2.ToString();
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(31608);
      strArray[Class15.smethod_0(5)] = this.int_3.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(31594);
      str2 = string.Concat(strArray);
    }
    GClass31 o = new GClass31(str1 + str2, (GInterface0) this, Class15.smethod_0(5), (object) null);
    gclass134.method_0((object) o);
    menuItems.method_0((object) new GClass31(Class13.smethod_0(31579) + ((!this.bool_3 ? 0 : 1) != 0 ? Class13.smethod_0(31567) : Class13.smethod_0(30900)), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(31667) + ((!this.bool_4 ? 0 : 1) != 0 ? Class13.smethod_0(31567) : Class13.smethod_0(30900)), (GInterface0) this, Class15.smethod_0(3), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
    this.bool_4 = GClass152.smethod_8(Class13.smethod_0(31718)) == Class15.smethod_0(1);
    if ((!this.bool_4 ? 1 : 0) != 0)
      return;
    this.bool_0 = GClass152.smethod_8(Class13.smethod_0(31342)) == Class15.smethod_0(1);
    this.bool_1 = GClass152.smethod_8(Class13.smethod_0(31297)) == Class15.smethod_0(1);
    this.bool_3 = GClass152.smethod_8(Class13.smethod_0(31451)) == Class15.smethod_0(1);
    if ((!this.bool_0 ? 1 : 0) == 0)
      this.long_0 = long.Parse(GClass152.smethod_2(Class13.smethod_0(32049)));
    if ((!this.bool_1 ? 1 : 0) != 0)
      return;
    this.long_2 = long.Parse(GClass152.smethod_2(Class13.smethod_0(32025)));
  }

  private void method_3()
  {
    GClass152.smethod_9(Class13.smethod_0(32176), (!this.bool_0 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(32131), (!this.bool_1 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    GClass152.smethod_9(Class13.smethod_0(32234), (!this.bool_3 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0));
    if ((!this.bool_0 ? 1 : 0) == 0)
      GClass152.smethod_4(Class13.smethod_0(32210), this.long_0.ToString());
    if ((!this.bool_1 ? 1 : 0) != 0)
      return;
    GClass152.smethod_4(Class13.smethod_0(31802), this.long_2.ToString());
  }

  private void method_4()
  {
    if (this.long_0 < (long) Class15.smethod_0(14))
      this.long_0 = (long) Class15.smethod_0(14);
    if ((this.string_0 == null ? 1 : 0) != 0 || (!this.string_0.Equals("") ? 1 : 0) == 0)
    {
      try
      {
        this.string_0 = File.ReadAllText(Class13.smethod_0(31825));
      }
      catch
      {
        this.string_0 = Class13.smethod_0(31929);
      }
    }
    if (GClass126.smethod_18() - this.long_1 <= this.long_0)
      return;
    this.long_1 = GClass126.smethod_18();
    GClass156.smethod_0().method_79(this.string_0);
  }

  private void method_5()
  {
    int num = GClass20.smethod_1().luong + GClass20.smethod_1().luongKhoa;
    if (num < Class15.smethod_0(3))
    {
      this.bool_1 = Class15.smethod_0(0) != 0;
      GClass116.gclass73_0.method_7(Class13.smethod_0(31990), Class15.smethod_0(0));
    }
    else
    {
      if (this.long_2 <= (long) Class15.smethod_0(0))
        this.long_2 = (long) Class15.smethod_0(14);
      if ((this.string_1 == null ? 1 : 0) != 0 || (!this.string_1.Equals("") ? 1 : 0) == 0)
      {
        try
        {
          this.string_1 = File.ReadAllText(Class13.smethod_0(32592));
        }
        catch
        {
          this.string_1 = Class13.smethod_0(25243);
        }
      }
      if (this.int_1 == num && GClass126.smethod_18() - this.long_3 > (long) Class15.smethod_0(15))
        this.long_3 = GClass126.smethod_18() - this.long_2 - (long) Class15.smethod_0(16);
      if (GClass126.smethod_18() - this.long_3 <= this.long_2)
        return;
      this.long_3 = GClass126.smethod_18();
      this.int_0 += Class15.smethod_0(1);
      this.int_1 = num;
      GClass156 gclass156 = GClass156.smethod_0();
      string[] strArray = new string[Class15.smethod_0(3)];
      strArray[Class15.smethod_0(0)] = this.int_0.ToString();
      strArray[Class15.smethod_0(1)] = Class13.smethod_0(25307);
      strArray[Class15.smethod_0(7)] = this.string_1;
      strArray[Class15.smethod_0(5)] = Class13.smethod_0(25302);
      strArray[Class15.smethod_0(2)] = GClass151.smethod_18(Class15.smethod_0(17), Class15.smethod_0(18)).ToString();
      string text = string.Concat(strArray);
      gclass156.method_99(text);
    }
  }

  private void method_6()
  {
    int num = GClass20.smethod_1().luong + GClass20.smethod_1().luongKhoa;
    if (num < Class15.smethod_0(3) || this.int_3 <= Class15.smethod_0(0) || this.int_2 >= this.int_3)
      this.bool_2 = Class15.smethod_0(0) != 0;
    if ((this.string_1 == null ? 1 : 0) != 0 || (!this.string_1.Equals("") ? 1 : 0) == 0)
    {
      try
      {
        this.string_1 = File.ReadAllText(Class13.smethod_0(25294));
      }
      catch
      {
        this.string_1 = Class13.smethod_0(25910);
      }
    }
    if (this.int_1 != num)
    {
      this.int_1 = num;
      this.int_2 += Class15.smethod_0(1);
    }
    if (GClass126.smethod_18() - this.long_3 < (long) Class15.smethod_0(19))
      return;
    this.long_3 = GClass126.smethod_18();
    this.int_0 += Class15.smethod_0(1);
    this.int_1 = num;
    GClass156 gclass156 = GClass156.smethod_0();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = this.int_0.ToString();
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(25891);
    strArray[Class15.smethod_0(7)] = this.string_1;
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(25886);
    strArray[Class15.smethod_0(2)] = GClass151.smethod_18(Class15.smethod_0(17), Class15.smethod_0(18)).ToString();
    string text = string.Concat(strArray);
    gclass156.method_99(text);
  }

  private void method_7()
  {
    if ((this.list_0 == null ? 0 : 1) == 0)
      this.list_0 = new List<int>();
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
    {
      GClass20 gclass20_0 = (GClass20) GClass116.gclass134_5.method_3(index);
      if ((!this.method_8(gclass20_0) ? 1 : 0) == 0 && (!this.list_0.Contains(gclass20_0.charID) ? 0 : 1) == 0)
        this.list_0.Add(gclass20_0.charID);
    }
    if ((this.string_2 == null ? 1 : 0) != 0 || (!this.string_2.Equals("") ? 1 : 0) == 0)
    {
      try
      {
        this.string_2 = File.ReadAllText(Class13.smethod_0(26371));
      }
      catch
      {
        this.string_2 = Class13.smethod_0(26476);
      }
    }
    if (this.list_0.Count <= Class15.smethod_0(0) || GClass126.smethod_18() - this.long_4 <= (long) Class15.smethod_0(20))
      return;
    this.long_4 = GClass126.smethod_18();
    this.int_4 += Class15.smethod_0(1);
    GClass156 gclass156 = GClass156.smethod_0();
    string[] strArray = new string[Class15.smethod_0(3)];
    strArray[Class15.smethod_0(0)] = this.int_4.ToString();
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(26441);
    strArray[Class15.smethod_0(7)] = this.string_2;
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(26571);
    strArray[Class15.smethod_0(2)] = GClass151.smethod_18(Class15.smethod_0(17), Class15.smethod_0(18)).ToString();
    string text = string.Concat(strArray);
    int id = this.list_0[Class15.smethod_0(0)];
    gclass156.method_98(text, id);
    this.list_0.RemoveAt(Class15.smethod_0(0));
  }

  private bool method_8(GClass20 gclass20_0) => (gclass20_0 == null ? 1 : 0) == 0 && (gclass20_0.cName == null ? 1 : 0) == 0 && (!gclass20_0.cName.Equals("") ? 0 : 1) == 0 && (!char.IsUpper(char.Parse(gclass20_0.cName.Substring(Class15.smethod_0(0), Class15.smethod_0(1)))) ? 0 : 1) == 0 && (!gclass20_0.isPet ? 0 : 1) == 0 && (!gclass20_0.isMiniPet ? 0 : 1) == 0 && (!gclass20_0.cName.StartsWith(Class13.smethod_0(26178)) ? 0 : 1) == 0 ? (gclass20_0.cName.StartsWith(Class13.smethod_0(26290)) ? 1 : 0) == Class15.smethod_0(0) : Class15.smethod_0(0) != 0;
}
