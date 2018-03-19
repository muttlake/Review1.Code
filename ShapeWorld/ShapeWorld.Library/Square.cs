

namespace ShapeWorld.Library
{
    public class Square: Shape
    {
        public int Side { get; set; }
        public Square(): base(4) 
        { 
            Side = 0;
        }

        public Square(int s): base(4)
        {
            Side = s;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}