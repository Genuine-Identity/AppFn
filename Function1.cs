using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AppFn
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> log)
        {
            _logger = log;
        }

        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("topic1", "subs1", Connection = "ConnectionStrings")] string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
            Console.WriteLine($"C# ServiceBus topic trigger function processed message: {mySbMsg}");

        }
    }
}
