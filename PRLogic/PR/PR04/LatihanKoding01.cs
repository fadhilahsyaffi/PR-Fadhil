﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR04
{
    class LatihanKoding01 : LogicBase
    {
        public LatihanKoding01(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n * 2 - 1;
            Array2D = new string[JumlahBaris, JumlahKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] Fibo = FunctionBase.Fibo(JumlahBaris * JumlahBaris);
            int angka = 0;
            for (int b = 0; b < JumlahBaris; b++)
            {
                for (int k = 0; k < JumlahKolom; k++)
                {
                    if (b + k >= JumlahBaris - 1 && k - b <= JumlahBaris - 1)
                        Array2D[b, k] = Fibo[angka++].ToString(); 
                }
            }
        }
    }
}
