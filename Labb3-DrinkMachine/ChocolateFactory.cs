using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class ChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Grandma has served {total} ml of her wonderful chocolate! ");
            return new Chocolate();
        }
    }
}
