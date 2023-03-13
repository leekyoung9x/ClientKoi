// Decompiled with JetBrains decompiler
// Type: Class17
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Security.Cryptography;

internal sealed class Class17 : SymmetricAlgorithm, IDisposable, ICryptoTransform
{
  private Random random_0;

  public Class17()
  {
    this.random_0 = new Random(DateTime.Now.Millisecond);
    this.LegalKeySizesValue = new KeySizes[1]
    {
      new KeySizes(128, 128, 0)
    };
    this.KeySize = 128;
    this.LegalBlockSizesValue = new KeySizes[1]
    {
      new KeySizes(128, 128, 0)
    };
    this.BlockSize = 128;
  }

  virtual ICryptoTransform SymmetricAlgorithm.CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
  {
    rgbKey.CopyTo((Array) this.Key, 0);
    rgbIV.CopyTo((Array) this.IV, 0);
    return (ICryptoTransform) this;
  }

  virtual ICryptoTransform SymmetricAlgorithm.CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
  {
    rgbKey.CopyTo((Array) this.Key, 0);
    rgbIV.CopyTo((Array) this.IV, 0);
    return (ICryptoTransform) this;
  }

  virtual void SymmetricAlgorithm.GenerateIV()
  {
    byte[] buffer = new byte[16];
    this.random_0.NextBytes(buffer);
    this.IV = buffer;
  }

  virtual void SymmetricAlgorithm.GenerateKey()
  {
    byte[] buffer = new byte[16];
    this.random_0.NextBytes(buffer);
    this.Key = buffer;
  }

  int ICryptoTransform.TransformBlock(
    byte[] inputBuffer,
    int inputOffset,
    int inputCount,
    byte[] outputBuffer,
    int outputOffset)
  {
    int length1 = this.Key.Length;
    int length2 = this.IV.Length;
    for (int index = 0; index < inputCount; ++index)
    {
      int num = (int) this.IV[index % length2];
      outputBuffer[index + outputOffset] = (byte) ((uint) inputBuffer[index + inputOffset] ^ (uint) this.Key[num % length1]);
    }
    return inputCount;
  }

  byte[] ICryptoTransform.TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
  {
    byte[] outputBuffer = new byte[inputCount];
    this.System\u002ESecurity\u002ECryptography\u002EICryptoTransform\u002ETransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, 0);
    return outputBuffer;
  }

  bool ICryptoTransform.CanReuseTransform => true;

  bool ICryptoTransform.CanTransformMultipleBlocks => true;

  int ICryptoTransform.InputBlockSize => 16;

  int ICryptoTransform.OutputBlockSize => 16;
}
