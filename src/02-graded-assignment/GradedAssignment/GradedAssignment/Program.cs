using System;

namespace GradedAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            int sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your sum is: {sum}$");

            if (sum >= 50) {
                //5%
            }
        }
    }
}
