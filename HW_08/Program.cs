using System;

namespace HW08_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            string[] strings = text.Split(';');
            Console.WriteLine();

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Replace("O", "A").Trim();
            }

            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
