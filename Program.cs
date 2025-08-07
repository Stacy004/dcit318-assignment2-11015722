using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("=== DCIT 318 ASSIGNMENT MENU ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunGradeCalculator();
                        break;
                    case "2":
                        RunTicketPriceCalculator();
                        break;
                    case "3":
                        RunTriangleIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("\nExiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunGradeCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== GRADE CALCULATOR ===");
            Console.Write("Enter a grade (0 - 100): ");

            string input = Console.ReadLine();
            int grade;

            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                if (grade >= 90)
                    Console.WriteLine("Letter Grade: A");
                else if (grade >= 80)
                    Console.WriteLine(" Grade: B");
                else if (grade >= 70)
                    Console.WriteLine(" Grade: C");
                else if (grade >= 60)
                    Console.WriteLine(" Grade: D");
                else
                    Console.WriteLine(" Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        static void RunTicketPriceCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== TICKET PRICE CALCULATOR ===");
            Console.Write("Enter your age: ");

            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age) && age >= 0)
            {
                if (age <= 12 || age >= 65)
                    Console.WriteLine("Ticket Price: GHC7");
                else
                    Console.WriteLine("Ticket Price: GHC10");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        static void RunTriangleIdentifier()
        {
            Console.Clear();
            Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");

            double side1 = ReadPositiveDouble("Enter length of side 1: ");
            double side2 = ReadPositiveDouble("Enter length of side 2: ");
            double side3 = ReadPositiveDouble("Enter length of side 3: ");

            // Check for triangle validity first
            if (IsValidTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("Triangle Type: Equilateral");
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    Console.WriteLine("Triangle Type: Isosceles");
                else
                    Console.WriteLine("Triangle Type: Scalene");
            }
            else
            {
                Console.WriteLine("The values entered do not form a valid triangle.");
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        static double ReadPositiveDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("Please enter a valid positive number.");
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
