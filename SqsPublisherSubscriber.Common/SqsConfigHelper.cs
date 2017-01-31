using Newtonsoft.Json;
using System.IO;

namespace SqsPublisherSubscriber.Common
{
    public static class SqsConfigHelper
    {
        private static SqsConfig _config;
        public static SqsConfig Config
        {
            get
            {
                return _config ?? GetConfig();
            }
        }

        private static SqsConfig GetConfig()
        {
            using (StreamReader r = new StreamReader("sqs-config.json"))
            {
                string json = r.ReadToEnd();
                _config = JsonConvert.DeserializeObject<SqsConfig>(json);
                return _config;
            }
        }
    }
}
