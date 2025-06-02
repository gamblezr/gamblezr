using System;

 

class Program

{

    static void Main()

    {

        bool continueProgram = true;

 

        while (continueProgram)

        {

            Console.WriteLine("Enter the first number:");

            string input1 = Console.ReadLine();

 

            Console.WriteLine("Enter the second number:");

            string input2 = Console.ReadLine();

 

            try

            {

                double num1 = Convert.ToDouble(input1);

                double num2 = Convert.ToDouble(input2);

 

                if (num2 == 0)

                {

                    Console.WriteLine("Error: Division by zero is not allowed.");

                }

                else

                {

                    try

                    {

                        double result = Divide(num1, num2);

                        Console.WriteLine($"Result: {result}");

                    }

                    catch (DivideByZeroException)

                    {

                        Console.WriteLine("Error: Division by zero is not allowed.");

                    }

                }

            }

            catch (FormatException)

            {

                Console.WriteLine("Error: Please enter valid numbers.");

            }

            catch (OverflowException)

            {

                Console.WriteLine("Error: The number entered is too large.");

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Unexpected Error: {ex.Message}");

            }

 

            Console.WriteLine("\nPress Enter to continue or type 'exit' to quit:");

            string userChoice = Console.ReadLine();

            if (userChoice?.ToLower() == "exit")

            {

                continueProgram = false;

            }

            Console.Clear(); // Optional: clears the console before starting over

        }

    }

 

    static double Divide(double a, double b)

    {

        if (b == 0)

        {

            throw new DivideByZeroException();

        }

        return a / b;

    }

}
