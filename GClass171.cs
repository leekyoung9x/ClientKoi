// Decompiled with JetBrains decompiler
// Type: GClass171
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System.Threading;
using UnityEngine;

public class GClass171
{
  private const int int_0 = 5;
  private const int int_1 = 100;
  public static int int_2;
  public static int int_3;
  public static int int_4;
  private static string string_0;
  private static float float_0;
  public static bool bool_0 = Class15.smethod_0(1) != 0;
  public static bool bool_1;
  public static bool bool_2;
  public static AudioSource audioSource_0;
  public static AudioSource audioSource_1;
  public static AudioSource audioSource_2;
  public static AudioClip[] audioClip_0;
  public static GameObject[] gameObject_0;
  public static string[] string_1;
  public static sbyte sbyte_0;
  public static sbyte sbyte_1;
  public static sbyte sbyte_2;
  public static sbyte sbyte_3;
  public static sbyte sbyte_4;
  public static sbyte sbyte_5;
  public static sbyte sbyte_6;
  public static sbyte sbyte_7;
  public static sbyte sbyte_8;
  public static sbyte sbyte_9;
  public static sbyte sbyte_10;
  public static sbyte sbyte_11;
  public static sbyte sbyte_12;
  public static sbyte sbyte_13;
  public static sbyte sbyte_14;
  public static sbyte sbyte_15;
  public static sbyte sbyte_16;
  public static sbyte sbyte_17;
  public static sbyte sbyte_18;
  public static sbyte sbyte_19;
  public static sbyte sbyte_20;
  public static sbyte sbyte_21;
  public static sbyte sbyte_22;
  public static sbyte sbyte_23;
  public static sbyte sbyte_24;
  public static sbyte sbyte_25;
  public static sbyte sbyte_26;
  public static sbyte sbyte_27;
  public static sbyte sbyte_28;
  public static sbyte sbyte_29;
  public static sbyte sbyte_30;
  public static sbyte sbyte_31;
  public static sbyte sbyte_32;
  public static sbyte sbyte_33;
  public static int int_5;

  public static void smethod_0(GClass172.GClass175 ac)
  {
  }

  public static void smethod_1()
  {
    for (int index = Class15.smethod_0(0); index < GClass171.gameObject_0.Length; index += Class15.smethod_0(1))
    {
      if ((!((Object) GClass171.gameObject_0[index] != (Object) null) ? 1 : 0) == 0)
        GClass171.gameObject_0[index].GetComponent<AudioSource>().Pause();
    }
  }

  public static bool smethod_2() => Class15.smethod_0(0) != 0;

  public static void smethod_3()
  {
    GameObject gameObject = new GameObject();
    gameObject.name = Class13.smethod_0(143764);
    gameObject.transform.position = Vector3.zero;
    gameObject.AddComponent<AudioListener>();
    GClass171.audioSource_2 = gameObject.AddComponent<AudioSource>();
  }

  public static void smethod_4(int[] musicID, int[] sID)
  {
    if ((GClass171.gameObject_0 == null ? 0 : 1) != 0 || (GClass171.audioClip_0 == null ? 0 : 1) != 0)
      return;
    GClass171.smethod_3();
    GClass171.int_5 = musicID.Length;
    GClass171.gameObject_0 = new GameObject[musicID.Length + sID.Length];
    GClass171.audioClip_0 = new AudioClip[musicID.Length + sID.Length];
    for (int pos = Class15.smethod_0(0); pos < GClass171.gameObject_0.Length; pos += Class15.smethod_0(1))
      GClass171.smethod_7(pos >= GClass171.int_5 ? Class13.smethod_0(143869) + (pos - GClass171.int_5).ToString() : Class13.smethod_0(143749) + pos.ToString(), pos);
  }

  public static void smethod_5(int id, float volume) => GClass171.smethod_12(id + GClass171.int_5, volume);

  public static void smethod_6(int id, float volume) => GClass171.smethod_12(id, volume);

  public static void smethod_7(string fileName, int pos)
  {
    GClass171.smethod_29(pos);
    GClass171.smethod_23(Main.string_0 + fileName, pos);
  }

  public static void smethod_8()
  {
    for (int pos = Class15.smethod_0(0); pos < GClass171.audioClip_0.Length; pos += Class15.smethod_0(1))
      GClass171.smethod_29(pos);
    for (int id = Class15.smethod_0(0); id < GClass171.int_5; id += Class15.smethod_0(1))
      GClass171.smethod_21(id);
  }

  public static void smethod_9()
  {
    for (int pos = Class15.smethod_0(0); pos < GClass171.audioClip_0.Length; pos += Class15.smethod_0(1))
      GClass171.smethod_29(pos);
    GClass171.smethod_21(Class15.smethod_0(0));
    GClass171.smethod_14();
    GClass171.smethod_17(Class15.smethod_0(0));
  }

