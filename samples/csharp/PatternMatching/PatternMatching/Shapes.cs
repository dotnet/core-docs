﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    #region 01_SquareDefinition
    public struct Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
    #endregion

    #region 03_CircleDefinition
    public struct Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    #endregion

    #region 08_RectangleAndTriangle
    public struct Rectangle
    {
        public double Length { get; }
        public double Height { get; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    public struct Triangle
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
    #endregion

}
