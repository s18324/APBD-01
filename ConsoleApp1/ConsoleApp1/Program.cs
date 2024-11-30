class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = Math.CalculateAverage(numbers);

        Console.WriteLine($"Średnia wynosi: {average}");
        
        int maxValue = Math.FindMaxValue(numbers);
        Console.WriteLine($"Maksymalna wartość wynosi: {maxValue}");
    }
}

public class Math
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int s = 0;
        foreach (int number in numbers)
        {
            s += number;
        }

        return (double)s / numbers.Length;
    }
    
    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }
}
