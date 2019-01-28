using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR07
{
    class Soal03 : LogicBase
    {
        public Soal03(int n)
        {
            JumlahBaris = n * 2 + 1;
            JumlahKolom = ((n * 2) - 1) + n * 2;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StarBar = bangun * 2;
                int StarKol = StarBar;
                int EndBar = JumlahBaris - 1;
                int EndKol = JumlahKolom - EndBar;

                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (b == StarBar || k == StarKol)
                        {
                            Array2D[b, k] = "*";
                            //Array2D[b, JumlahKolom - 1 - k] = "*";
                        }
                    }
                }
            }
        }
    }
}
