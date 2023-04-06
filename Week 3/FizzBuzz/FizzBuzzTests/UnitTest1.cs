using FizzBuzzApp;
namespace FizzBuzzTests
{
    public class FizzBuzzDoes
    {

        [Test]
        public void FizzBuzz_ReturnsNothing_GivenZero()
        {
            Assert.That(Program.FizzBuzz(0), Is.EqualTo(""));
        }

        [Test]
        public void FizzBuzz_ReturnsOne_GivenOne()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void FizzBuzz_ReturnsOneTwo_GivenTwo()
        {
            Assert.That(Program.FizzBuzz(2), Is.EqualTo("1 2"));
        }

        [Test]
        [Ignore("No longer relevant test")]
        public void FizzBuzz_ReturnsOneTwoThree_GivenOneTwoThree()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 3"));
        }

        [Test]
        public void FizzBuzz_ReturnsOneTwoFizz_GivenThree()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 Fizz"));
        }

        [Test]
        public void FizzBuzz_ReturnsOneTwoFizzFourBuzz_GivenFive()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("1 2 Fizz 4 Buzz"));
        }
    }
}