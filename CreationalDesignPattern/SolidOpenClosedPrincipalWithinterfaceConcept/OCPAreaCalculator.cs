using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOpenClosedPrincipalWithinterfaceConcept
{
    public class OCPAreaCalculator
    {
        private double _area { get; set; }
        public double Area { get { return _area; } }
        public void AddShape(IShapeWithArea shape)
        {
            _area += shape.Area;
        }
    }
}
