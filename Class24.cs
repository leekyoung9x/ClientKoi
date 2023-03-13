// Decompiled with JetBrains decompiler
// Type: Class24
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.IO;

internal sealed class Class24
{
  public static void smethod_0(Stream stream_0, Stream stream_1)
  {
    byte[] numArray = new byte[81920];
    Class24.Class25 class25 = new Class24.Class25(stream_0);
    while (true)
    {
      int count = class25.method_0(numArray, 0, numArray.Length);
label_1:
      int num;
      switch (Class24.smethod_1(14))
      {
        case 0:
          if (count > 0)
          {
            num = 1;
            goto case 1;
          }
          else
            goto label_2;
        case 1:
          stream_1.Write(numArray, 0, count);
          num = 2;
          continue;
        case 2:
          continue;
        default:
          goto label_1;
      }
    }
label_2:;
  }

  internal static int smethod_1(int int_0)
  {
    switch (int_0)
    {
      case 11:
        return 3;
      case 14:
        return 0;
      case 15:
        return 1;
      case 16:
        return 5;
      case 22:
        return 2;
      case 24:
        return 9;
      case 25:
        return 4;
      case 33:
        return 8;
      case 34:
        return 6;
      default:
        return -1;
    }
  }

  public sealed class Class25
  {
    private Class24.Class27 class27_0 = new Class24.Class27(32769);
    private Class24.Class26 class26_0;
    private Class23 class23_0;
    private int int_0 = -1;
    private int int_1 = -1;
    private bool bool_0;
    private int int_2;
    private long long_0;
    private long long_1;
    private bool bool_1;
    private int int_3;
    private bool bool_2;

    public Class25(Stream stream_0) => this.class26_0 = new Class24.Class26(stream_0);

    public int method_0(byte[] byte_0, int int_4, int int_5)
    {
      if ((int_5 == 0 ? 1 : 0) != 0 || (!this.bool_1 ? 1 : 0) == 0)
        return 0;
      int num1 = 0;
      while (num1 < int_5)
      {
        while (this.int_0 < 0 && (!this.bool_1 ? 1 : 0) != 0)
          this.bool_1 = !this.method_1();
        if ((!this.bool_1 ? 0 : 1) == 0)
        {
          int num2 = this.method_2(byte_0, int_4 + num1, int_5 - num1);
label_6:
          int num3;
          switch (Class24.smethod_1(15))
          {
            case 0:
              num1 += num2;
              num3 = 2;
              continue;
            case 1:
              if (num2 > 0)
              {
                num3 = 0;
                goto case 0;
              }
              else
              {
                this.int_0 = -1;
                continue;
              }
            case 2:
              continue;
            default:
              goto label_6;
          }
        }
        else
          break;
      }
      return num1;
    }

