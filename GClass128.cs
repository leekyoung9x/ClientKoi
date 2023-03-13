// Decompiled with JetBrains decompiler
// Type: GClass128
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections;

public class GClass128
{
  public Hashtable h = new Hashtable();

  public object method_0(object k) => this.h[k];

  public void method_1() => this.h.Clear();

  public IDictionaryEnumerator method_2() => this.h.GetEnumerator();

  public int method_3() => this.h.Count;

  public void method_4(object k, object v)
  {
    if ((!this.h.ContainsKey(k) ? 1 : 0) == 0)
      this.h.Remove(k);
    this.h.Add(k, v);
  }

  public void method_5(object k) => this.h.Remove(k);

  public void method_6(string key) => this.h.Remove((object) key);

  public bool method_7(object key) => this.h.ContainsKey(key);
}
