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
                Console.WriteLine("0. Exit");
                Console.Write("Please enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Default");
                        Console.WriteLine("2. Custom");
                        Console.Write("Choose an option: ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            Coffee espresso = coffeeMachine.MakeEspresso(false);
                            Console.WriteLine("Your espresso is ready!");
                            espresso.Result();
                        }
                        else if (option == 2)
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
