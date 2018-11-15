using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public interface IContactRepository
    {
        List<ContactModel> GetList();
        void Insert(ContactModel model);
    }
}
