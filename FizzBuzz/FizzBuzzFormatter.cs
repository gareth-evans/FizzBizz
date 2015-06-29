using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FizzBuzz
{
    public interface IFizzBuzzFormatter
    {
        string FormatFizzBuzzSequence(IEnumerable<object> fizzBuzzSequence);
    }

    public class FizzBuzzFormatter : IFizzBuzzFormatter
    {
        public string FormatFizzBuzzSequence(IEnumerable<object> fizzBuzzSequence)
        {
            var fizzBuzzArray = fizzBuzzSequence.ToArray();
            var fizzCount = fizzBuzzArray.Count(x => string.Equals(x, "fizz"));
            var buzzCount = fizzBuzzArray.Count(x => string.Equals(x, "buzz"));
            var fizzbuzzCount = fizzBuzzArray.Count(x => string.Equals(x, "fizzbuzz"));
            var luckyCount = fizzBuzzArray.Count(x => string.Equals(x, "lucky"));
            var integerCount = fizzBuzzArray.Count(x => x is int);

            var sb = new StringBuilder();
            sb.Append(string.Join(" ", fizzBuzzArray));
            sb.AppendFormat("fizz: {0}\r\n", fizzCount);
            sb.AppendFormat("buzz: {0}\r\n", buzzCount);
            sb.AppendFormat("fizzbuzz: {0}\r\n", fizzbuzzCount);
            sb.AppendFormat("lucky: {0}\r\n", luckyCount);
            sb.AppendFormat("integer: {0}", integerCount);

            return sb.ToString();
        }
    }
}