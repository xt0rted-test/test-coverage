namespace TestProject1;

using ClassLibrary1;

using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var obj = new Class1();

        Assert.Equal("$13.26", obj.GetValue());
    }
}
