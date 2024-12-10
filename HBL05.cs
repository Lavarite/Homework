using System;

public class HBL
{
    // Energy Bill Calculator
    // This method calculates the raw cost of energy usage.
    // Parameters:
    // - previousReading: The previous meter reading.
    // - currentReading: The current meter reading.
    // - calorificValue: The calorific value of the energy source (default is 39.3).
    public static void CalculateRawCost(double previousReading, double currentReading, double calorificValue = 39.3)
    {
        double unitsUsed = currentReading - previousReading; // Units used
        double kWh = unitsUsed * 1.022 * calorificValue / 3.6; // Convert units to kWh
        double cost = kWh * 2.84 / 100; // Calculate cost in GBP (convert pence to pounds)
        Console.WriteLine($"Raw cost of energy usage: {cost} GBP");
    }

    // Circle Properties
    // This method calculates various properties of a circle.
    // Parameters:
    // - diameter: The diameter of the circle.
    // - arcAngle: The angle of the arc in degrees.
    public static void CalculateCircleProperties(double diameter, double arcAngle)
    {
        double radius = diameter / 2; // Radius of the circle
        double area = 3.14 * Math.Pow(radius, 2); // Area of the circle
        double circumference = 3.14 * diameter; // Circumference of the circle
        double arcLength = (circumference * arcAngle) / 360; // Arc length based on arc angle

        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Circumference: {circumference}");
        Console.WriteLine($"Arc Length: {arcLength}");
    }

    // Ball Pit Problem
    private const double PackingDensity = 0.75; // Packing density constant

    // This method calculates the volume of the ball pit.
    // Parameters:
    // - radius: The radius of the ball pit.
    // - height: The height of the ball pit.
    public static double CalculateBallPitVolume(double radius, double height)
    {
        return 3.14 * Math.Pow(radius, 2) * height; // Volume of a cylindrical pit
    }

    // This method calculates the volume of a single ball.
    // Parameters:
    // - radius: The radius of the ball.
    public static double CalculateBallVolume(double radius)
    {
        return (4.0 / 3.0) * 3.14 * Math.Pow(radius, 3); // Volume of a sphere
    }

    // This method calculates the number of balls required to fill the ball pit.
    // Parameters:
    // - pitRadius: The radius of the ball pit.
    // - pitHeight: The height of the ball pit.
    // - ballRadius: The radius of a single ball.
    public static void CalculateNumberOfBalls(double pitRadius, double pitHeight, double ballRadius)
    {
        double ballPitVolume = CalculateBallPitVolume(pitRadius, pitHeight); // Calculate ball pit volume
        double ballVolume = CalculateBallVolume(ballRadius); // Calculate ball volume
        double numberOfBalls = (ballPitVolume / ballVolume) * PackingDensity; // Calculate number of balls needed

        Console.WriteLine($"Number of balls required: {Math.Floor(numberOfBalls)}");
    }
  
    // Entry point to test all subroutines
    public static void Main(string[] args)
    {
        // Energy Bill Calculator Example
        Console.WriteLine("Energy Bill Calculator:");
        CalculateRawCost(1000, 1200);

        // Circle Properties Example
        Console.WriteLine("\nCircle Properties:");
        CalculateCircleProperties(10, 45);

        // Ball Pit Problem Example
        Console.WriteLine("\nBall Pit Problem:");
        CalculateNumberOfBalls(1, 0.2, 0.05);
    }
}
