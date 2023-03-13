// Decompiled with JetBrains decompiler
// Type: GClass65
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

public class GClass65
{
  public static int int_0;
  public static int int_1;
  public static int int_2;
  public static int int_3;
  public static int int_4;
  public static int int_5;
  public static bool bool_0;
  public static bool bool_1;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  public static bool bool_5;
  public static bool bool_6;
  public static int int_6;
  public static bool bool_7;
  public static bool bool_8;
  private int int_7 = Class15.smethod_0(7);

  public static bool smethod_0(int tastId, int index) => (GClass20.smethod_1().taskMaint == null ? 1 : 0) == 0 && (int) GClass20.smethod_1().taskMaint.taskId == tastId && GClass20.smethod_1().taskMaint.index == index ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public static bool smethod_1()
  {
    if ((!GClass65.smethod_0(Class15.smethod_0(0), Class15.smethod_0(5)) ? 1 : 0) == 0 && (GClass62.gclass141_0.currentTabIndex == 0 ? 0 : 1) == 0 && (GClass62.gclass141_0.cmy < Class15.smethod_0(0) || GClass62.gclass141_0.cmy > Class15.smethod_0(6)))
      return Class15.smethod_0(0) != 0;
    return (!GClass65.smethod_0(Class15.smethod_0(7), Class15.smethod_0(0)) ? 1 : 0) == 0 && (!GClass62.gclass141_0.isShow ? 1 : 0) == 0 && (GClass62.gclass141_0.currentTabIndex == 0 ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
  }

  public static void smethod_2()
  {
    if ((!GClass62.gclass141_0.isShow ? 1 : 0) == 0)
      GClass65.bool_5 = Class15.smethod_0(0) != 0;
    if ((GClass116.smethod_15() == null ? 1 : 0) != 0)
      return;
    GClass65.int_0 = GClass116.smethod_15().cx;
    GClass65.int_1 = GClass116.smethod_15().cy;
    GClass65.int_6 = Class15.smethod_0(0);
    GClass65.bool_6 = Class15.smethod_0(1) != 0;
    GClass65.int_2 = (!GClass62.bool_5 ? 0 : 1) != 0 ? Class15.smethod_0(1) : Class15.smethod_0(0);
  }

  public static void smethod_3(int index)
  {
    if ((!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || GClass148.gclass134_0.method_2() - Class15.smethod_0(1) < index)
      return;
    GClass148 gclass148 = (GClass148) GClass148.gclass134_0.method_3(index);
    GClass65.int_0 = gclass148.cx + gclass148.sayWidth / Class15.smethod_0(7);
    GClass65.int_1 = gclass148.cy + Class15.smethod_0(6);
    GClass65.bool_5 = (!gclass148.isHide ? 0 : 1) != 0 || (!gclass148.isPaint ? 0 : 1) == 0 ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
    GClass65.int_2 = Class15.smethod_0(0);
    GClass65.bool_6 = Class15.smethod_0(1) != 0;
    GClass65.int_6 = Class15.smethod_0(0);
    if ((!GClass62.bool_5 ? 0 : 1) != 0)
      return;
    GClass65.bool_5 = Class15.smethod_0(0) != 0;
  }

  public static void smethod_4()
  {
    GClass65.int_2 = Class15.smethod_0(1);
    if ((!GClass62.gclass141_0.isShow ? 1 : 0) == 0)
      GClass65.bool_5 = Class15.smethod_0(0) != 0;
    bool flag = Class15.smethod_0(0) != 0;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      if ((!((GClass100) GClass116.gclass134_9.method_3(index)).isHintFocus ? 1 : 0) == 0)
      {
        flag = Class15.smethod_0(1) != 0;
        break;
      }
    }
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_9.method_2(); index += Class15.smethod_0(1))
    {
      GClass100 gclass100 = (GClass100) GClass116.gclass134_9.method_3(index);
      if ((!gclass100.isHintFocus ? 1 : 0) != 0)
      {
        if ((!flag ? 0 : 1) == 0)
        {
          if ((gclass100.status == 0 ? 1 : 0) != 0)
          {
            gclass100.isHintFocus = Class15.smethod_0(0) != 0;
          }
          else
          {
            gclass100.isHintFocus = Class15.smethod_0(1) != 0;
            break;
          }
        }
      }
      else
      {
        GClass65.int_0 = gclass100.x;
        GClass65.int_1 = gclass100.y + Class15.smethod_0(3);
        GClass65.bool_6 = Class15.smethod_0(1) != 0;
        if ((gclass100.status == 0 ? 0 : 1) != 0)
          break;
        gclass100.isHintFocus = Class15.smethod_0(0) != 0;
        break;
      }
    }
  }

