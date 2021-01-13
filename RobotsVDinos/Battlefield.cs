using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Battlefield
    {
        // member variables
        public Fleet fleet;
        public Herd herd;

        //constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //member methods
        public void Battle()
        {
            while (herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                fleet.robots[0].Attack(herd.dinosaurs[0]);
                if (herd.dinosaurs[0].health <= 0)
                    herd.dinosaurs.RemoveAt(0);

                if (herd.dinosaurs.Count == 0)
                    break;

                herd.dinosaurs[0].Attack(fleet.robots[0]);
                if (fleet.robots[0].health <= 0)
                    fleet.robots.RemoveAt(0);
            }

            if (fleet.robots.Count > 0)
                Console.WriteLine("Robots are victorious!");
            else
                Console.WriteLine("Dinosaurs are victorious!");

        }
    }
}
