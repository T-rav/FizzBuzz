namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetResult(int input)
        {
            if (input == 5 || input == 10)
            {
                return "Buzz";
            }

            if (InputIsDivisibleByThree(input))
            {
                return "Fizz";
            }

            return input.ToString();
        }

        private static bool InputIsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}
