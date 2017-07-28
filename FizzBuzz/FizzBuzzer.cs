namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetResult(int input)
        {
            if (InputIsDivisibleByFive(input))
            {
                return "Buzz";
            }

            if (InputIsDivisibleByThree(input))
            {
                return "Fizz";
            }

            return input.ToString();
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
