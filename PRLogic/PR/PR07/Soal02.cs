using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR07
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            JumlahBaris = 2 * n + (n * 2 - 1);
            JumlahKolom = JumlahBaris;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int ganjil = 1;
            int[] Fibo = FunctionBase.Fibo(JumlahBaris*JumlahBaris);
            int[] Tribo = FunctionBase.Tribo(JumlahBaris*JumlahBaris);
            int fb = 0;
            int tb = 0;
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    //atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2D[b, k] = ganjil.ToString();
                        ganjil += 2;
                    }
                    else if(b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= JumlahBaris - n)
                    {
                        Array2D[b, k] = ganjil.ToString();
                        ganjil += 2;
                    }
                        //kiri
                    else if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2D[b, k] = Fibo[fb++].ToString();
                    }
                        //kanan
                    else if(k-b<=n*2-1 && b+k<=(n*2-1)+(n*3)+n-2&&k>= JumlahKolom-n)
                    {
                        Array2D[b, k] = Tribo[tb++].ToString();
                    }
                }
            }
        }
    }
}
