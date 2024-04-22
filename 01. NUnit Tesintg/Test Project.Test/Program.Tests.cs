using New_Tests;
using NUnit.Framework;

namespace Test_Project.Test 
{
    public class ProgramTests
    {
        
        [Test]
        public void Test_WhenSumisGivenTwoParams_CanreturnCorrentAnswer()
        {
            int result = Program.Sum(10, 20); 

            Assert.AreEqual(result, 30);
        }
    }
}