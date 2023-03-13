// Decompiled with JetBrains decompiler
// Type: GClass154
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

public class GClass154
{
  public int cmtoX;
  public int cmtoY;
  public int cmx;
  public int cmy;
  public int cmvx;
  public int cmvy;
  public int cmdx;
  public int cmdy;
  public int xPos;
  public int yPos;
  public int width;
  public int height;
  public int cmxLim;
  public int cmyLim;
  public static GClass154 gclass154_0;
  private int int_0;
  private int int_1;
  private int[] int_2 = new int[Class15.smethod_0(5)];
  public bool pointerIsDowning;
  public bool isDownWhenRunning;
  private int int_3;
  public int selectedItem;
  public int ITEM_SIZE;
  public int nITEM;
  public int ITEM_PER_LINE;
  public bool styleUPDOWN = Class15.smethod_0(1) != 0;

  public void method_0()
  {
    this.cmtoX = Class15.smethod_0(0);
    this.cmtoY = Class15.smethod_0(0);
    this.cmx = Class15.smethod_0(0);
    this.cmy = Class15.smethod_0(0);
    this.cmvx = Class15.smethod_0(0);
    this.cmvy = Class15.smethod_0(0);
    this.cmdx = Class15.smethod_0(0);
    this.cmdy = Class15.smethod_0(0);
    this.cmxLim = Class15.smethod_0(0);
    this.cmyLim = Class15.smethod_0(0);
    this.width = Class15.smethod_0(0);
    this.height = Class15.smethod_0(0);
  }

  public GClass155 method_1() => (!this.styleUPDOWN ? 1 : 0) == 0 ? this.method_3(Class15.smethod_0(0) != 0) : this.method_4();

  public GClass155 method_2(bool isGetSelectNow) => (!this.styleUPDOWN ? 1 : 0) == 0 ? this.method_3(isGetSelectNow) : this.method_4();

