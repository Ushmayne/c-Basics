using System;




public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculator Application");

        for (bool run = true; run;)
        {

            Console.Write("Would you like to continue enter 1 for yes and any other number for no: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("The answer is: " + operations());
            }
            else
            {
                run = false;
            }
        }
        Console.WriteLine("Thank you for using the calculator application :)");
    }

    public static double operations()
    {
        int operation = 0;
        Console.WriteLine("Enter what operation you would like: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Exponentiation");
        Console.WriteLine("7. Square Root");
        Console.WriteLine("8. Factorial");
        do
        {
            operation = Convert.ToInt32(Console.ReadLine());
        } while (operation < 1 || operation > 8);

        int secondNumber = 0;
        Console.WriteLine("Enter the first number you would like to perform the operation on: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        if (operation != 7 && operation != 8)
        {
            Console.WriteLine("Enter the second number you would like to perform the operation on: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }


        switch (operation)
        {
            case 1:
                return (firstNumber + secondNumber); ;
                break;
            case 2:
                return (firstNumber - secondNumber);
                break;
            case 3:
                return (firstNumber * secondNumber);
                break;
            case 4:
                return (firstNumber / secondNumber);
                break;
            case 5:
                return (firstNumber % secondNumber);
                break;
            case 6:
                return (Math.Pow(firstNumber, secondNumber));
                break;
            case 7:
                return (Math.Sqrt(firstNumber));
                break;
            default:
                return (Factorial(firstNumber));
                break;

        }
        return (0);

    }

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }
        if (number == 0 || number == 1)
        {
            return 1;
        }
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result; 
        

    }
}