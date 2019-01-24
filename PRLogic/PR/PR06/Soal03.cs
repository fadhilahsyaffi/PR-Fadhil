using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal03 : LogicBase
    {
        public Soal03(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = (n * 2 - 1) * 2;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] Fibo = FunctionBase.Fibo(JumlahKolom * JumlahKolom);
            for (int bangun = 0; bangun < n; bangun++)
            {
                //Start End
                int StarBar = n * bangun;
                int StarKol = bangun % 2 * (n * 2 - 1);
                int EndBar = StarBar + (n - 1);
                int EndKol = StarKol + 2 * (n - 1);

                // Index Fibo
                int index = 0;
                int ganjil = 1;
                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b + k >= StarKol + EndBar && k - b <= EndKol - EndBar)
                        {
                            if (bangun % 2 == 0)
                            {
                                //if (b + k >= StarKol + EndBar && k - b <= EndKol - EndBar)
                                Array2D[b, k] = Fibo[index++].ToString();
                            }
                            else
                                Array2D[b, k] = ganjil.ToString();
                            ganjil += 2;
                        }
                    }
                }
            }
        }
    }
}
