using System.Text.Json.Serialization;
using Fedodo.NuGet.ActivityPub.Model.CoreTypes;
using Object = Fedodo.NuGet.ActivityPub.Model.CoreTypes.Object;

namespace Fedodo.NuGet.ActivityPub.Model.ActivityTypes;

/// <summary>
///     Indicates that the actor has joined the object. The target and origin typically have no defined meaning.
/// </summary>
public class Join<T> : Activity<T> where T : Object
{
    [JsonPropertyName("type")] public new string Type { get; set; } = "Join";
}