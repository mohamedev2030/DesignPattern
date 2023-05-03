using System;

namespace SolidOpenClosedPrincipalWithinterfaceConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var areaCalculator1 = new OCPAreaCalculator();
            areaCalculator1.AddShape(new OCPCircle(5d));
            Console.WriteLine("The total area of the shapes is " +
            areaCalculator1.Area);

            var areaCalculator2 = new OCPAreaCalculator();
            areaCalculator2.AddShape(new OCPSquare(50));
            Console.WriteLine("The total area of the shapes2 is " +
            areaCalculator2.Area);


        }
    }
}