  public static bool smethod_5()
  {
    if ((!GClass62.gclass141_0.isShow ? 1 : 0) == 0)
      GClass65.bool_5 = Class15.smethod_0(0) != 0;
    for (int index = Class15.smethod_0(0); index < GClass116.gclass134_6.method_2(); index += Class15.smethod_0(1))
    {
      GClass81 gclass81 = (GClass81) GClass116.gclass134_6.method_3(index);
      if (gclass81.playerId == GClass20.smethod_1().charID && (int) gclass81.template.id == Class15.smethod_0(184))
      {
        GClass65.int_2 = Class15.smethod_0(1);
        GClass65.int_0 = gclass81.x;
        GClass65.int_1 = gclass81.y + Class15.smethod_0(3);
        GClass65.bool_6 = Class15.smethod_0(1) != 0;
        return Class15.smethod_0(1) != 0;
      }
    }
    return Class15.smethod_0(0) != 0;
  }

  public static void smethod_6(GClass98 g)
  {
    try
    {
      if ((!GClass65.bool_8 ? 1 : 0) != 0 || GClass65.int_0 > GClass116.int_22 && GClass65.int_0 < GClass116.int_22 + GClass116.int_6 && GClass65.int_1 > GClass116.int_23 && GClass65.int_1 < GClass116.int_23 + GClass116.int_7 || GClass62.int_8 % Class15.smethod_0(31) < Class15.smethod_0(3) || (GClass43.gclass43_0 == null ? 0 : 1) != 0 || (GClass43.gclass43_1 == null ? 0 : 1) != 0 || (!GClass62.gclass141_0.isShow ? 0 : 1) != 0 || (!GClass65.bool_6 ? 0 : 1) == 0)
        return;
      int i1 = GClass65.int_0 - GClass20.smethod_1().cx;
      int i2 = GClass65.int_1 - GClass20.smethod_1().cy;
      int x = Class15.smethod_0(0);
      int y = Class15.smethod_0(0);
      int num = Class15.smethod_0(0);
      if (i1 > Class15.smethod_0(0) && i2 >= Class15.smethod_0(0))
      {
        if (GClass151.smethod_25(i1) >= GClass151.smethod_25(i2))
        {
          x = GClass116.int_6 - Class15.smethod_0(31);
          y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(6);
          if ((!GClass62.bool_5 ? 1 : 0) == 0)
            y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(31);
          num = Class15.smethod_0(0);
        }
        else
        {
          x = GClass116.int_6 / Class15.smethod_0(7);
          y = GClass116.int_7 - Class15.smethod_0(31);
          num = Class15.smethod_0(3);
        }
      }
      else if (i1 >= Class15.smethod_0(0) && i2 < Class15.smethod_0(0))
      {
        if (GClass151.smethod_25(i1) >= GClass151.smethod_25(i2))
        {
          x = GClass116.int_6 - Class15.smethod_0(31);
          y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(6);
          if ((!GClass62.bool_5 ? 1 : 0) == 0)
            y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(31);
          num = Class15.smethod_0(0);
        }
        else
        {
          x = GClass116.int_6 / Class15.smethod_0(7);
          y = Class15.smethod_0(31);
          num = Class15.smethod_0(37);
        }
      }
      if (i1 < Class15.smethod_0(0) && i2 >= Class15.smethod_0(0))
      {
        if (GClass151.smethod_25(i1) >= GClass151.smethod_25(i2))
        {
          x = Class15.smethod_0(31);
          y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(6);
          if ((!GClass62.bool_5 ? 1 : 0) == 0)
            y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(31);
          num = Class15.smethod_0(5);
        }
        else
        {
          x = GClass116.int_6 / Class15.smethod_0(7);
          y = GClass116.int_7 - Class15.smethod_0(31);
          num = Class15.smethod_0(3);
        }
      }
      else if (i1 <= Class15.smethod_0(0) && i2 < Class15.smethod_0(0))
      {
        if (GClass151.smethod_25(i1) >= GClass151.smethod_25(i2))
        {
          x = Class15.smethod_0(31);
          y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(6);
          if ((!GClass62.bool_5 ? 1 : 0) == 0)
            y = GClass116.int_7 / Class15.smethod_0(7) + Class15.smethod_0(31);
          num = Class15.smethod_0(5);
        }
        else
        {
          x = GClass116.int_6 / Class15.smethod_0(7);
          y = Class15.smethod_0(31);
          num = Class15.smethod_0(37);
        }
      }
      GClass116.smethod_16(g);
      g.method_24(GClass116.gclass66_45, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(47), Class15.smethod_0(10), num, x, y, GClass177.int_6);
    }
    catch (Exception ex)
    {
    }
  }

