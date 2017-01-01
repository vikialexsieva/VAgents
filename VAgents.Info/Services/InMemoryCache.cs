namespace VAgents.Info.Services
{
    using System;
    using System.Web;

    public class InMemoryCache : ICacheService
    {
        public void Clear(string cacheId)
        {
            HttpRuntime.Cache.Remove(cacheId);
        }

        public T Get<T>(string cacheId, Func<T> getItemCalback) where T : class
        {
            T item = HttpRuntime.Cache.Get(cacheId) as T;
            if (item == null)
            {
                item = getItemCalback();
                HttpContext.Current.Cache.Insert(cacheId, item);
            }

            return item;
        }
    }
}