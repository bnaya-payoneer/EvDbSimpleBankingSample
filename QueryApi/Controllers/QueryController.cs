using EvDbSample.Absractions;
using EvDbSample.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace QueryApi.Controllers;
[ApiController]
[Route("[controller]")]
public class QueryController : ControllerBase
{
    private readonly ILogger<QueryController> _logger;
    private readonly IEvDbBankStreamFactory _factory;

    public QueryController(ILogger<QueryController> logger,
                        IEvDbBankStreamFactory factory)
    {
        _logger = logger;
        this._factory = factory;
    }

    [HttpGet]
    public async Task<Balance> GetAsync(string user)
    {
        var stream = await _factory.GetAsync(user);
        return stream.Views.MyBalance;
    }
}
