// Decompiled with JetBrains decompiler
// Type: GClass159
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class GClass159 : GInterface5
{
  protected static GClass159 gclass159_0 = new GClass159();
  private static NetworkStream networkStream_0;
  private static BinaryReader binaryReader_0;
  private static BinaryWriter binaryWriter_0;
  public static GInterface4 ginterface4_0;
  public static bool bool_0 = Class15.smethod_0(1) != 0;
  private static TcpClient tcpClient_0;
  public static bool bool_1;
  public static bool bool_2;
  private static GClass159.GClass160 gclass160_0 = new GClass159.GClass160();
  public static Thread thread_0;
  public static Thread thread_1;
  public static Thread thread_2;
  public static int int_0;
  public static int int_1;
  private static bool bool_3;
  public static sbyte[] sbyte_0 = (sbyte[]) null;
  private static sbyte sbyte_1;
  private static sbyte sbyte_2;
  private static int int_2;
  private long long_0;
  public static string string_0 = string.Empty;
  public static bool bool_4;
  private string string_1;
  private int int_3;
  public static GClass134 gclass134_0 = new GClass134();

  public GClass159() => Debug.Log((object) Class13.smethod_0(150253));

  public void method_0() => GClass159.gclass160_0.sendingMessage.Clear();

  public static GClass159 smethod_0()
  {
    if ((GClass159.gclass159_0 == null ? 0 : 1) == 0)
      GClass159.gclass159_0 = new GClass159();
    return GClass159.gclass159_0;
  }

  public bool imethod_0() => GClass159.bool_1;

  public void imethod_1(GInterface4 msgHandler) => GClass159.ginterface4_0 = msgHandler;

  public void imethod_2(string host, int port)
  {
    if ((!GClass159.bool_1 ? 0 : 1) != 0 || (!GClass159.bool_2 ? 0 : 1) != 0)
      return;
    this.string_1 = host;
    this.int_3 = port;
    GClass159.bool_3 = Class15.smethod_0(0) != 0;
    GClass159.tcpClient_0 = (TcpClient) null;
    Debug.Log((object) Class13.smethod_0(150833));
    Debug.Log((object) (Class13.smethod_0(150818) + host));
    Debug.Log((object) (Class13.smethod_0(150811) + port.ToString()));
    GClass159.thread_0 = new Thread(new ThreadStart(this.method_1));
    GClass159.thread_0.Start();
  }

  private void method_1()
  {
    GClass159.bool_4 = Class15.smethod_0(0) != 0;
    GClass159.bool_2 = Class15.smethod_0(1) != 0;
    Thread.CurrentThread.Priority = (System.Threading.ThreadPriority) Class15.smethod_0(2);
    GClass159.bool_1 = Class15.smethod_0(1) != 0;
    try
    {
      this.method_2(this.string_1, this.int_3);
      GClass159.ginterface4_0.imethod_3(GClass159.bool_0);
    }
    catch (Exception ex)
    {
      if ((GClass159.ginterface4_0 == null ? 1 : 0) != 0)
        return;
      this.imethod_4();
      GClass159.ginterface4_0.imethod_1(GClass159.bool_0);
    }
  }

  public void method_2(string host, int port)
  {
    GClass159.tcpClient_0 = new TcpClient();
    GClass159.tcpClient_0.Connect(host, port);
    GClass159.networkStream_0 = GClass159.tcpClient_0.GetStream();
    GClass159.binaryReader_0 = new BinaryReader((Stream) GClass159.networkStream_0, (Encoding) new UTF8Encoding());
    GClass159.binaryWriter_0 = new BinaryWriter((Stream) GClass159.networkStream_0, (Encoding) new UTF8Encoding());
    new Thread(new ThreadStart(GClass159.gclass160_0.method_1)).Start();
    GClass159.Class6 class6 = new GClass159.Class6();
    GClass33.smethod_2(Class13.smethod_0(150909));
    // ISSUE: method pointer
    IntPtr method = __methodptr(method_0);
    GClass159.thread_1 = new Thread(new ThreadStart((object) class6, method));
    GClass159.thread_1.Start();
    GClass159.int_2 = GClass159.smethod_7();
    GClass159.bool_2 = Class15.smethod_0(0) != 0;
    GClass159.smethod_1(new GClass96(Class15.smethod_0(621)));
  }

  public void imethod_3(GClass96 message)
  {
    GClass151.smethod_7(Class13.smethod_0(150897) + message.command.ToString());
    GClass159.gclass160_0.method_0(message);
  }

  private static void smethod_1(GClass96 gclass96_0)
  {
    sbyte[] numArray = gclass96_0.method_0();
    try
    {
      if ((!GClass159.bool_3 ? 1 : 0) == 0)
      {
        sbyte num = GClass159.smethod_3(gclass96_0.command);
        GClass159.binaryWriter_0.Write(num);
      }
      else
        GClass159.binaryWriter_0.Write(gclass96_0.command);
      if ((numArray == null ? 1 : 0) == 0)
      {
        int length = numArray.Length;
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
        {
          int num1 = (int) GClass159.smethod_3((sbyte) (length >> Class15.smethod_0(88)));
          GClass159.binaryWriter_0.Write((sbyte) num1);
          int num2 = (int) GClass159.smethod_3((sbyte) (length & Class15.smethod_0(270)));
          GClass159.binaryWriter_0.Write((sbyte) num2);
        }
        else
          GClass159.binaryWriter_0.Write((ushort) length);
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
          {
            sbyte num = GClass159.smethod_3(numArray[index]);
            GClass159.binaryWriter_0.Write(num);
          }
        }
        GClass159.int_0 += Class15.smethod_0(3) + numArray.Length;
      }
      else
      {
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
        {
          int num3 = Class15.smethod_0(0);
          int num4 = (int) GClass159.smethod_3((sbyte) (num3 >> Class15.smethod_0(88)));
          GClass159.binaryWriter_0.Write((sbyte) num4);
          int num5 = (int) GClass159.smethod_3((sbyte) (num3 & Class15.smethod_0(270)));
          GClass159.binaryWriter_0.Write((sbyte) num5);
        }
        else
          GClass159.binaryWriter_0.Write((ushort) Class15.smethod_0(0));
        GClass159.int_0 += Class15.smethod_0(3);
      }
      GClass159.binaryWriter_0.Flush();
    }
    catch (Exception ex)
    {
      Debug.Log((object) ex.StackTrace);
    }
  }

  public static sbyte smethod_2(sbyte b)
  {
    sbyte[] sbyte0 = GClass159.sbyte_0;
    sbyte sbyte1 = GClass159.sbyte_1;
    GClass159.sbyte_1 = (sbyte) ((int) sbyte1 + Class15.smethod_0(1));
    int index = (int) sbyte1;
    int num = (int) (sbyte) ((int) sbyte0[index] & Class15.smethod_0(270) ^ (int) b & Class15.smethod_0(270));
    if ((int) GClass159.sbyte_1 < GClass159.sbyte_0.Length)
      return (sbyte) num;
    GClass159.sbyte_1 %= (sbyte) GClass159.sbyte_0.Length;
    return (sbyte) num;
  }

  public static sbyte smethod_3(sbyte b)
  {
    sbyte[] sbyte0 = GClass159.sbyte_0;
    sbyte sbyte2 = GClass159.sbyte_2;
    GClass159.sbyte_2 = (sbyte) ((int) sbyte2 + Class15.smethod_0(1));
    int index = (int) sbyte2;
    int num = (int) (sbyte) ((int) sbyte0[index] & Class15.smethod_0(270) ^ (int) b & Class15.smethod_0(270));
    if ((int) GClass159.sbyte_2 < GClass159.sbyte_0.Length)
      return (sbyte) num;
    GClass159.sbyte_2 %= (sbyte) GClass159.sbyte_0.Length;
    return (sbyte) num;
  }

  public static void smethod_4(GClass96 msg)
  {
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0)
      GClass159.ginterface4_0.imethod_0(msg);
    else
      GClass159.gclass134_0.method_0((object) msg);
  }

  public static void smethod_5()
  {
    while (GClass159.gclass134_0.method_2() > Class15.smethod_0(0))
    {
      GClass96 message = (GClass96) GClass159.gclass134_0.method_3(Class15.smethod_0(0));
      if ((!GClass32.bool_5 ? 0 : 1) != 0)
        break;
      if ((message == null ? 0 : 1) != 0)
      {
        GClass159.ginterface4_0.imethod_0(message);
        GClass159.gclass134_0.method_7(Class15.smethod_0(0));
      }
      else
      {
        GClass159.gclass134_0.method_7(Class15.smethod_0(0));
        break;
      }
    }
  }

  public void imethod_4() => GClass159.smethod_6();

  private static void smethod_6()
  {
    GClass159.sbyte_0 = (sbyte[]) null;
    GClass159.sbyte_1 = (sbyte) Class15.smethod_0(0);
    GClass159.sbyte_2 = (sbyte) Class15.smethod_0(0);
    try
    {
      GClass159.bool_1 = Class15.smethod_0(0) != 0;
      GClass159.bool_2 = Class15.smethod_0(0) != 0;
      if ((GClass159.tcpClient_0 == null ? 1 : 0) == 0)
      {
        GClass159.tcpClient_0.Close();
        GClass159.tcpClient_0 = (TcpClient) null;
      }
      if ((GClass159.networkStream_0 == null ? 1 : 0) == 0)
      {
        GClass159.networkStream_0.Close();
        GClass159.networkStream_0 = (NetworkStream) null;
      }
      if ((GClass159.binaryWriter_0 == null ? 1 : 0) == 0)
      {
        GClass159.binaryWriter_0.Close();
        GClass159.binaryWriter_0 = (BinaryWriter) null;
      }
      if ((GClass159.binaryReader_0 == null ? 1 : 0) == 0)
      {
        GClass159.binaryReader_0.Close();
        GClass159.binaryReader_0 = (BinaryReader) null;
      }
      GClass159.thread_2 = (Thread) null;
      GClass159.thread_1 = (Thread) null;
    }
    catch (Exception ex)
    {
    }
  }

  public static int smethod_7() => Environment.TickCount;

  public static byte smethod_8(sbyte var) => (int) var > Class15.smethod_0(0) ? (byte) var : (byte) ((uint) var + (uint) Class15.smethod_0(290));

  public static byte[] smethod_9(sbyte[] var)
  {
    byte[] numArray = new byte[var.Length];
    for (int index = Class15.smethod_0(0); index < var.Length; index += Class15.smethod_0(1))
      numArray[index] = (int) var[index] <= Class15.smethod_0(0) ? (byte) ((uint) var[index] + (uint) Class15.smethod_0(290)) : (byte) var[index];
    return numArray;
  }

  public class GClass160
  {
    public List<GClass96> sendingMessage;

    public GClass160() => this.sendingMessage = new List<GClass96>();

    public void method_0(GClass96 message) => this.sendingMessage.Add(message);

    public void method_1()
    {
      while ((!GClass159.bool_1 ? 0 : 1) != 0)
      {
        try
        {
          if ((!GClass159.bool_3 ? 1 : 0) == 0)
          {
            while (this.sendingMessage.Count > Class15.smethod_0(0))
            {
              GClass159.smethod_1(this.sendingMessage[Class15.smethod_0(0)]);
              this.sendingMessage.RemoveAt(Class15.smethod_0(0));
            }
          }
          try
          {
            Thread.Sleep(Class15.smethod_0(3));
          }
          catch (Exception ex)
          {
            GClass33.smethod_2(ex.ToString());
          }
        }
        catch (Exception ex)
        {
          GClass151.smethod_7(Class13.smethod_0(150951));
        }
      }
    }
  }

  private class Class6
  {
    public void method_0()
    {
      try
      {
        while ((!GClass159.bool_1 ? 0 : 1) != 0)
        {
          GClass96 gclass96 = this.method_3();
          if ((gclass96 == null ? 1 : 0) == 0)
          {
            try
            {
              if ((int) gclass96.command == Class15.smethod_0(621))
                this.method_1(gclass96);
              else
                GClass159.smethod_4(gclass96);
            }
            catch (Exception ex)
            {
              GClass33.smethod_0(Class13.smethod_0(150922));
            }
            try
            {
              Thread.Sleep(Class15.smethod_0(3));
            }
            catch (Exception ex)
            {
              GClass33.smethod_0(Class13.smethod_0(151002));
            }
          }
          else
            break;
        }
      }
      catch (Exception ex)
      {
        Debug.Log((object) Class13.smethod_0(150560));
        Debug.Log((object) ex.Message.ToString());
      }
      if ((!GClass159.bool_1 ? 0 : 1) == 0)
        return;
      if ((GClass159.ginterface4_0 == null ? 1 : 0) == 0)
      {
        if (GClass159.smethod_7() - GClass159.int_2 > Class15.smethod_0(16))
          GClass159.ginterface4_0.imethod_2(GClass159.bool_0);
        else
          GClass159.ginterface4_0.imethod_1(GClass159.bool_0);
      }
      if ((GClass159.tcpClient_0 == null ? 1 : 0) != 0)
        return;
      GClass159.smethod_6();
    }

    private void method_1(GClass96 gclass96_0)
    {
      try
      {
        sbyte length = gclass96_0.method_1().method_0();
        GClass159.sbyte_0 = new sbyte[(int) length];
        for (int index = Class15.smethod_0(0); index < (int) length; index += Class15.smethod_0(1))
          GClass159.sbyte_0[index] = gclass96_0.method_1().method_0();
        for (int index = Class15.smethod_0(0); index < GClass159.sbyte_0.Length - Class15.smethod_0(1); index += Class15.smethod_0(1))
          GClass159.sbyte_0[index + Class15.smethod_0(1)] ^= GClass159.sbyte_0[index];
        GClass159.bool_3 = Class15.smethod_0(1) != 0;
        GClass63.string_1 = gclass96_0.method_1().method_14();
        GClass63.int_1 = gclass96_0.method_1().method_8();
        GClass63.bool_0 = (gclass96_0.method_1().method_2() == (sbyte) 0 ? 0 : 1) != 0 ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;
        if ((!GClass159.bool_0 ? 1 : 0) != 0 || (!GClass63.bool_0 ? 1 : 0) != 0)
          return;
        GClass62.smethod_5();
      }
      catch (Exception ex)
      {
      }
    }

    private GClass96 method_2(sbyte sbyte_0)
    {
      int num1 = (int) GClass159.smethod_2(GClass159.binaryReader_0.ReadSByte()) + Class15.smethod_0(212);
      int num2 = (int) GClass159.smethod_2(GClass159.binaryReader_0.ReadSByte()) + Class15.smethod_0(212);
      int count = (((int) GClass159.smethod_2(GClass159.binaryReader_0.ReadSByte()) + Class15.smethod_0(212)) * Class15.smethod_0(290) + num2) * Class15.smethod_0(290) + num1;
      GClass33.smethod_2(Class13.smethod_0(150633) + count.ToString());
      sbyte[] numArray = new sbyte[count];
      Buffer.BlockCopy((Array) GClass159.binaryReader_0.ReadBytes(count), Class15.smethod_0(0), (Array) numArray, Class15.smethod_0(0), count);
      GClass159.int_1 += Class15.smethod_0(3) + count;
      int num3 = GClass159.int_1 + GClass159.int_0;
      int num4 = num3 / Class15.smethod_0(246);
      string str1 = num4.ToString();
      string str2 = Class13.smethod_0(144757);
      num4 = num3 % Class15.smethod_0(246) / Class15.smethod_0(68);
      string str3 = num4.ToString();
      string str4 = Class13.smethod_0(144738);
      GClass159.string_0 = str1 + str2 + str3 + str4;
      if ((!GClass159.bool_3 ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
          numArray[index] = GClass159.smethod_2(numArray[index]);
      }
      return new GClass96(sbyte_0, numArray);
    }

    private GClass96 method_3()
    {
      try
      {
        sbyte num1 = GClass159.binaryReader_0.ReadSByte();
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
          num1 = GClass159.smethod_2(num1);
        if ((int) num1 == Class15.smethod_0(599) || (int) num1 == Class15.smethod_0(592) || (int) num1 == Class15.smethod_0(67) || (int) num1 == Class15.smethod_0(598) || (int) num1 == Class15.smethod_0(605) || (int) num1 == Class15.smethod_0(594))
          return this.method_2(num1);
        int count;
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
        {
          int b1 = (int) GClass159.binaryReader_0.ReadSByte();
          sbyte b2 = GClass159.binaryReader_0.ReadSByte();
          count = ((int) GClass159.smethod_2((sbyte) b1) & Class15.smethod_0(270)) << Class15.smethod_0(88) | (int) GClass159.smethod_2(b2) & Class15.smethod_0(270);
        }
        else
        {
          int num2 = (int) GClass159.binaryReader_0.ReadSByte();
          sbyte num3 = GClass159.binaryReader_0.ReadSByte();
          int num4 = Class15.smethod_0(622);
          count = num2 & num4 | (int) num3 & Class15.smethod_0(270);
        }
        sbyte[] numArray = new sbyte[count];
        Buffer.BlockCopy((Array) GClass159.binaryReader_0.ReadBytes(count), Class15.smethod_0(0), (Array) numArray, Class15.smethod_0(0), count);
        GClass159.int_1 += Class15.smethod_0(3) + count;
        int num5 = GClass159.int_1 + GClass159.int_0;
        GClass159.string_0 = (num5 / Class15.smethod_0(246)).ToString() + Class13.smethod_0(144840) + (num5 % Class15.smethod_0(246) / Class15.smethod_0(68)).ToString() + Class13.smethod_0(144447);
        if ((!GClass159.bool_3 ? 1 : 0) == 0)
        {
          for (int index = Class15.smethod_0(0); index < numArray.Length; index += Class15.smethod_0(1))
            numArray[index] = GClass159.smethod_2(numArray[index]);
        }
        return new GClass96(num1, numArray);
      }
      catch (Exception ex)
      {
        Debug.Log((object) ex.StackTrace.ToString());
      }
      return (GClass96) null;
    }
  }
}
