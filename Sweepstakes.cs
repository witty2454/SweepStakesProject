using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        Random random = new Random();
        int Drawing;
        int regNumber;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            regNumber = contestants.Count() + 1;
            contestants.Add(regNumber, contestant);
        }

        public Contestant PickWinner()
        {
            do
            {
                Drawing = random.Next(0, contestants.Count + 1);
            } while (!contestants.ContainsKey(Drawing));

            return contestants[Drawing];                        
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName + " " + contestant.LastName
                + ", " + contestant.EmailAddress);
        }
    }
}