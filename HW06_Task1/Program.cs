using System;

namespace HW06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arrays length: ");
            int arrayLength;
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
            {
                Console.Write("Invalid number, enter length again: ");
            }

            int[] rndArray = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < rndArray.Length; i++)
            {
                rndArray[i] = rand.Next(-100, 100);
                Console.WriteLine("Random array element: [{0}] = {1}", i, rndArray[i]);
            }
            Console.WriteLine();

            int[] inpArray = new int[arrayLength];
            for (int i = 0; i < inpArray.Length; i++)
            {
                Console.Write("Enter input array element: [{0}] = ", i);
                int inpValue;
                while (!int.TryParse(Console.ReadLine(), out inpValue))
                {
                    Console.Write("Invalid number, enter array element again [{0}] = ", i);
                }
                inpArray[i] = inpValue;
            }
            Console.WriteLine();

            for (int i = 0; i < inpArray.Length; i++)
            {
                Console.WriteLine("Input array element: [{0}] = {1}", i, inpArray[i]);
            }
            Console.WriteLine();

            int[] sumArray = new int[arrayLength];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = rndArray[i] + inpArray[i];
                Console.WriteLine("Sum array element: [{0}] = {1}", i, sumArray[i]);
            }
            Console.ReadLine();
        }
    }
}
