using Final_Project.BusinessObjects;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public interface ILocationRepository
    {
        List<LocationObject> GetList();
        void Insert(LocationModel location);
        void Delete(LocationObject location);
        void Edit(LocationObject location);
    }
}
