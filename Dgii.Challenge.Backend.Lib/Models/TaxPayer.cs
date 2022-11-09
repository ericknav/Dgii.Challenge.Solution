using System.Text.Json.Serialization;

namespace Dgii.Challenge.Backend.Lib.Models;
public partial class TaxPayer
{
    [JsonPropertyName("rncCedula")]
    public string Rnc { get; set; } = String.Empty;
    [JsonPropertyName("nombre")]
    public string Name { get; set; } = String.Empty;
    [JsonPropertyName("tipo")]
    public string Type { get; set; } = String.Empty;
    [JsonPropertyName("estatus")]
    public string State { get; set; } = String.Empty;
}