    private bool method_1()
    {
      if ((!this.bool_0 ? 1 : 0) == 0)
        return false;
      this.long_0 = this.class26_0.long_0;
label_10:
      int num1 = Class24.smethod_1(25);
      int num2;
      int num3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            this.class26_0.method_1();
            num2 = 2;
            goto case 2;
          case 1:
            goto label_26;
          case 2:
            num3 = this.class26_0.method_0(16) ^ 41332;
            num1 = Class24.smethod_1(34);
            continue;
          case 3:
            this.int_0 = this.class26_0.method_0(4);
            num2 = 5;
            goto case 5;
          case 4:
            this.bool_0 = this.class26_0.method_0(1) > 0;
            num2 = 3;
            goto case 3;
          case 5:
            if (this.int_0 == 1)
            {
              num2 = 0;
              goto case 0;
            }
            else
              goto label_11;
          case 6:
            goto label_25;
          case 7:
            goto label_27;
          case 8:
            goto label_28;
          default:
            goto label_10;
        }
      }
label_11:
      if (this.int_0 == 5)
      {
        Struct40[] struct400 = Class19.struct40_0;
label_18:
        int num4 = Class24.smethod_1(15);
        int num5;
        while (true)
        {
          switch (num4)
          {
            case 0:
              this.class23_0 = Class19.class23_0;
              num5 = 2;
              goto case 2;
            case 1:
              Struct40[] struct401 = Class19.struct40_1;
              num5 = 3;
              goto case 3;
            case 2:
              this.bool_2 = false;
              num4 = Class24.smethod_1(25);
              continue;
            case 3:
              this.int_2 = 0;
              num5 = 0;
              goto case 0;
            case 4:
              goto label_28;
            default:
              goto label_18;
          }
        }
      }
      else if (this.int_0 == 4)
      {
        Struct40[] struct40_0;
        Struct40[] struct40_1;
        this.method_6(this.class26_0, out struct40_0, out struct40_1);
label_21:
        int num6;
        switch (Class24.smethod_1(14))
        {
          case 0:
            this.int_2 = 0;
            num6 = 1;
            goto case 1;
          case 1:
            this.class23_0 = Class19.smethod_4(struct40_0, struct40_1);
            num6 = 2;
            goto case 2;
          case 2:
            this.bool_2 = false;
            goto label_28;
          default:
            goto label_21;
        }
      }
      else
        goto label_28;
label_25:
      this.int_2 = num3;
      num2 = 1;
label_26:
      this.class23_0 = (Class23) null;
      num2 = 7;
label_27:
      this.bool_2 = true;
      num2 = 8;
label_28:
      this.long_1 = this.class26_0.long_0;
      return true;
    }

    private int method_2(byte[] byte_0, int int_4, int int_5)
    {
      int num1 = int_4;
      if (this.int_0 == 1)
      {
        if (this.int_2 > 0)
        {
          int int_3 = Math.Min(int_5, this.int_2);
label_9:
          int num2 = Class24.smethod_1(11);
          int num3;
          while (true)
          {
            switch (num2)
            {
              case 0:
                int_4 += int_3;
                num2 = Class24.smethod_1(16);
                continue;
              case 1:
                this.class27_0.method_1(byte_0, int_4, int_3);
                num3 = 4;
                goto case 4;
              case 2:
                int_5 -= int_3;
                num3 = 0;
                goto case 0;
              case 3:
                this.class26_0.method_2(byte_0, int_4, int_3);
                num3 = 1;
                goto case 1;
              case 4:
                this.int_2 -= int_3;
                num3 = 2;
                goto case 2;
              case 5:
                goto label_29;
              default:
                goto label_9;
            }
          }
        }
      }
      else if ((!this.bool_2 ? 0 : 1) == 0)
      {
        if (this.int_3 > 0)
          this.method_3(byte_0, ref int_4, ref int_5);
        if (int_5 > 0)
        {
          do
          {
            int num4 = Class24.Class25.smethod_0(this.class26_0, this.class23_0.class22_0);
            this.bool_2 = num4 == 256;
            if ((!this.bool_2 ? 0 : 1) == 0)
            {
              if (num4 < 256)
              {
                byte_0[int_4++] = (byte) num4;
label_16:
                int num5;
                switch (Class24.smethod_1(14))
                {
                  case 0:
                    this.class27_0.method_0((byte) num4);
                    num5 = 1;
                    goto case 1;
                  case 1:
                    --int_5;
                    num5 = 2;
                    break;
                  case 2:
                    break;
                  default:
                    goto label_16;
                }
              }
              else if (num4 <= 285)
              {
                int num6 = Class24.Class25.smethod_1(this.class26_0, num4);
label_25:
                int num7 = Class24.smethod_1(14);
                int num8;
                int num9;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      num8 = Class24.Class25.smethod_2(this.class26_0, this.class23_0.class22_1);
                      num9 = 2;
                      goto case 2;
                    case 1:
                      this.int_3 = num6;
                      num7 = Class24.smethod_1(11);
                      continue;
                    case 2:
                      this.int_1 = num8;
                      num9 = 1;
                      goto case 1;
                    case 3:
                      goto label_26;
                    default:
                      goto label_25;
                  }
                }
label_26:
                this.method_3(byte_0, ref int_4, ref int_5);
              }
            }
            else
              break;
          }
          while (int_5 > 0);
        }
      }
