using LAB2_Exceptions;

namespace Tests
{
    public class Tests
    {
       
       

        [Test]
        public void AverageMethod_IfEmptyList_ThrowsException()
        {
            var list = new List<int> { };

            Assert.That(() => Program.Average(list), Throws.TypeOf<ArgumentNullException>());
  
        }
    }
}