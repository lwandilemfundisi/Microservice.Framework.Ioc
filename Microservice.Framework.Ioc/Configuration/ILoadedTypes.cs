using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Ioc
{
    public interface ILoadedTypes
    {
        IReadOnlyCollection<Type> TypesLoaded { get; }
    }
}
