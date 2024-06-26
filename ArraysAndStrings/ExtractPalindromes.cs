using System.Text.RegularExpressions;

namespace ArraysAndStrings;

public class ExtractPalindromes
{
    public void Execute()
    {
        string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
        ExtractP(input);
    }

    static void ExtractP(string s)
    {
        string[] words = Regex.Split(s, @"\W+");
        HashSet<string> palindromes = new HashSet<string>();
        foreach (string word in words)
        {
            if (IsPalindrome(word) && word.Length >= 1)
            {
                palindromes.Add(word);
            }
        }
        var sortedPalindromes = palindromes.OrderBy(p => p).ToList();
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }
    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}