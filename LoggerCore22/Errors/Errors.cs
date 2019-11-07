using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLoggerCore22.Errors
{
    public class Errors : IErrors
    {
        private readonly ILogger _logger;

        public Errors(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger<Errors>();
        }

        public void Add(string error)
        {
            _logger.LogError(error);
        }
    }
}
