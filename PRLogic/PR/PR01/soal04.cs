using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01
{
    class soal04
    {
        public soal04()
        {
            Console.Write("Masukkan nilai n: ");
            int n = int.Parse(Console.ReadLine());
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1 || b == n / 2 || k == n / 2)
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
            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
    }
}
