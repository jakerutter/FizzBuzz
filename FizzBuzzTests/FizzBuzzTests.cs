using Xunit;

namespace FizzBuzzKata
{
  public class FizzBuzzTests
  {

    FizzBuzz fizzBuzz = new FizzBuzz();

    [Fact]
    public void whenFizzBuzzIsPassedANumberItReturnsThatNumber()
    {
      Assert.Equal("1", fizzBuzz.Fizz(1));
    }

    [Fact]
    public void whenFizzBuzzIsPassedTwoItReturnsTwo()
    {
      Assert.Equal("2", fizzBuzz.Fizz(2));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfThreeItReturnsFizz()
    {
      Assert.Equal("fizz", fizzBuzz.Fizz(3));
      Assert.Equal("fizz", fizzBuzz.Fizz(6));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfFiveItReturnsBuzz()
    {
      Assert.Equal("buzz", fizzBuzz.Fizz(5));
      Assert.Equal("buzz", fizzBuzz.Fizz(10));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfThreeAndFiveItReturnsFizzBuzz()
    {
      Assert.Equal("fizzBuzz", fizzBuzz.Fizz(15));
      Assert.Equal("fizzBuzz", fizzBuzz.Fizz(45));
    }
  }
}