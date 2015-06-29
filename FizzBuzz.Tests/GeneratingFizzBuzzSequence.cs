using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class GeneratingFizzBuzzSequence
    {
        [TestCase(20, new object[] {1, 2, "lucky", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", "lucky", 14, "fizzbuzz", 16, 17, "fizz", 19, "buzz"})]
        public void GenerateCorrectFuzzBizzString(int count, object[] expectedSequence)
        {
            var sut = new FizzBuzzSequenceGenerator();
            var result = sut.GenerateFizzBuzzSequence(1, count);

            Assert.That(result, Is.EquivalentTo(expectedSequence));
        }
    }
}
