using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class ArraySamples
    {
        void Sample1()
        {
            int[] mySet = new int[5];

            mySet[0] = 1;
            mySet[1] = 2;
            mySet[2] = 3;
            mySet[3] = 4;
            mySet[4] = 5;
        }

        void Sample2()
        {
            int[,] mySet = new int[3, 2];

            mySet[0, 0] = 1;
            mySet[0, 1] = 2;
            mySet[1, 0] = 3;
            mySet[1, 1] = 4;
            mySet[2, 0] = 5;
            mySet[2, 1] = 6;
        }
    }
}
