using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(1, 3)]
        [TestCase(2, 8)]
        [TestCase(3, 7)]

        public void RollDice_ReturnsCorrectValue(int seed, int expectedSum)
        {

            Random rand = new Random(seed);
            //int roll1 = rand.Next(1, 7);
            //int roll2 = rand.Next(1, 7);
            //int expectedSum = roll1 + roll2;
            Assert.That(Methods.RollDice(rand), Is.EqualTo(expectedSum));

        }

        [TestCase(1)]
        [TestCase(-2414355)]
        public void RollDice_ReturnsWithinRange(int seed)
        {

            Random rand = new Random(seed);


            Assert.That(Methods.RollDice(rand), Is.GreaterThanOrEqualTo(1));
            Assert.That(Methods.RollDice(rand), Is.LessThanOrEqualTo(12)); 

         
        }
    }
}
