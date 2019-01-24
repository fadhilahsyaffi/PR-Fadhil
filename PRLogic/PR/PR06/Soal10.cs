using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int StarKol = b % 2 == 0 ? 0 : JumlahBaris - 1 - b;
                int EndKol = StarKol + b;

                for (int k = StarKol; k <= EndKol; k++)
                {
                    Array2D[b, k] = (b + 1).ToString();
                }
            }
        }
    }
}
