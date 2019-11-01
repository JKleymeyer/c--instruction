using System;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");


            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter an integer");
                int integer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number\t" + "Square\t" + "Cube");
                Console.WriteLine("======\t" + "======\t" + "====");

                for (int i = 1; i <= integer; i++)
                {
                    int square = i + i;
                    int cube = i + i + i;

                    Console.WriteLine(+i+ "\t" + square+ "\t" + cube);
                }

                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
