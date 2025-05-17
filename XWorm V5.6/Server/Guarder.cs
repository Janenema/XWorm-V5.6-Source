using CryptoObfuscator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

internal class ZYXDNGuarder : Attribute
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static unsafe void XE8705B7572DC9EXX7BFC73X9972602F([In] object obj0)
  {
    if (Environment.OSVersion.Version.Major == 5 || obj0 != null)
      return;
    Module module = typeof (\u003CModule\u003E).Module;
    bool flag = Environment.Version.Major == 4;
    ulong* numPtr = stackalloc ulong[2];
    if (flag)
    {
      numPtr[0] = 27431033849798509UL;
      numPtr[1] = 7UL;
    }
    else
    {
      numPtr[0] = 7022344665548414829UL;
      numPtr[1] = 8UL;
    }
    IntPtr num1 = (IntPtr) module.GetType().GetField(new string((sbyte*) numPtr, 0, (int) numPtr[1]), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue((object) module);
    using (Stream input = (Stream) new MemoryStream(BabelObfuscatorAttribute.DecompressBytes(\u0028\u0029\u003B\u0009.XFE40FXCE68B47540898XE5DA4F7XE0A(module.Assembly.GetManifestResourceStream(EMyPID_8234_.XB6DAF26505F50XCDA0767075D0989BD("WDRGRTNYNzI3RTk1ODM4RVgzQTNEMkUzOTUxMzRGMUI="))))))
    {
      BinaryReader binaryReader = new BinaryReader(input);
      int length = binaryReader.ReadInt32();
      IntPtr[] numArray1 = new IntPtr[length];
      IntPtr[] numArray2 = new IntPtr[length];
      for (int index = 0; index < length; ++index)
      {
        MethodBase methodBase = module.ResolveMethod(binaryReader.ReadInt32());
        string s = binaryReader.ReadString();
        numArray1[index] = methodBase.MethodHandle.Value;
        numArray2[index] = Marshal.StringToHGlobalAnsi(s);
      }
      IntPtr zero = IntPtr.Zero;
      IntPtr num2;
      if (IntPtr.Size == 4)
      {
        \u003CModule\u003E.\u003C\u003Ec__DisplayClass17_0 cDisplayClass170 = new \u003CModule\u003E.\u003C\u003Ec__DisplayClass17_0();
        cDisplayClass170.rtNameX86 = "aPjMR";
        string path1 = Path.GetTempPath() + cDisplayClass170.rtNameX86 + "\\";
        Directory.CreateDirectory(path1);
        string path2 = path1 + cDisplayClass170.rtNameX86 + ".dll";
        if (!File.Exists(path2))
        {
          Assembly executingAssembly = Assembly.GetExecutingAssembly();
          using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(((IEnumerable<string>) executingAssembly.GetManifestResourceNames()).FirstOrDefault<string>(new Func<string, bool>(cDisplayClass170.\u003CInitialize\u003Eb__0))))
          {
            byte[] numArray3 = BabelObfuscatorAttribute.DecompressBytes(\u0028\u0029\u003B\u0009.XFE40FXCE68B47540898XE5DA4F7XE0A(manifestResourceStream));
            manifestResourceStream.Read(numArray3, 0, numArray3.Length);
            File.WriteAllBytes(path2, numArray3);
            FileSystemAccessRule rule = new FileSystemAccessRule((IdentityReference) new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
            FileSecurity accessControl = File.GetAccessControl(path2);
            accessControl.AddAccessRule(rule);
            File.SetAccessControl(path2, accessControl);
          }
        }
        num2 = YanoAttribute.LoadLibraryA(path2);
      }
      else
      {
        \u003CModule\u003E.\u003C\u003Ec__DisplayClass17_1 cDisplayClass171 = new \u003CModule\u003E.\u003C\u003Ec__DisplayClass17_1();
        cDisplayClass171.rtNameX64 = "TMzpx";
        string path3 = Path.GetTempPath() + cDisplayClass171.rtNameX64 + "\\";
        Directory.CreateDirectory(path3);
        string path4 = path3 + cDisplayClass171.rtNameX64 + ".dll";
        if (!File.Exists(path4))
        {
          Assembly executingAssembly = Assembly.GetExecutingAssembly();
          using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(((IEnumerable<string>) executingAssembly.GetManifestResourceNames()).FirstOrDefault<string>(new Func<string, bool>(cDisplayClass171.\u003CInitialize\u003Eb__1))))
          {
            byte[] numArray4 = BabelObfuscatorAttribute.DecompressBytes(\u0028\u0029\u003B\u0009.XFE40FXCE68B47540898XE5DA4F7XE0A(manifestResourceStream));
            manifestResourceStream.Read(numArray4, 0, numArray4.Length);
            File.WriteAllBytes(path4, numArray4);
            FileSystemAccessRule rule = new FileSystemAccessRule((IdentityReference) new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
            FileSecurity accessControl = File.GetAccessControl(path4);
            accessControl.AddAccessRule(rule);
            File.SetAccessControl(path4, accessControl);
          }
        }
        num2 = YanoAttribute.LoadLibraryA(path4);
      }
      string str = EMyPID_8234_.XB6DAF26505F50XCDA0767075D0989BD("SVNCeXRl");
      ((\u003CModule\u003E.IV) Marshal.GetDelegateForFunctionPointer(ProtectedWithCryptoObfuscatorAttribute.GetProcAddress(num2, str), typeof (\u003CModule\u003E.IV)))(flag, num1, numArray1, numArray2, length);
    }
  }
}
