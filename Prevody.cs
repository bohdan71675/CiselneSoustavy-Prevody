using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiselneSoustavy
{
    class Prevody
    {
        public string BinToDec(int bin)
        {
            double dec = 0;
            for (int i = 0; bin > 0; i++)
            {
                int cislo = bin % 10;
                if (cislo == 1)
                {
                    dec += Math.Pow(2, i);
                }
                bin = bin / 10;
            }

            return dec.ToString();
        }

        public string DecToBin(int dec)
        {
            string bin = "";

            for (int i = 0; dec > 0; i++)
            {
                if (dec % 2 == 1)
                {
                    bin = bin.Insert(0, "1");
                }
                else
                {
                    bin = bin.Insert(0, "0");
                }
                dec = dec / 2;
            }

            return bin;
        }

        public string HexToDec(string hex)
        {
            int moc = 1;
            int dec = 0;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    dec += (hex[i] - '0') * moc;
                    moc = moc * 16;
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    dec += (hex[i] - '7') * moc;
                    moc = moc * 16;
                }
            }
            return dec.ToString();
        }

        public string DecToHex(int dec)
        {
            string hex = "";
            int zbytek;
            while (dec > 0)
            {
                zbytek = dec % 16;
                if (zbytek >= 0 && zbytek <= 9)
                {
                    hex = hex.Insert(0, zbytek.ToString());
                }
                else
                {
                    char znak = (char)('A' + zbytek - 10);
                    hex = hex.Insert(0, znak.ToString());

                }

                dec /= 16;
            }
            return hex;
        }

        public string BinToHex(string bin)
        {
            //string dec = BinToDec(int.Parse(bin));
            //string hex = DecToHex(int.Parse(dec));
            int delka = bin.Length - 1;
            string hex = "";

            while (delka % 4 != 0)
            {
                bin = bin.Insert(0, "0");
                delka++;
            }

            while (delka > 0)
            {
                string substring = bin.Substring(bin.Length - 4, 4);
                bin = bin.Remove(bin.Length - 4, 4);
                delka -= 4;

                switch (substring)
                {
                    case "0000": hex = hex.Insert(0, "0"); break;
                    case "0001": hex = hex.Insert(0, "1"); break;
                    case "0010": hex = hex.Insert(0, "2"); break;
                    case "0011": hex = hex.Insert(0, "3"); break;
                    case "0100": hex = hex.Insert(0, "4"); break;
                    case "0101": hex = hex.Insert(0, "5"); break;
                    case "0110": hex = hex.Insert(0, "6"); break;
                    case "0111": hex = hex.Insert(0, "7"); break;
                    case "1000": hex = hex.Insert(0, "8"); break;
                    case "1001": hex = hex.Insert(0, "9"); break;
                    case "1010": hex = hex.Insert(0, "A"); break;
                    case "1011": hex = hex.Insert(0, "B"); break;
                    case "1100": hex = hex.Insert(0, "C"); break;
                    case "1101": hex = hex.Insert(0, "D"); break;
                    case "1110": hex = hex.Insert(0, "E"); break;
                    case "1111": hex = hex.Insert(0, "F"); break;
                    default:
                        return "Spatne cislo";
                }
            }

            return hex.ToString();
        }
        public string HexToBin(string hex)
        {
            //string dec = HexToDec(hex).ToString();
            //string bin = DecToBin(int.Parse(dec));
            int delka = hex.Length - 1;
            string bin = "";

            for (int i = 0; i <= delka; i++)
            {
                switch (hex[i])
                {
                    case '0': bin = bin.Insert(bin.Length, "0000"); break;
                    case '1': bin = bin.Insert(bin.Length, "0001"); break;
                    case '2': bin = bin.Insert(bin.Length, "0010"); break;
                    case '3': bin = bin.Insert(bin.Length, "0011"); break;
                    case '4': bin = bin.Insert(bin.Length, "0100"); break;
                    case '5': bin = bin.Insert(bin.Length, "0101"); break;
                    case '6': bin = bin.Insert(bin.Length, "0110"); break;
                    case '7': bin = bin.Insert(bin.Length, "0111"); break;
                    case '8': bin = bin.Insert(bin.Length, "1000"); break;
                    case '9': bin = bin.Insert(bin.Length, "1001"); break;
                    case 'A': bin = bin.Insert(bin.Length, "1010"); break;
                    case 'B': bin = bin.Insert(bin.Length, "1011"); break;
                    case 'C': bin = bin.Insert(bin.Length, "1100"); break;
                    case 'D': bin = bin.Insert(bin.Length, "1101"); break;
                    case 'E': bin = bin.Insert(bin.Length, "1110"); break;
                    case 'F': bin = bin.Insert(bin.Length, "1111"); break;
                    default:
                        return "Spatne cislo";
                }
            }


            return bin;
        }
    }
}

