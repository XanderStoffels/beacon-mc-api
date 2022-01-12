using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beacon.API.Plugins
{
    public interface IBeaconPlugin
    {
        public string Name { get; }
        public Version Version { get; }
        public void ConfigureServices(IServiceCollection services);
        public ValueTask EnableAsync();
        public ValueTask DisableAsync();

    }
}
