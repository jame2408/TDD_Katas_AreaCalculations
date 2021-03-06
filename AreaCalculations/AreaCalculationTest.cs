﻿using NUnit.Framework;

namespace AreaCalculations
{
    [TestFixture]
    public class AreaCalculationTest
    {
        private readonly Calculator _sut = new Calculator();

        [Test]
        public void Area_Of_A_Triangle_Is_Half_Of_Its_Base_Multiplied_By_Height()
        {
            const double triangleBase = 6;
            const double triangleHeight = 4;

            var triangle = new Triangle(triangleBase, triangleHeight);

            Assert.AreEqual(12, _sut.GetTotalArea(triangle));
        }

        [Test]
        public void Area_Of_A_Square_Is_Square_Of_Side()
        {
            const double side = 6;

            var square = new Square(side);

            Assert.AreEqual(36, _sut.GetTotalArea(square));
        }

        [Test]
        public void Area_Of_A_Rectangle_Is_Width_Multiplied_By_Height()
        {
            const double height = 4;
            const double width = 8;

            var rectangle = new Rectangle(height, width);

            Assert.AreEqual(32, _sut.GetTotalArea(rectangle));
        }

        [Test]
        public void Area_Of_A_Circle_Is_Square_Of_Radius_Mulitplied_By_Pi()
        {
            const double radius = 3;

            var circle = new Circle(radius);

            Assert.AreEqual(28.27, _sut.GetTotalArea(circle));
        }

        [Test]
        public void Total_Area_Is_Sum_Of_Areas_Of_Different_Shapes()
        {
            Assert.AreEqual(49.14, _sut.GetTotalArea(new Rectangle(4, 2), new Rectangle(3, 4), new Circle(1), new Square(1), new Triangle(10, 5)));
        }

        [Test]
        public void Total_Area_Is_Rounded_To_2_Decimals()
        {
            Assert.AreEqual(4.45, _sut.GetTotalArea(new Rectangle(1.112, 2), new Rectangle(1.111, 2)));
        }

        [Test]
        public void Total_Area_Is_0_When_There_Are_No_Shapes()
        {
            Assert.AreEqual(0, _sut.GetTotalArea());
        }
    }
}
