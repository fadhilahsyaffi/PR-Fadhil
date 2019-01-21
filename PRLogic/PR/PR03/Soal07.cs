using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal07 : LogicBase
    {
        public Soal07(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            int[] Fibo = FunctionBase.Soal03(JumlahKolom);
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b <= k && b + k <= JumlahBaris - 1)
                    {
                        Array2D[b, k] = Fibo[b].ToString();
                        Array2D[JumlahBaris - 1 - b, k] = Fibo[b].ToString();
                    }
                    else if (b < k && b + k >= JumlahBaris - 1)
                    {
                        Array2D[b, k] = Fibo[k].ToString();
                        Array2D[b, JumlahKolom - 1 - k] = Fibo[k].ToString();
                    }
                }

            }
        }
    }
}
