using System;



public class Weather
{
    private double temperature;//holds the temprature value
    private String unit;//holds the unit of temprature it is in
    public Weather()
    {
        temperature = 0.0;
        unit = "C";

    }
    public void setTemperature()
    {
        Console.WriteLine("Enter the temprature value:");
        this.temperature = Convert.ToDouble(Console.ReadLine());
        do
        {
            Console.WriteLine("Enter the unit of temprature (C/F/K):");
            this.unit = Console.ReadLine().ToUpper();
        } while (this.unit != "C" && this.unit != "F" && this.unit != "K");
        this.temp();
        if (this.unit == "F")
        {
            this.FC();
            this.unit = "C";
        }
        else if (this.unit == "K")
        {
            this.KC();
            this.unit = "C";
        }
    }


    public void FC()
    {
        this.temperature = (this.temperature - 32) * 5 / 9;
    }
    public void KC()
    {
        this.temperature = this.temperature - 273.15;
    }

    public void CF()
    {
        this.temperature = (this.temperature * 9 / 5) + 32;
    }
    public void CK()
    {
        this.temperature = this.temperature + 273.15;
    }

    public void temp()
    {
        Console.WriteLine("The temprature is " + this.temperature + " °" + this.unit);
    }



}
