using System;
using System.Collections.Generic;

// This program simulates owning and interacting with pets.
// Author: Yanzhi Wang
// Restrictions on the usage or known errors: None
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        List<Pet> pets = new List<Pet>();

        // Add a dog named Puddles to the list of pets
        Console.WriteLine("You bought a dog!");
        Console.Write("Dog's Name => ");
        string name = Console.ReadLine();
        Console.Write("Age => ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("License => ");
        int license = int.Parse(Console.ReadLine());
        Pet puddles = new Dog(name, age, license);
        pets.Add(puddles);

        // Loop through 20 iterations with a 90% chance of using an existing pet and a 10% chance of buying a new pet
        for (int i = 0; i < 20; i++)
        {
            if (rand.NextDouble() < 0.1)
            {
                // Buy a new pet
                Console.WriteLine("\nYou bought a cat!");
                Console.Write("Cat's Name => ");
                name = Console.ReadLine();
                Console.Write("Age => ");
                age = int.Parse(Console.ReadLine());
                Pet cat = new Cat(name, age);
                pets.Add(cat);
            }
            else
            {
                // Use an existing pet
                Pet pet = pets[rand.Next(pets.Count)];
                if (pet is Dog)
                {
                    Dog dog = (Dog)pet;
                    switch (rand.Next(3))
                    {
                        case 0:
                            Console.WriteLine(dog.Name + ": Yummy, I will eat anything!");
                            break;
                        case 1:
                            Console.WriteLine(dog.Name + ": Woof woof!");
                            break;
                        case 2:
                            Console.WriteLine(dog.Name + ": Woof woof, I need to go out.");
                            break;
                    }
                }
                else
                {
                    Cat cat = (Cat)pet;
                    switch (rand.Next(4))
                    {
                        case 0:
                            Console.WriteLine(cat.Name + ": Hiss!");
                            break;
                        case 1:
                            Console.WriteLine(cat.Name + ": Where's that mouse...");
                            break;
                        case 2:
                            Console.WriteLine(cat.Name + ": Yuck, I don't like that!");
                            break;
                        case 3:
                            Console.WriteLine(cat.Name + ": purrrrrrrrrrrrrrrrrrrr...");
                            break;
                    }
                }
            }
        }
    }
}

// This is the abstract base class for all pets.
// Author: Yanzhi Wang
// Restrictions on the usage or known errors: None
abstract class Pet
{
    // The pet's name
    public string Name { get; set; }

    // The pet's age
    public int Age { get; set; }

    // Constructor
    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// This class represents a dog.
// Author: Yanzhi Wang
// Restrictions on the usage or known errors: None
class Dog : Pet
{
    // The dog's license number
    public int License { get; set; }

    // Constructor
    public Dog(string name, int age, int license) : base(name, age)
    {
        License = license;
    }
}

// This class represents a cat.
// Author: Yanzhi Wang
// Restrictions on the usage or known errors: None
class Cat : Pet
{


    // Constructor
    public Cat(string name, int age) : base(name, age)
    {
    }
}

// The program simulates owning and interacting with pets, including buying new pets and using existing ones.
// The program includes an abstract Pet class and two derived classes, Dog and Cat, which inherit from Pet.
// Author: Yanzhi Wang
// Restrictions on the usage or known errors: None




