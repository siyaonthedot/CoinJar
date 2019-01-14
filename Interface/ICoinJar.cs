using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Interface
{
    public interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal TotalAmount { get; }
        void Reset();
    }

}
