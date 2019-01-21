using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class SoalPR : LogicBase
    {
        public SoalPR(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n * 2 - 1;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int ascii = 65;
            int [] Fibo = FunctionBase.Soal01(JumlahKolom);
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    //diagonal
                    if (b == k)
                    {
                        Array2D[b, k] = Fibo[b].ToString(); //kiri ke kanan
                        Array2D[b, JumlahKolom - k - 1] = Fibo[b].ToString(); // Refleksi kanan kiri
                    }
                        //diagonal tengah
                    else if (b + k == (JumlahKolom - 1) / 2)
                    {
                        Array2D[b, k] = Fibo[k].ToString(); //kanan
                        Array2D[b, JumlahKolom - k - 1] = Fibo[k].ToString(); //refleksi kiri
                    }
                        //tengah baris
                    else if (b == JumlahBaris / 2 && k <= JumlahKolom / 2)
                    {
                        Array2D[b,k] = ((char)ascii).ToString(); // kiri ke kanan
                        Array2D[b, JumlahKolom - k - 1] = ((char)ascii).ToString(); //refleksi kanan ke kiri
                        ascii++;
                    }
                }
            }
        }
    }
}
