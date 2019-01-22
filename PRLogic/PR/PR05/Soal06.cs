using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class Soal06 : LogicBase
    {
        public Soal06(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = (n * n + n) / 2;
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
                int StarKol = StarBar;
                // Ending Point
                int EndBar = StarBar + bangun;
                int EndKol = EndBar;

                for (int b = StarBar; b <= EndBar; b++)
                {
                    int angka = 1;
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        Array2D[b, k] = angka++.ToString();
                    }
                }
            }

        }
    }
}
