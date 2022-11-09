using Dgii.Challenge.Frontend.Lib.Models;

namespace Dgii.Challenge.Frontend.Lib.Services.Interfaces;
public interface IVoucherServices
{
    IEnumerable<Voucher> Get();
    IEnumerable<Voucher> Get(string rnc);
}