  public static void smethod_7(GClass98 g)
  {
    if ((GClass43.gclass43_1 == null ? 0 : 1) != 0 || (!GClass20.smethod_1().isUsePlane ? 0 : 1) != 0 || (!GClass20.smethod_1().isTeleport ? 1 : 0) == 0)
      return;
    GClass65.smethod_6(g);
    if ((GClass62.gclass95_0.tDelay == 0 ? 0 : 1) != 0 || (!GClass65.bool_5 ? 1 : 0) != 0 || (GClass43.gclass154_0 == null ? 0 : 1) != 0 || (!GClass20.bool_2 ? 0 : 1) != 0 || GClass62.gclass113_0 != GClass116.smethod_6() || (!GClass62.gclass141_0.isShow ? 1 : 0) == 0 && (GClass62.gclass141_0.cmx == 0 ? 0 : 1) != 0)
      return;
    if ((!GClass65.bool_6 ? 1 : 0) == 0)
      g.method_1(-GClass116.int_22, -GClass116.int_23);
    if ((GClass65.int_6 == 0 ? 0 : 1) == 0)
      g.method_32(GClass141.gclass66_0, GClass65.int_0 - Class15.smethod_0(9), GClass65.int_1, Class15.smethod_0(0));
    if (GClass65.int_6 == Class15.smethod_0(1))
      g.method_24(GClass141.gclass66_0, Class15.smethod_0(0), Class15.smethod_0(0), Class15.smethod_0(49), Class15.smethod_0(10), Class15.smethod_0(7), GClass65.int_0 + Class15.smethod_0(9), GClass65.int_1, GClass177.int_2);
    if ((!GClass65.bool_7 ? 1 : 0) != 0)
      return;
    g.method_32(GClass81.gclass66_0, GClass65.int_0, GClass65.int_1, Class15.smethod_0(5));
  }

