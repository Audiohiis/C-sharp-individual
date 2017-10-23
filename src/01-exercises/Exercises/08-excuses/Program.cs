using System;

namespace excuses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutisse", "Paha oli olla" };

            for (int i = 0; i < excuses.Length; i++) {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
            }
        }
    }
}
