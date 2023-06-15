using System;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class RunDrinkMachine
    {
        public void RunMachine()
        {
            var machine = new WarmDrinkMachine();
            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();

                IWarmDrink drink = machine.MakeDrink();
                drink.Consume();

                // Prompt the user to choose whether to exit or continue
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Do you want to make another drink? (Y/N)");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                if (userInput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    exitRequested = true;
                }
            }
        }
    }
}