  public static void smethod_8()
  {
    if (GClass20.smethod_1().taskMaint != null && GClass62.gclass113_0 == GClass116.gclass116_0)
    {
      int taskId = (int) GClass20.smethod_1().taskMaint.taskId;
      int index1 = GClass20.smethod_1().taskMaint.index;
      GClass65.bool_6 = Class15.smethod_0(0) != 0;
      GClass65.int_6 = Class15.smethod_0(0);
      GClass65.int_2 = Class15.smethod_0(0);
      GClass65.bool_5 = Class15.smethod_0(1) != 0;
      GClass65.bool_8 = Class15.smethod_0(1) != 0;
      if (GClass62.gclass95_0.showMenu && taskId > Class15.smethod_0(0))
        GClass65.bool_5 = Class15.smethod_0(0) != 0;
      switch (taskId)
      {
        case 0:
          if (GClass43.gclass43_0 == null && GClass20.smethod_1().statusMe != Class15.smethod_0(49))
          {
            if (index1 == 0 && GClass185.gclass134_0.method_2() != 0)
            {
              GClass65.int_0 = (int) ((GClass190) GClass185.gclass134_0.method_3(Class15.smethod_0(0))).minX - Class15.smethod_0(21);
              GClass65.int_1 = (int) ((GClass190) GClass185.gclass134_0.method_3(Class15.smethod_0(0))).minY + Class15.smethod_0(54);
              GClass65.bool_6 = Class15.smethod_0(1) != 0;
            }
            if (index1 == Class15.smethod_0(1))
              GClass65.smethod_3(Class15.smethod_0(0));
            if (index1 == Class15.smethod_0(7))
              GClass65.smethod_2();
            if (index1 == Class15.smethod_0(5))
            {
              if (!GClass62.gclass141_0.isShow)
                GClass65.smethod_2();
              else if (GClass62.gclass141_0.currentTabIndex == 0)
              {
                if (GClass62.gclass141_0.cp == null)
                {
                  GClass65.int_0 = GClass62.gclass141_0.xScroll + GClass62.gclass141_0.wScroll / Class15.smethod_0(7);
                  GClass65.int_1 = GClass62.gclass141_0.yScroll + Class15.smethod_0(51);
                }
                else if (GClass62.gclass95_0.tDelay != 0)
                {
                  GClass65.int_0 = GClass62.gclass141_0.xScroll + Class15.smethod_0(46);
                  GClass65.int_1 = GClass62.gclass141_0.yScroll + Class15.smethod_0(4);
                }
              }
              else if (GClass62.gclass141_0.currentTabIndex == Class15.smethod_0(1))
              {
                GClass65.int_0 = GClass62.gclass141_0.startTabPos + Class15.smethod_0(31);
                GClass65.int_1 = Class15.smethod_0(130);
              }
            }
            if (index1 == Class15.smethod_0(2))
            {
              if (GClass62.gclass141_0.isShow)
              {
                GClass65.int_0 = GClass62.gclass141_0.cmdClose.x + Class15.smethod_0(3);
                GClass65.int_1 = GClass62.gclass141_0.cmdClose.y + Class15.smethod_0(3);
              }
              else if (GClass62.gclass95_0.showMenu)
              {
                GClass65.int_0 = GClass62.int_10 / Class15.smethod_0(7);
                GClass65.int_1 = GClass62.int_11 - Class15.smethod_0(51);
              }
              else
                GClass65.smethod_2();
            }
            if (index1 != Class15.smethod_0(3))
              break;
            GClass65.smethod_2();
            break;
          }
          GClass65.int_0 = GClass62.int_10 / Class15.smethod_0(7);
          GClass65.int_1 = GClass62.int_11 - Class15.smethod_0(9);
          break;
        case 1:
          if (GClass43.gclass43_0 == null && GClass20.smethod_1().statusMe != Class15.smethod_0(49))
          {
            if (index1 == 0)
            {
              if (GClass185.smethod_5())
                GClass65.smethod_3(Class15.smethod_0(0));
              else
                GClass65.smethod_4();
            }
            if (index1 != Class15.smethod_0(1))
              break;
            if (!GClass185.smethod_5())
            {
              GClass65.smethod_3(Class15.smethod_0(1));
              break;
            }
            GClass65.smethod_2();
            break;
          }
          GClass65.int_0 = GClass62.int_10 / Class15.smethod_0(7);
          GClass65.int_1 = GClass62.int_11 - Class15.smethod_0(9);
          break;
        case 2:
          if (GClass43.gclass43_0 == null && GClass20.smethod_1().statusMe != Class15.smethod_0(49))
          {
            if (index1 == 0)
            {
              if (!GClass185.smethod_5())
                GClass65.bool_2 = Class15.smethod_0(1) != 0;
              if (!GClass62.gclass141_0.isShow)
              {
                if (!GClass65.bool_2)
                {
                  GClass65.int_0 = GClass116.smethod_6().cmdMenu.x;
                  GClass65.int_1 = GClass116.smethod_6().cmdMenu.y + Class15.smethod_0(47);
                  GClass65.int_6 = Class15.smethod_0(1);
                }
                else
                {
                  if (GClass116.smethod_25() == GClass185.int_37)
                  {
                    if (!GClass65.smethod_5())
                      GClass65.smethod_4();
                  }
                  else
                    GClass65.smethod_3(Class15.smethod_0(0));
                  if (GClass65.bool_2)
                    GClass65.bool_3 = Class15.smethod_0(1) != 0;
                }
              }
              else if (!GClass65.bool_2)
              {
                if (GClass62.gclass141_0.currentTabIndex == 0)
                {
                  int num = GClass62.int_11 <= Class15.smethod_0(137) ? Class15.smethod_0(31) : Class15.smethod_0(9);
                  GClass65.int_0 = GClass62.gclass141_0.xScroll + GClass62.gclass141_0.wScroll / Class15.smethod_0(7);
                  GClass65.int_1 = GClass62.gclass141_0.yScroll + GClass62.gclass141_0.hScroll - num;
                }
                else
                {
                  GClass65.int_0 = GClass62.gclass141_0.startTabPos + Class15.smethod_0(31);
                  GClass65.int_1 = Class15.smethod_0(130);
                }
              }
              else if (!GClass65.bool_3)
              {
                GClass65.int_0 = GClass62.gclass141_0.cmdClose.x + Class15.smethod_0(3);
                GClass65.int_1 = GClass62.gclass141_0.cmdClose.y + Class15.smethod_0(3);
              }
              else
                GClass65.bool_5 = Class15.smethod_0(0) != 0;
              if (GClass20.smethod_1().cMP <= Class15.smethod_0(0))
              {
                GClass65.int_0 = GClass116.int_102 + Class15.smethod_0(3);
                GClass65.int_1 = GClass116.int_103 + Class15.smethod_0(47);
                GClass65.bool_6 = Class15.smethod_0(0) != 0;
              }
            }
            if (index1 != Class15.smethod_0(1))
              break;
            GClass65.bool_5 = Class15.smethod_0(0) != 0;
            GClass65.bool_8 = Class15.smethod_0(0) != 0;
            break;
          }
          GClass65.int_0 = GClass62.int_10 / Class15.smethod_0(7);
          GClass65.int_1 = GClass62.int_11 - Class15.smethod_0(9);
          break;
        case 3:
          if (GClass43.gclass43_0 == null && GClass20.smethod_1().statusMe != Class15.smethod_0(49))
          {
            if (index1 == 0)
            {
              if (!GClass62.gclass141_0.isShow)
              {
                if (!GClass65.bool_4)
                {
                  GClass65.int_0 = GClass116.smethod_6().cmdMenu.x;
                  GClass65.int_1 = GClass116.smethod_6().cmdMenu.y + Class15.smethod_0(47);
                  GClass65.int_6 = Class15.smethod_0(1);
                }
                else
                {
                  if (GClass116.smethod_25() == GClass185.int_37)
                  {
                    if (!GClass65.smethod_5())
                      GClass65.smethod_4();
                  }
                  else
                    GClass65.smethod_3(Class15.smethod_0(0));
                  if (GClass65.bool_2)
                    GClass65.bool_3 = Class15.smethod_0(1) != 0;
                }
              }
              else if (!GClass65.bool_4)
              {
                Class15.smethod_0(137);
                GClass65.int_0 = GClass62.gclass141_0.xScroll + Class15.smethod_0(31) + Class15.smethod_0(59) - Class15.smethod_0(124);
                GClass65.int_1 = Class15.smethod_0(130);
              }
              else if (!GClass65.bool_3)
              {
                GClass65.int_0 = GClass62.gclass141_0.cmdClose.x + Class15.smethod_0(3);
                GClass65.int_1 = GClass62.gclass141_0.cmdClose.y + Class15.smethod_0(3);
              }
              else
                GClass65.bool_5 = Class15.smethod_0(0) != 0;
              if (GClass20.smethod_1().cMP > Class15.smethod_0(0))
                break;
              GClass65.int_0 = GClass116.int_102 + Class15.smethod_0(3);
              GClass65.int_1 = GClass116.int_103 + Class15.smethod_0(47);
              GClass65.bool_6 = Class15.smethod_0(0) != 0;
              break;
            }
            GClass65.bool_5 = Class15.smethod_0(0) != 0;
            GClass65.bool_8 = Class15.smethod_0(0) != 0;
            break;
          }
          GClass65.int_0 = GClass62.int_10 / Class15.smethod_0(7);
          GClass65.int_1 = GClass62.int_11 - Class15.smethod_0(9);
          break;
        default:
          if ((int) GClass20.smethod_1().taskMaint.taskId == Class15.smethod_0(45) && GClass20.smethod_1().taskMaint.index == Class15.smethod_0(7))
          {
            for (int index2 = Class15.smethod_0(0); index2 < GClass148.gclass134_0.method_2(); index2 += Class15.smethod_0(1))
            {
              GClass148 gclass148 = (GClass148) GClass148.gclass134_0.method_3(index2);
              if (gclass148.cy <= Class15.smethod_0(40))
              {
                GClass65.int_0 = gclass148.cx + gclass148.sayWidth / Class15.smethod_0(7);
                GClass65.int_1 = gclass148.cy + Class15.smethod_0(6);
                GClass65.bool_6 = Class15.smethod_0(1) != 0;
                GClass65.bool_5 = Class15.smethod_0(0) != 0;
                GClass65.bool_8 = Class15.smethod_0(1) != 0;
                return;
              }
            }
          }
          GClass65.bool_5 = Class15.smethod_0(0) != 0;
          GClass65.bool_8 = Class15.smethod_0(0) != 0;
          break;
      }
    }
    else
    {
      GClass65.bool_5 = Class15.smethod_0(0) != 0;
      GClass65.bool_8 = Class15.smethod_0(0) != 0;
    }
  }

