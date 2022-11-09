using Dgii.Challenge.Frontend.Lib.Models;
using Dgii.Challenge.Frontend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Frontend.Lib.Services;
public class VoucherServices : IVoucherServices
{
    private readonly Voucher[] taxPayers;
    public VoucherServices() 
    {
        taxPayers = new Voucher[]
        {
            new Voucher{
                Rnc = "98754321012",
                Encf = "E310000000001",
                Amount = 200.00,
                Itbis18 = 36.00,
            },
            new Voucher{
                Rnc = "98754321012",
                Encf = "E310000000002",
                Amount = 1000.00,
                Itbis18 = 180.00,
            },
        };
    }

    public IEnumerable<Voucher> Get()
    {
        return taxPayers;
    }

    public IEnumerable<Voucher> Get(string rnc)
    {
        return Get().Where(x => x.Rnc == rnc).ToList();
    }
}
