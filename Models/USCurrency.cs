using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinJar.Interface;
using System.Threading.Tasks;

namespace CoinJar.Models
{
    public class USCurrency : ICurrency
    {
        public double UnitPrice { get; set; }
        public USCurrency() { }
        public USCurrency(double unitPrice)
        {
            UnitPrice = unitPrice;
        }

    }
}
