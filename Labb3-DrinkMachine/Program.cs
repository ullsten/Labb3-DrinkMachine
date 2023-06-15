using Labb3_DrinkMachine.Interfaces;
using Spectre.Console;

namespace Labb3_DrinkMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkYellow;

            //Console.Clear();
            RunDrinkMachine runMachine = new RunDrinkMachine();
            runMachine.RunMachine();

            //Console.ResetColor();
        }
    }
}