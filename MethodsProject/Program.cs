using System;

namespace MethodsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StoryTelling();

            var result1 = Sum(2, 6, 1, 1, 1);
            Console.WriteLine($"The sum is: {result1}");

            var result2 = Multiply(2, 6);
            Console.WriteLine($"The product is: {result2}");

            var result3 = Divide(6, 2);
            Console.WriteLine($"This division's answer is: {result3}");

            var result4 = Subtract(2, 6);
            Console.WriteLine($"The difference is: {result4}");


        }

        public static void StoryTelling()
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
            Console.WriteLine("We wish him the best of luck!");

            Console.WriteLine();
            Console.WriteLine("Output for Exercise no. 2:");
        }

        // Exercise no. 2

        public static int Sum(params int[] list)
        {
            int TheSum = 0;
            for (int i = 0; i < list.Length; i++)
                TheSum = TheSum + list[i];
                return TheSum;
            
        }

        public static int Multiply(params int[] list)
        {
            int TheProduct = 1;
            for (int i = 0; i < list.Length; i++)
                TheProduct = TheProduct * list[i];
            return TheProduct;
        }

        public static int Subtract(params int[] list)
        {
            int TheDiff = 0;
            for (int i = 0; i < list.Length; i++)
                TheDiff = list[0] - list[i];
            return TheDiff;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
