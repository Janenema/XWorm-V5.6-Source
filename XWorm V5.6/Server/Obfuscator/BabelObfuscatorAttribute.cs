using Obfuscator;
using System;
using System.Runtime.InteropServices;

internal class BabelObfuscatorAttribute : Attribute
{
  public static byte[] DecompressBytes([In] byte[] obj0)
  {
    int length = Evaluation.SizeDecompressed(obj0);
label_1:
    int num1 = 1849035984;
    byte[] numArray1;
    byte[] destinationArray;
    while (true)
    {
      uint num2 = (uint) num1;
      uint num3;
      uint[] numArray2;
      int index1;
      uint num4;
      uint num5;
      int num6;
      switch ((uint) num1 % 14U)
      {
        case 0:
          goto label_1;
        case 1:
          num4 = num3;
          num1 = (int) num2 * 569101327 ^ -2132835397;
          continue;
        case 2:
          numArray2[0] = 83U;
          num1 = (int) num2 * 1166520023 ^ -1882254074;
          continue;
        case 3:
          num1 = (int) num2 * 2067552436 ^ 1844067355;
          continue;
        case 4:
          num1 = (int) num2 * 1676804693 ^ -492107855;
          continue;
        case 6:
          numArray2 = new uint[3];
          num1 = (int) num2 * 86322821 ^ 1855333636;
          continue;
        case 7:
          goto label_125;
        case 8:
          num1 = (int) num2 * 619071288 ^ 189115399;
          continue;
        case 9:
          numArray2[1] = 4294967260U + numArray2[0];
          num1 = (int) num2 * 1259773609 ^ 510020920;
          continue;
        case 10:
label_10:
          index1 = DotfuscatorAttribute.HeaderLen(obj0);
          num1 = 580979631;
          continue;
        case 11:
          numArray2[2] = 78U + numArray2[1] - numArray2[0];
          num1 = (int) num2 * 1362822457 ^ 1438748269;
          continue;
        case 12:
label_3:
          num6 = 73;
          break;
        case 13:
          num5 = num4 / numArray2[2];
          num1 = (int) num2 * 1086420378 ^ 635931609;
          continue;
        default:
          num6 = (int) num5 - 25724205;
          break;
      }
      int index2;
      uint num7;
      uint num8;
      uint num9;
      int[] numArray3;
      int index3;
      byte[] numArray4;
      int num10;
      int num11;
      uint index4;
      uint num12;
      int num13;
      int index5;
      int num14;
      while (true)
      {
        switch ((num3 = (uint) (num6 ^ 1080416954)) % 111U)
        {
          case 0:
            goto label_3;
          case 1:
            index2 = 0;
            uint num15 = num3;
            numArray2 = new uint[2]{ 34U, 0U };
            numArray2[1] = 91U - numArray2[0];
            num6 = (int) (num15 / numArray2[1]) - 18954258;
            continue;
          case 2:
            numArray1 = new byte[length];
            uint num16 = num3;
            numArray2 = new uint[2]{ 55U, 0U };
            numArray2[1] = 151U - numArray2[0];
            num6 = (int) (num16 / numArray2[1]) - 11253902;
            continue;
          case 3:
            numArray4 = new byte[4096];
            uint num17 = num3;
            numArray2 = new uint[2]{ 48U, 0U };
            numArray2[1] = 9U + numArray2[0];
            num6 = (int) (num17 / numArray2[1]) - 18954602;
            continue;
          case 4:
            index3 = -1;
            uint num18 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 85U;
            numArray2[1] = 4294967266U + numArray2[0];
            numArray2[2] = 4294967254U + numArray2[1] + numArray2[0];
            num6 = (int) (num18 / numArray2[2]) - 11024597;
            continue;
          case 5:
            num10 = (int) obj0[0] >> 2 & 3;
            uint num19 = num3;
            numArray2 = new uint[2]{ 47U, 0U };
            numArray2[1] = 4294967287U + numArray2[0];
            num6 = (int) (num19 / numArray2[1]) - 28431592;
            continue;
          case 6:
            int num20 = num10 == 3 ? 3 : (num20 = 417);
            num6 = num20 ^ (int) num3 / 1162745016;
            continue;
          case 7:
            int num21;
            num6 = num21 = ((int) obj0[0] & 1) != 1 ? 85 : (num21 = 1);
            continue;
          case 8:
            Array.Copy((Array) obj0, DotfuscatorAttribute.HeaderLen(obj0), (Array) destinationArray, 0, length);
            uint num22 = num3;
            numArray2 = new uint[2]{ 81U, 0U };
            numArray2[1] = 158U - numArray2[0];
            num6 = (int) (num22 / numArray2[1]) - 14031312;
            continue;
          case 9:
            int num23;
            num6 = num23 = num8 != 1U ? 5 : (num23 = 69);
            continue;
          case 10:
            index1 += 4;
            uint num24 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 27U;
            numArray2[1] = 18U + numArray2[0];
            numArray2[2] = 4294967285U + numArray2[1] + numArray2[0];
            num6 = (int) (num24 / numArray2[2]) - 17711308;
            continue;
          case 11:
            int num25 = num10 == 1 ? 437 : (num25 = 429);
            num6 = num25 ^ (int) num3 / 1591910298;
            continue;
          case 12:
            num6 = (int) (num3 / 1142641912U) - -5;
            continue;
          case 13:
            int num26;
            num6 = num26 = ((int) num8 & 1) == 1 ? 421 : (num26 = 434);
            continue;
          case 14:
            int num27 = num10 == 1 ? 87 : (num27 = (int) sbyte.MaxValue);
            num6 = num27 ^ (int) num3 / 1556177751;
            continue;
          case 15:
            index4 = (uint) numArray3[index5];
            uint num28 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 68U;
            numArray2[1] = 2U + numArray2[0];
            numArray2[2] = 172U - numArray2[1] - numArray2[0];
            num6 = (int) (num28 / numArray2[2]) - 31776894;
            continue;
          case 16:
            num12 = (uint) (((int) num7 & 15) + 2);
            uint num29 = num3;
            numArray2 = new uint[2]{ 67U, 0U };
            numArray2[1] = 117U - numArray2[0];
            num6 = (int) (num29 / numArray2[1]) - 21608260;
            continue;
          case 17:
            num6 = (int) (num3 / 73519265U) - -93;
            continue;
          case 18:
            index1 += 3;
            uint num30 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 64U;
            numArray2[1] = 1U + numArray2[0];
            numArray2[2] = 4294967212U + numArray2[1] + numArray2[0];
            num6 = (int) (num30 / numArray2[2]) - 24009194;
            continue;
          case 19:
            int num31;
            num6 = num31 = ((int) num7 & 3) == 0 ? 443 : (num31 = 435);
            continue;
          case 20:
            num12 = 3U;
            uint num32 = num3;
            numArray2 = new uint[2]{ 35U, 0U };
            numArray2[1] = 8U + numArray2[0];
            num6 = (int) (num32 / numArray2[1]) - 25125528;
            continue;
          case 21:
            num6 = (int) (num3 / 10405328U) - 29;
            continue;
          case 22:
            num9 = (num7 & (uint) ushort.MaxValue) >> 2;
            uint num33 = num3;
            numArray2 = new uint[2]{ 38U, 0U };
            numArray2[1] = 46U + numArray2[0];
            num6 = (int) (num33 / numArray2[1]) - 12861667;
            continue;
          case 23:
            index1 += 2;
            uint num34 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 36U;
            numArray2[1] = 83U - numArray2[0];
            numArray2[2] = 153U - numArray2[1] - numArray2[0];
            num6 = (int) (num34 / numArray2[2]) - 15434101;
            continue;
          case 24:
            int num35;
            num6 = num35 = ((int) num7 & 1) == 0 ? 431 : (num35 = 423);
            continue;
          case 25:
            num12 = (uint) (((int) (num7 >> 2) & 15) + 3);
            uint num36 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 66U;
            numArray2[1] = 4294967279U + numArray2[0];
            numArray2[2] = 44U + numArray2[1] - numArray2[0];
            num6 = (int) (num36 / numArray2[2]) - 40015024;
            continue;
          case 26:
            num6 = (int) (num3 / 519436876U) - -72;
            continue;
          case 27:
            num9 = num7 >> 7 & 131071U;
            uint num37 = num3;
            numArray2 = new uint[2]{ 54U, 0U };
            numArray2[1] = 41U + numArray2[0];
            num6 = (int) (num37 / numArray2[1]) - 11372730;
            continue;
          case 28:
            index1 += 3;
            uint num38 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 42U;
            numArray2[1] = uint.MaxValue + numArray2[0];
            numArray2[2] = 142U - numArray2[1] - numArray2[0];
            num6 = (int) (num38 / numArray2[2]) - 18312066;
            continue;
          case 29:
            num9 = num7 >> 15;
            num6 = 84;
            continue;
          case 30:
            index1 += 4;
            uint num39 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 62U;
            numArray2[1] = 116U - numArray2[0];
            numArray2[2] = 26U - numArray2[1] + numArray2[0];
            num6 = (int) (num39 / numArray2[2]) - 31776895;
            continue;
          case 31:
            numArray1[index2] = numArray1[(int) index4];
            num6 = 72;
            continue;
          case 32:
            numArray1[index2 + 2] = numArray1[(int) index4 + 2];
            uint num40 = num3;
            numArray2 = new uint[2]{ 59U, 0U };
            numArray2[1] = 85U - numArray2[0];
            num6 = (int) (num40 / numArray2[1]) - 41554421;
            continue;
          case 33:
            num6 = (int) (num3 / 222964316U) - -62;
            continue;
          case 34:
            ++num14;
            uint num41 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 97U;
            numArray2[1] = 4294967258U + numArray2[0];
            numArray2[2] = 125U + numArray2[1] - numArray2[0];
            num6 = (int) (num41 / numArray2[2]) - 12418519;
            continue;
          case 35:
            index2 += (int) num12;
            uint num42 = num3;
            numArray2 = new uint[2]{ 39U, 0U };
            numArray2[1] = 36U + numArray2[0];
            num6 = (int) (num42 / numArray2[1]) - 14405495;
            continue;
          case 36:
            num7 = (uint) ((int) numArray1[index3 + 1] | (int) numArray1[index3 + 2] << 8 | (int) numArray1[index3 + 3] << 16);
            uint num43 = num3;
            numArray2 = new uint[2]{ 99U, 0U };
            numArray2[1] = 4294967252U + numArray2[0];
            num6 = (int) (num43 / numArray2[1]) - 19643875;
            continue;
          case 37:
            ++index3;
            num6 = 68;
            continue;
          case 38:
            numArray3[index5] = index3;
            uint num44 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 85U;
            numArray2[1] = 153U - numArray2[0];
            numArray2[2] = 4294967203U + numArray2[1] + numArray2[0];
            num6 = (int) (num44 / numArray2[2]) - 18006507;
            continue;
          case 39:
            num7 = (uint) ((ulong) (num7 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) numArray1[index3 + 3] << 16));
            uint num45 = num3;
            numArray2 = new uint[2]{ 74U, 0U };
            numArray2[1] = 122U - numArray2[0];
            num6 = (int) (num45 / numArray2[1]) - 22508247;
            continue;
          case 40:
            num7 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16);
            uint num46 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 29U;
            numArray2[1] = 11U + numArray2[0];
            numArray2[2] = 24U + numArray2[1] - numArray2[0];
            num6 = (int) (num46 / numArray2[2]) - 30868610;
            continue;
          case 41:
            num7 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 | (int) obj0[index1 + 3] << 24);
            num6 = 444;
            continue;
          case 42:
            num6 = (int) (num3 / 1731808141U) - -1;
            continue;
          case 43:
            numArray1[index2] = obj0[index1];
            uint num47 = num3;
            numArray2 = new uint[2]{ 71U, 0U };
            numArray2[1] = 3U + numArray2[0];
            num6 = (int) (num47 / numArray2[1]) - 14599797;
            continue;
          case 44:
            ++index1;
            uint num48 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 84U;
            numArray2[1] = 110U - numArray2[0];
            numArray2[2] = 83U + numArray2[1] - numArray2[0];
            num6 = (int) (num48 / numArray2[2]) - 43216241;
            continue;
          case 45:
            int num49 = num10 != 1 ? 86 : (num49 = 444);
            num6 = num49 ^ (int) num3 / 120771201;
            continue;
          case 46:
            ++index3;
            num6 = 426;
            continue;
          case 47:
            index5 = (num13 >> 12 ^ num13) & 4095;
            uint num50 = num3;
            numArray2 = new uint[2]{ 92U, 0U };
            numArray2[1] = 4U + numArray2[0];
            num6 = (int) (num50 / numArray2[1]) - 11253919;
            continue;
          case 48:
            numArray4[index5] = (byte) 1;
            uint num51 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 35U;
            numArray2[1] = 83U - numArray2[0];
            numArray2[2] = 39U + numArray2[1] - numArray2[0];
            num6 = (int) (num51 / numArray2[2]) - 20776819;
            continue;
          case 49:
            num7 = (uint) ((ulong) (num7 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) obj0[index1 + 2] << 16));
            uint num52 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 47U;
            numArray2[1] = 13U + numArray2[0];
            numArray2[2] = 89U - numArray2[1] + numArray2[0];
            num6 = (int) (num52 / numArray2[2]) - 14215585;
            continue;
          case 50:
            num7 = (uint) ((ulong) (num7 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) obj0[index1 + 2] << 16) | (ulong) ((int) obj0[index1 + 3] << 24));
            num6 = 418;
            continue;
          case 51:
            int num53;
            num6 = num53 = num8 == 1U ? 416 : (num53 = 422);
            continue;
          case 52:
            num8 = 2147483648U;
            uint num54 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 90U;
            numArray2[1] = 130U - numArray2[0];
            numArray2[2] = 121U + numArray2[1] - numArray2[0];
            num6 = (int) (num54 / numArray2[2]) - 15216718;
            continue;
          case 53:
            ++index2;
            uint num55 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 90U;
            numArray2[1] = 4294967284U + numArray2[0];
            numArray2[2] = 4294967208U + numArray2[1] + numArray2[0];
            num6 = (int) (num55 / numArray2[2]) - 13504792;
            continue;
          case 54:
            num8 >>= 1;
            uint num56 = num3;
            numArray2 = new uint[2]{ 91U, 0U };
            numArray2[1] = 4294967236U + numArray2[0];
            num6 = (int) (num56 / numArray2[1]) - 34851751;
            continue;
          case 55:
            goto label_125;
          case 56:
            num12 = (uint) (((int) (num7 >> 2) & 31) + 2);
            uint num57 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 86U;
            numArray2[1] = 4294967264U + numArray2[0];
            numArray2[2] = 4294967220U + numArray2[1] + numArray2[0];
            num6 = (int) (num57 / numArray2[2]) - 16881399;
            continue;
          case 57:
            num11 = length - 6 - 4 - 1;
            uint num58 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 49U;
            numArray2[1] = 107U - numArray2[0];
            numArray2[2] = 167U - numArray2[1] - numArray2[0];
            num6 = (int) (num58 / numArray2[2]) - 18006938;
            continue;
          case 58:
            num6 = (int) (num3 / 122381320U) - -66;
            continue;
          case 59:
            index5 = (int) num7 >> 4 & 4095;
            uint num59 = num3;
            numArray2 = new uint[2]{ 86U, 0U };
            numArray2[1] = 145U - numArray2[0];
            num6 = (int) (num59 / numArray2[1]) - 18312029;
            continue;
          case 60:
            num12 = (uint) (((int) (num7 >> 7) & (int) byte.MaxValue) + 3);
            uint num60 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 95U;
            numArray2[1] = 149U - numArray2[0];
            numArray2[2] = 189U - numArray2[1] - numArray2[0];
            num6 = (int) (num60 / numArray2[2]) - 27010319;
            continue;
          case 61:
            destinationArray = new byte[length];
            uint num61 = num3;
            numArray2 = new uint[2]{ 39U, 0U };
            numArray2[1] = 43U + numArray2[0];
            num6 = (int) (num61 / numArray2[1]) - 13175817;
            continue;
          case 62:
            index4 = (uint) ((ulong) index2 - (ulong) num9);
            num6 = 107;
            continue;
          case 63:
            int num62 = ((int) num7 & 15) != 0 ? 120 : (num62 = 67);
            num6 = num62 ^ (int) num3 / 1600396368;
            continue;
          case 64:
            numArray1[index2 + 1] = numArray1[(int) index4 + 1];
            uint num63 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 58U;
            numArray2[1] = 100U - numArray2[0];
            numArray2[2] = 150U - numArray2[1] - numArray2[0];
            num6 = (int) (num63 / numArray2[2]) - 21608236;
            continue;
          case 65:
            goto label_10;
          case 66:
            num14 = 3;
            uint num64 = num3;
            numArray2 = new uint[2]{ 90U, 0U };
            numArray2[1] = 4294967244U + numArray2[0];
            num6 = (int) (num64 / numArray2[1]) - 28431921;
            continue;
          case 67:
            index1 += 2;
            uint num65 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 53U;
            numArray2[1] = 4294967280U + numArray2[0];
            numArray2[2] = 4294967288U + numArray2[1] + numArray2[0];
            num6 = (int) (num65 / numArray2[2]) - 13175696;
            continue;
          case 68:
            numArray1[index2 + num14] = numArray1[(long) index4 + (long) num14];
            num6 = 110;
            continue;
          case 69:
            goto label_48;
          case 70:
            int num66;
            num6 = num66 = (long) num14 < (long) num12 ? 76 : (num66 = 111);
            continue;
          case 71:
            num12 = (uint) obj0[index1 + 2];
            num6 = 126;
            continue;
          case 72:
            int num67 = num10 != 1 ? 99 : (num67 = 110);
            num6 = num67 ^ (int) num3 / 388442080;
            continue;
          case 73:
            num7 = 0U;
            uint num68 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 42U;
            numArray2[1] = 27U + numArray2[0];
            numArray2[2] = 23U + numArray2[1] - numArray2[0];
            num6 = (int) (num68 / numArray2[2]) - 21608327;
            continue;
          case 74:
            num6 = (int) (num3 / 667981451U) - -439;
            continue;
          case 75:
            num6 = (int) (num3 / 1291680263U) - -107;
            continue;
          case 76:
            index5 = ((int) (num7 >> 12) ^ (int) num7) & 4095;
            uint num69 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 88U;
            numArray2[1] = 4294967282U + numArray2[0];
            numArray2[2] = 70U - numArray2[1] + numArray2[0];
            num6 = (int) (num69 / numArray2[2]) - 12862009;
            continue;
          case 77:
            num8 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 | (int) obj0[index1 + 3] << 24);
            uint num70 = num3;
            numArray2 = new uint[2]{ 63U, 0U };
            numArray2[1] = 150U - numArray2[0];
            num6 = (int) (num70 / numArray2[1]) - 12418580;
            continue;
          case 78:
            numArray4[index5] = (byte) 1;
            uint num71 = num3;
            numArray2 = new uint[2]{ 98U, 0U };
            numArray2[1] = 4294967273U + numArray2[0];
            num6 = (int) (num71 / numArray2[1]) - 14405461;
            continue;
          case 79:
            num9 = (num7 & (uint) byte.MaxValue) >> 2;
            uint num72 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 79U;
            numArray2[1] = 174U - numArray2[0];
            numArray2[2] = 235U - numArray2[1] - numArray2[0];
            num6 = (int) (num72 / numArray2[2]) - 17711630;
            continue;
          case 80:
            int num73;
            num6 = num73 = (long) index3 >= (long) index2 - (long) num12 ? 96 : (num73 = 109);
            continue;
          case 81:
            numArray3 = new int[4096];
            uint num74 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 47U;
            numArray2[1] = 126U - numArray2[0];
            numArray2[2] = 4294967225U + numArray2[1] + numArray2[0];
            num6 = (int) (num74 / numArray2[2]) - 19643930;
            continue;
          case 82:
            num6 = (int) (num3 / 2048603273U) - -444;
            continue;
          case 83:
            ++index1;
            uint num75 = num3;
            numArray2 = new uint[2]{ 77U, 0U };
            numArray2[1] = 117U - numArray2[0];
            num6 = (int) (num75 / numArray2[1]) - 27010300;
            continue;
          case 84:
            index3 = index2 - 1;
            num6 = 102;
            continue;
          case 85:
            int num76 = index2 > num11 ? 7 : (num76 = 5);
            num6 = num76 ^ (int) num3 / 391984023;
            continue;
          case 86:
            int num77;
            num6 = num77 = index2 > num11 ? 410 : (num77 = 103);
            continue;
          case 87:
            int num78;
            num6 = num78 = ((int) num7 & 2) == 0 ? 114 : (num78 = 112);
            continue;
          case 88:
            ++index2;
            uint num79 = num3;
            numArray2 = new uint[2]{ 63U, 0U };
            numArray2[1] = 4294967269U + numArray2[0];
            num6 = (int) (num79 / numArray2[1]) - 30011484;
            continue;
          case 89:
            int num80 = num10 != 1 ? 2 : (num80 = 3);
            num6 = num80 ^ (int) num3 / 1635003183;
            continue;
          case 90:
            num8 >>= 1;
            uint num81 = num3;
            numArray2 = new uint[2]{ 41U, 0U };
            numArray2[1] = 4U + numArray2[0];
            num6 = (int) (num81 / numArray2[1]) - 24009166;
            continue;
          case 91:
            num12 = 3U;
            uint num82 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 42U;
            numArray2[1] = 41U + numArray2[0];
            numArray2[2] = 138U - numArray2[1] + numArray2[0];
            num6 = (int) (num82 / numArray2[2]) - 11138204;
            continue;
          case 92:
            num6 = (int) (num3 / 845956952U) - -429;
            continue;
          case 93:
            num7 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16);
            uint num83 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 89U;
            numArray2[1] = 2U + numArray2[0];
            numArray2[2] = 54U + numArray2[1] - numArray2[0];
            num6 = (int) (num83 / numArray2[2]) - 19293157;
            continue;
          case 94:
            num13 = (int) numArray1[index3] | (int) numArray1[index3 + 1] << 8 | (int) numArray1[index3 + 2] << 16;
            uint num84 = num3;
            numArray2 = new uint[2]{ 67U, 0U };
            numArray2[1] = 147U - numArray2[0];
            num6 = (int) (num84 / numArray2[1]) - 13505122;
            continue;
          case 95:
            num6 = (int) (num3 / 1901927933U) - -74;
            continue;
          case 96:
            numArray3[index5] = index3;
            uint num85 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 98U;
            numArray2[1] = 128U - numArray2[0];
            numArray2[2] = 113U + numArray2[1] - numArray2[0];
            num6 = (int) (num85 / numArray2[2]) - 24009179;
            continue;
          case 97:
            num8 = 1U;
            uint num86 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 79U;
            numArray2[1] = 159U - numArray2[0];
            numArray2[2] = 4294967209U + numArray2[1] + numArray2[0];
            num6 = (int) (num86 / numArray2[2]) - 15005778;
            continue;
          case 98:
            int num87;
            num6 = num87 = index3 >= index2 - 3 ? 89 : (num87 = 90);
            continue;
          case 99:
            num9 = (num7 & (uint) ushort.MaxValue) >> 6;
            uint num88 = num3;
            numArray2 = new uint[2]{ 51U, 0U };
            numArray2[1] = 81U - numArray2[0];
            num6 = (int) (num88 / numArray2[1]) - 36013788;
            continue;
          case 100:
            num6 = (int) (num3 / 1032625588U) - 0;
            continue;
          case 101:
            num7 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 | (int) obj0[index1 + 3] << 24);
            num6 = 5;
            continue;
          case 102:
            num6 = (int) (num3 / 1606591300U) - -1;
            continue;
          case 103:
            index1 += 2;
            uint num89 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 57U;
            numArray2[1] = 111U - numArray2[0];
            numArray2[2] = 28U + numArray2[1] - numArray2[0];
            num6 = (int) (num89 / numArray2[2]) - 43216563;
            continue;
          case 104:
            index1 += 4;
            uint num90 = num3;
            numArray2 = new uint[2]{ 77U, 0U };
            numArray2[1] = 17U + numArray2[0];
            num6 = (int) (num90 / numArray2[1]) - 11493706;
            continue;
          case 105:
            goto label_40;
          case 106:
            numArray1[index2] = obj0[index1];
            num6 = 93;
            continue;
          case 107:
            int num91;
            num6 = num91 = ((int) num7 & (int) sbyte.MaxValue) != 3 ? 119 : (num91 = 117);
            continue;
          case 108:
            ++index1;
            uint num92 = num3;
            numArray2 = new uint[2]{ 33U, 0U };
            numArray2[1] = 59U + numArray2[0];
            num6 = (int) (num92 / numArray2[1]) - 11743581;
            continue;
          case 109:
            num8 >>= 1;
            uint num93 = num3;
            numArray2 = new uint[3];
            numArray2[0] = 63U;
            numArray2[1] = 26U + numArray2[0];
            numArray2[2] = 93U - numArray2[1] + numArray2[0];
            num6 = (int) (num93 / numArray2[2]) - 16125505;
            continue;
          case 110:
            int num94;
            num6 = num94 = index2 > length - 1 ? 83 : (num94 = 95);
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      num1 = 192240111;
    }
label_40:
    throw new ArgumentException("C# version only supports level 1 and 3");
label_48:
    return destinationArray;
label_125:
    return numArray1;
  }
}
