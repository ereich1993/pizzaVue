using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using PizzaVueBackend.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaVueBackend
{
    public class LifetimeEventsHostedService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly IApplicationLifetime _appLifetime;
        private ITraceWriter traceWriter;

        public LifetimeEventsHostedService(ILogger<LifetimeEventsHostedService> logger,
            IApplicationLifetime appLifetime)
        {
            _logger = logger;
            _appLifetime = appLifetime;
        }
        


        public Task StartAsync(CancellationToken cancellationToken)
        {

            _appLifetime.ApplicationStarted.Register(OnStarted);
            _appLifetime.ApplicationStopping.Register(OnStopping);
            _appLifetime.ApplicationStopped.Register(OnStopped);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void OnStarted()
        {

            _logger.LogInformation("On started has been called");
            MailService.Initialize();

        }

        private void OnStopping()
        {
            _logger.LogInformation("On stoppin has been called");
        }

        private void OnStopped()
        {
            _logger.LogInformation("On stopped has been called");
        }
    }
}
