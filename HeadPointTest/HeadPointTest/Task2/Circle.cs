using System;

namespace HeadPointTest.Task2
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double initRadius)
        {
            _radius = validateValue(initRadius, nameof(initRadius));
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
