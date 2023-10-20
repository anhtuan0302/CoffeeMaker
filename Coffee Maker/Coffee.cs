using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker
{
    public class Coffee
    {
        public int coffeePowderAmount { get; set; }
        public int waterAmount { get; set; }
        public int milkAmount { get; set; }
        public int frothMilkAmount { get; set; }
        public int temperature { get; set; }
        public int finalVolume { get; set; }

        public Coffee(int coffeePowderAmount, int waterAmount, int milkAmount, int frothMilkAmount, int temperature)
        {
            this.coffeePowderAmount = coffeePowderAmount;
            this.waterAmount = waterAmount;
            this.milkAmount = milkAmount;
            this.frothMilkAmount = frothMilkAmount;
            this.temperature = temperature;
            this.finalVolume = coffeePowderAmount + waterAmount + milkAmount + frothMilkAmount;
        }

        public void Result()
        {
            Console.WriteLine("Coffee powder amount: " + coffeePowderAmount + "g");
            Console.WriteLine("Water amount: " + waterAmount + "ml");
            Console.WriteLine("Milk amount: " + milkAmount + "ml");
            Console.WriteLine("Froth milk amount: " + frothMilkAmount + "ml");
            Console.WriteLine("Temperature: " + temperature + "°C");
            Console.WriteLine("Final volume: " + finalVolume + "ml");
            Console.WriteLine("==============================");
        }
    }
}
