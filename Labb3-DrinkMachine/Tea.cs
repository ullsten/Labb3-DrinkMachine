using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class Tea : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Himalayan tea is served.");
        }
    }
}
