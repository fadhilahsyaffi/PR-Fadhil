using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR07
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
        {
            JumlahBaris = 2 * n + (n * 2 - 1);
            JumlahKolom = JumlahBaris;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < JumlahBaris; b++)
            {
                int StarKol = n;
                int EndKol = StarKol + 2 * n - 1;
                for (int k = StarKol; k <= EndKol; k++)
                {
                    if ((k - StarKol) - b <= (EndKol - StarKol) / 2 && b + (k - StarKol) >= (EndKol - StarKol) / 2 && b <= n - 1)
                    {
                        Array2D[b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[k, JumlahBaris - 1 - b] = "*";
                        Array2D[JumlahBaris - 1 - b, k] = "*";
                    }
                }
            }
        }
    }
}
