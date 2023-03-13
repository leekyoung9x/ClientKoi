// Decompiled with JetBrains decompiler
// Type: Class19
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;

internal sealed class Class19
{
  internal static Struct40[] struct40_0 = new Struct40[288];
  internal static Struct40[] struct40_1 = new Struct40[32];
  internal static Class23 class23_0;
  internal static readonly int[] int_0 = new int[19];
  internal static readonly int[] int_1;
  internal static readonly int[] int_2;
  internal static readonly int[] int_3;
  internal static readonly int[] int_4;

  static Class19()
  {
    Class19.int_0[0] = 16;
    Class19.int_0[1] = 17;
    Class19.int_0[2] = 18;
    Class19.int_0[4] = 8;
    Class19.int_0[5] = 7;
    Class19.int_0[6] = 9;
    Class19.int_0[7] = 6;
    Class19.int_0[8] = 10;
    Class19.int_0[9] = 5;
    Class19.int_0[10] = 11;
    Class19.int_0[11] = 4;
    Class19.int_0[12] = 12;
    Class19.int_0[13] = 3;
    Class19.int_0[14] = 13;
    Class19.int_0[15] = 2;
    Class19.int_0[16] = 14;
    Class19.int_0[17] = 1;
    Class19.int_0[18] = 15;
    Class19.int_1 = new int[29];
    Class19.int_1[0] = 3;
    Class19.int_1[1] = 4;
    Class19.int_1[2] = 5;
    Class19.int_1[3] = 6;
    Class19.int_1[4] = 7;
    Class19.int_1[5] = 8;
    Class19.int_1[6] = 9;
    Class19.int_1[7] = 10;
    Class19.int_1[8] = 11;
    Class19.int_1[9] = 13;
    Class19.int_1[10] = 15;
    Class19.int_1[11] = 17;
    Class19.int_1[12] = 19;
    Class19.int_1[13] = 23;
    Class19.int_1[14] = 27;
    Class19.int_1[15] = 31;
    Class19.int_1[16] = 35;
    Class19.int_1[17] = 43;
    Class19.int_1[18] = 51;
    Class19.int_1[19] = 59;
    Class19.int_1[20] = 67;
    Class19.int_1[21] = 83;
    Class19.int_1[22] = 99;
    Class19.int_1[23] = 115;
    Class19.int_1[24] = 131;
    Class19.int_1[25] = 163;
    Class19.int_1[26] = 195;
    Class19.int_1[27] = 227;
    Class19.int_1[28] = 258;
    Class19.int_2 = new int[29];
    int index1 = 8;
    int num1 = 0;
    for (; index1 < 28; ++index1)
    {
      if (index1 % 4 == 0)
        ++num1;
      Class19.int_2[index1] = num1;
    }
    Class19.int_3 = new int[30];
    Class19.int_3[0] = 1;
    Class19.int_3[1] = 2;
    Class19.int_3[2] = 3;
    Class19.int_3[3] = 4;
    Class19.int_3[4] = 5;
    Class19.int_3[5] = 7;
    Class19.int_3[6] = 9;
    Class19.int_3[7] = 13;
    Class19.int_3[8] = 17;
    Class19.int_3[9] = 25;
    Class19.int_3[10] = 33;
    Class19.int_3[11] = 49;
    Class19.int_3[12] = 65;
    Class19.int_3[13] = 97;
    Class19.int_3[14] = 129;
    Class19.int_3[15] = 193;
    Class19.int_3[16] = 257;
    Class19.int_3[17] = 385;
    Class19.int_3[18] = 513;
    Class19.int_3[19] = 769;
    Class19.int_3[20] = 1025;
    Class19.int_3[21] = 1537;
    Class19.int_3[22] = 2049;
    Class19.int_3[23] = 3073;
    Class19.int_3[24] = 4097;
    Class19.int_3[25] = 6145;
    Class19.int_3[26] = 8193;
    Class19.int_3[27] = 12289;
    Class19.int_3[28] = 16385;
    Class19.int_3[29] = 24577;
    Class19.int_4 = new int[30];
    int index2 = 4;
    int num2 = 0;
    for (; index2 < 30; ++index2)
    {
      if (index2 % 2 == 0)
        ++num2;
      Class19.int_4[index2] = num2;
    }
    for (int index3 = 0; index3 <= 143; ++index3)
    {
      Class19.struct40_0[index3].int_0 = 48 + index3;
      Class19.struct40_0[index3].int_1 = 8;
    }
    for (int index4 = 144; index4 <= (int) byte.MaxValue; ++index4)
    {
      Class19.struct40_0[index4].int_0 = 400 + index4 - 144;
      Class19.struct40_0[index4].int_1 = 9;
    }
    for (int index5 = 256; index5 <= 279; ++index5)
    {
      Class19.struct40_0[index5].int_0 = index5 - 256;
      Class19.struct40_0[index5].int_1 = 7;
    }
    for (int index6 = 280; index6 <= 287; ++index6)
    {
      Class19.struct40_0[index6].int_0 = 192 + index6 - 280;
      Class19.struct40_0[index6].int_1 = 8;
    }
    for (int index7 = 0; index7 <= 31; ++index7)
    {
      Class19.struct40_1[index7].int_0 = index7;
      Class19.struct40_1[index7].int_1 = 5;
    }
    Class19.class23_0 = Class19.smethod_4(Class19.struct40_0, Class19.struct40_1);
  }

