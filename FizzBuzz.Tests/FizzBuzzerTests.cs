using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void GetResult_WhenInputOne_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var input = 1;
            var expected = "1";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputTwo_ShouldReturnTwo()
        {
            //---------------Set up test pack-------------------
            var input = 2;
            var expected = "2";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputFour_ShouldReturnFour()
        {
            //---------------Set up test pack-------------------
            var input = 4;
            var expected = "4";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputThree_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 3;
            var expected = "Fizz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        public class FizzBuzzer
        {
            public string GetResult(int input)
            {
                if (input == 3)
                {
                    return "Fizz";
                }

                return input.ToString();
            }
        }
    }
}
