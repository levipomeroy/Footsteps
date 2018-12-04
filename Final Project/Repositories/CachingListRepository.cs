using Final_Project.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public class CachingListRepository : ListRepository
    {
        private IMemoryCache _MemCache;
        private readonly string ListPrefix = "ListCache_";

        public CachingListRepository(IOptions<Settings> settings, IMemoryCache cache) : base(settings)
        {
            _MemCache = cache;
        }

        override public List<UserListModel> GetUserLists(string UserID)
        {
            List<UserListModel> n = (List<UserListModel>)_MemCache.Get(ListPrefix + UserID);
            if (n != null) return n;
            else
            {
                List <UserListModel> m = base.GetUserLists(UserID);
                _MemCache.Set(ListPrefix + UserID, m);
                return m;
            }
        }

        override public void AddList(string Name, string UserID)
        {
            base.AddList(Name, UserID);
            _MemCache.Remove(ListPrefix + UserID);
        }

    }
}
