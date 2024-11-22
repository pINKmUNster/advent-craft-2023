namespace Day02
{
    public static class FizzBuzz
    {
        private const int Max = 100;
        private const int Min = 0;
        private const int Fizz = 3;
        private const int Buzz = 5;

        public static string Convert(int input)
        {
            if (IsOutOfRange(input)) throw new OutOfRangeException();

            return ToFizzBuzz(input);
        }

        private static bool IsOutOfRange(int input) => LessOrEqualThanMin(input) || GreaterThanMax(input);

        private static string ToFizzBuzz(int input)
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

        private static bool GreaterThanMax(int input) => input > Max;

        private static bool LessOrEqualThanMin(int input) => input <= Min;

        private static bool IsFizz(int input) => Is(input, Fizz);

        private static bool IsBuzz(int input) => Is(input, Buzz);

        private static bool Is(int input, int divisor) => input % divisor == 0;
    }
}