using System;
using System.Collections.Generic;

namespace HeadPointTest.Task2
{
    public class Triangle : Shape
    {
        public List<double> sides = new List<double>();

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            sides.Add(validateValue(firstSide, nameof(firstSide)));
            sides.Add(validateValue(secondSide, nameof(secondSide)));
            sides.Add(validateValue(thirdSide, nameof(thirdSide)));
        }

        public override double GetArea()
        {
            var s = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));            
        }
    }
}
