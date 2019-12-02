using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApplication1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(5, Is.EqualTo(5));
        }

        [Test]
        public void Test2()
        {
            Assert.That(5, Is.EqualTo(5));
        }
    }
}
