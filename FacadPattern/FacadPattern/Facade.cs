using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class Facade
    {
        AirFlowController afc;
        FuelInjector fi;
        Starter s;
        CoolingController cc;
        CatalyticConverter cac;

        public Facade()
        {
            afc = new AirFlowController();
            fi = new FuelInjector();
            s = new Starter();
            cc = new CoolingController();
            cac = new CatalyticConverter();
        }

        public void Start()
        {
            Console.WriteLine("Start Engine!");
            afc.takeAir();
            fi.on();
            fi.inject();
            s.start();
            cc.setTemperatureUpperLimit();
            cc.run();
            cac.on();
        }

        public void Stop()
        {
            Console.WriteLine("Stop the Engine");
            fi.off();
            cac.off();
            cc.setTemperatureUpperLimit();
            cc.stop();
            afc.off();
        }
    }
}
