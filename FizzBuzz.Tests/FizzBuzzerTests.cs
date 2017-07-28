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

        [Test]
        public void GetResult_WhenInputSix_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 6;
            var expected = "Fizz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputNine_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 9;
            var expected = "Fizz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputFive_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 5;
            var expected = "Buzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputTen_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 10;
            var expected = "Buzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputTwenty_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 20;
            var expected = "Buzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputFifteen_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 15;
            var expected = "FizzBuzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputThirty_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 30;
            var expected = "FizzBuzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenInputSeventyFive_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 75;
            var expected = "FizzBuzz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
