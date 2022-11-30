using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    public class Rectangulo
    {
        // punto A
        public double x1 { get; set; }
        public double y1 { get; set; }
        // punto B
        public double x2 { get; set; }
        public double y2 { get; set; }
        // punto C
        public double x3 { get; set; }
        public double y3 { get; set; }
        // punto D
        public double x4 { get; set; }
        public double y4 { get; set; }

        public double Area()
        {
            double side1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double side2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

            return side1 * side2;
        }
    }
}
