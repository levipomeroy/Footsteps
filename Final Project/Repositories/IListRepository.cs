using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public interface IListRepository
    {
        List<UserListModel> GetUserLists(string UserID);
        List<UserListItem> GetUserListItems(int ListID, string UserID);
        void AddList(string Name, string UserID);
    }
}
