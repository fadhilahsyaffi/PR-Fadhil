using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int deret = (n + 1) / 2;
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
                            int angka = deret;
                            for (int k = StarKol; k <= EndKol; k++)
                            {
                                if ((b - StarBar) + (k - StarKol) >= n / 2 && (k - StarKol) - (b - StarBar) <= n / 2 && b - StarBar <= n / 2)
                                {
                                    if (k < (StarKol + EndKol) / 2)
                                    {
                                        Array2D[b, k] = angka.ToString();
                                        Array2D[EndBar - b + StarBar, k] = angka.ToString();
                                        angka--;
                                    }
                                    else
                                    {
                                        Array2D[b,k] = angka.ToString();
                                        Array2D[EndBar- b + StarBar,k]= angka.ToString();
                                        angka++;
                                    }
                                }
                            }
                        }
                    }
                }
                    deret = deret + ((n+1)/2);
            }
        }
    }
}
