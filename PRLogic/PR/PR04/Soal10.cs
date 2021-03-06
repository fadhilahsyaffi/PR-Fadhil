﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_Base;

namespace PR04
{
    class Soal10 : LogicBase
    {
        public Soal10(int n1, int n2)
        {
            JumlahBaris = n1;
            JumlahKolom = (n1 * n2) - (n2 - 1);
            Array2D = new string[JumlahBaris, JumlahKolom];
            isiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }
        private void isiArray(int n2)
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {

                for (int b = 0; b < JumlahBaris; b++)
                {
                    int ascii = 65;
                    for (int k = 0; k < JumlahKolom; k++)
                    {
                        if (b + k >= (JumlahBaris - 1) / 2 && k - b <= (JumlahBaris - 1) / 2 && b <= JumlahBaris / 2)
                        {
                            Array2D[b, k + (JumlahBaris - 1) * bangun] = ((char)ascii).ToString();
                            Array2D[JumlahBaris - 1 - b, k + (JumlahBaris - 1) * bangun] = ((char)ascii).ToString();
                            if (k < JumlahBaris / 2)
                            {
                                ascii += 1;
                            }
                            else
                            {
                                ascii -= 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
