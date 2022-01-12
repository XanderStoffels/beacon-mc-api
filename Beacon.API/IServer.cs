using Beacon.API.Events;
using Beacon.API.Models;

namespace Beacon.API
{
    public interface IServer
    {
        public IMinecraftEventBus EventBus { get; }
        Task StartAsync(CancellationToken cancelToken);
        ValueTask ReloadAsync();
        ValueTask<ServerStatus> GetStatusAsync();
        //test
    }
}
