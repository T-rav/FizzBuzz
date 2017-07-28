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
            Assert.AreEqual(expected,result);
        }
    }

    public class FizzBuzzer
    {
        public string GetResult(int input)
        {
            return "1";
        }
    }
}
