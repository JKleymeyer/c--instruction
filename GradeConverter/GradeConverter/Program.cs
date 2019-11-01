using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Grade Converter");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter Numerical Grade: ");
                String input = Console.ReadLine();
                int NumGrade = int.Parse(input);
                String LetterGrade = " ";

                if(NumGrade >= 88) {
                    LetterGrade = "A";
                } else if (NumGrade >= 80) {
                    LetterGrade = "B";
                } else if (NumGrade >= 67) {
                    LetterGrade = "C";
                } else if (NumGrade >= 60) {
                    LetterGrade = "D";
                } else {
                    LetterGrade = "F";
                }

                Console.WriteLine("Letter Grade:" + LetterGrade);
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
