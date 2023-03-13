// Decompiled with JetBrains decompiler
// Type: GClass12
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass12 : GInterface0, GInterface1
{
  public static GClass12 gclass12_0 = new GClass12();
  private int int_0;
  private bool bool_0;
  private bool bool_1;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private string[] string_0;
  private string[] string_1;
  private string[] string_2;
  private string[] string_3;
  private string[] string_4;

  public void method_0()
  {
    if ((!this.bool_0 ? 1 : 0) != 0)
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
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (((this.int_0 == 0 ? 1 : 0) != 0 || this.int_0 == Class15.smethod_0(1)) && (num % Class15.smethod_0(51) == 0 ? 1 : 0) == 0)
          {
            GClass116.gclass73_0.method_7(Class13.smethod_0(29014), Class15.smethod_0(0));
            return;
          }
          if ((this.int_0 == 0 ? 1 : 0) != 0 || this.int_0 == Class15.smethod_0(1))
            num /= Class15.smethod_0(51);
          GClass156.smethod_0().method_124(this.int_0, num);
          GClass116.gclass73_0.method_7(Class13.smethod_0(28788), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(28749), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_4[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          if (((this.int_0 == 0 ? 1 : 0) != 0 || this.int_0 == Class15.smethod_0(1)) && (num % Class15.smethod_0(51) == 0 ? 1 : 0) == 0)
          {
            GClass116.gclass73_0.method_7(Class13.smethod_0(29014), Class15.smethod_0(0));
            return;
          }
          if ((this.int_0 == 0 ? 0 : 1) == 0)
          {
            this.bool_0 = Class15.smethod_0(1) != 0;
            this.bool_1 = Class15.smethod_0(1) != 0;
            this.int_2 = num;
          }
          else if (this.int_0 == Class15.smethod_0(1))
          {
            this.bool_0 = Class15.smethod_0(1) != 0;
            this.bool_1 = Class15.smethod_0(1) != 0;
            this.int_3 = num;
          }
          else if (this.int_0 == Class15.smethod_0(7))
          {
            this.bool_0 = Class15.smethod_0(1) != 0;
            this.bool_1 = Class15.smethod_0(1) != 0;
            this.int_1 = num;
          }
          else if (this.int_0 == Class15.smethod_0(5))
          {
            this.bool_0 = Class15.smethod_0(1) != 0;
            this.bool_1 = Class15.smethod_0(1) != 0;
            this.int_4 = num;
          }
          else if (this.int_0 == Class15.smethod_0(2))
          {
            int cCriticalGoc = GClass20.smethod_1().cCriticalGoc;
            if (num <= cCriticalGoc)
            {
              GClass116.gclass73_0.method_7(Class13.smethod_0(28749), Class15.smethod_0(0));
              return;
            }
            GClass156.smethod_0().method_124(this.int_0, num - cCriticalGoc);
          }
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(28749), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_0[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int m = this.int_1 = int.Parse(gclass23.tfChat.method_21());
          GClass116.gclass73_0.method_7(Class13.smethod_0(28823) + GClass138.smethod_9((long) m), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(28924), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_1[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int m = this.int_2 = int.Parse(gclass23.tfChat.method_21());
          GClass116.gclass73_0.method_7(Class13.smethod_0(28868) + GClass138.smethod_9((long) m), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29491), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_2[Class15.smethod_0(0)]) ? 1 : 0) != 0)
          return;
        try
        {
          int m = this.int_3 = int.Parse(gclass23.tfChat.method_21());
          GClass116.gclass73_0.method_7(Class13.smethod_0(29548) + GClass138.smethod_9((long) m), Class15.smethod_0(0));
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29531), Class15.smethod_0(0));
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
        this.method_2();
        break;
      case 1:
        this.method_3();
        break;
      case 2:
        this.bool_0 = (this.bool_0 ? 1 : 0) == Class15.smethod_0(0);
        GClass116.gclass73_0.method_7(Class13.smethod_0(30579) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(30535) : Class13.smethod_0(30554)), Class15.smethod_0(0));
        break;
      case 3:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 4:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_1[Class15.smethod_0(0)], this.string_1[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 5:
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_2[Class15.smethod_0(0)], this.string_2[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 6:
        this.method_4(Class15.smethod_0(0));
        break;
      case 7:
        this.method_4(Class15.smethod_0(1));
        break;
      case 8:
        this.method_4(Class15.smethod_0(7));
        break;
      case 9:
        this.method_4(Class15.smethod_0(5));
        break;
      case 10:
        this.method_4(Class15.smethod_0(2));
        break;
      case 11:
        this.int_0 = (int) p;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_3[Class15.smethod_0(0)], this.string_3[Class15.smethod_0(1)], GClass184.int_8);
        break;
      case 12:
        this.int_0 = (int) p;
        GClass13.gclass13_0.method_10((GInterface1) this, this.string_4[Class15.smethod_0(0)], this.string_4[Class15.smethod_0(1)], GClass184.int_8);
        break;
    }
  }

  public void method_1()
  {
    this.method_5();
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(30719), (GInterface0) this, Class15.smethod_0(1), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(26677), (GInterface0) this, Class15.smethod_0(7), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_2()
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(26742) + ((!this.bool_0 ? 0 : 1) != 0 ? Class13.smethod_0(27804) : Class13.smethod_0(27810)), (GInterface0) this, Class15.smethod_0(5), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27900) + GClass138.smethod_9((long) this.int_1) + Class13.smethod_0(27885), (GInterface0) this, Class15.smethod_0(2), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27883) + GClass138.smethod_9((long) this.int_2) + Class13.smethod_0(27885), (GInterface0) this, Class15.smethod_0(3), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27878) + GClass138.smethod_9((long) this.int_3) + Class13.smethod_0(27885), (GInterface0) this, Class15.smethod_0(37), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_3()
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27873), (GInterface0) this, Class15.smethod_0(38), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27870), (GInterface0) this, Class15.smethod_0(88), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(27867), (GInterface0) this, Class15.smethod_0(45), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28474), (GInterface0) this, Class15.smethod_0(31), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28468), (GInterface0) this, Class15.smethod_0(67), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  public void method_4(int index)
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(Class13.smethod_0(28456), (GInterface0) this, Class15.smethod_0(47), (object) index));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
  }

  private void method_5()
  {
  }

  private void method_6()
  {
  }

  private void method_7()
  {
    if ((GClass62.int_8 % Class15.smethod_0(51) == 0 ? 1 : 0) == 0)
      return;
    if (GClass20.smethod_1().cDamGoc < this.int_1)
    {
      int num1 = this.method_10();
      if (num1 >= Class15.smethod_0(0))
      {
        int num2 = this.int_1 - GClass20.smethod_1().cDamGoc;
        if (num1 > num2)
          num1 = num2;
        GClass156.smethod_0().method_124(Class15.smethod_0(7), num1);
      }
      if ((!this.bool_1 ? 0 : 1) == 0)
        return;
    }
    if (GClass20.smethod_1().cHPGoc < this.int_2)
    {
      int num3 = this.method_8();
      if (num3 >= Class15.smethod_0(0))
      {
        int num4 = (this.int_2 - GClass20.smethod_1().cHPGoc) / Class15.smethod_0(51);
        if (num3 > num4)
          num3 = num4;
        GClass156.smethod_0().method_124(Class15.smethod_0(0), num3);
      }
      if ((!this.bool_1 ? 0 : 1) == 0)
        return;
    }
    if (GClass20.smethod_1().cMPGoc < this.int_3)
    {
      int num5 = this.method_9();
      if (num5 >= Class15.smethod_0(0))
      {
        int num6 = (this.int_3 - GClass20.smethod_1().cMPGoc) / Class15.smethod_0(51);
        if (num5 > num6)
          num5 = num6;
        GClass156.smethod_0().method_124(Class15.smethod_0(1), num5);
      }
      if ((!this.bool_1 ? 0 : 1) == 0)
        return;
    }
    if (GClass20.smethod_1().cDefGoc >= this.int_4)
      return;
    int num7 = this.method_11();
    if (num7 < Class15.smethod_0(0))
      return;
    int num8 = this.int_4 - GClass20.smethod_1().cDefGoc;
    if (num7 > num8)
      num7 = num8;
    GClass156.smethod_0().method_124(Class15.smethod_0(5), num7);
  }

  private int method_8()
  {
    long cTiemNang = GClass20.smethod_1().cTiemNang;
    int cHpGoc = GClass20.smethod_1().cHPGoc;
    long num1 = (long) Class15.smethod_0(31) * (long) (Class15.smethod_0(7) * (cHpGoc + Class15.smethod_0(15)) + Class15.smethod_0(96)) / (long) Class15.smethod_0(7);
    long num2 = (long) Class15.smethod_0(21) * (long) (Class15.smethod_0(7) * (cHpGoc + Class15.smethod_0(15)) + Class15.smethod_0(97)) / (long) Class15.smethod_0(7);
    if (cTiemNang > (long) cHpGoc && cTiemNang < num1)
      return Class15.smethod_0(1);
    if (cTiemNang >= num1 && cTiemNang < num2)
      return Class15.smethod_0(31);
    return cTiemNang >= num2 ? Class15.smethod_0(21) : Class15.smethod_0(0);
  }

  private int method_9()
  {
    long cTiemNang = GClass20.smethod_1().cTiemNang;
    int cMpGoc = GClass20.smethod_1().cMPGoc;
    long num1 = (long) Class15.smethod_0(31) * (long) (Class15.smethod_0(7) * (cMpGoc + Class15.smethod_0(15)) + Class15.smethod_0(96)) / (long) Class15.smethod_0(7);
    long num2 = (long) Class15.smethod_0(21) * (long) (Class15.smethod_0(7) * (cMpGoc + Class15.smethod_0(15)) + Class15.smethod_0(97)) / (long) Class15.smethod_0(7);
    if (cTiemNang > (long) cMpGoc && cTiemNang < num1)
      return Class15.smethod_0(1);
    if (cTiemNang >= num1 && cTiemNang < num2)
      return Class15.smethod_0(31);
    return cTiemNang >= num2 ? Class15.smethod_0(21) : Class15.smethod_0(0);
  }

  private int method_10()
  {
    long cTiemNang = GClass20.smethod_1().cTiemNang;
    int cDamGoc = GClass20.smethod_1().cDamGoc;
    long num1 = (long) Class15.smethod_0(31) * (long) (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(45)) / (long) Class15.smethod_0(7) * (long) GClass20.smethod_1().expForOneAdd;
    long num2 = (long) Class15.smethod_0(21) * (long) (Class15.smethod_0(7) * cDamGoc + Class15.smethod_0(87)) / (long) Class15.smethod_0(7) * (long) GClass20.smethod_1().expForOneAdd;
    if (cTiemNang > (long) cDamGoc && cTiemNang < num1)
      return Class15.smethod_0(1);
    if (cTiemNang >= num1 && cTiemNang < num2)
      return Class15.smethod_0(31);
    return cTiemNang >= num2 ? Class15.smethod_0(21) : Class15.smethod_0(0);
  }

  private int method_11()
  {
    long cTiemNang = GClass20.smethod_1().cTiemNang;
    int cDefGoc = GClass20.smethod_1().cDefGoc;
    long num1 = (long) Class15.smethod_0(31) * (long) (Class15.smethod_0(7) * (cDefGoc + Class15.smethod_0(3)) + Class15.smethod_0(45)) / (long) Class15.smethod_0(7) * (long) Class15.smethod_0(17);
    long num2 = (long) Class15.smethod_0(21) * (long) (Class15.smethod_0(7) * (cDefGoc + Class15.smethod_0(3)) + Class15.smethod_0(87)) / (long) Class15.smethod_0(7) * (long) Class15.smethod_0(17);
    if (cTiemNang > (long) cDefGoc && cTiemNang < num1)
      return Class15.smethod_0(1);
    if (cTiemNang >= num1 && cTiemNang < num2)
      return Class15.smethod_0(31);
    return cTiemNang >= num2 ? Class15.smethod_0(21) : Class15.smethod_0(0);
  }

  public GClass12()
  {
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(21619);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(120823);
    this.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(120777);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(120332);
    this.string_1 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(7)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(154887);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(147641);
    this.string_2 = strArray3;
    string[] strArray4 = new string[Class15.smethod_0(7)];
    strArray4[Class15.smethod_0(0)] = Class13.smethod_0(147621);
    strArray4[Class15.smethod_0(1)] = Class13.smethod_0(147687);
    this.string_3 = strArray4;
    string[] strArray5 = new string[Class15.smethod_0(7)];
    strArray5[Class15.smethod_0(0)] = Class13.smethod_0(148428);
    strArray5[Class15.smethod_0(1)] = Class13.smethod_0(147687);
    this.string_4 = strArray5;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }
}
