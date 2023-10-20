using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker.Subsystem
{
    public class Grinder
    {
        public void SetGrindAmount(int amount)
        {
            Console.WriteLine("Setting grind amount to " + amount + "g");
        }

        public void Grind()
        {
            Console.WriteLine("Grinding... ");
        }
    }
}
