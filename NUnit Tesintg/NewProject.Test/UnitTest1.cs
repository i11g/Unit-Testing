using New_Tests;
using NUnit.Framework;

namespace NewProject.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = Program.Sum(10, 20);

            Assert.Pass();
        }
    }
}