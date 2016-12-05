using System;
using NUnit.Framework;

namespace EthanYoung.WordSplitter.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void InAllCases_GetTrue_ReturnsTrue()
        {
            Assert.True(Program.GetTrue());
        }
    }
}