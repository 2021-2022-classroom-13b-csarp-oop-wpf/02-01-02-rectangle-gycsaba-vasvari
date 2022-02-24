using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    /// <summary>
    /// Téglalap osztály
    /// </summary>
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0)
                throw new RectangleSideIsNullOrZero("A téglalap oldala nem lehet nulla vagy negatív!");
            if (sideB <= 0)
                throw new RectangleSideIsNullOrZero("A téglalap oldala nem lehet nulla vagy negatív!");
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double Perimeter
        {
            get
            {
                return 2 * sideA + 2 * sideB;
            }
        }

        public double Area
        {
            get
            {
                return sideA * sideB;
            }
        }

        public double SideA
        { 
            get
            {
                return sideA;
            }
            set
            {
                if (value <= 0)
                    throw new RectangleSideIsNullOrZero("A téglalap oldala nem lehet nulla vagy negatív!");
                sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return sideB; 
            }
            set
            {
                if (value <= 0)
                    throw new RectangleSideIsNullOrZero("A téglalap oldala nem lehet nulla vagy negatív!");
                sideB = value;
                    
            }
        }

        public override string ToString()
        {
            double roundedPerimeter = Math.Round(Perimeter, 2);
            double roundedArea = Math.Round(Area, 2);
            string result = sideA + "x" + sideB + " oldalú négyzet kerülete " + roundedPerimeter + ", területe " + roundedArea + ".";
            return result;
        }

    }
}