  internal static int smethod_0(int[] int_5, int[] int_6)
  {
    int num1 = 0;
label_1:
    int index;
    int num2;
    switch (Class24.smethod_1(14))
    {
      case 0:
        index = 0;
        num2 = 1;
        goto case 1;
      case 1:
        if (index != 0)
        {
          num2 = 2;
          goto case 2;
        }
        else
          break;
      case 2:
label_7:
        num1 += int_5[index] * int_6[index];
        num2 = 3;
        goto case 3;
      case 3:
        ++index;
        break;
      default:
        goto label_1;
    }
    if (index >= int_5.Length)
      return num1;
    goto label_7;
  }

  internal static int smethod_1(int[] int_5, int[] int_6)
  {
    int num1 = 0;
label_1:
    int index1;
    int num2;
    switch (Class24.smethod_1(22))
    {
      case 0:
        if (index1 != 0)
        {
          num2 = 1;
          goto case 1;
        }
        else
          break;
      case 1:
label_7:
        num1 += int_5[index1] * Class19.struct40_0[index1].int_1;
        num2 = 3;
        goto case 3;
      case 2:
        index1 = 0;
        num2 = 0;
        goto case 0;
      case 3:
        ++index1;
        break;
      default:
        goto label_1;
    }
    if (index1 >= int_5.Length)
    {
label_12:
      int num3 = Class24.smethod_1(14);
      int index2;
      int num4;
      while (true)
      {
        switch (num3)
        {
          case 0:
            index2 = 0;
            num4 = 2;
            goto case 2;
          case 1:
            goto label_14;
          case 2:
            if (index2 != 0)
            {
              num3 = Class24.smethod_1(15);
              continue;
            }
            goto label_13;
          case 3:
            goto label_15;
          default:
            goto label_12;
        }
      }
label_13:
      if (index2 >= int_6.Length)
        return num1;
label_14:
      num1 += int_6[index2] * Class19.struct40_1[index2].int_1;
      num4 = 3;
label_15:
      ++index2;
      goto label_13;
    }
    else
      goto label_7;
  }

  internal static Struct40[] smethod_2(int[] int_5)
  {
    Struct40[] struct40_2 = new Struct40[int_5.Length];
label_8:
    int num1 = Class24.smethod_1(22);
    while (true)
    {
      int index;
      int num2;
      switch (num1)
      {
        case 0:
          if (index != 0)
          {
            num2 = 1;
            goto case 1;
          }
          else
            break;
        case 1:
label_3:
          struct40_2[index].int_1 = int_5[index];
          num1 = Class24.smethod_1(11);
          continue;
        case 2:
          index = 0;
          num2 = 0;
          goto case 0;
        case 3:
          ++index;
          break;
        default:
          goto label_8;
      }
      if (index >= int_5.Length)
        break;
      goto label_3;
    }
    Class19.smethod_3(struct40_2);
    return struct40_2;
  }

