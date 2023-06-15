using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var machine = new WarmDrinkMachine();

            //IWarmDrink drink = machine.MakeDrink();

            //drink.Consume();
            var machine = new WarmDrinkMachine();
            bool exitRequested = false;

            while (!exitRequested)
            {
                IWarmDrink drink = machine.MakeDrink();
                drink.Consume();

                // Prompt the user to choose whether to exit or continue
                Console.WriteLine();
                Console.WriteLine("Do you want to make another drink? (Y/N)");
                string userInput = Console.ReadLine();

                if (userInput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    exitRequested = true;
                }
            }

        }
    }
}