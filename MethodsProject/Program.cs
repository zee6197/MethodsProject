using System;

namespace MethodsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); 
            var name = Console.ReadLine();

            Console.WriteLine("What is your major?");
            var major = Console.ReadLine();

            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();

            Console.WriteLine("Which school are you enrolled in?");
            var school = Console.ReadLine();

            Console.WriteLine("What is your graduation date?");
            var graduation = Console.ReadLine();

            Console.WriteLine($"{name} is a passionate student. His major is {major}.");
            Console.WriteLine($"His favorite subject is {subject}.");
            Console.WriteLine($"He's enrolled in {school}. He's graduating in {graduation}.");
        }
    }
}
