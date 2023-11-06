using System;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            double x = 0.5;
            double eps = 0.0001;
            int n = 0;
            double s = 0;
            double expected = Math.Log((1 + x) / (1 - x));

            // Act
            double actual = Program.S(x, eps, ref n, s);
        }
    }
}