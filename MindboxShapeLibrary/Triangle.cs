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
                if (value <= 0)
                    this.IsWrongSegment();

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
                if (value <= 0)
                    this.IsWrongSegment();
                
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
                if (value <= 0)
                    this.IsWrongSegment();
                
                segmentC = value;
            }
        }

        public Triangle(double segmentA, double segmentB, double segmentC)
        {
            if 
            (
                segmentA + segmentB <= segmentC || 
                segmentB + segmentC <= segmentA || 
                segmentC + segmentA <= segmentB
            )
                this.IsWrongSegment();

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
                Math.Pow(segmentA, 2) == (Math.Pow(segmentB, 2) + Math.Pow(segmentC, 2)) ||
                Math.Pow(segmentB, 2) == (Math.Pow(segmentA, 2) + Math.Pow(segmentC, 2)) ||
                Math.Pow(segmentC, 2) == (Math.Pow(segmentA, 2) + Math.Pow(segmentB, 2))
            )
                return true;

            return false;
        }

        private void IsWrongSegment()
        {
            throw new ArgumentException("Сторона должна быть больше нуля");
        }
    }
}
