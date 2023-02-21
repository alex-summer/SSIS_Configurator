using System.Text.Json.Serialization;

namespace JSON_READER;

public class DatabaseConfig
{
    public enum DbAuthMethod {
        Windows, 
        Password
    }
    
    public string? Name { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DbAuthMethod Authorization { get; set; }
}