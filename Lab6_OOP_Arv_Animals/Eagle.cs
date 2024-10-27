using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal class Eagle(string name = "Unknown", string color = "Unknown", int age = 0, double weight = 0.0, bool canFly = true, double wingSpan = 2.0)
        : Bird(name, color, age, weight, "Örn", canFly)
    {
        public double WingSpan { get; set; } = wingSpan;
        public override void MakeSound()
        {
            Console.WriteLine($"{Specie} Skriker!");
        }
        // New method representing the eagle's hunting
        public void Hunt()
        {
            Console.WriteLine($"{Name} dyker för ");
        }
        public override string ToString()
        {
            return base.ToString() + $", vingspan: {WingSpan} m";
        }
    }
}
