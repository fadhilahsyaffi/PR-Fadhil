using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class SoalPR01 : LogicBase
    {
        public SoalPR01(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = (n * n);
            Array2D = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Soal01(n * n);
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StarBar = (bangun * bangun + bangun) / 2 + (n - bangun) * bangun;
                int StarKol = (n - 1 - bangun) * (n - 1 - bangun);
                int angka = 0;
                int endBar = StarBar + (n - 1 - bangun);
                int endKol = StarKol + ((n - 1 - bangun) * 2);
                for (int b = StarBar; b <= endBar; b++)
                {
                    for (int k = StarKol; k <= endKol; k++)
                    {
                        if (b + k >= StarKol + endBar && k + endBar <= b + endKol)
                        {
                            Array2D[b, k] = fibo[angka++].ToString();
                        }
                    }

                }
            }
        }
    }
}
