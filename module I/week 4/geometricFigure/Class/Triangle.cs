using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometricFigure.Interface;

namespace geometricFigure.Class
{
    public class Triangle : IGeometricFigure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return (Base * Height) / 2;
        }
        public double Perimeter()
        {
            return ASide + BSide + CSide;
        }
    }
}
