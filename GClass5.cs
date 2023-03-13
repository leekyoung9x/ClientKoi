// Decompiled with JetBrains decompiler
// Type: GClass5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Collections.Generic;
using System.Threading;

public class GClass5 : GInterface0, GInterface1
{
  public static GClass5 gclass5_0 = new GClass5();
  private List<GClass5.GClass6> list_0;
  private GClass5.GClass6 gclass6_0;
  private List<string> list_1;
  private List<string> list_2;
  private bool bool_0;
  private string[] string_0;
  private string[] string_1;
  private string[] string_2;

  public GClass5()
  {
    this.list_0 = new List<GClass5.GClass6>();
    this.list_1 = new List<string>();
    this.list_2 = new List<string>();
    string[] strArray1 = new string[Class15.smethod_0(7)];
    strArray1[Class15.smethod_0(0)] = Class13.smethod_0(28962);
    strArray1[Class15.smethod_0(1)] = Class13.smethod_0(29173);
    this.string_0 = strArray1;
    string[] strArray2 = new string[Class15.smethod_0(7)];
    strArray2[Class15.smethod_0(0)] = Class13.smethod_0(29161);
    strArray2[Class15.smethod_0(1)] = Class13.smethod_0(28714);
    this.string_1 = strArray2;
    string[] strArray3 = new string[Class15.smethod_0(7)];
    strArray3[Class15.smethod_0(0)] = Class13.smethod_0(29445);
    strArray3[Class15.smethod_0(1)] = Class13.smethod_0(28714);
    this.string_2 = strArray3;
  }

  public void method_0()
  {
    if (this.list_0.Count <= Class15.smethod_0(0))
      return;
    for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
    {
      GClass5.GClass6 gclass6 = this.list_0[index];
      if (GClass126.smethod_18() - gclass6.lastTimeUse > (long) (gclass6.delay * Class15.smethod_0(15)))
      {
        gclass6.lastTimeUse = GClass126.smethod_18();
        GClass156.smethod_0().method_21((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (sbyte) -1, (short) gclass6.id);
        break;
      }
    }
  }

  public void imethod_1(string text, string to)
  {
    GClass23 gclass23 = GClass13.gclass13_0.method_31();
    if ((gclass23.tfChat.method_21() == null ? 1 : 0) == 0 && (!gclass23.tfChat.method_21().Equals(string.Empty) ? 0 : 1) == 0 && (!text.Equals(string.Empty) ? 0 : 1) == 0 && (text == null ? 0 : 1) != 0)
    {
      if ((!gclass23.strChat.Equals(this.string_0[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          int num = int.Parse(gclass23.tfChat.method_21());
          this.gclass6_0.delay = num;
          GClass73 gclass730 = GClass116.gclass73_0;
          string[] strArray = new string[Class15.smethod_0(3)];
          strArray[Class15.smethod_0(0)] = Class13.smethod_0(29681);
          strArray[Class15.smethod_0(1)] = this.gclass6_0.name;
          strArray[Class15.smethod_0(7)] = Class13.smethod_0(29668);
          strArray[Class15.smethod_0(5)] = num.ToString();
          strArray[Class15.smethod_0(2)] = Class13.smethod_0(29644);
          string s = string.Concat(strArray);
          int Type = Class15.smethod_0(0);
          gclass730.method_7(s, Type);
          this.list_0.Add(this.gclass6_0);
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29205), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else if ((!gclass23.strChat.Equals(this.string_2[Class15.smethod_0(0)]) ? 1 : 0) == 0)
      {
        try
        {
          this.gclass6_0.quantity = int.Parse(gclass23.tfChat.method_21());
          new Thread((ThreadStart) (() => this.method_6(this.gclass6_0))).Start();
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29387), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
      else
      {
        if ((!gclass23.strChat.Equals(this.string_1[Class15.smethod_0(0)]) ? 0 : 1) == 0)
          return;
        try
        {
          this.gclass6_0.quantity = int.Parse(gclass23.tfChat.method_21());
          new Thread((ThreadStart) (() => this.method_5(this.gclass6_0))).Start();
        }
        catch
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(29387), Class15.smethod_0(0));
        }
        GClass13.gclass13_0.method_12();
      }
    }
    else
      gclass23.isShow = Class15.smethod_0(0) != 0;
  }

  public void imethod_2()
  {
  }

  public void imethod_0(int idAction, object p)
  {
    switch (idAction - Class15.smethod_0(1))
    {
      case 0:
        this.method_3((GClass5.GClass6) p);
        break;
      case 1:
        this.method_2((int) p);
        break;
      case 2:
        this.method_4((GClass5.GClass6) p);
        break;
      case 3:
        this.list_1.Add(((GClass80) p).method_23());
        break;
      case 4:
        this.list_2.Add(((GClass80) p).method_23());
        break;
      case 5:
        this.list_1.Remove(((GClass80) p).method_23());
        break;
      case 6:
        this.list_2.Remove(((GClass80) p).method_23());
        break;
    }
  }

  public bool method_1(int itemID)
  {
    for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
    {
      if (this.list_0[index].id == itemID)
        return Class15.smethod_0(1) != 0;
    }
    return Class15.smethod_0(0) != 0;
  }

  private void method_2(int int_0)
  {
    for (int index = Class15.smethod_0(0); index < this.list_0.Count; index += Class15.smethod_0(1))
    {
      if (this.list_0[index].id == int_0)
      {
        this.list_0.RemoveAt(index);
        break;
      }
    }
  }

  private void method_3(GClass5.GClass6 gclass6_1)
  {
    this.gclass6_0 = gclass6_1;
    GClass13.gclass13_0.method_10((GInterface1) this, this.string_0[Class15.smethod_0(0)], this.string_0[Class15.smethod_0(1)], GClass184.int_8);
  }

  private void method_4(GClass5.GClass6 gclass6_1)
  {
    this.gclass6_0 = gclass6_1;
    GClass62.gclass141_0.isShow = Class15.smethod_0(0) != 0;
    if ((!gclass6_1.isSell ? 1 : 0) == 0)
      GClass13.gclass13_0.method_10((GInterface1) this, this.string_1[Class15.smethod_0(0)], this.string_1[Class15.smethod_0(1)], GClass184.int_8);
    else
      GClass13.gclass13_0.method_10((GInterface1) this, this.string_2[Class15.smethod_0(0)], this.string_2[Class15.smethod_0(1)], GClass184.int_8);
  }

  private void method_5(GClass5.GClass6 gclass6_1)
  {
    Thread.Sleep(Class15.smethod_0(21));
    short index = gclass6_1.index;
    while (gclass6_1.quantity > Class15.smethod_0(0))
    {
      if ((GClass20.smethod_1().arrItemBag[(int) index] == null ? 1 : 0) == 0 && ((GClass20.smethod_1().arrItemBag[(int) index] == null ? 1 : 0) != 0 || (int) GClass20.smethod_1().arrItemBag[(int) index].template.id == (int) (short) gclass6_1.id))
      {
        GClass156.smethod_0().method_55((sbyte) Class15.smethod_0(0), (sbyte) Class15.smethod_0(1), (short) GClass20.smethod_1().arrItemBag[(int) index].indexUI);
        Thread.Sleep(Class15.smethod_0(21));
        GClass156.smethod_0().method_55((sbyte) Class15.smethod_0(1), (sbyte) Class15.smethod_0(1), (short) GClass20.smethod_1().arrItemBag[(int) index].indexUI);
        Thread.Sleep(Class15.smethod_0(15));
        gclass6_1.quantity -= Class15.smethod_0(1);
        if (GClass20.smethod_1().xu > (long) Class15.smethod_0(22))
        {
          GClass116.gclass73_0.method_7(Class13.smethod_0(30512), Class15.smethod_0(0));
          return;
        }
      }
      else
      {
        GClass116.gclass73_0.method_7(Class13.smethod_0(29700), Class15.smethod_0(0));
        return;
      }
    }
    GClass116.gclass73_0.method_7(Class13.smethod_0(30512), Class15.smethod_0(0));
  }

  private void method_6(GClass5.GClass6 gclass6_1)
  {
    while (gclass6_1.quantity > Class15.smethod_0(0) && (!GClass116.smethod_6().method_16() ? 1 : 0) != 0)
    {
      GClass156.smethod_0().method_56((!gclass6_1.isGold ? 1 : 0) != 0 ? (sbyte) Class15.smethod_0(1) : (sbyte) Class15.smethod_0(0), gclass6_1.id, Class15.smethod_0(0));
      gclass6_1.quantity -= Class15.smethod_0(1);
      Thread.Sleep(Class15.smethod_0(15));
    }
    GClass116.gclass73_0.method_7(Class13.smethod_0(30476), Class15.smethod_0(0));
  }

  public void method_7(int type)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass5.Class0 class0 = new GClass5.Class0();
    // ISSUE: reference to a compiler-generated field
    class0.type = type;
    // ISSUE: reference to a compiler-generated field
    class0.\u003C\u003E4__this = this;
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(30470), Class15.smethod_0(0));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      new Thread(new ThreadStart(class0.method_0)).Start();
    }
  }

