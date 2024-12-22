using EvDb.Core;
using EvDbSample.Absractions;
using EvDbSample.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EvDbSampleWebApi.Controllers
{
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
        public async Task<Balance> PostAsync(Withdrew withdrew)
        {
            try
            {
                var stream = await _factory.GetAsync(withdrew.User);
                await stream.AddAsync(withdrew);
                await stream.AddAsync(new CommissionTaken(Guid.NewGuid(), withdrew.User, 2));
                await stream.StoreAsync();
                var result = stream.Views.MyBalance;
                return result;
            }
            catch (OCCException ex)
            {
                throw; // TODO: Handle concurrency
            }
        }
    }
}
