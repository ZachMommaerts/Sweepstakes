using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        Queue<Sweepstakes> queue;

        //Constructor

        //Member Methods (CAN DO)
        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakes = queue.Dequeue();
            return sweepstakes;
        }
    }
}
