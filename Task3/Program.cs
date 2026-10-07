using System;

class Task3
{
    static void Main()
    {
        // 1. Declare and initialize variables
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 123456789L;
        float myFloat = 5.75f;
        double myDouble = 19.99;
        decimal myDecimal = 99.99m;
        char myChar = 'A';
        bool myBool = true;

        // 2. Convert integer to string
        string intToString = myInt.ToString();

        // 3. Convert string to double
        string strDouble = "3.14";
        double stringToDouble = Convert.ToDouble(strDouble);

        // 4. Print all variables with labels
        Console.WriteLine($"[byte] myByte: {myByte}");
        Console.WriteLine($"[short] myShort: {myShort}");
        Console.WriteLine($"[int] myInt: {myInt}");
        Console.WriteLine($"[long] myLong: {myLong}");
        Console.WriteLine($"[float] myFloat: {myFloat}");
        Console.WriteLine($"[double] myDouble: {myDouble}");
        Console.WriteLine($"[decimal] myDecimal: {myDecimal}");
        Console.WriteLine($"[char] myChar: {myChar}");
        Console.WriteLine($"[bool] myBool: {myBool}");
        Console.WriteLine($"[string] Converted intToString: {intToString}");
        Console.WriteLine($"[double] Converted stringToDouble: {stringToDouble}");
    }
}