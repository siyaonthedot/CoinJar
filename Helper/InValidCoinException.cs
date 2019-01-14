using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Helper
{
    public class InValidCoinException : Exception
    {
        public InValidCoinException(string message)
            : base(message)
        {
        }
    }
}
