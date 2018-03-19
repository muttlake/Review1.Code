using System;
using ShapeWorld.Library;

namespace ShapeWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithShapes();
        }

        static void PlayWithShapes()
        {
            var r = new Rectangle(3, 6);
            var sq = new Square(9);

            Shape s1 = r;
            Shape s2 = sq;

            Console.WriteLine("r.Edges {0}", r.Edges);
            Console.WriteLine("s1.Edges {0}", s1.Edges);              
            Console.WriteLine("r.Area {0}",  r.Area());
            Console.WriteLine("s1.Area {0}", s1.Area());            
            
            Console.WriteLine("sq.Edges {0}", sq.Edges);
            Console.WriteLine("s2.Edges {0}", s2.Edges);            
            Console.WriteLine("sq.Area {0}", sq.Area());
            Console.WriteLine("s2.Area {0}", s2.Area());



            

        }
    }
}
