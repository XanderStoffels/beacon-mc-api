using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beacon.API.Events.Handling
{
    public abstract class MinecraftEventHandler<TEvent> : IMinecraftEventHandler<TEvent>
        where TEvent : MinecraftEvent
    {
        public virtual Priority Priority => Priority.NORMAL;
        public abstract ValueTask HandleAsync(TEvent e, CancellationToken cancelToken);
    }
}
