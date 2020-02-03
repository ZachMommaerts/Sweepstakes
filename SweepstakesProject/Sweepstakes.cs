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
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member Methods (CAN DO)
     
        public void RegisterContestant(Contestant contestant)
        {
            int i = contestants.Count;
            PrintContestantInfo(contestant);
            contestants.Add(i, contestant);
            i++;
        }
        public Contestant Pickwinner()
        {
            int winner;
            int i = contestants.Count;
            Random random = new Random();
            winner = random.Next(i + 1);
            return contestants[winner];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count;
            Console.WriteLine($"{contestant.registrationNumber} : {contestant.firstName} {contestant.lastName} : {contestant.emailAddress}");
        }
    }
}
