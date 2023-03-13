// Decompiled with JetBrains decompiler
// Type: Main
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Net.NetworkInformation;
using System.Threading;
using UnityEngine;

public class Main : MonoBehaviour
{
  public static Main main_0;
  public static GClass98 gclass98_0;
  public static GClass63 gclass63_0;
  public static string string_0 = Class13.smethod_0(154040);
  public static string string_1;
  public static bool bool_0;
  public static bool bool_1;
  public static bool bool_2;
  public static bool bool_3;
  public static bool bool_4;
  public static bool bool_5;
  public static bool bool_6;
  public static string string_2;
  public static int int_0;
  public static int int_1 = Class15.smethod_0(1);
  public static int int_2 = Class15.smethod_0(2);
  public const sbyte sbyte_0 = 4;
  public const sbyte sbyte_1 = 5;
  public const sbyte sbyte_2 = 6;
  private int int_3;
  public const sbyte sbyte_3 = 3;
  private int int_4;
  private int int_5;
  private int int_6;
  private int int_7;
  public int max;
  private int int_8;
  private int int_9;
  private long long_0;
  private long long_1;
  private bool bool_7;
  public static int int_10;
  public static int int_11;
  public static bool bool_8;
  public static bool bool_9 = Class15.smethod_0(1) != 0;
  public static bool bool_10;
  private Vector2 vector2_0;
  public static int int_12 = Class15.smethod_0(1);
  public static bool bool_11 = Class15.smethod_0(1) != 0;

  private void Start()
  {
    if ((!Main.bool_0 ? 1 : 0) == 0)
      return;
    Time.timeScale = Class15.smethod_2(17);
    if ((!(Thread.CurrentThread.Name != Class13.smethod_0(159039)) ? 1 : 0) == 0)
      Thread.CurrentThread.Name = Class13.smethod_0(159039);
    Main.string_1 = Thread.CurrentThread.Name;
    Main.bool_3 = Class15.smethod_0(1) != 0;
    Main.bool_0 = Class15.smethod_0(1) != 0;
    if ((!Main.bool_3 ? 1 : 0) != 0)
      return;
    this.int_3 = GClass152.smethod_8(Class13.smethod_0(159032));
    if (this.int_3 == Class15.smethod_0(1))
      Screen.SetResolution(Class15.smethod_0(420), Class15.smethod_0(197), Class15.smethod_0(0) != 0);
    else
      Screen.SetResolution(Class15.smethod_0(246), Class15.smethod_0(30), Class15.smethod_0(0) != 0);
  }

  private void method_0() => this.enabled = Class15.smethod_0(1) != 0;

  private void method_1(bool bool_12)
  {
    if ((!bool_12 ? 0 : 1) == 0)
      Time.timeScale = Class15.smethod_2(0);
    else
      Time.timeScale = Class15.smethod_2(16);
  }

  private void OnGUI()
  {
    if (this.int_6 < Class15.smethod_0(31))
      return;
    if ((this.int_7 == 0 ? 0 : 1) == 0)
      this.long_0 = GClass126.smethod_18();
    else if (GClass126.smethod_18() - this.long_0 > (long) Class15.smethod_0(15))
    {
      this.max = this.int_7;
      this.int_7 = Class15.smethod_0(0);
      this.long_0 = GClass126.smethod_18();
    }
    this.int_7 += Class15.smethod_0(1);
    this.method_5();
    GClass157.smethod_5();
    GClass159.smethod_5();
    if ((!Event.current.type.Equals((object) (EventType) Class15.smethod_0(38)) ? 1 : 0) != 0 || this.int_5 > this.int_4)
      return;
    GClass63.gclass62_0.method_20(Main.gclass98_0);
    this.int_5 += Class15.smethod_0(1);
    Main.gclass98_0.method_38();
  }

