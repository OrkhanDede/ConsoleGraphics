using System;
namespace ConsoleGraphic
{
    class RandomNumber
    {
        public static int NumberGenerat(int min, int max)
        {
            if (random == null)
                random = new Random();

            return random.Next(min, max);
        }

        private static Random random;
    }
}
