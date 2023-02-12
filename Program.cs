using tetofo.EventBus.Mock;
using tetofo.Stem;
using tetofo.Stem.Impl;

namespace tetofo;

public static class Program
{
    public static void Main(string[] args)
    {
        using IStem stem = new EventPayloadLoggerStem();
        stem.Event(new MockEvent());
    }
}
