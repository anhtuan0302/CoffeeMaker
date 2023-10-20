using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker.Subsystem
{
    public class Pump
    {
        public void SetWater(int amount)
        {
            Console.WriteLine("Setting water amount to " + amount + "ml");
        }

        public void PumpWater()
        {
            Console.WriteLine("Pumping water...");
        }

        public void SetMilk(int amount)
        {
            Console.WriteLine("Setting milk amount to " + amount + "ml");
        }

        public void PumpMilk()
        {
            Console.WriteLine("Pumping milk...");
        }
    }
}
