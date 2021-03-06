﻿using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            Console.WriteLine("Starting  Position :  " + pos);
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            const int WinPosition = 100;
            int count = 0;
            while (pos != WinPosition)
            {
                Random random = new Random();
                int dieNum = random.Next(1, 7);
                int option = random.Next(0, 3);
                if (pos + dieNum > WinPosition)
                    continue;
                switch (option)
                {
                    case NoPlay:
                        break;
                    case Ladder:
                        pos = pos + dieNum;
                        break;
                    case Snake:
                        if (pos - dieNum > 0)
                            pos = pos - dieNum;
                        else
                            pos = 0;
                        break;
                }
                count++;
                Console.WriteLine("ROLL : " + count + ", POSITION : " + pos);
            }
            Console.WriteLine("New Position :  " + pos);
            Console.WriteLine("The Player Has Reached the Exact Winning Position !! ");
            Console.WriteLine("After rolling the die '" + count + "' times");
        }
    }
}
