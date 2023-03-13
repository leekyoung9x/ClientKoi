// Decompiled with JetBrains decompiler
// Type: GClass86
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass86
{
  public static GClass128 gclass128_0 = new GClass128();

  public static void smethod_0(GClass85 it) => GClass86.gclass128_0.method_4((object) it.id, (object) it);

  public static GClass85 smethod_1(short id) => (GClass85) GClass86.gclass128_0.method_0((object) id);

  public static short smethod_2(short itemTemplateID) => GClass86.smethod_1(itemTemplateID).part;

  public static short smethod_3(short itemTemplateID) => GClass86.smethod_1(itemTemplateID).iconID;
}
