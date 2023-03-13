// Decompiled with JetBrains decompiler
// Type: GClass19
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass19
{
  public static GClass66 smethod_0(GClass66 img, int layer, int idImage)
  {
    int num = GClass185.int_25 - Class15.smethod_0(1);
    GClass66 img1 = img;
    if ((num == 0 ? 0 : 1) == 0 && layer == Class15.smethod_0(1))
      img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(167));
    if (num == Class15.smethod_0(1) && layer == Class15.smethod_0(1))
      img1 = GClass98.smethod_3(img, Class15.smethod_2(11), Class15.smethod_0(168));
    if (num == Class15.smethod_0(7) && layer == Class15.smethod_0(1))
      img1 = GClass98.smethod_3(img, Class15.smethod_2(12), Class15.smethod_0(169));
    if (num == Class15.smethod_0(5))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(13), Class15.smethod_0(170));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(12), Class15.smethod_0(170));
    }
    if (num == Class15.smethod_0(2))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(171));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(12), Class15.smethod_0(171));
    }
    if (num == Class15.smethod_0(37))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(172));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(172));
    }
    if (num == Class15.smethod_0(3))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(11), Class15.smethod_0(173));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(173));
    }
    if (num == Class15.smethod_0(88))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(174));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(174));
    }
    if (num == Class15.smethod_0(45))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(175));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(175));
    }
    if (num == Class15.smethod_0(31) && layer == Class15.smethod_0(1))
      img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(176));
    if (num == Class15.smethod_0(31) && layer == Class15.smethod_0(1))
      img1 = GClass98.smethod_3(img, Class15.smethod_2(13), Class15.smethod_0(176));
    if (num == Class15.smethod_0(67))
    {
      if (layer == Class15.smethod_0(1))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(0));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(0));
    }
    if (num > Class15.smethod_0(67))
    {
      if (layer == Class15.smethod_0(1) || layer == Class15.smethod_0(7))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(10), Class15.smethod_0(0));
      if (layer == Class15.smethod_0(5))
        img1 = GClass98.smethod_3(img, Class15.smethod_2(14), Class15.smethod_0(0));
    }
    byte[] data = GClass19.smethod_1(img1);
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(30805);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(30801);
    strArray[Class15.smethod_0(5)] = idImage.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(30784);
    strArray[Class15.smethod_0(3)] = layer.ToString();
    GClass152.smethod_0(string.Concat(strArray), GClass1.smethod_0(data));
    return img1;
  }

  public static byte[] smethod_1(GClass66 img)
  {
    try
    {
      return img.texture.EncodeToPNG();
    }
    catch (Exception ex)
    {
      return (byte[]) null;
    }
  }

  public static void smethod_2(short id, GClass66 img)
  {
    for (int index = Class15.smethod_0(0); index < GClass185.gclass134_2.method_2(); index += Class15.smethod_0(1))
    {
      GClass18 gclass18 = (GClass18) GClass185.gclass134_2.method_3(index);
      if ((int) gclass18.idImage == (int) id && (!gclass18.method_0() ? 0 : 1) == 0 && (int) gclass18.layer != Class15.smethod_0(7) && (int) gclass18.layer != Class15.smethod_0(2) && (!GClass18.gclass128_0.method_7((object) (gclass18.idImage.ToString() + Class13.smethod_0(31673) + gclass18.layer.ToString())) ? 0 : 1) == 0)
      {
        string[] strArray = new string[Class15.smethod_0(37)];
        strArray[Class15.smethod_0(0)] = Class13.smethod_0(31649);
        strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
        strArray[Class15.smethod_0(7)] = Class13.smethod_0(31673);
        strArray[Class15.smethod_0(5)] = id.ToString();
        strArray[Class15.smethod_0(2)] = Class13.smethod_0(31254);
        strArray[Class15.smethod_0(3)] = gclass18.layer.ToString();
        sbyte[] imageData = GClass152.smethod_1(string.Concat(strArray));
        if ((imageData == null ? 0 : 1) == 0)
        {
          GClass18.gclass128_0.method_4((object) (gclass18.idImage.ToString() + Class13.smethod_0(31673) + gclass18.layer.ToString()), (object) GClass19.smethod_0(img, (int) gclass18.layer, (int) gclass18.idImage));
        }
        else
        {
          GClass66 v = GClass66.smethod_6(imageData, Class15.smethod_0(0), imageData.Length);
          GClass18.gclass128_0.method_4((object) (gclass18.idImage.ToString() + Class13.smethod_0(31673) + gclass18.layer.ToString()), (object) v);
        }
      }
    }
  }
}
