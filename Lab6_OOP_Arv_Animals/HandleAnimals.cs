using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6_OOP_Arv_Animals
{
    internal class HandleAnimals
    {
        public List<Animal> Animals { get; set; }

        public HandleAnimals()
        {
            Animals = []; // Initialize the list of animals
            AddAnimals(); // Populate the list with animals
        }

        private void AddAnimals()
        {
            // Add different animals to the list with their attributes
            Animals.Add(new Dog(name: "Rex", color: "Brown", age: 5, weight: 25.0, specie: "Dog", breed: "German Shepherd"));
            Animals.Add(new Penguin(name: "Pingi", age: 3, weight: 12.5, swimmingSpeed: 15.0));
            Animals.Add(new Eagle(name: "Majestic", color: "White/Black", age: 7, weight: 6.3, wingSpan: 2.5));
            Animals.Add(new Bird(name: "Tweety", color: "Yellow", age: 2, weight: 0.1, species: "Dove", canFly: true));
            Animals.Add(new Snake(name: "Pytte", color: "Green", age: 8, weight: 45.7, species: "Python", length: 4.5));
            Animals.Add(new Dog(name: "Buddy", color: "Black", age: 4, weight: 30.0, specie: "Dog", breed: "Labrador"));
            Animals.Add(new Penguin(name: "Chilly", age: 2, weight: 11.0, swimmingSpeed: 12.0));
            Animals.Add(new Eagle(name: "Freedom", color: "Brown", age: 5, weight: 5.0, wingSpan: 2.0));
        }
        public void StartAll()
        {
            ShowAnimalInfo(); // Display information about all animals
            ShowOverWeightAnimals(10); // Show overweight animals above a certain weight
            MakeSound(); // Make sounds for each animal
        }
        private void ShowAnimalInfo()
        {
            Console.WriteLine("Info om djuren:"); // Header for animal information
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal); // Display each animal's information
            }
            Console.WriteLine(); // Empty line to separate sections
        }
        private void ShowOverWeightAnimals(int targetWeight)
        {
            Console.WriteLine($"Överviktiga djur med target vikt: {targetWeight} kg..."); // Header for overweight animals
            foreach (var animal in Animals.Where(a => a.IsOverWeight(targetWeight)))
            {
                Console.WriteLine($"{animal.Name} väger {animal.Weight} kg, överviktig med: {animal.Weight - targetWeight} kg"); // Display overweight information
            }
            Console.WriteLine(); // Empty line to separate sections
        }
        private void MakeSound()
        {
            Console.WriteLine("Ljud från djuren:"); // Header for animal sounds
            foreach (var animal in Animals)
            {
                animal.MakeSound(); // Call the method to make sound
            }
            Console.WriteLine(); // Empty line to separate sections
        }
    }
}
