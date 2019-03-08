using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartQuant.Trading;

namespace HuaQuant.Strategy
{
    internal class HuaStrategy:ATSStrategy
    {
        public HuaStrategy(string name, string description) : base(name, description) {
            this.marketManager = new HuaMarketManager();

        }

    }
}
