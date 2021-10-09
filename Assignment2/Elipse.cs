using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Elipse
    {
        private const double _DefaultMajorRadius = 0;
        private const double _DefaultMinorRadius = 0;
        private double _minorRadius;
        private double _majorRadius;

        public Elipse()
        {
            _majorRadius = _DefaultMajorRadius;
            _minorRadius = _DefaultMinorRadius;
        }

        public Elipse(double  minRadius, double majRadius)
        {
            _minorRadius = minRadius;
            _majorRadius = majRadius;

        }

        public Elipse(Elipse previous)
        {
            _minorRadius = previous._minorRadius;
            _majorRadius = previous._majorRadius;
        }
        public double perimeter()
        {
            //estimation: p = 2pi*sqrt((a^2 + b^2)/2)

            return (2 *Math.PI) * Math.Sqrt((Math.Pow(_majorRadius, 2)+Math.Pow(_minorRadius, 2)) / 2);
        }

        public double area()
        {
            return Math.PI * _minorRadius * _majorRadius;
        }

    }
}