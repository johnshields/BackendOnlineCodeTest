namespace BackendOnlineCodeTest;

public static class Program
{
    public static void Main()
    {
        // basic input test for StringFormatter
        string[] items = ["item1", "item2", "item3"];
        var listLinq = StringFormatter.ToCommaSeparatedListLinq(items);
        var listOptimal = StringFormatter.ToCommaSeparatedListOptimal(items);
        
        Console.WriteLine($"LINQ: {listLinq}");
        Console.WriteLine($"Optimal: {listOptimal}");
    }
}
