using System;
using System.Collections.Generic;
using System.Text;

namespace auto1
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public double PneuState { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
            Speed = 0;
        }

        public void Move()
        {
            if (Speed > 0)
            {
                FuelLevel = Math.Max(0, FuelLevel - 1);

                // FuelLevel = Math.Min(100, FuelLevel + 50);

                if (FuelLevel > 0)
                {
                    Distance += Speed;
                    PneuState -= Speed / 100D;
                }
            }
        }


        public void Tankovani_Skody()
        {
            FuelLevel += 10;
            if (FuelLevel > 100)
            {
                FuelLevel = 100;
            }
        }

        public void Tankovani_WM()
        {
            FuelLevel += 10;
            if (FuelLevel > 100)
            {
                FuelLevel = 100;
            }
        }

        public void Vymena_pneumatik_WM()
        {
            PneuState = 100;
        }

        public void Vymena_pneumatik_S()
        {
            PneuState = 100;
        }

        public void SpeedUp()
        {
            Speed = Math.Min(100, Speed + 1);
        }

        public void SpeedDown()
        {
            Speed = Math.Max(0, Speed - 1);
        }

    }
}
