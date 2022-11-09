using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dgii.Challenge.Frontend.Lib.Services;
using Dgii.Challenge.Frontend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Frontend.Web.Controllers;

public class TaxPayerController : Controller
{
    private readonly ITaxPayerServices taxPayerServices;
    private readonly IVoucherServices voucherServices;
    private readonly ILogger<TaxPayerController> _logger;

    public TaxPayerController(ILogger<TaxPayerController> logger)
    {
        _logger = logger;
        taxPayerServices = new TaxPayerServices();
        voucherServices = new VoucherServices();
    }

    public IActionResult Index()
    {
        return View(taxPayerServices.Get());
    }

    [Route("TaxPayer/Vouchers/{rnc}")]
    public IActionResult Vouchers(string rnc = "")
    {
        if (string.IsNullOrWhiteSpace(rnc))
        {
            return NotFound();
        }
        return View(voucherServices.Get(rnc.Trim()));
    }
}
