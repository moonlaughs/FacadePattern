using System;

namespace FacadPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWithOUTFacade rwf = new RunWithOUTFacade();

            Console.WriteLine("========");
            Facade f = new Facade();
            f.Start();
            Console.WriteLine("========");
            f.Stop();
            
        }
    }
}
