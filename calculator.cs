using System;

namespace calculator
{
    public class Program
    {
        private double penambahan(double a, double b)
        {
            return (a + b);
        }

        private double pengurangan(double a, double b)
        {
            return (a - b);
        }

        private double perkalian(double a, double b)
        {
            return (a * b);
        }

        private double pembagian(double a, double b)
        {
            return (a / b);
        }

        public void Main()
        {

            double a, b;
            char pilihan;
            Console.WriteLine("Pilih menu calculator: ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("\n");
            Console.WriteLine(" Masukan Pilihan	1-4	: ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            if (pilihan == '1')
            {
                Console.WriteLine("Inputkan nilai a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b");
                b = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
            }

            else if (pilihan == '2')
            {
                Console.WriteLine("Inputkan nilai a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b");
                b = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Hasil Pengurangan {0} + {1} = {2}", a, b, pengurangan(a, b));
            }

            else if (pilihan == '3')
            {
                Console.WriteLine("Inputkan nilai a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b");
                b = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Hasil Perkalian {0} + {1} = {2}", a, b, perkalian(a, b));
            }

            else if (pilihan == '4')
            {
                Console.WriteLine("Inputkan nilai a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b");
                b = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Hasil Pembagian {0} + {1} = {2}", a, b, pembagian(a, b));
            }
            else if (pilihan >= 5)
            {
                Console.WriteLine(" Maaf, menu yang anda pilih tidak teredia");
            }
        }
    }
}
