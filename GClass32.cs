// Decompiled with JetBrains decompiler
// Type: GClass32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using UnityEngine;

public class GClass32 : GInterface4
{
  protected static GClass32 gclass32_0;
  protected static GClass32 gclass32_1;
  public GClass96 messWait;
  public static bool bool_0;
  public static bool bool_1;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  private float float_0;
  private int int_0;
  private int int_1;
  public static bool bool_5;
  public static GClass128 gclass128_0 = new GClass128();
  public const sbyte sbyte_0 = 0;
  public const sbyte sbyte_1 = 0;
  public const sbyte sbyte_2 = 1;
  public const sbyte sbyte_3 = 2;
  public const sbyte sbyte_4 = 4;
  public const sbyte sbyte_5 = 5;

  public static GClass32 smethod_0()
  {
    if ((GClass32.gclass32_0 == null ? 0 : 1) == 0)
      GClass32.gclass32_0 = new GClass32();
    return GClass32.gclass32_0;
  }

  public static GClass32 smethod_1()
  {
    if ((GClass32.gclass32_1 == null ? 0 : 1) == 0)
      GClass32.gclass32_1 = new GClass32();
    return GClass32.gclass32_1;
  }

  public void imethod_3(bool isMain1)
  {
    GClass32.bool_4 = isMain1;
    GClass126.smethod_28();
  }

  public void imethod_1(bool isMain1)
  {
    GClass32.bool_4 = isMain1;
    GClass126.smethod_29();
  }

  public void imethod_2(bool isMain1)
  {
    GClass32.bool_4 = isMain1;
    GClass126.smethod_30();
  }

  public void method_0(GClass96 msg)
  {
    try
    {
      int index = (int) msg.method_1().method_5();
      GClass80 gclass80 = GClass116.gclass20_0.arrItemBody[index];
      gclass80.saleCoinLock = msg.method_1().method_8();
      gclass80.sys = (int) msg.method_1().method_2();
      gclass80.options = new GClass134();
      try
      {
        while (true)
          gclass80.options.method_0((object) new GClass83((int) msg.method_1().method_5(), (int) msg.method_1().method_7()));
      }
      catch (Exception ex)
      {
        GClass33.smethod_0(Class13.smethod_0(26974) + ex.ToString());
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(27059) + ex.ToString());
    }
  }

