using Dgii.Challenge.Frontend.Lib.Models;

namespace Dgii.Challenge.Frontend.Lib.Services.Interfaces;
public interface ITaxPayerServices
{
    IEnumerable<TaxPayer> Get();
}
