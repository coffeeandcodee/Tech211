using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedNUnit;
namespace AdvancedNUnitTests
{
    //NUnit runs test methods in ALPHABETICAL ORDER
    //These tests are dependent on each other
    public class CounterTests
    {
        
        Counter _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Counter(6);
        }

        //As opposed to 
        // Counter _sut = new Counter(6);
        //Tests would be dependent 



        [Test]
        [Category("Counter Tests")]
        public void Increment_IncreaseCountByOne()
        {
            //arrange
            int result = 7;

            //act
            _sut.Increment();


            Assert.That(_sut.Count, Is.EqualTo(result));


        }

        [Test]
        [Category("Counter Tests")]
        public void Decrement_DecrementCountByOne()
        {

            //arrange
            int result = 5;

            //act
            _sut.Decrement();

            //Assert
            Assert.That(_sut.Count, Is.EqualTo(result));

        }



    }
}
