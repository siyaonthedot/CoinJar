using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Models
{
    public class Dollar : UsCoin
    {

        public Dollar() : base(0.0800, 1.0) { }

    }
}
