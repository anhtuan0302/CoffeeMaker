using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker.Subsystem
{
    public class MilkFrother
    {
        public void SetMilk(int amount)
        {
            Console.WriteLine("Setting froth milk amount to " + amount + "ml");
        }

        public void FrothMilk()
        {
            Console.WriteLine("Frothing...");
        }
    }
}
