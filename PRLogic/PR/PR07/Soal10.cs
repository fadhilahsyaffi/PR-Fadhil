using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR07
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == 0 || bk == 0 || bb == n - 1 || bk == n - 1)
                    {
                        int StarBar = bb * n;
                        int StarKol = bk * n;
                        int EndBar = StarBar + n - 1;
                        int EndKol = StarKol + n - 1;

                        for (int b = StarBar; b <= EndBar; b++)
                        {
                            for (int k = StarKol; k <= EndKol; k++)
                            {
                                if (b - StarBar == k - StarKol || b == EndBar || k == StarKol)
                                    Array2D[b, k] = angka.ToString();
                            }
                        }
                        angka++;
                    }
                }
            }
        }
    }
}
