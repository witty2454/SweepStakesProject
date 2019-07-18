using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> theStack;

        public SweepstakesStackManager()
        {
            theStack = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            return theStack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            theStack.Push(sweepstakes);
        }
    }
}