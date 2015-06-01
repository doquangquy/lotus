using System.Collections.Generic;
using System;
using System.Linq;
using SharedCache.WinServiceCommon.Provider.Cache;
using CACHE = SharedCache.WinServiceCommon.Provider.Cache.IndexusDistributionCache;

namespace UTILS
{
    public static class SharedCached
    {
        public static void Add(string key, object obj)
        {
            CACHE.SharedCache.Add(key, obj);
        }

        public static void AddDemo(string key, object obj)
        {
            CACHE.SharedCache.DataContractAdd(key, obj);
        }

        public static void Add(string key, object obj, int timeout)
        {
            CACHE.SharedCache.Add(key, obj, DateTime.Now.AddMinutes(timeout));
        }

        public static void Remove(string key)
        {
            CACHE.SharedCache.Remove(key);
        }

        public static object Get(string key)
        {
            return CACHE.SharedCache.Get(key);
        }
        public static object GetDemo(string key)
        {
            return CACHE.SharedCache.DataContractGet(key);
        }

        public static void FlushAll()
        {
            CACHE.SharedCache.Clear();
        }

        public static void RemoveContainsKey(string keycontains)
        {

            foreach (var server in new IndexusSharedCacheProvider().ServersList)
            {
                var listKey = CACHE.SharedCache.GetAllKeys(server.IpAddress);
                var listKeyRemove = listKey.Where(c => c.Contains(keycontains));
                foreach (var skey in listKeyRemove)
                {
                    CACHE.SharedCache.Remove(skey);
                }
            }
        }

        public static void MultilDelete(List<string> lkey)
        {
            CACHE.SharedCache.MultiDelete(lkey);
        }

    }
}