  public void method_2()
  {
    if ((!this.bool_7 ? 0 : 1) != 0)
      return;
    Screen.orientation = (ScreenOrientation) Class15.smethod_0(5);
    Application.runInBackground = Class15.smethod_0(1) != 0;
    Application.targetFrameRate = Class15.smethod_0(4);
    this.useGUILayout = Class15.smethod_0(0) != 0;
    Main.bool_11 = Main.smethod_3();
    if ((!((Object) Main.main_0 == (Object) null) ? 1 : 0) == 0)
      Main.main_0 = this;
    this.bool_7 = Class15.smethod_0(1) != 0;
    GClass153.smethod_0();
    Main.string_2 = (!Main.bool_3 ? 1 : 0) != 0 ? this.method_3() : SystemInfo.deviceUniqueIdentifier;
    Main.bool_3 = Class15.smethod_0(1) != 0;
    if ((!Main.bool_3 ? 1 : 0) == 0)
      Screen.fullScreen = Class15.smethod_0(0) != 0;
    if ((!Main.bool_4 ? 1 : 0) == 0)
      Main.int_2 = Class15.smethod_0(37);
    if ((!Main.bool_3 ? 1 : 0) == 0)
      Main.int_2 = Class15.smethod_0(2);
    if ((!Main.bool_6 ? 1 : 0) == 0)
      Main.int_2 = Class15.smethod_0(3);
    if (GClass78.iPhoneGeneration_0 == (iPhoneGeneration) Class15.smethod_0(45))
      Main.bool_1 = Class15.smethod_0(1) != 0;
    if (GClass78.iPhoneGeneration_0 == (iPhoneGeneration) Class15.smethod_0(88))
      Main.bool_2 = Class15.smethod_0(1) != 0;
    Main.gclass98_0 = new GClass98();
    Main.gclass63_0 = new GClass63();
    GClass185.smethod_0();
    GClass140.smethod_0();
    GClass148.smethod_0();
    GClass116.smethod_2();
    GClass73.smethod_0().method_0();
    GClass141.smethod_0();
    GClass95.smethod_0();
    GClass88.smethod_0();
    GClass172.smethod_1().method_0(GClass185.int_37);
    Main.gclass98_0.method_44();
  }

  public static void smethod_0(string path)
  {
  }

  public string method_3()
  {
    NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
    for (int index = Class15.smethod_0(0); index < networkInterfaces.Length; index += Class15.smethod_0(1))
    {
      PhysicalAddress physicalAddress = networkInterfaces[index].GetPhysicalAddress();
      if ((!(physicalAddress.ToString() != string.Empty) ? 1 : 0) == 0)
        return physicalAddress.ToString();
    }
    return string.Empty;
  }

  public void method_4()
  {
    if ((!Main.bool_3 ? 1 : 0) != 0 || GClass152.smethod_8(Class13.smethod_0(153485)) == GClass98.int_8)
      return;
    GClass152.smethod_13();
    GClass152.smethod_9(Class13.smethod_0(153485), GClass98.int_8);
    GClass152.smethod_9(Class13.smethod_0(153593), this.int_3);
  }

  public static void smethod_1()
  {
    if ((!GClass188.bool_1 ? 1 : 0) != 0)
      return;
    GClass184.gclass188_0.active = Class15.smethod_0(0) != 0;
    GClass184.gclass188_0 = (GClass188) null;
  }

  private void FixedUpdate()
  {
    GClass152.smethod_7();
    this.int_6 += Class15.smethod_0(1);
    if (this.int_6 < Class15.smethod_0(31))
      return;
    if ((this.int_8 == 0 ? 0 : 1) == 0)
      this.long_1 = GClass126.smethod_18();
    else if (GClass126.smethod_18() - this.long_1 > (long) Class15.smethod_0(15))
    {
      this.int_9 = this.int_8;
      this.int_8 = Class15.smethod_0(0);
      this.long_1 = GClass126.smethod_18();
    }
    this.int_8 += Class15.smethod_0(1);
    this.method_2();
    this.int_4 += Class15.smethod_0(1);
    GClass79.smethod_1();
    GClass63.gclass62_0.method_2();
    GClass66.smethod_11();
    GClass35.smethod_0();
    GClass170.smethod_3();
    Class3.smethod_0();
    Main.int_11 += Class15.smethod_0(1);
    if (Main.int_11 > Class15.smethod_0(88))
      Main.int_11 = Class15.smethod_0(0);
    if ((!Main.bool_3 ? 0 : 1) != 0)
      return;
    int num = Class15.smethod_0(1) / Main.int_12;
  }

  private void Update()
  {
  }

