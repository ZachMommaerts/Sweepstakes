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

        //Member Methods (CAN DO)
        public string SweepstakesName()
        {
            name = "SuperBowl Ticket Giveaway";
            return name;
        }
        public void RegisterContestant(Contestant contestant)
        {


        }
        public Contestant Pickwinner()
        {
            Random random = new Random();
            random.Next(contestants.Count);
            return Contestant
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant.firstName = UserInterface.GetUserInputFor("first name");
            contestant.lastName = UserInterface.GetUserInputFor("last name");
            contestant.emailAddress = UserInterface.GetUserInputFor("email address");
        }
    }
}
