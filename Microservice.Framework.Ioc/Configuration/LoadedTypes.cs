using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microservice.Framework.Ioc
{
    public class LoadedTypes : ILoadedTypes
    {
        public LoadedTypes(
            IEnumerable<Type> loadedTypes)
        {
            TypesLoaded = loadedTypes.ToList();
        }

        public IReadOnlyCollection<Type> TypesLoaded { get; }
    }
}
