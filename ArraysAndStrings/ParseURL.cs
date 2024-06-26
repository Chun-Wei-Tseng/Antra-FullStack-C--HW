using System.Text.RegularExpressions;

namespace ArraysAndStrings;

public class ParseURL
{
    public void Execute()
    {
        string input1 = "https://www.apple.com/iphone";
        string input2 = "ftp://www.example.com/employee";
        string input3 = "https://google.com";
        string input4 = "www.apple.com";
        ParseU(input1);
        Console.WriteLine("---------------------------------------------------");
        ParseU(input2);
        Console.WriteLine("---------------------------------------------------");
        ParseU(input3);
        Console.WriteLine("---------------------------------------------------");
        ParseU(input4);
    }

    static void ParseU(string url)
    {
        string pattern = @"^(?<protocol>\w*:\/\/)?(?<server>[\w.-]+)(\/(?<resource>.*))?$";
        Match match = Regex.Match(url, pattern);
        if (match.Success)
        {
            string protocol = match.Groups["protocol"].Value;
            string server = match.Groups["server"].Value;
            string resource = match.Groups["resource"].Value;
            Console.WriteLine(url);
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
        else
        {
            Console.WriteLine("Invalid URL format");
        }
    }
}