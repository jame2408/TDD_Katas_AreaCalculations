using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculations
{
    [TestFixture]
    public class AreaCalculationTest
    {
        private Calculator sut = new Calculator();

        [Test]
        public void Area_Of_A_Triangle_Is_Half_Of_Its_Base_Multiplied_By_Height()
        {
            const double triangleBase = 6;
            const double triangleHeight = 4;

            var triangle = new Triangle(triangleBase, triangleHeight);

            Assert.AreEqual(12, sut.GetTotalArea(triangle));
        }

        [Test]
        public void AreaOfASquareIsSquareOfSide()
        {
            const double side = 6;

            var square = new Square(side);

            Assert.AreEqual(36, sut.GetTotalArea(square));
        }
    }

}
