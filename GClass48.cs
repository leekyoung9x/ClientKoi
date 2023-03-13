// Decompiled with JetBrains decompiler
// Type: GClass48
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass48
{
  public static GClass53[] gclass53_0;
  public static sbyte sbyte_0;
  public static sbyte sbyte_1 = (sbyte) Class15.smethod_0(1);
  public int timeStart;
  public int timeLenght;
  public short param;
  public GClass53 template;

  public GClass48(sbyte templateId, int timeStart, int timeLenght, short param)
  {
    this.template = GClass48.gclass53_0[(int) templateId];
    this.timeStart = timeStart;
    this.timeLenght = timeLenght / Class15.smethod_0(15);
    this.param = param;
  }
}
