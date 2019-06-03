using System.Text;

namespace FizzBuzzKata
{
    /// <summary>
    /// A simple FizzBuzz implementation.
    /// </summary>
    public static class FizzBuzz
    {
        /// <summary>
        /// Evaluates <param name="inputNumber"></param> and returns 'fizz' when it is evenly divisible by 3, 'buzz' when
        /// it is evenly divisible by 5, 'fizzbuzz' when divisible by both 3 and 5, and the input number when not
        /// divisible by 3 or 5.
        /// </summary>
        /// <param name="inputNumber">The number to evaluate</param>
        /// <returns>fizz, buzz, fizzbuzz, or the string representation of the number, dependent on the value of <paramref name="inputNumber"/></returns>
        public static string Evaluate(int inputNumber)
        {
            // Note: Using string append instead of StringBuilder since not many append calls will occur

            // Check if divisible by 3
            var output = inputNumber % 3 == 0 ? Fizz : string.Empty;

            // Check if divisible by 5
            if (inputNumber % 5 == 0)
            {
                output += Buzz;
            }

            // Return the special string or the original input
            return string.IsNullOrEmpty(output)
                ? inputNumber.ToString()
                : output;
        }

        /// <summary>
        /// Returns the string used for Fizz cases in FizzBuzz evaluation
        /// </summary>
        public static string Fizz => "fizz";

        /// <summary>
        /// Returns the string used for Buzz cases in FizzBuzz evaluation
        /// </summary>
        public static string Buzz => "buzz";
    }
}