using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enjaz_StackOverFlow
{
    public class Global
    {
        public delegate void DelLogMessage(string data);
        public static DelLogMessage LogMessage;
    }
}
