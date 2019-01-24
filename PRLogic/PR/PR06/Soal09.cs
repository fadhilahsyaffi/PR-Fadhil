using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            JumlahBaris = n + 2; ;
            JumlahKolom = (n * 3) + (n * (n - 1) / 2);
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 1;
            int deret = 1;
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StarBar = n - bangun - 1;
                int StarKol = (bangun * 3) + (bangun * (bangun - 1) / 2);
                int EndBar = n + 1;
                int EndKol = StarKol + 2 + bangun;
                for (int b = StarBar; b <= EndBar; b++)
                {
                    angka = deret;
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b + k == StarBar + EndKol || k == EndKol || b == EndBar)

                            Array2D[b, k] = angka.ToString();
                        angka++;
                    }
                }
                deret = angka;
            }
        }
    }
}
