namespace ArraysAndStrings;

public class ManageElements
{
    public void Execute()
    {
        List<string> list = new List<string>();
        string command;
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            command = Console.ReadLine();
            if (command.StartsWith("+"))
            {
                string item = command.Substring(2);
                list.Add(item);
            }
            else if (command.StartsWith("-"))
            {
                string item = command.Substring(2);
                list.Remove(item);
            }
            else if (command == "--")
            {
                list.Clear();
            }
            else if (command == "q")
            {
                break;
            }
            Console.WriteLine("Current list: " + string.Join(", ", list));
        }
    }
}