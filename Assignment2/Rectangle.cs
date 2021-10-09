using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Rectangle
    {
        public Rectangle()
        {
            _side1 = _DefaultSide1;
            _side2 = _DefaultSide1;
        }

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public Rectangle(Rectangle previous)
        {
            _side1 = previous._side1;
            _side2 = previous._side2;
        }

        public double Parameter()
        {
            return (_side1 * 2) + (_side2 * 2);
        }

        public double Area()
        {
            return _side1 * _side2;
        }

        const double _DefaultSide1 = 0;
        const double _DefaultSide2 = 0;
        double _side1 = 0;
        double _side2 = 0;
    }
}
