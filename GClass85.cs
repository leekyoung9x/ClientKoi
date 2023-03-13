// Decompiled with JetBrains decompiler
// Type: GClass85
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass85
{
  public short id;
  public sbyte type;
  public sbyte gender;
  public string name;
  public string[] subName;
  public string description;
  public sbyte level;
  public short iconID;
  public short part;
  public bool isUpToUp;
  public int w;
  public int h;
  public int strRequire;

  public GClass85(
    short templateID,
    sbyte type,
    sbyte gender,
    string name,
    string description,
    sbyte level,
    int strRequire,
    short iconID,
    short part,
    bool isUpToUp)
  {
    this.id = templateID;
    this.type = type;
    this.gender = gender;
    this.name = name;
    this.name = GClass151.smethod_14(this.name);
    this.description = description;
    this.description = GClass151.smethod_14(this.description);
    this.level = level;
    this.strRequire = strRequire;
    this.iconID = iconID;
    this.part = part;
    this.isUpToUp = isUpToUp;
  }
}
