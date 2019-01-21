using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR04
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n * 2 - 1;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            for (int b = 0; b < JumlahBaris; b++)
            {
                int nilaiawal = 1;
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (k >= b && b + k <= JumlahKolom - 1)
                    {
                        Array2D[b, k] = nilaiawal++.ToString();
                    }
                }
            }
        }
    }
}
