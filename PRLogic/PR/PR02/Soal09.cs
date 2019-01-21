using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR02
{
    class Soal09
    {
        public Soal09(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (k <= jK / 2)
                    {
                        Console.Write("{0}\t", k * 2 + 1);
                    }
                    else if (k > jK / 2)
                    {
                        Console.Write("{0}\t", (jB - k) * 2 - 1);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
