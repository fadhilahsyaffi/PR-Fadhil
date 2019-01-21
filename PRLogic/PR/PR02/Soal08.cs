using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR02
{
    class Soal08
    {
        public Soal08(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (b == k)
                    {
                        //diagonal kiri
                        Console.Write("{0}\t", k * 2 + 1);
                    }
                    else if (b + k == jB - 1)
                    {
                        //diagonal kanan
                        Console.Write("{0}\t", k * 2);
                    }
                    else if (b >= k && b + k <= jB - 1)
                    {
                        //sisi kiri
                        Console.Write("{0}\t", "A");
                    }
                    else if (b <= k && b + k >= jB - 1)
                    {
                        //sisi kanan
                        Console.Write("{0}\t", "B");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n");
            }
        }
    }
}
