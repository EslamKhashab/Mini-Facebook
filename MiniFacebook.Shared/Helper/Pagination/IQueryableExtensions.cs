using System;
using System.Linq;
using System.Linq.Expressions;

namespace MiniFacebook.Shared.Helper
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, SortType sortType, Expression<Func<T, object>> columnsMap = null)
        {
            if (columnsMap == null)
                return query;

            if (sortType == SortType.Ascending)
                return query.OrderBy(columnsMap);
            else
                return query.OrderByDescending(columnsMap);
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, PaginationObject paginationObject)
        {
            if (paginationObject.PageNumber <= 0)
                paginationObject.PageNumber = 1;

            if (paginationObject.PageSize <= 0)
                paginationObject.PageSize = 10;

            return query.Skip(paginationObject.PageSize * (paginationObject.PageNumber - 1)).Take(paginationObject.PageSize);
        }
    }
}
