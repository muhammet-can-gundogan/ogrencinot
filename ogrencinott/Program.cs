using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrencinott
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("öğrenci sayısını giriniz= ");
            byte satir = byte.Parse(Console.ReadLine());
            object[,] ogrenciler = new object[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "vize";
            ogrenciler[0, 3] = "final";
            ogrenciler[0, 4] = "ortalama";
            ogrenciler[0, 5] = "harf notu";
            double ort = 0;
            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                Console.Write("öğrenci adı giriniz:");
                ogrenciler[i, 0] = Console.ReadLine();
                Console.Write("öğrenci soyadı giriniz:");
                ogrenciler[i, 1] = Console.ReadLine();
                Console.Write("öğrenci vizesini giriniz:");
                ogrenciler[i, 2] = Console.ReadLine();
                Console.Write("öğrenci finalini giriniz:");
                ogrenciler[i, 3] = Console.ReadLine();
                int vzy = Convert.ToInt32(ogrenciler[i, 2]);
                int fnl = Convert.ToInt32(ogrenciler[i, 3]);
                ort = ((0.4) * vzy + (0.6) * fnl);
                ogrenciler[i, 4] = ort;

                if (ort >= 85)
                {
                    ogrenciler[i, 5] = "         AA";
                }
                else if (ort >= 70 && ort <= 84)
                {
                    ogrenciler[i, 5] = "        BB";
                }
                else if (ort >= 60 && ort <= 69)
                {
                    ogrenciler[i, 5] = "        CC";
                }
                else if (ort >= 45 && ort <= 59)
                {
                    ogrenciler[i, 5] = "        DD";
                }
                else
                {
                    ogrenciler[i, 5] = "        FF";
                }


            }


            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t"); 

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
