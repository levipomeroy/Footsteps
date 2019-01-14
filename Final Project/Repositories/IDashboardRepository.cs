using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public interface IDashboardRepository
    {
        int GetNumberOfCountriesVisited(string UserID);
        List<string> GetUserWithMostPinsLeaderboard();

        List<string> GetDatesOfTrips(string UserID);
        List<string> GetUsersWithMostCountries();
        List<string> GetUsersWithMostLocationsThisMonth();

        List<KeyValuePair<string, int>> GetCategoryCount(string UserID);
    }
}
