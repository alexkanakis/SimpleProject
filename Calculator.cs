﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return (x + y);
        }

        public static double Subtract(double x, double y)
        {
            return (y - x);
        }

        public static double Multiply(double x, double y)
        {
            return (y * x);
        }

        public static double Divide(double x, double y)
        {
            return (y / x);
        }
    }
}