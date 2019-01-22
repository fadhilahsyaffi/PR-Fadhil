using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = (n * n + n) / 2;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                // StartPoint
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = (JumlahKolom - bangun - StarBar - 1);

                //End Point
                int EndBar = StarBar + bangun;
                int EndKol = (JumlahKolom + bangun - EndBar - 1);
                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
