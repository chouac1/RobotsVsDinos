using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Dinosaur
    {
        // member variables

        public string type;
        public double health;
        public double energy;
        public double attackPower;

        //constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 100;
            Random rng = new Random();
            attackPower = rng.Next(1, 4);

        }

        //member methods
        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
        }
    }

}
