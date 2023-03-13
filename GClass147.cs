// Decompiled with JetBrains decompiler
// Type: GClass147
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass147
{
  public byte type;
  public int x;
  public int y;
  public int g;
  public int v;
  public int vMax;
  public int w;
  public int h;
  public int color;
  public int limitY;
  public int vx;
  public int vy;
  public int x2;
  public int y2;
  public int toX;
  public int toY;
  public int dis;
  public int f;
  public int ftam;
  public int fRe;
  public int frame;
  public int maxframe;
  public int fSmall;
  public int goc;
  public int gocT_Arc;
  public int idir;
  public int dirThrow;
  public int dir;
  public int dir_nguoc;
  public int idSkill;
  public int id;
  public int levelPaint;
  public int num_per_frame = Class15.smethod_0(1);
  public int life;
  public int goc_Arc;
  public int vx1000;
  public int vy1000;
  public int va;
  public int x1000;
  public int y1000;
  public int vX1000;
  public int vY1000;
  public long time;
  public long timecount;
  public GClass134 vecEffPoint;
  public string name;
  public string info;
  public bool isRemove;
  public bool isSmall;
  public bool isPaint;
  public bool isChange;
  public static GClass60[] gclass60_0;
  public GClass60 fraImgEff;

  public GClass147()
  {
  }

  public GClass147(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public GClass147(int x, int y, int goc)
  {
    this.x = x;
    this.y = y;
    this.goc = goc;
  }

  public void method_0()
  {
    this.f += Class15.smethod_0(1);
    this.x += this.vx;
    this.y += this.vy;
  }

  public void method_1()
  {
    this.x += this.vx;
    this.y += this.vy;
  }

  public void method_2(GClass98 g)
  {
    if ((!this.isRemove ? 0 : 1) != 0)
      return;
    int num = Class15.smethod_0(0);
    if ((!this.isSmall ? 1 : 0) == 0 && this.f >= this.fSmall)
      num = Class15.smethod_0(1);
    GClass147.gclass60_0[this.color].method_0(this.frame / Class15.smethod_0(7) + num, this.x, this.y, this.dis, Class15.smethod_0(5), g);
  }

  public void method_3()
  {
    this.f += Class15.smethod_0(1);
    if (this.maxframe > Class15.smethod_0(1))
    {
      this.frame += Class15.smethod_0(1);
      if (this.frame / Class15.smethod_0(7) >= this.maxframe)
        this.frame = Class15.smethod_0(0);
    }
    if (this.f < this.fRe)
      return;
    this.isRemove = Class15.smethod_0(1) != 0;
  }
}
