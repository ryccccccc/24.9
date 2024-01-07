using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace _24._9
{
    internal class Vector
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector()
        {
            x = new float();
            y = new float();
        }

        public Vector Somma(Vector v2)
        {
            Vector vr = new Vector();
            vr.x = x + v2.x;
            vr.y = y + v2.x;
            return vr;
        }

        public static Vector Parse(string txt)
        {
            var parts = txt.Split(';');
            Vector vp = new Vector();
            vp.x = float.Parse(parts[0]);
            vp.y = float.Parse(parts[1]);
            return vp;
        }
    }
}
