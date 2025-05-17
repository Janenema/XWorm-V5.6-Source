using System;
using System.Runtime.InteropServices;

internal class DotfuscatorAttribute : Attribute
{
  public static int HeaderLen([In] byte[] obj0)
  {
    if (((int) obj0[0] & 2) != 2)
    {
label_1:
      int num1 = 1888449089;
      while (true)
      {
        uint num2 = (uint) num1;
        uint num3;
        uint[] numArray;
        uint num4;
        uint num5;
        int num6;
        switch ((uint) num1 % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = num3;
            num1 = (int) num2 * 791286778 ^ -1938107876;
            continue;
          case 2:
            numArray[0] = 68U;
            num1 = (int) num2 * 582585054 ^ 291299940;
            continue;
          case 3:
            num1 = (int) num2 * 635162349 ^ 905126956;
            continue;
          case 5:
label_3:
            num6 = 0;
            break;
          case 6:
            numArray = new uint[2];
            num1 = (int) num2 * 1421298686 ^ 881955322;
            continue;
          case 7:
            goto label_15;
          case 8:
            num1 = (int) num2 * 1069568178 ^ -1278175995;
            continue;
          case 9:
            numArray[1] = 109U - numArray[0];
            num1 = (int) num2 * 114156085 ^ -1631082594;
            continue;
          case 10:
            goto label_10;
          case 11:
            num5 = num4 / numArray[1];
            num1 = (int) num2 * 1517629341 ^ -2099058229;
            continue;
          default:
            num6 = (int) num5 - 26351630;
            break;
        }
        switch ((num3 = (uint) (num6 ^ 1080416954)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_15;
          case 2:
            goto label_10;
          default:
            num1 = 906759991;
            continue;
        }
      }
label_10:
      return 3;
    }
label_15:
    return 9;
  }
}
