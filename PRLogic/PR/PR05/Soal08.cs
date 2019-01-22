using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR05
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = (n * n + n) / 2;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            // value
            int ganjil = 1;
            int genap = 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                // Starting Point
                int StarBar = (bangun * bangun + bangun) / 2;
                int StarKol = StarBar;
                // Ending Point
                int EndBar = StarBar + bangun;
                int EndKol = EndBar;

                //Flow
                //bool kanan = true;
                string arah = "kanan";

                for (int b = StarBar; b <= EndBar; b++)
                {
                    for (int k = StarKol; k <= EndKol; k++)
                    {
                        if (arah == "kanan")
                        {
                            if (bangun % 2 == 0)
                                Array2D[b, k] = ganjil.ToString();
                            else
                                Array2D[b, k] = genap.ToString();
                        }
                        else
                        {
                            if (bangun % 2 == 0)
                                Array2D[b, EndKol - k + StarKol] = ganjil.ToString();
                            else
                                Array2D[b, EndKol - k + StarKol] = genap.ToString();
                        }
                        if (bangun % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;
                    }
                    // kanan = !kanan;
                    if (arah == "kanan")
                        arah = "kiri";
                    else
                        arah = "kanan";
                }

            }
        }
    }
}
