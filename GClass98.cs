// Decompiled with JetBrains decompiler
// Type: GClass98
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections;
using UnityEngine;

public class GClass98
{
  public static int int_0 = Class15.smethod_0(1);
  public static int int_1 = Class15.smethod_0(7);
  public static int int_2 = Class15.smethod_0(2);
  public static int int_3 = Class15.smethod_0(88);
  public static int int_4 = Class15.smethod_0(10);
  public static int int_5 = Class15.smethod_0(120);
  private float float_0;
  private float float_1;
  private float float_2;
  private float float_3;
  public int clipX;
  public int clipY;
  public int clipW;
  public int clipH;
  private bool bool_0;
  private bool bool_1 = Class15.smethod_0(1) != 0;
  private int int_6;
  private int int_7;
  private float float_4;
  private float float_5;
  public static int int_8 = Class15.smethod_0(1);
  public const int int_9 = 64;
  public const int int_10 = 0;
  public const int int_11 = 1;
  public const int int_12 = 2;
  public const int int_13 = 1;
  public const int int_14 = 4;
  public const int int_15 = 7;
  public const int int_16 = 0;
  public const int int_17 = 3;
  public const int int_18 = 6;
  public const int int_19 = 5;
  public static Hashtable hashtable_0 = new Hashtable();
  public static int int_20;
  private int int_21;
  private int int_22;
  private int int_23;
  private Vector2 vector2_0 = new Vector2(Class15.smethod_2(0), Class15.smethod_2(0));
  private Rect rect_0;
  private Matrix4x4 matrix4x4_0;
  private Vector2 vector2_1;
  public Vector2 size = new Vector2(Class15.smethod_2(30), Class15.smethod_2(30));
  public Vector2 relativePosition = new Vector2(Class15.smethod_2(0), Class15.smethod_2(0));
  public Color clTrans;
  public static Color color_0 = new Color(Class15.smethod_2(16), Class15.smethod_2(16), Class15.smethod_2(16), Class15.smethod_2(0));
  private Material material_0;

  private void method_0(string string_0, Texture texture_0)
  {
    if (GClass98.hashtable_0.Count > Class15.smethod_0(320))
      GClass98.hashtable_0.Clear();
    if (texture_0.width * texture_0.height >= GClass62.int_10 * GClass62.int_11)
      return;
    GClass98.hashtable_0.Add((object) string_0, (object) texture_0);
  }

  public void method_1(int tx, int ty)
  {
    tx *= GClass98.int_8;
    ty *= GClass98.int_8;
    this.int_6 += tx;
    this.int_7 += ty;
    this.bool_1 = Class15.smethod_0(1) != 0;
    if ((this.int_6 == 0 ? 0 : 1) != 0 || (this.int_7 == 0 ? 0 : 1) != 0)
      return;
    this.bool_1 = Class15.smethod_0(0) != 0;
  }

  public void method_2(float x, float y)
  {
    this.float_4 += x;
    this.float_5 += y;
    this.bool_1 = Class15.smethod_0(1) != 0;
    if ((double) this.float_4 != (double) Class15.smethod_2(0) || (double) this.float_5 != (double) Class15.smethod_2(0))
      return;
    this.bool_1 = Class15.smethod_0(0) != 0;
  }

  public int method_3() => this.int_6 / GClass98.int_8;

  public int method_4() => this.int_7 / GClass98.int_8 + GClass98.int_20;

