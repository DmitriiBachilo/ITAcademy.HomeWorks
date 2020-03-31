using System;

namespace HW06_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength;
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
            {
                Console.WriteLine("Invalid value, enter again: ");
            }

            long[] array = new long[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(0,1000);
                Console.WriteLine("Array element: [{0}] = {1}", i, array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arrayLength / 2; i++)
            {
                long tmp = array[i];
                array[i] = array[arrayLength - 1 - i];
                array[arrayLength - 1 - i] = tmp;
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Reverse array element: [{0}] = {1}", i, array[i]);
            }

            Console.ReadLine();
        }
    }
}
