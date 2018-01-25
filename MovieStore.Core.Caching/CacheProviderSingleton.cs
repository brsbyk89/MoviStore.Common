using MovieStore.Core.Caching.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Caching
{
    public class CacheProviderSingleton
    {
        private static ICacheProvider instance;

        private CacheProviderSingleton() { }

        public static ICacheProvider GetProvider()
        {
            if (instance == null)
            {
                instance = CacheProviderFactory.Create();
            }

            return instance;
        }

    }
}
