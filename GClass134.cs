// Decompiled with JetBrains decompiler
// Type: GClass134
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections;

public class GClass134
{
  private ArrayList arrayList_0;

  public GClass134() => this.arrayList_0 = new ArrayList();

  public GClass134(string s) => this.arrayList_0 = new ArrayList();

  public GClass134(ArrayList a) => this.arrayList_0 = a;

  public void method_0(object o) => this.arrayList_0.Add(o);

  public bool method_1(object o) => (!this.arrayList_0.Contains(o) ? 1 : 0) == 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public int method_2() => (this.arrayList_0 == null ? 0 : 1) == 0 ? Class15.smethod_0(0) : this.arrayList_0.Count;

  public object method_3(int index) => index > -1 && index < this.arrayList_0.Count ? this.arrayList_0[index] : (object) null;

  public void method_4(int index, object obj)
  {
    if (index <= -1 || index >= this.arrayList_0.Count)
      return;
    this.arrayList_0[index] = obj;
  }

  public void method_5(object obj, int index)
  {
    if (index <= -1 || index >= this.arrayList_0.Count)
      return;
    this.arrayList_0[index] = obj;
  }

  public int method_6(object o) => this.arrayList_0.IndexOf(o);

  public void method_7(int index)
  {
    if (index <= -1 || index >= this.arrayList_0.Count)
      return;
    this.arrayList_0.RemoveAt(index);
  }

  public void method_8(object o) => this.arrayList_0.Remove(o);

  public void method_9() => this.arrayList_0.Clear();

  public void method_10(object o, int i) => this.arrayList_0.Insert(i, o);

  public object method_11() => this.arrayList_0[Class15.smethod_0(0)];

  public object method_12() => this.arrayList_0[this.arrayList_0.Count - Class15.smethod_0(1)];
}