  private void method_5()
  {
    if ((!Input.GetMouseButtonDown(Class15.smethod_0(0)) ? 1 : 0) == 0)
    {
      Vector3 mousePosition = Input.mousePosition;
      GClass63.gclass62_0.method_17((int) ((double) mousePosition.x / (double) GClass98.int_8), (int) (((double) Screen.height - (double) mousePosition.y) / (double) GClass98.int_8) + GClass98.int_20);
      this.vector2_0.x = mousePosition.x / (float) GClass98.int_8;
      this.vector2_0.y = mousePosition.y / (float) GClass98.int_8 + (float) GClass98.int_20;
    }
    if ((!Input.GetMouseButton(Class15.smethod_0(0)) ? 1 : 0) == 0)
    {
      Vector3 mousePosition = Input.mousePosition;
      GClass63.gclass62_0.method_16((int) ((double) mousePosition.x / (double) GClass98.int_8), (int) (((double) Screen.height - (double) mousePosition.y) / (double) GClass98.int_8) + GClass98.int_20);
      this.vector2_0.x = mousePosition.x / (float) GClass98.int_8;
      this.vector2_0.y = mousePosition.y / (float) GClass98.int_8 + (float) GClass98.int_20;
    }
    if ((!Input.GetMouseButtonUp(Class15.smethod_0(0)) ? 1 : 0) == 0)
    {
      Vector3 mousePosition = Input.mousePosition;
      this.vector2_0.x = mousePosition.x / (float) GClass98.int_8;
      this.vector2_0.y = mousePosition.y / (float) GClass98.int_8 + (float) GClass98.int_20;
      GClass63.gclass62_0.method_18((int) ((double) mousePosition.x / (double) GClass98.int_8), (int) (((double) Screen.height - (double) mousePosition.y) / (double) GClass98.int_8) + GClass98.int_20);
    }
    if ((!Input.anyKeyDown ? 1 : 0) == 0 && Event.current.type == (EventType) Class15.smethod_0(2))
    {
      int keyCode1 = GClass129.smethod_0(Event.current.keyCode);
      if ((!Input.GetKey((KeyCode) Class15.smethod_0(421)) ? 0 : 1) != 0 || (!Input.GetKey((KeyCode) Class15.smethod_0(422)) ? 1 : 0) == 0)
      {
        KeyCode keyCode2 = Event.current.keyCode;
        if (keyCode2 != (KeyCode) Class15.smethod_0(70))
        {
          if (keyCode2 == (KeyCode) Class15.smethod_0(32))
            keyCode1 = Class15.smethod_0(199);
        }
        else
          keyCode1 = Class15.smethod_0(101);
      }
      if ((keyCode1 == 0 ? 1 : 0) == 0)
        GClass63.gclass62_0.method_10(keyCode1);
    }
    if (Event.current.type == (EventType) Class15.smethod_0(3))
    {
      int keyCode = GClass129.smethod_0(Event.current.keyCode);
      if ((keyCode == 0 ? 1 : 0) == 0)
        GClass63.gclass62_0.method_12(keyCode);
    }
    if ((!Main.bool_3 ? 1 : 0) != 0)
      return;
    GClass63.gclass62_0.method_15((int) ((double) Input.GetAxis(Class13.smethod_0(153860)) * (double) Class15.smethod_2(9)));
    double x1 = (double) Input.mousePosition.x;
    float y1 = Input.mousePosition.y;
    int x2 = (int) x1 / GClass98.int_8;
    int y2 = (Screen.height - (int) y1) / GClass98.int_8;
    GClass63.gclass62_0.method_14(x2, y2);
  }

  private void OnApplicationQuit()
  {
    Debug.LogWarning((object) Class13.smethod_0(153921));
    GClass62.bool_10 = Class15.smethod_0(0) != 0;
    GClass157.smethod_0().imethod_4();
    GClass159.smethod_0().imethod_4();
    if ((!Main.bool_3 ? 1 : 0) != 0)
      return;
    Application.Quit();
  }

  private void OnApplicationPause(bool bool_12)
  {
    Main.bool_8 = Class15.smethod_0(0) != 0;
    if ((!bool_12 ? 1 : 0) == 0)
    {
      if ((!GClass62.smethod_3() ? 1 : 0) == 0)
        Main.bool_10 = Class15.smethod_0(1) != 0;
    }
    else
      Main.bool_8 = Class15.smethod_0(1) != 0;
    if ((!GClass188.bool_1 ? 1 : 0) == 0)
    {
      GClass184.gclass188_0.active = Class15.smethod_0(0) != 0;
      GClass184.gclass188_0 = (GClass188) null;
    }
    if ((!Main.bool_10 ? 1 : 0) != 0)
      return;
    Application.Quit();
  }

  public static void smethod_2()
  {
    if ((!Main.bool_3 ? 1 : 0) == 0)
      Main.main_0.OnApplicationQuit();
    else
      Main.int_12 = Class15.smethod_0(0);
  }

  public static bool smethod_3() => GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(1) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(7) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(2) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(3) ? Class15.smethod_0(1) != 0 : Class15.smethod_0(0) != 0;

  public static bool smethod_4() => GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(5) && GClass78.iPhoneGeneration_0 != (iPhoneGeneration) Class15.smethod_0(88) && GClass78.iPhoneGeneration_0 <= (iPhoneGeneration) Class15.smethod_0(45) ? Class15.smethod_0(0) != 0 : Class15.smethod_0(1) != 0;
}
