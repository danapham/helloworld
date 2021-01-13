using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from the following greetings: Howdy Y'all, Wassup, Hai");
            var greeting = Console.ReadLine();

            if (greeting == "")
                greeting = "Howdy Y'all";

            Console.WriteLine($"You chose {greeting}.");

            Console.WriteLine($"What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"{greeting} {name}.");

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            var random = new Random();
            var randomIndex = random.Next(0, animals.Length);
            Console.WriteLine($"Would you like to have a {color} {animals[randomIndex]}?");

            foreach (var animal in animals)
            {

                Console.WriteLine(animal);
            }
        }
    }
}
