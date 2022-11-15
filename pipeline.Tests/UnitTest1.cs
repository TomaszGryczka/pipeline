namespace pipeline.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("a", "a");
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(1 + 3, 4);
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(1 + 10, 11);
    }
}