using System.Text.Json.Serialization;

namespace JSON_READER;

public class IntegrationConfig
{
    public enum AuthMethod
    {
        Password,
        Key
    }

    public enum TransferMethod
    {
        Ftps,
        Sftp
    }
    
    public string? Name { get; set; }
    public string? Host { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AuthMethod Authorization { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TransferMethod Transfer { get; set; }
}