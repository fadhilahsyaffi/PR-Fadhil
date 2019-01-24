using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class LatihanKoding10 : LogicBase
    {
        public LatihanKoding10(int n)
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
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = JumlahKolom - bangun - StarBar - 1;
                int EndBar = JumlahKolom - StarKol - 1;
                int EndKol = StarKol + EndBar - StarBar;

                int angka = 1;
                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b - k <= EndBar - EndKol)
                            Array2D[b, k] = angka++.ToString();
                    }
                }
            }
        }
    }
}
