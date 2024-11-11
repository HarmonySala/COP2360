using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Initialize dictionary
    static Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>();

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1: Populate the Dictionary");
            Console.WriteLine("2: Display Dictionary Contents");
            Console.WriteLine("3: Remove a Key");
            Console.WriteLine("4: Add a New Key and Value");
            Console.WriteLine("5: Add a Value to an Existing Key");
            Console.WriteLine("6: Sort the Keys");
            Console.WriteLine("7: Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PopulateDictionary();
                    break;
                case "2":
                    DisplayContents();
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
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // a. Populate the dictionary with initial values
    static void PopulateDictionary()
    {
        // Example: predefined key-value pairs
        myDictionary["apple"] = new List<int> { 1, 2 };
        myDictionary["banana"] = new List<int> { 3, 4 };
        myDictionary["cherry"] = new List<int> { 5 };
        Console.WriteLine("Dictionary populated with initial values.");
    }

    // b. Display dictionary contents
    static void DisplayContents()
    {
        Console.WriteLine("Displaying dictionary contents:");
        foreach (var entry in myDictionary)
        {
            Console.WriteLine($"{entry.Key}: [{string.Join(", ", entry.Value)}]");
        }
    }

    // c. Remove a specified key from the dictionary
    static void RemoveKey()
    {
        Console.Write("Enter the key to remove: ");
        string key = Console.ReadLine();
        if (myDictionary.Remove(key))
        {
            Console.WriteLine($"Key '{key}' removed.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    // d. Add a new key and value
    static void AddNewKeyValue()
    {
        Console.Write("Enter the new key: ");
        string key = Console.ReadLine();
        Console.Write("Enter the integer value: ");
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            myDictionary[key] = new List<int> { value };
            Console.WriteLine($"Added key '{key}' with value '{value}'.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer value.");
        }
    }

    // e. Add a value to an existing key
    static void AddValueToExistingKey()
    {
        Console.Write("Enter the key to add a value to: ");
        string key = Console.ReadLine();
        if (myDictionary.ContainsKey(key))
        {
            Console.Write("Enter the integer value to add: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                myDictionary[key].Add(value);
                Console.WriteLine($"Added value '{value}' to key '{key}'.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
            }
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    // f. Sort the keys in the dictionary
    static void SortKeys()
    {
        var sortedDict = myDictionary.OrderBy(entry => entry.Key).ToDictionary(entry => entry.Key, entry => entry.Value);
        Console.WriteLine("Sorted dictionary contents:");
        foreach (var entry in sortedDict)
        {
            Console.WriteLine($"{entry.Key}: [{string.Join(", ", entry.Value)}]");
        }
    }
}
