using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class YanoAttribute : Attribute
{
  [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
  [MethodImpl(MethodImplOptions.ForwardRef)]
  public static extern IntPtr LoadLibraryA([In] string obj0);
}
