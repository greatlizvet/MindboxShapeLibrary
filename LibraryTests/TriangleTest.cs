using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MindboxShapeLibrary;

namespace LibraryTests
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleConstructFail()
        {
            Assert.Throws<ArgumentException>(() =>  new Triangle(0, 0, 0));
            Assert.Throws<ArgumentException>(() =>  new Triangle(0, 1, 2));
            Assert.Throws<ArgumentException>(() =>  new Triangle(1, 0, 2));
            Assert.Throws<ArgumentException>(() =>  new Triangle(1, 2, 0));
            Assert.Throws<ArgumentException>(() =>  new Triangle(1, 0, 0));
            Assert.Throws<ArgumentException>(() =>  new Triangle(0, 1, 0));
            Assert.Throws<ArgumentException>(() =>  new Triangle(0, 0, 1));
            Assert.Throws<ArgumentException>(() =>  new Triangle(1, 2, 3));
        }

        [Fact]
        public void TriangleConstructSuccess()
        {
            Assert.NotNull(new Triangle(1, 1, 1));

            Assert.NotNull(new Triangle(3, 4, 5));
        }

        [Fact]
        public void TriangleCalcArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.Equal(6, triangle.CalcArea());
        }

        [Fact]
        public void TriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightTriangle());

            triangle = new Triangle(5, 3, 4);

            Assert.True(triangle.IsRightTriangle());

            triangle = new Triangle(4, 5, 3);

            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            Triangle triangle = new Triangle(1, 1, 1);

            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void TriangleCalcPerimetr()
        {
            Triangle triangle = new Triangle(1, 1, 1);

            Assert.Equal(3, triangle.CalcPerimetr());
        }

        [Fact]
        public void ObjectType()
        {
            IShape shape = new Triangle(1, 1, 1);

            Assert.Equal(typeof(Triangle), shape.GetType());
        }

        [Fact]
        public void TriagnleChangeSegment()
        {
            Triangle triangle = new Triangle(1, 1, 1);

            Assert.Throws<ArgumentException>(() => triangle.SegmentA = -1);
            Assert.Throws<ArgumentException>(() => triangle.SegmentB = -1);
            Assert.Throws<ArgumentException>(() => triangle.SegmentC = -1);
        }
    }
}
