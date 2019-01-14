using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinJar.Interface;
using System.Threading.Tasks;

namespace CoinJar.Models
{
    public class FluidOunces : IVolume
    {

        public double Unit { get; set; }

        public FluidOunces() { }

        public FluidOunces(double unit)
        {
            Unit = unit;
        }

    }
}
