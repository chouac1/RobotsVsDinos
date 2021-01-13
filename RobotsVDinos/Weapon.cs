using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Weapon
    {
        // member variables
        public string type;
        public double attackPower;

        //constructor
        public Weapon(string type)
        {
            this.type = type;
            Random rng = new Random();
            attackPower = rng.Next(1, 4);
        }

        //member methods
    }
}
