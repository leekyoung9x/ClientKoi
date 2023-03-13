// Decompiled with JetBrains decompiler
// Type: GClass163
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass163
{
  public int param;
  public GClass164 optionTemplate;
  public string optionString;

  public string method_0()
  {
    if ((this.optionString == null ? 0 : 1) == 0)
      this.optionString = GClass138.smethod_4(this.optionTemplate.name, Class13.smethod_0(150764), string.Empty + this.param.ToString());
    return this.optionString;
  }
}
