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


    }
}
