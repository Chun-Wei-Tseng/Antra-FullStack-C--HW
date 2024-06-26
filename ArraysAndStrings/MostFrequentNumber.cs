namespace ArraysAndStrings;

public class MostFrequentNumber
{
    public void Execute()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        MostFrequent(array);
    }

    static void MostFrequent(int[] arr)
    {
        var frequency = arr.GroupBy(x => x).OrderByDescending(g => g.Count()).ThenBy(g => Array.IndexOf(arr, g.Key)).First();
        Console.WriteLine($"The number {frequency.Key} is the most frequent (occurs {frequency.Count()} times).");
    }
}