using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal06 : LogicBase
    {
        public Soal06(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int StarBar = bb * n;
                        int StarKol = bk * n;
                        int EndBar = StarBar + n - 1;
                        int EndKol = StarKol + n - 1;
                        for (int b = StarBar; b <= EndBar; b++)
                        {
                            for (int k = StarKol; k <= EndKol; k++)
                            {
                                if ((b - StarBar) + (k - StarKol) >= n / 2 && (k - StarKol) - (b - StarBar) <= n / 2)
                                {
                                    Array2D[b, k] = "*";
                                    Array2D[EndBar - (b - StarBar), k] = "*";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
