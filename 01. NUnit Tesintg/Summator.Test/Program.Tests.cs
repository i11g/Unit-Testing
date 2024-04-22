using NUnit.Framework;

namespace Summator.Test
{
    public class SumaTests
    {
        
        [Test]
        public void Test_WithFourPositiveNumber()
        {   
            int result=Suma.Sum(new int[] {1, 2, 3, 4});

            Assert.AreEqual(10, result);
        }
    }
}