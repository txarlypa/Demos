using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLoggerCore22.Errors
{
    public static class StaticErrors
    {
        public static void Add(string error, ILogger logger)
        {
            logger.LogError(error);
        }
    }
}
