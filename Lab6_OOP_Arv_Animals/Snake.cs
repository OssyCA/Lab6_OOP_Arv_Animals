using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal class Snake(string name = "Unknown", string color = "Unknown", int age = 0, double weight = 0.0, string species = "Snake", double length = 0.0)
        : Animal(name, color, age, weight, species)
    {
        public double Length { get; set; } = length;
        public override void MakeSound()
        {
            Console.WriteLine($"{Specie} låter hizzzz");
        }
        public override void Eat() // Overrides the eat meathod from animal
        {
            Console.WriteLine($"{Name} äter mindre djur!");
        }
        public override string ToString()
        {
            return base.ToString() + $", Längd: {Length} m";
        }
    }
}
