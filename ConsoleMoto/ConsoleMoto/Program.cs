using GlobalMotoServiceModule;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMoto
{
    class Nitification
    {
        internal void SendEmail(int distance)
        {
            Console.WriteLine($"###################\n" +
                $"Email: go to service - current distance {distance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<MyConsoleMoto> collection = new List<MyConsoleMoto>();
            var res = collection.Where(_ => _.DailyDistance == 10_000);
            collection.First();  //=--=
            collection.FirstOrDefault(moto =>
                                        moto.DailyDistance >= 2_000 
                                        && moto.Model.EndsWith('s'));

            //MotoServiceDelegate @delegate = new MotoServiceDelegate(GoToService);
            //MotoServiceDelegate @delegate = GoToService;
            Nitification notification = new Nitification();
            //@delegate = @delegate + notification.SendEmail;
            Action<int> action = GoToService;
            action += notification.SendEmail;
            MotoSerice service = new MotoSerice(action);
            MyConsoleMoto moto = new MyConsoleMoto("Suzuki");
            

            moto.StartEngine();
            moto.Move(1000);
            moto.Move(5000);
            moto.StopEngine();

            moto = null;
            service = null;
            
            service = new MotoSerice(action);
            moto = new MyConsoleMoto("Suzuki");

            moto.StartEngine();
            moto.Move(6000);
            moto.StopEngine();

            moto = null;
            service = null;
            action -= GoToService;

            service = new MotoSerice(action);
            moto = new MyConsoleMoto("Suzuki");
        }

        static void GoToService(int distanceFromLastService)
        {
            Console.WriteLine($"Time to go motoservice." +
                $" Current distance from the last Service is: {distanceFromLastService}");
        }
    }
}
