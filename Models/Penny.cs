using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Models
{
    public class Penny : UsCoin
    {

        public Penny() : base(0.0122, 0.01) { }

    }
}
