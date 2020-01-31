using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine($"{prompt}");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
