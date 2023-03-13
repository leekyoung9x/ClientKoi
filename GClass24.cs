// Decompiled with JetBrains decompiler
// Type: GClass24
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass24
{
  public string nameBoss;
  public string mapName;
  public int mapId;
  public DateTime appearTime;

  public GClass24()
  {
  }

  public GClass24(string text)
  {
    text = text.Replace(Class13.smethod_0(25300), "").Replace(Class13.smethod_0(26313), Class13.smethod_0(26921)).Replace(Class13.smethod_0(26919), Class13.smethod_0(26921));
    string str = text;
    char[] chArray = new char[Class15.smethod_0(1)];
    chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(114);
    string[] strArray = str.Split(chArray);
    this.nameBoss = strArray[Class15.smethod_0(0)].Trim();
    this.mapName = strArray[Class15.smethod_0(1)].Trim();
    this.mapId = this.method_0(this.mapName);
    this.appearTime = DateTime.Now;
  }

  public int method_0(string mapName)
  {
    for (int index = Class15.smethod_0(0); index < GClass185.string_2.Length; index += Class15.smethod_0(1))
    {
      if ((!GClass185.string_2[index].Equals(mapName) ? 1 : 0) == 0)
        return index;
    }
    return -1;
  }

  public void method_1(GClass98 g, int x, int y, int align)
  {
    TimeSpan timeSpan = DateTime.Now.Subtract(this.appearTime);
    int totalSeconds = (int) timeSpan.TotalSeconds;
    GClass97 gclass97_1 = GClass97.gclass97_15;
    if (GClass185.int_37 == this.mapId)
    {
      gclass97_1 = GClass97.gclass97_17;
      for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
      {
        if ((!((GClass20) GClass116.gclass134_5.method_3(index)).cName.Equals(this.nameBoss) ? 1 : 0) == 0)
        {
          gclass97_1 = GClass97.gclass97_1;
          break;
        }
      }
    }
    GClass97 gclass97_2 = gclass97_1;
    GClass98 g1 = g;
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = this.nameBoss;
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(26900);
    strArray[Class15.smethod_0(7)] = this.mapName;
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(26900);
    strArray[Class15.smethod_0(2)] = totalSeconds < Class15.smethod_0(4) ? totalSeconds.ToString() + Class13.smethod_0(26885) : timeSpan.Minutes.ToString() + Class13.smethod_0(26894);
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(26883);
    string st = string.Concat(strArray);
    int x1 = x;
    int y1 = y;
    int align1 = align;
    gclass97_2.method_6(g1, st, x1, y1, align1);
  }
}
