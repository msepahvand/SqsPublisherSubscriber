using Newtonsoft.Json;
using System.IO;

namespace SqsPublisherSubscriber.Common
{
    public class SqsConfigHelper
    {
        public static SqsConfig GetConfig()
        {
            using (StreamReader r = new StreamReader("sqs-config.json"))
            {
                string json = r.ReadToEnd();
                var config = JsonConvert.DeserializeObject<SqsConfig>(json);
                return config;
            }
        }
    }
}
