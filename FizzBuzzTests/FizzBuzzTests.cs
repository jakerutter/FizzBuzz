using Xunit;

namespace FizzBuzzKata
{
  public class FizzBuzzTests
  {
    [Fact]
    public void whenFizzBuzzIsPassedANumberItReturnsThatNumber()
    {
      FizzBuzz fizzBuzz = new FizzBuzz();
      Assert.Equal("1", fizzBuzz.Fizz(1));
    }

    [Fact]
    public void whenFizzBuzzIsPassedTwoItReturnsTwo()
    {
      FizzBuzz fizzBuzz = new FizzBuzz();
      Assert.Equal("2", fizzBuzz.Fizz(2));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfThreeItReturnsFizz()
    {
      FizzBuzz fizzBuzz = new FizzBuzz();
      Assert.Equal("fizz", fizzBuzz.Fizz(3));
      Assert.Equal("fizz", fizzBuzz.Fizz(6));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfFiveItReturnsBuzz()
    {
      FizzBuzz fizzBuzz = new FizzBuzz();
      Assert.Equal("buzz", fizzBuzz.Fizz(5));
      Assert.Equal("buzz", fizzBuzz.Fizz(10));
    }

    [Fact]
    public void whenFizzBuzzIsPassedAMultipleOfThreeAndFiveItReturnsFizzBuzz()
    {
      FizzBuzz fizzBuzz = new FizzBuzz();
      Assert.Equal("fizzBuzz", fizzBuzz.Fizz(15));
      Assert.Equal("fizzBuzz", fizzBuzz.Fizz(45));
    }
  }
}