  internal static void smethod_3(Struct40[] struct40_2)
  {
    int int1_1 = struct40_2[0].int_1;
label_10:
    int num1 = Class24.smethod_1(22);
    while (true)
    {
      int index;
      int num2;
      switch (num1)
      {
        case 0:
label_4:
          if (int1_1 < struct40_2[index].int_1)
          {
            num1 = Class24.smethod_1(11);
            continue;
          }
          break;
        case 1:
          if (index == 0)
          {
            num2 = 0;
            goto case 0;
          }
          else
            goto label_3;
        case 2:
          index = 1;
          num2 = 1;
          goto case 1;
        case 3:
          int1_1 = struct40_2[index].int_1;
          break;
        default:
          goto label_10;
      }
      ++index;
label_3:
      if (index >= struct40_2.Length)
        break;
      goto label_4;
    }
    int[] numArray1 = new int[int1_1 + 1];
label_19:
    int num3 = Class24.smethod_1(15);
    while (true)
    {
      int index;
      int num4;
      switch (num3)
      {
        case 0:
label_14:
          ++numArray1[struct40_2[index].int_1];
          num3 = Class24.smethod_1(11);
          continue;
        case 1:
          index = 0;
          num4 = 2;
          goto case 2;
        case 2:
          if (index != 0)
          {
            num4 = 0;
            goto case 0;
          }
          else
            break;
        case 3:
          ++index;
          break;
        default:
          goto label_19;
      }
      if (index >= struct40_2.Length)
        break;
      goto label_14;
    }
    int[] numArray2 = new int[int1_1 + 1];
label_25:
    int num5 = Class24.smethod_1(14);
    int index1;
    int num6;
    int num7;
    while (true)
    {
      switch (num5)
      {
        case 0:
          num7 = 0;
          num6 = 2;
          goto case 2;
        case 1:
          goto label_31;
        case 2:
          numArray1[0] = 0;
          num6 = 5;
          goto case 5;
        case 3:
          goto label_26;
        case 4:
          goto label_32;
        case 5:
          index1 = 1;
          num5 = Class24.smethod_1(11);
          continue;
        case 6:
          goto label_28;
        default:
          goto label_25;
      }
    }
label_26:
    if (index1 == 0)
    {
      num6 = 4;
      goto label_32;
    }
    else
      goto label_29;
label_28:
    ++index1;
label_29:
    if (index1 > int1_1)
    {
      for (int index2 = 0; index2 < struct40_2.Length; ++index2)
      {
        int int1_2 = struct40_2[index2].int_1;
        if ((int1_2 == 0 ? 1 : 0) == 0)
        {
          struct40_2[index2].int_0 = numArray2[int1_2];
          ++numArray2[int1_2];
        }
      }
      return;
    }
    goto label_32;
label_31:
    numArray2[index1] = num7;
    num6 = 6;
    goto label_28;
label_32:
    num7 = num7 + numArray1[index1 - 1] << 1;
    num6 = 1;
    goto label_31;
  }

  internal static Class23 smethod_4(Struct40[] struct40_2, Struct40[] struct40_3) => new Class23()
  {
    class22_0 = Class19.smethod_5(struct40_2),
    class22_1 = Class19.smethod_5(struct40_3)
  };

