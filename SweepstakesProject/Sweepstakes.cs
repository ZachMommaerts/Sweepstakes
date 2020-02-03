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
            this.name;
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
            int i = contestants.Count;
            Random random = new Random();
            random.Next(i);
            return contestants(i, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.registrationNumber} : {contestant.firstName} {contestant.lastName} : {contestant.emailAddress}");
        }
    }
}
