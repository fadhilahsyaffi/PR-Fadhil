using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class LatihanKoding06 : LogicBase
    {
        public LatihanKoding06(int n)
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
            int angka = 1;
            for (int bangun = 0; bangun < n; bangun++)
            {
                //posisi
                int StarBar = JumlahKolom - ((bangun * bangun + bangun) / 2) - bangun - 1;
                int StarKol = JumlahKolom - StarBar - bangun - 1;
                int EndBar = JumlahBaris - StarKol - 1;
                int EndKol = JumlahKolom - StarBar - 1;

                // arah
                bool kanan = true;
                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (kanan)
                            Array2D[b, k] = angka++.ToString();
                        else
                            Array2D[b, EndKol - k + StarKol] = angka++.ToString();
                    }
                    kanan = !kanan;
                }
            }
        }
    }
}
