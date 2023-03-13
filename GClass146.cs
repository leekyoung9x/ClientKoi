// Decompiled with JetBrains decompiler
// Type: GClass146
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass146
{
  public string name;
  public string showName;
  public string status;
  public int IDDB;
  private int int_0;
  public bool isReady;
  public int xu;
  public int gold;
  public string strMoney = string.Empty;
  public sbyte finishPosition;
  public bool isMaster;
  public static GClass66[] gclass66_0;
  public sbyte[] indexLv;
  public int onlineTime;

  public string method_0() => this.name;

  public void method_1(int m)
  {
    this.xu = m;
    this.strMoney = GClass62.smethod_35(this.xu);
  }

  public void method_2(string name)
  {
    this.name = name;
    if (name.Length > Class15.smethod_0(45))
      this.showName = name.Substring(Class15.smethod_0(0), Class15.smethod_0(88));
    else
      this.showName = name;
  }

  public void method_3(GClass98 g, int x, int y)
  {
  }

  public int method_4() => this.int_0;
}
