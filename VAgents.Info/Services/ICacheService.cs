namespace VAgents.Info.Services
{
    using System;

    public interface ICacheService
    {
        T Get<T>(string cacheId, Func<T> getItemCalback) where T : class;

        void Clear(string cacheId);
    }
}