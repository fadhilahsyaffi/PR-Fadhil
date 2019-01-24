using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR04
{
    class LatihanKoding03 : LogicBase
    {
        public LatihanKoding03(int n1, int n2)
        {
            JumlahBaris = n1;
            JumlahKolom = (n1 * n2) - (n2 - 1);
            Array2D = new string[JumlahBaris, JumlahKolom];
            isiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }
        private void isiArray(int n2)
        {
            for (int bgn = 0; bgn < n2; bgn++)
            {
                for (int b = 0; b < JumlahBaris; b++)
                {
                    for (int k = 0; k < JumlahKolom; k++)
                    {
                        if ((b + k == JumlahBaris / 2 || k - b == JumlahBaris / 2) && b <= JumlahBaris / 2)
                        {
                            Array2D[b, k + (JumlahBaris - 1) * bgn] = "A";
                            Array2D[JumlahBaris - 1 - b, k + (JumlahBaris - 1) * bgn] = "A";
                        }
                    }
                }
            }
        }
    }
}
