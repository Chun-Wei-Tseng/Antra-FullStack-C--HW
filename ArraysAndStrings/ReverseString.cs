namespace ArraysAndStrings;

public class ReverseString
{
    public void ExecuteMethodOne()
    {
        Console.Write("Reversed string (Method 1): ");
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString1 = new string(charArray);
        Console.WriteLine("Reversed string (Method 1): " + reversedString1);
    }

    public void ExecuteMethodTwo()
    {
        Console.Write("Reversed string (Method 2): ");
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}