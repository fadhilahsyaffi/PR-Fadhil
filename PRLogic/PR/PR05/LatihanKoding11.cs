using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class LatihanKoding11 : LogicBase
    {
        public LatihanKoding11(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = n * n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StarBar = (JumlahBaris - bangun) - ((bangun * bangun + bangun) / 2) - 1;
                //int StarBar = JumlahBaris - 1 - (bangun * bangun + bangun) / 2 + bangun;
                int StarKol = n + StarBar - (bangun * bangun + bangun) / 2;
                //int StarKol = (JumlahKolom - 1) - (bangun * bangun) - (bangun * 2);
                int EndBar = StarBar + bangun;
                //int EndBar = StarBar - bangun;
                int EndKol = StarKol + bangun * 2;

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
