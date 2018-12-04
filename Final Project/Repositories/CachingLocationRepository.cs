using Final_Project.BusinessObjects;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public class CachingLocationRepository : LocationRepository
    {
        private IMemoryCache _MemCache;
        private readonly string LocationPrefix = "LocationCache_";

        public CachingLocationRepository(IOptions<Settings> settings, IMemoryCache cache) : base(settings)
        {
            _MemCache = cache;
        }

        override public int GetNumberOfLocationsForUser(string UserId)
        {
            object n = _MemCache.Get(LocationPrefix + UserId);
            if (n != null) return (int)n;
            else
            {
                int num = base.GetNumberOfLocationsForUser(UserId);
                _MemCache.Set(LocationPrefix + UserId, num);
                return num;
            }
        }

        override public void Insert(LocationModel location)
        {
            base.Insert(location);
            _MemCache.Remove(LocationPrefix + location.UserID);
        }


        override public List<LocationObject> GetList(string UserID)
        {
            return base.GetList(UserID);
        }
    }
}
