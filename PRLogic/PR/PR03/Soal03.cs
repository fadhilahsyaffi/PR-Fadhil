using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal03 : LogicBase
    {
        public Soal03 (int n)
	{
            JumlahBaris = 1;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
	}
         private void IsiArray()
        {

            for (int b = 0; b < JumlahBaris; b++)
            {
                int[] Tribo = FunctionBase.FiboBalik(JumlahKolom);
                for (int k = 0; k < JumlahKolom; k++)
                {
                    Array2D[0, k] = Tribo[k].ToString();
                }
            }
        }
    }
}
