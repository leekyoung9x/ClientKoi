// Decompiled with JetBrains decompiler
// Type: GClass125
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass125 : GClass113, GInterface0
{
  public GClass184 tfUser;
  public GClass184 tfNgay;
  public GClass184 tfThang;
  public GClass184 tfNam;
  public GClass184 tfDiachi;
  public GClass184 tfCMND;
  public GClass184 tfNgayCap;
  public GClass184 tfNoiCap;
  public GClass184 tfSodt;
  public static bool bool_0 = Class15.smethod_0(0) != 0;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  public bool isCheck;
  public bool isRes;
  private GClass31 gclass31_0;
  private GClass31 gclass31_1;
  private GClass31 gclass31_2;
  private GClass31 gclass31_3;
  private GClass31 gclass31_4;
  private GClass31 gclass31_5;
  public string listFAQ = string.Empty;
  public string titleFAQ;
  public string subtitleFAQ;
  private string string_0 = string.Empty;
  private string string_1;
  private string string_2;
  public static bool bool_1 = Class15.smethod_0(0) != 0;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  public static bool bool_5;
  public static bool bool_6;
  public static string string_3;
  public static GClass66 gclass66_0;
  public int plX;
  public int plY;
  public int lY;
  public int lX;
  public int logoDes;
  public int lineX;
  public int lineY;
  public static int[] int_10;
  public static bool bool_7;
  public static short short_0;
  public static long long_0;
  public static long long_1;
  private int int_11;
  private GClass31 gclass31_6;
  private GClass31 gclass31_7;
  private int int_12;
  private int int_13;
  private int int_14;
  private int int_15;
  private int int_16;
  private int int_17;
  private string string_4 = string.Empty;
  public bool isFAQ;
  private int int_18 = -1;
  public bool isLogin2;
  private int int_19 = Class15.smethod_0(7);
  private int int_20;
  private int int_21 = Class15.smethod_0(268);
  private int int_22 = Class15.smethod_0(1);
  public static bool bool_8;

  public GClass125(sbyte haveName)
  {
    this.int_13 = Class15.smethod_0(288);
    GClass185.int_40 = (int) (sbyte) (GClass126.smethod_18() % (long) Class15.smethod_0(45));
    if (GClass185.int_40 == Class15.smethod_0(3) || GClass185.int_40 == Class15.smethod_0(37))
      GClass185.int_40 = Class15.smethod_0(2);
    GClass116.smethod_8(Class15.smethod_0(1) != 0, -1, -1);
    GClass116.int_22 = Class15.smethod_0(21);
    GClass116.int_23 = Class15.smethod_0(90);
    this.int_9 = GClass62.int_11 <= Class15.smethod_0(90) ? GClass62.int_13 - Class15.smethod_0(130) : GClass62.int_13 - Class15.smethod_0(25);
    this.method_14();
    this.int_7 = GClass62.int_10 < Class15.smethod_0(90) ? Class15.smethod_0(399) : Class15.smethod_0(195);
    this.int_11 = GClass62.int_13 - GClass113.int_0 - Class15.smethod_0(3);
    if (GClass62.int_11 <= Class15.smethod_0(195))
      this.int_11 = Class15.smethod_0(51);
    this.tfSodt = new GClass184();
    this.tfSodt.method_28(GClass184.int_8);
    this.tfSodt.width = Class15.smethod_0(99);
    this.tfSodt.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfSodt.name = Class13.smethod_0(140553);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfSodt.method_23(Class13.smethod_0(140622));
    this.tfUser = new GClass184();
    this.tfUser.width = Class15.smethod_0(99);
    this.tfUser.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
    this.tfUser.name = Class13.smethod_0(140714);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfUser.method_23(Class13.smethod_0(140700));
    this.tfUser.method_28(GClass184.int_7);
    this.tfNgay = new GClass184();
    this.tfNgay.method_28(GClass184.int_8);
    this.tfNgay.width = Class15.smethod_0(152);
    this.tfNgay.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfNgay.name = Class13.smethod_0(140680);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfNgay.method_23(Class13.smethod_0(140769));
    this.tfThang = new GClass184();
    this.tfThang.method_28(GClass184.int_8);
    this.tfThang.width = Class15.smethod_0(152);
    this.tfThang.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfThang.name = Class13.smethod_0(140757);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfThang.method_23(Class13.smethod_0(140769));
    this.tfNam = new GClass184();
    this.tfNam.method_28(GClass184.int_8);
    this.tfNam.width = Class15.smethod_0(152);
    this.tfNam.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfNam.name = Class13.smethod_0(142081);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfNam.method_23(Class13.smethod_0(142253));
    this.tfDiachi = new GClass184();
    this.tfDiachi.method_28(GClass184.int_7);
    this.tfDiachi.width = Class15.smethod_0(99);
    this.tfDiachi.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfDiachi.name = Class13.smethod_0(142248);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfDiachi.method_23(Class13.smethod_0(142060));
    this.tfCMND = new GClass184();
    this.tfCMND.method_28(GClass184.int_8);
    this.tfCMND.width = Class15.smethod_0(99);
    this.tfCMND.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfCMND.name = Class13.smethod_0(142766);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfCMND.method_23(Class13.smethod_0(142838));
    this.tfNgayCap = new GClass184();
    this.tfNgayCap.method_28(GClass184.int_8);
    this.tfNgayCap.width = Class15.smethod_0(99);
    this.tfNgayCap.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfNgayCap.name = Class13.smethod_0(142828);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfNgayCap.method_23(Class13.smethod_0(142816));
    this.tfNoiCap = new GClass184();
    this.tfNoiCap.method_28(GClass184.int_7);
    this.tfNoiCap.width = Class15.smethod_0(99);
    this.tfNoiCap.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfNoiCap.name = Class13.smethod_0(142801);
    if ((int) haveName == Class15.smethod_0(1))
      this.tfNoiCap.method_23(Class13.smethod_0(142397));
    this.int_11 += Class15.smethod_0(95);
    this.isCheck = Class15.smethod_0(1) != 0;
    this.int_6 = Class15.smethod_0(0);
    this.gclass31_0 = new GClass31(GClass62.int_10 <= Class15.smethod_0(90) ? GClass109.string_80 : GClass109.string_79, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(405), (object) null);
    this.gclass31_1 = new GClass31(GClass109.string_143, (GInterface0) this, Class15.smethod_0(406), (object) null);
    this.gclass31_3 = new GClass31(GClass109.string_81, (GInterface0) this, Class15.smethod_0(407), (object) null);
    this.gclass31_5 = new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(408), (object) null);
    this.left = this.gclass31_4 = new GClass31(GClass109.string_124, (GInterface0) this, Class15.smethod_0(363), (object) null);
    if (GClass62.bool_5)
    {
      this.gclass31_0.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(21);
      this.gclass31_4.x = GClass62.int_10 / Class15.smethod_0(7) - GClass113.int_2 - Class15.smethod_0(88);
      if (GClass62.int_11 >= Class15.smethod_0(90))
      {
        this.gclass31_0.y = GClass62.int_11 / Class15.smethod_0(7) - Class15.smethod_0(54);
        this.gclass31_4.y = this.int_13 + Class15.smethod_0(80);
      }
      this.gclass31_5.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(5);
      this.gclass31_5.y = this.int_13 + Class15.smethod_0(80);
      this.gclass31_3.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(39);
      this.gclass31_3.y = this.gclass31_4.y;
    }
    this.int_16 = Class15.smethod_0(162);
    this.int_17 = !this.isRes ? Class15.smethod_0(21) : Class15.smethod_0(80);
    this.int_14 = GClass62.int_12 - this.int_16 / Class15.smethod_0(7);
    this.int_15 = this.tfUser.y - Class15.smethod_0(9);
    int num1 = Class15.smethod_0(2);
    int num2 = num1 * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
    if (num2 >= GClass62.int_10)
      num2 = (num1 - Class15.smethod_0(1)) * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
    this.int_12 = GClass62.int_10 / Class15.smethod_0(7) - num2 / Class15.smethod_0(7);
    this.int_13 = Class15.smethod_0(3);
    this.lY = GClass62.int_10 < Class15.smethod_0(90) ? this.tfUser.y - Class15.smethod_0(6) : this.int_13 - Class15.smethod_0(6);
    this.tfUser.x = this.int_12 + Class15.smethod_0(31);
    this.tfUser.y = this.int_13 + Class15.smethod_0(51);
    this.gclass31_7 = new GClass31(GClass109.string_140, (GInterface0) this, Class15.smethod_0(409), (object) null);
    this.gclass31_7.x = Class15.smethod_0(777);
    this.gclass31_7.y = GClass62.int_11 - Class15.smethod_0(4);
    this.gclass31_2 = new GClass31(Class13.smethod_0(142385), (GInterface0) this, Class15.smethod_0(410), (object) null);
    this.gclass31_2.x = Class15.smethod_0(777);
    this.gclass31_2.y = GClass62.int_11 - Class15.smethod_0(6);
    if (GClass62.int_10 < Class15.smethod_0(262))
    {
      this.gclass31_7.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(25);
      this.gclass31_2.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(31);
      this.gclass31_2.y = this.gclass31_7.y = GClass62.int_11 - Class15.smethod_0(46);
    }
    this.center = this.gclass31_7;
    this.left = this.gclass31_2;
  }

  public void method_0()
  {
    GClass151.smethod_7(Class13.smethod_0(142466));
    GClass172.smethod_1().method_51();
    this.int_6 = Class15.smethod_0(0);
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
    this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      this.tfUser.isFocus = Class15.smethod_0(0) != 0;
      this.int_6 = -1;
    }
    this.vmethod_0();
  }

  protected void method_1()
  {
    GClass134 menuItems = new GClass134(Class13.smethod_0(142578));
    menuItems.method_0((object) new GClass31(GClass109.string_54, (GInterface0) this, Class15.smethod_0(364), (object) null));
    if ((!this.isLogin2 ? 0 : 1) == 0)
      menuItems.method_0((object) new GClass31(GClass109.string_55, (GInterface0) this, Class15.smethod_0(411), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_57, (GInterface0) this, Class15.smethod_0(410), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_95, (GInterface0) this, Class15.smethod_0(412), (object) null));
    if (GClass152.smethod_8(Class13.smethod_0(142564)) == Class15.smethod_0(1))
      menuItems.method_0((object) new GClass31(GClass109.string_183, (GInterface0) this, Class15.smethod_0(417), (object) null));
    else
      menuItems.method_0((object) new GClass31(GClass109.string_184, (GInterface0) this, Class15.smethod_0(418), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_137, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(269), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
  }

  protected void method_2()
  {
    if ((!this.tfUser.method_21().Equals(string.Empty) ? 1 : 0) == 0)
    {
      GClass62.smethod_28(GClass109.string_49);
    }
    else
    {
      this.tfUser.method_21().ToCharArray();
      if ((!this.tfNgay.method_21().Equals(string.Empty) ? 1 : 0) == 0)
        GClass62.smethod_28(GClass109.string_50);
      else if (this.tfUser.method_21().Length < Class15.smethod_0(3))
      {
        GClass62.smethod_28(GClass109.string_51);
      }
      else
      {
        Class15.smethod_0(0);
        string info1 = (string) null;
        int num;
        if ((int) GClass109.sbyte_0 == Class15.smethod_0(7))
        {
          if (this.tfUser.method_21().IndexOf(Class13.smethod_0(135966)) == -1 || this.tfUser.method_21().IndexOf(Class13.smethod_0(136717)) == -1)
            info1 = GClass109.string_53;
          num = Class15.smethod_0(0);
        }
        else
        {
          try
          {
            long.Parse(this.tfUser.method_21());
            if (this.tfUser.method_21().Length < Class15.smethod_0(88) || this.tfUser.method_21().Length > Class15.smethod_0(66) || (!this.tfUser.method_21().StartsWith(Class13.smethod_0(136715)) ? 0 : 1) == 0 && (!this.tfUser.method_21().StartsWith(Class13.smethod_0(136800)) ? 0 : 1) == 0)
              info1 = GClass109.string_52;
            num = Class15.smethod_0(1);
          }
          catch (Exception ex)
          {
            if (this.tfUser.method_21().IndexOf(Class13.smethod_0(135966)) == -1 || this.tfUser.method_21().IndexOf(Class13.smethod_0(136717)) == -1)
              info1 = GClass109.string_53;
            num = Class15.smethod_0(0);
          }
        }
        if ((info1 == null ? 1 : 0) == 0)
        {
          GClass62.smethod_28(info1);
        }
        else
        {
          GClass39 gclass390 = GClass62.gclass39_0;
          string[] strArray = new string[Class15.smethod_0(38)];
          strArray[Class15.smethod_0(0)] = GClass109.string_64;
          strArray[Class15.smethod_0(1)] = num != Class15.smethod_0(1) ? GClass109.string_66 + Class13.smethod_0(136797) : GClass109.string_65 + Class13.smethod_0(136797);
          strArray[Class15.smethod_0(7)] = this.tfUser.method_21();
          strArray[Class15.smethod_0(5)] = Class13.smethod_0(136794);
          strArray[Class15.smethod_0(2)] = GClass109.string_58;
          strArray[Class15.smethod_0(3)] = Class13.smethod_0(136797);
          strArray[Class15.smethod_0(37)] = this.tfNgay.method_21();
          string info2 = string.Concat(strArray);
          GClass31 left = new GClass31(GClass109.string_144, (GInterface0) this, Class15.smethod_0(370), (object) null);
          GClass31 right = new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(327), (object) null);
          gclass390.method_2(info2, left, (GClass31) null, right);
        }
        GClass62.gclass37_0 = (GClass37) GClass62.gclass39_0;
      }
    }
  }

  protected void method_3(string user)
  {
  }

  public void method_4()
  {
    if ((!this.listFAQ.Equals(string.Empty) ? 1 : 0) == 0)
      this.listFAQ.Equals(string.Empty);
    if ((!GClass157.bool_1 ? 0 : 1) == 0)
    {
      this.isFAQ = Class15.smethod_0(1) != 0;
      GClass62.smethod_4();
    }
    GClass62.smethod_31();
  }

  protected void method_5()
  {
    GClass134 menuItems = new GClass134(Class13.smethod_0(137538));
    if ((!GClass125.bool_1 ? 1 : 0) == 0)
      menuItems.method_0((object) new GClass31(Class13.smethod_0(139140), (GInterface0) this, Class15.smethod_0(413), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(139255), (GInterface0) this, Class15.smethod_0(414), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(139241), (GInterface0) this, Class15.smethod_0(415), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(139225), (GInterface0) this, Class15.smethod_0(416), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
    if (this.method_7() == -1 || (!GClass62.bool_5 ? 0 : 1) != 0)
      return;
    GClass62.gclass95_0.menuSelectedItem = this.method_7();
  }

  protected void method_6(int index) => GClass152.smethod_9(Class13.smethod_0(139203), index);

  protected int method_7() => GClass152.smethod_8(Class13.smethod_0(138809));

  public void method_8()
  {
  }

  public void method_9()
  {
  }

  public override void vmethod_3()
  {
    this.tfUser.method_17();
    this.tfNgay.method_17();
    this.tfThang.method_17();
    this.tfNam.method_17();
    this.tfDiachi.method_17();
    this.tfCMND.method_17();
    this.tfNoiCap.method_17();
    this.tfSodt.method_17();
    this.tfNgayCap.method_17();
    for (int index = Class15.smethod_0(0); index < GClass42.gclass134_1.method_2(); index += Class15.smethod_0(1))
      ((GClass42) GClass42.gclass134_1.method_3(index)).vmethod_0();
    if ((!GClass125.bool_2 ? 1 : 0) == 0 && (!GClass125.bool_3 ? 0 : 1) == 0 && (!GClass125.bool_6 ? 0 : 1) == 0 && (!GClass125.bool_4 ? 0 : 1) == 0 && (!GClass125.bool_5 ? 0 : 1) == 0)
    {
      GClass125.bool_2 = Class15.smethod_0(0) != 0;
      GClass126.smethod_26();
      GClass156.smethod_0().method_116();
    }
    GClass116.int_22 += Class15.smethod_0(1);
    if (GClass116.int_22 > GClass62.int_10 * Class15.smethod_0(5) + Class15.smethod_0(21))
      GClass116.int_22 = Class15.smethod_0(21);
    if ((GClass43.gclass43_0 == null ? 1 : 0) == 0)
      return;
    GClass62.smethod_7(Class13.smethod_0(138799), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(138786), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(138769), Class15.smethod_0(0));
    this.method_11();
    GClass62.smethod_7(Class13.smethod_0(138764), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(138759), Class15.smethod_0(0));
    if (this.int_20 >= Class15.smethod_0(0))
    {
      this.int_21 += this.int_22 * this.int_20;
      this.int_20 += this.int_22 * this.int_19;
      if (this.int_20 <= Class15.smethod_0(0))
        this.int_22 *= -1;
      if (this.int_21 > Class15.smethod_0(0))
      {
        this.int_22 *= -1;
        this.int_20 -= Class15.smethod_0(7) * this.int_19;
      }
    }
    GClass62.smethod_7(Class13.smethod_0(138754), Class15.smethod_0(0));
    if (this.int_18 >= Class15.smethod_0(0) && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
      this.method_10();
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((!this.isRes ? 1 : 0) == 0)
      {
        this.center = this.gclass31_3;
        this.left = this.gclass31_5;
      }
      else
      {
        this.center = this.gclass31_7;
        this.left = this.gclass31_2;
      }
    }
    else if ((!this.isRes ? 1 : 0) == 0)
    {
      this.center = this.gclass31_3;
      this.left = this.gclass31_5;
    }
    else
    {
      this.center = this.gclass31_7;
      this.left = this.gclass31_2;
    }
  }

  private void method_10()
  {
    this.int_18 += Class15.smethod_0(1);
    if (this.int_18 >= GClass109.string_114.Length)
      this.int_18 = Class15.smethod_0(0);
    if (GClass62.gclass37_0 != GClass62.gclass39_0 || (!GClass62.gclass39_0.isWait ? 1 : 0) != 0)
      return;
    GClass62.gclass39_0.method_1(GClass109.string_114[this.int_18]);
  }

  public void method_11()
  {
    if (this.int_9 == this.int_8)
      return;
    this.int_8 += this.int_9 - this.int_8 >> Class15.smethod_0(1);
  }

  public override void vmethod_2(int keyCode)
  {
    if ((!this.tfUser.isFocus ? 1 : 0) == 0)
      this.tfUser.method_10(keyCode);
    else if ((!this.tfNgay.isFocus ? 1 : 0) == 0)
      this.tfNgay.method_10(keyCode);
    else if ((!this.tfThang.isFocus ? 1 : 0) == 0)
      this.tfThang.method_10(keyCode);
    else if ((!this.tfNam.isFocus ? 1 : 0) == 0)
      this.tfNam.method_10(keyCode);
    else if ((!this.tfDiachi.isFocus ? 1 : 0) == 0)
      this.tfDiachi.method_10(keyCode);
    else if ((!this.tfCMND.isFocus ? 1 : 0) == 0)
      this.tfCMND.method_10(keyCode);
    else if ((!this.tfNoiCap.isFocus ? 1 : 0) == 0)
      this.tfNoiCap.method_10(keyCode);
    else if ((!this.tfSodt.isFocus ? 1 : 0) == 0)
      this.tfSodt.method_10(keyCode);
    else if ((!this.tfNgayCap.isFocus ? 1 : 0) == 0)
      this.tfNgayCap.method_10(keyCode);
    base.vmethod_2(keyCode);
  }

  public override void vmethod_1() => base.vmethod_1();

  public override void vmethod_5(GClass98 g)
  {
    GClass62.smethod_7(Class13.smethod_0(131385), Class15.smethod_0(1));
    GClass62.smethod_16(g);
    GClass62.smethod_7(Class13.smethod_0(131374), Class15.smethod_0(7));
    int y = this.tfUser.y - Class15.smethod_0(32);
    if (GClass62.int_11 <= Class15.smethod_0(99))
      y += Class15.smethod_0(3);
    if ((GClass43.gclass43_0 == null ? 0 : 1) != 0 || (GClass43.gclass43_1 == null ? 1 : 0) == 0)
      return;
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      this.int_12 = Class15.smethod_0(3);
      int h = Class15.smethod_0(560);
      if (GClass62.int_10 < Class15.smethod_0(777))
        this.int_12 = (GClass62.int_10 - Class15.smethod_0(194)) / Class15.smethod_0(7);
      this.int_13 = (GClass62.int_11 - h) / Class15.smethod_0(7);
      Class15.smethod_0(90);
      GClass148.smethod_4(g, this.int_12, this.int_13, Class15.smethod_0(194), h, -1, Class15.smethod_0(1) != 0);
      if (GClass62.int_11 > Class15.smethod_0(195) && (GClass125.gclass66_0 == null ? 1 : 0) == 0)
        g.method_32(GClass125.gclass66_0, GClass62.int_12, y, Class15.smethod_0(5));
      GClass62.smethod_7(Class13.smethod_0(131369), Class15.smethod_0(1));
      int num1 = Class15.smethod_0(2);
      if (num1 * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48) >= GClass62.int_10)
      {
        int num2 = num1 - Class15.smethod_0(1);
      }
      this.tfSodt.x = this.int_12 + Class15.smethod_0(31);
      this.tfSodt.y = this.int_13 + Class15.smethod_0(9);
      this.tfUser.x = this.tfSodt.x;
      this.tfUser.y = this.tfSodt.y + Class15.smethod_0(6);
      this.tfNgay.x = this.int_12 + Class15.smethod_0(31);
      this.tfNgay.y = this.tfUser.y + Class15.smethod_0(6);
      this.tfThang.x = this.tfNgay.x + Class15.smethod_0(62);
      this.tfThang.y = this.tfNgay.y;
      this.tfNam.x = this.tfThang.x + Class15.smethod_0(62);
      this.tfNam.y = this.tfThang.y;
      this.tfDiachi.x = this.tfUser.x;
      this.tfDiachi.y = this.tfNgay.y + Class15.smethod_0(6);
      this.tfCMND.x = this.tfUser.x;
      this.tfCMND.y = this.tfDiachi.y + Class15.smethod_0(6);
      this.tfNgayCap.x = this.tfUser.x;
      this.tfNgayCap.y = this.tfCMND.y + Class15.smethod_0(6);
      this.tfNoiCap.x = this.tfUser.x;
      this.tfNoiCap.y = this.tfNgayCap.y + Class15.smethod_0(6);
      this.tfUser.method_13(g);
      this.tfNgay.method_13(g);
      this.tfThang.method_13(g);
      this.tfNam.method_13(g);
      this.tfDiachi.method_13(g);
      this.tfCMND.method_13(g);
      this.tfNgayCap.method_13(g);
      this.tfNoiCap.method_13(g);
      this.tfSodt.method_13(g);
      if (GClass62.int_10 < Class15.smethod_0(314))
      {
        GClass97.gclass97_7.method_6(g, GClass109.string_67 + Class13.smethod_0(131364), this.tfUser.x - Class15.smethod_0(95), this.tfUser.y + Class15.smethod_0(38), Class15.smethod_0(0));
        GClass97.gclass97_7.method_6(g, GClass109.string_68 + Class13.smethod_0(131364), this.tfNgay.x - Class15.smethod_0(95), this.tfNgay.y + Class15.smethod_0(38), Class15.smethod_0(0));
        GClass97.gclass97_7.method_6(g, GClass109.string_96 + Class13.smethod_0(131362) + GClass125.string_3, GClass62.int_10 / Class15.smethod_0(7), this.tfNgay.y + Class15.smethod_0(120), Class15.smethod_0(7));
      }
    }
    string string2 = GClass63.string_2;
    g.method_16(GClass62.int_23);
    g.method_15(GClass62.int_10 - Class15.smethod_0(54), Class15.smethod_0(2), Class15.smethod_0(86), Class15.smethod_0(67));
    GClass97.gclass97_16.method_6(g, string2, GClass62.int_10 - Class15.smethod_0(28), Class15.smethod_0(2), GClass97.int_2);
    GClass62.smethod_6(g);
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      if (GClass62.int_10 > Class15.smethod_0(262))
      {
        GClass97.gclass97_3.method_10(g, Class13.smethod_0(131359), Class15.smethod_0(777), Class15.smethod_0(31), Class15.smethod_0(0), GClass97.gclass97_6);
        GClass97.gclass97_3.method_10(g, Class13.smethod_0(131337), Class15.smethod_0(777), Class15.smethod_0(46), Class15.smethod_0(0), GClass97.gclass97_6);
        GClass97.gclass97_3.method_10(g, Class13.smethod_0(131440), Class15.smethod_0(777), Class15.smethod_0(54), Class15.smethod_0(0), GClass97.gclass97_6);
      }
      else
      {
        GClass97.gclass97_3.method_10(g, Class13.smethod_0(131422), GClass62.int_10 / Class15.smethod_0(7), Class15.smethod_0(3), Class15.smethod_0(7), GClass97.gclass97_6);
        GClass97.gclass97_3.method_10(g, Class13.smethod_0(131440), GClass62.int_10 / Class15.smethod_0(7), Class15.smethod_0(9), Class15.smethod_0(7), GClass97.gclass97_6);
      }
    }
    base.vmethod_5(g);
  }

  private void method_12()
  {
    this.tfUser.isFocus = Class15.smethod_0(0) != 0;
    this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
    this.tfThang.isFocus = Class15.smethod_0(0) != 0;
    this.tfNam.isFocus = Class15.smethod_0(0) != 0;
    this.tfDiachi.isFocus = Class15.smethod_0(0) != 0;
    this.tfCMND.isFocus = Class15.smethod_0(0) != 0;
    this.tfNgayCap.isFocus = Class15.smethod_0(0) != 0;
    this.tfNoiCap.isFocus = Class15.smethod_0(0) != 0;
    this.tfSodt.isFocus = Class15.smethod_0(0) != 0;
  }

  private void method_13()
  {
    this.method_12();
    switch (this.int_6)
    {
      case 0:
        this.tfUser.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 1:
        this.tfNgay.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 2:
        this.tfThang.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 3:
        this.tfNam.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 4:
        this.tfDiachi.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 5:
        this.tfCMND.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 6:
        this.tfNgayCap.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 7:
        this.tfNoiCap.isFocus = Class15.smethod_0(1) != 0;
        break;
      case 8:
        this.tfSodt.isFocus = Class15.smethod_0(1) != 0;
        break;
    }
  }

  public override void vmethod_4()
  {
    if ((!GClass125.bool_0 ? 1 : 0) == 0)
      return;
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
    {
      if ((!this.tfUser.isFocus ? 1 : 0) == 0)
        this.right = this.tfUser.cmdClear;
      else if ((!this.tfNgay.isFocus ? 1 : 0) == 0)
        this.right = this.tfNgay.cmdClear;
      else if ((!this.tfThang.isFocus ? 1 : 0) == 0)
        this.right = this.tfThang.cmdClear;
      else if ((!this.tfNam.isFocus ? 1 : 0) == 0)
        this.right = this.tfNam.cmdClear;
      else if ((!this.tfDiachi.isFocus ? 1 : 0) == 0)
        this.right = this.tfDiachi.cmdClear;
      else if ((!this.tfCMND.isFocus ? 1 : 0) == 0)
        this.right = this.tfCMND.cmdClear;
      else if ((!this.tfNgayCap.isFocus ? 1 : 0) == 0)
        this.right = this.tfNgayCap.cmdClear;
      else if ((!this.tfNoiCap.isFocus ? 1 : 0) == 0)
        this.right = this.tfNoiCap.cmdClear;
      else if ((!this.tfSodt.isFocus ? 1 : 0) == 0)
        this.right = this.tfSodt.cmdClear;
    }
    if ((!GClass62.bool_11[Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      this.int_6 -= Class15.smethod_0(1);
      if (this.int_6 < Class15.smethod_0(0))
        this.int_6 = Class15.smethod_0(88);
      this.method_13();
    }
    else if ((!GClass62.bool_11[Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      this.int_6 += Class15.smethod_0(1);
      if (this.int_6 > Class15.smethod_0(88))
        this.int_6 = Class15.smethod_0(0);
      this.method_13();
    }
    if ((!GClass62.bool_11[Class15.smethod_0(27)] ? 0 : 1) != 0 || (!GClass62.bool_11[Class15.smethod_0(28)] ? 1 : 0) == 0)
    {
      GClass62.smethod_24();
      if ((!this.isLogin2 ? 1 : 0) != 0 || (!this.isRes ? 1 : 0) == 0)
      {
        if (this.int_6 == Class15.smethod_0(1))
        {
          this.tfUser.isFocus = Class15.smethod_0(0) != 0;
          this.tfNgay.isFocus = Class15.smethod_0(1) != 0;
        }
        else if ((this.int_6 == 0 ? 0 : 1) == 0)
        {
          this.tfUser.isFocus = Class15.smethod_0(1) != 0;
          this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
        }
        else
        {
          this.tfUser.isFocus = Class15.smethod_0(0) != 0;
          this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
        }
      }
    }
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((!this.isRes ? 1 : 0) == 0)
      {
        this.center = this.gclass31_3;
        this.left = this.gclass31_5;
      }
      else
      {
        this.center = this.gclass31_7;
        this.left = this.gclass31_2;
      }
    }
    else if ((!this.isRes ? 1 : 0) == 0)
    {
      this.center = this.gclass31_3;
      this.left = this.gclass31_5;
    }
    else
    {
      this.center = this.gclass31_7;
      this.left = this.gclass31_2;
    }
    if ((!GClass62.bool_16 ? 1 : 0) == 0)
    {
      if ((!GClass62.smethod_22(this.tfUser.x, this.tfUser.y, this.tfUser.width, this.tfUser.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(0);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfNgay.x, this.tfNgay.y, this.tfNgay.width, this.tfNgay.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(1);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfThang.x, this.tfThang.y, this.tfThang.width, this.tfThang.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(7);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfNam.x, this.tfNam.y, this.tfNam.width, this.tfNam.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(5);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfDiachi.x, this.tfDiachi.y, this.tfDiachi.width, this.tfDiachi.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(2);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfCMND.x, this.tfCMND.y, this.tfCMND.width, this.tfCMND.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(3);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfNgayCap.x, this.tfNgayCap.y, this.tfNgayCap.width, this.tfNgayCap.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(37);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfNoiCap.x, this.tfNoiCap.y, this.tfNoiCap.width, this.tfNoiCap.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(38);
        this.method_13();
      }
      else if ((!GClass62.smethod_22(this.tfSodt.x, this.tfSodt.y, this.tfSodt.width, this.tfSodt.height) ? 1 : 0) == 0)
      {
        this.int_6 = Class15.smethod_0(88);
        this.method_13();
      }
    }
    base.vmethod_4();
    GClass62.smethod_24();
  }

  public void method_14() => this.int_8 = Class15.smethod_0(141);

  public void imethod_0(int idAction, object p)
  {
    if (idAction <= Class15.smethod_0(409))
    {
      switch (idAction - Class15.smethod_0(15))
      {
        case 0:
          try
          {
            GClass63.gclass63_0.method_3((string) p);
          }
          catch (Exception ex)
          {
            ex.StackTrace.ToString();
          }
          GClass62.smethod_27();
          break;
        case 1:
          GClass62.smethod_27();
          this.isRes = Class15.smethod_0(0) != 0;
          break;
        case 2:
          break;
        case 3:
          GClass157.smethod_0().imethod_4();
          GClass62.gclass120_0.vmethod_0();
          break;
        case 4:
          GClass120.smethod_3();
          GClass62.gclass120_0.vmethod_0();
          break;
        case 5:
          try
          {
            GClass63.gclass63_0.method_3(Class13.smethod_0(131158));
            break;
          }
          catch (Exception ex)
          {
            ex.StackTrace.ToString();
            break;
          }
        default:
          switch (idAction - Class15.smethod_0(406))
          {
            case 0:
              if ((!this.isCheck ? 1 : 0) == 0)
              {
                this.isCheck = Class15.smethod_0(0) != 0;
                return;
              }
              this.isCheck = Class15.smethod_0(1) != 0;
              return;
            case 1:
              this.method_2();
              return;
            case 2:
              this.method_1();
              return;
            case 3:
              this.method_16();
              return;
            case 4:
              return;
            case 5:
              return;
            case 6:
              return;
            case 7:
              if ((!this.tfNgay.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfThang.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfNam.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfDiachi.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfCMND.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfNgayCap.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfNoiCap.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfSodt.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!this.tfUser.method_21().Equals(string.Empty) ? 1 : 0) != 0)
              {
                GClass62.smethod_28(GClass109.string_83);
                GClass156.smethod_0().method_3(this.tfNgay.method_21(), this.tfThang.method_21(), this.tfNam.method_21(), this.tfDiachi.method_21(), this.tfCMND.method_21(), this.tfNgayCap.method_21(), this.tfNoiCap.method_21(), this.tfSodt.method_21(), this.tfUser.method_21());
                return;
              }
              GClass62.smethod_28(Class13.smethod_0(131254));
              return;
            default:
              return;
          }
      }
    }
    else if (idAction != Class15.smethod_0(370))
    {
      if (idAction != Class15.smethod_0(408))
        return;
      this.method_15();
    }
    else
      this.method_3(this.tfUser.method_21());
  }

  public void method_15()
  {
    if ((!this.isLogin2 ? 1 : 0) == 0)
    {
      this.method_8();
    }
    else
    {
      this.isRes = Class15.smethod_0(0) != 0;
      this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
      this.tfUser.isFocus = Class15.smethod_0(1) != 0;
      this.left = this.gclass31_4;
    }
  }

  public void method_16()
  {
    GClass62.smethod_27();
    GClass62.smethod_28(GClass109.string_421);
    this.isRes = Class15.smethod_0(1) != 0;
    this.tfNgay.isFocus = Class15.smethod_0(0) != 0;
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
  }

  public void method_17()
  {
    if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) == 0)
    {
      GClass62.smethod_34(GClass109.string_420, new GClass31(GClass109.string_135, (GInterface0) GClass62.gclass141_0, Class15.smethod_0(307), (object) null), new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass141_0, Class15.smethod_0(308), (object) null));
    }
    else
    {
      GClass62.gclass62_0.method_9((GClass113) GClass62.gclass117_0);
      GClass157.smethod_0().imethod_4();
    }
  }

  static GClass125()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.hdrvmtPMOjpc));
    GClass125.int_10 = (int[]) Class15.smethod_4(byte_0);
  }
}
