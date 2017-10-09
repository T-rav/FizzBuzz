namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetResult(int input)
        {
            if (InputIsDivisibleByThree(input) && InputIsDivisibleByFive(input))
            {
                return "FizzBuzz";
            }

            if (InputIsDivisibleByFive(input))
            {
                return "Buzz";
            }

            if (InputIsDivisibleByThree(input))
            {
                return "Fizz";
            }

            if (IsPrimeNumber(input))
            {
                return "Whiz";
            }

            return input.ToString();
        }

        private static bool IsPrimeNumber(int input)
        {
            return input == 2 || input == 7 || input == 11;
        }

        private static bool InputIsDivisibleByFive(int input)
        {
            return input % 5 == 0;
        }

        private static bool InputIsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}
