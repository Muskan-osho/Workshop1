using System;

class Task4
{
    static void Main()
    {
        // 1. Create 1D integer array
        int[] numbers = { 42, 15, 8, 23, 4 };

        // 2. Sort array ascending
        Array.Sort(numbers);

        // 3. Reverse sorted array
        Array.Reverse(numbers);

        // 4. Print elements using a for loop
        Console.WriteLine("Array elements after sorting and reversing:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}: {numbers[i]}");
        }

        // 5. Array.IndexOf()
        int searchNumber = 15;
        int position = Array.IndexOf(numbers, searchNumber);
        Console.WriteLine($"\nPosition of number {searchNumber}: Index {position}");
    }
}