﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOpenClosedPrincipalWithinterfaceConcept
{
        public class OCPSquare : IShapeWithArea
        {
            public double Area { get; }
            public OCPSquare(double lengthOfSide)
            {
                Area =
            lengthOfSide * lengthOfSide;
            }
        }
}
