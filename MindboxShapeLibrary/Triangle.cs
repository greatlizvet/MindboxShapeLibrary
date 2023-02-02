using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxShapeLibrary
{
    public class Triangle : IShape
    {
        private double segmentA;
        private double segmentB;
        private double segmentC;

        public double SegmentA
        {
            get
            {
                return segmentA;
            }
            set
            {
                if (value > 0)
                    segmentA = value;
            }
        }
        public double SegmentB
        {
            get
            {
                return segmentB;
            }
            set
            {
                if (value > 0)
                    segmentB = value;
            }
        }
        public double SegmentC
        {
            get
            {
                return segmentC;
            }
            set
            {
                if (value > 0)
                    segmentC = value;
            }
        }

        public Triangle(double segmentA, double segmentB, double segmentC)
        {
            if (segmentA + segmentB <= segmentC || segmentB + segmentC <= segmentA || segmentC + segmentA <= segmentB)
                throw new ArgumentException("Невозможно создать треугольник с такими сторонами.");

            SegmentA = segmentA;
            SegmentB = segmentB;
            SegmentC = segmentC;
        }

        public double CalcArea()
        {
            double perimetr = CalcPerimetr() / 2;

            return Math.Sqrt(perimetr * (perimetr - SegmentA) * (perimetr - SegmentB) * (perimetr - SegmentC));
        }

        public double CalcPerimetr()
        {
            return (SegmentA + SegmentB + SegmentC);
        }

        public bool IsRightTriangle()
        {
            if
            (
                segmentA * segmentA == (segmentB * segmentB + segmentC * segmentC) ||
                segmentB * segmentB == (segmentA * segmentA + segmentB * segmentB) ||
                segmentC * segmentC == (segmentA * segmentA + segmentB * segmentB)
            )
                return true;

            return false;
        }
    }
}
