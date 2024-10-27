using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv_Animals
{
    internal abstract class Animal(string name = "Unknown", string color = "Unknown", int age = 0, double weight = 0.0, string specie = "Unknown")
    {
        public string Name { get; set; } = name;
        public string Color { get; set; } = color;
        public int Age { get; set; } = age;
        public double Weight { get; set; } = weight;
        public string Specie { get; set; } = specie;
        public abstract void MakeSound(); // Abstract method for the sound the animal makes

        // Method to check if the animal is overweight compared to the target weight
        public bool IsOverWeight(int targetWeight)
        {
            if (Weight <= targetWeight)
            {
                return false;
            }
            return true;

        }
        // Virtual method to describe the eating behavior of the animal
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} äter");
        }
        // Overridden method to return information about the animal
        public override string ToString()
        {
            return $"Namn: {Name}, Art: {Specie}, Färg: {Color}, Ålder: {Age} år, Vikt: {Weight} kg ";
        }
    }
}
