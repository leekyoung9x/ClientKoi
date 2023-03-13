// Decompiled with JetBrains decompiler
// Type: GClass26
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass26
{
  public int ID;
  public string name;
  public short[] idImage;
  public int xu;
  public int luong;
  public static GClass134 gclass134_0 = new GClass134();
  public static GClass128 gclass128_0 = new GClass128();

  public static void smethod_0(GClass26 cm)
  {
    GClass156.smethod_0().method_17((sbyte) cm.ID);
    GClass26.gclass134_0.method_0((object) cm);
  }

  public static GClass26 smethod_1(short ID)
  {
    for (int index = Class15.smethod_0(0); index < GClass26.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      GClass26 gclass26 = (GClass26) GClass26.gclass134_0.method_3(index);
      if (gclass26.ID == (int) ID)
        return gclass26;
    }
    return (GClass26) null;
  }

  public static bool smethod_2(int ID)
  {
    for (int index = Class15.smethod_0(0); index < GClass26.gclass134_0.method_2(); index += Class15.smethod_0(1))
    {
      if (((GClass26) GClass26.gclass134_0.method_3(index)).ID == ID)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }
}
