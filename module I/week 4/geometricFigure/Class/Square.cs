using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometricFigure.Interface;

namespace geometricFigure.Class
{
    public class Square : IGeometricFigure
    {
        public double Side { get; set; }
        public double Area()
        {
            return Side * Side;
        }
        public double Perimeter()
        {
            return Side * 4;
        }
    }
}
