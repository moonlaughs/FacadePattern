using System;
using System.Collections.Generic;
using System.Text;

namespace FacadPattern
{
    public class RunWithOUTFacade
    {
        AirFlowController afc = new AirFlowController();
        FuelInjector fi = new FuelInjector();
        Starter s = new Starter();
        CoolingController cc = new CoolingController();
        CatalyticConverter cac = new CatalyticConverter();
        
        public RunWithOUTFacade()
        {
            Console.WriteLine("Start Engine!");
            afc.takeAir();
            fi.on();
            fi.inject();
            s.start();
            cc.setTemperatureUpperLimit();
            cc.run();
            cac.on();

            Console.WriteLine("===========================");
            Console.WriteLine("Stop the Engine");
            fi.off();
            cac.off();
            cc.setTemperatureUpperLimit();
            cc.stop();
            afc.off();

        }
    }
}
