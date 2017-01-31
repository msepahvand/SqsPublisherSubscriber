using Amazon.SQS.Model;
using SqsPublisherSubscriber.Common;
using System;

namespace SqsPublisherSubscriber.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            var _client = SqsClientFactory.GetClient();

            try
            {
                var request = new ReceiveMessageRequest(SqsConfigHelper.Config.QueueUrl) { MaxNumberOfMessages = 10};
                var response = _client.ReceiveMessage(request);
                response.Messages.ForEach(x=>Console.WriteLine(x.Body));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
