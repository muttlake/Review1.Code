

namespace ShapeWorld.Library
{
    interface IShape
    {
        int Edges { get; }
        double Area();
        double Perimeter();
    }
}