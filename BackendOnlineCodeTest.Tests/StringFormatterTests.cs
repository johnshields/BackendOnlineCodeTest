using Xunit;

namespace BackendOnlineCodeTest.Tests;

public class StringFormatterTests
{
    // ToCommaSeparatedListLinq
    [Fact]
    public void ToCommaSeparatedListLinq_NullInput_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedListLinq(null);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListLinq_EmptyArray_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedListLinq([]);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListLinq_SingleItem_ReturnsQuotedItem()
    {
        var result = StringFormatter.ToCommaSeparatedListLinq(["item1"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\"", result);
    }

    [Fact]
    public void ToCommaSeparatedListLinq_MultipleItems_ReturnsCommaSeparatedQuotedItems()
    {
        var result = StringFormatter.ToCommaSeparatedListLinq(["item1", "item2", "item3"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\",\"item2\",\"item3\"", result);
    }

    // ToCommaSeparatedListOptimal
    [Fact]
    public void ToCommaSeparatedListOptimal_NullInput_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedListOptimal(null);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_EmptyArray_ReturnsEmptyString()
    {
        var result = StringFormatter.ToCommaSeparatedListOptimal([]);
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_SingleItem_ReturnsQuotedItem()
    {
        var result = StringFormatter.ToCommaSeparatedListOptimal(["item1"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\"", result);
    }

    [Fact]
    public void ToCommaSeparatedListOptimal_MultipleItems_ReturnsCommaSeparatedQuotedItems()
    {
        var result = StringFormatter.ToCommaSeparatedListOptimal(["item1", "item2", "item3"]);
        Assert.NotNull(result);
        Assert.Equal("\"item1\",\"item2\",\"item3\"", result);
    }
}