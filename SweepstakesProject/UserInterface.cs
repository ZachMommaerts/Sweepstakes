using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine($"Please enter your {prompt}.");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetDataStructurePreference()
        {
            Console.WriteLine($"Please enter if you would like to use stack or queue data structures (type stack or queue)");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetSweepstakesName()
        {
            Console.WriteLine("Please enter the name of the sweepstakes");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
