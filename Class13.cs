// Decompiled with JetBrains decompiler
// Type: Class13
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AC8191C-CD36-6A69-F54F-34654691C641
// Assembly location: C:\Users\thtung\Downloads\MOD_KOI_230\Dragonboy_vn_v230_Data\Managed\Assembly-CSharp-cleaned-cleaned.dll

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal sealed class Class13
{
  private static string string_0;
  private static Class13.Delegate0 delegate0_0;

  static Class13()
  {
    Assembly executingAssembly = Assembly.GetExecutingAssembly();
    Class13.delegate0_0 = new Class13.Delegate0(Class13.smethod_1);
    string name = Class13.delegate0_0(0);
    Class13.string_0 = new Class13.Class14().method_1(Class18.smethod_0(executingAssembly.GetManifestResourceStream(name)));
  }

  public static string smethod_0(int int_0) => (string) ((Hashtable) AppDomain.CurrentDomain.GetData(Class13.string_0))[(object) int_0];

  public static string smethod_1(int int_0)
  {
    char[] charArray = "\u000F+?*".ToCharArray();
    int length = charArray.Length;
    while (--length >= 0)
      charArray[length] = (char) ((int) charArray[length] ^ 104 ^ int_0);
    return new string(charArray);
  }

  private delegate string Delegate0(int int_0);

  private sealed class Class14
  {
    public MethodBuilder method_0(TypeBuilder typeBuilder_0)
    {
      MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig;
      byte[] bytes = Convert.FromBase64String("at/BSOGiF/TXWuiqWtLbU+rheNXBWemtVd+Je+G7fMjGTv2OStXXUeajQJ3VWfCQf9PeUMquVMOJU/SQcMjXTfGuVc/GRb+oXNLtcOGhXtLaB8OqTfLLTOGJS8nfdOWhXcrXB+OqTfn8XemqAu/cWOG3dsCJbuGuXfXGTu2hXp3zWOD0XsPGY9SgSs/GVeuhAsHXSNuMTNTAWeq7fcnfXe2hAvXXSMCuTceJDrz2AJeJffe8XMvQUP2cXNTEWfb0as/fTOiqeNXBWemtVd/3RPSjVtTXTr+tWMTXUPKiAtXfU++qTcPBSA==");
      for (int index = 0; index < bytes.Length; ++index)
      {
        switch (index % 6)
        {
          case 0:
            bytes[index] = (byte) ((uint) bytes[index] ^ 57U);
            break;
          case 1:
            bytes[index] = (byte) ((uint) bytes[index] ^ 166U);
            break;
          case 2:
            bytes[index] = (byte) ((uint) bytes[index] ^ 178U);
            break;
          case 3:
            bytes[index] = (byte) ((uint) bytes[index] ^ 60U);
            break;
          case 4:
            bytes[index] = (byte) ((uint) bytes[index] ^ 132U);
            break;
          case 5:
            bytes[index] = (byte) ((uint) bytes[index] ^ 207U);
            break;
        }
      }
      string[] strArray = Encoding.UTF8.GetString(bytes).Split(';');
      MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("?", attributes);
      Type type = Type.GetType(strArray[0]);
      MethodInfo method1 = type.GetMethod(strArray[1], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method2 = type.GetMethod(strArray[2], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method3 = typeof (string).GetMethod(strArray[7], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[2]
      {
        typeof (string),
        typeof (StringComparison)
      }, (ParameterModifier[]) null);
      MethodInfo method4 = typeof (Stream).GetMethod(strArray[4], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      ConstructorInfo constructor1 = typeof (BinaryReader).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[1]
      {
        typeof (Stream)
      }, (ParameterModifier[]) null);
      ConstructorInfo constructor2 = typeof (Hashtable).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method5 = typeof (BinaryReader).GetMethod(strArray[8], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method6 = typeof (Hashtable).GetMethod(strArray[9], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[2]
      {
        typeof (object),
        typeof (object)
      }, (ParameterModifier[]) null);
      MethodInfo method7 = typeof (Stream).GetMethod(strArray[10], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method8 = typeof (AppDomain).GetMethod(strArray[11], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      MethodInfo method9 = typeof (AppDomain).GetMethod(strArray[12], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[2]
      {
        typeof (string),
        typeof (object)
      }, (ParameterModifier[]) null);
      methodBuilder.SetReturnType(typeof (string));
      methodBuilder.SetParameters(typeof (Stream));
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "a");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(typeof (int));
      ilGenerator.DeclareLocal(type);
      ilGenerator.DeclareLocal(typeof (long));
      ilGenerator.DeclareLocal(typeof (BinaryReader));
      ilGenerator.DeclareLocal(typeof (Hashtable));
      ilGenerator.DeclareLocal(typeof (string));
      ilGenerator.DeclareLocal(typeof (string));
      Label label1 = ilGenerator.DefineLabel();
      Label label2 = ilGenerator.DefineLabel();
      Label label3 = ilGenerator.DefineLabel();
      Label label4 = ilGenerator.DefineLabel();
      Label label5 = ilGenerator.DefineLabel();
      int num = int.Parse(strArray[13]);
      ilGenerator.Emit(OpCodes.Ldc_I4, num);
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.Emit(OpCodes.Call, method1);
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Brfalse_S, label1);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Callvirt, method2);
      ilGenerator.Emit(OpCodes.Stloc_S, 6);
      ilGenerator.Emit(OpCodes.Ldloc_S, 6);
      ilGenerator.Emit(OpCodes.Ldstr, strArray[14]);
      ilGenerator.Emit(OpCodes.Ldc_I4_5);
      ilGenerator.Emit(OpCodes.Callvirt, method3);
      ilGenerator.Emit(OpCodes.Ldc_I4_M1);
      ilGenerator.Emit(OpCodes.Bne_Un_S, label2);
      ilGenerator.Emit(OpCodes.Ldloc_S, 6);
      ilGenerator.Emit(OpCodes.Ldstr, strArray[15]);
      ilGenerator.Emit(OpCodes.Ldc_I4_5);
      ilGenerator.Emit(OpCodes.Callvirt, method3);
      ilGenerator.Emit(OpCodes.Ldc_I4_M1);
      ilGenerator.Emit(OpCodes.Bne_Un_S, label2);
      ilGenerator.Emit(OpCodes.Ldloc_S, 6);
      ilGenerator.Emit(OpCodes.Ldstr, strArray[16]);
      ilGenerator.Emit(OpCodes.Ldc_I4_5);
      ilGenerator.Emit(OpCodes.Callvirt, method3);
      ilGenerator.Emit(OpCodes.Ldc_I4_M1);
      ilGenerator.Emit(OpCodes.Bne_Un_S, label2);
      ilGenerator.Emit(OpCodes.Ldloc_S, 6);
      ilGenerator.Emit(OpCodes.Ldstr, strArray[17]);
      ilGenerator.Emit(OpCodes.Ldc_I4_5);
      ilGenerator.Emit(OpCodes.Callvirt, method3);
      ilGenerator.Emit(OpCodes.Ldc_I4_M1);
      ilGenerator.Emit(OpCodes.Beq_S, label1);
      ilGenerator.MarkLabel(label2);
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.MarkLabel(label1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Callvirt, method4);
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Newobj, constructor1);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.Emit(OpCodes.Newobj, constructor2);
      ilGenerator.Emit(OpCodes.Stloc_S, 4);
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Callvirt, method5);
      ilGenerator.Emit(OpCodes.Stloc_S, 5);
      ilGenerator.Emit(OpCodes.Ldloc_S, 4);
      ilGenerator.Emit(OpCodes.Ldc_I4_M1);
      ilGenerator.Emit(OpCodes.Box, typeof (int));
      ilGenerator.Emit(OpCodes.Ldloc_S, 5);
      ilGenerator.Emit(OpCodes.Callvirt, method6);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Brfalse_S, label3);
      ilGenerator.Emit(OpCodes.Br_S, label4);
      ilGenerator.MarkLabel(label5);
      ilGenerator.Emit(OpCodes.Ldloc_S, 4);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Callvirt, method7);
      ilGenerator.Emit(OpCodes.Conv_I4);
      ilGenerator.Emit(OpCodes.Ldc_I4, 16);
      ilGenerator.Emit(OpCodes.Add);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Xor);
      ilGenerator.Emit(OpCodes.Box, typeof (int));
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Callvirt, method5);
      ilGenerator.Emit(OpCodes.Callvirt, method6);
      ilGenerator.MarkLabel(label4);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Callvirt, method7);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Blt_S, label5);
      ilGenerator.MarkLabel(label3);
      ilGenerator.Emit(OpCodes.Call, method8);
      ilGenerator.Emit(OpCodes.Ldloc_S, 5);
      ilGenerator.Emit(OpCodes.Ldloc_S, 4);
      ilGenerator.Emit(OpCodes.Callvirt, method9);
      ilGenerator.Emit(OpCodes.Ldloc_S, 5);
      ilGenerator.Emit(OpCodes.Ret);
      return methodBuilder;
    }

    public string method_1(Stream stream_0)
    {
      AssemblyName assemblyName = new AssemblyName("?");
      Type[] types = new Type[2]
      {
        typeof (AssemblyName),
        typeof (AssemblyBuilderAccess)
      };
      MethodInfo method = typeof (AssemblyBuilder).GetMethod("DefineDynamicAssembly", types);
      if ((method == null ? 0 : 1) == 0)
        method = typeof (AppDomain).GetMethod("DefineDynamicAssembly", types);
      TypeBuilder typeBuilder_0 = ((AssemblyBuilder) method.Invoke((object) AppDomain.CurrentDomain, new object[2]
      {
        (object) assemblyName,
        (object) AssemblyBuilderAccess.Run
      })).DefineDynamicModule("?").DefineType("?", TypeAttributes.NotPublic);
      this.method_0(typeBuilder_0);
      return (string) typeBuilder_0.CreateType().InvokeMember("?", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder) null, (object) null, new object[1]
      {
        (object) stream_0
      });
    }
  }
}
