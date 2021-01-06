using System;

namespace FInal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] KARAKTER = new string[11];
            KARAKTER[1] = "\u25A0";
            KARAKTER[2] = "\u2660";
            KARAKTER[3] = "\u2665";
            KARAKTER[4] = "\u25B2";
            KARAKTER[5] = "\u2666";
            KARAKTER[6] = "\u2663";
            KARAKTER[7] = "●";
            KARAKTER[8] = "☻";
            KARAKTER[9] = "♫";
            KARAKTER[10] = "☼";
            string[] value = new string[5];
            Console.Write("Berapa Pemain : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            int [] PEMAIN = new int [11];
            Console.Clear();
            for (int p = 1; p <= jumlah; p++)
            {
                if (p == 1)
                {
                    Console.WriteLine("PEMAIN 1");
                }
                else if (p == 2)
                {
                    Console.WriteLine("PEMAIN 2");
                }
                else if (p == 3)
                {
                    Console.WriteLine("PEMAIN 3");
                }
                for (int i = 0; i <= 9; i++)
                {
                    Console.Write(i + 1 + ".");
                    Console.Write(KARAKTER[i + 1] + "  ");
                }
                Console.WriteLine();
                Console.Write("Pilih Karakter : ");
                PEMAIN[p] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    if (PEMAIN[p] == i)
                    {
                        value[p] = PEMAIN[i].ToString();
                        value[p] = KARAKTER[i];
                    }
                }
            }
        }
    }
}