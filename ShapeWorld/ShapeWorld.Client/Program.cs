using System;
using System.Collections.Generic;
using System.Linq;
using ShapeWorld.Library;

namespace ShapeWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayWithShapes();
            PlayWithCollections();
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

        static void PlayWithCollections()
        {
            Shape[] array = new Shape[10];
            var a1 = new Shape[] {new Rectangle(), new Square(), new Rectangle()};
            var i1 = a1[1];
            a1[0] = i1;

            //multi-dimensional arrays
            Shape[,] a2 = new Shape[10,10];
            var a3 = new Shape[,] {{new Square(), new Rectangle()},
                                    {new Rectangle(), new Square()}};

            var i2 = a3[0,1];
            a2[2,3] = i2;

            // Jagged arrays are arrays of arrays
            Shape[][] a4 = new Shape[2][]; // the two secondary arrays can have different sizes
            var a5 = new Shape[][] {new Rectangle[2], new Square[4]
                                    {new Square() as Square, new Square(), new Square() as Square, new Square()}};

            //Lists
            List<Shape> l1 = new List<Shape>();
            l1.Add(new Square());
            var l2 = new List<Shape>() {new Square(), new Rectangle()};

            //Dictionary
            Dictionary<string, List<Shape>> d1 = new Dictionary<string, List<Shape>>();
            d1["apple"] = new List<Shape>() {new Square(), new Rectangle()};

            var d2 = new Dictionary<char, List<Shape>>(){
                {'a', new List<Shape>()},
                {'b', new List<Shape>()},
                {'c', new List<Shape>(){new Square(), new Rectangle()}}
            };

            var i3 = d2['c'][0];
            var i4 = d2.Keys.ElementAt(1); // Gets list of keys
            Console.WriteLine(i4);






        }
    }
}
