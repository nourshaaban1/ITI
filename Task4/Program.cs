using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1: checking if the number is positive, negative, or zero
            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("The number is positive");
            } else if (num1 < 0)
            {
                Console.WriteLine("The number is negative");
            } else {
                Console.WriteLine("The number is zero");
            }

            // task 2: checking if the number is even, or odd
            Console.WriteLine("Enter a number");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            // task 3: checking if rect is square 
            Console.WriteLine("Enter the height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());

            if(height == width)
            {
                Console.WriteLine("the shape is square");
            }else
            {
                Console.WriteLine("the shape is rectangle");
            }
        }
    }
}
