using System;

namespace Task_1
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double CalculateArea()
        {
            return side1 * side2;
        }

        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area => CalculateArea();

        public double Perimeter => CalculatePerimeter();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть довжину першої сторони прямокутника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть довжину другої сторони прямокутника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        }
    }
}
