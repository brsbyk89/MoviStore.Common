using System;
using MovieStore.Core.Caching.Contract;
using System.Runtime.Caching;

namespace MovieStore.Core.Caching
{
    public class HttpCacheProvider : ICacheProvider
    {
        public HttpCacheProvider()
        {

        }

        public void Set<T>(string key, T value)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            memoryCache.Add(key, value,null);
        }

        public void Set<T>(string key, T value, TimeSpan timeout)
        {

            MemoryCache memoryCache = MemoryCache.Default;
            memoryCache.Add(key, value, Convert.ToDateTime(timeout));
        }

        public T Get<T>(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            var result = memoryCache.Get(key);

            return (T)Convert.ChangeType(result, typeof(T));
        }

        public bool Remove(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(key))
            {
                memoryCache.Remove(key);
            }

            if (!IsInCache(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsInCache(string key)
        {
            bool isInCache = false;

            MemoryCache memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(key))
            {
                isInCache = true;
            }

            return isInCache;
        }
    }
}
