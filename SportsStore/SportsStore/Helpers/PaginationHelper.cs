using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Helpers
{
    public static class PaginationHelper
    {
        public static IQueryable<T> Paginate<T>(IQueryable<T> sortedItems, int pageNum, int pageSize)
        {
            var skippedList = sortedItems.Skip((pageNum - 1) * pageSize);

            var neededPortion = skippedList.Take(pageSize);

            return neededPortion;
        }

    }
}
