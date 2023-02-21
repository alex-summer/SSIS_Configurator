public class RootObject
{
    public DatabaseConfig DatabaseConfig { get; set; }
    public IntegrationConfig[] IntegrationConfig { get; set; }
}

public class DatabaseConfig
{
    public string Authorization { get; set; }
    public string Name { get; set; }
}

public class IntegrationConfig
{
    public string Name { get; set; }
    public string Authorization { get; set; }
    public string Host { get; set; }
    public string Transfer { get; set; }
}

