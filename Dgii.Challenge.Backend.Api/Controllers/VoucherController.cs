using Microsoft.AspNetCore.Mvc;
using Dgii.Challenge.Backend.Lib.Models;
using Dgii.Challenge.Backend.Lib.Services;
using Dgii.Challenge.Backend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VoucherController : ControllerBase
{
    private IVoucherServices voucherService;
    private readonly ILogger<VoucherController> _logger;

    public VoucherController(ILogger<VoucherController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Voucher> Get()
    {
        IEnumerable<Voucher> vouchers = new Voucher[]{};
        try
        {
            voucherService = new VoucherServices();
            vouchers = voucherService.Get();
        }
        catch(Exception ex)
        {
            _logger.LogError("VoucherController.Get",ex);
        }
        return vouchers;
    }

    [HttpGet("{rnc}")]
    public IEnumerable<Voucher> Get(string rnc)
    {
        IEnumerable<Voucher> vouchers = new Voucher[]{};
        try
        {
            voucherService = new VoucherServices();
            vouchers = voucherService.Get(rnc);
        }
        catch(Exception ex)
        {
            _logger.LogError($"VoucherController.Get({rnc})",ex);
        }
        return vouchers;
    }
}