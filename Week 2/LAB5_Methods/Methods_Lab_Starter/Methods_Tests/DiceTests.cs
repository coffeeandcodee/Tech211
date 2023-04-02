using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(7)]

        public void RollDice_ReturnsCorrectValue(int seed)
        {
            var rand = new Random(seed);
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int expectedSum = roll1 + roll2;
            Assert.That(Methods.RollDice(rand), Is.EqualTo(expectedSum));

        }
    }
}
