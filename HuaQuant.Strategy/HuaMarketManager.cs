using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartQuant.Trading;
using SmartQuant.Instruments;

namespace HuaQuant.Strategy
{
    class HuaMarketManager:MarketManager
    {
        //在初始化的时候，将投资组合中的证券添加到市场中去
        public override void Init()
        {
            base.Init();
            foreach(Position position in this.Portfolio.Positions)
            {
                this.AddInstrument(position.Instrument);
            }
        }
    }
}
