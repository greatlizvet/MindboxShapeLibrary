using System;
using Xunit;
using MindboxShapeLibrary;

namespace LibraryTests
{
    public class CircleTest
    {
        [Fact]
        public void CircleConstrcutFail()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void CircleConstructSuccess()
        {
            Assert.NotNull(new Circle(2));            
        }

        [Fact]
        public void CircleCalcArea()
        {
            Circle circle = new Circle(2);

            Assert.Equal(Math.PI * 4, circle.CalcArea());
        }

        [Fact]
        public void ObjectType()
        {
            IShape shape = new Circle(1);

            Assert.Equal(typeof(Circle), shape.GetType());            
        }

        [Fact]
        public void CircleCalcPerimetr()
        {
            Circle circe = new Circle(2);

            Assert.Equal(Math.PI * 2 * 2, circe.CalcPerimetr());
        }
    }
}
