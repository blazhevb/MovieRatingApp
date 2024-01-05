using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Mobile
{
    public static class AppLogger
    {
        private static ILogger _logger;

        public static void Initialize(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("AppLogger");
        }

        public static void LogError(Exception ex, string message)
        {
            _logger?.LogError(ex, message);
        }
    }
}
