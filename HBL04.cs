using System;

class Program
{
    // Draw the isosceles triangle (top of the tree)
    static void Triangle()
    {
        for (int i = 1; i <= 5; i++) // 5 rows for the triangle
        {
            int spaces = 5 - i; // Calculate leading spaces
            Console.Write(new string(' ', spaces)); // Print leading spaces
            Console.WriteLine(new string('X', i * 2)); // Print X's
        }
    }

    // Draw the rectangular base (trunk of the tree)
    static void Base(int size)
    {
        for (int i = 0; i < size; i++) // Print `size` lines
        {
            Console.Write(new string(' ', 7)); // Print leading spaces
            Console.WriteLine(new string('#', 4)); // Print trunk width
        }
    }

    // Draw the body segments of the tree
    static void Body(int segmentvs)
    {
        for (int s = 0; s < segments; s++) // Loop through each segment
        {
            for (int i = 0; i < 4; i++) // Each segment has 4 lines
            {
                int spaces = 6 - i; // Leading spaces decrease each line
                Console.Write(new string(' ', spaces)); // Print leading spaces
                Console.WriteLine(new string('X', 12 + i * 2)); // Print X's
            }
        }
    }

    // Combine the tree by calling subroutines
    static void Tree(int height, int baseHeight)
    {
        Triangle(); // Draw the triangle at the top
        Body(height); // Draw the body with `height` segments
        Base(baseHeight); // Draw the trunk with `baseHeight` lines
    }

    static void Main(string[] args)
    {
        // Ask user for inputs
        Console.WriteLine("Please enter the number of segments in your tree:");
        int segments = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the height of the trunk of your tree:");
        int baseHeight = int.Parse(Console.ReadLine());

        // Draw the tree
        Tree(segments, baseHeight);
    }
}

using System;

class Program
{
    // Function to print a string backwards
    static void Backwards(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    // Function to convert a decimal number to an 8-bit binary string
    static string DecToBin(int number)
    {
        string binary = Convert.ToString(number, 2).PadLeft(8, '0'); // Convert to binary and pad to 8 bits
        return binary;
    }

    // Function to convert a decimal number to a hexadecimal string
    static string DecToHex(int number)
    {
        return Convert.ToString(number, 16).ToUpper(); // Convert to hexadecimal and make it uppercase
    }

    static void Main(string[] args)
    {
        // Test the Backwards function
        Console.WriteLine("Testing Backwards Function:");
        Console.Write("Hello backwards is: ");
        Backwards("Hello");

        Console.Write("Computing backwards is: ");
        Backwards("Computing");

        Console.Write("Program backwards is: ");
        Backwards("Program");

        // Test the DecToBin function
        Console.WriteLine("\nTesting DecToBin Function:");
        Console.WriteLine("8 in binary is: " + DecToBin(8));
        Console.WriteLine("255 in binary is: " + DecToBin(255));
        Console.WriteLine("1 in binary is: " + DecToBin(1));

        // Test the DecToHex function
        Console.WriteLine("\nTesting DecToHex Function:");
        Console.WriteLine("255 in hexadecimal is: " + DecToHex(255));
        Console.WriteLine("16 in hexadecimal is: " + DecToHex(16));
        Console.WriteLine("42 in hexadecimal is: " + DecToHex(42));
    }
}

