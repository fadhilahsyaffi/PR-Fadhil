using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01
{
    class soal08
    {
        public soal08(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b >= k && b + k <= n - 1 || b <= k && b + k >= n - 1)
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