  private GClass155 method_3(bool bool_0)
  {
    int xPos = this.xPos;
    int yPos = this.yPos;
    int width = this.width;
    int height = this.height;
    if ((!GClass62.bool_14 ? 1 : 0) == 0)
    {
      if ((!this.pointerIsDowning ? 0 : 1) == 0 && (!GClass62.smethod_45(xPos, yPos, width, height) ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < this.int_2.Length; index += Class15.smethod_0(1))
          this.int_2[Class15.smethod_0(0)] = GClass62.int_1;
        this.int_1 = GClass62.int_1;
        this.pointerIsDowning = Class15.smethod_0(1) != 0;
        if ((!bool_0 ? 0 : 1) == 0)
          this.selectedItem = -1;
        this.isDownWhenRunning = (uint) this.int_3 > (uint) Class15.smethod_0(0);
        this.int_3 = Class15.smethod_0(0);
      }
      else if ((!this.pointerIsDowning ? 1 : 0) == 0)
      {
        this.int_0 += Class15.smethod_0(1);
        if (this.int_0 > Class15.smethod_0(3) && this.int_1 == GClass62.int_1 && (!this.isDownWhenRunning ? 0 : 1) == 0)
        {
          this.int_1 = Class15.smethod_0(223);
          this.selectedItem = this.ITEM_PER_LINE <= Class15.smethod_0(1) ? (this.cmtoY + GClass62.int_1 - yPos) / this.ITEM_SIZE : (this.cmtoY + GClass62.int_1 - yPos) / this.ITEM_SIZE * this.ITEM_PER_LINE + (this.cmtoX + GClass62.int_0 - xPos) / this.ITEM_SIZE;
        }
        int num = GClass62.int_1 - this.int_2[Class15.smethod_0(0)];
        if ((!bool_0 ? 0 : 1) == 0)
        {
          if ((num == 0 ? 1 : 0) == 0 && this.selectedItem != -1)
            this.selectedItem = -1;
        }
        else
          this.selectedItem = (this.cmtoY + GClass62.int_1 - yPos) / this.ITEM_SIZE;
        for (int index = this.int_2.Length - Class15.smethod_0(1); index > Class15.smethod_0(0); index -= Class15.smethod_0(1))
          this.int_2[index] = this.int_2[index - Class15.smethod_0(1)];
        this.int_2[Class15.smethod_0(0)] = GClass62.int_1;
        this.cmtoY -= num;
        if (this.cmtoY < Class15.smethod_0(0))
          this.cmtoY = Class15.smethod_0(0);
        if (this.cmtoY > this.cmyLim)
          this.cmtoY = this.cmyLim;
        if (this.cmy < Class15.smethod_0(0) || this.cmy > this.cmyLim)
          num /= Class15.smethod_0(7);
        this.cmy -= num;
      }
    }
    bool flag = Class15.smethod_0(0) != 0;
    if ((!GClass62.bool_16 ? 1 : 0) == 0 && (!this.pointerIsDowning ? 1 : 0) == 0)
    {
      int i = GClass62.int_1 - this.int_2[Class15.smethod_0(0)];
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if (GClass151.smethod_25(i) < Class15.smethod_0(51) && GClass151.smethod_25(GClass62.int_1 - this.int_1) < Class15.smethod_0(51) && (!this.isDownWhenRunning ? 0 : 1) == 0)
      {
        this.int_3 = Class15.smethod_0(0);
        this.cmtoY = this.cmy;
        this.int_1 = Class15.smethod_0(223);
        this.selectedItem = this.ITEM_PER_LINE <= Class15.smethod_0(1) ? (this.cmtoY + GClass62.int_1 - yPos) / this.ITEM_SIZE : (this.cmtoY + GClass62.int_1 - yPos) / this.ITEM_SIZE * this.ITEM_PER_LINE + (this.cmtoX + GClass62.int_0 - xPos) / this.ITEM_SIZE;
        this.int_0 = Class15.smethod_0(0);
        flag = Class15.smethod_0(1) != 0;
      }
      else if (this.selectedItem != -1 && this.int_0 > Class15.smethod_0(3))
      {
        this.int_0 = Class15.smethod_0(0);
        flag = Class15.smethod_0(1) != 0;
      }
      else if (this.selectedItem == -1 && (!this.isDownWhenRunning ? 1 : 0) != 0 || (!bool_0 ? 1 : 0) == 0 && this.selectedItem != -1 && (!this.isDownWhenRunning ? 0 : 1) == 0)
      {
        if (this.cmy < Class15.smethod_0(0))
          this.cmtoY = Class15.smethod_0(0);
        else if (this.cmy > this.cmyLim)
        {
          this.cmtoY = this.cmyLim;
        }
        else
        {
          int num = GClass62.int_1 - this.int_2[Class15.smethod_0(0)] + (this.int_2[Class15.smethod_0(0)] - this.int_2[Class15.smethod_0(1)]) + (this.int_2[Class15.smethod_0(1)] - this.int_2[Class15.smethod_0(7)]);
          this.int_3 = -(num > Class15.smethod_0(31) ? Class15.smethod_0(31) : (num < Class15.smethod_0(136) ? Class15.smethod_0(136) : Class15.smethod_0(0))) * Class15.smethod_0(21);
        }
      }
      this.pointerIsDowning = Class15.smethod_0(0) != 0;
      this.int_0 = Class15.smethod_0(0);
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
    }
    return new GClass155()
    {
      selected = this.selectedItem,
      isFinish = flag,
      isDowning = this.pointerIsDowning
    };
  }

