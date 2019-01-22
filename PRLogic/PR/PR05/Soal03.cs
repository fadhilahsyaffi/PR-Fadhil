using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class Soal03 : LogicBase
    {
        public Soal03(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n); 
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                // Starting Point
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = bangun * bangun;
                // Ending Point
                int EndBar = StarBar + bangun;
                int EndKol = StarKol +(bangun*2);

                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b + k >= StarKol + EndBar && k + EndBar <= b + EndKol)
                        Array2D[b, k] = "*";
                    }
                }
            }

        }
    }
}
