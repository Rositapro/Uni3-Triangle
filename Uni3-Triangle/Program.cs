using Uni3_Triangle;
class Program
{
    static void Main(string[] args)
    {
        // Create a triangle using the empty constructor and then set the dimensions
        Triangle triangle1 = new Triangle();
        triangle1.SetDimensions(20, 10, 12, 14, 16);

        // Create a triangle using the constructor that takes parameters
        Triangle triangle2 = new Triangle(10, 5, 6, 7, 8);

        // Method that only returns but doesn't receive anything
        double area1 = Triangle.CalculateArea(10, 5);
        Console.WriteLine("Area of the triangle: " + area1);

        // Overload that doesn't receive parameters
        double area2 = triangle1.CalculateArea();
        Console.WriteLine("Area of the triangle: " + area2);

        // Method that receives and returns
        double perimeter = triangle2.CalculatePerimeter(6, 7, 8);
        Console.WriteLine("Perimeter of the triangle: " + perimeter);

        // Method that doesn't return nor receive
        triangle1.ShowInformation();
        triangle2.ShowInformation();
        triangle1 = null;
        GC.Collect();

        Console.ReadLine();
    }
}
