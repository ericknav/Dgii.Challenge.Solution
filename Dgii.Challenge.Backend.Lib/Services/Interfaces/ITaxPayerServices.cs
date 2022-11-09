using Dgii.Challenge.Backend.Lib.Models;

namespace Dgii.Challenge.Backend.Lib.Services.Interfaces;
public interface ITaxPayerServices
{
    IEnumerable<TaxPayer> Get();
}
