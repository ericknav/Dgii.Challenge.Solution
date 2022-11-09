using Microsoft.AspNetCore.Mvc;
using Dgii.Challenge.Backend.Lib.Models;
using Dgii.Challenge.Backend.Lib.Services;
using Dgii.Challenge.Backend.Lib.Services.Interfaces;

namespace Dgii.Challenge.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TaxPayerController : ControllerBase
{
    private ITaxPayerServices taxPayerService;
    private readonly ILogger<TaxPayerController> _logger;

    public TaxPayerController(ILogger<TaxPayerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<TaxPayer> Get()
    {
        IEnumerable<TaxPayer> taxPayers = new TaxPayer[]{};
        try
        {
            taxPayerService = new TaxPayerServices();
            taxPayers = taxPayerService.Get();
        }
        catch(Exception ex)
        {
            _logger.LogError("TaxPayerController.Get",ex);
        }
        return taxPayers;
    }
}