label_29:
      this.long_1 = this.class26_0.long_0;
      return int_4 - num1;
    }

    private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
    {
      int num1 = Math.Min(this.int_3, int_5);
label_5:
      int num2 = Class24.smethod_1(15);
      byte[] numArray;
      int num3;
      while (true)
      {
        switch (num2)
        {
          case 0:
            int_5 -= num1;
            num3 = 2;
            goto case 2;
          case 1:
            numArray = this.class27_0.method_2(this.int_1, Math.Min(num1, this.int_1));
            num3 = 0;
            goto case 0;
          case 2:
            this.int_3 -= num1;
            num2 = Class24.smethod_1(11);
            continue;
          case 3:
            goto label_11;
          default:
            goto label_5;
        }
      }
label_11:
      while (num1 > numArray.Length)
      {
        Array.Copy((Array) numArray, 0, (Array) byte_0, int_4, numArray.Length);
label_7:
        int num4;
        switch (Class24.smethod_1(15))
        {
          case 0:
            num1 -= numArray.Length;
            num4 = 2;
            goto case 2;
          case 1:
            int_4 += numArray.Length;
            num4 = 0;
            goto case 0;
          case 2:
            this.class27_0.method_1(numArray, 0, numArray.Length);
            continue;
          default:
            goto label_7;
        }
      }
      Array.Copy((Array) numArray, 0, (Array) byte_0, int_4, num1);
label_13:
      int num5;
      switch (Class24.smethod_1(14))
      {
        case 0:
          int_4 += num1;
          num5 = 1;
          goto case 1;
        case 1:
          this.class27_0.method_1(numArray, 0, num1);
          num5 = 2;
          break;
        case 2:
          break;
        default:
          goto label_13;
      }
    }

    public bool method_4(int int_4)
    {
      byte[] byte_0 = new byte[1024];
      int num;
      while (int_4 > 0 && (num = this.method_0(byte_0, 0, Math.Min(1024, int_4))) > 0)
        int_4 -= num;
      return int_4 <= 0;
    }

    public void method_5()
    {
      byte[] byte_0 = new byte[1024];
      do
        ;
      while (this.method_0(byte_0, 0, 1024) > 0);
    }

    private static int smethod_0(Class24.Class26 class26_1, Class22 class22_0)
    {
      while ((class22_0 == null ? 1 : 0) == 0 && (!class22_0.bool_0 ? 1 : 0) != 0)
        class22_0 = class26_1.method_0(1) > 0 ? class22_0.class22_1 : class22_0.class22_0;
      return (int) class22_0.ushort_0;
    }

    private static int smethod_1(Class24.Class26 class26_1, int int_4)
    {
      int int_6;
      int int_7;
      Class19.smethod_7(int_4, out int_6, out int_7);
      return int_7 > 0 ? int_6 + class26_1.method_0(int_7) : int_6;
    }

    private static int smethod_2(Class24.Class26 class26_1, Class22 class22_0)
    {
      int index = Class24.Class25.smethod_0(class26_1, class22_0);
label_1:
      int num1;
      int num2;
      int int_2;
      int num3;
      switch (Class24.smethod_1(11))
      {
        case 0:
          int_2 = Class19.int_4[index];
          num2 = 1;
          goto case 1;
        case 1:
          if (int_2 <= 0)
            return num1;
          num2 = 2;
          goto case 2;
        case 2:
          num3 = class26_1.method_0(int_2);
          num2 = 4;
          goto case 4;
        case 3:
          num1 = Class19.int_3[index];
          num2 = 0;
          goto case 0;
        case 4:
          return num1 + num3;
        default:
          goto label_1;
      }
    }

    private void method_6(
      Class24.Class26 class26_1,
      out Struct40[] struct40_0,
      out Struct40[] struct40_1)
    {
      int length1 = class26_1.method_0(5) + 257;
label_5:
      int num1 = Class24.smethod_1(25);
      int[] int0;
      int length2;
      int num2;
      int num3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_7;
          case 1:
            goto label_6;
          case 2:
            goto label_8;
          case 3:
            num3 = class26_1.method_0(4) + 4;
            num2 = 6;
            goto case 6;
          case 4:
            length2 = class26_1.method_0(5) + 1;
            num2 = 3;
            goto case 3;
          case 5:
            goto label_12;
          case 6:
            int0 = Class19.int_0;
            num1 = Class24.smethod_1(15);
            continue;
          case 7:
            goto label_10;
          default:
            goto label_5;
        }
      }
label_6:
      int[] int_5 = new int[19];
      num2 = 0;
label_7:
      int index1 = 0;
      num2 = 2;
label_8:
      if (index1 != 0)
      {
        num2 = 5;
        goto label_12;
      }
      else
        goto label_11;
label_10:
      ++index1;
