// Decompiled with JetBrains decompiler
// Type: GClass127
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using UnityEngine;

public class GClass127
{
  public string name;
  public AudioClip clip;
  public long timeStart;

  public GClass127(string filename)
  {
    this.clip = (AudioClip) Resources.Load(filename);
    this.name = filename;
  }

  public void method_0()
  {
    Main.main_0.GetComponent<AudioSource>().PlayOneShot(this.clip);
    this.timeStart = GClass126.smethod_18();
  }

  public bool method_1() => Class15.smethod_0(0) != 0;
}
