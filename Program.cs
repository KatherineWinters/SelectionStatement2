using System;

namespace SelectionStatement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();
            
            switch (subject.ToLower())

            {
                case "english":
                    Console.WriteLine("Your favorite school subject is english.");
                    break;
                case "science":
                    Console.WriteLine("Your favorite school subject is science.");
                    break;
                case "math":
                    Console.WriteLine("Your favorite school subject is math.");
                    break;
                case "spanish":
                    Console.WriteLine("Your favorite school subject is spanish.");
                        break;
                case "gym":
                    Console.WriteLine("Your favorite school subject is gym.");
                    break;
                default:
                    Console.WriteLine($"Your favorite school subject isn't an option.");
                    break;
            }

        }
    }
}
