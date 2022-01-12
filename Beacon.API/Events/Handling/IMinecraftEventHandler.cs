namespace Beacon.API.Events.Handling
{
    public interface IMinecraftEventHandler<TEvent> where TEvent : MinecraftEvent 
    {
        public Priority Priority { get; }
        public ValueTask HandleAsync(TEvent e, CancellationToken cancelToken);
    }
}
