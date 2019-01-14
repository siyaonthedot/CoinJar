using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinJar.Interface;
using System.Threading.Tasks;

namespace CoinJar.Models
{
    public abstract class UsCoin : ICoin
    {

        public IVolume Volume { get; private set; }
        public ICurrency Amount { get; private set; }
        //public UsCoin()

        public UsCoin(double volume, double value)
        {
            Volume = new FluidOunces(volume);
            Amount = new USCurrency(value);
        }

    }
}
