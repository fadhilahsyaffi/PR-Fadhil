using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;
namespace PR05
{
    class LatihanKoding04 : LogicBase
    {
        public LatihanKoding04(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = (n * n + n) / 2;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //value
            int genap = 2;
            int ganjil = 1;
            for (int bangun = 0; bangun < n; bangun++)
            {
                //StarPoint
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = JumlahKolom - bangun - StarBar - 1;
                // End Point
                int EndBar = JumlahBaris - StarKol - 1;
                int EndKol = (JumlahKolom + bangun - EndBar - 1);
                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if(b == StarBar || b == EndBar || k == StarKol || k == EndKol)
                        if (bangun % 2 == 0)
                        {
                            Array2D[b, k] = ganjil.ToString();
                            ganjil += 2;
                        }
                        else
                        {
                            Array2D[b, k] = genap.ToString();
                            genap += 2;
                        }
                    }
                }
            }
        }

    }
}
