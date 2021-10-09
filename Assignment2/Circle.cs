using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Circle
    {
        double _radius = 0;
        const double _DefaultRadius = 0;


        public Circle()//default 
        {
            _radius = _DefaultRadius;
        }

        public Circle(double radius)//assigned
        {
            _radius = radius;
        }

        public Circle(Circle previous)
        {
            _radius = previous._radius;
        }
        public double circumference()
        {
            return 2 * Math.PI * _radius;
        }

        public double area()
        {
            return Math.Pow(Math.PI * _radius, 2);
        }

    }
}
