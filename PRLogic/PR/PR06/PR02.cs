using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR06
{
    class PR02 : LogicBase
    {
        public PR02(int n)
        {
            JumlahBaris = n + 2;
            JumlahKolom = 3 * n + (n * (n - 1) / 2);
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int stBrs = n - bangun - 1;
                int stKol = JumlahKolom - 1 - (bangun * 3 + (bangun * (bangun - 1) / 2)) - (bangun + 2);
                int endBrs = n + 1;
                int endKol = stKol + 2 + bangun;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if ((b - stBrs) + (k - stKol) == endKol - stKol || b == stBrs || k == stKol)
                            Array2D[b, k] = (JumlahKolom - k).ToString();
                    }
                }
            }
        }
    }
}
