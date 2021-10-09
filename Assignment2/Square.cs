using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Square
    {
        public Square()
        {
            _side = DefaultSide;
        }

        public Square(double side)
        {
            _side = side;
        }

        public Square(Square previous)
        {
            _side = previous._side;
        }

        public double perameter()
        {
            return _side * 4;
        }

        public double area()
        {
            return _side * _side;
        }

        private double _side;

        public const double DefaultSide = 0;
    }
}
