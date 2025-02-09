using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];// pobiera z konsoli pierwszy element tablicy, tam wpisałem Marcin
            Console.WriteLine("Witaj, " + name);

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}

        }
    }
} 