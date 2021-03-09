using System;

namespace CalculatorConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            // int a = 10; // deklarasi a, dgn nilai 10;
            // int b = 6; // deklarasi a, dgn nilai 6;

            Console.WriteLine("Pilih Menu Kalkulator :");

            Console.WriteLine("");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            
            Console.WriteLine("");

            Console.Write("Masukan Pilihan Anda : ");
            int a, b;
            int pil = int.Parse(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf Masukan Pilihan Yang Benar");
                    break;
            }

            Console.Write("");

            //Console.Write("Inputkan Nilai a = ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Inputkan Nilai b = ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            //Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            //Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            //Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan apa saja untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
