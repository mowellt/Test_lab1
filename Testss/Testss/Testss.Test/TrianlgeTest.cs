using NUnit.Framework;
using System;

namespace Testss.Test
{
    [TestFixture]
    public class TriangleTests
    {

        [Test]
        public void Created()
        {
            Assert.NotNull(new Triangle(5, 6, 4));
        }

        [Test]
        public void CorrectSidesShouldBeSet()
        {
            Triangle triangle = new Triangle(4, 5, 6);

            Assert.AreEqual(4, triangle.A);
            Assert.AreEqual(5, triangle.B);
            Assert.AreEqual(6, triangle.C);
        }

        [Test]
        public void CorrectSidesShouldBeSet2()
        {
            Triangle triangle = new Triangle();

            triangle.SetSides(3, 4,5);

            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(5, triangle.C);
        }

        [Test]
        [TestCase(-10, 6, 7)]
        [TestCase(3, -10, 1)]
        [TestCase(4, 5, -10)]
        public void NegativeThrows(double a, double b, double c)
        {
            Triangle triangle = new Triangle();

            Assert.Throws<FormatException>(() => triangle.SetSides(a, b, c));
        }
        [Test]
        [TestCase(100, 1, 5)]
        [TestCase(5, 100, 1)]
        [TestCase(1, 5, 100)]
        public void IncorrectThrows(double a, double b, double c)
        {
            Triangle triangle = new Triangle();

            Assert.Throws<ArgumentException>(() => triangle.SetSides(a, b, c));
        }
        [Test]
        [TestCase(-500, 1, 5)]
        [TestCase(5, -100, 1)]
        [TestCase(1, 5, -100)]
        public void NegativeCreatedParametersThrow(double a, double b, double c)
        {
            Assert.Throws<FormatException>(() => new Triangle(a, b, c));
        }

        [Test]
        [TestCase(100, 1, 5)]
        [TestCase(5, 100, 1)]
        [TestCase(1, 5, 100)]
        public void IncorrectCreatedParametersThrow(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}