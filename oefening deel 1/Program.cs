using System;

namespace oefening_deel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // player leraar = new player("first");

            double height, width, area, perimiter;
            height = GetSize("Height");
            width = GetSize("Width");

            area = ComputeArea(height, width);
            perimiter = ComputePerimeter(height, width);
            DisplayResults(height, width, area, perimiter);
            Console.ReadKey();

        }
        public static double GetSize(string WichOne)
        {
            string inValue;
            double side;
            Console.Write("Enter the {0}: ", WichOne);
            inValue = Console.ReadLine();
            side = double.Parse(inValue);
            return side;
        }
        public static double ComputeArea(double height, double width)
        {
            return height * width;
        }
        public static double ComputePerimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }
        public static void DisplayResults(double height, double width, double area, double perimeter)
        {
            Console.Clear();
            Console.WriteLine("Summary of Rectangle Measurments\n");
            Console.WriteLine("{0, -15} {1,5:f1}", "Height; ", height);
            Console.WriteLine("{0, -15} {1,5:f1}", "Width; ", width);
            Console.WriteLine("{0, -15} {1,5:f1}", "Area; ", area);
            Console.WriteLine("{0, -15} {1,5:f1}", "Perimeter; ", perimeter);
        }
    }
}