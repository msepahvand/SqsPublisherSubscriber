using SqsPublisherSubscriber.Common;
using System;

namespace SqsPublisherSubscriber.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var _client = SqsClientFactory.GetClient();

            try
            {
                var response = _client.SendMessage(SqsConfigHelper.Config.QueueUrl,
                    $"Hello {DateTime.Now}");

                Console.WriteLine(response.HttpStatusCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
