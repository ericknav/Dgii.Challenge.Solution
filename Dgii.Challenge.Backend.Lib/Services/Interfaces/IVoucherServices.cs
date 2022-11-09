using Dgii.Challenge.Backend.Lib.Models;

namespace Dgii.Challenge.Backend.Lib.Services.Interfaces;
public interface IVoucherServices
{
    IEnumerable<Voucher> Get();
    IEnumerable<Voucher> Get(string rnc);
}
