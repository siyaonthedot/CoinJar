using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinJar.Business;
using CoinJar.Interface;
using CoinJar.Models;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {
        static void Main(string[] args)
        {

            ICoin coin = new Dollar();
            coin.Amount.UnitPrice = 20;
            CoinJar.Business.CoinJar jar = new CoinJar.Business.CoinJar();
            jar.AddCoin(coin);
            coin.Amount.UnitPrice = 20;
            jar.AddCoin(coin);
            coin.Amount.UnitPrice = 20;
            jar.AddCoin(coin);
            Console.WriteLine("Total Amount: " + jar.TotalAmount);
            Console.ReadKey();

        }
    }
}
