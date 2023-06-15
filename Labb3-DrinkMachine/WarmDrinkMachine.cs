using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

//namespace Labb3_DrinkMachine
//{
//    public class WarmDrinkMachine
//    {
//        public enum AvailableDrink // violates open-closed
//        {
//            Coffee, Tea
//        }
//        private Dictionary<AvailableDrink, IWarmDrinkFactory> factories =
//          new Dictionary<AvailableDrink, IWarmDrinkFactory>();

//        private List<Tuple<string, IWarmDrinkFactory>> namedFactories =
//          new List<Tuple<string, IWarmDrinkFactory>>();

//        public WarmDrinkMachine()
//        {
//            foreach (var t in typeof(WarmDrinkMachine).Assembly.GetTypes())
//            {
//                if (typeof(IWarmDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
//                {
//                    namedFactories.Add(Tuple.Create(
//                      t.Name.Replace("Factory", string.Empty), (IWarmDrinkFactory)Activator.CreateInstance(t)));
//                }
//            }
//        }
//        public IWarmDrink MakeDrink()
//        {
//            Console.WriteLine("Welcome to AI Drink machine. How could I assist you today?");
//            Console.WriteLine();
//            Console.WriteLine("This is what we serve today:");

//            for (var index = 0; index < namedFactories.Count; index++)
//            {
//                var tuple = namedFactories[index];
//                Console.WriteLine($"{index}: {tuple.Item1}");
//            }
//            Console.WriteLine("Select a number to continue:");
//            while (true)
//            {
//                string s;
//                if ((s = Console.ReadLine()) != null
//                    && int.TryParse(s, out int i) // c# 7
//                    && i >= 0
//                    && i < namedFactories.Count)
//                {
//                    Console.Write("How much: ");
//                    s = Console.ReadLine();
//                    if (s != null
//                        && int.TryParse(s, out int total)
//                        && total > 0)
//                    {
//                        return namedFactories[i].Item2.Prepare(total);
//                    }
//                }
//                Console.WriteLine("Something went wrong with your input, try again.");
//            }
//        }
//    }
//}


namespace Labb3_DrinkMachine
{
    public class WarmDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffee,
            Tea,
            Cappuccino,
            Chocolate,
            Water,
        }

        public IWarmDrink MakeDrink()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the AI Drink machine. How can I assist you today?");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("This is what my rainbow meny serve today:");
           
           // Console.Clear();
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                Console.ForegroundColor = GetDrinkColor(drink);
                Console.WriteLine($"{(int)drink}: {drink}");
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Select a number to continue:");
            Console.ResetColor();
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                string input = Console.ReadLine();

                if (int.TryParse(input, out int selection)
                    && Enum.IsDefined(typeof(AvailableDrink), selection))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("How much: ");
                    if (int.TryParse(Console.ReadLine(), out int total) && total > 0)
                    {
                        Console.WriteLine();
                        AvailableDrink selectedDrink = (AvailableDrink)selection;
                        IWarmDrinkFactory factory = GetFactoryForDrink(selectedDrink);
                        return factory.Prepare(total);
                    }
                }

                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        //Set color like rainbow,  after 6 option it starts over.
        private ConsoleColor GetDrinkColor(AvailableDrink drink)
        {
            int drinkIndex = (int)drink;
            int colorIndex = drinkIndex % 6; // Number of colors in the rainbow pattern

            switch (colorIndex)
            {
                case 0:
                    return ConsoleColor.Red;
                case 1:
                    return ConsoleColor.Yellow;
                case 2:
                    return ConsoleColor.Green;
                case 3:
                    return ConsoleColor.Cyan;
                case 4:
                    return ConsoleColor.Blue;
                case 5:
                    return ConsoleColor.Magenta;
                default:
                    return ConsoleColor.White;
            }
        }

        private IWarmDrinkFactory GetFactoryForDrink(AvailableDrink drink)
        {
            switch (drink)
            {
                case AvailableDrink.Coffee:
                    return new CoffeeFactory();
                case AvailableDrink.Tea:
                    return new TeaFactory();
                case AvailableDrink.Cappuccino:
                    return new CappuccinoFactory();
                case AvailableDrink.Chocolate:
                    return new ChocolateFactory();
                case AvailableDrink.Water:
                    return new HotWaterFactory();
                default:
                    throw new InvalidOperationException("Invalid drink selection.");
            }
        }
    }
}
