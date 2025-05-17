using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class CryptoObfuscator\u002EProtectedWithCryptoObfuscatorAttribute : Attribute
{
  [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
  [MethodImpl(MethodImplOptions.ForwardRef)]
  public static extern IntPtr GetProcAddress([In] IntPtr obj0, [In] string obj1);
}
