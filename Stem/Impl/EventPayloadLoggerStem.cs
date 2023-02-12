using Microsoft.Extensions.DependencyInjection;
using tetofo.EventBus;
using tetofo.EventBus.Impl;
using tetofo.Service.Logger;
using tetofo.Service.Logger.Impl;

namespace tetofo.Stem.Impl;

public class EventPayloadLoggerStem : BaseStem
{
    protected override void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IEventPayloadLoggerService, EventPayloadLoggerService>();
        serviceCollection.AddSingleton<ICallback, EventPayloadLoggerCallback>();
    }
}