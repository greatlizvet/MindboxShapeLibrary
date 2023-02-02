using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxShapeLibrary
{
    public class Circle : IShape
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                    this.IsWrongRadius();

                radius = value;
            }
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                this.IsWrongRadius();

            Radius = radius;
        }

        public double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalcPerimetr()
        {            
            return 2 * Math.PI * Radius;
        }

        private void IsWrongRadius()
        {
            throw new ArgumentException("Радиус должен быть больше нуля"); 
        }
    }
}
