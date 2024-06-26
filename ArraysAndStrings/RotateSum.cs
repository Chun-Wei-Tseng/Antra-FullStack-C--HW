namespace ArraysAndStrings;

public class RotateSum
{
    public void Execute()
    {
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Enter the number of rotations:");
        int k = int.Parse(Console.ReadLine());
        int n = array.Length;
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            int[] rotatedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotatedArray[(i + r) % n] = array[i];
            }
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotatedArray[i];
            }
        }
        Console.WriteLine("Sum after rotations: " + string.Join(", ", sum));
    }
}