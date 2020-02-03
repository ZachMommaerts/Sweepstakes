using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        //Member Variables (HAS A)
        ISweepstakesManager _manager;

        //Constructor
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }

        //Member Methods (CAN DO)
        public void CreateSweepstakes()
        {
            _manager.InsertSweepStakes(Sweepsweepstakes)
        }
    }
}
