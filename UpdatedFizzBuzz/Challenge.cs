using System.Collections.Generic;

namespace UpdatedFizzBuzz
{
    public static class Challenge
    {
        public static string FizzBuzz(int n)
        {
            if (n < 1) return "";

            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return string.Join("\n", result);
        }
    }
}
