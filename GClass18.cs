// Decompiled with JetBrains decompiler
// Type: GClass18
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass18
{
  public int id;
  public int trans;
  public short idImage;
  public int x;
  public int y;
  public int dx;
  public int dy;
  public sbyte layer;
  public int nTilenotMove;
  public int[] tileX;
  public int[] tileY;
  public static GClass128 gclass128_0 = new GClass128();
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass134 gclass134_1 = new GClass134();
  private bool bool_0;
  public int transX;
  public int transY;
  public static int[] int_0;
  public static int[] int_1;
  public static sbyte[] sbyte_0;

  public static void smethod_0()
  {
  }

  public static bool smethod_1(string keyNew)
  {
    for (int index = Class15.smethod_0(0); index < GClass18.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass18.gclass134_0.method_3(index)).Equals(keyNew) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static bool smethod_2(string keyLast)
  {
    for (int index = Class15.smethod_0(0); index < GClass18.gclass134_1.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((string) GClass18.gclass134_1.method_3(index)).Equals(keyLast) ? 1 : 0) == 0)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_0()
  {
    if (GClass98.int_8 == Class15.smethod_0(1))
      return Class15.smethod_0(1) != 0;
    if ((!GClass185.smethod_14() ? 1 : 0) == 0)
      return Class15.smethod_0(1) != 0;
    for (int index = Class15.smethod_0(0); index < GClass18.int_0.Length; index += Class15.smethod_0(1))
    {
      if ((int) this.idImage == GClass18.int_0[index])
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public bool method_1()
  {
    for (int index = Class15.smethod_0(0); index < GClass18.int_1.Length; index += Class15.smethod_0(1))
    {
      if ((int) this.idImage == GClass18.int_1[index])
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public void method_2()
  {
    if ((!this.method_0() ? 0 : 1) != 0 || (int) this.layer == Class15.smethod_0(7) || (int) this.layer == Class15.smethod_0(2) || (!GClass18.gclass128_0.method_7((object) (this.idImage.ToString() + Class13.smethod_0(30692) + this.layer.ToString())) ? 1 : 0) == 0)
      return;
    GClass66 img = (GClass66) GClass18.gclass128_0.method_0((object) (this.idImage.ToString() + string.Empty));
    if ((img == null ? 1 : 0) != 0 || img.method_3() <= Class15.smethod_0(2))
      return;
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(30310);
    strArray[Class15.smethod_0(1)] = GClass98.int_8.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(30692);
    strArray[Class15.smethod_0(5)] = this.idImage.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(30308);
    strArray[Class15.smethod_0(3)] = this.layer.ToString();
    sbyte[] imageData = GClass152.smethod_1(string.Concat(strArray));
    if ((imageData == null ? 0 : 1) == 0)
    {
      GClass18.gclass128_0.method_4((object) (this.idImage.ToString() + Class13.smethod_0(30692) + this.layer.ToString()), (object) GClass19.smethod_0(img, (int) this.layer, (int) this.idImage));
    }
    else
    {
      GClass66 v = GClass66.smethod_6(imageData, Class15.smethod_0(0), imageData.Length);
      GClass18.gclass128_0.method_4((object) (this.idImage.ToString() + Class13.smethod_0(30692) + this.layer.ToString()), (object) v);
    }
  }

  public void method_3(GClass98 g)
  {
    if ((!GClass20.bool_4 ? 0 : 1) != 0 || (int) this.idImage == Class15.smethod_0(149) && GClass116.smethod_6().tMabuEff >= Class15.smethod_0(80))
      return;
    int int22 = GClass116.int_22;
    int int23 = GClass116.int_23;
    GClass66 image = (int) this.layer == Class15.smethod_0(7) || (int) this.layer == Class15.smethod_0(2) ? (GClass66) GClass18.gclass128_0.method_0((object) (this.idImage.ToString() + string.Empty)) : ((!this.method_0() ? 0 : 1) != 0 ? (GClass66) GClass18.gclass128_0.method_0((object) (this.idImage.ToString() + string.Empty)) : (GClass66) GClass18.gclass128_0.method_0((object) (this.idImage.ToString() + Class13.smethod_0(30365) + this.layer.ToString())));
    if ((image == null ? 1 : 0) != 0 || (int) this.idImage == Class15.smethod_0(150))
      return;
    if ((int) this.layer == Class15.smethod_0(2))
      this.transX = -int22 / Class15.smethod_0(7) + Class15.smethod_0(21);
    if ((int) this.idImage == Class15.smethod_0(35) && (int) this.layer == Class15.smethod_0(5))
      this.transX = -int22 / Class15.smethod_0(5) + Class15.smethod_0(90);
    if (((int) this.idImage == Class15.smethod_0(131) || (int) this.idImage == Class15.smethod_0(11) || (int) this.idImage == Class15.smethod_0(151) || (int) this.idImage == Class15.smethod_0(152)) && (int) this.layer == Class15.smethod_0(5))
      this.transX = -int22 / Class15.smethod_0(5) + Class15.smethod_0(90);
    if ((!this.method_1() ? 1 : 0) == 0 && (int) this.layer < Class15.smethod_0(2))
    {
      this.transX = -(int22 >> Class15.smethod_0(2)) + Class15.smethod_0(32);
      this.transY = (int23 >> Class15.smethod_0(3)) - Class15.smethod_0(9);
    }
    int x = this.x + this.dx + this.transX;
    int num = this.y + this.dy + this.transY;
    if (this.x + this.dx + image.method_0() + this.transX >= int22 && this.x + this.dx + this.transX <= int22 + GClass62.int_10 && this.y + this.dy + this.transY + image.method_1() >= int23 && this.y + this.dy + this.transY <= int23 + GClass62.int_11)
    {
      g.method_24(image, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(image), GClass98.smethod_1(image), this.trans, this.x + this.dx + this.transX, this.y + this.dy + this.transY, Class15.smethod_0(0));
      if ((int) this.idImage == Class15.smethod_0(67) && GClass185.int_37 != Class15.smethod_0(153))
      {
        g.method_5(x, num + Class15.smethod_0(40), Class15.smethod_0(154), Class15.smethod_0(49));
        for (int index = Class15.smethod_0(0); index < Class15.smethod_0(7); index += Class15.smethod_0(1))
          g.method_24(GClass185.gclass66_5, Class15.smethod_0(0), (GClass62.int_8 % Class15.smethod_0(88) >> Class15.smethod_0(7)) * Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(40), Class15.smethod_0(0), x + index * Class15.smethod_0(40), num + Class15.smethod_0(40), Class15.smethod_0(0));
        g.method_5(GClass116.int_22, GClass116.int_23, GClass116.int_6, GClass116.int_7);
      }
    }
    if ((!GClass185.smethod_15() ? 1 : 0) != 0 || (int) this.idImage <= Class15.smethod_0(155) || (int) this.idImage == Class15.smethod_0(156) || (int) this.idImage == Class15.smethod_0(157) || (int) this.idImage == Class15.smethod_0(158) || (int) this.idImage == Class15.smethod_0(159) || (int) this.idImage == Class15.smethod_0(128) || (int) this.idImage == Class15.smethod_0(160) || (int) this.idImage == Class15.smethod_0(161) || (int) this.idImage == Class15.smethod_0(162) || (int) this.idImage == Class15.smethod_0(163) || GClass185.int_23 - (this.x + this.dx + this.transX) < int22 || GClass185.int_23 - (this.x + this.dx + this.transX + image.method_0()) > int22 + GClass62.int_10 || this.y + this.dy + this.transY + image.method_1() < int23 || this.y + this.dy + this.transY > int23 + GClass62.int_11 || (int) this.idImage >= Class15.smethod_0(164) && (int) this.idImage < Class15.smethod_0(165))
      return;
    g.method_24(image, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(image), GClass98.smethod_1(image), Class15.smethod_0(7), GClass185.int_23 - (this.x + this.dx + this.transX), this.y + this.dy + this.transY, GClass177.int_2);
  }

  static GClass18()
  {
    byte[] byte_0_1 = new byte[Class15.smethod_0(166)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_1, __fieldref (Class12.NOlnUUeduwuY));
    GClass18.int_0 = (int[]) Class15.smethod_4(byte_0_1);
    byte[] byte_0_2 = new byte[Class15.smethod_0(64)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0_2, __fieldref (Class12.GoMyCxZySQij));
    GClass18.int_1 = (int[]) Class15.smethod_4(byte_0_2);
  }
}
