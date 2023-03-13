// Decompiled with JetBrains decompiler
// Type: Class9
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

internal class Class9
{
  public static void smethod_0(GClass96 gclass96_0)
  {
    try
    {
      GClass151.smethod_7(Class13.smethod_0(140762) + gclass96_0.command.ToString());
      sbyte command = gclass96_0.command;
      if ((int) command <= Class15.smethod_0(108))
      {
        switch ((int) command - Class15.smethod_0(778))
        {
          case 0:
            Class9.smethod_3(gclass96_0);
            break;
          case 1:
            Class9.smethod_1(gclass96_0);
            break;
          case 2:
            sbyte num1 = gclass96_0.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(140736) + num1.ToString());
            if ((int) num1 == Class15.smethod_0(1))
            {
              int num2 = (int) gclass96_0.method_1().method_2();
              string num3 = gclass96_0.method_1().method_14();
              string finish = gclass96_0.method_1().method_14();
              GClass116.smethod_6().method_119(num3, finish);
            }
            if (num1 != (sbyte) 0)
              break;
            GClass116.smethod_6().method_124(gclass96_0.method_1().method_14());
            break;
          case 3:
            GClass23.smethod_0().isShow = Class15.smethod_0(0) != 0;
            string title = gclass96_0.method_1().method_14();
            GClass151.smethod_7(Class13.smethod_0(135650) + title);
            sbyte type1 = gclass96_0.method_1().method_2();
            GClass124.smethod_2().method_1((int) type1, title);
            for (int index = Class15.smethod_0(0); index < (int) type1; index += Class15.smethod_0(1))
            {
              GClass124.smethod_2().tf[index].name = gclass96_0.method_1().method_14();
              int num4 = (int) gclass96_0.method_1().method_2();
              if (num4 == 0)
                GClass124.smethod_2().tf[index].method_28(GClass184.int_8);
              if (num4 == Class15.smethod_0(1))
                GClass124.smethod_2().tf[index].method_28(GClass184.int_7);
              if (num4 == Class15.smethod_0(7))
                GClass124.smethod_2().tf[index].method_28(GClass184.int_9);
            }
            break;
          case 4:
            sbyte num5 = gclass96_0.method_1().method_2();
            int num6 = (int) gclass96_0.method_1().method_2();
            if (num6 == 0)
            {
              if ((int) num5 == Class15.smethod_0(7))
              {
                int charId = gclass96_0.method_1().method_8();
                if (charId == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_126();
                else if (GClass116.smethod_12(charId) != null)
                  GClass116.smethod_12(charId).method_126();
              }
              int num7 = (int) gclass96_0.method_1().method_5();
              int charId1 = gclass96_0.method_1().method_8();
              if (num7 == Class15.smethod_0(120))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  int charId2 = gclass96_0.method_1().method_8();
                  if (charId1 == GClass20.smethod_1().charID)
                  {
                    GClass20.smethod_1().holdEffID = num7;
                    GClass116.smethod_12(charId2).method_102(GClass20.smethod_1());
                  }
                  else if (GClass116.smethod_12(charId1) != null && charId2 != GClass20.smethod_1().charID)
                  {
                    GClass116.smethod_12(charId1).holdEffID = num7;
                    GClass116.smethod_12(charId2).method_102(GClass116.smethod_12(charId1));
                  }
                  else if (GClass116.smethod_12(charId1) != null && charId2 == GClass20.smethod_1().charID)
                  {
                    GClass116.smethod_12(charId1).holdEffID = num7;
                    GClass20.smethod_1().method_102(GClass116.smethod_12(charId1));
                  }
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_123();
                else if (GClass116.smethod_12(charId1) != null)
                  GClass116.smethod_12(charId1).method_123();
              }
              if (num7 == Class15.smethod_0(48))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  if (charId1 == GClass20.smethod_1().charID)
                    GClass20.smethod_1().protectEff = Class15.smethod_0(1) != 0;
                  else if (GClass116.smethod_12(charId1) != null)
                    GClass116.smethod_12(charId1).protectEff = Class15.smethod_0(1) != 0;
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_124();
                else if (GClass116.smethod_12(charId1) != null)
                  GClass116.smethod_12(charId1).method_124();
              }
              if (num7 == Class15.smethod_0(53))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  if (charId1 == GClass20.smethod_1().charID)
                    GClass20.smethod_1().huytSao = Class15.smethod_0(1) != 0;
                  else if (GClass116.smethod_12(charId1) != null)
                    GClass116.smethod_12(charId1).huytSao = Class15.smethod_0(1) != 0;
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_128();
                else if (GClass116.smethod_12(charId1) != null)
                  GClass116.smethod_12(charId1).method_128();
              }
              if (num7 == Class15.smethod_0(54))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  if (charId1 == GClass20.smethod_1().charID)
                    GClass20.smethod_1().blindEff = Class15.smethod_0(1) != 0;
                  else if (GClass116.smethod_12(charId1) != null)
                    GClass116.smethod_12(charId1).blindEff = Class15.smethod_0(1) != 0;
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_125();
                else if (GClass116.smethod_12(charId1) != null)
                  GClass116.smethod_12(charId1).method_125();
              }
              if (num7 == Class15.smethod_0(55))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  if (charId1 == GClass20.smethod_1().charID)
                    GClass20.smethod_1().sleepEff = Class15.smethod_0(1) != 0;
                  else if (GClass116.smethod_12(charId1) != null)
                    GClass116.smethod_12(charId1).sleepEff = Class15.smethod_0(1) != 0;
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().method_131();
                else if (GClass116.smethod_12(charId1) != null)
                  GClass116.smethod_12(charId1).method_131();
              }
              if (num7 == Class15.smethod_0(108))
              {
                if ((int) num5 == Class15.smethod_0(1))
                {
                  if (charId1 == GClass20.smethod_1().charID)
                    GClass20.smethod_1().stone = Class15.smethod_0(1) != 0;
                }
                else if (charId1 == GClass20.smethod_1().charID)
                  GClass20.smethod_1().stone = Class15.smethod_0(0) != 0;
              }
            }
            if (num6 != Class15.smethod_0(1))
              break;
            int num8 = (int) gclass96_0.method_1().method_5();
            sbyte mobIndex = gclass96_0.method_1().method_2();
            string[] strArray1 = new string[Class15.smethod_0(37)];
            strArray1[Class15.smethod_0(0)] = Class13.smethod_0(135533);
            strArray1[Class15.smethod_0(1)] = mobIndex.ToString();
            strArray1[Class15.smethod_0(7)] = Class13.smethod_0(135502);
            strArray1[Class15.smethod_0(5)] = num8.ToString();
            strArray1[Class15.smethod_0(2)] = Class13.smethod_0(135598);
            strArray1[Class15.smethod_0(3)] = num5.ToString();
            GClass151.smethod_7(string.Concat(strArray1));
            if (num8 == Class15.smethod_0(120))
            {
              if ((int) num5 == Class15.smethod_0(1))
              {
                int charId = gclass96_0.method_1().method_8();
                if (charId == GClass20.smethod_1().charID)
                {
                  GClass116.smethod_13(mobIndex).holdEffID = num8;
                  GClass20.smethod_1().method_103(GClass116.smethod_13(mobIndex));
                }
                else if (GClass116.smethod_12(charId) != null)
                {
                  GClass116.smethod_13(mobIndex).holdEffID = num8;
                  GClass116.smethod_12(charId).method_103(GClass116.smethod_13(mobIndex));
                }
              }
              else
                GClass116.smethod_13(mobIndex).method_26();
            }
            if (num8 == Class15.smethod_0(54))
            {
              if ((int) num5 == Class15.smethod_0(1))
                GClass116.smethod_13(mobIndex).blindEff = Class15.smethod_0(1) != 0;
              else
                GClass116.smethod_13(mobIndex).method_27();
            }
            if (num8 != Class15.smethod_0(55))
              break;
            if ((int) num5 == Class15.smethod_0(1))
            {
              GClass116.smethod_13(mobIndex).sleepEff = Class15.smethod_0(1) != 0;
              break;
            }
            GClass116.smethod_13(mobIndex).method_28();
            break;
          case 5:
            int charId3 = gclass96_0.method_1().method_8();
            if (GClass116.smethod_12(charId3) == null)
              break;
            GClass116.smethod_12(charId3).perCentMp = (int) gclass96_0.method_1().method_2();
            break;
          case 6:
            GClass21 gclass21 = GClass116.smethod_11(gclass96_0.method_1().method_6());
            sbyte length1 = gclass96_0.method_1().method_2();
            gclass21.duahau = new int[(int) length1];
            GClass151.smethod_7(Class13.smethod_0(140340) + length1.ToString());
            for (int index = Class15.smethod_0(0); index < (int) length1; index += Class15.smethod_0(1))
              gclass21.duahau[index] = (int) gclass96_0.method_1().method_6();
            gclass21.method_156(gclass96_0.method_1().method_2(), gclass96_0.method_1().method_8());
            break;
          case 7:
            GClass156.long_3 = GClass126.smethod_18() - GClass156.long_1;
            GClass156.smethod_0().method_38();
            break;
          case 8:
            GClass156.long_2 = GClass126.smethod_18() - GClass156.long_0;
            GClass156.smethod_0().method_37();
            break;
          case 9:
            GClass20.smethod_1().rank = gclass96_0.method_1().method_8();
            break;
          case 10:
            break;
          case 11:
            GClass116.smethod_6().tMabuEff = Class15.smethod_0(0);
            GClass116.smethod_6().percentMabu = gclass96_0.method_1().method_2();
            if ((int) GClass116.smethod_6().percentMabu == Class15.smethod_0(21))
              GClass116.smethod_6().mabuEff = Class15.smethod_0(1) != 0;
            if ((int) GClass116.smethod_6().percentMabu != Class15.smethod_0(444))
              break;
            GClass21.bool_20 = Class15.smethod_0(1) != 0;
            break;
          case 12:
            GClass116.bool_55 = (int) gclass96_0.method_1().method_2() == Class15.smethod_0(1);
            break;
          case 13:
            GClass20.smethod_1().method_6(gclass96_0.method_1().method_14(), gclass96_0.method_1().method_6(), gclass96_0.method_1().method_6(), gclass96_0.method_1().method_6());
            break;
          case 14:
            break;
          case 15:
            sbyte[] numArray = new sbyte[Class15.smethod_0(31)];
            for (int index = Class15.smethod_0(0); index < Class15.smethod_0(31); index += Class15.smethod_0(1))
            {
              numArray[index] = gclass96_0.method_1().method_2();
              GClass151.smethod_7(Class13.smethod_0(141858) + numArray[index].ToString());
            }
            GClass116.smethod_6().method_6(numArray);
            GClass116.smethod_6().method_5(numArray);
            GClass116.smethod_6().method_7(numArray);
            break;
          case 16:
            break;
          case 17:
            short num9 = gclass96_0.method_1().method_6();
            Class8.gclass134_0 = new GClass134();
            for (int index = Class15.smethod_0(0); index < (int) num9; index += Class15.smethod_0(1))
            {
              string string_0 = gclass96_0.method_1().method_14();
              sbyte sbyte_0 = gclass96_0.method_1().method_2();
              Class8.gclass134_0.method_0((object) new Class8(string_0, sbyte_0));
            }
            Class8.smethod_0();
            Class8.smethod_4();
            break;
          case 18:
            int num10 = (int) gclass96_0.method_1().method_2();
            if (num10 == Class15.smethod_0(1))
            {
              int id = gclass96_0.method_1().method_8();
              sbyte[] data = GClass152.smethod_1(id.ToString() + string.Empty);
              if (data == null)
                GClass156.smethod_0().method_138((sbyte) Class15.smethod_0(1), -1, (sbyte[]) null);
              else
                GClass156.smethod_0().method_138((sbyte) Class15.smethod_0(1), id, data);
            }
            if (num10 != 0)
              break;
            int num11 = gclass96_0.method_1().method_8();
            short length2 = gclass96_0.method_1().method_6();
            sbyte[] data1 = new sbyte[(int) length2];
            gclass96_0.method_1().method_21(ref data1, Class15.smethod_0(0), (int) length2);
            GClass152.smethod_0(num11.ToString() + string.Empty, data1);
            break;
          case 19:
            break;
          case 20:
            break;
          case 21:
            break;
          case 22:
            short num12 = gclass96_0.method_1().method_6();
            int num13 = (int) gclass96_0.method_1().method_6();
            if (GClass87.smethod_0((int) num12))
            {
              GClass87.smethod_3((int) num12).method_2(num13);
              break;
            }
            GClass87 o1 = new GClass87(num12, num13);
            GClass20.gclass134_0.method_0((object) o1);
            break;
          case 23:
            GClass123.smethod_2().time = (short) Class15.smethod_0(0);
            GClass123.smethod_2().maxTime = gclass96_0.method_1().method_6();
            GClass123.smethod_2().last = GClass123.smethod_2().curr = GClass126.smethod_18();
            GClass123.smethod_2().type = gclass96_0.method_1().method_2();
            GClass123.smethod_2().vmethod_0();
            break;
          case 24:
            break;
          case 25:
            sbyte num14 = gclass96_0.method_1().method_2();
            if (num14 == (sbyte) 0)
            {
              GClass62.gclass141_0.vFlag.method_9();
              sbyte num15 = gclass96_0.method_1().method_2();
              for (int index1 = Class15.smethod_0(0); index1 < (int) num15; index1 += Class15.smethod_0(1))
              {
                GClass80 o2 = new GClass80();
                short id = gclass96_0.method_1().method_6();
                if (id != (short) -1)
                {
                  o2.template = GClass86.smethod_1(id);
                  sbyte length3 = gclass96_0.method_1().method_2();
                  if (length3 != (sbyte) -1)
                  {
                    o2.itemOption = new GClass83[(int) length3];
                    for (int index2 = Class15.smethod_0(0); index2 < o2.itemOption.Length; index2 += Class15.smethod_0(1))
                    {
                      int optionTemplateId = (int) gclass96_0.method_1().method_5();
                      int num16 = (int) gclass96_0.method_1().method_7();
                      o2.itemOption[index2] = new GClass83(optionTemplateId, num16);
                    }
                  }
                }
                GClass62.gclass141_0.vFlag.method_0((object) o2);
              }
              GClass62.gclass141_0.method_16();
              GClass62.gclass141_0.method_44();
              break;
            }
            if ((int) num14 == Class15.smethod_0(1))
            {
              int num17 = gclass96_0.method_1().method_8();
              sbyte cflag = gclass96_0.method_1().method_2();
              GClass151.smethod_7(Class13.smethod_0(135617) + num17.ToString() + Class13.smethod_0(135281) + cflag.ToString());
              if (num17 == GClass20.smethod_1().charID)
                GClass20.smethod_1().cFlag = cflag;
              else if (GClass116.smethod_12(num17) != null)
                GClass116.smethod_12(num17).cFlag = cflag;
              GClass116.smethod_6().method_115(num17, cflag);
              break;
            }
            if ((int) num14 != Class15.smethod_0(7))
              break;
            sbyte num18 = gclass96_0.method_1().method_2();
            int num19 = (int) gclass96_0.method_1().method_6();
            GClass116.gclass134_11.method_0((object) new GClass144()
            {
              cflag = num18,
              IDimageFlag = num19
            });
            for (int index = Class15.smethod_0(0); index < GClass116.gclass134_11.method_2(); index += Class15.smethod_0(1))
            {
              GClass144 gclass144 = (GClass144) GClass116.gclass134_11.method_3(index);
              string[] strArray2 = new string[Class15.smethod_0(37)];
              strArray2[Class15.smethod_0(0)] = Class13.smethod_0(135277);
              strArray2[Class15.smethod_0(1)] = index.ToString();
              strArray2[Class15.smethod_0(7)] = Class13.smethod_0(135273);
              strArray2[Class15.smethod_0(5)] = gclass144.cflag.ToString();
              strArray2[Class15.smethod_0(2)] = Class13.smethod_0(135416);
              strArray2[Class15.smethod_0(3)] = gclass144.IDimageFlag.ToString();
              GClass151.smethod_7(string.Concat(strArray2));
            }
            for (int index = Class15.smethod_0(0); index < GClass116.gclass134_5.method_2(); index += Class15.smethod_0(1))
            {
              GClass20 gclass20 = (GClass20) GClass116.gclass134_5.method_3(index);
              if (gclass20 != null && (int) gclass20.cFlag == (int) num18)
                gclass20.flagImage = num19;
            }
            if ((int) GClass20.smethod_1().cFlag != (int) num18)
              break;
            GClass20.smethod_1().flagImage = num19;
            break;
          case 26:
            sbyte num20 = gclass96_0.method_1().method_2();
            if (num20 == (sbyte) 0 || (int) num20 != Class15.smethod_0(1))
              break;
            GClass62.gclass117_0.isLogin2 = Class15.smethod_0(0) != 0;
            GClass156.smethod_0().method_39(GClass152.smethod_2(Class13.smethod_0(135394)), GClass152.smethod_2(Class13.smethod_0(135390)), GClass63.string_2, (sbyte) Class15.smethod_0(0));
            GClass117.bool_9 = Class15.smethod_0(1) != 0;
            break;
          case 27:
            GClass62.gclass117_0.isLogin2 = Class15.smethod_0(1) != 0;
            GClass62.smethod_4();
            string str = gclass96_0.method_1().method_14();
            GClass152.smethod_4(Class13.smethod_0(135385) + GClass120.int_12.ToString(), str);
            GClass156.smethod_0().method_35();
            GClass156.smethod_0().method_39(str, string.Empty, GClass63.string_2, (sbyte) Class15.smethod_0(1));
            break;
          case 28:
            GClass71.smethod_5();
            bool flag = Class15.smethod_0(0) != 0;
            if (GClass62.int_10 > Class15.smethod_0(7) * GClass141.int_19)
              flag = Class15.smethod_0(1) != 0;
            sbyte index3 = gclass96_0.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(135378) + index3.ToString());
            GClass62.gclass141_0.maxPageShop[(int) index3] = (int) gclass96_0.method_1().method_2();
            GClass62.gclass141_0.currPageShop[(int) index3] = (int) gclass96_0.method_1().method_2();
            GClass151.smethod_7(Class13.smethod_0(135365) + GClass62.gclass141_0.maxPageShop[(int) index3].ToString() + Class13.smethod_0(136355) + GClass62.gclass141_0.currPageShop[(int) index3].ToString());
            int length4 = (int) gclass96_0.method_1().method_5();
            GClass20.smethod_1().arrItemShop[(int) index3] = new GClass80[length4];
            for (int index4 = Class15.smethod_0(0); index4 < length4; index4 += Class15.smethod_0(1))
            {
              short id = gclass96_0.method_1().method_6();
              if (id != (short) -1)
              {
                GClass151.smethod_7(Class13.smethod_0(136320) + id.ToString());
                GClass20.smethod_1().arrItemShop[(int) index3][index4] = new GClass80();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].template = GClass86.smethod_1(id);
                GClass20.smethod_1().arrItemShop[(int) index3][index4].itemId = (int) gclass96_0.method_1().method_6();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].buyCoin = gclass96_0.method_1().method_8();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].buyGold = gclass96_0.method_1().method_8();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].buyType = gclass96_0.method_1().method_2();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].quantity = gclass96_0.method_1().method_8();
                GClass20.smethod_1().arrItemShop[(int) index3][index4].isMe = gclass96_0.method_1().method_2();
                GClass141.string_12 = GClass109.string_339;
                sbyte length5 = gclass96_0.method_1().method_2();
                if (length5 != (sbyte) -1)
                {
                  GClass20.smethod_1().arrItemShop[(int) index3][index4].itemOption = new GClass83[(int) length5];
                  for (int index5 = Class15.smethod_0(0); index5 < GClass20.smethod_1().arrItemShop[(int) index3][index4].itemOption.Length; index5 += Class15.smethod_0(1))
                  {
                    int optionTemplateId = (int) gclass96_0.method_1().method_5();
                    int num21 = (int) gclass96_0.method_1().method_7();
                    GClass20.smethod_1().arrItemShop[(int) index3][index4].itemOption[index5] = new GClass83(optionTemplateId, num21);
                    GClass20.smethod_1().arrItemShop[(int) index3][index4].compare = GClass62.gclass141_0.method_124(GClass20.smethod_1().arrItemShop[(int) index3][index4]);
                  }
                }
                if ((int) gclass96_0.method_1().method_2() == Class15.smethod_0(1))
                {
                  int headTemp = (int) gclass96_0.method_1().method_6();
                  int bodyTemp = (int) gclass96_0.method_1().method_6();
                  int legTemp = (int) gclass96_0.method_1().method_6();
                  int bagTemp = (int) gclass96_0.method_1().method_6();
                  GClass20.smethod_1().arrItemShop[(int) index3][index4].method_19(headTemp, bodyTemp, legTemp, bagTemp);
                }
              }
            }
            if (flag)
              GClass62.gclass141_1.method_11();
            GClass62.gclass141_0.method_76();
            GClass62.gclass141_0.cmy = GClass62.gclass141_0.cmtoY = Class15.smethod_0(0);
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
            break;
          case 36:
            break;
          case 37:
            break;
          case 38:
            break;
          case 39:
            GClass62.bool_0 = (int) gclass96_0.method_1().method_2() == Class15.smethod_0(1);
            break;
          default:
            if ((int) command != Class15.smethod_0(8))
            {
              if ((int) command != Class15.smethod_0(108))
                break;
              GClass62.smethod_27();
              GClass117.bool_0 = Class15.smethod_0(0) != 0;
              GClass20.bool_4 = Class15.smethod_0(0) != 0;
              sbyte haveName = gclass96_0.method_1().method_2();
              if (GClass62.gclass125_0 == null)
                GClass62.gclass125_0 = new GClass125(haveName);
              GClass62.gclass125_0.method_0();
              break;
            }
            int charId4 = gclass96_0.method_1().method_8();
            if ((int) gclass96_0.method_1().method_2() == Class15.smethod_0(1))
            {
              short num22 = gclass96_0.method_1().method_6();
              sbyte fimg = -1;
              int[] frameNew = (int[]) null;
              short wimg = (short) Class15.smethod_0(0);
              short himg = (short) Class15.smethod_0(0);
              try
              {
                fimg = gclass96_0.method_1().method_2();
                if ((int) fimg > Class15.smethod_0(0))
                {
                  sbyte length6 = gclass96_0.method_1().method_2();
                  frameNew = new int[(int) length6];
                  for (int index6 = Class15.smethod_0(0); index6 < (int) length6; index6 += Class15.smethod_0(1))
                    frameNew[index6] = (int) gclass96_0.method_1().method_2();
                  wimg = gclass96_0.method_1().method_6();
                  himg = gclass96_0.method_1().method_6();
                }
              }
              catch (Exception ex)
              {
              }
              if (charId4 == GClass20.smethod_1().charID)
              {
                GClass20.smethod_1().petFollow = new GClass191();
                GClass20.smethod_1().petFollow.smallID = num22;
                if ((int) fimg <= Class15.smethod_0(0))
                  break;
                GClass20.smethod_1().petFollow.method_0((int) fimg, frameNew, (int) wimg, (int) himg);
                break;
              }
              GClass20 gclass20 = GClass116.smethod_12(charId4);
              gclass20.petFollow = new GClass191();
              gclass20.petFollow.smallID = num22;
              if ((int) fimg <= Class15.smethod_0(0))
                break;
              gclass20.petFollow.method_0((int) fimg, frameNew, (int) wimg, (int) himg);
              break;
            }
            if (charId4 == GClass20.smethod_1().charID)
            {
              GClass20.smethod_1().petFollow.method_3();
              GClass20.smethod_1().petFollow = (GClass191) null;
              break;
            }
            GClass20 gclass20_1 = GClass116.smethod_12(charId4);
            gclass20_1.petFollow.method_3();
            gclass20_1.petFollow = (GClass191) null;
            break;
        }
      }
      else if ((int) command <= Class15.smethod_0(64))
      {
        switch ((int) command - Class15.smethod_0(154))
        {
          case 0:
            GClass120.int_12 = (int) gclass96_0.method_1().method_2();
            GClass62.gclass62_0.method_9((GClass113) GClass62.gclass120_0);
            GClass157.smethod_0().imethod_4();
            GClass62.smethod_27();
            GClass120.bool_3 = Class15.smethod_0(1) != 0;
            break;
          case 1:
            break;
          case 2:
            break;
          case 3:
            Class2 class2 = (Class2) GClass116.smethod_12(gclass96_0.method_1().method_8());
            sbyte sbyte_22 = gclass96_0.method_1().method_2();
            short short_5 = gclass96_0.method_1().method_6();
            short short_6 = gclass96_0.method_1().method_6();
            sbyte length7 = gclass96_0.method_1().method_2();
            GClass20[] gclass20_5 = new GClass20[(int) length7];
            int[] int_37_1 = new int[(int) length7];
            for (int index7 = Class15.smethod_0(0); index7 < (int) length7; index7 += Class15.smethod_0(1))
            {
              int charId5 = gclass96_0.method_1().method_8();
              GClass151.smethod_7(Class13.smethod_0(140745) + charId5.ToString());
              gclass20_5[index7] = (GClass20) null;
              gclass20_5[index7] = charId5 == GClass20.smethod_1().charID ? GClass20.smethod_1() : GClass116.smethod_12(charId5);
              int_37_1[index7] = gclass96_0.method_1().method_8();
            }
            class2.method_159(sbyte_22, short_5, short_6, gclass20_5, int_37_1);
            break;
          case 4:
            int num23 = (int) gclass96_0.method_1().method_2();
            if (num23 == Class15.smethod_0(1))
            {
              int charId6 = gclass96_0.method_1().method_8();
              if (charId6 == GClass20.smethod_1().charID)
              {
                GClass20.smethod_1().method_76(Class15.smethod_0(1) != 0);
                GClass20.smethod_1().cx = (int) gclass96_0.method_1().method_6();
                GClass20.smethod_1().cy = (int) gclass96_0.method_1().method_6();
                if (num23 != 0)
                  goto label_222;
                else
                  goto label_218;
              }
              else
              {
                GClass20 gclass20_2 = GClass116.smethod_12(charId6);
                if (gclass20_2 != null)
                {
                  gclass20_2.method_76(Class15.smethod_0(1) != 0);
                  gclass20_2.cx = (int) gclass96_0.method_1().method_6();
                  gclass20_2.cy = (int) gclass96_0.method_1().method_6();
                  if (num23 != 0)
                    goto label_222;
                  else
                    goto label_218;
                }
              }
            }
            if (num23 != 0)
              goto label_222;
label_218:
            int charId7 = gclass96_0.method_1().method_8();
            if (charId7 == GClass20.smethod_1().charID)
              GClass20.smethod_1().method_76(Class15.smethod_0(0) != 0);
            else
              GClass116.smethod_12(charId7)?.method_76(Class15.smethod_0(0) != 0);
label_222:
            if (num23 == Class15.smethod_0(7))
            {
              int charId8 = gclass96_0.method_1().method_8();
              int int_37_2 = gclass96_0.method_1().method_8();
              ((Class2) GClass116.smethod_12(charId8)).method_156(int_37_2);
            }
            if (num23 != Class15.smethod_0(5))
              break;
            GClass116.sbyte_11 = gclass96_0.method_1().method_2();
            break;
          default:
            if ((int) command != Class15.smethod_0(64))
              break;
            string chatVip = GClass151.smethod_14(gclass96_0.method_1().method_14());
            GClass116.smethod_6().method_120(chatVip);
            break;
        }
      }
      else
      {
        switch ((int) command - Class15.smethod_0(21))
        {
          case 0:
            int num24 = (int) gclass96_0.method_1().method_2();
            sbyte index8 = gclass96_0.method_1().method_2();
            GClass80 gclass80 = (GClass80) null;
            if (num24 == 0)
              gclass80 = GClass20.smethod_1().arrItemBody[(int) index8];
            if (num24 == Class15.smethod_0(1))
              gclass80 = GClass20.smethod_1().arrItemBag[(int) index8];
            short id1 = gclass96_0.method_1().method_6();
            if (id1 == (short) -1)
              break;
            gclass80.template = GClass86.smethod_1(id1);
            gclass80.quantity = gclass96_0.method_1().method_8();
            gclass80.info = gclass96_0.method_1().method_14();
            gclass80.content = gclass96_0.method_1().method_14();
            sbyte length8 = gclass96_0.method_1().method_2();
            if (length8 == (sbyte) 0)
              break;
            gclass80.itemOption = new GClass83[(int) length8];
            for (int index9 = Class15.smethod_0(0); index9 < gclass80.itemOption.Length; index9 += Class15.smethod_0(1))
            {
              int optionTemplateId = (int) gclass96_0.method_1().method_5();
              GClass151.smethod_7(Class13.smethod_0(141879) + optionTemplateId.ToString());
              int num25 = (int) gclass96_0.method_1().method_7();
              if (optionTemplateId != -1)
                gclass80.itemOption[index9] = new GClass83(optionTemplateId, num25);
            }
            break;
          case 1:
            GClass151.smethod_7(Class13.smethod_0(142209));
            GClass104 gclass104 = GClass100.smethod_1();
            if (gclass104 == null)
              break;
            sbyte type2 = gclass96_0.method_1().method_2();
            if (type2 == (sbyte) 0 || (int) type2 == Class15.smethod_0(1) || (int) type2 == Class15.smethod_0(7) || (int) type2 == Class15.smethod_0(2) || (int) type2 == Class15.smethod_0(5))
            {
              if ((int) type2 == Class15.smethod_0(5))
              {
                gclass104.xTo = gclass104.xFirst = (int) gclass96_0.method_1().method_6();
                gclass104.yTo = gclass104.yFirst = (int) gclass96_0.method_1().method_6();
                gclass104.method_46();
              }
              else
              {
                sbyte length9 = gclass96_0.method_1().method_2();
                GClass151.smethod_7(Class13.smethod_0(142278) + length9.ToString());
                GClass20[] cAttack = new GClass20[(int) length9];
                int[] dame = new int[(int) length9];
                for (int index10 = Class15.smethod_0(0); index10 < (int) length9; index10 += Class15.smethod_0(1))
                {
                  int charId9 = gclass96_0.method_1().method_8();
                  GClass151.smethod_7(Class13.smethod_0(140745) + charId9.ToString());
                  cAttack[index10] = (GClass20) null;
                  cAttack[index10] = charId9 == GClass20.smethod_1().charID ? GClass20.smethod_1() : GClass116.smethod_12(charId9);
                  dame[index10] = gclass96_0.method_1().method_8();
                }
                gclass104.method_47(cAttack, dame, type2);
              }
            }
            if ((int) type2 == Class15.smethod_0(3))
            {
              gclass104.haftBody = Class15.smethod_0(1) != 0;
              gclass104.status = Class15.smethod_0(7);
            }
            if ((int) type2 == Class15.smethod_0(37))
            {
              gclass104.method_31();
              gclass104.x = (int) gclass96_0.method_1().method_6();
              gclass104.y = (int) gclass96_0.method_1().method_6();
            }
            if ((int) type2 == Class15.smethod_0(38))
              gclass104.method_47((GClass20[]) null, (int[]) null, type2);
            if ((int) type2 == Class15.smethod_0(88))
            {
              gclass104.xTo = gclass104.xFirst = (int) gclass96_0.method_1().method_6();
              gclass104.yTo = gclass104.yFirst = (int) gclass96_0.method_1().method_6();
              gclass104.status = Class15.smethod_0(7);
            }
            if ((int) type2 != Class15.smethod_0(45))
              break;
            gclass104.x = gclass104.y = gclass104.xTo = gclass104.yTo = gclass104.xFirst = gclass104.yFirst = Class15.smethod_0(223);
            break;
          case 2:
            sbyte num26 = gclass96_0.method_1().method_2();
            if (num26 == (sbyte) 0 || (int) num26 == Class15.smethod_0(1) || (int) num26 == Class15.smethod_0(7) || (int) num26 == Class15.smethod_0(37))
            {
              GClass102 gclass102 = GClass100.smethod_2();
              if (gclass102 == null)
                break;
              if ((int) num26 == Class15.smethod_0(37))
              {
                gclass102.x = gclass102.y = gclass102.xTo = gclass102.yTo = gclass102.xFirst = gclass102.yFirst = Class15.smethod_0(223);
                break;
              }
              sbyte length10 = gclass96_0.method_1().method_2();
              GClass20[] cAttack = new GClass20[(int) length10];
              int[] dame = new int[(int) length10];
              for (int index11 = Class15.smethod_0(0); index11 < (int) length10; index11 += Class15.smethod_0(1))
              {
                int charId10 = gclass96_0.method_1().method_8();
                cAttack[index11] = (GClass20) null;
                cAttack[index11] = charId10 == GClass20.smethod_1().charID ? GClass20.smethod_1() : GClass116.smethod_12(charId10);
                dame[index11] = gclass96_0.method_1().method_8();
              }
              gclass102.method_46(cAttack, dame, num26);
            }
            if ((int) num26 == Class15.smethod_0(5) || (int) num26 == Class15.smethod_0(2) || (int) num26 == Class15.smethod_0(3) || (int) num26 == Class15.smethod_0(38))
            {
              GClass101 gclass101 = GClass100.smethod_3();
              if (gclass101 == null)
                break;
              if ((int) num26 == Class15.smethod_0(38))
              {
                gclass101.x = gclass101.y = gclass101.xTo = gclass101.yTo = gclass101.xFirst = gclass101.yFirst = Class15.smethod_0(223);
                break;
              }
              if ((int) num26 == Class15.smethod_0(5) || (int) num26 == Class15.smethod_0(2))
              {
                sbyte length11 = gclass96_0.method_1().method_2();
                GClass20[] cAttack = new GClass20[(int) length11];
                int[] dame = new int[(int) length11];
                for (int index12 = Class15.smethod_0(0); index12 < (int) length11; index12 += Class15.smethod_0(1))
                {
                  int charId11 = gclass96_0.method_1().method_8();
                  cAttack[index12] = (GClass20) null;
                  cAttack[index12] = charId11 == GClass20.smethod_1().charID ? GClass20.smethod_1() : GClass116.smethod_12(charId11);
                  dame[index12] = gclass96_0.method_1().method_8();
                }
                gclass101.method_45(cAttack, dame, num26);
              }
              if ((int) num26 == Class15.smethod_0(3))
              {
                short xMoveTo = gclass96_0.method_1().method_6();
                gclass101.method_57(xMoveTo);
              }
            }
            if ((int) num26 <= Class15.smethod_0(45) || (int) num26 >= Class15.smethod_0(6))
              break;
            Class9.smethod_4(gclass96_0, (int) num26);
            break;
          default:
            switch ((int) command - Class15.smethod_0(76))
            {
              case 0:
                int loop = Class15.smethod_0(0);
                int layer = Class15.smethod_0(0);
                int id2 = Class15.smethod_0(0);
                short x = (short) Class15.smethod_0(0);
                short y = (short) Class15.smethod_0(0);
                short loopCount = -1;
                try
                {
                  loop = (int) gclass96_0.method_1().method_2();
                  layer = (int) gclass96_0.method_1().method_2();
                  id2 = (int) gclass96_0.method_1().method_5();
                  x = gclass96_0.method_1().method_6();
                  y = gclass96_0.method_1().method_6();
                  loopCount = gclass96_0.method_1().method_6();
                }
                catch (Exception ex)
                {
                }
                GClass40.smethod_0(new GClass41(id2, (int) x, (int) y, layer, loop, (int) loopCount));
                return;
              case 1:
                try
                {
                  gclass96_0.method_1().method_14();
                  GClass126.sbyte_1 = gclass96_0.method_1().method_2();
                  GClass126.sbyte_2 = gclass96_0.method_1().method_2();
                  return;
                }
                catch (Exception ex)
                {
                  return;
                }
              case 2:
                return;
              case 3:
                return;
              case 4:
                return;
              case 5:
                return;
              case 6:
                return;
              case 7:
                return;
              case 8:
                GClass126.string_1 = gclass96_0.method_1().method_14();
                GClass126.string_0 = gclass96_0.method_1().method_14();
                GClass151.smethod_7(Class13.smethod_0(135425) + GClass126.string_1);
                GClass126.smethod_13();
                return;
              case 9:
                short num27 = gclass96_0.method_1().method_6();
                GClass151.smethod_7(Class13.smethod_0(135441) + num27.ToString());
                GClass117.short_0 = num27;
                GClass117.long_1 = GClass117.long_0 = GClass126.smethod_18();
                GClass62.smethod_27();
                return;
              case 10:
                GClass151.smethod_7(Class13.smethod_0(143058));
                int charId12 = gclass96_0.method_1().method_8();
                short xPos = gclass96_0.method_1().method_6();
                short yPos = gclass96_0.method_1().method_6();
                sbyte typePos = gclass96_0.method_1().method_2();
                GClass20 c = (GClass20) null;
                if (charId12 == GClass20.smethod_1().charID)
                  c = GClass20.smethod_1();
                else if (GClass116.smethod_12(charId12) != null)
                  c = GClass116.smethod_12(charId12);
                if (c == null)
                  return;
                GClass47.smethod_3(typePos != (sbyte) 0 ? Class15.smethod_0(185) : Class15.smethod_0(4), c, Class15.smethod_0(1));
                c.method_127(xPos, yPos, typePos);
                return;
              case 11:
                short id3 = gclass96_0.method_1().method_6();
                string info = gclass96_0.method_1().method_14();
                GClass151.smethod_7(Class13.smethod_0(143156) + info + Class13.smethod_0(143130) + id3.ToString());
                GClass116.smethod_11(id3)?.method_7(info);
                return;
              case 12:
                sbyte fusion = gclass96_0.method_1().method_2();
                int charId13 = gclass96_0.method_1().method_8();
                if (charId13 == GClass20.smethod_1().charID)
                {
                  GClass20.smethod_1().method_130(fusion);
                  return;
                }
                if (GClass116.smethod_12(charId13) == null)
                  return;
                GClass116.smethod_12(charId13).method_130(fusion);
                return;
              case 13:
                return;
              case 14:
                Class9.smethod_2(gclass96_0);
                return;
              default:
                return;
            }
        }
      }
    }
    catch (Exception ex)
    {
      GClass151.smethod_7(Class13.smethod_0(137020) + ex.StackTrace);
    }
  }

  private static void smethod_1(GClass96 gclass96_0)
  {
    try
    {
      sbyte num = gclass96_0.method_1().method_2();
      if ((num == (sbyte) 0 ? 0 : 1) == 0)
      {
        sbyte length = gclass96_0.method_1().method_2();
        short[] idImage = new short[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
          idImage[index] = gclass96_0.method_1().method_6();
        sbyte typePrice = gclass96_0.method_1().method_2();
        int price = gclass96_0.method_1().method_8();
        short idTicket = gclass96_0.method_1().method_6();
        GClass114.smethod_2().method_0(idImage, (byte) typePrice, price, idTicket);
      }
      else
      {
        if ((int) num != Class15.smethod_0(1))
          return;
        sbyte length = gclass96_0.method_1().method_2();
        short[] idImage = new short[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
          idImage[index] = gclass96_0.method_1().method_6();
        GClass114.smethod_2().method_7(idImage);
      }
    }
    catch (Exception ex)
    {
    }
  }

  private static void smethod_2(GClass96 gclass96_0)
  {
    try
    {
      sbyte num1 = gclass96_0.method_1().method_2();
      if ((num1 == (sbyte) 0 ? 0 : 1) == 0)
      {
        GClass119.smethod_2();
        GClass134 list = new GClass134(string.Empty);
        short numMax = gclass96_0.method_1().method_6();
        int num2 = Class15.smethod_0(0);
        for (int index1 = Class15.smethod_0(0); index1 < (int) numMax; index1 += Class15.smethod_0(1))
        {
          GClass75 o = new GClass75();
          int id = (int) gclass96_0.method_1().method_6();
          int no = index1 + Class15.smethod_0(1);
          int idIcon = (int) gclass96_0.method_1().method_6();
          sbyte rank = gclass96_0.method_1().method_2();
          sbyte amount = gclass96_0.method_1().method_2();
          sbyte max_amount = gclass96_0.method_1().method_2();
          short templateId = -1;
          GClass20 charInfo = (GClass20) null;
          sbyte typeMonster = gclass96_0.method_1().method_2();
          if ((typeMonster == (sbyte) 0 ? 0 : 1) == 0)
          {
            templateId = gclass96_0.method_1().method_6();
          }
          else
          {
            int head = (int) gclass96_0.method_1().method_6();
            int num3 = (int) gclass96_0.method_1().method_6();
            int num4 = (int) gclass96_0.method_1().method_6();
            int num5 = (int) gclass96_0.method_1().method_6();
            int body = num3;
            int leg = num4;
            int bag = num5;
            charInfo = GClass75.smethod_0(head, body, leg, bag);
          }
          string name = gclass96_0.method_1().method_14();
          string info = gclass96_0.method_1().method_14();
          sbyte level = gclass96_0.method_1().method_2();
          sbyte isUse = gclass96_0.method_1().method_2();
          sbyte length = gclass96_0.method_1().method_2();
          GClass83[] itemOption = (GClass83[]) null;
          if ((length == (sbyte) 0 ? 1 : 0) == 0)
          {
            itemOption = new GClass83[(int) length];
            for (int index2 = Class15.smethod_0(0); index2 < itemOption.Length; index2 += Class15.smethod_0(1))
            {
              int optionTemplateId = (int) gclass96_0.method_1().method_5();
              int num6 = (int) gclass96_0.method_1().method_7();
              sbyte num7 = gclass96_0.method_1().method_2();
              itemOption[index2] = new GClass83(optionTemplateId, num6);
              itemOption[index2].activeCard = num7;
            }
          }
          o.method_0(id, no, idIcon, rank, typeMonster, templateId, name, info, charInfo, itemOption);
          o.method_2(level);
          o.method_3(isUse);
          o.method_1(amount, max_amount);
          list.method_0((object) o);
          if ((int) level > Class15.smethod_0(0))
            num2 += Class15.smethod_0(1);
        }
        GClass119.smethod_2().method_0(list, num2, (int) numMax);
        GClass119.smethod_2().vmethod_0();
      }
      else if ((int) num1 == Class15.smethod_0(1))
      {
        int id = (int) gclass96_0.method_1().method_6();
        sbyte isUse = gclass96_0.method_1().method_2();
        if ((GClass75.smethod_1(GClass119.gclass134_0, id) == null ? 1 : 0) == 0)
          GClass75.smethod_1(GClass119.gclass134_0, id).method_3(isUse);
        GClass119.smethod_4();
      }
      else if ((int) num1 == Class15.smethod_0(7))
      {
        int id = (int) gclass96_0.method_1().method_6();
        sbyte level = gclass96_0.method_1().method_2();
        int num8 = Class15.smethod_0(0);
        for (int index = Class15.smethod_0(0); index < GClass119.gclass134_0.method_2(); index += Class15.smethod_0(1))
        {
          GClass75 gclass75 = (GClass75) GClass119.gclass134_0.method_3(index);
          if ((gclass75 == null ? 1 : 0) == 0)
          {
            if (gclass75.id == id)
              gclass75.method_2(level);
            if ((int) gclass75.level > Class15.smethod_0(0))
              num8 += Class15.smethod_0(1);
          }
        }
        GClass119.smethod_3(num8, GClass119.gclass134_0.method_2());
        if ((GClass75.smethod_1(GClass119.gclass134_1, id) == null ? 1 : 0) != 0)
          return;
        GClass75.smethod_1(GClass119.gclass134_1, id).method_2(level);
      }
      else if ((int) num1 == Class15.smethod_0(5))
      {
        int id = (int) gclass96_0.method_1().method_6();
        sbyte amount = gclass96_0.method_1().method_2();
        sbyte max_amount = gclass96_0.method_1().method_2();
        if ((GClass75.smethod_1(GClass119.gclass134_0, id) == null ? 1 : 0) == 0)
          GClass75.smethod_1(GClass119.gclass134_0, id).method_1(amount, max_amount);
        if ((GClass75.smethod_1(GClass119.gclass134_1, id) == null ? 1 : 0) != 0)
          return;
        GClass75.smethod_1(GClass119.gclass134_1, id).method_1(amount, max_amount);
      }
      else
      {
        if ((int) num1 != Class15.smethod_0(2))
          return;
        int charId = gclass96_0.method_1().method_8();
        short num9 = gclass96_0.method_1().method_6();
        GClass20 gclass20 = charId != GClass20.smethod_1().charID ? GClass116.smethod_12(charId) : GClass20.smethod_1();
        if ((gclass20 == null ? 1 : 0) != 0)
          return;
        gclass20.idAuraEff = num9;
        gclass20.idEff_Set_Item = (short) gclass96_0.method_1().method_2();
      }
    }
    catch (Exception ex)
    {
    }
  }

  private static void smethod_3(GClass96 gclass96_0)
  {
    try
    {
      sbyte num = gclass96_0.method_1().method_2();
      int charId = gclass96_0.method_1().method_8();
      GClass20 c = charId != GClass20.smethod_1().charID ? GClass116.smethod_12(charId) : GClass20.smethod_1();
      if ((num == (sbyte) 0 ? 0 : 1) == 0)
      {
        int id = (int) gclass96_0.method_1().method_6();
        int layer = (int) gclass96_0.method_1().method_2();
        int loop = (int) gclass96_0.method_1().method_2();
        short loopCount = gclass96_0.method_1().method_6();
        sbyte isStand = gclass96_0.method_1().method_2();
        if ((c == null ? 1 : 0) != 0)
          return;
        c.method_136(new GClass41(id, c, layer, loop, (int) loopCount, isStand));
      }
      else if ((int) num == Class15.smethod_0(1))
      {
        int id = (int) gclass96_0.method_1().method_6();
        if ((c == null ? 1 : 0) != 0)
          return;
        c.method_137(Class15.smethod_0(0), id);
      }
      else
      {
        if ((int) num != Class15.smethod_0(7) || (c == null ? 1 : 0) != 0)
          return;
        c.method_137(-1, Class15.smethod_0(0));
      }
    }
    catch (Exception ex)
    {
    }
  }

  private static void smethod_4(GClass96 gclass96_0, int int_0)
  {
    try
    {
      GClass103 gclass103 = GClass100.smethod_4(gclass96_0.method_1().method_2());
      if ((gclass103 == null ? 0 : 1) == 0)
        return;
      if (int_0 == Class15.smethod_0(31))
      {
        short xMoveTo = gclass96_0.method_1().method_6();
        short yMoveTo = gclass96_0.method_1().method_6();
        gclass103.method_54(xMoveTo, yMoveTo);
      }
      if (int_0 >= Class15.smethod_0(67) && int_0 <= Class15.smethod_0(51))
      {
        sbyte length = gclass96_0.method_1().method_2();
        GClass20[] cAttack = new GClass20[(int) length];
        int[] dame = new int[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
        {
          int charId = gclass96_0.method_1().method_8();
          cAttack[index] = (GClass20) null;
          cAttack[index] = charId == GClass20.smethod_1().charID ? GClass20.smethod_1() : GClass116.smethod_12(charId);
          dame[index] = gclass96_0.method_1().method_8();
        }
        sbyte dir = gclass96_0.method_1().method_2();
        gclass103.method_43(cAttack, dame, (sbyte) (int_0 - Class15.smethod_0(31)), dir);
      }
      if (int_0 == Class15.smethod_0(27))
      {
        gclass103.xTo = (int) gclass96_0.method_1().method_6();
        gclass103.yTo = (int) gclass96_0.method_1().method_6();
        gclass103.method_42();
      }
      Class15.smethod_0(28);
      if (int_0 != Class15.smethod_0(29))
        return;
      gclass103.method_56();
    }
    catch (Exception ex)
    {
    }
  }
}