  public static void smethod_9()
  {
    GClass65.smethod_8();
    int num = (GClass65.int_6 == 0 ? 0 : 1) != 0 ? Class15.smethod_0(132) : Class15.smethod_0(7);
    if ((!GClass65.bool_1 ? 0 : 1) == 0)
    {
      GClass65.bool_7 = Class15.smethod_0(0) != 0;
      GClass65.int_3 += Class15.smethod_0(1);
      if (GClass65.int_3 != Class15.smethod_0(32))
        return;
      GClass65.int_3 = Class15.smethod_0(0);
      GClass65.bool_1 = Class15.smethod_0(1) != 0;
    }
    else
    {
      GClass65.int_3 += Class15.smethod_0(1);
      if ((GClass65.int_2 == 0 ? 0 : 1) == 0)
      {
        if (GClass65.int_3 == Class15.smethod_0(7))
        {
          GClass65.int_0 += Class15.smethod_0(7) * num;
          GClass65.int_1 -= Class15.smethod_0(2);
          GClass65.bool_7 = Class15.smethod_0(1) != 0;
        }
        if (GClass65.int_3 == Class15.smethod_0(2))
        {
          GClass65.int_0 -= Class15.smethod_0(7) * num;
          GClass65.int_1 += Class15.smethod_0(2);
          GClass65.bool_1 = Class15.smethod_0(0) != 0;
          GClass65.bool_7 = Class15.smethod_0(0) != 0;
          GClass65.int_3 = Class15.smethod_0(0);
        }
        if (GClass65.int_3 > Class15.smethod_0(2))
          GClass65.bool_1 = Class15.smethod_0(0) != 0;
      }
      if (GClass65.int_2 != Class15.smethod_0(1))
        return;
      if (GClass65.int_3 == Class15.smethod_0(7))
      {
        if ((!GClass62.bool_5 ? 1 : 0) == 0)
          GClass116.smethod_17(GClass109.string_236, GClass65.int_0, GClass65.int_1 + Class15.smethod_0(31), Class15.smethod_0(0), Class15.smethod_0(51), GClass97.int_10);
        GClass65.bool_7 = Class15.smethod_0(1) != 0;
        GClass65.int_0 += Class15.smethod_0(7) * num;
        GClass65.int_1 -= Class15.smethod_0(2);
      }
      if (GClass65.int_3 == Class15.smethod_0(2))
      {
        GClass65.bool_7 = Class15.smethod_0(0) != 0;
        GClass65.int_0 -= num;
        GClass65.int_1 += Class15.smethod_0(7);
      }
      if (GClass65.int_3 == Class15.smethod_0(37))
      {
        GClass65.bool_7 = Class15.smethod_0(1) != 0;
        GClass65.int_0 += num;
        GClass65.int_1 -= Class15.smethod_0(7);
      }
      if (GClass65.int_3 == Class15.smethod_0(88))
      {
        GClass65.bool_7 = Class15.smethod_0(0) != 0;
        GClass65.int_0 -= num;
        GClass65.int_1 += Class15.smethod_0(7);
      }
      if (GClass65.int_3 != Class15.smethod_0(31))
        return;
      GClass65.int_0 -= num;
      GClass65.int_1 += Class15.smethod_0(7);
      GClass65.bool_1 = Class15.smethod_0(0) != 0;
      GClass65.int_3 = Class15.smethod_0(0);
    }
  }
}
