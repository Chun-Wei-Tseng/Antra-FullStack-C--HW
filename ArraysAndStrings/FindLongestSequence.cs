namespace ArraysAndStrings;

public class FindLongestSequence
{
    public void Execute()
    { 
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        FindLongest(array);
    }

    static void FindLongest(int[] arr)
    {
        int maxLength = 1;
        int currentLength = 1;
        int number = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    number = arr[i];
                }
            }
            else
            {
                currentLength = 1;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}