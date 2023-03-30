using NUnit.Framework;
using DataTypes_Lib;

namespace DataTypes_Test
{
//    1     | 1
//10    | 3_628_800 
//12    | 479_001_600
//13    | 6_227_020_800
//20    | 2_432_902_008_176_640_000
    public class MethodTests
    { 
        [TestCase(1, 1)]
        [TestCase(10, 3_628_800)]
        [TestCase(12, 479_001_600)]
        [TestCase(13, 6_227_020_800)]
        [TestCase(20, 2_432_902_008_176_640_000)]

        public void Factorial_Returns_CorrectInteger(int n, double expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }

        [Test]
        public void Mult_ReturnsCorrectProductOfFloats()
        {
            var result = Methods.Mult(2.1f, 3.0f);
            /*Initally, before "Within" modifier
            Expected: 6.30000019f
            But was:  6.29999971f
            (WHY?)
            */
            Assert.That(result, Is.EqualTo(6.30000f).Within(0.0005));           
        }
    }
}