using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, IBeverage> beverageList = BeverageFactory.CreateBeverages();
            Dictionary<int, ICondiment> condimentList = CondimentFactory.CreateCondiments();

            Console.WriteLine("Select the beverage: ");
            DisplayBeverages();

            int beverageIndex = GetUserSelection();
            if (!beverageList.ContainsKey(beverageIndex))
            {
                Console.WriteLine("Invalid choice. Exiting.");
                return;
            }

            string details = beverageList[beverageIndex].AddBeverage("");
            decimal totalPrice = beverageList[beverageIndex].GetPrice();

            Console.WriteLine("Select the condiments for your beverage: ");
            DisplayCondiments();

            while (true)
            {
                int condimentIndex = GetUserSelection();

                if (condimentIndex == 5)
                {
                    Console.WriteLine(details);
                    Console.WriteLine($"Total Price: ${totalPrice:F2}");
                    Console.ReadKey();
                    return;
                }
                else if (!condimentList.ContainsKey(condimentIndex))
                {
                    Console.WriteLine("Invalid choice. Please select a valid condiment.");
                }
                else
                {
                    details = condimentList[condimentIndex].AddCondiment(details);
                    totalPrice += condimentList[condimentIndex].GetPrice();
                }

                Console.WriteLine("Would you like to add another condiment? (1-4 for more condiments, 5 to finish)");
            }
        }

        static void DisplayBeverages()
        {
            Console.WriteLine("1. Coffee ($2.00)");
            Console.WriteLine("2. Espresso ($2.50)");
            Console.WriteLine("3. Latte ($3.00)");
        }

        static void DisplayCondiments()
        {
            Console.WriteLine("1. Milk ($0.50)");
            Console.WriteLine("2. Sugar ($0.25)");
            Console.WriteLine("3. Whipped Cream ($0.75)");
            Console.WriteLine("4. None");
            Console.WriteLine("5. Exit");
        }

        static int GetUserSelection()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
