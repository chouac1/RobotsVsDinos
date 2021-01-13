using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Robot
    {
        // member variables
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon;

        //constructor
        public Robot(string name, string weaponType)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            weapon = new Weapon(weaponType);
        }

        //member methods

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }

    }
}
