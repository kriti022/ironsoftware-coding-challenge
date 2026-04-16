using Xunit;

public class OldPhonePadTests
{
    private readonly OldPhonePadDecoder _decoder = new();

    [Fact]
    public void BasicInput_ShouldReturnCorrectLetter()
    {
        Assert.Equal("E", _decoder.Decode("33#"));
    }

    [Fact]
    public void ShouldHandleBackspace()
    {
        Assert.Equal("B", _decoder.Decode("227*#"));
    }

    [Fact]
    public void ShouldHandleWord()
    {
        Assert.Equal("HELLO", _decoder.Decode("4433555 555666#"));
    }

    [Fact]
    public void ShouldHandlePauseBetweenSameDigits()
    {
        Assert.Equal("CA", _decoder.Decode("222 2#"));
    }

    [Fact]
    public void ShouldHandleMultipleBackspaces()
    {
        Assert.Equal("", _decoder.Decode("22**#"));
    }

    [Fact]
    public void ShouldWrapAroundLetters()
    {
        Assert.Equal("Z", _decoder.Decode("9999#"));
    }

    [Fact]
    public void EmptyInput_ShouldReturnEmpty()
    {
        Assert.Equal("", _decoder.Decode("#"));
    }
}
