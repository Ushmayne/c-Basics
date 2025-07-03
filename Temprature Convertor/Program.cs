//A simple temprature Convertor in C#

using System;




public class Program
{
    public static void Main(string[] args)
    {
        Weather temp = new Weather();
        Console.WriteLine("Welcome to the Temperature Converter!");
        while (DisplayMenu(temp) != 4);
    }

    public static int DisplayMenu(Weather temp)
    {
        temp.setTemperature();
        int choice;
        do
        {
            Console.WriteLine("Select the conversion you want to perform:");
            Console.WriteLine("1. Convert to Celsius");
            Console.WriteLine("2. Convert to Fahrenheit");
            Console.WriteLine("3. Convert to Kelvin");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
        } while (choice < 1 || choice > 4);

        switch (choice)
        {
            case 1:
                temp.temp(); ;
                break;
            case 2:
                temp.CF();
                temp.temp();
                break;
            case 3:
                temp.CK();
                temp.temp();
                break;
            default:
                Console.WriteLine("Exiting the program.");
                break;
        }

        return(choice);
       
    }
}