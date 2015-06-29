using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FormattingFizzBuzzSequence
    {
        [Test]
        public void ShouldProduceSpaceDelimeteredList()
        {
            const string expectedResult = "1 2 lucky";
            var sequence = new object[] {1, 2, "lucky"};
            var sut = new FizzBuzzFormatter();

            var result = sut.FormatFizzBuzzSequence(sequence);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}