label_11:
      if (index1 >= num3)
      {
        Class22 class22_0 = Class19.smethod_5(Class19.smethod_2(int_5));
label_23:
        int num4 = Class24.smethod_1(22);
        int[] numArray;
        while (true)
        {
          int index2;
          int num5;
          switch (num4)
          {
            case 0:
label_16:
              struct40_0[index2].int_1 = numArray[index2];
              num4 = Class24.smethod_1(16);
              continue;
            case 1:
              struct40_0 = new Struct40[length1];
              num5 = 3;
              goto case 3;
            case 2:
              numArray = Class24.Class25.smethod_3(class26_1, class22_0, length1 + length2);
              num5 = 1;
              goto case 1;
            case 3:
              index2 = 0;
              num5 = 4;
              goto case 4;
            case 4:
              if (index2 != 0)
              {
                num5 = 0;
                goto case 0;
              }
              else
                break;
            case 5:
              ++index2;
              break;
            default:
              goto label_23;
          }
          if (index2 >= length1)
            break;
          goto label_16;
        }
        Class19.smethod_3(struct40_0);
label_27:
        int num6 = Class24.smethod_1(11);
        while (true)
        {
          switch (num6)
          {
            case 0:
              goto label_33;
            case 1:
              goto label_29;
            case 2:
              goto label_28;
            case 3:
              struct40_1 = new Struct40[length2];
              num6 = Class24.smethod_1(22);
              continue;
            case 4:
              goto label_31;
            default:
              goto label_27;
          }
        }
label_28:
        int index3 = 0;
        int num7 = 1;
label_29:
        if (index3 != 0)
        {
          num7 = 0;
          goto label_33;
        }
        else
          goto label_32;
label_31:
        ++index3;
label_32:
        if (index3 >= length2)
        {
          Class19.smethod_3(struct40_1);
          return;
        }
label_33:
        struct40_1[index3].int_1 = numArray[index3 + length1];
        num7 = 4;
        goto label_31;
      }
label_12:
      int_5[int0[index1]] = class26_1.method_0(3);
      num2 = 7;
      goto label_10;
    }

    private static int[] smethod_3(Class24.Class26 class26_1, Class22 class22_0, int int_4)
    {
      int[] numArray = new int[int_4];
label_1:
      int index;
      int num1;
      int num2;
      switch (Class24.smethod_1(15))
      {
        case 0:
          if (num2 < 16)
          {
            num1 = 3;
            goto case 3;
          }
          else
          {
            switch (num2)
            {
              case 16:
                int num3 = class26_1.method_0(2) + 3;
label_19:
                int num4 = Class24.smethod_1(22);
                while (true)
                {
                  int num5;
                  int num6;
                  switch (num4)
                  {
                    case 0:
label_14:
                      numArray[index + num5] = numArray[index - 1];
                      num4 = Class24.smethod_1(11);
                      continue;
                    case 1:
                      if (num5 != 0)
                      {
                        num6 = 0;
                        goto case 0;
                      }
                      else
                        break;
                    case 2:
                      num5 = 0;
                      num6 = 1;
                      goto case 1;
                    case 3:
                      ++num5;
                      break;
                    default:
                      goto label_19;
                  }
                  if (num5 >= num3)
                    break;
                  goto label_14;
                }
                index += num3 - 1;
                goto label_5;
              case 17:
label_21:
                int num7;
                int num8;
                switch (Class24.smethod_1(15))
                {
                  case 0:
                    index += num7 - 1;
                    num8 = 2;
                    goto label_5;
                  case 1:
                    num7 = class26_1.method_0(3) + 3;
                    num8 = 0;
                    goto case 0;
                  case 2:
                    goto label_5;
                  default:
                    goto label_21;
                }
              case 18:
                int num9 = class26_1.method_0(7) + 11;
                index += num9 - 1;
                goto label_5;
              default:
                goto label_5;
            }
          }
        case 1:
          index = 0;
          num1 = 2;
          goto case 2;
        case 2:
          if (index != 0)
          {
            num1 = 4;
            goto case 4;
          }
          else
            break;
        case 3:
          numArray[index] = num2;
          num1 = 5;
          goto case 5;
        case 4:
label_25:
          num2 = Class24.Class25.smethod_0(class26_1, class22_0);
          num1 = 0;
          goto case 0;
        case 5:
label_5:
          ++index;
          break;
        default:
          goto label_1;
      }
      if (index >= int_4)
        return numArray;
      goto label_25;
    }
  }

  private sealed class Class26
  {
    private uint uint_0;
    private int int_0;
    private int int_1;
    private Stream stream_0;
    internal long long_0;

    internal Class26(Stream stream_1) => this.stream_0 = stream_1;

    internal int method_0(int int_2)
    {
      this.long_0 += (long) int_2;
      for (int index = int_2 - (this.int_1 - this.int_0); index > 0; index -= 8)
      {
        this.uint_0 |= checked ((uint) this.stream_0.ReadByte()) << this.int_1;
        this.int_1 += 8;
      }
      int num = (int) (this.uint_0 >> this.int_0) & (1 << int_2) - 1;
      this.int_0 += int_2;
      if (this.int_1 == this.int_0)
      {
        this.int_0 = 0;
        this.int_1 = 0;
        this.uint_0 = 0U;
        return num;
      }
      if (this.int_0 < 8)
        return num;
      this.uint_0 >>= this.int_0;
      this.int_1 -= this.int_0;
      this.int_0 = 0;
      return num;
    }

    internal void method_1()
    {
      if (this.int_1 != this.int_0)
        this.long_0 += (long) (this.int_1 - this.int_0);
      this.int_0 = 0;
      this.int_1 = 0;
      this.uint_0 = 0U;
    }

    internal void method_2(byte[] byte_0, int int_2, int int_3) => this.long_0 += (long) (this.stream_0.Read(byte_0, int_2, int_3) << 3);
  }

  private sealed class Class27
  {
    private byte[] byte_0;
    private int int_0;
    internal int int_1;
    internal long long_0;

    internal Class27(int int_2)
    {
      this.int_1 = int_2;
      this.byte_0 = new byte[int_2];
    }

    internal void method_0(byte byte_1)
    {
      this.byte_0[this.int_0++] = byte_1;
      if (this.int_0 >= this.int_1)
        this.int_0 = 0;
      ++this.long_0;
    }

    internal void method_1(byte[] byte_1, int int_2, int int_3)
    {
      this.long_0 += (long) int_3;
label_6:
      int num1 = Class24.smethod_1(15);
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            this.int_0 = 0;
            num1 = Class24.smethod_1(11);
            continue;
          case 1:
            if (int_3 >= this.int_1)
            {
              num2 = 2;
              goto case 2;
            }
            else
              goto label_7;
          case 2:
            Array.Copy((Array) byte_1, int_2, (Array) this.byte_0, 0, this.int_1);
            num2 = 0;
            goto case 0;
          case 3:
            goto label_22;
          default:
            goto label_6;
        }
      }
