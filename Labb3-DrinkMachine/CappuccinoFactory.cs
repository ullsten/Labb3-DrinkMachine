using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml of the best cappuccino in your cup.");
            return new Cappuccino();
        }
    }
}
