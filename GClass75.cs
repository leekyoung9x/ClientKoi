// Decompiled with JetBrains decompiler
// Type: GClass75
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Runtime.CompilerServices;

public class GClass75
{
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 1;
  public sbyte rank;
  public sbyte amount;
  public sbyte max_amount;
  public sbyte typeMonster;
  public int id;
  public int no;
  public int idIcon;
  public string name;
  public string info;
  public sbyte level;
  public sbyte isUse;
  public GClass20 charInfo;
  public GClass100 mobInfo;
  public GClass83[] itemOption;
  private int[] int_0;
  private int int_1;
  private long long_0;
  public GClass43 cp;
  public GClass134 eff;

  public void method_0(
    int id,
    int no,
    int idIcon,
    sbyte rank,
    sbyte typeMonster,
    short templateId,
    string name,
    string info,
    GClass20 charInfo,
    GClass83[] itemOption)
  {
    this.id = id;
    this.no = no;
    this.idIcon = idIcon;
    this.rank = rank;
    this.typeMonster = typeMonster;
    if (templateId != (short) -1)
    {
      this.mobInfo = new GClass100();
      this.mobInfo.templateId = (int) templateId;
    }
    this.name = name;
    this.info = info;
    this.charInfo = charInfo;
    this.itemOption = itemOption;
    this.method_5();
  }

  public void method_1(sbyte amount, sbyte max_amount)
  {
    this.amount = amount;
    this.max_amount = max_amount;
  }

  public void method_2(sbyte level)
  {
    this.level = level;
    this.method_5();
  }

  public void method_3(sbyte isUse)
  {
    this.isUse = isUse;
    this.method_5();
  }

  public static GClass20 smethod_0(int head, int body, int leg, int bag) => new GClass20()
  {
    head = head,
    body = body,
    leg = leg,
    bag = bag
  };

  public static GClass75 smethod_1(GClass134 vec, int id)
  {
    if ((vec == null ? 1 : 0) == 0)
    {
      for (int index = Class15.smethod_0(0); index < vec.method_2(); index += Class15.smethod_0(1))
      {
        GClass75 gclass75 = (GClass75) vec.method_3(index);
        if ((gclass75 == null ? 1 : 0) == 0 && gclass75.id == id)
          return gclass75;
      }
    }
    return (GClass75) null;
  }

  public void method_4(GClass98 g, int x, int y)
  {
    this.int_1 += Class15.smethod_0(1);
    if (this.int_1 > this.int_0.Length - Class15.smethod_0(1))
      this.int_1 = Class15.smethod_0(0);
    if ((this.typeMonster == (sbyte) 0 ? 0 : 1) == 0)
    {
      if ((GClass100.gclass106_0[this.mobInfo.templateId] == null ? 1 : 0) != 0)
        return;
      if ((GClass100.gclass106_0[this.mobInfo.templateId].data == null ? 1 : 0) == 0)
      {
        GClass100.gclass106_0[this.mobInfo.templateId].data.method_9(g, this.int_0[this.int_1], x, y, Class15.smethod_0(0), Class15.smethod_0(0));
      }
      else
      {
        if (this.long_0 - GClass62.long_0 >= (long) Class15.smethod_0(0))
          return;
        this.long_0 = GClass62.long_0 + (long) Class15.smethod_0(225);
        this.mobInfo.method_1();
      }
    }
    else
    {
      if ((this.charInfo == null ? 1 : 0) != 0)
        return;
      this.charInfo.method_94(g, x, y, Class15.smethod_0(1), this.int_0[this.int_1], Class15.smethod_0(1) != 0);
    }
  }

