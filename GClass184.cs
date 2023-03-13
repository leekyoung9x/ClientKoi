// Decompiled with JetBrains decompiler
// Type: GClass184
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class GClass184 : GInterface0
{
  public bool isFocus;
  public int x;
  public int y;
  public int width;
  public int height;
  public bool lockArrow;
  public bool justReturnFromTextBox;
  public bool paintFocus = Class15.smethod_0(1) != 0;
  public const sbyte sbyte_0 = 14;
  public const sbyte sbyte_1 = 15;
  public const sbyte sbyte_2 = 19;
  public static int int_0 = Class15.smethod_0(7);
  private static readonly int[] int_1;
  private static int int_2;
  private static readonly int int_3;
  private static readonly int int_4;
  private static readonly int int_5;
  private static readonly int int_6;
  public static readonly int int_7;
  public static readonly int int_8;
  public static readonly int int_9;
  public static readonly int int_10;
  private static string[] string_0;
  private static string[] string_1;
  private static string[] string_2;
  private string string_3 = string.Empty;
  private string string_4 = string.Empty;
  private string string_5 = string.Empty;
  private int int_11;
  private int int_12;
  private int int_13 = Class15.smethod_0(16);
  private int int_14;
  private static int int_15;
  private int int_16;
  private int int_17;
  private int int_18 = GClass184.int_6;
  private int int_19 = GClass184.int_7;
  public static bool bool_0;
  public static int int_20;
  public static int int_21;
  public static long long_0;
  public static readonly string[] string_6;
  public static readonly int int_22;
  public static readonly int int_23;
  public static readonly int int_24;
  public static readonly int int_25;
  public static int int_26;
  public static readonly sbyte sbyte_3;
  public static readonly sbyte sbyte_4;
  public static readonly sbyte sbyte_5;
  public static readonly sbyte sbyte_6;
  public static GClass184 gclass184_0;
  public bool isTfield;
  public bool isPaintMouse = Class15.smethod_0(1) != 0;
  public string name = string.Empty;
  public string title = string.Empty;
  public string strInfo;
  public GClass31 cmdClear;
  public GClass31 cmdDoneAction;
  private GClass113 gclass113_0;
  private int int_27;
  private int int_28;
  public static int int_29;
  private int int_30 = -1;
  private int int_31;
  private int int_32;
  private long long_1;
  private static string string_7;
  public static GClass66 gclass66_0;
  public int timePutKeyClearAll;
  public int timeClearFirt;
  public bool isPaintCarret;
  public bool showSubTextField = Class15.smethod_0(1) != 0;
  public static GClass188 gclass188_0;
  public static int[][] int_33;

  public GClass184(GClass113 parentScr)
  {
    this.string_3 = string.Empty;
    this.gclass113_0 = parentScr;
    this.method_1();
  }

  public GClass184()
  {
    this.string_3 = string.Empty;
    this.method_1();
  }

  public GClass184(int x, int y, int w, int h)
  {
    this.string_3 = string.Empty;
    this.method_1();
    this.x = x;
    this.y = y;
    this.width = w;
    this.height = h;
  }

  public GClass184(string text, int maxLen, int inputType)
  {
    this.string_3 = text;
    this.int_13 = maxLen;
    this.int_19 = inputType;
    this.method_1();
    this.isTfield = Class15.smethod_0(1) != 0;
  }

  public static bool smethod_0(char ch) => (int) ch >= Class15.smethod_0(154) && (int) ch <= Class15.smethod_0(210) || (int) ch >= Class15.smethod_0(130) && (int) ch <= Class15.smethod_0(23) || (int) ch >= Class15.smethod_0(109) && (int) ch <= Class15.smethod_0(153) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public void method_0()
  {
  }

  public static void smethod_1(int mode)
  {
    if (mode == GClass184.int_23)
    {
      GClass184.string_0[Class15.smethod_0(0)] = Class13.smethod_0(146200);
      GClass184.string_0[Class15.smethod_0(31)] = Class13.smethod_0(146198);
      GClass184.string_0[Class15.smethod_0(67)] = Class13.smethod_0(146195);
      GClass184.int_26 = Class15.smethod_0(95);
    }
    else if (mode == GClass184.int_22)
    {
      GClass184.string_0[Class15.smethod_0(0)] = Class13.smethod_0(146193);
      GClass184.string_0[Class15.smethod_0(31)] = Class13.smethod_0(146190);
      GClass184.string_0[Class15.smethod_0(67)] = Class13.smethod_0(146195);
      GClass184.int_26 = Class15.smethod_0(95);
    }
    else
    {
      if (mode != GClass184.int_24)
        return;
      GClass184.string_0[Class15.smethod_0(0)] = Class13.smethod_0(146200);
      GClass184.string_0[Class15.smethod_0(31)] = Class13.smethod_0(146190);
      GClass184.string_0[Class15.smethod_0(67)] = Class13.smethod_0(146184);
      GClass184.int_26 = Class15.smethod_0(108);
    }
  }

  public void method_1()
  {
    GClass184.int_2 = GClass113.int_0 + Class15.smethod_0(1);
    this.cmdClear = new GClass31(GClass109.string_129, (GInterface0) this, Class15.smethod_0(15), (object) null);
    if ((!Main.bool_3 ? 1 : 0) == 0)
      GClass184.int_0 = Class15.smethod_0(0);
    if ((GClass184.gclass66_0 == null ? 0 : 1) != 0)
      return;
    GClass184.gclass66_0 = GClass62.smethod_40(Class13.smethod_0(146181));
  }

  public void method_2(int keyCode)
  {
    if (keyCode != Class15.smethod_0(193) || this.int_27 > Class15.smethod_0(0))
      return;
    if (this.int_27 <= Class15.smethod_0(0))
      this.int_27 = Class15.smethod_0(1);
    this.method_4();
  }

  public void method_3()
  {
    this.string_3 = string.Empty;
    if ((GClass184.gclass188_0 == null ? 1 : 0) == 0)
      GClass184.gclass188_0.text = string.Empty;
    this.int_11 = Class15.smethod_0(0);
    this.method_11(Class15.smethod_0(0));
    this.method_16();
  }

  public void method_4()
  {
    if (this.int_11 <= Class15.smethod_0(0) || this.string_3.Length <= Class15.smethod_0(0))
      return;
    this.string_3 = this.string_3.Substring(Class15.smethod_0(0), this.int_11 - Class15.smethod_0(1));
    this.int_11 -= Class15.smethod_0(1);
    this.method_11(Class15.smethod_0(0));
    this.method_16();
    if ((GClass184.gclass188_0 == null ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.text = this.string_3;
  }

  public void method_5()
  {
    if (this.int_11 <= Class15.smethod_0(0) || this.string_3.Length <= Class15.smethod_0(0))
      return;
    this.string_3 = this.string_3.Substring(Class15.smethod_0(0), this.string_3.Length - Class15.smethod_0(1));
    this.int_11 -= Class15.smethod_0(1);
    this.method_6();
    this.method_16();
    this.method_20(Class15.smethod_0(1) != 0);
    if ((GClass184.gclass188_0 == null ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.text = string.Empty;
  }

  public void method_6()
  {
    if ((this.string_5 == null ? 1 : 0) != 0 || (GClass97.gclass97_21 == null ? 1 : 0) != 0)
      return;
    this.string_5 = this.int_19 != GClass184.int_9 ? this.string_3 : this.string_4;
    if (this.int_14 < Class15.smethod_0(0) && GClass97.gclass97_21.method_17(this.string_5) + this.int_14 < this.width - GClass184.int_5 - Class15.smethod_0(47) - GClass184.int_20)
      this.int_14 = this.width - Class15.smethod_0(31) - GClass184.int_20 - GClass97.gclass97_21.method_17(this.string_5);
    if (this.int_14 + GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11)) <= Class15.smethod_0(0))
    {
      this.int_14 = -GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11));
      this.int_14 += Class15.smethod_0(54);
    }
    else if (this.int_14 + GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11)) >= this.width - Class15.smethod_0(66) - GClass184.int_20)
      this.int_14 = this.width - Class15.smethod_0(31) - GClass184.int_20 - GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11)) - Class15.smethod_0(7) * GClass184.int_5;
    if (this.int_14 <= Class15.smethod_0(0))
      return;
    this.int_14 = Class15.smethod_0(0);
  }

  private void method_7(int int_34)
  {
    string[] strArray = this.int_19 == GClass184.int_9 || this.int_19 == GClass184.int_10 ? GClass184.string_1 : GClass184.string_0;
    if (int_34 == GClass184.int_15)
    {
      this.int_17 = (this.int_17 + Class15.smethod_0(1)) % strArray[int_34 - Class15.smethod_0(154)].Length;
      char c = strArray[int_34 - Class15.smethod_0(154)][this.int_17];
      object obj = (object) (char) ((GClass184.int_21 == 0 ? 1 : 0) != 0 ? (int) char.ToLower(c) : (GClass184.int_21 == Class15.smethod_0(1) ? (int) char.ToUpper(c) : (GClass184.int_21 != Class15.smethod_0(7) ? (int) strArray[int_34 - Class15.smethod_0(154)][strArray[int_34 - Class15.smethod_0(154)].Length - Class15.smethod_0(1)] : (int) char.ToUpper(c))));
      string str = this.string_3.Substring(Class15.smethod_0(0), this.int_11 - Class15.smethod_0(1)) + obj;
      if (this.int_11 < this.string_3.Length)
        str += this.string_3.Substring(this.int_11, this.string_3.Length);
      this.string_3 = str;
      this.int_16 = GClass184.int_1[GClass184.int_0];
      this.method_16();
    }
    else if (this.string_3.Length < this.int_13)
    {
      if (GClass184.int_21 == Class15.smethod_0(1) && GClass184.int_15 != Class15.smethod_0(624))
        GClass184.int_21 = Class15.smethod_0(0);
      this.int_17 = Class15.smethod_0(0);
      char c = strArray[int_34 - Class15.smethod_0(154)][this.int_17];
      object obj = (object) (char) ((GClass184.int_21 == 0 ? 1 : 0) != 0 ? (int) char.ToLower(c) : (GClass184.int_21 == Class15.smethod_0(1) ? (int) char.ToUpper(c) : (GClass184.int_21 != Class15.smethod_0(7) ? (int) strArray[int_34 - Class15.smethod_0(154)][strArray[int_34 - Class15.smethod_0(154)].Length - Class15.smethod_0(1)] : (int) char.ToUpper(c))));
      string str = this.string_3.Substring(Class15.smethod_0(0), this.int_11) + obj;
      if (this.int_11 < this.string_3.Length)
        str += this.string_3.Substring(this.int_11, this.string_3.Length);
      this.string_3 = str;
      this.int_16 = GClass184.int_1[GClass184.int_0];
      this.int_11 += Class15.smethod_0(1);
      this.method_16();
      this.method_6();
    }
    GClass184.int_15 = int_34;
  }

  private void method_8(int int_34)
  {
    if ((this.int_19 == GClass184.int_9 || this.int_19 == GClass184.int_10) && (int_34 < Class15.smethod_0(154) || int_34 > Class15.smethod_0(210)) && (int_34 < Class15.smethod_0(130) || int_34 > Class15.smethod_0(23)) && (int_34 < Class15.smethod_0(109) || int_34 > Class15.smethod_0(153)) || this.int_19 == GClass184.int_8 && (int_34 < Class15.smethod_0(154) || int_34 > Class15.smethod_0(210)))
      return;
    bool flag = Class15.smethod_0(1) != 0;
    try
    {
      if ((!Input.GetKey((KeyCode) Class15.smethod_0(625)) ? 0 : 1) == 0)
      {
        if ((!Input.GetKey((KeyCode) Class15.smethod_0(626)) ? 1 : 0) != 0)
          goto label_9;
      }
      if (int_34 == Class15.smethod_0(447))
      {
        TextEditor textEditor = new TextEditor();
        textEditor.Paste();
        if (this.string_3.Length + textEditor.text.Length < this.int_13)
        {
          this.string_3 += textEditor.text;
          this.int_11 = this.string_3.Length;
          this.method_16();
          this.method_11(Class15.smethod_0(0));
          flag = Class15.smethod_0(0) != 0;
        }
      }
    }
    catch
    {
    }
label_9:
    if ((!(this.string_3.Length < this.int_13 & flag) ? 1 : 0) == 0)
    {
      string text = this.string_3.Substring(Class15.smethod_0(0), this.int_11) + ((char) int_34).ToString();
      if (this.int_11 < this.string_3.Length)
        text += this.string_3.Substring(this.int_11, this.string_3.Length - this.int_11);
      if (this.int_19 == GClass184.int_9)
      {
        this.string_3 = text;
        this.int_11 += Class15.smethod_0(1);
      }
      else
      {
        this.string_3 = GClass189.smethod_0(text);
        this.int_11 = this.string_3.Length;
      }
      this.method_16();
      this.method_11(Class15.smethod_0(0));
    }
    if ((GClass184.gclass188_0 == null ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.text = this.string_3;
  }

  public static void smethod_2()
  {
    GClass184.int_21 += Class15.smethod_0(1);
    if (GClass184.int_21 > Class15.smethod_0(5))
      GClass184.int_21 = Class15.smethod_0(0);
    GClass184.int_15 = GClass184.int_26;
    GClass184.long_0 = (long) (Environment.TickCount / Class15.smethod_0(15));
  }

  private void method_9()
  {
    this.long_1 = (long) (Environment.TickCount / Class15.smethod_0(21));
    if (this.int_30 == -1)
    {
      for (int int11 = this.int_11; int11 > Class15.smethod_0(0); int11 -= Class15.smethod_0(1))
      {
        char ch1 = this.string_3[int11 - Class15.smethod_0(1)];
        for (int index = Class15.smethod_0(0); index < GClass184.string_7.Length; index += Class15.smethod_0(1))
        {
          char ch2 = GClass184.string_7[index];
          if ((int) ch1 == (int) ch2)
          {
            this.int_31 = index;
            this.int_32 = Class15.smethod_0(0);
            this.int_30 = int11 - Class15.smethod_0(1);
            return;
          }
        }
      }
      this.int_30 = -1;
    }
    else
    {
      this.int_32 += Class15.smethod_0(1);
      if (this.int_32 >= Class15.smethod_0(37))
        this.int_32 = Class15.smethod_0(0);
      string str1 = this.string_3.Substring(Class15.smethod_0(0), this.int_30);
      string str2 = this.string_3.Substring(this.int_30 + Class15.smethod_0(1));
      string str3 = GClass184.string_7.Substring(this.int_31 + this.int_32, Class15.smethod_0(1));
      this.string_3 = str1 + str3 + str2;
    }
  }

  public bool method_10(int keyCode)
  {
    if ((!Main.bool_3 ? 1 : 0) == 0 && keyCode == Class15.smethod_0(193))
    {
      this.method_2(Class15.smethod_0(193));
      return Class15.smethod_0(1) != 0;
    }
    if (keyCode != Class15.smethod_0(88) && keyCode != Class15.smethod_0(193) && keyCode != Class15.smethod_0(627))
    {
      if ((!GClass184.bool_0 ? 1 : 0) == 0 && keyCode >= Class15.smethod_0(120))
      {
        this.method_8(keyCode);
        return Class15.smethod_0(0) != 0;
      }
      if (keyCode == GClass184.int_29 && this.int_19 == GClass184.int_7)
      {
        this.method_9();
        return Class15.smethod_0(0) != 0;
      }
      if (keyCode == Class15.smethod_0(108))
        keyCode = Class15.smethod_0(129);
      if (keyCode == Class15.smethod_0(95))
        keyCode = Class15.smethod_0(211);
      if (keyCode >= Class15.smethod_0(154) && keyCode <= Class15.smethod_0(211))
      {
        if (this.int_19 != GClass184.int_7 && this.int_19 != GClass184.int_9 && this.int_19 != GClass184.int_10)
        {
          if (this.int_19 == GClass184.int_8)
          {
            this.method_8(keyCode);
            this.int_16 = Class15.smethod_0(1);
          }
        }
        else
          this.method_7(keyCode);
      }
      else
      {
        this.int_17 = Class15.smethod_0(0);
        GClass184.int_15 = Class15.smethod_0(624);
        if (keyCode == Class15.smethod_0(49) && (!this.lockArrow ? 0 : 1) == 0)
        {
          if (this.int_11 > Class15.smethod_0(0))
          {
            this.int_11 -= Class15.smethod_0(1);
            this.method_11(Class15.smethod_0(0));
            this.int_18 = GClass184.int_6;
            return Class15.smethod_0(0) != 0;
          }
        }
        else if (keyCode == Class15.smethod_0(9) && (!this.lockArrow ? 0 : 1) == 0)
        {
          if (this.int_11 < this.string_3.Length)
          {
            this.int_11 += Class15.smethod_0(1);
            this.method_11(Class15.smethod_0(0));
            this.int_18 = GClass184.int_6;
            return Class15.smethod_0(0) != 0;
          }
        }
        else
        {
          if (keyCode == Class15.smethod_0(65))
          {
            this.method_4();
            return Class15.smethod_0(0) != 0;
          }
          GClass184.int_15 = keyCode;
        }
      }
      return Class15.smethod_0(1) != 0;
    }
    this.method_4();
    return Class15.smethod_0(1) != 0;
  }

  public void method_11(int index)
  {
    this.string_5 = this.int_19 != GClass184.int_9 ? this.string_3 : this.string_4;
    int num1 = GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11));
    if (index != -1)
    {
      if (index != Class15.smethod_0(1))
        this.int_14 = -(num1 - (this.width - Class15.smethod_0(66)));
      else if (num1 + this.int_14 > this.width - Class15.smethod_0(46) && this.int_11 < this.string_5.Length && this.int_11 > Class15.smethod_0(0))
        this.int_14 -= GClass97.gclass97_21.method_17(this.string_5.Substring(this.int_11 - Class15.smethod_0(1), Class15.smethod_0(1)));
    }
    else if (num1 + this.int_14 < Class15.smethod_0(9) && this.int_11 > Class15.smethod_0(0) && this.int_11 < this.string_5.Length)
      this.int_14 += GClass97.gclass97_21.method_17(this.string_5.Substring(this.int_11, Class15.smethod_0(1)));
    if (this.int_14 > Class15.smethod_0(0))
    {
      this.int_14 = Class15.smethod_0(0);
    }
    else
    {
      if (this.int_14 >= Class15.smethod_0(0))
        return;
      int num2 = GClass97.gclass97_21.method_17(this.string_5) - (this.width - Class15.smethod_0(66));
      if (this.int_14 >= -num2)
        return;
      this.int_14 = -num2;
    }
  }

  public void method_12(
    GClass98 g,
    bool iss,
    int x,
    int y,
    int w,
    int h,
    int xText,
    int yText,
    string text,
    string info)
  {
    g.method_16(Class15.smethod_0(0));
    if ((!iss ? 1 : 0) == 0)
    {
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(13), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(371), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + w - Class15.smethod_0(36), y, Class15.smethod_0(0));
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(59), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + w - Class15.smethod_0(129), y, Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < (w - Class15.smethod_0(129)) / Class15.smethod_0(36); index += Class15.smethod_0(1))
        g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(59), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + Class15.smethod_0(36) + index * Class15.smethod_0(36), y, Class15.smethod_0(0));
    }
    else
    {
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(271), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + w - Class15.smethod_0(36), y, Class15.smethod_0(0));
      g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(33), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + w - Class15.smethod_0(129), y, Class15.smethod_0(0));
      for (int index = Class15.smethod_0(0); index < (w - Class15.smethod_0(129)) / Class15.smethod_0(36); index += Class15.smethod_0(1))
        g.method_24(GClass184.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(33), Class15.smethod_0(36), Class15.smethod_0(33), Class15.smethod_0(0), x + Class15.smethod_0(36) + index * Class15.smethod_0(36), y, Class15.smethod_0(0));
    }
    g.method_5(x + Class15.smethod_0(5), y + Class15.smethod_0(1), w - Class15.smethod_0(2), h);
    if ((text == null ? 1 : 0) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0)
    {
      GClass97.gclass97_21.method_6(g, text, xText, yText, Class15.smethod_0(0));
    }
    else
    {
      if ((info == null ? 1 : 0) != 0)
        return;
      if ((!iss ? 1 : 0) == 0)
        GClass97.gclass97_9.method_6(g, info, xText, yText, Class15.smethod_0(0));
      else
        GClass97.gclass97_10.method_6(g, info, xText, yText, Class15.smethod_0(0));
    }
  }

  public void method_13(GClass98 g)
  {
    g.method_5(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    bool iss = this.method_14();
    this.string_5 = this.int_19 != GClass184.int_9 ? this.string_3 : this.string_4;
    this.method_12(g, iss, this.x, this.y - Class15.smethod_0(1), this.width, this.height + Class15.smethod_0(3), GClass184.int_5 + this.int_14 + this.x + Class15.smethod_0(1), this.y + (this.height - GClass97.gclass97_21.method_20()) / Class15.smethod_0(7) + Class15.smethod_0(7), this.string_5, this.name);
    g.method_5(this.x + Class15.smethod_0(5), this.y + Class15.smethod_0(1), this.width - Class15.smethod_0(2), this.height - Class15.smethod_0(7));
    g.method_16(Class15.smethod_0(0));
    if ((!iss ? 1 : 0) != 0 || (!this.isPaintMouse ? 1 : 0) != 0 || (!this.isPaintCarret ? 1 : 0) != 0)
      return;
    if ((this.int_16 == 0 ? 0 : 1) == 0 && (this.int_18 > Class15.smethod_0(0) || (this.int_12 / GClass184.int_4 % Class15.smethod_0(2) == 0 ? 0 : 1) == 0))
    {
      g.method_16(Class15.smethod_0(628));
      g.method_15(GClass184.int_5 + Class15.smethod_0(1) + this.int_14 + this.x + GClass97.gclass97_21.method_17(this.string_5.Substring(Class15.smethod_0(0), this.int_11) + Class13.smethod_0(145969)) - GClass184.int_3 - GClass97.gclass97_21.method_17(Class13.smethod_0(145969)), this.y + (this.height - GClass184.int_2) / Class15.smethod_0(7) + Class15.smethod_0(3), GClass184.int_3, GClass184.int_2);
    }
    GClass62.smethod_6(g);
    if ((this.string_3 == null ? 1 : 0) != 0 || this.string_3.Length <= Class15.smethod_0(0) || (!GClass62.bool_5 ? 1 : 0) != 0)
      return;
    g.method_32(GClass62.gclass66_7, this.x + this.width - Class15.smethod_0(47), this.y + this.height / Class15.smethod_0(7) + Class15.smethod_0(5), GClass98.int_1 | GClass98.int_0);
  }

  private bool method_14() => this.isFocus;

  public string method_15(string str, int index, int indexTo)
  {
    if (index >= Class15.smethod_0(0) && indexTo > str.Length - Class15.smethod_0(1))
      return str.Substring(index);
    if (index < Class15.smethod_0(0) || index > str.Length - Class15.smethod_0(1) || indexTo < Class15.smethod_0(0) || indexTo > str.Length - Class15.smethod_0(1))
      return string.Empty;
    string empty = string.Empty;
    for (int index1 = index; index1 < indexTo; index1 += Class15.smethod_0(1))
      empty += str[index1].ToString();
    return empty;
  }

  private void method_16()
  {
    if (this.int_19 != GClass184.int_9)
      return;
    this.string_4 = string.Empty;
    for (int index = Class15.smethod_0(0); index < this.string_3.Length; index += Class15.smethod_0(1))
      this.string_4 += Class13.smethod_0(146092);
    if (this.int_16 <= Class15.smethod_0(0) || this.int_11 <= Class15.smethod_0(0))
      return;
    this.string_4 = this.string_4.Substring(Class15.smethod_0(0), this.int_11 - Class15.smethod_0(1)) + this.string_3[this.int_11 - Class15.smethod_0(1)].ToString() + this.string_4.Substring(this.int_11, this.string_4.Length);
  }

  public void method_17()
  {
    this.isPaintCarret = Class15.smethod_0(1) != 0;
    if ((!Main.bool_3 ? 1 : 0) == 0)
    {
      if (this.int_27 > Class15.smethod_0(0))
        this.int_27 -= Class15.smethod_0(1);
      if (this.int_27 <= Class15.smethod_0(0))
        this.int_27 = Class15.smethod_0(0);
    }
    if ((GClass184.gclass188_0 == null ? 1 : 0) == 0 && GClass184.gclass184_0 == this)
    {
      if (GClass184.gclass188_0.text.Length < Class15.smethod_0(54) && (!this.isFocus ? 1 : 0) == 0)
        this.method_23(GClass184.gclass188_0.text);
      if ((!GClass184.gclass188_0.done ? 1 : 0) == 0 && (this.cmdDoneAction == null ? 1 : 0) == 0)
        this.cmdDoneAction.method_1();
    }
    this.int_12 += Class15.smethod_0(1);
    if (this.int_16 > Class15.smethod_0(0))
    {
      this.int_16 -= Class15.smethod_0(1);
      if ((this.int_16 == 0 ? 0 : 1) == 0)
      {
        this.int_17 = Class15.smethod_0(0);
        if (GClass184.int_21 == Class15.smethod_0(1) && GClass184.int_15 != GClass184.int_26 && (!this.isFocus ? 1 : 0) == 0)
          GClass184.int_21 = Class15.smethod_0(0);
        GClass184.int_15 = Class15.smethod_0(624);
        this.method_16();
      }
    }
    if (this.int_18 > Class15.smethod_0(0))
      this.int_18 -= Class15.smethod_0(1);
    if ((!GClass62.bool_16 ? 1 : 0) == 0)
      this.method_18();
    if (this.int_30 == -1 || (long) (Environment.TickCount / Class15.smethod_0(21)) - this.long_1 <= (long) Class15.smethod_0(3))
      return;
    this.int_30 = -1;
  }

  public void method_18()
  {
    if ((!GClass62.smethod_22(this.x + this.width - Class15.smethod_0(51), this.y, Class15.smethod_0(54), this.height) ? 1 : 0) == 0)
    {
      this.method_3();
      this.isFocus = Class15.smethod_0(1) != 0;
    }
    else if ((!GClass62.smethod_22(this.x, this.y, this.width - Class15.smethod_0(51), this.height) ? 1 : 0) == 0)
      this.method_20(Class15.smethod_0(1) != 0);
    else
      this.method_19(Class15.smethod_0(0) != 0);
  }

  public void method_19(bool isFocus)
  {
    if (this.isFocus != isFocus)
      GClass184.int_21 = Class15.smethod_0(0);
    GClass184.int_15 = Class15.smethod_0(624);
    GClass184.long_0 = (long) (int) (DateTime.Now.Ticks / (long) Class15.smethod_0(15));
    this.isFocus = isFocus;
    if ((!isFocus ? 1 : 0) != 0)
      return;
    GClass184.gclass184_0 = this;
    if ((GClass184.gclass188_0 == null ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.text = GClass184.gclass184_0.string_3;
  }

  public void method_20(bool isFocus)
  {
    if (this.isFocus != isFocus)
      GClass184.int_21 = Class15.smethod_0(0);
    GClass184.int_15 = Class15.smethod_0(624);
    GClass184.long_0 = (long) (int) (DateTime.Now.Ticks / (long) Class15.smethod_0(15));
    this.isFocus = isFocus;
    if ((!isFocus ? 1 : 0) == 0)
      GClass184.gclass184_0 = this;
    else if (GClass184.gclass184_0 == this)
      GClass184.gclass184_0 = (GClass184) null;
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) != 0 || (GClass184.gclass184_0 == null ? 1 : 0) != 0)
      return;
    isFocus = Class15.smethod_0(1) != 0;
    GClass188.bool_0 = (GClass184.gclass184_0.showSubTextField ? 1 : 0) == Class15.smethod_0(0);
    GEnum0 t = (GEnum0) Class15.smethod_0(1);
    if (this.int_19 == GClass184.int_8)
      t = (GEnum0) Class15.smethod_0(7);
    bool type = Class15.smethod_0(0) != 0;
    if (this.int_19 == GClass184.int_9)
      type = Class15.smethod_0(1) != 0;
    GClass184.gclass188_0 = GClass188.smethod_0(GClass184.gclass184_0.string_3, t, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, type, Class15.smethod_0(0) != 0, GClass184.gclass184_0.name);
    if ((GClass184.gclass188_0 == null ? 1 : 0) == 0)
      GClass184.gclass188_0.text = GClass184.gclass184_0.string_3;
    GClass33.smethod_5(Class13.smethod_0(146080) + GClass184.gclass184_0.string_3);
  }

  public string method_21() => this.string_3;

  public void method_22()
  {
    if ((GClass184.gclass188_0 == null ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.text = string.Empty;
  }

  public void method_23(string text)
  {
    if ((text == null ? 1 : 0) != 0)
      return;
    GClass184.int_15 = Class15.smethod_0(624);
    this.int_16 = Class15.smethod_0(0);
    this.int_17 = Class15.smethod_0(0);
    this.string_3 = text;
    this.string_5 = text;
    if ((!(text == string.Empty) ? 1 : 0) == 0)
      GClass188.smethod_1();
    this.method_16();
    this.int_11 = text.Length;
    this.method_6();
  }

  public void method_24(string text)
  {
    this.string_3 = this.string_3.Substring(Class15.smethod_0(0), this.int_11) + text + this.string_3.Substring(this.int_11);
    this.method_16();
    this.int_11 += text.Length;
    this.method_6();
  }

  public int method_25() => this.int_13;

  public void method_26(int maxTextLenght) => this.int_13 = maxTextLenght;

  public int method_27() => this.int_19;

  public void method_28(int iputType)
  {
    this.int_19 = iputType;
    this.method_26(Class15.smethod_0(16));
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction != Class15.smethod_0(15))
      return;
    this.method_4();
  }

  static GClass184()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.THVrftVhrchw));
    GClass184.int_1 = (int[]) Class15.smethod_4(byte_0_1);
    GClass184.int_2 = Class15.smethod_0(0);
    GClass184.int_3 = Class15.smethod_0(1);
    GClass184.int_4 = Class15.smethod_0(3);
    GClass184.int_5 = Class15.smethod_0(2);
    GClass184.int_6 = Class15.smethod_0(31);
    GClass184.int_7 = Class15.smethod_0(0);
    GClass184.int_8 = Class15.smethod_0(1);
    GClass184.int_9 = Class15.smethod_0(7);
    GClass184.int_10 = Class15.smethod_0(5);
    string[] strArray1 = new string[Class15.smethod_0(66)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(146807);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(146804);
    strArray1[Class15.smethod_0(7)] = Class13.smethod_0(146767);
    strArray1[Class15.smethod_0(5)] = Class13.smethod_0(146839);
    strArray1[Class15.smethod_0(2)] = Class13.smethod_0(146921);
    strArray1[Class15.smethod_0(3)] = Class13.smethod_0(147043);
    strArray1[Class15.smethod_0(37)] = Class13.smethod_0(147038);
    strArray1[Class15.smethod_0(38)] = Class13.smethod_0(147095);
    strArray1[Class15.smethod_0(88)] = Class13.smethod_0(147079);
    strArray1[Class15.smethod_0(45)] = Class13.smethod_0(140174);
    strArray1[Class15.smethod_0(31)] = Class13.smethod_0(140248);
    strArray1[Class15.smethod_0(67)] = Class13.smethod_0(140246);
    GClass184.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(66)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(140241);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(140239);
    strArray2[Class15.smethod_0(7)] = Class13.smethod_0(140237);
    strArray2[Class15.smethod_0(5)] = Class13.smethod_0(140232);
    strArray2[Class15.smethod_0(2)] = Class13.smethod_0(140227);
    strArray2[Class15.smethod_0(3)] = Class13.smethod_0(147043);
    strArray2[Class15.smethod_0(37)] = Class13.smethod_0(139838);
    strArray2[Class15.smethod_0(38)] = Class13.smethod_0(147095);
    strArray2[Class15.smethod_0(88)] = Class13.smethod_0(139833);
    strArray2[Class15.smethod_0(45)] = Class13.smethod_0(139828);
    strArray2[Class15.smethod_0(31)] = Class13.smethod_0(140241);
    strArray2[Class15.smethod_0(67)] = Class13.smethod_0(140241);
    GClass184.string_1 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(186)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(146807);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(139822);
    strArray3[Class15.smethod_0(7)] = Class13.smethod_0(139818);
    strArray3[Class15.smethod_0(5)] = Class13.smethod_0(139814);
    strArray3[Class15.smethod_0(2)] = Class13.smethod_0(139810);
    strArray3[Class15.smethod_0(3)] = Class13.smethod_0(139806);
    strArray3[Class15.smethod_0(37)] = Class13.smethod_0(139802);
    strArray3[Class15.smethod_0(38)] = Class13.smethod_0(139798);
    strArray3[Class15.smethod_0(88)] = Class13.smethod_0(139794);
    strArray3[Class15.smethod_0(45)] = Class13.smethod_0(139850);
    strArray3[Class15.smethod_0(31)] = Class13.smethod_0(140241);
    strArray3[Class15.smethod_0(67)] = Class13.smethod_0(140241);
    strArray3[Class15.smethod_0(66)] = Class13.smethod_0(139943);
    strArray3[Class15.smethod_0(47)] = Class13.smethod_0(140588);
    strArray3[Class15.smethod_0(49)] = Class13.smethod_0(140567);
    strArray3[Class15.smethod_0(9)] = Class13.smethod_0(140564);
    strArray3[Class15.smethod_0(10)] = Class13.smethod_0(140560);
    GClass184.string_2 = strArray3;
    GClass184.int_15 = Class15.smethod_0(624);
    GClass184.bool_0 = Class15.smethod_0(1) != 0;
    GClass184.int_21 = Class15.smethod_0(0);
    string[] strArray4 = new string[Class15.smethod_0(2)];
    strArray4[Class15.smethod_0(0)] = Class13.smethod_0(140557);
    strArray4[Class15.smethod_0(1)] = Class13.smethod_0(140640);
    strArray4[Class15.smethod_0(7)] = Class13.smethod_0(140636);
    strArray4[Class15.smethod_0(5)] = Class13.smethod_0(140632);
    GClass184.string_6 = strArray4;
    GClass184.int_22 = Class15.smethod_0(0);
    GClass184.int_23 = Class15.smethod_0(1);
    GClass184.int_24 = Class15.smethod_0(7);
    GClass184.int_25 = Class15.smethod_0(5);
    GClass184.int_26 = Class15.smethod_0(67);
    GClass184.sbyte_3 = (sbyte) Class15.smethod_0(0);
    GClass184.sbyte_4 = (sbyte) Class15.smethod_0(1);
    GClass184.sbyte_5 = (sbyte) Class15.smethod_0(7);
    GClass184.sbyte_6 = (sbyte) Class15.smethod_0(5);
    GClass184.string_7 = Class13.smethod_0(140369);
    int[][] numArray1 = new int[Class15.smethod_0(186)][];
    int index1 = Class15.smethod_0(0);
    int[] numArray2 = new int[Class15.smethod_0(7)];
    numArray2[Class15.smethod_0(0)] = Class15.smethod_0(120);
    numArray2[Class15.smethod_0(1)] = Class15.smethod_0(154);
    numArray1[index1] = numArray2;
    int index2 = Class15.smethod_0(1);
    int[] numArray3 = new int[Class15.smethod_0(7)];
    numArray3[Class15.smethod_0(0)] = Class15.smethod_0(449);
    numArray3[Class15.smethod_0(1)] = Class15.smethod_0(151);
    numArray1[index2] = numArray3;
    int index3 = Class15.smethod_0(7);
    int[] numArray4 = new int[Class15.smethod_0(7)];
    numArray4[Class15.smethod_0(0)] = Class15.smethod_0(32);
    numArray4[Class15.smethod_0(1)] = Class15.smethod_0(39);
    numArray1[index3] = numArray4;
    int index4 = Class15.smethod_0(5);
    int[] numArray5 = new int[Class15.smethod_0(7)];
    numArray5[Class15.smethod_0(0)] = Class15.smethod_0(190);
    numArray5[Class15.smethod_0(1)] = Class15.smethod_0(81);
    numArray1[index4] = numArray5;
    int index5 = Class15.smethod_0(2);
    int[] numArray6 = new int[Class15.smethod_0(7)];
    numArray6[Class15.smethod_0(0)] = Class15.smethod_0(72);
    numArray6[Class15.smethod_0(1)] = Class15.smethod_0(11);
    numArray1[index5] = numArray6;
    int index6 = Class15.smethod_0(3);
    int[] numArray7 = new int[Class15.smethod_0(7)];
    numArray7[Class15.smethod_0(0)] = Class15.smethod_0(69);
    numArray7[Class15.smethod_0(1)] = Class15.smethod_0(135);
    numArray1[index6] = numArray7;
    int index7 = Class15.smethod_0(37);
    int[] numArray8 = new int[Class15.smethod_0(7)];
    numArray8[Class15.smethod_0(0)] = Class15.smethod_0(271);
    numArray8[Class15.smethod_0(1)] = Class15.smethod_0(26);
    numArray1[index7] = numArray8;
    int index8 = Class15.smethod_0(38);
    int[] numArray9 = new int[Class15.smethod_0(7)];
    numArray9[Class15.smethod_0(0)] = Class15.smethod_0(280);
    numArray9[Class15.smethod_0(1)] = Class15.smethod_0(131);
    numArray1[index8] = numArray9;
    int index9 = Class15.smethod_0(88);
    int[] numArray10 = new int[Class15.smethod_0(7)];
    numArray10[Class15.smethod_0(0)] = Class15.smethod_0(368);
    numArray10[Class15.smethod_0(1)] = Class15.smethod_0(283);
    numArray1[index9] = numArray10;
    int index10 = Class15.smethod_0(45);
    int[] numArray11 = new int[Class15.smethod_0(7)];
    numArray11[Class15.smethod_0(0)] = Class15.smethod_0(210);
    numArray11[Class15.smethod_0(1)] = Class15.smethod_0(216);
    numArray1[index10] = numArray11;
    int index11 = Class15.smethod_0(31);
    int[] numArray12 = new int[Class15.smethod_0(7)];
    numArray12[Class15.smethod_0(0)] = Class15.smethod_0(108);
    numArray12[Class15.smethod_0(1)] = Class15.smethod_0(212);
    numArray1[index11] = numArray12;
    int index12 = Class15.smethod_0(67);
    int[] numArray13 = new int[Class15.smethod_0(7)];
    numArray13[Class15.smethod_0(0)] = Class15.smethod_0(95);
    numArray13[Class15.smethod_0(1)] = Class15.smethod_0(155);
    numArray1[index12] = numArray13;
    int index13 = Class15.smethod_0(66);
    int[] numArray14 = new int[Class15.smethod_0(7)];
    numArray14[Class15.smethod_0(0)] = Class15.smethod_0(48);
    numArray14[Class15.smethod_0(1)] = Class15.smethod_0(76);
    numArray1[index13] = numArray14;
    int index14 = Class15.smethod_0(47);
    int[] numArray15 = new int[Class15.smethod_0(7)];
    numArray15[Class15.smethod_0(0)] = Class15.smethod_0(182);
    numArray15[Class15.smethod_0(1)] = Class15.smethod_0(109);
    numArray1[index14] = numArray15;
    int index15 = Class15.smethod_0(49);
    byte[] byte_0_2 = new byte[Class15.smethod_0(62)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.JniMOzCuiPiY));
    int[] numArray16 = (int[]) Class15.smethod_4(byte_0_2);
    numArray1[index15] = numArray16;
    int index16 = Class15.smethod_0(9);
    int[] numArray17 = new int[Class15.smethod_0(7)];
    numArray17[Class15.smethod_0(0)] = Class15.smethod_0(71);
    numArray17[Class15.smethod_0(1)] = Class15.smethod_0(44);
    numArray1[index16] = numArray17;
    int index17 = Class15.smethod_0(10);
    int[] numArray18 = new int[Class15.smethod_0(7)];
    numArray18[Class15.smethod_0(0)] = Class15.smethod_0(74);
    numArray18[Class15.smethod_0(1)] = Class15.smethod_0(59);
    numArray1[index17] = numArray18;
    GClass184.int_33 = numArray1;
  }
}
