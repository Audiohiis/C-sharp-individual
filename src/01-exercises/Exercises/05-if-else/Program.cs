using System;

namespace ifelse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata!");

            Random rnd = new Random();
            int myNumber = rnd.Next(1, 101);

            Console.Write("Sina pakud: ");
            int userNumber = Int32.Parse(Console.ReadLine());

            if (myNumber > userNumber)
            {
                Console.WriteLine("Minu number on suurem.");
            }
            else if  (myNumber < userNumber) {
                Console.WriteLine("Minu number on väiksem");
            }
            else {
                Console.WriteLine("Ära arvasid!");
            }
               
        }
    }
}
