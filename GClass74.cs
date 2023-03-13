// Decompiled with JetBrains decompiler
// Type: GClass74
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass74
{
  public int type_PB;
  public int maxPoint;
  public int pointTeam1;
  public int pointTeam2;
  public int color_1;
  public int color_2;
  public int maxLife = Class15.smethod_0(1);
  public int lifeTeam1;
  public int lifeTeam2;
  public string nameTeam1;
  public string nameTeam2;
  public short idmapPaint;
  public short timeSecond;
  public short timepaintSecond;
  public short maxtimeSecond = (short) Class15.smethod_0(1);
  public byte owner;
  public long timeStart;
  public GClass134 vecInfo = new GClass134(Class13.smethod_0(121184));

  public GClass74(
    int type_PB,
    short idmapPaint,
    string nameTeam1,
    string nameTeam2,
    int maxPoint,
    short timeSecond)
  {
    this.type_PB = type_PB;
    this.idmapPaint = idmapPaint;
    this.nameTeam1 = nameTeam1;
    this.nameTeam2 = nameTeam2;
    this.timeSecond = timeSecond;
    this.timeStart = GClass62.long_0;
    this.maxPoint = maxPoint;
    if (this.maxPoint <= Class15.smethod_0(0))
      this.maxPoint = Class15.smethod_0(1);
    this.pointTeam1 = Class15.smethod_0(0);
    this.pointTeam2 = Class15.smethod_0(0);
    this.owner = (byte) Class15.smethod_0(0);
    this.color_1 = Class15.smethod_0(2);
    this.color_2 = Class15.smethod_0(37);
  }

  public void method_0(int type_PB, short timeSecond)
  {
    this.type_PB = type_PB;
    this.timeSecond = timeSecond;
    this.timeStart = GClass62.long_0;
  }

  public void method_1(int type_PB, int pointTeam1, int pointTeam2)
  {
    this.type_PB = type_PB;
    this.pointTeam1 = pointTeam1;
    this.pointTeam2 = pointTeam2;
  }

  public void method_2(int type_PB, int lifeTeam1, int lifeTeam2)
  {
    this.type_PB = type_PB;
    this.lifeTeam1 = lifeTeam1;
    this.lifeTeam2 = lifeTeam2;
  }
}
