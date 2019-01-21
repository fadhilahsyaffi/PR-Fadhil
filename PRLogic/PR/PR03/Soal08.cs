using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {

            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b <= k && b + k <= JumlahBaris - 1 && b % 2 == 0)
                    {
                        Array2D[b, k] = (b + 1).ToString();
                        Array2D[JumlahBaris - 1 - b, k] = (b + 1).ToString();
                    }
                    else if (b >= k && b + k <= JumlahBaris - 1 && k % 2 == 0)
                    {
                        Array2D[b, k] = (k + 1).ToString();
                        Array2D[b, JumlahKolom - 1 - k] = (k + 1).ToString();
                    }
                }
            }
        }
    }
}
