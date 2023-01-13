using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureQueueFunction
{
    public class ProcessMessage
    {
        [FunctionName("ProcessMessage")]
        public void Run([QueueTrigger("anishqueue", Connection = "anishconnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
