using System.Text;

namespace ArraysAndStrings;

public class ReverseWords
{
    public void Execute()
    {
        string input = "C# is not C++, and PHP is not Delphi!";
        ReverseW(input);
    }

    static void ReverseW(string s)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        List<string> words = new List<string>();
        List<string> allParts = new List<string>();
        int start = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (Array.Exists(separators, separator => separator == s[i]))
            {
                if (i > start)
                {
                    words.Add(s.Substring(start, i - start));
                    allParts.Add(s.Substring(start, i - start));
                }
                allParts.Add(s[i].ToString());
                start = i + 1;
            }
        }
        if (start < s.Length)
        {
            words.Add(s.Substring(start));
            allParts.Add(s.Substring(start));
        }
        words.Reverse();
        StringBuilder result = new StringBuilder();
        int wordIndex = 0;
        foreach (string part in allParts)
        {
            if (Array.Exists(separators, separator => separator.ToString() == part))
            {
                result.Append(part);
            }
            else
            {
                result.Append(words[wordIndex]);
                wordIndex++;
            }
        }
        Console.WriteLine("Input sentence:");
        Console.WriteLine(s);
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(result.ToString());
    }
}