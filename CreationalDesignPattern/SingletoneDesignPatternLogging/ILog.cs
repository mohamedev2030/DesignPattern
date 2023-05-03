using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPatternLogging
{
    public interface ILog
    {
         string LogException(string message);
    }
}
