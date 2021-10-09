using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Pentagon
    {
        double _sidelength = 0;
        const double _defaultSideLength = 0;

        public Pentagon()
        {
            _sidelength = _defaultSideLength;
        }

        public Pentagon(double sidelength)
        {
            _sidelength = sidelength;
        }

        public Pentagon(Pentagon previous)
        {
            _sidelength = previous._sidelength;
        }

        public double perimeter()
        {
            return _sidelength * 5;
        }

        public double area()
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(_sidelength, 2);
        }
    }
}
