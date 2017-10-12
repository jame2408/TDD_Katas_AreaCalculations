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
            return (triangle.TriangleBase * triangle.TriangleHeight) / 2;
        }
    }

    public class Triangle
    {
        public Triangle(double triangleBase, double triangleHeight)
        {
            this.TriangleBase = triangleBase;
            this.TriangleHeight = triangleHeight;
        }

        public double TriangleBase { get; }

        public double TriangleHeight { get; }
    }
}