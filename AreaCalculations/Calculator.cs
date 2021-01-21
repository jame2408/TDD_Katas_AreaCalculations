using System;
using System.Linq;

namespace AreaCalculations
{
    public interface IShape
    {
        double Area();
    }

    public class Calculator
    {
        public double GetTotalArea(params IShape[] shapes)
        {
            var sum = shapes.Sum(shape => shape.Area());

            return Math.Round(sum, 2);
        }
    }

    public class Triangle : IShape
    {
        public Triangle(double triangleBase, double triangleHeight)
        {
            this.TriangleBase = triangleBase;
            this.TriangleHeight = triangleHeight;
        }

        private double TriangleBase { get; }
        private double TriangleHeight { get; }

        public double Area()
        {
            return (TriangleBase * TriangleHeight) / 2;
        }
    }

    public class Square : IShape
    {
        public Square(double side)
        {
            this.Side = side;
        }

        private double Side { get; }

        public double Area()
        {
            return Side * Side;
        }
    }

    public class Rectangle : IShape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        private double Height { get; }
        private double Width { get; }

        public double Area()
        {
            return Height * Width;
        }
    }

    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius { get; }

        public double Area()
        {
            return Math.Round((Radius * Radius * Math.PI), 2);
        }
    }
}