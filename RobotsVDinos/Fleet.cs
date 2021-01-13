using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Fleet
    {
        // member variables
        public List<Robot> robots;

        //constructor
        public Fleet()
        {
            robots = new List<Robot>();

            Robot robot1 = new Robot("Terminator", "Sword");
            Robot robot2 = new Robot("Smitty", "Bazooka");
            Robot robot3 = new Robot("Tommy", "Laser-Eyes");

            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }

        //member methods
    }
}
