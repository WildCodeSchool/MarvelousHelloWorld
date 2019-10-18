using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Utilisation: " +
                                  AppDomain.CurrentDomain.FriendlyName +
                                  " [nom]");
                return;
            }
            Console.WriteLine("Hello, " + args[0] + " !");
        }
    }
}