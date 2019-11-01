using System;

namespace StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("student Registration Form");
            Console.WriteLine();

            Console.WriteLine("Enter first name: ");
            String FName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            String LName = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            String Birth = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Welcome " + FName + " " + LName);
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("Your temporary password is: " + FName + "*" + Birth);
        } 
    }
}