  internal static Class22 smethod_5(Struct40[] struct40_2)
  {
    Class19.Struct39[] struct39_0 = new Class19.Struct39[struct40_2.Length];
label_4:
    int num1 = Class24.smethod_1(11);
    int int_5;
    int num2;
    int index;
    while (true)
    {
      switch (num1)
      {
        case 0:
          index = 0;
          num1 = Class24.smethod_1(25);
          continue;
        case 1:
          goto label_12;
        case 2:
          goto label_15;
        case 3:
          int_5 = 0;
          num2 = 0;
          goto case 0;
        case 4:
          goto label_5;
        case 5:
          goto label_7;
        default:
          goto label_4;
      }
    }
label_5:
    if (index != 0)
    {
      num2 = 2;
      goto label_15;
    }
    else
      goto label_10;
label_7:
    Class19.Struct39 struct39;
    int num3;
    switch (Class24.smethod_1(15))
    {
      case 0:
        struct39.ushort_0 = (ushort) index;
        num3 = 2;
        goto case 2;
      case 1:
        struct39.struct40_0 = struct40_2[index];
        num3 = 0;
        goto case 0;
      case 2:
        struct39_0[int_5++] = struct39;
        break;
      default:
        goto label_7;
    }
label_9:
    ++index;
label_10:
    if (index >= struct40_2.Length)
      return Class19.smethod_6(struct39_0, int_5, 0, 0);
    goto label_15;
label_12:
    struct39 = new Class19.Struct39();
    num2 = 5;
    goto label_7;
label_15:
    if (struct40_2[index].int_1 > 0)
    {
      num2 = 1;
      goto label_12;
    }
    else
      goto label_9;
  }

  private static Class22 smethod_6(Class19.Struct39[] struct39_0, int int_5, int int_6, int int_7)
  {
    Class19.Struct39[] struct39_0_1 = new Class19.Struct39[int_5];
label_6:
    int num1 = Class24.smethod_1(33);
    int int_5_1;
    int int_5_2;
    Class19.Struct39[] struct39_0_2;
    int num2;
    Class22 class22;
    while (true)
    {
      switch (num1)
      {
        case 0:
          goto label_12;
        case 1:
          class22 = new Class22();
          num2 = 5;
          goto case 5;
        case 2:
          goto label_17;
        case 3:
          goto label_14;
        case 4:
          goto label_7;
        case 5:
          class22.bool_0 = false;
          num2 = 10;
          goto case 10;
        case 6:
          goto label_16;
        case 7:
          goto label_8;
        case 8:
          struct39_0_2 = new Class19.Struct39[int_5];
          num2 = 1;
          goto case 1;
        case 9:
          goto label_21;
        case 10:
          int_5_1 = 0;
          int_5_2 = 0;
          num1 = Class24.smethod_1(25);
          continue;
        case 11:
          goto label_10;
        default:
          goto label_6;
      }
    }
label_7:
    int index = 0;
    num2 = 7;
label_8:
    if (index != 0)
    {
      num2 = 9;
      goto label_21;
    }
    else
      goto label_11;
label_10:
    ++index;
label_11:
    if (index >= int_5)
    {
      if ((!class22.bool_0 ? 0 : 1) == 0)
      {
        if (int_5_1 > 0)
          class22.class22_0 = Class19.smethod_6(struct39_0_1, int_5_1, int_6 << 1, int_7 + 1);
        if (int_5_2 > 0)
          class22.class22_1 = Class19.smethod_6(struct39_0_2, int_5_2, int_6 << 1 | 1, int_7 + 1);
      }
      return class22;
    }
    goto label_21;
label_12:
    Class19.Struct39 struct39;
    if (struct39.struct40_0.int_1 == int_7)
      num2 = 3;
    else
      goto label_18;
label_14:
    if (struct39.struct40_0.int_0 == int_6)
      num2 = 6;
    else
      goto label_18;
label_16:
    class22.bool_0 = true;
    num2 = 2;
label_17:
    class22.ushort_0 = struct39.ushort_0;
    num2 = 11;
    goto label_10;
label_18:
    if (((struct39.struct40_0.int_0 >> struct39.struct40_0.int_1 - int_7 - 1 & 1) == 0 ? 1 : 0) == 0)
    {
      struct39_0_2[int_5_2++] = struct39;
      goto label_10;
    }
    else
    {
      struct39_0_1[int_5_1++] = struct39;
      goto label_10;
    }
label_21:
    struct39 = struct39_0[index];
    num2 = 0;
    goto label_12;
  }

