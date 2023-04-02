using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("totalDays must not be negative"));

        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 1, 1, 1)]
        [TestCase(2, 4, 8, 1.41)]
        [TestCase(3, 9, 27, 1.73)]
        

        public void PowersRoot_ReturnsCorrectValues(int input, int expSquare, int expCube, double expRoot)
        {
            var answer = Methods.PowersRoot(input);
            Assert.That(answer.square, Is.EqualTo(expSquare));
            Assert.That(answer.cube, Is.EqualTo(expCube));
            Assert.That(answer.root, Is.EqualTo(expRoot));
        }

        /*Come back and implement tests for negative inputs*/
        
    }
}