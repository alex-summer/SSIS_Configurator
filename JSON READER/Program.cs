using JSON_READER;
using System.Text.Json;

string fileName = @"C:\Users\alexs\RiderProjects\JSON READER\JSON READER\test_config.json";
string jsonString = File.ReadAllText(fileName);
Data data = JsonSerializer.Deserialize<Data>(jsonString)!;
Console.Write(data);

foreach (var config in data.IntegrationConfig)
{
    Console.WriteLine(config.Name);
}
