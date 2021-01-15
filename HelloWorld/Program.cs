using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static bool PinValidation(string pin)
        {
            Int32.TryParse(pin, out int intPin );
            if (pin.Length >= 4 && pin.Length <= 8 && intPin != 0)
                return true;
            else
                return false;
        }
        static bool NumberValidation(string number)
        {
            var digits = "";
            foreach (char c in number)
            {
                if (Char.IsDigit(c))
                    digits += c;
            }
            var firstThree = digits.Substring(3, 3);
            var count = firstThree.Count(x => x.ToString() == "5");
            if (digits.ToString().Length == 10 && count != 3)
            {
                foreach (char c in number)
                {
                    if (Char.IsNumber(c) || Char.IsWhiteSpace(c) || c.ToString() == "-" || c.ToString() == "(" || c.ToString() == ")")
                        continue;
                    else
                    {
                        return false;
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
                
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Choose from the following greetings: Howdy Y'all, Wassup, Hai");
            //var greeting = Console.ReadLine();

            //if (greeting == "")
            //    greeting = "Howdy Y'all";

            //Console.WriteLine($"You chose {greeting}.");

            //Console.WriteLine($"What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine($"{greeting} {name}.");

            //Console.WriteLine("What is your favorite color?");
            //var color = Console.ReadLine();

            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            //var random = new Random();
            //var randomIndex = random.Next(0, animals.Length);
            //Console.WriteLine($"Would you like to have a {color} {animals[randomIndex]}?");

            //foreach (var animal in animals)
            //{

            //    Console.WriteLine(animal);
            //}

            //Console.WriteLine("Tell me a secret");
            //var secret = Console.ReadLine();
            //var masked = secret.Substring(secret.Length - 4).PadLeft(secret.Length, '*');
            //Console.WriteLine(masked);

            //Console.WriteLine("Enter a pin code.");
            //var pin = Console.ReadLine();
            //bool result = PinValidation(pin);
            //Console.WriteLine(result);

            Console.WriteLine("Enter a phone number.");
            var number = Console.ReadLine();
            var result2 = NumberValidation(number);
            Console.WriteLine(result2);
        }
    }
}
