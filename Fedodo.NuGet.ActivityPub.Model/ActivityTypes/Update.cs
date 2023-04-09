using System.Text.Json.Serialization;
using Fedodo.NuGet.ActivityPub.Model.CoreTypes;
using Object = Fedodo.NuGet.ActivityPub.Model.CoreTypes.Object;

namespace Fedodo.NuGet.ActivityPub.Model.ActivityTypes;

/// <summary>
///     Indicates that the actor has updated the object. Note, however, that this vocabulary does not define a mechanism
///     for describing the actual set of modifications made to object.
///     The target and origin typically have no defined meaning.
/// </summary>
public class Update<T> : Activity<T> where T : Object
{
    [JsonPropertyName("type")] public new string Type { get; set; } = "Update";
}