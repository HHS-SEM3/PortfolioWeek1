using Xunit;

namespace Week1.Tests;

public class HelloWorldTests
{
    [Fact]
    [Trait("TestGroup", "HelloWorld")]
    public void Message_Is_HelloWorld()
    {
        Assert.Equal("Hello, World!", HelloWorld.Message);
    }
}