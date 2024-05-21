using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundServiceConsole
{
    public class TestBackground : IHostedService, IHostedLifecycleService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
