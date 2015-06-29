using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();;
            var result = fizzBuzzer.GenerateFizzBuzzString(1, 20);

            Console.WriteLine(result);
        }
    }
}
