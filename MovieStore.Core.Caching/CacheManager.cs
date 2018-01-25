using MovieStore.Core.Caching.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Caching
{
    public static class CacheManager
    {
        static ICacheProvider _cacheProvider;

        static CacheManager()
        {
            _cacheProvider = CacheProviderSingleton.GetProvider();
        }

        public static object Get(string key)
        {
            return _cacheProvider.Get<object>(key);
        }

        public static void Set(string key,object value)
        {
             _cacheProvider.Set<object>(key,value);
        }

    }
}
