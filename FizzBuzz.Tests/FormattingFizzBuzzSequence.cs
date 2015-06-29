using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FormattingFizzBuzzSequence
    {
        [Test]
        public void ShouldGenerateSummaryReportForFizzBuzz()
        {
            var sequence = new object[]
            {
                1, 2, "lucky", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", "lucky", 14, "fizzbuzz", 16, 17, "fizz", 19, "buzz"
            };

            var expected = new StringBuilder("1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz")
                .AppendLine("fizz: 4")
                .AppendLine("buzz: 3")
                .AppendLine("fizzbuzz: 1")
                .AppendLine("lucky: 2")
                .Append("integer: 10")
                .ToString();

            var sut = new FizzBuzzFormatter();

            var result = sut.FormatFizzBuzzSequence(sequence);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}