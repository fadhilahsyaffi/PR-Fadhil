using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class LatihanKoding07 : LogicBase
    {
        public LatihanKoding07(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n * 2 - 1;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] Fibo = FunctionBase.Fibo(JumlahKolom);
            int[] Tribo = FunctionBase.Tribo(JumlahKolom);
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b == k)
                    {
                        Array2D[b, k] = Fibo[k].ToString();
                        Array2D[b, JumlahKolom - 1 - k] = Fibo[b].ToString();
                    }
                    else if (b+k == JumlahBaris - 1)
                    {
                        Array2D[b, k] = Tribo[k].ToString();
                        Array2D[b, JumlahKolom - 1 - k] = Tribo[b].ToString();
                    }
                    else if(b>=k && b+k <= JumlahBaris-1 && b-k != 1 && b+k != JumlahBaris - 2)
                    {
                        Array2D[b, k] = "A";
                        Array2D[b, JumlahKolom - 1 - k] = "A";
                    }
                }
            }
        }
    }
}