  private GClass155 method_4()
  {
    int xPos = this.xPos;
    int yPos = this.yPos;
    int width = this.width;
    int height = this.height;
    if ((!GClass62.bool_14 ? 1 : 0) == 0)
    {
      if ((!this.pointerIsDowning ? 0 : 1) == 0 && (!GClass62.smethod_45(xPos, yPos, width, height) ? 1 : 0) == 0)
      {
        for (int index = Class15.smethod_0(0); index < this.int_2.Length; index += Class15.smethod_0(1))
          this.int_2[Class15.smethod_0(0)] = GClass62.int_0;
        this.int_1 = GClass62.int_0;
        this.pointerIsDowning = Class15.smethod_0(1) != 0;
        this.selectedItem = -1;
        this.isDownWhenRunning = (uint) this.int_3 > (uint) Class15.smethod_0(0);
        this.int_3 = Class15.smethod_0(0);
      }
      else if ((!this.pointerIsDowning ? 1 : 0) == 0)
      {
        this.int_0 += Class15.smethod_0(1);
        if (this.int_0 > Class15.smethod_0(3) && this.int_1 == GClass62.int_0 && (!this.isDownWhenRunning ? 0 : 1) == 0)
        {
          this.int_1 = Class15.smethod_0(223);
          this.selectedItem = (this.cmtoX + GClass62.int_0 - xPos) / this.ITEM_SIZE;
        }
        int num = GClass62.int_0 - this.int_2[Class15.smethod_0(0)];
        if ((num == 0 ? 1 : 0) == 0 && this.selectedItem != -1)
          this.selectedItem = -1;
        for (int index = this.int_2.Length - Class15.smethod_0(1); index > Class15.smethod_0(0); index -= Class15.smethod_0(1))
          this.int_2[index] = this.int_2[index - Class15.smethod_0(1)];
        this.int_2[Class15.smethod_0(0)] = GClass62.int_0;
        this.cmtoX -= num;
        if (this.cmtoX < Class15.smethod_0(0))
          this.cmtoX = Class15.smethod_0(0);
        if (this.cmtoX > this.cmxLim)
          this.cmtoX = this.cmxLim;
        if (this.cmx < Class15.smethod_0(0) || this.cmx > this.cmxLim)
          num /= Class15.smethod_0(7);
        this.cmx -= num;
      }
    }
    bool flag = Class15.smethod_0(0) != 0;
    if ((!GClass62.bool_16 ? 1 : 0) == 0 && (!this.pointerIsDowning ? 1 : 0) == 0)
    {
      int i = GClass62.int_0 - this.int_2[Class15.smethod_0(0)];
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
      if (GClass151.smethod_25(i) < Class15.smethod_0(51) && GClass151.smethod_25(GClass62.int_0 - this.int_1) < Class15.smethod_0(51) && (!this.isDownWhenRunning ? 0 : 1) == 0)
      {
        this.int_3 = Class15.smethod_0(0);
        this.cmtoX = this.cmx;
        this.int_1 = Class15.smethod_0(223);
        this.selectedItem = (this.cmtoX + GClass62.int_0 - xPos) / this.ITEM_SIZE;
        this.int_0 = Class15.smethod_0(0);
        flag = Class15.smethod_0(1) != 0;
      }
      else if (this.selectedItem != -1 && this.int_0 > Class15.smethod_0(3))
      {
        this.int_0 = Class15.smethod_0(0);
        flag = Class15.smethod_0(1) != 0;
      }
      else if (this.selectedItem == -1 && (!this.isDownWhenRunning ? 0 : 1) == 0)
      {
        if (this.cmx < Class15.smethod_0(0))
          this.cmtoX = Class15.smethod_0(0);
        else if (this.cmx > this.cmxLim)
        {
          this.cmtoX = this.cmxLim;
        }
        else
        {
          int num = GClass62.int_0 - this.int_2[Class15.smethod_0(0)] + (this.int_2[Class15.smethod_0(0)] - this.int_2[Class15.smethod_0(1)]) + (this.int_2[Class15.smethod_0(1)] - this.int_2[Class15.smethod_0(7)]);
          this.int_3 = -(num > Class15.smethod_0(31) ? Class15.smethod_0(31) : (num < Class15.smethod_0(136) ? Class15.smethod_0(136) : Class15.smethod_0(0))) * Class15.smethod_0(21);
        }
      }
      this.pointerIsDowning = Class15.smethod_0(0) != 0;
      this.int_0 = Class15.smethod_0(0);
      GClass62.bool_16 = Class15.smethod_0(0) != 0;
    }
    return new GClass155()
    {
      selected = this.selectedItem,
      isFinish = flag,
      isDowning = this.pointerIsDowning
    };
  }

