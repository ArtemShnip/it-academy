using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Moto
    {
        public string Model { get; set; }
        public int VinNumber { get; set; }

        public Moto()
        {
        }
        public Moto(string model, int vinNumber)
        {
            Model = model;
            VinNumber = vinNumber;
        }
        public void CleanMoto(ref Moto moto, string name = "moto")
        {
            moto.VinNumber = 100;
            moto = new Moto();
        }
    }
}
