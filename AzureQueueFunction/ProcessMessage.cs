using System;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureQueueFunction
{
    public class ProcessMessage
    {
        [FunctionName("ProcessMessage")]
        public void Run([QueueTrigger("anishqueue", Connection = "anishconnection")]Order order, ILogger log)
        {
            log.LogInformation("Order Id {0}", order.OrderID);
            log.LogInformation("Quantity {0}", order.Quantity);
        }
    }
}