  public void method_5()
  {
    if ((this.int_3 == 0 ? 1 : 0) == 0 && (!this.pointerIsDowning ? 0 : 1) == 0)
    {
      if ((!this.styleUPDOWN ? 1 : 0) == 0)
      {
        this.cmtoY += this.int_3 / Class15.smethod_0(21);
        if (this.cmtoY < Class15.smethod_0(0))
          this.cmtoY = Class15.smethod_0(0);
        else if (this.cmtoY > this.cmyLim)
          this.cmtoY = this.cmyLim;
        else
          this.cmy = this.cmtoY;
      }
      else
      {
        this.cmtoX += this.int_3 / Class15.smethod_0(21);
        if (this.cmtoX < Class15.smethod_0(0))
          this.cmtoX = Class15.smethod_0(0);
        else if (this.cmtoX > this.cmxLim)
          this.cmtoX = this.cmxLim;
        else
          this.cmx = this.cmtoX;
      }
      this.int_3 = this.int_3 * Class15.smethod_0(45) / Class15.smethod_0(31);
      if (this.int_3 < Class15.smethod_0(21) && this.int_3 > Class15.smethod_0(143))
        this.int_3 = Class15.smethod_0(0);
    }
    if (this.cmx != this.cmtoX && (!this.pointerIsDowning ? 0 : 1) == 0)
    {
      this.cmvx = this.cmtoX - this.cmx << Class15.smethod_0(7);
      this.cmdx += this.cmvx;
      this.cmx += this.cmdx >> Class15.smethod_0(2);
      this.cmdx &= Class15.smethod_0(9);
    }
    if (this.cmy == this.cmtoY || (!this.pointerIsDowning ? 0 : 1) != 0)
      return;
    this.cmvy = this.cmtoY - this.cmy << Class15.smethod_0(7);
    this.cmdy += this.cmvy;
    this.cmy += this.cmdy >> Class15.smethod_0(2);
    this.cmdy &= Class15.smethod_0(9);
  }

  public void method_6(
    int nItem,
    int ITEM_SIZE,
    int xPos,
    int yPos,
    int width,
    int height,
    bool styleUPDOWN,
    int ITEM_PER_LINE)
  {
    this.xPos = xPos;
    this.yPos = yPos;
    this.ITEM_SIZE = ITEM_SIZE;
    this.nITEM = nItem;
    this.width = width;
    this.height = height;
    this.styleUPDOWN = styleUPDOWN;
    this.ITEM_PER_LINE = ITEM_PER_LINE;
    string[] strArray = new string[Class15.smethod_0(37)];
    strArray[Class15.smethod_0(0)] = Class13.smethod_0(148179);
    strArray[Class15.smethod_0(1)] = nItem.ToString();
    strArray[Class15.smethod_0(7)] = Class13.smethod_0(149164);
    strArray[Class15.smethod_0(5)] = ITEM_SIZE.ToString();
    strArray[Class15.smethod_0(2)] = Class13.smethod_0(149152);
    strArray[Class15.smethod_0(3)] = height.ToString();
    GClass151.smethod_7(string.Concat(strArray));
    if ((!styleUPDOWN ? 1 : 0) == 0)
    {
      int num = nItem / ITEM_PER_LINE;
      if ((nItem % ITEM_PER_LINE == 0 ? 1 : 0) == 0)
        num += Class15.smethod_0(1);
      this.cmyLim = num * ITEM_SIZE - height;
    }
    else
      this.cmxLim = ITEM_PER_LINE * ITEM_SIZE - width;
    if (this.cmyLim < Class15.smethod_0(0))
      this.cmyLim = Class15.smethod_0(0);
    if (this.cmxLim >= Class15.smethod_0(0))
      return;
    this.cmxLim = Class15.smethod_0(0);
  }

  public void method_7(int to)
  {
    if ((!this.styleUPDOWN ? 1 : 0) == 0)
    {
      to -= (this.height - this.ITEM_SIZE) / Class15.smethod_0(7);
      this.cmtoY = to;
      if (this.cmtoY < Class15.smethod_0(0))
        this.cmtoY = Class15.smethod_0(0);
      if (this.cmtoY <= this.cmyLim)
        return;
      this.cmtoY = this.cmyLim;
    }
    else
    {
      to -= (this.width - this.ITEM_SIZE) / Class15.smethod_0(7);
      this.cmtoX = to;
      if (this.cmtoX < Class15.smethod_0(0))
        this.cmtoX = Class15.smethod_0(0);
      if (this.cmtoX <= this.cmxLim)
        return;
      this.cmtoX = this.cmxLim;
    }
  }

  public static GClass154 smethod_0()
  {
    if ((GClass154.gclass154_0 == null ? 0 : 1) == 0)
      GClass154.gclass154_0 = new GClass154();
    return GClass154.gclass154_0;
  }
}
