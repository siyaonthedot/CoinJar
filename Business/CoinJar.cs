using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinJar.Interface;
using CoinJar.Models;
using CoinJar.Helper;
using System.Threading.Tasks;

namespace CoinJar.Business
{
    public class CoinJar : ICoinJar
    {
        private List<ICoin> coinHeap;
        private FluidOunces totalVolume;
        private ICurrency actualAmount;
        private FluidOunces actualVolume;

        /// <summary>
        /// Get Total Amount
        /// </summary>
        public decimal TotalAmount
        {
            get
            {
                return Convert.ToDecimal(actualAmount.UnitPrice);
            }

        }
        /// <summary>
        /// Get Total Volume
        /// </summary>
        public IVolume TotalVolume
        {
            get
            {
                return totalVolume;
            }
        }

        public CoinJar()
        {
            totalVolume = new FluidOunces();
            totalVolume.Unit = 420000;
            Reset();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coin"></param>
        public void AddCoin(ICoin coin)
        {
            if (coin.GetType().BaseType != typeof(UsCoin))
                throw new InValidCoinException("MyCoinJar accepts only UsCoin");
            if (this.TotalVolume.Unit < (this.actualVolume.Unit + coin.Volume.Unit))
                throw new CoinOverFlowException();

            coinHeap.Add(coin);
            actualVolume.Unit += coin.Volume.Unit;
            actualAmount.UnitPrice += coin.Amount.UnitPrice;
        }

        /// <summary>
        /// Reset Coin and FluidOunces
        /// </summary>
        public void Reset()
        {
            coinHeap = new List<ICoin>();
            actualVolume = new FluidOunces();
            actualAmount = new USCurrency();
        }

       
    }
}
