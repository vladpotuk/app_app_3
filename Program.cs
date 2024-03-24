namespace EventCSharp
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D otherPoint)
        {
            double deltaX = X - otherPoint.X;
            double deltaY = Y - otherPoint.Y;
            double deltaZ = Z - otherPoint.Z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points = new Point3D[]
            {
            new Point3D(1, 2, 3),
            new Point3D(-2, 0, 4),
            new Point3D(5, -1, 2),
            new Point3D(3, 4, -2)
            };

            double maxDistance = double.MinValue;
            Point3D maxDistancePoint1 = null;
            Point3D maxDistancePoint2 = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        maxDistancePoint1 = points[i];
                        maxDistancePoint2 = points[j];
                    }
                }
            }

            Console.WriteLine($"Точка 1: ({maxDistancePoint1.X}, {maxDistancePoint1.Y}, {maxDistancePoint1.Z})");
            Console.WriteLine($"Точка 2: ({maxDistancePoint2.X}, {maxDistancePoint2.Y}, {maxDistancePoint2.Z})");
            Console.WriteLine($"Максимальна відстань між точками: {maxDistance}");
        }
    }
}