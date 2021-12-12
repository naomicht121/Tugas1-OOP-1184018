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
            int anak;
            String judul = "ANAK AYAM TURUN 10\n";
            Console.Write(judul);
            Console.WriteLine("nilai Anak ayam harus positif dan tidak boleh 0 dan maksimal adalah 10. contoh 1,2,3,..10");

            String ayam;
            Console.WriteLine("Anak Ayam : ");
            ayam = Console.ReadLine();
            anak = Convert.ToInt16(ayam);

            if (anak >= 1 && 10 >= anak)
            {

                for (int i = anak; i > 1; i--)
                {
                    Console.WriteLine("Anak ayam turun {0} Mati satu tinggal {1}", i, i - 1);
                }
                Console.WriteLine("Anak ayam turun 1 Mati satu tinggal induknya");
                Console.ReadLine();
            }

        }
    }

}
