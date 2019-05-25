using Shouldly;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void WhenFizzBuzzIsPassedNonDivisibleNumberItReturnsThatNumber(int input)
        {
            FizzBuzz.Evaluate(input).ShouldBe(input.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void WhenFizzBuzzIsPassedAMultipleOfThreeItReturnsFizz(int input)
        {
            FizzBuzz.Evaluate(input).ShouldContain(FizzBuzz.Fizz);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void WhenFizzBuzzIsPassedAMultipleOfFiveItReturnsBuzz(int input)
        {
            FizzBuzz.Evaluate(input).ShouldContain(FizzBuzz.Buzz);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        public void WhenFizzBuzzIsPassedAMultipleOfThreeAndFiveItReturnsFizzBuzz(int input)
        {
            FizzBuzz.Evaluate(input).ShouldBe($"{FizzBuzz.Fizz}{FizzBuzz.Buzz}");
        }
    }
}