using Coffee_Maker.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker
{
    public class CoffeeMachineFacade
    {
        private Grinder grinder;
        private Heater heater;
        private MilkFrother milkFrother;
        private Pump pump;

        private int customWaterAmount { get; set; }
        private int customMilkAmount { get; set; }
        private int customFrothMilkAmount { get; set; }
        private int customCoffeePowderAmount { get; set; }

        public CoffeeMachineFacade()
        {
            grinder = new Grinder();
            heater = new Heater();
            milkFrother = new MilkFrother();
            pump = new Pump();
        }

        public Coffee MakeEspresso(bool custom)
        {
            customMilkAmount = 0;
            customFrothMilkAmount = 0;
            if (custom)
            {
                Console.Write("Enter coffee powder amount (g): ");
                int coffeePowderAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter water amount (ml): ");
                int waterAmount = Convert.ToInt32(Console.ReadLine());

                customCoffeePowderAmount = coffeePowderAmount;
                customWaterAmount = waterAmount;
            }
            else
            {
                customCoffeePowderAmount = 8;
                customWaterAmount = 17;
            }

            Console.WriteLine("==============================");
            pump.SetWater(customWaterAmount);
            pump.PumpWater();
            heater.SetTemp(90);
            heater.Heat();
            grinder.SetGrindAmount(customCoffeePowderAmount);
            grinder.Grind();
            Console.WriteLine("==============================");
            return new Coffee(customCoffeePowderAmount, customWaterAmount, customMilkAmount, customFrothMilkAmount, 90);
        }
    }
}
