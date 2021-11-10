using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1184018
{
    class Program
    {

        static void Main(string[] args)
        {
            String judul = "ANAK AYAM TURUN 10\n";
            Console.Write(judul);

            String ayam = "\nAnak ayam turunlah ";
            String mati = ", Mati satu tinggallah ";

            int i = 10;

            while (i > 0)
            {
                
                String[] angka = { "9", "8", "7", "6", "5", "4", "3", "2", "1", "induknya\n" };
                

                for (int m = 0; m < angka.Length; m++)
                {
                    Console.Write(ayam + i + mati + angka[m]);
                    i--;
                }

            }
                


        }



    }
}
