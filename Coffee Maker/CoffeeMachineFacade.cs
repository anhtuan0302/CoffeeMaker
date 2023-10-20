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

        public Coffee MakeAmericano(bool custom)
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
                customCoffeePowderAmount = 5;
                customWaterAmount = 35;
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

        public Coffee MakeCappuccino(bool custom)
        {
            if (custom)
            {
                Console.Write("Enter coffee powder amount (g): ");
                int coffeePowderAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter water amount (ml): ");
                int waterAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter milk amount (ml): ");
                int milkAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter froth milk amount (ml): ");
                int frothMilkAmount = Convert.ToInt32(Console.ReadLine());

                customCoffeePowderAmount = coffeePowderAmount;
                customWaterAmount = waterAmount;
                customMilkAmount = milkAmount;
                customFrothMilkAmount = frothMilkAmount;
            }
            else
            {
                customCoffeePowderAmount = 5;
                customWaterAmount = 10;
                customMilkAmount = 10;
                customFrothMilkAmount = 15;
            }

            Console.WriteLine("==============================");
            pump.SetWater(customWaterAmount);
            pump.PumpWater();
            heater.SetTemp(90);
            heater.Heat();
            grinder.SetGrindAmount(customCoffeePowderAmount);
            grinder.Grind();
            pump.SetMilk(customMilkAmount);
            pump.PumpMilk();
            heater.SetTemp(50);
            heater.Heat();
            milkFrother.SetMilk(customFrothMilkAmount);
            milkFrother.FrothMilk();
            Console.WriteLine("==============================");
            return new Coffee(customCoffeePowderAmount, customWaterAmount, customMilkAmount, customFrothMilkAmount, 90);
        }

        public Coffee MakeLatte(bool custom)
        {
            if (custom)
            {
                Console.Write("Enter coffee powder amount (g): ");
                int coffeePowderAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter water amount (ml): ");
                int waterAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter milk amount (ml): ");
                int milkAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter froth milk amount (ml): ");
                int frothMilkAmount = Convert.ToInt32(Console.ReadLine());

                customCoffeePowderAmount = coffeePowderAmount;
                customWaterAmount = waterAmount;
                customMilkAmount = milkAmount;
                customFrothMilkAmount = frothMilkAmount;
            }
            else
            {
                customCoffeePowderAmount = 5;
                customWaterAmount = 10;
                customMilkAmount = 15;
                customFrothMilkAmount = 10;
            }

            Console.WriteLine("==============================");
            pump.SetWater(customWaterAmount);
            pump.PumpWater();
            heater.SetTemp(90);
            heater.Heat();
            grinder.SetGrindAmount(customCoffeePowderAmount);
            grinder.Grind();
            pump.SetMilk(customMilkAmount);
            pump.PumpMilk();
            heater.SetTemp(50);
            heater.Heat();
            milkFrother.SetMilk(customFrothMilkAmount);
            milkFrother.FrothMilk();
            Console.WriteLine("==============================");
            return new Coffee(customCoffeePowderAmount, customWaterAmount, customMilkAmount, customFrothMilkAmount, 90);
        }

        public string MakeHotWater(bool custom)
        {
            if (custom)
            {
                Console.Write("Enter water amount (ml): ");
                int waterAmount = Convert.ToInt32(Console.ReadLine());

                customWaterAmount = waterAmount;
            }
            else
            {
                customWaterAmount = 100;
            }

            Console.WriteLine("==============================");
            pump.SetWater(customWaterAmount);
            pump.PumpWater();
            heater.SetTemp(100);
            heater.Heat();
            return "Hot water " + customWaterAmount  + "ml is ready!";
        }

        public string MakeClean()
        {            
            Console.WriteLine("==============================");
            pump.SetWater(100);
            pump.PumpWater();
            heater.SetTemp(100);
            heater.Heat();
            return "Cleaning is done!";
        }
    }
}
