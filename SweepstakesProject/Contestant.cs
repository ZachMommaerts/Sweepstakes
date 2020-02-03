using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {
        //Member Variables (HAS A)
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //Constructor
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("first name");
            lastName = UserInterface.GetUserInputFor("last name");
            emailAddress = UserInterface.GetUserInputFor("email address");
            Random random = new Random();
        }

        //Member Methods (CAN DO)


    }
}