  internal static void smethod_7(int int_5, out int int_6, out int int_7)
  {
    int_6 = Class19.int_1[int_5 - 257];
    int_7 = Class19.int_2[int_5 - 257];
  }

  internal static void smethod_8(int int_5, out int int_6, out int int_7, out int int_8)
  {
    int index = Array.BinarySearch<int>(Class19.int_1, int_5);
    if (index < 0)
      index = ~index - 1;
    int_6 = index + 257;
label_3:
    int num;
    switch (Class24.smethod_1(14))
    {
      case 0:
        int_7 = int_5 - Class19.int_1[index];
        num = 1;
        goto case 1;
      case 1:
        int_8 = Class19.int_2[index];
        num = 2;
        break;
      case 2:
        break;
      default:
        goto label_3;
    }
  }

  internal static void smethod_9(int int_5, out int int_6, out int int_7, out int int_8)
  {
    int index = Array.BinarySearch<int>(Class19.int_3, int_5);
    if (index < 0)
      index = ~index - 1;
    int_6 = index;
label_3:
    int num;
    switch (Class24.smethod_1(15))
    {
      case 0:
        int_8 = Class19.int_4[index];
        num = 2;
        break;
      case 1:
        int_7 = int_5 - Class19.int_3[index];
        num = 0;
        goto case 0;
      case 2:
        break;
      default:
        goto label_3;
    }
  }

  internal static int[] smethod_10(int[] int_5, int int_6) => Class19.Class20.smethod_0(int_5, int_6);

  internal static int[] smethod_11(int[] int_5) => Class19.Class20.smethod_0(int_5, 15);

  internal static int smethod_12(int int_5)
  {
    switch (int_5)
    {
      case 16:
        return 2;
      case 17:
        return 3;
      case 18:
        return 7;
      default:
        return 0;
    }
  }

