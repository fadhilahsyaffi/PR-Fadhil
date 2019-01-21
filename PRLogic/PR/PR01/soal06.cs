using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01
{
    class soal06
    {
        public soal06(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b >= k)
                    {
                        Console.Write("*  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
