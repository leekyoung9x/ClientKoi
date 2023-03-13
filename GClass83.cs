// Decompiled with JetBrains decompiler
// Type: GClass83
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass83
{
  public int param;
  public sbyte active;
  public sbyte activeCard;
  public GClass84 optionTemplate;

  public GClass83()
  {
  }

  public GClass83(int optionTemplateId, int param)
  {
    if (optionTemplateId == Class15.smethod_0(28))
    {
      optionTemplateId = Class15.smethod_0(37);
      param *= Class15.smethod_0(15);
    }
    if (optionTemplateId == Class15.smethod_0(29))
    {
      optionTemplateId = Class15.smethod_0(38);
      param *= Class15.smethod_0(15);
    }
    this.param = param;
    this.optionTemplate = GClass116.smethod_6().iOptionTemplates[optionTemplateId];
  }

  public string method_0() => GClass138.smethod_4(this.optionTemplate.name, Class13.smethod_0(157409), this.param.ToString() + string.Empty);

  public string method_1() => GClass138.smethod_4(this.optionTemplate.name, Class13.smethod_0(157404), string.Empty);

  public string method_2() => GClass138.smethod_4(this.optionTemplate.name, Class13.smethod_0(159157), string.Empty);
}