  public void method_5()
  {
    this.cp = new GClass43();
    string empty = string.Empty;
    string chat = string.Empty + Class13.smethod_0(121335) + this.info + Class13.smethod_0(121305);
    if ((this.itemOption == null ? 1 : 0) == 0)
    {
      int num1 = Class15.smethod_0(0);
      bool flag1 = Class15.smethod_0(1) != 0;
      while ((!flag1 ? 0 : 1) != 0)
      {
        int num2 = Class15.smethod_0(0);
        for (int index = Class15.smethod_0(0); index < this.itemOption.Length; index += Class15.smethod_0(1))
        {
          if ((!this.itemOption[index].method_0().Equals(string.Empty) ? 0 : 1) == 0 && num1 == (int) this.itemOption[index].activeCard)
          {
            num2 += Class15.smethod_0(1);
            break;
          }
        }
        if ((num2 == 0 ? 0 : 1) != 0)
        {
          if ((num1 == 0 ? 0 : 1) == 0)
          {
            chat = chat + Class13.smethod_0(121301) + GClass109.string_4 + Class13.smethod_0(120894);
          }
          else
          {
            string str = chat;
            string[] strArray = new string[Class15.smethod_0(37)];
            strArray[Class15.smethod_0(0)] = str;
            strArray[Class15.smethod_0(1)] = Class13.smethod_0(121301);
            strArray[Class15.smethod_0(7)] = GClass109.string_3;
            strArray[Class15.smethod_0(5)] = Class13.smethod_0(120891);
            strArray[Class15.smethod_0(2)] = num1.ToString();
            strArray[Class15.smethod_0(3)] = Class13.smethod_0(120894);
            chat = string.Concat(strArray);
          }
          for (int index = Class15.smethod_0(0); index < this.itemOption.Length; index += Class15.smethod_0(1))
          {
            string str1 = this.itemOption[index].method_0();
            if ((!str1.Equals(string.Empty) ? 0 : 1) == 0 && num1 == (int) this.itemOption[index].activeCard)
            {
              string str2 = Class13.smethod_0(120886);
              if ((this.level == (sbyte) 0 ? 0 : 1) == 0)
                str2 = Class13.smethod_0(120884);
              else if ((this.itemOption[index].activeCard == (sbyte) 0 ? 1 : 0) == 0)
              {
                if ((this.isUse == (sbyte) 0 ? 0 : 1) == 0)
                  str2 = Class13.smethod_0(120884);
                else if ((int) this.level < (int) this.itemOption[index].activeCard)
                  str2 = Class13.smethod_0(120884);
              }
              string str3 = chat;
              string[] strArray = new string[Class15.smethod_0(3)];
              strArray[Class15.smethod_0(0)] = str3;
              strArray[Class15.smethod_0(1)] = Class13.smethod_0(120880);
              strArray[Class15.smethod_0(7)] = str2;
              strArray[Class15.smethod_0(5)] = Class13.smethod_0(120875);
              strArray[Class15.smethod_0(2)] = str1;
              chat = string.Concat(strArray);
            }
          }
          if ((num2 == 0 ? 1 : 0) == 0)
            num1 += Class15.smethod_0(1);
        }
        else
        {
          bool flag2 = Class15.smethod_0(0) != 0;
          break;
        }
      }
    }
    this.method_6(this.cp, chat);
  }

  public void method_6(GClass43 cp, string chat)
  {
    cp.sayWidth = GClass119.int_14;
    cp.cx = GClass119.int_12;
    cp.says = GClass97.gclass97_11.method_15(chat, cp.sayWidth - Class15.smethod_0(88));
    cp.delay = Class15.smethod_0(261);
    cp.c = (GClass21) null;
    cp.ch = cp.says.Length * Class15.smethod_0(66);
    cp.cy = GClass119.int_13;
    cp.strY = Class15.smethod_0(31);
    cp.lim = cp.ch - GClass119.int_16;
    if (cp.lim >= Class15.smethod_0(0))
      return;
    cp.lim = Class15.smethod_0(0);
  }

  public void method_7()
  {
    if ((int) this.amount != (int) this.max_amount || (this.eff.method_2() == 0 ? 0 : 1) != 0)
      return;
    int num = GClass151.smethod_18(Class15.smethod_0(1), Class15.smethod_0(3));
    for (int index = Class15.smethod_0(0); index < num; index += Class15.smethod_0(1))
      this.eff.method_0((object) new GClass150()
      {
        x = GClass151.smethod_18(Class15.smethod_0(3), Class15.smethod_0(46)),
        y = GClass151.smethod_18(Class15.smethod_0(3), Class15.smethod_0(46)),
        v = (index * GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(88))),
        w = Class15.smethod_0(0),
        anchor = -1
      });
  }

  public void method_8(GClass98 g, int x, int y)
  {
    this.method_7();
    for (int index = Class15.smethod_0(0); index < this.eff.method_2(); index += Class15.smethod_0(1))
    {
      GClass150 gclass150 = (GClass150) this.eff.method_3(index);
      if ((gclass150 == null ? 1 : 0) == 0)
      {
        if (gclass150.w < gclass150.v)
          gclass150.w += Class15.smethod_0(1);
        if (gclass150.w >= gclass150.v)
        {
          gclass150.anchor = GClass62.int_8 / Class15.smethod_0(5) % (GClass119.gclass60_2.nFrame + Class15.smethod_0(1));
          if (gclass150.anchor >= GClass119.gclass60_2.nFrame)
          {
            this.eff.method_7(index);
            index -= Class15.smethod_0(1);
          }
          else
            GClass119.gclass60_2.method_0(gclass150.anchor, x + gclass150.x, y + gclass150.y, Class15.smethod_0(0), Class15.smethod_0(5), g);
        }
      }
    }
  }

  public GClass75()
  {
    byte[] byte_0 = new byte[Class15.smethod_0(11)];
    // ISSUE: field reference
    RuntimeHelpers.InitializeArray((Array) byte_0, __fieldref (Class12.taZaMaITCHJW));
    this.int_0 = (int[]) Class15.smethod_4(byte_0);
    this.eff = new GClass134(string.Empty);
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }
}
