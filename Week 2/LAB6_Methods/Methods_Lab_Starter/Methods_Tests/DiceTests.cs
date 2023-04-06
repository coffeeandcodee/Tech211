using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]

        public void RollDice_ReturnsCorrectValue()
        {
            //NO CONTROL FLOW IN TESTS
            //In this case, we test the method by setting up sequence 
            //of steps similar to method
            Random rand = new Random(1);
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int expected = roll1 + roll2;

            var result = Methods.RollDice(new Random());

            Assert.That(Methods.RollDice(rand), Is.EqualTo(result));

        }

        [TestCase(1)]
        [TestCase(-2414355)]
        public void RollDice_ReturnsWithinRange(int seed)
        {

            Random rand = new Random(seed);


            Assert.That(Methods.RollDice(rand), Is.GreaterThanOrEqualTo(1));
            Assert.That(Methods.RollDice(rand), Is.LessThanOrEqualTo(12));
            Assert.That(Methods.RollDice(rand), Is.InRange(1, 12));
         
        }
    }
}
