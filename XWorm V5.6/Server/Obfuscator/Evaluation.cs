using System;
using System.Runtime.InteropServices;

internal class NineRays\u002EObfuscator\u002EEvaluation : Attribute
{
  public static int SizeDecompressed([In] byte[] obj0)
  {
    if (DotfuscatorAttribute.HeaderLen(obj0) == 9)
    {
label_1:
      int num1 = 1903901494;
      while (true)
      {
        uint num2 = (uint) num1;
        uint num3;
        uint[] numArray;
        uint num4;
        uint num5;
        int num6;
        switch ((uint) num1 % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = num3;
            num1 = (int) num2 * 1886604292 ^ -1671989284;
            continue;
          case 2:
            numArray[0] = 87U;
            num1 = (int) num2 * 2004654667 ^ -436532258;
            continue;
          case 3:
            num1 = (int) num2 * 1080179011 ^ 67738550;
            continue;
          case 4:
            num1 = (int) num2 * 456533807 ^ -952560709;
            continue;
          case 6:
            numArray = new uint[3];
            num1 = (int) num2 * 745205400 ^ 1321003084;
            continue;
          case 7:
            goto label_17;
          case 8:
            num1 = (int) num2 * 1396663879 ^ -659178309;
            continue;
          case 9:
            numArray[1] = 4294967237U + numArray[0];
            num1 = (int) num2 * 170488849 ^ 1682714616;
            continue;
          case 10:
            goto label_10;
          case 11:
            numArray[2] = 4294967263U + numArray[1] + numArray[0];
            num1 = (int) num2 * 932772924 ^ -2078097758;
            continue;
          case 12:
label_3:
            num6 = 0;
            break;
          case 13:
            num5 = num4 / numArray[2];
            num1 = (int) num2 * 1364557768 ^ 1759403971;
            continue;
          default:
            num6 = (int) num5 - 13175813;
            break;
        }
        switch ((num3 = (uint) (num6 ^ 1080416954)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_17;
          case 2:
            goto label_10;
          default:
            num1 = 783999811;
            continue;
        }
      }
label_10:
      return (int) obj0[5] | (int) obj0[6] << 8 | (int) obj0[7] << 16 | (int) obj0[8] << 24;
    }
label_17:
    return (int) obj0[2];
  }
}
