using Xunit;

namespace BackendOnlineCodeTest.Tests;

public class StringFormatterTests
{
    [Fact]
    public void ToCommaSeparatedListOptimal_NullInput_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedList(null);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_EmptyArray_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedList([]);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_SingleItem_ReturnsQuotedItem()
    {
        var result = StringFormatter.ToCommaSeparatedList(["item1"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\"", result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_MultipleItems_ReturnsCommaSeparatedQuotedItems()
    {
        var result = StringFormatter.ToCommaSeparatedList(["item1", "item2", "item3"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\",\"item2\",\"item3\"", result);
    }
}