label_22:
      return;
label_7:
      if (this.int_0 + int_3 > this.int_1)
      {
        int length1 = this.int_1 - this.int_0;
label_9:
        int length2;
        int num3;
        switch (Class24.smethod_1(11))
        {
          case 0:
            Array.Copy((Array) byte_1, int_2 + length1, (Array) this.byte_0, 0, length2);
            num3 = 1;
            goto case 1;
          case 1:
            this.int_0 = length2;
            num3 = 4;
            break;
          case 2:
            Array.Copy((Array) byte_1, int_2, (Array) this.byte_0, this.int_0, length1);
            num3 = 0;
            goto case 0;
          case 3:
            length2 = this.int_0 + int_3 - this.int_1;
            num3 = 2;
            goto case 2;
          case 4:
            break;
          default:
            goto label_9;
        }
      }
      else
      {
        Array.Copy((Array) byte_1, int_2, (Array) this.byte_0, this.int_0, int_3);
label_16:
        int num4;
        switch (Class24.smethod_1(15))
        {
          case 0:
            if (this.int_0 != this.int_1)
              break;
            num4 = 2;
            goto case 2;
          case 1:
            this.int_0 += int_3;
            num4 = 0;
            goto case 0;
          case 2:
            this.int_0 = 0;
            break;
          default:
            goto label_16;
        }
      }
    }

    internal byte[] method_2(int int_2, int int_3)
    {
      byte[] destinationArray = new byte[int_3];
label_1:
      int num1;
      switch (Class24.smethod_1(15))
      {
        case 0:
          Array.Copy((Array) this.byte_0, this.int_0 - int_2, (Array) destinationArray, 0, int_3);
          num1 = 2;
          goto case 2;
        case 1:
          if (this.int_0 >= int_2)
          {
            num1 = 0;
            goto case 0;
          }
          else
          {
            int num2 = int_2 - this.int_0;
label_6:
            int num3;
            switch (Class24.smethod_1(22))
            {
              case 0:
                Array.Copy((Array) this.byte_0, this.int_1 - num2, (Array) destinationArray, 0, num2);
                num3 = 1;
                goto case 1;
              case 1:
                Array.Copy((Array) this.byte_0, 0, (Array) destinationArray, num2, int_3 - num2);
                num3 = 3;
                goto label_12;
              case 2:
                if (num2 < int_3)
                {
                  num3 = 0;
                  goto case 0;
                }
                else
                {
                  Array.Copy((Array) this.byte_0, this.int_1 - num2, (Array) destinationArray, 0, int_3);
                  goto label_12;
                }
              case 3:
                goto label_12;
              default:
                goto label_6;
            }
          }
        case 2:
label_12:
          return destinationArray;
        default:
          goto label_1;
      }
    }
  }
}
