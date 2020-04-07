using System.Threading;

namespace CheckIn
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerProfile profile = new PassengerProfile();
            new Greeting().Run(profile);
            Thread.Sleep(2000);
            new Registration().Run(profile);
            Thread.Sleep(2000);
            new Security().Run();
        }
    }
}
