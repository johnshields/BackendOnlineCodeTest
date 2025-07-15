namespace BackendOnlineCodeTest;

public static class Program
{
    public static void Main()
    {
        string[] items = ["item1", "item2", "item3"];
        var results = StringFormatter.ToCommaSeparatedList(items, "\"");
        Console.WriteLine(results);
    }
}
