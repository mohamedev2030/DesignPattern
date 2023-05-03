using System;

namespace CreationalFluentInterfaceDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();
            //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");
            //To See the Details call the ShowDetails Method
            obj.ShowDetails();
            Console.Read();
        }
    }
}
