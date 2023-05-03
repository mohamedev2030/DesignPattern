using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidOpenClosedPrincipalWithinterfaceConcept
{
    public class OCPCircle : IShapeWithArea
    {
        public double Area { get; }
        public OCPCircle(double radius)
        {
            Area = Math.PI * (radius * radius);
        }
    }

}
