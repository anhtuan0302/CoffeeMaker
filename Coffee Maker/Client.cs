using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker
{
    public class Client
    {
        public static void Main(string[] args)
        {
            CoffeeMachineFacade coffeeMachine = new CoffeeMachineFacade();

            while (true)
            {
                Console.WriteLine("1. Make Espresso");
                Console.WriteLine("2. Make Americano");
                Console.WriteLine("3. Make Cappuccino");
                Console.WriteLine("4. Make Latte");
                Console.WriteLine("5. Make Hot Water");
                Console.WriteLine("6. Make Clean");
                Console.WriteLine("0. Exit");
                Console.WriteLine("------------------------------");
                Console.Write("Please enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.WriteLine("------------------------------");
                        Console.Write("Choose an option: ");
                        int espressoOption = Convert.ToInt32(Console.ReadLine());
                        if (espressoOption == 1)
                        {
                            Coffee espresso = coffeeMachine.MakeEspresso(false);
                            Console.WriteLine("Your espresso is ready!");
                            espresso.Result();
                        }
                        else if (espressoOption == 2)
                        {
                            Coffee espresso = coffeeMachine.MakeEspresso(true);
                            Console.WriteLine("Your espresso is ready!");
                            espresso.Result();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.WriteLine("------------------------------");
                        Console.Write("Choose an option: ");
                        int AmericanoOption = Convert.ToInt32(Console.ReadLine());
                        if (AmericanoOption == 1)
                        {
                            Coffee americano = coffeeMachine.MakeAmericano(false);
                            Console.WriteLine("Your americano is ready!");
                            americano.Result();
                        }
                        else if (AmericanoOption == 2)
                        {
                            Coffee americano = coffeeMachine.MakeAmericano(true);
                            Console.WriteLine("Your americano is ready!");
                            americano.Result();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.WriteLine("------------------------------");
                        Console.Write("Choose an option: ");
                        int CappuccinoOption = Convert.ToInt32(Console.ReadLine());
                        if (CappuccinoOption == 1)
                        {
                            Coffee capuccino = coffeeMachine.MakeCappuccino(false);
                            Console.WriteLine("Your cappuccino is ready!");
                            capuccino.Result();
                        }
                        else if (CappuccinoOption == 2)
                        {
                            Coffee cappuccino = coffeeMachine.MakeCappuccino(true);
                            Console.WriteLine("Your cappuccino is ready!");
                            cappuccino.Result();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.WriteLine("------------------------------");
                        Console.Write("Choose an option: ");
                        int LatteOption = Convert.ToInt32(Console.ReadLine());
                        if (LatteOption == 1)
                        {
                            Coffee latte = coffeeMachine.MakeLatte(false);
                            Console.WriteLine("Your latte is ready!");
                            latte.Result();
                        }
                        else if (LatteOption == 2)
                        {
                            Coffee latte = coffeeMachine.MakeAmericano(true);
                            Console.WriteLine("Your latte is ready!");
                            latte.Result();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.WriteLine("------------------------------");
                        Console.Write("Choose an option: ");
                        int hotWaterOption = Convert.ToInt32(Console.ReadLine());
                        string hotWaterResult;
                        if (hotWaterOption == 1)
                        {
                            hotWaterResult = coffeeMachine.MakeHotWater(false);
                            Console.WriteLine(hotWaterResult);
                            Console.WriteLine("==============================");
                        }
                        else if (hotWaterOption == 2)
                        {
                            hotWaterResult = coffeeMachine.MakeHotWater(true);
                            Console.WriteLine(hotWaterResult);
                            Console.WriteLine("==============================");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                        break;
                    case 6:
                        string cleanResult;
                        Console.WriteLine("==============================");
                        cleanResult = coffeeMachine.MakeClean();
                        Console.WriteLine(cleanResult);
                        Console.WriteLine("==============================");
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