  public static void smethod_10()
  {
  }

  public static void smethod_11(int x)
  {
    if ((!GClass62.bool_21 ? 1 : 0) != 0)
      return;
    GClass171.smethod_29(x);
  }

  public static void smethod_12(int id, float volume)
  {
    if ((!GClass171.bool_1 ? 0 : 1) != 0 || (!GClass62.bool_21 ? 1 : 0) != 0)
      return;
    GClass171.smethod_26(volume, id);
  }

  public static void smethod_13(int id, float volume)
  {
    if ((!GClass62.bool_21 ? 1 : 0) != 0 || (!((Object) GClass171.audioSource_1 == (Object) null) ? 0 : 1) != 0)
      return;
    GClass171.audioSource_1.GetComponent<AudioSource>().loop = Class15.smethod_0(1) != 0;
    GClass171.audioSource_1.GetComponent<AudioSource>().clip = GClass171.audioClip_0[id];
    GClass171.audioSource_1.GetComponent<AudioSource>().volume = volume;
    GClass171.audioSource_1.GetComponent<AudioSource>().Play();
  }

  public static void smethod_14() => GClass171.audioSource_1.GetComponent<AudioSource>().Stop();

  public static bool smethod_15() => (!((Object) GClass171.audioSource_1 == (Object) null) ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : GClass171.audioSource_1.GetComponent<AudioSource>().isPlaying;

  public static void smethod_16(int id, float volume, bool isLoop)
  {
    if ((!GClass62.bool_21 ? 1 : 0) != 0 || (!((Object) GClass171.audioSource_2 == (Object) null) ? 0 : 1) != 0)
      return;
    GClass171.audioSource_0.GetComponent<AudioSource>().loop = isLoop;
    GClass171.audioSource_0.GetComponent<AudioSource>().clip = GClass171.audioClip_0[id];
    GClass171.audioSource_0.GetComponent<AudioSource>().volume = volume;
    GClass171.audioSource_0.GetComponent<AudioSource>().Play();
  }

  public static void smethod_17(int id) => GClass171.audioSource_0.GetComponent<AudioSource>().Stop();

  public static bool smethod_18(int id) => (!((Object) GClass171.audioSource_0 == (Object) null) ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : GClass171.audioSource_0.GetComponent<AudioSource>().isPlaying;

  public static void smethod_19(int type, float vl, bool loop)
  {
    if ((!GClass171.bool_1 ? 0 : 1) != 0)
      return;
    vl -= Class15.smethod_2(10);
    if ((double) vl <= (double) Class15.smethod_2(0))
      vl = Class15.smethod_2(32);
    GClass171.smethod_20(type, vl);
  }

  public static void smethod_20(int id, float volume)
  {
    if ((!GClass62.bool_21 ? 1 : 0) != 0)
      return;
    if (id == GClass172.int_2)
    {
      GClass171.smethod_6(id, volume + Class15.smethod_2(13));
    }
    else
    {
      if ((!((Object) GClass171.audioSource_2 == (Object) null) ? 0 : 1) != 0 || (!GClass171.smethod_22(id) ? 0 : 1) != 0)
        return;
      GClass171.audioSource_2.GetComponent<AudioSource>().loop = Class15.smethod_0(1) != 0;
      GClass171.audioSource_2.GetComponent<AudioSource>().clip = GClass171.audioClip_0[id];
      GClass171.audioSource_2.GetComponent<AudioSource>().volume = volume;
      GClass171.audioSource_2.GetComponent<AudioSource>().Play();
    }
  }

  public static void smethod_21(int id) => GClass171.audioSource_2.GetComponent<AudioSource>().Stop();

  public static bool smethod_22(int id) => (!((Object) GClass171.audioSource_2 == (Object) null) ? 1 : 0) == 0 ? Class15.smethod_0(0) != 0 : GClass171.audioSource_2.GetComponent<AudioSource>().isPlaying;

  public static void smethod_23(string filename, int pos)
  {
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0)
      GClass171.smethod_25(filename, pos);
    else
      GClass171.smethod_24(filename, pos);
  }

  private static void smethod_24(string string_2, int int_6)
  {
    if ((GClass171.int_2 == 0 ? 1 : 0) == 0)
    {
      GClass33.smethod_2(Class13.smethod_0(143842) + string_2 + Class13.smethod_0(143818) + GClass171.string_0);
    }
    else
    {
      GClass171.string_0 = string_2;
      GClass171.int_3 = int_6;
      GClass171.int_2 = Class15.smethod_0(7);
      int num;
      for (num = Class15.smethod_0(0); num < Class15.smethod_0(21); num += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass171.int_2 == 0 ? 1 : 0) != 0)
          break;
      }
      if (num == Class15.smethod_0(21))
      {
        GClass33.smethod_2(Class13.smethod_0(143419) + string_2);
      }
      else
      {
        string[] strArray = new string[Class15.smethod_0(3)];
        strArray[Class15.smethod_0(0)] = Class13.smethod_0(143394);
        strArray[Class15.smethod_0(1)] = string_2;
        strArray[Class15.smethod_0(7)] = Class13.smethod_0(143382);
        strArray[Class15.smethod_0(5)] = (num * Class15.smethod_0(3)).ToString();
        strArray[Class15.smethod_0(2)] = Class13.smethod_0(143372);
        GClass33.smethod_1(string.Concat(strArray));
      }
    }
  }

  private static void smethod_25(string string_2, int int_6)
  {
    GClass171.audioClip_0[int_6] = (AudioClip) Resources.Load(string_2, typeof (AudioClip));
    GameObject.Find(Class13.smethod_0(143485)).AddComponent<AudioSource>();
    GClass171.gameObject_0[int_6] = GameObject.Find(Class13.smethod_0(143485));
  }

  public static void smethod_26(float volume, int pos)
  {
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0)
      GClass171.smethod_28(volume, pos);
    else
      GClass171.smethod_27(volume, pos);
  }

  public static void smethod_27(float volume, int pos)
  {
    if ((GClass171.int_2 == 0 ? 1 : 0) == 0)
    {
      Debug.LogError((object) Class13.smethod_0(143465));
    }
    else
    {
      GClass171.float_0 = volume;
      GClass171.int_3 = pos;
      GClass171.int_2 = Class15.smethod_0(5);
      int num;
      for (num = Class15.smethod_0(0); num < Class15.smethod_0(21); num += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass171.int_2 == 0 ? 1 : 0) != 0)
          break;
      }
      if (num == Class15.smethod_0(21))
        Debug.LogError((object) Class13.smethod_0(143425));
      else
        Debug.Log((object) (Class13.smethod_0(143509) + (num * Class15.smethod_0(3)).ToString() + Class13.smethod_0(143596)));
    }
  }

  public static void smethod_28(float volume, int pos)
  {
    if ((!((Object) GClass171.gameObject_0[pos] == (Object) null) ? 0 : 1) != 0)
      return;
    GClass171.gameObject_0[pos].GetComponent<AudioSource>().PlayOneShot(GClass171.audioClip_0[pos], volume);
  }

  public static void smethod_29(int pos)
  {
    if ((!(Thread.CurrentThread.Name == Main.string_1) ? 1 : 0) == 0)
      GClass171.smethod_31(pos);
    else
      GClass171.smethod_30(pos);
  }

  public static void smethod_30(int pos)
  {
    if ((GClass171.int_2 == 0 ? 1 : 0) == 0)
    {
      Debug.LogError((object) Class13.smethod_0(143588));
    }
    else
    {
      GClass171.int_3 = pos;
      GClass171.int_2 = Class15.smethod_0(2);
      int num;
      for (num = Class15.smethod_0(0); num < Class15.smethod_0(21); num += Class15.smethod_0(1))
      {
        Thread.Sleep(Class15.smethod_0(3));
        if ((GClass171.int_2 == 0 ? 1 : 0) != 0)
          break;
      }
      if (num == Class15.smethod_0(21))
        Debug.LogError((object) Class13.smethod_0(144190));
      else
        Debug.Log((object) (Class13.smethod_0(144155) + (num * Class15.smethod_0(3)).ToString() + Class13.smethod_0(144251)));
    }
  }

  public static void smethod_31(int pos)
  {
    if ((!((Object) GClass171.gameObject_0[pos] != (Object) null) ? 1 : 0) != 0)
      return;
    GClass171.gameObject_0[pos].GetComponent<AudioSource>().Stop();
  }

  static GClass171()
  {
    string[] strArray = new string[Class15.smethod_0(117)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(144248);
    strArray[Class15.smethod_0(1)] = Class13.smethod_0(145971);
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(145967);
    strArray[Class15.smethod_0(5)] = Class13.smethod_0(145965);
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(145944);
    strArray[Class15.smethod_0(3)] = Class13.smethod_0(146090);
    strArray[Class15.smethod_0(37)] = Class13.smethod_0(146088);
    strArray[Class15.smethod_0(38)] = Class13.smethod_0(146086);
    strArray[Class15.smethod_0(88)] = Class13.smethod_0(146061);
    strArray[Class15.smethod_0(45)] = Class13.smethod_0(146152);
    strArray[Class15.smethod_0(31)] = Class13.smethod_0(147420);
    strArray[Class15.smethod_0(67)] = Class13.smethod_0(147413);
    strArray[Class15.smethod_0(66)] = Class13.smethod_0(146955);
    strArray[Class15.smethod_0(47)] = Class13.smethod_0(146952);
    strArray[Class15.smethod_0(49)] = Class13.smethod_0(139539);
    strArray[Class15.smethod_0(9)] = Class13.smethod_0(139638);
    strArray[Class15.smethod_0(10)] = Class13.smethod_0(139635);
    strArray[Class15.smethod_0(186)] = Class13.smethod_0(139632);
    strArray[Class15.smethod_0(124)] = Class13.smethod_0(139629);
    strArray[Class15.smethod_0(65)] = Class13.smethod_0(139670);
    strArray[Class15.smethod_0(51)] = Class13.smethod_0(139667);
    strArray[Class15.smethod_0(27)] = Class13.smethod_0(139664);
    strArray[Class15.smethod_0(28)] = Class13.smethod_0(139661);
    strArray[Class15.smethod_0(29)] = Class13.smethod_0(139658);
    strArray[Class15.smethod_0(40)] = Class13.smethod_0(139655);
    strArray[Class15.smethod_0(46)] = Class13.smethod_0(139652);
    strArray[Class15.smethod_0(50)] = Class13.smethod_0(139649);
    strArray[Class15.smethod_0(33)] = Class13.smethod_0(139774);
    strArray[Class15.smethod_0(35)] = Class13.smethod_0(139771);
    strArray[Class15.smethod_0(36)] = Class13.smethod_0(139667);
    strArray[Class15.smethod_0(6)] = Class13.smethod_0(139768);
    strArray[Class15.smethod_0(8)] = Class13.smethod_0(139746);
    strArray[Class15.smethod_0(120)] = Class13.smethod_0(139743);
    strArray[Class15.smethod_0(48)] = Class13.smethod_0(139740);
    GClass171.string_1 = strArray;
    GClass171.sbyte_0 = (sbyte) Class15.smethod_0(0);
    GClass171.sbyte_1 = (sbyte) Class15.smethod_0(1);
    GClass171.sbyte_2 = (sbyte) Class15.smethod_0(7);
    GClass171.sbyte_3 = (sbyte) Class15.smethod_0(5);
    GClass171.sbyte_4 = (sbyte) Class15.smethod_0(2);
    GClass171.sbyte_5 = (sbyte) Class15.smethod_0(3);
    GClass171.sbyte_6 = (sbyte) Class15.smethod_0(37);
    GClass171.sbyte_7 = (sbyte) Class15.smethod_0(38);
    GClass171.sbyte_8 = (sbyte) Class15.smethod_0(88);
    GClass171.sbyte_9 = (sbyte) Class15.smethod_0(45);
    GClass171.sbyte_10 = (sbyte) Class15.smethod_0(31);
    GClass171.sbyte_11 = (sbyte) Class15.smethod_0(67);
    GClass171.sbyte_12 = (sbyte) Class15.smethod_0(66);
    GClass171.sbyte_13 = (sbyte) Class15.smethod_0(47);
    GClass171.sbyte_14 = (sbyte) Class15.smethod_0(49);
    GClass171.sbyte_15 = (sbyte) Class15.smethod_0(9);
    GClass171.sbyte_16 = (sbyte) Class15.smethod_0(10);
    GClass171.sbyte_17 = (sbyte) Class15.smethod_0(186);
    GClass171.sbyte_18 = (sbyte) Class15.smethod_0(124);
    GClass171.sbyte_19 = (sbyte) Class15.smethod_0(65);
    GClass171.sbyte_20 = (sbyte) Class15.smethod_0(51);
    GClass171.sbyte_21 = (sbyte) Class15.smethod_0(27);
    GClass171.sbyte_22 = (sbyte) Class15.smethod_0(28);
    GClass171.sbyte_23 = (sbyte) Class15.smethod_0(29);
    GClass171.sbyte_24 = (sbyte) Class15.smethod_0(40);
    GClass171.sbyte_25 = (sbyte) Class15.smethod_0(46);
    GClass171.sbyte_26 = (sbyte) Class15.smethod_0(50);
    GClass171.sbyte_27 = (sbyte) Class15.smethod_0(33);
    GClass171.sbyte_28 = (sbyte) Class15.smethod_0(35);
    GClass171.sbyte_29 = (sbyte) Class15.smethod_0(36);
    GClass171.sbyte_30 = (sbyte) Class15.smethod_0(6);
    GClass171.sbyte_31 = (sbyte) Class15.smethod_0(8);
    GClass171.sbyte_32 = (sbyte) Class15.smethod_0(120);
    GClass171.sbyte_33 = (sbyte) Class15.smethod_0(48);
  }
}
