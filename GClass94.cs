// Decompiled with JetBrains decompiler
// Type: GClass94
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass94
{
  public int ID;
  public short head;
  public short headICON = -1;
  public short leg;
  public short body;
  public string name;
  public sbyte role;
  public string powerPoint;
  public int donate;
  public int receive_donate;
  public int curClanPoint;
  public int clanPoint;
  public int lastRequest;
  public string joinTime;

  public static string smethod_0(int r)
  {
    string str;
    switch (r)
    {
      case 0:
        str = GClass109.string_256;
        break;
      case 1:
        str = GClass109.string_257;
        break;
      case 2:
        str = GClass109.string_259;
        break;
      default:
        str = string.Empty;
        break;
    }
    return str;
  }
}
