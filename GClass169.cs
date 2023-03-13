// Decompiled with JetBrains decompiler
// Type: GClass169
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass169
{
  public static int[][] int_0;
  public static GClass169 gclass169_0;
  public static GClass66[] gclass66_0;
  public static GClass192[] gclass192_0;
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass66 gclass66_1 = (GClass66) null;
  public static sbyte[] sbyte_0;
  public static int int_1;
  public static short short_0;

  public GClass169() => this.method_1();

  public static void smethod_0()
  {
    if ((GClass169.gclass66_0 == null ? 0 : 1) != 0)
      return;
    GClass66[] gclass66Array = new GClass66[Class15.smethod_0(3)];
    gclass66Array[Class15.smethod_0(0)] = GClass62.smethod_39(Class13.smethod_0(151428));
    gclass66Array[Class15.smethod_0(1)] = GClass62.smethod_39(Class13.smethod_0(151150));
    gclass66Array[Class15.smethod_0(7)] = GClass62.smethod_39(Class13.smethod_0(151136));
    gclass66Array[Class15.smethod_0(5)] = GClass62.smethod_39(Class13.smethod_0(151122));
    gclass66Array[Class15.smethod_0(2)] = GClass62.smethod_39(Class13.smethod_0(151108));
    GClass169.gclass66_0 = gclass66Array;
  }

  public static void smethod_1()
  {
    GClass169.gclass66_0 = (GClass66[]) null;
    GClass126.smethod_26();
  }

  public static void smethod_2() => GClass169.gclass66_1 = GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0);

  public static void smethod_3()
  {
    GClass169.gclass169_0 = (GClass169) null;
    GClass169.gclass169_0 = new GClass169();
  }

  public void method_0(byte[] data)
  {
  }

  public void method_1()
  {
    int num = Class15.smethod_0(0);
    try
    {
      GClass35 gclass35 = new GClass35(GClass152.smethod_1(Class13.smethod_0(151217)));
      short length = gclass35.method_0();
      GClass169.int_0 = new int[(int) length][];
      for (int index = Class15.smethod_0(0); index < GClass169.int_0.Length; index += Class15.smethod_0(1))
        GClass169.int_0[index] = new int[Class15.smethod_0(3)];
      for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
      {
        num += Class15.smethod_0(1);
        GClass169.int_0[index][Class15.smethod_0(0)] = gclass35.method_10();
        GClass169.int_0[index][Class15.smethod_0(1)] = (int) gclass35.method_0();
        GClass169.int_0[index][Class15.smethod_0(7)] = (int) gclass35.method_0();
        GClass169.int_0[index][Class15.smethod_0(5)] = (int) gclass35.method_0();
        GClass169.int_0[index][Class15.smethod_0(2)] = (int) gclass35.method_0();
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_4(Class13.smethod_0(151191) + ex.ToString() + Class13.smethod_0(151175) + num.ToString());
    }
  }

  public static void smethod_4()
  {
  }

  public static void smethod_5(int id)
  {
    GClass151.smethod_7(Class13.smethod_0(151244) + id.ToString() + Class13.smethod_0(143636) + GClass98.int_8.ToString());
    GClass66 img1 = GClass62.smethod_40(Class13.smethod_0(144295) + id.ToString() + Class13.smethod_0(144257));
    if ((img1 == null ? 1 : 0) == 0)
    {
      GClass169.gclass192_0[id] = new GClass192(img1, id);
    }
    else
    {
      bool flag = Class15.smethod_0(0) != 0;
      sbyte[] imageData = GClass152.smethod_1(GClass98.int_8.ToString() + Class13.smethod_0(144371) + id.ToString());
      if ((imageData == null ? 1 : 0) == 0)
      {
        if ((GClass169.sbyte_0 == null ? 1 : 0) == 0 && imageData.Length % Class15.smethod_0(73) != (int) GClass169.sbyte_0[id])
          flag = Class15.smethod_0(1) != 0;
        if ((!flag ? 0 : 1) == 0)
        {
          GClass66 img2 = GClass66.smethod_6(imageData, Class15.smethod_0(0), imageData.Length);
          if ((img2 == null ? 1 : 0) == 0)
            GClass169.gclass192_0[id] = new GClass192(img2, id);
          else
            flag = Class15.smethod_0(1) != 0;
        }
      }
      else
        flag = Class15.smethod_0(1) != 0;
      if ((!flag ? 1 : 0) != 0)
        return;
      GClass169.gclass192_0[id] = new GClass192(GClass169.gclass66_1, id);
      GClass156.smethod_0().method_106(id);
    }
  }

  public static void smethod_6(GClass98 g, int id, int x, int y, int transform, int anchor)
  {
    if ((GClass169.gclass66_0 == null ? 0 : 1) == 0)
    {
      GClass192 gclass192_0 = GClass169.gclass192_0[id];
      if ((gclass192_0 == null ? 0 : 1) == 0)
        GClass169.smethod_5(id);
      else
        g.method_47(gclass192_0, Class15.smethod_0(0), Class15.smethod_0(0), GClass98.smethod_0(gclass192_0.img), GClass98.smethod_1(gclass192_0.img), transform, x, y, anchor);
    }
    else if ((GClass169.int_0 == null ? 1 : 0) == 0)
    {
      if (id < GClass169.int_0.Length && GClass169.int_0[id][Class15.smethod_0(1)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(5)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(7)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(2)] < Class15.smethod_0(290))
      {
        if ((GClass169.gclass66_0[GClass169.int_0[id][Class15.smethod_0(0)]] == null ? 1 : 0) != 0)
          return;
        g.method_24(GClass169.gclass66_0[GClass169.int_0[id][Class15.smethod_0(0)]], GClass169.int_0[id][Class15.smethod_0(1)], GClass169.int_0[id][Class15.smethod_0(7)], GClass169.int_0[id][Class15.smethod_0(5)], GClass169.int_0[id][Class15.smethod_0(2)], transform, x, y, anchor);
      }
      else
      {
        GClass192 gclass192 = GClass169.gclass192_0[id];
        if ((gclass192 == null ? 0 : 1) == 0)
          GClass169.smethod_5(id);
        else
          gclass192.method_0(g, transform, x, y, anchor);
      }
    }
    else
    {
      if (GClass62.gclass113_0 == GClass116.smethod_6())
        return;
      GClass192 gclass192 = GClass169.gclass192_0[id];
      if ((gclass192 == null ? 0 : 1) == 0)
        GClass169.smethod_5(id);
      else
        gclass192.method_0(g, transform, x, y, anchor);
    }
  }

  public static void smethod_7(
    GClass98 g,
    int id,
    int f,
    int x,
    int y,
    int w,
    int h,
    int transform,
    int anchor)
  {
    if ((GClass169.gclass66_0 == null ? 0 : 1) == 0)
    {
      GClass192 gclass192 = GClass169.gclass192_0[id];
      if ((gclass192 == null ? 0 : 1) == 0)
        GClass169.smethod_5(id);
      else
        g.method_24(gclass192.img, Class15.smethod_0(0), f * w, w, h, transform, x, y, anchor);
    }
    else if ((GClass169.int_0 == null ? 1 : 0) == 0)
    {
      if (id < GClass169.int_0.Length && (GClass169.int_0[id] == null ? 1 : 0) == 0 && GClass169.int_0[id][Class15.smethod_0(1)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(5)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(7)] < Class15.smethod_0(290) && GClass169.int_0[id][Class15.smethod_0(2)] < Class15.smethod_0(290))
      {
        if (GClass169.int_0[id][Class15.smethod_0(0)] != Class15.smethod_0(2) && (GClass169.gclass66_0[GClass169.int_0[id][Class15.smethod_0(0)]] == null ? 1 : 0) == 0)
        {
          g.method_24(GClass169.gclass66_0[GClass169.int_0[id][Class15.smethod_0(0)]], Class15.smethod_0(0), f * w, w, h, transform, x, y, anchor);
        }
        else
        {
          GClass192 gclass192 = GClass169.gclass192_0[id];
          if ((gclass192 == null ? 0 : 1) == 0)
            GClass169.smethod_5(id);
          else
            gclass192.method_1(g, transform, f, x, y, w, h, anchor);
        }
      }
      else
      {
        GClass192 gclass192 = GClass169.gclass192_0[id];
        if ((gclass192 == null ? 0 : 1) == 0)
          GClass169.smethod_5(id);
        else
          gclass192.method_1(g, transform, f, x, y, w, h, anchor);
      }
    }
    else
    {
      if (GClass62.gclass113_0 == GClass116.smethod_6())
        return;
      GClass192 gclass192 = GClass169.gclass192_0[id];
      if ((gclass192 == null ? 0 : 1) == 0)
        GClass169.smethod_5(id);
      else
        gclass192.method_1(g, transform, f, x, y, w, h, anchor);
    }
  }

  public static void smethod_8()
  {
  }
}
