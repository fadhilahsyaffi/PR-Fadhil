using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = n * 2 - 1;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int[] Fibo = FunctionBase.Soal01(JumlahKolom * n);
                int index = 0;
                int ganjil = 1;
                //Starting point
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = (n * 2 - 1) / 2 - bangun;

                //Ending Point
                int EndBar = StarBar + bangun;
                int EndKol = StarKol + (bangun * 2);


                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b - k >= EndBar - EndKol && b + k >= EndBar + StarKol)
                        {
                            if (bangun % 2 == 0)
                            {
                                Array2D[b, k] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                                Array2D[b, k] = Fibo[index++].ToString();
                        }

                    }
                }
            }
        }

    }
}
