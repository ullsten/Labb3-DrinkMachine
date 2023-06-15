using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class TeaFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Himalayan tea with {total} ml is served by Red Panda Heidi!");
            return new Tea();
        }
    }
}
