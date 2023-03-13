// Decompiled with JetBrains decompiler
// Type: GClass66
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Threading;
using UnityEngine;

public class GClass66
{
  private const int int_0 = 5;
  private const int int_1 = 500;
  public Texture2D texture = new Texture2D(Class15.smethod_0(1), Class15.smethod_0(1));
  public static GClass66 gclass66_0;
  public static string string_0;
  public static byte[] byte_0;
  public static GClass66 gclass66_1;
  public static int int_2;
  public static int int_3;
  public static int int_4;
  public static int int_5;
  public static int int_6;
  public int w;
  public int h;
  public static int int_7;
  public Color colorBlend = Color.black;

  public static GClass66 smethod_0() => GClass66.smethod_21();

  public static GClass66 smethod_1(string filename) => GClass66.smethod_18(filename);

  public static GClass66 smethod_2(byte[] imageData) => GClass66.smethod_19(imageData);

  public static GClass66 smethod_3(GClass66 src, int x, int y, int w, int h, int transform) => GClass66.smethod_20(src, x, y, w, h, transform);

  public static GClass66 smethod_4(int w, int h) => GClass66.smethod_22(w, h);

  public static GClass66 smethod_5(GClass66 img)
  {
    GClass66 gclass66 = GClass66.smethod_4(img.w, img.h);
    gclass66.texture = img.texture;
    gclass66.texture.Apply();
    return gclass66;
  }

  public static GClass66 smethod_6(sbyte[] imageData, int offset, int lenght)
  {
    if (offset + lenght > imageData.Length)
      return (GClass66) null;
    byte[] imageData1 = new byte[lenght];
    for (int index = Class15.smethod_0(0); index < lenght; index += Class15.smethod_0(1))
      imageData1[index] = GClass66.smethod_7(imageData[index + offset]);
    return GClass66.smethod_2(imageData1);
  }

  public static byte smethod_7(sbyte var) => (int) var > Class15.smethod_0(0) ? (byte) var : (byte) ((uint) var + (uint) Class15.smethod_0(290));

  public static byte[] smethod_8(sbyte[] var)
  {
    byte[] numArray = new byte[var.Length];
    for (int index = Class15.smethod_0(0); index < var.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) var[index] <= Class15.smethod_0(0) ? (byte) ((uint) var[index] + (uint) Class15.smethod_0(290)) : (byte) var[index];
    return numArray;
  }

  public static GClass66 smethod_9(int[] rbg, int w, int h, bool bl)
  {
    GClass66 gclass66 = GClass66.smethod_4(w, h);
    Color[] colors = new Color[rbg.Length];
    for (int index = Class15.smethod_0(0); index < colors.Length; index += Class15.smethod_0(1))
      colors[index] = GClass66.smethod_10(rbg[index]);
    gclass66.texture.SetPixels(Class15.smethod_0(0), Class15.smethod_0(0), w, h, colors);
    gclass66.texture.Apply();
    return gclass66;
  }

  public static Color smethod_10(int rgb)
  {
    int num1 = rgb & Class15.smethod_0(270);
    int num2 = rgb >> Class15.smethod_0(88) & Class15.smethod_0(270);
    int num3 = rgb >> Class15.smethod_0(10) & Class15.smethod_0(270);
    float b = (float) num1 / Class15.smethod_2(21);
    float g = (float) num2 / Class15.smethod_2(21);
    return new Color((float) num3 / Class15.smethod_2(21), g, b);
  }

  public static void smethod_11()
  {
    if (GClass66.int_7 == Class15.smethod_0(7))
    {
      GClass66.int_7 = Class15.smethod_0(1);
      GClass66.gclass66_0 = GClass66.smethod_21();
      GClass66.int_7 = Class15.smethod_0(0);
    }
    else if (GClass66.int_7 == Class15.smethod_0(5))
    {
      GClass66.int_7 = Class15.smethod_0(1);
      GClass66.gclass66_0 = GClass66.smethod_18(GClass66.string_0);
      GClass66.int_7 = Class15.smethod_0(0);
    }
    else if (GClass66.int_7 == Class15.smethod_0(2))
    {
      GClass66.int_7 = Class15.smethod_0(1);
      GClass66.gclass66_0 = GClass66.smethod_19(GClass66.byte_0);
      GClass66.int_7 = Class15.smethod_0(0);
    }
    else if (GClass66.int_7 == Class15.smethod_0(3))
    {
      GClass66.int_7 = Class15.smethod_0(1);
      GClass66.gclass66_0 = GClass66.smethod_20(GClass66.gclass66_1, GClass66.int_2, GClass66.int_3, GClass66.int_4, GClass66.int_5, GClass66.int_6);
      GClass66.int_7 = Class15.smethod_0(0);
    }
    else
    {
      if (GClass66.int_7 != Class15.smethod_0(37))
        return;
      GClass66.int_7 = Class15.smethod_0(1);
      GClass66.gclass66_0 = GClass66.smethod_22(GClass66.int_4, GClass66.int_5);
      GClass66.int_7 = Class15.smethod_0(0);
    }
  }

