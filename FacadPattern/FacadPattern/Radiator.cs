using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class Radiator
    {
        public void on()
        {
            Console.WriteLine("Radiator on");
        }

        public void off()
        {
            Console.WriteLine("Radiator off");
        }

        public void setSpeed()
        {
            Console.WriteLine("Radiator set speed");
        }
    }
}
