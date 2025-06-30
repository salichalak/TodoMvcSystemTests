using Microsoft.Extensions.Configuration;

namespace TodoMvcSystemTests.Config
{
    public static class ConfigManager
    {
        private static readonly IConfigurationRoot _config;

        static ConfigManager()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static string BaseUrl => _config["TestSettings:BaseUrl"];
    }
}
