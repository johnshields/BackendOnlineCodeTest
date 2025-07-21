namespace BackendOnlineCodeTest;

public static class Program
{
    public static void Main()
    {
        // basic input test for StringFormatter
        string[] items = ["item1", "item2", "item3"];
        var itemList = StringFormatter.ToCommaSeparatedList(items);
        
        Console.WriteLine(itemList);
    }
}