  internal static int[] smethod_13(int[] int_5, int int_6, int int_7)
  {
    Class21 class21 = new Class21();
    int num1 = 0;
    while (num1 < int_7)
    {
      if ((int_5[int_6 + num1] == 0 ? 0 : 1) == 0)
      {
        int num2 = 0;
        int num3;
        do
        {
          ++num2;
label_8:
          int num4 = Class24.smethod_1(15);
          int num5;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_9;
              case 1:
                if (num1 + num2 < int_7)
                {
                  num5 = 2;
                  goto case 2;
                }
                else
                  goto label_15;
              case 2:
                if (num2 < 138)
                {
                  num4 = Class24.smethod_1(14);
                  continue;
                }
                goto label_15;
              case 3:
                goto label_12;
              default:
                goto label_8;
            }
          }
label_9:
          if (int_5[int_6 + num1 + num2] != 0)
          {
            num5 = 3;
          }
          else
          {
            num3 = 1;
            goto label_13;
          }
label_12:
          num3 = 0;
label_13:;
        }
        while (num3 != 0);
label_15:
        if (num2 < 3)
        {
          if (num2 >= 1)
            class21.method_0(0);
          if (num2 >= 2)
            class21.method_0(0);
        }
        else if (num2 < 11)
        {
          class21.method_0(17);
          class21.method_0(num2 - 3);
        }
        else
        {
          class21.method_0(18);
          class21.method_0(num2 - 11);
        }
        num1 += num2;
      }
      else
      {
        int int_2 = int_5[int_6 + num1++];
label_30:
        int num6 = Class24.smethod_1(14);
        int num7;
        int num8;
        while (true)
        {
          switch (num6)
          {
            case 0:
              class21.method_0(int_2);
              num8 = 2;
              goto case 2;
            case 1:
              if (num7 != 0)
              {
                num6 = Class24.smethod_1(11);
                continue;
              }
              goto label_31;
            case 2:
              num7 = 0;
              num8 = 1;
              goto case 1;
            case 3:
              goto label_33;
            default:
              goto label_30;
          }
        }
label_31:
        if (num1 + num7 < int_7 && num7 < 6)
        {
          if (int_5[int_6 + num1 + num7] == int_2)
            goto label_33;
        }
        else
          goto label_38;
label_35:
        int num9 = Class24.smethod_1(15);
label_36:
        int num10;
        switch (num9)
        {
          case 0:
            class21.method_0(num7 - 3);
            num10 = 3;
            goto case 3;
          case 1:
            goto label_38;
          case 2:
            break;
          case 3:
            num1 += num7;
            continue;
          default:
            goto label_35;
        }
label_37:
        class21.method_0(16);
        num9 = Class24.smethod_1(14);
        goto label_36;
label_38:
        if (num7 >= 3)
        {
          num10 = 2;
          goto label_37;
        }
        else
          continue;
label_33:
        ++num7;
        goto label_31;
      }
    }
    return class21.method_1();
  }

  private sealed class Class20
  {
    internal static int[] smethod_0(int[] int_0, int int_1)
    {
      int[] items = new int[int_0.Length];
label_9:
      int num1 = Class24.smethod_1(15);
      int[] numArray1;
      while (true)
      {
        int index;
        int num2;
        switch (num1)
        {
          case 0:
            index = 0;
            num2 = 2;
            goto case 2;
          case 1:
            numArray1 = new int[int_0.Length];
            num2 = 0;
            goto case 0;
          case 2:
            if (index != 0)
            {
              num2 = 3;
              goto case 3;
            }
            else
              break;
          case 3:
label_3:
            items[index] = index;
            num1 = Class24.smethod_1(25);
            continue;
          case 4:
            ++index;
            break;
          default:
            goto label_9;
        }
        if (index >= items.Length)
          break;
        goto label_3;
      }
      Array.Copy((Array) int_0, (Array) numArray1, int_0.Length);
label_13:
      int num3 = Class24.smethod_1(15);
      while (true)
      {
        switch (num3)
        {
          case 0:
            goto label_15;
          case 1:
            Array.Sort<int, int>(numArray1, items);
            num3 = Class24.smethod_1(22);
            continue;
          case 2:
            goto label_14;
          case 3:
            goto label_18;
          default:
            goto label_13;
        }
      }
label_14:
      int sourceIndex = 0;
      int num4 = 0;
label_15:
      if (sourceIndex != 0)
      {
        num4 = 3;
        goto label_18;
      }
label_17:
      if (sourceIndex >= numArray1.Length || (numArray1[sourceIndex] == 0 ? 1 : 0) == 0)
      {
        int[] numArray2 = new int[numArray1.Length - sourceIndex];
        Array.Copy((Array) numArray1, sourceIndex, (Array) numArray2, 0, numArray2.Length);
        int[] numArray3;
        if ((numArray2.Length == 0 ? 0 : 1) == 0)
          numArray3 = new int[0];
        else if (numArray2.Length == 1)
          numArray3 = new int[1]{ 1 };
        else
          numArray3 = Class19.Class20.smethod_1(numArray2, int_1);
        int[] numArray4 = new int[int_0.Length];
label_32:
        int num5 = Class24.smethod_1(14);
        while (true)
        {
          int index;
          int num6;
          switch (num5)
          {
            case 0:
              index = 0;
              num6 = 2;
              goto case 2;
            case 1:
label_27:
              numArray4[items[index + sourceIndex]] = numArray3[index];
              num5 = Class24.smethod_1(11);
              continue;
            case 2:
              if (index != 0)
              {
                num6 = 1;
                goto case 1;
              }
              else
                break;
            case 3:
              ++index;
              break;
            default:
              goto label_32;
          }
          if (index >= numArray3.Length)
            break;
          goto label_27;
        }
        return numArray4;
      }
label_18:
      ++sourceIndex;
      goto label_17;
    }

    private static int[] smethod_1(int[] int_0, int int_1)
    {
      int length = int_0.Length;
label_5:
      int num1 = Class24.smethod_1(11);
      int[][] numArray1;
      int num2;
      int[] int_0_1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_6;
          case 2:
            int_0_1 = new int[int_0.Length / 2];
            num1 = Class24.smethod_1(15);
            continue;
          case 3:
            numArray1 = new int[int_1][];
            num2 = 5;
            goto case 5;
          case 4:
            goto label_7;
          case 5:
            numArray1[0] = int_0;
            num2 = 2;
            goto case 2;
          case 6:
            goto label_9;
          default:
            goto label_5;
        }
      }
