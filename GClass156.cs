// Decompiled with JetBrains decompiler
// Type: GClass156
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Threading;

public class GClass156
{
  private GInterface5 ginterface5_0 = (GInterface5) GClass157.smethod_0();
  protected static GClass156 gclass156_0;
  public static long long_0;
  public static long long_1;
  public static long long_2;
  public static long long_3;
  public int demGui;
  public static bool bool_0;
  private bool bool_1;

  public static GClass156 smethod_0()
  {
    if ((GClass156.gclass156_0 == null ? 0 : 1) == 0)
      GClass156.gclass156_0 = new GClass156();
    return GClass156.gclass156_0;
  }

  public void method_0(int itemID)
  {
    if ((!this.bool_1 ? 1 : 0) == 0)
      return;
    this.bool_1 = Class15.smethod_0(1) != 0;
    Thread.Sleep(Class15.smethod_0(16));
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
    {
      GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
      if ((gclass80 == null ? 1 : 0) == 0 && (int) gclass80.template.id == itemID)
      {
        sbyte id = (sbyte) index;
        this.bool_1 = Class15.smethod_0(0) != 0;
        this.method_31((sbyte) Class15.smethod_0(2), id);
        break;
      }
    }
  }

  public void method_1(int id)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass156.Class4 class4 = new GClass156.Class4();
    // ISSUE: reference to a compiler-generated field
    class4.\u003C\u003E4__this = this;
    if ((GClass20.smethod_1().arrItemBody[Class15.smethod_0(3)] == null ? 1 : 0) != 0 || (GClass20.smethod_1().arrItemBody[Class15.smethod_0(3)] == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().arrItemBody[Class15.smethod_0(3)].template.id != Class15.smethod_0(563))
    {
      // ISSUE: reference to a compiler-generated field
      class4.itemID = Class15.smethod_0(0);
      if ((GClass20.smethod_1().arrItemBody[Class15.smethod_0(3)] == null ? 1 : 0) == 0 && (!this.bool_1 ? 0 : 1) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        class4.itemID = (int) GClass20.smethod_1().arrItemBody[Class15.smethod_0(3)].template.id;
      }
      for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().arrItemBag.Length; index += Class15.smethod_0(1))
      {
        GClass80 gclass80 = GClass20.smethod_1().arrItemBag[index];
        if ((gclass80 == null ? 1 : 0) == 0 && (int) gclass80.template.id >= Class15.smethod_0(564) && (int) gclass80.template.id <= Class15.smethod_0(565))
        {
          sbyte id1 = (sbyte) index;
          this.method_31((sbyte) Class15.smethod_0(2), id1);
          // ISSUE: reference to a compiler-generated field
          if ((class4.itemID == 0 ? 1 : 0) == 0 && (!this.bool_1 ? 0 : 1) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            ThreadStart start = class4.\u003C\u003E9__0;
            if ((start == null ? 0 : 1) == 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              start = class4.\u003C\u003E9__0 = new ThreadStart(class4.method_0);
            }
            new Thread(start).Start();
          }
          GClass116.gclass73_0.method_7(Class13.smethod_0(149819), Class15.smethod_0(0));
          break;
        }
      }
    }
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(124));
      message.method_2().method_11(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_2()
  {
    if ((GClass126.string_2 == null ? 0 : 1) == 0)
      return;
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(379));
      message.method_2().method_16(GClass126.string_2);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_3(
    string day,
    string month,
    string year,
    string address,
    string cmnd,
    string dayCmnd,
    string noiCapCmnd,
    string sdt,
    string name)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(108));
      message.method_2().method_16(day);
      message.method_2().method_16(month);
      message.method_2().method_16(year);
      message.method_2().method_16(address);
      message.method_2().method_16(cmnd);
      message.method_2().method_16(dayCmnd);
      message.method_2().method_16(noiCapCmnd);
      message.method_2().method_16(sdt);
      message.method_2().method_16(name);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_4()
  {
    if ((GClass126.string_2 == null ? 0 : 1) == 0)
      return;
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(379));
      message.method_2().method_16(GClass126.string_2);
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_5(sbyte status)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(566));
      message.method_2().method_2(status);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_6(sbyte action, GClass134 id)
  {
    GClass151.smethod_7(Class13.smethod_0(149853));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(567));
      message.method_2().method_2(action);
      if ((int) action == Class15.smethod_0(1))
      {
        message.method_2().method_3(id.method_2());
        for (int index = Class15.smethod_0(0); index < id.method_2(); index += Class15.smethod_0(1))
        {
          message.method_2().method_3(((GClass80) id.method_3(index)).indexUI);
          GClass151.smethod_7(Class13.smethod_0(149832) + ((GClass80) id.method_3(index)).indexUI.ToString());
        }
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_7(sbyte action, int playerID, sbyte index, int num)
  {
    GClass151.smethod_10(Class13.smethod_0(149932) + action.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(568));
      message.method_2().method_2(action);
      if ((action == (sbyte) 0 ? 1 : 0) != 0 || (int) action == Class15.smethod_0(1))
      {
        GClass151.smethod_10(Class13.smethod_0(149912) + playerID.ToString());
        message.method_2().method_11(playerID);
      }
      if ((int) action == Class15.smethod_0(7))
      {
        GClass151.smethod_10(Class13.smethod_0(149892) + index.ToString() + Class13.smethod_0(150004) + num.ToString());
        message.method_2().method_2(index);
        message.method_2().method_11(num);
      }
      if ((int) action == Class15.smethod_0(2))
      {
        GClass151.smethod_10(Class13.smethod_0(149997) + index.ToString());
        message.method_2().method_2(index);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_8(GClass184[] t)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(149978));
      message = new GClass96((sbyte) Class15.smethod_0(569));
      GClass151.smethod_7(Class13.smethod_0(149966) + t.Length.ToString());
      message.method_2().method_3(t.Length);
      for (int index = Class15.smethod_0(0); index < t.Length; index += Class15.smethod_0(1))
        message.method_2().method_16(t[index].method_21());
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_9(sbyte index)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(265));
      message.method_2().method_2(index);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_10(short x, short y)
  {
    GClass151.smethod_7(Class13.smethod_0(149542) + x.ToString() + Class13.smethod_0(149528) + y.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96(Class15.smethod_0(0));
      message.method_2().method_8(x);
      message.method_2().method_8(y);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_11()
  {
    GClass151.smethod_7(Class13.smethod_0(149523));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96(Class15.smethod_0(1));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_12()
  {
  }

  public void method_13(char ch)
  {
    GClass151.smethod_7(Class13.smethod_0(150077) + ch.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(570));
      message.method_2().method_4(ch);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_14(sbyte action, int playerId)
  {
    GClass151.smethod_7(Class13.smethod_0(150057));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(571));
      message.method_2().method_2(action);
      if (playerId != -1)
        message.method_2().method_11(playerId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_15(int index)
  {
    GClass151.smethod_7(Class13.smethod_0(150046));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(572));
      message.method_2().method_3(index);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_16(int playerID)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(573));
      message.method_2().method_11(playerID);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_17(sbyte id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(574));
      message.method_2().method_2(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_18(sbyte status)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(179));
      message.method_2().method_2(status);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_19(int id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(575));
      message.method_2().method_11(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_20(int type, string text, int clanID)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(576));
      message.method_2().method_3(type);
      if ((type == 0 ? 0 : 1) == 0)
        message.method_2().method_16(text);
      if (type == Class15.smethod_0(7))
        message.method_2().method_11(clanID);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_21(sbyte type, sbyte where, sbyte index, short template)
  {
    GClass33.smethod_0(Class13.smethod_0(150844) + type.ToString());
    if (GClass20.smethod_1().statusMe == Class15.smethod_0(49))
      return;
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(577));
      message.method_2().method_2(type);
      message.method_2().method_2(where);
      message.method_2().method_2(index);
      if (index == (sbyte) -1)
        message.method_2().method_8(template);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_22(int id, sbyte action)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(578));
      message.method_2().method_11(id);
      message.method_2().method_2(action);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_23(int id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(141));
      message.method_2().method_11(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_24(string text)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(579));
      message.method_2().method_16(text);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_25(short id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(580));
      message.method_2().method_8(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_26(int id, sbyte role)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(581));
      message.method_2().method_11(id);
      message.method_2().method_2(role);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_27()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(582));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_28(sbyte action, int playerID, int clanID, int code)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(583));
      message.method_2().method_2(action);
      if ((action == (sbyte) 0 ? 0 : 1) == 0)
        message.method_2().method_11(playerID);
      if ((int) action == Class15.smethod_0(1) || (int) action == Class15.smethod_0(7))
      {
        message.method_2().method_11(clanID);
        message.method_2().method_11(code);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_29(sbyte action, sbyte id, string text)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(584));
      message.method_2().method_2(action);
      if ((int) action == Class15.smethod_0(7) || (int) action == Class15.smethod_0(2))
      {
        message.method_2().method_2(id);
        message.method_2().method_16(text);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_30(sbyte gender)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(585));
      message.method_2().method_2(gender);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_31(sbyte type, sbyte id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(268));
      message.method_2().method_2(type);
      message.method_2().method_2(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_32(int npcTemplateId, int menuId, int optionId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(54));
      message.method_2().method_3(npcTemplateId);
      message.method_2().method_3(menuId);
      if (optionId >= Class15.smethod_0(0))
        message.method_2().method_3(optionId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public GClass96 method_33(sbyte command)
  {
    GClass96 gclass96 = new GClass96((sbyte) Class15.smethod_0(586));
    gclass96.method_2().method_2(command);
    return gclass96;
  }

  public GClass96 method_34(sbyte command)
  {
    GClass96 gclass96 = new GClass96((sbyte) Class15.smethod_0(587));
    gclass96.method_2().method_2(command);
    return gclass96;
  }

  public static GClass96 smethod_1(sbyte command)
  {
    GClass96 gclass96 = new GClass96((sbyte) Class15.smethod_0(217));
    gclass96.method_2().method_2(command);
    return gclass96;
  }

  public void method_35()
  {
    if (GClass152.smethod_8(Class13.smethod_0(150795)) != -1)
      Main.int_2 = GClass152.smethod_8(Class13.smethod_0(150795));
    try
    {
      GClass96 message = this.method_33((sbyte) Class15.smethod_0(7));
      message.method_2().method_3(Main.int_2);
      message.method_2().method_3(GClass98.int_8);
      message.method_2().method_13(Class15.smethod_0(0) != 0);
      message.method_2().method_11(GClass62.int_10);
      message.method_2().method_11(GClass62.int_11);
      message.method_2().method_13(GClass184.bool_0);
      message.method_2().method_13(GClass62.bool_5);
      message.method_2().method_16(GClass62.smethod_0() + Class13.smethod_0(150899) + GClass63.string_2);
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
  }

  public void method_36()
  {
    GClass151.smethod_7(Class13.smethod_0(150870));
    if (GClass152.smethod_8(Class13.smethod_0(150854)) != -1)
      GClass126.int_0 = GClass152.smethod_8(Class13.smethod_0(150854));
    try
    {
      GClass151.smethod_7(Class13.smethod_0(150959));
      GClass96 message = this.method_33((sbyte) Class15.smethod_0(7));
      message.method_2().method_3(GClass126.int_0);
      message.method_2().method_3(GClass98.int_8);
      GClass151.smethod_7(Class13.smethod_0(150703) + GClass98.int_8.ToString());
      message.method_2().method_13(Class15.smethod_0(0) != 0);
      message.method_2().method_11(GClass62.int_10);
      message.method_2().method_11(GClass62.int_11);
      message.method_2().method_13(GClass184.bool_0);
      message.method_2().method_13(GClass62.bool_5);
      message.method_2().method_16(GClass62.smethod_0() + Class13.smethod_0(150739) + GClass63.string_2);
      this.ginterface5_0 = (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
      message.method_4();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
  }

  public void method_37()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(588));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      GClass156.long_0 = GClass126.smethod_18();
      message.method_4();
    }
  }

  public void method_38()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(589));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      GClass156.long_1 = GClass126.smethod_18();
      message.method_4();
    }
  }

  public void method_39(string username, string pass, string version, sbyte type)
  {
    try
    {
      GClass96 message = this.method_33((sbyte) Class15.smethod_0(0));
      if ((!(GClass13.gclass13_0.method_46() != string.Empty) ? 1 : 0) == 0)
      {
        message.method_2().method_16(GClass13.gclass13_0.method_46());
        message.method_2().method_16(GClass13.gclass13_0.method_47());
      }
      else
      {
        message.method_2().method_16(username);
        message.method_2().method_16(pass);
      }
      message.method_2().method_16(version);
      message.method_2().method_2(type);
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
  }

  public void method_40(
    string username,
    string pass,
    string usernameAo,
    string passAo,
    string version)
  {
    try
    {
      GClass96 message = this.method_33((sbyte) Class15.smethod_0(1));
      message.method_2().method_16(username);
      message.method_2().method_16(pass);
      if ((usernameAo == null ? 1 : 0) == 0 && (!usernameAo.Equals(string.Empty) ? 0 : 1) == 0)
      {
        message.method_2().method_16(usernameAo);
        message.method_2().method_16(Class13.smethod_0(151351));
      }
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
  }

  public void method_41()
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(453));
    this.ginterface5_0.imethod_3(message);
    message.method_4();
  }

  public void method_42(sbyte type)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(590));
    try
    {
      message.method_2().method_2(type);
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
    }
  }

  public void method_43(int zoneId, int indexUI)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(27));
    try
    {
      message.method_2().method_3(zoneId);
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
    }
  }

  public void method_44(int second)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(591));
    try
    {
      message.method_2().method_11(second);
      this.ginterface5_0.imethod_3(message);
      message.method_4();
    }
    catch (Exception ex)
    {
    }
  }

  public void method_45()
  {
    int num1 = GClass20.smethod_1().cx - GClass20.smethod_1().cxSend;
    int num2 = GClass20.smethod_1().cy - GClass20.smethod_1().cySend;
    if ((!GClass20.bool_2 ? 0 : 1) != 0 || (num1 == 0 ? 0 : 1) == 0 && (num2 == 0 ? 1 : 0) != 0 || (!GClass32.bool_5 ? 0 : 1) != 0 || (!GClass20.smethod_1().isTeleport ? 0 : 1) != 0 || GClass20.smethod_1().cy <= Class15.smethod_0(0))
      return;
    if ((!GClass20.smethod_1().telePortSkill ? 1 : 0) == 0)
      return;
    try
    {
      GClass96 message = new GClass96((sbyte) Class15.smethod_0(252));
      GClass20.smethod_1().cxSend = GClass20.smethod_1().cx;
      GClass20.smethod_1().cySend = GClass20.smethod_1().cy;
      GClass20.smethod_1().cdirSend = GClass20.smethod_1().cdir;
      GClass20.smethod_1().cactFirst = GClass20.smethod_1().statusMe;
      if ((GClass185.smethod_25(GClass20.smethod_1().cx / (int) GClass185.sbyte_0, GClass20.smethod_1().cy / (int) GClass185.sbyte_0) == 0 ? 0 : 1) == 0)
      {
        message.method_2().method_2((sbyte) Class15.smethod_0(1));
        if ((!GClass20.smethod_1().canFly ? 1 : 0) == 0)
        {
          if ((!GClass20.smethod_1().isHaveMount ? 0 : 1) == 0)
            GClass20.smethod_1().cMP -= GClass20.smethod_1().cMPGoc / Class15.smethod_0(21) * ((int) GClass20.smethod_1().isMonkey != Class15.smethod_0(1) ? Class15.smethod_0(1) : Class15.smethod_0(7));
          if (GClass20.smethod_1().cMP < Class15.smethod_0(0))
            GClass20.smethod_1().cMP = Class15.smethod_0(0);
          GClass116.smethod_6().isInjureMp = Class15.smethod_0(1) != 0;
          GClass116.smethod_6().twMp = Class15.smethod_0(0);
        }
      }
      else
        message.method_2().method_2((sbyte) Class15.smethod_0(0));
      message.method_2().method_9(GClass20.smethod_1().cx);
      if ((num2 == 0 ? 1 : 0) == 0)
        message.method_2().method_9(GClass20.smethod_1().cy);
      this.ginterface5_0.imethod_3(message);
      GClass116.int_48 += Class15.smethod_0(1);
      message.method_4();
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(144272) + ex.ToString());
    }
  }

  public void method_46(string charname)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(587));
    try
    {
      message.method_2().method_2((sbyte) Class15.smethod_0(1));
      message.method_2().method_16(charname);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    this.ginterface5_0.imethod_3(message);
  }

  public void method_47(sbyte sub, int value)
  {
  }

  public void method_48(string name, int gender, int hair)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(587));
    try
    {
      message.method_2().method_2((sbyte) Class15.smethod_0(7));
      message.method_2().method_16(name);
      message.method_2().method_3(gender);
      message.method_2().method_3(hair);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    this.ginterface5_0.imethod_3(message);
  }

  public void method_49(int modTemplateId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(67));
      message.method_2().method_3(modTemplateId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_50(int npcTemplateId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(66));
      message.method_2().method_3(npcTemplateId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_51(int skillId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(45));
      message.method_2().method_9(skillId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_52(int typeUI, int indexUI)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(95));
      message.method_2().method_3(typeUI);
      message.method_2().method_3(indexUI);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_53(int charId, int indexUI)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(23));
      message.method_2().method_11(charId);
      message.method_2().method_3(indexUI);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_54(int skillTemplateId, int point)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(186));
      message.method_2().method_9(skillTemplateId);
      message.method_2().method_3(point);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_55(sbyte action, sbyte type, short id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(38));
      message.method_2().method_2(action);
      message.method_2().method_2(type);
      message.method_2().method_8(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_56(sbyte type, int id, int quantity)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(37));
      message.method_2().method_2(type);
      message.method_2().method_9(id);
      if (quantity > Class15.smethod_0(1))
        message.method_2().method_9(quantity);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_57(int skillTemplateId)
  {
    GClass33.smethod_0(GClass20.smethod_1().cName + Class13.smethod_0(144702) + skillTemplateId.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(117));
      message.method_2().method_9(skillTemplateId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_58(short id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(592));
      message.method_2().method_8(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_59()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(36));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_60(short npcID, sbyte select)
  {
    GClass151.smethod_7(Class13.smethod_0(145942) + select.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(120));
      message.method_2().method_8(npcID);
      message.method_2().method_2(select);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_61(int npcId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(48));
      message.method_2().method_9(npcId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_62(int npcId, int menuId, int optionId)
  {
    GClass33.smethod_0(Class13.smethod_0(146016) + menuId.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(28));
      message.method_2().method_3(npcId);
      message.method_2().method_3(menuId);
      message.method_2().method_3(optionId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_63(short menuId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(33));
      message.method_2().method_8(menuId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_64(short menuId, string str)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(119));
      message.method_2().method_8(menuId);
      message.method_2().method_16(str);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_65(int typeUI)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(28));
      message.method_2().method_3(typeUI);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_66()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(65));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_67(int coinOut)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(27));
      message.method_2().method_11(coinOut);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_68(GClass80 item, GClass80[] items, bool isGold)
  {
    GClass62.gclass39_0.method_0();
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(49));
      message.method_2().method_13(isGold);
      message.method_2().method_3(item.indexUI);
      for (int index = Class15.smethod_0(0); index < items.Length; index += Class15.smethod_0(1))
      {
        if ((items[index] == null ? 1 : 0) == 0)
          message.method_2().method_3(items[index].indexUI);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_69(GClass80[] items)
  {
    GClass62.gclass39_0.method_0();
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(47));
      for (int index = Class15.smethod_0(0); index < items.Length; index += Class15.smethod_0(1))
      {
        if ((items[index] == null ? 1 : 0) == 0)
          message.method_2().method_3(items[index].indexUI);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_70(int playerMapId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(52));
      message.method_2().method_11(playerMapId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_71()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(32));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_72()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(53));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_73(int coin, GClass80[] items)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(34));
      message.method_2().method_11(coin);
      int num = Class15.smethod_0(0);
      for (int index = Class15.smethod_0(0); index < items.Length; index += Class15.smethod_0(1))
      {
        if ((items[index] == null ? 1 : 0) == 0)
          num += Class15.smethod_0(1);
      }
      message.method_2().method_3(num);
      for (int index = Class15.smethod_0(0); index < items.Length; index += Class15.smethod_0(1))
      {
        if ((items[index] == null ? 1 : 0) == 0)
          message.method_2().method_3(items[index].indexUI);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_74(GClass134 vMob, GClass134 vChar, int type)
  {
    try
    {
      GClass96 message = (GClass96) null;
      if ((type == 0 ? 0 : 1) == 0)
        return;
      if (vMob.method_2() > Class15.smethod_0(0) && vChar.method_2() > Class15.smethod_0(0))
      {
        if (type != Class15.smethod_0(1))
        {
          if (type == Class15.smethod_0(7))
            message = new GClass96((sbyte) Class15.smethod_0(131));
        }
        else
          message = new GClass96((sbyte) Class15.smethod_0(200));
        message.method_2().method_3(vMob.method_2());
        for (int index = Class15.smethod_0(0); index < vMob.method_2(); index += Class15.smethod_0(1))
        {
          GClass100 gclass100 = (GClass100) vMob.method_3(index);
          message.method_2().method_3(gclass100.mobId);
        }
        for (int index = Class15.smethod_0(0); index < vChar.method_2(); index += Class15.smethod_0(1))
        {
          GClass20 gclass20 = (GClass20) vChar.method_3(index);
          if ((gclass20 == null ? 1 : 0) == 0)
            message.method_2().method_11(gclass20.charID);
          else
            message.method_2().method_11(-1);
        }
      }
      else if (vMob.method_2() > Class15.smethod_0(0))
      {
        message = new GClass96((sbyte) Class15.smethod_0(271));
        for (int index = Class15.smethod_0(0); index < vMob.method_2(); index += Class15.smethod_0(1))
        {
          GClass100 gclass100 = (GClass100) vMob.method_3(index);
          if ((!gclass100.isMobMe ? 0 : 1) == 0)
          {
            message.method_2().method_3(gclass100.mobId);
          }
          else
          {
            message.method_2().method_2((sbyte) -1);
            message.method_2().method_11(gclass100.mobId);
          }
        }
      }
      else if (vChar.method_2() > Class15.smethod_0(0))
      {
        message = new GClass96((sbyte) Class15.smethod_0(593));
        for (int index = Class15.smethod_0(0); index < vChar.method_2(); index += Class15.smethod_0(1))
        {
          GClass20 gclass20 = (GClass20) vChar.method_3(index);
          message.method_2().method_11(gclass20.charID);
        }
      }
      if ((message == null ? 1 : 0) != 0)
        return;
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
  }

  public void method_75(int itemMapId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(188));
      message.method_2().method_9(itemMapId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_76(int index)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(253));
      message.method_2().method_3(index);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_77()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(206));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_78()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0((int) byte.MaxValue));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_79(string text)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(74));
      message.method_2().method_16(text);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_80()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(594));
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_81()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(37));
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_82()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(38));
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_83()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(88));
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_84()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(47));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_85(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(86));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_86(string name)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(69));
      message.method_2().method_16(name);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_87(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(177));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_88(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(216));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_89(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(211));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_90(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(106));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_91(string name)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(62));
      message.method_2().method_16(name);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_92(sbyte action, sbyte type, int playerId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(595));
      message.method_2().method_2(action);
      message.method_2().method_2(type);
      message.method_2().method_11(playerId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_93(int maptemplateId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(31));
      message.method_2().method_3(maptemplateId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_94()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(61));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_95(GClass134 chars)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(124));
      message.method_2().method_3(chars.method_2());
      for (int index = Class15.smethod_0(0); index < chars.method_2(); index += Class15.smethod_0(1))
      {
        GClass20 gclass20 = (GClass20) chars.method_3(index);
        message.method_2().method_11(gclass20.charID);
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_96(string str)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(10));
      message.method_2().method_16(str);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_97(string str)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(186));
      message.method_2().method_16(str);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_98(string text, int id)
  {
    GClass151.smethod_7(Class13.smethod_0(146130) + text);
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(596));
      message.method_2().method_11(id);
      message.method_2().method_16(text);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_99(string text)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(597));
      message.method_2().method_16(text);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_100(string to, string text)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(82));
      message.method_2().method_16(to);
      message.method_2().method_16(text);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_101(string NAP, string PIN)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(10));
      message.method_2().method_16(NAP);
      message.method_2().method_16(PIN);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_102(string key, sbyte[] data)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(4));
      message.method_2().method_16(key);
      message.method_2().method_11(data.Length);
      message.method_2().method_19(data);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_103(string key)
  {
    GClass33.smethod_0(Class13.smethod_0(146729));
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(293));
      message.method_2().method_16(key);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_104()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(186));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_105(string name, int id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(124));
      message.method_2().method_11(id);
      message.method_2().method_16(name);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_106(int id)
  {
    GClass62.smethod_4();
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(146693) + id.ToString());
      message = new GClass96((sbyte) Class15.smethod_0(598));
      message.method_2().method_11(id);
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_107(int index1, int index2, int index3)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(48));
      message.method_2().method_3(index1);
      message.method_2().method_3(index2);
      message.method_2().method_3(index3);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_108(string name)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(117));
      message.method_2().method_16(name);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_109(int indexItem, int numSplit)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(54));
      message.method_2().method_3(indexItem);
      message.method_2().method_11(numSplit);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_110(int pass)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(52));
      message.method_2().method_11(pass);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_111(int pass)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(55));
      message.method_2().method_11(pass);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_112(int passOld, int passNew)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(34));
      message.method_2().method_11(passOld);
      message.method_2().method_11(passNew);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_113(int pass2)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = this.method_34((sbyte) Class15.smethod_0(53));
      message.method_2().method_11(pass2);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_114(short id)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(599));
      message.method_2().method_8(id);
      this.ginterface5_0 = (!GClass159.smethod_0().imethod_0() ? 1 : 0) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0 ? (GInterface5) GClass157.smethod_0() : (GInterface5) GClass159.smethod_0();
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_115()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(203));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_116()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(205));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_117()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(310));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_118(sbyte action)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(600));
      message.method_2().method_2(action);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_119(sbyte ID)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(601));
      message.method_2().method_2(ID);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_120(sbyte action)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(602));
      message.method_2().method_2(action);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_121(sbyte action)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(603));
      message.method_2().method_2(action);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_122(string user)
  {
    GClass151.smethod_7(Class13.smethod_0(146929));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(604));
      message.method_2().method_16(user);
      message.method_2().method_3(Class15.smethod_0(1));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_123(sbyte action)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(590));
      message.method_2().method_2(action);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_124(int typePotential, int num)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = GClass156.smethod_1((sbyte) Class15.smethod_0(10));
      message.method_2().method_3(typePotential);
      message.method_2().method_9(num);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_125(sbyte action, GClass134 vResourceIndex)
  {
    GClass151.smethod_7(Class13.smethod_0(146949) + action.ToString());
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(605));
      message.method_2().method_2(action);
      if ((int) action == Class15.smethod_0(7) && (vResourceIndex == null ? 1 : 0) == 0)
      {
        message.method_2().method_9(vResourceIndex.method_2());
        for (int index = Class15.smethod_0(0); index < vResourceIndex.method_2(); index += Class15.smethod_0(1))
          message.method_2().method_8(short.Parse((string) vResourceIndex.method_3(index)));
      }
      if ((!GClass159.smethod_0().imethod_0() ? 1 : 0) == 0 && (!GClass159.bool_2 ? 0 : 1) == 0)
      {
        this.ginterface5_0 = (GInterface5) GClass159.smethod_0();
      }
      else
      {
        GClass156.bool_0 = Class15.smethod_0(1) != 0;
        this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
      }
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(ex.Message + ex.StackTrace);
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_126(int selected)
  {
    GClass151.smethod_7(Class13.smethod_0(147114));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(606));
      message.method_2().method_3(selected);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_127()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(607));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_128(string topName, sbyte selected)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(608));
      message.method_2().method_16(topName);
      message.method_2().method_2(selected);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_129(sbyte b, int charID)
  {
    GClass96 message = (GClass96) null;
    GClass151.smethod_7(Class13.smethod_0(147089));
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(609));
      message.method_2().method_2(b);
      if ((int) b == Class15.smethod_0(1) || (int) b == Class15.smethod_0(7))
        message.method_2().method_11(charID);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_130(sbyte action, int itemId, sbyte moneyType, int money, int quaintly)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(140273) + action.ToString());
      message = new GClass96((sbyte) Class15.smethod_0(143));
      message.method_2().method_2(action);
      if ((action == (sbyte) 0 ? 0 : 1) == 0)
      {
        message.method_2().method_9(itemId);
        message.method_2().method_2(moneyType);
        message.method_2().method_11(money);
        message.method_2().method_11(quaintly);
      }
      if ((int) action == Class15.smethod_0(1) || (int) action == Class15.smethod_0(7))
        message.method_2().method_9(itemId);
      if ((int) action == Class15.smethod_0(5))
      {
        message.method_2().method_9(itemId);
        message.method_2().method_2(moneyType);
        message.method_2().method_11(money);
      }
      if ((int) action == Class15.smethod_0(2))
      {
        message.method_2().method_2(moneyType);
        message.method_2().method_3(money);
        GClass151.smethod_7(Class13.smethod_0(139860) + moneyType.ToString() + Class13.smethod_0(139847) + money.ToString());
      }
      if ((int) action == Class15.smethod_0(3))
        message.method_2().method_9(itemId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_131(sbyte action, sbyte flagType)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(610));
      message.method_2().method_2(action);
      GClass151.smethod_7(Class13.smethod_0(139967) + action.ToString() + Class13.smethod_0(139939) + flagType.ToString());
      if ((action == (sbyte) 0 ? 1 : 0) == 0)
        message.method_2().method_2(flagType);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_132(int pass)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(139935) + pass.ToString());
      message = new GClass96((sbyte) Class15.smethod_0(611));
      message.method_2().method_11(pass);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_133(sbyte status)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(612));
      message.method_2().method_2(status);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_134()
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(140028));
      message = new GClass96((sbyte) Class15.smethod_0(613));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_135(sbyte type)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(140001));
      message = new GClass96((sbyte) Class15.smethod_0(614));
      message.method_2().method_2(type);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_136(GClass134 vID)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(139993) + vID.method_2().ToString());
      message = new GClass96((sbyte) Class15.smethod_0(615));
      message.method_2().method_9(vID.method_2());
      if (vID.method_2() > Class15.smethod_0(0))
      {
        for (int index = Class15.smethod_0(0); index < vID.method_2(); index += Class15.smethod_0(1))
        {
          GClass151.smethod_7(Class13.smethod_0(139973) + ((Class8) vID.method_3(index)).id);
          message.method_2().method_16(((Class8) vID.method_3(index)).id);
        }
      }
      if ((!GClass159.smethod_0().imethod_0() ? 1 : 0) == 0 && (!GClass159.bool_2 ? 0 : 1) == 0)
      {
        this.ginterface5_0 = (GInterface5) GClass159.smethod_0();
      }
      else
      {
        this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
        GClass156.bool_0 = Class15.smethod_0(1) != 0;
      }
      this.ginterface5_0.imethod_3(message);
      this.ginterface5_0 = (GInterface5) GClass157.smethod_0();
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_137()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(616));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_138(sbyte action, int id, sbyte[] data)
  {
    GClass96 message = (GClass96) null;
    try
    {
      GClass151.smethod_7(Class13.smethod_0(140600));
      message = new GClass96((sbyte) Class15.smethod_0(617));
      message.method_2().method_2(action);
      if ((int) action == Class15.smethod_0(1))
      {
        message.method_2().method_11(id);
        if ((data == null ? 1 : 0) == 0)
        {
          int length = data.Length;
          message.method_2().method_9(length);
          message.method_2().method_18(ref data, Class15.smethod_0(0), length);
        }
      }
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_139(sbyte[] skill)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(618));
      for (int index = Class15.smethod_0(0); index < GClass116.gclass161_1.Length; index += Class15.smethod_0(1))
        message.method_2().method_2(skill[index]);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_140()
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(244));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_141(int id)
  {
    GClass151.smethod_7(Class13.smethod_0(140581));
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(619));
      message.method_2().method_11(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_142(int charId)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(217));
      message.method_2().method_2((sbyte) Class15.smethod_0(182));
      message.method_2().method_11(charId);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_143(int charId, short select)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(217));
      message.method_2().method_2((sbyte) Class15.smethod_0(199));
      message.method_2().method_11(charId);
      message.method_2().method_8(select);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_144(string nameImg)
  {
    GClass96 message = (GClass96) null;
    try
    {
      message = new GClass96((sbyte) Class15.smethod_0(283));
      message.method_2().method_16(nameImg);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_145(byte type, byte soluong)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(620));
    try
    {
      message.method_2().method_3((int) type);
      if ((int) soluong > Class15.smethod_0(0))
        message.method_2().method_3((int) soluong);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_146(int i, int id)
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(73));
    try
    {
      message.method_2().method_3(i);
      if (id != -1)
        message.method_2().method_9(id);
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_147()
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(40));
    try
    {
      message.method_2().method_3(GClass20.smethod_1().idHat != (short) -1 ? -1 : Class15.smethod_0(0));
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }

  public void method_148()
  {
    GClass96 message = new GClass96((sbyte) Class15.smethod_0(151));
    try
    {
      this.ginterface5_0.imethod_3(message);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      message.method_4();
    }
  }
}
