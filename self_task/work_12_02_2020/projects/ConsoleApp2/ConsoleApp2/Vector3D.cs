using System;

namespace ConsoleApp2
{
    class Vector3D
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D VectorProduct(Vector3D other)
        {
            return new Vector3D(Y * other.Z - Z * other.Y,
                                Z * other.X - X * other.Z,
                                X * other.Y - Y * other.X);
        }

        public double GetLengt()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double ScalarProduct(Vector3D Vector)
        {
            return (X * Vector.X + Y * Vector.Y + Z * Vector.Z);
        }

        public override string ToString()
        {
            return $"Vector (X: {X}, Y: {Y}, Z: {Z})";
        }
    }
}
