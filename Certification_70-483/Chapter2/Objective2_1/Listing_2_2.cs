using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter2.Objective2_1
{
    using Certification.Common;

    public class Listing_2_2 : IRunnable
    {
        public struct Point
        {
            public int x, y;
            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        public class Tree
        {
            public Point Leaf;
        }

        public void Run()
        {
            Point p = new Point(2, 1);
            p.x = 3;

            Tree t = new Tree();
            t.Leaf = new Point(1,2);
            t.Leaf.x = 3;

            Console.WriteLine(t.Leaf.x);
        }

        public void Func(Point l)
        {
            l.x = 3;
        }
    }
}
