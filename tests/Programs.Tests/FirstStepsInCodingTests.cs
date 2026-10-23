namespace Programs.Tests;

public class FirstStepsInCodingTests
{
    // These exercises are still the "Hello, World!" template; replace the cases once they're solved.
    [Theory]
    [InlineData("001-Ex1")]
    [InlineData("001-Ex2")]
    [InlineData("001-Ex3")]
    [InlineData("001-Ex4")]
    [InlineData("001-Ex5")]
    [InlineData("001-Ex6")]
    [InlineData("001-Ex7")]
    [InlineData("001-Ex8")]
    [InlineData("001-Ex9")]
    [InlineData("002-Ex1")]
    [InlineData("002-Ex2")]
    [InlineData("002-Ex3")]
    [InlineData("002-Ex4")]
    [InlineData("002-Ex5")]
    [InlineData("002-Ex6")]
    [InlineData("002-Ex7")]
    [InlineData("002-Ex8")]
    [InlineData("002-Ex9")]
    public void Prints_hello_world(string program) =>
        Assert.Equal("Hello, World!\n", ProgramRunner.Run(program));
}
