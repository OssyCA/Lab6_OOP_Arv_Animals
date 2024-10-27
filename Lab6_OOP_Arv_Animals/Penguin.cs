using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal class Penguin(string name = "Unknown", string color = "Black and White", int age = 0, double weight = 0.0, double swimmingSpeed = 10.0)
        : Bird(name, color, age, weight, "Penguin", canFly: false)
    {
        public double SwimmingSpeed { get; set; } = swimmingSpeed;
        public override void MakeSound()
        {
            Console.WriteLine($"{Specie} Pipade ljud!");
        }
        // Method representing the penguin's swimming behavior
        public void Swim()
        {
            Console.WriteLine($"{Name} simmar i {SwimmingSpeed} km/h!");
        }
        public override string ToString()
        {
            return base.ToString() + $", Sim fart: {SwimmingSpeed} km/h";
        }
    }
}
