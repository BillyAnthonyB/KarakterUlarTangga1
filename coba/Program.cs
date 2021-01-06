using System;

namespace coba
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
            Console.Write("Berapa Pemain : ");
            int PEMAIN = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int p = 1; p <= PEMAIN; p++)
            {
                for (int i = 0; i <= 9; i++)
                {
                    Console.Write(i + 1 + ".");
                    Console.Write(KARAKTER[i + 1] + "  ");
                }
                Console.WriteLine();
                Console.Write("Pilih Karakter : ");
                string Pilih1 = Console.ReadLine();
                Console.Clear();
                string P = Convert.ToString(p);
                for (int i = 1; i < 10; i++)
                {
                    if (P == KARAKTER[i])
                    {
                        Console.Write("1." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("2." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("3." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("4." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("5." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("6." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("7." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("8." + KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine();
                }
                Console.Write("Pilih Warna : ");
                int Pilih2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                for (int i = 1; i < 10; i++)
                {
                    if (Pilih2 == 1)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (Pilih2 == 2)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (Pilih2 == 3)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (Pilih2 == 4)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (Pilih2 == 5)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (Pilih2 == 6)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (Pilih2 == 7)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (Pilih2 == 8)
                    {
                        Console.Write(KARAKTER[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                Console.ResetColor();
            }
        }
    }
}
