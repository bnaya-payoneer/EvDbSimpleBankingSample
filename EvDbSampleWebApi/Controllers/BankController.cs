using EvDb.Core;
using EvDbSample.Absractions;
using EvDbSample.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace EvDbSampleWebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class BankController : ControllerBase
{

    private readonly ILogger<BankController> _logger;
    private readonly IEvDbBankStreamFactory _factory;

    public BankController(ILogger<BankController> logger,
                    IEvDbBankStreamFactory factory)
    {
        _logger = logger;
        this._factory = factory;
    }

    [HttpGet]
    public IActionResult Get()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<Balance> PostAsync(WithdrewRequest request)
    {
        var stream = await _factory.GetAsync(request.User);
        //stream.Tx();
        //using var tx = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        try
        {
            Withdrew withdrew = new(Guid.NewGuid(), request.Volume, request.User);
            await stream.AddAsync(withdrew);
            //await stream.AddAsync(new CommissionTaken(Guid.NewGuid(), withdrew.User, 2));
            await stream.StoreAsync();
            var result = stream.Views.MyBalance;

            // Make you own Tx
            return result;
        }
        catch (OCCException ex)
        {
            throw; // TODO: Handle concurrency
        }
    }
}
