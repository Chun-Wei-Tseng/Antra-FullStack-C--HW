namespace ArraysAndStrings;

public class CopyingAnArray
{
    public void Execute()
    {
        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] copiedArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }
        Console.WriteLine("Original array: " + string.Join(", ", originalArray));
        Console.WriteLine("Copied array: " + string.Join(", ", copiedArray));
    }
}