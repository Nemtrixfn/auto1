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

        public Vehicle(string brand)
        {                                                                                                                                                                 
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
        }
        
        public void Move()
        {
            FuelLevel -= 1;
            Distance += 20;
            PneuState -= 0.01;
        }
        

        
    }
}
