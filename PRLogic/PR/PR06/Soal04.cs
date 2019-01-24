using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal04 : LogicBase
    {
        public Soal04(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int ganjil = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    bool kanan = true;
                    int StarBar = bb * n;
                    int StarKol = bk * n;
                    int EndBar = StarBar + n - 1;
                    int EndKol = StarKol + n - 1;

                    for (int b = StarBar; b <= EndBar; b++)
                    {
                        for (int k = StarKol; k <= EndKol; k++)
                        {
                            if (bb == bk)
                            {
                                if (kanan)
                                {
                                    Array2D[b, k] = ganjil.ToString();
                                }
                                else
                                {
                                    Array2D[b, EndKol - k + StarKol] = ganjil.ToString();
                                }
                                ganjil += 2;
                            }
                        }
                        kanan = !kanan;
                    }
                }
            }
        }
    }
}
