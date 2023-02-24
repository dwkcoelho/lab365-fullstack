using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometricFigure.Interface;

namespace geometricFigure.Class
{
    public class Circle : IGeometricFigure
    {
        public double Radius { get; set; }
        public double Area()
        {
            return (Radius * Radius) * 3.14;
        }
        public double Perimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
