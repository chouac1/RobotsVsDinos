using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    public class Herd
    {
        // member variables
        public List<Dinosaur> dinosaurs;

        //constructor
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("T-REX");
            Dinosaur dinosaur2 = new Dinosaur("Raptor");
            Dinosaur dinosaur3 = new Dinosaur("Megladon");

            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }

        //member methods
    }
}