  private void method_8(List<string> list_3)
  {
    if ((!this.bool_0 ? 1 : 0) == 0)
    {
      GClass116.gclass73_0.method_7(Class13.smethod_0(30573), Class15.smethod_0(0));
    }
    else
    {
      this.bool_0 = Class15.smethod_0(1) != 0;
      for (int id = GClass20.smethod_1().arrItemBag.Length - Class15.smethod_0(1); id >= Class15.smethod_0(0); id -= Class15.smethod_0(1))
      {
        GClass80 gclass80 = GClass20.smethod_1().arrItemBag[id];
        if ((gclass80 == null ? 1 : 0) == 0 && (!list_3.Contains(gclass80.method_23()) ? 1 : 0) == 0)
        {
          GClass156.smethod_0().method_31((sbyte) Class15.smethod_0(2), (sbyte) id);
          Thread.Sleep(Class15.smethod_0(21));
        }
      }
      this.bool_0 = Class15.smethod_0(0) != 0;
    }
  }

  public List<string> method_9() => this.list_1;

  public List<string> method_10() => this.list_2;

  public class GClass6
  {
    public int id;
    public string name;
    public int quantity;
    public short index;
    public bool isGold;
    public bool isSell;
    public int delay;
    public long lastTimeUse;

    public GClass6()
    {
    }

    public GClass6(int id, string name)
    {
      this.id = id;
      this.name = name;
    }

    public GClass6(int id, short index, bool isGold, bool isSell)
    {
      this.id = id;
      this.isGold = isGold;
      this.index = index;
      this.isSell = isSell;
    }
  }
}
