using System;

namespace Task_2
{
    class Point
    {
        private double x, y;
        private string name;

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public double X => x;
        public double Y => y;
        public string Name => name;
    }

    class Figure
    {
        private Point[] points;

        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
                throw new ArgumentException("Багатокутник повинен мати від 3 до 5 вершин.");
            this.points = points;
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                perimeter += GetSideLength(points[i], points[(i + 1) % points.Length]);
            }
            return perimeter;
        }

        public string Name => $"Багатокутник з {points.Length} вершинами";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");

            Figure triangle = new Figure(A, B, C);

            Console.WriteLine($"Назва: {triangle.Name}");
            Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()}");
            Console.ReadLine();
        }
    }
}
