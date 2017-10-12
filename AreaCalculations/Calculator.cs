using System;

namespace AreaCalculations
{
    public class Calculator
    {
        public Calculator()
        {
        }

        internal double GetTotalArea(Triangle triangle)
        {
            throw new NotImplementedException();
        }
    }

    public class Triangle
    {
        private double triangleBase;
        private double triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
        }
    }
}