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

        public Errors(ILogger<Errors> logger)
        {
            _logger = logger;
        }

        public void Add(string error)
        {
            _logger.LogError(error);
        }
    }
}
