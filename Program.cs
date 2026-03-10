Console.WriteLine(StatisticsHelper.IsOddOrEven(4));
Console.WriteLine(StatisticsHelper.IsOddOrEven(7));
public class StatisticsHelper
{
    public static string IsOddOrEven(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
    
    
}