using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibo(JumlahKolom);
            int ascii = 64;

            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b <= k && b + k <= JumlahBaris - 1)
                    {
                        Array2D[b, k] = b % 2 == 0 ? fibo[b / 2].ToString() : ((char)(ascii + (b + 1) / 2)).ToString();
                        Array2D[JumlahKolom - 1 - b, k] = b % 2 == 0 ? fibo[b / 2].ToString() : ((char)(ascii + (b + 1) / 2)).ToString();
                        /*if (b % 2 == 0)
                        {
                            Array2D[b, k] = fibo[b / 2].ToString();
                            Array2D[jmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                        }
                        else
                        {
                            Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                            Array2D[b, jmlhKolom - 1 - k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        }*/

                    }
                    else if (b >= k && b + k <= JumlahKolom - 1)
                    {
                        Array2D[b, k] = k % 2 == 0 ? fibo[k / 2].ToString() : ((char)(ascii + (k + 1) / 2)).ToString();
                        Array2D[b, JumlahKolom - 1 - k] = k % 2 == 0 ? fibo[k / 2].ToString() : ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}

