using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR04
{
    class Latihankoding02 : LogicBase
    {
        public Latihankoding02(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] Fibo = FunctionBase.Fibo(JumlahBaris * JumlahKolom);
            int[] Tribo = FunctionBase.Tribo(JumlahBaris * JumlahKolom);
            int nilai = 0;
            for (int b = 0; b < JumlahBaris; b++)
            {
            int ascii = 65;
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b + k >= JumlahBaris / 2 && k - b <= JumlahBaris / 2 && b < JumlahBaris / 2)
                    {
                        Array2D[b, k] = Fibo[nilai].ToString();
                        Array2D[JumlahBaris - 1 - b, k] = Tribo[nilai].ToString();
                        nilai++;
                    }
                    else if (b == JumlahBaris / 2 && k <= JumlahKolom / 2)
                    {
                        Array2D[b,k] = ((char)ascii).ToString();
                        Array2D[b, JumlahKolom - 1 - k] = ((char)ascii).ToString();
                        ascii++;
                    }
                }
            }
        }
    }
}

