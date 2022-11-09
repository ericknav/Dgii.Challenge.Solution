using RestSharp;
using Dgii.Challenge.Frontend.Lib.Models;
using Dgii.Challenge.Frontend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Frontend.Lib.Services;
public class TaxPayerServices : ITaxPayerServices
{
    private readonly RestClient _client;
    private readonly TaxPayer[] taxPayers;
    public TaxPayerServices() {
        _client = new RestClient("https://localhost:7299/");
        taxPayers = new TaxPayer[]
        {
            new TaxPayer{
                Rnc = "98754321012",
                Name = "JUAN PEREZ",
                Type = "PERSONA FISICA",
                State = "activo",
            },
            new TaxPayer{
                Rnc = "123456789",
                Name = "FARMACIA TU SALUD",
                Type = "PERSONA JURIDICA",
                State = "inactivo",
            },
        };
    }

    public IEnumerable<TaxPayer> Get()
    {
        /*
        var request = new RestRequest("TaxPlayer", Method.Get);
        var response = await _client.ExecuteGetAsync<IEnumerable<TaxPayer>>(request);
        if (!response.IsSuccessful)
        {
        //Logic for handling unsuccessful response
        }
        */
        //return response.Data;
        return taxPayers;
    }
}
