using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR02
{
    class Soal10
    {
        public Soal10(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (b <= jB / 2)
                    {
                        Console.Write("{0}\t", b * 2);
                    }
                    else if (b > jB / 2) 
                    {
                        Console.Write("{0}\t", (jB - b - 1) * 2);
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
