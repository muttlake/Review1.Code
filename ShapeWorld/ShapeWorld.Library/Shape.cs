

namespace ShapeWorld.Library
{
    abstract public class Shape
    {
        public int Edges { get; }
        abstract public double Area();
        abstract public double Perimeter();

        public Shape()
        {
            Edges = 0;
        }

        public Shape(int n)
        {
            Edges = n;
        }

    }
}