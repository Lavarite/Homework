using System;

public bool IsDivisible(int firstNumber, int secondNumber)
{
    // Check if the second number is zero to avoid division by zero
    if (secondNumber == 0)
    {
        return false;
    }

    // Check if the second number is exactly divisible by the first number
    if (secondNumber % firstNumber == 0)
    {
        return true;
    }
    
    return false;
}

public int DogYears(double actualYears)
{
    if (actualYears <= 2)
    {
        // If the dog's age is 2 or less, return 12 times the actual years
        return (int)(actualYears * 12);
    }
    else
    {
        // If the dog's age is more than 2, calculate the dog's age as:
        // 24 + 6 for every year above 2
        return (int)(24 + (actualYears - 2) * 6);
    }
}

public class ElectricCarCharging
{
    public (string totalCost, int pointsGained) CalculateChargingCost(int minutesCharged)
    {
        // Set the minimum charge time to 15 minutes
        int minimumChargeTime = 15;
        double costPerMinute = 0.20; // 20p per minute
        double sessionCharge = 1.00; // £1 per session
        double totalCost;
        int pointsGained;
        
        // Apply the minimum charge time if minutesCharged is less than 15
        if (minutesCharged < minimumChargeTime)
        {
            minutesCharged = minimumChargeTime;
        }

        // Calculate the total cost
        totalCost = sessionCharge + (minutesCharged * costPerMinute);

        // Calculate the points gained (1.5 points per minute, rounded down)
        pointsGained = (int)(minutesCharged * 1.5);

        // Return total cost formatted as currency and the points gained
        return ($"£{totalCost:F2}", pointsGained);
    }
}
