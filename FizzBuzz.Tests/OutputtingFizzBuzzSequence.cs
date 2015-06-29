using System.IO;
using AutoMoq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class OutputtingFizzBuzzSequence
    {
        [Test]
        public void ShouldWriteSequence()
        {
            const string sequenceString = "SomeString";
            var sequence = new object[] {1, 2, 3};

            var mocker = new AutoMoqer();
            var sut = mocker.Create<FizzBuzzMediator>();

            mocker.GetMock<IFizzBuzzSequenceGenerator>()
                .Setup(x => x.GenerateFizzBuzzSequence(1, 3))
                .Returns(sequence);

            mocker.GetMock<IFizzBuzzFormatter>()
                .Setup(x => x.FormatFizzBuzzSequence(sequence))
                .Returns(sequenceString);

            sut.GenerateFizzBuzzSequence(1,3);

            mocker.GetMock<TextWriter>()
                  .Verify(x => x.WriteLine(sequenceString));
        }
    }
}