namespace Day02
{
    public static class FizzBuzz
    {
        public static string Convert(int input)
        {
            if (input > 0)
            {
                if (input <= 100)
                {
                    if (IsFizz(input) && IsBuzz(input))
                    {
                        return "FizzBuzz";
                    }

                    if (IsFizz(input))
                    {
                        return "Fizz";
                    }

                    if (IsBuzz(input))
                    {
                        return "Buzz";
                    }

                    return input.ToString();
                }
                else
                {
                    throw new OutOfRangeException();
                }
            }
            else
            {
                throw new OutOfRangeException();
            }
        }

        private static bool IsFizz(int input) => input % 3 == 0;

        private static bool IsBuzz(int input) => input % 5 == 0;
    }
}