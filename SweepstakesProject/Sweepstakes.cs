using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //Member Variables (HAS A)
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Constructor
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //Member Methods (CAN DO)
        public string SweepstakesName()
        {
            name = "SuperBowl Ticket Giveaway";
            return name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            PrintContestantInfo(contestant);
            contestants.Add(contestant.registrationNumber, contestant);

        }
        public Contestant Pickwinner()
        {
            int i = contests[i, value];
            Random random = new Random();
            random.Next(contestants.Count);
            return contestants;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.registrationNumber} : {contestant.firstName} {contestant.lastName} : {contestant.emailAddress}");
        }
    }
}
