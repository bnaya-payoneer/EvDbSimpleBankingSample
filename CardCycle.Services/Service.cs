using Microsoft.Extensions.Logging;
using Cards.Repositories.Factories;
using Cards.Common;
using CardCycle.Common.Events;

namespace CardCycle.Services;

public class Service(
                ILogger<Service> _logger,
                IEvDbCardFactory _cardFactory)
                // ICardCycleEvents cardCycleEvents)
{
    public async Task PostAsync(Request request)
    {
        var stream = await _cardFactory.GetAsync(request.DebitCardId);
        var e = new CardCanceledEvent(request.DebitCardId);
        await stream.AddAsync(e);
        await stream.StoreAsync();
    }
}
