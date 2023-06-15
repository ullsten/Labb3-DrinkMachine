using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3_DrinkMachine.Interfaces;

namespace Labb3_DrinkMachine
{
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("The best Coffee is served.");
        }
    }
}
