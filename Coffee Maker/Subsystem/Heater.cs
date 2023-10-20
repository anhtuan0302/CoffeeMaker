using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker.Subsystem
{
    public class Heater
    {
        public void SetTemp(int temp)
        {
            Console.WriteLine("Setting temperature to " + temp + "°C");
        }

        public void Heat()
        {
            Console.WriteLine("Heating...");
        }
    }
}
