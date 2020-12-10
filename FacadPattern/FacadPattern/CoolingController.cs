using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class CoolingController
    {
        public string Radiator { get; set; }
        public string temperatureSensor { get; set; }

        public void setTemperatureUpperLimit()
        {
            Console.WriteLine("set temp upper limit");
        }

        public void run()
        {
            Console.WriteLine("run");
        }

        public void cool()
        {
            Console.WriteLine("cool");
        }

        public void stop()
        {
            Console.WriteLine("stop");
        }
    }
}
