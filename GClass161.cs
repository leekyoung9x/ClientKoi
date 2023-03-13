// Decompiled with JetBrains decompiler
// Type: GClass161
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass161
{
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 1;
  public const sbyte sbyte_2 = 0;
  public const sbyte sbyte_3 = 1;
  public const sbyte sbyte_4 = 2;
  public const sbyte sbyte_5 = 3;
  public const sbyte sbyte_6 = 4;
  public GClass167 template;
  public short skillId;
  public int point;
  public long powRequire;
  public int coolDown;
  public long lastTimeUseThisSkill;
  public int dx;
  public int dy;
  public int maxFight;
  public int manaUse;
  public GClass163[] options;
  public bool paintCanNotUseSkill;
  public short damage;
  public string moreInfo;
  public short price;

  public string method_0()
  {
    if ((this.coolDown % Class15.smethod_0(15) == 0 ? 0 : 1) == 0)
      return (this.coolDown / Class15.smethod_0(15)).ToString() + string.Empty;
    int num = this.coolDown % Class15.smethod_0(15);
    return (this.coolDown / Class15.smethod_0(15)).ToString() + Class13.smethod_0(145050) + ((num % Class15.smethod_0(21) == 0 ? 0 : 1) != 0 ? num / Class15.smethod_0(31) : num / Class15.smethod_0(21)).ToString();
  }

  public void method_1(int x, int y, GClass98 g)
  {
    GClass169.smethod_6(g, this.template.iconId, x, y, Class15.smethod_0(0), GClass177.int_6);
    long num1 = GClass126.smethod_18() - this.lastTimeUseThisSkill;
    if (num1 >= (long) this.coolDown)
    {
      this.paintCanNotUseSkill = Class15.smethod_0(0) != 0;
    }
    else
    {
      this.paintCanNotUseSkill = Class15.smethod_0(1) != 0;
      g.method_21(Class15.smethod_0(102), Class15.smethod_2(31));
      int num2 = (int) (num1 * (long) Class15.smethod_0(51) / (long) this.coolDown);
      g.method_15(x - Class15.smethod_0(31), y - Class15.smethod_0(31) + num2, Class15.smethod_0(51), Class15.smethod_0(51) - num2);
      long m = (long) this.coolDown - num1;
      if (m > (long) Class15.smethod_0(181))
      {
        GClass97 gclass9711 = GClass97.gclass97_11;
        GClass98 g1 = g;
        string str = GClass138.smethod_9(m);
        char[] chArray = new char[Class15.smethod_0(1)];
        chArray[Class15.smethod_0(0)] = (char) Class15.smethod_0(71);
        string st = str.Split(chArray)[Class15.smethod_0(0)];
        int x1 = x;
        int y1 = y - Class15.smethod_0(37);
        int align = Class15.smethod_0(7);
        gclass9711.method_6(g1, st, x1, y1, align);
      }
      else if (m > (long) Class15.smethod_0(15))
        GClass97.gclass97_11.method_6(g, GClass138.smethod_9(m).Substring(Class15.smethod_0(0), Class15.smethod_0(5)), x, y - Class15.smethod_0(37), Class15.smethod_0(7));
      else
        GClass97.gclass97_11.method_6(g, Class13.smethod_0(147242) + m.ToString().Substring(Class15.smethod_0(0), Class15.smethod_0(7)), x, y - Class15.smethod_0(37), Class15.smethod_0(7));
    }
  }
}
