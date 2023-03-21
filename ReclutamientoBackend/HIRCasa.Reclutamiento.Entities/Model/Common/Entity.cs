using System.Text.Json.Serialization;

namespace HIRCasa.Reclutamiento.Entities.Model.Common;
public abstract class Entity
{
    [JsonPropertyOrder(0)]
    public int Id { get; set; }
}
