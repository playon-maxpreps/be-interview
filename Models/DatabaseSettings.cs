namespace DotNetInterviewApi.Models
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string MaxRetryCount { get; set; } = "3"; // Should be int
        public int CommandTimeout { get; set; } = 30;
    }

    public class FeatureFlags
    {
        public bool EnableCaching { get; set; } = true;
        public bool EnableLogging { get; set; } = true;
        public string CacheTimeout { get; set; } = "300"; // Should be int
    }
} 