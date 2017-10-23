using System;

namespace userinput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan seda");

            Console.Write("Sina ütled: ");
            string askInput = Console.ReadLine();
            Console.Write($"Mina ütlen: {askInput}");

        }
    }
}
