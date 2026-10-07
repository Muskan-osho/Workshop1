using System;
using System.Collections.Generic;

class Task6
{
    static void Main()
    {
        // --- PART 1: List<string> ---
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("--- Fruits List ---");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine();

        // --- PART 2: Dictionary<int, string> ---
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Mango" }
        };
        fruitDictionary.Add(4, "Grapes");

        Console.WriteLine("--- Fruit Dictionary ---");
        foreach (KeyValuePair<int, string> kvp in fruitDictionary)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}