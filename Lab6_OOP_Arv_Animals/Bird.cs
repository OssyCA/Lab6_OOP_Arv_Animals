using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal class Bird(string name = "Unknown", string color = "Unknown", int age = 0, double weight = 0.0, string species = "Bird", bool canFly = true) :
        Animal(name, color, age, weight, species) // inheritance from animal
    {
        public bool CanFly { get; set; } = canFly;
        public override void MakeSound() // Overrides the abstract MakeSound method from the Animal base class
        {
            Console.WriteLine($"{Specie} kvittrar!");
        }
        public override string ToString()
        {
            string flyMsg = CanFly ? "Kan flyga" : "Kan inte flyga"; // message depending if the bird can fly
            return base.ToString() + $", {flyMsg}";
        }
    }
}
