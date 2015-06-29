using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class GeneratingFizzBuzzString
    {
        [TestCase(20, "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz")]
        public void GenerateCorrectFuzzBizzString(int count, string expectedString)
        {
            var sut = new FizzBuzzer();
            var result = sut.GenerateFizzBuzzString(1, count);

            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
