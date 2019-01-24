using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class PR01 : LogicBase
    {
        public PR01(int n)
        {
            JumlahBaris = 2 * n + (n * 2 - 1);
            JumlahKolom = JumlahBaris;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int StarKol = n;
                int EndKol = StarKol + 2 * n - 1;

                for (int k = StarKol; k <=EndKol; k++)
                {
                    if (b + (k-StarKol) >= (EndKol -StarKol) /2 && (k-StarKol) - b <= (EndKol-StarKol)/2)
                    {
                        //atas
                        Array2D[b, k] = "*";
                        //kiri
                        Array2D[k, b] = "*";
                        //kanan
                        Array2D[k, JumlahBaris - 1 - b] = "*";
                        //bawah
                        Array2D[JumlahBaris - 1 - b, k] = "*";
                    }
                }
            }
        }
    }
}
