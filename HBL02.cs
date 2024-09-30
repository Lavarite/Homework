using System;

class Program
{
    static void Main()
    {
        int mark = 59; 
        var result = GetGrade(mark);
        Console.WriteLine($"A mark of {mark} is grade {result.grade}. You needed {result.marksToNextGrade} more marks for the next grade.");
    }

    static (int grade, int marksToNextGrade) GetGrade(int mark)
    {
        int[] marks = { 0, 2, 4, 13, 22, 31, 41, 54, 67, 80 };
        int[] grades = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 1; i < marks.Length; i++)
        {
            if (mark < marks[i])
            {
                return (grades[i - 1], marks[i] - mark);
            }
        }
        return (9, 0);  // Max grade
    }
}
//
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Li";
        var element = GetElementInfo(input);
        if (element != null)
        {
            Console.WriteLine($"Element: {element.Name}\nAtomic Weight: {element.AtomicWeight}\nGroup: {element.Group}");
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    static Element GetElementInfo(string input)
    {
        var periodicTable = new List<Element>
        {
            new Element("Hydrogen", "H", 1.008, "Non-metals"),
            new Element("Helium", "He", 4.0026, "Noble gases"),
            new Element("Lithium", "Li", 6.94, "Alkali metals"),
            new Element("Beryllium", "Be", 9.0122, "Alkaline earth metals"),
            new Element("Carbon", "C", 12.011, "Non-metals"),
            new Element("Oxygen", "O", 15.999, "Non-metals")
        };

        foreach (var element in periodicTable)
        {
            if (element.Name.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                element.Symbol.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                element.Group.Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                return element;
            }
        }
        return null;
    }
}

class Element
{
    public string Name { get; }
    public string Symbol { get; }
    public double AtomicWeight { get; }
    public string Group { get; }

    public Element(string name, string symbol, double atomicWeight, string group)
    {
        Name = name;
        Symbol = symbol;
        AtomicWeight = atomicWeight;
        Group = group;
    }
}
//
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(DayFormat(2, "day"));  // Example usage
    }

    static string DayFormat(int day, string format)
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] shortdays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        string[] chardays = { "M", "Tu", "W", "Th", "F", "Sa", "Su" };

        if (day < 1 || day > 7) return "Invalid day";

        switch (format)
        {
          case "day":
            return days[day - 1];
          case "shortday":
            return shortdays[day - 1];
          case "char":
            return chardays[day - 1];
          default:
            return "Invalid format";
        }
    }
}
