namespace Beacon.API.Events
{
    public interface IMinecraftEventBus
    {
        public ValueTask FireEventAsync<TEvent>(TEvent e, CancellationToken cToken = default) where TEvent : MinecraftEvent;
    }
}
