using GlobalMotoServiceModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMoto
{
    class MyConsoleMoto
    {
        public string Model { get; set; }

        public DateTime Year { get; set; }

        public static int Odometr { get; private set; }

        public int DailyDistance { get; set; }

        public MyConsoleMoto(string madel)
        {
            Model = madel;
        }

        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine($"Engine has been started at {DateTime.Now}");
        }

        public void Move(int distance)
        {
            //DailyDistance = DailyDistance + distance;
            DailyDistance += distance;
            Console.WriteLine($" Move {distance}");
        }

        public void StopEngine()
        {
            Odometr += DailyDistance;
            MotoSerice.DistanceFromLastService += DailyDistance;

            Console.WriteLine();
            Console.WriteLine($"Engine has been stoped at {DateTime.Now}");
            Console.WriteLine($" Total distance {Odometr} km");
        }
    }
}
