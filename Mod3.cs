using System;

class Octopus
{
    string name;
    public int Age = 10;
    static readonly int legs = 8, eyes = 1;

    // Constructor to initialize the octopus name
    public Octopus(string octopusName)
    {
        name = octopusName;
    }

    // Method to display octopus details
    public void DisplayInfo()
    {
        Console.WriteLine($"Octopus Name: {name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Legs: {legs}");
        Console.WriteLine($"Eyes: {eyes}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Octopus class
        Octopus myOctopus = new Octopus("Inky");
        myOctopus.DisplayInfo();
    }
}
