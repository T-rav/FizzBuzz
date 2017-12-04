using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestCase(1, "1")]
        [TestCase(4, "4")]
        public void GetResult_WhenNumberNotDivisibleBy3or5_ShouldReturnNumber(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
 
        [TestCase(6)]
        [TestCase(9)]
        public void GetResult_WhenNumberDivisibleBy3_ShouldReturnFizz(int input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            var expected = "Fizz";
            Assert.AreEqual(expected, result);
        }

        [TestCase(10)]
        [TestCase(20)]
        public void GetResult_WhenNumberDivisibleBy5_ShouldReturnBuzz(int input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            var expected = "Buzz";
            Assert.AreEqual(expected, result);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(75)]
        public void GetResult_WhenNumberDivisibleBy3and5_ShouldReturnFizzBuzz(int input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }

    [TestCase(2)]
    [TestCase(7)]
    [TestCase(97)]
    public void GetResult_WhenNumberPrimeNot3or5_ShouldReturnWhiz(int input)
    {
        //---------------Set up test pack-------------------
        var fizzBuzzer = CreateFizzBuzzer();
        //---------------Execute Test ----------------------
        var result = fizzBuzzer.GetResult(input);
        //---------------Test Result -----------------------
        var expected = "Whiz";
        Assert.AreEqual(expected, result);
    }

        [Test]
        public void GetResult_WhenPrimeLarger100_ShouldReturnNumber()
        {
            //---------------Set up test pack-------------------
            var input = 101;
            var expected = "101";
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenNumber3_ShouldReturnFizzWhiz()
        {
            //---------------Set up test pack-------------------
            var input = 3;
            var expected = "FizzWhiz";
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenNumber5_ShouldReturnBuzzWhiz()
        {
            //---------------Set up test pack-------------------
            var input = 5;
            var expected = "BuzzWhiz";
            var fizzBuzzer = CreateFizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        [Ignore("Example Learning Test")]
        public void LearningTest_Goal_CalculatePrimes()
        {
            // arrange
            var canidateNumber = 2;
            var expected = true;
            // act
            var isPrime = Enumerable
                .Range(1, canidateNumber).Where(x => canidateNumber % x == 0)
                .SequenceEqual(new[] { 1, canidateNumber });

            // assert
            Assert.AreEqual(expected, isPrime);
        }

        private static FizzBuzzer CreateFizzBuzzer()
        {
            var fizzBuzzer = CreateFizzBuzzer();
            return fizzBuzzer;
        }

    }
}
