using Microservice.Framework.Common;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microservice.Framework.Ioc
{
    public interface IContainer
    {
        IServiceCollection ServiceCollection { get; }

        IContainer SetupResilientStrategyForOptimisticConcurrency(int numberOfRetries, TimeSpan waitBeforeTrying);

        IContainer SetupContainer(Action<ISetup> setup);
    }
}
