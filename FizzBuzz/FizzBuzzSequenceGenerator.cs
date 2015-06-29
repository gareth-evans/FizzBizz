using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IFizzBuzzSequenceGenerator
    {
        IEnumerable<object> GenerateFizzBuzzSequence(int start, int count);
    }

    public class FizzBuzzSequenceGenerator : IFizzBuzzSequenceGenerator
    {
        public IEnumerable<object> GenerateFizzBuzzSequence(int start, int count)
        {
            for (var i = start; i <= count; i++)
            {
                if (i.ToString().Contains("3"))
                {
                    yield return "lucky";
                    continue;
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return ("fizzbuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    yield return "fizz";
                    continue;
                }

                if (i % 5 == 0)
                {
                    yield return "buzz";
                    continue;
                }

                yield return i;
            }
        }
    }
}