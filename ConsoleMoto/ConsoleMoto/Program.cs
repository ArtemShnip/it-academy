using GlobalMotoServiceModule;
using System;

namespace ConsoleMoto
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConsoleMoto moto = new MyConsoleMoto("Suzuki");
            MotoSerice service = new MotoSerice();

            moto.StartEngine();
            moto.Move(1000);
            moto.Move(5000);
            moto.StopEngine();

            moto = null;
            service = null;
            moto = new MyConsoleMoto("Suzuki");
            service = new MotoSerice();

            moto.StartEngine();
            moto.Move(6000);
            moto.StopEngine();

            moto = null;
            service = null;
            moto = new MyConsoleMoto("Suzuki");
            service = new MotoSerice();
        }

        static void GoToService(int distanceFromLastService)
        {
            Console.WriteLine($"Time to go motoservice." +
                $" Current distance from the last Service is: {distanceFromLastService}");
        }
    }
}