label_6:
      int index1 = 0;
      num2 = 4;
label_7:
      if (index1 != 0)
      {
        num2 = 0;
        goto label_11;
      }
      else
        goto label_10;
label_9:
      ++index1;
label_10:
      if (index1 >= int_0_1.Length)
      {
        for (int index2 = 1; index2 < int_1; ++index2)
        {
          int[] numArray2 = Class19.Class20.smethod_2(int_0_1, int_0);
label_23:
          int num3 = Class24.smethod_1(11);
          while (true)
          {
            int index3;
            int num4;
            switch (num3)
            {
              case 0:
label_16:
                int_0_1[index3] = numArray2[index3 * 2] + numArray2[index3 * 2 + 1];
                num3 = Class24.smethod_1(16);
                continue;
              case 1:
                if (index3 != 0)
                {
                  num4 = 0;
                  goto case 0;
                }
                else
                  break;
              case 2:
                index3 = 0;
                num4 = 1;
                goto case 1;
              case 3:
                numArray1[index2] = numArray2;
                num4 = 4;
                goto case 4;
              case 4:
                int_0_1 = new int[numArray2.Length / 2];
                num4 = 2;
                goto case 2;
              case 5:
                ++index3;
                break;
              default:
                goto label_23;
            }
            if (index3 >= int_0_1.Length)
              break;
            goto label_16;
          }
        }
        int[] numArray3 = new int[length];
label_27:
        int num5;
        int num6;
        int index4;
        switch (Class24.smethod_1(14))
        {
          case 0:
            num5 = length - 1;
            num6 = 1;
            goto case 1;
          case 1:
            index4 = int_1 - 1;
            num6 = 2;
            goto case 2;
          case 2:
            for (; index4 >= 0; --index4)
            {
              int[] numArray4 = numArray1[index4];
              int num7 = 0;
              int index5 = 0;
              for (int index6 = 0; index6 < num5 * 2; ++index6)
              {
                if (index5 < int_0.Length && int_0[index5] == numArray4[index6])
                {
                  ++numArray3[index5];
                  ++index5;
                }
                else
                  ++num7;
              }
              num5 = num7;
            }
            return numArray3;
          default:
            goto label_27;
        }
      }
label_11:
      int_0_1[index1] = int_0[index1 * 2] + int_0[index1 * 2 + 1];
      num2 = 6;
      goto label_9;
    }

    private static int[] smethod_2(int[] int_0, int[] int_1)
    {
      int[] numArray = new int[int_0.Length + int_1.Length];
label_7:
      int num1 = Class24.smethod_1(25);
      int num2;
      int num3;
      int index1;
      int index2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_8;
          case 1:
            if (num2 != 0)
            {
              num1 = Class24.smethod_1(14);
              continue;
            }
            goto label_12;
          case 2:
            goto label_10;
          case 3:
            index2 = 0;
            num3 = 5;
            goto case 5;
          case 4:
            index1 = 0;
            num3 = 3;
            goto case 3;
          case 5:
            num2 = 0;
            num3 = 1;
            goto case 1;
          case 6:
            goto label_12;
          default:
            goto label_7;
        }
      }
label_8:
      if (int_0[index1] < int_1[index2])
      {
        num3 = 2;
      }
      else
      {
        numArray[num2++] = int_1[index2++];
        goto label_12;
      }
label_10:
      numArray[num2++] = int_0[index1++];
      num3 = 6;
label_12:
      if (index1 >= int_0.Length || index2 >= int_1.Length)
      {
        while (index1 < int_0.Length)
          numArray[num2++] = int_0[index1++];
        while (index2 < int_1.Length)
          numArray[num2++] = int_1[index2++];
        return numArray;
      }
      goto label_8;
    }
  }

  private struct Struct39
  {
    internal Struct40 struct40_0;
    internal ushort ushort_0;
  }
}
