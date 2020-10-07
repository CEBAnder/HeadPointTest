using HeadPointTest.Task2;
using NUnit.Framework;
using System;

namespace HeadPoint.Test
{
    public class Task2Test
    {
        [Test]
        public void Circle_NegativeRadius_ThrowException()
        {
            Assert.Throws<IncorrectParamException>(() => new Circle(-1));
        }

        [Test]
        public void Circle_PositiveRadius_GetArea()
        {
            var setupCircle = new Circle(1);
            var expected = Math.PI;
            var result = setupCircle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Triangle_NegativeSide_ThrowException()
        {
            Assert.Throws<IncorrectParamException>(() => new Triangle(-1, 2, 2));
        }

        [Test]
        public void Triangle_RightTriangle_GetArea()
        {
            var setupTriangle = new Triangle(3, 4, 5);
            var expected = 6;
            var result = setupTriangle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Triangle_CasualTriangle_GetArea()
        {
            var setupTriangle = new Triangle(4, 13, 15);
            var expected = 24;
            var result = setupTriangle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
