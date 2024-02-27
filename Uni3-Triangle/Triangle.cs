using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Uni3_Triangle
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public string Type { get; private set; }
        public double Area { get; private set; }
        public bool IsEquilateral { get; private set; }
        public bool IsIsosceles { get; private set; }
        public bool IsScalene { get; private set; }

        // Constructor that doesn't receive parameters
        public Triangle()
        {
            // Default values can be set if desired
        }

        // Constructor that receives parameters to initialize the triangle
        public Triangle(double baseTriangle, double heightTriangle, double side1, double side2, double side3)
        {
            Base = baseTriangle;
            Height = heightTriangle;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CalculateProperties();
        }

        // Method to calculate additional properties of the triangle
        private void CalculateProperties()
        {
            Area = (Base * Height) / 2;

            IsEquilateral = Side1 == Side2 && Side2 == Side3;
            IsIsosceles = Side1 == Side2 || Side1 == Side3 || Side2 == Side3;
            IsScalene = !IsEquilateral && !IsIsosceles;

            if (IsEquilateral)
                Type = "Equilateral";
            else if (IsIsosceles)
                Type = "Isosceles";
            else
                Type = "Scalene";
        }

        // Destructor
        ~Triangle()
        {
            Console.WriteLine("Triangle object destroyed.");
        }

        // Method that only returns but doesn't receive anything
        public static double CalculateArea(double baseTriangle, double heightTriangle)
        {
            double area = (baseTriangle * heightTriangle) / 2;
            return area;
        }

        // Overload that doesn't receive parameters
        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }

        // Method that only receives
        public void SetDimensions(double baseTriangle, double heightTriangle, double side1, double side2, double side3)
        {
            Base = baseTriangle;
            Height = heightTriangle;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CalculateProperties();
        }

        // Method that receives and returns
        public double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        // Method that doesn't return nor receive
        public void ShowInformation(double baseTriangle, double heightTriangle, double side1, double side2, double side3)
        {
            Console.WriteLine("Triangle information:");
            Console.WriteLine("Base: " + baseTriangle);
            Console.WriteLine("Height: " + heightTriangle);
            Console.WriteLine("Side 1: " + side1);
            Console.WriteLine("Side 2: " + side2);
            Console.WriteLine("Side 3: " + side3);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Is equilateral: " + IsEquilateral);
            Console.WriteLine("Is isosceles: " + IsIsosceles);
            Console.WriteLine("Is scalene: " + IsScalene);
        }

        // Overload that doesn't receive parameters
        public void ShowInformation()
        {
            Console.WriteLine("Triangle information:");
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Side 1: " + Side1);
            Console.WriteLine("Side 2: " + Side2);
            Console.WriteLine("Side 3: " + Side3);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Is equilateral: " + IsEquilateral);
            Console.WriteLine("Is isosceles: " + IsIsosceles);
            Console.WriteLine("Is scalene: " + IsScalene);
        }
    }

}

