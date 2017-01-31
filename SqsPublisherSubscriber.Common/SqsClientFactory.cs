using Amazon.SQS;

namespace SqsPublisherSubscriber.Common
{
    public class SqsClientFactory
    {
        public static AmazonSQSClient GetClient()
        {
            var config = SqsConfigHelper.Config;

            var client = new AmazonSQSClient(
                    awsAccessKeyId: config.AccessKeyId,
                    awsSecretAccessKey: config.SecretAccessKey,
                    region: Amazon.RegionEndpoint.GetBySystemName(config.RegionDisplayName));

            return client;
        }

    }
}
