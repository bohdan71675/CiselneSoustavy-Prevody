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
            string dec = BinToDec(int.Parse(bin));
            string hex = DecToHex(int.Parse(dec));
            return hex;
        }
        public string HexToBin(string hex)
        {
            string dec = HexToDec(hex).ToString();
            string bin = DecToBin(int.Parse(dec));
            return bin;
        }
    }
}

