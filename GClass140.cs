// Decompiled with JetBrains decompiler
// Type: GClass140
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass140
{
  public static int int_0 = Class15.smethod_0(482);
  public static int int_1 = Class15.smethod_0(104);
  public static int int_2 = Class15.smethod_0(483);
  public static int int_3 = Class15.smethod_0(484);
  public static int int_4 = Class15.smethod_0(142);
  public static GClass66 gclass66_0;
  public static GClass66 gclass66_1;
  public static GClass66 gclass66_2;
  public static GClass66 gclass66_3;
  public static GClass66 gclass66_4;
  public static GClass66 gclass66_5;
  public static GClass66 gclass66_6;
  public static GClass66 gclass66_7;
  public static GClass66 gclass66_8;
  public static GClass66 gclass66_9;
  public static GClass66 gclass66_10;
  public static GClass66[] gclass66_11 = new GClass66[Class15.smethod_0(7)];
  public static GClass66[] gclass66_12 = new GClass66[Class15.smethod_0(7)];
  public static GClass66[] gclass66_13 = new GClass66[Class15.smethod_0(37)];
  public static int int_5 = Class15.smethod_0(40);
  public static int int_6 = Class15.smethod_0(0);
  public int[] color;
  public static GClass66 gclass66_14 = GClass62.smethod_40(Class13.smethod_0(155567));

  public static void smethod_0()
  {
    for (int index = Class15.smethod_0(0); index < GClass140.gclass66_13.Length; index += Class15.smethod_0(1))
      GClass140.gclass66_13[index] = GClass62.smethod_40(Class13.smethod_0(154774) + (index + Class15.smethod_0(1)).ToString() + Class13.smethod_0(154844));
  }

  public void method_0(GClass98 g)
  {
    g.method_16(Class15.smethod_0(464));
    g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    g.method_32(GClass140.gclass66_0, GClass62.int_10 / Class15.smethod_0(7), GClass62.int_11 / Class15.smethod_0(7) - GClass140.int_5 / Class15.smethod_0(7) - Class15.smethod_0(1), Class15.smethod_0(5));
    g.method_32(GClass140.gclass66_3, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0));
    g.method_32(GClass140.gclass66_5, GClass62.int_10, Class15.smethod_0(0), GClass98.int_4 | GClass98.int_3);
    g.method_32(GClass140.gclass66_2, Class15.smethod_0(0), GClass62.int_11 - GClass140.int_5 - Class15.smethod_0(7), GClass98.int_5 | GClass98.int_2);
    g.method_32(GClass140.gclass66_4, GClass62.int_10, GClass62.int_11 - GClass140.int_5 - Class15.smethod_0(7), GClass98.int_5 | GClass98.int_3);
    g.method_16(Class15.smethod_0(465));
    g.method_14(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, Class15.smethod_0(0));
    g.method_14(Class15.smethod_0(0), GClass62.int_11 - GClass140.int_5 - Class15.smethod_0(7), GClass62.int_10, Class15.smethod_0(0));
    g.method_14(Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_11 - GClass140.int_5);
    g.method_14(GClass62.int_10 - Class15.smethod_0(1), Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_11 - GClass140.int_5);
  }

  public void method_1(GClass98 g)
  {
    g.method_16(Class15.smethod_0(466));
    g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
  }

  public void method_2()
  {
  }

  public void method_3(GClass98 g)
  {
  }

  public void method_4(GClass98 g, int x, int y, int w, int h)
  {
    g.method_16(Class15.smethod_0(467));
    g.method_15(x, y, w, h);
    g.method_16(Class15.smethod_0(468));
    g.method_14(x, y, w, h);
  }

  public void method_5(GClass98 g, int y, int x, int width, int height)
  {
    g.method_16(Class15.smethod_0(469));
    g.method_15(x, y, width, height);
    g.method_16(Class15.smethod_0(0));
    g.method_14(x - Class15.smethod_0(1), y - Class15.smethod_0(1), width + Class15.smethod_0(1), height + Class15.smethod_0(1));
  }

  public void method_6(GClass98 g, int h)
  {
    g.method_16(Class15.smethod_0(470));
    g.method_15(Class15.smethod_0(88), GClass62.int_11 - (h + Class15.smethod_0(52)), GClass62.int_10 - Class15.smethod_0(10), h + Class15.smethod_0(2));
    g.method_16(Class15.smethod_0(471));
    g.method_15(Class15.smethod_0(31), GClass62.int_11 - (h + Class15.smethod_0(95)), GClass62.int_10 - Class15.smethod_0(51), h);
  }

  public void method_7(GClass98 g, GClass31 left, GClass31 center, GClass31 right)
  {
    GClass97 gclass97 = (!GClass62.bool_5 ? 1 : 0) != 0 ? GClass97.gclass97_6 : GClass97.gclass97_6;
    int num = Class15.smethod_0(5);
    if ((left == null ? 1 : 0) == 0)
    {
      GClass140.int_6 = gclass97.method_17(left.caption);
      if (GClass140.int_6 > Class15.smethod_0(0))
      {
        if (left.x >= Class15.smethod_0(0) && left.y > Class15.smethod_0(0))
        {
          left.method_3(g);
        }
        else
        {
          g.method_32((GClass113.int_4 == 0 ? 0 : 1) != 0 ? GClass116.gclass66_22 : GClass116.gclass66_23, Class15.smethod_0(1), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(1), Class15.smethod_0(0));
          gclass97.method_6(g, left.caption, Class15.smethod_0(95), GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(5) + num, Class15.smethod_0(7));
        }
      }
    }
    if ((center == null ? 1 : 0) == 0)
    {
      GClass140.int_6 = gclass97.method_17(center.caption);
      if (GClass140.int_6 > Class15.smethod_0(0))
      {
        if (center.x > Class15.smethod_0(0) && center.y > Class15.smethod_0(0))
        {
          center.method_3(g);
        }
        else
        {
          g.method_32(GClass113.int_4 != Class15.smethod_0(1) ? GClass116.gclass66_22 : GClass116.gclass66_23, GClass62.int_12 - Class15.smethod_0(95), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(1), Class15.smethod_0(0));
          gclass97.method_6(g, center.caption, GClass62.int_12, GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(5) + num, Class15.smethod_0(7));
        }
      }
    }
    if ((right == null ? 0 : 1) == 0)
      return;
    GClass140.int_6 = gclass97.method_17(right.caption);
    if (GClass140.int_6 <= Class15.smethod_0(0))
      return;
    if (right.x > Class15.smethod_0(0) && right.y > Class15.smethod_0(0))
    {
      right.method_3(g);
    }
    else
    {
      g.method_32(GClass113.int_4 != Class15.smethod_0(7) ? GClass116.gclass66_22 : GClass116.gclass66_23, GClass62.int_10 - Class15.smethod_0(135), GClass62.int_11 - GClass113.int_3 - Class15.smethod_0(1), Class15.smethod_0(0));
      gclass97.method_6(g, right.caption, GClass62.int_10 - Class15.smethod_0(95), GClass62.int_11 - GClass113.int_3 + Class15.smethod_0(5) + num, Class15.smethod_0(7));
    }
  }

  public void method_8(GClass98 g)
  {
  }

  public void method_9(GClass98 g, int x, int y, int w, int h)
  {
    g.method_16(Class15.smethod_0(465));
    g.method_15(x, y, w, h);
  }

  public void method_10(GClass98 g, int x, int y) => g.method_32(GClass140.gclass66_1, x, y, Class15.smethod_0(5));

  public void method_11(GClass98 g, string number)
  {
  }

  public void method_12(GClass98 g, int x, int y, int w, int h, bool iss)
  {
    if ((!iss ? 1 : 0) == 0)
    {
      g.method_16(Class15.smethod_0(472));
      g.method_37(x, y, w, h, Class15.smethod_0(31), Class15.smethod_0(31));
      g.method_16(Class15.smethod_0(473));
    }
    else
    {
      g.method_16(Class15.smethod_0(474));
      g.method_37(x, y, w, h, Class15.smethod_0(31), Class15.smethod_0(31));
      g.method_16(Class15.smethod_0(474));
    }
    g.method_37(x + Class15.smethod_0(5), y + Class15.smethod_0(5), w - Class15.smethod_0(37), h - Class15.smethod_0(37), Class15.smethod_0(31), Class15.smethod_0(31));
  }

  public void method_13(
    GClass98 g,
    int x,
    int y,
    int w,
    int h,
    string title,
    string subTitle,
    string check)
  {
  }

  public void method_14(GClass98 g, string title, string subTitle, string check)
  {
  }

  public void method_15(GClass98 g, int x, int y, int index)
  {
    g.method_32(GClass140.gclass66_11[Class15.smethod_0(1)], x, y, Class15.smethod_0(5));
    if (index != Class15.smethod_0(1))
      return;
    g.method_32(GClass140.gclass66_11[Class15.smethod_0(0)], x + Class15.smethod_0(1), y - Class15.smethod_0(5), Class15.smethod_0(5));
  }

  public void method_16(GClass98 g, int x, int y, int index) => g.method_32(GClass140.gclass66_12[index], x, y, Class15.smethod_0(0));

  public void method_17(GClass98 g, int roomId) => this.method_0(g);

  public void method_18(GClass98 g, int x, int y, bool check, bool focus)
  {
    if ((!focus ? 1 : 0) == 0)
      g.method_24(GClass140.gclass66_14, Class15.smethod_0(0), ((!check ? 1 : 0) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(5)) * Class15.smethod_0(124), Class15.smethod_0(51), Class15.smethod_0(124), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
    else
      g.method_24(GClass140.gclass66_14, Class15.smethod_0(0), ((!check ? 0 : 1) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0)) * Class15.smethod_0(124), Class15.smethod_0(51), Class15.smethod_0(124), Class15.smethod_0(0), x, y, Class15.smethod_0(0));
  }

  public void method_19(GClass98 g, int x, int y, int w, int h, string[] str)
  {
    this.method_34(x, y, w, h, g);
    int num = y + Class15.smethod_0(51) - GClass97.gclass97_21.method_20();
    int index = Class15.smethod_0(0);
    int y1 = num;
    while (index < str.Length)
    {
      GClass97.gclass97_21.method_6(g, str[index], x + w / Class15.smethod_0(7), y1, Class15.smethod_0(7));
      index += Class15.smethod_0(1);
      y1 += GClass97.gclass97_21.method_20();
    }
  }

  public void method_20(GClass98 g, int x, int y, bool iss, bool isSe, int i, int wStr)
  {
  }

  public void method_21(GClass98 g, int x, int y, int xTo, int yTo)
  {
    g.method_16(Class15.smethod_0(465));
    g.method_11(x, y, xTo, yTo);
  }

  public void method_22(GClass98 g, int x, int y, int w, int h, bool iss)
  {
    if ((!iss ? 1 : 0) == 0)
    {
      g.method_16(Class15.smethod_0(475));
      g.method_15(x + Class15.smethod_0(7), y + Class15.smethod_0(7), w - Class15.smethod_0(5), w - Class15.smethod_0(5));
    }
    g.method_16(Class15.smethod_0(476));
    g.method_14(x, y, w, w);
  }

  public void method_23(GClass98 g, int x, int y, int h)
  {
    g.method_16(Class15.smethod_0(477));
    g.method_15(x, y, Class15.smethod_0(2), h);
  }

  public int[] method_24() => this.color;

  public void method_25(GClass98 g)
  {
    g.method_16(Class15.smethod_0(464));
    g.method_15(Class15.smethod_0(0), Class15.smethod_0(0), GClass62.int_10, GClass62.int_11);
    g.method_32(GClass140.gclass66_1, GClass62.int_11 >> Class15.smethod_0(1), GClass62.int_10 >> Class15.smethod_0(1), Class15.smethod_0(5));
  }

  public void method_26(GClass98 g, bool isRes)
  {
    int num = Class15.smethod_0(0);
    if ((!isRes ? 0 : 1) == 0 && GClass62.int_11 <= Class15.smethod_0(194))
      num = Class15.smethod_0(9);
    GClass97.gclass97_7.method_6(g, GClass109.string_59[Class15.smethod_0(0)], GClass62.int_12, GClass62.int_13 + Class15.smethod_0(4) - num, Class15.smethod_0(7));
    GClass97.gclass97_7.method_6(g, GClass109.string_59[Class15.smethod_0(1)], GClass62.int_12, GClass62.int_13 + Class15.smethod_0(184) - num, Class15.smethod_0(7));
  }

  public void method_27(GClass98 g, int x, int y, int w, int h) => g.method_32(GClass140.gclass66_7, x - Class15.smethod_0(38), y, Class15.smethod_0(0));

  public int method_28() => Class15.smethod_0(0);

  public string method_29() => Class13.smethod_0(155409);

  public void method_30(GClass98 g, int x, int y, int w, int h)
  {
    g.method_16(Class15.smethod_0(142));
    g.method_14(x, y, Class15.smethod_0(54), Class15.smethod_0(54));
    g.method_14(x + Class15.smethod_0(1), y + Class15.smethod_0(1), Class15.smethod_0(34), Class15.smethod_0(34));
  }

  public string method_31() => Class13.smethod_0(155510) + GClass63.string_2 + Class13.smethod_0(155580) + GClass63.sbyte_0.ToString();

  public void method_32(int focus)
  {
  }

  public void method_33(int x, int y, int w, int h, GClass98 g)
  {
    g.method_16(Class15.smethod_0(478));
    g.method_14(x + Class15.smethod_0(124), y, (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(120), h);
    g.method_14(x + Class15.smethod_0(124) + (w - Class15.smethod_0(86)) / Class15.smethod_0(7) + Class15.smethod_0(120), y, (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(28), h);
    g.method_14(x, y + Class15.smethod_0(88), w, h - Class15.smethod_0(186));
    g.method_16(GClass140.int_0);
    g.method_15(x + Class15.smethod_0(124), y + Class15.smethod_0(5), (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(120), h - Class15.smethod_0(2));
    g.method_15(x + Class15.smethod_0(124) + (w - Class15.smethod_0(86)) / Class15.smethod_0(7) + Class15.smethod_0(8), y + Class15.smethod_0(5), (w - Class15.smethod_0(34)) / Class15.smethod_0(7) - Class15.smethod_0(28), h - Class15.smethod_0(2));
    g.method_15(x + Class15.smethod_0(1), y + Class15.smethod_0(37), w - Class15.smethod_0(1), h - Class15.smethod_0(67));
    g.method_16(Class15.smethod_0(479));
    g.method_15(x + Class15.smethod_0(124), y + Class15.smethod_0(1), (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(120), Class15.smethod_0(7));
    g.method_15(x + Class15.smethod_0(124) + (w - Class15.smethod_0(86)) / Class15.smethod_0(7) + Class15.smethod_0(120), y + Class15.smethod_0(1), (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(66), Class15.smethod_0(7));
    g.method_15(x + Class15.smethod_0(124), y + h - Class15.smethod_0(7), (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(8), Class15.smethod_0(7));
    g.method_15(x + Class15.smethod_0(124) + (w - Class15.smethod_0(86)) / Class15.smethod_0(7) + Class15.smethod_0(120), y + h - Class15.smethod_0(7), (w - Class15.smethod_0(86)) / Class15.smethod_0(7) - Class15.smethod_0(8), Class15.smethod_0(7));
    g.method_15(x + Class15.smethod_0(1), y + Class15.smethod_0(67), Class15.smethod_0(7), h - Class15.smethod_0(124));
    g.method_15(x + w - Class15.smethod_0(7), y + Class15.smethod_0(67), Class15.smethod_0(7), h - Class15.smethod_0(124));
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(0)], x - Class15.smethod_0(5), y - Class15.smethod_0(7), GClass98.int_4 | GClass98.int_2);
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(7)], x + w + Class15.smethod_0(5), y - Class15.smethod_0(7), GClass177.int_2);
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(1)], x - Class15.smethod_0(5), y + h + Class15.smethod_0(5), GClass177.int_4);
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(5)], x + w + Class15.smethod_0(2), y + h + Class15.smethod_0(7), GClass177.int_5);
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(2)], x + w / Class15.smethod_0(7), y, GClass177.int_0);
    g.method_32(GClass140.gclass66_13[Class15.smethod_0(3)], x + w / Class15.smethod_0(7), y + h + Class15.smethod_0(1), GClass177.int_3);
  }

  public void method_34(int x, int y, int w, int h, GClass98 g)
  {
    g.method_16(Class15.smethod_0(303));
    g.method_14(x + Class15.smethod_0(37), y, w - Class15.smethod_0(66), h);
    g.method_14(x, y + Class15.smethod_0(37), w, h - Class15.smethod_0(66));
    g.method_14(x + Class15.smethod_0(38), y + Class15.smethod_0(1), w - Class15.smethod_0(49), h - Class15.smethod_0(7));
    g.method_14(x + Class15.smethod_0(1), y + Class15.smethod_0(38), w - Class15.smethod_0(7), h - Class15.smethod_0(49));
    g.method_16(Class15.smethod_0(480));
    g.method_15(x + Class15.smethod_0(88), y + Class15.smethod_0(7), w - Class15.smethod_0(10), h - Class15.smethod_0(5));
    g.method_15(x + Class15.smethod_0(7), y + Class15.smethod_0(88), w - Class15.smethod_0(5), h - Class15.smethod_0(49));
    g.method_32(GClass62.gclass66_8[Class15.smethod_0(7)], x, y, GClass98.int_4 | GClass98.int_2);
    g.method_24(GClass62.gclass66_8[Class15.smethod_0(7)], Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(10), Class15.smethod_0(10), Class15.smethod_0(7), x + w + Class15.smethod_0(1), y, GClass177.int_2);
    g.method_24(GClass62.gclass66_8[Class15.smethod_0(7)], Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(10), Class15.smethod_0(10), Class15.smethod_0(1), x, y + h + Class15.smethod_0(1), GClass177.int_4);
    g.method_24(GClass62.gclass66_8[Class15.smethod_0(7)], Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(10), Class15.smethod_0(10), Class15.smethod_0(5), x + w + Class15.smethod_0(1), y + h + Class15.smethod_0(1), GClass177.int_5);
  }

  public void method_35(int x, int y, int w, int h, GClass98 g)
  {
    g.method_16(Class15.smethod_0(481));
    g.method_15(x, y, w, h);
    g.method_16(Class15.smethod_0(480));
    g.method_15(x + Class15.smethod_0(1), y + Class15.smethod_0(1), w - Class15.smethod_0(7), h - Class15.smethod_0(7));
  }

  public void method_36(int x, int y, int w, int h, GClass98 g) => this.method_34(x, y, w, h, g);

  public void method_37(int x, int y, int w, int h, GClass98 g)
  {
    g.method_16(GClass140.int_0);
    g.method_15(x, y, w, h);
  }

  public void method_38(int x, int y, int w, int h, GClass98 g)
  {
    g.method_16(GClass140.int_1);
    g.method_15(x, y, w, h);
  }

  public GClass140()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(315)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.YoFNjcPcfZco));
    this.color = (int[]) Class15.smethod_4(byte_0);
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }
}
