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
                if(cislo == 1)
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

            for(int i = 0; dec > 0; i++)
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
            double dec = 0;
            for(int i = 0; i < hex.Length - 1; i++)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    int cislo = int.Parse(hex[i].ToString());
                    dec += Math.Pow(16, i) * cislo;

                }
                else if (hex[i] == 'A')
                {
                    dec += Math.Pow(16, i) * 10;
                }
                else if (hex[i] == 'B')
                {
                    dec += Math.Pow(16, i) * 11;
                }
                else if (hex[i] == 'C')
                {
                    dec += Math.Pow(16, i) * 12;
                }
                else if (hex[i] == 'D')
                {
                    dec += Math.Pow(16, i) * 13;
                }
                else if (hex[i] == 'E')
                {
                    dec += Math.Pow(16, i) * 14;
                }
                else if (hex[i] == 'F')
                {
                    dec += Math.Pow(16, i) * 15;
                }

            }
            return dec.ToString();
        }
    }
}
