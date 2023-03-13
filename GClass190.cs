// Decompiled with JetBrains decompiler
// Type: GClass190
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass190 : GInterface0
{
  public short minX;
  public short minY;
  public short maxX;
  public short maxY;
  public bool isEnter;
  public bool isOffline;
  public GClass148 popup;

  public GClass190(
    short minX,
    short minY,
    short maxX,
    short maxY,
    bool isEnter,
    bool isOffline,
    string name)
  {
    this.minX = minX;
    this.minY = minY;
    this.maxX = maxX;
    this.maxY = maxY;
    name = GClass151.smethod_14(name);
    this.isEnter = isEnter;
    this.isOffline = isOffline;
    if ((GClass185.int_37 == Class15.smethod_0(27) || GClass185.int_37 == Class15.smethod_0(28) || GClass185.int_37 == Class15.smethod_0(29)) && (int) this.minX >= Class15.smethod_0(0) && (int) this.minX <= Class15.smethod_0(40) || ((((GClass185.int_37 == 0 ? 0 : 1) == 0 && (GClass20.smethod_1().cgender == 0 ? 0 : 1) != 0 || GClass185.int_37 == Class15.smethod_0(38) && GClass20.smethod_1().cgender != Class15.smethod_0(1) ? Class15.smethod_0(1) : (GClass185.int_37 != Class15.smethod_0(49) ? Class15.smethod_0(0) : ((GClass20.smethod_1().cgender == Class15.smethod_0(7) ? 1 : 0) == Class15.smethod_0(0) ? 1 : 0))) & (isOffline ? 1 : 0)) == 0 ? 1 : 0) == 0)
      return;
    if ((!GClass185.smethod_14() ? 0 : 1) == 0 && GClass185.int_37 != Class15.smethod_0(43))
    {
      if ((!isEnter ? 0 : 1) == 0 && (!isOffline ? 0 : 1) == 0)
      {
        this.popup = new GClass148(name, (int) minX, (int) minY - Class15.smethod_0(40));
        this.popup.command = new GClass31((string) null, (GInterface0) this, Class15.smethod_0(1), (object) this);
        this.popup.isWayPoint = Class15.smethod_0(1) != 0;
        this.popup.isPaint = Class15.smethod_0(0) != 0;
        GClass148.smethod_2(this.popup);
      }
      else
      {
        if ((!GClass185.smethod_2() ? 1 : 0) == 0)
        {
          this.popup = new GClass148(name, (int) minX, (int) minY - Class15.smethod_0(10));
        }
        else
        {
          int x = (int) minX + ((int) maxX - (int) minX) / Class15.smethod_0(7);
          this.popup = new GClass148(name, x, (int) minY - ((minY == (short) 0 ? 1 : 0) != 0 ? Class15.smethod_0(599) : Class15.smethod_0(10)));
        }
        this.popup.command = new GClass31((string) null, (GInterface0) this, Class15.smethod_0(7), (object) this);
        this.popup.isWayPoint = Class15.smethod_0(1) != 0;
        this.popup.isPaint = Class15.smethod_0(0) != 0;
        GClass148.smethod_2(this.popup);
      }
      GClass185.gclass134_0.method_0((object) this);
    }
    else
    {
      if ((int) minY > Class15.smethod_0(19) && (!GClass185.smethod_14() ? 0 : 1) != 0)
        return;
      this.popup = new GClass148(name, (int) minX + ((int) maxX - (int) minX) / Class15.smethod_0(7), (int) maxY - ((int) minX <= Class15.smethod_0(21) ? Class15.smethod_0(154) : Class15.smethod_0(40)));
      this.popup.command = new GClass31((string) null, (GInterface0) this, Class15.smethod_0(1), (object) this);
      this.popup.isWayPoint = Class15.smethod_0(1) != 0;
      this.popup.isPaint = Class15.smethod_0(0) != 0;
      GClass148.smethod_2(this.popup);
      GClass185.gclass134_0.method_0((object) this);
    }
  }

  public void imethod_0(int idAction, object p)
  {
    if (idAction != Class15.smethod_0(1))
    {
      if (idAction != Class15.smethod_0(7))
        return;
      GClass116.smethod_6().auto = Class15.smethod_0(0);
      if ((GClass20.smethod_1().method_13() == null ? 1 : 0) == 0)
      {
        GClass156.smethod_0().method_45();
        GClass71.smethod_1();
        GClass156.smethod_0().method_115();
        GClass20.bool_2 = Class15.smethod_0(1) != 0;
      }
      else if ((GClass20.smethod_1().method_14() == null ? 1 : 0) == 0)
      {
        GClass156.smethod_0().method_45();
        GClass156.smethod_0().method_41();
        GClass20.bool_3 = Class15.smethod_0(1) != 0;
        GClass20.bool_2 = Class15.smethod_0(1) != 0;
        GClass62.smethod_25();
        GClass62.smethod_24();
        GClass71.smethod_1();
      }
      else
      {
        int xEnd = ((int) this.minX + (int) this.maxX) / Class15.smethod_0(7);
        int maxY = (int) this.maxY;
        GClass20.smethod_1().currentMovePoint = new GClass108(xEnd, maxY);
        GClass20.smethod_1().cdir = GClass20.smethod_1().cx - GClass20.smethod_1().currentMovePoint.xEnd <= Class15.smethod_0(0) ? Class15.smethod_0(1) : -1;
        GClass20.smethod_1().endMovePointCommand = new GClass31((string) null, (GInterface0) this, Class15.smethod_0(7), (object) null);
      }
    }
    else
    {
      int xEnd = ((int) this.minX + (int) this.maxX) / Class15.smethod_0(7);
      int yEnd = (int) this.maxY;
      if ((int) this.maxY > (int) this.minY + Class15.smethod_0(40))
        yEnd = ((int) this.minY + (int) this.maxY) / Class15.smethod_0(7);
      GClass116.smethod_6().auto = Class15.smethod_0(0);
      GClass20.smethod_1().currentMovePoint = new GClass108(xEnd, yEnd);
      GClass20.smethod_1().cdir = GClass20.smethod_1().cx - GClass20.smethod_1().currentMovePoint.xEnd <= Class15.smethod_0(0) ? Class15.smethod_0(1) : -1;
      GClass156.smethod_0().method_45();
    }
  }
}