  public void imethod_0(GClass96 msg)
  {
    GClass62.gclass134_4.method_9();
    GClass62.smethod_7(Class13.smethod_0(28168), Class15.smethod_0(7));
    try
    {
      GClass126.smethod_3(Class13.smethod_0(28274) + msg.command.ToString());
      GClass20 gclass20_1 = (GClass20) null;
      GClass134 gclass134 = new GClass134();
      Class15.smethod_0(0);
      Class9.smethod_0(msg);
      sbyte command1 = msg.command;
      GClass20 gclass20_2;
      int num1;
      switch ((int) command1 - Class15.smethod_0(264))
      {
        case 0:
          int num2 = (int) msg.method_1().method_2();
          if (num2 == 0)
            GClass116.smethod_13(msg.method_1().method_2()).method_3();
          if (num2 == Class15.smethod_0(1))
          {
            GClass116.smethod_13(msg.method_1().method_2()).method_2(msg.method_1().method_6());
            goto case 1;
          }
          else
            goto case 1;
        case 1:
        case 2:
        case 3:
        case 4:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 23:
        case 34:
        case 37:
        case 39:
        case 40:
        case 41:
        case 54:
        case 56:
        case 57:
        case 58:
        case 63:
        case 64:
        case 72:
        case 73:
        case 74:
        case 79:
        case 85:
        case 89:
        case 95:
        case 96:
        case 97:
        case 99:
        case 100:
        case 101:
        case 102:
        case 103:
        case 104:
        case 105:
        case 106:
        case 107:
        case 109:
        case 110:
        case 111:
        case 112:
        case 115:
        case 116:
        case 117:
        case 120:
        case 121:
        case 122:
        case 124:
        case 125:
        case 126:
        case (int) sbyte.MaxValue:
        case 128:
        case 129:
        case 130:
        case 131:
        case 133:
        case 134:
        case 135:
        case 137:
        case 138:
        case 140:
        case 142:
        case 143:
        case 146:
        case 147:
        case 148:
        case 149:
        case 154:
        case 156:
        case 157:
        case 160:
        case 161:
        case 163:
        case 164:
        case 165:
        case 167:
        case 171:
        case 172:
        case 173:
        case 179:
        case 182:
        case 183:
        case 184:
        case 185:
        case 186:
        case 187:
        case 188:
        case 189:
        case 190:
        case 191:
        case 192:
        case 201:
        case 203:
        case 205:
          sbyte command2 = msg.command;
          if ((int) command2 <= Class15.smethod_0(65))
          {
            if ((int) command2 <= Class15.smethod_0(281))
            {
              if ((int) command2 != Class15.smethod_0(282))
              {
                if ((int) command2 == Class15.smethod_0(281))
                {
                  sbyte num3 = msg.method_1().method_2();
                  for (int index = Class15.smethod_0(0); index < GClass116.gclass134_10.method_2(); index += Class15.smethod_0(1))
                  {
                    GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index);
                    if (gclass21.template.npcTemplateId == (int) num3)
                    {
                      gclass21.isHide = msg.method_1().method_2() != (sbyte) 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
                      break;
                    }
                  }
                }
              }
              else
              {
                GClass100 gclass100 = (GClass100) null;
                try
                {
                  gclass100 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
                }
                catch (Exception ex)
                {
                }
                if (gclass100 != null)
                {
                  gclass100.levelBoss = msg.method_1().method_2();
                  if ((int) gclass100.levelBoss > Class15.smethod_0(0))
                    gclass100.typeSuperEff = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
                }
              }
            }
            else
            {
              switch ((int) command2 - Class15.smethod_0(201))
              {
                case 0:
                  GClass62.smethod_7(Class13.smethod_0(188273), Class15.smethod_0(7));
                  GClass20.smethod_1().meDead = Class15.smethod_0(1) != 0;
                  GClass20.smethod_1().cPk = msg.method_1().method_2();
                  GClass20.smethod_1().method_110(msg.method_1().method_6(), msg.method_1().method_6());
                  try
                  {
                    GClass20.smethod_1().cPower = msg.method_1().method_9();
                    GClass20.smethod_1().method_0();
                  }
                  catch (Exception ex)
                  {
                    GClass33.smethod_0(Class13.smethod_0(188411) + msg.command.ToString());
                  }
                  GClass20.smethod_1().countKill = Class15.smethod_0(0);
                  break;
                case 1:
                  GClass62.smethod_7(Class13.smethod_0(182535), Class15.smethod_0(7));
                  if (GClass20.smethod_1().wdx != (short) 0 || GClass20.smethod_1().wdy != (short) 0)
                  {
                    GClass20.smethod_1().cx = (int) GClass20.smethod_1().wdx;
                    GClass20.smethod_1().cy = (int) GClass20.smethod_1().wdy;
                    GClass20.smethod_1().wdx = GClass20.smethod_1().wdy = (short) Class15.smethod_0(0);
                  }
                  GClass20.smethod_1().method_112();
                  GClass20.smethod_1().isLockMove = Class15.smethod_0(0) != 0;
                  GClass20.smethod_1().meDead = Class15.smethod_0(0) != 0;
                  break;
                case 2:
                case 3:
                case 13:
                  break;
                case 4:
                  GClass62.smethod_7(Class13.smethod_0(189129), Class15.smethod_0(7));
                  int index1 = (int) msg.method_1().method_5();
                  if (index1 > GClass116.gclass134_9.method_2() - Class15.smethod_0(1) || index1 < Class15.smethod_0(0))
                    return;
                  GClass100 gclass100_1 = (GClass100) GClass116.gclass134_9.method_3(index1);
                  gclass100_1.sys = (int) msg.method_1().method_2();
                  gclass100_1.levelBoss = msg.method_1().method_2();
                  if (gclass100_1.levelBoss != (sbyte) 0)
                    gclass100_1.typeSuperEff = GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(5));
                  gclass100_1.x = gclass100_1.xFirst;
                  gclass100_1.y = gclass100_1.yFirst;
                  gclass100_1.status = Class15.smethod_0(3);
                  gclass100_1.injureThenDie = Class15.smethod_0(0) != 0;
                  gclass100_1.hp = msg.method_1().method_8();
                  gclass100_1.maxHp = gclass100_1.hp;
                  gclass100_1.method_22();
                  GClass47.smethod_0(Class15.smethod_0(4), gclass100_1.x, gclass100_1.y, Class15.smethod_0(1));
                  break;
                case 5:
                  GClass151.smethod_7(Class13.smethod_0(190783));
                  GClass62.smethod_7(Class13.smethod_0(190840), Class15.smethod_0(7));
                  GClass100 gclass100_2 = (GClass100) null;
                  try
                  {
                    gclass100_2 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
                  }
                  catch (Exception ex)
                  {
                    GClass33.smethod_0(Class13.smethod_0(190799) + msg.command.ToString());
                  }
                  if (gclass100_2 != null && gclass100_2.status != 0 && gclass100_2.status != 0)
                  {
                    gclass100_2.method_24();
                    try
                    {
                      int num4 = msg.method_3();
                      if (msg.method_1().method_10())
                        GClass116.smethod_17(Class13.smethod_0(121200) + num4.ToString(), gclass100_2.x, gclass100_2.y - gclass100_2.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_6);
                      else
                        GClass116.smethod_17(Class13.smethod_0(121200) + num4.ToString(), gclass100_2.x, gclass100_2.y - gclass100_2.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_8);
                      sbyte num5 = msg.method_1().method_2();
                      for (int index2 = Class15.smethod_0(0); index2 < (int) num5; index2 += Class15.smethod_0(1))
                      {
                        GClass81 o = new GClass81(msg.method_1().method_6(), msg.method_1().method_6(), gclass100_2.x, gclass100_2.y, (int) msg.method_1().method_6(), (int) msg.method_1().method_6());
                        int num6 = o.playerId = msg.method_1().method_8();
                        GClass151.smethod_7(Class13.smethod_0(190536) + num6.ToString() + Class13.smethod_0(190598) + GClass20.smethod_1().charID.ToString());
                        GClass116.gclass134_6.method_0((object) o);
                        if (GClass151.smethod_25(o.y - GClass20.smethod_1().cy) < Class15.smethod_0(40) && GClass151.smethod_25(o.x - GClass20.smethod_1().cx) < Class15.smethod_0(40))
                          GClass20.smethod_1().charFocus = (GClass20) null;
                      }
                      break;
                    }
                    catch (Exception ex)
                    {
                      GClass33.smethod_0(Class13.smethod_0(190658) + ex.ToString() + Class13.smethod_0(191408) + msg.command.ToString());
                      break;
                    }
                  }
                  else
                    break;
                case 6:
                  GClass62.smethod_7(Class13.smethod_0(191097), Class15.smethod_0(7));
                  GClass100 gclass100_3 = (GClass100) null;
                  try
                  {
                    int index3 = (int) msg.method_1().method_5();
                    gclass100_3 = (GClass100) GClass116.gclass134_9.method_3(index3);
                  }
                  catch (Exception ex)
                  {
                    GClass151.smethod_7(Class13.smethod_0(191059) + msg.command.ToString() + Class13.smethod_0(191825) + ex.StackTrace);
                  }
                  if (gclass100_3 != null)
                  {
                    GClass20.smethod_1().isDie = Class15.smethod_0(0) != 0;
                    GClass20.bool_3 = Class15.smethod_0(0) != 0;
                    int HPShow = msg.method_3();
                    int MPShow;
                    try
                    {
                      MPShow = msg.method_3();
                    }
                    catch (Exception ex)
                    {
                      MPShow = Class15.smethod_0(0);
                    }
                    if (gclass100_3.isBusyAttackSomeOne)
                    {
                      GClass20.smethod_1().method_108(HPShow, MPShow, Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
                      break;
                    }
                    gclass100_3.dame = HPShow;
                    gclass100_3.dameMp = MPShow;
                    gclass100_3.method_10(GClass20.smethod_1());
                    break;
                  }
                  break;
                case 7:
                  GClass62.smethod_7(Class13.smethod_0(191498), Class15.smethod_0(7));
                  GClass100 gclass100_4 = (GClass100) null;
                  try
                  {
                    gclass100_4 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
                  }
                  catch (Exception ex)
                  {
                  }
                  GClass62.smethod_7(Class13.smethod_0(191729), Class15.smethod_0(7));
                  if (gclass100_4 != null)
                  {
                    GClass62.smethod_7(Class13.smethod_0(192259), Class15.smethod_0(7));
                    GClass20 cFocus = GClass116.smethod_12(msg.method_1().method_8());
                    if (cFocus == null)
                      return;
                    GClass62.smethod_7(Class13.smethod_0(187136), Class15.smethod_0(7));
                    int num7 = msg.method_3();
                    gclass100_4.dame = cFocus.cHP - num7;
                    cFocus.cHPNew = num7;
                    GClass62.smethod_7(Class13.smethod_0(186888), Class15.smethod_0(7));
                    try
                    {
                      cFocus.cMP = msg.method_3();
                    }
                    catch (Exception ex)
                    {
                    }
                    GClass62.smethod_7(Class13.smethod_0(187705), Class15.smethod_0(7));
                    if (gclass100_4.isBusyAttackSomeOne)
                      cFocus.method_108(gclass100_4.dame, Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
                    else
                      gclass100_4.method_10(cFocus);
                    GClass62.smethod_7(Class13.smethod_0(187562), Class15.smethod_0(7));
                    break;
                  }
                  break;
                case 8:
                  GClass62.smethod_7(Class13.smethod_0(189680), Class15.smethod_0(7));
                  GClass100 gclass100_5 = (GClass100) null;
                  try
                  {
                    gclass100_5 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
                  }
                  catch (Exception ex)
                  {
                  }
                  GClass62.smethod_7(Class13.smethod_0(190225), Class15.smethod_0(7));
                  if (gclass100_5 != null)
                  {
                    gclass100_5.hp = msg.method_3();
                    gclass100_5.method_22();
                    int num8 = msg.method_3();
                    if (num8 == Class15.smethod_0(1))
                      return;
                    bool flag = Class15.smethod_0(0) != 0;
                    try
                    {
                      flag = msg.method_1().method_11();
                    }
                    catch (Exception ex)
                    {
                    }
                    sbyte id = msg.method_1().method_2();
                    if (id != (sbyte) -1)
                      GClass40.smethod_0(new GClass41((int) id, gclass100_5.x, gclass100_5.imethod_1(), Class15.smethod_0(5), Class15.smethod_0(1), -1));
                    GClass62.smethod_7(Class13.smethod_0(121193), Class15.smethod_0(7));
                    if (flag)
                      GClass116.smethod_17(Class13.smethod_0(121200) + num8.ToString(), gclass100_5.x, gclass100_5.imethod_1() - gclass100_5.imethod_3(), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_6);
                    else if (num8 == 0)
                    {
                      gclass100_5.x = gclass100_5.xFirst;
                      gclass100_5.y = gclass100_5.yFirst;
                      GClass116.smethod_17(GClass109.string_233, gclass100_5.x, gclass100_5.imethod_1() - gclass100_5.imethod_3(), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_7);
                    }
                    else
                      GClass116.smethod_17(Class13.smethod_0(121200) + num8.ToString(), gclass100_5.x, gclass100_5.imethod_1() - gclass100_5.imethod_3(), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_8);
                  }
                  GClass62.smethod_7(Class13.smethod_0(190003), Class15.smethod_0(7));
                  break;
                case 9:
                  GClass62.smethod_7(Class13.smethod_0(180708), Class15.smethod_0(7));
                  GClass20 gclass20_3 = GClass116.smethod_12(msg.method_1().method_8());
                  if (gclass20_3 == null)
                    return;
                  gclass20_3.cPk = msg.method_1().method_2();
                  gclass20_3.method_111(msg.method_1().method_6(), msg.method_1().method_6());
                  break;
                case 10:
                  GClass62.smethod_7(Class13.smethod_0(196330), Class15.smethod_0(7));
                  int num9 = msg.method_1().method_8();
                  GClass33.smethod_0(Class13.smethod_0(188680) + num9.ToString());
                  for (int index4 = Class15.smethod_0(0); index4 < GClass116.gclass134_5.method_2(); index4 += Class15.smethod_0(1))
                  {
                    GClass20 gclass20_4 = (GClass20) null;
                    try
                    {
                      gclass20_4 = (GClass20) GClass116.gclass134_5.method_3(index4);
                    }
                    catch (Exception ex)
                    {
                      GClass33.smethod_0(Class13.smethod_0(188853) + ex.ToString());
                    }
                    if (gclass20_4 != null)
                    {
                      if (gclass20_4.charID == num9)
                      {
                        GClass62.smethod_7(Class13.smethod_0(188479) + index4.ToString(), Class15.smethod_0(7));
                        gclass20_4.method_96((int) msg.method_1().method_6(), (int) msg.method_1().method_6(), Class15.smethod_0(0));
                        gclass20_4.lastUpdateTime = GClass126.smethod_18();
                        break;
                      }
                    }
                    else
                      break;
                  }
                  GClass62.smethod_7(Class13.smethod_0(188589), Class15.smethod_0(7));
                  break;
                case 11:
                  GClass62.smethod_7(Class13.smethod_0(189366), Class15.smethod_0(7));
                  int num10 = msg.method_1().method_8();
                  for (int index5 = Class15.smethod_0(0); index5 < GClass116.gclass134_5.method_2(); index5 += Class15.smethod_0(1))
                  {
                    GClass20 gclass20_5 = (GClass20) GClass116.gclass134_5.method_3(index5);
                    if (gclass20_5 != null && gclass20_5.charID == num10)
                    {
                      if (!gclass20_5.isInvisiblez && !gclass20_5.isUsePlane)
                        GClass47.smethod_0(Class15.smethod_0(4), gclass20_5.cx, gclass20_5.cy, Class15.smethod_0(1));
                      if (gclass20_5.isUsePlane)
                        return;
                      GClass116.gclass134_5.method_7(index5);
                      return;
                    }
                  }
                  break;
                case 12:
                  GClass62.smethod_7(Class13.smethod_0(194145), Class15.smethod_0(7));
                  int num11 = msg.method_1().method_8();
                  int num12 = msg.method_1().method_8();
                  GClass20 gclass20_6;
                  if (num12 != Class15.smethod_0(143))
                  {
                    gclass20_6 = new GClass20();
                    gclass20_6.charID = num11;
                    gclass20_6.clanID = num12;
                  }
                  else
                  {
                    gclass20_6 = (GClass20) new Class2();
                    gclass20_6.charID = num11;
                    gclass20_6.clanID = num12;
                  }
                  if (gclass20_6.clanID == Class15.smethod_0(132))
                    gclass20_6.isCopy = Class15.smethod_0(1) != 0;
                  if (this.method_15(gclass20_6, msg))
                  {
                    sbyte num13 = msg.method_1().method_2();
                    if (gclass20_6.cy <= Class15.smethod_0(31) && num13 != (sbyte) 0 && (int) num13 != Class15.smethod_0(7))
                    {
                      GClass151.smethod_7(Class13.smethod_0(194226) + gclass20_6.cx.ToString() + Class13.smethod_0(194866) + gclass20_6.cy.ToString());
                      GClass182 p = new GClass182(gclass20_6.cx, gclass20_6.cy, gclass20_6.head, gclass20_6.cdir, Class15.smethod_0(1), Class15.smethod_0(0) != 0, (int) num13 != Class15.smethod_0(1) ? (int) num13 : gclass20_6.cgender);
                      p.id = gclass20_6.charID;
                      gclass20_6.isTeleport = Class15.smethod_0(1) != 0;
                      GClass182.smethod_0(p);
                    }
                    if ((int) num13 == Class15.smethod_0(7))
                      gclass20_6.method_34();
                    for (int index6 = Class15.smethod_0(0); index6 < GClass116.gclass134_9.method_2(); index6 += Class15.smethod_0(1))
                    {
                      GClass100 gclass100_6 = (GClass100) GClass116.gclass134_9.method_3(index6);
                      if (gclass100_6 != null && gclass100_6.isMobMe && gclass100_6.mobId == gclass20_6.charID)
                      {
                        GClass151.smethod_7(Class13.smethod_0(194889));
                        gclass20_6.mobMe = gclass100_6;
                        gclass20_6.mobMe.x = gclass20_6.cx;
                        gclass20_6.mobMe.y = gclass20_6.cy - Class15.smethod_0(54);
                        break;
                      }
                    }
                    if (GClass116.smethod_12(gclass20_6.charID) == null)
                      GClass116.gclass134_5.method_0((object) gclass20_6);
                    gclass20_6.isMonkey = msg.method_1().method_2();
                    short num14 = msg.method_1().method_6();
                    GClass151.smethod_7(Class13.smethod_0(195055) + num14.ToString() + Class13.smethod_0(194570));
                    if (num14 != (short) -1)
                    {
                      gclass20_6.isHaveMount = Class15.smethod_0(1) != 0;
                      if ((int) num14 <= Class15.smethod_0(286))
                      {
                        if ((uint) num14 - (uint) Class15.smethod_0(287) > (uint) Class15.smethod_0(7))
                        {
                          if ((uint) num14 - (uint) Class15.smethod_0(207) <= (uint) Class15.smethod_0(7))
                          {
                            gclass20_6.isMountVip = Class15.smethod_0(1) != 0;
                            goto label_1056;
                          }
                        }
                        else
                        {
                          gclass20_6.isMountVip = Class15.smethod_0(0) != 0;
                          goto label_1056;
                        }
                      }
                      else if ((int) num14 != Class15.smethod_0(208))
                      {
                        if ((int) num14 == Class15.smethod_0(209))
                        {
                          gclass20_6.isSpeacialMount = Class15.smethod_0(1) != 0;
                          goto label_1056;
                        }
                      }
                      else
                      {
                        gclass20_6.isEventMount = Class15.smethod_0(1) != 0;
                        goto label_1056;
                      }
                      if ((int) num14 >= (int) GClass20.short_2)
                        gclass20_6.idMount = num14;
                    }
                    else
                      gclass20_6.isHaveMount = Class15.smethod_0(0) != 0;
                  }
label_1056:
                  sbyte num15 = msg.method_1().method_2();
                  GClass151.smethod_7(Class13.smethod_0(194795) + num15.ToString());
                  gclass20_6.cFlag = num15;
                  gclass20_6.isNhapThe = (int) msg.method_1().method_2() == Class15.smethod_0(1);
                  try
                  {
                    gclass20_6.idAuraEff = msg.method_1().method_6();
                    gclass20_6.idEff_Set_Item = (short) msg.method_1().method_0();
                    gclass20_6.idHat = msg.method_1().method_6();
                    if (gclass20_6.bag >= Class15.smethod_0(218) && gclass20_6.bag < Class15.smethod_0(270))
                    {
                      gclass20_6.method_136(new GClass41(gclass20_6.bag, gclass20_6, Class15.smethod_0(7), -1, Class15.smethod_0(31), (sbyte) Class15.smethod_0(1))
                      {
                        typeEff = Class15.smethod_0(3)
                      });
                    }
                    else
                    {
                      for (int index7 = Class15.smethod_0(0); index7 < Class15.smethod_0(271); index7 += Class15.smethod_0(1))
                        gclass20_6.method_137(Class15.smethod_0(0), Class15.smethod_0(218) + index7);
                    }
                  }
                  catch (Exception ex)
                  {
                    GClass151.smethod_7(Class13.smethod_0(195347) + ex.StackTrace);
                  }
                  GClass116.smethod_6().method_115(gclass20_6.charID, gclass20_6.cFlag);
                  string[] strArray1 = new string[Class15.smethod_0(88)];
                  strArray1[Class15.smethod_0(0)] = Class13.smethod_0(196155);
                  strArray1[Class15.smethod_0(1)] = gclass20_1.charID.ToString();
                  strArray1[Class15.smethod_0(7)] = Class13.smethod_0(196199);
                  strArray1[Class15.smethod_0(5)] = gclass20_1.cName;
                  strArray1[Class15.smethod_0(2)] = Class13.smethod_0(196199);
                  strArray1[Class15.smethod_0(3)] = gclass20_1.cFlag.ToString();
                  strArray1[Class15.smethod_0(37)] = Class13.smethod_0(196199);
                  strArray1[Class15.smethod_0(38)] = gclass20_1.bag.ToString();
                  GClass151.smethod_7(string.Concat(strArray1));
                  break;
                case 14:
                  GClass62.smethod_7(Class13.smethod_0(194536), Class15.smethod_0(7));
                  int num16 = (int) msg.method_1().method_2();
                  int num17 = msg.method_1().method_8();
                  if (num16 == 0)
                    GClass20.smethod_1().cPower += (long) num17;
                  if (num16 == Class15.smethod_0(1))
                    GClass20.smethod_1().cTiemNang += (long) num17;
                  if (num16 == Class15.smethod_0(7))
                  {
                    GClass20.smethod_1().cPower += (long) num17;
                    GClass20.smethod_1().cTiemNang += (long) num17;
                  }
                  GClass20.smethod_1().method_0();
                  if ((int) GClass20.smethod_1().cTypePk != Class15.smethod_0(5))
                  {
                    GClass116.smethod_17((num17 <= Class15.smethod_0(0) ? string.Empty : Class13.smethod_0(136021)) + num17.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch, Class15.smethod_0(0), Class15.smethod_0(200), GClass97.int_5);
                    if (num17 > Class15.smethod_0(0) && GClass20.smethod_1().petFollow != null && (int) GClass20.smethod_1().petFollow.smallID == Class15.smethod_0(285))
                    {
                      GClass47.smethod_0(Class15.smethod_0(280), GClass20.smethod_1().petFollow.cmx, GClass20.smethod_1().petFollow.cmy, Class15.smethod_0(1));
                      GClass47.smethod_0(Class15.smethod_0(280), GClass20.smethod_1().cx, GClass20.smethod_1().cy, Class15.smethod_0(1));
                      break;
                    }
                    break;
                  }
                  break;
                case 15:
                  GClass62.smethod_7(Class13.smethod_0(193220), Class15.smethod_0(28));
                  int num18 = msg.method_1().method_8();
                  GClass20.smethod_1().yen += num18;
                  GClass116.smethod_17(num18 <= Class15.smethod_0(0) ? string.Empty + num18.ToString() : Class13.smethod_0(136021) + num18.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(31), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_4);
                  break;
                case 16:
                  GClass62.smethod_7(Class13.smethod_0(193220), Class15.smethod_0(284));
                  int num19 = msg.method_1().method_8();
                  GClass20.smethod_1().xu += (long) num19;
                  GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
                  GClass20.smethod_1().yen -= num19;
                  GClass116.smethod_17(Class13.smethod_0(136021) + num19.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(31), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_4);
                  break;
                default:
                  if ((int) command2 != Class15.smethod_0(124))
                  {
                    if ((int) command2 == Class15.smethod_0(65))
                    {
                      GClass20.smethod_1().countKill = (int) msg.method_1().method_7();
                      GClass20.smethod_1().countKillMax = (int) msg.method_1().method_7();
                      break;
                    }
                    break;
                  }
                  sbyte num20 = msg.method_1().method_2();
                  for (int index8 = Class15.smethod_0(0); index8 < (int) num20; index8 += Class15.smethod_0(1))
                  {
                    int charId = msg.method_1().method_8();
                    int num21 = (int) msg.method_1().method_6();
                    int num22 = (int) msg.method_1().method_6();
                    int num23 = msg.method_3();
                    GClass20 gclass20_7 = GClass116.smethod_12(charId);
                    if (gclass20_7 != null)
                    {
                      gclass20_7.cx = num21;
                      gclass20_7.cy = num22;
                      GClass20 gclass20_8 = gclass20_7;
                      gclass20_7.cHPShow = num1 = num23;
                      int num24 = num1;
                      gclass20_8.cHP = num24;
                      gclass20_7.lastUpdateTime = GClass126.smethod_18();
                    }
                  }
                  break;
              }
            }
          }
          else if ((int) command2 <= Class15.smethod_0(70))
          {
            if ((int) command2 != Class15.smethod_0(74))
            {
              if ((int) command2 == Class15.smethod_0(70))
              {
                GClass62.smethod_7(Class13.smethod_0(190056), Class15.smethod_0(7));
                GClass100 gclass100_7 = (GClass100) null;
                try
                {
                  gclass100_7 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
                }
                catch (Exception ex)
                {
                  GClass33.smethod_0(Class13.smethod_0(190092) + ex.ToString());
                }
                if (gclass100_7 != null)
                {
                  gclass100_7.hp = msg.method_1().method_8();
                  gclass100_7.method_22();
                  GClass116.smethod_17(GClass109.string_233, gclass100_7.x, gclass100_7.y - gclass100_7.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_7);
                }
              }
            }
            else
            {
              GClass62.smethod_7(Class13.smethod_0(182685), Class15.smethod_0(7));
              int charId = msg.method_1().method_8();
              string info = msg.method_1().method_14();
              GClass151.smethod_7(Class13.smethod_0(182737) + charId.ToString() + Class13.smethod_0(182319) + info);
              (GClass20.smethod_1().charID != charId ? GClass116.smethod_12(charId) : GClass20.smethod_1())?.method_7(info);
            }
          }
          else if ((int) command2 != Class15.smethod_0(283))
          {
            if ((int) command2 != Class15.smethod_0(26))
            {
              switch ((int) command2 - Class15.smethod_0(101))
              {
                case 0:
                  GClass62.smethod_7(Class13.smethod_0(193220), Class15.smethod_0(28));
                  int num25 = msg.method_1().method_8();
                  GClass20.smethod_1().xu += (long) num25;
                  GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
                  GClass116.smethod_17(num25 <= Class15.smethod_0(0) ? string.Empty + num25.ToString() : Class13.smethod_0(136021) + num25.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(31), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_4);
                  break;
                case 1:
                  GClass62.smethod_7(Class13.smethod_0(193757), Class15.smethod_0(28));
                  GClass20.smethod_1().taskOrders.method_0((object) new GClass180(msg.method_1().method_2(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_14(), msg.method_1().method_14(), msg.method_1().method_2(), msg.method_1().method_2()));
                  break;
                case 2:
                  sbyte num26 = msg.method_1().method_2();
                  for (int index9 = Class15.smethod_0(0); index9 < GClass20.smethod_1().taskOrders.method_2(); index9 += Class15.smethod_0(1))
                  {
                    GClass180 gclass180 = (GClass180) GClass20.smethod_1().taskOrders.method_3(index9);
                    if (gclass180.taskId == (int) num26)
                    {
                      gclass180.count = (int) msg.method_1().method_6();
                      break;
                    }
                  }
                  break;
              }
            }
            else
            {
              GClass62.smethod_7(Class13.smethod_0(190840), Class15.smethod_0(7));
              GClass100 gclass100_8 = (GClass100) null;
              try
              {
                gclass100_8 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
              }
              catch (Exception ex)
              {
                GClass33.smethod_0(Class13.smethod_0(191431) + msg.command.ToString());
              }
              if (gclass100_8 != null && gclass100_8.status != 0 && gclass100_8.status != 0)
              {
                gclass100_8.status = Class15.smethod_0(0);
                GClass47.smethod_0(Class15.smethod_0(4), gclass100_8.x, gclass100_8.y, Class15.smethod_0(1));
                GClass81 o = new GClass81(msg.method_1().method_6(), msg.method_1().method_6(), gclass100_8.x, gclass100_8.y, (int) msg.method_1().method_6(), (int) msg.method_1().method_6());
                GClass116.gclass134_6.method_0((object) o);
                if (GClass151.smethod_25(o.y - GClass20.smethod_1().cy) < Class15.smethod_0(40) && GClass151.smethod_25(o.x - GClass20.smethod_1().cx) < Class15.smethod_0(40))
                  GClass20.smethod_1().charFocus = (GClass20) null;
              }
            }
          }
          else
            GClass151.smethod_7(Class13.smethod_0(188049));
          GClass62.smethod_7(Class13.smethod_0(182296), Class15.smethod_0(7));
          break;
        case 5:
          int num27 = (int) msg.method_1().method_2();
          if (num27 == 0)
            GClass20.smethod_1().havePet = Class15.smethod_0(0) != 0;
          if (num27 == Class15.smethod_0(1))
            GClass20.smethod_1().havePet = Class15.smethod_0(1) != 0;
          if (num27 == Class15.smethod_0(7))
          {
            GClass71.smethod_5();
            GClass20.smethod_2().head = (int) msg.method_1().method_6();
            GClass20.smethod_2().method_58();
            int length1 = (int) msg.method_1().method_5();
            GClass151.smethod_7(Class13.smethod_0(155042) + length1.ToString());
            GClass20.smethod_2().arrItemBody = new GClass80[length1];
            for (int index10 = Class15.smethod_0(0); index10 < length1; index10 += Class15.smethod_0(1))
            {
              short id = msg.method_1().method_6();
              GClass151.smethod_7(Class13.smethod_0(155010) + id.ToString());
              if (id != (short) -1)
              {
                GClass151.smethod_7(Class13.smethod_0(154676));
                GClass20.smethod_2().arrItemBody[index10] = new GClass80();
                GClass20.smethod_2().arrItemBody[index10].template = GClass86.smethod_1(id);
                int type = (int) GClass20.smethod_2().arrItemBody[index10].template.type;
                GClass20.smethod_2().arrItemBody[index10].quantity = msg.method_1().method_8();
                GClass151.smethod_7(Class13.smethod_0(154715));
                GClass20.smethod_2().arrItemBody[index10].info = msg.method_1().method_14();
                GClass20.smethod_2().arrItemBody[index10].content = msg.method_1().method_14();
                int length2 = (int) msg.method_1().method_5();
                GClass151.smethod_7(Class13.smethod_0(154788) + length2.ToString());
                if (length2 != 0)
                {
                  GClass20.smethod_2().arrItemBody[index10].itemOption = new GClass83[length2];
                  for (int index11 = Class15.smethod_0(0); index11 < GClass20.smethod_2().arrItemBody[index10].itemOption.Length; index11 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num28 = (int) msg.method_1().method_7();
                    GClass20.smethod_2().arrItemBody[index10].itemOption[index11] = new GClass83(optionTemplateId, num28);
                  }
                }
                if (type != 0)
                {
                  if (type == Class15.smethod_0(1))
                    GClass20.smethod_2().leg = (int) GClass20.smethod_2().arrItemBody[index10].template.part;
                }
                else
                  GClass20.smethod_2().body = (int) GClass20.smethod_2().arrItemBody[index10].template.part;
              }
            }
            GClass20.smethod_2().cHP = msg.method_3();
            GClass20.smethod_2().cHPFull = msg.method_3();
            GClass20.smethod_2().cMP = msg.method_3();
            GClass20.smethod_2().cMPFull = msg.method_3();
            GClass20.smethod_2().cDamFull = msg.method_3();
            GClass20.smethod_2().cName = msg.method_1().method_14();
            GClass20.smethod_2().currStrLevel = msg.method_1().method_14();
            GClass20.smethod_2().cPower = msg.method_1().method_9();
            GClass20.smethod_2().cTiemNang = msg.method_1().method_9();
            GClass20.smethod_2().petStatus = msg.method_1().method_2();
            GClass20.smethod_2().cStamina = (int) msg.method_1().method_6();
            GClass20.smethod_2().cMaxStamina = msg.method_1().method_6();
            GClass20.smethod_2().cCriticalFull = (int) msg.method_1().method_2();
            GClass20.smethod_2().cDefull = (int) msg.method_1().method_6();
            GClass20.smethod_2().arrPetSkill = new GClass161[(int) msg.method_1().method_2()];
            GClass151.smethod_7(Class13.smethod_0(154839) + GClass20.smethod_2().arrPetSkill?.ToString());
            for (int index12 = Class15.smethod_0(0); index12 < GClass20.smethod_2().arrPetSkill.Length; index12 += Class15.smethod_0(1))
            {
              short skillId = msg.method_1().method_6();
              if (skillId != (short) -1)
              {
                GClass20.smethod_2().arrPetSkill[index12] = GClass166.smethod_1(skillId);
              }
              else
              {
                GClass20.smethod_2().arrPetSkill[index12] = new GClass161();
                GClass20.smethod_2().arrPetSkill[index12].template = (GClass167) null;
                GClass20.smethod_2().arrPetSkill[index12].moreInfo = msg.method_1().method_14();
              }
            }
            if (GClass62.gclass141_0.isShowPet)
            {
              if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
              {
                GClass62.gclass141_1 = new GClass141();
                string[][][] tabName = GClass62.gclass141_1.tabName;
                int index13 = Class15.smethod_0(38);
                string[][] strArray2 = new string[Class15.smethod_0(1)][];
                int index14 = Class15.smethod_0(0);
                string[] strArray3 = new string[Class15.smethod_0(1)];
                strArray3[Class15.smethod_0(0)] = string.Empty;
                strArray2[index14] = strArray3;
                tabName[index13] = strArray2;
                GClass62.gclass141_1.method_12();
                GClass62.gclass141_1.method_44();
                GClass62.gclass141_0.method_33();
                GClass62.gclass141_0.method_44();
                goto case 1;
              }
              else
              {
                GClass62.gclass141_0.tabName[Class15.smethod_0(27)] = GClass109.string_104;
                GClass62.gclass141_0.method_33();
                GClass62.gclass141_0.method_44();
                goto case 1;
              }
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 13:
          GClass71.smethod_5();
          if (msg.method_1().method_2() == (sbyte) 0)
          {
            GClass62.gclass141_0.vEnemy.method_9();
            int num29 = (int) msg.method_1().method_5();
            for (int index15 = Class15.smethod_0(0); index15 < num29; index15 += Class15.smethod_0(1))
            {
              GClass20 gclass20_9 = new GClass20();
              gclass20_9.charID = msg.method_1().method_8();
              gclass20_9.head = (int) msg.method_1().method_6();
              gclass20_9.headICON = (int) msg.method_1().method_6();
              gclass20_9.body = (int) msg.method_1().method_6();
              gclass20_9.leg = (int) msg.method_1().method_6();
              gclass20_9.bag = (int) msg.method_1().method_6();
              gclass20_9.cName = msg.method_1().method_14();
              GClass72 o = new GClass72(msg.method_1().method_14());
              bool flag = msg.method_1().method_11();
              o.charInfo = gclass20_9;
              o.isOnline = flag;
              GClass151.smethod_7(Class13.smethod_0(157924) + flag.ToString());
              GClass62.gclass141_0.vEnemy.method_0((object) o);
            }
            GClass62.gclass141_0.method_20();
            GClass62.gclass141_0.method_44();
            goto case 1;
          }
          else
            goto case 1;
        case 14:
          int num30 = (int) msg.method_1().method_2();
          GClass62.gclass95_0.showMenu = Class15.smethod_0(0) != 0;
          if (num30 == 0)
          {
            GClass62.smethod_34(msg.method_1().method_14(), new GClass31(GClass109.string_135, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(266), (object) msg.method_1().method_14()), new GClass31(GClass109.string_136, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(267), (object) null));
            goto case 1;
          }
          else
            goto case 1;
        case 15:
          GClass20.smethod_1().cNangdong = (long) msg.method_1().method_8();
          goto case 1;
        case 16:
          sbyte t = msg.method_1().method_2();
          GClass62.gclass141_0.vTop.method_9();
          string str1 = msg.method_1().method_14();
          sbyte num31 = msg.method_1().method_2();
          for (int index16 = Class15.smethod_0(0); index16 < (int) num31; index16 += Class15.smethod_0(1))
          {
            int num32 = msg.method_1().method_8();
            int num33 = msg.method_1().method_8();
            short num34 = msg.method_1().method_6();
            short num35 = msg.method_1().method_6();
            short num36 = msg.method_1().method_6();
            short num37 = msg.method_1().method_6();
            string str2 = msg.method_1().method_14();
            string str3 = msg.method_1().method_14();
            GClass62.gclass141_0.vTop.method_0((object) new GClass187()
            {
              rank = num32,
              headID = (int) num34,
              headICON = (int) num35,
              body = num36,
              leg = num37,
              name = str2,
              info = str3,
              info2 = msg.method_1().method_14(),
              pId = num33
            });
          }
          GClass62.gclass141_0.topName = str1;
          GClass62.gclass141_0.method_21(t);
          GClass62.gclass141_0.method_44();
          goto case 1;
        case 17:
          sbyte num38 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(28313) + num38.ToString());
          if (num38 == (sbyte) 0)
          {
            int num39 = msg.method_1().method_8();
            short templateId = msg.method_1().method_6();
            int num40 = msg.method_3();
            GClass172.smethod_1().method_22();
            if (num39 == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().mobMe = new GClass100(num39, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, (int) templateId, Class15.smethod_0(1), num40, (sbyte) Class15.smethod_0(0), num40, (short) (GClass20.smethod_1().cx + (GClass20.smethod_1().cdir != Class15.smethod_0(1) ? Class15.smethod_0(268) : Class15.smethod_0(54))), (short) GClass20.smethod_1().cy, (sbyte) Class15.smethod_0(2), (sbyte) Class15.smethod_0(0));
              GClass20.smethod_1().mobMe.isMobMe = Class15.smethod_0(1) != 0;
              GClass40.smethod_0(new GClass41(Class15.smethod_0(124), GClass20.smethod_1().mobMe.x, GClass20.smethod_1().mobMe.y, Class15.smethod_0(7), Class15.smethod_0(31), -1));
              GClass20.smethod_1().tMobMeBorn = Class15.smethod_0(6);
              GClass116.gclass134_9.method_0((object) GClass20.smethod_1().mobMe);
            }
            else
            {
              gclass20_1 = GClass116.smethod_12(num39);
              if (gclass20_1 != null)
              {
                gclass20_1.mobMe = new GClass100(num39, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, (int) templateId, Class15.smethod_0(1), num40, (sbyte) Class15.smethod_0(0), num40, (short) gclass20_1.cx, (short) gclass20_1.cy, (sbyte) Class15.smethod_0(2), (sbyte) Class15.smethod_0(0))
                {
                  isMobMe = Class15.smethod_0(1) != 0
                };
                GClass116.gclass134_9.method_0((object) gclass20_1.mobMe);
              }
              else if (GClass116.smethod_14(num39) == null)
                GClass116.gclass134_9.method_0((object) new GClass100(num39, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, Class15.smethod_0(0) != 0, (int) templateId, Class15.smethod_0(1), num40, (sbyte) Class15.smethod_0(0), num40, (short) Class15.smethod_0(143), (short) Class15.smethod_0(143), (sbyte) Class15.smethod_0(2), (sbyte) Class15.smethod_0(0))
                {
                  isMobMe = (Class15.smethod_0(1) != 0)
                });
            }
          }
          if ((int) num38 == Class15.smethod_0(1))
          {
            int charId = msg.method_1().method_8();
            int mobId = (int) msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(28289) + charId.ToString());
            if (charId == GClass20.smethod_1().charID)
            {
              if (GClass116.smethod_14(mobId) != null)
                GClass20.smethod_1().mobMe.method_25(GClass116.smethod_14(mobId));
            }
            else
            {
              gclass20_1 = GClass116.smethod_12(charId);
              if (gclass20_1 != null && GClass116.smethod_14(mobId) != null)
                gclass20_1.mobMe.method_25(GClass116.smethod_14(mobId));
            }
          }
          if ((int) num38 == Class15.smethod_0(7))
          {
            int mobId = msg.method_1().method_8();
            int charId = msg.method_1().method_8();
            int HPShow = msg.method_3();
            int num41 = msg.method_3();
            if (mobId == GClass20.smethod_1().charID)
            {
              GClass151.smethod_7(Class13.smethod_0(121211) + HPShow.ToString());
              gclass20_1 = GClass116.smethod_12(charId);
              if (gclass20_1 != null)
              {
                gclass20_1.cHPNew = num41;
                if (GClass20.smethod_1().mobMe.isBusyAttackSomeOne)
                {
                  gclass20_1.method_108(HPShow, Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
                }
                else
                {
                  GClass20.smethod_1().mobMe.dame = HPShow;
                  GClass20.smethod_1().mobMe.method_10(gclass20_1);
                }
              }
            }
            else
            {
              GClass100 gclass100_9 = GClass116.smethod_14(mobId);
              if (gclass100_9 != null)
              {
                if (charId == GClass20.smethod_1().charID)
                {
                  GClass20.smethod_1().cHPNew = num41;
                  if (gclass100_9.isBusyAttackSomeOne)
                  {
                    GClass20.smethod_1().method_108(HPShow, Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
                  }
                  else
                  {
                    gclass100_9.dame = HPShow;
                    gclass100_9.method_10(GClass20.smethod_1());
                  }
                }
                else
                {
                  gclass20_1 = GClass116.smethod_12(charId);
                  if (gclass20_1 != null)
                  {
                    gclass20_1.cHPNew = num41;
                    if (gclass100_9.isBusyAttackSomeOne)
                    {
                      gclass20_1.method_108(HPShow, Class15.smethod_0(0), Class15.smethod_0(0) != 0, Class15.smethod_0(1) != 0);
                    }
                    else
                    {
                      gclass100_9.dame = HPShow;
                      gclass100_9.method_10(gclass20_1);
                    }
                  }
                }
              }
            }
          }
          if ((int) num38 == Class15.smethod_0(5))
          {
            int charId = msg.method_1().method_8();
            int mobId = msg.method_1().method_8();
            int num42 = msg.method_3();
            int num43 = msg.method_3();
            gclass20_2 = (GClass20) null;
            gclass20_1 = GClass20.smethod_1().charID != charId ? GClass116.smethod_12(charId) : GClass20.smethod_1();
            if (gclass20_1 != null)
            {
              GClass100 mobToAttack = GClass116.smethod_14(mobId);
              if (gclass20_1.mobMe != null)
                gclass20_1.mobMe.method_25(mobToAttack);
              if (mobToAttack != null)
              {
                mobToAttack.hp = num42;
                mobToAttack.method_22();
                if (num43 == 0)
                {
                  mobToAttack.x = mobToAttack.xFirst;
                  mobToAttack.y = mobToAttack.yFirst;
                  GClass116.smethod_17(GClass109.string_233, mobToAttack.x, mobToAttack.y - mobToAttack.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_7);
                }
                else
                  GClass116.smethod_17(Class13.smethod_0(121200) + num43.ToString(), mobToAttack.x, mobToAttack.y - mobToAttack.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_8);
              }
            }
          }
          Class15.smethod_0(2);
          if ((int) num38 == Class15.smethod_0(3))
          {
            int charId = msg.method_1().method_8();
            sbyte index17 = msg.method_1().method_2();
            int mobId = msg.method_1().method_8();
            int num44 = msg.method_3();
            int num45 = msg.method_3();
            gclass20_2 = (GClass20) null;
            gclass20_1 = charId != GClass20.smethod_1().charID ? GClass116.smethod_12(charId) : GClass20.smethod_1();
            if (gclass20_1 == null)
              break;
            if ((GClass185.smethod_26(gclass20_1.cx, gclass20_1.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
              gclass20_1.method_65(GClass116.gclass165_0[(int) index17], Class15.smethod_0(0));
            else
              gclass20_1.method_65(GClass116.gclass165_0[(int) index17], Class15.smethod_0(1));
            GClass100 gclass100_10 = GClass116.smethod_14(mobId);
            gclass20_1.cdir = gclass20_1.cx > gclass100_10.x ? -1 : Class15.smethod_0(1);
            gclass20_1.mobFocus = gclass100_10;
            gclass100_10.hp = num45;
            gclass100_10.method_22();
            GClass62.smethod_7(Class13.smethod_0(121193), Class15.smethod_0(7));
            if (num44 == 0)
            {
              gclass100_10.x = gclass100_10.xFirst;
              gclass100_10.y = gclass100_10.yFirst;
              GClass116.smethod_17(GClass109.string_233, gclass100_10.x, gclass100_10.y - gclass100_10.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_7);
            }
            else
              GClass116.smethod_17(Class13.smethod_0(121200) + num44.ToString(), gclass100_10.x, gclass100_10.y - gclass100_10.h, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_8);
          }
          if ((int) num38 == Class15.smethod_0(37))
          {
            int charId = msg.method_1().method_8();
            if (charId == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().mobMe.method_24();
            }
            else
            {
              gclass20_1 = GClass116.smethod_12(charId);
              gclass20_1?.mobMe.method_24();
            }
          }
          if ((int) num38 == Class15.smethod_0(38))
          {
            int charId = msg.method_1().method_8();
            if (charId == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().mobMe = (GClass100) null;
              for (int index18 = Class15.smethod_0(0); index18 < GClass116.gclass134_9.method_2(); index18 += Class15.smethod_0(1))
              {
                if (((GClass100) GClass116.gclass134_9.method_3(index18)).mobId == charId)
                  GClass116.gclass134_9.method_7(index18);
              }
              goto case 1;
            }
            else
            {
              gclass20_1 = GClass116.smethod_12(charId);
              for (int index19 = Class15.smethod_0(0); index19 < GClass116.gclass134_9.method_2(); index19 += Class15.smethod_0(1))
              {
                if (((GClass100) GClass116.gclass134_9.method_3(index19)).mobId == charId)
                  GClass116.gclass134_9.method_7(index19);
              }
              if (gclass20_1 != null)
              {
                gclass20_1.mobMe = (GClass100) null;
                goto case 1;
              }
              else
                goto case 1;
            }
          }
          else
            goto case 1;
        case 18:
          while (msg.method_1().method_18() > Class15.smethod_0(0))
          {
            short num46 = msg.method_1().method_6();
            int num47 = msg.method_1().method_8();
            for (int index20 = Class15.smethod_0(0); index20 < GClass20.smethod_1().vSkill.method_2(); index20 += Class15.smethod_0(1))
            {
              GClass161 gclass161 = (GClass161) GClass20.smethod_1().vSkill.method_3(index20);
              if (gclass161 != null && (int) gclass161.skillId == (int) num46)
              {
                if (num47 < gclass161.coolDown)
                  gclass161.lastTimeUseThisSkill = GClass126.smethod_18() - (long) (gclass161.coolDown - num47);
                string[] strArray4 = new string[Class15.smethod_0(37)];
                strArray4[Class15.smethod_0(0)] = Class13.smethod_0(28251);
                strArray4[Class15.smethod_0(1)] = gclass161.template.id.ToString();
                strArray4[Class15.smethod_0(7)] = Class13.smethod_0(28348);
                strArray4[Class15.smethod_0(5)] = num47.ToString();
                strArray4[Class15.smethod_0(2)] = Class13.smethod_0(28333);
                strArray4[Class15.smethod_0(3)] = gclass161.coolDown.ToString();
                GClass151.smethod_7(string.Concat(strArray4));
              }
            }
          }
          goto case 1;
        case 19:
          short length3 = msg.method_1().method_6();
          GClass18.sbyte_0 = new sbyte[(int) length3];
          for (int index21 = Class15.smethod_0(0); index21 < (int) length3; index21 += Class15.smethod_0(1))
            GClass18.sbyte_0[index21] = msg.method_1().method_2();
          goto case 1;
        case 20:
          Main.int_2 = (int) msg.method_1().method_2();
          GClass152.smethod_13();
          GClass152.smethod_9(Class13.smethod_0(121316), Main.int_2);
          GClass152.smethod_9(Class13.smethod_0(121292), GClass98.int_8);
          GClass62.smethod_32(GClass109.string_240, Class15.smethod_0(269), (object) null);
          goto case 1;
        case 21:
          sbyte length4 = msg.method_1().method_2();
          GClass62.gclass141_0.mapNames = new string[(int) length4];
          GClass62.gclass141_0.planetNames = new string[(int) length4];
          for (int index22 = Class15.smethod_0(0); index22 < (int) length4; index22 += Class15.smethod_0(1))
          {
            GClass62.gclass141_0.mapNames[index22] = msg.method_1().method_14();
            GClass62.gclass141_0.planetNames[index22] = msg.method_1().method_14();
          }
          GClass62.gclass141_0.method_6();
          GClass62.gclass141_0.method_44();
          goto case 1;
        case 22:
          sbyte num48 = msg.method_1().method_2();
          int charId1 = msg.method_1().method_8();
          GClass151.smethod_7(Class13.smethod_0(120854) + num48.ToString());
          gclass20_1 = GClass20.smethod_1().charID != charId1 ? GClass116.smethod_12(charId1) : GClass20.smethod_1();
          if (num48 != (sbyte) -1)
          {
            short num49 = msg.method_1().method_6();
            short num50 = msg.method_1().method_6();
            short num51 = msg.method_1().method_6();
            sbyte num52 = msg.method_1().method_2();
            string[] strArray5 = new string[Class15.smethod_0(88)];
            strArray5[Class15.smethod_0(0)] = Class13.smethod_0(120953);
            strArray5[Class15.smethod_0(1)] = num52.ToString();
            strArray5[Class15.smethod_0(7)] = Class13.smethod_0(120996);
            strArray5[Class15.smethod_0(5)] = num49.ToString();
            strArray5[Class15.smethod_0(2)] = Class13.smethod_0(120985);
            strArray5[Class15.smethod_0(3)] = num50.ToString();
            strArray5[Class15.smethod_0(37)] = Class13.smethod_0(120968);
            strArray5[Class15.smethod_0(38)] = num51.ToString();
            GClass151.smethod_9(string.Concat(strArray5));
            if (gclass20_1 != null)
            {
              if (gclass20_1.charID == charId1)
              {
                gclass20_1.isMask = Class15.smethod_0(1) != 0;
                gclass20_1.isMonkey = num52;
                if (gclass20_1.isMonkey != (sbyte) 0)
                {
                  gclass20_1.isWaitMonkey = Class15.smethod_0(0) != 0;
                  gclass20_1.isLockMove = Class15.smethod_0(0) != 0;
                }
              }
              else if (gclass20_1 != null)
              {
                gclass20_1.isMask = Class15.smethod_0(1) != 0;
                gclass20_1.isMonkey = num52;
              }
              if (num49 != (short) -1)
                gclass20_1.head = (int) num49;
              if (num50 != (short) -1)
                gclass20_1.body = (int) num50;
              if (num51 != (short) -1)
                gclass20_1.leg = (int) num51;
            }
          }
          if (num48 == (sbyte) -1 && gclass20_1 != null)
          {
            gclass20_1.isMask = Class15.smethod_0(0) != 0;
            gclass20_1.isMonkey = (sbyte) Class15.smethod_0(0);
          }
          if (gclass20_1 != null)
            goto case 1;
          else
            goto case 1;
        case 24:
          GClass62.smethod_27();
          GClass62.gclass120_0.vmethod_0();
          goto case 1;
        case 25:
          string str4 = Class13.smethod_0(120960);
          num1 = msg.method_1().method_18();
          string str5 = num1.ToString();
          string str6 = Class13.smethod_0(121646);
          GClass151.smethod_7(str4 + str5 + str6);
          msg.method_1().method_3(Class15.smethod_0(17));
          this.method_4(msg.method_1(), Class15.smethod_0(1) != 0);
          msg.method_1().method_4();
          sbyte[] data1 = new sbyte[msg.method_1().method_18()];
          msg.method_1().method_17(ref data1);
          sbyte[] numArray1 = new sbyte[Class15.smethod_0(1)];
          numArray1[Class15.smethod_0(0)] = GClass116.sbyte_0;
          sbyte[] data2 = numArray1;
          GClass152.smethod_0(Class13.smethod_0(121762), data2);
          GClass117.bool_3 = Class15.smethod_0(0) != 0;
          if ((int) GClass116.sbyte_4 == (int) GClass116.sbyte_0 && (int) GClass116.sbyte_5 == (int) GClass116.sbyte_1 && (int) GClass116.sbyte_6 == (int) GClass116.sbyte_2 && (int) GClass116.sbyte_7 == (int) GClass116.sbyte_3)
          {
            string[] strArray6 = new string[Class15.smethod_0(38)];
            strArray6[Class15.smethod_0(0)] = GClass116.sbyte_4.ToString();
            strArray6[Class15.smethod_0(1)] = Class13.smethod_0(121744);
            strArray6[Class15.smethod_0(7)] = GClass116.sbyte_5.ToString();
            strArray6[Class15.smethod_0(5)] = Class13.smethod_0(121744);
            strArray6[Class15.smethod_0(2)] = GClass116.sbyte_6.ToString();
            strArray6[Class15.smethod_0(3)] = Class13.smethod_0(121744);
            strArray6[Class15.smethod_0(37)] = GClass116.sbyte_7.ToString();
            GClass151.smethod_7(string.Concat(strArray6));
            GClass116.smethod_6().method_22();
            GClass116.smethod_6().method_20();
            GClass116.smethod_6().method_21();
            GClass116.smethod_6().method_23();
            GClass156.smethod_0().method_84();
            break;
          }
          goto case 1;
        case 26:
          sbyte num53 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(121825) + num53.ToString());
          if (num53 == (sbyte) 0)
          {
            int playerID = msg.method_1().method_8();
            GClass116.smethod_6().method_114(playerID);
          }
          if ((int) num53 == Class15.smethod_0(1))
          {
            int num54 = msg.method_1().method_8();
            GClass20 cGD = GClass116.smethod_12(num54);
            if (cGD == null)
              break;
            GClass62.gclass141_0.method_56(cGD);
            GClass62.gclass141_0.method_44();
            GClass156.smethod_0().method_16(num54);
          }
          if ((int) num53 == Class15.smethod_0(7))
          {
            sbyte num55 = msg.method_1().method_2();
            for (int index23 = Class15.smethod_0(0); index23 < GClass62.gclass141_0.vMyGD.method_2(); index23 += Class15.smethod_0(1))
            {
              GClass80 o = (GClass80) GClass62.gclass141_0.vMyGD.method_3(index23);
              if (o.indexUI == (int) num55)
              {
                GClass62.gclass141_0.vMyGD.method_8((object) o);
                break;
              }
            }
          }
          Class15.smethod_0(3);
          if ((int) num53 == Class15.smethod_0(37))
          {
            GClass62.gclass141_0.isFriendLock = Class15.smethod_0(1) != 0;
            if (GClass62.gclass141_1 != null)
              GClass62.gclass141_1.isFriendLock = Class15.smethod_0(1) != 0;
            GClass62.gclass141_0.vFriendGD.method_9();
            if (GClass62.gclass141_1 != null)
              GClass62.gclass141_1.vFriendGD.method_9();
            int num56 = msg.method_1().method_8();
            sbyte num57 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(121407) + num57.ToString());
            for (int index24 = Class15.smethod_0(0); index24 < (int) num57; index24 += Class15.smethod_0(1))
            {
              GClass80 o = new GClass80();
              o.template = GClass86.smethod_1(msg.method_1().method_6());
              o.quantity = msg.method_1().method_8();
              int length5 = (int) msg.method_1().method_5();
              if (length5 != 0)
              {
                o.itemOption = new GClass83[length5];
                for (int index25 = Class15.smethod_0(0); index25 < o.itemOption.Length; index25 += Class15.smethod_0(1))
                {
                  int optionTemplateId = (int) msg.method_1().method_5();
                  int num58 = (int) msg.method_1().method_7();
                  o.itemOption[index25] = new GClass83(optionTemplateId, num58);
                  o.compare = GClass62.gclass141_0.method_124(o);
                }
              }
              if (GClass62.gclass141_1 != null)
                GClass62.gclass141_1.vFriendGD.method_0((object) o);
              else
                GClass62.gclass141_0.vFriendGD.method_0((object) o);
            }
            if (GClass62.gclass141_1 != null)
            {
              GClass62.gclass141_1.method_55(Class15.smethod_0(0) != 0);
              GClass62.gclass141_1.friendMoneyGD = num56;
            }
            else
            {
              GClass62.gclass141_0.friendMoneyGD = num56;
              if (GClass62.gclass141_0.currentTabIndex == Class15.smethod_0(7))
                GClass62.gclass141_0.method_55(Class15.smethod_0(0) != 0);
            }
          }
          if ((int) num53 == Class15.smethod_0(38))
          {
            GClass71.smethod_5();
            if (GClass62.gclass141_0.isShow)
            {
              GClass62.gclass141_0.method_141();
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 27:
          GClass151.smethod_7(Class13.smethod_0(121394));
          int num59 = (int) msg.method_1().method_2();
          if (num59 == 0)
          {
            int lenght = (int) msg.method_1().method_7();
            GClass151.smethod_7(Class13.smethod_0(157223) + lenght.ToString());
            sbyte[] data3 = new sbyte[lenght];
            msg.method_1().method_21(ref data3, Class15.smethod_0(0), lenght);
            GClass116.gclass66_44 = GClass66.smethod_6(data3, Class15.smethod_0(0), lenght);
            GClass116.smethod_6().keyInput = Class13.smethod_0(157278);
            GClass116.smethod_6().strCapcha = msg.method_1().method_14();
            GClass116.smethod_6().keyCapcha = new int[GClass116.smethod_6().strCapcha.Length];
            GClass116.smethod_6().mobCapcha = new GClass100();
            GClass116.smethod_6().right = (GClass31) null;
          }
          if (num59 == Class15.smethod_0(1))
            GClass105.bool_2 = Class15.smethod_0(1) != 0;
          if (num59 == Class15.smethod_0(7))
          {
            GClass105.bool_0 = Class15.smethod_0(1) != 0;
            GClass116.smethod_6().right = GClass116.smethod_6().cmdFocus;
            goto case 1;
          }
          else
            goto case 1;
        case 28:
          int index26 = (int) msg.method_1().method_5();
          GClass100 gclass100_11 = (GClass100) null;
          try
          {
            gclass100_11 = (GClass100) GClass116.gclass134_9.method_3(index26);
          }
          catch (Exception ex)
          {
          }
          if (gclass100_11 != null)
          {
            gclass100_11.maxHp = msg.method_1().method_8();
            goto case 1;
          }
          else
            goto case 1;
        case 29:
          sbyte num60 = msg.method_1().method_2();
          if (num60 == (sbyte) 0)
          {
            int num61 = (int) msg.method_1().method_6();
            int num62 = (int) msg.method_1().method_6();
            int num63 = (int) msg.method_1().method_5();
            int num64 = msg.method_1().method_8();
            msg.method_1().method_14();
            int num65 = (int) msg.method_1().method_6();
            int num66 = (int) msg.method_1().method_6();
            GClass116.smethod_6().isRongNamek = (int) msg.method_1().method_2() != Class15.smethod_0(1) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
            GClass116.smethod_6().xR = num65;
            GClass116.smethod_6().yR = num66;
            string[] strArray7 = new string[Class15.smethod_0(3)];
            strArray7[Class15.smethod_0(0)] = Class13.smethod_0(157260);
            strArray7[Class15.smethod_0(1)] = num65.ToString();
            strArray7[Class15.smethod_0(7)] = Class13.smethod_0(157255);
            strArray7[Class15.smethod_0(5)] = num66.ToString();
            strArray7[Class15.smethod_0(2)] = Class13.smethod_0(157355);
            GClass151.smethod_7(string.Concat(strArray7));
            if (GClass20.smethod_1().charID == num64)
            {
              GClass62.gclass141_0.method_140();
              GClass116.smethod_6().method_51(Class15.smethod_0(1) != 0);
            }
            else if (GClass185.int_37 == num61 && GClass185.int_39 == num63)
              GClass116.smethod_6().method_51(Class15.smethod_0(0) != 0);
            else if (GClass98.int_8 > Class15.smethod_0(1))
              GClass116.smethod_6().method_53();
            GClass116.smethod_6().mapRID = num61;
            GClass116.smethod_6().bgRID = num62;
            GClass116.smethod_6().zoneRID = num63;
          }
          if ((int) num60 == Class15.smethod_0(1))
          {
            GClass151.smethod_7(Class13.smethod_0(157420) + GClass116.smethod_6().mapRID.ToString() + Class13.smethod_0(158140) + GClass116.smethod_6().zoneRID.ToString());
            GClass151.smethod_7(Class13.smethod_0(158207) + GClass185.int_37.ToString() + Class13.smethod_0(157748) + GClass185.int_39.ToString());
            if (GClass185.int_37 == GClass116.smethod_6().mapRID && GClass185.int_39 == GClass116.smethod_6().zoneRID)
            {
              GClass116.smethod_6().method_52();
            }
            else
            {
              GClass116.smethod_6().isRongThanXuatHien = Class15.smethod_0(0) != 0;
              if (GClass116.smethod_6().isRongNamek)
                GClass116.smethod_6().isRongNamek = Class15.smethod_0(0) != 0;
            }
          }
          if ((int) num60 == Class15.smethod_0(7))
            goto case 1;
          else
            goto case 1;
        case 30:
          sbyte length6 = msg.method_1().method_2();
          GClass185.int_64 = new int[(int) length6][][];
          GClass185.int_63 = new int[(int) length6][];
          for (int index27 = Class15.smethod_0(0); index27 < (int) length6; index27 += Class15.smethod_0(1))
          {
            sbyte length7 = msg.method_1().method_2();
            GClass185.int_63[index27] = new int[(int) length7];
            GClass185.int_64[index27] = new int[(int) length7][];
            for (int index28 = Class15.smethod_0(0); index28 < (int) length7; index28 += Class15.smethod_0(1))
            {
              GClass185.int_63[index27][index28] = msg.method_1().method_8();
              sbyte length8 = msg.method_1().method_2();
              GClass185.int_64[index27][index28] = new int[(int) length8];
              for (int index29 = Class15.smethod_0(0); index29 < (int) length8; index29 += Class15.smethod_0(1))
                GClass185.int_64[index27][index28][index29] = (int) msg.method_1().method_2();
            }
          }
          goto case 1;
        case 31:
          sbyte num67 = msg.method_1().method_2();
          if (num67 == (sbyte) 0)
          {
            string src1 = msg.method_1().method_14();
            string src2 = msg.method_1().method_14();
            GClass62.gclass141_0.method_29();
            GClass62.gclass141_0.combineInfo = GClass97.gclass97_2.method_15(src1, GClass141.int_19);
            GClass62.gclass141_0.combineTopInfo = GClass97.gclass97_11.method_15(src2, GClass141.int_19);
            GClass62.gclass141_0.method_44();
          }
          if ((int) num67 == Class15.smethod_0(1))
          {
            GClass62.gclass141_0.vItemCombine.method_9();
            sbyte num68 = msg.method_1().method_2();
            for (int index30 = Class15.smethod_0(0); index30 < (int) num68; index30 += Class15.smethod_0(1))
            {
              sbyte num69 = msg.method_1().method_2();
              for (int index31 = Class15.smethod_0(0); index31 < GClass20.smethod_1().arrItemBag.Length; index31 += Class15.smethod_0(1))
              {
                GClass80 o = GClass20.smethod_1().arrItemBag[index31];
                if (o != null && o.indexUI == (int) num69)
                {
                  o.isSelect = Class15.smethod_0(1) != 0;
                  GClass62.gclass141_0.vItemCombine.method_0((object) o);
                }
              }
            }
            if (GClass62.gclass141_0.isShow)
              GClass62.gclass141_0.method_30();
          }
          if ((int) num67 == Class15.smethod_0(7))
          {
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(0);
            GClass62.gclass141_0.method_185(Class15.smethod_0(0));
          }
          if ((int) num67 == Class15.smethod_0(5))
          {
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(1);
            GClass62.gclass141_0.method_185(Class15.smethod_0(0));
          }
          if ((int) num67 == Class15.smethod_0(2))
          {
            short num70 = msg.method_1().method_6();
            GClass62.gclass141_0.iconID3 = num70;
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(0);
            GClass62.gclass141_0.method_185(Class15.smethod_0(1));
          }
          if ((int) num67 == Class15.smethod_0(3))
          {
            short num71 = msg.method_1().method_6();
            GClass62.gclass141_0.iconID3 = num71;
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(0);
            GClass62.gclass141_0.method_185(Class15.smethod_0(7));
          }
          if ((int) num67 == Class15.smethod_0(37))
          {
            short num72 = msg.method_1().method_6();
            short num73 = msg.method_1().method_6();
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(0);
            GClass62.gclass141_0.method_185(Class15.smethod_0(5));
            GClass62.gclass141_0.iconID1 = num72;
            GClass62.gclass141_0.iconID3 = num73;
          }
          if ((int) num67 == Class15.smethod_0(38))
          {
            short num74 = msg.method_1().method_6();
            GClass62.gclass141_0.iconID3 = num74;
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(0);
            GClass62.gclass141_0.method_185(Class15.smethod_0(2));
          }
          if ((int) num67 == Class15.smethod_0(88))
          {
            GClass62.gclass141_0.iconID3 = (short) -1;
            GClass62.gclass141_0.combineSuccess = (sbyte) Class15.smethod_0(1);
            GClass62.gclass141_0.method_185(Class15.smethod_0(2));
          }
          short num75 = (short) Class15.smethod_0(27);
          try
          {
            num75 = msg.method_1().method_6();
          }
          catch (Exception ex)
          {
          }
          for (int index32 = Class15.smethod_0(0); index32 < GClass116.gclass134_10.method_2(); index32 += Class15.smethod_0(1))
          {
            GClass21 gclass21 = (GClass21) GClass116.gclass134_10.method_3(index32);
            if (gclass21.template.npcTemplateId == (int) num75)
            {
              GClass62.gclass141_0.xS = gclass21.cx - GClass116.int_22;
              GClass62.gclass141_0.yS = gclass21.cy - GClass116.int_23;
              GClass62.gclass141_0.idNPC = (int) num75;
              break;
            }
          }
          goto case 1;
        case 32:
          sbyte num76 = msg.method_1().method_2();
          GClass71.smethod_5();
          if (num76 == (sbyte) 0)
          {
            GClass62.gclass141_0.vFriend.method_9();
            int num77 = (int) msg.method_1().method_5();
            for (int index33 = Class15.smethod_0(0); index33 < num77; index33 += Class15.smethod_0(1))
            {
              GClass20 gclass20_10 = new GClass20();
              gclass20_10.charID = msg.method_1().method_8();
              gclass20_10.head = (int) msg.method_1().method_6();
              gclass20_10.headICON = (int) msg.method_1().method_6();
              gclass20_10.body = (int) msg.method_1().method_6();
              gclass20_10.leg = (int) msg.method_1().method_6();
              gclass20_10.bag = (int) msg.method_1().method_5();
              gclass20_10.cName = msg.method_1().method_14();
              bool flag = msg.method_1().method_11();
              GClass62.gclass141_0.vFriend.method_0((object) new GClass72(GClass109.string_254 + Class13.smethod_0(157799) + msg.method_1().method_14())
              {
                charInfo = gclass20_10,
                isOnline = flag
              });
            }
            GClass62.gclass141_0.method_19();
            GClass62.gclass141_0.method_44();
          }
          if ((int) num76 == Class15.smethod_0(5))
          {
            GClass134 vFriend = GClass62.gclass141_0.vFriend;
            int num78 = msg.method_1().method_8();
            GClass151.smethod_7(Class13.smethod_0(157875) + num78.ToString());
            for (int index34 = Class15.smethod_0(0); index34 < vFriend.method_2(); index34 += Class15.smethod_0(1))
            {
              GClass72 gclass72 = (GClass72) vFriend.method_3(index34);
              if (gclass72.charInfo != null && gclass72.charInfo.charID == num78)
              {
                GClass151.smethod_7(Class13.smethod_0(157937) + gclass72.isOnline.ToString());
                gclass72.isOnline = msg.method_1().method_11();
                break;
              }
            }
          }
          if ((int) num76 == Class15.smethod_0(7))
          {
            GClass134 vFriend = GClass62.gclass141_0.vFriend;
            int num79 = msg.method_1().method_8();
            for (int index35 = Class15.smethod_0(0); index35 < vFriend.method_2(); index35 += Class15.smethod_0(1))
            {
              GClass72 o = (GClass72) vFriend.method_3(index35);
              if (o.charInfo != null && o.charInfo.charID == num79)
              {
                vFriend.method_8((object) o);
                break;
              }
            }
            if (GClass62.gclass141_0.isShow)
            {
              GClass62.gclass141_0.method_23();
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 33:
          GClass71.smethod_5();
          msg.method_1().method_8();
          GClass20 charMenu = GClass62.gclass141_0.charMenu;
          if (charMenu == null)
            break;
          charMenu.cPower = msg.method_1().method_9();
          charMenu.currStrLevel = msg.method_1().method_14();
          goto case 1;
        case 35:
          short length9 = msg.method_1().method_6();
          GClass169.sbyte_0 = new sbyte[(int) length9];
          GClass169.short_0 = length9;
          GClass169.gclass192_0 = new GClass192[(int) length9];
          for (int index36 = Class15.smethod_0(0); index36 < (int) length9; index36 += Class15.smethod_0(1))
            GClass169.sbyte_0[index36] = msg.method_1().method_2();
          goto case 1;
        case 36:
          sbyte num80 = msg.method_1().method_2();
          if (num80 == (sbyte) 0)
          {
            sbyte length10 = msg.method_1().method_2();
            if ((int) length10 <= Class15.smethod_0(0))
              break;
            GClass20.smethod_1().arrArchive = new GClass0[(int) length10];
            for (int index37 = Class15.smethod_0(0); index37 < (int) length10; index37 += Class15.smethod_0(1))
            {
              GClass20.smethod_1().arrArchive[index37] = new GClass0();
              GClass20.smethod_1().arrArchive[index37].info1 = (index37 + Class15.smethod_0(1)).ToString() + Class13.smethod_0(158518) + msg.method_1().method_14();
              GClass20.smethod_1().arrArchive[index37].info2 = msg.method_1().method_14();
              GClass20.smethod_1().arrArchive[index37].money = (int) msg.method_1().method_6();
              GClass20.smethod_1().arrArchive[index37].isFinish = msg.method_1().method_11();
              GClass20.smethod_1().arrArchive[index37].isRecieve = msg.method_1().method_11();
            }
            GClass62.gclass141_0.method_9();
            GClass62.gclass141_0.method_44();
            goto case 1;
          }
          else if ((int) num80 == Class15.smethod_0(1))
          {
            int index38 = (int) msg.method_1().method_5();
            if (GClass20.smethod_1().arrArchive[index38] != null)
            {
              GClass20.smethod_1().arrArchive[index38].isRecieve = Class15.smethod_0(1) != 0;
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 38:
          if (GClass120.bool_2)
            break;
          if (!GClass62.smethod_38())
          {
            GClass156.smethod_0().method_125((sbyte) Class15.smethod_0(5), (GClass134) null);
            GClass169.smethod_0();
            GClass122.gclass66_0 = (GClass66) null;
            if (GClass152.smethod_2(Class13.smethod_0(152928)) != null || GClass152.smethod_2(Class13.smethod_0(153007) + GClass120.int_12.ToString()) != null)
              GClass117.bool_0 = Class15.smethod_0(1) != 0;
            GClass62.gclass117_0 = new GClass117();
            GClass62.gclass117_0.vmethod_0();
            break;
          }
          bool flag1 = Class15.smethod_0(1) != 0;
          sbyte num81 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(153067) + num81.ToString());
          if (num81 == (sbyte) 0)
          {
            int num82 = msg.method_1().method_8();
            string s = GClass152.smethod_2(Class13.smethod_0(152624));
            int num83 = s == null || !(s != string.Empty) ? -1 : int.Parse(s);
            if (num83 != -1 && num83 == num82)
            {
              GClass151.smethod_7(Class13.smethod_0(152702));
              GClass169.smethod_0();
              GClass122.gclass66_0 = (GClass66) null;
              GClass120.bool_6 = Class15.smethod_0(1) != 0;
              if (GClass62.gclass113_0 != GClass62.gclass117_0)
                GClass62.gclass120_0.vmethod_0();
            }
            else
            {
              GClass120.bool_6 = Class15.smethod_0(0) != 0;
              GClass62.gclass120_0.method_7();
            }
          }
          if ((int) num81 == Class15.smethod_0(1))
          {
            GClass120.string_11 = GClass109.string_87;
            GClass120.int_15 = (int) msg.method_1().method_6();
            GClass156.smethod_0().method_125((sbyte) Class15.smethod_0(7), (GClass134) null);
          }
          if ((int) num81 == Class15.smethod_0(7))
          {
            try
            {
              GClass32.bool_0 = Class15.smethod_0(1) != 0;
              GClass62.smethod_27();
              GClass120.int_17 += Class15.smethod_0(1);
              GClass120.int_14 = GClass120.int_17 * Class15.smethod_0(21) / GClass120.int_15;
              string[] strArray8 = GClass151.smethod_27(msg.method_1().method_14(), Class13.smethod_0(152739), Class15.smethod_0(0));
              string filename = Class13.smethod_0(152824) + GClass98.int_8.ToString() + strArray8[strArray8.Length - Class15.smethod_0(1)];
              int length11 = msg.method_1().method_8();
              sbyte[] data4 = new sbyte[length11];
              msg.method_1().method_21(ref data4, Class15.smethod_0(0), length11);
              sbyte[] data5 = data4;
              GClass152.smethod_0(filename, data5);
            }
            catch (Exception ex)
            {
              GClass62.smethod_32(GClass109.string_89, Class15.smethod_0(269), (object) null);
            }
          }
          if ((int) num81 == Class15.smethod_0(5) & flag1)
          {
            GClass32.bool_0 = Class15.smethod_0(0) != 0;
            int num84 = msg.method_1().method_8();
            GClass151.smethod_7(Class13.smethod_0(152804) + num84.ToString());
            GClass152.smethod_4(Class13.smethod_0(152624), num84.ToString() + string.Empty);
            GClass156.smethod_0().method_125((sbyte) Class15.smethod_0(5), (GClass134) null);
            GClass62.smethod_27();
            GClass122.gclass66_0 = (GClass66) null;
            GClass169.smethod_0();
            GClass126.smethod_26();
            GClass120.bool_4 = Class15.smethod_0(1) != 0;
            GClass120.bool_6 = Class15.smethod_0(1) != 0;
            GClass116.smethod_6().method_24();
            if (GClass62.gclass113_0 != GClass62.gclass117_0)
            {
              GClass62.gclass120_0.vmethod_0();
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 42:
          GClass151.smethod_7(Class13.smethod_0(136945));
          GClass62.smethod_27();
          int num85 = (int) msg.method_1().method_6();
          string chat1 = msg.method_1().method_14();
          GClass21 gclass21_1 = new GClass21(-1, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0));
          gclass21_1.avatar = num85;
          int howLong = Class15.smethod_0(17);
          GClass21 c1 = gclass21_1;
          GClass43.smethod_2(chat1, howLong, c1);
          int num86 = (int) msg.method_1().method_2();
          if (num86 == 0)
          {
            GClass43.gclass43_1.cmdMsg1 = new GClass31(GClass109.string_125, (GInterface0) GClass43.gclass43_1, Class15.smethod_0(94), (object) null);
            GClass43.gclass43_1.cmdMsg1.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(95);
            GClass43.gclass43_1.cmdMsg1.y = GClass62.int_11 - Class15.smethod_0(95);
          }
          if (num86 == Class15.smethod_0(1))
          {
            string p = msg.method_1().method_14();
            string caption = msg.method_1().method_14();
            GClass43.gclass43_1.cmdMsg1 = new GClass31(caption, (GInterface0) GClass43.gclass43_1, Class15.smethod_0(15), (object) p);
            GClass43.gclass43_1.cmdMsg1.x = GClass62.int_10 / Class15.smethod_0(7) - Class15.smethod_0(62);
            GClass43.gclass43_1.cmdMsg1.y = GClass62.int_11 - Class15.smethod_0(95);
            GClass43.gclass43_1.cmdMsg2 = new GClass31(GClass109.string_125, (GInterface0) GClass43.gclass43_1, Class15.smethod_0(94), (object) null);
            GClass43.gclass43_1.cmdMsg2.x = GClass62.int_10 / Class15.smethod_0(7) + Class15.smethod_0(67);
            GClass43.gclass43_1.cmdMsg2.y = GClass62.int_11 - Class15.smethod_0(95);
            goto case 1;
          }
          else
            goto case 1;
        case 43:
          GClass20.smethod_1().cMaxStamina = msg.method_1().method_6();
          goto case 1;
        case 44:
          GClass20.smethod_1().cStamina = (int) msg.method_1().method_6();
          goto case 1;
        case 45:
          GClass151.smethod_7(Class13.smethod_0(150535));
          this.float_0 += Class15.smethod_2(16);
          int index39 = msg.method_1().method_8();
          sbyte[] numArray2;
          try
          {
            numArray2 = GClass138.smethod_2(msg);
            GClass151.smethod_7(Class13.smethod_0(150603) + index39.ToString());
            if (index39 == Class15.smethod_0(273))
              GClass151.smethod_7(Class13.smethod_0(150664) + numArray2.Length.ToString());
            GClass169.gclass192_0[index39].img = this.method_5(numArray2);
          }
          catch (Exception ex)
          {
            numArray2 = (sbyte[]) null;
            GClass169.gclass192_0[index39].img = GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0);
          }
          if (numArray2 != null)
          {
            GClass152.smethod_0(GClass98.int_8.ToString() + Class13.smethod_0(150762) + index39.ToString(), numArray2);
            goto case 1;
          }
          else
            goto case 1;
        case 46:
          int id1 = (int) msg.method_1().method_6();
          sbyte[] data6 = GClass138.smethod_2(msg);
          GClass50 gclass50 = GClass41.smethod_2(id1);
          sbyte typeread1 = msg.method_1().method_0();
          if (typeread1 == (sbyte) 0)
            gclass50.method_7(data6);
          else
            gclass50.method_8(data6, typeread1);
          sbyte[] imageData1 = GClass138.smethod_2(msg);
          gclass50.img = GClass66.smethod_6(imageData1, Class15.smethod_0(0), imageData1.Length);
          GClass151.smethod_7(Class13.smethod_0(150725));
          if (id1 == Class15.smethod_0(63))
          {
            sbyte length12 = msg.method_1().method_2();
            short[][] numArray3 = new short[(int) length12][];
            for (int index40 = Class15.smethod_0(0); index40 < (int) length12; index40 += Class15.smethod_0(1))
            {
              int length13 = (int) msg.method_1().method_5();
              numArray3[index40] = new short[length13];
              for (int index41 = Class15.smethod_0(0); index41 < length13; index41 += Class15.smethod_0(1))
                numArray3[index40][index41] = msg.method_1().method_6();
            }
            gclass50.anim_data = numArray3;
            goto case 1;
          }
          else
            goto case 1;
        case 47:
          GClass151.smethod_7(Class13.smethod_0(153394));
          GClass71.smethod_5();
          int charId2 = msg.method_1().method_8();
          sbyte num87 = msg.method_1().method_2();
          if (num87 != (sbyte) 0)
          {
            if (GClass20.smethod_1().charID == charId2)
            {
              GClass32.bool_5 = Class15.smethod_0(1) != 0;
              GClass116.int_38 = Class15.smethod_0(16);
              GClass116.smethod_6().center = (GClass31) null;
              if (num87 == (sbyte) 0 || (int) num87 == Class15.smethod_0(1) || (int) num87 == Class15.smethod_0(5))
                GClass182.smethod_0(new GClass182(GClass20.smethod_1().cx, GClass20.smethod_1().cy, GClass20.smethod_1().head, GClass20.smethod_1().cdir, Class15.smethod_0(0), Class15.smethod_0(1) != 0, (int) num87 != Class15.smethod_0(1) ? (int) num87 : GClass20.smethod_1().cgender));
              if ((int) num87 == Class15.smethod_0(7))
              {
                GClass116.int_38 = Class15.smethod_0(32);
                GClass20.smethod_1().method_33();
                goto case 1;
              }
              else
                goto case 1;
            }
            else
            {
              GClass20 gclass20_11 = GClass116.smethod_12(charId2);
              if ((num87 == (sbyte) 0 || (int) num87 == Class15.smethod_0(1) || (int) num87 == Class15.smethod_0(5)) && gclass20_11 != null)
              {
                gclass20_11.isUsePlane = Class15.smethod_0(1) != 0;
                GClass182.smethod_0(new GClass182(gclass20_11.cx, gclass20_11.cy, gclass20_11.head, gclass20_11.cdir, Class15.smethod_0(0), Class15.smethod_0(0) != 0, (int) num87 != Class15.smethod_0(1) ? (int) num87 : gclass20_11.cgender)
                {
                  id = charId2
                });
              }
              if ((int) num87 == Class15.smethod_0(7))
              {
                gclass20_11.method_33();
                goto case 1;
              }
              else
                goto case 1;
            }
          }
          else
            goto case 1;
        case 48:
          int charId3 = msg.method_1().method_8();
          int num88 = (int) msg.method_1().method_5();
          gclass20_2 = (GClass20) null;
          gclass20_1 = charId3 != GClass20.smethod_1().charID ? GClass116.smethod_12(charId3) : GClass20.smethod_1();
          gclass20_1.bag = num88;
          if (gclass20_1.bag >= Class15.smethod_0(218) && gclass20_1.bag < Class15.smethod_0(270))
          {
            gclass20_1.method_136(new GClass41(gclass20_1.bag, gclass20_1, Class15.smethod_0(7), -1, Class15.smethod_0(31), (sbyte) Class15.smethod_0(1))
            {
              typeEff = Class15.smethod_0(3)
            });
          }
          else
          {
            for (int index42 = Class15.smethod_0(0); index42 < Class15.smethod_0(271); index42 += Class15.smethod_0(1))
              gclass20_1.method_137(Class15.smethod_0(0), Class15.smethod_0(218) + index42);
          }
          string[] strArray9 = new string[Class15.smethod_0(3)];
          strArray9[Class15.smethod_0(0)] = Class13.smethod_0(153443);
          strArray9[Class15.smethod_0(1)] = gclass20_1 != null ? gclass20_1.cName : string.Empty;
          strArray9[Class15.smethod_0(7)] = charId3.ToString();
          strArray9[Class15.smethod_0(5)] = Class13.smethod_0(153505);
          strArray9[Class15.smethod_0(2)] = num88.ToString();
          GClass151.smethod_7(string.Concat(strArray9));
          goto case 1;
        case 49:
          GClass151.smethod_7(Class13.smethod_0(153493));
          int num89 = (int) msg.method_1().method_5();
          sbyte length14 = msg.method_1().method_2();
          GClass26 v = new GClass26();
          v.ID = num89;
          if ((int) length14 > Class15.smethod_0(0))
          {
            v.idImage = new short[(int) length14];
            for (int index43 = Class15.smethod_0(0); index43 < (int) length14; index43 += Class15.smethod_0(1))
            {
              v.idImage[index43] = msg.method_1().method_6();
              GClass151.smethod_7(Class13.smethod_0(153599) + num89.ToString() + Class13.smethod_0(153548) + v.idImage[index43].ToString());
            }
            GClass26.gclass128_0.method_4((object) (num89.ToString() + string.Empty), (object) v);
            goto case 1;
          }
          else
            goto case 1;
        case 50:
          int ID = (int) msg.method_1().method_5();
          sbyte length15 = msg.method_1().method_2();
          if ((int) length15 > Class15.smethod_0(0))
          {
            GClass26 gclass26 = GClass26.smethod_1((short) ID);
            if (gclass26 != null)
            {
              gclass26.idImage = new short[(int) length15];
              for (int index44 = Class15.smethod_0(0); index44 < (int) length15; index44 += Class15.smethod_0(1))
              {
                gclass26.idImage[index44] = msg.method_1().method_6();
                if ((int) gclass26.idImage[index44] > Class15.smethod_0(0))
                  GClass169.gclass134_0.method_0((object) (gclass26.idImage[index44].ToString() + string.Empty));
              }
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 51:
          int charId4 = msg.method_1().method_8();
          if (charId4 != GClass20.smethod_1().charID)
          {
            if (GClass116.smethod_12(charId4) != null)
            {
              GClass116.smethod_12(charId4).clanID = msg.method_1().method_8();
              if (GClass116.smethod_12(charId4).clanID == Class15.smethod_0(132))
              {
                GClass116.smethod_12(charId4).isCopy = Class15.smethod_0(1) != 0;
                goto case 1;
              }
              else
                goto case 1;
            }
            else
              goto case 1;
          }
          else if (GClass20.smethod_1().clan != null)
          {
            GClass20.smethod_1().clan.ID = msg.method_1().method_8();
            goto case 1;
          }
          else
            goto case 1;
        case 52:
          GClass62.smethod_7(Class13.smethod_0(134155), Class15.smethod_0(7));
          int charId5 = msg.method_1().method_8();
          int charId6 = -1;
          if (charId5 != GClass20.smethod_1().charID)
          {
            GClass20 gclass20_12 = GClass116.smethod_12(charId5);
            if (gclass20_12 == null)
              break;
            if (gclass20_12.currentMovePoint != null)
            {
              gclass20_12.method_75(gclass20_12.cx, gclass20_12.cy, Class15.smethod_0(31));
              gclass20_12.cx = gclass20_12.currentMovePoint.xEnd;
              gclass20_12.cy = gclass20_12.currentMovePoint.yEnd;
            }
            int index45 = (int) msg.method_1().method_5();
            GClass151.smethod_7(Class13.smethod_0(134929) + index45.ToString());
            if ((GClass185.smethod_26(gclass20_12.cx, gclass20_12.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
              gclass20_12.method_65(GClass116.gclass165_0[index45], Class15.smethod_0(0));
            else
              gclass20_12.method_65(GClass116.gclass165_0[index45], Class15.smethod_0(1));
            sbyte length16 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(135102) + length16.ToString());
            GClass20[] gclass20Array = new GClass20[(int) length16];
            int length17;
            for (length17 = Class15.smethod_0(0); length17 < gclass20Array.Length; length17 += Class15.smethod_0(1))
            {
              charId6 = msg.method_1().method_8();
              GClass20 gclass20_13;
              if (charId6 == GClass20.smethod_1().charID)
              {
                gclass20_13 = GClass20.smethod_1();
                if (!GClass116.bool_56 && GClass116.bool_54 && GClass116.bool_55)
                  GClass116.bool_56 = Class15.smethod_0(1) != 0;
              }
              else
                gclass20_13 = GClass116.smethod_12(charId6);
              gclass20Array[length17] = gclass20_13;
              if (length17 == 0)
                gclass20_12.cdir = gclass20_12.cx > gclass20_13.cx ? -1 : Class15.smethod_0(1);
            }
            if (length17 > Class15.smethod_0(0))
            {
              gclass20_12.attChars = new GClass20[length17];
              for (int index46 = Class15.smethod_0(0); index46 < gclass20_12.attChars.Length; index46 += Class15.smethod_0(1))
                gclass20_12.attChars[index46] = gclass20Array[index46];
              gclass20_12.mobFocus = (GClass100) null;
              gclass20_12.charFocus = gclass20_12.attChars[Class15.smethod_0(0)];
            }
          }
          else
          {
            int num90 = (int) msg.method_1().method_2();
            int num91 = (int) msg.method_1().method_2();
            charId6 = msg.method_1().method_8();
          }
          try
          {
            sbyte num92 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(135068) + num92.ToString());
            if ((int) num92 == Class15.smethod_0(1))
            {
              sbyte num93 = msg.method_1().method_2();
              GClass151.smethod_7(Class13.smethod_0(135157) + num93.ToString());
              if (charId6 == GClass20.smethod_1().charID)
              {
                bool flag2 = Class15.smethod_0(0) != 0;
                gclass20_1 = GClass20.smethod_1();
                int num94 = msg.method_3();
                GClass151.smethod_7(Class13.smethod_0(143707) + num94.ToString());
                gclass20_1.isDie = msg.method_1().method_11();
                if (gclass20_1.isDie)
                  GClass20.bool_3 = Class15.smethod_0(1) != 0;
                GClass151.smethod_7(Class13.smethod_0(192954) + gclass20_1.isDie.ToString() + Class13.smethod_0(193000));
                int num95 = Class15.smethod_0(0);
                bool isCrit = gclass20_1.isCrit = msg.method_1().method_11();
                gclass20_1.isMob = Class15.smethod_0(0) != 0;
                int HPShow = gclass20_1.damHP = num94 + num95;
                if (num93 == (sbyte) 0)
                {
                  gclass20_1.method_108(HPShow, Class15.smethod_0(0), isCrit, Class15.smethod_0(0) != 0);
                  goto case 1;
                }
                else
                  goto case 1;
              }
              else
              {
                gclass20_1 = GClass116.smethod_12(charId6);
                if (gclass20_1 == null)
                  break;
                bool flag3 = Class15.smethod_0(0) != 0;
                int num96 = msg.method_3();
                GClass151.smethod_7(Class13.smethod_0(192556) + num96.ToString());
                gclass20_1.isDie = msg.method_1().method_11();
                GClass151.smethod_7(Class13.smethod_0(192954) + gclass20_1.isDie.ToString() + Class13.smethod_0(193000));
                int num97 = Class15.smethod_0(0);
                bool isCrit = gclass20_1.isCrit = msg.method_1().method_11();
                gclass20_1.isMob = Class15.smethod_0(0) != 0;
                int HPShow = gclass20_1.damHP = num96 + num97;
                if (num93 == (sbyte) 0)
                {
                  gclass20_1.method_108(HPShow, Class15.smethod_0(0), isCrit, Class15.smethod_0(0) != 0);
                  goto case 1;
                }
                else
                  goto case 1;
              }
            }
            else
              goto case 1;
          }
          catch (Exception ex)
          {
            goto case 1;
          }
        case 53:
          sbyte typePK = msg.method_1().method_2();
          GClass116.smethod_6().method_113(msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_14(), typePK);
          goto case 1;
        case 55:
          string strInvite = msg.method_1().method_14();
          int clanID = msg.method_1().method_8();
          int code = msg.method_1().method_8();
          GClass116.smethod_6().method_28(strInvite, clanID, code);
          goto case 1;
        case 59:
          GClass71.smethod_5();
          bool flag4 = Class15.smethod_0(0) != 0;
          int num98 = msg.method_1().method_8();
          GClass151.smethod_7(Class13.smethod_0(153134) + num98.ToString());
          if (num98 == -1)
          {
            bool flag5 = Class15.smethod_0(1) != 0;
            GClass20.smethod_1().clan = (GClass25) null;
            GClass28.gclass134_0.method_9();
            if (GClass62.gclass141_0.member != null)
              GClass62.gclass141_0.member.method_9();
            if (GClass62.gclass141_0.myMember != null)
              GClass62.gclass141_0.myMember.method_9();
            if (GClass62.gclass113_0 != GClass116.smethod_6())
              break;
            GClass62.gclass141_0.method_73();
            break;
          }
          GClass62.gclass141_0.tabIcon = (GClass178) null;
          if (GClass20.smethod_1().clan == null)
            GClass20.smethod_1().clan = new GClass25();
          GClass20.smethod_1().clan.ID = num98;
          GClass20.smethod_1().clan.name = msg.method_1().method_14();
          GClass20.smethod_1().clan.slogan = msg.method_1().method_14();
          GClass20.smethod_1().clan.imgID = (int) msg.method_1().method_5();
          GClass20.smethod_1().clan.powerPoint = msg.method_1().method_14();
          GClass20.smethod_1().clan.leaderName = msg.method_1().method_14();
          GClass20.smethod_1().clan.currMember = (int) msg.method_1().method_5();
          GClass20.smethod_1().clan.maxMember = (int) msg.method_1().method_5();
          GClass20.smethod_1().role = msg.method_1().method_2();
          GClass20.smethod_1().clan.clanPoint = msg.method_1().method_8();
          GClass20.smethod_1().clan.level = (int) msg.method_1().method_2();
          GClass62.gclass141_0.myMember = new GClass134();
          for (int index47 = Class15.smethod_0(0); index47 < GClass20.smethod_1().clan.currMember; index47 += Class15.smethod_0(1))
            GClass62.gclass141_0.myMember.method_0((object) new GClass94()
            {
              ID = msg.method_1().method_8(),
              head = msg.method_1().method_6(),
              headICON = msg.method_1().method_6(),
              leg = msg.method_1().method_6(),
              body = msg.method_1().method_6(),
              name = msg.method_1().method_14(),
              role = msg.method_1().method_2(),
              powerPoint = msg.method_1().method_14(),
              donate = msg.method_1().method_8(),
              receive_donate = msg.method_1().method_8(),
              clanPoint = msg.method_1().method_8(),
              curClanPoint = msg.method_1().method_8(),
              joinTime = GClass138.smethod_6(msg.method_1().method_8())
            });
          int num99 = (int) msg.method_1().method_5();
          for (int index48 = Class15.smethod_0(0); index48 < num99; index48 += Class15.smethod_0(1))
            this.method_7(msg, -1);
          if (GClass62.gclass141_0.isSearchClan || GClass62.gclass141_0.isViewMember || GClass62.gclass141_0.isMessage)
            GClass62.gclass141_0.method_73();
          if (flag4)
            GClass62.gclass141_0.method_73();
          GClass151.smethod_7(Class13.smethod_0(153094));
          goto case 1;
        case 60:
          int num100 = (int) msg.method_1().method_2();
          if (num100 == 0)
          {
            GClass94 o = new GClass94();
            o.ID = msg.method_1().method_8();
            o.head = msg.method_1().method_6();
            o.headICON = msg.method_1().method_6();
            o.leg = msg.method_1().method_6();
            o.body = msg.method_1().method_6();
            o.name = msg.method_1().method_14();
            o.role = msg.method_1().method_2();
            o.powerPoint = msg.method_1().method_14();
            o.donate = msg.method_1().method_8();
            o.receive_donate = msg.method_1().method_8();
            o.clanPoint = msg.method_1().method_8();
            o.joinTime = GClass138.smethod_6(msg.method_1().method_8());
            if (GClass62.gclass141_0.myMember == null)
              GClass62.gclass141_0.myMember = new GClass134();
            GClass62.gclass141_0.myMember.method_0((object) o);
            GClass62.gclass141_0.method_72();
          }
          if (num100 == Class15.smethod_0(1))
          {
            GClass62.gclass141_0.myMember.method_7((int) msg.method_1().method_2());
            GClass62.gclass141_0.currentListLength -= Class15.smethod_0(1);
            GClass62.gclass141_0.method_72();
          }
          if (num100 == Class15.smethod_0(7))
          {
            GClass94 gclass94 = new GClass94();
            gclass94.ID = msg.method_1().method_8();
            gclass94.head = msg.method_1().method_6();
            gclass94.headICON = msg.method_1().method_6();
            gclass94.leg = msg.method_1().method_6();
            gclass94.body = msg.method_1().method_6();
            gclass94.name = msg.method_1().method_14();
            gclass94.role = msg.method_1().method_2();
            gclass94.powerPoint = msg.method_1().method_14();
            gclass94.donate = msg.method_1().method_8();
            gclass94.receive_donate = msg.method_1().method_8();
            gclass94.clanPoint = msg.method_1().method_8();
            gclass94.joinTime = GClass138.smethod_6(msg.method_1().method_8());
            for (int index49 = Class15.smethod_0(0); index49 < GClass62.gclass141_0.myMember.method_2(); index49 += Class15.smethod_0(1))
            {
              GClass94 o1 = (GClass94) GClass62.gclass141_0.myMember.method_3(index49);
              if (o1.ID == gclass94.ID)
              {
                if (GClass20.smethod_1().charID == gclass94.ID)
                  GClass20.smethod_1().role = gclass94.role;
                GClass94 o2 = gclass94;
                GClass62.gclass141_0.myMember.method_8((object) o1);
                GClass62.gclass141_0.myMember.method_10((object) o2, index49);
                return;
              }
            }
          }
          GClass151.smethod_7(Class13.smethod_0(154117));
          goto case 1;
        case 61:
          GClass71.smethod_5();
          this.method_7(msg, Class15.smethod_0(0));
          if (GClass62.gclass141_0.isMessage && GClass62.gclass141_0.type == Class15.smethod_0(3))
          {
            GClass62.gclass141_0.method_72();
            goto case 1;
          }
          else
            goto case 1;
        case 62:
          GClass71.smethod_5();
          GClass62.gclass141_0.member = new GClass134();
          sbyte num101 = msg.method_1().method_2();
          for (int index50 = Class15.smethod_0(0); index50 < (int) num101; index50 += Class15.smethod_0(1))
            GClass62.gclass141_0.member.method_0((object) new GClass94()
            {
              ID = msg.method_1().method_8(),
              head = msg.method_1().method_6(),
              headICON = msg.method_1().method_6(),
              leg = msg.method_1().method_6(),
              body = msg.method_1().method_6(),
              name = msg.method_1().method_14(),
              role = msg.method_1().method_2(),
              powerPoint = msg.method_1().method_14(),
              donate = msg.method_1().method_8(),
              receive_donate = msg.method_1().method_8(),
              clanPoint = msg.method_1().method_8(),
              joinTime = GClass138.smethod_6(msg.method_1().method_8())
            });
          GClass62.gclass141_0.isViewMember = Class15.smethod_0(1) != 0;
          GClass62.gclass141_0.isSearchClan = Class15.smethod_0(0) != 0;
          GClass62.gclass141_0.isMessage = Class15.smethod_0(0) != 0;
          GClass62.gclass141_0.currentListLength = GClass62.gclass141_0.member.method_2() + Class15.smethod_0(7);
          GClass62.gclass141_0.method_72();
          goto case 1;
        case 65:
          GClass71.smethod_5();
          sbyte length18 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(154199) + length18.ToString());
          if (length18 == (sbyte) 0)
          {
            GClass62.gclass141_0.clanReport = GClass109.string_291;
            GClass62.gclass141_0.clans = (GClass25[]) null;
          }
          else
          {
            GClass62.gclass141_0.clans = new GClass25[(int) length18];
            GClass151.smethod_7(Class13.smethod_0(154932) + GClass62.gclass141_0.clans.Length.ToString());
            for (int index51 = Class15.smethod_0(0); index51 < GClass62.gclass141_0.clans.Length; index51 += Class15.smethod_0(1))
            {
              GClass62.gclass141_0.clans[index51] = new GClass25();
              GClass62.gclass141_0.clans[index51].ID = msg.method_1().method_8();
              GClass62.gclass141_0.clans[index51].name = msg.method_1().method_14();
              GClass62.gclass141_0.clans[index51].slogan = msg.method_1().method_14();
              GClass62.gclass141_0.clans[index51].imgID = (int) msg.method_1().method_5();
              GClass62.gclass141_0.clans[index51].powerPoint = msg.method_1().method_14();
              GClass62.gclass141_0.clans[index51].leaderName = msg.method_1().method_14();
              GClass62.gclass141_0.clans[index51].currMember = (int) msg.method_1().method_5();
              GClass62.gclass141_0.clans[index51].maxMember = (int) msg.method_1().method_5();
              GClass62.gclass141_0.clans[index51].date = msg.method_1().method_8();
            }
          }
          GClass62.gclass141_0.isSearchClan = Class15.smethod_0(1) != 0;
          GClass62.gclass141_0.isViewMember = Class15.smethod_0(0) != 0;
          GClass62.gclass141_0.isMessage = Class15.smethod_0(0) != 0;
          if (GClass62.gclass141_0.isSearchClan)
          {
            GClass62.gclass141_0.method_72();
            goto case 1;
          }
          else
            goto case 1;
        case 66:
          GClass71.smethod_5();
          sbyte num102 = msg.method_1().method_2();
          if ((int) num102 == Class15.smethod_0(1) || (int) num102 == Class15.smethod_0(5))
          {
            GClass62.smethod_27();
            GClass26.gclass134_0.method_9();
            int num103 = (int) msg.method_1().method_5();
            for (int index52 = Class15.smethod_0(0); index52 < num103; index52 += Class15.smethod_0(1))
            {
              GClass26 cm = new GClass26();
              cm.ID = (int) msg.method_1().method_5();
              cm.name = msg.method_1().method_14();
              cm.xu = msg.method_1().method_8();
              cm.luong = msg.method_1().method_8();
              if (!GClass26.smethod_2(cm.ID))
              {
                GClass26.smethod_0(cm);
              }
              else
              {
                GClass26.smethod_1((short) cm.ID).name = cm.name;
                GClass26.smethod_1((short) cm.ID).xu = cm.xu;
                GClass26.smethod_1((short) cm.ID).luong = cm.luong;
              }
            }
            if (GClass20.smethod_1().clan != null)
              GClass62.gclass141_0.method_167();
          }
          if ((int) num102 == Class15.smethod_0(2))
          {
            GClass20.smethod_1().clan.imgID = (int) msg.method_1().method_5();
            GClass20.smethod_1().clan.slogan = msg.method_1().method_14();
            goto case 1;
          }
          else
            goto case 1;
        case 67:
          sbyte num104 = msg.method_1().method_2();
          int charId7 = msg.method_1().method_8();
          short index53 = msg.method_1().method_6();
          GClass151.smethod_7(Class13.smethod_0(149103) + num104.ToString() + Class13.smethod_0(149065) + charId7.ToString());
          if (num104 == (sbyte) 0)
          {
            GClass151.smethod_7(Class13.smethod_0(149173) + charId7.ToString());
            if (GClass20.smethod_1().charID != charId7)
            {
              gclass20_1 = GClass116.smethod_12(charId7);
              if ((GClass185.smethod_26(gclass20_1.cx, gclass20_1.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
              {
                gclass20_1.method_65(GClass116.gclass165_0[(int) index53], Class15.smethod_0(0));
              }
              else
              {
                gclass20_1.method_65(GClass116.gclass165_0[(int) index53], Class15.smethod_0(1));
                gclass20_1.delayFall = Class15.smethod_0(51);
              }
            }
            else
            {
              GClass20.smethod_1().method_25();
              GClass151.smethod_7(Class13.smethod_0(149137));
            }
            sbyte num105 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(149953) + num105.ToString());
            for (int index54 = Class15.smethod_0(0); index54 < (int) num105; index54 += Class15.smethod_0(1))
            {
              sbyte index55 = msg.method_1().method_2();
              sbyte num106 = msg.method_1().method_2();
              GClass151.smethod_7(Class13.smethod_0(149620) + index55.ToString());
              if ((int) index53 >= Class15.smethod_0(108) && (int) index53 <= Class15.smethod_0(154))
              {
                ((GClass100) GClass116.gclass134_9.method_3((int) index55)).isFreez = Class15.smethod_0(1) != 0;
                ((GClass100) GClass116.gclass134_9.method_3((int) index55)).seconds = (int) num106;
                ((GClass100) GClass116.gclass134_9.method_3((int) index55)).last = ((GClass100) GClass116.gclass134_9.method_3((int) index55)).cur = GClass126.smethod_18();
              }
            }
            sbyte num107 = msg.method_1().method_2();
            for (int index56 = Class15.smethod_0(0); index56 < (int) num107; index56 += Class15.smethod_0(1))
            {
              int charId8 = msg.method_1().method_8();
              sbyte num108 = msg.method_1().method_2();
              GClass151.smethod_7(Class13.smethod_0(149596) + charId8.ToString() + Class13.smethod_0(149686) + GClass20.smethod_1().charID.ToString());
              if ((int) index53 >= Class15.smethod_0(108) && (int) index53 <= Class15.smethod_0(154))
              {
                if (charId8 == GClass20.smethod_1().charID)
                {
                  if (!GClass20.smethod_1().isFlyAndCharge && !GClass20.smethod_1().isStandAndCharge)
                  {
                    GClass116.smethod_6().isFreez = Class15.smethod_0(1) != 0;
                    GClass20.smethod_1().isFreez = Class15.smethod_0(1) != 0;
                    GClass20.smethod_1().freezSeconds = (int) num108;
                    GClass20.smethod_1().lastFreez = GClass20.smethod_1().currFreez = GClass126.smethod_18();
                    GClass20.smethod_1().isLockMove = Class15.smethod_0(1) != 0;
                  }
                }
                else
                {
                  gclass20_1 = GClass116.smethod_12(charId8);
                  if (gclass20_1 != null && !gclass20_1.isFlyAndCharge && !gclass20_1.isStandAndCharge)
                  {
                    gclass20_1.isFreez = Class15.smethod_0(1) != 0;
                    gclass20_1.seconds = (int) num108;
                    gclass20_1.freezSeconds = (int) num108;
                    gclass20_1.lastFreez = GClass116.smethod_12(charId8).currFreez = GClass126.smethod_18();
                  }
                }
              }
            }
          }
          if ((int) num104 == Class15.smethod_0(1) && charId7 != GClass20.smethod_1().charID)
            GClass116.smethod_12(charId7).isCharge = Class15.smethod_0(1) != 0;
          if ((int) num104 == Class15.smethod_0(5))
          {
            if (charId7 == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().isCharge = Class15.smethod_0(0) != 0;
              GClass172.smethod_1().method_45();
              GClass20.smethod_1().method_25();
            }
            else
              GClass116.smethod_12(charId7).isCharge = Class15.smethod_0(0) != 0;
          }
          if ((int) num104 == Class15.smethod_0(2))
          {
            if (charId7 == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().seconds = (int) msg.method_1().method_6() - Class15.smethod_0(15);
              GClass20.smethod_1().last = GClass126.smethod_18();
              GClass151.smethod_7(Class13.smethod_0(149733) + GClass20.smethod_1().seconds.ToString() + Class13.smethod_0(150508) + GClass20.smethod_1().last.ToString());
            }
            else if (GClass116.smethod_12(charId7) != null)
            {
              int cgender = GClass116.smethod_12(charId7).cgender;
              if (cgender != 0)
              {
                if (cgender == Class15.smethod_0(1))
                  GClass116.smethod_12(charId7).method_69(Class15.smethod_0(1) != 0);
              }
              else
                GClass116.smethod_12(charId7).method_69(Class15.smethod_0(0) != 0);
              GClass116.smethod_12(charId7).skillTemplateId = (int) index53;
              GClass116.smethod_12(charId7).isUseSkillAfterCharge = Class15.smethod_0(1) != 0;
              GClass116.smethod_12(charId7).seconds = (int) msg.method_1().method_6();
              GClass116.smethod_12(charId7).last = GClass126.smethod_18();
            }
          }
          if ((int) num104 == Class15.smethod_0(3))
          {
            if (charId7 == GClass20.smethod_1().charID)
              GClass20.smethod_1().method_68();
            else if (GClass116.smethod_12(charId7) != null)
              GClass116.smethod_12(charId7).method_68();
          }
          if ((int) num104 == Class15.smethod_0(37))
          {
            if (charId7 == GClass20.smethod_1().charID)
              GClass20.smethod_1().method_70(GClass116.gclass165_0[(int) index53], Class15.smethod_0(0));
            else if (GClass116.smethod_12(charId7) != null)
            {
              GClass116.smethod_12(charId7).method_70(GClass116.gclass165_0[(int) index53], Class15.smethod_0(0));
              GClass172.smethod_1().method_8();
            }
          }
          if ((int) num104 == Class15.smethod_0(38))
          {
            if (charId7 == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().seconds = (int) msg.method_1().method_6();
              GClass151.smethod_7(Class13.smethod_0(150019) + GClass20.smethod_1().seconds.ToString());
              GClass20.smethod_1().last = GClass126.smethod_18();
            }
            else if (GClass116.smethod_12(charId7) != null)
            {
              GClass116.smethod_12(charId7).method_69(Class15.smethod_0(1) != 0);
              GClass116.smethod_12(charId7).seconds = (int) msg.method_1().method_6();
              GClass116.smethod_12(charId7).last = GClass126.smethod_18();
              GClass172.smethod_1().method_8();
            }
          }
          if ((int) num104 == Class15.smethod_0(88) && charId7 != GClass20.smethod_1().charID && GClass116.smethod_12(charId7) != null)
          {
            GClass116.smethod_12(charId7).method_70(GClass116.gclass165_0[(int) index53], Class15.smethod_0(0));
            goto case 1;
          }
          else
            goto case 1;
        case 68:
          bool flag6 = Class15.smethod_0(0) != 0;
          if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
            flag6 = Class15.smethod_0(1) != 0;
          sbyte typeShop = msg.method_1().method_2();
          int length19 = (int) msg.method_1().method_5();
          GClass20.smethod_1().arrItemShop = new GClass80[length19][];
          GClass62.gclass141_0.shopTabName = new string[length19 + (!flag6 ? Class15.smethod_0(1) : Class15.smethod_0(0))][];
          for (int index57 = Class15.smethod_0(0); index57 < GClass62.gclass141_0.shopTabName.Length; index57 += Class15.smethod_0(1))
            GClass62.gclass141_0.shopTabName[index57] = new string[Class15.smethod_0(7)];
          if ((int) typeShop == Class15.smethod_0(7))
          {
            GClass62.gclass141_0.maxPageShop = new int[length19];
            GClass62.gclass141_0.currPageShop = new int[length19];
          }
          if (!flag6)
            GClass62.gclass141_0.shopTabName[length19] = GClass109.string_198;
          for (int index58 = Class15.smethod_0(0); index58 < length19; index58 += Class15.smethod_0(1))
          {
            string[] strArray10 = GClass151.smethod_27(msg.method_1().method_14(), Class13.smethod_0(28253), Class15.smethod_0(0));
            if ((int) typeShop == Class15.smethod_0(7))
              GClass62.gclass141_0.maxPageShop[index58] = (int) msg.method_1().method_5();
            if (strArray10.Length == Class15.smethod_0(7))
              GClass62.gclass141_0.shopTabName[index58] = strArray10;
            if (strArray10.Length == Class15.smethod_0(1))
            {
              GClass62.gclass141_0.shopTabName[index58][Class15.smethod_0(0)] = strArray10[Class15.smethod_0(0)];
              GClass62.gclass141_0.shopTabName[index58][Class15.smethod_0(1)] = string.Empty;
            }
            int length20 = (int) msg.method_1().method_5();
            GClass20.smethod_1().arrItemShop[index58] = new GClass80[length20];
            GClass141.string_12 = GClass109.string_339;
            if ((int) typeShop == Class15.smethod_0(1))
              GClass141.string_12 = GClass109.string_340;
            for (int index59 = Class15.smethod_0(0); index59 < length20; index59 += Class15.smethod_0(1))
            {
              short id2 = msg.method_1().method_6();
              if (id2 != (short) -1)
              {
                GClass20.smethod_1().arrItemShop[index58][index59] = new GClass80();
                GClass20.smethod_1().arrItemShop[index58][index59].template = GClass86.smethod_1(id2);
                string[] strArray11 = new string[Class15.smethod_0(37)];
                strArray11[Class15.smethod_0(0)] = Class13.smethod_0(150205);
                strArray11[Class15.smethod_0(1)] = index58.ToString();
                strArray11[Class15.smethod_0(7)] = Class13.smethod_0(150181);
                strArray11[Class15.smethod_0(5)] = GClass20.smethod_1().arrItemShop[index58][index59].template.name;
                strArray11[Class15.smethod_0(2)] = Class13.smethod_0(150267);
                strArray11[Class15.smethod_0(3)] = GClass20.smethod_1().arrItemShop[index58][index59].template.id.ToString();
                GClass151.smethod_7(string.Concat(strArray11));
                if ((int) typeShop == Class15.smethod_0(88))
                {
                  GClass20.smethod_1().arrItemShop[index58][index59].buyCoin = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].buyGold = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].quantity = msg.method_1().method_8();
                }
                else if ((int) typeShop == Class15.smethod_0(2))
                  GClass20.smethod_1().arrItemShop[index58][index59].reason = msg.method_1().method_14();
                else if (typeShop == (sbyte) 0)
                {
                  GClass20.smethod_1().arrItemShop[index58][index59].buyCoin = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].buyGold = msg.method_1().method_8();
                }
                else if ((int) typeShop == Class15.smethod_0(1))
                  GClass20.smethod_1().arrItemShop[index58][index59].powerRequire = msg.method_1().method_9();
                else if ((int) typeShop == Class15.smethod_0(7))
                {
                  GClass20.smethod_1().arrItemShop[index58][index59].itemId = (int) msg.method_1().method_6();
                  GClass20.smethod_1().arrItemShop[index58][index59].buyCoin = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].buyGold = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].buyType = msg.method_1().method_2();
                  GClass20.smethod_1().arrItemShop[index58][index59].quantity = msg.method_1().method_8();
                  GClass20.smethod_1().arrItemShop[index58][index59].isMe = msg.method_1().method_2();
                }
                else if ((int) typeShop == Class15.smethod_0(5))
                {
                  GClass20.smethod_1().arrItemShop[index58][index59].isBuySpec = Class15.smethod_0(1) != 0;
                  GClass20.smethod_1().arrItemShop[index58][index59].iconSpec = msg.method_1().method_6();
                  GClass20.smethod_1().arrItemShop[index58][index59].buySpec = msg.method_1().method_8();
                }
                int length21 = (int) msg.method_1().method_5();
                if (length21 != 0)
                {
                  GClass20.smethod_1().arrItemShop[index58][index59].itemOption = new GClass83[length21];
                  for (int index60 = Class15.smethod_0(0); index60 < GClass20.smethod_1().arrItemShop[index58][index59].itemOption.Length; index60 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num109 = (int) msg.method_1().method_7();
                    GClass20.smethod_1().arrItemShop[index58][index59].itemOption[index60] = new GClass83(optionTemplateId, num109);
                    GClass20.smethod_1().arrItemShop[index58][index59].compare = GClass62.gclass141_0.method_124(GClass20.smethod_1().arrItemShop[index58][index59]);
                  }
                }
                sbyte num110 = msg.method_1().method_2();
                GClass20.smethod_1().arrItemShop[index58][index59].newItem = num110 != (sbyte) 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
                if ((int) msg.method_1().method_2() == Class15.smethod_0(1))
                {
                  int headTemp = (int) msg.method_1().method_6();
                  int bodyTemp = (int) msg.method_1().method_6();
                  int legTemp = (int) msg.method_1().method_6();
                  int bagTemp = (int) msg.method_1().method_6();
                  GClass20.smethod_1().arrItemShop[index58][index59].method_19(headTemp, bodyTemp, legTemp, bagTemp);
                }
              }
            }
          }
          if (flag6)
          {
            if ((int) typeShop != Class15.smethod_0(7))
            {
              GClass62.gclass141_1 = new GClass141();
              string[][][] tabName = GClass62.gclass141_1.tabName;
              int index61 = Class15.smethod_0(38);
              string[][] strArray12 = new string[Class15.smethod_0(1)][];
              int index62 = Class15.smethod_0(0);
              string[] strArray13 = new string[Class15.smethod_0(1)];
              strArray13[Class15.smethod_0(0)] = string.Empty;
              strArray12[index62] = strArray13;
              tabName[index61] = strArray12;
              GClass62.gclass141_1.method_12();
              GClass62.gclass141_1.method_44();
            }
            else
            {
              GClass62.gclass141_1 = new GClass141();
              GClass62.gclass141_1.method_10();
              GClass62.gclass141_1.method_44();
            }
          }
          GClass62.gclass141_0.tabName[Class15.smethod_0(1)] = GClass62.gclass141_0.shopTabName;
          if ((int) typeShop == Class15.smethod_0(7))
          {
            string[][] strArray14 = GClass62.gclass141_0.tabName[Class15.smethod_0(1)];
            if (flag6)
            {
              string[][][] tabName = GClass62.gclass141_0.tabName;
              int index63 = Class15.smethod_0(1);
              string[][] strArray15 = new string[Class15.smethod_0(2)][];
              strArray15[Class15.smethod_0(0)] = strArray14[Class15.smethod_0(0)];
              strArray15[Class15.smethod_0(1)] = strArray14[Class15.smethod_0(1)];
              strArray15[Class15.smethod_0(7)] = strArray14[Class15.smethod_0(7)];
              strArray15[Class15.smethod_0(5)] = strArray14[Class15.smethod_0(5)];
              tabName[index63] = strArray15;
            }
            else
            {
              string[][][] tabName = GClass62.gclass141_0.tabName;
              int index64 = Class15.smethod_0(1);
              string[][] strArray16 = new string[Class15.smethod_0(3)][];
              strArray16[Class15.smethod_0(0)] = strArray14[Class15.smethod_0(0)];
              strArray16[Class15.smethod_0(1)] = strArray14[Class15.smethod_0(1)];
              strArray16[Class15.smethod_0(7)] = strArray14[Class15.smethod_0(7)];
              strArray16[Class15.smethod_0(5)] = strArray14[Class15.smethod_0(5)];
              strArray16[Class15.smethod_0(2)] = strArray14[Class15.smethod_0(2)];
              tabName[index64] = strArray16;
            }
          }
          GClass62.gclass141_0.method_27((int) typeShop);
          GClass62.gclass141_0.method_44();
          goto case 1;
        case 69:
          sbyte itemAction = msg.method_1().method_2();
          sbyte where = msg.method_1().method_2();
          sbyte index65 = msg.method_1().method_2();
          string info1 = msg.method_1().method_14();
          GClass62.gclass141_0.method_183(itemAction, info1, where, index65);
          goto case 1;
        case 70:
          GClass20.smethod_1().cHPGoc = msg.method_3();
          GClass20.smethod_1().cMPGoc = msg.method_3();
          GClass20.smethod_1().cDamGoc = msg.method_1().method_8();
          GClass20.smethod_1().cHPFull = msg.method_3();
          GClass20.smethod_1().cMPFull = msg.method_3();
          GClass20.smethod_1().cHP = msg.method_3();
          GClass20.smethod_1().cMP = msg.method_3();
          GClass20.smethod_1().cspeed = (int) msg.method_1().method_2();
          GClass20.smethod_1().hpFrom1000TiemNang = msg.method_1().method_2();
          GClass20.smethod_1().mpFrom1000TiemNang = msg.method_1().method_2();
          GClass20.smethod_1().damFrom1000TiemNang = msg.method_1().method_2();
          GClass20.smethod_1().cDamFull = msg.method_1().method_8();
          GClass20.smethod_1().cDefull = msg.method_1().method_8();
          GClass20.smethod_1().cCriticalFull = (int) msg.method_1().method_2();
          GClass20.smethod_1().cTiemNang = msg.method_1().method_9();
          GClass20.smethod_1().expForOneAdd = msg.method_1().method_6();
          GClass20.smethod_1().cDefGoc = (int) msg.method_1().method_6();
          GClass20.smethod_1().cCriticalGoc = (int) msg.method_1().method_2();
          GClass71.smethod_5();
          goto case 1;
        case 71:
          sbyte length22 = msg.method_1().method_2();
          GClass20.smethod_1().strLevel = new string[(int) length22];
          for (int index66 = Class15.smethod_0(0); index66 < (int) length22; index66 += Class15.smethod_0(1))
          {
            string str7 = msg.method_1().method_14();
            GClass20.smethod_1().strLevel[index66] = str7;
          }
          GClass151.smethod_7(Class13.smethod_0(150237) + msg.command.ToString());
          goto case 1;
        case 75:
          sbyte num111 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(155424) + num111.ToString());
          if (num111 == (sbyte) 0)
          {
            GClass20.smethod_1().head = (int) msg.method_1().method_6();
            GClass20.smethod_1().method_58();
            int length23 = (int) msg.method_1().method_5();
            GClass151.smethod_7(Class13.smethod_0(155042) + length23.ToString());
            GClass20.smethod_1().arrItemBody = new GClass80[length23];
            for (int index67 = Class15.smethod_0(0); index67 < length23; index67 += Class15.smethod_0(1))
            {
              short id3 = msg.method_1().method_6();
              if (id3 != (short) -1)
              {
                GClass20.smethod_1().arrItemBody[index67] = new GClass80();
                GClass20.smethod_1().arrItemBody[index67].template = GClass86.smethod_1(id3);
                int type = (int) GClass20.smethod_1().arrItemBody[index67].template.type;
                GClass20.smethod_1().arrItemBody[index67].quantity = msg.method_1().method_8();
                GClass20.smethod_1().arrItemBody[index67].info = msg.method_1().method_14();
                GClass20.smethod_1().arrItemBody[index67].content = msg.method_1().method_14();
                int length24 = (int) msg.method_1().method_5();
                if (length24 != 0)
                {
                  GClass20.smethod_1().arrItemBody[index67].itemOption = new GClass83[length24];
                  for (int index68 = Class15.smethod_0(0); index68 < GClass20.smethod_1().arrItemBody[index67].itemOption.Length; index68 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num112 = (int) msg.method_1().method_7();
                    GClass20.smethod_1().arrItemBody[index67].itemOption[index68] = new GClass83(optionTemplateId, num112);
                  }
                }
                if (type != 0)
                {
                  if (type == Class15.smethod_0(1))
                    GClass20.smethod_1().leg = (int) GClass20.smethod_1().arrItemBody[index67].template.part;
                }
                else
                  GClass20.smethod_1().body = (int) GClass20.smethod_1().arrItemBody[index67].template.part;
              }
            }
            goto case 1;
          }
          else
            goto case 1;
        case 76:
          sbyte num113 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(155424) + num113.ToString());
          if (num113 == (sbyte) 0)
          {
            int length25 = (int) msg.method_1().method_5();
            GClass20.smethod_1().arrItemBag = new GClass80[length25];
            GClass116.int_37 = Class15.smethod_0(0);
            GClass151.smethod_7(Class13.smethod_0(149447) + length25.ToString());
            for (int index69 = Class15.smethod_0(0); index69 < length25; index69 += Class15.smethod_0(1))
            {
              short id4 = msg.method_1().method_6();
              if (id4 != (short) -1)
              {
                GClass20.smethod_1().arrItemBag[index69] = new GClass80();
                GClass20.smethod_1().arrItemBag[index69].template = GClass86.smethod_1(id4);
                GClass20.smethod_1().arrItemBag[index69].quantity = msg.method_1().method_8();
                GClass20.smethod_1().arrItemBag[index69].info = msg.method_1().method_14();
                GClass20.smethod_1().arrItemBag[index69].content = msg.method_1().method_14();
                GClass20.smethod_1().arrItemBag[index69].indexUI = index69;
                int length26 = (int) msg.method_1().method_5();
                if (length26 != 0)
                {
                  GClass20.smethod_1().arrItemBag[index69].itemOption = new GClass83[length26];
                  for (int index70 = Class15.smethod_0(0); index70 < GClass20.smethod_1().arrItemBag[index69].itemOption.Length; index70 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num114 = (int) msg.method_1().method_7();
                    GClass20.smethod_1().arrItemBag[index69].itemOption[index70] = new GClass83(optionTemplateId, num114);
                  }
                  GClass20.smethod_1().arrItemBag[index69].compare = GClass62.gclass141_0.method_124(GClass20.smethod_1().arrItemBag[index69]);
                }
                int type = (int) GClass20.smethod_1().arrItemBag[index69].template.type;
                Class15.smethod_0(67);
                if ((int) GClass20.smethod_1().arrItemBag[index69].template.type == Class15.smethod_0(37))
                  GClass116.int_37 += GClass20.smethod_1().arrItemBag[index69].quantity;
              }
            }
          }
          if ((int) num113 == Class15.smethod_0(7))
          {
            sbyte index71 = msg.method_1().method_2();
            int num115 = msg.method_1().method_8();
            int quantity = GClass20.smethod_1().arrItemBag[(int) index71].quantity;
            GClass20.smethod_1().arrItemBag[(int) index71].quantity = num115;
            if (GClass20.smethod_1().arrItemBag[(int) index71].quantity < quantity && (int) GClass20.smethod_1().arrItemBag[(int) index71].template.type == Class15.smethod_0(37))
              GClass116.int_37 -= quantity - GClass20.smethod_1().arrItemBag[(int) index71].quantity;
            if (GClass20.smethod_1().arrItemBag[(int) index71].quantity == 0)
            {
              GClass20.smethod_1().arrItemBag[(int) index71] = (GClass80) null;
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 77:
          sbyte num116 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(155424) + num116.ToString());
          if (num116 == (sbyte) 0)
          {
            int length27 = (int) msg.method_1().method_5();
            GClass20.smethod_1().arrItemBox = new GClass80[length27];
            GClass62.gclass141_0.hasUse = Class15.smethod_0(0);
            for (int index72 = Class15.smethod_0(0); index72 < length27; index72 += Class15.smethod_0(1))
            {
              short id5 = msg.method_1().method_6();
              if (id5 != (short) -1)
              {
                GClass20.smethod_1().arrItemBox[index72] = new GClass80();
                GClass20.smethod_1().arrItemBox[index72].template = GClass86.smethod_1(id5);
                GClass20.smethod_1().arrItemBox[index72].quantity = msg.method_1().method_8();
                GClass20.smethod_1().arrItemBox[index72].info = msg.method_1().method_14();
                GClass20.smethod_1().arrItemBox[index72].content = msg.method_1().method_14();
                int length28 = (int) msg.method_1().method_5();
                if (length28 != 0)
                {
                  GClass20.smethod_1().arrItemBox[index72].itemOption = new GClass83[length28];
                  for (int index73 = Class15.smethod_0(0); index73 < GClass20.smethod_1().arrItemBox[index72].itemOption.Length; index73 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num117 = (int) msg.method_1().method_7();
                    GClass20.smethod_1().arrItemBox[index72].itemOption[index73] = new GClass83(optionTemplateId, num117);
                  }
                }
                GClass62.gclass141_0.hasUse += Class15.smethod_0(1);
              }
            }
          }
          if ((int) num116 == Class15.smethod_0(1))
          {
            bool flag7 = Class15.smethod_0(0) != 0;
            try
            {
              if ((int) msg.method_1().method_2() == Class15.smethod_0(1))
                flag7 = Class15.smethod_0(1) != 0;
            }
            catch (Exception ex)
            {
            }
            GClass62.gclass141_0.method_28();
            GClass62.gclass141_0.isBoxClan = flag7;
            GClass62.gclass141_0.method_44();
          }
          if ((int) num116 == Class15.smethod_0(7))
          {
            sbyte index74 = msg.method_1().method_2();
            int num118 = msg.method_1().method_8();
            GClass20.smethod_1().arrItemBox[(int) index74].quantity = num118;
            if (GClass20.smethod_1().arrItemBox[(int) index74].quantity == 0)
            {
              GClass20.smethod_1().arrItemBox[(int) index74] = (GClass80) null;
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
        case 78:
          sbyte num119 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(150804) + num119.ToString());
          if (num119 == (sbyte) 0 && GClass116.smethod_6().magicTree != null)
          {
            GClass151.smethod_7(Class13.smethod_0(150883));
            GClass22 magicTree = GClass116.smethod_6().magicTree;
            magicTree.id = (int) msg.method_1().method_6();
            magicTree.name = msg.method_1().method_14();
            magicTree.name = GClass151.smethod_14(magicTree.name);
            magicTree.x = (int) msg.method_1().method_6();
            magicTree.y = (int) msg.method_1().method_6();
            magicTree.level = (int) msg.method_1().method_2();
            magicTree.currPeas = (int) msg.method_1().method_6();
            magicTree.maxPeas = (int) msg.method_1().method_6();
            GClass151.smethod_7(Class13.smethod_0(150971) + magicTree.currPeas.ToString());
            magicTree.strInfo = msg.method_1().method_14();
            magicTree.seconds = msg.method_1().method_8();
            magicTree.timeToRecieve = magicTree.seconds;
            sbyte length29 = msg.method_1().method_2();
            magicTree.peaPostionX = new int[(int) length29];
            magicTree.peaPostionY = new int[(int) length29];
            for (int index75 = Class15.smethod_0(0); index75 < (int) length29; index75 += Class15.smethod_0(1))
            {
              magicTree.peaPostionX[index75] = (int) msg.method_1().method_2();
              magicTree.peaPostionY[index75] = (int) msg.method_1().method_2();
            }
            magicTree.isUpdate = msg.method_1().method_10();
            magicTree.last = magicTree.cur = GClass126.smethod_18();
            GClass116.smethod_6().magicTree.isUpdateTree = Class15.smethod_0(1) != 0;
          }
          if ((int) num119 == Class15.smethod_0(1))
          {
            GClass134 menuItems = new GClass134();
            try
            {
              while (msg.method_1().method_18() > Class15.smethod_0(0))
              {
                string caption = msg.method_1().method_14();
                menuItems.method_0((object) new GClass31(caption, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(272), (object) null));
              }
            }
            catch (Exception ex)
            {
              GClass33.smethod_0(Class13.smethod_0(151029) + ex.ToString());
            }
            GClass62.gclass95_0.method_2(menuItems, Class15.smethod_0(5));
          }
          if ((int) num119 == Class15.smethod_0(7))
          {
            GClass116.smethod_6().magicTree.remainPeas = (int) msg.method_1().method_6();
            GClass116.smethod_6().magicTree.seconds = msg.method_1().method_8();
            GClass116.smethod_6().magicTree.last = GClass116.smethod_6().magicTree.cur = GClass126.smethod_18();
            GClass116.smethod_6().magicTree.isUpdateTree = Class15.smethod_0(1) != 0;
            GClass116.smethod_6().magicTree.isPeasEffect = Class15.smethod_0(1) != 0;
            goto case 1;
          }
          else
            goto case 1;
        case 80:
          short id6 = msg.method_1().method_6();
          int lenght1 = msg.method_1().method_8();
          GClass66 gclass66_1 = (GClass66) null;
          sbyte[] numArray4;
          try
          {
            numArray4 = new sbyte[lenght1];
            for (int index76 = Class15.smethod_0(0); index76 < lenght1; index76 += Class15.smethod_0(1))
              numArray4[index76] = msg.method_1().method_2();
            gclass66_1 = GClass66.smethod_6(numArray4, Class15.smethod_0(0), lenght1);
            GClass18.gclass128_0.method_4((object) (id6.ToString() + string.Empty), (object) gclass66_1);
          }
          catch (Exception ex)
          {
            numArray4 = (sbyte[]) null;
            GClass18.gclass128_0.method_4((object) (id6.ToString() + string.Empty), (object) GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0));
          }
          if (numArray4 != null)
          {
            if (GClass98.int_8 > Class15.smethod_0(1))
              GClass152.smethod_0(GClass98.int_8.ToString() + Class13.smethod_0(151319) + id6.ToString(), numArray4);
            GClass19.smethod_2(id6, gclass66_1);
            goto case 1;
          }
          else
            goto case 1;
        case 81:
          GClass185.gclass134_1.method_9();
          short num120 = msg.method_1().method_6();
          GClass33.smethod_3(Class13.smethod_0(132049) + num120.ToString());
          for (int index77 = Class15.smethod_0(0); index77 < (int) num120; index77 += Class15.smethod_0(1))
          {
            GClass18 o = new GClass18();
            o.id = index77;
            o.idImage = msg.method_1().method_6();
            o.layer = msg.method_1().method_2();
            o.dx = (int) msg.method_1().method_6();
            o.dy = (int) msg.method_1().method_6();
            sbyte length30 = msg.method_1().method_2();
            o.tileX = new int[(int) length30];
            o.tileY = new int[(int) length30];
            for (int index78 = Class15.smethod_0(0); index78 < (int) length30; index78 += Class15.smethod_0(1))
            {
              o.tileX[index77] = (int) msg.method_1().method_2();
              o.tileY[index77] = (int) msg.method_1().method_2();
            }
            GClass185.gclass134_1.method_0((object) o);
          }
          goto case 1;
        case 82:
          this.method_13(msg);
          goto case 1;
        case 83:
          this.method_12(msg);
          goto case 1;
        case 84:
          this.method_11(msg);
          goto case 1;
        case 86:
          GClass120.int_20 = Class15.smethod_0(7);
          GClass62.smethod_7(Class13.smethod_0(151407), Class15.smethod_0(7));
          GClass62.smethod_28(msg.method_1().method_14());
          GClass71.smethod_5();
          GClass117.bool_0 = Class15.smethod_0(0) != 0;
          GClass20.bool_4 = Class15.smethod_0(0) != 0;
          if (GClass62.gclass113_0 == GClass62.gclass117_0)
          {
            GClass62.gclass120_0.vmethod_0();
            goto case 1;
          }
          else
            goto case 1;
        case 87:
          GClass62.smethod_7(Class13.smethod_0(151479), Class15.smethod_0(7));
          GClass116.gclass73_0.method_7(msg.method_1().method_14(), Class15.smethod_0(0));
          goto case 1;
        case 88:
          GClass20.bool_4 = Class15.smethod_0(1) != 0;
          GClass33.smethod_0(Class13.smethod_0(131178));
          GClass116.smethod_6().magicTree = (GClass22) null;
          GClass62.bool_4 = Class15.smethod_0(1) != 0;
          GClass62.smethod_7(Class13.smethod_0(131298), Class15.smethod_0(7));
          GClass116.smethod_5();
          GClass62.smethod_27();
          GClass185.gclass134_0.method_9();
          GClass148.gclass134_0.method_9();
          GClass126.smethod_26();
          GClass185.int_37 = (int) msg.method_1().method_5();
          GClass185.sbyte_2 = msg.method_1().method_2();
          GClass185.int_25 = (int) msg.method_1().method_2();
          GClass185.int_40 = (int) msg.method_1().method_2();
          string[] strArray17 = new string[Class15.smethod_0(3)];
          strArray17[Class15.smethod_0(0)] = Class13.smethod_0(131899);
          strArray17[Class15.smethod_0(1)] = GClass185.sbyte_2.ToString();
          strArray17[Class15.smethod_0(7)] = Class13.smethod_0(131967);
          strArray17[Class15.smethod_0(5)] = GClass185.int_41.ToString();
          strArray17[Class15.smethod_0(2)] = Class13.smethod_0(131913);
          GClass33.smethod_0(string.Concat(strArray17));
          GClass185.int_43 = (int) msg.method_1().method_2();
          GClass185.string_1 = msg.method_1().method_14();
          GClass185.int_39 = (int) msg.method_1().method_2();
          GClass62.smethod_7(Class13.smethod_0(132077), Class15.smethod_0(7));
          try
          {
            GClass185.smethod_23(GClass185.int_37);
          }
          catch (Exception ex)
          {
            GClass156.smethod_0().method_93(GClass185.int_37);
            this.messWait = msg;
            break;
          }
          this.method_9(msg);
          try
          {
            GClass185.bool_0 = msg.method_1().method_2() != (sbyte) 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
          }
          catch (Exception ex)
          {
          }
          GClass116.int_22 = GClass116.int_28;
          GClass116.int_23 = GClass116.int_29;
          goto case 1;
        case 90:
          GClass62.smethod_7(Class13.smethod_0(136385), Class15.smethod_0(7));
          GClass20.bool_3 = Class15.smethod_0(1) != 0;
          GClass20.bool_2 = Class15.smethod_0(1) != 0;
          GClass116.smethod_6().timeStartMap = Class15.smethod_0(0);
          GClass116.smethod_6().timeLengthMap = Class15.smethod_0(0);
          GClass20.smethod_1().mobFocus = (GClass100) null;
          GClass20.smethod_1().npcFocus = (GClass21) null;
          GClass20.smethod_1().charFocus = (GClass20) null;
          GClass20.smethod_1().itemFocus = (GClass81) null;
          GClass20.smethod_1().focus.method_9();
          GClass20.smethod_1().testCharId = Class15.smethod_0(180);
          GClass20.smethod_1().killCharId = Class15.smethod_0(180);
          GClass62.smethod_17();
          GClass116.smethod_6().method_34();
          GClass116.smethod_6().center = (GClass31) null;
          goto case 1;
        case 91:
          GClass62.smethod_7(Class13.smethod_0(143166), Class15.smethod_0(7));
          short num121 = msg.method_1().method_6();
          for (int index79 = Class15.smethod_0(0); index79 < GClass116.gclass134_6.method_2(); index79 += Class15.smethod_0(1))
          {
            if (((GClass81) GClass116.gclass134_6.method_3(index79)).itemMapID == (int) num121)
            {
              GClass116.gclass134_6.method_7(index79);
              break;
            }
          }
          goto case 1;
        case 92:
          GClass62.smethod_7(Class13.smethod_0(143135), Class15.smethod_0(7));
          GClass20.smethod_1().itemFocus = (GClass81) null;
          short num122 = msg.method_1().method_6();
          for (int index80 = Class15.smethod_0(0); index80 < GClass116.gclass134_6.method_2(); index80 += Class15.smethod_0(1))
          {
            GClass81 gclass81 = (GClass81) GClass116.gclass134_6.method_3(index80);
            if (gclass81.itemMapID == (int) num122)
            {
              gclass81.method_0(GClass20.smethod_1().cx, GClass20.smethod_1().cy - Class15.smethod_0(31));
              string s = msg.method_1().method_14();
              int num123 = Class15.smethod_0(0);
              try
              {
                num123 = (int) msg.method_1().method_6();
                if ((int) gclass81.template.type == Class15.smethod_0(45))
                {
                  num123 = (int) msg.method_1().method_6();
                  GClass20.smethod_1().xu += (long) num123;
                  GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
                }
                else if ((int) gclass81.template.type == Class15.smethod_0(31))
                {
                  num123 = (int) msg.method_1().method_6();
                  GClass20.smethod_1().luong += num123;
                  GClass20.smethod_1().luongStr = GClass126.smethod_6((long) GClass20.smethod_1().luong);
                }
                else if ((int) gclass81.template.type == Class15.smethod_0(117))
                {
                  num123 = (int) msg.method_1().method_6();
                  GClass20.smethod_1().luongKhoa += num123;
                  GClass20.smethod_1().luongKhoaStr = GClass126.smethod_6((long) GClass20.smethod_1().luongKhoa);
                }
              }
              catch (Exception ex)
              {
              }
              if (s.Equals(string.Empty))
              {
                if ((int) gclass81.template.type == Class15.smethod_0(45))
                {
                  GClass116.smethod_17((num123 >= Class15.smethod_0(0) ? Class13.smethod_0(136021) : string.Empty) + num123.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_4);
                  GClass172.smethod_1().method_9();
                }
                else if ((int) gclass81.template.type == Class15.smethod_0(31))
                {
                  GClass116.smethod_17((num123 >= Class15.smethod_0(0) ? Class13.smethod_0(136021) : string.Empty) + num123.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_5);
                  GClass172.smethod_1().method_9();
                }
                else if ((int) gclass81.template.type == Class15.smethod_0(117))
                {
                  GClass116.smethod_17((num123 >= Class15.smethod_0(0) ? Class13.smethod_0(136021) : string.Empty) + num123.ToString(), GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch, Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_3);
                  GClass172.smethod_1().method_9();
                }
                else
                {
                  GClass116.gclass73_0.method_7(GClass109.string_162 + Class13.smethod_0(136005) + (num123 <= Class15.smethod_0(0) ? string.Empty : num123.ToString() + Class13.smethod_0(136005)) + gclass81.template.name, Class15.smethod_0(0));
                  GClass172.smethod_1().method_9();
                }
                if (num123 > Class15.smethod_0(0) && GClass20.smethod_1().petFollow != null && (int) GClass20.smethod_1().petFollow.smallID == Class15.smethod_0(279))
                {
                  GClass47.smethod_0(Class15.smethod_0(280), GClass20.smethod_1().petFollow.cmx, GClass20.smethod_1().petFollow.cmy, Class15.smethod_0(1));
                  GClass47.smethod_0(Class15.smethod_0(280), GClass20.smethod_1().cx, GClass20.smethod_1().cy, Class15.smethod_0(1));
                  break;
                }
                break;
              }
              if (s.Length == Class15.smethod_0(1))
              {
                GClass33.smethod_4(Class13.smethod_0(135889) + s);
                break;
              }
              GClass116.gclass73_0.method_7(s, Class15.smethod_0(0));
              break;
            }
          }
          goto case 1;
        case 93:
          GClass62.smethod_7(Class13.smethod_0(136571), Class15.smethod_0(7));
          short num124 = msg.method_1().method_6();
          gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          for (int index81 = Class15.smethod_0(0); index81 < GClass116.gclass134_6.method_2(); index81 += Class15.smethod_0(1))
          {
            GClass81 gclass81 = (GClass81) GClass116.gclass134_6.method_3(index81);
            if (gclass81.itemMapID == (int) num124)
            {
              if (gclass20_1 == null)
                return;
              gclass81.method_0(gclass20_1.cx, gclass20_1.cy - Class15.smethod_0(31));
              if (gclass81.x < gclass20_1.cx)
              {
                gclass20_1.cdir = -1;
                break;
              }
              if (gclass81.x > gclass20_1.cx)
              {
                gclass20_1.cdir = Class15.smethod_0(1);
                break;
              }
              break;
            }
          }
          goto case 1;
        case 94:
          GClass62.smethod_7(Class13.smethod_0(136530), Class15.smethod_0(7));
          int index82 = (int) msg.method_1().method_2();
          GClass116.gclass134_6.method_0((object) new GClass81(msg.method_1().method_6(), GClass20.smethod_1().arrItemBag[index82].template.id, GClass20.smethod_1().cx, GClass20.smethod_1().cy, (int) msg.method_1().method_6(), (int) msg.method_1().method_6()));
          GClass20.smethod_1().arrItemBag[index82] = (GClass80) null;
          goto case 1;
        case 98:
          GClass62.smethod_7(Class13.smethod_0(136360), Class15.smethod_0(7));
          gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_1 == null)
            break;
          GClass116.gclass134_6.method_0((object) new GClass81(msg.method_1().method_6(), msg.method_1().method_6(), gclass20_1.cx, gclass20_1.cy, (int) msg.method_1().method_6(), (int) msg.method_1().method_6()));
          goto case 1;
        case 108:
          GClass62.smethod_7(Class13.smethod_0(131594), Class15.smethod_0(7));
          gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_1 == null)
            break;
          GClass62.smethod_7(Class13.smethod_0(131767), Class15.smethod_0(7));
          if ((GClass185.smethod_26(gclass20_1.cx, gclass20_1.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
            gclass20_1.method_65(GClass116.gclass165_0[(int) msg.method_1().method_5()], Class15.smethod_0(0));
          else
            gclass20_1.method_65(GClass116.gclass165_0[(int) msg.method_1().method_5()], Class15.smethod_0(1));
          GClass62.smethod_7(Class13.smethod_0(131715), Class15.smethod_0(7));
          gclass20_1.attMobs = new GClass100[(int) msg.method_1().method_2()];
          for (int index83 = Class15.smethod_0(0); index83 < gclass20_1.attMobs.Length; index83 += Class15.smethod_0(1))
          {
            GClass100 gclass100_12 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_2());
            gclass20_1.attMobs[index83] = gclass100_12;
            if (index83 == 0)
              gclass20_1.cdir = gclass20_1.cx > gclass100_12.x ? -1 : Class15.smethod_0(1);
          }
          GClass62.smethod_7(Class13.smethod_0(131797), Class15.smethod_0(7));
          gclass20_1.charFocus = (GClass20) null;
          gclass20_1.mobFocus = gclass20_1.attMobs[Class15.smethod_0(0)];
          GClass20[] gclass20Array1 = new GClass20[Class15.smethod_0(31)];
          int length31 = Class15.smethod_0(0);
          try
          {
            for (length31 = Class15.smethod_0(0); length31 < gclass20Array1.Length; length31 += Class15.smethod_0(1))
            {
              int charId9 = msg.method_1().method_8();
              GClass20 gclass20_14 = gclass20Array1[length31] = charId9 != GClass20.smethod_1().charID ? GClass116.smethod_12(charId9) : GClass20.smethod_1();
              if (length31 == 0)
                gclass20_1.cdir = gclass20_1.cx > gclass20_14.cx ? -1 : Class15.smethod_0(1);
            }
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(132369) + ex.ToString());
          }
          GClass62.smethod_7(Class13.smethod_0(133694), Class15.smethod_0(7));
          if (length31 > Class15.smethod_0(0))
          {
            gclass20_1.attChars = new GClass20[length31];
            for (int index84 = Class15.smethod_0(0); index84 < gclass20_1.attChars.Length; index84 += Class15.smethod_0(1))
              gclass20_1.attChars[index84] = gclass20Array1[index84];
            gclass20_1.charFocus = gclass20_1.attChars[Class15.smethod_0(0)];
            gclass20_1.mobFocus = (GClass100) null;
          }
          GClass62.smethod_7(Class13.smethod_0(133666), Class15.smethod_0(7));
          goto case 1;
        case 113:
          bool flag8 = msg.method_1().method_10();
          GClass151.smethod_7(Class13.smethod_0(154983) + flag8.ToString());
          if (!flag8)
          {
            GClass62.smethod_28(msg.method_1().method_14());
            goto case 1;
          }
          else
          {
            GClass62.gclass117_0.isLogin2 = Class15.smethod_0(0) != 0;
            GClass152.smethod_4(Class13.smethod_0(153007) + GClass120.int_12.ToString(), string.Empty);
            GClass62.smethod_27();
            GClass62.gclass117_0.method_9();
            goto case 1;
          }
        case 114:
          GClass20.bool_4 = Class15.smethod_0(1) != 0;
          GClass117.bool_9 = Class15.smethod_0(0) != 0;
          if (!GClass116.bool_1)
            GClass116.smethod_6().method_0();
          GClass18.smethod_0();
          GClass62.smethod_27();
          GClass115.bool_0 = Class15.smethod_0(1) != 0;
          GClass115.smethod_2().vmethod_0();
          goto case 1;
        case 118:
          GClass62.smethod_7(Class13.smethod_0(138541), Class15.smethod_0(7));
          GClass20.smethod_1().xu = msg.method_1().method_9();
          GClass20.smethod_1().luong = msg.method_1().method_8();
          GClass20.smethod_1().luongKhoa = msg.method_1().method_8();
          GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
          GClass20.smethod_1().luongStr = GClass126.smethod_6((long) GClass20.smethod_1().luong);
          GClass20.smethod_1().luongKhoaStr = GClass126.smethod_6((long) GClass20.smethod_1().luongKhoa);
          GClass62.smethod_27();
          goto case 1;
        case 119:
          sbyte type1 = msg.method_1().method_2();
          short id7 = msg.method_1().method_6();
          string info2 = msg.method_1().method_14();
          GClass62.gclass141_0.method_184(type1, info2, id7);
          goto case 1;
        case 123:
          GClass62.smethod_7(Class13.smethod_0(150578), Class15.smethod_0(7));
          int int_2 = (int) msg.method_1().method_2();
          sbyte typeread2 = msg.method_1().method_2();
          if (typeread2 != (sbyte) 0)
            GClass100.gclass106_0[int_2].data.method_8(GClass138.smethod_2(msg), typeread2);
          else
            GClass100.gclass106_0[int_2].data.method_7(GClass138.smethod_2(msg));
          for (int index85 = Class15.smethod_0(0); index85 < GClass116.gclass134_9.method_2(); index85 += Class15.smethod_0(1))
          {
            GClass100 gclass100_13 = (GClass100) GClass116.gclass134_9.method_3(index85);
            if (gclass100_13.templateId == int_2)
            {
              gclass100_13.w = GClass100.gclass106_0[int_2].data.width;
              gclass100_13.h = GClass100.gclass106_0[int_2].data.height;
            }
          }
          sbyte[] imageData2 = GClass138.smethod_2(msg);
          GClass66 gclass66_2 = GClass66.smethod_6(imageData2, Class15.smethod_0(0), imageData2.Length);
          GClass100.gclass106_0[int_2].data.img = gclass66_2;
          int num125 = (int) msg.method_1().method_2();
          GClass100.gclass106_0[int_2].data.typeData = num125;
          if (num125 == Class15.smethod_0(1) || num125 == Class15.smethod_0(7))
          {
            this.method_19(msg, int_2);
            goto case 1;
          }
          else
            goto case 1;
        case 132:
          this.method_21(msg);
          goto case 1;
        case 136:
          this.method_23(msg);
          goto case 1;
        case 139:
          GClass134 menuItems1 = new GClass134();
          msg.method_1().method_14();
          int num126 = (int) msg.method_1().method_2();
          for (int index86 = Class15.smethod_0(0); index86 < num126; index86 += Class15.smethod_0(1))
          {
            string caption = msg.method_1().method_14();
            short p = msg.method_1().method_6();
            menuItems1.method_0((object) new GClass31(caption, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(276), (object) p));
          }
          GClass62.gclass95_0.method_0(menuItems1, Class15.smethod_0(5));
          goto case 1;
        case 141:
          GClass62.smethod_7(Class13.smethod_0(142553), Class15.smethod_0(7));
          GClass116.smethod_6().method_109(msg);
          goto case 1;
        case 144:
          GClass62.smethod_7(Class13.smethod_0(138202), Class15.smethod_0(7));
          int num127 = (int) msg.method_1().method_6();
          for (int index87 = Class15.smethod_0(0); index87 < GClass116.gclass134_10.method_2(); index87 += Class15.smethod_0(1))
          {
            GClass21 gclass21_2 = (GClass21) GClass116.gclass134_10.method_3(index87);
            if (gclass21_2.template.npcTemplateId == num127 && gclass21_2.Equals((object) GClass20.smethod_1().npcFocus))
            {
              string chat2 = msg.method_1().method_14();
              string[] menu = new string[(int) msg.method_1().method_2()];
              for (int index88 = Class15.smethod_0(0); index88 < menu.Length; index88 += Class15.smethod_0(1))
                menu[index88] = msg.method_1().method_14();
              GClass116.smethod_6().method_18(menu, gclass21_2);
              GClass43.smethod_5(chat2, Class15.smethod_0(17), gclass21_2);
              return;
            }
          }
          GClass21 gclass21_3 = new GClass21(num127, Class15.smethod_0(0), Class15.smethod_0(143), Class15.smethod_0(21), num127, GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(7)]);
          GClass151.smethod_7(GClass20.smethod_1().npcFocus == null ? Class13.smethod_0(137748) : Class13.smethod_0(138181));
          string chat3 = msg.method_1().method_14();
          string[] menu1 = new string[(int) msg.method_1().method_2()];
          for (int index89 = Class15.smethod_0(0); index89 < menu1.Length; index89 += Class15.smethod_0(1))
            menu1[index89] = msg.method_1().method_14();
          try
          {
            gclass21_3.avatar = (int) msg.method_1().method_6();
          }
          catch (Exception ex)
          {
          }
          GClass151.smethod_7(GClass20.smethod_1().npcFocus == null ? Class13.smethod_0(137748) : Class13.smethod_0(138181));
          GClass116.smethod_6().method_18(menu1, gclass21_3);
          GClass43.smethod_5(chat3, Class15.smethod_0(17), gclass21_3);
          goto case 1;
        case 145:
          GClass62.smethod_7(Class13.smethod_0(146607), Class15.smethod_0(7));
          GClass71.smethod_5();
          GClass62.smethod_25();
          GClass62.smethod_24();
          GClass134 menuItems2 = new GClass134();
          try
          {
            while (true)
            {
              string caption = msg.method_1().method_14();
              menuItems2.method_0((object) new GClass31(caption, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(277), (object) null));
            }
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(139626) + ex.ToString());
          }
          if (GClass20.smethod_1().npcFocus == null)
            break;
          for (int index90 = Class15.smethod_0(0); index90 < GClass20.smethod_1().npcFocus.template.menu.Length; index90 += Class15.smethod_0(1))
          {
            string[] p = GClass20.smethod_1().npcFocus.template.menu[index90];
            menuItems2.method_0((object) new GClass31(p[Class15.smethod_0(0)], (GInterface0) GClass62.gclass62_0, Class15.smethod_0(278), (object) p));
          }
          GClass62.gclass95_0.method_2(menuItems2, Class15.smethod_0(5));
          goto case 1;
        case 150:
          GClass62.smethod_7(Class13.smethod_0(137543), Class15.smethod_0(7));
          GClass71.smethod_5();
          int num128 = (int) msg.method_1().method_6();
          GClass151.smethod_7(Class13.smethod_0(137330) + num128.ToString());
          string chat4 = GClass151.smethod_14(msg.method_1().method_14());
          for (int index91 = Class15.smethod_0(0); index91 < GClass116.gclass134_10.method_2(); index91 += Class15.smethod_0(1))
          {
            GClass21 c2 = (GClass21) GClass116.gclass134_10.method_3(index91);
            GClass151.smethod_7(Class13.smethod_0(137424) + c2.template.npcTemplateId.ToString());
            if (c2.template.npcTemplateId == num128)
            {
              GClass43.smethod_3(chat4, Class15.smethod_0(17), c2);
              GClass62.gclass141_0.method_140();
              return;
            }
          }
          GClass21 c3 = new GClass21(num128, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(0), num128, GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(7)]);
          if (c3.template.npcTemplateId == Class15.smethod_0(3))
            c3.charID = Class15.smethod_0(3);
          try
          {
            c3.avatar = (int) msg.method_1().method_6();
          }
          catch (Exception ex)
          {
          }
          GClass43.smethod_3(chat4, Class15.smethod_0(17), c3);
          GClass62.gclass141_0.method_140();
          goto case 1;
        case 151:
          GClass62.smethod_7(Class13.smethod_0(146040), Class15.smethod_0(7));
          GClass116.smethod_6().typeTradeOrder = Class15.smethod_0(7);
          if (GClass116.smethod_6().typeTrade >= Class15.smethod_0(7) && GClass116.smethod_6().typeTradeOrder >= Class15.smethod_0(7))
          {
            GClass71.smethod_1();
            goto case 1;
          }
          else
            goto case 1;
        case 152:
          GClass62.smethod_7(Class13.smethod_0(139408), Class15.smethod_0(7));
          GClass62.int_9 = Class15.smethod_0(19);
          short taskId = msg.method_1().method_6();
          sbyte index92 = msg.method_1().method_2();
          string name = GClass151.smethod_14(msg.method_1().method_14());
          string detail = GClass151.smethod_14(msg.method_1().method_14());
          string[] subNames = new string[(int) msg.method_1().method_2()];
          string[] contentInfo = new string[subNames.Length];
          GClass116.int_59 = new int[subNames.Length];
          GClass116.int_60 = new int[subNames.Length];
          short[] counts = new short[subNames.Length];
          short count = -1;
          for (int index93 = Class15.smethod_0(0); index93 < subNames.Length; index93 += Class15.smethod_0(1))
          {
            string str8 = GClass151.smethod_14(msg.method_1().method_14());
            GClass116.int_59[index93] = (int) msg.method_1().method_2();
            GClass116.int_60[index93] = (int) msg.method_1().method_6();
            string str9 = GClass151.smethod_14(msg.method_1().method_14());
            counts[index93] = (short) -1;
            if (!str8.Equals(string.Empty))
            {
              subNames[index93] = str8;
              contentInfo[index93] = str9;
            }
          }
          try
          {
            count = msg.method_1().method_6();
            for (int index94 = Class15.smethod_0(0); index94 < subNames.Length; index94 += Class15.smethod_0(1))
              counts[index94] = msg.method_1().method_6();
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(140093) + ex.ToString());
          }
          GClass20.smethod_1().taskMaint = new GClass179(taskId, index92, name, detail, subNames, counts, count, contentInfo);
          if (GClass20.smethod_1().npcFocus != null)
            GClass21.smethod_10();
          GClass20.smethod_0(Class15.smethod_0(0) != 0);
          goto case 1;
        case 153:
          GClass62.smethod_7(Class13.smethod_0(140215), Class15.smethod_0(7));
          GClass62.int_9 = Class15.smethod_0(21);
          GClass151.smethod_7(Class13.smethod_0(141849));
          GClass20.smethod_1().taskMaint.index += Class15.smethod_0(1);
          GClass20.smethod_1().taskMaint.count = (short) Class15.smethod_0(0);
          GClass21.smethod_10();
          GClass20.smethod_0(Class15.smethod_0(1) != 0);
          goto case 1;
        case 155:
          GClass62.int_9 = Class15.smethod_0(32);
          GClass62.smethod_7(Class13.smethod_0(141926), Class15.smethod_0(7));
          GClass20.smethod_1().taskMaint.count = msg.method_1().method_6();
          if (GClass20.smethod_1().npcFocus != null)
            GClass21.smethod_10();
          try
          {
            short num129 = msg.method_1().method_6();
            short num130 = msg.method_1().method_6();
            GClass20.smethod_1().x_hint = num129;
            GClass20.smethod_1().y_hint = num130;
            GClass151.smethod_7(Class13.smethod_0(142626) + num129.ToString() + Class13.smethod_0(142840) + num130.ToString());
            for (int index95 = Class15.smethod_0(0); index95 < GClass185.gclass134_0.method_2(); index95 += Class15.smethod_0(1))
              GClass151.smethod_7(Class13.smethod_0(142500) + GClass185.gclass134_0.method_3(index95)?.ToString());
            goto case 1;
          }
          catch (Exception ex)
          {
            goto case 1;
          }
        case 158:
          GClass62.smethod_7(Class13.smethod_0(145024), Class15.smethod_0(7));
          GClass33.smethod_5(Class13.smethod_0(145136) + GClass20.bool_2.ToString());
          GClass20.bool_3 = Class15.smethod_0(0) != 0;
          GClass20.smethod_1().method_26((int) msg.method_1().method_6(), (int) msg.method_1().method_6());
          goto case 1;
        case 159:
          GClass62.smethod_7(Class13.smethod_0(151075), Class15.smethod_0(7));
          GClass116.smethod_6().method_34();
          goto case 1;
        case 162:
          sbyte num131 = msg.method_1().method_2();
          GClass141.gclass134_0.method_9();
          for (int index96 = Class15.smethod_0(0); index96 < (int) num131; index96 += Class15.smethod_0(1))
          {
            Class7 o = new Class7();
            o.id = msg.method_1().method_6();
            o.main = msg.method_1().method_14();
            o.content = msg.method_1().method_14();
            GClass141.gclass134_0.method_0((object) o);
            o.hasRead = (GClass152.smethod_8(o.id.ToString() + string.Empty) == -1 ? 1 : 0) == Class15.smethod_0(0);
          }
          goto case 1;
        case 166:
          gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_1 == null)
            break;
          int index97 = (int) msg.method_1().method_5();
          if ((GClass185.smethod_26(gclass20_1.cx, gclass20_1.cy) & Class15.smethod_0(7)) == Class15.smethod_0(7))
            gclass20_1.method_65(GClass116.gclass165_0[index97], Class15.smethod_0(0));
          else
            gclass20_1.method_65(GClass116.gclass165_0[index97], Class15.smethod_0(1));
          GClass62.smethod_7(Class13.smethod_0(133783), Class15.smethod_0(7));
          GClass100[] gclass100Array = new GClass100[Class15.smethod_0(31)];
          int length32 = Class15.smethod_0(0);
          try
          {
            GClass62.smethod_7(Class13.smethod_0(133878), Class15.smethod_0(7));
            for (length32 = Class15.smethod_0(0); length32 < gclass100Array.Length; length32 += Class15.smethod_0(1))
            {
              GClass62.smethod_7(Class13.smethod_0(133833) + length32.ToString(), Class15.smethod_0(7));
              GClass100 gclass100_14 = gclass100Array[length32] = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_2());
              if (length32 == 0)
                gclass20_1.cdir = gclass20_1.cx > gclass100_14.x ? -1 : Class15.smethod_0(1);
              GClass62.smethod_7(Class13.smethod_0(134568) + length32.ToString(), Class15.smethod_0(7));
            }
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(134629) + ex.ToString());
          }
          GClass62.smethod_7(Class13.smethod_0(134202), Class15.smethod_0(7));
          if (length32 > Class15.smethod_0(0))
          {
            gclass20_1.attMobs = new GClass100[length32];
            for (int index98 = Class15.smethod_0(0); index98 < gclass20_1.attMobs.Length; index98 += Class15.smethod_0(1))
              gclass20_1.attMobs[index98] = gclass100Array[index98];
            gclass20_1.charFocus = (GClass20) null;
            gclass20_1.mobFocus = gclass20_1.attMobs[Class15.smethod_0(0)];
            goto case 1;
          }
          else
            goto case 1;
        case 168:
          GClass62.smethod_7(Class13.smethod_0(143629), Class15.smethod_0(7));
          gclass20_2 = (GClass20) null;
          int charId10 = msg.method_1().method_8();
          if (charId10 == GClass20.smethod_1().charID)
          {
            bool flag9 = Class15.smethod_0(0) != 0;
            gclass20_1 = GClass20.smethod_1();
            gclass20_1.cHP = msg.method_3();
            int num132 = msg.method_3();
            GClass151.smethod_7(Class13.smethod_0(143707) + num132.ToString());
            if (num132 != 0)
              gclass20_1.method_109();
            int num133 = Class15.smethod_0(0);
            try
            {
              flag9 = msg.method_1().method_11();
              sbyte id8 = msg.method_1().method_2();
              if (id8 != (sbyte) -1)
              {
                GClass151.smethod_7(Class13.smethod_0(143776) + id8.ToString());
                GClass40.smethod_0(new GClass41((int) id8, gclass20_1.cx, gclass20_1.cy, Class15.smethod_0(5), Class15.smethod_0(1), -1));
              }
            }
            catch (Exception ex)
            {
            }
            int num134 = num132 + num133;
            if ((int) GClass20.smethod_1().cTypePk != Class15.smethod_0(2))
            {
              if (num134 == 0)
              {
                GClass116.smethod_17(GClass109.string_233, gclass20_1.cx, gclass20_1.cy - gclass20_1.ch, Class15.smethod_0(0), Class15.smethod_0(134), GClass97.int_10);
                goto case 1;
              }
              else
              {
                GClass116.smethod_17(Class13.smethod_0(121200) + num134.ToString(), gclass20_1.cx, gclass20_1.cy - gclass20_1.ch, Class15.smethod_0(0), Class15.smethod_0(134), flag9 ? GClass97.int_6 : GClass97.int_3);
                goto case 1;
              }
            }
            else
              goto case 1;
          }
          else
          {
            gclass20_1 = GClass116.smethod_12(charId10);
            if (gclass20_1 == null)
              break;
            gclass20_1.cHP = msg.method_3();
            bool flag10 = Class15.smethod_0(0) != 0;
            int num135 = msg.method_3();
            if (num135 != 0)
              gclass20_1.method_109();
            int num136 = Class15.smethod_0(0);
            try
            {
              flag10 = msg.method_1().method_11();
              sbyte id9 = msg.method_1().method_2();
              if (id9 != (sbyte) -1)
              {
                GClass151.smethod_7(Class13.smethod_0(143776) + id9.ToString());
                GClass40.smethod_0(new GClass41((int) id9, gclass20_1.cx, gclass20_1.cy, Class15.smethod_0(5), Class15.smethod_0(1), -1));
              }
            }
            catch (Exception ex)
            {
            }
            int num137 = num135 + num136;
            if ((int) gclass20_1.cTypePk != Class15.smethod_0(2))
            {
              if (num137 == 0)
              {
                GClass116.smethod_17(GClass109.string_233, gclass20_1.cx, gclass20_1.cy - gclass20_1.ch, Class15.smethod_0(0), Class15.smethod_0(134), GClass97.int_7);
                goto case 1;
              }
              else
              {
                GClass116.smethod_17(Class13.smethod_0(121200) + num137.ToString(), gclass20_1.cx, gclass20_1.cy - gclass20_1.ch, Class15.smethod_0(0), Class15.smethod_0(134), flag10 ? GClass97.int_6 : GClass97.int_8);
                goto case 1;
              }
            }
            else
              goto case 1;
          }
        case 169:
          GClass62.smethod_7(Class13.smethod_0(146084), Class15.smethod_0(7));
          GClass134 menuItems3 = new GClass134();
          menuItems3.method_0((object) new GClass31(msg.method_1().method_14(), (GInterface0) GClass62.gclass62_0, Class15.smethod_0(274), (object) null));
          GClass62.gclass95_0.method_2(menuItems3, Class15.smethod_0(5));
          goto case 1;
        case 170:
          GClass62.smethod_7(Class13.smethod_0(146843), Class15.smethod_0(7));
          int charId11 = msg.method_1().method_8();
          GClass20 gclass20_15 = charId11 != GClass20.smethod_1().charID ? GClass116.smethod_12(charId11) : GClass20.smethod_1();
          gclass20_15.moveFast = new short[Class15.smethod_0(5)];
          gclass20_15.moveFast[Class15.smethod_0(0)] = (short) Class15.smethod_0(0);
          short num138 = msg.method_1().method_6();
          short num139 = msg.method_1().method_6();
          gclass20_15.moveFast[Class15.smethod_0(1)] = num138;
          gclass20_15.moveFast[Class15.smethod_0(7)] = num139;
          try
          {
            int charId12 = msg.method_1().method_8();
            GClass20 gclass20_16 = charId12 != GClass20.smethod_1().charID ? GClass116.smethod_12(charId12) : GClass20.smethod_1();
            gclass20_16.cx = (int) num138;
            gclass20_16.cy = (int) num139;
            goto case 1;
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(146464) + ex.ToString());
            goto case 1;
          }
        case 174:
          GClass62.smethod_7(Class13.smethod_0(146204), Class15.smethod_0(7));
          gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_1 != null)
          {
            gclass20_1.killCharId = GClass20.smethod_1().charID;
            GClass20.smethod_1().npcFocus = (GClass21) null;
            GClass20.smethod_1().mobFocus = (GClass100) null;
            GClass20.smethod_1().itemFocus = (GClass81) null;
            GClass20.smethod_1().charFocus = gclass20_1;
            GClass20.bool_13 = Class15.smethod_0(1) != 0;
            GClass116.gclass73_0.method_7(gclass20_1.cName + GClass109.string_160, Class15.smethod_0(0));
            goto case 1;
          }
          else
            goto case 1;
        case 175:
          GClass62.smethod_7(Class13.smethod_0(146188), Class15.smethod_0(7));
          GClass20.smethod_1().killCharId = msg.method_1().method_8();
          GClass20.smethod_1().npcFocus = (GClass21) null;
          GClass20.smethod_1().mobFocus = (GClass100) null;
          GClass20.smethod_1().itemFocus = (GClass81) null;
          GClass20.smethod_1().charFocus = GClass116.smethod_12(GClass20.smethod_1().killCharId);
          GClass20.bool_13 = Class15.smethod_0(1) != 0;
          goto case 1;
        case 176:
          GClass62.smethod_7(Class13.smethod_0(145975), Class15.smethod_0(7));
          gclass20_1 = GClass20.smethod_1();
          try
          {
            gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          }
          catch (Exception ex)
          {
            GClass33.smethod_0(Class13.smethod_0(145963) + ex.ToString());
          }
          gclass20_1.killCharId = Class15.smethod_0(180);
          goto case 1;
        case 177:
          sbyte id10 = msg.method_1().method_0();
          string text = msg.method_1().method_14();
          short time = msg.method_1().method_6();
          if (GClass87.smethod_2((int) id10))
          {
            if (time != (short) 0)
            {
              GClass87.smethod_1((int) id10).method_0(id10, text, (int) time);
              goto case 1;
            }
            else
            {
              GClass116.gclass134_0.method_8((object) GClass87.smethod_1((int) id10));
              goto case 1;
            }
          }
          else
          {
            GClass87 o = new GClass87();
            o.method_0(id10, text, (int) time);
            GClass116.gclass134_0.method_0((object) o);
            goto case 1;
          }
        case 178:
          this.method_16(msg);
          goto case 1;
        case 180:
          GClass151.smethod_7(Class13.smethod_0(136696));
          GClass62.smethod_7(Class13.smethod_0(136289), Class15.smethod_0(7));
          short itemMapID = msg.method_1().method_6();
          short itemTemplateID = msg.method_1().method_6();
          int x = (int) msg.method_1().method_6();
          int y = (int) msg.method_1().method_6();
          int playerId = msg.method_1().method_8();
          short r = (short) Class15.smethod_0(0);
          if (playerId == Class15.smethod_0(132))
            r = msg.method_1().method_6();
          GClass81 o3 = new GClass81(playerId, itemMapID, itemTemplateID, x, y, r);
          GClass116.gclass134_6.method_0((object) o3);
          goto case 1;
        case 181:
          GClass172.bool_0 = msg.method_1().method_2() != (sbyte) 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
          goto case 1;
        case 193:
          GClass62.smethod_7(Class13.smethod_0(151155), Class15.smethod_0(7));
          ((GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5())).isDisable = msg.method_1().method_10();
          goto case 1;
        case 194:
          GClass62.smethod_7(Class13.smethod_0(151222), Class15.smethod_0(7));
          ((GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5())).isDontMove = msg.method_1().method_10();
          goto case 1;
        case 195:
          GClass62.smethod_7(Class13.smethod_0(144975), Class15.smethod_0(7));
          int charId13 = msg.method_1().method_8();
          gclass20_1 = charId13 != GClass20.smethod_1().charID ? GClass116.smethod_12(charId13) : GClass20.smethod_1();
          if (gclass20_1 == null)
            break;
          GClass100 mobToAttack1 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
          if (gclass20_1.mobMe != null)
          {
            gclass20_1.mobMe.method_25(mobToAttack1);
            goto case 1;
          }
          else
            goto case 1;
        case 196:
          int charId14 = msg.method_1().method_8();
          if (charId14 == GClass20.smethod_1().charID)
          {
            gclass20_1 = GClass20.smethod_1();
          }
          else
          {
            gclass20_1 = GClass116.smethod_12(charId14);
            if (gclass20_1 == null)
              break;
          }
          gclass20_1.cHP = gclass20_1.cHPFull;
          gclass20_1.cMP = gclass20_1.cMPFull;
          gclass20_1.cx = (int) msg.method_1().method_6();
          gclass20_1.cy = (int) msg.method_1().method_6();
          gclass20_1.method_112();
          goto case 1;
        case 197:
          GClass62.smethod_7(Class13.smethod_0(151222), Class15.smethod_0(7));
          ((GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5())).isFire = msg.method_1().method_10();
          goto case 1;
        case 198:
          GClass62.smethod_7(Class13.smethod_0(151222), Class15.smethod_0(7));
          GClass100 gclass100_15 = (GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5());
          gclass100_15.isIce = msg.method_1().method_10();
          if (!gclass100_15.isIce)
          {
            GClass47.smethod_0(Class15.smethod_0(216), gclass100_15.x, gclass100_15.y - Class15.smethod_0(45), Class15.smethod_0(1));
            goto case 1;
          }
          else
            goto case 1;
        case 199:
          GClass62.smethod_7(Class13.smethod_0(151222), Class15.smethod_0(7));
          ((GClass100) GClass116.gclass134_9.method_3((int) msg.method_1().method_5())).isWind = msg.method_1().method_10();
          goto case 1;
        case 200:
          string info3 = msg.method_1().method_14();
          short p1 = msg.method_1().method_6();
          GClass62.gclass38_0.method_0(info3, new GClass31(GClass109.string_144, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(275), (object) p1), GClass184.int_7);
          goto case 1;
        case 202:
          GClass62.smethod_7(Class13.smethod_0(142476), Class15.smethod_0(7));
          this.method_0(msg);
          goto case 1;
        case 204:
          if (GClass62.gclass113_0 == GClass116.gclass116_0)
            GClass62.smethod_27();
          string str10 = msg.method_1().method_14();
          string str11 = GClass151.smethod_14(msg.method_1().method_14());
          string empty = string.Empty;
          GClass20 c4 = (GClass20) null;
          sbyte num140 = (sbyte) Class15.smethod_0(0);
          if (!str10.Equals(string.Empty))
          {
            c4 = new GClass20();
            c4.charID = msg.method_1().method_8();
            c4.head = (int) msg.method_1().method_6();
            c4.headICON = (int) msg.method_1().method_6();
            c4.body = (int) msg.method_1().method_6();
            c4.bag = (int) msg.method_1().method_6();
            c4.leg = (int) msg.method_1().method_6();
            num140 = msg.method_1().method_2();
            c4.cName = str10;
          }
          string s1 = empty + str11;
          GClass71.smethod_5();
          if (str10.Equals(string.Empty))
          {
            GClass116.gclass73_0.method_7(s1, Class15.smethod_0(0));
            goto case 1;
          }
          else
          {
            GClass116.gclass73_1.method_6(s1, c4, num140 == (sbyte) 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0);
            if (GClass62.gclass141_0.isShow && GClass62.gclass141_0.type == Class15.smethod_0(88))
            {
              GClass62.gclass141_0.method_74();
              goto case 1;
            }
            else
              goto case 1;
          }
        case 206:
          GClass62.smethod_7(Class13.smethod_0(151479), Class15.smethod_0(7));
          GClass116.gclass73_0.method_7(msg.method_1().method_14(), Class15.smethod_0(0));
          goto case 1;
        default:
          if ((int) command1 == Class15.smethod_0(265))
          {
            sbyte num141 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(28265) + num141.ToString());
            if (num141 == (sbyte) 0)
            {
              GClass141.short_0 = msg.method_1().method_6();
              GClass141.string_0 = msg.method_1().method_14();
              goto case 1;
            }
            else if ((int) num141 == Class15.smethod_0(1))
            {
              sbyte length33 = msg.method_1().method_2();
              GClass20.smethod_1().infoSpeacialSkill = new string[(int) length33][];
              GClass20.smethod_1().imgSpeacialSkill = new short[(int) length33][];
              GClass62.gclass141_0.speacialTabName = new string[(int) length33][];
              for (int index99 = Class15.smethod_0(0); index99 < (int) length33; index99 += Class15.smethod_0(1))
              {
                GClass62.gclass141_0.speacialTabName[index99] = new string[Class15.smethod_0(7)];
                string[] strArray18 = GClass151.smethod_27(msg.method_1().method_14(), Class13.smethod_0(28253), Class15.smethod_0(0));
                if (strArray18.Length == Class15.smethod_0(7))
                  GClass62.gclass141_0.speacialTabName[index99] = strArray18;
                if (strArray18.Length == Class15.smethod_0(1))
                {
                  GClass62.gclass141_0.speacialTabName[index99][Class15.smethod_0(0)] = strArray18[Class15.smethod_0(0)];
                  GClass62.gclass141_0.speacialTabName[index99][Class15.smethod_0(1)] = string.Empty;
                }
                int length34 = (int) msg.method_1().method_2();
                GClass20.smethod_1().infoSpeacialSkill[index99] = new string[length34];
                GClass20.smethod_1().imgSpeacialSkill[index99] = new short[length34];
                for (int index100 = Class15.smethod_0(0); index100 < length34; index100 += Class15.smethod_0(1))
                {
                  GClass20.smethod_1().imgSpeacialSkill[index99][index100] = msg.method_1().method_6();
                  GClass20.smethod_1().infoSpeacialSkill[index99][index100] = msg.method_1().method_14();
                }
              }
              GClass62.gclass141_0.tabName[Class15.smethod_0(46)] = GClass62.gclass141_0.speacialTabName;
              GClass62.gclass141_0.method_200();
              GClass62.gclass141_0.method_44();
              goto case 1;
            }
            else
              goto case 1;
          }
          else
            goto case 1;
      }
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(182393) + ex.StackTrace);
    }
    finally
    {
      msg?.method_4();
    }
  }

  private void method_1(GClass131 gclass131_0)
  {
    GClass116.sbyte_3 = gclass131_0.method_2();
    GClass86.gclass128_0.method_1();
    GClass116.smethod_6().iOptionTemplates = new GClass84[(int) gclass131_0.method_5()];
    for (int index = Class15.smethod_0(0); index < GClass116.smethod_6().iOptionTemplates.Length; index += Class15.smethod_0(1))
    {
      GClass116.smethod_6().iOptionTemplates[index] = new GClass84();
      GClass116.smethod_6().iOptionTemplates[index].id = index;
      GClass116.smethod_6().iOptionTemplates[index].name = gclass131_0.method_14();
      GClass116.smethod_6().iOptionTemplates[index].type = (int) gclass131_0.method_2();
    }
    int num = (int) gclass131_0.method_6();
    for (int templateID = Class15.smethod_0(0); templateID < num; templateID += Class15.smethod_0(1))
      GClass86.smethod_0(new GClass85((short) templateID, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_10()));
  }

  private void method_2(GClass131 gclass131_0)
  {
    GClass116.sbyte_2 = gclass131_0.method_2();
    GClass116.smethod_6().sOptionTemplates = new GClass164[(int) gclass131_0.method_2()];
    for (int index = Class15.smethod_0(0); index < GClass116.smethod_6().sOptionTemplates.Length; index += Class15.smethod_0(1))
    {
      GClass116.smethod_6().sOptionTemplates[index] = new GClass164();
      GClass116.smethod_6().sOptionTemplates[index].id = index;
      GClass116.smethod_6().sOptionTemplates[index].name = gclass131_0.method_14();
    }
    GClass116.gclass137_0 = new GClass137[(int) gclass131_0.method_2()];
    for (int index1 = Class15.smethod_0(0); index1 < GClass116.gclass137_0.Length; index1 += Class15.smethod_0(1))
    {
      GClass116.gclass137_0[index1] = new GClass137();
      GClass116.gclass137_0[index1].classId = index1;
      GClass116.gclass137_0[index1].name = gclass131_0.method_14();
      GClass116.gclass137_0[index1].skillTemplates = new GClass167[(int) gclass131_0.method_2()];
      for (int index2 = Class15.smethod_0(0); index2 < GClass116.gclass137_0[index1].skillTemplates.Length; index2 += Class15.smethod_0(1))
      {
        GClass116.gclass137_0[index1].skillTemplates[index2] = new GClass167();
        GClass116.gclass137_0[index1].skillTemplates[index2].id = gclass131_0.method_2();
        GClass116.gclass137_0[index1].skillTemplates[index2].name = gclass131_0.method_14();
        GClass116.gclass137_0[index1].skillTemplates[index2].maxPoint = (int) gclass131_0.method_2();
        GClass116.gclass137_0[index1].skillTemplates[index2].manaUseType = (int) gclass131_0.method_2();
        GClass116.gclass137_0[index1].skillTemplates[index2].type = (int) gclass131_0.method_2();
        GClass116.gclass137_0[index1].skillTemplates[index2].iconId = (int) gclass131_0.method_6();
        GClass116.gclass137_0[index1].skillTemplates[index2].damInfo = gclass131_0.method_14();
        int lineWidth = Class15.smethod_0(288);
        if (GClass62.int_10 == Class15.smethod_0(212) || GClass62.int_11 <= Class15.smethod_0(289))
          lineWidth = Class15.smethod_0(21);
        GClass116.gclass137_0[index1].skillTemplates[index2].description = GClass97.gclass97_14.method_15(gclass131_0.method_14(), lineWidth);
        GClass116.gclass137_0[index1].skillTemplates[index2].skills = new GClass161[(int) gclass131_0.method_2()];
        for (int index3 = Class15.smethod_0(0); index3 < GClass116.gclass137_0[index1].skillTemplates[index2].skills.Length; index3 += Class15.smethod_0(1))
        {
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3] = new GClass161();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].skillId = gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].template = GClass116.gclass137_0[index1].skillTemplates[index2];
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].point = (int) gclass131_0.method_2();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].powRequire = gclass131_0.method_9();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].manaUse = (int) gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].coolDown = gclass131_0.method_8();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].dx = (int) gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].dy = (int) gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].maxFight = (int) gclass131_0.method_2();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].damage = gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].price = gclass131_0.method_6();
          GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3].moreInfo = gclass131_0.method_14();
          GClass166.smethod_0(GClass116.gclass137_0[index1].skillTemplates[index2].skills[index3]);
        }
      }
    }
  }

  private void method_3(GClass131 gclass131_0)
  {
    GClass116.sbyte_1 = gclass131_0.method_2();
    GClass185.string_2 = new string[(int) gclass131_0.method_5()];
    for (int index = Class15.smethod_0(0); index < GClass185.string_2.Length; index += Class15.smethod_0(1))
      GClass185.string_2[index] = gclass131_0.method_14();
    GClass21.gclass139_0 = new GClass139[(int) gclass131_0.method_2()];
    for (sbyte index1 = (sbyte) Class15.smethod_0(0); (int) index1 < GClass21.gclass139_0.Length; index1 += (sbyte) Class15.smethod_0(1))
    {
      GClass21.gclass139_0[(int) index1] = new GClass139();
      GClass21.gclass139_0[(int) index1].npcTemplateId = (int) index1;
      GClass21.gclass139_0[(int) index1].name = gclass131_0.method_14();
      GClass21.gclass139_0[(int) index1].headId = (int) gclass131_0.method_6();
      GClass21.gclass139_0[(int) index1].bodyId = (int) gclass131_0.method_6();
      GClass21.gclass139_0[(int) index1].legId = (int) gclass131_0.method_6();
      GClass21.gclass139_0[(int) index1].menu = new string[(int) gclass131_0.method_2()][];
      for (int index2 = Class15.smethod_0(0); index2 < GClass21.gclass139_0[(int) index1].menu.Length; index2 += Class15.smethod_0(1))
      {
        GClass21.gclass139_0[(int) index1].menu[index2] = new string[(int) gclass131_0.method_2()];
        for (int index3 = Class15.smethod_0(0); index3 < GClass21.gclass139_0[(int) index1].menu[index2].Length; index3 += Class15.smethod_0(1))
          GClass21.gclass139_0[(int) index1].menu[index2][index3] = gclass131_0.method_14();
      }
    }
    GClass100.gclass106_0 = new GClass106[(int) gclass131_0.method_2()];
    for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < GClass100.gclass106_0.Length; index += (sbyte) Class15.smethod_0(1))
    {
      GClass100.gclass106_0[(int) index] = new GClass106();
      GClass100.gclass106_0[(int) index].mobTemplateId = index;
      GClass100.gclass106_0[(int) index].type = gclass131_0.method_2();
      GClass100.gclass106_0[(int) index].name = gclass131_0.method_14();
      GClass100.gclass106_0[(int) index].hp = gclass131_0.method_8();
      GClass100.gclass106_0[(int) index].rangeMove = gclass131_0.method_2();
      GClass100.gclass106_0[(int) index].speed = gclass131_0.method_2();
      GClass100.gclass106_0[(int) index].dartType = gclass131_0.method_2();
    }
  }

  private void method_4(GClass131 gclass131_0, bool bool_6)
  {
    GClass116.sbyte_0 = gclass131_0.method_2();
    if ((!bool_6 ? 1 : 0) != 0)
      return;
    GClass152.smethod_0(Class13.smethod_0(174205), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_0(Class13.smethod_0(174197), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_0(Class13.smethod_0(174188), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_0(Class13.smethod_0(174178), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_0(Class13.smethod_0(174169), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_0(Class13.smethod_0(174161), GClass138.smethod_3(gclass131_0));
    GClass152.smethod_14(Class13.smethod_0(174152));
  }

  private GClass66 method_5(sbyte[] sbyte_6)
  {
    try
    {
      return GClass66.smethod_6(sbyte_6, Class15.smethod_0(0), sbyte_6.Length);
    }
    catch (Exception ex)
    {
    }
    return (GClass66) null;
  }

  public int[] method_6(sbyte[] b)
  {
    int[] numArray = new int[b.Length];
    for (int index = Class15.smethod_0(0); index < b.Length; index += Class15.smethod_0(1))
    {
      int num = (int) b[index];
      if (num < Class15.smethod_0(0))
        num += Class15.smethod_0(290);
      numArray[index] = num;
    }
    return numArray;
  }

  public void method_7(GClass96 msg, int index)
  {
    try
    {
      GClass28 cm = new GClass28();
      sbyte num = msg.method_1().method_2();
      cm.type = (int) num;
      cm.id = msg.method_1().method_8();
      cm.playerId = msg.method_1().method_8();
      cm.playerName = msg.method_1().method_14();
      cm.role = msg.method_1().method_2();
      cm.time = (long) (msg.method_1().method_8() + Class15.smethod_0(291));
      bool upToTop = Class15.smethod_0(0) != 0;
      GClass116.bool_53 = Class15.smethod_0(0) != 0;
      if ((num == (sbyte) 0 ? 0 : 1) == 0)
      {
        string str = msg.method_1().method_14();
        GClass116.bool_53 = Class15.smethod_0(1) != 0;
        if (GClass97.gclass97_11.method_17(str) > GClass141.int_19 - Class15.smethod_0(4))
        {
          cm.chat = GClass97.gclass97_11.method_15(str, GClass141.int_19 - Class15.smethod_0(31));
        }
        else
        {
          cm.chat = new string[Class15.smethod_0(1)];
          cm.chat[Class15.smethod_0(0)] = str;
        }
        cm.color = msg.method_1().method_2();
      }
      else if ((int) num == Class15.smethod_0(1))
      {
        cm.recieve = (int) msg.method_1().method_2();
        cm.maxCap = (int) msg.method_1().method_2();
        if ((!(upToTop = (int) msg.method_1().method_2() == Class15.smethod_0(1)) ? 1 : 0) == 0)
          GClass116.bool_53 = Class15.smethod_0(1) != 0;
        if (cm.playerId != GClass20.smethod_1().charID)
        {
          if (cm.recieve < cm.maxCap)
          {
            GClass28 gclass28 = cm;
            string[] strArray = new string[Class15.smethod_0(1)];
            strArray[Class15.smethod_0(0)] = GClass109.string_234;
            gclass28.option = strArray;
          }
          else
            cm.option = (string[]) null;
        }
        if ((GClass62.gclass141_0.cp == null ? 1 : 0) == 0)
          GClass62.gclass141_0.method_181(cm.recieve, cm.maxCap);
      }
      else if ((int) num == Class15.smethod_0(7) && (GClass20.smethod_1().role == (sbyte) 0 ? 0 : 1) == 0)
      {
        GClass116.bool_53 = Class15.smethod_0(1) != 0;
        GClass28 gclass28 = cm;
        string[] strArray = new string[Class15.smethod_0(7)];
        strArray[Class15.smethod_0(0)] = GClass109.string_145;
        strArray[Class15.smethod_0(1)] = GClass109.string_235;
        gclass28.option = strArray;
      }
      if (GClass62.gclass113_0 != GClass116.gclass116_0)
        GClass116.bool_53 = Class15.smethod_0(0) != 0;
      else if ((!GClass62.gclass141_0.isShow ? 1 : 0) == 0 && (GClass62.gclass141_0.type == 0 ? 0 : 1) == 0 && GClass62.gclass141_0.currentTabIndex == Class15.smethod_0(5))
        GClass116.bool_53 = Class15.smethod_0(0) != 0;
      GClass28.smethod_0(cm, index, upToTop);
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(174145) + msg.command.ToString());
    }
  }

  public void method_8(sbyte teleport3)
  {
    GClass151.smethod_7(Class13.smethod_0(174257) + GClass20.bool_4.ToString());
    GClass116.smethod_6().auto = Class15.smethod_0(0);
    GClass116.bool_56 = Class15.smethod_0(0) != 0;
    GClass115.gclass115_0 = (GClass115) null;
    GClass116.gclass73_0.isUpdate = Class15.smethod_0(0) != 0;
    GClass116.gclass73_1.isUpdate = Class15.smethod_0(0) != 0;
    GClass116.int_38 = Class15.smethod_0(0);
    GClass62.gclass141_0.isShow = Class15.smethod_0(0) != 0;
    GClass172.smethod_1().method_51();
    if ((!GClass116.bool_1 ? 0 : 1) == 0 && (!GClass115.bool_0 ? 0 : 1) == 0)
      GClass116.smethod_6().method_0();
    GClass116.smethod_8(Class15.smethod_0(0) != 0, (int) teleport3 != Class15.smethod_0(1) ? -1 : GClass20.smethod_1().cx, (teleport3 == (sbyte) 0 ? 1 : 0) != 0 ? -1 : Class15.smethod_0(0));
    GClass185.smethod_33();
    GClass185.smethod_13(GClass185.int_25);
    GClass151.smethod_7(Class13.smethod_0(174239));
    GClass20.smethod_1().cvx = Class15.smethod_0(0);
    GClass20.smethod_1().statusMe = Class15.smethod_0(2);
    GClass20.smethod_1().currentMovePoint = (GClass108) null;
    GClass20.smethod_1().mobFocus = (GClass100) null;
    GClass20.smethod_1().charFocus = (GClass20) null;
    GClass20.smethod_1().npcFocus = (GClass21) null;
    GClass20.smethod_1().itemFocus = (GClass81) null;
    GClass20.smethod_1().skillPaint = (GClass165) null;
    GClass20.smethod_1().method_76(Class15.smethod_0(0) != 0);
    GClass20.smethod_1().skillPaintRandomPaint = (GClass165) null;
    GClass62.smethod_46();
    if (GClass20.smethod_1().cy >= GClass185.int_24 - Class15.smethod_0(21))
    {
      GClass20.smethod_1().isFlyUp = Class15.smethod_0(1) != 0;
      GClass20.smethod_1().cx += GClass151.smethod_25(GClass151.smethod_18(Class15.smethod_0(0), Class15.smethod_0(25)));
      GClass156.smethod_0().method_45();
    }
    GClass116.smethod_6().method_24();
    GClass62.smethod_19(GClass185.int_40);
    GClass20.bool_3 = Class15.smethod_0(0) != 0;
    GClass151.smethod_7(Class13.smethod_0(174224) + GClass20.smethod_1().cy.ToString() + Class13.smethod_0(174219));
    for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().vEff.method_2(); index += Class15.smethod_0(1))
    {
      if ((int) ((GClass48) GClass20.smethod_1().vEff.method_3(index)).template.type == Class15.smethod_0(31))
      {
        GClass20.bool_3 = Class15.smethod_0(1) != 0;
        break;
      }
    }
    GClass62.smethod_25();
    GClass62.smethod_24();
    GClass116.smethod_6().dHP = GClass20.smethod_1().cHP;
    GClass116.smethod_6().dMP = GClass20.smethod_1().cMP;
    GClass20.bool_2 = Class15.smethod_0(0) != 0;
    GClass116.smethod_6().vmethod_0();
    if (GClass20.smethod_1().cy <= Class15.smethod_0(31) && (teleport3 == (sbyte) 0 ? 1 : 0) == 0 && (int) teleport3 != Class15.smethod_0(7))
    {
      GClass182.smethod_0(new GClass182(GClass20.smethod_1().cx, GClass20.smethod_1().cy, GClass20.smethod_1().head, GClass20.smethod_1().cdir, Class15.smethod_0(1), Class15.smethod_0(1) != 0, (int) teleport3 != Class15.smethod_0(1) ? (int) teleport3 : GClass20.smethod_1().cgender));
      GClass20.smethod_1().isTeleport = Class15.smethod_0(1) != 0;
    }
    if ((int) teleport3 == Class15.smethod_0(7))
      GClass20.smethod_1().method_34();
    if ((!GClass116.smethod_6().isRongThanXuatHien ? 1 : 0) == 0)
    {
      if (GClass185.int_37 == GClass116.smethod_6().mapRID && GClass185.int_39 == GClass116.smethod_6().zoneRID)
        GClass116.smethod_6().method_54(GClass116.smethod_6().xR, GClass116.smethod_6().yR);
      if (GClass98.int_8 > Class15.smethod_0(1))
        GClass116.smethod_6().method_53();
    }
    GClass71.smethod_5();
    GClass71.smethod_0(GClass185.string_1, GClass109.string_204 + Class13.smethod_0(174301) + GClass185.int_39.ToString(), Class15.smethod_0(6));
    GClass62.smethod_27();
    GClass62.bool_4 = Class15.smethod_0(0) != 0;
    GClass65.smethod_4();
    GClass65.smethod_2();
    GClass62.smethod_7(Class13.smethod_0(174299), Class15.smethod_0(7));
  }

  public void method_9(GClass96 msg)
  {
    try
    {
      if (GClass98.int_8 == Class15.smethod_0(1))
        GClass169.smethod_4();
      GClass20.smethod_1().cx = GClass20.smethod_1().cxSend = GClass20.smethod_1().cxFocus = (int) msg.method_1().method_6();
      GClass20.smethod_1().cy = GClass20.smethod_1().cySend = GClass20.smethod_1().cyFocus = (int) msg.method_1().method_6();
      GClass20.smethod_1().xSd = GClass20.smethod_1().cx;
      GClass20.smethod_1().ySd = GClass20.smethod_1().cy;
      string[] strArray = new string[Class15.smethod_0(66)];
      strArray[Class15.smethod_0(0)] = Class13.smethod_0(174292);
      strArray[Class15.smethod_0(1)] = GClass20.smethod_1().head.ToString();
      strArray[Class15.smethod_0(7)] = Class13.smethod_0(174285);
      strArray[Class15.smethod_0(5)] = GClass20.smethod_1().body.ToString();
      strArray[Class15.smethod_0(2)] = Class13.smethod_0(174277);
      strArray[Class15.smethod_0(3)] = GClass20.smethod_1().leg.ToString();
      strArray[Class15.smethod_0(37)] = Class13.smethod_0(174909);
      strArray[Class15.smethod_0(38)] = GClass20.smethod_1().cx.ToString();
      strArray[Class15.smethod_0(88)] = Class13.smethod_0(174904);
      strArray[Class15.smethod_0(45)] = GClass20.smethod_1().cy.ToString();
      strArray[Class15.smethod_0(31)] = Class13.smethod_0(174899);
      strArray[Class15.smethod_0(67)] = GClass20.smethod_1().cgender.ToString();
      GClass151.smethod_7(string.Concat(strArray));
      if (GClass20.smethod_1().cx >= Class15.smethod_0(0) && GClass20.smethod_1().cx <= Class15.smethod_0(21))
        GClass20.smethod_1().cdir = Class15.smethod_0(1);
      else if (GClass20.smethod_1().cx >= GClass185.int_21 - Class15.smethod_0(21) && GClass20.smethod_1().cx <= GClass185.int_21)
        GClass20.smethod_1().cdir = -1;
      GClass62.smethod_7(Class13.smethod_0(174886), Class15.smethod_0(7));
      int num1 = (int) msg.method_1().method_2();
      GClass151.smethod_7(Class13.smethod_0(174879) + num1.ToString());
      if (!GClass116.gclass73_0.isDone)
      {
        GClass116.gclass73_0.cmx = GClass20.smethod_1().cx - GClass116.int_22;
        GClass116.gclass73_0.cmy = GClass20.smethod_1().cy - GClass116.int_23;
      }
      for (int index = Class15.smethod_0(0); index < num1; index += Class15.smethod_0(1))
      {
        GClass190 gclass190 = new GClass190(msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_14());
        if ((GClass185.int_37 == Class15.smethod_0(27) || GClass185.int_37 == Class15.smethod_0(28) || GClass185.int_37 == Class15.smethod_0(29)) && (int) gclass190.minX >= Class15.smethod_0(0))
          Class15.smethod_0(40);
      }
      Resources.UnloadUnusedAssets();
      GC.Collect();
      GClass62.smethod_7(Class13.smethod_0(174868), Class15.smethod_0(7));
      int num2 = (int) msg.method_1().method_2();
      GClass100.gclass134_1.method_9();
      for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < num2; index += (sbyte) Class15.smethod_0(1))
      {
        GClass100 o1 = new GClass100((int) index, msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), (int) msg.method_1().method_2(), (int) msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_2(), msg.method_1().method_2());
        o1.xSd = o1.x;
        o1.ySd = o1.y;
        o1.isBoss = msg.method_1().method_11();
        if (GClass100.gclass106_0[o1.templateId].type != (sbyte) 0)
        {
          o1.dir = (int) index % Class15.smethod_0(5) != 0 ? Class15.smethod_0(1) : -1;
          o1.x += Class15.smethod_0(31) - (int) index % Class15.smethod_0(51);
        }
        o1.isMobMe = Class15.smethod_0(0) != 0;
        GClass104 o2 = (GClass104) null;
        GClass101 o3 = (GClass101) null;
        GClass102 o4 = (GClass102) null;
        GClass103 o5 = (GClass103) null;
        if (o1.templateId == Class15.smethod_0(152))
          o2 = new GClass104((int) index, (short) o1.x, (short) o1.y, Class15.smethod_0(152), o1.hp, o1.maxHp, o1.sys);
        if (o1.templateId == Class15.smethod_0(135))
          o3 = new GClass101((int) index, (short) o1.x, (short) o1.y, Class15.smethod_0(135), o1.hp, o1.maxHp, o1.sys);
        if (o1.templateId == Class15.smethod_0(107))
          o4 = new GClass102((int) index, (short) o1.x, (short) o1.y, Class15.smethod_0(107), o1.hp, o1.maxHp, Class15.smethod_0(5));
        if (o1.isBoss)
          o5 = new GClass103((int) index, (short) o1.x, (short) o1.y, o1.templateId, o1.hp, o1.maxHp, o1.sys);
        if (o5 != null)
          GClass116.gclass134_9.method_0((object) o5);
        else if (o2 != null)
          GClass116.gclass134_9.method_0((object) o2);
        else if (o3 != null)
          GClass116.gclass134_9.method_0((object) o3);
        else if (o4 != null)
          GClass116.gclass134_9.method_0((object) o4);
        else
          GClass116.gclass134_9.method_0((object) o1);
      }
      for (int index = Class15.smethod_0(0); index < GClass100.gclass134_0.method_2(); index += Class15.smethod_0(1))
      {
        string str = (string) GClass100.gclass134_0.method_3(index);
        if (!GClass100.smethod_0(str))
        {
          GClass100.gclass106_0[int.Parse(str)].data = (GClass50) null;
          GClass100.gclass134_0.method_7(index);
          index -= Class15.smethod_0(1);
        }
      }
      if (GClass20.smethod_1().mobMe != null && GClass116.smethod_14(GClass20.smethod_1().mobMe.mobId) == null)
      {
        GClass20.smethod_1().mobMe.method_1();
        GClass20.smethod_1().mobMe.x = GClass20.smethod_1().cx;
        GClass20.smethod_1().mobMe.y = GClass20.smethod_1().cy - Class15.smethod_0(54);
        GClass116.gclass134_9.method_0((object) GClass20.smethod_1().mobMe);
      }
      int num3 = (int) msg.method_1().method_2();
      byte num4 = (byte) Class15.smethod_0(0);
      while ((int) num4 < num3)
        num4 += (byte) Class15.smethod_0(1);
      GClass62.smethod_7(Class13.smethod_0(174861), Class15.smethod_0(7));
      int num5 = (int) msg.method_1().method_2();
      GClass151.smethod_7(Class13.smethod_0(174854) + num5.ToString());
      for (int npcId = Class15.smethod_0(0); npcId < num5; npcId += Class15.smethod_0(1))
      {
        sbyte status = msg.method_1().method_2();
        short cx = msg.method_1().method_6();
        short cy = msg.method_1().method_6();
        sbyte templateId = msg.method_1().method_2();
        short num6 = msg.method_1().method_6();
        if ((int) templateId != Class15.smethod_0(37) && ((int) GClass20.smethod_1().taskMaint.taskId >= Class15.smethod_0(38) && ((int) GClass20.smethod_1().taskMaint.taskId != Class15.smethod_0(38) || GClass20.smethod_1().taskMaint.index > Class15.smethod_0(1)) || (int) templateId != Class15.smethod_0(38) && (int) templateId != Class15.smethod_0(88) && (int) templateId != Class15.smethod_0(45)) && ((int) GClass20.smethod_1().taskMaint.taskId >= Class15.smethod_0(37) || (int) templateId != Class15.smethod_0(10)))
        {
          if ((int) templateId == Class15.smethod_0(2))
          {
            GClass116.smethod_6().magicTree = new GClass22(npcId, (int) status, (int) cx, (int) cy, (int) templateId, (int) num6);
            GClass156.smethod_0().method_42((sbyte) Class15.smethod_0(7));
            GClass116.gclass134_10.method_0((object) GClass116.smethod_6().magicTree);
          }
          else
          {
            GClass21 o = new GClass21(npcId, (int) status, (int) cx, (int) cy + Class15.smethod_0(5), (int) templateId, (int) num6);
            GClass116.gclass134_10.method_0((object) o);
          }
        }
      }
      GClass62.smethod_7(Class13.smethod_0(174971), Class15.smethod_0(7));
      int num7 = (int) msg.method_1().method_2();
      GClass151.smethod_7(Class13.smethod_0(174964) + num7.ToString());
      for (int index1 = Class15.smethod_0(0); index1 < num7; index1 += Class15.smethod_0(1))
      {
        short itemMapID = msg.method_1().method_6();
        short itemTemplateID = msg.method_1().method_6();
        int x = (int) msg.method_1().method_6();
        int y = (int) msg.method_1().method_6();
        int playerId = msg.method_1().method_8();
        short r = (short) Class15.smethod_0(0);
        if (playerId == Class15.smethod_0(132))
          r = msg.method_1().method_6();
        GClass81 o = new GClass81(playerId, itemMapID, itemTemplateID, x, y, r);
        bool flag = Class15.smethod_0(0) != 0;
        for (int index2 = Class15.smethod_0(0); index2 < GClass116.gclass134_6.method_2(); index2 += Class15.smethod_0(1))
        {
          if (((GClass81) GClass116.gclass134_6.method_3(index2)).itemMapID == o.itemMapID)
          {
            flag = Class15.smethod_0(1) != 0;
            break;
          }
        }
        if (!flag)
          GClass116.gclass134_6.method_0((object) o);
      }
      GClass185.gclass134_2.method_9();
      if (GClass98.int_8 == Class15.smethod_0(1))
        GClass18.smethod_0();
      GClass18.gclass134_0.method_9();
      if (GClass62.bool_1 && (!GClass62.bool_1 || !GClass185.smethod_1()) && GClass185.int_37 != Class15.smethod_0(70) && GClass185.int_37 != Class15.smethod_0(71) && GClass185.int_37 != Class15.smethod_0(43) && GClass185.int_37 != Class15.smethod_0(154))
      {
        short num8 = msg.method_1().method_6();
        for (int index = Class15.smethod_0(0); index < (int) num8; index += Class15.smethod_0(1))
        {
          int num9 = (int) msg.method_1().method_6();
          int num10 = (int) msg.method_1().method_6();
          int num11 = (int) msg.method_1().method_6();
        }
        short num12 = msg.method_1().method_6();
        for (int index = Class15.smethod_0(0); index < (int) num12; index += Class15.smethod_0(1))
        {
          msg.method_1().method_14();
          msg.method_1().method_14();
        }
      }
      else
      {
        short num13 = msg.method_1().method_6();
        GClass151.smethod_7(Class13.smethod_0(174951) + num13.ToString());
        for (int index = Class15.smethod_0(0); index < (int) num13; index += Class15.smethod_0(1))
        {
          short id = msg.method_1().method_6();
          short num14 = msg.method_1().method_6();
          short num15 = msg.method_1().method_6();
          if (GClass185.smethod_4((int) id) != null)
          {
            GClass18 gclass18 = GClass185.smethod_4((int) id);
            GClass18 o = new GClass18();
            o.id = (int) id;
            o.idImage = gclass18.idImage;
            o.dx = gclass18.dx;
            o.dy = gclass18.dy;
            o.x = (int) num14 * (int) GClass185.sbyte_0;
            o.y = (int) num15 * (int) GClass185.sbyte_0;
            o.layer = gclass18.layer;
            if (GClass185.smethod_10(o.id))
            {
              o.trans = index % Class15.smethod_0(7) != 0 ? Class15.smethod_0(7) : Class15.smethod_0(0);
              if (GClass185.int_37 == Class15.smethod_0(70))
                o.trans = Class15.smethod_0(0);
            }
            if (!GClass18.gclass128_0.method_7((object) (o.idImage.ToString() + string.Empty)))
            {
              if (GClass98.int_8 == Class15.smethod_0(1))
              {
                GClass66 v = GClass62.smethod_40(Class13.smethod_0(174943) + o.idImage.ToString() + Class13.smethod_0(174927));
                if (v == null)
                {
                  v = GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0);
                  GClass156.smethod_0().method_114(o.idImage);
                }
                GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) v);
              }
              else
              {
                bool flag = Class15.smethod_0(0) != 0;
                sbyte[] imageData = GClass152.smethod_1(GClass98.int_8.ToString() + Class13.smethod_0(174922) + o.idImage.ToString());
                if (imageData != null)
                {
                  if (GClass18.sbyte_0 != null)
                  {
                    GClass151.smethod_7(Class13.smethod_0(174915) + (imageData.Length % Class15.smethod_0(73)).ToString() + Class13.smethod_0(175029) + GClass18.sbyte_0[(int) o.idImage].ToString());
                    if (imageData.Length % Class15.smethod_0(73) != (int) GClass18.sbyte_0[(int) o.idImage])
                      flag = Class15.smethod_0(1) != 0;
                  }
                  if (!flag)
                  {
                    GClass66 v = GClass66.smethod_6(imageData, Class15.smethod_0(0), imageData.Length);
                    if (v != null)
                      GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) v);
                    else
                      flag = Class15.smethod_0(1) != 0;
                  }
                }
                else
                  flag = Class15.smethod_0(1) != 0;
                if (flag)
                {
                  GClass66 v = GClass62.smethod_40(Class13.smethod_0(174943) + o.idImage.ToString() + Class13.smethod_0(174927));
                  if (v == null)
                  {
                    v = GClass66.smethod_9(new int[Class15.smethod_0(1)], Class15.smethod_0(1), Class15.smethod_0(1), Class15.smethod_0(1) != 0);
                    GClass156.smethod_0().method_114(o.idImage);
                  }
                  GClass18.gclass128_0.method_4((object) (o.idImage.ToString() + string.Empty), (object) v);
                }
              }
              GClass18.gclass134_1.method_0((object) (o.idImage.ToString() + string.Empty));
            }
            if (!GClass18.smethod_1(o.idImage.ToString() + string.Empty))
              GClass18.gclass134_0.method_0((object) (o.idImage.ToString() + string.Empty));
            o.method_2();
            GClass185.gclass134_2.method_0((object) o);
          }
        }
        for (int index = Class15.smethod_0(0); index < GClass18.gclass134_1.method_2(); index += Class15.smethod_0(1))
        {
          string str1 = (string) GClass18.gclass134_1.method_3(index);
          if (!GClass18.smethod_1(str1))
          {
            GClass18.gclass128_0.method_5((object) str1);
            GClass128 gclass1280_1 = GClass18.gclass128_0;
            string str2 = str1;
            string str3 = Class13.smethod_0(175015);
            int num16 = Class15.smethod_0(1);
            string str4 = num16.ToString();
            string key1 = str2 + str3 + str4;
            if (gclass1280_1.method_7((object) key1))
            {
              GClass128 gclass1280_2 = GClass18.gclass128_0;
              string str5 = str1;
              string str6 = Class13.smethod_0(175015);
              num16 = Class15.smethod_0(1);
              string str7 = num16.ToString();
              string k = str5 + str6 + str7;
              gclass1280_2.method_5((object) k);
            }
            GClass128 gclass1280_3 = GClass18.gclass128_0;
            string str8 = str1;
            string str9 = Class13.smethod_0(175015);
            num16 = Class15.smethod_0(5);
            string str10 = num16.ToString();
            string key2 = str8 + str9 + str10;
            if (gclass1280_3.method_7((object) key2))
            {
              GClass128 gclass1280_4 = GClass18.gclass128_0;
              string str11 = str1;
              string str12 = Class13.smethod_0(175015);
              num16 = Class15.smethod_0(5);
              string str13 = num16.ToString();
              string k = str11 + str12 + str13;
              gclass1280_4.method_5((object) k);
            }
            GClass18.gclass134_1.method_7(index);
            index -= Class15.smethod_0(1);
          }
        }
        GClass16.bool_3 = Class15.smethod_0(0) != 0;
        GClass16.int_37 = Class15.smethod_0(0);
        GClass40.gclass134_0.method_9();
        GClass16.gclass134_0.method_9();
        GClass41.gclass134_2.method_9();
        short num17 = msg.method_1().method_6();
        for (int index = Class15.smethod_0(0); index < (int) num17; index += Class15.smethod_0(1))
          this.method_10(msg.method_1().method_14(), msg.method_1().method_14());
        for (int index = Class15.smethod_0(0); index < GClass41.gclass134_1.method_2(); index += Class15.smethod_0(1))
        {
          string str = (string) GClass41.gclass134_1.method_3(index);
          if (!GClass41.smethod_3(str))
          {
            GClass41.smethod_0(int.Parse(str));
            GClass41.gclass134_1.method_7(index);
            index -= Class15.smethod_0(1);
          }
        }
      }
      GClass185.int_41 = (int) msg.method_1().method_2();
      this.method_8(msg.method_1().method_2());
      GClass20.bool_4 = Class15.smethod_0(0) != 0;
      GClass62.smethod_7(Class13.smethod_0(175009), Class15.smethod_0(7));
      Resources.UnloadUnusedAssets();
      GC.Collect();
      GClass33.smethod_2(Class13.smethod_0(175002));
    }
    catch (Exception ex)
    {
      this.method_8((sbyte) Class15.smethod_0(0));
      GClass156.smethod_0().method_117();
      GClass20.bool_4 = Class15.smethod_0(0) != 0;
      GClass151.smethod_9(Class13.smethod_0(175093) + ex.StackTrace);
    }
  }

  public void method_10(string key, string value)
  {
    if ((!key.Equals(Class13.smethod_0(175071)) ? 1 : 0) == 0)
    {
      if (GClass141.int_5 > Class15.smethod_0(0))
        return;
      string[] strArray = GClass151.smethod_27(value, Class13.smethod_0(175067), Class15.smethod_0(0));
      int id = int.Parse(strArray[Class15.smethod_0(0)]);
      int num1 = int.Parse(strArray[Class15.smethod_0(1)]);
      int num2 = int.Parse(strArray[Class15.smethod_0(7)]);
      int num3 = int.Parse(strArray[Class15.smethod_0(5)]);
      int num4;
      int num5;
      if (strArray.Length <= Class15.smethod_0(2))
      {
        num4 = -1;
        num5 = Class15.smethod_0(1);
      }
      else
      {
        num4 = int.Parse(strArray[Class15.smethod_0(2)]);
        num5 = int.Parse(strArray[Class15.smethod_0(3)]);
      }
      int x = num2;
      int y = num3;
      int layer = num1;
      int loop = num4;
      int loopCount = num5;
      GClass41 me = new GClass41(id, x, y, layer, loop, loopCount);
      if (strArray.Length > Class15.smethod_0(37))
      {
        me.typeEff = int.Parse(strArray[Class15.smethod_0(37)]);
        if (strArray.Length > Class15.smethod_0(38))
        {
          me.indexFrom = int.Parse(strArray[Class15.smethod_0(38)]);
          me.indexTo = int.Parse(strArray[Class15.smethod_0(88)]);
        }
      }
      GClass40.smethod_0(me);
    }
    else
    {
      if ((!key.Equals(Class13.smethod_0(175065)) ? 1 : 0) != 0 || GClass141.int_5 > Class15.smethod_0(1))
        return;
      GClass16.smethod_7(int.Parse(value));
    }
  }

  public void method_11(GClass96 msg)
  {
    GClass62.smethod_7(Class13.smethod_0(175060), Class15.smethod_0(7));
    try
    {
      sbyte num1 = msg.method_1().method_2();
      GClass126.smethod_3(Class13.smethod_0(175056) + num1.ToString());
      switch ((int) num1 - Class15.smethod_0(2))
      {
        case 0:
          GClass62.smethod_7(Class13.smethod_0(174626), Class15.smethod_0(7));
          GClass62.gclass117_0.method_10();
          GClass116.bool_54 = Class15.smethod_0(0) != 0;
          GClass116.bool_55 = Class15.smethod_0(0) != 0;
          GClass117.bool_2 = Class15.smethod_0(1) != 0;
          GClass117.bool_3 = Class15.smethod_0(1) != 0;
          GClass117.bool_4 = Class15.smethod_0(1) != 0;
          GClass117.bool_5 = Class15.smethod_0(1) != 0;
          GClass117.bool_6 = Class15.smethod_0(1) != 0;
          GClass116.sbyte_4 = msg.method_1().method_2();
          GClass116.sbyte_5 = msg.method_1().method_2();
          GClass116.sbyte_6 = msg.method_1().method_2();
          GClass116.sbyte_7 = msg.method_1().method_2();
          int num2 = (int) msg.method_1().method_2();
          if (GClass62.gclass117_0.isLogin2)
          {
            GClass152.smethod_4(Class13.smethod_0(174622), string.Empty);
            GClass152.smethod_4(Class13.smethod_0(174618), string.Empty);
          }
          else
            GClass152.smethod_4(Class13.smethod_0(174613) + GClass120.int_12.ToString(), string.Empty);
          if ((int) GClass116.sbyte_4 != (int) GClass116.sbyte_0)
          {
            GClass116.bool_1 = Class15.smethod_0(0) != 0;
            GClass156.smethod_0().method_80();
          }
          else
          {
            try
            {
              GClass117.bool_3 = Class15.smethod_0(0) != 0;
            }
            catch (Exception ex)
            {
              GClass116.sbyte_0 = (sbyte) -1;
              GClass156.smethod_0().method_80();
            }
          }
          if ((int) GClass116.sbyte_5 != (int) GClass116.sbyte_1)
          {
            GClass116.bool_1 = Class15.smethod_0(0) != 0;
            GClass156.smethod_0().method_81();
          }
          else
          {
            try
            {
              if (!GClass116.bool_1)
                this.method_3(new GClass35(GClass152.smethod_1(Class13.smethod_0(174606))).r);
              GClass117.bool_4 = Class15.smethod_0(0) != 0;
            }
            catch (Exception ex)
            {
              GClass116.sbyte_1 = (sbyte) -1;
              GClass156.smethod_0().method_81();
            }
          }
          if ((int) GClass116.sbyte_6 != (int) GClass116.sbyte_2)
          {
            GClass116.bool_1 = Class15.smethod_0(0) != 0;
            GClass156.smethod_0().method_82();
          }
          else
          {
            try
            {
              if (!GClass116.bool_1)
                this.method_2(new GClass35(GClass152.smethod_1(Class13.smethod_0(174600))).r);
              GClass117.bool_5 = Class15.smethod_0(0) != 0;
            }
            catch (Exception ex)
            {
              GClass116.sbyte_2 = (sbyte) -1;
              GClass156.smethod_0().method_82();
            }
          }
          if ((int) GClass116.sbyte_7 != (int) GClass116.sbyte_3)
          {
            GClass116.bool_1 = Class15.smethod_0(0) != 0;
            GClass156.smethod_0().method_83();
          }
          else
          {
            try
            {
              this.method_18(new GClass35(GClass152.smethod_1(Class13.smethod_0(174592))).r, (sbyte) Class15.smethod_0(0), Class15.smethod_0(0) != 0);
              this.method_18(new GClass35(GClass152.smethod_1(Class13.smethod_0(174712))).r, (sbyte) Class15.smethod_0(1), Class15.smethod_0(0) != 0);
              this.method_18(new GClass35(GClass152.smethod_1(Class13.smethod_0(174704))).r, (sbyte) Class15.smethod_0(7), Class15.smethod_0(0) != 0);
              this.method_18(new GClass35(GClass152.smethod_1(Class13.smethod_0(174696))).r, (sbyte) Class15.smethod_0(21), Class15.smethod_0(0) != 0);
              GClass117.bool_6 = Class15.smethod_0(0) != 0;
            }
            catch (Exception ex)
            {
              GClass116.sbyte_3 = (sbyte) -1;
              GClass156.smethod_0().method_83();
            }
          }
          if ((int) GClass116.sbyte_4 == (int) GClass116.sbyte_0 && (int) GClass116.sbyte_5 == (int) GClass116.sbyte_1 && (int) GClass116.sbyte_6 == (int) GClass116.sbyte_2 && (int) GClass116.sbyte_7 == (int) GClass116.sbyte_3)
          {
            if (!GClass116.bool_1)
            {
              GClass116.smethod_6().method_22();
              GClass116.smethod_6().method_20();
              GClass116.smethod_6().method_21();
              GClass116.smethod_6().method_23();
            }
            GClass156.smethod_0().method_84();
          }
          sbyte length = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(174686) + length.ToString());
          GClass116.long_0 = new long[(int) length];
          for (int index = Class15.smethod_0(0); index < GClass116.long_0.Length; index += Class15.smethod_0(1))
            GClass116.long_0[index] = msg.method_1().method_9();
          break;
        case 1:
          break;
        case 2:
          GClass151.smethod_7(Class13.smethod_0(174671) + msg.method_1().method_18().ToString() + Class13.smethod_0(174783));
          msg.method_1().method_3(Class15.smethod_0(17));
          this.method_3(msg.method_1());
          msg.method_1().method_4();
          sbyte[] data1 = new sbyte[msg.method_1().method_18()];
          msg.method_1().method_17(ref data1);
          GClass152.smethod_0(Class13.smethod_0(174606), data1);
          sbyte[] numArray1 = new sbyte[Class15.smethod_0(1)];
          numArray1[Class15.smethod_0(0)] = GClass116.sbyte_1;
          sbyte[] data2 = numArray1;
          GClass152.smethod_0(Class13.smethod_0(174776), data2);
          GClass117.bool_4 = Class15.smethod_0(0) != 0;
          if ((int) GClass116.sbyte_4 != (int) GClass116.sbyte_0 || (int) GClass116.sbyte_5 != (int) GClass116.sbyte_1 || (int) GClass116.sbyte_6 != (int) GClass116.sbyte_2 || (int) GClass116.sbyte_7 != (int) GClass116.sbyte_3)
            break;
          GClass116.smethod_6().method_22();
          GClass116.smethod_6().method_20();
          GClass116.smethod_6().method_21();
          GClass116.smethod_6().method_23();
          GClass156.smethod_0().method_84();
          break;
        case 3:
          GClass151.smethod_7(Class13.smethod_0(174763) + msg.method_1().method_18().ToString() + Class13.smethod_0(174783));
          msg.method_1().method_3(Class15.smethod_0(17));
          this.method_2(msg.method_1());
          msg.method_1().method_4();
          sbyte[] data3 = new sbyte[msg.method_1().method_18()];
          msg.method_1().method_17(ref data3);
          GClass152.smethod_0(Class13.smethod_0(174600), data3);
          sbyte[] numArray2 = new sbyte[Class15.smethod_0(1)];
          numArray2[Class15.smethod_0(0)] = GClass116.sbyte_2;
          sbyte[] data4 = numArray2;
          GClass152.smethod_0(Class13.smethod_0(174745), data4);
          GClass117.bool_5 = Class15.smethod_0(0) != 0;
          if ((int) GClass116.sbyte_4 != (int) GClass116.sbyte_0 || (int) GClass116.sbyte_5 != (int) GClass116.sbyte_1 || (int) GClass116.sbyte_6 != (int) GClass116.sbyte_2 || (int) GClass116.sbyte_7 != (int) GClass116.sbyte_3)
            break;
          GClass116.smethod_6().method_22();
          GClass116.smethod_6().method_20();
          GClass116.smethod_6().method_21();
          GClass116.smethod_6().method_23();
          GClass156.smethod_0().method_84();
          break;
        case 4:
          GClass151.smethod_7(Class13.smethod_0(174730) + msg.method_1().method_18().ToString() + Class13.smethod_0(174783));
          this.method_17(msg.method_1());
          break;
        case 5:
          GClass62.smethod_7(Class13.smethod_0(175402), Class15.smethod_0(7));
          break;
        case 6:
          try
          {
            GClass20.bool_4 = Class15.smethod_0(1) != 0;
            GClass151.smethod_7(Class13.smethod_0(174841));
            GClass62.bool_4 = Class15.smethod_0(1) != 0;
            GClass185.int_27 = (int[]) null;
            GClass185.int_28 = (int[]) null;
            GClass126.smethod_26();
            GClass62.smethod_7(Class13.smethod_0(174820), Class15.smethod_0(7));
            GClass185.int_21 = (int) msg.method_1().method_2();
            GClass185.int_22 = (int) msg.method_1().method_2();
            GClass185.int_27 = new int[GClass185.int_21 * GClass185.int_22];
            GClass151.smethod_7(Class13.smethod_0(174815) + (GClass185.int_21 * GClass185.int_22).ToString());
            for (int index = Class15.smethod_0(0); index < GClass185.int_27.Length; index += Class15.smethod_0(1))
            {
              int num3 = (int) msg.method_1().method_2();
              if (num3 < Class15.smethod_0(0))
                num3 += Class15.smethod_0(290);
              GClass185.int_27[index] = (int) (ushort) num3;
            }
            GClass185.int_28 = new int[GClass185.int_27.Length];
            msg = this.messWait;
            this.method_9(msg);
            try
            {
              GClass185.bool_0 = msg.method_1().method_2() != (sbyte) 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
            }
            catch (Exception ex)
            {
            }
          }
          catch (Exception ex)
          {
            GClass33.smethod_2(Class13.smethod_0(174801) + ex.ToString());
          }
          msg.method_4();
          this.messWait.method_4();
          msg = this.messWait = (GClass96) null;
          break;
        case 7:
          break;
        case 8:
          GClass62.smethod_7(Class13.smethod_0(175407), Class15.smethod_0(7));
          break;
        case 9:
          break;
        case 10:
          break;
        case 11:
          break;
        case 12:
          GClass118.smethod_2().vmethod_0();
          break;
        case 13:
          GClass62.smethod_7(Class13.smethod_0(174652), Class15.smethod_0(7));
          GClass20.smethod_1().method_116();
          break;
        case 14:
          GClass62.bool_4 = Class15.smethod_0(0) != 0;
          GClass62.smethod_27();
          int p = msg.method_1().method_8();
          GClass62.gclass38_0.method_0(GClass109.string_77, new GClass31(GClass109.string_140, (GInterface0) GClass62.gclass62_0, Class15.smethod_0(292), (object) p), GClass184.int_7);
          break;
        case 15:
          break;
        case 16:
          GClass20.smethod_1().cPk = msg.method_1().method_2();
          GClass116.gclass73_0.method_7(GClass109.string_159 + Class13.smethod_0(174645) + GClass20.smethod_1().cPk.ToString(), Class15.smethod_0(0));
          break;
        default:
          if ((int) num1 != Class15.smethod_0(95))
          {
            if ((int) num1 != Class15.smethod_0(86))
              break;
            GClass116.sbyte_10 = msg.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(174643) + GClass116.sbyte_10.ToString());
            break;
          }
          GClass62.smethod_27();
          GClass116.smethod_6().method_34();
          GClass116.gclass73_0.method_7(msg.method_1().method_14(), Class15.smethod_0(0));
          break;
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_2(Class13.smethod_0(175397) + msg.command.ToString());
    }
    finally
    {
      msg?.method_4();
    }
  }

  public void method_12(GClass96 msg)
  {
    try
    {
      sbyte num = msg.method_1().method_2();
      GClass126.smethod_3(Class13.smethod_0(175372) + num.ToString());
      if ((int) num != Class15.smethod_0(7))
        return;
      string str = msg.method_1().method_14();
      if ((!GClass126.bool_0 ? 1 : 0) == 0)
        str = Class13.smethod_0(175478) + str;
      if (GClass152.smethod_8(Class13.smethod_0(175428)) == Class15.smethod_0(1))
        return;
      GClass120.string_9 = GClass126.int_0 != Class15.smethod_0(1) ? str : str;
      GClass120.smethod_4(GClass120.string_9);
      try
      {
        GClass141.bool_1 = (int) msg.method_1().method_2() == Class15.smethod_0(1);
        sbyte x = msg.method_1().method_2();
        GClass152.smethod_9(Class13.smethod_0(175428), (int) x);
      }
      catch (Exception ex)
      {
      }
    }
    catch (Exception ex)
    {
    }
    finally
    {
      if ((msg == null ? 1 : 0) == 0)
        msg.method_4();
    }
  }

  public void method_13(GClass96 msg)
  {
    try
    {
      GClass62.smethod_7(Class13.smethod_0(175546), Class15.smethod_0(7));
      sbyte num1 = msg.method_1().method_2();
      GClass126.smethod_3(Class13.smethod_0(175541) + num1.ToString());
      switch (num1)
      {
        case 0:
          GClass62.smethod_7(Class13.smethod_0(175610), Class15.smethod_0(7));
          GClass119.gclass134_0 = new GClass134();
          GClass182.gclass134_0.method_9();
          GClass116.gclass134_5.method_9();
          GClass116.gclass134_6.method_9();
          GClass20.gclass134_0.method_9();
          GClass116.smethod_24();
          GClass116.gclass20_0 = GClass20.smethod_1();
          GClass20.smethod_1().charID = msg.method_1().method_8();
          GClass20.smethod_1().ctaskId = (int) msg.method_1().method_2();
          GClass20.smethod_1().cgender = (int) msg.method_1().method_2();
          GClass20.smethod_1().head = (int) msg.method_1().method_6();
          GClass20.smethod_1().cName = msg.method_1().method_14();
          GClass20.smethod_1().cPk = msg.method_1().method_2();
          GClass20.smethod_1().cTypePk = msg.method_1().method_2();
          GClass20.smethod_1().cPower = msg.method_1().method_9();
          GClass20.smethod_1().method_0();
          GClass20.smethod_1().eff5BuffHp = (int) msg.method_1().method_6();
          GClass20.smethod_1().eff5BuffMp = (int) msg.method_1().method_6();
          GClass20.smethod_1().nClass = GClass116.gclass137_0[(int) msg.method_1().method_2()];
          GClass20.smethod_1().vSkill.method_9();
          GClass20.smethod_1().vSkillFight.method_9();
          GClass116.smethod_6().dHP = GClass20.smethod_1().cHP;
          GClass116.smethod_6().dMP = GClass20.smethod_1().cMP;
          sbyte num2 = msg.method_1().method_2();
          for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < (int) num2; index += (sbyte) Class15.smethod_0(1))
            this.method_14(GClass166.smethod_1(msg.method_1().method_6()));
          GClass116.smethod_6().method_64();
          GClass116.smethod_6().method_4();
          GClass20.smethod_1().xu = msg.method_1().method_9();
          GClass20.smethod_1().luongKhoa = msg.method_1().method_8();
          GClass20.smethod_1().luong = msg.method_1().method_8();
          GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
          GClass20.smethod_1().luongStr = GClass126.smethod_6((long) GClass20.smethod_1().luong);
          GClass20.smethod_1().luongKhoaStr = GClass126.smethod_6((long) GClass20.smethod_1().luongKhoa);
          GClass20.smethod_1().arrItemBody = new GClass80[(int) msg.method_1().method_2()];
          try
          {
            GClass20.smethod_1().method_58();
            for (int index1 = Class15.smethod_0(0); index1 < GClass20.smethod_1().arrItemBody.Length; index1 += Class15.smethod_0(1))
            {
              short id = msg.method_1().method_6();
              if (id != (short) -1)
              {
                GClass85 gclass85 = GClass86.smethod_1(id);
                int type = (int) gclass85.type;
                GClass20.smethod_1().arrItemBody[index1] = new GClass80();
                GClass20.smethod_1().arrItemBody[index1].template = gclass85;
                GClass20.smethod_1().arrItemBody[index1].quantity = msg.method_1().method_8();
                GClass20.smethod_1().arrItemBody[index1].info = msg.method_1().method_14();
                GClass20.smethod_1().arrItemBody[index1].content = msg.method_1().method_14();
                int length = (int) msg.method_1().method_5();
                if (length != 0)
                {
                  GClass20.smethod_1().arrItemBody[index1].itemOption = new GClass83[length];
                  for (int index2 = Class15.smethod_0(0); index2 < GClass20.smethod_1().arrItemBody[index1].itemOption.Length; index2 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) msg.method_1().method_5();
                    int num3 = (int) msg.method_1().method_7();
                    GClass20.smethod_1().arrItemBody[index1].itemOption[index2] = new GClass83(optionTemplateId, num3);
                  }
                }
                if (type != 0)
                {
                  if (type == Class15.smethod_0(1))
                  {
                    GClass20.smethod_1().leg = (int) GClass20.smethod_1().arrItemBody[index1].template.part;
                    GClass151.smethod_7(Class13.smethod_0(175605) + GClass20.smethod_1().leg.ToString());
                  }
                }
                else
                {
                  GClass151.smethod_7(Class13.smethod_0(175605) + GClass20.smethod_1().body.ToString());
                  GClass20.smethod_1().body = (int) GClass20.smethod_1().arrItemBody[index1].template.part;
                }
              }
            }
          }
          catch (Exception ex)
          {
          }
          GClass20.smethod_1().arrItemBag = new GClass80[(int) msg.method_1().method_2()];
          GClass116.int_37 = Class15.smethod_0(0);
          for (int index3 = Class15.smethod_0(0); index3 < GClass20.smethod_1().arrItemBag.Length; index3 += Class15.smethod_0(1))
          {
            short id = msg.method_1().method_6();
            if (id != (short) -1)
            {
              GClass20.smethod_1().arrItemBag[index3] = new GClass80();
              GClass20.smethod_1().arrItemBag[index3].template = GClass86.smethod_1(id);
              GClass20.smethod_1().arrItemBag[index3].quantity = msg.method_1().method_8();
              GClass20.smethod_1().arrItemBag[index3].info = msg.method_1().method_14();
              GClass20.smethod_1().arrItemBag[index3].content = msg.method_1().method_14();
              GClass20.smethod_1().arrItemBag[index3].indexUI = index3;
              sbyte length = msg.method_1().method_2();
              if (length != (sbyte) 0)
              {
                GClass20.smethod_1().arrItemBag[index3].itemOption = new GClass83[(int) length];
                for (int index4 = Class15.smethod_0(0); index4 < GClass20.smethod_1().arrItemBag[index3].itemOption.Length; index4 += Class15.smethod_0(1))
                {
                  int optionTemplateId = (int) msg.method_1().method_5();
                  int num4 = (int) msg.method_1().method_7();
                  GClass20.smethod_1().arrItemBag[index3].itemOption[index4] = new GClass83(optionTemplateId, num4);
                  GClass20.smethod_1().arrItemBag[index3].method_0();
                }
              }
              if ((int) GClass20.smethod_1().arrItemBag[index3].template.type == Class15.smethod_0(37))
                GClass116.int_37 += GClass20.smethod_1().arrItemBag[index3].quantity;
            }
          }
          GClass20.smethod_1().arrItemBox = new GClass80[(int) msg.method_1().method_2()];
          GClass62.gclass141_0.hasUse = Class15.smethod_0(0);
          for (int index5 = Class15.smethod_0(0); index5 < GClass20.smethod_1().arrItemBox.Length; index5 += Class15.smethod_0(1))
          {
            short id = msg.method_1().method_6();
            if (id != (short) -1)
            {
              GClass20.smethod_1().arrItemBox[index5] = new GClass80();
              GClass20.smethod_1().arrItemBox[index5].template = GClass86.smethod_1(id);
              GClass20.smethod_1().arrItemBox[index5].quantity = msg.method_1().method_8();
              GClass20.smethod_1().arrItemBox[index5].info = msg.method_1().method_14();
              GClass20.smethod_1().arrItemBox[index5].content = msg.method_1().method_14();
              GClass20.smethod_1().arrItemBox[index5].itemOption = new GClass83[(int) msg.method_1().method_2()];
              for (int index6 = Class15.smethod_0(0); index6 < GClass20.smethod_1().arrItemBox[index5].itemOption.Length; index6 += Class15.smethod_0(1))
              {
                int optionTemplateId = (int) msg.method_1().method_5();
                int num5 = (int) msg.method_1().method_7();
                GClass20.smethod_1().arrItemBox[index5].itemOption[index6] = new GClass83(optionTemplateId, num5);
                GClass20.smethod_1().arrItemBox[index5].method_0();
              }
              GClass62.gclass141_0.hasUse += Class15.smethod_0(1);
            }
          }
          GClass20.smethod_1().statusMe = Class15.smethod_0(2);
          GClass116.bool_7 = GClass152.smethod_8(GClass20.smethod_1().cName + Class13.smethod_0(175557)) >= Class15.smethod_0(1) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
          short length1 = msg.method_1().method_6();
          GClass20.short_0 = new short[(int) length1];
          GClass20.short_1 = new short[(int) length1];
          for (int index = Class15.smethod_0(0); index < (int) length1; index += Class15.smethod_0(1))
          {
            GClass20.short_0[index] = msg.method_1().method_6();
            GClass20.short_1[index] = msg.method_1().method_6();
          }
          for (int index = Class15.smethod_0(0); index < GClass116.gclass73_0.charId.Length; index += Class15.smethod_0(1))
            GClass116.gclass73_0.charId[index] = new int[Class15.smethod_0(5)];
          GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(0)] = (int) msg.method_1().method_6();
          GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(1)] = (int) msg.method_1().method_6();
          GClass116.gclass73_0.charId[GClass20.smethod_1().cgender][Class15.smethod_0(7)] = (int) msg.method_1().method_6();
          GClass20.smethod_1().isNhapThe = (int) msg.method_1().method_2() == Class15.smethod_0(1);
          GClass151.smethod_7(Class13.smethod_0(175553) + GClass20.smethod_1().isNhapThe.ToString());
          GClass116.long_1 = GClass126.smethod_18() - (long) msg.method_1().method_8() * (long) Class15.smethod_0(15);
          GClass116.sbyte_12 = msg.method_1().method_2();
          GClass156.smethod_0().method_30((sbyte) GClass20.smethod_1().cgender);
          GClass156.smethod_0().method_2();
          try
          {
            GClass20.smethod_1().idAuraEff = msg.method_1().method_6();
            GClass20.smethod_1().idEff_Set_Item = (short) msg.method_1().method_0();
            GClass20.smethod_1().idHat = msg.method_1().method_6();
            break;
          }
          catch (Exception ex)
          {
            break;
          }
        case 1:
          GClass62.smethod_7(Class13.smethod_0(175517), Class15.smethod_0(7));
          GClass20.smethod_1().nClass = GClass116.gclass137_0[(int) msg.method_1().method_2()];
          GClass20.smethod_1().cTiemNang = msg.method_1().method_9();
          GClass20.smethod_1().vSkill.method_9();
          GClass20.smethod_1().vSkillFight.method_9();
          GClass20.smethod_1().myskill = (GClass161) null;
          break;
        case 2:
          GClass62.smethod_7(Class13.smethod_0(175512), Class15.smethod_0(7));
          if (GClass20.smethod_1().statusMe != Class15.smethod_0(49) && GClass20.smethod_1().statusMe != Class15.smethod_0(3))
          {
            GClass20.smethod_1().cHP = GClass20.smethod_1().cHPFull;
            GClass20.smethod_1().cMP = GClass20.smethod_1().cMPFull;
            GClass33.smethod_3(Class13.smethod_0(175507));
          }
          GClass20.smethod_1().vSkill.method_9();
          GClass20.smethod_1().vSkillFight.method_9();
          sbyte num6 = msg.method_1().method_2();
          for (sbyte index = (sbyte) Class15.smethod_0(0); (int) index < (int) num6; index += (sbyte) Class15.smethod_0(1))
            this.method_14(GClass166.smethod_1(msg.method_1().method_6()));
          GClass116.smethod_6().method_64();
          if (!GClass116.bool_18)
            break;
          GClass116.int_45 = -1;
          GClass116.smethod_6().left = GClass116.smethod_6().center = (GClass31) null;
          break;
        case 3:
          break;
        case 4:
          GClass62.smethod_7(Class13.smethod_0(175158), Class15.smethod_0(7));
          GClass20.smethod_1().xu = msg.method_1().method_9();
          GClass20.smethod_1().luong = msg.method_1().method_8();
          GClass20.smethod_1().cHP = msg.method_3();
          GClass20.smethod_1().cMP = msg.method_3();
          GClass20.smethod_1().luongKhoa = msg.method_1().method_8();
          GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
          GClass20.smethod_1().luongStr = GClass126.smethod_6((long) GClass20.smethod_1().luong);
          GClass20.smethod_1().luongKhoaStr = GClass126.smethod_6((long) GClass20.smethod_1().luongKhoa);
          break;
        case 5:
          GClass62.smethod_7(Class13.smethod_0(175153), Class15.smethod_0(7));
          int cHp = GClass20.smethod_1().cHP;
          GClass20.smethod_1().cHP = msg.method_3();
          if (GClass20.smethod_1().cHP > cHp && (int) GClass20.smethod_1().cTypePk != Class15.smethod_0(2))
          {
            GClass116.smethod_17(Class13.smethod_0(175148) + (GClass20.smethod_1().cHP - cHp).ToString() + Class13.smethod_0(175146) + GClass109.string_369, GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(51), Class15.smethod_0(0), -1, GClass97.int_12);
            GClass172.smethod_1().method_3();
            if (GClass20.smethod_1().petFollow != null && (int) GClass20.smethod_1().petFollow.smallID == Class15.smethod_0(295))
              GClass46.smethod_0(GClass20.smethod_1().petFollow.cmx + (GClass20.smethod_1().petFollow.dir != Class15.smethod_0(1) ? Class15.smethod_0(136) : Class15.smethod_0(31)), GClass20.smethod_1().petFollow.cmy + Class15.smethod_0(31), Class15.smethod_0(1) != 0, -1, -1, GClass20.smethod_1(), Class15.smethod_0(36));
          }
          if (GClass20.smethod_1().cHP < cHp)
            GClass116.smethod_17(Class13.smethod_0(175144) + (cHp - GClass20.smethod_1().cHP).ToString() + Class13.smethod_0(175146) + GClass109.string_369, GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(51), Class15.smethod_0(0), -1, GClass97.int_12);
          GClass116.smethod_6().dHP = GClass20.smethod_1().cHP;
          if (!GClass116.bool_18)
            break;
          break;
        case 6:
          GClass62.smethod_7(Class13.smethod_0(175142), Class15.smethod_0(7));
          if (GClass20.smethod_1().statusMe == Class15.smethod_0(49) || GClass20.smethod_1().statusMe == Class15.smethod_0(3))
            break;
          int cMp = GClass20.smethod_1().cMP;
          GClass20.smethod_1().cMP = msg.method_3();
          if (GClass20.smethod_1().cMP > cMp)
          {
            GClass116.smethod_17(Class13.smethod_0(175148) + (GClass20.smethod_1().cMP - cMp).ToString() + Class13.smethod_0(175146) + GClass109.string_370, GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(29), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_13);
            GClass172.smethod_1().method_3();
            if (GClass20.smethod_1().petFollow != null && (int) GClass20.smethod_1().petFollow.smallID == Class15.smethod_0(296))
              GClass46.smethod_0(GClass20.smethod_1().petFollow.cmx + (GClass20.smethod_1().petFollow.dir != Class15.smethod_0(1) ? Class15.smethod_0(136) : Class15.smethod_0(31)), GClass20.smethod_1().petFollow.cmy + Class15.smethod_0(31), Class15.smethod_0(1) != 0, -1, -1, GClass20.smethod_1(), Class15.smethod_0(36));
          }
          if (GClass20.smethod_1().cMP < cMp)
            GClass116.smethod_17(Class13.smethod_0(175144) + (cMp - GClass20.smethod_1().cMP).ToString() + Class13.smethod_0(175146) + GClass109.string_370, GClass20.smethod_1().cx, GClass20.smethod_1().cy - GClass20.smethod_1().ch - Class15.smethod_0(29), Class15.smethod_0(0), Class15.smethod_0(132), GClass97.int_13);
          GClass151.smethod_7(Class13.smethod_0(175137) + GClass20.smethod_1().cMP.ToString());
          GClass116.smethod_6().dMP = GClass20.smethod_1().cMP;
          if (!GClass116.bool_18)
            break;
          break;
        case 7:
          GClass20 c1 = GClass116.smethod_12(msg.method_1().method_8());
          if (c1 == null)
            break;
          c1.clanID = msg.method_1().method_8();
          if (c1.clanID == Class15.smethod_0(132))
            c1.isCopy = Class15.smethod_0(1) != 0;
          this.method_15(c1, msg);
          try
          {
            c1.idAuraEff = msg.method_1().method_6();
            c1.idEff_Set_Item = (short) msg.method_1().method_0();
            c1.idHat = msg.method_1().method_6();
            if (c1.bag >= Class15.smethod_0(218))
            {
              c1.method_136(new GClass41(c1.bag, c1, Class15.smethod_0(7), -1, Class15.smethod_0(31), (sbyte) Class15.smethod_0(1))
              {
                typeEff = Class15.smethod_0(3)
              });
              break;
            }
            c1.method_137(Class15.smethod_0(0), Class15.smethod_0(218));
            break;
          }
          catch (Exception ex)
          {
            break;
          }
        case 8:
          GClass62.smethod_7(Class13.smethod_0(175127), Class15.smethod_0(7));
          GClass20 gclass20_1 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_1 == null)
            break;
          gclass20_1.cspeed = (int) msg.method_1().method_2();
          break;
        case 9:
          GClass62.smethod_7(Class13.smethod_0(175122), Class15.smethod_0(7));
          GClass20 gclass20_2 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_2 == null)
            break;
          gclass20_2.cHP = msg.method_3();
          gclass20_2.cHPFull = msg.method_3();
          break;
        case 10:
          GClass62.smethod_7(Class13.smethod_0(175117), Class15.smethod_0(7));
          GClass20 gclass20_3 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_3 == null)
            break;
          gclass20_3.cHP = msg.method_3();
          gclass20_3.cHPFull = msg.method_3();
          gclass20_3.eff5BuffHp = (int) msg.method_1().method_6();
          gclass20_3.eff5BuffMp = (int) msg.method_1().method_6();
          gclass20_3.wp = (int) msg.method_1().method_6();
          if (gclass20_3.wp != -1)
            break;
          gclass20_3.method_59();
          break;
        case 11:
          GClass62.smethod_7(Class13.smethod_0(175112), Class15.smethod_0(7));
          GClass20 gclass20_4 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_4 == null)
            break;
          gclass20_4.cHP = msg.method_3();
          gclass20_4.cHPFull = msg.method_3();
          gclass20_4.eff5BuffHp = (int) msg.method_1().method_6();
          gclass20_4.eff5BuffMp = (int) msg.method_1().method_6();
          gclass20_4.body = (int) msg.method_1().method_6();
          if (gclass20_4.body != -1)
            break;
          gclass20_4.method_60();
          break;
        case 12:
          GClass62.smethod_7(Class13.smethod_0(175107), Class15.smethod_0(7));
          GClass20 gclass20_5 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_5 == null)
            break;
          gclass20_5.cHP = msg.method_3();
          gclass20_5.cHPFull = msg.method_3();
          gclass20_5.eff5BuffHp = (int) msg.method_1().method_6();
          gclass20_5.eff5BuffMp = (int) msg.method_1().method_6();
          gclass20_5.leg = (int) msg.method_1().method_6();
          if (gclass20_5.leg != -1)
            break;
          gclass20_5.method_61();
          break;
        case 13:
          GClass62.smethod_7(Class13.smethod_0(175230), Class15.smethod_0(7));
          GClass20 gclass20_6 = GClass116.smethod_12(msg.method_1().method_8());
          if (gclass20_6 == null)
            break;
          gclass20_6.cHP = msg.method_3();
          gclass20_6.cHPFull = msg.method_3();
          gclass20_6.eff5BuffHp = (int) msg.method_1().method_6();
          gclass20_6.eff5BuffMp = (int) msg.method_1().method_6();
          break;
        case 14:
          GClass62.smethod_7(Class13.smethod_0(175225), Class15.smethod_0(7));
          GClass20 c2 = GClass116.smethod_12(msg.method_1().method_8());
          if (c2 == null)
            break;
          c2.cHP = msg.method_3();
          sbyte num7 = msg.method_1().method_2();
          GClass151.smethod_7(Class13.smethod_0(175220) + num7.ToString());
          if ((int) num7 == Class15.smethod_0(1))
          {
            GClass47.smethod_3(Class15.smethod_0(67), c2, Class15.smethod_0(3));
            GClass47.smethod_3(Class15.smethod_0(297), c2, Class15.smethod_0(2));
          }
          try
          {
            c2.cHPFull = msg.method_3();
            break;
          }
          catch (Exception ex)
          {
            break;
          }
        case 15:
          GClass62.smethod_7(Class13.smethod_0(175198), Class15.smethod_0(7));
          GClass20 c3 = GClass116.smethod_12(msg.method_1().method_8());
          if (c3 == null)
            break;
          c3.cHP = msg.method_3();
          c3.cHPFull = msg.method_3();
          c3.cx = (int) msg.method_1().method_6();
          c3.cy = (int) msg.method_1().method_6();
          c3.statusMe = Class15.smethod_0(1);
          c3.cp3 = Class15.smethod_0(5);
          GClass47.smethod_3(Class15.smethod_0(56), c3, Class15.smethod_0(7));
          break;
        case 16:
          break;
        case 17:
          break;
        case 18:
          break;
        case 19:
          GClass62.smethod_7(Class13.smethod_0(175492), Class15.smethod_0(7));
          GClass20.smethod_1().method_10();
          break;
        case 20:
          break;
        case 21:
          GClass62.smethod_7(Class13.smethod_0(175615), Class15.smethod_0(7));
          int num8 = msg.method_1().method_8();
          GClass20.smethod_1().xuInBox -= num8;
          GClass20.smethod_1().xu += (long) num8;
          GClass20.smethod_1().xuStr = GClass126.smethod_6(GClass20.smethod_1().xu);
          break;
        case 22:
          break;
        case 23:
          short skillId = msg.method_1().method_6();
          GClass161 gclass161_0 = GClass166.smethod_1(skillId);
          this.method_14(gclass161_0);
          if (skillId == (short) 0 || (int) skillId == Class15.smethod_0(49) || (int) skillId == Class15.smethod_0(35))
            break;
          GClass116.gclass73_0.method_7(GClass109.string_169 + Class13.smethod_0(175146) + gclass161_0.template.name, Class15.smethod_0(0));
          break;
        case 24:
          break;
        case 25:
          break;
        case 26:
          break;
        case 27:
          break;
        case 28:
          break;
        case 29:
          break;
        case 30:
          break;
        case 31:
          break;
        case 32:
          break;
        case 33:
          break;
        case 34:
          break;
        case 35:
          GClass62.smethod_7(Class13.smethod_0(175193), Class15.smethod_0(7));
          int charId1 = msg.method_1().method_8();
          GClass151.smethod_7(Class13.smethod_0(175189) + charId1.ToString());
          if (GClass185.int_37 == Class15.smethod_0(288))
            GClass116.smethod_6().method_90();
          if (charId1 == GClass20.smethod_1().charID)
          {
            GClass20.smethod_1().cTypePk = msg.method_1().method_2();
            if (GClass116.smethod_6().method_94() && GClass20.smethod_1().cTypePk != (sbyte) 0)
              GClass116.smethod_6().method_90();
            GClass151.smethod_7(Class13.smethod_0(175182) + GClass20.smethod_1().cTypePk.ToString());
            GClass20.smethod_1().npcFocus = (GClass21) null;
            if (!GClass116.smethod_6().method_31(GClass20.smethod_1().mobFocus))
              GClass20.smethod_1().mobFocus = (GClass100) null;
            GClass20.smethod_1().itemFocus = (GClass81) null;
          }
          else
          {
            GClass20 gclass20_7 = GClass116.smethod_12(charId1);
            if (gclass20_7 != null)
            {
              GClass151.smethod_7(Class13.smethod_0(175182) + gclass20_7.cTypePk.ToString());
              gclass20_7.cTypePk = msg.method_1().method_2();
              if (gclass20_7.method_101())
                GClass20.smethod_1().charFocus = gclass20_7;
            }
          }
          for (int charId2 = Class15.smethod_0(0); charId2 < GClass116.gclass134_5.method_2(); charId2 += Class15.smethod_0(1))
          {
            GClass20 gclass20_8 = GClass116.smethod_12(charId2);
            if (gclass20_8 != null && gclass20_8.cTypePk != (sbyte) 0 && (int) gclass20_8.cTypePk == (int) GClass20.smethod_1().cTypePk)
            {
              if (!GClass20.smethod_1().mobFocus.isMobMe)
                GClass20.smethod_1().mobFocus = (GClass100) null;
              GClass20.smethod_1().npcFocus = (GClass21) null;
              GClass20.smethod_1().itemFocus = (GClass81) null;
              break;
            }
          }
          GClass151.smethod_7(Class13.smethod_0(175172));
          break;
        default:
          switch ((int) num1 - Class15.smethod_0(293))
          {
            case 0:
              string str1 = msg.method_1().method_14();
              sbyte[] data = new sbyte[msg.method_1().method_8()];
              msg.method_1().method_16(ref data);
              if (data.Length == 0)
                data = (sbyte[]) null;
              if (str1.Equals(Class13.smethod_0(175283)))
              {
                GClass116.smethod_6().method_6(data);
                return;
              }
              if (str1.Equals(Class13.smethod_0(175276)))
              {
                GClass116.smethod_6().method_5(data);
                return;
              }
              if (!str1.Equals(Class13.smethod_0(175269)))
                return;
              GClass116.smethod_6().method_7(data);
              return;
            case 1:
              GClass151.smethod_7(Class13.smethod_0(175262));
              GClass161 gclass161 = GClass166.smethod_1(msg.method_1().method_6());
              for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().vSkill.method_2(); index += Class15.smethod_0(1))
              {
                if ((int) ((GClass161) GClass20.smethod_1().vSkill.method_3(index)).template.id == (int) gclass161.template.id)
                {
                  GClass20.smethod_1().vSkill.method_5((object) gclass161, index);
                  break;
                }
              }
              for (int index = Class15.smethod_0(0); index < GClass20.smethod_1().vSkillFight.method_2(); index += Class15.smethod_0(1))
              {
                if ((int) ((GClass161) GClass20.smethod_1().vSkillFight.method_3(index)).template.id == (int) gclass161.template.id)
                {
                  GClass20.smethod_1().vSkillFight.method_5((object) gclass161, index);
                  break;
                }
              }
              for (int index = Class15.smethod_0(0); index < GClass116.gclass161_1.Length; index += Class15.smethod_0(1))
              {
                if (GClass116.gclass161_1[index] != null && (int) GClass116.gclass161_1[index].template.id == (int) gclass161.template.id)
                {
                  GClass116.gclass161_1[index] = gclass161;
                  break;
                }
              }
              for (int index = Class15.smethod_0(0); index < GClass116.gclass161_0.Length; index += Class15.smethod_0(1))
              {
                if (GClass116.gclass161_0[index] != null && (int) GClass116.gclass161_0[index].template.id == (int) gclass161.template.id)
                {
                  GClass116.gclass161_0[index] = gclass161;
                  break;
                }
              }
              if ((int) GClass20.smethod_1().myskill.template.id == (int) gclass161.template.id)
                GClass20.smethod_1().myskill = gclass161;
              GClass116.gclass73_0.method_7(GClass109.string_350 + gclass161.template.name + GClass109.string_351 + gclass161.point.ToString(), Class15.smethod_0(0));
              return;
            case 2:
              sbyte num9 = msg.method_1().method_2();
              if ((int) num9 <= Class15.smethod_0(0))
                return;
              GClass71.smethod_1();
              GClass134 vPlayerMenu = GClass62.gclass141_0.vPlayerMenu;
              for (int index = Class15.smethod_0(0); index < (int) num9; index += Class15.smethod_0(1))
              {
                string caption = msg.method_1().method_14();
                string str2 = msg.method_1().method_14();
                short num10 = msg.method_1().method_6();
                GClass20.smethod_1().charFocus.menuSelect = (int) num10;
                int action = Class15.smethod_0(294);
                GClass20 charFocus = GClass20.smethod_1().charFocus;
                vPlayerMenu.method_0((object) new GClass31(caption, action, (object) charFocus)
                {
                  caption2 = str2
                });
              }
              GClass71.smethod_5();
              GClass62.gclass141_0.method_15();
              return;
            default:
              return;
          }
      }
    }
    catch (Exception ex)
    {
      GClass33.smethod_0(Class13.smethod_0(175246) + ex.ToString());
    }
    finally
    {
      msg?.method_4();
    }
  }

  private void method_14(GClass161 gclass161_0)
  {
    if ((GClass20.smethod_1().myskill == null ? 0 : 1) == 0)
      GClass20.smethod_1().myskill = gclass161_0;
    else if ((!gclass161_0.template.Equals((object) GClass20.smethod_1().myskill.template) ? 1 : 0) == 0)
      GClass20.smethod_1().myskill = gclass161_0;
    GClass20.smethod_1().vSkill.method_0((object) gclass161_0);
    if (gclass161_0.template.type != Class15.smethod_0(1) && gclass161_0.template.type != Class15.smethod_0(2) && gclass161_0.template.type != Class15.smethod_0(7) && gclass161_0.template.type != Class15.smethod_0(5) || (gclass161_0.template.maxPoint == 0 ? 1 : 0) == 0 && (gclass161_0.template.maxPoint <= Class15.smethod_0(0) || gclass161_0.point <= Class15.smethod_0(0)))
      return;
    if ((int) gclass161_0.template.id == GClass20.smethod_1().skillTemplateId)
      GClass156.smethod_0().method_57(GClass20.smethod_1().skillTemplateId);
    GClass20.smethod_1().vSkillFight.method_0((object) gclass161_0);
  }

  public bool method_15(GClass20 c, GClass96 msg)
  {
    try
    {
      c.clevel = (int) msg.method_1().method_2();
      c.isInvisiblez = msg.method_1().method_11();
      c.cTypePk = msg.method_1().method_2();
      string[] strArray1 = new string[Class15.smethod_0(37)];
      strArray1[Class15.smethod_0(0)] = Class13.smethod_0(175359);
      strArray1[Class15.smethod_0(1)] = c.cTypePk.ToString();
      strArray1[Class15.smethod_0(7)] = Class13.smethod_0(175345);
      strArray1[Class15.smethod_0(5)] = c.charID.ToString();
      strArray1[Class15.smethod_0(2)] = Class13.smethod_0(175333);
      strArray1[Class15.smethod_0(3)] = c.cName;
      GClass151.smethod_7(string.Concat(strArray1));
      c.nClass = GClass116.gclass137_0[(int) msg.method_1().method_2()];
      c.cgender = (int) msg.method_1().method_2();
      c.head = (int) msg.method_1().method_6();
      c.cName = msg.method_1().method_14();
      c.cHP = msg.method_3();
      c.dHP = c.cHP;
      if ((c.cHP == 0 ? 0 : 1) == 0)
        c.statusMe = Class15.smethod_0(49);
      c.cHPFull = msg.method_3();
      if (c.cy >= GClass185.int_24 - Class15.smethod_0(21))
        c.isFlyUp = Class15.smethod_0(1) != 0;
      c.body = (int) msg.method_1().method_6();
      c.leg = (int) msg.method_1().method_6();
      c.bag = (int) msg.method_1().method_5();
      string[] strArray2 = new string[Class15.smethod_0(45)];
      strArray2[Class15.smethod_0(0)] = Class13.smethod_0(175328);
      strArray2[Class15.smethod_0(1)] = c.body.ToString();
      strArray2[Class15.smethod_0(7)] = Class13.smethod_0(175320);
      strArray2[Class15.smethod_0(5)] = c.leg.ToString();
      strArray2[Class15.smethod_0(2)] = Class13.smethod_0(175313);
      strArray2[Class15.smethod_0(3)] = c.bag.ToString();
      strArray2[Class15.smethod_0(37)] = Class13.smethod_0(175307);
      strArray2[Class15.smethod_0(38)] = c.bag.ToString();
      strArray2[Class15.smethod_0(88)] = Class13.smethod_0(175300);
      GClass151.smethod_7(string.Concat(strArray2));
      c.isShadown = Class15.smethod_0(1) != 0;
      int num1 = (int) msg.method_1().method_2();
      if (c.wp == -1)
        c.method_59();
      if (c.body == -1)
        c.method_60();
      if (c.leg == -1)
        c.method_61();
      c.cx = (int) msg.method_1().method_6();
      c.cy = (int) msg.method_1().method_6();
      c.xSd = c.cx;
      c.ySd = c.cy;
      c.eff5BuffHp = (int) msg.method_1().method_6();
      c.eff5BuffMp = (int) msg.method_1().method_6();
      int num2 = (int) msg.method_1().method_2();
      for (int index = Class15.smethod_0(0); index < num2; index += Class15.smethod_0(1))
      {
        GClass48 o = new GClass48(msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_6());
        c.vEff.method_0((object) o);
        if ((int) o.template.type == Class15.smethod_0(66) || (int) o.template.type == Class15.smethod_0(67))
          c.isInvisiblez = Class15.smethod_0(1) != 0;
      }
      return Class15.smethod_0(1) != 0;
    }
    catch (Exception ex)
    {
      ex.StackTrace.ToString();
    }
    return Class15.smethod_0(0) != 0;
  }

  private void method_16(GClass96 gclass96_0)
  {
    try
    {
      string str = gclass96_0.method_1().method_14();
      sbyte nFrame = gclass96_0.method_1().method_2();
      GClass151.smethod_7(Class13.smethod_0(175906) + str + Class13.smethod_0(175883) + nFrame.ToString());
      sbyte[] numArray = GClass138.smethod_2(gclass96_0);
      GClass66 img = this.method_5(numArray);
      GClass69.smethod_0(str, img, nFrame);
      if ((numArray == null ? 1 : 0) != 0)
        return;
      GClass69.smethod_3(str, nFrame, numArray);
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(175880) + ex.StackTrace);
    }
  }

  private void method_17(GClass131 gclass131_0)
  {
    try
    {
      this.method_18(gclass131_0, (sbyte) -1, Class15.smethod_0(1) != 0);
    }
    catch (Exception ex)
    {
    }
  }

  private void method_18(GClass131 gclass131_0, sbyte sbyte_6, bool bool_6)
  {
    try
    {
      gclass131_0.method_3(Class15.smethod_0(17));
      GClass116.sbyte_3 = gclass131_0.method_2();
      sbyte_6 = gclass131_0.method_2();
      if ((sbyte_6 == (sbyte) 0 ? 0 : 1) == 0)
      {
        GClass116.smethod_6().iOptionTemplates = new GClass84[(int) gclass131_0.method_5()];
        for (int index = Class15.smethod_0(0); index < GClass116.smethod_6().iOptionTemplates.Length; index += Class15.smethod_0(1))
        {
          GClass116.smethod_6().iOptionTemplates[index] = new GClass84();
          GClass116.smethod_6().iOptionTemplates[index].id = index;
          GClass116.smethod_6().iOptionTemplates[index].name = gclass131_0.method_14();
          GClass116.smethod_6().iOptionTemplates[index].type = (int) gclass131_0.method_2();
        }
        if ((!bool_6 ? 1 : 0) != 0)
          return;
        gclass131_0.method_4();
        sbyte[] data = new sbyte[gclass131_0.method_18()];
        gclass131_0.method_17(ref data);
        GClass152.smethod_0(Class13.smethod_0(175982), data);
      }
      else if ((int) sbyte_6 == Class15.smethod_0(1))
      {
        GClass86.gclass128_0.method_1();
        int num = (int) gclass131_0.method_6();
        for (int templateID = Class15.smethod_0(0); templateID < num; templateID += Class15.smethod_0(1))
          GClass86.smethod_0(new GClass85((short) templateID, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_11()));
        if ((!bool_6 ? 1 : 0) != 0)
          return;
        gclass131_0.method_4();
        sbyte[] data = new sbyte[gclass131_0.method_18()];
        gclass131_0.method_17(ref data);
        GClass152.smethod_0(Class13.smethod_0(175974), data);
      }
      else if ((int) sbyte_6 == Class15.smethod_0(7))
      {
        int num1 = (int) gclass131_0.method_6();
        int num2 = (int) gclass131_0.method_6();
        for (int templateID = num1; templateID < num2; templateID += Class15.smethod_0(1))
          GClass86.smethod_0(new GClass85((short) templateID, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_11()));
        if ((!bool_6 ? 1 : 0) != 0)
          return;
        gclass131_0.method_4();
        sbyte[] data1 = new sbyte[gclass131_0.method_18()];
        gclass131_0.method_17(ref data1);
        GClass152.smethod_0(Class13.smethod_0(175966), data1);
        sbyte[] numArray = new sbyte[Class15.smethod_0(1)];
        numArray[Class15.smethod_0(0)] = GClass116.sbyte_3;
        sbyte[] data2 = numArray;
        GClass152.smethod_0(Class13.smethod_0(175958), data2);
        GClass117.bool_6 = Class15.smethod_0(0) != 0;
        if ((int) GClass116.sbyte_4 != (int) GClass116.sbyte_0 || (int) GClass116.sbyte_5 != (int) GClass116.sbyte_1 || (int) GClass116.sbyte_6 != (int) GClass116.sbyte_2 || (int) GClass116.sbyte_7 != (int) GClass116.sbyte_3)
          return;
        GClass116.smethod_6().method_22();
        GClass116.smethod_6().method_20();
        GClass116.smethod_6().method_21();
        GClass116.smethod_6().method_23();
        GClass156.smethod_0().method_84();
      }
      else
      {
        if ((int) sbyte_6 != Class15.smethod_0(21))
          return;
        GClass20.int_23 = this.method_20(gclass131_0);
        if ((!bool_6 ? 1 : 0) != 0)
          return;
        gclass131_0.method_4();
        sbyte[] data = new sbyte[gclass131_0.method_18()];
        gclass131_0.method_17(ref data);
        GClass152.smethod_0(Class13.smethod_0(175944), data);
      }
    }
    catch (Exception ex)
    {
      ex.ToString();
    }
  }

  private void method_19(GClass96 gclass96_0, int int_2)
  {
    try
    {
      int length1 = (int) gclass96_0.method_1().method_2();
      int[][] v = new int[length1][];
      for (int index1 = Class15.smethod_0(0); index1 < length1; index1 += Class15.smethod_0(1))
      {
        int length2 = (int) gclass96_0.method_1().method_2();
        v[index1] = new int[length2];
        for (int index2 = Class15.smethod_0(0); index2 < length2; index2 += Class15.smethod_0(1))
          v[index1][index2] = (int) gclass96_0.method_1().method_2();
      }
      GClass32.gclass128_0.method_4((object) (int_2.ToString() + string.Empty), (object) v);
    }
    catch (Exception ex)
    {
    }
  }

  private int[][] method_20(GClass131 gclass131_0)
  {
    int[][] numArray1 = new int[Class15.smethod_0(1)][];
    int index1 = Class15.smethod_0(0);
    int[] numArray2 = new int[Class15.smethod_0(7)];
    numArray2[Class15.smethod_0(0)] = Class15.smethod_0(258);
    numArray2[Class15.smethod_0(1)] = Class15.smethod_0(259);
    numArray1[index1] = numArray2;
    int[][] numArray3 = numArray1;
    try
    {
      numArray3 = new int[(int) gclass131_0.method_6()][];
      for (int index2 = Class15.smethod_0(0); index2 < numArray3.Length; index2 += Class15.smethod_0(1))
      {
        int length = (int) gclass131_0.method_2();
        numArray3[index2] = new int[length];
        for (int index3 = Class15.smethod_0(0); index3 < length; index3 += Class15.smethod_0(1))
          numArray3[index2][index3] = (int) gclass131_0.method_6();
      }
      return numArray3;
    }
    catch (Exception ex)
    {
      return numArray3;
    }
  }

  public void method_21(GClass96 msg)
  {
    try
    {
      sbyte int_2 = msg.method_1().method_2();
      if ((int_2 == (sbyte) 0 ? 0 : 1) != 0)
        return;
      this.method_22(msg, (int) int_2);
    }
    catch (Exception ex)
    {
    }
  }

  private void method_22(GClass96 gclass96_0, int int_2)
  {
    try
    {
      sbyte num1 = gclass96_0.method_1().method_2();
      if ((num1 == (sbyte) 0 ? 0 : 1) == 0)
      {
        short idmapPaint = gclass96_0.method_1().method_6();
        string nameTeam1 = gclass96_0.method_1().method_14();
        string nameTeam2 = gclass96_0.method_1().method_14();
        int maxPoint = gclass96_0.method_1().method_8();
        short timeSecond = gclass96_0.method_1().method_6();
        int num2 = (int) gclass96_0.method_1().method_2();
        GClass116.gclass74_0 = new GClass74(int_2, idmapPaint, nameTeam1, nameTeam2, maxPoint, timeSecond);
        GClass116.gclass74_0.maxLife = num2;
        GClass116.gclass74_0.method_2(int_2, Class15.smethod_0(0), Class15.smethod_0(0));
      }
      else if ((int) num1 == Class15.smethod_0(1))
      {
        int pointTeam1 = gclass96_0.method_1().method_8();
        int pointTeam2 = gclass96_0.method_1().method_8();
        if ((GClass116.gclass74_0 == null ? 1 : 0) != 0)
          return;
        GClass116.gclass74_0.method_1(int_2, pointTeam1, pointTeam2);
      }
      else if ((int) num1 == Class15.smethod_0(7))
      {
        sbyte num3 = gclass96_0.method_1().method_2();
        short type = (short) Class15.smethod_0(0);
        if ((int) num3 == Class15.smethod_0(1))
        {
          type = (short) Class15.smethod_0(1);
          Class15.smethod_0(5);
        }
        else if ((int) num3 == Class15.smethod_0(7))
          type = (short) Class15.smethod_0(7);
        GClass116.gclass74_0 = (GClass74) null;
        GClass116.smethod_34((int) type, -1, GClass62.int_12, GClass62.int_13, Class15.smethod_0(0), Class15.smethod_0(0));
      }
      else if ((int) num1 == Class15.smethod_0(3))
      {
        short timeSecond = gclass96_0.method_1().method_6();
        if ((GClass116.gclass74_0 == null ? 1 : 0) != 0)
          return;
        GClass116.gclass74_0.method_0(int_2, timeSecond);
      }
      else
      {
        if ((int) num1 != Class15.smethod_0(2))
          return;
        int lifeTeam1 = (int) gclass96_0.method_1().method_2();
        int lifeTeam2 = (int) gclass96_0.method_1().method_2();
        if ((GClass116.gclass74_0 == null ? 1 : 0) != 0)
          return;
        GClass116.gclass74_0.method_2(int_2, lifeTeam1, lifeTeam2);
      }
    }
    catch (Exception ex)
    {
    }
  }

  public void method_23(GClass96 msg)
  {
    try
    {
      if ((msg.method_1().method_2() == (sbyte) 0 ? 0 : 1) != 0)
        return;
      short num = msg.method_1().method_6();
      GClass20.smethod_1().idHat = num;
      GClass172.smethod_1().method_2();
    }
    catch (Exception ex)
    {
    }
  }
}
