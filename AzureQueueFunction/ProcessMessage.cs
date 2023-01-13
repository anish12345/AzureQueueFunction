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
        [return: Table("Orders", Connection = "anishconnection")]
        public TableOrder Run([QueueTrigger("anishqueue", Connection = "anishconnection")]Order order, ILogger log)
        {
            TableOrder tableOrder = new TableOrder()
            {
                PartitionKey = order.OrderID,
                RowKey = order.Quantity.ToString()
            };

            log.LogInformation("Order written to table");
            return tableOrder;
        }
    }
}
