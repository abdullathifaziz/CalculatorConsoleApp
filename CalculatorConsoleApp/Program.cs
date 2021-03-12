using System;

namespace CalculatorConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|     APLIKASI KALKULATOR    |");

            Console.WriteLine("|                            |");

            Console.WriteLine("| 1. Penambahan              |");
            Console.WriteLine("| 2. Pengurangan             |");
            Console.WriteLine("| 3. Perkalian               |");
            Console.WriteLine("| 4. Pembagian               |");
            Console.WriteLine("+----------------------------+");

            Console.Write("| Masukan Pilihan Anda : ");
            int a, b;
            int pil = int.Parse(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    Console.Write("| Masukan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("| Masukan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("+----------------------------+");
                    Console.WriteLine("| Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    Console.WriteLine("+----------------------------+");
                    break;
                case 2:
                    Console.Write("| Masukan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("| Masukan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("+----------------------------+");
                    Console.WriteLine("| Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    Console.WriteLine("+----------------------------+");
                    break;
                case 3:
                    Console.Write("| Masukan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("| Masukan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("+----------------------------+");
                    Console.WriteLine("| Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    Console.WriteLine("+----------------------------+");
                    break;
                case 4:
                    Console.Write("| Masukan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("| Masukan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("+----------------------------+");
                    Console.WriteLine("| Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    Console.WriteLine("+----------------------------+");
                    break;
                default:
                    Console.WriteLine("| Maaf Masukan Pilihan Yang Benar");
                    break;
            }


            Console.WriteLine("\nTEKAN ENTER UNTU KELUAR");
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
