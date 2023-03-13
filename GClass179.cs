// Decompiled with JetBrains decompiler
// Type: GClass179
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass179
{
  public int index;
  public int max;
  public short[] counts;
  public short taskId;
  public string[] names;
  public string[] details;
  public string[] subNames;
  public string[] contentInfo;
  public short count;

  public GClass179(
    short taskId,
    sbyte index,
    string name,
    string detail,
    string[] subNames,
    short[] counts,
    short count,
    string[] contentInfo)
  {
    this.taskId = taskId;
    this.index = (int) index;
    this.names = GClass97.gclass97_7.method_15(name, GClass141.int_19 - Class15.smethod_0(51));
    this.details = GClass97.gclass97_11.method_15(detail, GClass141.int_19 - Class15.smethod_0(51));
    this.subNames = subNames;
    this.counts = counts;
    this.count = count;
    this.contentInfo = contentInfo;
  }
}
