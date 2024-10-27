using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal class Dog(string name = "Unknown", string color = "Unknown", int age = 0, double weight = 0.0, string specie = "Unknown", string breed = "Unknown")
        : Animal(name, color, age, weight, specie)
    {
        public string Breed { get; set; } = breed;
        // New method representing the dog playing
        public void PlayFetch()
        {
            Console.WriteLine($"{Name} hämtar en boll");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Hunden Skäller! Voff Voff");
        }
        public override string ToString()
        {
            return base.ToString() + $"ras: {Breed}";
        }
    }
}
