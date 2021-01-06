using System;

namespace KarakterUlarTangga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string A = "\u25A0";
            Console.Write("Pilih Berapa Pemain : ");
            int PEMAIN = Convert.ToInt32(Console.ReadLine());
            if (PEMAIN == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(A);
            }
            if (PEMAIN == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(A);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(A);
            }
            if (PEMAIN == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(A);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(A);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(A);
            }
            if (PEMAIN == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(A);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(A);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(A);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(A);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
