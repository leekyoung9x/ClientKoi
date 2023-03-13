// Decompiled with JetBrains decompiler
// Type: GClass97
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GClass97
{
  public static int int_0 = Class15.smethod_0(0);
  public static int int_1 = Class15.smethod_0(1);
  public static int int_2 = Class15.smethod_0(7);
  public static int int_3 = Class15.smethod_0(0);
  public static int int_4 = Class15.smethod_0(1);
  public static int int_5 = Class15.smethod_0(7);
  public static int int_6 = Class15.smethod_0(5);
  public static int int_7 = Class15.smethod_0(2);
  public static int int_8 = Class15.smethod_0(3);
  public static int int_9 = Class15.smethod_0(37);
  public static int int_10 = Class15.smethod_0(38);
  public static int int_11 = Class15.smethod_0(88);
  public static int int_12 = Class15.smethod_0(45);
  public static int int_13 = Class15.smethod_0(31);
  private int int_14;
  private GClass66 gclass66_0;
  private string string_0;
  private int[][] int_15;
  public static int int_16;
  public static int[] int_17;
  public static GClass97 gclass97_0;
  public static GClass97 gclass97_1;
  public static GClass97 gclass97_2;
  public static GClass97 gclass97_3;
  public static GClass97 gclass97_4;
  public static GClass97 gclass97_5;
  public static GClass97 gclass97_6;
  public static GClass97 gclass97_7;
  public static GClass97 gclass97_8;
  public static GClass97 gclass97_9;
  public static GClass97 gclass97_10;
  public static GClass97 gclass97_11;
  public static GClass97 gclass97_12;
  public static GClass97 gclass97_13;
  public static GClass97 gclass97_14;
  public static GClass97 gclass97_15;
  public static GClass97 gclass97_16;
  public static GClass97 gclass97_17;
  public static GClass97 gclass97_18;
  public static GClass97 gclass97_19;
  public static GClass97 gclass97_20;
  public static GClass97 gclass97_21;
  public static GClass97 gclass97_22;
  public static GClass97 gclass97_23;
  public static GClass97 gclass97_24;
  public static GClass97 gclass97_25;
  public static GClass97 gclass97_26;
  public static GClass97 gclass97_27;
  public static GClass97 gclass97_28;
  public static GClass97 gclass97_29;
  public static GClass97 gclass97_30;
  public static GClass97 gclass97_31;
  public static GClass97 gclass97_32;
  public static GClass97 gclass97_33;
  public static GClass97 gclass97_34;
  public static GClass97 gclass97_35;
  public static GClass97 gclass97_36;
  public static GClass97 gclass97_37;
  public static GClass97 gclass97_38;
  public static GClass97 gclass97_39;
  public static GClass97 gclass97_40;
  public static GClass97 gclass97_41;
  public static GClass97 gclass97_42;
  public static GClass97 gclass97_43;
  public static GClass97 gclass97_44;
  public Font myFont;
  private int int_18;
  private int int_19;
  public Color color1 = Color.white;
  public Color color2 = Color.gray;
  public sbyte id;
  public int fstyle;
  public string st1 = Class13.smethod_0(158844);
  public string st2 = Class13.smethod_0(159636);
  public const string string_1 = " 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW";
  private int int_20;
  private string string_2;

  public GClass97(string strFont, string pathImage, string pathData, int space)
  {
    try
    {
      this.string_0 = strFont;
      this.int_14 = space;
      this.string_2 = pathImage;
      GClass35 gclass35 = (GClass35) null;
      this.method_22();
      try
      {
        gclass35 = GClass133.smethod_0(pathData);
        this.int_15 = new int[(int) gclass35.method_0()][];
        for (int index = Class15.smethod_0(0); index < this.int_15.Length; index += Class15.smethod_0(1))
        {
          this.int_15[index] = new int[Class15.smethod_0(2)];
          this.int_15[index][Class15.smethod_0(0)] = (int) gclass35.method_0();
          this.int_15[index][Class15.smethod_0(1)] = (int) gclass35.method_0();
          this.int_15[index][Class15.smethod_0(7)] = (int) gclass35.method_0();
          this.int_15[index][Class15.smethod_0(5)] = (int) gclass35.method_0();
          this.method_0(this.int_15[index][Class15.smethod_0(5)]);
        }
        gclass35.method_4();
      }
      catch (Exception ex1)
      {
        try
        {
          gclass35.method_4();
        }
        catch (Exception ex2)
        {
          ex2.StackTrace.ToString();
        }
      }
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
  }

  public GClass97(sbyte id)
  {
    string str = Class13.smethod_0(152423);
    if ((int) id > Class15.smethod_0(0) && (int) id < Class15.smethod_0(31) || (int) id == Class15.smethod_0(65))
    {
      this.int_20 = Class15.smethod_0(1);
      str = Class13.smethod_0(152415);
    }
    else if ((int) id >= Class15.smethod_0(31) && (int) id <= Class15.smethod_0(124))
    {
      str = Class13.smethod_0(152423);
      this.int_20 = Class15.smethod_0(7);
    }
    else if ((int) id > Class15.smethod_0(40))
      str = Class13.smethod_0(152406);
    this.id = id;
    this.myFont = (Font) Resources.Load(Class13.smethod_0(152397) + GClass98.int_8.ToString() + Class13.smethod_0(152384) + str);
    if ((int) id < Class15.smethod_0(46))
    {
      this.color1 = this.method_5(id);
      this.color2 = this.method_5(id);
    }
    else
    {
      this.color1 = this.method_2((int) id);
      this.color2 = this.method_2((int) id);
    }
    this.int_19 = this.method_18(Class13.smethod_0(152510));
  }

  public static void smethod_0()
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
    {
      GClass97.gclass97_1 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152954), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_2 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152906), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_3 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(153000), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_4 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152603), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_5 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152603), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_6 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152691), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_7 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(152653), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_8 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(154036), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_9 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(154100), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_10 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148087), Class13.smethod_0(152924), Class15.smethod_0(0));
      GClass97.gclass97_11 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148150), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_12 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148220), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_14 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148171), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_15 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148755), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_16 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148855), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_17 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148829), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_18 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148804), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_19 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148902), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_20 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148868), Class13.smethod_0(148129), Class15.smethod_0(0));
      GClass97.gclass97_21 = new GClass97(Class13.smethod_0(152508), Class13.smethod_0(148950), Class13.smethod_0(148928), -1);
      GClass97.gclass97_22 = new GClass97(Class13.smethod_0(148516), Class13.smethod_0(148607), Class13.smethod_0(148581), Class15.smethod_0(0));
      GClass97.gclass97_23 = new GClass97(Class13.smethod_0(148516), Class13.smethod_0(148566), Class13.smethod_0(148581), Class15.smethod_0(0));
      GClass97.gclass97_24 = new GClass97(Class13.smethod_0(148516), Class13.smethod_0(148671), Class13.smethod_0(148581), Class15.smethod_0(0));
      GClass97.gclass97_25 = new GClass97(Class13.smethod_0(148516), Class13.smethod_0(148646), Class13.smethod_0(148581), Class15.smethod_0(0));
      GClass97.gclass97_26 = new GClass97(Class13.smethod_0(148516), Class13.smethod_0(148622), Class13.smethod_0(148581), Class15.smethod_0(0));
      GClass97.gclass97_27 = GClass97.gclass97_23;
      GClass97.gclass97_28 = GClass97.gclass97_3;
      GClass97.gclass97_29 = GClass97.gclass97_22;
      GClass97.gclass97_30 = GClass97.gclass97_24;
      GClass97.gclass97_31 = GClass97.gclass97_26;
      GClass97.gclass97_32 = GClass97.gclass97_12;
      GClass97.gclass97_34 = GClass97.gclass97_17;
      GClass97.gclass97_35 = GClass97.gclass97_15;
      GClass97.gclass97_36 = GClass97.gclass97_19;
      GClass97.gclass97_37 = GClass97.gclass97_16;
      GClass97.gclass97_38 = GClass97.gclass97_15;
      GClass97.gclass97_39 = GClass97.gclass97_7;
      GClass97.gclass97_40 = GClass97.gclass97_20;
      GClass97.gclass97_41 = GClass97.gclass97_8;
      GClass97.gclass97_13 = GClass97.gclass97_12;
      GClass97.gclass97_43 = GClass97.gclass97_1;
      GClass97.gclass97_44 = GClass97.gclass97_4;
      GClass97.gclass97_42 = GClass97.gclass97_11;
    }
    else
    {
      GClass97.gclass97_0 = new GClass97((sbyte) Class15.smethod_0(0));
      GClass97.gclass97_1 = new GClass97((sbyte) Class15.smethod_0(1));
      GClass97.gclass97_2 = new GClass97((sbyte) Class15.smethod_0(7));
      GClass97.gclass97_3 = new GClass97((sbyte) Class15.smethod_0(5));
      GClass97.gclass97_4 = new GClass97((sbyte) Class15.smethod_0(2));
      GClass97.gclass97_5 = new GClass97((sbyte) Class15.smethod_0(2));
      GClass97.gclass97_6 = new GClass97((sbyte) Class15.smethod_0(3));
      GClass97.gclass97_7 = new GClass97((sbyte) Class15.smethod_0(37));
      GClass97.gclass97_8 = new GClass97((sbyte) Class15.smethod_0(38));
      GClass97.gclass97_9 = new GClass97((sbyte) Class15.smethod_0(88));
      GClass97.gclass97_10 = new GClass97((sbyte) Class15.smethod_0(45));
      GClass97.gclass97_11 = new GClass97((sbyte) Class15.smethod_0(31));
      GClass97.gclass97_12 = new GClass97((sbyte) Class15.smethod_0(67));
      GClass97.gclass97_13 = GClass97.gclass97_12;
      GClass97.gclass97_14 = new GClass97((sbyte) Class15.smethod_0(66));
      GClass97.gclass97_15 = new GClass97((sbyte) Class15.smethod_0(47));
      GClass97.gclass97_16 = new GClass97((sbyte) Class15.smethod_0(49));
      GClass97.gclass97_17 = new GClass97((sbyte) Class15.smethod_0(9));
      GClass97.gclass97_18 = new GClass97((sbyte) Class15.smethod_0(10));
      GClass97.gclass97_19 = new GClass97((sbyte) Class15.smethod_0(186));
      GClass97.gclass97_20 = new GClass97((sbyte) Class15.smethod_0(124));
      GClass97.gclass97_21 = new GClass97((sbyte) Class15.smethod_0(65));
      GClass97.gclass97_22 = new GClass97((sbyte) Class15.smethod_0(51));
      GClass97.gclass97_23 = new GClass97((sbyte) Class15.smethod_0(27));
      GClass97.gclass97_24 = new GClass97((sbyte) Class15.smethod_0(28));
      GClass97.gclass97_25 = new GClass97((sbyte) Class15.smethod_0(29));
      GClass97.gclass97_26 = new GClass97((sbyte) Class15.smethod_0(40));
      GClass97.gclass97_27 = new GClass97((sbyte) Class15.smethod_0(46));
      GClass97.gclass97_29 = new GClass97((sbyte) Class15.smethod_0(50));
      GClass97.gclass97_30 = new GClass97((sbyte) Class15.smethod_0(33));
      GClass97.gclass97_28 = new GClass97((sbyte) Class15.smethod_0(35));
      GClass97.gclass97_32 = new GClass97((sbyte) Class15.smethod_0(36));
      GClass97.gclass97_31 = new GClass97((sbyte) Class15.smethod_0(6));
      GClass97.gclass97_33 = new GClass97((sbyte) Class15.smethod_0(8));
      GClass97.gclass97_34 = GClass97.gclass97_1;
      GClass97.gclass97_35 = GClass97.gclass97_15;
      GClass97.gclass97_36 = GClass97.gclass97_19;
      GClass97.gclass97_37 = GClass97.gclass97_16;
      GClass97.gclass97_38 = GClass97.gclass97_15;
      GClass97.gclass97_39 = GClass97.gclass97_7;
      GClass97.gclass97_40 = GClass97.gclass97_20;
      GClass97.gclass97_41 = GClass97.gclass97_8;
      GClass97.gclass97_43 = new GClass97((sbyte) Class15.smethod_0(1));
      GClass97.gclass97_44 = new GClass97((sbyte) Class15.smethod_0(2));
      GClass97.gclass97_42 = new GClass97((sbyte) Class15.smethod_0(31));
      GClass97.int_16 = Class15.smethod_0(1);
      if (GClass98.int_8 != Class15.smethod_0(1))
        return;
      GClass97.int_16 = Class15.smethod_0(134);
    }
  }

  public void method_0(int height) => this.int_18 = height;

  public Color method_1(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    float b = (float) num1 / Class15.smethod_2(21);
    float g = (float) num2 / Class15.smethod_2(21);
    return new Color((float) num3 / Class15.smethod_2(21), g, b);
  }

  public Color method_2(int id)
  {
    Color[] colorArray = new Color[Class15.smethod_0(38)];
    colorArray[Class15.smethod_0(0)] = Color.red;
    colorArray[Class15.smethod_0(1)] = Color.yellow;
    colorArray[Class15.smethod_0(7)] = Color.green;
    colorArray[Class15.smethod_0(5)] = Color.white;
    colorArray[Class15.smethod_0(2)] = this.method_1(Class15.smethod_0(423));
    colorArray[Class15.smethod_0(3)] = Color.red;
    colorArray[Class15.smethod_0(37)] = Color.black;
    return colorArray[id - Class15.smethod_0(46)];
  }

  public void method_3(int ID)
  {
    this.color1 = this.method_1(GClass97.int_17[ID]);
    this.color2 = this.method_1(GClass97.int_17[ID]);
  }

  public void method_4(GClass98 g, string st, int x, int y, int align, sbyte idFont)
  {
    sbyte ID = this.id;
    if ((int) idFont > Class15.smethod_0(0))
      ID = idFont;
    x -= Class15.smethod_0(1);
    if ((int) this.id > Class15.smethod_0(40))
    {
      Color[] colorArray1 = new Color[Class15.smethod_0(37)];
      colorArray1[Class15.smethod_0(0)] = this.method_1(Class15.smethod_0(424));
      colorArray1[Class15.smethod_0(1)] = this.method_1(Class15.smethod_0(425));
      colorArray1[Class15.smethod_0(7)] = this.method_1(Class15.smethod_0(426));
      colorArray1[Class15.smethod_0(5)] = this.method_1(Class15.smethod_0(0));
      colorArray1[Class15.smethod_0(2)] = this.method_1(Class15.smethod_0(427));
      colorArray1[Class15.smethod_0(3)] = this.method_1(Class15.smethod_0(424));
      Color[] colorArray2 = colorArray1;
      this.color1 = colorArray2[(int) this.id - Class15.smethod_0(46)];
      this.color2 = colorArray2[(int) this.id - Class15.smethod_0(46)];
      this.method_21(g, st, x + Class15.smethod_0(1), y, align);
      this.method_21(g, st, x - Class15.smethod_0(1), y, align);
      this.method_21(g, st, x, y - Class15.smethod_0(1), align);
      this.method_21(g, st, x, y + Class15.smethod_0(1), align);
      this.method_21(g, st, x + Class15.smethod_0(1), y + Class15.smethod_0(1), align);
      this.method_21(g, st, x + Class15.smethod_0(1), y - Class15.smethod_0(1), align);
      this.method_21(g, st, x - Class15.smethod_0(1), y - Class15.smethod_0(1), align);
      this.method_21(g, st, x - Class15.smethod_0(1), y + Class15.smethod_0(1), align);
      this.color1 = this.method_2((int) this.id);
      this.color2 = this.method_2((int) this.id);
    }
    else
      this.method_3((int) ID);
    this.method_21(g, st, x, y - this.int_20, align);
  }

  public Color method_5(sbyte id) => this.method_1(GClass97.int_17[(int) id]);

  public void method_6(GClass98 g, string st, int x, int y, int align)
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
    {
      int length = st.Length;
      int x1 = (align == 0 ? 1 : 0) != 0 ? x : (align == Class15.smethod_0(1) ? x - this.method_17(st) : x - (this.method_17(st) >> Class15.smethod_0(1)));
      for (int index1 = Class15.smethod_0(0); index1 < length; index1 += Class15.smethod_0(1))
      {
        int index2 = this.string_0.IndexOf(st[index1].ToString() + string.Empty);
        if (index2 == -1)
          index2 = Class15.smethod_0(0);
        if (index2 > -1)
        {
          int x0 = this.int_15[index2][Class15.smethod_0(0)];
          int y0 = this.int_15[index2][Class15.smethod_0(1)];
          int w0 = this.int_15[index2][Class15.smethod_0(7)];
          int h0 = this.int_15[index2][Class15.smethod_0(5)];
          if (y0 + h0 > this.gclass66_0.texture.height)
          {
            y0 -= this.gclass66_0.texture.height;
            x0 = this.gclass66_0.texture.width / Class15.smethod_0(7);
          }
          g.method_24(this.gclass66_0, x0, y0, w0, h0, Class15.smethod_0(0), x1, y, Class15.smethod_0(51));
        }
        x1 += this.int_15[index2][Class15.smethod_0(7)] + this.int_14;
      }
    }
    else
      this.method_4(g, st, x, y, align, (sbyte) Class15.smethod_0(0));
  }

  public void method_7(GClass98 g, string st, int x, int y, int align)
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
      this.method_6(g, st, x, y, align);
    else
      this.method_4(g, st, x, y, align, (sbyte) Class15.smethod_0(0));
  }

  public void method_8(GClass98 g, string st, int x, int y, int align, GClass97 font2)
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
      this.method_10(g, st, x, y, align, font2);
    else
      this.method_9(g, st, x, y, align, font2);
  }

  public void method_9(GClass98 g, string st, int x, int y, int align, GClass97 font)
  {
    this.method_4(g, st, x - Class15.smethod_0(1), y - Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x - Class15.smethod_0(1), y + Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x + Class15.smethod_0(1), y - Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x + Class15.smethod_0(1), y + Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x, y - Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x, y + Class15.smethod_0(1), align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x + Class15.smethod_0(1), y, align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x - Class15.smethod_0(1), y, align, (sbyte) Class15.smethod_0(0));
    this.method_4(g, st, x, y, align, (sbyte) Class15.smethod_0(0));
  }

  public void method_10(GClass98 g, string st, int x, int y, int align, GClass97 font)
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
    {
      int length = st.Length;
      int x1 = (align == 0 ? 1 : 0) != 0 ? x : (align == Class15.smethod_0(1) ? x - this.method_17(st) : x - (this.method_17(st) >> Class15.smethod_0(1)));
      for (int index1 = Class15.smethod_0(0); index1 < length; index1 += Class15.smethod_0(1))
      {
        int index2 = this.string_0.IndexOf(st[index1]);
        if (index2 == -1)
          index2 = Class15.smethod_0(0);
        if (index2 > -1)
        {
          int x0 = this.int_15[index2][Class15.smethod_0(0)];
          int y0 = this.int_15[index2][Class15.smethod_0(1)];
          int w0 = this.int_15[index2][Class15.smethod_0(7)];
          int h0 = this.int_15[index2][Class15.smethod_0(5)];
          if (y0 + h0 > this.gclass66_0.texture.height)
          {
            y0 -= this.gclass66_0.texture.height;
            x0 = this.gclass66_0.texture.width / Class15.smethod_0(7);
          }
          if ((!GClass62.bool_1 ? 0 : 1) == 0 && (font == null ? 1 : 0) == 0)
          {
            g.method_24(font.gclass66_0, x0, y0, w0, h0, Class15.smethod_0(0), x1 + Class15.smethod_0(1), y, Class15.smethod_0(51));
            g.method_24(font.gclass66_0, x0, y0, w0, h0, Class15.smethod_0(0), x1, y + Class15.smethod_0(1), Class15.smethod_0(51));
          }
          g.method_24(this.gclass66_0, x0, y0, w0, h0, Class15.smethod_0(0), x1, y, Class15.smethod_0(51));
        }
        x1 += this.int_15[index2][Class15.smethod_0(7)] + this.int_14;
      }
    }
    else
    {
      this.method_4(g, st, x, y + Class15.smethod_0(1), align, font.id);
      this.method_4(g, st, x, y, align, (sbyte) Class15.smethod_0(0));
    }
  }

  public GClass134 method_11(string src, int lineWidth)
  {
    GClass134 gclass134 = new GClass134();
    string empty = string.Empty;
    for (int index = Class15.smethod_0(0); index < src.Length; index += Class15.smethod_0(1))
    {
      if ((int) src[index] != Class15.smethod_0(31) && (int) src[index] != Class15.smethod_0(88))
      {
        empty += src[index].ToString();
        if (this.method_17(empty) > lineWidth)
        {
          Class15.smethod_0(0);
          int num = empty.Length - Class15.smethod_0(1);
          while (num >= Class15.smethod_0(0) && (int) empty[num] != Class15.smethod_0(120))
            num -= Class15.smethod_0(1);
          if (num < Class15.smethod_0(0))
            num = empty.Length - Class15.smethod_0(1);
          gclass134.method_0((object) empty.Substring(Class15.smethod_0(0), num));
          index = index - (empty.Length - num) + Class15.smethod_0(1);
          empty = string.Empty;
        }
        if (index == src.Length - Class15.smethod_0(1) && (!empty.Trim().Equals(string.Empty) ? 0 : 1) == 0)
          gclass134.method_0((object) empty);
      }
      else
      {
        gclass134.method_0((object) empty);
        empty = string.Empty;
      }
    }
    return gclass134;
  }

  public string method_12(string str)
  {
    string str1 = string.Empty;
    bool flag = Class15.smethod_0(0) != 0;
    for (int index = Class15.smethod_0(0); index < str.Length; index += Class15.smethod_0(1))
    {
      if ((!flag ? 0 : 1) == 0)
      {
        string strSource = str.Substring(index);
        str1 = (!this.method_16(strSource, Class13.smethod_0(149298)) ? 1 : 0) != 0 ? str1 + strSource : str1 + str[index].ToString() + Class13.smethod_0(149296);
        flag = Class15.smethod_0(1) != 0;
      }
      else if ((int) str[index] == Class15.smethod_0(120))
        flag = Class15.smethod_0(0) != 0;
    }
    return str1;
  }

  public string[] method_13(string src, int lineWidth)
  {
    ArrayList arrayList = this.method_14(src, lineWidth);
    string[] strArray = new string[arrayList.Count];
    for (int index = Class15.smethod_0(0); index < arrayList.Count; index += Class15.smethod_0(1))
      strArray[index] = (string) arrayList[index];
    return strArray;
  }

  public ArrayList method_14(string src, int lineWidth)
  {
    ArrayList arrayList = new ArrayList();
    int num1 = Class15.smethod_0(0);
    int index = Class15.smethod_0(0);
    int length = src.Length;
    if (length < Class15.smethod_0(3))
    {
      arrayList.Add((object) src);
      return arrayList;
    }
    string empty = string.Empty;
    try
    {
      while (true)
      {
        while (this.method_19(empty) < lineWidth)
        {
          empty += src[index].ToString();
          index += Class15.smethod_0(1);
          if ((int) src[index] != Class15.smethod_0(31))
          {
            if (index >= length - Class15.smethod_0(1))
            {
              index = length - Class15.smethod_0(1);
              break;
            }
          }
          else
            break;
        }
        if (index != length - Class15.smethod_0(1) && (int) src[index + Class15.smethod_0(1)] != Class15.smethod_0(120))
        {
          int num2 = index;
          while ((int) src[index + Class15.smethod_0(1)] != Class15.smethod_0(31) && ((int) src[index + Class15.smethod_0(1)] != Class15.smethod_0(120) || (int) src[index] == Class15.smethod_0(120)) && index != num1)
            index -= Class15.smethod_0(1);
          if (index == num1)
            index = num2;
        }
        string str = src.Substring(num1, index + Class15.smethod_0(1) - num1);
        if ((int) str[Class15.smethod_0(0)] == Class15.smethod_0(31))
          str = str.Substring(Class15.smethod_0(1), str.Length - Class15.smethod_0(1));
        if ((int) str[str.Length - Class15.smethod_0(1)] == Class15.smethod_0(31))
          str = str.Substring(Class15.smethod_0(0), str.Length - Class15.smethod_0(1));
        arrayList.Add((object) str);
        if (index != length - Class15.smethod_0(1))
        {
          num1 = index + Class15.smethod_0(1);
          while (num1 != length - Class15.smethod_0(1) && (int) src[num1] == Class15.smethod_0(120))
            num1 += Class15.smethod_0(1);
          if (num1 != length - Class15.smethod_0(1))
          {
            index = num1;
            empty = string.Empty;
          }
          else
            break;
        }
        else
          goto label_24;
      }
      return arrayList;
label_24:
      return arrayList;
    }
    catch (Exception ex)
    {
      string[] strArray = new string[Class15.smethod_0(88)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(149291);
      strArray[Class15.smethod_0(1)] = src;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(149328);
      strArray[Class15.smethod_0(5)] = index.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(149322);
      strArray[Class15.smethod_0(3)] = ex.Message;
      strArray[Class15.smethod_0(37)] = Class13.smethod_0(149322);
      strArray[Class15.smethod_0(38)] = ex.StackTrace;
      GClass33.smethod_5(string.Concat(strArray));
      arrayList.Add((object) src);
      return arrayList;
    }
  }

  public string[] method_15(string src, int lineWidth)
  {
    GClass134 gclass134 = this.method_11(src, lineWidth);
    string[] strArray = new string[gclass134.method_2()];
    for (int index = Class15.smethod_0(0); index < gclass134.method_2(); index += Class15.smethod_0(1))
      strArray[index] = (string) gclass134.method_3(index);
    return strArray;
  }

  public bool method_16(string strSource, string str)
  {
    for (int index = Class15.smethod_0(0); index < strSource.Length; index += Class15.smethod_0(1))
    {
      if ((!(string.Empty + strSource[index].ToString()).Equals(str) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public int method_17(string s)
  {
    if (GClass98.int_8 != Class15.smethod_0(1))
      return this.method_18(s);
    int num = Class15.smethod_0(0);
    for (int index1 = Class15.smethod_0(0); index1 < s.Length; index1 += Class15.smethod_0(1))
    {
      int index2 = this.string_0.IndexOf(s[index1]);
      if (index2 == -1)
        index2 = Class15.smethod_0(0);
      num += this.int_15[index2][Class15.smethod_0(7)] + this.int_14;
    }
    return num;
  }

  public int method_18(string s)
  {
    try
    {
      return (int) new GUIStyle() { font = this.myFont }.CalcSize(new GUIContent(s)).x / GClass98.int_8;
    }
    catch (Exception ex)
    {
      string[] strArray = new string[Class15.smethod_0(37)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(149025);
      strArray[Class15.smethod_0(1)] = s;
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(149009);
      strArray[Class15.smethod_0(5)] = ex.Message;
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(149090);
      strArray[Class15.smethod_0(3)] = ex.StackTrace;
      GClass33.smethod_2(string.Concat(strArray));
      return this.method_19(s);
    }
  }

  public int method_19(string s) => s.Length * this.int_19 / GClass98.int_8;

  public int method_20()
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
      return this.int_18;
    if (this.int_18 > Class15.smethod_0(0))
      return this.int_18 / GClass98.int_8;
    GUIStyle guiStyle = new GUIStyle();
    guiStyle.font = this.myFont;
    try
    {
      this.int_18 = (int) guiStyle.CalcSize(new GUIContent(Class13.smethod_0(149088))).y + Class15.smethod_0(7);
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(149082) + ex.StackTrace);
      this.int_18 = Class15.smethod_0(51);
    }
    return this.int_18 / GClass98.int_8;
  }

  public void method_21(GClass98 g, string st, int x0, int y0, int align)
  {
    y0 += GClass97.int_16;
    GUIStyle style = new GUIStyle(GUI.skin.label);
    style.font = this.myFont;
    if (((!this.Equals((object) GClass97.gclass97_43) ? 0 : 1) != 0 || (!this.Equals((object) GClass97.gclass97_42) ? 0 : 1) != 0 || (!this.Equals((object) GClass97.gclass97_44) ? 1 : 0) == 0) && GClass98.int_8 == Class15.smethod_0(7))
    {
      style = new GUIStyle(GUI.skin.label);
      style.fontSize = Class15.smethod_0(47);
    }
    float x = Class15.smethod_2(0);
    float y = Class15.smethod_2(0);
    switch (align)
    {
      case 0:
        x = (float) x0;
        y = (float) y0;
        style.alignment = (TextAnchor) Class15.smethod_0(0);
        break;
      case 1:
        x = (float) (x0 - GClass62.int_10);
        y = (float) y0;
        style.alignment = (TextAnchor) Class15.smethod_0(7);
        break;
      case 2:
      case 3:
        x = (float) (x0 - GClass62.int_10 / Class15.smethod_0(7));
        y = (float) y0;
        style.alignment = (TextAnchor) Class15.smethod_0(1);
        break;
    }
    style.normal.textColor = this.color1;
    if ((int) this.id == Class15.smethod_0(9))
      style.normal.textColor = Color.red;
    if ((!this.Equals((object) GClass97.gclass97_42) ? 1 : 0) == 0)
      style.normal.textColor = Color.black;
    g.method_20(st, (int) x, (int) y, style);
  }

  public static string[] smethod_1(string _text, string _searchStr)
  {
    int num1 = Class15.smethod_0(0);
    int startIndex1 = Class15.smethod_0(0);
    int length = _searchStr.Length;
    int num2 = _text.IndexOf(_searchStr, startIndex1);
    while (num2 != -1)
    {
      int startIndex2 = num2 + length;
      num2 = _text.IndexOf(_searchStr, startIndex2);
      num1 += Class15.smethod_0(1);
    }
    string[] strArray = new string[num1 + Class15.smethod_0(1)];
    int num3 = _text.IndexOf(_searchStr);
    int startIndex3 = Class15.smethod_0(0);
    int index = Class15.smethod_0(0);
    while (num3 != -1)
    {
      strArray[index] = _text.Substring(startIndex3, num3 - startIndex3);
      startIndex3 = num3 + length;
      num3 = _text.IndexOf(_searchStr, startIndex3);
      index += Class15.smethod_0(1);
    }
    strArray[index] = _text.Substring(startIndex3, _text.Length - startIndex3);
    return strArray;
  }

  public void method_22()
  {
    if (GClass98.int_8 != Class15.smethod_0(1))
      return;
    this.gclass66_0 = GClass62.smethod_40(this.string_2);
  }

  public void method_23()
  {
  }

  static GClass97()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(428)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.pwXTlKePreYX));
    GClass97.int_17 = (int[]) Class15.smethod_4(byte_0);
  }
}
