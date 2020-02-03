using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        Stack<Sweepstakes> stack;

        //Constructor

        //Member Methods (CAN DO)
        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakes = stack.Pop();
            return sweepstakes;
        }
    }
}
