﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager _manager;
            switch (UserInterface.GetDataStructurePreference())
            {
                case "queue":
                    _manager = new SweepstakesQueueManager();
                    break;
                case "stack":
                    _manager = new SweepstakesStackManager();
                    break;
                default:
                    Console.WriteLine("Not a valid option. Please choose again");
                    CreateMarketingFirmWithManager();
                    break;
            }
        }
    }
}
