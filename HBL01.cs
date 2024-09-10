using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("   *");
        Console.WriteLine("  ***");
        Console.WriteLine(" *****");
        Console.WriteLine("*******");
        //
        Console.WriteLine("\"I have written my first computer program\" the pupil said to the teacher.");
        //
        Console.Write("Enter your favorite film: ");
        string film = Console.ReadLine();
        
        Console.Write("How many times have you seen it? ");
        string times = Console.ReadLine();
        
        Console.WriteLine($"Your favorite film is {film} and you have seen it {times} times.");
        //
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        string age = Console.ReadLine();
        
        Console.WriteLine(name + ", " + age);
        Console.WriteLine(name + ", " + age);
        Console.WriteLine(name + ", " + age);
        Console.WriteLine(name + ", " + age);
        Console.WriteLine(name + ", " + age);
        //
        string[] words = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter word {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        Array.Reverse(words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        //
        Console.Write("Enter the length: ");
        double length = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the height: ");
        double height = double.Parse(Console.ReadLine());
        
        double volume = length * width * height;
        
        Console.WriteLine($"Volume of the cuboid: {volume}");
        //
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"{number} x 1 = {number * 1}");
        Console.WriteLine($"{number} x 2 = {number * 2}");
        Console.WriteLine($"{number} x 3 = {number * 3}");
        Console.WriteLine($"{number} x 4 = {number * 4}");
        Console.WriteLine($"{number} x 5 = {number * 5}");
        //
        Console.Write("How many children are there? ");
        int children = int.Parse(Console.ReadLine());
        
        Console.Write("How many sweets do they each have? ");
        int sweetsPerChild = int.Parse(Console.ReadLine());
        
        Console.Write("How many ducks were there? ");
        int ducks = int.Parse(Console.ReadLine());
        
        Console.Write("How many sweets did each child give each duck? ");
        int sweetsPerDuck = int.Parse(Console.ReadLine());
        
        int sweetsLeft = (sweetsPerChild - 1) * children - sweetsPerDuck * ducks * children;
        
        Console.WriteLine($"There were {children} children each with a bag containing {sweetsPerChild} sweets. They walked past {ducks} ducks. Each child gave {sweetsPerDuck} sweets to each of the ducks and ate one themself. They decided to put the rest into a pile. They counted the pile and found it contained {sweetsLeft} sweets.");
        //
        Console.Write("Enter the radius of the cylinder: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        double height = double.Parse(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;
        double area = 2 * Math.PI * radius * (radius + height);

        Console.WriteLine($"Volume: {volume}");
        Console.WriteLine($"Surface Area: {area}");
        //
        double total = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter number {i}: ");
            total += double.Parse(Console.ReadLine());
        }

        double average = total / 5;
        Console.WriteLine($"Average: {average}");
        //
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        
        double c = Math.Sqrt(a * a + b * b);
        
        Console.WriteLine($"The hypotenuse is: {c:F2}");
    }
}
