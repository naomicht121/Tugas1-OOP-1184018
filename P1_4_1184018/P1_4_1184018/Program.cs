using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1184018
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENU PERSEGI PANJANG\n----------------------------");
                Console.WriteLine("\n1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Hitung Panjang Diagonal\n----------------------------");

                Console.Write("\nMasukkan Menu: ");
                int hitung;
                hitung = Convert.ToInt16(Console.ReadLine());

                if (hitung == 1)
                {
                    Console.WriteLine("\nHITUNG LUAS\n----------------------------");
                    double rumus;
                    int p;
                    Console.Write("Masukkan Panjang: ");
                    p = Convert.ToInt16(Console.ReadLine());

                    int l;
                    Console.Write("Masukkan Lebar: ");
                    l = Convert.ToInt16(Console.ReadLine());

                    rumus = p * l;
                    Console.WriteLine("Luasnya adalah " + rumus);

                    Console.Write("Pilih Menu Lainnya (Y/T)?");

                }
                else if (hitung == 2)
                {
                    Console.WriteLine("\nHITUNG KELILING\n----------------------------");
                    double keliling;
                    int panjang;
                    int lebar;

                    Console.Write("Masukkan panjang: ");
                    panjang = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Masukkan lebar: ");
                    lebar = Convert.ToInt16(Console.ReadLine());


                    keliling = (2 * panjang) + (2 * lebar);
                    Console.WriteLine("Kelilingnya adalah " + keliling);

                    Console.Write("Pilih Menu Lainnya (Y/T)?");
                } else if (hitung == 3)
                {
                    Console.WriteLine("\nHITUNG PANJANG DIAGONAL\n----------------------------");
                    
                    double diagonal;
                    

                    int x1;
                    Console.Write("Panjang sisi:  ");
                    x1 = Convert.ToInt16(Console.ReadLine());

                    int x2;
                    Console.Write("Lebar sisi: ");
                    x2 = Convert.ToInt16(Console.ReadLine());

                    int h1 = x1 * x1;
                    int h2 = x2 * x2;

                    diagonal = h1 + h2;

                    Console.WriteLine("Diagonalnya adalah " + Math.Sqrt(diagonal));

                    

                    Console.Write("Pilih Menu Lainnya (Y/T)?");
                }


            }
            while (Console.ReadLine() == "Y");




        }
    }
}
