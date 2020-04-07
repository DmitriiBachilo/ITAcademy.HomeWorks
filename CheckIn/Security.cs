using System;

namespace CheckIn
{
    class Security
    {
        public void Run()
        {
            Console.WriteLine(" - Hello. This is Airport security control. Do you have prohibited items: weapons, drugs, explosives? Yes, no?");
            string yes = Console.ReadLine();
            if (yes == "yes")
            {
                Console.WriteLine(" - Please, follow us to security room.");
            }
            else
            {
                Console.WriteLine(" - In connection, with the difficult epidemiological situation in our country and the world, we measure your body temperature");
                int temp;
                Random rand = new Random();
                temp = rand.Next(36, 40);
                Console.WriteLine($" - Your temperature is {temp}");
                if (temp >= 37)
                {
                    Console.WriteLine(" - Please, follow us to local medical room.");
                }
                else
                {
                    Console.WriteLine(" - Temperature is OK. Go to your gate.");
                }
            }
        }

    }
}
