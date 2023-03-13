// Decompiled with JetBrains decompiler
// Type: GClass69
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections;

public class GClass69
{
  public static GClass128 gclass128_0 = new GClass128();

  public static void smethod_0(string name, GClass66 img, sbyte nFrame) => GClass69.gclass128_0.method_4((object) (string.Empty + name), (object) new GClass91(img, nFrame));

  public static GClass91 smethod_1(string nameImg, GClass128 hash)
  {
    GClass91 v = (GClass91) hash.method_0((object) (string.Empty + nameImg));
    if ((v == null ? 0 : 1) == 0)
    {
      v = new GClass91();
      GClass91 gclass91 = GClass69.smethod_2(nameImg);
      if ((gclass91 == null ? 1 : 0) == 0)
      {
        v.img = gclass91.img;
        v.nFrame = gclass91.nFrame;
      }
      hash.method_4((object) (string.Empty + nameImg), (object) v);
    }
    v.count = GClass62.long_0 / (long) Class15.smethod_0(15);
    if ((v.img == null ? 0 : 1) == 0)
    {
      v.timeImageNull -= Class15.smethod_0(1);
      if (v.timeImageNull <= Class15.smethod_0(0))
      {
        GClass156.smethod_0().method_144(nameImg);
        v.timeImageNull = Class15.smethod_0(90);
      }
    }
    return v;
  }

  public static GClass91 smethod_2(string nameImg)
  {
    string filename = GClass98.int_8.ToString() + Class13.smethod_0(21634) + nameImg;
    GClass91 gclass91 = (GClass91) null;
    sbyte[] imageData = GClass152.smethod_1(filename);
    if ((imageData == null ? 0 : 1) == 0)
      return gclass91;
    try
    {
      return new GClass91()
      {
        nFrame = imageData[Class15.smethod_0(0)],
        img = GClass66.smethod_6(imageData, Class15.smethod_0(1), imageData.Length)
      };
    }
    catch (Exception ex)
    {
      return (GClass91) null;
    }
  }

  public static void smethod_3(string nameImg, sbyte nFrame, sbyte[] data)
  {
    string filename = GClass98.int_8.ToString() + Class13.smethod_0(21745) + nameImg;
    GClass36 gclass36 = new GClass36();
    try
    {
      gclass36.method_5(nFrame);
      for (int index = Class15.smethod_0(0); index < data.Length; index += Class15.smethod_0(1))
        gclass36.method_5(data[index]);
      GClass152.smethod_0(filename, gclass36.method_3());
      gclass36.method_4();
    }
    catch (Exception ex)
    {
    }
  }

  public static void smethod_4(GClass128 hash, int minute, bool isTrue)
  {
    GClass134 gclass134 = new GClass134(Class13.smethod_0(120489));
    if ((!isTrue ? 1 : 0) == 0)
    {
      hash.method_1();
    }
    else
    {
      IDictionaryEnumerator dictionaryEnumerator = hash.method_2();
      while ((!dictionaryEnumerator.MoveNext() ? 0 : 1) != 0)
      {
        GClass91 gclass91 = (GClass91) dictionaryEnumerator.Value;
        if (GClass62.long_0 / (long) Class15.smethod_0(15) - gclass91.count > (long) (minute * Class15.smethod_0(4)))
        {
          string key = (string) dictionaryEnumerator.Key;
          gclass134.method_0((object) key);
        }
      }
      for (int index = Class15.smethod_0(0); index < gclass134.method_2(); index += Class15.smethod_0(1))
        hash.method_5((object) (string) gclass134.method_3(index));
    }
  }
}
