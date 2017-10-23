using System;

namespace askandcalculate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaator. Ütle mulle kaks numbrit ja ma ütlen sulle nende summa");
            Console.Write("Esimene number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Teine number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.Write($"Tulemuseks on: {sum}");
        }
    }
}
