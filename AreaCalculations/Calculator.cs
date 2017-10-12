using System;

namespace AreaCalculations
{
    interface IShape
    {
        double area();
    }

    public class Calculator
    {
        internal double GetTotalArea(params IShape[] shapes)
        {
            var sum = 0d;
            foreach (var shape in shapes)
            {
                var area = shape.area();
                sum += area;
            }

            return Math.Round(sum, 2);
        }
    }

    public class Triangle : IShape
    {
        private double TriangleBase { get; }
        private double TriangleHeight { get; }

        public Triangle(double triangleBase, double triangleHeight)
        {
            this.TriangleBase = triangleBase;
            this.TriangleHeight = triangleHeight;
        }

        public double area()
        {
            return (TriangleBase * TriangleHeight) / 2;
        }
    }

    public class Square : IShape
    {
        private double Side { get; }

        public Square(double side)
        {
            this.Side = side;
        }

        public double area()
        {
            return Side * Side;
        }
    }

    public class Rectangle : IShape
    {
        private double Height { get; }
        private double Width { get; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double area()
        {
            return Height * Width;
        }
    }

    public class Circle : IShape
    {
        private double Radius { get;}

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double area()
        {
            return Math.Round((Radius * Radius * Math.PI), 2);
        }
    }
}