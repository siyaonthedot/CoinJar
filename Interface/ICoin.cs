using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Interface
{
    public interface ICoin
    {
        IVolume Volume { get; }
        ICurrency Amount { get; }

    }
}
