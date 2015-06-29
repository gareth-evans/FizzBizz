using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzFormatter
    {
        public string FormatFizzBuzzSequence(IEnumerable<object> fizzBuzzSequence)
        {
            return string.Join(" ", fizzBuzzSequence);
        }
    }
}