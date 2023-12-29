using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _24._9
{
    internal class Vector
    {
        public float Modulo { get; set; }
        public float x1 { get; set; }
        public float y1 { get; set; }

        public Vector(float X1, float Y1)
        {
            x1 = X1;
            y1 = Y1;
        }

        public void Somma(float x2, float y2, out float xr, out float yr)
        {
            xr = x1 + x2;
            yr = y1 + y2;
        }

        public static Vector Parse(float x3, float y3)
        {
            
        }
    }
}