  public void method_5(int x, int y, int w, int h)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    w *= GClass98.int_8;
    h *= GClass98.int_8;
    this.int_21 = this.int_6;
    this.int_22 = this.int_7;
    this.clipX = x;
    this.clipY = y;
    this.clipW = w;
    this.clipH = h;
    this.bool_0 = Class15.smethod_0(1) != 0;
  }

  public int method_6() => GClass116.int_22;

  public int method_7() => GClass116.int_23;

  public int method_8() => GClass116.int_6;

  public int method_9() => GClass116.int_7;

  public void method_10(int x, int y, int w, int h, int color, int alpha)
  {
    float alpha1 = Class15.smethod_2(7);
    this.method_21(color, alpha1);
    this.method_15(x, y, w, h);
  }

  public void method_11(int x1, int y1, int x2, int y2)
  {
    x1 *= GClass98.int_8;
    y1 *= GClass98.int_8;
    x2 *= GClass98.int_8;
    y2 *= GClass98.int_8;
    if (y1 == y2)
    {
      if (x1 > x2)
      {
        int num = x2;
        x2 = x1;
        x1 = num;
      }
      this.method_15(x1, y1, x2 - x1, Class15.smethod_0(1));
    }
    else if (x1 == x2)
    {
      if (y1 > y2)
      {
        int num = y2;
        y2 = y1;
        y1 = num;
      }
      this.method_15(x1, y1, Class15.smethod_0(1), y2 - y1);
    }
    else
    {
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_6;
        y1 += this.int_7;
        x2 += this.int_6;
        y2 += this.int_7;
      }
      string str = Class13.smethod_0(149142) + this.float_0.ToString() + this.float_1.ToString() + this.float_2.ToString();
      Texture2D texture_0 = (Texture2D) GClass98.hashtable_0[(object) str];
      if ((!((UnityEngine.Object) texture_0 == (UnityEngine.Object) null) ? 1 : 0) == 0)
      {
        texture_0 = new Texture2D(Class15.smethod_0(1), Class15.smethod_0(1));
        Color color = new Color(this.float_0, this.float_1, this.float_2);
        texture_0.SetPixel(Class15.smethod_0(0), Class15.smethod_0(0), color);
        texture_0.Apply();
        this.method_0(str, (Texture) texture_0);
      }
      Vector2 pivotPoint = new Vector2((float) x1, (float) y1);
      Vector2 vector2 = new Vector2((float) x2, (float) y2) - pivotPoint;
      float angle = Class15.smethod_2(23) * Mathf.Atan(vector2.y / vector2.x);
      if ((double) vector2.x < (double) Class15.smethod_2(0))
        angle += Class15.smethod_2(24);
      int num = (int) Mathf.Ceil(Class15.smethod_2(0));
      GUIUtility.RotateAroundPivot(angle, pivotPoint);
      int x = Class15.smethod_0(0);
      int y = Class15.smethod_0(0);
      int width = Class15.smethod_0(0);
      int height = Class15.smethod_0(0);
      if ((!this.bool_0 ? 1 : 0) == 0)
      {
        x = this.clipX;
        y = this.clipY;
        width = this.clipW;
        height = this.clipH;
        if ((!this.bool_1 ? 1 : 0) == 0)
        {
          x += this.int_21;
          y += this.int_22;
        }
      }
      if ((!this.bool_0 ? 1 : 0) == 0)
        GUI.BeginGroup(new Rect((float) x, (float) y, (float) width, (float) height));
      Graphics.DrawTexture(new Rect(pivotPoint.x - (float) x, pivotPoint.y - (float) num - (float) y, vector2.magnitude, Class15.smethod_2(16)), (Texture) texture_0);
      if ((!this.bool_0 ? 1 : 0) == 0)
        GUI.EndGroup();
      GUIUtility.RotateAroundPivot(Class15.smethod_2(0) - angle, pivotPoint);
    }
  }

  public Color method_12(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    float b = (float) num1 / Class15.smethod_2(21);
    float g = (float) num2 / Class15.smethod_2(21);
    return new Color((float) num3 / Class15.smethod_2(21), g, b);
  }

  public float[] method_13(Color cl)
  {
    float num1 = Class15.smethod_2(21) * cl.r;
    float num2 = Class15.smethod_2(21) * cl.g;
    float num3 = Class15.smethod_2(21) * cl.b;
    float[] numArray = new float[Class15.smethod_0(5)];
    numArray[Class15.smethod_0(0)] = num1;
    numArray[Class15.smethod_0(1)] = num2;
    numArray[Class15.smethod_0(7)] = num3;
    return numArray;
  }

  public void method_14(int x, int y, int w, int h)
  {
    int num = Class15.smethod_0(1);
    this.method_15(x, y, w, num);
    this.method_15(x, y, num, h);
    this.method_15(x + w, y, num, h + Class15.smethod_0(1));
    this.method_15(x, y + h, w + Class15.smethod_0(1), num);
  }

  public void method_15(int x, int y, int w, int h)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    w *= GClass98.int_8;
    h *= GClass98.int_8;
    if (w < Class15.smethod_0(0) || h < Class15.smethod_0(0))
      return;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += this.int_6;
      y += this.int_7;
    }
    int width1 = Class15.smethod_0(1);
    int height1 = Class15.smethod_0(1);
    string[] strArray = new string[Class15.smethod_0(38)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(149822);
    strArray[Class15.smethod_0(1)] = width1.ToString();
    strArray[Class15.smethod_0(7)] = height1.ToString();
    strArray[Class15.smethod_0(5)] = this.float_0.ToString();
    strArray[Class15.smethod_0(2)] = this.float_1.ToString();
    strArray[Class15.smethod_0(3)] = this.float_2.ToString();
    strArray[Class15.smethod_0(37)] = this.float_3.ToString();
    string str = string.Concat(strArray);
    Texture2D texture2D = (Texture2D) GClass98.hashtable_0[(object) str];
    if ((!((UnityEngine.Object) texture2D == (UnityEngine.Object) null) ? 1 : 0) == 0)
    {
      texture2D = new Texture2D(width1, height1);
      Color color = new Color(this.float_0, this.float_1, this.float_2, this.float_3);
      texture2D.SetPixel(Class15.smethod_0(0), Class15.smethod_0(0), color);
      texture2D.Apply();
      this.method_0(str, (Texture) texture2D);
    }
    int x1 = Class15.smethod_0(0);
    int y1 = Class15.smethod_0(0);
    int width2 = Class15.smethod_0(0);
    int height2 = Class15.smethod_0(0);
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      y1 = this.clipY;
      width2 = this.clipW;
      height2 = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        y1 += this.int_22;
      }
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      GUI.BeginGroup(new Rect((float) x1, (float) y1, (float) width2, (float) height2));
    GUI.DrawTexture(new Rect((float) (x - x1), (float) (y - y1), (float) w, (float) h), (Texture) texture2D);
    if ((!this.bool_0 ? 1 : 0) != 0)
      return;
    GUI.EndGroup();
  }

  public void method_16(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    this.float_2 = (float) num1 / Class15.smethod_2(21);
    this.float_1 = (float) num2 / Class15.smethod_2(21);
    this.float_0 = (float) num3 / Class15.smethod_2(21);
    this.float_3 = Class15.smethod_2(8);
  }

  public void method_17(Color color)
  {
    this.float_2 = color.b;
    this.float_1 = color.g;
    this.float_0 = color.r;
  }

  public void method_18(Color color, float a)
  {
    this.float_2 = color.b;
    this.float_1 = color.g;
    this.float_0 = color.r;
    this.float_3 = a;
  }

  public void method_19(int rgb)
  {
    if (rgb == this.int_23)
      return;
    this.int_23 = rgb;
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    this.float_2 = (float) num1 / Class15.smethod_2(21);
    this.float_1 = (float) num2 / Class15.smethod_2(21);
    this.float_0 = (float) num3 / Class15.smethod_2(21);
    Main.main_0.GetComponent<Camera>().backgroundColor = new Color(this.float_0, this.float_1, this.float_2);
  }

  public void method_20(string s, int x, int y, GUIStyle style)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += this.int_6;
      y += this.int_7;
    }
    int x1 = Class15.smethod_0(0);
    int y1 = Class15.smethod_0(0);
    int width = Class15.smethod_0(0);
    int height = Class15.smethod_0(0);
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      y1 = this.clipY;
      width = this.clipW;
      height = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        y1 += this.int_22;
      }
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      GUI.BeginGroup(new Rect((float) x1, (float) y1, (float) width, (float) height));
    GUI.Label(new Rect((float) (x - x1), (float) (y - y1), GClass153.float_0, Class15.smethod_2(25)), s, style);
    if ((!this.bool_0 ? 1 : 0) != 0)
      return;
    GUI.EndGroup();
  }

  public void method_21(int rgb, float alpha)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    this.float_2 = (float) num1 / Class15.smethod_2(21);
    this.float_1 = (float) num2 / Class15.smethod_2(21);
    this.float_0 = (float) num3 / Class15.smethod_2(21);
    this.float_3 = alpha;
  }

  public void method_22(string s, int x, int y, GUIStyle style, int w)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += this.int_6;
      y += this.int_7;
    }
    int x1 = Class15.smethod_0(0);
    int y1 = Class15.smethod_0(0);
    int width = Class15.smethod_0(0);
    int height = Class15.smethod_0(0);
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      y1 = this.clipY;
      width = this.clipW;
      height = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        y1 += this.int_22;
      }
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      GUI.BeginGroup(new Rect((float) x1, (float) y1, (float) width, (float) height));
    GUI.Label(new Rect((float) (x - x1), (float) (y - y1 - Class15.smethod_0(2)), (float) w, Class15.smethod_2(25)), s, style);
    if ((!this.bool_0 ? 1 : 0) != 0)
      return;
    GUI.EndGroup();
  }

  private void method_23(int int_24)
  {
    Vector2 vector2 = new Vector2(Class15.smethod_2(0), Class15.smethod_2(0));
    if (int_24 <= Class15.smethod_0(186))
    {
      if (int_24 <= Class15.smethod_0(37))
      {
        if (int_24 != Class15.smethod_0(5))
        {
          if (int_24 == Class15.smethod_0(37))
            vector2 = new Vector2(Class15.smethod_2(0), (float) (Screen.height / Class15.smethod_0(7)));
        }
        else
          vector2 = new Vector2(this.size.x / Class15.smethod_2(17), this.size.y / Class15.smethod_2(17));
      }
      else if (int_24 != Class15.smethod_0(31))
      {
        if (int_24 == Class15.smethod_0(186))
          vector2 = new Vector2((float) (Screen.width / Class15.smethod_0(7)), Class15.smethod_2(0));
      }
      else
        vector2 = new Vector2((float) Screen.width, (float) (Screen.height / Class15.smethod_0(7)));
    }
    else if (int_24 <= Class15.smethod_0(40))
    {
      if (int_24 != Class15.smethod_0(51))
      {
        if (int_24 == Class15.smethod_0(40))
          vector2 = new Vector2((float) Screen.width, Class15.smethod_2(0));
      }
      else
        vector2 = new Vector2(Class15.smethod_2(0), Class15.smethod_2(0));
    }
    else if (int_24 != Class15.smethod_0(48))
    {
      if (int_24 != Class15.smethod_0(86))
      {
        if (int_24 == Class15.smethod_0(54))
          vector2 = new Vector2((float) Screen.width, (float) Screen.height);
      }
      else
        vector2 = new Vector2(Class15.smethod_2(0), (float) Screen.height);
    }
    else
      vector2 = new Vector2((float) (Screen.width / Class15.smethod_0(7)), (float) Screen.height);
    this.vector2_0 = vector2 + this.relativePosition;
    this.rect_0 = new Rect(this.vector2_0.x - this.size.x * Class15.smethod_2(7), this.vector2_0.y - this.size.y * Class15.smethod_2(7), this.size.x, this.size.y);
    this.vector2_1 = new Vector2(this.rect_0.xMin + this.rect_0.width * Class15.smethod_2(7), this.rect_0.yMin + this.rect_0.height * Class15.smethod_2(7));
  }

  public void method_24(
    GClass66 arg0,
    int x0,
    int y0,
    int w0,
    int h0,
    int arg5,
    int x,
    int y,
    int arg8)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    x0 *= GClass98.int_8;
    y0 *= GClass98.int_8;
    w0 *= GClass98.int_8;
    h0 *= GClass98.int_8;
    this.method_28(arg0, (float) x0, (float) y0, w0, h0, arg5, x, y, arg8);
  }

  public void method_25(
    GClass66 arg0,
    int x0,
    int y0,
    int w0,
    int h0,
    int arg5,
    float x,
    float y,
    int arg8)
  {
    x *= (float) GClass98.int_8;
    y *= (float) GClass98.int_8;
    x0 *= GClass98.int_8;
    y0 *= GClass98.int_8;
    w0 *= GClass98.int_8;
    h0 *= GClass98.int_8;
    this.method_27(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
  }

  public void method_26(
    GClass66 arg0,
    int x0,
    int y0,
    int w0,
    int h0,
    int arg5,
    int x,
    int y,
    int arg8,
    bool isClip)
  {
    this.method_24(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
  }

  public void method_27(
    GClass66 image,
    int x0,
    int y0,
    int w,
    int h,
    int transform,
    float x,
    float y,
    int anchor)
  {
    if ((image == null ? 0 : 1) == 0)
      return;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += (float) this.int_6;
      y += (float) this.int_7;
    }
    float num1 = (float) w;
    float num2 = (float) h;
    float num3 = Class15.smethod_2(0);
    float num4 = Class15.smethod_2(0);
    float num5 = Class15.smethod_2(0);
    float num6 = Class15.smethod_2(0);
    float num7 = Class15.smethod_2(16);
    float num8 = Class15.smethod_2(0);
    int num9 = Class15.smethod_0(1);
    if ((anchor & GClass98.int_0) == GClass98.int_0)
      num5 -= num1 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_1) == GClass98.int_1)
      num6 -= num2 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_3) == GClass98.int_3)
      num5 -= num1;
    if ((anchor & GClass98.int_5) == GClass98.int_5)
      num6 -= num2;
    x += num5;
    y += num6;
    int x1 = Class15.smethod_0(0);
    Class15.smethod_0(0);
    int width = Class15.smethod_0(0);
    Class15.smethod_0(0);
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      int clipY = this.clipY;
      width = this.clipW;
      int clipH = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        clipY += this.int_22;
      }
      Rect r1 = new Rect(x, y, (float) w, (float) h);
      Rect r2 = new Rect((float) x1, (float) clipY, (float) width, (float) clipH);
      Rect rect = this.method_39(r1, r2);
      if ((double) rect.width <= (double) Class15.smethod_2(0) || (double) rect.height <= (double) Class15.smethod_2(0))
        return;
      num1 = rect.width;
      num2 = rect.height;
      num3 = rect.x - r1.x;
      num4 = rect.y - r1.y;
    }
    float num10 = Class15.smethod_2(0);
    float num11 = Class15.smethod_2(0);
    switch (transform - Class15.smethod_0(1))
    {
      case 0:
        num9 = -1;
        num11 += num2;
        break;
      case 1:
        num10 += num1;
        num7 = Class15.smethod_2(26);
        if ((!this.bool_0 ? 1 : 0) == 0)
        {
          if ((double) x1 > (double) x)
          {
            num8 = Class15.smethod_2(0) - num3;
            break;
          }
          if ((double) (x1 + width) < (double) x + (double) w)
          {
            num8 = Class15.smethod_2(0) - ((float) (x1 + width) - x - (float) w);
            break;
          }
          break;
        }
        break;
      case 2:
        num9 = -1;
        num11 += num2;
        num7 = Class15.smethod_2(26);
        num10 += num1;
        break;
    }
    int num12 = Class15.smethod_0(0);
    int num13 = Class15.smethod_0(0);
    if (transform == Class15.smethod_0(3) || transform == Class15.smethod_0(37) || transform == Class15.smethod_0(2) || transform == Class15.smethod_0(38))
    {
      this.matrix4x4_0 = GUI.matrix;
      this.size = new Vector2((float) w, (float) h);
      this.relativePosition = new Vector2(x, y);
      this.method_23(Class15.smethod_0(5));
      if (transform != Class15.smethod_0(3))
      {
        if (transform == Class15.smethod_0(37))
          this.method_23(Class15.smethod_0(5));
      }
      else
      {
        this.size = new Vector2((float) w, (float) h);
        this.method_23(Class15.smethod_0(5));
      }
      switch (transform - Class15.smethod_0(2))
      {
        case 0:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          num10 += num1;
          num7 = Class15.smethod_2(26);
          if ((!this.bool_0 ? 1 : 0) == 0)
          {
            if ((double) x1 > (double) x)
            {
              num8 = Class15.smethod_2(0) - num3;
              break;
            }
            if ((double) (x1 + width) < (double) x + (double) w)
            {
              num8 = Class15.smethod_2(0) - ((float) (x1 + width) - x - (float) w);
              break;
            }
            break;
          }
          break;
        case 1:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(27), this.vector2_1);
          break;
        case 2:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          break;
        case 3:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          num9 = -1;
          num11 += num2;
          break;
      }
    }
    Graphics.DrawTexture(new Rect(x + num3 + num10 + (float) num12, y + num4 + (float) num13 + num11, num1 * num7, num2 * (float) num9), (Texture) image.texture, new Rect(((float) x0 + num3 + num8) / (float) image.texture.width, (float) ((double) image.texture.height - (double) num2 - ((double) y0 + (double) num4)) / (float) image.texture.height, num1 / (float) image.texture.width, num2 / (float) image.texture.height), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0));
    if (transform != Class15.smethod_0(3) && transform != Class15.smethod_0(37) && transform != Class15.smethod_0(2) && transform != Class15.smethod_0(38))
      return;
    GUI.matrix = this.matrix4x4_0;
  }

  public void method_28(
    GClass66 image,
    float x0,
    float y0,
    int w,
    int h,
    int transform,
    int x,
    int y,
    int anchor)
  {
    if ((image == null ? 0 : 1) == 0)
      return;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += this.int_6;
      y += this.int_7;
    }
    float num1 = (float) w;
    float num2 = (float) h;
    float num3 = Class15.smethod_2(0);
    float num4 = Class15.smethod_2(0);
    float num5 = Class15.smethod_2(0);
    float num6 = Class15.smethod_2(0);
    float num7 = Class15.smethod_2(16);
    float num8 = Class15.smethod_2(0);
    int num9 = Class15.smethod_0(1);
    if ((anchor & GClass98.int_0) == GClass98.int_0)
      num5 -= num1 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_1) == GClass98.int_1)
      num6 -= num2 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_3) == GClass98.int_3)
      num5 -= num1;
    if ((anchor & GClass98.int_5) == GClass98.int_5)
      num6 -= num2;
    x += (int) num5;
    y += (int) num6;
    int x1 = Class15.smethod_0(0);
    Class15.smethod_0(0);
    int width = Class15.smethod_0(0);
    Class15.smethod_0(0);
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      int clipY = this.clipY;
      width = this.clipW;
      int clipH = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        clipY += this.int_22;
      }
      Rect r1 = new Rect((float) x, (float) y, (float) w, (float) h);
      Rect r2 = new Rect((float) x1, (float) clipY, (float) width, (float) clipH);
      Rect rect = this.method_39(r1, r2);
      if ((double) rect.width <= (double) Class15.smethod_2(0) || (double) rect.height <= (double) Class15.smethod_2(0))
        return;
      num1 = rect.width;
      num2 = rect.height;
      num3 = rect.x - r1.x;
      num4 = rect.y - r1.y;
    }
    float num10 = Class15.smethod_2(0);
    float num11 = Class15.smethod_2(0);
    switch (transform - Class15.smethod_0(1))
    {
      case 0:
        num9 = -1;
        num11 += num2;
        break;
      case 1:
        num10 += num1;
        num7 = Class15.smethod_2(26);
        if ((!this.bool_0 ? 1 : 0) == 0)
        {
          if (x1 > x)
          {
            num8 = Class15.smethod_2(0) - num3;
            break;
          }
          if (x1 + width < x + w)
          {
            num8 = (float) -(x1 + width - x - w);
            break;
          }
          break;
        }
        break;
      case 2:
        num9 = -1;
        num11 += num2;
        num7 = Class15.smethod_2(26);
        num10 += num1;
        break;
    }
    int num12 = Class15.smethod_0(0);
    int num13 = Class15.smethod_0(0);
    if (transform == Class15.smethod_0(3) || transform == Class15.smethod_0(37) || transform == Class15.smethod_0(2) || transform == Class15.smethod_0(38))
    {
      this.matrix4x4_0 = GUI.matrix;
      this.size = new Vector2((float) w, (float) h);
      this.relativePosition = new Vector2((float) x, (float) y);
      this.method_23(Class15.smethod_0(5));
      if (transform != Class15.smethod_0(3))
      {
        if (transform == Class15.smethod_0(37))
          this.method_23(Class15.smethod_0(5));
      }
      else
      {
        this.size = new Vector2((float) w, (float) h);
        this.method_23(Class15.smethod_0(5));
      }
      switch (transform - Class15.smethod_0(2))
      {
        case 0:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          num10 += num1;
          num7 = Class15.smethod_2(26);
          if ((!this.bool_0 ? 1 : 0) == 0)
          {
            if (x1 > x)
            {
              num8 = Class15.smethod_2(0) - num3;
              break;
            }
            if (x1 + width < x + w)
            {
              num8 = (float) -(x1 + width - x - w);
              break;
            }
            break;
          }
          break;
        case 1:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(27), this.vector2_1);
          break;
        case 2:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          break;
        case 3:
          GUIUtility.RotateAroundPivot(Class15.smethod_2(28), this.vector2_1);
          num9 = -1;
          num11 += num2;
          break;
      }
    }
    Graphics.DrawTexture(new Rect((float) x + num3 + num10 + (float) num12, (float) y + num4 + (float) num13 + num11, num1 * num7, num2 * (float) num9), (Texture) image.texture, new Rect((x0 + num3 + num8) / (float) image.texture.width, (float) ((double) image.texture.height - (double) num2 - ((double) y0 + (double) num4)) / (float) image.texture.height, num1 / (float) image.texture.width, num2 / (float) image.texture.height), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0));
    if (transform != Class15.smethod_0(3) && transform != Class15.smethod_0(37) && transform != Class15.smethod_0(2) && transform != Class15.smethod_0(38))
      return;
    GUI.matrix = this.matrix4x4_0;
  }

  public void method_29(
    GClass66 image,
    float x0,
    float y0,
    int w,
    int h,
    int transform,
    float x,
    float y,
    int anchor)
  {
    GUI.color = this.method_12(Class15.smethod_0(167));
    x *= (float) GClass98.int_8;
    y *= (float) GClass98.int_8;
    x0 *= (float) GClass98.int_8;
    y0 *= (float) GClass98.int_8;
    w *= GClass98.int_8;
    h *= GClass98.int_8;
  }

  public void method_30(
    GClass66 image,
    float x0,
    float y0,
    int w,
    int h,
    int transform,
    int x,
    int y,
    int anchor)
  {
    GUI.color = image.colorBlend;
    if ((!this.bool_1 ? 1 : 0) == 0)
    {
      x += this.int_6;
      y += this.int_7;
    }
    string[] strArray = new string[Class15.smethod_0(38)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(149623);
    strArray[Class15.smethod_0(1)] = x0.ToString();
    strArray[Class15.smethod_0(7)] = y0.ToString();
    strArray[Class15.smethod_0(5)] = w.ToString();
    strArray[Class15.smethod_0(2)] = h.ToString();
    strArray[Class15.smethod_0(3)] = transform.ToString();
    strArray[Class15.smethod_0(37)] = image.GetHashCode().ToString();
    string str = string.Concat(strArray);
    Texture2D texture = (Texture2D) GClass98.hashtable_0[(object) str];
    if ((!((UnityEngine.Object) texture == (UnityEngine.Object) null) ? 1 : 0) == 0)
    {
      texture = GClass66.smethod_3(image, (int) x0, (int) y0, w, h, transform).texture;
      this.method_0(str, (Texture) texture);
    }
    int x1 = Class15.smethod_0(0);
    int y1 = Class15.smethod_0(0);
    int width = Class15.smethod_0(0);
    int height = Class15.smethod_0(0);
    float num1 = (float) w;
    float num2 = (float) h;
    float num3 = Class15.smethod_2(0);
    float num4 = Class15.smethod_2(0);
    if ((anchor & GClass98.int_0) == GClass98.int_0)
      num3 -= num1 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_1) == GClass98.int_1)
      num4 -= num2 / Class15.smethod_2(17);
    if ((anchor & GClass98.int_3) == GClass98.int_3)
      num3 -= num1;
    if ((anchor & GClass98.int_5) == GClass98.int_5)
      num4 -= num2;
    x += (int) num3;
    y += (int) num4;
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      x1 = this.clipX;
      y1 = this.clipY;
      width = this.clipW;
      height = this.clipH;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_21;
        y1 += this.int_22;
      }
    }
    if ((!this.bool_0 ? 1 : 0) == 0)
      GUI.BeginGroup(new Rect((float) x1, (float) y1, (float) width, (float) height));
    GUI.DrawTexture(new Rect((float) (x - x1), (float) (y - y1), (float) w, (float) h), (Texture) texture);
    if ((!this.bool_0 ? 1 : 0) == 0)
      GUI.EndGroup();
    GUI.color = new Color(Class15.smethod_2(16), Class15.smethod_2(16), Class15.smethod_2(16), Class15.smethod_2(16));
  }

  public void method_31(GClass66 image, float x, float y)
  {
    x *= (float) GClass98.int_8;
    y *= (float) GClass98.int_8;
    GUI.DrawTexture(new Rect(x + (float) this.int_6, y + (float) this.int_7, (float) image.method_3(), (float) image.method_4()), (Texture) image.texture);
  }

  public void method_32(GClass66 image, int x, int y, int anchor)
  {
    if ((image == null ? 1 : 0) != 0 || (!GClass13.gclass13_0.method_36() ? 0 : 1) != 0)
      return;
    this.method_24(image, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(image), GClass98.smethod_1(image), Class15.smethod_0(0), x, y, anchor);
  }

  public void method_33(GClass66 image, int x, int y, int anchor)
  {
    if ((image == null ? 1 : 0) != 0)
      return;
    this.method_24(image, Class15.smethod_0(0), Class15.smethod_0(0), image.texture.width, image.texture.height, Class15.smethod_0(0), x, y, anchor);
  }

  public void method_34(GClass66 image, int x, int y)
  {
    if ((image == null ? 1 : 0) != 0)
      return;
    this.method_24(image, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(image), GClass98.smethod_1(image), Class15.smethod_0(0), x, y, GClass98.int_4 | GClass98.int_2);
  }

  public void method_35(GClass66 image, float x, float y, int anchor)
  {
    if ((image == null ? 1 : 0) != 0)
      return;
    this.method_25(image, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(image), GClass98.smethod_1(image), Class15.smethod_0(0), x, y, anchor);
  }

  public void method_36(int x, int y, int w, int h, int arcWidth, int arcHeight) => this.method_14(x, y, w, h);

  public void method_37(int x, int y, int width, int height, int arcWidth, int arcHeight) => this.method_15(x, y, width, height);

  public void method_38()
  {
    this.bool_0 = Class15.smethod_0(0) != 0;
    this.bool_1 = Class15.smethod_0(0) != 0;
    this.int_6 = Class15.smethod_0(0);
    this.int_7 = Class15.smethod_0(0);
  }

  public Rect method_39(Rect r1, Rect r2)
  {
    float x1 = r1.x;
    float y1 = r1.y;
    float x2 = r2.x;
    float y2 = r2.y;
    float num1 = x1 + r1.width;
    float num2 = y1 + r1.height;
    float num3 = x2 + r2.width;
    float num4 = y2 + r2.height;
    if ((double) x1 < (double) x2)
      x1 = x2;
    if ((double) y1 < (double) y2)
      y1 = y2;
    if ((double) num1 > (double) num3)
      num1 = num3;
    if ((double) num2 > (double) num4)
      num2 = num4;
    float width = num1 - x1;
    float height = num2 - y1;
    if ((double) width < (double) Class15.smethod_2(29))
      width = Class15.smethod_2(29);
    if ((double) height < (double) Class15.smethod_2(29))
      height = Class15.smethod_2(29);
    return new Rect(x1, y1, (float) (int) width, (float) (int) height);
  }

  public void method_40(GClass66 image, int x, int y, int w, int h, int tranform)
  {
    GUI.color = Color.red;
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    w *= GClass98.int_8;
    h *= GClass98.int_8;
    if ((image == null ? 1 : 0) != 0)
      return;
    Graphics.DrawTexture(new Rect((float) (x + this.int_6), (float) (y + this.int_7), (tranform == 0 ? 0 : 1) != 0 ? (float) -w : (float) w, (float) h), (Texture) image.texture);
  }

  public void method_41(GClass66 image, int x, int y)
  {
    x *= GClass98.int_8;
    y *= GClass98.int_8;
    if ((image == null ? 1 : 0) != 0)
      return;
    Graphics.DrawTexture(new Rect((float) x, (float) y, (float) image.w, (float) image.h), (Texture) image.texture);
  }

  public static int smethod_0(GClass66 image) => image.method_0();

  public static int smethod_1(GClass66 image) => image.method_1();

  public static bool smethod_2(Color color) => (!(color == Color.clear) ? 0 : 1) == 0 && (!(color == GClass98.color_0) ? 1 : 0) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public static GClass66 smethod_3(GClass66 img0, float level, int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    float b1 = (float) num1 / Class15.smethod_2(21);
    float g1 = (float) num2 / Class15.smethod_2(21);
    Color color1 = new Color((float) num3 / Class15.smethod_2(21), g1, b1);
    Color[] pixels = img0.texture.GetPixels();
    float r = color1.r;
    float g2 = color1.g;
    float b2 = color1.b;
    for (int index = Class15.smethod_0(0); index < pixels.Length; index += Class15.smethod_0(1))
    {
      Color color2 = pixels[index];
      if ((!GClass98.smethod_2(color2) ? 1 : 0) == 0)
      {
        float num4 = (r - color2.r) * level + color2.r;
        float num5 = (g2 - color2.g) * level + color2.g;
        float num6 = (b2 - color2.b) * level + color2.b;
        if ((double) num4 > (double) Class15.smethod_2(8))
          num4 = Class15.smethod_2(8);
        if ((double) num4 < (double) Class15.smethod_2(0))
          num4 = Class15.smethod_2(0);
        if ((double) num5 > (double) Class15.smethod_2(8))
          num5 = Class15.smethod_2(8);
        if ((double) num5 < (double) Class15.smethod_2(0))
          num5 = Class15.smethod_2(0);
        if ((double) num6 < (double) Class15.smethod_2(0))
          num6 = Class15.smethod_2(0);
        if ((double) num6 > (double) Class15.smethod_2(8))
          num6 = Class15.smethod_2(8);
        pixels[index].r = num4;
        pixels[index].g = num5;
        pixels[index].b = num6;
      }
    }
    GClass66 gclass66 = GClass66.smethod_4(img0.method_3(), img0.method_4());
    gclass66.texture.SetPixels(pixels);
    GClass66.smethod_26(gclass66.texture);
    gclass66.texture.Apply();
    GClass33.smethod_3(Class13.smethod_0(149670));
    return gclass66;
  }

  public static Color smethod_4(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    float b = (float) num1 / Class15.smethod_2(21);
    float g = (float) num2 / Class15.smethod_2(21);
    return new Color((float) num3 / Class15.smethod_2(21), g, b);
  }

  public void method_42(GClass66 imgTrans, int x, int y, int w, int h)
  {
    this.method_21(Class15.smethod_0(0), Class15.smethod_2(7));
    this.method_15(x * GClass98.int_8, y * GClass98.int_8, w * GClass98.int_8, h * GClass98.int_8);
  }

  public static int smethod_5(float level, int color, int colorBlend)
  {
    Color color1 = GClass98.smethod_4(colorBlend);
    float num1 = color1.r * Class15.smethod_2(8);
    float num2 = color1.g * Class15.smethod_2(8);
    double num3 = (double) color1.b * (double) Class15.smethod_2(8);
    Color color2 = GClass98.smethod_4(color);
    float num4 = (num1 + color2.r) * level + color2.r;
    float num5 = (num2 + color2.g) * level + color2.g;
    double b = (double) color2.b;
    float num6 = (float) (num3 + b) * level + color2.b;
    if ((double) num4 > (double) Class15.smethod_2(8))
      num4 = Class15.smethod_2(8);
    if ((double) num4 < (double) Class15.smethod_2(0))
      num4 = Class15.smethod_2(0);
    if ((double) num5 > (double) Class15.smethod_2(8))
      num5 = Class15.smethod_2(8);
    if ((double) num5 < (double) Class15.smethod_2(0))
      num5 = Class15.smethod_2(0);
    if ((double) num6 < (double) Class15.smethod_2(0))
      num6 = Class15.smethod_2(0);
    if ((double) num6 > (double) Class15.smethod_2(8))
      num6 = Class15.smethod_2(8);
    return (int) num6 & Class15.smethod_0(270) + ((int) num5 << Class15.smethod_0(88)) & Class15.smethod_0(270) + ((int) num4 << Class15.smethod_0(10)) & Class15.smethod_0(270);
  }

  public static int smethod_6(Color cl)
  {
    double num1 = (double) cl.r * (double) Class15.smethod_2(8);
    float num2 = cl.b * Class15.smethod_2(8);
    float num3 = cl.g * Class15.smethod_2(8);
    return ((int) num1 & Class15.smethod_0(270)) << Class15.smethod_0(10) | ((int) num3 & Class15.smethod_0(270)) << Class15.smethod_0(88) | (int) num2 & Class15.smethod_0(270);
  }

  public static int smethod_7(GClass66 img) => img.w;

  public static int smethod_8(GClass66 img) => img.h;

  public void method_43(int i, int j, int k, int l, int m, int n) => this.method_15(i * GClass98.int_8, j * GClass98.int_8, k * GClass98.int_8, l * GClass98.int_8);

  public void method_44()
  {
    if ((!(bool) (UnityEngine.Object) this.material_0 ? 0 : 1) != 0)
      return;
    this.material_0 = new Material(Class13.smethod_0(150333));
    this.material_0.hideFlags = (HideFlags) Class15.smethod_0(293);
    this.material_0.shader.hideFlags = (HideFlags) Class15.smethod_0(293);
  }

  public void method_45(GClass134 totalLine)
  {
    this.material_0.SetPass(Class15.smethod_0(0));
    GL.PushMatrix();
    GL.Begin(Class15.smethod_0(1));
    for (int index1 = Class15.smethod_0(0); index1 < totalLine.method_2(); index1 += Class15.smethod_0(1))
    {
      GClass99 gclass99 = (GClass99) totalLine.method_3(index1);
      GL.Color(new Color(gclass99.r, gclass99.g, gclass99.b, gclass99.a));
      int x1 = gclass99.x1 * GClass98.int_8;
      int y1 = gclass99.y1 * GClass98.int_8;
      int x2 = gclass99.x2 * GClass98.int_8;
      int y2 = gclass99.y2 * GClass98.int_8;
      if ((!this.bool_1 ? 1 : 0) == 0)
      {
        x1 += this.int_6;
        y1 += this.int_7;
        x2 += this.int_6;
        y2 += this.int_7;
      }
      for (int index2 = Class15.smethod_0(0); index2 < GClass98.int_8; index2 += Class15.smethod_0(1))
      {
        GL.Vertex((Vector3) new Vector2((float) (x1 + index2), (float) (y1 + index2)));
        GL.Vertex((Vector3) new Vector2((float) (x2 + index2), (float) (y2 + index2)));
        if (index2 > Class15.smethod_0(0))
        {
          GL.Vertex((Vector3) new Vector2((float) (x1 + index2), (float) y1));
          GL.Vertex((Vector3) new Vector2((float) (x2 + index2), (float) y2));
          GL.Vertex((Vector3) new Vector2((float) x1, (float) (y1 + index2)));
          GL.Vertex((Vector3) new Vector2((float) x2, (float) (y2 + index2)));
        }
      }
    }
    GL.End();
    GL.PopMatrix();
    totalLine.method_9();
  }

  public void method_46(GClass98 g, int x, int y, int xTo, int yTo, int nLine, int color)
  {
    GClass134 totalLine = new GClass134();
    for (int index = Class15.smethod_0(0); index < nLine; index += Class15.smethod_0(1))
      totalLine.method_0((object) new GClass99(x, y, xTo + index, yTo + index, color));
    g.method_45(totalLine);
  }

  internal void method_47(
    GClass192 gclass192_0,
    int int_24,
    int int_25,
    int int_26,
    int int_27,
    int int_28,
    int int_29,
    int int_30,
    int int_31)
  {
    throw new NotImplementedException();
  }
}
