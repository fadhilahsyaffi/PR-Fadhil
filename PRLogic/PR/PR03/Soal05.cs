using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal05: LogicBase
    {
        public Soal05(int n)
        {
        JumlahBaris = n;
        JumlahKolom = n;
        Array2D = new string[JumlahBaris, JumlahKolom];
        IsiArray();
        FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            int[] Fibo = FunctionBase.FiboBalik(JumlahKolom);
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if((b <= k || b + k >= JumlahKolom - 1))
                    Array2D[b, k] = Fibo[k].ToString();
                }
            }
        }
    }
}
