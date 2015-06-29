using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzMediator(new FizzBuzzSequenceGenerator(), new FizzBuzzFormatter(), Console.Out);
            fizzBuzzer.GenerateFizzBuzzSequence(1, 20);
        }
    }
}
