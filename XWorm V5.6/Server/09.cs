using System;
using System.IO;
using System.Runtime.InteropServices;

internal class \u0028\u0029\u003B\u0009 : Attribute
{
  public static byte[] XFE40FXCE68B47540898XE5DA4F7XE0A([In] Stream obj0)
  {
    using (MemoryStream destination = new MemoryStream())
    {
      obj0.CopyTo((Stream) destination);
      return destination.ToArray();
    }
  }
}
