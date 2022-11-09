using System.Text.Json.Serialization;

namespace Dgii.Challenge.Frontend.Lib.Models;
public partial class Voucher
{
    [JsonPropertyName("rncCedula")]
    public string Rnc { get; set; } = String.Empty;
    [JsonPropertyName("eNCF")]
    public string Encf { get; set; } = String.Empty;
    [JsonPropertyName("monto")]
    public double Amount { get; set; }
    [JsonPropertyName("itbis18")]
    public double Itbis18 { get; set; }
}
