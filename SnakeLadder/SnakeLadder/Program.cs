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
            Console.WriteLine("Three options - No Play, Ladder, Snake ");
            int option = random.Next(0,3);
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            switch (option)
            {
                case NoPlay:
                    Console.WriteLine("No Play");
                    break;
                case Ladder:
                    Console.WriteLine("Ladder");
                    pos = pos + dieNum;
                    break;
                case Snake:
                    Console.WriteLine("Snake");
                    if (pos - dieNum > 0)
                        pos = pos - dieNum;
                    else
                        pos = 0;
                    break;
            }
            Console.WriteLine("The New Position :  " + pos);
        }
    }
}