  private static GClass66 smethod_12()
  {
    if ((GClass66.int_7 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(20848));
      return (GClass66) null;
    }
    GClass66.gclass66_0 = (GClass66) null;
    GClass66.int_7 = Class15.smethod_0(7);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass66.int_7 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      GClass33.smethod_2(Class13.smethod_0(20898));
      GClass66.int_7 = Class15.smethod_0(0);
    }
    return GClass66.gclass66_0;
  }

  private static GClass66 smethod_13(string string_1)
  {
    if ((GClass66.int_7 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(20546) + string_1 + Class13.smethod_0(20714));
      return (GClass66) null;
    }
    GClass66.gclass66_0 = (GClass66) null;
    GClass66.string_0 = string_1;
    GClass66.int_7 = Class15.smethod_0(5);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass66.int_7 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      GClass33.smethod_2(Class13.smethod_0(20685) + string_1);
      GClass66.int_7 = Class15.smethod_0(0);
    }
    return GClass66.gclass66_0;
  }

  private static GClass66 smethod_14(byte[] byte_1)
  {
    if ((GClass66.int_7 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(21257));
      return (GClass66) null;
    }
    GClass66.gclass66_0 = (GClass66) null;
    GClass66.byte_0 = byte_1;
    GClass66.int_7 = Class15.smethod_0(2);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass66.int_7 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      GClass33.smethod_2(Class13.smethod_0(21317));
      GClass66.int_7 = Class15.smethod_0(0);
    }
    return GClass66.gclass66_0;
  }

  private static GClass66 smethod_15(
    GClass66 gclass66_2,
    int int_8,
    int int_9,
    int int_10,
    int int_11,
    int int_12)
  {
    if ((GClass66.int_7 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(21408));
      return (GClass66) null;
    }
    GClass66.gclass66_0 = (GClass66) null;
    GClass66.gclass66_1 = gclass66_2;
    GClass66.int_2 = int_8;
    GClass66.int_3 = int_9;
    GClass66.int_4 = int_10;
    GClass66.int_5 = int_11;
    GClass66.int_6 = int_12;
    GClass66.int_7 = Class15.smethod_0(3);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass66.int_7 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      GClass33.smethod_2(Class13.smethod_0(21459));
      GClass66.int_7 = Class15.smethod_0(0);
    }
    return GClass66.gclass66_0;
  }

  private static GClass66 smethod_16(int int_8, int int_9)
  {
    if ((GClass66.int_7 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(21011));
      return (GClass66) null;
    }
    GClass66.gclass66_0 = (GClass66) null;
    GClass66.int_4 = int_8;
    GClass66.int_5 = int_9;
    GClass66.int_7 = Class15.smethod_0(37);
    int num;
    for (num = Class15.smethod_0(0); num < Class15.smethod_0(16); num += Class15.smethod_0(1))
    {
      Thread.Sleep(Class15.smethod_0(3));
      if ((GClass66.int_7 == 0 ? 1 : 0) != 0)
        break;
    }
    if (num == Class15.smethod_0(16))
    {
      GClass33.smethod_2(Class13.smethod_0(21070));
      GClass66.int_7 = Class15.smethod_0(0);
    }
    return GClass66.gclass66_0;
  }

  public static byte[] smethod_17(string filename)
  {
    GClass66 gclass66 = new GClass66();
    TextAsset textAsset = (TextAsset) Resources.Load(filename, typeof (TextAsset));
    if ((!((UnityEngine.Object) textAsset == (UnityEngine.Object) null) ? 0 : 1) != 0 || (textAsset.bytes == null ? 1 : 0) != 0 || (textAsset.bytes.Length == 0 ? 0 : 1) == 0)
      throw new Exception(Class13.smethod_0(21189) + filename);
    sbyte[] numArray = GClass1.smethod_0(textAsset.bytes);
    Debug.LogError((object) (Class13.smethod_0(21878) + numArray.Length.ToString()));
    return textAsset.bytes;
  }

  private static GClass66 smethod_18(string string_1)
  {
    GClass66 gclass66_2 = new GClass66();
    Texture2D texture2D = Resources.Load(string_1) as Texture2D;
    gclass66_2.texture = (!((UnityEngine.Object) texture2D == (UnityEngine.Object) null) ? 1 : 0) != 0 ? texture2D : throw new Exception(Class13.smethod_0(21840) + string_1);
    gclass66_2.w = gclass66_2.texture.width;
    gclass66_2.h = gclass66_2.texture.height;
    GClass66.smethod_25(gclass66_2);
    return gclass66_2;
  }

  public static GClass66 smethod_19(byte[] imageData)
  {
    if ((imageData == null ? 1 : 0) == 0 && (imageData.Length == 0 ? 0 : 1) != 0)
    {
      GClass66 gclass66_2 = new GClass66();
      try
      {
        gclass66_2.texture.LoadImage(imageData);
        gclass66_2.w = gclass66_2.texture.width;
        gclass66_2.h = gclass66_2.texture.height;
        GClass66.smethod_25(gclass66_2);
        return gclass66_2;
      }
      catch (Exception ex)
      {
        GClass33.smethod_2(Class13.smethod_0(22011) + Environment.StackTrace);
        return gclass66_2;
      }
    }
    else
    {
      GClass33.smethod_2(Class13.smethod_0(21919));
      return (GClass66) null;
    }
  }

  private static GClass66 smethod_20(
    GClass66 gclass66_2,
    int int_8,
    int int_9,
    int int_10,
    int int_11,
    int int_12)
  {
    GClass66 gclass66_2_1 = new GClass66();
    gclass66_2_1.texture = new Texture2D(int_10, int_11);
    int_9 = gclass66_2.texture.height - int_9 - int_11;
    for (int x = Class15.smethod_0(0); x < int_10; x += Class15.smethod_0(1))
    {
      for (int y = Class15.smethod_0(0); y < int_11; y += Class15.smethod_0(1))
      {
        int num1 = x;
        if (int_12 == Class15.smethod_0(7))
          num1 = int_10 - x;
        int num2 = y;
        gclass66_2_1.texture.SetPixel(x, y, gclass66_2.texture.GetPixel(int_8 + num1, int_9 + num2));
      }
    }
    gclass66_2_1.texture.Apply();
    gclass66_2_1.w = gclass66_2_1.texture.width;
    gclass66_2_1.h = gclass66_2_1.texture.height;
    GClass66.smethod_25(gclass66_2_1);
    return gclass66_2_1;
  }

  private static GClass66 smethod_21() => new GClass66();

  public static GClass66 smethod_22(int w, int h)
  {
    GClass66 gclass66_2 = new GClass66();
    gclass66_2.texture = new Texture2D(w, h, (TextureFormat) Class15.smethod_0(2), Class15.smethod_0(0) != 0);
    GClass66.smethod_25(gclass66_2);
    gclass66_2.w = w;
    gclass66_2.h = h;
    gclass66_2.texture.Apply();
    return gclass66_2;
  }

  public static int smethod_23(GClass66 image) => image.method_0();

  public static int smethod_24(GClass66 image) => image.method_1();

  public int method_0() => this.w / GClass98.int_8;

  public int method_1() => this.h / GClass98.int_8;

  private static void smethod_25(GClass66 gclass66_2) => GClass66.smethod_26(gclass66_2.texture);

  public static void smethod_26(Texture2D texture)
  {
    texture.anisoLevel = Class15.smethod_0(0);
    texture.filterMode = (FilterMode) Class15.smethod_0(0);
    texture.mipMapBias = Class15.smethod_2(0);
    texture.wrapMode = (TextureWrapMode) Class15.smethod_0(1);
  }

  public Color[] method_2() => this.texture.GetPixels();

  public int method_3() => this.w;

  public int method_4() => this.h;

  public void method_5(ref int[] data, int x1, int x2, int x, int y, int w, int h)
  {
    Color[] pixels = this.texture.GetPixels(x, this.h - Class15.smethod_0(1) - y, w, h);
    for (int index = Class15.smethod_0(0); index < pixels.Length; index += Class15.smethod_0(1))
      data[index] = GClass98.smethod_6(pixels[index]);
  }
}
