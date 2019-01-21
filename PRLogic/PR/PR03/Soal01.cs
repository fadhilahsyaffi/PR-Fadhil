using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR03
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
        {
            JumlahBaris = 1;
            JumlahKolom = n;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            //Console.WriteLine("Nilai Jumlah Baris: {0}", jumlahBaris);
            //Console.WriteLine("Nilai Jumlah Kolom: {0}", JumlahKolom);
            //Console.WriteLine("Buffer Array: {0}", jumlahBaris * JumlahKolom);

            int[] Fibo = FunctionBase.Soal01(JumlahKolom);
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    Array2D[0, k] = Fibo[k].ToString();
                    //diagonal kiri ke kanan
                    //if (b == k)
                    //Array2D[b, k] = (k * 2 + 1).ToString();
                    //diagonal kanan ke kiri
                    //else if (b + k == jumlahBaris - 1)
                    //Array2D[b, k] = (k * 2).ToString();
                }
            }
        }
    }
}
