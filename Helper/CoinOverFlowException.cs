using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Helper
{
    public class CoinOverFlowException : Exception
    {
        public CoinOverFlowException()
            : base("Coins overflowed the jar")
        {
        }
    }
}
