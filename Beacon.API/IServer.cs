using Beacon.API.Events;
using Beacon.API.Models;
using Microsoft.Extensions.Logging;

namespace Beacon.API
{
    public interface IServer
    {
        public Version Version { get; }
        public ILogger<IServer> Logger { get; }
        public IMinecraftEventBus EventBus { get; }

        public Task StartAsync(CancellationToken cancelToken);
        public ValueTask ReloadAsync();
        public ValueTask<ServerStatus> GetStatusAsync();
    }
}
