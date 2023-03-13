// Decompiled with JetBrains decompiler
// Type: GClass28
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass28 : GInterface0
{
  public int id;
  public int type;
  public int playerId;
  public string playerName;
  public long time;
  public int headId;
  public string[] chat;
  public sbyte color;
  public sbyte role;
  private int int_0;
  public int recieve;
  public int maxCap;
  public string[] option;
  public static GClass134 gclass134_0 = new GClass134();

  public static void smethod_0(GClass28 cm, int index, bool upToTop)
  {
    for (int index1 = Class15.smethod_0(0); index1 < GClass28.gclass134_0.method_2(); index1 += Class15.smethod_0(1))
    {
      GClass28 o = (GClass28) GClass28.gclass134_0.method_3(index1);
      if (o.id != cm.id)
      {
        if ((o.maxCap == 0 ? 1 : 0) == 0 && o.recieve == o.maxCap)
          GClass28.gclass134_0.method_8((object) o);
      }
      else
      {
        GClass28.gclass134_0.method_8((object) o);
        if ((!upToTop ? 0 : 1) == 0)
        {
          GClass28.gclass134_0.method_10((object) cm, index1);
          return;
        }
        GClass28.gclass134_0.method_10((object) cm, Class15.smethod_0(0));
        return;
      }
    }
    if (index == -1)
      GClass28.gclass134_0.method_0((object) cm);
    else
      GClass28.gclass134_0.method_10((object) cm, Class15.smethod_0(0));
    if (GClass28.gclass134_0.method_2() <= Class15.smethod_0(51))
      return;
    GClass28.gclass134_0.method_7(GClass28.gclass134_0.method_2() - Class15.smethod_0(1));
  }

  public void method_0(GClass98 g, int x, int y)
  {
    GClass97 gclass97_1 = GClass97.gclass97_6;
    if ((this.role == (sbyte) 0 ? 0 : 1) == 0)
      gclass97_1 = GClass97.gclass97_1;
    else if ((int) this.role == Class15.smethod_0(1))
      gclass97_1 = GClass97.gclass97_8;
    else if ((int) this.role == Class15.smethod_0(7))
      gclass97_1 = GClass97.gclass97_7;
    if ((this.type == 0 ? 0 : 1) == 0)
    {
      gclass97_1.method_6(g, this.playerName, x + Class15.smethod_0(5), y + Class15.smethod_0(1), Class15.smethod_0(0));
      if ((this.color == (sbyte) 0 ? 0 : 1) == 0)
        GClass97.gclass97_16.method_6(g, this.chat[Class15.smethod_0(0)] + (this.chat.Length <= Class15.smethod_0(1) ? string.Empty : Class13.smethod_0(26322)), x + Class15.smethod_0(5), y + Class15.smethod_0(67), Class15.smethod_0(0));
      else
        GClass97.gclass97_17.method_6(g, this.chat[Class15.smethod_0(0)] + (this.chat.Length <= Class15.smethod_0(1) ? string.Empty : Class13.smethod_0(26322)), x + Class15.smethod_0(5), y + Class15.smethod_0(67), Class15.smethod_0(0));
      GClass97.gclass97_16.method_6(g, GClass138.smethod_10(this.int_0) + Class13.smethod_0(26315) + GClass109.string_292, x + GClass62.gclass141_0.wScroll - Class15.smethod_0(5), y + Class15.smethod_0(1), GClass97.int_1);
    }
    if (this.type == Class15.smethod_0(1))
    {
      GClass97 gclass97_2 = gclass97_1;
      GClass98 g1 = g;
      string[] strArray1 = new string[Class15.smethod_0(37)];
      strArray1[Class15.smethod_0(0)] = this.playerName;
      strArray1[Class15.smethod_0(1)] = Class13.smethod_0(26907);
      strArray1[Class15.smethod_0(7)] = this.recieve.ToString();
      strArray1[Class15.smethod_0(5)] = Class13.smethod_0(26904);
      strArray1[Class15.smethod_0(2)] = this.maxCap.ToString();
      strArray1[Class15.smethod_0(3)] = Class13.smethod_0(26902);
      string st1 = string.Concat(strArray1);
      int x1 = x + Class15.smethod_0(5);
      int y1 = y + Class15.smethod_0(1);
      int align1 = Class15.smethod_0(0);
      gclass97_2.method_6(g1, st1, x1, y1, align1);
      GClass97 gclass9718 = GClass97.gclass97_18;
      GClass98 g2 = g;
      string[] strArray2 = new string[Class15.smethod_0(3)];
      strArray2[Class15.smethod_0(0)] = GClass109.string_251;
      strArray2[Class15.smethod_0(1)] = Class13.smethod_0(26315);
      strArray2[Class15.smethod_0(7)] = GClass138.smethod_10(this.int_0);
      strArray2[Class15.smethod_0(5)] = Class13.smethod_0(26315);
      strArray2[Class15.smethod_0(2)] = GClass109.string_292;
      string st2 = string.Concat(strArray2);
      int x2 = x + Class15.smethod_0(5);
      int y2 = y + Class15.smethod_0(67);
      int align2 = Class15.smethod_0(0);
      gclass9718.method_6(g2, st2, x2, y2, align2);
    }
    if (this.type != Class15.smethod_0(7))
      return;
    gclass97_1.method_6(g, this.playerName, x + Class15.smethod_0(5), y + Class15.smethod_0(1), Class15.smethod_0(0));
    GClass97.gclass97_18.method_6(g, GClass109.string_283, x + Class15.smethod_0(5), y + Class15.smethod_0(67), Class15.smethod_0(0));
  }

  public void imethod_0(int idAction, object p)
  {
  }

  public void method_1()
  {
    if ((this.time == 0L ? 1 : 0) != 0)
      return;
    this.int_0 = (int) (GClass126.smethod_18() / (long) Class15.smethod_0(15) - this.time);
  }
}
