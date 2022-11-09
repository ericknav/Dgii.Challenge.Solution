using System.Text.Json.Serialization;

namespace Dgii.Challenge.Backend.Lib.Models;
public partial class Voucher
{
    [JsonPropertyName("rncCedula")]
    public string Rnc { get; set; } = String.Empty;
    [JsonPropertyName("eNCF")]
    public string Encf { get; set; } = String.Empty;
    [JsonPropertyName("monto")]
    public string Amount { get; set; } = String.Empty;
    [JsonPropertyName("itbis18")]
    public string Itbis18 { get; set; } = String.Empty;
}
