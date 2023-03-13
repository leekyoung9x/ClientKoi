// Decompiled with JetBrains decompiler
// Type: GClass180
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass180
{
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 1;
  public int taskId;
  public int count;
  public short maxCount;
  public string name;
  public string description;
  public int killId;
  public int mapId;

  public GClass180(
    sbyte taskId,
    short count,
    short maxCount,
    string name,
    string description,
    sbyte killId,
    sbyte mapId)
  {
    this.count = (int) count;
    this.maxCount = maxCount;
    this.taskId = (int) taskId;
    this.name = name;
    this.description = description;
    this.killId = (int) killId;
    this.mapId = (int) mapId;
  }
}
