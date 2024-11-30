class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = Math.CalculateAverage(numbers);

        Console.WriteLine($"Średnia wynosi: {average}");
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

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}
