// Decompiled with JetBrains decompiler
// Type: GClass96
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass96
{
  public sbyte command;
  private GClass131 gclass131_0;
  private GClass136 gclass136_0;

  public GClass96(int command)
  {
    this.command = (sbyte) command;
    this.gclass136_0 = new GClass136();
  }

  public GClass96() => this.gclass136_0 = new GClass136();

  public GClass96(sbyte command)
  {
    this.command = command;
    this.gclass136_0 = new GClass136();
  }

  public GClass96(sbyte command, sbyte[] data)
  {
    this.command = command;
    this.gclass131_0 = new GClass131(data);
  }

  public sbyte[] method_0() => this.gclass136_0.method_20();

  public GClass131 method_1() => this.gclass131_0;

  public GClass136 method_2() => this.gclass136_0;

  public int method_3() => this.gclass131_0.method_8();

  public void method_4()
  {
  }
}
