using Amazon.SQS;
using SqsPublisherSubscriber.Common;
using System;

namespace SqsPublisherSubscriber.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {

            var config = SqsConfigHelper.GetConfig();

            var queueUrl = $"https://sqs.{config.RegionDisplayName}.amazonaws.com/{config.AccountNumber}/{config.QueueName}";
            var _client = new AmazonSQSClient(
                    awsAccessKeyId: config.AccessKeyId,
                    awsSecretAccessKey: config.SecretAccessKey,
                    region: Amazon.RegionEndpoint.GetBySystemName(config.RegionDisplayName));

            try
            {
                var response = _client.SendMessage(queueUrl, $"Hello {DateTime.Now}");
            }
            catch (Exception ex)
            {
                
            }
            
        }
    }
}
