using System;

namespace AreaCalculations
{
    interface IShape
    {
        double area();
    }

    public class Calculator
    {
        public Calculator()
        {
        }

        internal double GetTotalArea(IShape shape)
        {
            return shape.area();
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

        public double area()
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

        public double area()
        {
            return Side * Side;
        }
    }

    public class Rectangle : IShape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double area()
        {
            return height * width;
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return Math.Round((radius * radius * Math.PI), 2);
        }
    }
}