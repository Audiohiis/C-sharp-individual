using System;

namespace foreacharray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutisse", "Paha oli olla" };

            int i = 1;

            foreach (string excuse in excuses)
            {
                Console.WriteLine(i + "." + excuse);
                i++;
            }
        }
    }
}
