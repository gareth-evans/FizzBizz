using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GenerateFizzBuzzString(int start, int count)
        {
            var sb = new StringBuilder();

            for (var i = start; i <= count; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.Append("fizzbuzz ");
                    continue;
                }

                if (i % 3 == 0)
                {
                    sb.Append("fizz ");
                    continue;
                }

                if (i % 5 == 0)
                {
                    sb.Append("buzz ");
                    continue;
                }

                sb.Append(i);
                sb.Append(" ");
            }

            return sb.ToString().Trim();
        }
    }
}