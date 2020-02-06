using System;
using System.Collections.Generic;
using System.Text;

namespace Refl
    {
        class Moto
        {
            public string Name { get; set; }
            public string Model { get; set; }

            private int _vinNumber = 111;

            public int Odometr { get; set; }

        public Moto()
        {
            Name = "Def";
        }

            public Moto(string name)
            {
                Name = name;
            }

            public int GetVinNumber()
            {
                return _vinNumber;
            }

            public override string ToString()
            {
                return $"Moto: {Name}, Model: {Model}, VIN: {_vinNumber}";
            }
        }
    }