using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01
{
    class Program
    {
        static void Main(string[] args)
        {
            string jawab = "y"; //t-> tidak keluar
            //jawab.toLower() -> alternatif
            while (jawab == "y" || jawab == "Y")
            {
                Console.WriteLine("--- Logic 01 ---");
                Console.Write("Masukkan nomor soal : ");
                int soal = int.Parse(Console.ReadLine());

                Console.Write("Masukkan nilai n : ");
                int val = int.Parse(Console.ReadLine());

                switch (soal)
                {
                    case 4:
                        Soal04 soal04 = new Soal04(val);
                        break;
                    case 5:
                        soal05 soal05 = new soal05(val);
                        break;
                    case 6:
                        soal06 soal06 = new soal06(val);
                        break;
                    case 7:
                        soal07 soal07 = new soal07(val);
                        break;
                    case 8:
                        soal08 soal08 = new soal08(val);
                        break;
                    default:
                        Console.Write("Soal tidak ditemukan!!!");
                        break;
                }
                //ganjalan
                Console.Write("Apakah masih berlanjut?[Y/T]");
                jawab = Console.ReadLine();
            }
        }
    }
}
