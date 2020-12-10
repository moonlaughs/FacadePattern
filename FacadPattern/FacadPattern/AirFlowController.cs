using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class AirFlowController
    {
        public int airFlowMeter;

        public void takeAir()
        {
            Console.WriteLine("AirFlowController take air");
        }

        public void off()
        {
            Console.WriteLine("AirFlowController off");
        }
    }
}
