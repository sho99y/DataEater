using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEater
{
    class ColorSet
    {
        public ColorSet(int Red, int Blue, int Green)
        {
            Id = countColor + 1;
            R = Red;
            B = Blue;
            G = Green;
            countColor++;
        }

        public static int countColor = -1;
        public int Id { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }
}
