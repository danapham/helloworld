﻿using System;
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
            var firstThree = digits.Substring(0, 3);
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
        static string LetterLooper(string input)
        {
            char[] splitUp = input.ToCharArray();
            string[] convertedSplitUp = Array.ConvertAll(splitUp, element => element.ToString());
            string[] uppercased = Array.ConvertAll(convertedSplitUp, element => element.ToUpper());

            for (int i = 0; i < input.Length; i++)
            {
               string newValue = uppercased[i].PadRight(i + 1, splitUp[i]);
               convertedSplitUp[i] = newValue;
            }
            return String.Join("-", convertedSplitUp);
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

            //Console.WriteLine("Enter a phone number.");
            //var number = Console.ReadLine();
            //var result2 = NumberValidation(number);
            //Console.WriteLine(result2);

            //Console.WriteLine("Enter a serial code.");
            //var serial = Console.ReadLine();
            //Console.WriteLine(LetterLooper(serial));

            Console.WriteLine("Enter operation.");
            var operation = Console.ReadLine();
            var firstTwo = operation.Substring(0, 2);
            string numbers;
            if (firstTwo == "^2")
            {
                var trimmed = operation.TrimStart('*', ' ', '^', '+', '/');
                numbers = trimmed.Remove(0, 1);
            }
            else if (firstTwo == "av")
            {
                numbers = operation.Remove(0, 3);
            }
            else
            {
                numbers = operation.TrimStart('*', ' ', '^', '+', '/');
            }
            string[] splitNumbers = numbers.Split(",");
            int[] convertedNumbers = Array.ConvertAll(splitNumbers, number => Int32.Parse(number));

            switch (firstTwo)
            {
                case "* ":
                    var multiplied = 1;
                    foreach (int number in convertedNumbers)
                    {
                        multiplied *= number;
                    }
                    Console.WriteLine(multiplied);
                    break;
                case "^2":
                    for (int i = 0; i < convertedNumbers.Length; i++)
                    {
                        convertedNumbers[i] *= convertedNumbers[i];
                    }
                    Console.WriteLine(string.Join(',', convertedNumbers));
                    break;
                case "+ ":
                    var added = 0;
                    foreach (int number in convertedNumbers)
                    {
                        added += number;
                    }
                    Console.WriteLine(added);
                    break;
                case "/ ":
                    var divided = convertedNumbers[0] / convertedNumbers[1];
                    Console.WriteLine(divided);
                    break;
                case "av":
                    var sum = 0;
                    for (int i = 0; i < convertedNumbers.Length; i++)
                    {
                        sum += convertedNumbers[i];
                    }
                    var average = sum / convertedNumbers.Length;
                    Console.WriteLine(average);
                    break;
            }
        }
    }
}
