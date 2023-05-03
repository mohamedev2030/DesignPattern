using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidInterfaceSegreation
{
    internal interface IPrinter
    {
        //create the interfaces::
        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
        }
        public interface IFaxTasks
        {
            void Fax(string content);
        }
        public interface IPrintDuplexTasks
        {
            void PrintDuplex(string content);
        }
    }
}
