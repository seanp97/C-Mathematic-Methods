using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public static class Trigonometry
    {

        public static double AreaOfRectangle(double l, double w)
        {
            return l * w;
        }

        public static double AreaOfParallelogram(double b, double h)
        {
            return b * h;
        }

        public static double AreaOfTriangle(double b, double h)
        {
            return b * h / 2;
        }

        public static double AreaOfSquare(double side)
        {
            return side * side;
        }

        public static double AreaOfTrapezoid(double a, double b, double h)
        {
            return (a + b) / 2 * h;
        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }

        public static double PerimOfSquare(double p)
        {
            return p * p;
        }

        public static double PerimOfCircle(double d)
        {
            return Math.PI * d;
        }

        public static double PerimOfRectangle(double w, double l)
        {
            return 2 * (l + w);
        }

        public static double PerimOfTriangle(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double SurfaceAreaOfRectangularPrism(double l, double w, double h)
        {
            return ((l * w) * 2) + ((l * h) * 2) + ((w * h) * 2);
        }

        public static double SurfaceAreaOfRightCylinder(double r, double h)
        {
            return ((Math.PI * r * h) * 2) + (Math.PI * r * r);
        }
        public static double SurfaceAreaOfSphere(double r)
        {
            return 4 * Math.PI * r * r;
        }

        public static double SurfaceAreaOfCube(double s)
        {
            return 6 * s * s;
        }
        public static double CircleCircumference(double r)
        {
            return r * 2 * Math.PI;
        }

        public static double PyTheorem(double a, double b)
        {
            return (a * a) + (b * b);
        }

        public static double VolOfPrism(double cross, double l)
        {
            return cross * l;
        }

        public static double VolOfCube(double s)
        {
            return 3 * s;
        }

        public static double VolOfSquarePyramid(double b, double h)
        {
            return (b * b) * h / 100 * 33.3333333333;
        }

        public static double VolOfCone(double r, double h)
        {
            return Math.PI * r * r * (h / 100 * 33.3333333333);
        }

        public static double VolOfSphere(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 3) / 3;
        }

        public static double VolOfRectangle(double l, double w, double h)
        {
            return l * w * h;
        }

        public static double TotalCost(double u, double c)
        {
            return u * c;
        }

        public static double PercentageOf(double value, double target)
        {
            return target / 100 * value;
        }

    }
}
