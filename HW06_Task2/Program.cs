using System;

namespace HW06_Task2
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

            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("Enter input array element: [{0}] = ", i);
                int inpValue;
                while (!int.TryParse(Console.ReadLine(), out inpValue))
                {
                    Console.Write("Invalid number, enter array element again [{0}] = ", i);
                }
                array[i] = inpValue;
            }
            Console.WriteLine();

            Console.Write("Enter additional element value: ");
            int addValue;
            while (!int.TryParse(Console.ReadLine(), out addValue))
            {
                Console.Write("Invalid number, enter additional element again: ");
            }
            
            Console.Write("Enter additional element index: ");
            int addIndex;
            while (!int.TryParse(Console.ReadLine(), out addIndex) || addIndex < 0 || addIndex >= arrayLength)
            {
                Console.Write("Invalid number, enter additional element index again: ");
            }
            Console.WriteLine();

            for (int i = arrayLength - 1; i > addIndex; i--)
            {
                array[i] = array[i - 1];
            }
            array[addIndex] = addValue;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Array element: [{0}] = {1}", i, array[i]);
            }

            Console.ReadKey();
        }
    }
}
