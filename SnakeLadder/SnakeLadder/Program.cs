using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            Console.WriteLine("Position :  " + pos);
            Random random = new Random();
            int dieNum = random.Next(1,7);
            Console.WriteLine("Number after rolling die :  " + dieNum);
        }
    }
}
