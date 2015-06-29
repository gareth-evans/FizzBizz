using System;
using System.IO;

namespace FizzBuzz
{
    public class FizzBuzzMediator
    {
        private readonly FizzBuzzSequenceGenerator _sequenceGenerator;
        private readonly FizzBuzzFormatter _formatter;
        private readonly TextWriter _textWriter;

        public FizzBuzzMediator(FizzBuzzSequenceGenerator sequenceGenerator, FizzBuzzFormatter formatter, TextWriter textWriter)
        {
            if (sequenceGenerator == null) throw new ArgumentNullException("sequenceGenerator");
            if (formatter == null) throw new ArgumentNullException("formatter");
            if (textWriter == null) throw new ArgumentNullException("textWriter");

            _sequenceGenerator = sequenceGenerator;
            _formatter = formatter;
            _textWriter = textWriter;
        }

        public void GenerateFizzBuzzSequence(int start, int count)
        {
            var sequence = _sequenceGenerator.GenerateFizzBuzzSequence(start, count);
            var formattedSequence = _formatter.FormatFizzBuzzSequence(sequence);

            _textWriter.WriteLine(formattedSequence);
        }
    }
}