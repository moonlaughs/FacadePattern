using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class FuelInjector
    {
        public string fuelPump;


        public void on()
        {
            Console.WriteLine("FuelInjector on");
        }

        public void inject()
        {
            Console.WriteLine("FuelInjector inject");
        }

        public void off()
        {
            Console.WriteLine("FuelInjector off");
        }
    }
}
