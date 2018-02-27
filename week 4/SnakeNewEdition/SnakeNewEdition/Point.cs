using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNewEdition
{
    [Serializable]

    public class Point
    {
        public int x;
        public int y;

        public Point()
        {

        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
