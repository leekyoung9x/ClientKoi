// Decompiled with JetBrains decompiler
// Type: GClass117
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass117 : GClass113, GInterface0
{
  public GClass184 tfUser;
  public GClass184 tfPass;
  public static bool bool_0 = Class15.smethod_0(0) != 0;
  private int int_6;
  private int int_7;
  private int int_8;
  private int int_9;
  public bool isCheck;
  public bool isRes;
  public GClass31 cmdLogin;
  public GClass31 cmdCheck;
  public GClass31 cmdFogetPass;
  public GClass31 cmdRes;
  public GClass31 cmdMenu;
  public GClass31 cmdBackFromRegister;
  public string listFAQ = string.Empty;
  public string titleFAQ;
  public string subtitleFAQ;
  private string string_0 = string.Empty;
  public static bool bool_1 = Class15.smethod_0(0) != 0;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  public static bool bool_5;
  public static bool bool_6;
  public static string string_1;
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
  private GClass31 gclass31_0;
  private GClass31 gclass31_1;
  private int int_12;
  private int int_13;
  public static GClass63 gclass63_0;
  private int int_14 = GClass62.int_13 - GClass113.int_0 - Class15.smethod_0(3);
  private int int_15;
  private int int_16;
  private int int_17;
  private int int_18;
  private int int_19;
  private int int_20 = Class15.smethod_0(51);
  private bool bool_8;
  private string string_2 = string.Empty;
  public bool isFAQ;
  private int int_21 = -1;
  public bool isLogin2;
  private int int_22 = Class15.smethod_0(7);
  private int int_23;
  private int int_24 = Class15.smethod_0(268);
  private int int_25 = Class15.smethod_0(1);
  private GClass31 gclass31_2;
  public static bool bool_9;

  public GClass117()
  {
    this.int_13 = GClass62.int_13 - Class15.smethod_0(6);
    GClass185.int_40 = (int) (sbyte) (GClass126.smethod_18() % (long) Class15.smethod_0(45));
    if (GClass185.int_40 == Class15.smethod_0(3) || GClass185.int_40 == Class15.smethod_0(37))
      GClass185.int_40 = Class15.smethod_0(2);
    GClass116.smethod_8(Class15.smethod_0(1) != 0, -1, -1);
    GClass116.int_22 = Class15.smethod_0(21);
    GClass116.int_23 = Class15.smethod_0(90);
    Main.smethod_1();
    this.int_9 = GClass62.int_11 <= Class15.smethod_0(90) ? GClass62.int_13 - Class15.smethod_0(130) : GClass62.int_13 - Class15.smethod_0(25);
    this.method_13();
    this.int_7 = GClass62.int_10 < Class15.smethod_0(90) ? Class15.smethod_0(399) : Class15.smethod_0(195);
    this.int_11 = GClass62.int_13 - GClass113.int_0 - Class15.smethod_0(3);
    if (GClass62.int_11 <= Class15.smethod_0(195))
      this.int_11 = Class15.smethod_0(51);
    this.tfUser = new GClass184();
    this.tfUser.y = GClass62.int_13 - GClass113.int_0 - Class15.smethod_0(45);
    this.tfUser.width = this.int_7;
    this.tfUser.height = GClass113.int_0 + Class15.smethod_0(7);
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
    this.tfUser.method_28(GClass184.int_7);
    this.tfUser.name = ((int) GClass109.sbyte_0 != Class15.smethod_0(7) ? GClass109.string_65 + Class13.smethod_0(158513) : string.Empty) + GClass109.string_66;
    this.tfPass = new GClass184();
    this.tfPass.y = GClass62.int_13 - Class15.smethod_0(2);
    this.tfPass.method_28(GClass184.int_9);
    this.tfPass.width = this.int_7;
    this.tfPass.height = GClass113.int_0 + Class15.smethod_0(7);
    this.int_11 += Class15.smethod_0(95);
    this.isCheck = Class15.smethod_0(1) != 0;
    int num1 = GClass152.smethod_8(Class13.smethod_0(158468));
    if (num1 != Class15.smethod_0(1))
    {
      if (num1 == Class15.smethod_0(7))
        this.isCheck = Class15.smethod_0(0) != 0;
    }
    else
      this.isCheck = Class15.smethod_0(1) != 0;
    this.tfUser.method_23(GClass152.smethod_2(Class13.smethod_0(158590)));
    this.tfPass.method_23(GClass152.smethod_2(Class13.smethod_0(158586)));
    if (this.gclass31_2 == null)
    {
      this.gclass31_2 = new GClass31(Class13.smethod_0(158579), (GInterface0) this, Class15.smethod_0(47), (object) null);
      this.gclass31_2.x = GClass62.int_10 - Class15.smethod_0(62);
      this.gclass31_2.y = GClass126.int_0 != Class15.smethod_0(1) || GClass62.bool_5 ? Class15.smethod_0(7) + Class15.smethod_0(37) : GClass62.int_11 - Class15.smethod_0(51);
    }
    this.int_6 = Class15.smethod_0(0);
    this.cmdLogin = new GClass31(GClass62.int_10 <= Class15.smethod_0(90) ? GClass109.string_80 : GClass109.string_79, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(405), (object) null);
    this.cmdCheck = new GClass31(GClass109.string_143, (GInterface0) this, Class15.smethod_0(406), (object) null);
    this.cmdRes = new GClass31(GClass109.string_81, (GInterface0) this, Class15.smethod_0(407), (object) null);
    this.cmdBackFromRegister = new GClass31(GClass109.string_145, (GInterface0) this, Class15.smethod_0(408), (object) null);
    this.left = this.cmdMenu = new GClass31(GClass109.string_124, (GInterface0) this, Class15.smethod_0(363), (object) null);
    this.int_15 = this.tfUser.y - Class15.smethod_0(7) * this.tfUser.height;
    if (GClass62.bool_5)
    {
      this.cmdLogin.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(88);
      this.cmdMenu.x = GClass62.int_10 / Class15.smethod_0(7) - GClass113.int_2 - Class15.smethod_0(88);
      if (GClass62.int_11 >= Class15.smethod_0(90))
      {
        this.cmdLogin.y = this.int_13 + Class15.smethod_0(80);
        this.cmdMenu.y = this.int_13 + Class15.smethod_0(80);
      }
      this.cmdBackFromRegister.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(5);
      this.cmdBackFromRegister.y = this.int_13 + Class15.smethod_0(80);
      this.cmdRes.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(39);
      this.cmdRes.y = this.cmdMenu.y;
    }
    this.int_18 = Class15.smethod_0(162);
    this.int_19 = !this.isRes ? Class15.smethod_0(21) : Class15.smethod_0(80);
    this.int_16 = GClass62.int_12 - this.int_18 / Class15.smethod_0(7);
    this.int_17 = this.tfUser.y - Class15.smethod_0(9);
    int num2 = Class15.smethod_0(2);
    int num3 = num2 * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
    if (num3 >= GClass62.int_10)
      num3 = (num2 - Class15.smethod_0(1)) * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
    this.int_12 = GClass62.int_10 / Class15.smethod_0(7) - num3 / Class15.smethod_0(7);
    this.int_13 = GClass62.int_13 - Class15.smethod_0(6);
    this.lY = GClass62.int_10 < Class15.smethod_0(90) ? this.tfUser.y - Class15.smethod_0(6) : this.int_13 - Class15.smethod_0(6);
    this.tfUser.x = this.int_12 + Class15.smethod_0(31);
    this.tfUser.y = this.int_13 + Class15.smethod_0(51);
    this.gclass31_1 = new GClass31(GClass109.string_140, (GInterface0) this, Class15.smethod_0(409), (object) null);
    this.gclass31_1.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(39);
    this.gclass31_1.y = this.cmdLogin.y;
    this.cmdFogetPass = new GClass31(GClass109.string_57, (GInterface0) this, Class15.smethod_0(410), (object) null);
    this.cmdFogetPass.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(5);
    this.cmdFogetPass.y = this.cmdLogin.y;
    this.center = this.gclass31_1;
    this.left = this.cmdFogetPass;
  }

  public static void smethod_2()
  {
    try
    {
      if ((!GClass117.bool_7 ? 1 : 0) == 0)
        return;
      GClass31 gclass31_1 = new GClass31();
      GClass31 gclass31 = gclass31_1;
      // ISSUE: reference to a compiler-generated field
      GDelegate0 gdelegate0 = GClass117.\u003C\u003Ec.\u003C\u003E9__64_0;
      if ((gdelegate0 == null ? 0 : 1) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        gdelegate0 = GClass117.\u003C\u003Ec.\u003C\u003E9__64_0 = (GDelegate0) (string_0 =>
        {
          try
          {
            if ((string_0 == null ? 1 : 0) != 0 || (!(string_0 == string.Empty) ? 0 : 1) != 0)
              return;
            GClass152.smethod_19(string_0);
            if ((!string_0.Contains(Class13.smethod_0(149980)) ? 1 : 0) != 0)
              return;
            int length = string_0.IndexOf(Class13.smethod_0(149980));
            string host = string_0.Substring(Class15.smethod_0(0), length);
            string s = string_0.Substring(length + Class15.smethod_0(1));
            GClass63.string_0 = host;
            GClass63.int_0 = int.Parse(s);
            GClass157.smethod_0().imethod_2(host, int.Parse(s));
            GClass117.bool_7 = Class15.smethod_0(1) != 0;
          }
          catch (Exception ex)
          {
          }
        });
      }
      gclass31.actionChat = gdelegate0;
      Class3.smethod_1(GClass120.string_8, gclass31_1);
    }
    catch (Exception ex)
    {
    }
  }

  public override void vmethod_0()
  {
    this.bool_8 = Class15.smethod_0(0) != 0;
    GClass172.smethod_1().method_51();
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
    this.tfPass.isFocus = Class15.smethod_0(0) != 0;
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
      this.tfUser.isFocus = Class15.smethod_0(0) != 0;
    GClass62.smethod_19(Class15.smethod_0(0));
    base.vmethod_0();
  }

  public void method_0()
  {
    string text1 = GClass152.smethod_2(Class13.smethod_0(158392));
    if ((text1 == null ? 1 : 0) == 0 && (!text1.Equals(string.Empty) ? 0 : 1) == 0)
      this.tfUser.method_23(text1);
    string text2 = GClass152.smethod_2(Class13.smethod_0(158383));
    if ((text2 == null ? 1 : 0) != 0 || (!text2.Equals(string.Empty) ? 0 : 1) != 0)
      return;
    this.tfPass.method_23(text2);
  }

  public void method_1()
  {
  }

  protected void method_2()
  {
    GClass134 menuItems = new GClass134();
    menuItems.method_0((object) new GClass31(GClass109.string_54, (GInterface0) this, Class15.smethod_0(364), (object) null));
    if ((!this.isLogin2 ? 0 : 1) == 0)
      menuItems.method_0((object) new GClass31(GClass109.string_55, (GInterface0) this, Class15.smethod_0(411), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_57, (GInterface0) this, Class15.smethod_0(410), (object) null));
    menuItems.method_0((object) new GClass31(GClass109.string_95, (GInterface0) this, Class15.smethod_0(412), (object) null));
    if ((!Main.bool_3 ? 1 : 0) == 0)
      menuItems.method_0((object) new GClass31(GClass109.string_137, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(269), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
  }

  protected void method_3()
  {
    if ((!this.tfUser.method_21().Equals(string.Empty) ? 1 : 0) == 0)
    {
      GClass62.smethod_28(GClass109.string_49);
    }
    else
    {
      this.tfUser.method_21().ToCharArray();
      if ((!this.tfPass.method_21().Equals(string.Empty) ? 1 : 0) == 0)
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
          if (this.tfUser.method_21().IndexOf(Class13.smethod_0(158403)) == -1 || this.tfUser.method_21().IndexOf(Class13.smethod_0(158401)) == -1)
            info1 = GClass109.string_53;
          num = Class15.smethod_0(0);
        }
        else
        {
          try
          {
            long.Parse(this.tfUser.method_21());
            if (this.tfUser.method_21().Length < Class15.smethod_0(88) || this.tfUser.method_21().Length > Class15.smethod_0(66) || (!this.tfUser.method_21().StartsWith(Class13.smethod_0(159034)) ? 0 : 1) == 0 && (!this.tfUser.method_21().StartsWith(Class13.smethod_0(159018)) ? 0 : 1) == 0)
              info1 = GClass109.string_52;
            num = Class15.smethod_0(1);
          }
          catch (Exception ex)
          {
            if (this.tfUser.method_21().IndexOf(Class13.smethod_0(158403)) == -1 || this.tfUser.method_21().IndexOf(Class13.smethod_0(158401)) == -1)
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
          strArray[Class15.smethod_0(1)] = num != Class15.smethod_0(1) ? GClass109.string_66 + Class13.smethod_0(158980) : GClass109.string_65 + Class13.smethod_0(158980);
          strArray[Class15.smethod_0(7)] = this.tfUser.method_21();
          strArray[Class15.smethod_0(5)] = Class13.smethod_0(153495);
          strArray[Class15.smethod_0(2)] = GClass109.string_58;
          strArray[Class15.smethod_0(3)] = Class13.smethod_0(158980);
          strArray[Class15.smethod_0(37)] = this.tfPass.method_21();
          string info2 = string.Concat(strArray);
          GClass31 left = new GClass31(GClass109.string_144, (GInterface0) this, Class15.smethod_0(370), (object) null);
          GClass31 right = new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(327), (object) null);
          gclass390.method_2(info2, left, (GClass31) null, right);
        }
        GClass62.gclass37_0 = (GClass37) GClass62.gclass39_0;
      }
    }
  }

  protected void method_4(string user)
  {
    this.isFAQ = Class15.smethod_0(0) != 0;
    GClass62.smethod_29(GClass109.string_84);
    GClass62.smethod_4();
    GClass62.smethod_29(GClass109.string_35);
    this.string_2 = this.tfPass.method_21();
    GClass156.smethod_0().method_40(user, this.tfPass.method_21(), GClass152.smethod_2(Class13.smethod_0(153125) + GClass120.int_12.ToString()), GClass152.smethod_2(Class13.smethod_0(153118) + GClass120.int_12.ToString()), GClass63.string_2);
    GClass152.smethod_4(Class13.smethod_0(153098), user);
    GClass152.smethod_4(Class13.smethod_0(153328), this.tfPass.method_21());
    this.int_20 = Class15.smethod_0(51);
    this.bool_8 = Class15.smethod_0(1) != 0;
  }

  public void method_5()
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

  protected void method_6()
  {
    GClass134 menuItems = new GClass134();
    if ((!GClass117.bool_1 ? 1 : 0) == 0)
      menuItems.method_0((object) new GClass31(Class13.smethod_0(153285), (GInterface0) this, Class15.smethod_0(413), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(153912), (GInterface0) this, Class15.smethod_0(414), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(153898), (GInterface0) this, Class15.smethod_0(415), (object) null));
    menuItems.method_0((object) new GClass31(Class13.smethod_0(153882), (GInterface0) this, Class15.smethod_0(416), (object) null));
    GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(0));
    if (this.method_8() == -1 || (!GClass62.bool_5 ? 0 : 1) != 0)
      return;
    GClass62.gclass95_0.menuSelectedItem = this.method_8();
  }

  protected void method_7(int index) => GClass152.smethod_9(Class13.smethod_0(153970), index);

  protected int method_8() => GClass152.smethod_8(Class13.smethod_0(153960));

  public void method_9()
  {
    string username = GClass152.smethod_2(Class13.smethod_0(153950));
    string pass = GClass152.smethod_2(Class13.smethod_0(153946));
    this.isLogin2 = (username == null ? 1 : 0) != 0 || (!username.Equals(string.Empty) ? 0 : 1) != 0 ? ((GClass152.smethod_2(Class13.smethod_0(153941) + GClass120.int_12.ToString()) == null ? 1 : 0) != 0 || (!GClass152.smethod_2(Class13.smethod_0(153941) + GClass120.int_12.ToString()).Equals(string.Empty) ? 0 : 1) != 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0) : Class15.smethod_0(0) != 0;
    if (((username == null ? 1 : 0) != 0 || (!username.Equals(string.Empty) ? 1 : 0) == 0) && (!this.isLogin2 ? 1 : 0) == 0)
    {
      username = GClass152.smethod_2(Class13.smethod_0(153941) + GClass120.int_12.ToString());
      pass = Class13.smethod_0(153934);
    }
    if ((username == null ? 1 : 0) != 0 || (pass == null ? 1 : 0) != 0 || (GClass63.string_2 == null ? 1 : 0) != 0 || (!username.Equals(string.Empty) ? 1 : 0) == 0)
      return;
    if ((!pass.Equals(string.Empty) ? 1 : 0) == 0)
    {
      this.int_6 = Class15.smethod_0(1);
      this.tfUser.isFocus = Class15.smethod_0(0) != 0;
      this.tfPass.isFocus = Class15.smethod_0(1) != 0;
      if ((!GClass62.bool_5 ? 0 : 1) != 0)
        return;
      this.right = this.tfPass.cmdClear;
    }
    else
    {
      GClass62.smethod_4();
      string[] strArray = new string[Class15.smethod_0(88)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(153932);
      strArray[Class15.smethod_0(1)] = username;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(153923);
      strArray[Class15.smethod_0(5)] = pass;
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(153923);
      strArray[Class15.smethod_0(3)] = GClass63.string_2;
      strArray[Class15.smethod_0(37)] = Class13.smethod_0(153923);
      strArray[Class15.smethod_0(38)] = ((!this.isLogin2 ? 0 : 1) != 0 ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0)).ToString();
      GClass151.smethod_7(string.Concat(strArray));
      GClass156.smethod_0().method_39(username, pass, GClass63.string_2, (!this.isLogin2 ? 0 : 1) != 0 ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0));
      if ((!GClass157.bool_1 ? 1 : 0) == 0)
        GClass62.smethod_31();
      else
        GClass62.smethod_28(GClass109.string_20);
      this.int_6 = Class15.smethod_0(0);
      if ((!this.isLogin2 ? 0 : 1) != 0)
        return;
      this.method_14();
    }
  }

  public void method_10()
  {
    if ((!this.isCheck ? 1 : 0) == 0)
    {
      GClass152.smethod_9(Class13.smethod_0(153772), Class15.smethod_0(1));
      GClass152.smethod_4(Class13.smethod_0(154139), this.tfUser.method_21().ToLower().Trim());
      GClass152.smethod_4(Class13.smethod_0(154133), this.tfPass.method_21().ToLower().Trim());
    }
    else
    {
      GClass152.smethod_9(Class13.smethod_0(153772), Class15.smethod_0(7));
      GClass152.smethod_4(Class13.smethod_0(154139), string.Empty);
      GClass152.smethod_4(Class13.smethod_0(154133), string.Empty);
    }
  }

  public override void vmethod_3()
  {
    if ((!Main.bool_4 ? 1 : 0) == 0 && (!this.bool_8 ? 1 : 0) == 0)
    {
      if (this.int_20 < Class15.smethod_0(0))
      {
        GClass62.smethod_27();
        GClass157.smethod_0().imethod_4();
        GClass62.gclass120_0.vmethod_0();
        this.bool_8 = Class15.smethod_0(0) != 0;
      }
      else
        this.int_20 -= Class15.smethod_0(1);
    }
    if ((int) GClass117.short_0 > Class15.smethod_0(0))
    {
      GClass62.smethod_31();
      GClass117.long_1 = GClass126.smethod_18();
      if (GClass117.long_1 - GClass117.long_0 >= (long) Class15.smethod_0(15))
      {
        GClass117.short_0 -= (short) Class15.smethod_0(1);
        if ((GClass117.short_0 == (short) 0 ? 0 : 1) == 0)
        {
          GClass157.smethod_0().imethod_4();
          GClass62.gclass117_0.method_9();
        }
        GClass117.long_0 = GClass117.long_1;
      }
    }
    if ((!this.isLogin2 ? 1 : 0) == 0 && (!this.isRes ? 0 : 1) == 0)
    {
      this.tfUser.name = ((int) GClass109.sbyte_0 != Class15.smethod_0(7) ? GClass109.string_65 + Class13.smethod_0(154201) : string.Empty) + GClass109.string_66;
      this.tfPass.name = GClass109.string_58;
      this.tfUser.isPaintCarret = Class15.smethod_0(0) != 0;
      this.tfPass.isPaintCarret = Class15.smethod_0(0) != 0;
      this.tfUser.method_17();
      this.tfPass.method_17();
    }
    else
    {
      this.tfUser.name = ((int) GClass109.sbyte_0 != Class15.smethod_0(7) ? GClass109.string_65 + Class13.smethod_0(154201) : string.Empty) + GClass109.string_66;
      this.tfPass.name = GClass109.string_58;
      this.tfUser.method_17();
      this.tfPass.method_17();
    }
    if ((!GClass188.bool_1 ? 1 : 0) == 0)
      GClass98.int_20 = Class15.smethod_0(32);
    for (int index = Class15.smethod_0(0); index < GClass42.gclass134_1.method_2(); index += Class15.smethod_0(1))
      ((GClass42) GClass42.gclass134_1.method_3(index)).vmethod_0();
    if ((!GClass117.bool_2 ? 1 : 0) == 0 && (!GClass117.bool_3 ? 0 : 1) == 0 && (!GClass117.bool_6 ? 0 : 1) == 0 && (!GClass117.bool_4 ? 0 : 1) == 0 && (!GClass117.bool_5 ? 0 : 1) == 0)
    {
      GClass117.bool_2 = Class15.smethod_0(0) != 0;
      GClass126.smethod_26();
      GClass156.smethod_0().method_116();
    }
    GClass116.int_22 += Class15.smethod_0(1);
    if (GClass116.int_22 > GClass62.int_10 * Class15.smethod_0(5) + Class15.smethod_0(21))
      GClass116.int_22 = Class15.smethod_0(21);
    if ((GClass43.gclass43_0 == null ? 1 : 0) == 0)
      return;
    GClass62.smethod_7(Class13.smethod_0(154191), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(154186), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(154181), Class15.smethod_0(0));
    this.method_12();
    GClass62.smethod_7(Class13.smethod_0(154176), Class15.smethod_0(0));
    GClass62.smethod_7(Class13.smethod_0(154299), Class15.smethod_0(0));
    if (this.int_23 >= Class15.smethod_0(0))
    {
      this.int_24 += this.int_25 * this.int_23;
      this.int_23 += this.int_25 * this.int_22;
      if (this.int_23 <= Class15.smethod_0(0))
        this.int_25 *= -1;
      if (this.int_24 > Class15.smethod_0(0))
      {
        this.int_25 *= -1;
        this.int_23 -= Class15.smethod_0(7) * this.int_22;
      }
    }
    GClass62.smethod_7(Class13.smethod_0(154289), Class15.smethod_0(0));
    if (this.int_21 >= Class15.smethod_0(0) && (GClass62.int_8 % Class15.smethod_0(21) == 0 ? 0 : 1) == 0)
      this.method_11();
    if ((!this.isLogin2 ? 1 : 0) == 0 && (!this.isRes ? 0 : 1) == 0)
    {
      this.tfUser.isPaintCarret = Class15.smethod_0(0) != 0;
      this.tfPass.isPaintCarret = Class15.smethod_0(0) != 0;
      this.tfUser.method_17();
      this.tfPass.method_17();
    }
    else
    {
      this.tfUser.name = ((int) GClass109.sbyte_0 != Class15.smethod_0(7) ? GClass109.string_65 + Class13.smethod_0(154201) : string.Empty) + GClass109.string_66;
      this.tfPass.name = GClass109.string_58;
      this.tfUser.method_17();
      this.tfPass.method_17();
    }
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((!this.isRes ? 1 : 0) == 0)
      {
        this.center = this.cmdRes;
        this.left = this.cmdBackFromRegister;
      }
      else
      {
        this.center = this.gclass31_1;
        this.left = this.cmdFogetPass;
      }
    }
    else if ((!this.isRes ? 1 : 0) == 0)
    {
      this.center = this.cmdRes;
      this.left = this.cmdBackFromRegister;
    }
    else
    {
      this.center = this.gclass31_1;
      this.left = this.cmdFogetPass;
    }
    if ((!Main.bool_3 ? 0 : 1) == 0 && (!GClass188.bool_1 ? 0 : 1) == 0 && (!Main.bool_9 ? 0 : 1) == 0 && (!Main.bool_4 ? 0 : 1) == 0)
    {
      string str1 = this.tfUser.method_21().ToLower().Trim();
      string str2 = this.tfPass.method_21().ToLower().Trim();
      string empty = string.Empty;
      if ((!str1.Equals(empty) ? 0 : 1) == 0 && (!str2.Equals(string.Empty) ? 0 : 1) == 0)
        this.method_9();
      Main.bool_9 = Class15.smethod_0(1) != 0;
    }
    this.method_1();
  }

  private void method_11()
  {
    this.int_21 += Class15.smethod_0(1);
    if (this.int_21 >= GClass109.string_114.Length)
      this.int_21 = Class15.smethod_0(0);
    if (GClass62.gclass37_0 != GClass62.gclass39_0 || (!GClass62.gclass39_0.isWait ? 1 : 0) != 0)
      return;
    GClass62.gclass39_0.method_1(GClass109.string_114[this.int_21]);
  }

  public void method_12()
  {
    if (this.int_9 == this.int_8)
      return;
    this.int_8 += this.int_9 - this.int_8 >> Class15.smethod_0(1);
  }

  public override void vmethod_2(int keyCode)
  {
    if ((!this.tfUser.isFocus ? 1 : 0) == 0)
      this.tfUser.method_10(keyCode);
    else if ((!this.tfPass.isFocus ? 1 : 0) == 0)
      this.tfPass.method_10(keyCode);
    base.vmethod_2(keyCode);
  }

  public override void vmethod_1() => base.vmethod_1();

  public override void vmethod_5(GClass98 g)
  {
    GClass62.smethod_7(Class13.smethod_0(155414), Class15.smethod_0(1));
    GClass62.smethod_16(g);
    GClass62.smethod_7(Class13.smethod_0(155396), Class15.smethod_0(7));
    int y = this.tfUser.y - Class15.smethod_0(32);
    if (GClass62.int_11 <= Class15.smethod_0(99))
      y += Class15.smethod_0(3);
    GClass97.gclass97_20.method_10(g, Class13.smethod_0(155519) + GClass13.gclass13_0.method_45(), GClass62.int_10 - Class15.smethod_0(7), Class15.smethod_0(186), Class15.smethod_0(1), GClass97.gclass97_16);
    if (GClass126.int_0 == Class15.smethod_0(1) && (!GClass62.bool_5 ? 0 : 1) == 0)
      GClass97.gclass97_20.method_10(g, GClass13.gclass13_0.method_44(), GClass62.int_10 - Class15.smethod_0(7), GClass62.int_11 - Class15.smethod_0(9), Class15.smethod_0(1), GClass97.gclass97_16);
    else
      GClass97.gclass97_20.method_10(g, GClass13.gclass13_0.method_44(), GClass62.int_10 - Class15.smethod_0(7), Class15.smethod_0(7), Class15.smethod_0(1), GClass97.gclass97_16);
    if ((GClass43.gclass43_0 == null ? 0 : 1) != 0 || (GClass43.gclass43_1 == null ? 1 : 0) == 0)
      return;
    if ((GClass62.gclass37_0 == null ? 0 : 1) == 0)
    {
      int h = Class15.smethod_0(57);
      int w = GClass62.int_10 < Class15.smethod_0(90) ? Class15.smethod_0(195) : Class15.smethod_0(96);
      GClass148.smethod_4(g, this.int_12, this.int_13 - Class15.smethod_0(31), w, h, -1, Class15.smethod_0(1) != 0);
      g.method_32(GClass13.gclass13_0.method_37(), GClass62.int_12, y, Class15.smethod_0(5));
      GClass62.smethod_7(Class13.smethod_0(155517), Class15.smethod_0(1));
      int num1 = Class15.smethod_0(2);
      int num2 = num1 * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
      if (num2 >= GClass62.int_10)
        num2 = (num1 - Class15.smethod_0(1)) * Class15.smethod_0(120) + Class15.smethod_0(29) + Class15.smethod_0(48);
      this.int_12 = GClass62.int_10 / Class15.smethod_0(7) - num2 / Class15.smethod_0(7);
      this.tfUser.x = this.int_12 + Class15.smethod_0(31);
      this.tfUser.y = this.int_13 + Class15.smethod_0(51);
      this.tfPass.x = this.int_12 + Class15.smethod_0(31);
      this.tfPass.y = this.int_13 + Class15.smethod_0(280);
      this.tfUser.method_13(g);
      this.tfPass.method_13(g);
      if (GClass62.int_10 < Class15.smethod_0(314))
      {
        GClass97.gclass97_7.method_6(g, GClass109.string_67 + Class13.smethod_0(149175), this.tfUser.x - Class15.smethod_0(95), this.tfUser.y + Class15.smethod_0(38), Class15.smethod_0(0));
        GClass97.gclass97_7.method_6(g, GClass109.string_68 + Class13.smethod_0(149175), this.tfPass.x - Class15.smethod_0(95), this.tfPass.y + Class15.smethod_0(38), Class15.smethod_0(0));
        GClass97.gclass97_7.method_6(g, GClass109.string_96 + Class13.smethod_0(149175) + GClass117.string_1, GClass62.int_10 / Class15.smethod_0(7), this.tfPass.y + Class15.smethod_0(120), Class15.smethod_0(7));
      }
    }
    base.vmethod_5(g);
  }

  public override void vmethod_4()
  {
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((this.gclass31_2 == null ? 1 : 0) == 0 && (!this.gclass31_2.method_4() ? 1 : 0) == 0)
        this.gclass31_2.method_1();
    }
    else if (GClass126.int_0 == Class15.smethod_0(1) && (!GClass62.bool_11[Class15.smethod_0(47)] ? 1 : 0) == 0)
    {
      GClass62.bool_11[Class15.smethod_0(47)] = Class15.smethod_0(0) != 0;
      this.gclass31_2.method_1();
    }
    if ((!GClass117.bool_0 ? 1 : 0) == 0)
      return;
    if ((!GClass62.bool_5 ? 0 : 1) == 0)
    {
      if ((!this.tfUser.isFocus ? 1 : 0) == 0)
        this.right = this.tfUser.cmdClear;
      else
        this.right = this.tfPass.cmdClear;
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 1 : 0) == 0)
    {
      this.int_6 -= Class15.smethod_0(1);
      if (this.int_6 < Class15.smethod_0(0))
        this.int_6 = Class15.smethod_0(1);
    }
    else if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 0 : 1) != 0 || (!GClass62.bool_11[Class15.smethod_0(10)] ? 1 : 0) == 0)
    {
      this.int_6 += Class15.smethod_0(1);
      if (this.int_6 > Class15.smethod_0(1))
        this.int_6 = Class15.smethod_0(0);
    }
    if ((!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(27)] ? 0 : 1) != 0 || (!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(88) : Class15.smethod_0(28)] ? 0 : 1) != 0 || (!GClass62.bool_11[Class15.smethod_0(10)] ? 1 : 0) == 0)
    {
      GClass62.smethod_24();
      if ((!this.isLogin2 ? 1 : 0) != 0 || (!this.isRes ? 1 : 0) == 0)
      {
        if (this.int_6 == Class15.smethod_0(1))
        {
          this.tfUser.isFocus = Class15.smethod_0(0) != 0;
          this.tfPass.isFocus = Class15.smethod_0(1) != 0;
        }
        else if ((this.int_6 == 0 ? 0 : 1) == 0)
        {
          this.tfUser.isFocus = Class15.smethod_0(1) != 0;
          this.tfPass.isFocus = Class15.smethod_0(0) != 0;
        }
        else
        {
          this.tfUser.isFocus = Class15.smethod_0(0) != 0;
          this.tfPass.isFocus = Class15.smethod_0(0) != 0;
        }
      }
    }
    if ((!GClass62.bool_5 ? 1 : 0) == 0)
    {
      if ((!this.isRes ? 1 : 0) == 0)
      {
        this.center = this.cmdRes;
        this.left = this.cmdBackFromRegister;
      }
      else
      {
        this.center = this.gclass31_1;
        this.left = this.cmdFogetPass;
      }
    }
    else if ((!this.isRes ? 1 : 0) == 0)
    {
      this.center = this.cmdRes;
      this.left = this.cmdBackFromRegister;
    }
    else
    {
      this.center = this.gclass31_1;
      this.left = this.cmdFogetPass;
    }
    if ((!GClass62.bool_16 ? 1 : 0) == 0 && ((!this.isLogin2 ? 1 : 0) != 0 || (!this.isRes ? 1 : 0) == 0))
    {
      if ((!GClass62.smethod_22(this.tfUser.x, this.tfUser.y, this.tfUser.width, this.tfUser.height) ? 1 : 0) == 0)
        this.int_6 = Class15.smethod_0(0);
      else if ((!GClass62.smethod_22(this.tfPass.x, this.tfPass.y, this.tfPass.width, this.tfPass.height) ? 1 : 0) == 0)
        this.int_6 = Class15.smethod_0(1);
    }
    if ((!Main.bool_3 ? 1 : 0) == 0 && (!GClass62.bool_11[(!Main.bool_3 ? 1 : 0) != 0 ? Class15.smethod_0(3) : Class15.smethod_0(46)] ? 1 : 0) == 0 && (this.right == null ? 1 : 0) == 0)
      this.right.method_1();
    base.vmethod_4();
    GClass62.smethod_24();
  }

  public void method_13() => this.int_8 = Class15.smethod_0(141);

  public void imethod_0(int idAction, object p)
  {
    if (idAction <= Class15.smethod_0(409))
    {
      if (idAction != Class15.smethod_0(47))
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
            }
            GClass62.smethod_27();
            break;
          case 1:
            GClass62.smethod_27();
            this.isRes = Class15.smethod_0(0) != 0;
            break;
          case 2:
            GClass62.smethod_31();
            string username = GClass152.smethod_2(Class13.smethod_0(149236) + GClass120.int_12.ToString());
            if ((username == null ? 1 : 0) == 0 && (!username.Equals(string.Empty) ? 1 : 0) != 0)
            {
              GClass62.gclass117_0.isLogin2 = Class15.smethod_0(1) != 0;
              GClass62.smethod_4();
              GClass156.smethod_0().method_35();
              GClass156.smethod_0().method_39(username, string.Empty, GClass63.string_2, (sbyte) Class15.smethod_0(1));
              break;
            }
            GClass156.smethod_0().method_122(string.Empty);
            break;
          case 3:
            GClass62.smethod_28(GClass109.string_69);
            break;
          case 4:
            GClass120.smethod_3();
            GClass62.gclass120_0.vmethod_0();
            break;
          case 5:
            try
            {
              GClass63.gclass63_0.method_3(Class13.smethod_0(149219));
              break;
            }
            catch (Exception ex)
            {
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
                this.method_3();
                return;
              case 2:
                this.method_2();
                return;
              case 3:
                this.method_15();
                return;
              case 4:
                return;
              case 5:
                return;
              case 6:
                return;
              case 7:
                GClass152.smethod_4(Class13.smethod_0(149857), this.tfUser.method_21().Trim());
                GClass152.smethod_4(Class13.smethod_0(149845), this.tfPass.method_21().Trim());
                if ((!GClass120.bool_6 ? 1 : 0) == 0)
                {
                  GClass62.gclass120_0.vmethod_0();
                  return;
                }
                GClass62.gclass120_0.method_7();
                return;
              default:
                return;
            }
        }
      }
      else
      {
        switch (GClass126.int_0 - Class15.smethod_0(1))
        {
          case 0:
            GClass126.smethod_8();
            break;
          case 2:
          case 4:
            GClass126.smethod_9();
            break;
          case 3:
            GClass126.smethod_7();
            break;
          case 5:
            GClass126.smethod_10();
            break;
        }
      }
    }
    else if (idAction <= Class15.smethod_0(408))
    {
      if (idAction != Class15.smethod_0(370))
      {
        if (idAction != Class15.smethod_0(408))
          return;
        this.method_14();
      }
      else
        this.method_4(this.tfUser.method_21());
    }
    else if (idAction != Class15.smethod_0(417))
    {
      if (idAction != Class15.smethod_0(418))
        return;
      GClass152.smethod_9(Class13.smethod_0(149193), Class15.smethod_0(1));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
    else
    {
      GClass152.smethod_9(Class13.smethod_0(149193), Class15.smethod_0(0));
      GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
    }
  }

  public void method_14()
  {
    if ((!this.isLogin2 ? 1 : 0) == 0)
    {
      this.method_9();
    }
    else
    {
      this.isRes = Class15.smethod_0(0) != 0;
      this.tfPass.isFocus = Class15.smethod_0(0) != 0;
      this.tfUser.isFocus = Class15.smethod_0(1) != 0;
      this.left = this.cmdMenu;
    }
  }

  public void method_15()
  {
    GClass62.smethod_27();
    this.isRes = Class15.smethod_0(1) != 0;
    this.tfPass.isFocus = Class15.smethod_0(0) != 0;
    this.tfUser.isFocus = Class15.smethod_0(1) != 0;
  }

  public void method_16()
  {
    if ((!GClass62.gclass117_0.isLogin2 ? 1 : 0) == 0)
    {
      GClass62.smethod_34(GClass109.string_420, new GClass31(GClass109.string_135, (GInterface0) GClass62.gclass141_0, Class15.smethod_0(307), (object) null), new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass141_0, Class15.smethod_0(308), (object) null));
    }
    else
    {
      if ((!Main.bool_4 ? 1 : 0) == 0)
        GClass63.bool_1 = Class15.smethod_0(1) != 0;
      GClass62.gclass62_0.resetToLoginScr = Class15.smethod_0(0) != 0;
      GClass62.gclass62_0.method_9((GClass113) GClass62.gclass117_0);
      GClass157.smethod_0().imethod_4();
    }
  }

  static GClass117()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(60)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.hdrvmtPMOjpc));
    GClass117.int_10 = (int[]) Class15.smethod_4(byte_0);
  }
}
