﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_DrinkMachine.Interfaces
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
