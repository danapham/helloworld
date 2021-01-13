using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from the following greetings: Howdy Y'all!!, Wassup?!, Hai");
            var input = Console.ReadLine();

            if (input == "")
                input = "Howdy Y'all!!";

            Console.WriteLine($"You chose {input}.");
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            
            foreach(var animal in animals)
            {

                Console.WriteLine(animal);
            }
        }
    }
}
