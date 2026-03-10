Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    Console.WriteLine(StatisticsHelper.IsOddOrEven(number));
}
else
{
    Console.WriteLine("Error: please enter a valid number.");
}
public class StatisticsHelper{

    public static double CalculateAverage(int[] values)
    {
        int sum = 0;
        foreach (var v in values) sum += v;
        return (double)sum / values.Length;
    }
    
    public static int CalculateMin(int[] values)
    {
        int min = values[0];
        foreach (var v in values) if (v < min) min = v;
        return min;
    }
    
    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var v in values) if (v > max) max = v;
        return max;
    }
    
    public static string IsOddOrEven(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
    
    
}