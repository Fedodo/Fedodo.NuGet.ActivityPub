using System.Text.Json.Serialization;

namespace Fedodo.NuGet.ActivityPub.Model;

public class PagedCollection
{
    [JsonPropertyName("@context")] public string Context { get; set; } = "https://www.w3.org/ns/activitystreams";
    [JsonPropertyName("id")] public Uri Id { get; set; }
    [JsonPropertyName("type")] public string Type { get; set; } = "Collection";
    [JsonPropertyName("totalItems")] public long TotalItems { get; set; }
    [JsonPropertyName("first")] public Uri First { get; set; }
    [JsonPropertyName("last")] public Uri Last { get; set; }
}