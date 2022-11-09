using Dgii.Challenge.Backend.Lib.Models;
using Dgii.Challenge.Backend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Backend.Lib.Services;
public class TaxPayerServices : ITaxPayerServices
{
    private readonly TaxPayer[] taxPayers;
    public TaxPayerServices() {
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
        return taxPayers;
    }
}
