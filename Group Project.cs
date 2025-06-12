using System;
using System.Collections.Generic;
using System.Linq;

class DictionaryManager
{
    static Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n==== Dictionary Menu ====");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add New Key and Value");
            Console.WriteLine("5. Add Value to Existing Key");
            Console.WriteLine("6. Sort Keys");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PopulateDictionary();
                    break;
                case "2":
                    DisplayDictionary();
                    break;
                case "3":
                    RemoveKey();
                    break;
                case "4":
                    AddNewKeyValue();
                    break;
                case "5":
                    AddValueToExistingKey();
                    break;
                case "6":
                    SortKeys();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void PopulateDictionary()
    {
        myDictionary.Clear();
        myDictionary["Apple"] = new List<string> { "Fruit", "Red" };
        myDictionary["Car"] = new List<string> { "Vehicle", "Fast" };
        myDictionary["Dog"] = new List<string> { "Animal", "Friendly" };
        Console.WriteLine("Dictionary populated with default values.");
    }

    static void DisplayDictionary()
    {
        Console.WriteLine("\n--- Dictionary Contents ---");
        foreach (var pair in myDictionary)
        {
            Console.WriteLine($"Key: {pair.Key} | Values: {string.Join(", ", pair.Value)}");
        }
    }

    static void RemoveKey()
    {
        Console.Write("Enter the key to remove: ");
        string key = Console.ReadLine();

        if (myDictionary.Remove(key))
        {
            Console.WriteLine("Key removed successfully.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    static void AddNewKeyValue()
    {
        Console.Write("Enter a new key: ");
        string key = Console.ReadLine();

        Console.Write("Enter a value for the key: ");
        string value = Console.ReadLine();

        if (!myDictionary.ContainsKey(key))
        {
            myDictionary[key] = new List<string> { value };
            Console.WriteLine("Key-value pair added.");
        }
        else
        {
            Console.WriteLine("Key already exists. Use option 5 to add a value to an existing key.");
        }
    }

    static void AddValueToExistingKey()
    {
        Console.Write("Enter the existing key: ");
        string key = Console.ReadLine();

        if (myDictionary.ContainsKey(key))
        {
            Console.Write("Enter a new value to add: ");
            string value = Console.ReadLine();
            myDictionary[key].Add(value);
            Console.WriteLine("Value added to existing key.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    static void SortKeys()
    {
        Console.WriteLine("\n--- Sorted Dictionary Keys ---");
        var sortedKeys = myDictionary.Keys.OrderBy(k => k).ToList();
        foreach (string key in sortedKeys)
        {
            Console.WriteLine($"Key: {key} | Values: {string.Join(", ", myDictionary[key])}");
        }
    }
}
