namespace SqsPublisherSubscriber.Common
{
    public class SqsConfig
    {
        public string QueueName { get; set; }
        public string AccountNumber { get; set; }
        public string AccessKeyId { get; set; }
        public string SecretAccessKey { get; set; }
        public string RegionDisplayName { get; set; }

        public string QueueUrl
        {
            get
            {
               return $"https://sqs.{RegionDisplayName}.amazonaws.com/{AccountNumber}/{QueueName}";
            }
        }
    }
}