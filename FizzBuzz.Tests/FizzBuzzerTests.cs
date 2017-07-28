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
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(1);
            //---------------Test Result -----------------------
            Assert.AreEqual("1",result);
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
