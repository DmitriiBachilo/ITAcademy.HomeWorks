using System;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol: ");
            char n = Convert.ToChar(Console.Read());

            switch (n)
            {
                case 'w': 
                    Console.WriteLine("The figure moves up");
                    break;
                case 'a': 
                    Console.WriteLine("The figure moves left");
                    break;
                case 's':
                    Console.WriteLine("The figure moves down");
                    break;
                case 'd':
                    Console.WriteLine("The figure moves right");
                    break;
                default:
                    Console.WriteLine("Invalid symbol, enter a symbol from the range: w, a, s, d");
                    break;
            }

            Console.ReadKey();
        }
    }
}
