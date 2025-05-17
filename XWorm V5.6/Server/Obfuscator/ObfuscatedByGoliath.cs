using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class ObfuscatedByGoliath : Attribute
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public ObfuscatedByGoliath([In] string obj0) => throw new Exception("や");
}
