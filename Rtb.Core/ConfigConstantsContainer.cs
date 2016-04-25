using System.Collections.Specialized;
using System.Configuration;
using Rtb.Core.Interface;

namespace Rtb.Core
{
    public class ConfigConstantsContainer : IConstantsContainer
    {
        private readonly NameValueCollection _config;

        public ConfigConstantsContainer()
        {
            _config = ConfigurationManager.AppSettings;
        }

        public string ApplicationKey => _config["ApplicationKey"];

        public string RabbitHost => _config["RabbitHost"];

    }
}
