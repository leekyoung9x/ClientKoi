// Decompiled with JetBrains decompiler
// Type: GClass87
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass87
{
  public short idIcon;
  public int second;
  public int minute;
  private long long_0;
  private long long_1;
  private bool bool_0;
  private bool bool_1;
  private string string_0;
  private bool bool_2;
  public int time;
  public int coutTime;
  private int int_0 = Class15.smethod_0(21);

  public GClass87()
  {
  }

  public GClass87(short idIcon, int s)
  {
    this.idIcon = idIcon;
    this.minute = s / Class15.smethod_0(4);
    this.second = s % Class15.smethod_0(4);
    this.time = s;
    this.coutTime = s;
    this.long_0 = this.long_1 = GClass126.smethod_18();
    this.bool_2 = (int) idIcon == Class15.smethod_0(49);
  }

  public void method_0(sbyte id, string text, int time)
  {
    this.bool_1 = time != -1 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    this.bool_0 = Class15.smethod_0(1) != 0;
    this.minute = time / Class15.smethod_0(4);
    this.second = time % Class15.smethod_0(4);
    this.idIcon = (short) id;
    this.time = time;
    this.coutTime = time;
    this.string_0 = text;
    this.long_0 = this.long_1 = GClass126.smethod_18();
    this.bool_2 = (int) this.idIcon == Class15.smethod_0(49);
  }

  public void method_1(int time, bool isText)
  {
    this.minute = time / Class15.smethod_0(4);
    this.second = time % Class15.smethod_0(4);
    this.time = time;
    this.coutTime = time;
    this.bool_0 = isText;
    this.long_0 = this.long_1 = GClass126.smethod_18();
  }

  public static bool smethod_0(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if ((int) ((GClass87) GClass20.gclass134_0.method_3(index)).idIcon == id)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static GClass87 smethod_1(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass87 gclass87 = (GClass87) GClass116.gclass134_0.method_3(index);
      if ((int) gclass87.idIcon == id)
        return gclass87;
    }
    return (GClass87) null;
  }

  public static bool smethod_2(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if ((int) ((GClass87) GClass116.gclass134_0.method_3(index)).idIcon == id)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  public static GClass87 smethod_3(int id)
  {
    for (int index = Class15.smethod_0(0); index < GClass20.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass87 gclass87 = (GClass87) GClass20.gclass134_0.method_3(index);
      if ((int) gclass87.idIcon == id)
        return gclass87;
    }
    return (GClass87) null;
  }

  public void method_2(int time)
  {
    this.minute = time / Class15.smethod_0(4);
    this.second = time % Class15.smethod_0(4);
    this.coutTime = time;
    this.long_0 = this.long_1 = GClass126.smethod_18();
  }

  public void method_3(GClass98 g, int x, int y)
  {
    GClass169.smethod_6(g, (int) this.idIcon, x, y, Class15.smethod_0(0), Class15.smethod_0(5));
    string empty = string.Empty;
    string st = this.minute.ToString() + Class13.smethod_0(157928);
    if ((this.minute == 0 ? 0 : 1) == 0)
      st = this.second.ToString() + Class13.smethod_0(157926);
    GClass97.gclass97_3.method_10(g, st, x, y + Class15.smethod_0(9), Class15.smethod_0(7), GClass97.gclass97_6);
  }

  public void method_4(GClass98 g, int x, int y)
  {
    if ((!this.bool_2 ? 1 : 0) == 0)
    {
      if ((GClass20.smethod_1() == null ? 1 : 0) != 0)
        return;
      int w = Class15.smethod_0(25);
      int x1 = GClass62.int_10 / Class15.smethod_0(7) - w / Class15.smethod_0(7);
      int y1 = GClass62.int_11 - Class15.smethod_0(25);
      g.method_16(Class15.smethod_0(398));
      g.method_15(x1, y1, w, Class15.smethod_0(7));
      g.method_16(Class15.smethod_0(142));
      if (this.int_0 <= Class15.smethod_0(0))
        return;
      g.method_15(x1, y1, w * this.int_0 / Class15.smethod_0(21), Class15.smethod_0(7));
    }
    else
    {
      string empty = string.Empty;
      string str = this.minute.ToString() + Class13.smethod_0(157912);
      if (this.minute < Class15.smethod_0(1))
        str = this.second.ToString() + Class13.smethod_0(157910);
      if (this.minute < Class15.smethod_0(0))
        str = string.Empty;
      if ((!this.bool_1 ? 1 : 0) == 0)
        str = string.Empty;
      GClass97.gclass97_3.method_10(g, this.string_0 + Class13.smethod_0(158515) + str, x, y, Class15.smethod_0(0), GClass97.gclass97_6);
    }
  }

  public void method_5()
  {
    this.long_0 = GClass126.smethod_18();
    if (this.long_0 - this.long_1 >= (long) Class15.smethod_0(15))
    {
      this.long_1 = GClass126.smethod_18();
      this.second -= Class15.smethod_0(1);
      this.coutTime -= Class15.smethod_0(1);
      if (this.second <= Class15.smethod_0(0))
      {
        this.second = Class15.smethod_0(4);
        this.minute -= Class15.smethod_0(1);
      }
      if (this.time > Class15.smethod_0(0))
        this.int_0 = this.coutTime * Class15.smethod_0(21) / this.time;
    }
    if (this.minute < Class15.smethod_0(0) && (!this.bool_0 ? 0 : 1) == 0)
      GClass20.gclass134_0.method_8((object) this);
    if (this.minute >= Class15.smethod_0(0) || (!this.bool_0 ? 1 : 0) != 0 || (!this.bool_1 ? 0 : 1) != 0)
      return;
    GClass116.gclass134_0.method_8((object) this);
  }
}
